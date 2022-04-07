#if !defined(AFX_DIALOGREGISTER_H__0C453DE3_6717_40A9_AA6A_C1ACC244212B__INCLUDED_)
#define AFX_DIALOGREGISTER_H__0C453DE3_6717_40A9_AA6A_C1ACC244212B__INCLUDED_

/////////////////////////////////////////////////////////////////////////////

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

/////////////////////////////////////////////////////////////////////////////

#import "..\..\include\AxEmail.tlb"

/////////////////////////////////////////////////////////////////////////////

#include "HyperLink.h"

/////////////////////////////////////////////////////////////////////////////

class CDialogRegister : public CDialog
{
// Construction
public:
	CDialogRegister(CWnd* pParent = NULL);   // standard constructor
	virtual ~CDialogRegister();

// Dialog Data
	//{{AFX_DATA(CDialogRegister)
	enum { IDD = IDD_DIALOG_REGISTER };
	CHyperLink	m_hlCompanyURL;
	CHyperLink	m_hlSalesEmail;
	CHyperLink	m_hlSalesURL;
	CString	m_strRegistrationCode;
	//}}AFX_DATA

	AxEmail::ISmtpPtr	m_oSmtp;


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CDialogRegister)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CDialogRegister)
	virtual BOOL OnInitDialog();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnBnClickedOk();
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_DIALOGREGISTER_H__0C453DE3_6717_40A9_AA6A_C1ACC244212B__INCLUDED_)
