#include "stdafx.h"

#include <comdef.h>
#include <atlbase.h>

#include "Demo.h"
#include "DialogSmtp.h"

/////////////////////////////////////////////////////////////////////////////

#include <atlconv.h>
#include <tchar.h>

/////////////////////////////////////////////////////////////////////////////

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////

CDialogSmtp::CDialogSmtp(CWnd* pParent)  : CDialog(CDialogSmtp::IDD, pParent)
{
  //{{AFX_DATA_INIT(CDialogSmtp)
  m_strToAddress    = _T("");
  m_strSubject      = _T("");
  m_strResult       = _T("");
  m_strResponse     = _T("");
  m_strPassword     = _T("");
  m_strLogfile      = _T("");
  m_strHost         = _T("");
  m_strFromName     = _T("");
  m_strFromAddress  = _T("");
  m_strBody         = _T("");
  m_strAttachment   = _T("");
  m_strAccount      = _T("");
  m_bAuth           = FALSE;
  m_strCcAddress    = _T("");
  m_strBccAddress   = _T("");
  m_bSecure         = FALSE;
  m_uPort           = 25;
  //}}AFX_DATA_INIT

  m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);

  m_oSmtp        = NULL;
  m_oMessage      = NULL;

}

/////////////////////////////////////////////////////////////////////////////

CDialogSmtp::~CDialogSmtp()
{
  if( m_oSmtp != NULL )
    m_oSmtp.Release();

  if( m_oMessage != NULL )
    m_oMessage.Release();
}

/////////////////////////////////////////////////////////////////////////////

void CDialogSmtp::DoDataExchange(CDataExchange* pDX)
{
  CDialog::DoDataExchange(pDX);
  //{{AFX_DATA_MAP(CDialogSmtp)
  DDX_Control(pDX, IDC_COMBO_CHARSET, m_comboCharset);
  DDX_Control(pDX, IDC_COMBO_FORMAT, m_comboFormat);
  DDX_Control(pDX, IDC_COMBO_PRIORITY, m_comboPriority);
  DDX_Text(pDX, IDC_EDIT_TOADDRESS, m_strToAddress);
  DDX_Text(pDX, IDC_EDIT_SUBJECT, m_strSubject);
  DDX_Text(pDX, IDC_EDIT_RESULT, m_strResult);
  DDX_Text(pDX, IDC_EDIT_RESPONSE, m_strResponse);
  DDX_Text(pDX, IDC_EDIT_PASSWORD, m_strPassword);
  DDX_Text(pDX, IDC_EDIT_LOGFILE, m_strLogfile);
  DDX_Text(pDX, IDC_EDIT_HOST, m_strHost);
  DDX_Text(pDX, IDC_EDIT_FROMNAME, m_strFromName);
  DDX_Text(pDX, IDC_EDIT_FROMADDRESS, m_strFromAddress);
  DDX_Text(pDX, IDC_EDIT_BODY, m_strBody);
  DDX_Text(pDX, IDC_EDIT_ATTACHMENT, m_strAttachment);
  DDX_Text(pDX, IDC_EDIT_ACCOUNT, m_strAccount);
  DDX_Check(pDX, IDC_CHECK_REQUIRESAUTHENTICATION, m_bAuth);
  DDX_Text(pDX, IDC_EDIT_CCADDRESS, m_strCcAddress);
  DDX_Text(pDX, IDC_EDIT_BCCADDRESS, m_strBccAddress);
  DDX_Check(pDX, IDC_CHECK_SECURE, m_bSecure);
  DDX_Text(pDX, IDC_EDIT_PORT, m_uPort);
  //}}AFX_DATA_MAP
}

/////////////////////////////////////////////////////////////////////////////

BEGIN_MESSAGE_MAP(CDialogSmtp, CDialog)
  //{{AFX_MSG_MAP(CDialogSmtp)
  ON_BN_CLICKED(IDC_CHECK_REQUIRESAUTHENTICATION, OnRequiresauthentication)
  ON_BN_CLICKED(IDC_BUTTON_SEND, OnSend)
  ON_WM_CLOSE()
  ON_BN_CLICKED(IDC_BUTTON_VIEW, OnView)
  ON_BN_CLICKED(IDC_BUTTON_BROWSE, OnBrowse)
  ON_BN_CLICKED(IDC_CHECK_SECURE, OnCheckSecure)
  //}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////

BOOL CDialogSmtp::OnInitDialog() 
{
  CDialog::OnInitDialog();
  
  TCHAR  szTempPath[ MAX_PATH + 1 ];

  GetTempPath( MAX_PATH - 14, szTempPath );
  if( szTempPath[ 0 ] == '\0' || szTempPath[ lstrlen( szTempPath ) - 1 ] != '\\' )
    _tcscat( szTempPath, _T("\\") );
  m_strLogfile  = szTempPath;
  m_strLogfile += "Smtp.log";

  SetIcon(m_hIcon, TRUE);      // Set big icon
  SetIcon(m_hIcon, FALSE);    // Set small icon

    // Initialize COM
  CoInitialize(NULL);

  // Create Smtp object
  m_oSmtp.CreateInstance(__uuidof(AxEmail::Smtp));
  if( m_oSmtp == NULL )
  {
    AfxMessageBox( _T("Failed to create AxEmail:Smtp") );
  }

  // Create E-mail Message object
  m_oMessage.CreateInstance(__uuidof(AxEmail::Message));
  if( m_oMessage == NULL )
  {
    AfxMessageBox( _T("Failed to create AxEmail:Message.\n") );    
  }
  
  UpdateData( FALSE );

  m_comboFormat.AddString ( _T("Plain") );
  m_comboFormat.AddString ( _T("HTML") );
  m_comboFormat.SetCurSel ( 0 );

  m_comboCharset.AddString ( _T("Standard") );
  m_comboCharset.AddString ( _T("Thai") );
  m_comboCharset.AddString ( _T("Japanese") );
  m_comboCharset.AddString ( _T("Chinese Simplified") );
  m_comboCharset.AddString ( _T("Korean") );
  m_comboCharset.AddString ( _T("Chinese Traditional") );
  m_comboCharset.AddString ( _T("Central Europe") );
  m_comboCharset.AddString ( _T("Russian") );
  m_comboCharset.AddString ( _T("Western") );
  m_comboCharset.AddString ( _T("Greek") );
  m_comboCharset.AddString ( _T("Turkish") );
  m_comboCharset.AddString ( _T("Hebrew") );
  m_comboCharset.AddString ( _T("Arabic") );
  m_comboCharset.AddString ( _T("Baltic") );
  m_comboCharset.AddString ( _T("Vietnamese") );
  m_comboCharset.AddString ( _T("UTF-7") );
  m_comboCharset.AddString ( _T("UTF-8") );
  m_comboCharset.SetCurSel ( 0 );

  m_comboPriority.AddString ( _T("Highest") );
  m_comboPriority.AddString ( _T("High") );
  m_comboPriority.AddString ( _T("Normal") );
  m_comboPriority.AddString ( _T("Low") );
  m_comboPriority.AddString ( _T("Lowest") );
  m_comboPriority.SetCurSel ( 2 );
    
  OnRequiresauthentication();
  
  return TRUE;
}

/////////////////////////////////////////////////////////////////////////////

void CDialogSmtp::OnRequiresauthentication() 
{
  UpdateData ( TRUE );

  GetDlgItem ( IDC_EDIT_ACCOUNT  )->EnableWindow ( m_bAuth );
  GetDlgItem ( IDC_EDIT_PASSWORD )->EnableWindow ( m_bAuth );
}

/////////////////////////////////////////////////////////////////////////////

void CDialogSmtp::OnSend() 
{
  CString  strAddress      = _T("");
  CString  strAddresses    = _T("");

  if( m_oSmtp == NULL || m_oMessage == NULL )
    return;
  
  UpdateData( TRUE );

  AfxGetApp( )->DoWaitCursor( 1 );

  // Clear all props first (good practise)
  m_oSmtp->Clear();
  m_oMessage->Clear ();

  // Set From Address
  m_oMessage->FromAddress = ( LPCTSTR ) m_strFromAddress;  
  
  // Set From Name
  m_oMessage->FromName = ( LPCTSTR ) m_strFromName;

  // Set Subject
  m_oMessage->Subject  = ( LPCTSTR ) m_strSubject;

  // Set Body
  if( m_comboCharset.GetCurSel() == 0 )
    m_oMessage->BodyPlainText = ( LPCTSTR ) m_strBody;
  else
    m_oMessage->BodyHtml = ( LPCTSTR ) m_strBody;

  // Set Attachments
  if( m_strAttachment != _T("") )
  {
    int nPos = 0;
    CString strToken = m_strAttachment.Tokenize( _T(";"), nPos );
    while( strToken != _T("") )
    {
      m_oMessage->AddAttachment( ( LPCTSTR ) strToken, _T("") );
      if( m_oMessage->LastError != 0 )
        goto _EndSend;
      strToken = m_strAttachment.Tokenize( _T(";"), nPos );
    }
  }

  // Set Encoding
  switch( m_comboCharset.GetCurSel() )
  {
    case 0:   m_oMessage->Encoding = AXEMAIL_MESSAGEENCODING_DEFAULT;       break;
    case 1:   m_oMessage->Encoding = AXEMAIL_MESSAGEENCODING_THAI;          break;
    case 2:   m_oMessage->Encoding = AXEMAIL_MESSAGEENCODING_JAPANESE;      break;
    case 3:   m_oMessage->Encoding = AXEMAIL_MESSAGEENCODING_CHINESE_SIMP;  break;
    case 4:   m_oMessage->Encoding = AXEMAIL_MESSAGEENCODING_KOREAN;        break;
    case 5:   m_oMessage->Encoding = AXEMAIL_MESSAGEENCODING_CHINESE_TRAD;  break;
    case 6:   m_oMessage->Encoding = AXEMAIL_MESSAGEENCODING_CENTRALEUROPE; break;
    case 7:   m_oMessage->Encoding = AXEMAIL_MESSAGEENCODING_RUSSIAN;       break;
    case 8:   m_oMessage->Encoding = AXEMAIL_MESSAGEENCODING_WESTERN;       break;
    case 9:   m_oMessage->Encoding = AXEMAIL_MESSAGEENCODING_GREEK;         break;
    case 10:  m_oMessage->Encoding = AXEMAIL_MESSAGEENCODING_TURKISH;       break;
    case 11:  m_oMessage->Encoding = AXEMAIL_MESSAGEENCODING_HEBREW;        break;
    case 12:  m_oMessage->Encoding = AXEMAIL_MESSAGEENCODING_ARABIC;        break;
    case 13:  m_oMessage->Encoding = AXEMAIL_MESSAGEENCODING_BALTIC;        break;
    case 14:  m_oMessage->Encoding = AXEMAIL_MESSAGEENCODING_VIETNAMESE;    break;
    case 15:  m_oMessage->Encoding = AXEMAIL_MESSAGEENCODING_UTF7;          break;
    case 16:  m_oMessage->Encoding = AXEMAIL_MESSAGEENCODING_UTF8;          break;
  }
  
  m_oMessage->Priority = m_comboPriority.GetCurSel() + 1;

  // Set To Addresses
  if( m_strToAddress != _T( "" ) )
  {
    m_oMessage->AddTo( ( LPCTSTR ) m_strToAddress, _T( "" ) );
    if( m_oMessage->LastError != 0 )
      goto _EndSend;
  }

  // Set Cc Addresses
  if( m_strCcAddress != _T( "" ) )
  {
    m_oMessage->AddCc( ( LPCTSTR ) m_strCcAddress, _T( "" ) );
    if( m_oMessage->LastError != 0 )
      goto _EndSend;
  }

  // Set Cc Addresses
  if( m_strBccAddress != _T( "" ) )
  {
    m_oMessage->AddBcc( ( LPCTSTR ) m_strBccAddress, _T( "" ) );
    if( m_oMessage->LastError != 0 )
      goto _EndSend;
  }

  // Set LogFile property 
  m_oSmtp->LogFile = ( LPCTSTR )  m_strLogfile;

  // Set Secure if secure communications is required
  if( m_bSecure )
  {
    m_oSmtp->SetSecure( m_uPort );
    if( m_oSmtp->LastError != 0 )
      goto _EndSend;
  }
  else
  {
    m_oSmtp->HostPort = m_uPort;
  }

  // Connect now
  if( m_bAuth )
    m_oSmtp->Connect( ( LPCTSTR) m_strHost, ( LPCTSTR) m_strAccount, ( LPCTSTR)  m_strPassword );
  else
    m_oSmtp->Connect( ( LPCTSTR) m_strHost , _T( "" ) , _T( "" ) );
  if( m_oSmtp->LastError != 0 )
    goto _EndSend;


  m_strResult = "Please wait...";
  UpdateData( FALSE );

  // Send
  m_oSmtp->Send( m_oMessage );

_EndSend:

  if( m_oSmtp != NULL )
  {
    m_strResult.Format ( _T("%ld (%s)"), m_oSmtp->LastError, ( LPCTSTR ) m_oSmtp->GetErrorDescription( m_oSmtp->LastError ) ); 

    m_strResponse = ( LPCSTR ) m_oSmtp->LastSmtpResponse;

    m_oSmtp->Disconnect();  // Disconnect session. Can be called even if there's no connection established
  }

  UpdateData( FALSE );

  AfxGetApp( )->DoWaitCursor( 0 );

}

/////////////////////////////////////////////////////////////////////////////

void CDialogSmtp::OnClose() 
{
  UpdateData( TRUE );
  
  CDialog::OnClose();
}

/////////////////////////////////////////////////////////////////////////////

void CDialogSmtp::OnView() 
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
    AfxMessageBox( _T("Can't run viewer."), MB_OK );
  }  
}

/////////////////////////////////////////////////////////////////////////////

void CDialogSmtp::OnBrowse() 
{
  CFileDialog    cfd( TRUE, NULL, NULL, OFN_HIDEREADONLY | OFN_ALLOWMULTISELECT, NULL );
  POSITION    pos;
  CString      sFile;

  UpdateData ( TRUE );

  m_strAttachment = _T( "" );

  if( cfd.DoModal () != IDOK )
    goto _EndOnBrowse;


  pos = cfd.GetStartPosition();
  while (pos != NULL)
  {
    if( m_strAttachment.GetLength() > 0 )
      m_strAttachment += _T( ";" );
    sFile = cfd.GetNextPathName(pos);
    m_strAttachment += sFile;
  }

  
_EndOnBrowse:

  UpdateData ( FALSE );
}



/////////////////////////////////////////////////////////////////////////////

void CDialogSmtp::OnCheckSecure() 
{
  UpdateData( TRUE );

  m_uPort = m_bSecure ? 465 : 25;

  UpdateData( FALSE );
}
