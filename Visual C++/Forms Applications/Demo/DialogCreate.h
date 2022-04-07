#if !defined(AFX_DIALOGCREATE_H__B37824DA_CAE6_4AD4_84FA_A0FB68472E24__INCLUDED_)
#define AFX_DIALOGCREATE_H__B37824DA_CAE6_4AD4_84FA_A0FB68472E24__INCLUDED_

/////////////////////////////////////////////////////////////////////////////

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

/////////////////////////////////////////////////////////////////////////////

#import "..\..\include\AxEmail.tlb"
#include "..\..\include\AxEmailConstants.h"

/////////////////////////////////////////////////////////////////////////////

class CDialogCreate : public CDialog
{
// Construction
public:
	CDialogCreate(CWnd* pParent = NULL);   // standard constructor

	CString	m_strFileName;

// Dialog Data
	//{{AFX_DATA(CDialogCreate)
	enum { IDD = IDD_DIALOG_CREATE };
	CComboBox	m_comboFormat;
	CComboBox	m_comboPriority;
	CComboBox	m_comboCharset;
	CString	m_strAttachments;
	CString	m_strBody;
	CString	m_strSubject;
	CString	m_strFromName;
	CString	m_strFromAddress;
	CString	m_strToAddress;
	CString	m_strBccAddress;
	CString	m_strCcAddress;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CDialogCreate)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CDialogCreate)
	virtual BOOL OnInitDialog();
	afx_msg void OnSave();
	afx_msg void OnCancel();
	afx_msg void OnButtonBrowse();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_DIALOGCREATE_H__B37824DA_CAE6_4AD4_84FA_A0FB68472E24__INCLUDED_)
