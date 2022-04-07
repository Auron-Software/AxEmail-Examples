#pragma once

#import "..\..\include\AxEmail.tlb"
#include "..\..\include\AxEmailConstants.h"

// CDialogImap dialog

class CDialogImap : public CDialogEx
{
	DECLARE_DYNAMIC(CDialogImap)

public:
	CDialogImap(CWnd* pParent = NULL);   // standard constructor
	virtual ~CDialogImap();

// Dialog Data
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_DIALOG_IMAP };
#endif

protected:
  
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support

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

	DECLARE_MESSAGE_MAP()

  void ClearControls();
  void UpdateControls();
  VOID SetupListControl();

  LONG GetResult();

  void AddMailboxes(LPCTSTR tszReference, int nDepth, int nMaxDepth);

private:

  CListCtrl	m_ListAttachments;
  CListCtrl	m_List;
  CComboBox m_CmbMailbox;
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

  AxEmail::IImapPtr m_oImap;
  AxEmail::IMessagePtr m_oMessage;
  AxEmail::IConstantsPtr m_oConstants;

  CString	m_strTempPath;
};
