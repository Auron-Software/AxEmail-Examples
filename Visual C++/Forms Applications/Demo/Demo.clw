; CLW file contains information for the MFC ClassWizard

[General Info]
Version=1
LastClass=CDemoDlg
LastTemplate=CDialog
NewFileInclude1=#include "stdafx.h"
NewFileInclude2=#include "demo.h"
LastPage=0

ClassCount=9
Class1=CDemoApp
Class2=CDemoDlg
Class3=CDialogLicensing
Class4=CDialogMime
Class5=CDialogPop3
Class6=CDialogRegister
Class7=CDialogSmtp
Class8=CHyperLink

ResourceCount=14
Resource1=IDD_DIALOG_SMTP
Resource2=IDD_DEMO_DIALOG
Resource3=IDD_DIALOG_POP3
Resource4=IDD_DIALOG_REGISTER
Resource5=IDD_DIALOG_LICENSING
Resource6=IDD_DIALOG_MIME
Class9=CDialogCreate
Resource7=IDD_DIALOG_CREATE
Resource8=IDD_DIALOG_SMTP (English (U.S.))
Resource9=IDD_DIALOG_REGISTER (English (U.S.))
Resource10=IDD_DIALOG_LICENSING (English (U.S.))
Resource11=IDD_DIALOG_POP3 (English (U.S.))
Resource12=IDD_DEMO_DIALOG (English (U.S.))
Resource13=IDD_DIALOG_MIME (English (U.S.))
Resource14=IDD_DIALOG_CREATE (English (U.S.))

[CLS:CDemoApp]
Type=0
BaseClass=CWinApp
HeaderFile=Demo.h
ImplementationFile=Demo.cpp

[CLS:CDemoDlg]
Type=0
BaseClass=CDialog
HeaderFile=DemoDlg.h
ImplementationFile=DemoDlg.cpp
Filter=D
VirtualFilter=dWC
LastObject=IDC_STATIC_VERSION

[CLS:CDialogLicensing]
Type=0
BaseClass=CDialog
HeaderFile=DialogLicensing.h
ImplementationFile=DialogLicensing.cpp

[CLS:CDialogMime]
Type=0
BaseClass=CDialog
HeaderFile=DialogMime.h
ImplementationFile=DialogMime.cpp
LastObject=65535
Filter=D
VirtualFilter=dWC

[CLS:CDialogPop3]
Type=0
BaseClass=CDialog
HeaderFile=DialogPop3.h
ImplementationFile=DialogPop3.cpp
Filter=D
VirtualFilter=dWC
LastObject=IDC_BUTTON_SAVEAS

[CLS:CDialogRegister]
Type=0
BaseClass=CDialog
HeaderFile=DialogRegister.h
ImplementationFile=DialogRegister.cpp

[CLS:CDialogSmtp]
Type=0
BaseClass=CDialog
HeaderFile=DialogSmtp.h
ImplementationFile=DialogSmtp.cpp
Filter=D
VirtualFilter=dWC
LastObject=IDC_CHECK_SECURE

[CLS:CHyperLink]
Type=0
BaseClass=CStatic
HeaderFile=HyperLink.h
ImplementationFile=HyperLink.cpp

[DLG:IDD_DEMO_DIALOG]
Type=1
Class=CDemoDlg
ControlCount=13
Control1=IDC_BUTTON_SMTP,button,1342242816
Control2=IDC_BUTTON_POP3,button,1342242816
Control3=IDC_STATIC,button,1342177287
Control4=IDC_STATIC,button,1342177287
Control5=IDC_BUTTON_LICENSING,button,1342242816
Control6=IDC_STATIC,static,1342308352
Control7=IDC_STATIC,static,1342308352
Control8=IDC_STATIC,static,1342308352
Control9=IDC_STATIC,static,1342308352
Control10=IDC_STATIC,static,1342308352
Control11=IDC_STATIC,static,1342308352
Control12=IDC_BUTTON_MIME,button,1342242816
Control13=IDC_STATIC,static,1342308352

[DLG:IDD_DIALOG_LICENSING]
Type=1
Class=CDialogLicensing
ControlCount=23
Control1=IDC_STATIC,static,1342177283
Control2=IDC_STATIC_ABOUTHEADER2,static,1342308352
Control3=IDOK,button,1342373889
Control4=IDC_STATIC,static,1342177296
Control5=IDC_STATIC_DIGIBUYURL,static,1342308352
Control6=IDC_STATIC_SALESEMAIL,static,1342308352
Control7=IDC_STATIC,static,1342308352
Control8=IDC_STATIC,static,1342308352
Control9=IDC_STATIC,static,1342308352
Control10=IDC_STATIC,static,1342177296
Control11=IDC_STATIC,static,1342308352
Control12=IDC_STATIC_REGTITLE,static,1342308352
Control13=IDC_EDIT_REGCODE,edit,1350633600
Control14=IDC_STATIC_SUPPORTURL,static,1342308352
Control15=IDC_STATIC,static,1342308352
Control16=IDC_STATIC,static,1342177296
Control17=IDC_STATIC,static,1342308352
Control18=IDC_STATIC,static,1342308352
Control19=IDC_STATIC,static,1342308352
Control20=IDC_STATIC_SUPPORTEMAIL,static,1342308352
Control21=IDC_STATIC,static,1342308352
Control22=IDC_BUTTON_REGISTER,button,1342242816
Control23=IDC_STATIC,static,1342308352

[DLG:IDD_DIALOG_MIME]
Type=1
Class=CDialogMime
ControlCount=25
Control1=65535,static,1342308352
Control2=IDC_EDIT_HOST,edit,1350631552
Control3=65535,static,1342308352
Control4=IDC_CHECK_REQUIRESAUTHENTICATION,button,1342242819
Control5=65535,static,1342308352
Control6=IDC_EDIT_ACCOUNT,edit,1350631552
Control7=65535,static,1342308352
Control8=IDC_EDIT_PASSWORD,edit,1350631584
Control9=65535,static,1342308352
Control10=IDC_EDIT_FILE,edit,1350633600
Control11=65535,static,1342308352
Control12=IDC_EDIT_BODY,edit,1350637764
Control13=IDC_BUTTON_LOAD,button,1342242816
Control14=IDC_BUTTON_SEND,button,1342242816
Control15=65535,static,1342308352
Control16=IDC_EDIT_RESULT,edit,1350633600
Control17=65535,static,1342308352
Control18=IDC_EDIT_RESPONSE,edit,1350637764
Control19=65535,static,1342308352
Control20=IDC_EDIT_LOGFILE,edit,1350631552
Control21=IDC_BUTTON_VIEW,button,1342242816
Control22=65535,button,1342177287
Control23=65535,button,1342177287
Control24=65535,button,1342177287
Control25=IDC_BUTTON_CREATE,button,1342242816

[DLG:IDD_DIALOG_POP3]
Type=1
Class=CDialogPop3
ControlCount=35
Control1=IDC_STATIC,button,1342177287
Control2=IDC_STATIC,static,1342308352
Control3=IDC_EDIT_HOST,edit,1350631552
Control4=IDC_STATIC,static,1342308352
Control5=IDC_STATIC,static,1342308352
Control6=IDC_EDIT_ACCOUNT,edit,1350631552
Control7=IDC_EDIT_PASSWORD,edit,1350631584
Control8=IDC_STATIC,button,1342177287
Control9=IDC_LIST,SysListView32,1350664197
Control10=IDC_BUTTON_CONNECT,button,1342242816
Control11=IDC_BUTTON_DISCONNECT,button,1342242816
Control12=IDC_BUTTON_LIST,button,1342242816
Control13=IDC_STATIC,button,1342177287
Control14=IDC_STATIC,static,1342308352
Control15=IDC_STATIC,static,1342308352
Control16=IDC_STATIC,static,1342308352
Control17=IDC_STATIC,static,1342308352
Control18=IDC_EDIT_FROM,edit,1350633600
Control19=IDC_EDIT_TO,edit,1350633600
Control20=IDC_EDIT_SUBJECT,edit,1350633600
Control21=IDC_EDIT_BODY,edit,1352734724
Control22=IDC_STATIC,button,1342177287
Control23=IDC_STATIC,static,1342308352
Control24=IDC_STATIC,static,1342308352
Control25=IDC_EDIT_RESULT,edit,1350633600
Control26=IDC_EDIT_LOGFILE,edit,1350631552
Control27=IDC_BUTTON_VIEW,button,1342242816
Control28=IDC_STATIC,static,1342308352
Control29=IDC_LIST_ATTACHMENTS,SysListView32,1484849159
Control30=IDC_STATIC,static,1342308352
Control31=IDC_EDIT_FROMNAME,edit,1350633472
Control32=IDC_STATIC,static,1342308352
Control33=IDC_EDIT_RESPONSE,edit,1350637764
Control34=IDC_BUTTON_DELETE,button,1342242816
Control35=IDC_BUTTON_SAVEAS,button,1342242816

[DLG:IDD_DIALOG_REGISTER]
Type=1
Class=CDialogRegister
ControlCount=16
Control1=IDC_STATIC,static,1342308352
Control2=IDC_EDIT_REGISTRATIONCODE,edit,1350631552
Control3=IDOK,button,1342242817
Control4=IDCANCEL,button,1342242816
Control5=IDC_STATIC_SALESURL,static,1342308352
Control6=IDC_STATIC_SALESEMAIL,static,1342308352
Control7=IDC_STATIC_COMPANYURL,static,1342308352
Control8=IDC_STATIC,static,1342308352
Control9=IDC_STATIC,static,1342308352
Control10=IDC_STATIC,static,1342308352
Control11=IDC_STATIC,static,1342308352
Control12=IDC_STATIC,static,1342177296
Control13=IDC_STATIC,static,1342308352
Control14=IDC_STATIC,static,1342308352
Control15=IDC_STATIC,static,1342308352
Control16=IDC_STATIC,static,1342177296

[DLG:IDD_DIALOG_SMTP]
Type=1
Class=CDialogSmtp
ControlCount=44
Control1=IDC_STATIC,static,1342308352
Control2=IDC_EDIT_HOST,edit,1350631552
Control3=IDC_STATIC,static,1342308352
Control4=IDC_CHECK_REQUIRESAUTHENTICATION,button,1342242819
Control5=IDC_STATIC,static,1342308352
Control6=IDC_EDIT_ACCOUNT,edit,1350631552
Control7=IDC_STATIC,static,1342308352
Control8=IDC_EDIT_PASSWORD,edit,1350631584
Control9=IDC_STATIC,static,1342308352
Control10=IDC_EDIT_FROMADDRESS,edit,1350631552
Control11=IDC_STATIC,static,1342308352
Control12=IDC_EDIT_FROMNAME,edit,1350631552
Control13=IDC_STATIC,static,1342308352
Control14=IDC_EDIT_TOADDRESS,edit,1350631552
Control15=IDC_STATIC,static,1342308352
Control16=IDC_EDIT_CCADDRESS,edit,1350631552
Control17=IDC_STATIC,static,1342308352
Control18=IDC_EDIT_BCCADDRESS,edit,1350631552
Control19=IDC_STATIC,static,1342308352
Control20=IDC_STATIC,static,1342308352
Control21=IDC_EDIT_SUBJECT,edit,1350631552
Control22=IDC_STATIC,static,1342308352
Control23=IDC_EDIT_BODY,edit,1350635716
Control24=IDC_STATIC,static,1342308352
Control25=IDC_EDIT_ATTACHMENT,edit,1350631552
Control26=IDC_BUTTON_BROWSE,button,1342242816
Control27=IDC_STATIC,static,1342308352
Control28=IDC_COMBO_CHARSET,combobox,1344339970
Control29=IDC_STATIC,static,1342308352
Control30=IDC_COMBO_FORMAT,combobox,1344339970
Control31=IDC_STATIC,static,1342308352
Control32=IDC_COMBO_PRIORITY,combobox,1344339970
Control33=IDC_BUTTON_SEND,button,1342242816
Control34=IDC_STATIC,static,1342308352
Control35=IDC_EDIT_RESULT,edit,1350633600
Control36=IDC_STATIC,static,1342308352
Control37=IDC_EDIT_RESPONSE,edit,1350637764
Control38=IDC_STATIC,static,1342308352
Control39=IDC_EDIT_LOGFILE,edit,1350631552
Control40=IDC_BUTTON_VIEW,button,1342242816
Control41=IDC_STATIC,button,1342177287
Control42=IDC_STATIC,button,1342177287
Control43=IDC_STATIC,button,1342177287
Control44=IDC_STATIC,button,1342177287

[DLG:IDD_DIALOG_CREATE]
Type=1
Class=CDialogCreate
ControlCount=29
Control1=65535,static,1342308352
Control2=IDC_EDIT_FROMADDRESS,edit,1350631552
Control3=65535,static,1342308352
Control4=IDC_EDIT_FROMNAME,edit,1350631552
Control5=65535,static,1342308352
Control6=IDC_EDIT_TOADDRESS,edit,1350631552
Control7=65535,static,1342308352
Control8=IDC_EDIT_CCADDRESS,edit,1350631552
Control9=65535,static,1342308352
Control10=IDC_EDIT_BCCADDRESS,edit,1350631552
Control11=65535,static,1342308352
Control12=65535,static,1342308352
Control13=IDC_EDIT_SUBJECT,edit,1350631552
Control14=65535,static,1342308352
Control15=IDC_EDIT_BODY,edit,1350635716
Control16=65535,static,1342308352
Control17=IDC_EDIT_ATTACHMENT,edit,1350631552
Control18=IDC_BUTTON_BROWSE,button,1342242816
Control19=65535,static,1342308352
Control20=IDC_COMBO_CHARSET,combobox,1344339970
Control21=65535,static,1342308352
Control22=IDC_COMBO_FORMAT,combobox,1344339970
Control23=65535,static,1342308352
Control24=IDC_COMBO_PRIORITY,combobox,1344339970
Control25=65535,button,1342177287
Control26=65535,button,1342177287
Control27=65535,button,1342177287
Control28=IDC_BUTTON_SAVE,button,1342242816
Control29=ID_CANCEL,button,1342242817

[CLS:CDialogCreate]
Type=0
HeaderFile=DialogCreate.h
ImplementationFile=DialogCreate.cpp
BaseClass=CDialog
Filter=D
VirtualFilter=dWC
LastObject=65535

[DLG:IDD_DEMO_DIALOG (English (U.S.))]
Type=1
Class=CDemoDlg
ControlCount=10
Control1=IDC_BUTTON_SMTP,button,1342242816
Control2=IDC_BUTTON_POP3,button,1342242816
Control3=IDC_BUTTON_LICENSING,button,1342242816
Control4=IDC_STATIC,static,1342308352
Control5=IDC_STATIC,static,1342308352
Control6=IDC_BUTTON_MIME,button,1342242816
Control7=IDC_STATIC,static,1342177296
Control8=IDC_STATIC,static,1342177296
Control9=IDC_STATIC,static,1342308352
Control10=IDC_STATIC_VERSION,static,1342308352

[DLG:IDD_DIALOG_SMTP (English (U.S.))]
Type=1
Class=CDialogSmtp
ControlCount=47
Control1=IDC_STATIC,static,1342308352
Control2=IDC_EDIT_HOST,edit,1350631552
Control3=IDC_CHECK_REQUIRESAUTHENTICATION,button,1342242819
Control4=IDC_STATIC,static,1342308352
Control5=IDC_EDIT_ACCOUNT,edit,1350631552
Control6=IDC_STATIC,static,1342308352
Control7=IDC_EDIT_PASSWORD,edit,1350631584
Control8=IDC_STATIC,static,1342308352
Control9=IDC_EDIT_FROMADDRESS,edit,1350631552
Control10=IDC_STATIC,static,1342308352
Control11=IDC_EDIT_FROMNAME,edit,1350631552
Control12=IDC_STATIC,static,1342308352
Control13=IDC_EDIT_TOADDRESS,edit,1350631552
Control14=IDC_STATIC,static,1342308352
Control15=IDC_EDIT_CCADDRESS,edit,1350631552
Control16=IDC_STATIC,static,1342308352
Control17=IDC_EDIT_BCCADDRESS,edit,1350631552
Control18=IDC_STATIC,static,1342308352
Control19=IDC_STATIC,static,1342308352
Control20=IDC_EDIT_SUBJECT,edit,1350631552
Control21=IDC_STATIC,static,1342308352
Control22=IDC_EDIT_BODY,edit,1350635716
Control23=IDC_STATIC,static,1342308352
Control24=IDC_EDIT_ATTACHMENT,edit,1350631552
Control25=IDC_BUTTON_BROWSE,button,1342242816
Control26=IDC_STATIC,static,1342308352
Control27=IDC_COMBO_CHARSET,combobox,1344339970
Control28=IDC_STATIC,static,1342308352
Control29=IDC_COMBO_FORMAT,combobox,1344339970
Control30=IDC_STATIC,static,1342308352
Control31=IDC_COMBO_PRIORITY,combobox,1344339970
Control32=IDC_BUTTON_SEND,button,1342242816
Control33=IDC_STATIC,static,1342308352
Control34=IDC_EDIT_RESULT,edit,1350633600
Control35=IDC_STATIC,static,1342308352
Control36=IDC_EDIT_RESPONSE,edit,1350637764
Control37=IDC_STATIC,static,1342308352
Control38=IDC_EDIT_LOGFILE,edit,1350631552
Control39=IDC_BUTTON_VIEW,button,1342242816
Control40=IDC_STATIC,button,1342177287
Control41=IDC_STATIC,button,1342177287
Control42=IDC_STATIC,button,1342177287
Control43=IDC_STATIC,button,1342177287
Control44=IDC_STATIC,static,1342308352
Control45=IDC_EDIT_PORT,edit,1350631552
Control46=IDC_CHECK_SECURE,button,1342242819
Control47=IDC_STATIC,static,1342308352

[DLG:IDD_DIALOG_POP3 (English (U.S.))]
Type=1
Class=CDialogPop3
ControlCount=38
Control1=IDC_STATIC,button,1342177287
Control2=IDC_STATIC,static,1342308352
Control3=IDC_EDIT_HOST,edit,1350631552
Control4=IDC_STATIC,static,1342308352
Control5=IDC_STATIC,static,1342308352
Control6=IDC_EDIT_ACCOUNT,edit,1350631552
Control7=IDC_EDIT_PASSWORD,edit,1350631584
Control8=IDC_STATIC,button,1342177287
Control9=IDC_LIST,SysListView32,1350664197
Control10=IDC_BUTTON_CONNECT,button,1342242816
Control11=IDC_BUTTON_DISCONNECT,button,1342242816
Control12=IDC_BUTTON_LIST,button,1342242816
Control13=IDC_STATIC,button,1342177287
Control14=IDC_STATIC,static,1342308352
Control15=IDC_STATIC,static,1342308352
Control16=IDC_STATIC,static,1342308352
Control17=IDC_STATIC,static,1342308352
Control18=IDC_EDIT_FROM,edit,1350633600
Control19=IDC_EDIT_TO,edit,1350633600
Control20=IDC_EDIT_SUBJECT,edit,1350633600
Control21=IDC_EDIT_BODY,edit,1352734724
Control22=IDC_STATIC,button,1342177287
Control23=IDC_STATIC,static,1342308352
Control24=IDC_STATIC,static,1342308352
Control25=IDC_EDIT_RESULT,edit,1350633600
Control26=IDC_EDIT_LOGFILE,edit,1350631552
Control27=IDC_BUTTON_VIEW,button,1342242816
Control28=IDC_STATIC,static,1342308352
Control29=IDC_LIST_ATTACHMENTS,SysListView32,1484849159
Control30=IDC_STATIC,static,1342308352
Control31=IDC_EDIT_FROMNAME,edit,1350633472
Control32=IDC_STATIC,static,1342308352
Control33=IDC_EDIT_RESPONSE,edit,1350637764
Control34=IDC_BUTTON_DELETE,button,1342242816
Control35=IDC_BUTTON_SAVEAS,button,1342242816
Control36=IDC_STATIC,static,1342308352
Control37=IDC_EDIT_PORT2,edit,1350631552
Control38=IDC_CHECK_SECURE,button,1342242819

[DLG:IDD_DIALOG_LICENSING (English (U.S.))]
Type=1
Class=?
ControlCount=23
Control1=IDC_STATIC,static,1342177283
Control2=IDC_STATIC_ABOUTHEADER2,static,1342308352
Control3=IDOK,button,1342373889
Control4=IDC_STATIC,static,1342177296
Control5=IDC_STATIC_DIGIBUYURL,static,1342308352
Control6=IDC_STATIC_SALESEMAIL,static,1342308352
Control7=IDC_STATIC,static,1342308352
Control8=IDC_STATIC,static,1342308352
Control9=IDC_STATIC,static,1342308352
Control10=IDC_STATIC,static,1342177296
Control11=IDC_STATIC,static,1342308352
Control12=IDC_STATIC_REGTITLE,static,1342308352
Control13=IDC_EDIT_REGCODE,edit,1350633600
Control14=IDC_STATIC_SUPPORTURL,static,1342308352
Control15=IDC_STATIC,static,1342308352
Control16=IDC_STATIC,static,1342177296
Control17=IDC_STATIC,static,1342308352
Control18=IDC_STATIC,static,1342308352
Control19=IDC_STATIC,static,1342308352
Control20=IDC_STATIC_SUPPORTEMAIL,static,1342308352
Control21=IDC_STATIC,static,1342308352
Control22=IDC_BUTTON_REGISTER,button,1342242816
Control23=IDC_STATIC,static,1342308352

[DLG:IDD_DIALOG_REGISTER (English (U.S.))]
Type=1
Class=?
ControlCount=16
Control1=IDC_STATIC,static,1342308352
Control2=IDC_EDIT_REGISTRATIONCODE,edit,1350631552
Control3=IDOK,button,1342242817
Control4=IDCANCEL,button,1342242816
Control5=IDC_STATIC_SALESURL,static,1342308352
Control6=IDC_STATIC_SALESEMAIL,static,1342308352
Control7=IDC_STATIC_COMPANYURL,static,1342308352
Control8=IDC_STATIC,static,1342308352
Control9=IDC_STATIC,static,1342308352
Control10=IDC_STATIC,static,1342308352
Control11=IDC_STATIC,static,1342308352
Control12=IDC_STATIC,static,1342177296
Control13=IDC_STATIC,static,1342308352
Control14=IDC_STATIC,static,1342308352
Control15=IDC_STATIC,static,1342308352
Control16=IDC_STATIC,static,1342177296

[DLG:IDD_DIALOG_MIME (English (U.S.))]
Type=1
Class=CDialogMime
ControlCount=27
Control1=IDC_STATIC,static,1342308352
Control2=IDC_EDIT_HOST,edit,1350631552
Control3=IDC_CHECK_REQUIRESAUTHENTICATION,button,1342242819
Control4=IDC_STATIC,static,1342308352
Control5=IDC_EDIT_ACCOUNT,edit,1350631552
Control6=IDC_STATIC,static,1342308352
Control7=IDC_EDIT_PASSWORD,edit,1350631584
Control8=IDC_STATIC,static,1342308352
Control9=IDC_EDIT_FILE,edit,1350633600
Control10=IDC_STATIC,static,1342308352
Control11=IDC_EDIT_BODY,edit,1350637764
Control12=IDC_BUTTON_LOAD,button,1342242816
Control13=IDC_BUTTON_SEND,button,1342242816
Control14=IDC_STATIC,static,1342308352
Control15=IDC_EDIT_RESULT,edit,1350633600
Control16=IDC_STATIC,static,1342308352
Control17=IDC_EDIT_RESPONSE,edit,1350637764
Control18=IDC_STATIC,static,1342308352
Control19=IDC_EDIT_LOGFILE,edit,1350631552
Control20=IDC_BUTTON_VIEW,button,1342242816
Control21=IDC_STATIC,button,1342177287
Control22=IDC_STATIC,button,1342177287
Control23=IDC_STATIC,button,1342177287
Control24=IDC_BUTTON_CREATE,button,1342242816
Control25=IDC_STATIC,static,1342308352
Control26=IDC_EDIT_PORT,edit,1350631552
Control27=IDC_CHECK_SECURE,button,1342242819

[DLG:IDD_DIALOG_CREATE (English (U.S.))]
Type=1
Class=?
ControlCount=29
Control1=65535,static,1342308352
Control2=IDC_EDIT_FROMADDRESS,edit,1350631552
Control3=65535,static,1342308352
Control4=IDC_EDIT_FROMNAME,edit,1350631552
Control5=65535,static,1342308352
Control6=IDC_EDIT_TOADDRESS,edit,1350631552
Control7=65535,static,1342308352
Control8=IDC_EDIT_CCADDRESS,edit,1350631552
Control9=65535,static,1342308352
Control10=IDC_EDIT_BCCADDRESS,edit,1350631552
Control11=65535,static,1342308352
Control12=65535,static,1342308352
Control13=IDC_EDIT_SUBJECT,edit,1350631552
Control14=65535,static,1342308352
Control15=IDC_EDIT_BODY,edit,1350635716
Control16=65535,static,1342308352
Control17=IDC_EDIT_ATTACHMENT,edit,1350631552
Control18=IDC_BUTTON_BROWSE,button,1342242816
Control19=65535,static,1342308352
Control20=IDC_COMBO_CHARSET,combobox,1344339970
Control21=65535,static,1342308352
Control22=IDC_COMBO_FORMAT,combobox,1344339970
Control23=65535,static,1342308352
Control24=IDC_COMBO_PRIORITY,combobox,1344339970
Control25=65535,button,1342177287
Control26=65535,button,1342177287
Control27=65535,button,1342177287
Control28=IDC_BUTTON_SAVE,button,1342242816
Control29=ID_CANCEL,button,1342242817

