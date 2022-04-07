#include "stdafx.h"
#include "Demo.h"
#include "DemoDlg.h"

/////////////////////////////////////////////////////////////////////////////

#import "..\..\include\AxEmail.tlb"
#include "..\..\include\AxEmailConstants.h"

/////////////////////////////////////////////////////////////////////////////

#include "DialogPop3.h"
#include "DialogSmtp.h"
#include "DialogImap.h"
#include "DialogMime.h"
#include "DialogLicensing.h"

/////////////////////////////////////////////////////////////////////////////

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////

CDemoDlg::CDemoDlg(CWnd* pParent)  : CDialog(CDemoDlg::IDD, pParent)
{
  //{{AFX_DATA_INIT(CDemoDlg)
  m_strVersion = _T("");
  //}}AFX_DATA_INIT
  m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

/////////////////////////////////////////////////////////////////////////////

void CDemoDlg::DoDataExchange(CDataExchange* pDX)
{
  CDialog::DoDataExchange(pDX);
  //{{AFX_DATA_MAP(CDemoDlg)
  DDX_Text(pDX, IDC_STATIC_VERSION, m_strVersion);
  //}}AFX_DATA_MAP
}

/////////////////////////////////////////////////////////////////////////////

BEGIN_MESSAGE_MAP(CDemoDlg, CDialog)
  //{{AFX_MSG_MAP(CDemoDlg)
  ON_BN_CLICKED(IDC_BUTTON_POP3, OnPop3)
  ON_BN_CLICKED(IDC_BUTTON_SMTP, OnSmtp)
  ON_BN_CLICKED(IDC_BUTTON_LICENSING, OnLicensing)
  ON_BN_CLICKED(IDC_BUTTON_MIME, OnButtonMime)
  //}}AFX_MSG_MAP
  ON_BN_CLICKED(IDC_BUTTON_IMAP, &CDemoDlg::OnBnClickedButtonImap)
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////

BOOL CDemoDlg::OnInitDialog()
{
  AxEmail::ISmtpPtr oSmtp = NULL;

  CDialog::OnInitDialog();

  // Create Smtp object
  oSmtp.CreateInstance(__uuidof(AxEmail::Smtp));
  if( oSmtp != NULL )
  {
    m_strVersion.Format( _T("%s; Build %s; Module: %s"), ( LPCTSTR ) oSmtp->Version, ( LPCTSTR ) oSmtp->Build, ( LPCTSTR ) oSmtp->Module );

    oSmtp.Release();
  }

  UpdateData( FALSE );

  SetIcon(m_hIcon, TRUE);      // Set big icon
  SetIcon(m_hIcon, FALSE);    // Set small icon

  return TRUE;
}

/////////////////////////////////////////////////////////////////////////////

void CDemoDlg::OnSmtp() 
{
  CDialogSmtp dlg;
  dlg.DoModal();  
}


/////////////////////////////////////////////////////////////////////////////

void CDemoDlg::OnPop3() 
{
  CDialogPop3  dlg;
  dlg.DoModal();  
}

/////////////////////////////////////////////////////////////////////////////

void CDemoDlg::OnLicensing() 
{
  CDialogLicensing dlg;
  dlg.DoModal ();
}

/////////////////////////////////////////////////////////////////////////////

void CDemoDlg::OnButtonMime() 
{
  CDialogMime dlg;
  dlg.DoModal();
}

/////////////////////////////////////////////////////////////////////////////


void CDemoDlg::OnBnClickedButtonImap()
{
  CDialogImap dlg;
  dlg.DoModal();
}
