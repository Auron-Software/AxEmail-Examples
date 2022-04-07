#include "stdafx.h"
#include "demo.h"
#include "DialogMime.h"
#include "DialogCreate.h"

/////////////////////////////////////////////////////////////////////////////

#include <atlconv.h>
#include <comdef.h>
#include <tchar.h>

/////////////////////////////////////////////////////////////////////////////

#import "..\..\include\AxEmail.tlb"
#include "..\..\include\AxEmailConstants.h"

/////////////////////////////////////////////////////////////////////////////

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////

CDialogMime::CDialogMime(CWnd* pParent) : CDialog(CDialogMime::IDD, pParent)
{
  //{{AFX_DATA_INIT(CDialogMime)
  m_bAuth = FALSE;
  m_strAccount    = _T("");
  m_strHost       = _T("");
  m_strPassword   = _T("");
  m_strLogfile    = _T("");
  m_strResult     = _T("");
  m_strMime       = _T("");
  m_strResponse   = _T("");
  m_strFile       = _T("");
  m_bSecure       = FALSE;
  m_uPort         = 25;
  //}}AFX_DATA_INIT

  m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

/////////////////////////////////////////////////////////////////////////////

void CDialogMime::DoDataExchange(CDataExchange* pDX)
{
  CDialog::DoDataExchange(pDX);
  //{{AFX_DATA_MAP(CDialogMime)
  DDX_Check(pDX, IDC_CHECK_REQUIRESAUTHENTICATION, m_bAuth);
  DDX_Text(pDX, IDC_EDIT_ACCOUNT, m_strAccount);
  DDX_Text(pDX, IDC_EDIT_HOST, m_strHost);
  DDX_Text(pDX, IDC_EDIT_PASSWORD, m_strPassword);
  DDX_Text(pDX, IDC_EDIT_LOGFILE, m_strLogfile);
  DDX_Text(pDX, IDC_EDIT_RESULT, m_strResult);
  DDX_Text(pDX, IDC_EDIT_BODY, m_strMime);
  DDX_Text(pDX, IDC_EDIT_RESPONSE, m_strResponse);
  DDX_Text(pDX, IDC_EDIT_FILE, m_strFile);
  DDX_Check(pDX, IDC_CHECK_SECURE, m_bSecure);
  DDX_Text(pDX, IDC_EDIT_PORT, m_uPort);
  //}}AFX_DATA_MAP
}

/////////////////////////////////////////////////////////////////////////////

BEGIN_MESSAGE_MAP(CDialogMime, CDialog)
  //{{AFX_MSG_MAP(CDialogMime)
  ON_BN_CLICKED(IDC_CHECK_REQUIRESAUTHENTICATION, OnRequiresauthentication)
  ON_BN_CLICKED(IDC_BUTTON_LOAD, OnButtonLoad)
  ON_BN_CLICKED(IDC_BUTTON_SEND, OnButtonSend)
  ON_BN_CLICKED(IDC_BUTTON_VIEW, OnButtonView)
  ON_BN_CLICKED(IDC_BUTTON_CREATE, OnCreate)
  //}}AFX_MSG_MAP
  ON_BN_CLICKED(IDC_CHECK_SECURE, &CDialogMime::OnBnClickedCheckSecure)
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////

BOOL CDialogMime::OnInitDialog() 
{
  TCHAR  szTempPath[ MAX_PATH + 1 ] = { 0 };

  CDialog::OnInitDialog();
  
  GetTempPath( MAX_PATH - 14, szTempPath );
  if( szTempPath[ 0 ] == '\0' || szTempPath[ lstrlen( szTempPath ) - 1 ] != '\\' )
    _tcscat( szTempPath, _T("\\") );
  m_strLogfile  = szTempPath;
  m_strLogfile += "Mime.log";

  SetIcon(m_hIcon, TRUE);      // Set big icon
  SetIcon(m_hIcon, FALSE);    // Set small icon
  
  // Create Smtp object
  m_oSmtp.CreateInstance(__uuidof(AxEmail::Smtp));
  if( m_oSmtp == NULL )
  {
    AfxMessageBox( _T("Failed to create AxEmail:Smtp") );
  }
  
  // Create Email message object
  m_oMessage.CreateInstance(__uuidof(AxEmail::Message));
  if( m_oMessage == NULL )
  {
    AfxMessageBox( _T("Failed to create AxEmail:Message") );
  }

  UpdateData( FALSE );

  OnRequiresauthentication();

  return TRUE;
}

/////////////////////////////////////////////////////////////////////////////

void CDialogMime::OnRequiresauthentication() 
{
  UpdateData ( TRUE );

  GetDlgItem ( IDC_EDIT_ACCOUNT  )->EnableWindow ( m_bAuth );
  GetDlgItem ( IDC_EDIT_PASSWORD )->EnableWindow ( m_bAuth );  
}

/////////////////////////////////////////////////////////////////////////////

void CDialogMime::OnButtonLoad() 
{
  CFileDialog    cfd( TRUE, _T ( "MIM" ), NULL, OFN_HIDEREADONLY, _T ( "MIME Email File (*.MIM)|*.MIM||\0\0" ) );

  if( m_oSmtp == NULL || m_oMessage == NULL )
    return;

  UpdateData( TRUE );

  if( cfd.DoModal() != IDOK )
    goto _EndOnButtonLoad;

  m_strFile = cfd.GetPathName ();

  UpdateData ( FALSE );

  AfxGetApp( )->DoWaitCursor( 1 );
  m_oMessage->LoadMIME( _bstr_t( m_strFile ) );
  AfxGetApp( )->DoWaitCursor( 0 );

  if( GetLastError( TRUE ) == 0L )
    m_strMime = ( LPCTSTR ) m_oMessage->MessageSource;
  else
    m_strFile.Empty();

_EndOnButtonLoad:

  UpdateData ( FALSE );  
}

/////////////////////////////////////////////////////////////////////////////

LONG CDialogMime::GetLastError( BOOL bMail )
{
  LONG  lLastError  = 0L;

  UpdateData ( TRUE );

  if( m_oSmtp == NULL || m_oMessage == NULL )
    return -1L;

  if( bMail )
    m_strResult.Format( _T("%ld: %s"), m_oMessage->LastError, ( LPCTSTR ) m_oMessage->GetErrorDescription( m_oMessage->LastError ) );
  else
    m_strResult.Format( _T("%ld: %s"), m_oSmtp->LastError, ( LPCTSTR ) m_oSmtp->GetErrorDescription( m_oSmtp->LastError ) );

  m_strResponse = ( LPCTSTR ) m_oSmtp->LastSmtpResponse;

  UpdateData ( FALSE );

  return lLastError;
}

/////////////////////////////////////////////////////////////////////////////

void CDialogMime::OnButtonSend() 
{
  UpdateData( TRUE );

  AfxGetApp( )->DoWaitCursor( 1 );

  if( m_oSmtp == NULL || m_oMessage == NULL )
    goto _EndSend;

  // Clear all props first (good practise)
  m_oSmtp->Clear();

  // Set LogFile property 
  m_oSmtp->put_LogFile( _bstr_t( m_strLogfile ) );

  // Set Secure if secure communications is required
  if( m_bSecure )
  {
    m_oSmtp->SetSecure( m_uPort );
    if( GetLastError( FALSE ) != 0L )
      goto _EndSend;
  }
  else
  {
    m_oSmtp->HostPort = m_uPort;
  }

  // Connect now
  m_oSmtp->Connect( ( LPCTSTR ) m_strHost, m_bAuth ? ( LPCTSTR ) m_strAccount : _T(""), m_bAuth ? ( LPCTSTR ) m_strPassword : _T("") );
  if( GetLastError( FALSE ) != 0L )
    goto _EndSend;

  m_oSmtp->Send( m_oMessage );

  GetLastError( FALSE );

  m_oSmtp->Disconnect ();

_EndSend:

  AfxGetApp( )->DoWaitCursor( 0 );
}

/////////////////////////////////////////////////////////////////////////////

void CDialogMime::OnButtonView() 
{
  HANDLE      hFirstFile;
  WIN32_FIND_DATA  findData;

  UpdateData( TRUE );
  
  if( m_strLogfile.GetLength() <= 0 ) 
    return;

  if( ( hFirstFile = FindFirstFile ( ( LPCTSTR ) m_strLogfile, &findData ) ) == INVALID_HANDLE_VALUE )
  {
    AfxMessageBox ( _T("File does not exist."), MB_OK );
    return;
  }
  FindClose( hFirstFile );

  if( ShellExecute( NULL, _T("open"), m_strLogfile, NULL, NULL, SW_SHOWDEFAULT ) == INVALID_HANDLE_VALUE ) 
  {
    AfxMessageBox( _T("Failed to launch Viewer."), MB_OK );
  }  
}

/////////////////////////////////////////////////////////////////////////////

void CDialogMime::OnCreate() 
{
  CDialogCreate  Dialog;
  
  UpdateData( TRUE );

  if( Dialog.DoModal() != IDOK )
    return;

  m_strFile =  Dialog.m_strFileName;

  UpdateData ( FALSE );

  AfxGetApp( )->DoWaitCursor( 1 );
  m_oMessage->LoadMIME( ( LPCTSTR ) m_strFile  );
  AfxGetApp( )->DoWaitCursor( 0 );

  if( GetLastError( TRUE ) == 0L )
    m_strMime = ( LPCTSTR ) m_oMessage->MessageSource;
  else
    m_strMime = _T( "" );

  UpdateData ( FALSE );
}

/////////////////////////////////////////////////////////////////////////////

void CDialogMime::OnBnClickedCheckSecure()
{
  UpdateData( TRUE );

  m_uPort = m_bSecure ? 465 : 25;

  UpdateData( FALSE );
}
