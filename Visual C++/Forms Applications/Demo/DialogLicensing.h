#if !defined(AFX_DIALOGLICENSING_H__2CAEB3F7_6F90_4E81_BA77_690F9B84BC27__INCLUDED_)
#define AFX_DIALOGLICENSING_H__2CAEB3F7_6F90_4E81_BA77_690F9B84BC27__INCLUDED_

/////////////////////////////////////////////////////////////////////////////

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

/////////////////////////////////////////////////////////////////////////////

#include "HyperLink.h"

/////////////////////////////////////////////////////////////////////////////

#import "..\..\include\AxEmail.tlb"
#include "..\..\include\AxEmailConstants.h"

/////////////////////////////////////////////////////////////////////////////

class CDialogLicensing : public CDialog
{
// Construction
public:
	CDialogLicensing(CWnd* pParent = NULL);   // standard constructor
	~CDialogLicensing ();

// Dialog Data
	//{{AFX_DATA(CDialogLicensing)
	enum { IDD = IDD_DIALOG_LICENSING };
	CHyperLink	m_hlSalesEmail;
	CHyperLink	m_hlSupportUrl;
	CHyperLink	m_hlSupportEmail;
	CHyperLink	m_hlDigibuy;
	CString	m_strLicenseKey;
	CString	m_strAboutHeader2;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CDialogLicensing)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	AxEmail::ISmtpPtr m_oSmtp;

	void ShowLicenseInfo();

	// Generated message map functions
	//{{AFX_MSG(CDialogLicensing)
	virtual BOOL OnInitDialog();
	afx_msg void OnButtonRegister();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_DIALOGLICENSING_H__2CAEB3F7_6F90_4E81_BA77_690F9B84BC27__INCLUDED_)
