#if !defined(AFX_DIALOGSMTP_H__867B3DA5_EAAD_41BD_AEA8_6F16510531F6__INCLUDED_)
#define AFX_DIALOGSMTP_H__867B3DA5_EAAD_41BD_AEA8_6F16510531F6__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

/////////////////////////////////////////////////////////////////////////////

#import "..\..\include\AxEmail.tlb"
#include "..\..\include\AxEmailConstants.h"

/////////////////////////////////////////////////////////////////////////////

class CDialogSmtp : public CDialog
{
// Construction
public:
	
	CDialogSmtp(CWnd* pParent = NULL);   // standard constructor
	virtual ~CDialogSmtp();   // standard constructor

// Dialog Data
	//{{AFX_DATA(CDialogSmtp)
	enum { IDD = IDD_DIALOG_SMTP };
	CComboBox	m_comboCharset;
	CComboBox	m_comboFormat;
	CComboBox	m_comboPriority;
	CString	m_strToName;
	CString	m_strToAddress;
	CString	m_strSubject;
	CString	m_strResult;
	CString	m_strResponse;
	CString	m_strPassword;
	CString	m_strLogfile;
	CString	m_strHost;
	CString	m_strFromName;
	CString	m_strFromAddress;
	CString	m_strBody;
	CString	m_strAttachment;
	CString	m_strAccount;
	BOOL	m_bAuth;
	CString	m_strCcAddress;
	CString	m_strBccAddress;
	BOOL	m_bSecure;
	UINT	m_uPort;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CDialogSmtp)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	
	HICON m_hIcon;

	AxEmail::ISmtpPtr m_oSmtp;
	AxEmail::IMessagePtr m_oMessage;

	// Generated message map functions
	//{{AFX_MSG(CDialogSmtp)
	virtual BOOL OnInitDialog();
	afx_msg void OnRequiresauthentication();
	afx_msg void OnSend();
	afx_msg void OnClose();
	afx_msg void OnView();
	afx_msg void OnBrowse();
	afx_msg void OnCheckSecure();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_DIALOGSMTP_H__867B3DA5_EAAD_41BD_AEA8_6F16510531F6__INCLUDED_)
