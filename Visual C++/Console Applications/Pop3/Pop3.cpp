#include <comdef.h>
#include <atlbase.h>
#include <windows.h>
#include <stdio.h>

////////////////////////////////////////////////////////////////////////////////

#import "..\..\include\AxEmail.tlb"
#include "..\..\include\AxEmailConstants.h"

////////////////////////////////////////////////////////////////////////////////

LPTSTR ReadInput( LPCTSTR lptszTitle, BOOL bAllowEmpty = FALSE );

////////////////////////////////////////////////////////////////////////////////


int main(void)
{

	LONG			lLastError		= 0L;
	LONG			lNumMessages	= 0L;
	INT				i;
    _bstr_t			bstrHostName, bstrAccount, bstrPassword;
	LPTSTR			cp;
	BOOL			bSecure			= FALSE;
	AxEmail::IPop3Ptr oPop3 = NULL;
	AxEmail::IMessagePtr oMessage = NULL;


    // initialize COM
	CoInitialize(NULL);

	oPop3.CreateInstance(__uuidof(AxEmail::Pop3));
	if( oPop3 == NULL )
	{
		_tprintf( _T("Failed to create AxEmail:Pop3.\n") );		
		goto _EndMain;
	}

	// A license key is required to unlock this component after the trial period has expired.
	// Assign the LicenseKey property every time a new instance of this component is created (see code below). 
	// Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry.
	// For details, see manual, chapter "Product Activation".
	/*
	oPop3->LicenseKey = _T("XXXXX-XXXXX-XXXXX");
	*/
  
  // Component info
	_tprintf( _T("Auron Email Component %s\nBuild: %s\nModule: %s\nLicense Status: %s\nLicense Key: %s\n\n"), ( LPCTSTR ) oPop3->Version, ( LPCTSTR ) oPop3->Build, ( LPCTSTR ) oPop3->Module, ( LPCTSTR ) oPop3->LicenseStatus, ( LPCTSTR ) oPop3->LicenseKey );

  // Log File
  // oPop3->LogFile = _T("C:\\Pop3.log");
	_tprintf( _T("Log File used: %s\n\n"), ( LPCTSTR ) oPop3->LogFile );

  
	cp				= ReadInput( _T("POP3 Server") );
	bSecure			= _tcsicmp( cp, _T("pop.gmail.com") ) == 0;
	bstrHostName	= cp;
	bstrAccount		= ReadInput( _T("POP3 mailbox account") );
	bstrPassword	= ReadInput( _T("POP3 mailbox password") );

	if( bSecure )
	{
		oPop3->SetSecure( 995 );
		_tprintf( _T("SetSecure, result: %ld (%s)\n"), oPop3->LastError, ( LPCTSTR ) oPop3->GetErrorDescription( oPop3->LastError ) ); 
	}

	// Connect
	_tprintf( _T("Connecting...\n") );
	oPop3->Connect ( bstrHostName, bstrAccount, bstrPassword );
	_tprintf( _T("Connect, result: %ld (%s)\n"), oPop3->LastError, ( LPCTSTR ) oPop3->GetErrorDescription( oPop3->LastError ) ); 
	if( oPop3->LastError != 0 )
		goto _EndMain;

	// Count messages
	lNumMessages = oPop3->CountMessages();
	_tprintf( _T("CountMessages, result: %ld (%s)\n"), oPop3->LastError, ( LPCTSTR ) oPop3->GetErrorDescription( oPop3->LastError ) ); 
	if( lLastError != 0 )
		goto _EndMain;

	_tprintf( _T("Number of messages in mailbox: %ld\n"), lNumMessages );

	for(  i = 1; i < lNumMessages + 1 ; i++ )
	{
		oMessage = oPop3->GetEmailHeader( i ); 

		if( oMessage == NULL )
			continue;

		_tprintf( _T("Mail ID       : %d\n"), oMessage->ID );
		_tprintf( _T("  Mail From   : %s\n"), ( LPCTSTR ) oMessage->FromAddress );	
		_tprintf( _T("  Mail To     : %s\n"), ( LPCTSTR ) oMessage->ToAddress );	
		_tprintf( _T("  Mail Subject: %s\n"), ( LPCTSTR ) oMessage->Subject );	
		_tprintf( _T("  Mail Size   : %ld\n"), oMessage->Size );
		_tprintf( _T("  Mail Sent   : %s\n"), ( LPCTSTR ) oMessage->Date );
			
		_tprintf( _T("\n") );
	}

	oPop3->Disconnect();

_EndMain:

	if( oPop3 != NULL )
	{
		oPop3.Release();
	}

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


