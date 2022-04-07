#include <comdef.h>
#include <atlbase.h>
#include <windows.h>
#include <process.h>
#include <stdarg.h>
#include <stdio.h>

////////////////////////////////////////////////////////////////////////////////

#import "..\..\include\AxEmail.tlb"

#include "..\..\include\AxEmailConstants.h"

////////////////////////////////////////////////////////////////////////////////

LPTSTR ReadInput( LPCTSTR lptszTitle, BOOL bAllowEmpty = FALSE );

////////////////////////////////////////////////////////////////////////////////



int main(void)
{
	LPTSTR			cp;
    _bstr_t			bstrHostName	= "";
	_bstr_t			bstrAccount		= "";
	_bstr_t			bstrPassword	= "";
	BOOL			bSecure			= FALSE;
	AxEmail::ISmtpPtr oSmtp = NULL;
	AxEmail::IMessagePtr oMessage = NULL;


    // initialize COM
	CoInitialize(NULL);

	oSmtp.CreateInstance(__uuidof(AxEmail::Smtp));
	if( oSmtp == NULL )
	{
		_tprintf( _T("Failed to create AxEmail:Smtp.\n") );		
		goto _EndMain;
	}

	oMessage.CreateInstance(__uuidof(AxEmail::Message));
	if( oMessage == NULL )
	{
		_tprintf( _T("Failed to create AxEmail:Message.\n") );		
		goto _EndMain;
	}

	// A license key is required to unlock this component after the trial period has expired.
	// Assign the LicenseKey property every time a new instance of this component is created (see code below). 
	// Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry.
	// For details, see manual, chapter "Product Activation".
	/*
	oSmtp->LicenseKey = _T("XXXXX-XXXXX-XXXXX");
	*/
  
  // Component info
	_tprintf( _T("Auron Email Component %s\nBuild: %s\nModule: %s\nLicense Status: %s\nLicense Key: %s\n\n"), ( LPCTSTR ) oSmtp->Version, ( LPCTSTR ) oSmtp->Build, ( LPCTSTR ) oSmtp->Module, ( LPCTSTR ) oSmtp->LicenseStatus, ( LPCTSTR ) oSmtp->LicenseKey );

  // Log File
  // oSmtp->LogFile = _T("C:\\Smtp.log"); 
	_tprintf( _T("Log File used: %s\n\n"), ( LPCTSTR ) oSmtp->LogFile );


    cp				= ReadInput( _T("SMTP Server") );
	bSecure			= _tcsicmp( cp, _T("smtp.gmail.com") ) == 0;
	bstrHostName	= cp;
	bstrAccount		= ReadInput( _T("SMTP server account (optional)"), TRUE );
	if( bstrAccount.length() > 0 ) 
		bstrPassword	= ReadInput( _T("SMTP server password"), TRUE );

	if( bSecure )
	{
		oSmtp->SetSecure( 465 );
		_tprintf( _T("SetSecure, result: %ld (%s)\n"), oSmtp->LastError, ( LPCTSTR ) oSmtp->GetErrorDescription( oSmtp->LastError ) ); 
	}

	_tprintf( _T("Connecting...\n") );
	oSmtp->Connect( bstrHostName, bstrAccount, bstrPassword );
	_tprintf( _T("Connect, result: %ld (%s)\n"), oSmtp->LastError, ( LPCTSTR ) oSmtp->GetErrorDescription( oSmtp->LastError ) ); 
	if( oSmtp->LastError != 0L )
		goto _EndMain;

	cp = ReadInput( _T("FROM address") );
	oMessage->FromAddress = cp;
	oMessage->FromName = cp ;

	oMessage->Subject = ReadInput( _T("Subject") );

	cp = ReadInput( _T("HTML formatted message body (y/n)") );
	if( cp[0] == 'y' || cp[0] == 'Y' )
		oMessage->BodyHtml = ReadInput( _T("Message (HTML formatted)") );
	else
		oMessage->BodyPlainText = ReadInput( _T("Message (Plain Text formatted)") );

	oMessage->Priority = AXEMAIL_MESSAGEPRIORITY_MEDIUM;	// Normal priority (default)
	oMessage->Encoding = AXEMAIL_MESSAGEENCODING_DEFAULT;	// Default Encoding
	
	cp = ReadInput( _T("TO address") );
	oMessage->AddTo( cp,  cp );
	_tprintf( _T("AddTo, result: %ld (%s)\n"), oMessage->LastError, ( LPCTSTR ) oMessage->GetErrorDescription( oMessage->LastError ) ); 

	cp = ReadInput( _T("CC address (optional)"), TRUE );
	if( _tcslen( cp ) > 0 )
	{
		oMessage->AddCc( cp,  cp );
		_tprintf( _T("AddCc, result: %ld (%s)\n"), oMessage->LastError, ( LPCTSTR ) oMessage->GetErrorDescription( oMessage->LastError ) ); 
	}

	cp = ReadInput( _T("BCC address (optional)"), TRUE );
	if( _tcslen( cp ) > 0 )
	{
		oMessage->AddBcc( cp,  cp );
		_tprintf( _T("AddBcc, result: %ld (%s)\n"), oMessage->LastError, ( LPCTSTR ) oMessage->GetErrorDescription( oMessage->LastError ) ); 
	}

	_tprintf( _T("Sending...\n") );
	oSmtp->Send( oMessage );
	_tprintf( _T("Send, result: %ld (%s)\n"), oSmtp->LastError, ( LPCTSTR ) oSmtp->GetErrorDescription( oSmtp->LastError ) ); 

	_tprintf( _T("Disconnecting...\n") );
	oSmtp->Disconnect();


_EndMain:

	if( oSmtp != NULL )
		oSmtp.Release();

	if( oMessage   != NULL )
		oMessage.Release();

	CoUninitialize();

	_tprintf( _T("Ready.\n") );

	return 0;
}

////////////////////////////////////////////////////////////////////////////////

LPTSTR ReadInput( LPCTSTR lptszTitle, BOOL bAllowEmpty )
{
	static TCHAR		tszInput [ 255 + 1 ] = { _T('\0') };

	_tprintf( _T("%s:\n"), lptszTitle );
	do
	{
		_tprintf ( _T("   > ") );
		// scanf ( "%s", tszInput );
		fflush(stdin); 
		fflush(stdout); 
		_fgetts( tszInput, 255, stdin );
		if( tszInput[ 0 ] != _T('\0') && tszInput[ _tcsclen( tszInput ) - 1  ] == _T('\n') )
			tszInput[ _tcsclen( tszInput ) - 1  ] = _T('\0');
	} while( _tcsclen ( tszInput ) == 0 && ! bAllowEmpty );

	return tszInput;
}


///////////////////////////////////////////////////////////////////////////////////////////

