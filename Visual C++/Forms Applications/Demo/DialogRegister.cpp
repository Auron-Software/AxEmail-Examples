#include "stdafx.h"
#include "Demo.h"
#include "DialogRegister.h"

/////////////////////////////////////////////////////////////////////////////

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////

CDialogRegister::CDialogRegister(CWnd* pParent) : CDialog(CDialogRegister::IDD, pParent)
{
  //{{AFX_DATA_INIT(CDialogRegister)
  m_strRegistrationCode = _T("");
  //}}AFX_DATA_INIT

  m_oSmtp = NULL;
  m_oSmtp.CreateInstance(__uuidof(AxEmail::Smtp));
}

/////////////////////////////////////////////////////////////////////////////

CDialogRegister::~CDialogRegister()
{
  if( m_oSmtp != NULL )
    m_oSmtp.Release();
}

/////////////////////////////////////////////////////////////////////////////

void CDialogRegister::DoDataExchange(CDataExchange* pDX)
{
  CDialog::DoDataExchange(pDX);
  //{{AFX_DATA_MAP(CDialogRegister)
  DDX_Control(pDX, IDC_STATIC_COMPANYURL, m_hlCompanyURL);
  DDX_Control(pDX, IDC_STATIC_SALESEMAIL, m_hlSalesEmail);
  DDX_Control(pDX, IDC_STATIC_SALESURL, m_hlSalesURL);
  DDX_Text(pDX, IDC_EDIT_REGISTRATIONCODE, m_strRegistrationCode);
  //}}AFX_DATA_MAP
}

/////////////////////////////////////////////////////////////////////////////

BEGIN_MESSAGE_MAP(CDialogRegister, CDialog)
  //{{AFX_MSG_MAP(CDialogRegister)
  //}}AFX_MSG_MAP
  ON_BN_CLICKED(IDOK, &CDialogRegister::OnBnClickedOk)
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////

BOOL CDialogRegister::OnInitDialog() 
{  
  CDialog::OnInitDialog();

  // Create Smtp object
  if( m_oSmtp != NULL )
  {
    m_strRegistrationCode = ( LPCTSTR ) m_oSmtp->LicenseKey;
  }

  m_hlSalesURL.SetWindowText  ( _T("www.auronsoftware.com/sales") );
  m_hlSalesURL.SetURL      (  "https://www.auronsoftware.com/sales" );
  
  m_hlSalesEmail.SetWindowText( _T("sales@auronsoftware.com") );
  m_hlSalesEmail.SetURL    (  "mailto:sales@auronsoftware.com" );
    
  m_hlCompanyURL.SetWindowText( _T("www.auronsoftware.com") );
  m_hlCompanyURL.SetURL    (  "https://www.auronsoftware.com" );
  
  UpdateData ( FALSE );

  return TRUE; 
}

/////////////////////////////////////////////////////////////////////////////

void CDialogRegister::OnBnClickedOk()
{
  CString  strErrMsg, strOldKey; 

  UpdateData( TRUE );

  if( m_oSmtp == NULL )
    return;
  
  strOldKey = (LPCTSTR ) m_oSmtp->LicenseKey;
  m_oSmtp->LicenseKey = (LPCTSTR ) m_strRegistrationCode;
  m_oSmtp->SaveLicenseKey();
  if( m_oSmtp->LastError != 0L )
  {
    strErrMsg.Format( _T("SaveLicense failed, error %ld: %s"), m_oSmtp->LastError, ( LPCTSTR ) m_oSmtp->GetErrorDescription( m_oSmtp->LastError ) );
    AfxMessageBox( strErrMsg );
    m_oSmtp->LicenseKey = ( LPCTSTR ) strOldKey;

    UpdateData( FALSE );

    return;
  }
    
  UpdateData( FALSE );
  
  OnOK();
}
