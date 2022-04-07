#if !defined(AFX_DIALOGPOP3_H__A4F942C3_BBF0_4F74_89F8_94FCA82EF140__INCLUDED_)
#define AFX_DIALOGPOP3_H__A4F942C3_BBF0_4F74_89F8_94FCA82EF140__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

/////////////////////////////////////////////////////////////////////////////

#import "..\..\include\AxEmail.tlb"
#include "..\..\include\AxEmailConstants.h"

/////////////////////////////////////////////////////////////////////////////

class CDialogPop3 : public CDialog
{
public:
	CDialogPop3(CWnd* pParent = NULL);   // standard constructor
	virtual ~CDialogPop3();

	//{{AFX_DATA(CDialogPop3)
	enum { IDD = IDD_DIALOG_POP3 };
	CListCtrl	m_ListAttachments;
	CListCtrl	m_List;
	CString	m_strMailTo;
	CString	m_strSubject;
	CString	m_strResult;
	CString	m_strResponse;
	CString	m_strPassword;
	CString	m_strLogfile;
	CString	m_strHost;
	CString	m_strFromName;
	CString	m_strMailFrom;
	CString	m_strBody;
	CString	m_strAccount;
	BOOL	m_bSecure;
	UINT	m_uPort;
	//}}AFX_DATA

	//{{AFX_VIRTUAL(CDialogPop3)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

protected:

	HICON m_hIcon;

	AxEmail::IPop3Ptr m_oPop3;
	AxEmail::IMessagePtr m_oMessage;

	LONG	m_lMessageCount;

	CString	m_strTempPath;

	//{{AFX_MSG(CDialogPop3)
	afx_msg void OnConnect();
	afx_msg void OnDisconnect();
	afx_msg void OnDelete();
	afx_msg void OnList();
	afx_msg void OnView();
	virtual BOOL OnInitDialog();
	afx_msg void OnClose();
	afx_msg void OnDblclkListAttachments(NMHDR* pNMHDR, LRESULT* pResult);
	afx_msg void OnItemchangedList(NMHDR* pNMHDR, LRESULT* pResult);
	afx_msg void OnButtonSaveas();
	afx_msg void OnCheckSecure();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
private:
	void ClearControls();
	void UpdateControls();
	VOID SetupListControl();

	LONG GetResult();
};

/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}

#endif // !defined(AFX_DIALOGPOP3_H__A4F942C3_BBF0_4F74_89F8_94FCA82EF140__INCLUDED_)
