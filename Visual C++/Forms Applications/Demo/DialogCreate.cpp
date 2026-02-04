#include "stdafx.h"
#include <comdef.h>

#include "demo.h"
#include "DialogCreate.h"

/////////////////////////////////////////////////////////////////////////////

#include <atlconv.h>
#include <tchar.h>

/////////////////////////////////////////////////////////////////////////////


#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////

CDialogCreate::CDialogCreate(CWnd* pParent) : CDialog(CDialogCreate::IDD, pParent)
{
	//{{AFX_DATA_INIT(CDialogCreate)
	m_strAttachments	= _T("");
	m_strBody			= _T("");
	m_strSubject		= _T("");
	m_strFromName		= _T("");
	m_strFromAddress	= _T("");
	m_strToAddress		= _T("");
	m_strBccAddress		= _T("");
	m_strCcAddress		= _T("");
	//}}AFX_DATA_INIT
}

/////////////////////////////////////////////////////////////////////////////

void CDialogCreate::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CDialogCreate)
	DDX_Control(pDX, IDC_COMBO_FORMAT, m_comboFormat);
	DDX_Control(pDX, IDC_COMBO_PRIORITY, m_comboPriority);
	DDX_Control(pDX, IDC_COMBO_CHARSET, m_comboCharset);
	DDX_Text(pDX, IDC_EDIT_ATTACHMENT, m_strAttachments);
	DDX_Text(pDX, IDC_EDIT_BODY, m_strBody);
	DDX_Text(pDX, IDC_EDIT_SUBJECT, m_strSubject);
	DDX_Text(pDX, IDC_EDIT_FROMNAME, m_strFromName);
	DDX_Text(pDX, IDC_EDIT_FROMADDRESS, m_strFromAddress);
	DDX_Text(pDX, IDC_EDIT_TOADDRESS, m_strToAddress);
	DDX_Text(pDX, IDC_EDIT_BCCADDRESS, m_strBccAddress);
	DDX_Text(pDX, IDC_EDIT_CCADDRESS, m_strCcAddress);
	//}}AFX_DATA_MAP
}

/////////////////////////////////////////////////////////////////////////////

BEGIN_MESSAGE_MAP(CDialogCreate, CDialog)
	//{{AFX_MSG_MAP(CDialogCreate)
	ON_BN_CLICKED(IDC_BUTTON_SAVE, OnSave)
	ON_BN_CLICKED(ID_CANCEL, OnCancel)
	ON_BN_CLICKED(IDC_BUTTON_BROWSE, OnButtonBrowse)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////

BOOL CDialogCreate::OnInitDialog() 
{
	CDialog::OnInitDialog();
	
	m_comboFormat.AddString ( _T("Plain") );
	m_comboFormat.AddString ( _T("HTML") );

	m_comboFormat.SetCurSel ( 0 );

	m_comboCharset.AddString ( _T("Default") );
	m_comboCharset.AddString ( _T("Thai") );
	m_comboCharset.AddString ( _T("Japanese") );
	m_comboCharset.AddString ( _T("Chinese Simplified") );
	m_comboCharset.AddString ( _T("Korean") );
	m_comboCharset.AddString ( _T("Chinese Traditional") );
	m_comboCharset.AddString ( _T("Central Europe") );
	m_comboCharset.AddString ( _T("Russian") );
	m_comboCharset.AddString ( _T("Western") );
	m_comboCharset.AddString ( _T("Greek") );
	m_comboCharset.AddString ( _T("Turkish") );
	m_comboCharset.AddString ( _T("Hebrew") );
	m_comboCharset.AddString ( _T("Arabic") );
	m_comboCharset.AddString ( _T("Baltic") );
	m_comboCharset.AddString ( _T("Vietnamese") );
	m_comboCharset.AddString ( _T("UTF-7") );
	m_comboCharset.AddString ( _T("UTF-8") );

	m_comboCharset.SetCurSel ( 0 );

	m_comboPriority.AddString ( _T("Highest") );
	m_comboPriority.AddString ( _T("High") );
	m_comboPriority.AddString ( _T("Normal") );
	m_comboPriority.AddString ( _T("Low") );
	m_comboPriority.AddString ( _T("Lowest") );

	m_comboPriority.SetCurSel ( 2 );
	
	return TRUE;
}

/////////////////////////////////////////////////////////////////////////////

void CDialogCreate::OnSave() 
{
	CString			strErrMsg		= "";
	AxEmail::IMessagePtr oMessage = NULL;
	CFileDialog		cfd( FALSE, _T ( "MIM" ), NULL, OFN_HIDEREADONLY, _T ( "MIME Email File (*.MIM)|*.MIM||\0\0" ) );

	// Create E-mail Message object
	oMessage.CreateInstance(__uuidof(AxEmail::Message));
	if( oMessage == NULL )
	{
		AfxMessageBox( _T("Failed to create AxEmail:Message.") );
		return;
	}

	UpdateData( TRUE );

	oMessage->FromAddress	= ( LPCTSTR ) m_strFromAddress;	
	oMessage->FromName		= ( LPCTSTR ) m_strFromName;
	oMessage->Subject		= ( LPCTSTR ) m_strSubject;

	// Set Body
	if( m_comboFormat.GetCurSel() == 0 )
		oMessage->BodyPlainText	= ( LPCTSTR ) m_strBody;
	else
		oMessage->BodyHtml		= ( LPCTSTR ) m_strBody;

	switch( m_comboCharset.GetCurSel() )
	{
		case 0:		oMessage->Encoding = AXEMAIL_MESSAGEENCODING_DEFAULT;		break;
		case 1:		oMessage->Encoding = AXEMAIL_MESSAGEENCODING_THAI;			break;
		case 2:		oMessage->Encoding = AXEMAIL_MESSAGEENCODING_JAPANESE;		break;
		case 3:		oMessage->Encoding = AXEMAIL_MESSAGEENCODING_CHINESE_SIMP;	break;
		case 4:		oMessage->Encoding = AXEMAIL_MESSAGEENCODING_KOREAN;		break;
		case 5:		oMessage->Encoding = AXEMAIL_MESSAGEENCODING_CHINESE_TRAD;	break;
		case 6:		oMessage->Encoding = AXEMAIL_MESSAGEENCODING_CENTRALEUROPE;	break;
		case 7:		oMessage->Encoding = AXEMAIL_MESSAGEENCODING_RUSSIAN;		break;
		case 8:		oMessage->Encoding = AXEMAIL_MESSAGEENCODING_WESTERN;		break;
		case 9:		oMessage->Encoding = AXEMAIL_MESSAGEENCODING_GREEK;			break;
		case 10:	oMessage->Encoding = AXEMAIL_MESSAGEENCODING_TURKISH;		break;
		case 11:	oMessage->Encoding = AXEMAIL_MESSAGEENCODING_HEBREW;		break;
		case 12:	oMessage->Encoding = AXEMAIL_MESSAGEENCODING_ARABIC;		break;
		case 13:	oMessage->Encoding = AXEMAIL_MESSAGEENCODING_BALTIC;		break;
		case 14:	oMessage->Encoding = AXEMAIL_MESSAGEENCODING_VIETNAMESE;	break;
		case 15:	oMessage->Encoding = AXEMAIL_MESSAGEENCODING_UTF7;			break;
		case 16:	oMessage->Encoding = AXEMAIL_MESSAGEENCODING_UTF8;			break;
	}
	
	oMessage->Priority = m_comboPriority.GetCurSel() + 1;

	// To Addresses
	if( m_strToAddress != "" )
	{
		oMessage->AddTo( ( LPCTSTR ) m_strToAddress, _T("") );
		if( oMessage->LastError != 0L )
			goto _EndOnSave;
	}

	// Cc Addresses
	if( m_strCcAddress != "" )
	{
		oMessage->AddCc( ( LPCTSTR ) m_strCcAddress, _T("") );
		if( oMessage->LastError != 0L )
			goto _EndOnSave;
	}

	// Bcc Addresses
	if( m_strBccAddress != "" )
	{
		oMessage->AddBcc( ( LPCTSTR ) m_strBccAddress, _T("") );
		if( oMessage->LastError != 0L )
			goto _EndOnSave;
	}

	// Set Attachments
	if( m_strAttachments != "" )
	{
		oMessage->AddAttachment( ( LPCTSTR ) m_strAttachments, _T(""), VARIANT_FALSE);
		if( oMessage->LastError != 0L )
			goto _EndOnSave;
	}

	// Set Encode
	oMessage->Encode();
	if( oMessage->LastError != 0L )
		goto _EndOnSave;
	
	// Show Modal SaveAs Dialog
	if( cfd.DoModal() == IDOK )
	{
		m_strFileName = cfd.GetPathName(); 
		oMessage->SaveMIME( ( LPCTSTR ) m_strFileName );
		if( oMessage->LastError != 0L)
			goto _EndOnSave;

	}

	// Set Attachments
	if( m_strAttachments != "" )
	{
		oMessage->AddAttachment( ( LPCTSTR ) m_strAttachments, _T(""), VARIANT_FALSE);
		if( oMessage->LastError != 0L )
			goto _EndOnSave;
	}

_EndOnSave:


	if( oMessage != NULL )
	{
		strErrMsg.Format( _T("Result: %ld (%s)"), oMessage->LastError, ( LPCTSTR ) oMessage->GetErrorDescription( oMessage->LastError ) );

		AfxMessageBox( strErrMsg, oMessage->LastError == 0L ? MB_OK | MB_ICONINFORMATION : MB_OK | MB_ICONERROR );

		if(  oMessage != NULL &&  oMessage->LastError == 0L )
		{
			CDialog::OnOK();
		}

		oMessage.Release();
		oMessage = NULL;
	}
}

/////////////////////////////////////////////////////////////////////////////

void CDialogCreate::OnCancel() 
{
	CDialog::OnCancel ();	
}

/////////////////////////////////////////////////////////////////////////////

void CDialogCreate::OnButtonBrowse() 
{
	CFileDialog		cfd( TRUE, NULL, NULL, OFN_HIDEREADONLY | OFN_ALLOWMULTISELECT, NULL );
	POSITION		pos;
	CString			sFile;

	UpdateData( TRUE );

	m_strAttachments = "";

	if( cfd.DoModal () != IDOK )
		goto _EndOnButtonBrowse;

	pos = cfd.GetStartPosition();
	while (pos != NULL)
	{
		if( m_strAttachments.GetLength() > 0 )
			m_strAttachments += ";";
		sFile = cfd.GetNextPathName(pos);
		m_strAttachments += sFile;
	}

	
_EndOnButtonBrowse:

	UpdateData ( FALSE );	
}

/////////////////////////////////////////////////////////////////////////////
