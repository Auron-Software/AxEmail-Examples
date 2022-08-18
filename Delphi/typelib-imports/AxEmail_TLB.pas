unit AxEmail_TLB;

// ************************************************************************ //
// WARNING                                                                    
// -------                                                                    
// The types declared in this file were generated from data read from a       
// Type Library. If this type library is explicitly or indirectly (via        
// another type library referring to this type library) re-imported, or the   
// 'Refresh' command of the Type Library Editor activated while editing the   
// Type Library, the contents of this file will be regenerated and all        
// manual modifications will be lost.                                         
// ************************************************************************ //

// $Rev: 17244 $
// File generated on 11/13/2018 2:08:12 PM from Type Library described below.

// ************************************************************************  //
// Type Lib: G:\AxEmail\VisualC\AxEmail\Release32\AxEmail32.dll (1)
// LIBID: {3BCF1B58-7071-4564-9D1D-FA008B19179A}
// LCID: 0
// Helpfile: 
// HelpString: ActiveXperts E-mail Component 5.0 Type Library
// DepndLst: 
//   (1) v2.0 stdole, (C:\Windows\SysWOW64\stdole2.tlb)
// Errors:
//   Hint: Member 'Type' of 'IImapFetchData' changed to 'Type_'
//   Hint: Member 'Type' of 'IImapFetchData' changed to 'Type_'
//   WARN: Could not find file 'H:\Utils\TLIBIMP.SYM, G:\AxEmail\TLIBIMP.SYM, H:\Utils\..\bin\tlibimp.sym'
// Cmdline:
//   "H:\Utils\tlibimp.exe"  -P+ -Ha- -Hs- -Hr- -D"G:\AxEmail\Samples\Delphi\typelib-imports\" "G:\AxEmail\VisualC\AxEmail\Release32\AxEmail32.dll"
// ************************************************************************ //
{$TYPEDADDRESS OFF} // Unit must be compiled without type-checked pointers. 
{$WARN SYMBOL_PLATFORM OFF}
{$WRITEABLECONST ON}
{$VARPROPSETTER ON}
{$ALIGN 4}
interface

uses Windows, ActiveX, Classes, Graphics, OleServer, StdVCL, Variants;
  

// *********************************************************************//
// GUIDS declared in the TypeLibrary. Following prefixes are used:        
//   Type Libraries     : LIBID_xxxx                                      
//   CoClasses          : CLASS_xxxx                                      
//   DISPInterfaces     : DIID_xxxx                                       
//   Non-DISP interfaces: IID_xxxx                                        
// *********************************************************************//
const
  // TypeLibrary Major and minor versions
  AxEmailMajorVersion = 1;
  AxEmailMinorVersion = 0;

  LIBID_AxEmail: TGUID = '{3BCF1B58-7071-4564-9D1D-FA008B19179A}';

  IID_IMessage: TGUID = '{CC87528F-D4BF-4BFE-8DF7-9BFB57D33810}';
  CLASS_Message: TGUID = '{1A9CF5C5-C6E4-48B1-910A-74437BA16414}';
  IID_ISmtp: TGUID = '{FE73AE95-A7C6-4E98-8AF2-CAB94AAE743A}';
  CLASS_Smtp: TGUID = '{CA181116-E4BA-4F09-9176-328CDF8409D5}';
  IID_IPop3: TGUID = '{7D24A1B3-4808-4208-9A9F-2A281256744A}';
  CLASS_Pop3: TGUID = '{6F7E09C2-CAFF-4501-9E34-F395DF830B87}';
  IID_IImapFetchData: TGUID = '{E867B037-8B16-4C91-B4F3-91A5A5B9032F}';
  CLASS_ImapFetchData: TGUID = '{56BC74E1-2204-4049-9B1F-336ED3D57A8C}';
  IID_IImap: TGUID = '{2F17D77B-374D-431E-8772-8FD1B20D1516}';
  CLASS_Imap: TGUID = '{B5BB4EE0-3F88-41A8-BC18-65C90A2CFE9E}';
  IID_IConstants: TGUID = '{AD78421F-9ECA-4BFD-81E6-94712D62DEFD}';
  CLASS_Constants: TGUID = '{5F45F782-073A-4D8D-ADB9-23C9F3F34684}';
type

// *********************************************************************//
// Forward declaration of types defined in TypeLibrary                    
// *********************************************************************//
  IMessage = interface;
  IMessageDisp = dispinterface;
  ISmtp = interface;
  ISmtpDisp = dispinterface;
  IPop3 = interface;
  IPop3Disp = dispinterface;
  IImapFetchData = interface;
  IImapFetchDataDisp = dispinterface;
  IImap = interface;
  IImapDisp = dispinterface;
  IConstants = interface;
  IConstantsDisp = dispinterface;

// *********************************************************************//
// Declaration of CoClasses defined in Type Library                       
// (NOTE: Here we map each CoClass to its Default Interface)              
// *********************************************************************//
  Message = IMessage;
  Smtp = ISmtp;
  Pop3 = IPop3;
  ImapFetchData = IImapFetchData;
  Imap = IImap;
  Constants = IConstants;


// *********************************************************************//
// Declaration of structures, unions and aliases.                         
// *********************************************************************//
  PWideString1 = ^WideString; {*}


// *********************************************************************//
// Interface: IMessage
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {CC87528F-D4BF-4BFE-8DF7-9BFB57D33810}
// *********************************************************************//
  IMessage = interface(IDispatch)
    ['{CC87528F-D4BF-4BFE-8DF7-9BFB57D33810}']
    function Get_LastError: Integer; safecall;
    function Get_FromName: WideString; safecall;
    procedure Set_FromName(const Name: WideString); safecall;
    function Get_FromAddress: WideString; safecall;
    procedure Set_FromAddress(const Address: WideString); safecall;
    function Get_ReplyAddress: WideString; safecall;
    procedure Set_ReplyAddress(const Address: WideString); safecall;
    function Get_ReadReceiptAddress: WideString; safecall;
    procedure Set_ReadReceiptAddress(const Address: WideString); safecall;
    function Get_Organization: WideString; safecall;
    procedure Set_Organization(const Organization: WideString); safecall;
    function Get_Subject: WideString; safecall;
    procedure Set_Subject(const Subject: WideString); safecall;
    function Get_BodyPlainText: WideString; safecall;
    procedure Set_BodyPlainText(const Body: WideString); safecall;
    function Get_BodyHtml: WideString; safecall;
    procedure Set_BodyHtml(const Body: WideString); safecall;
    function Get_Encoding: Integer; safecall;
    procedure Set_Encoding(Encoding: Integer); safecall;
    function Get_Priority: Integer; safecall;
    procedure Set_Priority(Priority: Integer); safecall;
    function Get_ID: Integer; safecall;
    function Get_MessageSource: WideString; safecall;
    function Get_MessageHeader: WideString; safecall;
    function Get_Size: Integer; safecall;
    function Get_Date: WideString; safecall;
    function Get_ToAddress: WideString; safecall;
    function Get_CcAddress: WideString; safecall;
    function Get_BccAddress: WideString; safecall;
    function Get_ImapFlags: WideString; safecall;
    function Get_ImapUID: Integer; safecall;
    function Get_ImapSequenceNumber: Integer; safecall;
    procedure Set_ImapSequenceNumber(Uid: Integer); safecall;
    procedure Clear; safecall;
    function GetErrorDescription(lError: Integer): WideString; safecall;
    procedure AddTo(const EmailAddress: WideString; const DisplayName: WideString); safecall;
    procedure AddCc(const EmailAddress: WideString; const DisplayName: WideString); safecall;
    procedure AddBcc(const EmailAddress: WideString; const DisplayName: WideString); safecall;
    function CountAttachments: Integer; safecall;
    function GetAttachmentName(ID: Integer): WideString; safecall;
    function GetAttachmentSize(ID: Integer): Integer; safecall;
    procedure AddAttachment(const FileName: WideString); safecall;
    procedure SaveAttachment(ID: Integer; const SaveAsFile: WideString); safecall;
    function ImapHasFlag(const Flag: WideString): WordBool; safecall;
    procedure LoadMIME(const MimeFile: WideString); safecall;
    procedure SaveMIME(const MimeFile: WideString); safecall;
    procedure Encode; safecall;
    procedure Decode; safecall;
    function GetHeaderValue(const Name: WideString): WideString; safecall;
    procedure AddHeader(const Name: WideString; const Value: WideString); safecall;
    property LastError: Integer read Get_LastError;
    property FromName: WideString read Get_FromName write Set_FromName;
    property FromAddress: WideString read Get_FromAddress write Set_FromAddress;
    property ReplyAddress: WideString read Get_ReplyAddress write Set_ReplyAddress;
    property ReadReceiptAddress: WideString read Get_ReadReceiptAddress write Set_ReadReceiptAddress;
    property Organization: WideString read Get_Organization write Set_Organization;
    property Subject: WideString read Get_Subject write Set_Subject;
    property BodyPlainText: WideString read Get_BodyPlainText write Set_BodyPlainText;
    property BodyHtml: WideString read Get_BodyHtml write Set_BodyHtml;
    property Encoding: Integer read Get_Encoding write Set_Encoding;
    property Priority: Integer read Get_Priority write Set_Priority;
    property ID: Integer read Get_ID;
    property MessageSource: WideString read Get_MessageSource;
    property MessageHeader: WideString read Get_MessageHeader;
    property Size: Integer read Get_Size;
    property Date: WideString read Get_Date;
    property ToAddress: WideString read Get_ToAddress;
    property CcAddress: WideString read Get_CcAddress;
    property BccAddress: WideString read Get_BccAddress;
    property ImapFlags: WideString read Get_ImapFlags;
    property ImapUID: Integer read Get_ImapUID;
    property ImapSequenceNumber: Integer read Get_ImapSequenceNumber write Set_ImapSequenceNumber;
  end;

// *********************************************************************//
// DispIntf:  IMessageDisp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {CC87528F-D4BF-4BFE-8DF7-9BFB57D33810}
// *********************************************************************//
  IMessageDisp = dispinterface
    ['{CC87528F-D4BF-4BFE-8DF7-9BFB57D33810}']
    property LastError: Integer readonly dispid 1;
    property FromName: WideString dispid 50;
    property FromAddress: WideString dispid 51;
    property ReplyAddress: WideString dispid 52;
    property ReadReceiptAddress: WideString dispid 53;
    property Organization: WideString dispid 54;
    property Subject: WideString dispid 55;
    property BodyPlainText: WideString dispid 56;
    property BodyHtml: WideString dispid 57;
    property Encoding: Integer dispid 58;
    property Priority: Integer dispid 59;
    property ID: Integer readonly dispid 70;
    property MessageSource: WideString readonly dispid 71;
    property MessageHeader: WideString readonly dispid 72;
    property Size: Integer readonly dispid 73;
    property Date: WideString readonly dispid 74;
    property ToAddress: WideString readonly dispid 75;
    property CcAddress: WideString readonly dispid 76;
    property BccAddress: WideString readonly dispid 77;
    property ImapFlags: WideString readonly dispid 80;
    property ImapUID: Integer readonly dispid 81;
    property ImapSequenceNumber: Integer dispid 82;
    procedure Clear; dispid 100;
    function GetErrorDescription(lError: Integer): WideString; dispid 101;
    procedure AddTo(const EmailAddress: WideString; const DisplayName: WideString); dispid 200;
    procedure AddCc(const EmailAddress: WideString; const DisplayName: WideString); dispid 201;
    procedure AddBcc(const EmailAddress: WideString; const DisplayName: WideString); dispid 202;
    function CountAttachments: Integer; dispid 300;
    function GetAttachmentName(ID: Integer): WideString; dispid 301;
    function GetAttachmentSize(ID: Integer): Integer; dispid 302;
    procedure AddAttachment(const FileName: WideString); dispid 303;
    procedure SaveAttachment(ID: Integer; const SaveAsFile: WideString); dispid 304;
    function ImapHasFlag(const Flag: WideString): WordBool; dispid 305;
    procedure LoadMIME(const MimeFile: WideString); dispid 310;
    procedure SaveMIME(const MimeFile: WideString); dispid 311;
    procedure Encode; dispid 320;
    procedure Decode; dispid 321;
    function GetHeaderValue(const Name: WideString): WideString; dispid 330;
    procedure AddHeader(const Name: WideString; const Value: WideString); dispid 331;
  end;

// *********************************************************************//
// Interface: ISmtp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {FE73AE95-A7C6-4E98-8AF2-CAB94AAE743A}
// *********************************************************************//
  ISmtp = interface(IDispatch)
    ['{FE73AE95-A7C6-4E98-8AF2-CAB94AAE743A}']
    function Get_Version: WideString; safecall;
    function Get_Build: WideString; safecall;
    function Get_Module: WideString; safecall;
    function Get_LicenseStatus: WideString; safecall;
    function Get_LicenseKey: WideString; safecall;
    procedure Set_LicenseKey(const LicenseKey: WideString); safecall;
    procedure SaveLicenseKey; safecall;
    function Get_LogFile: WideString; safecall;
    procedure Set_LogFile(const LogFile: WideString); safecall;
    function Get_ActivityFile: WideString; safecall;
    procedure Set_ActivityFile(const ActivityFile: WideString); safecall;
    procedure Sleep(Ms: Integer); safecall;
    procedure Clear; safecall;
    function Get_LastError: Integer; safecall;
    function GetErrorDescription(ErrorCode: Integer): WideString; safecall;
    function Get_TimeoutConnect: Integer; safecall;
    procedure Set_TimeoutConnect(TimoutMs: Integer); safecall;
    function Get_TimeoutAuthentication: Integer; safecall;
    procedure Set_TimeoutAuthentication(TimoutMs: Integer); safecall;
    function Get_TimeoutCommand: Integer; safecall;
    procedure Set_TimeoutCommand(TimoutMs: Integer); safecall;
    function Get_TimeoutData: Integer; safecall;
    procedure Set_TimeoutData(TimoutMs: Integer); safecall;
    function Get_HostPort: Integer; safecall;
    procedure Set_HostPort(HostPort: Integer); safecall;
    function Get_Authentication: Integer; safecall;
    procedure Set_Authentication(Authentication: Integer); safecall;
    function Get_UseStartTls: WordBool; safecall;
    procedure Set_UseStartTls(UseStartTls: WordBool); safecall;
    function Get_IpVersion: Integer; safecall;
    procedure Set_IpVersion(IpVersion: Integer); safecall;
    function Get_LastSmtpResponse: WideString; safecall;
    procedure SetSecure(Port: Integer); safecall;
    procedure Connect(const Host: WideString; const Account: WideString; const Password: WideString); safecall;
    procedure Disconnect; safecall;
    procedure Send(const Message: IMessage); safecall;
    property Version: WideString read Get_Version;
    property Build: WideString read Get_Build;
    property Module: WideString read Get_Module;
    property LicenseStatus: WideString read Get_LicenseStatus;
    property LicenseKey: WideString read Get_LicenseKey write Set_LicenseKey;
    property LogFile: WideString read Get_LogFile write Set_LogFile;
    property ActivityFile: WideString read Get_ActivityFile write Set_ActivityFile;
    property LastError: Integer read Get_LastError;
    property TimeoutConnect: Integer read Get_TimeoutConnect write Set_TimeoutConnect;
    property TimeoutAuthentication: Integer read Get_TimeoutAuthentication write Set_TimeoutAuthentication;
    property TimeoutCommand: Integer read Get_TimeoutCommand write Set_TimeoutCommand;
    property TimeoutData: Integer read Get_TimeoutData write Set_TimeoutData;
    property HostPort: Integer read Get_HostPort write Set_HostPort;
    property Authentication: Integer read Get_Authentication write Set_Authentication;
    property UseStartTls: WordBool read Get_UseStartTls write Set_UseStartTls;
    property IpVersion: Integer read Get_IpVersion write Set_IpVersion;
    property LastSmtpResponse: WideString read Get_LastSmtpResponse;
  end;

// *********************************************************************//
// DispIntf:  ISmtpDisp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {FE73AE95-A7C6-4E98-8AF2-CAB94AAE743A}
// *********************************************************************//
  ISmtpDisp = dispinterface
    ['{FE73AE95-A7C6-4E98-8AF2-CAB94AAE743A}']
    property Version: WideString readonly dispid 1;
    property Build: WideString readonly dispid 2;
    property Module: WideString readonly dispid 3;
    property LicenseStatus: WideString readonly dispid 100;
    property LicenseKey: WideString dispid 101;
    procedure SaveLicenseKey; dispid 102;
    property LogFile: WideString dispid 201;
    property ActivityFile: WideString dispid 202;
    procedure Sleep(Ms: Integer); dispid 300;
    procedure Clear; dispid 301;
    property LastError: Integer readonly dispid 400;
    function GetErrorDescription(ErrorCode: Integer): WideString; dispid 401;
    property TimeoutConnect: Integer dispid 500;
    property TimeoutAuthentication: Integer dispid 510;
    property TimeoutCommand: Integer dispid 520;
    property TimeoutData: Integer dispid 530;
    property HostPort: Integer dispid 600;
    property Authentication: Integer dispid 610;
    property UseStartTls: WordBool dispid 620;
    property IpVersion: Integer dispid 640;
    property LastSmtpResponse: WideString readonly dispid 700;
    procedure SetSecure(Port: Integer); dispid 800;
    procedure Connect(const Host: WideString; const Account: WideString; const Password: WideString); dispid 810;
    procedure Disconnect; dispid 820;
    procedure Send(const Message: IMessage); dispid 830;
  end;

// *********************************************************************//
// Interface: IPop3
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {7D24A1B3-4808-4208-9A9F-2A281256744A}
// *********************************************************************//
  IPop3 = interface(IDispatch)
    ['{7D24A1B3-4808-4208-9A9F-2A281256744A}']
    function Get_Version: WideString; safecall;
    function Get_Build: WideString; safecall;
    function Get_Module: WideString; safecall;
    function Get_LicenseStatus: WideString; safecall;
    function Get_LicenseKey: WideString; safecall;
    procedure Set_LicenseKey(const LicenseKey: WideString); safecall;
    procedure SaveLicenseKey; safecall;
    function Get_LogFile: WideString; safecall;
    procedure Set_LogFile(const LogFile: WideString); safecall;
    function Get_ActivityFile: WideString; safecall;
    procedure Set_ActivityFile(const ActivityFile: WideString); safecall;
    procedure Sleep(Ms: Integer); safecall;
    procedure Clear; safecall;
    function Get_LastError: Integer; safecall;
    function GetErrorDescription(ErrorCode: Integer): WideString; safecall;
    function Get_TimeoutConnect: Integer; safecall;
    procedure Set_TimeoutConnect(TimoutMs: Integer); safecall;
    function Get_TimeoutAuthentication: Integer; safecall;
    procedure Set_TimeoutAuthentication(TimoutMs: Integer); safecall;
    function Get_TimeoutCommand: Integer; safecall;
    procedure Set_TimeoutCommand(TimoutMs: Integer); safecall;
    function Get_TimeoutData: Integer; safecall;
    procedure Set_TimeoutData(TimoutMs: Integer); safecall;
    function Get_HostPort: Integer; safecall;
    procedure Set_HostPort(HostPort: Integer); safecall;
    function Get_Authentication: Integer; safecall;
    procedure Set_Authentication(Authentication: Integer); safecall;
    function Get_IpVersion: Integer; safecall;
    procedure Set_IpVersion(IpVersion: Integer); safecall;
    function Get_LastPop3Response: WideString; safecall;
    procedure SetSecure(Port: Integer); safecall;
    procedure Connect(const Host: WideString; const Account: WideString; const Password: WideString); safecall;
    procedure Disconnect; safecall;
    function IsConnected: WordBool; safecall;
    function CountMessages: Integer; safecall;
    function GetEmailHeader(ID: Integer): IMessage; safecall;
    function GetEmailMessage(lID: Integer): IMessage; safecall;
    procedure DeleteMessage(ID: Integer); safecall;
    property Version: WideString read Get_Version;
    property Build: WideString read Get_Build;
    property Module: WideString read Get_Module;
    property LicenseStatus: WideString read Get_LicenseStatus;
    property LicenseKey: WideString read Get_LicenseKey write Set_LicenseKey;
    property LogFile: WideString read Get_LogFile write Set_LogFile;
    property ActivityFile: WideString read Get_ActivityFile write Set_ActivityFile;
    property LastError: Integer read Get_LastError;
    property TimeoutConnect: Integer read Get_TimeoutConnect write Set_TimeoutConnect;
    property TimeoutAuthentication: Integer read Get_TimeoutAuthentication write Set_TimeoutAuthentication;
    property TimeoutCommand: Integer read Get_TimeoutCommand write Set_TimeoutCommand;
    property TimeoutData: Integer read Get_TimeoutData write Set_TimeoutData;
    property HostPort: Integer read Get_HostPort write Set_HostPort;
    property Authentication: Integer read Get_Authentication write Set_Authentication;
    property IpVersion: Integer read Get_IpVersion write Set_IpVersion;
    property LastPop3Response: WideString read Get_LastPop3Response;
  end;

// *********************************************************************//
// DispIntf:  IPop3Disp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {7D24A1B3-4808-4208-9A9F-2A281256744A}
// *********************************************************************//
  IPop3Disp = dispinterface
    ['{7D24A1B3-4808-4208-9A9F-2A281256744A}']
    property Version: WideString readonly dispid 1;
    property Build: WideString readonly dispid 2;
    property Module: WideString readonly dispid 3;
    property LicenseStatus: WideString readonly dispid 100;
    property LicenseKey: WideString dispid 101;
    procedure SaveLicenseKey; dispid 102;
    property LogFile: WideString dispid 201;
    property ActivityFile: WideString dispid 202;
    procedure Sleep(Ms: Integer); dispid 300;
    procedure Clear; dispid 301;
    property LastError: Integer readonly dispid 400;
    function GetErrorDescription(ErrorCode: Integer): WideString; dispid 401;
    property TimeoutConnect: Integer dispid 500;
    property TimeoutAuthentication: Integer dispid 510;
    property TimeoutCommand: Integer dispid 520;
    property TimeoutData: Integer dispid 530;
    property HostPort: Integer dispid 600;
    property Authentication: Integer dispid 610;
    property IpVersion: Integer dispid 640;
    property LastPop3Response: WideString readonly dispid 700;
    procedure SetSecure(Port: Integer); dispid 800;
    procedure Connect(const Host: WideString; const Account: WideString; const Password: WideString); dispid 810;
    procedure Disconnect; dispid 820;
    function IsConnected: WordBool; dispid 830;
    function CountMessages: Integer; dispid 900;
    function GetEmailHeader(ID: Integer): IMessage; dispid 910;
    function GetEmailMessage(lID: Integer): IMessage; dispid 920;
    procedure DeleteMessage(ID: Integer); dispid 930;
  end;

// *********************************************************************//
// Interface: IImapFetchData
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {E867B037-8B16-4C91-B4F3-91A5A5B9032F}
// *********************************************************************//
  IImapFetchData = interface(IDispatch)
    ['{E867B037-8B16-4C91-B4F3-91A5A5B9032F}']
    function Get_IsTopLevel: WordBool; safecall;
    function Get_Type_: Integer; safecall;
    function Get_Value: WideString; safecall;
    function Get_ValueAsInt: Integer; safecall;
    function Get_Text: WideString; safecall;
    function GetSubDataCount: Integer; safecall;
    function GetSubData(lIdx: Integer): IImapFetchData; safecall;
    function GetSubDataByName(const Val: WideString): IImapFetchData; safecall;
    function ContainsValue(const Val: WideString): WordBool; safecall;
    function ContainsIntValue(Val: Integer): WordBool; safecall;
    function Get_LastError: Integer; safecall;
    function GetErrorDescription(ErrorCode: Integer): WideString; safecall;
    property IsTopLevel: WordBool read Get_IsTopLevel;
    property Type_: Integer read Get_Type_;
    property Value: WideString read Get_Value;
    property ValueAsInt: Integer read Get_ValueAsInt;
    property Text: WideString read Get_Text;
    property LastError: Integer read Get_LastError;
  end;

// *********************************************************************//
// DispIntf:  IImapFetchDataDisp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {E867B037-8B16-4C91-B4F3-91A5A5B9032F}
// *********************************************************************//
  IImapFetchDataDisp = dispinterface
    ['{E867B037-8B16-4C91-B4F3-91A5A5B9032F}']
    property IsTopLevel: WordBool readonly dispid 10;
    property Type_: Integer readonly dispid 20;
    property Value: WideString readonly dispid 30;
    property ValueAsInt: Integer readonly dispid 40;
    property Text: WideString readonly dispid 50;
    function GetSubDataCount: Integer; dispid 100;
    function GetSubData(lIdx: Integer): IImapFetchData; dispid 110;
    function GetSubDataByName(const Val: WideString): IImapFetchData; dispid 120;
    function ContainsValue(const Val: WideString): WordBool; dispid 140;
    function ContainsIntValue(Val: Integer): WordBool; dispid 150;
    property LastError: Integer readonly dispid 400;
    function GetErrorDescription(ErrorCode: Integer): WideString; dispid 401;
  end;

// *********************************************************************//
// Interface: IImap
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {2F17D77B-374D-431E-8772-8FD1B20D1516}
// *********************************************************************//
  IImap = interface(IDispatch)
    ['{2F17D77B-374D-431E-8772-8FD1B20D1516}']
    function Get_Version: WideString; safecall;
    function Get_Build: WideString; safecall;
    function Get_Module: WideString; safecall;
    function Get_LicenseStatus: WideString; safecall;
    function Get_LicenseKey: WideString; safecall;
    procedure Set_LicenseKey(const LicenseKey: WideString); safecall;
    procedure SaveLicenseKey; safecall;
    function Get_LogFile: WideString; safecall;
    procedure Set_LogFile(const LogFile: WideString); safecall;
    function Get_ActivityFile: WideString; safecall;
    procedure Set_ActivityFile(const ActivityFile: WideString); safecall;
    procedure Sleep(Ms: Integer); safecall;
    procedure Clear; safecall;
    function Get_LastError: Integer; safecall;
    function GetErrorDescription(ErrorCode: Integer): WideString; safecall;
    function Get_TimeoutConnect: Integer; safecall;
    procedure Set_TimeoutConnect(TimoutMs: Integer); safecall;
    function Get_TimeoutCommand: Integer; safecall;
    procedure Set_TimeoutCommand(TimoutMs: Integer); safecall;
    function Get_TimeoutAppend: Integer; safecall;
    procedure Set_TimeoutAppend(TimoutMs: Integer); safecall;
    function Get_FetchMaxNumItemsAtOnce: Integer; safecall;
    procedure Set_FetchMaxNumItemsAtOnce(pVal: Integer); safecall;
    function Get_MaximumPendingFetchData: Integer; safecall;
    procedure Set_MaximumPendingFetchData(pVal: Integer); safecall;
    function Get_MaximumPendingExpunged: Integer; safecall;
    procedure Set_MaximumPendingExpunged(pVal: Integer); safecall;
    function Get_UseSequenceNumForStoreAndCopy: WordBool; safecall;
    procedure Set_UseSequenceNumForStoreAndCopy(pVal: WordBool); safecall;
    function Get_HostPort: Integer; safecall;
    procedure Set_HostPort(HostPort: Integer); safecall;
    function Get_Authentication: Integer; safecall;
    procedure Set_Authentication(Authentication: Integer); safecall;
    function Get_UseStartTls: WordBool; safecall;
    procedure Set_UseStartTls(UseStartTls: WordBool); safecall;
    function Get_AutoClose: WordBool; safecall;
    procedure Set_AutoClose(AutoClose: WordBool); safecall;
    function Get_IpVersion: Integer; safecall;
    procedure Set_IpVersion(IpVersion: Integer); safecall;
    function Get_Secure: WordBool; safecall;
    procedure Set_Secure(pVal: WordBool); safecall;
    function Get_LastImapResponse: WideString; safecall;
    function Get_HierarchySeparator: WideString; safecall;
    function Get_Capabilities: WideString; safecall;
    function Get_Exists: Integer; safecall;
    function Get_Recent: Integer; safecall;
    function Get_Unseen: Integer; safecall;
    function Get_UidNext: Integer; safecall;
    procedure SetSecure(Port: Integer); safecall;
    procedure Connect(const Host: WideString; const Account: WideString; const Password: WideString); safecall;
    procedure Disconnect; safecall;
    function IsConnected: WordBool; safecall;
    procedure Select(const Mailbox: WideString); safecall;
    procedure Examine(const Mailbox: WideString); safecall;
    procedure Status(const Mailbox: WideString); safecall;
    procedure Close; safecall;
    procedure Create(const MailboxName: WideString); safecall;
    procedure Delete(const MailboxName: WideString); safecall;
    procedure Rename(const Source: WideString; const Target: WideString); safecall;
    procedure Subscribe(const MailboxName: WideString); safecall;
    procedure Unsubscribe(const MailboxName: WideString); safecall;
    procedure Copy(const IdSet: WideString; const Mailbox: WideString); safecall;
    procedure Store(const IdSet: WideString; const Flags: WideString; Option: Integer); safecall;
    procedure Noop; safecall;
    procedure Check; safecall;
    procedure Expunge; safecall;
    function GetPendingExpunged: Integer; safecall;
    function GetPendingFetchData: IImapFetchData; safecall;
    procedure ListSubscribed(const Reference: WideString; const Mailbox: WideString); safecall;
    procedure List(const Reference: WideString; const Mailbox: WideString); safecall;
    function ListCount: Integer; safecall;
    function ListAttributes(Index: Integer): WideString; safecall;
    function ListHasAttribute(Index: Integer; var Attribute: WideString): WordBool; safecall;
    function ListName(Index: Integer): WideString; safecall;
    function FetchFirstEmail(const Criteria: WideString): IMessage; safecall;
    function FetchNextEmail: IMessage; safecall;
    function FetchFirstEmailHeader(const Criteria: WideString): IMessage; safecall;
    function FetchNextEmailHeader: IMessage; safecall;
    function FetchFirst(const Criteria: WideString; const DataItems: WideString): IImapFetchData; safecall;
    function FetchNext: IImapFetchData; safecall;
    procedure Append(const Mailbox: WideString; const pVal: IMessage; const Flags: WideString; 
                     const DateTime: WideString); safecall;
    function HasCapability(const Capability: WideString): WordBool; safecall;
    function FormatDate(Year: Integer; Month: Integer; Day: Integer): WideString; safecall;
    function FormatTime(Hour: Integer; Minute: Integer; Second: Integer; OffsetMinute: Integer): WideString; safecall;
    property Version: WideString read Get_Version;
    property Build: WideString read Get_Build;
    property Module: WideString read Get_Module;
    property LicenseStatus: WideString read Get_LicenseStatus;
    property LicenseKey: WideString read Get_LicenseKey write Set_LicenseKey;
    property LogFile: WideString read Get_LogFile write Set_LogFile;
    property ActivityFile: WideString read Get_ActivityFile write Set_ActivityFile;
    property LastError: Integer read Get_LastError;
    property TimeoutConnect: Integer read Get_TimeoutConnect write Set_TimeoutConnect;
    property TimeoutCommand: Integer read Get_TimeoutCommand write Set_TimeoutCommand;
    property TimeoutAppend: Integer read Get_TimeoutAppend write Set_TimeoutAppend;
    property FetchMaxNumItemsAtOnce: Integer read Get_FetchMaxNumItemsAtOnce write Set_FetchMaxNumItemsAtOnce;
    property MaximumPendingFetchData: Integer read Get_MaximumPendingFetchData write Set_MaximumPendingFetchData;
    property MaximumPendingExpunged: Integer read Get_MaximumPendingExpunged write Set_MaximumPendingExpunged;
    property UseSequenceNumForStoreAndCopy: WordBool read Get_UseSequenceNumForStoreAndCopy write Set_UseSequenceNumForStoreAndCopy;
    property HostPort: Integer read Get_HostPort write Set_HostPort;
    property Authentication: Integer read Get_Authentication write Set_Authentication;
    property UseStartTls: WordBool read Get_UseStartTls write Set_UseStartTls;
    property AutoClose: WordBool read Get_AutoClose write Set_AutoClose;
    property IpVersion: Integer read Get_IpVersion write Set_IpVersion;
    property Secure: WordBool read Get_Secure write Set_Secure;
    property LastImapResponse: WideString read Get_LastImapResponse;
    property HierarchySeparator: WideString read Get_HierarchySeparator;
    property Capabilities: WideString read Get_Capabilities;
    property Exists: Integer read Get_Exists;
    property Recent: Integer read Get_Recent;
    property Unseen: Integer read Get_Unseen;
    property UidNext: Integer read Get_UidNext;
  end;

// *********************************************************************//
// DispIntf:  IImapDisp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {2F17D77B-374D-431E-8772-8FD1B20D1516}
// *********************************************************************//
  IImapDisp = dispinterface
    ['{2F17D77B-374D-431E-8772-8FD1B20D1516}']
    property Version: WideString readonly dispid 1;
    property Build: WideString readonly dispid 2;
    property Module: WideString readonly dispid 3;
    property LicenseStatus: WideString readonly dispid 100;
    property LicenseKey: WideString dispid 101;
    procedure SaveLicenseKey; dispid 102;
    property LogFile: WideString dispid 201;
    property ActivityFile: WideString dispid 202;
    procedure Sleep(Ms: Integer); dispid 300;
    procedure Clear; dispid 301;
    property LastError: Integer readonly dispid 400;
    function GetErrorDescription(ErrorCode: Integer): WideString; dispid 401;
    property TimeoutConnect: Integer dispid 500;
    property TimeoutCommand: Integer dispid 520;
    property TimeoutAppend: Integer dispid 530;
    property FetchMaxNumItemsAtOnce: Integer dispid 540;
    property MaximumPendingFetchData: Integer dispid 550;
    property MaximumPendingExpunged: Integer dispid 560;
    property UseSequenceNumForStoreAndCopy: WordBool dispid 570;
    property HostPort: Integer dispid 600;
    property Authentication: Integer dispid 610;
    property UseStartTls: WordBool dispid 620;
    property AutoClose: WordBool dispid 630;
    property IpVersion: Integer dispid 640;
    property Secure: WordBool dispid 650;
    property LastImapResponse: WideString readonly dispid 700;
    property HierarchySeparator: WideString readonly dispid 710;
    property Capabilities: WideString readonly dispid 720;
    property Exists: Integer readonly dispid 730;
    property Recent: Integer readonly dispid 740;
    property Unseen: Integer readonly dispid 750;
    property UidNext: Integer readonly dispid 760;
    procedure SetSecure(Port: Integer); dispid 800;
    procedure Connect(const Host: WideString; const Account: WideString; const Password: WideString); dispid 810;
    procedure Disconnect; dispid 820;
    function IsConnected: WordBool; dispid 830;
    procedure Select(const Mailbox: WideString); dispid 900;
    procedure Examine(const Mailbox: WideString); dispid 910;
    procedure Status(const Mailbox: WideString); dispid 920;
    procedure Close; dispid 930;
    procedure Create(const MailboxName: WideString); dispid 940;
    procedure Delete(const MailboxName: WideString); dispid 950;
    procedure Rename(const Source: WideString; const Target: WideString); dispid 960;
    procedure Subscribe(const MailboxName: WideString); dispid 970;
    procedure Unsubscribe(const MailboxName: WideString); dispid 980;
    procedure Copy(const IdSet: WideString; const Mailbox: WideString); dispid 990;
    procedure Store(const IdSet: WideString; const Flags: WideString; Option: Integer); dispid 1000;
    procedure Noop; dispid 1010;
    procedure Check; dispid 1020;
    procedure Expunge; dispid 1030;
    function GetPendingExpunged: Integer; dispid 1040;
    function GetPendingFetchData: IImapFetchData; dispid 1050;
    procedure ListSubscribed(const Reference: WideString; const Mailbox: WideString); dispid 1100;
    procedure List(const Reference: WideString; const Mailbox: WideString); dispid 1110;
    function ListCount: Integer; dispid 1120;
    function ListAttributes(Index: Integer): WideString; dispid 1130;
    function ListHasAttribute(Index: Integer; var Attribute: WideString): WordBool; dispid 1140;
    function ListName(Index: Integer): WideString; dispid 1150;
    function FetchFirstEmail(const Criteria: WideString): IMessage; dispid 1210;
    function FetchNextEmail: IMessage; dispid 1220;
    function FetchFirstEmailHeader(const Criteria: WideString): IMessage; dispid 1230;
    function FetchNextEmailHeader: IMessage; dispid 1240;
    function FetchFirst(const Criteria: WideString; const DataItems: WideString): IImapFetchData; dispid 1250;
    function FetchNext: IImapFetchData; dispid 1260;
    procedure Append(const Mailbox: WideString; const pVal: IMessage; const Flags: WideString; 
                     const DateTime: WideString); dispid 1270;
    function HasCapability(const Capability: WideString): WordBool; dispid 1510;
    function FormatDate(Year: Integer; Month: Integer; Day: Integer): WideString; dispid 1520;
    function FormatTime(Hour: Integer; Minute: Integer; Second: Integer; OffsetMinute: Integer): WideString; dispid 1530;
  end;

// *********************************************************************//
// Interface: IConstants
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {AD78421F-9ECA-4BFD-81E6-94712D62DEFD}
// *********************************************************************//
  IConstants = interface(IDispatch)
    ['{AD78421F-9ECA-4BFD-81E6-94712D62DEFD}']
    function Get_EMAIL_MESSAGE_PRIORITY_HIGHEST: Integer; safecall;
    function Get_EMAIL_MESSAGE_PRIORITY_HIGH: Integer; safecall;
    function Get_EMAIL_MESSAGE_PRIORITY_MEDIUM: Integer; safecall;
    function Get_EMAIL_MESSAGE_PRIORITY_LOW: Integer; safecall;
    function Get_EMAIL_MESSAGE_PRIORITY_LOWEST: Integer; safecall;
    function Get_EMAIL_MESSAGE_ENCODING_DEFAULT: Integer; safecall;
    function Get_EMAIL_MESSAGE_ENCODING_THAI: Integer; safecall;
    function Get_EMAIL_MESSAGE_ENCODING_JAPANESE: Integer; safecall;
    function Get_EMAIL_MESSAGE_ENCODING_CHINESE_SIMP: Integer; safecall;
    function Get_EMAIL_MESSAGE_ENCODING_KOREAN: Integer; safecall;
    function Get_EMAIL_MESSAGE_ENCODING_CHINESE_TRAD: Integer; safecall;
    function Get_EMAIL_MESSAGE_ENCODING_CENTRALEUROPE: Integer; safecall;
    function Get_EMAIL_MESSAGE_ENCODING_RUSSIAN: Integer; safecall;
    function Get_EMAIL_MESSAGE_ENCODING_WESTERN: Integer; safecall;
    function Get_EMAIL_MESSAGE_ENCODING_GREEK: Integer; safecall;
    function Get_EMAIL_MESSAGE_ENCODING_TURKISH: Integer; safecall;
    function Get_EMAIL_MESSAGE_ENCODING_HEBREW: Integer; safecall;
    function Get_EMAIL_MESSAGE_ENCODING_ARABIC: Integer; safecall;
    function Get_EMAIL_MESSAGE_ENCODING_BALTIC: Integer; safecall;
    function Get_EMAIL_MESSAGE_ENCODING_VIETNAMESE: Integer; safecall;
    function Get_EMAIL_MESSAGE_ENCODING_UTF7: Integer; safecall;
    function Get_EMAIL_MESSAGE_ENCODING_UTF8: Integer; safecall;
    function Get_SMTP_AUTH_AUTO: Integer; safecall;
    function Get_SMTP_AUTH_PLAIN: Integer; safecall;
    function Get_SMTP_AUTH_LOGIN: Integer; safecall;
    function Get_SMTP_AUTH_MD5CRAM: Integer; safecall;
    function Get_POP3_AUTH_PLAIN: Integer; safecall;
    function Get_POP3_AUTH_APOP: Integer; safecall;
    function Get_POP3_AUTH_AUTO: Integer; safecall;
    function Get_IMAP_SK_ALL: WideString; safecall;
    function Get_IMAP_SK_ANSWERED: WideString; safecall;
    function Get_IMAP_SK_BCC: WideString; safecall;
    function Get_IMAP_SK_BEFORE: WideString; safecall;
    function Get_IMAP_SK_BODY: WideString; safecall;
    function Get_IMAP_SK_CC: WideString; safecall;
    function Get_IMAP_SK_DELETED: WideString; safecall;
    function Get_IMAP_SK_DRAFT: WideString; safecall;
    function Get_IMAP_SK_FLAGGED: WideString; safecall;
    function Get_IMAP_SK_FROM: WideString; safecall;
    function Get_IMAP_SK_HEADER: WideString; safecall;
    function Get_IMAP_SK_KEYWORD: WideString; safecall;
    function Get_IMAP_SK_LARGER: WideString; safecall;
    function Get_IMAP_SK_NEW: WideString; safecall;
    function Get_IMAP_SK_NOT: WideString; safecall;
    function Get_IMAP_SK_OLD: WideString; safecall;
    function Get_IMAP_SK_ON: WideString; safecall;
    function Get_IMAP_SK_OR: WideString; safecall;
    function Get_IMAP_SK_RECENT: WideString; safecall;
    function Get_IMAP_SK_SEEN: WideString; safecall;
    function Get_IMAP_SK_SENTBEFORE: WideString; safecall;
    function Get_IMAP_SK_SENTON: WideString; safecall;
    function Get_IMAP_SK_SENTSINCE: WideString; safecall;
    function Get_IMAP_SK_SINCE: WideString; safecall;
    function Get_IMAP_SK_SMALLER: WideString; safecall;
    function Get_IMAP_SK_SUBJECT: WideString; safecall;
    function Get_IMAP_SK_TEXT: WideString; safecall;
    function Get_IMAP_SK_TO: WideString; safecall;
    function Get_IMAP_SK_UID: WideString; safecall;
    function Get_IMAP_SK_UNANSWERED: WideString; safecall;
    function Get_IMAP_SK_UNDELETED: WideString; safecall;
    function Get_IMAP_SK_UNDRAFT: WideString; safecall;
    function Get_IMAP_SK_UNFLAGGED: WideString; safecall;
    function Get_IMAP_SK_UNKEYWORD: WideString; safecall;
    function Get_IMAP_SK_UNSEEN: WideString; safecall;
    function Get_IMAP_FM_ALL: WideString; safecall;
    function Get_IMAP_FM_FAST: WideString; safecall;
    function Get_IMAP_FM_FULL: WideString; safecall;
    function Get_IMAP_FDI_BODY: WideString; safecall;
    function Get_IMAP_FDI_HEADER: WideString; safecall;
    function Get_IMAP_FDI_HEADER_FIELDS: WideString; safecall;
    function Get_IMAP_FDI_HEADER_FIELDS_NOT: WideString; safecall;
    function Get_IMAP_FDI_MIME: WideString; safecall;
    function Get_IMAP_FDI_TEXT: WideString; safecall;
    function Get_IMAP_FDI_BODY_PEEK: WideString; safecall;
    function Get_IMAP_FDI_BODYSTRUCTURE: WideString; safecall;
    function Get_IMAP_FDI_ENVELOPE: WideString; safecall;
    function Get_IMAP_FDI_FLAGS: WideString; safecall;
    function Get_IMAP_FDI_INTERNALDATE: WideString; safecall;
    function Get_IMAP_FDI_RFC822: WideString; safecall;
    function Get_IMAP_FDI_RFC822_HEADER: WideString; safecall;
    function Get_IMAP_FDI_RFC822_SIZE: WideString; safecall;
    function Get_IMAP_FDI_RFC822_TEXT: WideString; safecall;
    function Get_IMAP_FDI_UID: WideString; safecall;
    function Get_IMAP_MBX_FLAG_NOINFERIORS: WideString; safecall;
    function Get_IMAP_MBX_FLAG_NOSELECT: WideString; safecall;
    function Get_IMAP_MBX_FLAG_MARKED: WideString; safecall;
    function Get_IMAP_MBX_FLAG_UNMARKED: WideString; safecall;
    function Get_IMAP_MBX_FLAG_ALL: WideString; safecall;
    function Get_IMAP_MBX_FLAG_ARCHIVE: WideString; safecall;
    function Get_IMAP_MBX_FLAG_DRAFTS: WideString; safecall;
    function Get_IMAP_MBX_FLAG_FLAGGED: WideString; safecall;
    function Get_IMAP_MBX_FLAG_JUNK: WideString; safecall;
    function Get_IMAP_MBX_FLAG_SENT: WideString; safecall;
    function Get_IMAP_MBX_FLAG_TRASH: WideString; safecall;
    function Get_IMAP_MBX_FLAG_HASNOCHILDREN: WideString; safecall;
    function Get_IMAP_MBX_FLAG_HASCHILDREN: WideString; safecall;
    function Get_IMAP_MAIL_FLAG_SEEN: WideString; safecall;
    function Get_IMAP_MAIL_FLAG_ANSWERED: WideString; safecall;
    function Get_IMAP_MAIL_FLAG_FLAGGED: WideString; safecall;
    function Get_IMAP_MAIL_FLAG_DELETED: WideString; safecall;
    function Get_IMAP_MAIL_FLAG_DRAFT: WideString; safecall;
    function Get_IMAP_MAIL_FLAG_RECENT: WideString; safecall;
    function Get_IMAP_FD_TYPE_INTEGER: Integer; safecall;
    function Get_IMAP_FD_TYPE_STRING: Integer; safecall;
    function Get_IMAP_FD_TYPE_STRING_LITERAL: Integer; safecall;
    function Get_IMAP_FD_TYPE_LIST: Integer; safecall;
    function Get_IMAP_FD_TYPE_ATOM: Integer; safecall;
    function Get_IMAP_FD_TYPE_NIL: Integer; safecall;
    function Get_IMAP_STO_SET: Integer; safecall;
    function Get_IMAP_STO_ADD: Integer; safecall;
    function Get_IMAP_STO_REMOVE: Integer; safecall;
    function Get_IMAP_STO_SILENT: Integer; safecall;
    function Get_IMAP_AUTH_AUTO: Integer; safecall;
    function Get_IMAP_AUTH_LOGIN: Integer; safecall;
    function Get_IMAP_AUTH_PLAIN: Integer; safecall;
    function Get_IPVERSION_4: Integer; safecall;
    function Get_IPVERSION_6: Integer; safecall;
    function Get_IPVERSION_6_4: Integer; safecall;
    function MessagePriorityToString(lVal: Integer): WideString; safecall;
    function MessageEncodingToString(lVal: Integer): WideString; safecall;
    function SmtpAuthToString(lVal: Integer): WideString; safecall;
    function Pop3AuthToString(lVal: Integer): WideString; safecall;
    function ImapAuthToString(lVal: Integer): WideString; safecall;
    function ImapFetchDataTypeToString(lVal: Integer): WideString; safecall;
    function ImapStoreOptionToString(lVal: Integer): WideString; safecall;
    property EMAIL_MESSAGE_PRIORITY_HIGHEST: Integer read Get_EMAIL_MESSAGE_PRIORITY_HIGHEST;
    property EMAIL_MESSAGE_PRIORITY_HIGH: Integer read Get_EMAIL_MESSAGE_PRIORITY_HIGH;
    property EMAIL_MESSAGE_PRIORITY_MEDIUM: Integer read Get_EMAIL_MESSAGE_PRIORITY_MEDIUM;
    property EMAIL_MESSAGE_PRIORITY_LOW: Integer read Get_EMAIL_MESSAGE_PRIORITY_LOW;
    property EMAIL_MESSAGE_PRIORITY_LOWEST: Integer read Get_EMAIL_MESSAGE_PRIORITY_LOWEST;
    property EMAIL_MESSAGE_ENCODING_DEFAULT: Integer read Get_EMAIL_MESSAGE_ENCODING_DEFAULT;
    property EMAIL_MESSAGE_ENCODING_THAI: Integer read Get_EMAIL_MESSAGE_ENCODING_THAI;
    property EMAIL_MESSAGE_ENCODING_JAPANESE: Integer read Get_EMAIL_MESSAGE_ENCODING_JAPANESE;
    property EMAIL_MESSAGE_ENCODING_CHINESE_SIMP: Integer read Get_EMAIL_MESSAGE_ENCODING_CHINESE_SIMP;
    property EMAIL_MESSAGE_ENCODING_KOREAN: Integer read Get_EMAIL_MESSAGE_ENCODING_KOREAN;
    property EMAIL_MESSAGE_ENCODING_CHINESE_TRAD: Integer read Get_EMAIL_MESSAGE_ENCODING_CHINESE_TRAD;
    property EMAIL_MESSAGE_ENCODING_CENTRALEUROPE: Integer read Get_EMAIL_MESSAGE_ENCODING_CENTRALEUROPE;
    property EMAIL_MESSAGE_ENCODING_RUSSIAN: Integer read Get_EMAIL_MESSAGE_ENCODING_RUSSIAN;
    property EMAIL_MESSAGE_ENCODING_WESTERN: Integer read Get_EMAIL_MESSAGE_ENCODING_WESTERN;
    property EMAIL_MESSAGE_ENCODING_GREEK: Integer read Get_EMAIL_MESSAGE_ENCODING_GREEK;
    property EMAIL_MESSAGE_ENCODING_TURKISH: Integer read Get_EMAIL_MESSAGE_ENCODING_TURKISH;
    property EMAIL_MESSAGE_ENCODING_HEBREW: Integer read Get_EMAIL_MESSAGE_ENCODING_HEBREW;
    property EMAIL_MESSAGE_ENCODING_ARABIC: Integer read Get_EMAIL_MESSAGE_ENCODING_ARABIC;
    property EMAIL_MESSAGE_ENCODING_BALTIC: Integer read Get_EMAIL_MESSAGE_ENCODING_BALTIC;
    property EMAIL_MESSAGE_ENCODING_VIETNAMESE: Integer read Get_EMAIL_MESSAGE_ENCODING_VIETNAMESE;
    property EMAIL_MESSAGE_ENCODING_UTF7: Integer read Get_EMAIL_MESSAGE_ENCODING_UTF7;
    property EMAIL_MESSAGE_ENCODING_UTF8: Integer read Get_EMAIL_MESSAGE_ENCODING_UTF8;
    property SMTP_AUTH_AUTO: Integer read Get_SMTP_AUTH_AUTO;
    property SMTP_AUTH_PLAIN: Integer read Get_SMTP_AUTH_PLAIN;
    property SMTP_AUTH_LOGIN: Integer read Get_SMTP_AUTH_LOGIN;
    property SMTP_AUTH_MD5CRAM: Integer read Get_SMTP_AUTH_MD5CRAM;
    property POP3_AUTH_PLAIN: Integer read Get_POP3_AUTH_PLAIN;
    property POP3_AUTH_APOP: Integer read Get_POP3_AUTH_APOP;
    property POP3_AUTH_AUTO: Integer read Get_POP3_AUTH_AUTO;
    property IMAP_SK_ALL: WideString read Get_IMAP_SK_ALL;
    property IMAP_SK_ANSWERED: WideString read Get_IMAP_SK_ANSWERED;
    property IMAP_SK_BCC: WideString read Get_IMAP_SK_BCC;
    property IMAP_SK_BEFORE: WideString read Get_IMAP_SK_BEFORE;
    property IMAP_SK_BODY: WideString read Get_IMAP_SK_BODY;
    property IMAP_SK_CC: WideString read Get_IMAP_SK_CC;
    property IMAP_SK_DELETED: WideString read Get_IMAP_SK_DELETED;
    property IMAP_SK_DRAFT: WideString read Get_IMAP_SK_DRAFT;
    property IMAP_SK_FLAGGED: WideString read Get_IMAP_SK_FLAGGED;
    property IMAP_SK_FROM: WideString read Get_IMAP_SK_FROM;
    property IMAP_SK_HEADER: WideString read Get_IMAP_SK_HEADER;
    property IMAP_SK_KEYWORD: WideString read Get_IMAP_SK_KEYWORD;
    property IMAP_SK_LARGER: WideString read Get_IMAP_SK_LARGER;
    property IMAP_SK_NEW: WideString read Get_IMAP_SK_NEW;
    property IMAP_SK_NOT: WideString read Get_IMAP_SK_NOT;
    property IMAP_SK_OLD: WideString read Get_IMAP_SK_OLD;
    property IMAP_SK_ON: WideString read Get_IMAP_SK_ON;
    property IMAP_SK_OR: WideString read Get_IMAP_SK_OR;
    property IMAP_SK_RECENT: WideString read Get_IMAP_SK_RECENT;
    property IMAP_SK_SEEN: WideString read Get_IMAP_SK_SEEN;
    property IMAP_SK_SENTBEFORE: WideString read Get_IMAP_SK_SENTBEFORE;
    property IMAP_SK_SENTON: WideString read Get_IMAP_SK_SENTON;
    property IMAP_SK_SENTSINCE: WideString read Get_IMAP_SK_SENTSINCE;
    property IMAP_SK_SINCE: WideString read Get_IMAP_SK_SINCE;
    property IMAP_SK_SMALLER: WideString read Get_IMAP_SK_SMALLER;
    property IMAP_SK_SUBJECT: WideString read Get_IMAP_SK_SUBJECT;
    property IMAP_SK_TEXT: WideString read Get_IMAP_SK_TEXT;
    property IMAP_SK_TO: WideString read Get_IMAP_SK_TO;
    property IMAP_SK_UID: WideString read Get_IMAP_SK_UID;
    property IMAP_SK_UNANSWERED: WideString read Get_IMAP_SK_UNANSWERED;
    property IMAP_SK_UNDELETED: WideString read Get_IMAP_SK_UNDELETED;
    property IMAP_SK_UNDRAFT: WideString read Get_IMAP_SK_UNDRAFT;
    property IMAP_SK_UNFLAGGED: WideString read Get_IMAP_SK_UNFLAGGED;
    property IMAP_SK_UNKEYWORD: WideString read Get_IMAP_SK_UNKEYWORD;
    property IMAP_SK_UNSEEN: WideString read Get_IMAP_SK_UNSEEN;
    property IMAP_FM_ALL: WideString read Get_IMAP_FM_ALL;
    property IMAP_FM_FAST: WideString read Get_IMAP_FM_FAST;
    property IMAP_FM_FULL: WideString read Get_IMAP_FM_FULL;
    property IMAP_FDI_BODY: WideString read Get_IMAP_FDI_BODY;
    property IMAP_FDI_HEADER: WideString read Get_IMAP_FDI_HEADER;
    property IMAP_FDI_HEADER_FIELDS: WideString read Get_IMAP_FDI_HEADER_FIELDS;
    property IMAP_FDI_HEADER_FIELDS_NOT: WideString read Get_IMAP_FDI_HEADER_FIELDS_NOT;
    property IMAP_FDI_MIME: WideString read Get_IMAP_FDI_MIME;
    property IMAP_FDI_TEXT: WideString read Get_IMAP_FDI_TEXT;
    property IMAP_FDI_BODY_PEEK: WideString read Get_IMAP_FDI_BODY_PEEK;
    property IMAP_FDI_BODYSTRUCTURE: WideString read Get_IMAP_FDI_BODYSTRUCTURE;
    property IMAP_FDI_ENVELOPE: WideString read Get_IMAP_FDI_ENVELOPE;
    property IMAP_FDI_FLAGS: WideString read Get_IMAP_FDI_FLAGS;
    property IMAP_FDI_INTERNALDATE: WideString read Get_IMAP_FDI_INTERNALDATE;
    property IMAP_FDI_RFC822: WideString read Get_IMAP_FDI_RFC822;
    property IMAP_FDI_RFC822_HEADER: WideString read Get_IMAP_FDI_RFC822_HEADER;
    property IMAP_FDI_RFC822_SIZE: WideString read Get_IMAP_FDI_RFC822_SIZE;
    property IMAP_FDI_RFC822_TEXT: WideString read Get_IMAP_FDI_RFC822_TEXT;
    property IMAP_FDI_UID: WideString read Get_IMAP_FDI_UID;
    property IMAP_MBX_FLAG_NOINFERIORS: WideString read Get_IMAP_MBX_FLAG_NOINFERIORS;
    property IMAP_MBX_FLAG_NOSELECT: WideString read Get_IMAP_MBX_FLAG_NOSELECT;
    property IMAP_MBX_FLAG_MARKED: WideString read Get_IMAP_MBX_FLAG_MARKED;
    property IMAP_MBX_FLAG_UNMARKED: WideString read Get_IMAP_MBX_FLAG_UNMARKED;
    property IMAP_MBX_FLAG_ALL: WideString read Get_IMAP_MBX_FLAG_ALL;
    property IMAP_MBX_FLAG_ARCHIVE: WideString read Get_IMAP_MBX_FLAG_ARCHIVE;
    property IMAP_MBX_FLAG_DRAFTS: WideString read Get_IMAP_MBX_FLAG_DRAFTS;
    property IMAP_MBX_FLAG_FLAGGED: WideString read Get_IMAP_MBX_FLAG_FLAGGED;
    property IMAP_MBX_FLAG_JUNK: WideString read Get_IMAP_MBX_FLAG_JUNK;
    property IMAP_MBX_FLAG_SENT: WideString read Get_IMAP_MBX_FLAG_SENT;
    property IMAP_MBX_FLAG_TRASH: WideString read Get_IMAP_MBX_FLAG_TRASH;
    property IMAP_MBX_FLAG_HASNOCHILDREN: WideString read Get_IMAP_MBX_FLAG_HASNOCHILDREN;
    property IMAP_MBX_FLAG_HASCHILDREN: WideString read Get_IMAP_MBX_FLAG_HASCHILDREN;
    property IMAP_MAIL_FLAG_SEEN: WideString read Get_IMAP_MAIL_FLAG_SEEN;
    property IMAP_MAIL_FLAG_ANSWERED: WideString read Get_IMAP_MAIL_FLAG_ANSWERED;
    property IMAP_MAIL_FLAG_FLAGGED: WideString read Get_IMAP_MAIL_FLAG_FLAGGED;
    property IMAP_MAIL_FLAG_DELETED: WideString read Get_IMAP_MAIL_FLAG_DELETED;
    property IMAP_MAIL_FLAG_DRAFT: WideString read Get_IMAP_MAIL_FLAG_DRAFT;
    property IMAP_MAIL_FLAG_RECENT: WideString read Get_IMAP_MAIL_FLAG_RECENT;
    property IMAP_FD_TYPE_INTEGER: Integer read Get_IMAP_FD_TYPE_INTEGER;
    property IMAP_FD_TYPE_STRING: Integer read Get_IMAP_FD_TYPE_STRING;
    property IMAP_FD_TYPE_STRING_LITERAL: Integer read Get_IMAP_FD_TYPE_STRING_LITERAL;
    property IMAP_FD_TYPE_LIST: Integer read Get_IMAP_FD_TYPE_LIST;
    property IMAP_FD_TYPE_ATOM: Integer read Get_IMAP_FD_TYPE_ATOM;
    property IMAP_FD_TYPE_NIL: Integer read Get_IMAP_FD_TYPE_NIL;
    property IMAP_STO_SET: Integer read Get_IMAP_STO_SET;
    property IMAP_STO_ADD: Integer read Get_IMAP_STO_ADD;
    property IMAP_STO_REMOVE: Integer read Get_IMAP_STO_REMOVE;
    property IMAP_STO_SILENT: Integer read Get_IMAP_STO_SILENT;
    property IMAP_AUTH_AUTO: Integer read Get_IMAP_AUTH_AUTO;
    property IMAP_AUTH_LOGIN: Integer read Get_IMAP_AUTH_LOGIN;
    property IMAP_AUTH_PLAIN: Integer read Get_IMAP_AUTH_PLAIN;
    property IPVERSION_4: Integer read Get_IPVERSION_4;
    property IPVERSION_6: Integer read Get_IPVERSION_6;
    property IPVERSION_6_4: Integer read Get_IPVERSION_6_4;
  end;

// *********************************************************************//
// DispIntf:  IConstantsDisp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {AD78421F-9ECA-4BFD-81E6-94712D62DEFD}
// *********************************************************************//
  IConstantsDisp = dispinterface
    ['{AD78421F-9ECA-4BFD-81E6-94712D62DEFD}']
    property EMAIL_MESSAGE_PRIORITY_HIGHEST: Integer readonly dispid 100;
    property EMAIL_MESSAGE_PRIORITY_HIGH: Integer readonly dispid 101;
    property EMAIL_MESSAGE_PRIORITY_MEDIUM: Integer readonly dispid 102;
    property EMAIL_MESSAGE_PRIORITY_LOW: Integer readonly dispid 103;
    property EMAIL_MESSAGE_PRIORITY_LOWEST: Integer readonly dispid 104;
    property EMAIL_MESSAGE_ENCODING_DEFAULT: Integer readonly dispid 200;
    property EMAIL_MESSAGE_ENCODING_THAI: Integer readonly dispid 201;
    property EMAIL_MESSAGE_ENCODING_JAPANESE: Integer readonly dispid 202;
    property EMAIL_MESSAGE_ENCODING_CHINESE_SIMP: Integer readonly dispid 203;
    property EMAIL_MESSAGE_ENCODING_KOREAN: Integer readonly dispid 204;
    property EMAIL_MESSAGE_ENCODING_CHINESE_TRAD: Integer readonly dispid 205;
    property EMAIL_MESSAGE_ENCODING_CENTRALEUROPE: Integer readonly dispid 206;
    property EMAIL_MESSAGE_ENCODING_RUSSIAN: Integer readonly dispid 207;
    property EMAIL_MESSAGE_ENCODING_WESTERN: Integer readonly dispid 208;
    property EMAIL_MESSAGE_ENCODING_GREEK: Integer readonly dispid 209;
    property EMAIL_MESSAGE_ENCODING_TURKISH: Integer readonly dispid 210;
    property EMAIL_MESSAGE_ENCODING_HEBREW: Integer readonly dispid 211;
    property EMAIL_MESSAGE_ENCODING_ARABIC: Integer readonly dispid 212;
    property EMAIL_MESSAGE_ENCODING_BALTIC: Integer readonly dispid 213;
    property EMAIL_MESSAGE_ENCODING_VIETNAMESE: Integer readonly dispid 214;
    property EMAIL_MESSAGE_ENCODING_UTF7: Integer readonly dispid 215;
    property EMAIL_MESSAGE_ENCODING_UTF8: Integer readonly dispid 216;
    property SMTP_AUTH_AUTO: Integer readonly dispid 300;
    property SMTP_AUTH_PLAIN: Integer readonly dispid 301;
    property SMTP_AUTH_LOGIN: Integer readonly dispid 302;
    property SMTP_AUTH_MD5CRAM: Integer readonly dispid 303;
    property POP3_AUTH_PLAIN: Integer readonly dispid 400;
    property POP3_AUTH_APOP: Integer readonly dispid 401;
    property POP3_AUTH_AUTO: Integer readonly dispid 402;
    property IMAP_SK_ALL: WideString readonly dispid 500;
    property IMAP_SK_ANSWERED: WideString readonly dispid 501;
    property IMAP_SK_BCC: WideString readonly dispid 502;
    property IMAP_SK_BEFORE: WideString readonly dispid 503;
    property IMAP_SK_BODY: WideString readonly dispid 504;
    property IMAP_SK_CC: WideString readonly dispid 505;
    property IMAP_SK_DELETED: WideString readonly dispid 506;
    property IMAP_SK_DRAFT: WideString readonly dispid 507;
    property IMAP_SK_FLAGGED: WideString readonly dispid 508;
    property IMAP_SK_FROM: WideString readonly dispid 509;
    property IMAP_SK_HEADER: WideString readonly dispid 510;
    property IMAP_SK_KEYWORD: WideString readonly dispid 511;
    property IMAP_SK_LARGER: WideString readonly dispid 512;
    property IMAP_SK_NEW: WideString readonly dispid 513;
    property IMAP_SK_NOT: WideString readonly dispid 514;
    property IMAP_SK_OLD: WideString readonly dispid 515;
    property IMAP_SK_ON: WideString readonly dispid 516;
    property IMAP_SK_OR: WideString readonly dispid 517;
    property IMAP_SK_RECENT: WideString readonly dispid 518;
    property IMAP_SK_SEEN: WideString readonly dispid 519;
    property IMAP_SK_SENTBEFORE: WideString readonly dispid 520;
    property IMAP_SK_SENTON: WideString readonly dispid 521;
    property IMAP_SK_SENTSINCE: WideString readonly dispid 522;
    property IMAP_SK_SINCE: WideString readonly dispid 523;
    property IMAP_SK_SMALLER: WideString readonly dispid 524;
    property IMAP_SK_SUBJECT: WideString readonly dispid 525;
    property IMAP_SK_TEXT: WideString readonly dispid 526;
    property IMAP_SK_TO: WideString readonly dispid 527;
    property IMAP_SK_UID: WideString readonly dispid 528;
    property IMAP_SK_UNANSWERED: WideString readonly dispid 529;
    property IMAP_SK_UNDELETED: WideString readonly dispid 530;
    property IMAP_SK_UNDRAFT: WideString readonly dispid 531;
    property IMAP_SK_UNFLAGGED: WideString readonly dispid 532;
    property IMAP_SK_UNKEYWORD: WideString readonly dispid 533;
    property IMAP_SK_UNSEEN: WideString readonly dispid 534;
    property IMAP_FM_ALL: WideString readonly dispid 535;
    property IMAP_FM_FAST: WideString readonly dispid 536;
    property IMAP_FM_FULL: WideString readonly dispid 537;
    property IMAP_FDI_BODY: WideString readonly dispid 538;
    property IMAP_FDI_HEADER: WideString readonly dispid 539;
    property IMAP_FDI_HEADER_FIELDS: WideString readonly dispid 540;
    property IMAP_FDI_HEADER_FIELDS_NOT: WideString readonly dispid 541;
    property IMAP_FDI_MIME: WideString readonly dispid 542;
    property IMAP_FDI_TEXT: WideString readonly dispid 543;
    property IMAP_FDI_BODY_PEEK: WideString readonly dispid 544;
    property IMAP_FDI_BODYSTRUCTURE: WideString readonly dispid 545;
    property IMAP_FDI_ENVELOPE: WideString readonly dispid 546;
    property IMAP_FDI_FLAGS: WideString readonly dispid 547;
    property IMAP_FDI_INTERNALDATE: WideString readonly dispid 548;
    property IMAP_FDI_RFC822: WideString readonly dispid 549;
    property IMAP_FDI_RFC822_HEADER: WideString readonly dispid 550;
    property IMAP_FDI_RFC822_SIZE: WideString readonly dispid 551;
    property IMAP_FDI_RFC822_TEXT: WideString readonly dispid 552;
    property IMAP_FDI_UID: WideString readonly dispid 553;
    property IMAP_MBX_FLAG_NOINFERIORS: WideString readonly dispid 564;
    property IMAP_MBX_FLAG_NOSELECT: WideString readonly dispid 565;
    property IMAP_MBX_FLAG_MARKED: WideString readonly dispid 566;
    property IMAP_MBX_FLAG_UNMARKED: WideString readonly dispid 567;
    property IMAP_MBX_FLAG_ALL: WideString readonly dispid 568;
    property IMAP_MBX_FLAG_ARCHIVE: WideString readonly dispid 569;
    property IMAP_MBX_FLAG_DRAFTS: WideString readonly dispid 570;
    property IMAP_MBX_FLAG_FLAGGED: WideString readonly dispid 571;
    property IMAP_MBX_FLAG_JUNK: WideString readonly dispid 572;
    property IMAP_MBX_FLAG_SENT: WideString readonly dispid 573;
    property IMAP_MBX_FLAG_TRASH: WideString readonly dispid 574;
    property IMAP_MBX_FLAG_HASNOCHILDREN: WideString readonly dispid 575;
    property IMAP_MBX_FLAG_HASCHILDREN: WideString readonly dispid 576;
    property IMAP_MAIL_FLAG_SEEN: WideString readonly dispid 577;
    property IMAP_MAIL_FLAG_ANSWERED: WideString readonly dispid 578;
    property IMAP_MAIL_FLAG_FLAGGED: WideString readonly dispid 579;
    property IMAP_MAIL_FLAG_DELETED: WideString readonly dispid 580;
    property IMAP_MAIL_FLAG_DRAFT: WideString readonly dispid 581;
    property IMAP_MAIL_FLAG_RECENT: WideString readonly dispid 582;
    property IMAP_FD_TYPE_INTEGER: Integer readonly dispid 554;
    property IMAP_FD_TYPE_STRING: Integer readonly dispid 555;
    property IMAP_FD_TYPE_STRING_LITERAL: Integer readonly dispid 556;
    property IMAP_FD_TYPE_LIST: Integer readonly dispid 557;
    property IMAP_FD_TYPE_ATOM: Integer readonly dispid 558;
    property IMAP_FD_TYPE_NIL: Integer readonly dispid 559;
    property IMAP_STO_SET: Integer readonly dispid 560;
    property IMAP_STO_ADD: Integer readonly dispid 561;
    property IMAP_STO_REMOVE: Integer readonly dispid 562;
    property IMAP_STO_SILENT: Integer readonly dispid 563;
    property IMAP_AUTH_AUTO: Integer readonly dispid 583;
    property IMAP_AUTH_LOGIN: Integer readonly dispid 584;
    property IMAP_AUTH_PLAIN: Integer readonly dispid 585;
    property IPVERSION_4: Integer readonly dispid 700;
    property IPVERSION_6: Integer readonly dispid 701;
    property IPVERSION_6_4: Integer readonly dispid 702;
    function MessagePriorityToString(lVal: Integer): WideString; dispid 10001;
    function MessageEncodingToString(lVal: Integer): WideString; dispid 10002;
    function SmtpAuthToString(lVal: Integer): WideString; dispid 10003;
    function Pop3AuthToString(lVal: Integer): WideString; dispid 10004;
    function ImapAuthToString(lVal: Integer): WideString; dispid 10005;
    function ImapFetchDataTypeToString(lVal: Integer): WideString; dispid 10006;
    function ImapStoreOptionToString(lVal: Integer): WideString; dispid 10007;
  end;

// *********************************************************************//
// The Class CoMessage provides a Create and CreateRemote method to          
// create instances of the default interface IMessage exposed by              
// the CoClass Message. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoMessage = class
    class function Create: IMessage;
    class function CreateRemote(const MachineName: string): IMessage;
  end;

// *********************************************************************//
// The Class CoSmtp provides a Create and CreateRemote method to          
// create instances of the default interface ISmtp exposed by              
// the CoClass Smtp. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoSmtp = class
    class function Create: ISmtp;
    class function CreateRemote(const MachineName: string): ISmtp;
  end;

// *********************************************************************//
// The Class CoPop3 provides a Create and CreateRemote method to          
// create instances of the default interface IPop3 exposed by              
// the CoClass Pop3. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoPop3 = class
    class function Create: IPop3;
    class function CreateRemote(const MachineName: string): IPop3;
  end;

// *********************************************************************//
// The Class CoImapFetchData provides a Create and CreateRemote method to          
// create instances of the default interface IImapFetchData exposed by              
// the CoClass ImapFetchData. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoImapFetchData = class
    class function Create: IImapFetchData;
    class function CreateRemote(const MachineName: string): IImapFetchData;
  end;

// *********************************************************************//
// The Class CoImap provides a Create and CreateRemote method to          
// create instances of the default interface IImap exposed by              
// the CoClass Imap. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoImap = class
    class function Create: IImap;
    class function CreateRemote(const MachineName: string): IImap;
  end;

// *********************************************************************//
// The Class CoConstants provides a Create and CreateRemote method to          
// create instances of the default interface IConstants exposed by              
// the CoClass Constants. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoConstants = class
    class function Create: IConstants;
    class function CreateRemote(const MachineName: string): IConstants;
  end;

implementation

uses ComObj;

class function CoMessage.Create: IMessage;
begin
  Result := CreateComObject(CLASS_Message) as IMessage;
end;

class function CoMessage.CreateRemote(const MachineName: string): IMessage;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_Message) as IMessage;
end;

class function CoSmtp.Create: ISmtp;
begin
  Result := CreateComObject(CLASS_Smtp) as ISmtp;
end;

class function CoSmtp.CreateRemote(const MachineName: string): ISmtp;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_Smtp) as ISmtp;
end;

class function CoPop3.Create: IPop3;
begin
  Result := CreateComObject(CLASS_Pop3) as IPop3;
end;

class function CoPop3.CreateRemote(const MachineName: string): IPop3;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_Pop3) as IPop3;
end;

class function CoImapFetchData.Create: IImapFetchData;
begin
  Result := CreateComObject(CLASS_ImapFetchData) as IImapFetchData;
end;

class function CoImapFetchData.CreateRemote(const MachineName: string): IImapFetchData;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_ImapFetchData) as IImapFetchData;
end;

class function CoImap.Create: IImap;
begin
  Result := CreateComObject(CLASS_Imap) as IImap;
end;

class function CoImap.CreateRemote(const MachineName: string): IImap;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_Imap) as IImap;
end;

class function CoConstants.Create: IConstants;
begin
  Result := CreateComObject(CLASS_Constants) as IConstants;
end;

class function CoConstants.CreateRemote(const MachineName: string): IConstants;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_Constants) as IConstants;
end;

end.
