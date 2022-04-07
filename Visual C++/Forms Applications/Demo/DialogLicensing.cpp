#include "stdafx.h"
#include "Demo.h"
#include "DialogLicensing.h"
#include "DialogRegister.h" 

/////////////////////////////////////////////////////////////////////////////

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////

CDialogLicensing::CDialogLicensing(CWnd* pParent) : CDialog(CDialogLicensing::IDD, pParent)
{
	//{{AFX_DATA_INIT(CDialogLicensing)
	m_strLicenseKey		= _T("");
	m_strAboutHeader2	= _T("");
	//}}AFX_DATA_INIT

	// Create Smtp object
	m_oSmtp = NULL;
	m_oSmtp.CreateInstance(__uuidof(AxEmail::Smtp));
}

/////////////////////////////////////////////////////////////////////////////

CDialogLicensing::~CDialogLicensing ()
{
	if( m_oSmtp != NULL )
		m_oSmtp.Release ();
}

/////////////////////////////////////////////////////////////////////////////

void CDialogLicensing::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CDialogLicensing)
	DDX_Control(pDX, IDC_STATIC_SALESEMAIL,		m_hlSalesEmail);
	DDX_Control(pDX, IDC_STATIC_SUPPORTURL,		m_hlSupportUrl);
	DDX_Control(pDX, IDC_STATIC_SUPPORTEMAIL,	m_hlSupportEmail);
	DDX_Control(pDX, IDC_STATIC_DIGIBUYURL,		m_hlDigibuy);
	DDX_Text(pDX, IDC_EDIT_REGCODE, m_strLicenseKey);
	DDX_Text(pDX, IDC_STATIC_ABOUTHEADER2, m_strAboutHeader2);
	//}}AFX_DATA_MAP
}

/////////////////////////////////////////////////////////////////////////////

BEGIN_MESSAGE_MAP(CDialogLicensing, CDialog)
	//{{AFX_MSG_MAP(CDialogLicensing)
	ON_BN_CLICKED(IDC_BUTTON_REGISTER, OnButtonRegister)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////

BOOL CDialogLicensing::OnInitDialog() 
{
	CDialog::OnInitDialog();

	m_strAboutHeader2  = _T( "Auron Email Component " );
	if( m_oSmtp != NULL )
		m_strAboutHeader2 += ( LPCTSTR ) m_oSmtp->Build;

	m_hlDigibuy.SetWindowText		    ( _T("www.auronsoftware.com/sales") );
	m_hlDigibuy.SetURL				      ( _T("https://www.auronsoftware.com/sales") );

	m_hlSupportUrl.SetWindowText    ( _T("www.auronsoftware.com/support/smtp-pop3-component") );
	m_hlSupportUrl.SetURL			      ( _T("https://www.auronsoftware.com/knowledge-base//#email-component") );
	
	m_hlSupportEmail.SetWindowText	( _T("support@auronsoftware.com") );
	m_hlSupportEmail.SetURL			    ( _T("mailto:support@auronsoftware.com") );

	m_hlSalesEmail.SetWindowText	  ( _T("www.auronsoftware.com/sales") );
	m_hlSalesEmail.SetURL			      ( _T("https://www.auronsoftware.com/sales") );

	ShowLicenseInfo();

	UpdateData( FALSE );

	return TRUE;
}

/////////////////////////////////////////////////////////////////////////////

void CDialogLicensing::OnButtonRegister() 
{
	CDialogRegister	dlg;

	if( m_oSmtp == NULL )
		return;
	
	if ( dlg.DoModal () != IDOK )
		return;
																												
	ShowLicenseInfo();
}

/////////////////////////////////////////////////////////////////////////////

void CDialogLicensing::ShowLicenseInfo()
{
	CString		strLicenseKey;

	UpdateData( TRUE );

	if( m_oSmtp == NULL )
		return;

  m_strLicenseKey.Format( _T("%s (%s)"), ( LPCTSTR ) m_oSmtp->LicenseStatus, _tcslen( ( LPCTSTR ) m_oSmtp->LicenseKey ) > 0 ? ( LPCTSTR ) m_oSmtp->LicenseKey : _T("no license key" ) );
	
	UpdateData( FALSE );
}
