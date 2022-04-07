// DialogImap.cpp : implementation file
//

#include "stdafx.h"
#include "Demo.h"
#include "DialogImap.h"
#include "afxdialogex.h"

#include <vector>

// CDialogImap dialog

IMPLEMENT_DYNAMIC(CDialogImap, CDialogEx)

CDialogImap::CDialogImap(CWnd* pParent /*=NULL*/)
	: CDialogEx(IDD_DIALOG_IMAP, pParent)
{
  m_strMailTo     = _T("");
  m_strSubject    = _T("");
  m_strResult     = _T("");
  m_strResponse   = _T("");
  m_strPassword   = _T("");
  m_strLogfile    = _T("");
  m_strHost       = _T("imap.gmail.com");
  m_strFromName   = _T("");
  m_strMailFrom   = _T("");
  m_strBody       = _T("");
  m_strAccount    = _T("");
  m_bSecure       = TRUE;
  m_uPort         = 993;

  m_oImap         = NULL;
  m_oMessage      = NULL;
  m_oConstants    = NULL;
}

CDialogImap::~CDialogImap()
{
  if( m_oImap != NULL )
    m_oImap.Release();

  if (m_oConstants != NULL)
    m_oConstants.Release();
}

void CDialogImap::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
  DDX_Control(pDX, IDC_LIST_ATTACHMENTS, m_ListAttachments);
  DDX_Control(pDX, IDC_LIST, m_List);
  DDX_Control(pDX, IDC_CMB_MAILBOX, m_CmbMailbox);
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
}


BEGIN_MESSAGE_MAP(CDialogImap, CDialogEx)
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
END_MESSAGE_MAP()


// CDialogImap message handlers

void CDialogImap::OnConnect()
{
  if( m_oImap == NULL )
    return;

  AfxGetApp ()->DoWaitCursor ( 1 );

  UpdateData ( TRUE );

  m_oImap->FetchMaxNumItemsAtOnce = 50;           // improve performance at the cost of memory
  m_oImap->LogFile = ( LPCTSTR ) m_strLogfile;

  m_oImap->Secure = m_bSecure ? VARIANT_TRUE: VARIANT_FALSE;
  m_oImap->HostPort = m_uPort;

  m_oImap->Connect( ( LPCTSTR ) m_strHost, ( LPCTSTR ) m_strAccount, ( LPCTSTR ) m_strPassword );
  if (GetResult() == 0)
  {
    m_CmbMailbox.ResetContent();
    AddMailboxes(_T(""), 0, 5);
    if (m_CmbMailbox.GetCount() > 0)
      m_CmbMailbox.SetCurSel(0);
  }

  UpdateControls();
  AfxGetApp ()->DoWaitCursor ( -1 );
}

void CDialogImap::AddMailboxes(LPCTSTR tszReference, int nDepth, int nMaxDepth)
{
  nDepth = nDepth + 1;

  m_oImap->List(tszReference, _T("%"));
  if (m_oImap->LastError != 0)
  {
    GetResult();
    return;
  }

  struct SListItem
  {
    CString sName;
    CString sAttributes;
  };
  std::vector<SListItem> vListItems;  

  int nCnt = m_oImap->ListCount();
  for (int i = 0; i < nCnt; i++)
  {
    SListItem li;
    li.sName = (LPCTSTR)m_oImap->ListName(i);
    li.sAttributes = (LPCTSTR)m_oImap->ListAttributes(i);
    vListItems.push_back(li);
  }
    
  CString sSep = (LPCTSTR)m_oImap->HierarchySeparator;
  CString sNewReference;
  for (auto oLi: vListItems)
  {
    sNewReference = oLi.sName + sSep;

    m_CmbMailbox.AddString(oLi.sName);

    // don't recurse further than max depth
    // NOTE: A lot of IMAP implementations have the 'CHILDREN' children capability where the mailbox flags indicate
    // if the mailbox has children or not. We select on the negative (does not say it has no children) 
    // to recurse to make sure that it also works for IMAP implementations that do not implement the 'CHILDREN' capability
    if (nDepth < nMaxDepth && oLi.sAttributes.Find(m_oConstants->IMAP_MBX_FLAG_HASNOCHILDREN) == -1)
      AddMailboxes(sNewReference, nDepth, nMaxDepth);
  }
}

void CDialogImap::OnDisconnect()
{
  if( m_oImap == NULL )
    return;

  AfxGetApp ()->DoWaitCursor ( 1 );

  m_oImap->Disconnect();
  GetResult();

  UpdateControls();

  ClearControls();

  AfxGetApp ()->DoWaitCursor( -1 );  
}

void CDialogImap::OnDelete()
{
  INT    nSelected    = m_List.GetSelectionMark ();
  INT    nMessageID   = (INT)m_List.GetItemData ( nSelected );  

  CString sId;
  sId.Format(_T("%d"), nMessageID);

  m_oImap->Store(sId.GetBuffer(), m_oConstants->IMAP_MAIL_FLAG_DELETED, m_oConstants->IMAP_STO_ADD);
  if (GetResult() == 0)
    m_oImap->Expunge();
  
  if (GetResult() == 0L)
    OnList();  
}

void CDialogImap::OnList()
{
  LONG    lIndex    = 0L;
  LONG    iMessage  = 0L;
  CString strBuffer;
  CString strMailbox;  

  if (m_CmbMailbox.GetCurSel() < 0) return;

  AfxGetApp ()->DoWaitCursor( 1 );    

  m_List.DeleteAllItems ();

  m_CmbMailbox.GetWindowText(strMailbox);
  m_oImap->Select(strMailbox.GetBuffer());
  if (GetResult()) goto _EndOnList;

  m_oMessage = m_oImap->FetchFirstEmailHeader(m_oConstants->IMAP_SK_ALL);
  while (m_oImap->LastError == 0)
  {
    strBuffer.Format( _T("%d"), m_oMessage->ImapUID );
    m_List.InsertItem( lIndex, strBuffer );
    m_List.SetItemText( lIndex, 1, ( LPCTSTR ) m_oMessage->FromAddress );
    m_List.SetItemText( lIndex, 2, ( LPCTSTR ) m_oMessage->Date );
    m_List.SetItemText ( lIndex, 3, ( LPCTSTR ) m_oMessage->Subject );
    m_List.SetItemData ( lIndex, m_oMessage->ImapUID );

    m_oMessage = m_oImap->FetchNextEmailHeader();
  }
  
  GetResult();

_EndOnList:

  UpdateControls ();

  AfxGetApp ()->DoWaitCursor ( -1 );
}

void CDialogImap::OnView()
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

BOOL CDialogImap::OnInitDialog()
{
  TCHAR  szTempPath[ MAX_PATH + 1 ] = { 0 };

  CDialog::OnInitDialog();

  GetTempPath( MAX_PATH - 14, szTempPath );
  if( szTempPath[ 0 ] == '\0' || szTempPath[ lstrlen( szTempPath ) - 1 ] != '\\' ) 
    _tcscat( szTempPath, _T("\\") );

  m_strTempPath = szTempPath;
  m_strLogfile  = szTempPath;
  m_strLogfile += "Imap.log";

  // Create Imap objects
  m_oConstants.CreateInstance(__uuidof(AxEmail::Constants));
  m_oImap.CreateInstance(__uuidof(AxEmail::Imap));
  if( m_oImap == NULL || m_oConstants == NULL )
  {
    AfxMessageBox( _T("Failed to create AxEmail:Imap and AxEmail:Constants") );
  }

  UpdateControls();

  SetupListControl();

  UpdateData( FALSE );

  return TRUE;
}

void CDialogImap::OnClose()
{
  UpdateData ( TRUE );

  OnDisconnect ();

  CDialog::OnClose();
}

void CDialogImap::OnDblclkListAttachments(NMHDR* pNMHDR, LRESULT* pResult)
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

void CDialogImap::OnItemchangedList(NMHDR* pNMHDR, LRESULT* pResult)
{
  NM_LISTVIEW  *pNMListView = (NM_LISTVIEW*)pNMHDR;
  CString      strTemp = _T( "" ), strSize = _T( "" );
  LONG         lNumAttachments = 0, iAttachment = 0;
  INT          nSelected = 0;
  CString      strUid;

  UpdateData( TRUE );

  AfxGetApp ()->DoWaitCursor( 1 );

  m_ListAttachments.DeleteAllItems ();

  m_strMailFrom = m_strFromName = m_strMailTo = m_strSubject =  m_strBody   = _T( "" );

  if(    ( pNMListView->uChanged & LVIF_STATE )
    && ( pNMListView->uNewState & LVIS_SELECTED && pNMListView->uNewState & LVIS_FOCUSED && !(pNMListView->uOldState & LVIS_SELECTED) && !(pNMListView->uOldState & LVIS_FOCUSED) )
    && ( ( nSelected = (INT)m_List.GetItemData ( pNMListView->iItem ) ) > 0 ))
  {  
    strUid.Format(_T("%s %d"), (LPCTSTR)m_oConstants->IMAP_SK_UID, nSelected);
    m_oMessage = m_oImap->FetchFirstEmail(strUid.GetBuffer());
    if (GetResult() == 0)
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
  }

  UpdateData( FALSE );

  GetDlgItem ( IDC_LIST_ATTACHMENTS )->EnableWindow( lNumAttachments > 0 ? TRUE : FALSE );

  AfxGetApp ()->DoWaitCursor ( -1 );

  *pResult = 0;
}

void CDialogImap::OnButtonSaveas()
{
  CFileDialog    cfd( FALSE, NULL, NULL, OFN_HIDEREADONLY, NULL );
  INT          nSelected    = (INT)m_List.GetItemData ( m_List.GetSelectionMark () );
  CString      strErrMsg, strUid;

  AfxGetApp ()->DoWaitCursor ( 1 );

  if ( nSelected <= 0 )
    goto _EndOnButtonSaveas;

  strUid.Format(_T("%s %d"), (LPCTSTR)m_oConstants->IMAP_SK_UID, nSelected);
  m_oMessage = m_oImap->FetchFirstEmail(strUid.GetBuffer());

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

void CDialogImap::OnCheckSecure()
{
  UpdateData( TRUE );

  m_uPort = m_bSecure ? 993 : 143;

  UpdateData( FALSE );  
}

void CDialogImap::ClearControls()
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

void CDialogImap::UpdateControls()
{
  VARIANT_BOOL bConnected = VARIANT_TRUE;

  bConnected = m_oImap->IsConnected(); 

  GetDlgItem ( IDC_BUTTON_DISCONNECT  )->EnableWindow (  bConnected );
  GetDlgItem ( IDC_BUTTON_LIST        )->EnableWindow (  bConnected );
  GetDlgItem ( IDC_EDIT_RESPONSE      )->EnableWindow (  bConnected );
  GetDlgItem ( IDC_BUTTON_CONNECT     )->EnableWindow ( !bConnected );
  GetDlgItem ( IDC_LIST               )->EnableWindow (  bConnected );
  GetDlgItem ( IDC_CMB_MAILBOX        )->EnableWindow (  bConnected );
  GetDlgItem ( IDC_EDIT_HOST          )->EnableWindow ( !bConnected );
  GetDlgItem ( IDC_EDIT_PORT          )->EnableWindow ( !bConnected );
  GetDlgItem ( IDC_CHECK_SECURE       )->EnableWindow ( !bConnected );
  GetDlgItem ( IDC_EDIT_ACCOUNT       )->EnableWindow ( !bConnected );
  GetDlgItem ( IDC_EDIT_PASSWORD      )->EnableWindow ( !bConnected );
  GetDlgItem ( IDC_BUTTON_DELETE      )->EnableWindow (  bConnected );
  GetDlgItem ( IDC_BUTTON_SAVEAS      )->EnableWindow (  bConnected );

  GetDlgItem ( IDC_LIST_ATTACHMENTS   )->EnableWindow (  bConnected );
}

VOID CDialogImap::SetupListControl()
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

LONG CDialogImap::GetResult()
{
  UpdateData( TRUE );

  if( m_oImap == NULL )
    return -1L;

  m_strResponse = ( LPCTSTR )m_oImap->LastImapResponse;

  UpdateData( FALSE );  

  return m_oImap->LastError;
}
