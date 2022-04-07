
#include "stdafx.h"

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
  _bstr_t			bstrHostName, bstrAccount, bstrPassword;
  LPTSTR			cp;
  BOOL			bSecure			= FALSE;
  AxEmail::IImapPtr oImap = NULL;
  AxEmail::IMessagePtr oMessage = NULL;
  AxEmail::IConstantsPtr oConstants = NULL;

  // initialize COM
  CoInitialize(NULL);

  oConstants.CreateInstance(__uuidof(AxEmail::Constants));
  oImap.CreateInstance(__uuidof(AxEmail::Imap));
  if( oImap == NULL || oConstants == NULL )
  {
    _tprintf( _T("Failed to create AxEmail:Imap and AxEmail:Constants.\n") );		
    goto _EndMain;
  }

  // A license key is required to unlock this component after the trial period has expired.
  // Assign the LicenseKey property every time a new instance of this component is created (see code below). 
  // Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry.
  // For details, see manual, chapter "Product Activation".
  /*
  oImap->LicenseKey = _T("XXXXX-XXXXX-XXXXX");
  */

  // Component info
  _tprintf( _T("Auron Email Component %s\nBuild: %s\nModule: %s\nLicense Status: %s\nLicense Key: %s\n\n"), ( LPCTSTR ) oImap->Version, ( LPCTSTR ) oImap->Build, ( LPCTSTR ) oImap->Module, ( LPCTSTR ) oImap->LicenseStatus, ( LPCTSTR ) oImap->LicenseKey );

  // Log File
  // oImap->LogFile = _T("C:\\Imap.log");
  _tprintf( _T("Log File used: %s\n\n"), ( LPCTSTR ) oImap->LogFile );


  cp				= ReadInput( _T("Imap Server") );
  bSecure			= _tcsicmp( cp, _T("imap.gmail.com") ) == 0;
  bstrHostName	= cp;
  bstrAccount		= ReadInput( _T("Imap mailbox account") );
  bstrPassword	= ReadInput( _T("Imap mailbox password") );

  if( bSecure )
  {
    oImap->SetSecure( 993 );
    _tprintf( _T("SetSecure, result: %ld (%s)\n"), oImap->LastError, ( LPCTSTR ) oImap->GetErrorDescription( oImap->LastError ) ); 
  }

  // Connect
  _tprintf( _T("Connecting...\n") );
  oImap->Connect ( bstrHostName, bstrAccount, bstrPassword );
  _tprintf( _T("Connect, result: %ld (%s)\n"), oImap->LastError, ( LPCTSTR ) oImap->GetErrorDescription( oImap->LastError ) ); 
  if( oImap->LastError != 0 )
    goto _EndMain;


  oMessage = oImap->FetchFirstEmail(oConstants->IMAP_SK_ALL);
  while (oImap->LastError == 0)
  {
    _tprintf( _T("Mail ID       : %d\n"), oMessage->ImapUID );
    _tprintf( _T("  Mail From   : %s\n"), ( LPCTSTR ) oMessage->FromAddress );	
    _tprintf( _T("  Mail To     : %s\n"), ( LPCTSTR ) oMessage->ToAddress );	
    _tprintf( _T("  Mail Subject: %s\n"), ( LPCTSTR ) oMessage->Subject );	
    _tprintf( _T("  Mail Size   : %ld\n"), oMessage->Size );
    _tprintf( _T("  Mail Sent   : %s\n"), ( LPCTSTR ) oMessage->Date );

    _tprintf( _T("\n") );

    oMessage = oImap->FetchNextEmail();
  }

  oImap->Disconnect();

_EndMain:

  if( oImap != NULL )
  {
    oImap.Release();
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


