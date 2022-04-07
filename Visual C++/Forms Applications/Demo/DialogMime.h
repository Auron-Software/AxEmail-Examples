#if !defined(AFX_DIALOGMIME_H__7D6978A0_7DC0_4244_8A19_C48C280FD453__INCLUDED_)
#define AFX_DIALOGMIME_H__7D6978A0_7DC0_4244_8A19_C48C280FD453__INCLUDED_

/////////////////////////////////////////////////////////////////////////////

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

/////////////////////////////////////////////////////////////////////////////

#import "..\..\include\AxEmail.tlb"
#include "..\..\include\AxEmailConstants.h"

/////////////////////////////////////////////////////////////////////////////

class CDialogMime : public CDialog
{
// Construction
public:
	CDialogMime(CWnd* pParent = NULL);   // standard constructor

// Dialog Data
	//{{AFX_DATA(CDialogMime)
	enum { IDD = IDD_DIALOG_MIME };
	BOOL	m_bAuth;
	CString	m_strAccount;
	CString	m_strHost;
	CString	m_strPassword;
	CString	m_strLogfile;
	CString	m_strResult;
	CString	m_strMime;
	CString	m_strResponse;
	CString	m_strFile;
	BOOL	m_bSecure;
	UINT	m_uPort;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CDialogMime)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	HICON	m_hIcon;

	AxEmail::ISmtpPtr m_oSmtp;
	AxEmail::IMessagePtr m_oMessage;

	// Generated message map functions
	//{{AFX_MSG(CDialogMime)
	virtual BOOL OnInitDialog();
	afx_msg void OnRequiresauthentication();
	afx_msg void OnButtonLoad();
	afx_msg void OnButtonSend();
	afx_msg void OnButtonView();
	afx_msg void OnCreate();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
private:
	LONG GetLastError (BOOL bMail);
public:
	afx_msg void OnBnClickedCheckSecure();
};

/////////////////////////////////////////////////////////////////////////////
//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_DIALOGMIME_H__7D6978A0_7DC0_4244_8A19_C48C280FD453__INCLUDED_)
