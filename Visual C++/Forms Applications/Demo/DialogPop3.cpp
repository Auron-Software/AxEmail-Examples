#include "stdafx.h"

#include <comdef.h>

#include "Demo.h"
#include "DialogPop3.h"

/////////////////////////////////////////////////////////////////////////////

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////

CDialogPop3::CDialogPop3(CWnd* pParent /*=NULL*/)
  : CDialog(CDialogPop3::IDD, pParent)
{
  //{{AFX_DATA_INIT(CDialogPop3)
  m_strMailTo     = _T("");
  m_strSubject    = _T("");
  m_strResult     = _T("");
  m_strResponse   = _T("");
  m_strPassword   = _T("");
  m_strLogfile    = _T("");
  m_strHost       = _T("");
  m_strFromName   = _T("");
  m_strMailFrom   = _T("");
  m_strBody       = _T("");
  m_strAccount    = _T("");
  m_bSecure       = FALSE;
  m_uPort         = 110;
  //}}AFX_DATA_INIT

  m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);

  m_oPop3         = NULL;
  m_oMessage      = NULL;

  m_lMessageCount = 0L;
}

/////////////////////////////////////////////////////////////////////////////

CDialogPop3::~CDialogPop3()
{
  if( m_oPop3 != NULL )
    m_oPop3.Release();
}

/////////////////////////////////////////////////////////////////////////////

void CDialogPop3::DoDataExchange(CDataExchange* pDX)
{
  CDialog::DoDataExchange(pDX);
  //{{AFX_DATA_MAP(CDialogPop3)
  DDX_Control(pDX, IDC_LIST_ATTACHMENTS, m_ListAttachments);
  DDX_Control(pDX, IDC_LIST, m_List);
  DDX_Text(pDX, IDC_EDIT_TO, m_strMailTo);
  DDX_Text(pDX, IDC_EDIT_SUBJECT, m_strSubject);
  DDX_Text(pDX, IDC_EDIT_RESULT, m_strResult);
  DDX_Text(pDX, IDC_EDIT_RESPONSE, m_strResponse);
  DDX_Text(pDX, IDC_EDIT_PASSWORD, m_strPassword);
  DDX_Text(pDX, IDC_EDIT_LOGFILE, m_strLogfile);
  DDX_Text(pDX, IDC_EDIT_HOST, m_strHost);
  DDX_Text(pDX, IDC_EDIT_FROMNAME, m_strFromName);
  DDX_Text(pDX, IDC_EDIT_FROM, m_strMailFrom);
  DDX_Text(pDX, IDC_EDIT_BODY, m_strBody);
  DDX_Text(pDX, IDC_EDIT_ACCOUNT, m_strAccount);
  DDX_Check(pDX, IDC_CHECK_SECURE, m_bSecure);
  DDX_Text(pDX, IDC_EDIT_PORT2, m_uPort);
  //}}AFX_DATA_MAP
}

/////////////////////////////////////////////////////////////////////////////

BEGIN_MESSAGE_MAP(CDialogPop3, CDialog)
  //{{AFX_MSG_MAP(CDialogPop3)
  ON_BN_CLICKED(IDC_BUTTON_CONNECT, OnConnect)
  ON_BN_CLICKED(IDC_BUTTON_DISCONNECT, OnDisconnect)
  ON_BN_CLICKED(IDC_BUTTON_DELETE, OnDelete)
  ON_BN_CLICKED(IDC_BUTTON_LIST, OnList)
  ON_BN_CLICKED(IDC_BUTTON_VIEW, OnView)
  ON_WM_CLOSE()
  ON_NOTIFY(NM_DBLCLK, IDC_LIST_ATTACHMENTS, OnDblclkListAttachments)
  ON_NOTIFY(LVN_ITEMCHANGED, IDC_LIST, OnItemchangedList)
  ON_BN_CLICKED(IDC_BUTTON_SAVEAS, OnButtonSaveas)
  ON_BN_CLICKED(IDC_CHECK_SECURE, OnCheckSecure)
  //}}AFX_MSG_MAP
END_MESSAGE_MAP()


/////////////////////////////////////////////////////////////////////////////

BOOL CDialogPop3::OnInitDialog() 
{
  TCHAR  szTempPath[ MAX_PATH + 1 ] = { 0 };

  CDialog::OnInitDialog();
  
  GetTempPath( MAX_PATH - 14, szTempPath );
  if( szTempPath[ 0 ] == '\0' || szTempPath[ lstrlen( szTempPath ) - 1 ] != '\\' ) 
    _tcscat( szTempPath, _T("\\") );
  
  m_strTempPath = szTempPath;
  m_strLogfile  = szTempPath;
  m_strLogfile += "Pop3.log";

  SetIcon(m_hIcon, TRUE);      
  SetIcon(m_hIcon, FALSE);
  
  // Create Pop3 object
  m_oPop3.CreateInstance(__uuidof(AxEmail::Pop3));
  if( m_oPop3 == NULL )
  {
    AfxMessageBox( _T("Failed to create AxEmail:Pop3") );
  }

  UpdateControls();

  SetupListControl();

  UpdateData( FALSE );
  
  return TRUE;
}

/////////////////////////////////////////////////////////////////////////////

void CDialogPop3::OnConnect() 
{
  if( m_oPop3 == NULL )
    return;

  AfxGetApp ()->DoWaitCursor ( 1 );

  UpdateData ( TRUE );

  m_oPop3->LogFile = ( LPCTSTR ) m_strLogfile;

  // Set Secure if secure communications is required
  if( m_bSecure )
  {
    m_oPop3->SetSecure( m_uPort );
    if( GetResult() != 0L )
      goto _EndOnConnect;
  }
  else
  {
    m_oPop3->HostPort = m_uPort;
  }

  m_oPop3->Connect( ( LPCTSTR ) m_strHost, ( LPCTSTR ) m_strAccount, ( LPCTSTR ) m_strPassword );
  GetResult();

_EndOnConnect:

  UpdateControls();
  AfxGetApp ()->DoWaitCursor ( -1 );
}

/////////////////////////////////////////////////////////////////////////////

void CDialogPop3::OnDisconnect() 
{
  if( m_oPop3 == NULL )
    return;

  AfxGetApp ()->DoWaitCursor ( 1 );

  m_oPop3->Disconnect();
  GetResult();

  UpdateControls();

  ClearControls();

  AfxGetApp ()->DoWaitCursor( -1 );  
}

/////////////////////////////////////////////////////////////////////////////

void CDialogPop3::OnDelete() 
{
  INT    nSelected    = m_List.GetSelectionMark ();
  INT    nMessageID   = (INT)m_List.GetItemData ( nSelected );  
  
  if( m_oPop3 == NULL )
    return;

  m_oPop3->DeleteMessage( nMessageID );

  if( GetResult() == 0L )
    OnList();  
}

/////////////////////////////////////////////////////////////////////////////

void CDialogPop3::OnList() 
{
  LONG    lIndex    = 0L;
  LONG    iMessage  = 0L;
  CString    strBuffer;

  if( m_oPop3 == NULL )
    return;

  AfxGetApp ()->DoWaitCursor( 1 );

  m_List.DeleteAllItems ();

  m_lMessageCount = m_oPop3->CountMessages();

  if ( GetResult() != 0L )
    goto _EndOnList;

  
  for( iMessage = 1; iMessage <= m_lMessageCount; iMessage++ )
  {
    if( ( m_oMessage = m_oPop3->GetEmailHeader( iMessage ) ) != NULL )
    {
    
      strBuffer.Format( _T("%d"), m_oMessage->ID );
      m_List.InsertItem( lIndex, strBuffer );
                
      m_List.SetItemText( lIndex, 1, ( LPCTSTR ) m_oMessage->FromAddress );
      
      m_List.SetItemText( lIndex, 2, ( LPCTSTR ) m_oMessage->Date );

      m_List.SetItemText ( lIndex, 3, ( LPCTSTR ) m_oMessage->Subject );

      m_List.SetItemData ( lIndex, m_oMessage->ID );

      lIndex++;      
    }
  }

_EndOnList:

  UpdateControls ();

  AfxGetApp ()->DoWaitCursor ( -1 );
}

/////////////////////////////////////////////////////////////////////////////

void CDialogPop3::OnView() 
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

VOID CDialogPop3::SetupListControl()
{
  m_List.SetExtendedStyle ( LVS_EX_GRIDLINES | LVS_EX_FULLROWSELECT| LVS_EX_HEADERDRAGDROP );

  LVCOLUMN lvCol;

  ZeroMemory (&lvCol,sizeof(LVCOLUMN));

  lvCol.mask  = LVCF_TEXT|LVCF_WIDTH;
  lvCol.cx    = 40;
  lvCol.pszText  = _T("ID");

  m_List.InsertColumn ( 0, &lvCol);

  lvCol.cx    = 130;
  lvCol.pszText  = _T("Sender");

  m_List.InsertColumn ( 1, &lvCol);

  lvCol.cx    = 130;
  lvCol.pszText  = _T("Time");

  m_List.InsertColumn ( 2, &lvCol);

  lvCol.cx    = 160;
  lvCol.pszText  = _T("Subject");

  m_List.InsertColumn ( 3, &lvCol );
}


/////////////////////////////////////////////////////////////////////////////

void CDialogPop3::UpdateControls()
{
  VARIANT_BOOL bConnected = VARIANT_TRUE;

  bConnected = m_oPop3->IsConnected(); 

  GetDlgItem ( IDC_BUTTON_DISCONNECT  )->EnableWindow (  bConnected );
  GetDlgItem ( IDC_BUTTON_LIST        )->EnableWindow (  bConnected );
  GetDlgItem ( IDC_EDIT_RESPONSE      )->EnableWindow (  bConnected );
  GetDlgItem ( IDC_BUTTON_CONNECT     )->EnableWindow ( !bConnected );
  GetDlgItem ( IDC_LIST               )->EnableWindow (  bConnected );
  GetDlgItem ( IDC_EDIT_HOST          )->EnableWindow ( !bConnected );
  GetDlgItem ( IDC_EDIT_PORT          )->EnableWindow ( !bConnected );
  GetDlgItem ( IDC_CHECK_SECURE       )->EnableWindow ( !bConnected );
  GetDlgItem ( IDC_EDIT_ACCOUNT       )->EnableWindow ( !bConnected );
  GetDlgItem ( IDC_EDIT_PASSWORD      )->EnableWindow ( !bConnected );
  GetDlgItem ( IDC_BUTTON_DELETE      )->EnableWindow (  bConnected );
  GetDlgItem ( IDC_BUTTON_SAVEAS      )->EnableWindow (  bConnected );

  GetDlgItem ( IDC_LIST_ATTACHMENTS   )->EnableWindow (  bConnected );

}

/////////////////////////////////////////////////////////////////////////////

void CDialogPop3::OnClose() 
{
  UpdateData ( TRUE );

  OnDisconnect ();
  
  CDialog::OnClose();
}

/////////////////////////////////////////////////////////////////////////////

LONG CDialogPop3::GetResult()
{
  UpdateData( TRUE );

  if( m_oPop3 == NULL )
    return -1L;

  m_strResponse = ( LPCTSTR ) m_oPop3->LastPop3Response;

  UpdateData( FALSE );  

  return m_oPop3->LastError;
}

/////////////////////////////////////////////////////////////////////////////

void CDialogPop3::OnDblclkListAttachments(NMHDR*, LRESULT* pResult) 
{
  INT    nSelected    = m_ListAttachments.GetSelectionMark ();
  CString strFileName    = "";

  if ( m_oMessage == NULL )
    return;

  strFileName   = m_strTempPath;
  strFileName += ( LPCTSTR ) m_oMessage->GetAttachmentName( nSelected + 1 );

  m_oMessage->SaveAttachment( nSelected + 1 ,strFileName.GetBuffer() );

  if( ShellExecute( NULL, _T("open"), strFileName, NULL, NULL, SW_SHOWDEFAULT ) == INVALID_HANDLE_VALUE ) 
    AfxMessageBox( _T("Failed to launch viewer."), MB_OK );

  *pResult = 0;
}

/////////////////////////////////////////////////////////////////////////////

void CDialogPop3::ClearControls()
{
  UpdateData ( TRUE );

  m_ListAttachments.DeleteAllItems ();
  m_List.DeleteAllItems ();

  m_strBody      =  _T("");
  m_strMailFrom  =  _T("");
  m_strMailTo    =  _T("");
  m_strSubject   =  _T("");
  m_strResponse  =  _T("");
  m_strFromName  =  _T("");

  UpdateData ( FALSE );
}

/////////////////////////////////////////////////////////////////////////////

void CDialogPop3::OnItemchangedList(NMHDR* pNMHDR, LRESULT* pResult) 
{
  NM_LISTVIEW  *pNMListView = (NM_LISTVIEW*)pNMHDR;
  CString      strTemp = _T( "" ), strSize = _T( "" );
  LONG         lNumAttachments = 0, iAttachment = 0;
  INT          nSelected = 0;

  UpdateData( TRUE );

  AfxGetApp ()->DoWaitCursor( 1 );

  m_ListAttachments.DeleteAllItems ();

  m_strMailFrom = m_strFromName = m_strMailTo = m_strSubject =  m_strBody   = _T( "" );

  if(    ( pNMListView->uChanged & LVIF_STATE )
    && ( pNMListView->uNewState & LVIS_SELECTED && pNMListView->uNewState & LVIS_FOCUSED && !(pNMListView->uOldState & LVIS_SELECTED) && !(pNMListView->uOldState & LVIS_FOCUSED) )
    && ( ( nSelected = (INT)m_List.GetItemData ( pNMListView->iItem ) ) > 0 )
    && ( ( m_oMessage = m_oPop3->GetEmailMessage ( nSelected ) ) != NULL ) )
  {  
    m_strMailFrom  = ( LPCTSTR ) m_oMessage->FromAddress;
    m_strFromName  = ( LPCTSTR ) m_oMessage->FromName;
    m_strMailTo    = ( LPCTSTR ) m_oMessage->ToAddress;
    m_strSubject   = ( LPCTSTR ) m_oMessage->Subject ;

    m_strBody     = ( LPCTSTR ) m_oMessage->BodyPlainText;
    if( m_strBody == "" )
      m_strBody   = ( LPCTSTR ) m_oMessage->BodyHtml ;
    m_strBody.Replace ( _T("\n"), _T("\r\n") );

    for( iAttachment = 1, lNumAttachments = m_oMessage->CountAttachments(); iAttachment <= lNumAttachments ; iAttachment++ )
    {              
      strTemp  = ( LPCSTR ) m_oMessage->GetAttachmentName( iAttachment );
      strTemp += " - ";
      strSize.Format ( _T("%ld KB") , ( m_oMessage->GetAttachmentSize( iAttachment ) / 1024 ) + 1 );
      strTemp += strSize;

      m_ListAttachments.InsertItem ( iAttachment - 1, strTemp, 0 );
      m_ListAttachments.SetItemData( iAttachment - 1, iAttachment );
  
    }    
  }

  UpdateData( FALSE );

  GetDlgItem ( IDC_LIST_ATTACHMENTS )->EnableWindow( lNumAttachments > 0 ? TRUE : FALSE );

  AfxGetApp ()->DoWaitCursor ( -1 );

  *pResult = 0;
}

/////////////////////////////////////////////////////////////////////////////

void CDialogPop3::OnButtonSaveas() 
{
  CFileDialog    cfd( FALSE, NULL, NULL, OFN_HIDEREADONLY, NULL );
  INT          nSelected    = (INT)m_List.GetItemData ( m_List.GetSelectionMark () );
  CString      strErrMsg;
  
  AfxGetApp ()->DoWaitCursor ( 1 );

  if ( nSelected <= 0 )
    goto _EndOnButtonSaveas;

  m_oMessage = m_oPop3->GetEmailMessage ( nSelected );

  if( GetResult() != 0L )
    goto _EndOnButtonSaveas;
  
  if( m_oMessage == NULL )
    goto _EndOnButtonSaveas;

  if ( cfd.DoModal () != IDOK )
    goto _EndOnButtonSaveas;

  m_oMessage->SaveMIME( ( LPCTSTR ) cfd.GetPathName() );
  if( m_oMessage->LastError != 0L )
  {
    strErrMsg.Format( _T("SaveMIME failed, result: %ld (%s)"), m_oMessage->LastError, ( LPCTSTR ) m_oMessage->GetErrorDescription( m_oMessage->LastError ) );
    AfxMessageBox( strErrMsg );
  }

_EndOnButtonSaveas:

  return;
}

/////////////////////////////////////////////////////////////////////////////

void CDialogPop3::OnCheckSecure() 
{
  UpdateData( TRUE );

  m_uPort = m_bSecure ? 995 : 110;

  UpdateData( FALSE );  
}
