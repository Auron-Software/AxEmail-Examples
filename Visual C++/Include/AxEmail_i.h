

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 8.01.0628 */
/* at Mon Jan 18 19:14:07 2038
 */
/* Compiler settings for AxEmail.idl:
    Oicf, W1, Zp8, env=Win32 (32b run), target_arch=X86 8.01.0628 
    protocol : dce , ms_ext, c_ext, robust
    error checks: allocation ref bounds_check enum stub_data 
    VC __declspec() decoration level: 
         __declspec(uuid()), __declspec(selectany), __declspec(novtable)
         DECLSPEC_UUID(), MIDL_INTERFACE()
*/
/* @@MIDL_FILE_HEADING(  ) */



/* verify that the <rpcndr.h> version is high enough to compile this file*/
#ifndef __REQUIRED_RPCNDR_H_VERSION__
#define __REQUIRED_RPCNDR_H_VERSION__ 500
#endif

#include "rpc.h"
#include "rpcndr.h"

#ifndef __RPCNDR_H_VERSION__
#error this stub requires an updated version of <rpcndr.h>
#endif /* __RPCNDR_H_VERSION__ */

#ifndef COM_NO_WINDOWS_H
#include "windows.h"
#include "ole2.h"
#endif /*COM_NO_WINDOWS_H*/

#ifndef __AxEmail_i_h__
#define __AxEmail_i_h__

#if defined(_MSC_VER) && (_MSC_VER >= 1020)
#pragma once
#endif

#ifndef DECLSPEC_XFGVIRT
#if defined(_CONTROL_FLOW_GUARD_XFG)
#define DECLSPEC_XFGVIRT(base, func) __declspec(xfg_virtual(base, func))
#else
#define DECLSPEC_XFGVIRT(base, func)
#endif
#endif

/* Forward Declarations */ 

#ifndef __IMessage_FWD_DEFINED__
#define __IMessage_FWD_DEFINED__
typedef interface IMessage IMessage;

#endif 	/* __IMessage_FWD_DEFINED__ */


#ifndef __IOAuth2_FWD_DEFINED__
#define __IOAuth2_FWD_DEFINED__
typedef interface IOAuth2 IOAuth2;

#endif 	/* __IOAuth2_FWD_DEFINED__ */


#ifndef __ISmtp_FWD_DEFINED__
#define __ISmtp_FWD_DEFINED__
typedef interface ISmtp ISmtp;

#endif 	/* __ISmtp_FWD_DEFINED__ */


#ifndef __IPop3_FWD_DEFINED__
#define __IPop3_FWD_DEFINED__
typedef interface IPop3 IPop3;

#endif 	/* __IPop3_FWD_DEFINED__ */


#ifndef __IImapFetchData_FWD_DEFINED__
#define __IImapFetchData_FWD_DEFINED__
typedef interface IImapFetchData IImapFetchData;

#endif 	/* __IImapFetchData_FWD_DEFINED__ */


#ifndef __IImap_FWD_DEFINED__
#define __IImap_FWD_DEFINED__
typedef interface IImap IImap;

#endif 	/* __IImap_FWD_DEFINED__ */


#ifndef __IConstants_FWD_DEFINED__
#define __IConstants_FWD_DEFINED__
typedef interface IConstants IConstants;

#endif 	/* __IConstants_FWD_DEFINED__ */


#ifndef __Message_FWD_DEFINED__
#define __Message_FWD_DEFINED__

#ifdef __cplusplus
typedef class Message Message;
#else
typedef struct Message Message;
#endif /* __cplusplus */

#endif 	/* __Message_FWD_DEFINED__ */


#ifndef __OAuth2_FWD_DEFINED__
#define __OAuth2_FWD_DEFINED__

#ifdef __cplusplus
typedef class OAuth2 OAuth2;
#else
typedef struct OAuth2 OAuth2;
#endif /* __cplusplus */

#endif 	/* __OAuth2_FWD_DEFINED__ */


#ifndef __Smtp_FWD_DEFINED__
#define __Smtp_FWD_DEFINED__

#ifdef __cplusplus
typedef class Smtp Smtp;
#else
typedef struct Smtp Smtp;
#endif /* __cplusplus */

#endif 	/* __Smtp_FWD_DEFINED__ */


#ifndef __Pop3_FWD_DEFINED__
#define __Pop3_FWD_DEFINED__

#ifdef __cplusplus
typedef class Pop3 Pop3;
#else
typedef struct Pop3 Pop3;
#endif /* __cplusplus */

#endif 	/* __Pop3_FWD_DEFINED__ */


#ifndef __ImapFetchData_FWD_DEFINED__
#define __ImapFetchData_FWD_DEFINED__

#ifdef __cplusplus
typedef class ImapFetchData ImapFetchData;
#else
typedef struct ImapFetchData ImapFetchData;
#endif /* __cplusplus */

#endif 	/* __ImapFetchData_FWD_DEFINED__ */


#ifndef __Imap_FWD_DEFINED__
#define __Imap_FWD_DEFINED__

#ifdef __cplusplus
typedef class Imap Imap;
#else
typedef struct Imap Imap;
#endif /* __cplusplus */

#endif 	/* __Imap_FWD_DEFINED__ */


#ifndef __Constants_FWD_DEFINED__
#define __Constants_FWD_DEFINED__

#ifdef __cplusplus
typedef class Constants Constants;
#else
typedef struct Constants Constants;
#endif /* __cplusplus */

#endif 	/* __Constants_FWD_DEFINED__ */


/* header files for imported files */
#include "oaidl.h"
#include "ocidl.h"

#ifdef __cplusplus
extern "C"{
#endif 


#ifndef __IMessage_INTERFACE_DEFINED__
#define __IMessage_INTERFACE_DEFINED__

/* interface IMessage */
/* [unique][helpstring][nonextensible][dual][uuid][object] */ 


EXTERN_C const IID IID_IMessage;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("CC87528F-D4BF-4BFE-8DF7-9BFB57D33810")
    IMessage : public IDispatch
    {
    public:
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_LastError( 
            /* [retval][out] */ LONG *LastError) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_UnsubscribeEmail( 
            /* [retval][out] */ BSTR *Val) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_UnsubscribeEmail( 
            /* [in] */ BSTR Val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_UnsubscribeUrl( 
            /* [retval][out] */ BSTR *Val) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_UnsubscribeUrl( 
            /* [in] */ BSTR Val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_FromName( 
            /* [retval][out] */ BSTR *Name) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_FromName( 
            /* [in] */ BSTR Name) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_FromAddress( 
            /* [retval][out] */ BSTR *Address) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_FromAddress( 
            /* [in] */ BSTR Address) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_ReplyAddress( 
            /* [retval][out] */ BSTR *Address) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_ReplyAddress( 
            /* [in] */ BSTR Address) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_ReadReceiptAddress( 
            /* [retval][out] */ BSTR *Address) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_ReadReceiptAddress( 
            /* [in] */ BSTR Address) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_Organization( 
            /* [retval][out] */ BSTR *Organization) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_Organization( 
            /* [in] */ BSTR Organization) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_Subject( 
            /* [retval][out] */ BSTR *Subject) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_Subject( 
            /* [in] */ BSTR Subject) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_BodyPlainText( 
            /* [retval][out] */ BSTR *Body) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_BodyPlainText( 
            /* [in] */ BSTR Body) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_BodyHtml( 
            /* [retval][out] */ BSTR *Body) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_BodyHtml( 
            /* [in] */ BSTR Body) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_Encoding( 
            /* [retval][out] */ LONG *Encoding) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_Encoding( 
            /* [in] */ LONG Encoding) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_Priority( 
            /* [retval][out] */ LONG *Priority) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_Priority( 
            /* [in] */ LONG Priority) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_ID( 
            /* [retval][out] */ LONG *ID) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_MessageSource( 
            /* [retval][out] */ BSTR *Source) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_MessageHeader( 
            /* [retval][out] */ BSTR *Header) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_Size( 
            /* [retval][out] */ LONG *Size) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_Date( 
            /* [retval][out] */ BSTR *Date) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_ToAddress( 
            /* [retval][out] */ BSTR *Address) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_CcAddress( 
            /* [retval][out] */ BSTR *Address) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_BccAddress( 
            /* [retval][out] */ BSTR *Address) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_ImapFlags( 
            /* [retval][out] */ BSTR *Flags) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_ImapUID( 
            /* [retval][out] */ LONG *Uid) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_ImapSequenceNumber( 
            /* [retval][out] */ LONG *Uid) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_ImapSequenceNumber( 
            /* [in] */ LONG Uid) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Clear( void) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE GetErrorDescription( 
            /* [in] */ LONG lError,
            /* [retval][out] */ BSTR *Description) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE AddTo( 
            /* [in] */ BSTR EmailAddress,
            /* [defaultvalue][in] */ BSTR DisplayName = (BSTR)L"") = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE AddCc( 
            /* [in] */ BSTR EmailAddress,
            /* [defaultvalue][in] */ BSTR DisplayName = (BSTR)L"") = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE AddBcc( 
            /* [in] */ BSTR EmailAddress,
            /* [defaultvalue][in] */ BSTR DisplayName = (BSTR)L"") = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE CountAttachments( 
            /* [retval][out] */ LONG *Count) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE GetAttachmentName( 
            /* [in] */ LONG ID,
            /* [retval][out] */ BSTR *Name) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE GetAttachmentSize( 
            /* [in] */ LONG ID,
            /* [retval][out] */ LONG *Size) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE AddAttachment( 
            /* [in] */ BSTR FileName,
            /* [defaultvalue][in] */ BSTR AttachmentName = (BSTR)L"",
            /* [defaultvalue][in] */ VARIANT_BOOL InlineDisposition = 0) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE SaveAttachment( 
            /* [in] */ LONG ID,
            /* [in] */ BSTR SaveAsFile) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE ImapHasFlag( 
            /* [in] */ BSTR Flag,
            /* [retval][out] */ VARIANT_BOOL *__MIDL__IMessage0000) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE LoadMIME( 
            /* [in] */ BSTR MimeFile) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE SaveMIME( 
            /* [in] */ BSTR MimeFile) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Encode( void) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Decode( void) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE GetHeaderValue( 
            /* [in] */ BSTR Name,
            /* [retval][out] */ BSTR *Value) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE AddHeader( 
            /* [in] */ BSTR Name,
            /* [in] */ BSTR Value,
            /* [defaultvalue][in] */ VARIANT_BOOL Enquote = -1) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE HtmlToPlainText( 
            /* [in] */ BSTR Html,
            /* [retval][out] */ BSTR *Plain) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct IMessageVtbl
    {
        BEGIN_INTERFACE
        
        DECLSPEC_XFGVIRT(IUnknown, QueryInterface)
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            IMessage * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        DECLSPEC_XFGVIRT(IUnknown, AddRef)
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            IMessage * This);
        
        DECLSPEC_XFGVIRT(IUnknown, Release)
        ULONG ( STDMETHODCALLTYPE *Release )( 
            IMessage * This);
        
        DECLSPEC_XFGVIRT(IDispatch, GetTypeInfoCount)
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfoCount )( 
            IMessage * This,
            /* [out] */ UINT *pctinfo);
        
        DECLSPEC_XFGVIRT(IDispatch, GetTypeInfo)
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfo )( 
            IMessage * This,
            /* [in] */ UINT iTInfo,
            /* [in] */ LCID lcid,
            /* [out] */ ITypeInfo **ppTInfo);
        
        DECLSPEC_XFGVIRT(IDispatch, GetIDsOfNames)
        HRESULT ( STDMETHODCALLTYPE *GetIDsOfNames )( 
            IMessage * This,
            /* [in] */ REFIID riid,
            /* [size_is][in] */ LPOLESTR *rgszNames,
            /* [range][in] */ UINT cNames,
            /* [in] */ LCID lcid,
            /* [size_is][out] */ DISPID *rgDispId);
        
        DECLSPEC_XFGVIRT(IDispatch, Invoke)
        /* [local] */ HRESULT ( STDMETHODCALLTYPE *Invoke )( 
            IMessage * This,
            /* [annotation][in] */ 
            _In_  DISPID dispIdMember,
            /* [annotation][in] */ 
            _In_  REFIID riid,
            /* [annotation][in] */ 
            _In_  LCID lcid,
            /* [annotation][in] */ 
            _In_  WORD wFlags,
            /* [annotation][out][in] */ 
            _In_  DISPPARAMS *pDispParams,
            /* [annotation][out] */ 
            _Out_opt_  VARIANT *pVarResult,
            /* [annotation][out] */ 
            _Out_opt_  EXCEPINFO *pExcepInfo,
            /* [annotation][out] */ 
            _Out_opt_  UINT *puArgErr);
        
        DECLSPEC_XFGVIRT(IMessage, get_LastError)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_LastError )( 
            IMessage * This,
            /* [retval][out] */ LONG *LastError);
        
        DECLSPEC_XFGVIRT(IMessage, get_UnsubscribeEmail)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_UnsubscribeEmail )( 
            IMessage * This,
            /* [retval][out] */ BSTR *Val);
        
        DECLSPEC_XFGVIRT(IMessage, put_UnsubscribeEmail)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_UnsubscribeEmail )( 
            IMessage * This,
            /* [in] */ BSTR Val);
        
        DECLSPEC_XFGVIRT(IMessage, get_UnsubscribeUrl)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_UnsubscribeUrl )( 
            IMessage * This,
            /* [retval][out] */ BSTR *Val);
        
        DECLSPEC_XFGVIRT(IMessage, put_UnsubscribeUrl)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_UnsubscribeUrl )( 
            IMessage * This,
            /* [in] */ BSTR Val);
        
        DECLSPEC_XFGVIRT(IMessage, get_FromName)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_FromName )( 
            IMessage * This,
            /* [retval][out] */ BSTR *Name);
        
        DECLSPEC_XFGVIRT(IMessage, put_FromName)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_FromName )( 
            IMessage * This,
            /* [in] */ BSTR Name);
        
        DECLSPEC_XFGVIRT(IMessage, get_FromAddress)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_FromAddress )( 
            IMessage * This,
            /* [retval][out] */ BSTR *Address);
        
        DECLSPEC_XFGVIRT(IMessage, put_FromAddress)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_FromAddress )( 
            IMessage * This,
            /* [in] */ BSTR Address);
        
        DECLSPEC_XFGVIRT(IMessage, get_ReplyAddress)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_ReplyAddress )( 
            IMessage * This,
            /* [retval][out] */ BSTR *Address);
        
        DECLSPEC_XFGVIRT(IMessage, put_ReplyAddress)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_ReplyAddress )( 
            IMessage * This,
            /* [in] */ BSTR Address);
        
        DECLSPEC_XFGVIRT(IMessage, get_ReadReceiptAddress)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_ReadReceiptAddress )( 
            IMessage * This,
            /* [retval][out] */ BSTR *Address);
        
        DECLSPEC_XFGVIRT(IMessage, put_ReadReceiptAddress)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_ReadReceiptAddress )( 
            IMessage * This,
            /* [in] */ BSTR Address);
        
        DECLSPEC_XFGVIRT(IMessage, get_Organization)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Organization )( 
            IMessage * This,
            /* [retval][out] */ BSTR *Organization);
        
        DECLSPEC_XFGVIRT(IMessage, put_Organization)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_Organization )( 
            IMessage * This,
            /* [in] */ BSTR Organization);
        
        DECLSPEC_XFGVIRT(IMessage, get_Subject)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Subject )( 
            IMessage * This,
            /* [retval][out] */ BSTR *Subject);
        
        DECLSPEC_XFGVIRT(IMessage, put_Subject)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_Subject )( 
            IMessage * This,
            /* [in] */ BSTR Subject);
        
        DECLSPEC_XFGVIRT(IMessage, get_BodyPlainText)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_BodyPlainText )( 
            IMessage * This,
            /* [retval][out] */ BSTR *Body);
        
        DECLSPEC_XFGVIRT(IMessage, put_BodyPlainText)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_BodyPlainText )( 
            IMessage * This,
            /* [in] */ BSTR Body);
        
        DECLSPEC_XFGVIRT(IMessage, get_BodyHtml)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_BodyHtml )( 
            IMessage * This,
            /* [retval][out] */ BSTR *Body);
        
        DECLSPEC_XFGVIRT(IMessage, put_BodyHtml)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_BodyHtml )( 
            IMessage * This,
            /* [in] */ BSTR Body);
        
        DECLSPEC_XFGVIRT(IMessage, get_Encoding)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Encoding )( 
            IMessage * This,
            /* [retval][out] */ LONG *Encoding);
        
        DECLSPEC_XFGVIRT(IMessage, put_Encoding)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_Encoding )( 
            IMessage * This,
            /* [in] */ LONG Encoding);
        
        DECLSPEC_XFGVIRT(IMessage, get_Priority)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Priority )( 
            IMessage * This,
            /* [retval][out] */ LONG *Priority);
        
        DECLSPEC_XFGVIRT(IMessage, put_Priority)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_Priority )( 
            IMessage * This,
            /* [in] */ LONG Priority);
        
        DECLSPEC_XFGVIRT(IMessage, get_ID)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_ID )( 
            IMessage * This,
            /* [retval][out] */ LONG *ID);
        
        DECLSPEC_XFGVIRT(IMessage, get_MessageSource)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_MessageSource )( 
            IMessage * This,
            /* [retval][out] */ BSTR *Source);
        
        DECLSPEC_XFGVIRT(IMessage, get_MessageHeader)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_MessageHeader )( 
            IMessage * This,
            /* [retval][out] */ BSTR *Header);
        
        DECLSPEC_XFGVIRT(IMessage, get_Size)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Size )( 
            IMessage * This,
            /* [retval][out] */ LONG *Size);
        
        DECLSPEC_XFGVIRT(IMessage, get_Date)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Date )( 
            IMessage * This,
            /* [retval][out] */ BSTR *Date);
        
        DECLSPEC_XFGVIRT(IMessage, get_ToAddress)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_ToAddress )( 
            IMessage * This,
            /* [retval][out] */ BSTR *Address);
        
        DECLSPEC_XFGVIRT(IMessage, get_CcAddress)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_CcAddress )( 
            IMessage * This,
            /* [retval][out] */ BSTR *Address);
        
        DECLSPEC_XFGVIRT(IMessage, get_BccAddress)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_BccAddress )( 
            IMessage * This,
            /* [retval][out] */ BSTR *Address);
        
        DECLSPEC_XFGVIRT(IMessage, get_ImapFlags)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_ImapFlags )( 
            IMessage * This,
            /* [retval][out] */ BSTR *Flags);
        
        DECLSPEC_XFGVIRT(IMessage, get_ImapUID)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_ImapUID )( 
            IMessage * This,
            /* [retval][out] */ LONG *Uid);
        
        DECLSPEC_XFGVIRT(IMessage, get_ImapSequenceNumber)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_ImapSequenceNumber )( 
            IMessage * This,
            /* [retval][out] */ LONG *Uid);
        
        DECLSPEC_XFGVIRT(IMessage, put_ImapSequenceNumber)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_ImapSequenceNumber )( 
            IMessage * This,
            /* [in] */ LONG Uid);
        
        DECLSPEC_XFGVIRT(IMessage, Clear)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Clear )( 
            IMessage * This);
        
        DECLSPEC_XFGVIRT(IMessage, GetErrorDescription)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *GetErrorDescription )( 
            IMessage * This,
            /* [in] */ LONG lError,
            /* [retval][out] */ BSTR *Description);
        
        DECLSPEC_XFGVIRT(IMessage, AddTo)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *AddTo )( 
            IMessage * This,
            /* [in] */ BSTR EmailAddress,
            /* [defaultvalue][in] */ BSTR DisplayName);
        
        DECLSPEC_XFGVIRT(IMessage, AddCc)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *AddCc )( 
            IMessage * This,
            /* [in] */ BSTR EmailAddress,
            /* [defaultvalue][in] */ BSTR DisplayName);
        
        DECLSPEC_XFGVIRT(IMessage, AddBcc)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *AddBcc )( 
            IMessage * This,
            /* [in] */ BSTR EmailAddress,
            /* [defaultvalue][in] */ BSTR DisplayName);
        
        DECLSPEC_XFGVIRT(IMessage, CountAttachments)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *CountAttachments )( 
            IMessage * This,
            /* [retval][out] */ LONG *Count);
        
        DECLSPEC_XFGVIRT(IMessage, GetAttachmentName)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *GetAttachmentName )( 
            IMessage * This,
            /* [in] */ LONG ID,
            /* [retval][out] */ BSTR *Name);
        
        DECLSPEC_XFGVIRT(IMessage, GetAttachmentSize)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *GetAttachmentSize )( 
            IMessage * This,
            /* [in] */ LONG ID,
            /* [retval][out] */ LONG *Size);
        
        DECLSPEC_XFGVIRT(IMessage, AddAttachment)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *AddAttachment )( 
            IMessage * This,
            /* [in] */ BSTR FileName,
            /* [defaultvalue][in] */ BSTR AttachmentName,
            /* [defaultvalue][in] */ VARIANT_BOOL InlineDisposition);
        
        DECLSPEC_XFGVIRT(IMessage, SaveAttachment)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *SaveAttachment )( 
            IMessage * This,
            /* [in] */ LONG ID,
            /* [in] */ BSTR SaveAsFile);
        
        DECLSPEC_XFGVIRT(IMessage, ImapHasFlag)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *ImapHasFlag )( 
            IMessage * This,
            /* [in] */ BSTR Flag,
            /* [retval][out] */ VARIANT_BOOL *__MIDL__IMessage0000);
        
        DECLSPEC_XFGVIRT(IMessage, LoadMIME)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *LoadMIME )( 
            IMessage * This,
            /* [in] */ BSTR MimeFile);
        
        DECLSPEC_XFGVIRT(IMessage, SaveMIME)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *SaveMIME )( 
            IMessage * This,
            /* [in] */ BSTR MimeFile);
        
        DECLSPEC_XFGVIRT(IMessage, Encode)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Encode )( 
            IMessage * This);
        
        DECLSPEC_XFGVIRT(IMessage, Decode)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Decode )( 
            IMessage * This);
        
        DECLSPEC_XFGVIRT(IMessage, GetHeaderValue)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *GetHeaderValue )( 
            IMessage * This,
            /* [in] */ BSTR Name,
            /* [retval][out] */ BSTR *Value);
        
        DECLSPEC_XFGVIRT(IMessage, AddHeader)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *AddHeader )( 
            IMessage * This,
            /* [in] */ BSTR Name,
            /* [in] */ BSTR Value,
            /* [defaultvalue][in] */ VARIANT_BOOL Enquote);
        
        DECLSPEC_XFGVIRT(IMessage, HtmlToPlainText)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *HtmlToPlainText )( 
            IMessage * This,
            /* [in] */ BSTR Html,
            /* [retval][out] */ BSTR *Plain);
        
        END_INTERFACE
    } IMessageVtbl;

    interface IMessage
    {
        CONST_VTBL struct IMessageVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define IMessage_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define IMessage_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define IMessage_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define IMessage_GetTypeInfoCount(This,pctinfo)	\
    ( (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo) ) 

#define IMessage_GetTypeInfo(This,iTInfo,lcid,ppTInfo)	\
    ( (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo) ) 

#define IMessage_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)	\
    ( (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) ) 

#define IMessage_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)	\
    ( (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) ) 


#define IMessage_get_LastError(This,LastError)	\
    ( (This)->lpVtbl -> get_LastError(This,LastError) ) 

#define IMessage_get_UnsubscribeEmail(This,Val)	\
    ( (This)->lpVtbl -> get_UnsubscribeEmail(This,Val) ) 

#define IMessage_put_UnsubscribeEmail(This,Val)	\
    ( (This)->lpVtbl -> put_UnsubscribeEmail(This,Val) ) 

#define IMessage_get_UnsubscribeUrl(This,Val)	\
    ( (This)->lpVtbl -> get_UnsubscribeUrl(This,Val) ) 

#define IMessage_put_UnsubscribeUrl(This,Val)	\
    ( (This)->lpVtbl -> put_UnsubscribeUrl(This,Val) ) 

#define IMessage_get_FromName(This,Name)	\
    ( (This)->lpVtbl -> get_FromName(This,Name) ) 

#define IMessage_put_FromName(This,Name)	\
    ( (This)->lpVtbl -> put_FromName(This,Name) ) 

#define IMessage_get_FromAddress(This,Address)	\
    ( (This)->lpVtbl -> get_FromAddress(This,Address) ) 

#define IMessage_put_FromAddress(This,Address)	\
    ( (This)->lpVtbl -> put_FromAddress(This,Address) ) 

#define IMessage_get_ReplyAddress(This,Address)	\
    ( (This)->lpVtbl -> get_ReplyAddress(This,Address) ) 

#define IMessage_put_ReplyAddress(This,Address)	\
    ( (This)->lpVtbl -> put_ReplyAddress(This,Address) ) 

#define IMessage_get_ReadReceiptAddress(This,Address)	\
    ( (This)->lpVtbl -> get_ReadReceiptAddress(This,Address) ) 

#define IMessage_put_ReadReceiptAddress(This,Address)	\
    ( (This)->lpVtbl -> put_ReadReceiptAddress(This,Address) ) 

#define IMessage_get_Organization(This,Organization)	\
    ( (This)->lpVtbl -> get_Organization(This,Organization) ) 

#define IMessage_put_Organization(This,Organization)	\
    ( (This)->lpVtbl -> put_Organization(This,Organization) ) 

#define IMessage_get_Subject(This,Subject)	\
    ( (This)->lpVtbl -> get_Subject(This,Subject) ) 

#define IMessage_put_Subject(This,Subject)	\
    ( (This)->lpVtbl -> put_Subject(This,Subject) ) 

#define IMessage_get_BodyPlainText(This,Body)	\
    ( (This)->lpVtbl -> get_BodyPlainText(This,Body) ) 

#define IMessage_put_BodyPlainText(This,Body)	\
    ( (This)->lpVtbl -> put_BodyPlainText(This,Body) ) 

#define IMessage_get_BodyHtml(This,Body)	\
    ( (This)->lpVtbl -> get_BodyHtml(This,Body) ) 

#define IMessage_put_BodyHtml(This,Body)	\
    ( (This)->lpVtbl -> put_BodyHtml(This,Body) ) 

#define IMessage_get_Encoding(This,Encoding)	\
    ( (This)->lpVtbl -> get_Encoding(This,Encoding) ) 

#define IMessage_put_Encoding(This,Encoding)	\
    ( (This)->lpVtbl -> put_Encoding(This,Encoding) ) 

#define IMessage_get_Priority(This,Priority)	\
    ( (This)->lpVtbl -> get_Priority(This,Priority) ) 

#define IMessage_put_Priority(This,Priority)	\
    ( (This)->lpVtbl -> put_Priority(This,Priority) ) 

#define IMessage_get_ID(This,ID)	\
    ( (This)->lpVtbl -> get_ID(This,ID) ) 

#define IMessage_get_MessageSource(This,Source)	\
    ( (This)->lpVtbl -> get_MessageSource(This,Source) ) 

#define IMessage_get_MessageHeader(This,Header)	\
    ( (This)->lpVtbl -> get_MessageHeader(This,Header) ) 

#define IMessage_get_Size(This,Size)	\
    ( (This)->lpVtbl -> get_Size(This,Size) ) 

#define IMessage_get_Date(This,Date)	\
    ( (This)->lpVtbl -> get_Date(This,Date) ) 

#define IMessage_get_ToAddress(This,Address)	\
    ( (This)->lpVtbl -> get_ToAddress(This,Address) ) 

#define IMessage_get_CcAddress(This,Address)	\
    ( (This)->lpVtbl -> get_CcAddress(This,Address) ) 

#define IMessage_get_BccAddress(This,Address)	\
    ( (This)->lpVtbl -> get_BccAddress(This,Address) ) 

#define IMessage_get_ImapFlags(This,Flags)	\
    ( (This)->lpVtbl -> get_ImapFlags(This,Flags) ) 

#define IMessage_get_ImapUID(This,Uid)	\
    ( (This)->lpVtbl -> get_ImapUID(This,Uid) ) 

#define IMessage_get_ImapSequenceNumber(This,Uid)	\
    ( (This)->lpVtbl -> get_ImapSequenceNumber(This,Uid) ) 

#define IMessage_put_ImapSequenceNumber(This,Uid)	\
    ( (This)->lpVtbl -> put_ImapSequenceNumber(This,Uid) ) 

#define IMessage_Clear(This)	\
    ( (This)->lpVtbl -> Clear(This) ) 

#define IMessage_GetErrorDescription(This,lError,Description)	\
    ( (This)->lpVtbl -> GetErrorDescription(This,lError,Description) ) 

#define IMessage_AddTo(This,EmailAddress,DisplayName)	\
    ( (This)->lpVtbl -> AddTo(This,EmailAddress,DisplayName) ) 

#define IMessage_AddCc(This,EmailAddress,DisplayName)	\
    ( (This)->lpVtbl -> AddCc(This,EmailAddress,DisplayName) ) 

#define IMessage_AddBcc(This,EmailAddress,DisplayName)	\
    ( (This)->lpVtbl -> AddBcc(This,EmailAddress,DisplayName) ) 

#define IMessage_CountAttachments(This,Count)	\
    ( (This)->lpVtbl -> CountAttachments(This,Count) ) 

#define IMessage_GetAttachmentName(This,ID,Name)	\
    ( (This)->lpVtbl -> GetAttachmentName(This,ID,Name) ) 

#define IMessage_GetAttachmentSize(This,ID,Size)	\
    ( (This)->lpVtbl -> GetAttachmentSize(This,ID,Size) ) 

#define IMessage_AddAttachment(This,FileName,AttachmentName,InlineDisposition)	\
    ( (This)->lpVtbl -> AddAttachment(This,FileName,AttachmentName,InlineDisposition) ) 

#define IMessage_SaveAttachment(This,ID,SaveAsFile)	\
    ( (This)->lpVtbl -> SaveAttachment(This,ID,SaveAsFile) ) 

#define IMessage_ImapHasFlag(This,Flag,__MIDL__IMessage0000)	\
    ( (This)->lpVtbl -> ImapHasFlag(This,Flag,__MIDL__IMessage0000) ) 

#define IMessage_LoadMIME(This,MimeFile)	\
    ( (This)->lpVtbl -> LoadMIME(This,MimeFile) ) 

#define IMessage_SaveMIME(This,MimeFile)	\
    ( (This)->lpVtbl -> SaveMIME(This,MimeFile) ) 

#define IMessage_Encode(This)	\
    ( (This)->lpVtbl -> Encode(This) ) 

#define IMessage_Decode(This)	\
    ( (This)->lpVtbl -> Decode(This) ) 

#define IMessage_GetHeaderValue(This,Name,Value)	\
    ( (This)->lpVtbl -> GetHeaderValue(This,Name,Value) ) 

#define IMessage_AddHeader(This,Name,Value,Enquote)	\
    ( (This)->lpVtbl -> AddHeader(This,Name,Value,Enquote) ) 

#define IMessage_HtmlToPlainText(This,Html,Plain)	\
    ( (This)->lpVtbl -> HtmlToPlainText(This,Html,Plain) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __IMessage_INTERFACE_DEFINED__ */


#ifndef __IOAuth2_INTERFACE_DEFINED__
#define __IOAuth2_INTERFACE_DEFINED__

/* interface IOAuth2 */
/* [unique][helpstring][nonextensible][dual][uuid][object] */ 


EXTERN_C const IID IID_IOAuth2;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("FFB7E17F-EF95-437E-BB93-EF506948AD18")
    IOAuth2 : public IDispatch
    {
    public:
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_Version( 
            /* [retval][out] */ BSTR *Version) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_Build( 
            /* [retval][out] */ BSTR *Build) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_Module( 
            /* [retval][out] */ BSTR *Module) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_LicenseStatus( 
            /* [retval][out] */ BSTR *LicenseStatus) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_LicenseKey( 
            /* [retval][out] */ BSTR *LicenseKey) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_LicenseKey( 
            /* [in] */ BSTR LicenseKey) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE SaveLicenseKey( void) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_LogFile( 
            /* [retval][out] */ BSTR *Logfile) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_LogFile( 
            /* [in] */ BSTR Logfile) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_ActivityFile( 
            /* [retval][out] */ BSTR *ActivityFile) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_ActivityFile( 
            /* [in] */ BSTR ActivityFile) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Sleep( 
            LONG Ms) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Clear( void) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_LastError( 
            /* [retval][out] */ LONG *LastError) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE GetErrorDescription( 
            /* [in] */ LONG ErrorCode,
            /* [retval][out] */ BSTR *Description) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_Flow( 
            /* [retval][out] */ LONG *Val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_AuthCodeUrl( 
            /* [retval][out] */ BSTR *Val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_DeviceCodeUrl( 
            /* [retval][out] */ BSTR *Val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_TokenExchangeUrl( 
            /* [retval][out] */ BSTR *Val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_RedirectUrl( 
            /* [retval][out] */ BSTR *Val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_VerificationUrl( 
            /* [retval][out] */ BSTR *Val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_ClientID( 
            /* [retval][out] */ BSTR *Val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_ClientSecret( 
            /* [retval][out] */ BSTR *Val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_Scope( 
            /* [retval][out] */ BSTR *Val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_SuccessHtml( 
            /* [retval][out] */ BSTR *Val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_ErrorHtml( 
            /* [retval][out] */ BSTR *Val) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_Flow( 
            /* [in] */ LONG Val) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_AuthCodeUrl( 
            /* [in] */ BSTR Val) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_DeviceCodeUrl( 
            /* [in] */ BSTR Val) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_TokenExchangeUrl( 
            /* [in] */ BSTR Val) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_RedirectUrl( 
            /* [in] */ BSTR Val) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_VerificationUrl( 
            /* [in] */ BSTR Val) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_ClientID( 
            /* [in] */ BSTR Val) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_ClientSecret( 
            /* [in] */ BSTR Val) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_Scope( 
            /* [in] */ BSTR Val) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_SuccessHtml( 
            /* [in] */ BSTR Val) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_ErrorHtml( 
            /* [in] */ BSTR Val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_AutoOpenBrowser( 
            /* [retval][out] */ VARIANT_BOOL *Val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_LoginUrl( 
            /* [retval][out] */ BSTR *Val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_DeviceCode( 
            /* [retval][out] */ BSTR *Val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_UserCode( 
            /* [retval][out] */ BSTR *Val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_UserCodeMessage( 
            /* [retval][out] */ BSTR *Val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_BearerToken( 
            /* [retval][out] */ BSTR *Val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_RefreshToken( 
            /* [retval][out] */ BSTR *Val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_BearerExpInSeconds( 
            /* [retval][out] */ LONG *Val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_UserCodeExpInSeconds( 
            /* [retval][out] */ LONG *Val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_PollIntervalInSeconds( 
            /* [retval][out] */ LONG *Val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_LastResponse( 
            /* [retval][out] */ BSTR *Val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_ResultScope( 
            /* [retval][out] */ BSTR *Val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_ResultError( 
            /* [retval][out] */ BSTR *Val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_ResultErrorDescription( 
            /* [retval][out] */ BSTR *Val) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_AutoOpenBrowser( 
            /* [in] */ VARIANT_BOOL Val) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_BearerToken( 
            /* [in] */ BSTR Val) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_RefreshToken( 
            /* [in] */ BSTR Val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_ProxyServer( 
            /* [retval][out] */ BSTR *Val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_ProxyAccount( 
            /* [retval][out] */ BSTR *Val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_ProxyPassword( 
            /* [retval][out] */ BSTR *Val) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_ProxyServer( 
            /* [in] */ BSTR newVal) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_ProxyAccount( 
            /* [in] */ BSTR newVal) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_ProxyPassword( 
            /* [in] */ BSTR newVal) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Login( void) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE WaitForTokens( 
            /* [in] */ LONG nTimeoutMs) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE RefreshBearerToken( void) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct IOAuth2Vtbl
    {
        BEGIN_INTERFACE
        
        DECLSPEC_XFGVIRT(IUnknown, QueryInterface)
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            IOAuth2 * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        DECLSPEC_XFGVIRT(IUnknown, AddRef)
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            IOAuth2 * This);
        
        DECLSPEC_XFGVIRT(IUnknown, Release)
        ULONG ( STDMETHODCALLTYPE *Release )( 
            IOAuth2 * This);
        
        DECLSPEC_XFGVIRT(IDispatch, GetTypeInfoCount)
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfoCount )( 
            IOAuth2 * This,
            /* [out] */ UINT *pctinfo);
        
        DECLSPEC_XFGVIRT(IDispatch, GetTypeInfo)
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfo )( 
            IOAuth2 * This,
            /* [in] */ UINT iTInfo,
            /* [in] */ LCID lcid,
            /* [out] */ ITypeInfo **ppTInfo);
        
        DECLSPEC_XFGVIRT(IDispatch, GetIDsOfNames)
        HRESULT ( STDMETHODCALLTYPE *GetIDsOfNames )( 
            IOAuth2 * This,
            /* [in] */ REFIID riid,
            /* [size_is][in] */ LPOLESTR *rgszNames,
            /* [range][in] */ UINT cNames,
            /* [in] */ LCID lcid,
            /* [size_is][out] */ DISPID *rgDispId);
        
        DECLSPEC_XFGVIRT(IDispatch, Invoke)
        /* [local] */ HRESULT ( STDMETHODCALLTYPE *Invoke )( 
            IOAuth2 * This,
            /* [annotation][in] */ 
            _In_  DISPID dispIdMember,
            /* [annotation][in] */ 
            _In_  REFIID riid,
            /* [annotation][in] */ 
            _In_  LCID lcid,
            /* [annotation][in] */ 
            _In_  WORD wFlags,
            /* [annotation][out][in] */ 
            _In_  DISPPARAMS *pDispParams,
            /* [annotation][out] */ 
            _Out_opt_  VARIANT *pVarResult,
            /* [annotation][out] */ 
            _Out_opt_  EXCEPINFO *pExcepInfo,
            /* [annotation][out] */ 
            _Out_opt_  UINT *puArgErr);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_Version)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Version )( 
            IOAuth2 * This,
            /* [retval][out] */ BSTR *Version);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_Build)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Build )( 
            IOAuth2 * This,
            /* [retval][out] */ BSTR *Build);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_Module)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Module )( 
            IOAuth2 * This,
            /* [retval][out] */ BSTR *Module);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_LicenseStatus)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_LicenseStatus )( 
            IOAuth2 * This,
            /* [retval][out] */ BSTR *LicenseStatus);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_LicenseKey)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_LicenseKey )( 
            IOAuth2 * This,
            /* [retval][out] */ BSTR *LicenseKey);
        
        DECLSPEC_XFGVIRT(IOAuth2, put_LicenseKey)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_LicenseKey )( 
            IOAuth2 * This,
            /* [in] */ BSTR LicenseKey);
        
        DECLSPEC_XFGVIRT(IOAuth2, SaveLicenseKey)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *SaveLicenseKey )( 
            IOAuth2 * This);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_LogFile)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_LogFile )( 
            IOAuth2 * This,
            /* [retval][out] */ BSTR *Logfile);
        
        DECLSPEC_XFGVIRT(IOAuth2, put_LogFile)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_LogFile )( 
            IOAuth2 * This,
            /* [in] */ BSTR Logfile);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_ActivityFile)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_ActivityFile )( 
            IOAuth2 * This,
            /* [retval][out] */ BSTR *ActivityFile);
        
        DECLSPEC_XFGVIRT(IOAuth2, put_ActivityFile)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_ActivityFile )( 
            IOAuth2 * This,
            /* [in] */ BSTR ActivityFile);
        
        DECLSPEC_XFGVIRT(IOAuth2, Sleep)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Sleep )( 
            IOAuth2 * This,
            LONG Ms);
        
        DECLSPEC_XFGVIRT(IOAuth2, Clear)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Clear )( 
            IOAuth2 * This);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_LastError)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_LastError )( 
            IOAuth2 * This,
            /* [retval][out] */ LONG *LastError);
        
        DECLSPEC_XFGVIRT(IOAuth2, GetErrorDescription)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *GetErrorDescription )( 
            IOAuth2 * This,
            /* [in] */ LONG ErrorCode,
            /* [retval][out] */ BSTR *Description);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_Flow)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Flow )( 
            IOAuth2 * This,
            /* [retval][out] */ LONG *Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_AuthCodeUrl)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_AuthCodeUrl )( 
            IOAuth2 * This,
            /* [retval][out] */ BSTR *Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_DeviceCodeUrl)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_DeviceCodeUrl )( 
            IOAuth2 * This,
            /* [retval][out] */ BSTR *Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_TokenExchangeUrl)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_TokenExchangeUrl )( 
            IOAuth2 * This,
            /* [retval][out] */ BSTR *Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_RedirectUrl)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_RedirectUrl )( 
            IOAuth2 * This,
            /* [retval][out] */ BSTR *Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_VerificationUrl)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_VerificationUrl )( 
            IOAuth2 * This,
            /* [retval][out] */ BSTR *Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_ClientID)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_ClientID )( 
            IOAuth2 * This,
            /* [retval][out] */ BSTR *Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_ClientSecret)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_ClientSecret )( 
            IOAuth2 * This,
            /* [retval][out] */ BSTR *Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_Scope)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Scope )( 
            IOAuth2 * This,
            /* [retval][out] */ BSTR *Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_SuccessHtml)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_SuccessHtml )( 
            IOAuth2 * This,
            /* [retval][out] */ BSTR *Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_ErrorHtml)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_ErrorHtml )( 
            IOAuth2 * This,
            /* [retval][out] */ BSTR *Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, put_Flow)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_Flow )( 
            IOAuth2 * This,
            /* [in] */ LONG Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, put_AuthCodeUrl)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_AuthCodeUrl )( 
            IOAuth2 * This,
            /* [in] */ BSTR Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, put_DeviceCodeUrl)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_DeviceCodeUrl )( 
            IOAuth2 * This,
            /* [in] */ BSTR Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, put_TokenExchangeUrl)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_TokenExchangeUrl )( 
            IOAuth2 * This,
            /* [in] */ BSTR Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, put_RedirectUrl)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_RedirectUrl )( 
            IOAuth2 * This,
            /* [in] */ BSTR Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, put_VerificationUrl)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_VerificationUrl )( 
            IOAuth2 * This,
            /* [in] */ BSTR Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, put_ClientID)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_ClientID )( 
            IOAuth2 * This,
            /* [in] */ BSTR Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, put_ClientSecret)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_ClientSecret )( 
            IOAuth2 * This,
            /* [in] */ BSTR Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, put_Scope)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_Scope )( 
            IOAuth2 * This,
            /* [in] */ BSTR Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, put_SuccessHtml)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_SuccessHtml )( 
            IOAuth2 * This,
            /* [in] */ BSTR Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, put_ErrorHtml)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_ErrorHtml )( 
            IOAuth2 * This,
            /* [in] */ BSTR Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_AutoOpenBrowser)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_AutoOpenBrowser )( 
            IOAuth2 * This,
            /* [retval][out] */ VARIANT_BOOL *Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_LoginUrl)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_LoginUrl )( 
            IOAuth2 * This,
            /* [retval][out] */ BSTR *Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_DeviceCode)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_DeviceCode )( 
            IOAuth2 * This,
            /* [retval][out] */ BSTR *Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_UserCode)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_UserCode )( 
            IOAuth2 * This,
            /* [retval][out] */ BSTR *Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_UserCodeMessage)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_UserCodeMessage )( 
            IOAuth2 * This,
            /* [retval][out] */ BSTR *Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_BearerToken)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_BearerToken )( 
            IOAuth2 * This,
            /* [retval][out] */ BSTR *Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_RefreshToken)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_RefreshToken )( 
            IOAuth2 * This,
            /* [retval][out] */ BSTR *Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_BearerExpInSeconds)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_BearerExpInSeconds )( 
            IOAuth2 * This,
            /* [retval][out] */ LONG *Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_UserCodeExpInSeconds)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_UserCodeExpInSeconds )( 
            IOAuth2 * This,
            /* [retval][out] */ LONG *Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_PollIntervalInSeconds)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_PollIntervalInSeconds )( 
            IOAuth2 * This,
            /* [retval][out] */ LONG *Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_LastResponse)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_LastResponse )( 
            IOAuth2 * This,
            /* [retval][out] */ BSTR *Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_ResultScope)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_ResultScope )( 
            IOAuth2 * This,
            /* [retval][out] */ BSTR *Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_ResultError)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_ResultError )( 
            IOAuth2 * This,
            /* [retval][out] */ BSTR *Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_ResultErrorDescription)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_ResultErrorDescription )( 
            IOAuth2 * This,
            /* [retval][out] */ BSTR *Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, put_AutoOpenBrowser)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_AutoOpenBrowser )( 
            IOAuth2 * This,
            /* [in] */ VARIANT_BOOL Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, put_BearerToken)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_BearerToken )( 
            IOAuth2 * This,
            /* [in] */ BSTR Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, put_RefreshToken)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_RefreshToken )( 
            IOAuth2 * This,
            /* [in] */ BSTR Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_ProxyServer)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_ProxyServer )( 
            IOAuth2 * This,
            /* [retval][out] */ BSTR *Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_ProxyAccount)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_ProxyAccount )( 
            IOAuth2 * This,
            /* [retval][out] */ BSTR *Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, get_ProxyPassword)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_ProxyPassword )( 
            IOAuth2 * This,
            /* [retval][out] */ BSTR *Val);
        
        DECLSPEC_XFGVIRT(IOAuth2, put_ProxyServer)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_ProxyServer )( 
            IOAuth2 * This,
            /* [in] */ BSTR newVal);
        
        DECLSPEC_XFGVIRT(IOAuth2, put_ProxyAccount)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_ProxyAccount )( 
            IOAuth2 * This,
            /* [in] */ BSTR newVal);
        
        DECLSPEC_XFGVIRT(IOAuth2, put_ProxyPassword)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_ProxyPassword )( 
            IOAuth2 * This,
            /* [in] */ BSTR newVal);
        
        DECLSPEC_XFGVIRT(IOAuth2, Login)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Login )( 
            IOAuth2 * This);
        
        DECLSPEC_XFGVIRT(IOAuth2, WaitForTokens)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *WaitForTokens )( 
            IOAuth2 * This,
            /* [in] */ LONG nTimeoutMs);
        
        DECLSPEC_XFGVIRT(IOAuth2, RefreshBearerToken)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *RefreshBearerToken )( 
            IOAuth2 * This);
        
        END_INTERFACE
    } IOAuth2Vtbl;

    interface IOAuth2
    {
        CONST_VTBL struct IOAuth2Vtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define IOAuth2_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define IOAuth2_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define IOAuth2_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define IOAuth2_GetTypeInfoCount(This,pctinfo)	\
    ( (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo) ) 

#define IOAuth2_GetTypeInfo(This,iTInfo,lcid,ppTInfo)	\
    ( (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo) ) 

#define IOAuth2_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)	\
    ( (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) ) 

#define IOAuth2_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)	\
    ( (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) ) 


#define IOAuth2_get_Version(This,Version)	\
    ( (This)->lpVtbl -> get_Version(This,Version) ) 

#define IOAuth2_get_Build(This,Build)	\
    ( (This)->lpVtbl -> get_Build(This,Build) ) 

#define IOAuth2_get_Module(This,Module)	\
    ( (This)->lpVtbl -> get_Module(This,Module) ) 

#define IOAuth2_get_LicenseStatus(This,LicenseStatus)	\
    ( (This)->lpVtbl -> get_LicenseStatus(This,LicenseStatus) ) 

#define IOAuth2_get_LicenseKey(This,LicenseKey)	\
    ( (This)->lpVtbl -> get_LicenseKey(This,LicenseKey) ) 

#define IOAuth2_put_LicenseKey(This,LicenseKey)	\
    ( (This)->lpVtbl -> put_LicenseKey(This,LicenseKey) ) 

#define IOAuth2_SaveLicenseKey(This)	\
    ( (This)->lpVtbl -> SaveLicenseKey(This) ) 

#define IOAuth2_get_LogFile(This,Logfile)	\
    ( (This)->lpVtbl -> get_LogFile(This,Logfile) ) 

#define IOAuth2_put_LogFile(This,Logfile)	\
    ( (This)->lpVtbl -> put_LogFile(This,Logfile) ) 

#define IOAuth2_get_ActivityFile(This,ActivityFile)	\
    ( (This)->lpVtbl -> get_ActivityFile(This,ActivityFile) ) 

#define IOAuth2_put_ActivityFile(This,ActivityFile)	\
    ( (This)->lpVtbl -> put_ActivityFile(This,ActivityFile) ) 

#define IOAuth2_Sleep(This,Ms)	\
    ( (This)->lpVtbl -> Sleep(This,Ms) ) 

#define IOAuth2_Clear(This)	\
    ( (This)->lpVtbl -> Clear(This) ) 

#define IOAuth2_get_LastError(This,LastError)	\
    ( (This)->lpVtbl -> get_LastError(This,LastError) ) 

#define IOAuth2_GetErrorDescription(This,ErrorCode,Description)	\
    ( (This)->lpVtbl -> GetErrorDescription(This,ErrorCode,Description) ) 

#define IOAuth2_get_Flow(This,Val)	\
    ( (This)->lpVtbl -> get_Flow(This,Val) ) 

#define IOAuth2_get_AuthCodeUrl(This,Val)	\
    ( (This)->lpVtbl -> get_AuthCodeUrl(This,Val) ) 

#define IOAuth2_get_DeviceCodeUrl(This,Val)	\
    ( (This)->lpVtbl -> get_DeviceCodeUrl(This,Val) ) 

#define IOAuth2_get_TokenExchangeUrl(This,Val)	\
    ( (This)->lpVtbl -> get_TokenExchangeUrl(This,Val) ) 

#define IOAuth2_get_RedirectUrl(This,Val)	\
    ( (This)->lpVtbl -> get_RedirectUrl(This,Val) ) 

#define IOAuth2_get_VerificationUrl(This,Val)	\
    ( (This)->lpVtbl -> get_VerificationUrl(This,Val) ) 

#define IOAuth2_get_ClientID(This,Val)	\
    ( (This)->lpVtbl -> get_ClientID(This,Val) ) 

#define IOAuth2_get_ClientSecret(This,Val)	\
    ( (This)->lpVtbl -> get_ClientSecret(This,Val) ) 

#define IOAuth2_get_Scope(This,Val)	\
    ( (This)->lpVtbl -> get_Scope(This,Val) ) 

#define IOAuth2_get_SuccessHtml(This,Val)	\
    ( (This)->lpVtbl -> get_SuccessHtml(This,Val) ) 

#define IOAuth2_get_ErrorHtml(This,Val)	\
    ( (This)->lpVtbl -> get_ErrorHtml(This,Val) ) 

#define IOAuth2_put_Flow(This,Val)	\
    ( (This)->lpVtbl -> put_Flow(This,Val) ) 

#define IOAuth2_put_AuthCodeUrl(This,Val)	\
    ( (This)->lpVtbl -> put_AuthCodeUrl(This,Val) ) 

#define IOAuth2_put_DeviceCodeUrl(This,Val)	\
    ( (This)->lpVtbl -> put_DeviceCodeUrl(This,Val) ) 

#define IOAuth2_put_TokenExchangeUrl(This,Val)	\
    ( (This)->lpVtbl -> put_TokenExchangeUrl(This,Val) ) 

#define IOAuth2_put_RedirectUrl(This,Val)	\
    ( (This)->lpVtbl -> put_RedirectUrl(This,Val) ) 

#define IOAuth2_put_VerificationUrl(This,Val)	\
    ( (This)->lpVtbl -> put_VerificationUrl(This,Val) ) 

#define IOAuth2_put_ClientID(This,Val)	\
    ( (This)->lpVtbl -> put_ClientID(This,Val) ) 

#define IOAuth2_put_ClientSecret(This,Val)	\
    ( (This)->lpVtbl -> put_ClientSecret(This,Val) ) 

#define IOAuth2_put_Scope(This,Val)	\
    ( (This)->lpVtbl -> put_Scope(This,Val) ) 

#define IOAuth2_put_SuccessHtml(This,Val)	\
    ( (This)->lpVtbl -> put_SuccessHtml(This,Val) ) 

#define IOAuth2_put_ErrorHtml(This,Val)	\
    ( (This)->lpVtbl -> put_ErrorHtml(This,Val) ) 

#define IOAuth2_get_AutoOpenBrowser(This,Val)	\
    ( (This)->lpVtbl -> get_AutoOpenBrowser(This,Val) ) 

#define IOAuth2_get_LoginUrl(This,Val)	\
    ( (This)->lpVtbl -> get_LoginUrl(This,Val) ) 

#define IOAuth2_get_DeviceCode(This,Val)	\
    ( (This)->lpVtbl -> get_DeviceCode(This,Val) ) 

#define IOAuth2_get_UserCode(This,Val)	\
    ( (This)->lpVtbl -> get_UserCode(This,Val) ) 

#define IOAuth2_get_UserCodeMessage(This,Val)	\
    ( (This)->lpVtbl -> get_UserCodeMessage(This,Val) ) 

#define IOAuth2_get_BearerToken(This,Val)	\
    ( (This)->lpVtbl -> get_BearerToken(This,Val) ) 

#define IOAuth2_get_RefreshToken(This,Val)	\
    ( (This)->lpVtbl -> get_RefreshToken(This,Val) ) 

#define IOAuth2_get_BearerExpInSeconds(This,Val)	\
    ( (This)->lpVtbl -> get_BearerExpInSeconds(This,Val) ) 

#define IOAuth2_get_UserCodeExpInSeconds(This,Val)	\
    ( (This)->lpVtbl -> get_UserCodeExpInSeconds(This,Val) ) 

#define IOAuth2_get_PollIntervalInSeconds(This,Val)	\
    ( (This)->lpVtbl -> get_PollIntervalInSeconds(This,Val) ) 

#define IOAuth2_get_LastResponse(This,Val)	\
    ( (This)->lpVtbl -> get_LastResponse(This,Val) ) 

#define IOAuth2_get_ResultScope(This,Val)	\
    ( (This)->lpVtbl -> get_ResultScope(This,Val) ) 

#define IOAuth2_get_ResultError(This,Val)	\
    ( (This)->lpVtbl -> get_ResultError(This,Val) ) 

#define IOAuth2_get_ResultErrorDescription(This,Val)	\
    ( (This)->lpVtbl -> get_ResultErrorDescription(This,Val) ) 

#define IOAuth2_put_AutoOpenBrowser(This,Val)	\
    ( (This)->lpVtbl -> put_AutoOpenBrowser(This,Val) ) 

#define IOAuth2_put_BearerToken(This,Val)	\
    ( (This)->lpVtbl -> put_BearerToken(This,Val) ) 

#define IOAuth2_put_RefreshToken(This,Val)	\
    ( (This)->lpVtbl -> put_RefreshToken(This,Val) ) 

#define IOAuth2_get_ProxyServer(This,Val)	\
    ( (This)->lpVtbl -> get_ProxyServer(This,Val) ) 

#define IOAuth2_get_ProxyAccount(This,Val)	\
    ( (This)->lpVtbl -> get_ProxyAccount(This,Val) ) 

#define IOAuth2_get_ProxyPassword(This,Val)	\
    ( (This)->lpVtbl -> get_ProxyPassword(This,Val) ) 

#define IOAuth2_put_ProxyServer(This,newVal)	\
    ( (This)->lpVtbl -> put_ProxyServer(This,newVal) ) 

#define IOAuth2_put_ProxyAccount(This,newVal)	\
    ( (This)->lpVtbl -> put_ProxyAccount(This,newVal) ) 

#define IOAuth2_put_ProxyPassword(This,newVal)	\
    ( (This)->lpVtbl -> put_ProxyPassword(This,newVal) ) 

#define IOAuth2_Login(This)	\
    ( (This)->lpVtbl -> Login(This) ) 

#define IOAuth2_WaitForTokens(This,nTimeoutMs)	\
    ( (This)->lpVtbl -> WaitForTokens(This,nTimeoutMs) ) 

#define IOAuth2_RefreshBearerToken(This)	\
    ( (This)->lpVtbl -> RefreshBearerToken(This) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __IOAuth2_INTERFACE_DEFINED__ */


#ifndef __ISmtp_INTERFACE_DEFINED__
#define __ISmtp_INTERFACE_DEFINED__

/* interface ISmtp */
/* [unique][helpstring][nonextensible][dual][uuid][object] */ 


EXTERN_C const IID IID_ISmtp;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("FE73AE95-A7C6-4E98-8AF2-CAB94AAE743A")
    ISmtp : public IDispatch
    {
    public:
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_Version( 
            /* [retval][out] */ BSTR *Version) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_Build( 
            /* [retval][out] */ BSTR *Build) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_Module( 
            /* [retval][out] */ BSTR *Module) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_LicenseStatus( 
            /* [retval][out] */ BSTR *LicenseStatus) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_LicenseKey( 
            /* [retval][out] */ BSTR *LicenseKey) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_LicenseKey( 
            /* [in] */ BSTR LicenseKey) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE SaveLicenseKey( void) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_LogFile( 
            /* [retval][out] */ BSTR *Logfile) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_LogFile( 
            /* [in] */ BSTR Logfile) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_ActivityFile( 
            /* [retval][out] */ BSTR *ActivityFile) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_ActivityFile( 
            /* [in] */ BSTR ActivityFile) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Sleep( 
            LONG Ms) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Clear( void) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_LastError( 
            /* [retval][out] */ LONG *LastError) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE GetErrorDescription( 
            /* [in] */ LONG ErrorCode,
            /* [retval][out] */ BSTR *Description) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_TimeoutConnect( 
            /* [retval][out] */ LONG *TimoutMs) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_TimeoutConnect( 
            /* [in] */ LONG TimoutMs) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_TimeoutAuthentication( 
            /* [retval][out] */ LONG *TimoutMs) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_TimeoutAuthentication( 
            /* [in] */ LONG TimoutMs) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_TimeoutCommand( 
            /* [retval][out] */ LONG *TimoutMs) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_TimeoutCommand( 
            /* [in] */ LONG TimoutMs) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_TimeoutData( 
            /* [retval][out] */ LONG *TimoutMs) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_TimeoutData( 
            /* [in] */ LONG TimoutMs) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_HostPort( 
            /* [retval][out] */ LONG *HostPort) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_HostPort( 
            /* [in] */ LONG HostPort) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_Authentication( 
            /* [retval][out] */ LONG *Authentication) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_Authentication( 
            /* [in] */ LONG Authentication) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_UseStartTls( 
            /* [retval][out] */ VARIANT_BOOL *UseStartTls) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_UseStartTls( 
            /* [in] */ VARIANT_BOOL UseStartTls) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IpVersion( 
            /* [retval][out] */ LONG *IpVersion) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_IpVersion( 
            /* [in] */ LONG IpVersion) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_BearerToken( 
            /* [retval][out] */ BSTR *Val) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_BearerToken( 
            /* [in] */ BSTR Val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_LastSmtpResponse( 
            /* [retval][out] */ BSTR *LastSmtpResponse) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE SetSecure( 
            /* [defaultvalue][in] */ LONG Port = 465) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Connect( 
            /* [in] */ BSTR Host,
            /* [defaultvalue][in] */ BSTR Account = (BSTR)L"",
            /* [defaultvalue][in] */ BSTR Password = (BSTR)L"") = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Disconnect( void) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Send( 
            /* [in] */ IMessage *Message) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct ISmtpVtbl
    {
        BEGIN_INTERFACE
        
        DECLSPEC_XFGVIRT(IUnknown, QueryInterface)
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            ISmtp * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        DECLSPEC_XFGVIRT(IUnknown, AddRef)
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            ISmtp * This);
        
        DECLSPEC_XFGVIRT(IUnknown, Release)
        ULONG ( STDMETHODCALLTYPE *Release )( 
            ISmtp * This);
        
        DECLSPEC_XFGVIRT(IDispatch, GetTypeInfoCount)
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfoCount )( 
            ISmtp * This,
            /* [out] */ UINT *pctinfo);
        
        DECLSPEC_XFGVIRT(IDispatch, GetTypeInfo)
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfo )( 
            ISmtp * This,
            /* [in] */ UINT iTInfo,
            /* [in] */ LCID lcid,
            /* [out] */ ITypeInfo **ppTInfo);
        
        DECLSPEC_XFGVIRT(IDispatch, GetIDsOfNames)
        HRESULT ( STDMETHODCALLTYPE *GetIDsOfNames )( 
            ISmtp * This,
            /* [in] */ REFIID riid,
            /* [size_is][in] */ LPOLESTR *rgszNames,
            /* [range][in] */ UINT cNames,
            /* [in] */ LCID lcid,
            /* [size_is][out] */ DISPID *rgDispId);
        
        DECLSPEC_XFGVIRT(IDispatch, Invoke)
        /* [local] */ HRESULT ( STDMETHODCALLTYPE *Invoke )( 
            ISmtp * This,
            /* [annotation][in] */ 
            _In_  DISPID dispIdMember,
            /* [annotation][in] */ 
            _In_  REFIID riid,
            /* [annotation][in] */ 
            _In_  LCID lcid,
            /* [annotation][in] */ 
            _In_  WORD wFlags,
            /* [annotation][out][in] */ 
            _In_  DISPPARAMS *pDispParams,
            /* [annotation][out] */ 
            _Out_opt_  VARIANT *pVarResult,
            /* [annotation][out] */ 
            _Out_opt_  EXCEPINFO *pExcepInfo,
            /* [annotation][out] */ 
            _Out_opt_  UINT *puArgErr);
        
        DECLSPEC_XFGVIRT(ISmtp, get_Version)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Version )( 
            ISmtp * This,
            /* [retval][out] */ BSTR *Version);
        
        DECLSPEC_XFGVIRT(ISmtp, get_Build)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Build )( 
            ISmtp * This,
            /* [retval][out] */ BSTR *Build);
        
        DECLSPEC_XFGVIRT(ISmtp, get_Module)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Module )( 
            ISmtp * This,
            /* [retval][out] */ BSTR *Module);
        
        DECLSPEC_XFGVIRT(ISmtp, get_LicenseStatus)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_LicenseStatus )( 
            ISmtp * This,
            /* [retval][out] */ BSTR *LicenseStatus);
        
        DECLSPEC_XFGVIRT(ISmtp, get_LicenseKey)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_LicenseKey )( 
            ISmtp * This,
            /* [retval][out] */ BSTR *LicenseKey);
        
        DECLSPEC_XFGVIRT(ISmtp, put_LicenseKey)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_LicenseKey )( 
            ISmtp * This,
            /* [in] */ BSTR LicenseKey);
        
        DECLSPEC_XFGVIRT(ISmtp, SaveLicenseKey)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *SaveLicenseKey )( 
            ISmtp * This);
        
        DECLSPEC_XFGVIRT(ISmtp, get_LogFile)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_LogFile )( 
            ISmtp * This,
            /* [retval][out] */ BSTR *Logfile);
        
        DECLSPEC_XFGVIRT(ISmtp, put_LogFile)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_LogFile )( 
            ISmtp * This,
            /* [in] */ BSTR Logfile);
        
        DECLSPEC_XFGVIRT(ISmtp, get_ActivityFile)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_ActivityFile )( 
            ISmtp * This,
            /* [retval][out] */ BSTR *ActivityFile);
        
        DECLSPEC_XFGVIRT(ISmtp, put_ActivityFile)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_ActivityFile )( 
            ISmtp * This,
            /* [in] */ BSTR ActivityFile);
        
        DECLSPEC_XFGVIRT(ISmtp, Sleep)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Sleep )( 
            ISmtp * This,
            LONG Ms);
        
        DECLSPEC_XFGVIRT(ISmtp, Clear)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Clear )( 
            ISmtp * This);
        
        DECLSPEC_XFGVIRT(ISmtp, get_LastError)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_LastError )( 
            ISmtp * This,
            /* [retval][out] */ LONG *LastError);
        
        DECLSPEC_XFGVIRT(ISmtp, GetErrorDescription)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *GetErrorDescription )( 
            ISmtp * This,
            /* [in] */ LONG ErrorCode,
            /* [retval][out] */ BSTR *Description);
        
        DECLSPEC_XFGVIRT(ISmtp, get_TimeoutConnect)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_TimeoutConnect )( 
            ISmtp * This,
            /* [retval][out] */ LONG *TimoutMs);
        
        DECLSPEC_XFGVIRT(ISmtp, put_TimeoutConnect)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_TimeoutConnect )( 
            ISmtp * This,
            /* [in] */ LONG TimoutMs);
        
        DECLSPEC_XFGVIRT(ISmtp, get_TimeoutAuthentication)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_TimeoutAuthentication )( 
            ISmtp * This,
            /* [retval][out] */ LONG *TimoutMs);
        
        DECLSPEC_XFGVIRT(ISmtp, put_TimeoutAuthentication)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_TimeoutAuthentication )( 
            ISmtp * This,
            /* [in] */ LONG TimoutMs);
        
        DECLSPEC_XFGVIRT(ISmtp, get_TimeoutCommand)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_TimeoutCommand )( 
            ISmtp * This,
            /* [retval][out] */ LONG *TimoutMs);
        
        DECLSPEC_XFGVIRT(ISmtp, put_TimeoutCommand)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_TimeoutCommand )( 
            ISmtp * This,
            /* [in] */ LONG TimoutMs);
        
        DECLSPEC_XFGVIRT(ISmtp, get_TimeoutData)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_TimeoutData )( 
            ISmtp * This,
            /* [retval][out] */ LONG *TimoutMs);
        
        DECLSPEC_XFGVIRT(ISmtp, put_TimeoutData)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_TimeoutData )( 
            ISmtp * This,
            /* [in] */ LONG TimoutMs);
        
        DECLSPEC_XFGVIRT(ISmtp, get_HostPort)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_HostPort )( 
            ISmtp * This,
            /* [retval][out] */ LONG *HostPort);
        
        DECLSPEC_XFGVIRT(ISmtp, put_HostPort)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_HostPort )( 
            ISmtp * This,
            /* [in] */ LONG HostPort);
        
        DECLSPEC_XFGVIRT(ISmtp, get_Authentication)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Authentication )( 
            ISmtp * This,
            /* [retval][out] */ LONG *Authentication);
        
        DECLSPEC_XFGVIRT(ISmtp, put_Authentication)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_Authentication )( 
            ISmtp * This,
            /* [in] */ LONG Authentication);
        
        DECLSPEC_XFGVIRT(ISmtp, get_UseStartTls)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_UseStartTls )( 
            ISmtp * This,
            /* [retval][out] */ VARIANT_BOOL *UseStartTls);
        
        DECLSPEC_XFGVIRT(ISmtp, put_UseStartTls)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_UseStartTls )( 
            ISmtp * This,
            /* [in] */ VARIANT_BOOL UseStartTls);
        
        DECLSPEC_XFGVIRT(ISmtp, get_IpVersion)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IpVersion )( 
            ISmtp * This,
            /* [retval][out] */ LONG *IpVersion);
        
        DECLSPEC_XFGVIRT(ISmtp, put_IpVersion)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_IpVersion )( 
            ISmtp * This,
            /* [in] */ LONG IpVersion);
        
        DECLSPEC_XFGVIRT(ISmtp, get_BearerToken)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_BearerToken )( 
            ISmtp * This,
            /* [retval][out] */ BSTR *Val);
        
        DECLSPEC_XFGVIRT(ISmtp, put_BearerToken)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_BearerToken )( 
            ISmtp * This,
            /* [in] */ BSTR Val);
        
        DECLSPEC_XFGVIRT(ISmtp, get_LastSmtpResponse)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_LastSmtpResponse )( 
            ISmtp * This,
            /* [retval][out] */ BSTR *LastSmtpResponse);
        
        DECLSPEC_XFGVIRT(ISmtp, SetSecure)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *SetSecure )( 
            ISmtp * This,
            /* [defaultvalue][in] */ LONG Port);
        
        DECLSPEC_XFGVIRT(ISmtp, Connect)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Connect )( 
            ISmtp * This,
            /* [in] */ BSTR Host,
            /* [defaultvalue][in] */ BSTR Account,
            /* [defaultvalue][in] */ BSTR Password);
        
        DECLSPEC_XFGVIRT(ISmtp, Disconnect)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Disconnect )( 
            ISmtp * This);
        
        DECLSPEC_XFGVIRT(ISmtp, Send)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Send )( 
            ISmtp * This,
            /* [in] */ IMessage *Message);
        
        END_INTERFACE
    } ISmtpVtbl;

    interface ISmtp
    {
        CONST_VTBL struct ISmtpVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define ISmtp_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define ISmtp_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define ISmtp_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define ISmtp_GetTypeInfoCount(This,pctinfo)	\
    ( (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo) ) 

#define ISmtp_GetTypeInfo(This,iTInfo,lcid,ppTInfo)	\
    ( (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo) ) 

#define ISmtp_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)	\
    ( (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) ) 

#define ISmtp_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)	\
    ( (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) ) 


#define ISmtp_get_Version(This,Version)	\
    ( (This)->lpVtbl -> get_Version(This,Version) ) 

#define ISmtp_get_Build(This,Build)	\
    ( (This)->lpVtbl -> get_Build(This,Build) ) 

#define ISmtp_get_Module(This,Module)	\
    ( (This)->lpVtbl -> get_Module(This,Module) ) 

#define ISmtp_get_LicenseStatus(This,LicenseStatus)	\
    ( (This)->lpVtbl -> get_LicenseStatus(This,LicenseStatus) ) 

#define ISmtp_get_LicenseKey(This,LicenseKey)	\
    ( (This)->lpVtbl -> get_LicenseKey(This,LicenseKey) ) 

#define ISmtp_put_LicenseKey(This,LicenseKey)	\
    ( (This)->lpVtbl -> put_LicenseKey(This,LicenseKey) ) 

#define ISmtp_SaveLicenseKey(This)	\
    ( (This)->lpVtbl -> SaveLicenseKey(This) ) 

#define ISmtp_get_LogFile(This,Logfile)	\
    ( (This)->lpVtbl -> get_LogFile(This,Logfile) ) 

#define ISmtp_put_LogFile(This,Logfile)	\
    ( (This)->lpVtbl -> put_LogFile(This,Logfile) ) 

#define ISmtp_get_ActivityFile(This,ActivityFile)	\
    ( (This)->lpVtbl -> get_ActivityFile(This,ActivityFile) ) 

#define ISmtp_put_ActivityFile(This,ActivityFile)	\
    ( (This)->lpVtbl -> put_ActivityFile(This,ActivityFile) ) 

#define ISmtp_Sleep(This,Ms)	\
    ( (This)->lpVtbl -> Sleep(This,Ms) ) 

#define ISmtp_Clear(This)	\
    ( (This)->lpVtbl -> Clear(This) ) 

#define ISmtp_get_LastError(This,LastError)	\
    ( (This)->lpVtbl -> get_LastError(This,LastError) ) 

#define ISmtp_GetErrorDescription(This,ErrorCode,Description)	\
    ( (This)->lpVtbl -> GetErrorDescription(This,ErrorCode,Description) ) 

#define ISmtp_get_TimeoutConnect(This,TimoutMs)	\
    ( (This)->lpVtbl -> get_TimeoutConnect(This,TimoutMs) ) 

#define ISmtp_put_TimeoutConnect(This,TimoutMs)	\
    ( (This)->lpVtbl -> put_TimeoutConnect(This,TimoutMs) ) 

#define ISmtp_get_TimeoutAuthentication(This,TimoutMs)	\
    ( (This)->lpVtbl -> get_TimeoutAuthentication(This,TimoutMs) ) 

#define ISmtp_put_TimeoutAuthentication(This,TimoutMs)	\
    ( (This)->lpVtbl -> put_TimeoutAuthentication(This,TimoutMs) ) 

#define ISmtp_get_TimeoutCommand(This,TimoutMs)	\
    ( (This)->lpVtbl -> get_TimeoutCommand(This,TimoutMs) ) 

#define ISmtp_put_TimeoutCommand(This,TimoutMs)	\
    ( (This)->lpVtbl -> put_TimeoutCommand(This,TimoutMs) ) 

#define ISmtp_get_TimeoutData(This,TimoutMs)	\
    ( (This)->lpVtbl -> get_TimeoutData(This,TimoutMs) ) 

#define ISmtp_put_TimeoutData(This,TimoutMs)	\
    ( (This)->lpVtbl -> put_TimeoutData(This,TimoutMs) ) 

#define ISmtp_get_HostPort(This,HostPort)	\
    ( (This)->lpVtbl -> get_HostPort(This,HostPort) ) 

#define ISmtp_put_HostPort(This,HostPort)	\
    ( (This)->lpVtbl -> put_HostPort(This,HostPort) ) 

#define ISmtp_get_Authentication(This,Authentication)	\
    ( (This)->lpVtbl -> get_Authentication(This,Authentication) ) 

#define ISmtp_put_Authentication(This,Authentication)	\
    ( (This)->lpVtbl -> put_Authentication(This,Authentication) ) 

#define ISmtp_get_UseStartTls(This,UseStartTls)	\
    ( (This)->lpVtbl -> get_UseStartTls(This,UseStartTls) ) 

#define ISmtp_put_UseStartTls(This,UseStartTls)	\
    ( (This)->lpVtbl -> put_UseStartTls(This,UseStartTls) ) 

#define ISmtp_get_IpVersion(This,IpVersion)	\
    ( (This)->lpVtbl -> get_IpVersion(This,IpVersion) ) 

#define ISmtp_put_IpVersion(This,IpVersion)	\
    ( (This)->lpVtbl -> put_IpVersion(This,IpVersion) ) 

#define ISmtp_get_BearerToken(This,Val)	\
    ( (This)->lpVtbl -> get_BearerToken(This,Val) ) 

#define ISmtp_put_BearerToken(This,Val)	\
    ( (This)->lpVtbl -> put_BearerToken(This,Val) ) 

#define ISmtp_get_LastSmtpResponse(This,LastSmtpResponse)	\
    ( (This)->lpVtbl -> get_LastSmtpResponse(This,LastSmtpResponse) ) 

#define ISmtp_SetSecure(This,Port)	\
    ( (This)->lpVtbl -> SetSecure(This,Port) ) 

#define ISmtp_Connect(This,Host,Account,Password)	\
    ( (This)->lpVtbl -> Connect(This,Host,Account,Password) ) 

#define ISmtp_Disconnect(This)	\
    ( (This)->lpVtbl -> Disconnect(This) ) 

#define ISmtp_Send(This,Message)	\
    ( (This)->lpVtbl -> Send(This,Message) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __ISmtp_INTERFACE_DEFINED__ */


#ifndef __IPop3_INTERFACE_DEFINED__
#define __IPop3_INTERFACE_DEFINED__

/* interface IPop3 */
/* [unique][helpstring][nonextensible][dual][uuid][object] */ 


EXTERN_C const IID IID_IPop3;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("7D24A1B3-4808-4208-9A9F-2A281256744A")
    IPop3 : public IDispatch
    {
    public:
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_Version( 
            /* [retval][out] */ BSTR *Version) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_Build( 
            /* [retval][out] */ BSTR *Build) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_Module( 
            /* [retval][out] */ BSTR *Module) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_LicenseStatus( 
            /* [retval][out] */ BSTR *LicenseStatus) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_LicenseKey( 
            /* [retval][out] */ BSTR *LicenseKey) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_LicenseKey( 
            /* [in] */ BSTR LicenseKey) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE SaveLicenseKey( void) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_LogFile( 
            /* [retval][out] */ BSTR *Logfile) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_LogFile( 
            /* [in] */ BSTR Logfile) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_ActivityFile( 
            /* [retval][out] */ BSTR *ActivityFile) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_ActivityFile( 
            /* [in] */ BSTR ActivityFile) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Sleep( 
            LONG Ms) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Clear( void) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_LastError( 
            /* [retval][out] */ LONG *LastError) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE GetErrorDescription( 
            /* [in] */ LONG ErrorCode,
            /* [retval][out] */ BSTR *Description) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_TimeoutConnect( 
            /* [retval][out] */ LONG *TimoutMs) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_TimeoutConnect( 
            /* [in] */ LONG TimoutMs) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_TimeoutAuthentication( 
            /* [retval][out] */ LONG *TimoutMs) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_TimeoutAuthentication( 
            /* [in] */ LONG TimoutMs) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_TimeoutCommand( 
            /* [retval][out] */ LONG *TimoutMs) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_TimeoutCommand( 
            /* [in] */ LONG TimoutMs) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_TimeoutData( 
            /* [retval][out] */ LONG *TimoutMs) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_TimeoutData( 
            /* [in] */ LONG TimoutMs) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_HostPort( 
            /* [retval][out] */ LONG *HostPort) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_HostPort( 
            /* [in] */ LONG HostPort) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_Authentication( 
            /* [retval][out] */ LONG *Authentication) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_Authentication( 
            /* [in] */ LONG Authentication) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IpVersion( 
            /* [retval][out] */ LONG *IpVersion) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_IpVersion( 
            /* [in] */ LONG IpVersion) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_LastPop3Response( 
            /* [retval][out] */ BSTR *LastPop3Response) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_BearerToken( 
            /* [retval][out] */ BSTR *Val) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_BearerToken( 
            /* [in] */ BSTR Val) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE SetSecure( 
            /* [defaultvalue][in] */ LONG Port = 995) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Connect( 
            /* [in] */ BSTR Host,
            /* [in] */ BSTR Account,
            /* [defaultvalue][in] */ BSTR Password = (BSTR)L"") = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Disconnect( void) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE IsConnected( 
            /* [retval][out] */ VARIANT_BOOL *IsConnected) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE CountMessages( 
            /* [retval][out] */ LONG *Count) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE GetEmailHeader( 
            LONG ID,
            /* [retval][out] */ IMessage **Header) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE GetEmailMessage( 
            /* [in] */ LONG lID,
            /* [retval][out] */ IMessage **Message) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE DeleteMessage( 
            LONG ID) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct IPop3Vtbl
    {
        BEGIN_INTERFACE
        
        DECLSPEC_XFGVIRT(IUnknown, QueryInterface)
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            IPop3 * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        DECLSPEC_XFGVIRT(IUnknown, AddRef)
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            IPop3 * This);
        
        DECLSPEC_XFGVIRT(IUnknown, Release)
        ULONG ( STDMETHODCALLTYPE *Release )( 
            IPop3 * This);
        
        DECLSPEC_XFGVIRT(IDispatch, GetTypeInfoCount)
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfoCount )( 
            IPop3 * This,
            /* [out] */ UINT *pctinfo);
        
        DECLSPEC_XFGVIRT(IDispatch, GetTypeInfo)
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfo )( 
            IPop3 * This,
            /* [in] */ UINT iTInfo,
            /* [in] */ LCID lcid,
            /* [out] */ ITypeInfo **ppTInfo);
        
        DECLSPEC_XFGVIRT(IDispatch, GetIDsOfNames)
        HRESULT ( STDMETHODCALLTYPE *GetIDsOfNames )( 
            IPop3 * This,
            /* [in] */ REFIID riid,
            /* [size_is][in] */ LPOLESTR *rgszNames,
            /* [range][in] */ UINT cNames,
            /* [in] */ LCID lcid,
            /* [size_is][out] */ DISPID *rgDispId);
        
        DECLSPEC_XFGVIRT(IDispatch, Invoke)
        /* [local] */ HRESULT ( STDMETHODCALLTYPE *Invoke )( 
            IPop3 * This,
            /* [annotation][in] */ 
            _In_  DISPID dispIdMember,
            /* [annotation][in] */ 
            _In_  REFIID riid,
            /* [annotation][in] */ 
            _In_  LCID lcid,
            /* [annotation][in] */ 
            _In_  WORD wFlags,
            /* [annotation][out][in] */ 
            _In_  DISPPARAMS *pDispParams,
            /* [annotation][out] */ 
            _Out_opt_  VARIANT *pVarResult,
            /* [annotation][out] */ 
            _Out_opt_  EXCEPINFO *pExcepInfo,
            /* [annotation][out] */ 
            _Out_opt_  UINT *puArgErr);
        
        DECLSPEC_XFGVIRT(IPop3, get_Version)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Version )( 
            IPop3 * This,
            /* [retval][out] */ BSTR *Version);
        
        DECLSPEC_XFGVIRT(IPop3, get_Build)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Build )( 
            IPop3 * This,
            /* [retval][out] */ BSTR *Build);
        
        DECLSPEC_XFGVIRT(IPop3, get_Module)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Module )( 
            IPop3 * This,
            /* [retval][out] */ BSTR *Module);
        
        DECLSPEC_XFGVIRT(IPop3, get_LicenseStatus)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_LicenseStatus )( 
            IPop3 * This,
            /* [retval][out] */ BSTR *LicenseStatus);
        
        DECLSPEC_XFGVIRT(IPop3, get_LicenseKey)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_LicenseKey )( 
            IPop3 * This,
            /* [retval][out] */ BSTR *LicenseKey);
        
        DECLSPEC_XFGVIRT(IPop3, put_LicenseKey)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_LicenseKey )( 
            IPop3 * This,
            /* [in] */ BSTR LicenseKey);
        
        DECLSPEC_XFGVIRT(IPop3, SaveLicenseKey)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *SaveLicenseKey )( 
            IPop3 * This);
        
        DECLSPEC_XFGVIRT(IPop3, get_LogFile)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_LogFile )( 
            IPop3 * This,
            /* [retval][out] */ BSTR *Logfile);
        
        DECLSPEC_XFGVIRT(IPop3, put_LogFile)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_LogFile )( 
            IPop3 * This,
            /* [in] */ BSTR Logfile);
        
        DECLSPEC_XFGVIRT(IPop3, get_ActivityFile)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_ActivityFile )( 
            IPop3 * This,
            /* [retval][out] */ BSTR *ActivityFile);
        
        DECLSPEC_XFGVIRT(IPop3, put_ActivityFile)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_ActivityFile )( 
            IPop3 * This,
            /* [in] */ BSTR ActivityFile);
        
        DECLSPEC_XFGVIRT(IPop3, Sleep)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Sleep )( 
            IPop3 * This,
            LONG Ms);
        
        DECLSPEC_XFGVIRT(IPop3, Clear)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Clear )( 
            IPop3 * This);
        
        DECLSPEC_XFGVIRT(IPop3, get_LastError)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_LastError )( 
            IPop3 * This,
            /* [retval][out] */ LONG *LastError);
        
        DECLSPEC_XFGVIRT(IPop3, GetErrorDescription)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *GetErrorDescription )( 
            IPop3 * This,
            /* [in] */ LONG ErrorCode,
            /* [retval][out] */ BSTR *Description);
        
        DECLSPEC_XFGVIRT(IPop3, get_TimeoutConnect)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_TimeoutConnect )( 
            IPop3 * This,
            /* [retval][out] */ LONG *TimoutMs);
        
        DECLSPEC_XFGVIRT(IPop3, put_TimeoutConnect)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_TimeoutConnect )( 
            IPop3 * This,
            /* [in] */ LONG TimoutMs);
        
        DECLSPEC_XFGVIRT(IPop3, get_TimeoutAuthentication)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_TimeoutAuthentication )( 
            IPop3 * This,
            /* [retval][out] */ LONG *TimoutMs);
        
        DECLSPEC_XFGVIRT(IPop3, put_TimeoutAuthentication)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_TimeoutAuthentication )( 
            IPop3 * This,
            /* [in] */ LONG TimoutMs);
        
        DECLSPEC_XFGVIRT(IPop3, get_TimeoutCommand)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_TimeoutCommand )( 
            IPop3 * This,
            /* [retval][out] */ LONG *TimoutMs);
        
        DECLSPEC_XFGVIRT(IPop3, put_TimeoutCommand)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_TimeoutCommand )( 
            IPop3 * This,
            /* [in] */ LONG TimoutMs);
        
        DECLSPEC_XFGVIRT(IPop3, get_TimeoutData)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_TimeoutData )( 
            IPop3 * This,
            /* [retval][out] */ LONG *TimoutMs);
        
        DECLSPEC_XFGVIRT(IPop3, put_TimeoutData)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_TimeoutData )( 
            IPop3 * This,
            /* [in] */ LONG TimoutMs);
        
        DECLSPEC_XFGVIRT(IPop3, get_HostPort)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_HostPort )( 
            IPop3 * This,
            /* [retval][out] */ LONG *HostPort);
        
        DECLSPEC_XFGVIRT(IPop3, put_HostPort)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_HostPort )( 
            IPop3 * This,
            /* [in] */ LONG HostPort);
        
        DECLSPEC_XFGVIRT(IPop3, get_Authentication)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Authentication )( 
            IPop3 * This,
            /* [retval][out] */ LONG *Authentication);
        
        DECLSPEC_XFGVIRT(IPop3, put_Authentication)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_Authentication )( 
            IPop3 * This,
            /* [in] */ LONG Authentication);
        
        DECLSPEC_XFGVIRT(IPop3, get_IpVersion)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IpVersion )( 
            IPop3 * This,
            /* [retval][out] */ LONG *IpVersion);
        
        DECLSPEC_XFGVIRT(IPop3, put_IpVersion)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_IpVersion )( 
            IPop3 * This,
            /* [in] */ LONG IpVersion);
        
        DECLSPEC_XFGVIRT(IPop3, get_LastPop3Response)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_LastPop3Response )( 
            IPop3 * This,
            /* [retval][out] */ BSTR *LastPop3Response);
        
        DECLSPEC_XFGVIRT(IPop3, get_BearerToken)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_BearerToken )( 
            IPop3 * This,
            /* [retval][out] */ BSTR *Val);
        
        DECLSPEC_XFGVIRT(IPop3, put_BearerToken)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_BearerToken )( 
            IPop3 * This,
            /* [in] */ BSTR Val);
        
        DECLSPEC_XFGVIRT(IPop3, SetSecure)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *SetSecure )( 
            IPop3 * This,
            /* [defaultvalue][in] */ LONG Port);
        
        DECLSPEC_XFGVIRT(IPop3, Connect)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Connect )( 
            IPop3 * This,
            /* [in] */ BSTR Host,
            /* [in] */ BSTR Account,
            /* [defaultvalue][in] */ BSTR Password);
        
        DECLSPEC_XFGVIRT(IPop3, Disconnect)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Disconnect )( 
            IPop3 * This);
        
        DECLSPEC_XFGVIRT(IPop3, IsConnected)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *IsConnected )( 
            IPop3 * This,
            /* [retval][out] */ VARIANT_BOOL *IsConnected);
        
        DECLSPEC_XFGVIRT(IPop3, CountMessages)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *CountMessages )( 
            IPop3 * This,
            /* [retval][out] */ LONG *Count);
        
        DECLSPEC_XFGVIRT(IPop3, GetEmailHeader)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *GetEmailHeader )( 
            IPop3 * This,
            LONG ID,
            /* [retval][out] */ IMessage **Header);
        
        DECLSPEC_XFGVIRT(IPop3, GetEmailMessage)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *GetEmailMessage )( 
            IPop3 * This,
            /* [in] */ LONG lID,
            /* [retval][out] */ IMessage **Message);
        
        DECLSPEC_XFGVIRT(IPop3, DeleteMessage)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *DeleteMessage )( 
            IPop3 * This,
            LONG ID);
        
        END_INTERFACE
    } IPop3Vtbl;

    interface IPop3
    {
        CONST_VTBL struct IPop3Vtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define IPop3_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define IPop3_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define IPop3_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define IPop3_GetTypeInfoCount(This,pctinfo)	\
    ( (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo) ) 

#define IPop3_GetTypeInfo(This,iTInfo,lcid,ppTInfo)	\
    ( (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo) ) 

#define IPop3_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)	\
    ( (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) ) 

#define IPop3_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)	\
    ( (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) ) 


#define IPop3_get_Version(This,Version)	\
    ( (This)->lpVtbl -> get_Version(This,Version) ) 

#define IPop3_get_Build(This,Build)	\
    ( (This)->lpVtbl -> get_Build(This,Build) ) 

#define IPop3_get_Module(This,Module)	\
    ( (This)->lpVtbl -> get_Module(This,Module) ) 

#define IPop3_get_LicenseStatus(This,LicenseStatus)	\
    ( (This)->lpVtbl -> get_LicenseStatus(This,LicenseStatus) ) 

#define IPop3_get_LicenseKey(This,LicenseKey)	\
    ( (This)->lpVtbl -> get_LicenseKey(This,LicenseKey) ) 

#define IPop3_put_LicenseKey(This,LicenseKey)	\
    ( (This)->lpVtbl -> put_LicenseKey(This,LicenseKey) ) 

#define IPop3_SaveLicenseKey(This)	\
    ( (This)->lpVtbl -> SaveLicenseKey(This) ) 

#define IPop3_get_LogFile(This,Logfile)	\
    ( (This)->lpVtbl -> get_LogFile(This,Logfile) ) 

#define IPop3_put_LogFile(This,Logfile)	\
    ( (This)->lpVtbl -> put_LogFile(This,Logfile) ) 

#define IPop3_get_ActivityFile(This,ActivityFile)	\
    ( (This)->lpVtbl -> get_ActivityFile(This,ActivityFile) ) 

#define IPop3_put_ActivityFile(This,ActivityFile)	\
    ( (This)->lpVtbl -> put_ActivityFile(This,ActivityFile) ) 

#define IPop3_Sleep(This,Ms)	\
    ( (This)->lpVtbl -> Sleep(This,Ms) ) 

#define IPop3_Clear(This)	\
    ( (This)->lpVtbl -> Clear(This) ) 

#define IPop3_get_LastError(This,LastError)	\
    ( (This)->lpVtbl -> get_LastError(This,LastError) ) 

#define IPop3_GetErrorDescription(This,ErrorCode,Description)	\
    ( (This)->lpVtbl -> GetErrorDescription(This,ErrorCode,Description) ) 

#define IPop3_get_TimeoutConnect(This,TimoutMs)	\
    ( (This)->lpVtbl -> get_TimeoutConnect(This,TimoutMs) ) 

#define IPop3_put_TimeoutConnect(This,TimoutMs)	\
    ( (This)->lpVtbl -> put_TimeoutConnect(This,TimoutMs) ) 

#define IPop3_get_TimeoutAuthentication(This,TimoutMs)	\
    ( (This)->lpVtbl -> get_TimeoutAuthentication(This,TimoutMs) ) 

#define IPop3_put_TimeoutAuthentication(This,TimoutMs)	\
    ( (This)->lpVtbl -> put_TimeoutAuthentication(This,TimoutMs) ) 

#define IPop3_get_TimeoutCommand(This,TimoutMs)	\
    ( (This)->lpVtbl -> get_TimeoutCommand(This,TimoutMs) ) 

#define IPop3_put_TimeoutCommand(This,TimoutMs)	\
    ( (This)->lpVtbl -> put_TimeoutCommand(This,TimoutMs) ) 

#define IPop3_get_TimeoutData(This,TimoutMs)	\
    ( (This)->lpVtbl -> get_TimeoutData(This,TimoutMs) ) 

#define IPop3_put_TimeoutData(This,TimoutMs)	\
    ( (This)->lpVtbl -> put_TimeoutData(This,TimoutMs) ) 

#define IPop3_get_HostPort(This,HostPort)	\
    ( (This)->lpVtbl -> get_HostPort(This,HostPort) ) 

#define IPop3_put_HostPort(This,HostPort)	\
    ( (This)->lpVtbl -> put_HostPort(This,HostPort) ) 

#define IPop3_get_Authentication(This,Authentication)	\
    ( (This)->lpVtbl -> get_Authentication(This,Authentication) ) 

#define IPop3_put_Authentication(This,Authentication)	\
    ( (This)->lpVtbl -> put_Authentication(This,Authentication) ) 

#define IPop3_get_IpVersion(This,IpVersion)	\
    ( (This)->lpVtbl -> get_IpVersion(This,IpVersion) ) 

#define IPop3_put_IpVersion(This,IpVersion)	\
    ( (This)->lpVtbl -> put_IpVersion(This,IpVersion) ) 

#define IPop3_get_LastPop3Response(This,LastPop3Response)	\
    ( (This)->lpVtbl -> get_LastPop3Response(This,LastPop3Response) ) 

#define IPop3_get_BearerToken(This,Val)	\
    ( (This)->lpVtbl -> get_BearerToken(This,Val) ) 

#define IPop3_put_BearerToken(This,Val)	\
    ( (This)->lpVtbl -> put_BearerToken(This,Val) ) 

#define IPop3_SetSecure(This,Port)	\
    ( (This)->lpVtbl -> SetSecure(This,Port) ) 

#define IPop3_Connect(This,Host,Account,Password)	\
    ( (This)->lpVtbl -> Connect(This,Host,Account,Password) ) 

#define IPop3_Disconnect(This)	\
    ( (This)->lpVtbl -> Disconnect(This) ) 

#define IPop3_IsConnected(This,IsConnected)	\
    ( (This)->lpVtbl -> IsConnected(This,IsConnected) ) 

#define IPop3_CountMessages(This,Count)	\
    ( (This)->lpVtbl -> CountMessages(This,Count) ) 

#define IPop3_GetEmailHeader(This,ID,Header)	\
    ( (This)->lpVtbl -> GetEmailHeader(This,ID,Header) ) 

#define IPop3_GetEmailMessage(This,lID,Message)	\
    ( (This)->lpVtbl -> GetEmailMessage(This,lID,Message) ) 

#define IPop3_DeleteMessage(This,ID)	\
    ( (This)->lpVtbl -> DeleteMessage(This,ID) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __IPop3_INTERFACE_DEFINED__ */


#ifndef __IImapFetchData_INTERFACE_DEFINED__
#define __IImapFetchData_INTERFACE_DEFINED__

/* interface IImapFetchData */
/* [unique][helpstring][nonextensible][dual][uuid][object] */ 


EXTERN_C const IID IID_IImapFetchData;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("E867B037-8B16-4C91-B4F3-91A5A5B9032F")
    IImapFetchData : public IDispatch
    {
    public:
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IsTopLevel( 
            /* [retval][out] */ VARIANT_BOOL *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_Type( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_Value( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_ValueAsInt( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_Text( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE GetSubDataCount( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE GetSubData( 
            /* [in] */ LONG lIdx,
            /* [retval][out] */ IImapFetchData **pVal) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE GetSubDataByName( 
            /* [in] */ BSTR Val,
            /* [retval][out] */ IImapFetchData **pVal) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE ContainsValue( 
            /* [in] */ BSTR Val,
            /* [retval][out] */ VARIANT_BOOL *pVal) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE ContainsIntValue( 
            /* [in] */ LONG Val,
            /* [retval][out] */ VARIANT_BOOL *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_LastError( 
            /* [retval][out] */ LONG *LastError) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE GetErrorDescription( 
            /* [in] */ LONG ErrorCode,
            /* [retval][out] */ BSTR *Description) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_Sequence( 
            /* [retval][out] */ LONG *pVal) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct IImapFetchDataVtbl
    {
        BEGIN_INTERFACE
        
        DECLSPEC_XFGVIRT(IUnknown, QueryInterface)
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            IImapFetchData * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        DECLSPEC_XFGVIRT(IUnknown, AddRef)
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            IImapFetchData * This);
        
        DECLSPEC_XFGVIRT(IUnknown, Release)
        ULONG ( STDMETHODCALLTYPE *Release )( 
            IImapFetchData * This);
        
        DECLSPEC_XFGVIRT(IDispatch, GetTypeInfoCount)
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfoCount )( 
            IImapFetchData * This,
            /* [out] */ UINT *pctinfo);
        
        DECLSPEC_XFGVIRT(IDispatch, GetTypeInfo)
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfo )( 
            IImapFetchData * This,
            /* [in] */ UINT iTInfo,
            /* [in] */ LCID lcid,
            /* [out] */ ITypeInfo **ppTInfo);
        
        DECLSPEC_XFGVIRT(IDispatch, GetIDsOfNames)
        HRESULT ( STDMETHODCALLTYPE *GetIDsOfNames )( 
            IImapFetchData * This,
            /* [in] */ REFIID riid,
            /* [size_is][in] */ LPOLESTR *rgszNames,
            /* [range][in] */ UINT cNames,
            /* [in] */ LCID lcid,
            /* [size_is][out] */ DISPID *rgDispId);
        
        DECLSPEC_XFGVIRT(IDispatch, Invoke)
        /* [local] */ HRESULT ( STDMETHODCALLTYPE *Invoke )( 
            IImapFetchData * This,
            /* [annotation][in] */ 
            _In_  DISPID dispIdMember,
            /* [annotation][in] */ 
            _In_  REFIID riid,
            /* [annotation][in] */ 
            _In_  LCID lcid,
            /* [annotation][in] */ 
            _In_  WORD wFlags,
            /* [annotation][out][in] */ 
            _In_  DISPPARAMS *pDispParams,
            /* [annotation][out] */ 
            _Out_opt_  VARIANT *pVarResult,
            /* [annotation][out] */ 
            _Out_opt_  EXCEPINFO *pExcepInfo,
            /* [annotation][out] */ 
            _Out_opt_  UINT *puArgErr);
        
        DECLSPEC_XFGVIRT(IImapFetchData, get_IsTopLevel)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IsTopLevel )( 
            IImapFetchData * This,
            /* [retval][out] */ VARIANT_BOOL *pVal);
        
        DECLSPEC_XFGVIRT(IImapFetchData, get_Type)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Type )( 
            IImapFetchData * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IImapFetchData, get_Value)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Value )( 
            IImapFetchData * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IImapFetchData, get_ValueAsInt)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_ValueAsInt )( 
            IImapFetchData * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IImapFetchData, get_Text)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Text )( 
            IImapFetchData * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IImapFetchData, GetSubDataCount)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *GetSubDataCount )( 
            IImapFetchData * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IImapFetchData, GetSubData)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *GetSubData )( 
            IImapFetchData * This,
            /* [in] */ LONG lIdx,
            /* [retval][out] */ IImapFetchData **pVal);
        
        DECLSPEC_XFGVIRT(IImapFetchData, GetSubDataByName)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *GetSubDataByName )( 
            IImapFetchData * This,
            /* [in] */ BSTR Val,
            /* [retval][out] */ IImapFetchData **pVal);
        
        DECLSPEC_XFGVIRT(IImapFetchData, ContainsValue)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *ContainsValue )( 
            IImapFetchData * This,
            /* [in] */ BSTR Val,
            /* [retval][out] */ VARIANT_BOOL *pVal);
        
        DECLSPEC_XFGVIRT(IImapFetchData, ContainsIntValue)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *ContainsIntValue )( 
            IImapFetchData * This,
            /* [in] */ LONG Val,
            /* [retval][out] */ VARIANT_BOOL *pVal);
        
        DECLSPEC_XFGVIRT(IImapFetchData, get_LastError)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_LastError )( 
            IImapFetchData * This,
            /* [retval][out] */ LONG *LastError);
        
        DECLSPEC_XFGVIRT(IImapFetchData, GetErrorDescription)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *GetErrorDescription )( 
            IImapFetchData * This,
            /* [in] */ LONG ErrorCode,
            /* [retval][out] */ BSTR *Description);
        
        DECLSPEC_XFGVIRT(IImapFetchData, get_Sequence)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Sequence )( 
            IImapFetchData * This,
            /* [retval][out] */ LONG *pVal);
        
        END_INTERFACE
    } IImapFetchDataVtbl;

    interface IImapFetchData
    {
        CONST_VTBL struct IImapFetchDataVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define IImapFetchData_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define IImapFetchData_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define IImapFetchData_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define IImapFetchData_GetTypeInfoCount(This,pctinfo)	\
    ( (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo) ) 

#define IImapFetchData_GetTypeInfo(This,iTInfo,lcid,ppTInfo)	\
    ( (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo) ) 

#define IImapFetchData_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)	\
    ( (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) ) 

#define IImapFetchData_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)	\
    ( (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) ) 


#define IImapFetchData_get_IsTopLevel(This,pVal)	\
    ( (This)->lpVtbl -> get_IsTopLevel(This,pVal) ) 

#define IImapFetchData_get_Type(This,pVal)	\
    ( (This)->lpVtbl -> get_Type(This,pVal) ) 

#define IImapFetchData_get_Value(This,pVal)	\
    ( (This)->lpVtbl -> get_Value(This,pVal) ) 

#define IImapFetchData_get_ValueAsInt(This,pVal)	\
    ( (This)->lpVtbl -> get_ValueAsInt(This,pVal) ) 

#define IImapFetchData_get_Text(This,pVal)	\
    ( (This)->lpVtbl -> get_Text(This,pVal) ) 

#define IImapFetchData_GetSubDataCount(This,pVal)	\
    ( (This)->lpVtbl -> GetSubDataCount(This,pVal) ) 

#define IImapFetchData_GetSubData(This,lIdx,pVal)	\
    ( (This)->lpVtbl -> GetSubData(This,lIdx,pVal) ) 

#define IImapFetchData_GetSubDataByName(This,Val,pVal)	\
    ( (This)->lpVtbl -> GetSubDataByName(This,Val,pVal) ) 

#define IImapFetchData_ContainsValue(This,Val,pVal)	\
    ( (This)->lpVtbl -> ContainsValue(This,Val,pVal) ) 

#define IImapFetchData_ContainsIntValue(This,Val,pVal)	\
    ( (This)->lpVtbl -> ContainsIntValue(This,Val,pVal) ) 

#define IImapFetchData_get_LastError(This,LastError)	\
    ( (This)->lpVtbl -> get_LastError(This,LastError) ) 

#define IImapFetchData_GetErrorDescription(This,ErrorCode,Description)	\
    ( (This)->lpVtbl -> GetErrorDescription(This,ErrorCode,Description) ) 

#define IImapFetchData_get_Sequence(This,pVal)	\
    ( (This)->lpVtbl -> get_Sequence(This,pVal) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __IImapFetchData_INTERFACE_DEFINED__ */


#ifndef __IImap_INTERFACE_DEFINED__
#define __IImap_INTERFACE_DEFINED__

/* interface IImap */
/* [unique][helpstring][nonextensible][dual][uuid][object] */ 


EXTERN_C const IID IID_IImap;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("2F17D77B-374D-431E-8772-8FD1B20D1516")
    IImap : public IDispatch
    {
    public:
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_Version( 
            /* [retval][out] */ BSTR *Version) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_Build( 
            /* [retval][out] */ BSTR *Build) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_Module( 
            /* [retval][out] */ BSTR *Module) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_LicenseStatus( 
            /* [retval][out] */ BSTR *LicenseStatus) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_LicenseKey( 
            /* [retval][out] */ BSTR *LicenseKey) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_LicenseKey( 
            /* [in] */ BSTR LicenseKey) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE SaveLicenseKey( void) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_LogFile( 
            /* [retval][out] */ BSTR *Logfile) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_LogFile( 
            /* [in] */ BSTR Logfile) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_ActivityFile( 
            /* [retval][out] */ BSTR *ActivityFile) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_ActivityFile( 
            /* [in] */ BSTR ActivityFile) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Sleep( 
            LONG Ms) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Clear( void) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_LastError( 
            /* [retval][out] */ LONG *LastError) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE GetErrorDescription( 
            /* [in] */ LONG ErrorCode,
            /* [retval][out] */ BSTR *Description) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_TimeoutConnect( 
            /* [retval][out] */ LONG *TimoutMs) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_TimeoutConnect( 
            /* [in] */ LONG TimoutMs) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_TimeoutCommand( 
            /* [retval][out] */ LONG *TimoutMs) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_TimeoutCommand( 
            /* [in] */ LONG TimoutMs) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_TimeoutAppend( 
            /* [retval][out] */ LONG *TimoutMs) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_TimeoutAppend( 
            /* [in] */ LONG TimoutMs) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_FetchMaxNumItemsAtOnce( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_FetchMaxNumItemsAtOnce( 
            /* [in] */ LONG Val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_MaximumPendingFetchData( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_MaximumPendingFetchData( 
            /* [in] */ LONG Val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_MaximumPendingExpunged( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_MaximumPendingExpunged( 
            /* [in] */ LONG Val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_UseSequenceNumForStoreAndCopy( 
            /* [retval][out] */ VARIANT_BOOL *pVal) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_UseSequenceNumForStoreAndCopy( 
            /* [in] */ VARIANT_BOOL Val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_HostPort( 
            /* [retval][out] */ LONG *HostPort) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_HostPort( 
            /* [in] */ LONG HostPort) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_Authentication( 
            /* [retval][out] */ LONG *Authentication) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_Authentication( 
            /* [in] */ LONG Authentication) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_UseStartTls( 
            /* [retval][out] */ VARIANT_BOOL *UseStartTls) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_UseStartTls( 
            /* [in] */ VARIANT_BOOL UseStartTls) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_AutoClose( 
            /* [retval][out] */ VARIANT_BOOL *AutoClose) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_AutoClose( 
            /* [in] */ VARIANT_BOOL AutoClose) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IpVersion( 
            /* [retval][out] */ LONG *IpVersion) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_IpVersion( 
            /* [in] */ LONG IpVersion) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_Secure( 
            /* [retval][out] */ VARIANT_BOOL *pVal) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_Secure( 
            /* [in] */ VARIANT_BOOL val) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_LastImapResponse( 
            /* [retval][out] */ BSTR *LastImapResponse) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_HierarchySeparator( 
            /* [retval][out] */ BSTR *HierarchySeparator) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_Capabilities( 
            /* [retval][out] */ BSTR *Capabilities) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_Exists( 
            /* [retval][out] */ LONG *Exists) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_Recent( 
            /* [retval][out] */ LONG *Recent) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_Unseen( 
            /* [retval][out] */ LONG *Unseen) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_UidNext( 
            /* [retval][out] */ LONG *UidNext) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_BearerToken( 
            /* [retval][out] */ BSTR *Val) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_BearerToken( 
            /* [in] */ BSTR Val) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE SetSecure( 
            /* [defaultvalue][in] */ LONG Port = 993) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Connect( 
            /* [in] */ BSTR Host,
            /* [defaultvalue][in] */ BSTR Account = (BSTR)L"",
            /* [defaultvalue][in] */ BSTR Password = (BSTR)L"") = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Disconnect( void) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE IsConnected( 
            /* [retval][out] */ VARIANT_BOOL *IsConnected) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Select( 
            /* [in] */ BSTR Mailbox) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Examine( 
            /* [in] */ BSTR Mailbox) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Status( 
            /* [in] */ BSTR Mailbox) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Close( void) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Create( 
            /* [in] */ BSTR MailboxName) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Delete( 
            /* [in] */ BSTR MailboxName) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Rename( 
            /* [in] */ BSTR Source,
            /* [in] */ BSTR Target) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Subscribe( 
            /* [in] */ BSTR MailboxName) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Unsubscribe( 
            /* [in] */ BSTR MailboxName) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Copy( 
            /* [in] */ BSTR IdSet,
            /* [in] */ BSTR Mailbox) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Store( 
            /* [in] */ BSTR IdSet,
            /* [in] */ BSTR Flags,
            /* [defaultvalue][in] */ LONG Option = 1) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Noop( void) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Check( void) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Expunge( void) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE GetPendingExpunged( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE GetPendingFetchData( 
            /* [retval][out] */ IImapFetchData **ppVal) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE ListSubscribed( 
            BSTR Reference,
            BSTR Mailbox) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE List( 
            BSTR Reference,
            BSTR Mailbox) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE ListCount( 
            /* [retval][out] */ LONG *Count) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE ListAttributes( 
            /* [in] */ LONG Index,
            /* [retval][out] */ BSTR *__MIDL__IImap0000) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE ListHasAttribute( 
            /* [in] */ LONG Index,
            /* [in] */ BSTR *Attribute,
            /* [retval][out] */ VARIANT_BOOL *__MIDL__IImap0001) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE ListName( 
            /* [in] */ LONG Index,
            /* [retval][out] */ BSTR *__MIDL__IImap0002) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE FetchFirstEmail( 
            /* [in] */ BSTR Criteria,
            /* [retval][out] */ IMessage **ppVal) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE FetchNextEmail( 
            /* [retval][out] */ IMessage **ppVal) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE FetchFirstEmailHeader( 
            /* [in] */ BSTR Criteria,
            /* [retval][out] */ IMessage **ppVal) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE FetchNextEmailHeader( 
            /* [retval][out] */ IMessage **ppVal) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE FetchFirst( 
            /* [in] */ BSTR Criteria,
            /* [in] */ BSTR DataItems,
            /* [retval][out] */ IImapFetchData **ppVal) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE FetchNext( 
            /* [retval][out] */ IImapFetchData **ppVal) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Append( 
            /* [in] */ BSTR Mailbox,
            /* [in] */ IMessage *pVal,
            /* [defaultvalue][in] */ BSTR Flags = (BSTR)L"",
            /* [defaultvalue][in] */ BSTR DateTime = (BSTR)L"") = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE HasCapability( 
            /* [in] */ BSTR Capability,
            /* [retval][out] */ VARIANT_BOOL *CapabilitySupported) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE FormatDate( 
            /* [in] */ LONG Year,
            /* [in] */ LONG Month,
            /* [in] */ LONG Day,
            /* [retval][out] */ BSTR *DateString) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE FormatTime( 
            /* [in] */ LONG Hour,
            /* [in] */ LONG Minute,
            /* [in] */ LONG Second,
            /* [in] */ LONG OffsetMinute,
            /* [retval][out] */ BSTR *DateString) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Idle( void) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE IdleDone( void) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IdleResetTimeMin( 
            /* [retval][out] */ LONG *Val) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_IdleResetTimeMin( 
            /* [in] */ LONG Val) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct IImapVtbl
    {
        BEGIN_INTERFACE
        
        DECLSPEC_XFGVIRT(IUnknown, QueryInterface)
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            IImap * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        DECLSPEC_XFGVIRT(IUnknown, AddRef)
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            IImap * This);
        
        DECLSPEC_XFGVIRT(IUnknown, Release)
        ULONG ( STDMETHODCALLTYPE *Release )( 
            IImap * This);
        
        DECLSPEC_XFGVIRT(IDispatch, GetTypeInfoCount)
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfoCount )( 
            IImap * This,
            /* [out] */ UINT *pctinfo);
        
        DECLSPEC_XFGVIRT(IDispatch, GetTypeInfo)
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfo )( 
            IImap * This,
            /* [in] */ UINT iTInfo,
            /* [in] */ LCID lcid,
            /* [out] */ ITypeInfo **ppTInfo);
        
        DECLSPEC_XFGVIRT(IDispatch, GetIDsOfNames)
        HRESULT ( STDMETHODCALLTYPE *GetIDsOfNames )( 
            IImap * This,
            /* [in] */ REFIID riid,
            /* [size_is][in] */ LPOLESTR *rgszNames,
            /* [range][in] */ UINT cNames,
            /* [in] */ LCID lcid,
            /* [size_is][out] */ DISPID *rgDispId);
        
        DECLSPEC_XFGVIRT(IDispatch, Invoke)
        /* [local] */ HRESULT ( STDMETHODCALLTYPE *Invoke )( 
            IImap * This,
            /* [annotation][in] */ 
            _In_  DISPID dispIdMember,
            /* [annotation][in] */ 
            _In_  REFIID riid,
            /* [annotation][in] */ 
            _In_  LCID lcid,
            /* [annotation][in] */ 
            _In_  WORD wFlags,
            /* [annotation][out][in] */ 
            _In_  DISPPARAMS *pDispParams,
            /* [annotation][out] */ 
            _Out_opt_  VARIANT *pVarResult,
            /* [annotation][out] */ 
            _Out_opt_  EXCEPINFO *pExcepInfo,
            /* [annotation][out] */ 
            _Out_opt_  UINT *puArgErr);
        
        DECLSPEC_XFGVIRT(IImap, get_Version)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Version )( 
            IImap * This,
            /* [retval][out] */ BSTR *Version);
        
        DECLSPEC_XFGVIRT(IImap, get_Build)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Build )( 
            IImap * This,
            /* [retval][out] */ BSTR *Build);
        
        DECLSPEC_XFGVIRT(IImap, get_Module)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Module )( 
            IImap * This,
            /* [retval][out] */ BSTR *Module);
        
        DECLSPEC_XFGVIRT(IImap, get_LicenseStatus)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_LicenseStatus )( 
            IImap * This,
            /* [retval][out] */ BSTR *LicenseStatus);
        
        DECLSPEC_XFGVIRT(IImap, get_LicenseKey)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_LicenseKey )( 
            IImap * This,
            /* [retval][out] */ BSTR *LicenseKey);
        
        DECLSPEC_XFGVIRT(IImap, put_LicenseKey)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_LicenseKey )( 
            IImap * This,
            /* [in] */ BSTR LicenseKey);
        
        DECLSPEC_XFGVIRT(IImap, SaveLicenseKey)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *SaveLicenseKey )( 
            IImap * This);
        
        DECLSPEC_XFGVIRT(IImap, get_LogFile)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_LogFile )( 
            IImap * This,
            /* [retval][out] */ BSTR *Logfile);
        
        DECLSPEC_XFGVIRT(IImap, put_LogFile)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_LogFile )( 
            IImap * This,
            /* [in] */ BSTR Logfile);
        
        DECLSPEC_XFGVIRT(IImap, get_ActivityFile)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_ActivityFile )( 
            IImap * This,
            /* [retval][out] */ BSTR *ActivityFile);
        
        DECLSPEC_XFGVIRT(IImap, put_ActivityFile)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_ActivityFile )( 
            IImap * This,
            /* [in] */ BSTR ActivityFile);
        
        DECLSPEC_XFGVIRT(IImap, Sleep)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Sleep )( 
            IImap * This,
            LONG Ms);
        
        DECLSPEC_XFGVIRT(IImap, Clear)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Clear )( 
            IImap * This);
        
        DECLSPEC_XFGVIRT(IImap, get_LastError)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_LastError )( 
            IImap * This,
            /* [retval][out] */ LONG *LastError);
        
        DECLSPEC_XFGVIRT(IImap, GetErrorDescription)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *GetErrorDescription )( 
            IImap * This,
            /* [in] */ LONG ErrorCode,
            /* [retval][out] */ BSTR *Description);
        
        DECLSPEC_XFGVIRT(IImap, get_TimeoutConnect)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_TimeoutConnect )( 
            IImap * This,
            /* [retval][out] */ LONG *TimoutMs);
        
        DECLSPEC_XFGVIRT(IImap, put_TimeoutConnect)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_TimeoutConnect )( 
            IImap * This,
            /* [in] */ LONG TimoutMs);
        
        DECLSPEC_XFGVIRT(IImap, get_TimeoutCommand)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_TimeoutCommand )( 
            IImap * This,
            /* [retval][out] */ LONG *TimoutMs);
        
        DECLSPEC_XFGVIRT(IImap, put_TimeoutCommand)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_TimeoutCommand )( 
            IImap * This,
            /* [in] */ LONG TimoutMs);
        
        DECLSPEC_XFGVIRT(IImap, get_TimeoutAppend)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_TimeoutAppend )( 
            IImap * This,
            /* [retval][out] */ LONG *TimoutMs);
        
        DECLSPEC_XFGVIRT(IImap, put_TimeoutAppend)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_TimeoutAppend )( 
            IImap * This,
            /* [in] */ LONG TimoutMs);
        
        DECLSPEC_XFGVIRT(IImap, get_FetchMaxNumItemsAtOnce)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_FetchMaxNumItemsAtOnce )( 
            IImap * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IImap, put_FetchMaxNumItemsAtOnce)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_FetchMaxNumItemsAtOnce )( 
            IImap * This,
            /* [in] */ LONG Val);
        
        DECLSPEC_XFGVIRT(IImap, get_MaximumPendingFetchData)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_MaximumPendingFetchData )( 
            IImap * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IImap, put_MaximumPendingFetchData)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_MaximumPendingFetchData )( 
            IImap * This,
            /* [in] */ LONG Val);
        
        DECLSPEC_XFGVIRT(IImap, get_MaximumPendingExpunged)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_MaximumPendingExpunged )( 
            IImap * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IImap, put_MaximumPendingExpunged)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_MaximumPendingExpunged )( 
            IImap * This,
            /* [in] */ LONG Val);
        
        DECLSPEC_XFGVIRT(IImap, get_UseSequenceNumForStoreAndCopy)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_UseSequenceNumForStoreAndCopy )( 
            IImap * This,
            /* [retval][out] */ VARIANT_BOOL *pVal);
        
        DECLSPEC_XFGVIRT(IImap, put_UseSequenceNumForStoreAndCopy)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_UseSequenceNumForStoreAndCopy )( 
            IImap * This,
            /* [in] */ VARIANT_BOOL Val);
        
        DECLSPEC_XFGVIRT(IImap, get_HostPort)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_HostPort )( 
            IImap * This,
            /* [retval][out] */ LONG *HostPort);
        
        DECLSPEC_XFGVIRT(IImap, put_HostPort)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_HostPort )( 
            IImap * This,
            /* [in] */ LONG HostPort);
        
        DECLSPEC_XFGVIRT(IImap, get_Authentication)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Authentication )( 
            IImap * This,
            /* [retval][out] */ LONG *Authentication);
        
        DECLSPEC_XFGVIRT(IImap, put_Authentication)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_Authentication )( 
            IImap * This,
            /* [in] */ LONG Authentication);
        
        DECLSPEC_XFGVIRT(IImap, get_UseStartTls)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_UseStartTls )( 
            IImap * This,
            /* [retval][out] */ VARIANT_BOOL *UseStartTls);
        
        DECLSPEC_XFGVIRT(IImap, put_UseStartTls)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_UseStartTls )( 
            IImap * This,
            /* [in] */ VARIANT_BOOL UseStartTls);
        
        DECLSPEC_XFGVIRT(IImap, get_AutoClose)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_AutoClose )( 
            IImap * This,
            /* [retval][out] */ VARIANT_BOOL *AutoClose);
        
        DECLSPEC_XFGVIRT(IImap, put_AutoClose)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_AutoClose )( 
            IImap * This,
            /* [in] */ VARIANT_BOOL AutoClose);
        
        DECLSPEC_XFGVIRT(IImap, get_IpVersion)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IpVersion )( 
            IImap * This,
            /* [retval][out] */ LONG *IpVersion);
        
        DECLSPEC_XFGVIRT(IImap, put_IpVersion)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_IpVersion )( 
            IImap * This,
            /* [in] */ LONG IpVersion);
        
        DECLSPEC_XFGVIRT(IImap, get_Secure)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Secure )( 
            IImap * This,
            /* [retval][out] */ VARIANT_BOOL *pVal);
        
        DECLSPEC_XFGVIRT(IImap, put_Secure)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_Secure )( 
            IImap * This,
            /* [in] */ VARIANT_BOOL val);
        
        DECLSPEC_XFGVIRT(IImap, get_LastImapResponse)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_LastImapResponse )( 
            IImap * This,
            /* [retval][out] */ BSTR *LastImapResponse);
        
        DECLSPEC_XFGVIRT(IImap, get_HierarchySeparator)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_HierarchySeparator )( 
            IImap * This,
            /* [retval][out] */ BSTR *HierarchySeparator);
        
        DECLSPEC_XFGVIRT(IImap, get_Capabilities)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Capabilities )( 
            IImap * This,
            /* [retval][out] */ BSTR *Capabilities);
        
        DECLSPEC_XFGVIRT(IImap, get_Exists)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Exists )( 
            IImap * This,
            /* [retval][out] */ LONG *Exists);
        
        DECLSPEC_XFGVIRT(IImap, get_Recent)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Recent )( 
            IImap * This,
            /* [retval][out] */ LONG *Recent);
        
        DECLSPEC_XFGVIRT(IImap, get_Unseen)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Unseen )( 
            IImap * This,
            /* [retval][out] */ LONG *Unseen);
        
        DECLSPEC_XFGVIRT(IImap, get_UidNext)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_UidNext )( 
            IImap * This,
            /* [retval][out] */ LONG *UidNext);
        
        DECLSPEC_XFGVIRT(IImap, get_BearerToken)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_BearerToken )( 
            IImap * This,
            /* [retval][out] */ BSTR *Val);
        
        DECLSPEC_XFGVIRT(IImap, put_BearerToken)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_BearerToken )( 
            IImap * This,
            /* [in] */ BSTR Val);
        
        DECLSPEC_XFGVIRT(IImap, SetSecure)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *SetSecure )( 
            IImap * This,
            /* [defaultvalue][in] */ LONG Port);
        
        DECLSPEC_XFGVIRT(IImap, Connect)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Connect )( 
            IImap * This,
            /* [in] */ BSTR Host,
            /* [defaultvalue][in] */ BSTR Account,
            /* [defaultvalue][in] */ BSTR Password);
        
        DECLSPEC_XFGVIRT(IImap, Disconnect)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Disconnect )( 
            IImap * This);
        
        DECLSPEC_XFGVIRT(IImap, IsConnected)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *IsConnected )( 
            IImap * This,
            /* [retval][out] */ VARIANT_BOOL *IsConnected);
        
        DECLSPEC_XFGVIRT(IImap, Select)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Select )( 
            IImap * This,
            /* [in] */ BSTR Mailbox);
        
        DECLSPEC_XFGVIRT(IImap, Examine)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Examine )( 
            IImap * This,
            /* [in] */ BSTR Mailbox);
        
        DECLSPEC_XFGVIRT(IImap, Status)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Status )( 
            IImap * This,
            /* [in] */ BSTR Mailbox);
        
        DECLSPEC_XFGVIRT(IImap, Close)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Close )( 
            IImap * This);
        
        DECLSPEC_XFGVIRT(IImap, Create)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Create )( 
            IImap * This,
            /* [in] */ BSTR MailboxName);
        
        DECLSPEC_XFGVIRT(IImap, Delete)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Delete )( 
            IImap * This,
            /* [in] */ BSTR MailboxName);
        
        DECLSPEC_XFGVIRT(IImap, Rename)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Rename )( 
            IImap * This,
            /* [in] */ BSTR Source,
            /* [in] */ BSTR Target);
        
        DECLSPEC_XFGVIRT(IImap, Subscribe)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Subscribe )( 
            IImap * This,
            /* [in] */ BSTR MailboxName);
        
        DECLSPEC_XFGVIRT(IImap, Unsubscribe)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Unsubscribe )( 
            IImap * This,
            /* [in] */ BSTR MailboxName);
        
        DECLSPEC_XFGVIRT(IImap, Copy)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Copy )( 
            IImap * This,
            /* [in] */ BSTR IdSet,
            /* [in] */ BSTR Mailbox);
        
        DECLSPEC_XFGVIRT(IImap, Store)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Store )( 
            IImap * This,
            /* [in] */ BSTR IdSet,
            /* [in] */ BSTR Flags,
            /* [defaultvalue][in] */ LONG Option);
        
        DECLSPEC_XFGVIRT(IImap, Noop)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Noop )( 
            IImap * This);
        
        DECLSPEC_XFGVIRT(IImap, Check)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Check )( 
            IImap * This);
        
        DECLSPEC_XFGVIRT(IImap, Expunge)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Expunge )( 
            IImap * This);
        
        DECLSPEC_XFGVIRT(IImap, GetPendingExpunged)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *GetPendingExpunged )( 
            IImap * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IImap, GetPendingFetchData)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *GetPendingFetchData )( 
            IImap * This,
            /* [retval][out] */ IImapFetchData **ppVal);
        
        DECLSPEC_XFGVIRT(IImap, ListSubscribed)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *ListSubscribed )( 
            IImap * This,
            BSTR Reference,
            BSTR Mailbox);
        
        DECLSPEC_XFGVIRT(IImap, List)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *List )( 
            IImap * This,
            BSTR Reference,
            BSTR Mailbox);
        
        DECLSPEC_XFGVIRT(IImap, ListCount)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *ListCount )( 
            IImap * This,
            /* [retval][out] */ LONG *Count);
        
        DECLSPEC_XFGVIRT(IImap, ListAttributes)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *ListAttributes )( 
            IImap * This,
            /* [in] */ LONG Index,
            /* [retval][out] */ BSTR *__MIDL__IImap0000);
        
        DECLSPEC_XFGVIRT(IImap, ListHasAttribute)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *ListHasAttribute )( 
            IImap * This,
            /* [in] */ LONG Index,
            /* [in] */ BSTR *Attribute,
            /* [retval][out] */ VARIANT_BOOL *__MIDL__IImap0001);
        
        DECLSPEC_XFGVIRT(IImap, ListName)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *ListName )( 
            IImap * This,
            /* [in] */ LONG Index,
            /* [retval][out] */ BSTR *__MIDL__IImap0002);
        
        DECLSPEC_XFGVIRT(IImap, FetchFirstEmail)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *FetchFirstEmail )( 
            IImap * This,
            /* [in] */ BSTR Criteria,
            /* [retval][out] */ IMessage **ppVal);
        
        DECLSPEC_XFGVIRT(IImap, FetchNextEmail)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *FetchNextEmail )( 
            IImap * This,
            /* [retval][out] */ IMessage **ppVal);
        
        DECLSPEC_XFGVIRT(IImap, FetchFirstEmailHeader)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *FetchFirstEmailHeader )( 
            IImap * This,
            /* [in] */ BSTR Criteria,
            /* [retval][out] */ IMessage **ppVal);
        
        DECLSPEC_XFGVIRT(IImap, FetchNextEmailHeader)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *FetchNextEmailHeader )( 
            IImap * This,
            /* [retval][out] */ IMessage **ppVal);
        
        DECLSPEC_XFGVIRT(IImap, FetchFirst)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *FetchFirst )( 
            IImap * This,
            /* [in] */ BSTR Criteria,
            /* [in] */ BSTR DataItems,
            /* [retval][out] */ IImapFetchData **ppVal);
        
        DECLSPEC_XFGVIRT(IImap, FetchNext)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *FetchNext )( 
            IImap * This,
            /* [retval][out] */ IImapFetchData **ppVal);
        
        DECLSPEC_XFGVIRT(IImap, Append)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Append )( 
            IImap * This,
            /* [in] */ BSTR Mailbox,
            /* [in] */ IMessage *pVal,
            /* [defaultvalue][in] */ BSTR Flags,
            /* [defaultvalue][in] */ BSTR DateTime);
        
        DECLSPEC_XFGVIRT(IImap, HasCapability)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *HasCapability )( 
            IImap * This,
            /* [in] */ BSTR Capability,
            /* [retval][out] */ VARIANT_BOOL *CapabilitySupported);
        
        DECLSPEC_XFGVIRT(IImap, FormatDate)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *FormatDate )( 
            IImap * This,
            /* [in] */ LONG Year,
            /* [in] */ LONG Month,
            /* [in] */ LONG Day,
            /* [retval][out] */ BSTR *DateString);
        
        DECLSPEC_XFGVIRT(IImap, FormatTime)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *FormatTime )( 
            IImap * This,
            /* [in] */ LONG Hour,
            /* [in] */ LONG Minute,
            /* [in] */ LONG Second,
            /* [in] */ LONG OffsetMinute,
            /* [retval][out] */ BSTR *DateString);
        
        DECLSPEC_XFGVIRT(IImap, Idle)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Idle )( 
            IImap * This);
        
        DECLSPEC_XFGVIRT(IImap, IdleDone)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *IdleDone )( 
            IImap * This);
        
        DECLSPEC_XFGVIRT(IImap, get_IdleResetTimeMin)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IdleResetTimeMin )( 
            IImap * This,
            /* [retval][out] */ LONG *Val);
        
        DECLSPEC_XFGVIRT(IImap, put_IdleResetTimeMin)
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_IdleResetTimeMin )( 
            IImap * This,
            /* [in] */ LONG Val);
        
        END_INTERFACE
    } IImapVtbl;

    interface IImap
    {
        CONST_VTBL struct IImapVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define IImap_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define IImap_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define IImap_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define IImap_GetTypeInfoCount(This,pctinfo)	\
    ( (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo) ) 

#define IImap_GetTypeInfo(This,iTInfo,lcid,ppTInfo)	\
    ( (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo) ) 

#define IImap_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)	\
    ( (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) ) 

#define IImap_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)	\
    ( (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) ) 


#define IImap_get_Version(This,Version)	\
    ( (This)->lpVtbl -> get_Version(This,Version) ) 

#define IImap_get_Build(This,Build)	\
    ( (This)->lpVtbl -> get_Build(This,Build) ) 

#define IImap_get_Module(This,Module)	\
    ( (This)->lpVtbl -> get_Module(This,Module) ) 

#define IImap_get_LicenseStatus(This,LicenseStatus)	\
    ( (This)->lpVtbl -> get_LicenseStatus(This,LicenseStatus) ) 

#define IImap_get_LicenseKey(This,LicenseKey)	\
    ( (This)->lpVtbl -> get_LicenseKey(This,LicenseKey) ) 

#define IImap_put_LicenseKey(This,LicenseKey)	\
    ( (This)->lpVtbl -> put_LicenseKey(This,LicenseKey) ) 

#define IImap_SaveLicenseKey(This)	\
    ( (This)->lpVtbl -> SaveLicenseKey(This) ) 

#define IImap_get_LogFile(This,Logfile)	\
    ( (This)->lpVtbl -> get_LogFile(This,Logfile) ) 

#define IImap_put_LogFile(This,Logfile)	\
    ( (This)->lpVtbl -> put_LogFile(This,Logfile) ) 

#define IImap_get_ActivityFile(This,ActivityFile)	\
    ( (This)->lpVtbl -> get_ActivityFile(This,ActivityFile) ) 

#define IImap_put_ActivityFile(This,ActivityFile)	\
    ( (This)->lpVtbl -> put_ActivityFile(This,ActivityFile) ) 

#define IImap_Sleep(This,Ms)	\
    ( (This)->lpVtbl -> Sleep(This,Ms) ) 

#define IImap_Clear(This)	\
    ( (This)->lpVtbl -> Clear(This) ) 

#define IImap_get_LastError(This,LastError)	\
    ( (This)->lpVtbl -> get_LastError(This,LastError) ) 

#define IImap_GetErrorDescription(This,ErrorCode,Description)	\
    ( (This)->lpVtbl -> GetErrorDescription(This,ErrorCode,Description) ) 

#define IImap_get_TimeoutConnect(This,TimoutMs)	\
    ( (This)->lpVtbl -> get_TimeoutConnect(This,TimoutMs) ) 

#define IImap_put_TimeoutConnect(This,TimoutMs)	\
    ( (This)->lpVtbl -> put_TimeoutConnect(This,TimoutMs) ) 

#define IImap_get_TimeoutCommand(This,TimoutMs)	\
    ( (This)->lpVtbl -> get_TimeoutCommand(This,TimoutMs) ) 

#define IImap_put_TimeoutCommand(This,TimoutMs)	\
    ( (This)->lpVtbl -> put_TimeoutCommand(This,TimoutMs) ) 

#define IImap_get_TimeoutAppend(This,TimoutMs)	\
    ( (This)->lpVtbl -> get_TimeoutAppend(This,TimoutMs) ) 

#define IImap_put_TimeoutAppend(This,TimoutMs)	\
    ( (This)->lpVtbl -> put_TimeoutAppend(This,TimoutMs) ) 

#define IImap_get_FetchMaxNumItemsAtOnce(This,pVal)	\
    ( (This)->lpVtbl -> get_FetchMaxNumItemsAtOnce(This,pVal) ) 

#define IImap_put_FetchMaxNumItemsAtOnce(This,Val)	\
    ( (This)->lpVtbl -> put_FetchMaxNumItemsAtOnce(This,Val) ) 

#define IImap_get_MaximumPendingFetchData(This,pVal)	\
    ( (This)->lpVtbl -> get_MaximumPendingFetchData(This,pVal) ) 

#define IImap_put_MaximumPendingFetchData(This,Val)	\
    ( (This)->lpVtbl -> put_MaximumPendingFetchData(This,Val) ) 

#define IImap_get_MaximumPendingExpunged(This,pVal)	\
    ( (This)->lpVtbl -> get_MaximumPendingExpunged(This,pVal) ) 

#define IImap_put_MaximumPendingExpunged(This,Val)	\
    ( (This)->lpVtbl -> put_MaximumPendingExpunged(This,Val) ) 

#define IImap_get_UseSequenceNumForStoreAndCopy(This,pVal)	\
    ( (This)->lpVtbl -> get_UseSequenceNumForStoreAndCopy(This,pVal) ) 

#define IImap_put_UseSequenceNumForStoreAndCopy(This,Val)	\
    ( (This)->lpVtbl -> put_UseSequenceNumForStoreAndCopy(This,Val) ) 

#define IImap_get_HostPort(This,HostPort)	\
    ( (This)->lpVtbl -> get_HostPort(This,HostPort) ) 

#define IImap_put_HostPort(This,HostPort)	\
    ( (This)->lpVtbl -> put_HostPort(This,HostPort) ) 

#define IImap_get_Authentication(This,Authentication)	\
    ( (This)->lpVtbl -> get_Authentication(This,Authentication) ) 

#define IImap_put_Authentication(This,Authentication)	\
    ( (This)->lpVtbl -> put_Authentication(This,Authentication) ) 

#define IImap_get_UseStartTls(This,UseStartTls)	\
    ( (This)->lpVtbl -> get_UseStartTls(This,UseStartTls) ) 

#define IImap_put_UseStartTls(This,UseStartTls)	\
    ( (This)->lpVtbl -> put_UseStartTls(This,UseStartTls) ) 

#define IImap_get_AutoClose(This,AutoClose)	\
    ( (This)->lpVtbl -> get_AutoClose(This,AutoClose) ) 

#define IImap_put_AutoClose(This,AutoClose)	\
    ( (This)->lpVtbl -> put_AutoClose(This,AutoClose) ) 

#define IImap_get_IpVersion(This,IpVersion)	\
    ( (This)->lpVtbl -> get_IpVersion(This,IpVersion) ) 

#define IImap_put_IpVersion(This,IpVersion)	\
    ( (This)->lpVtbl -> put_IpVersion(This,IpVersion) ) 

#define IImap_get_Secure(This,pVal)	\
    ( (This)->lpVtbl -> get_Secure(This,pVal) ) 

#define IImap_put_Secure(This,val)	\
    ( (This)->lpVtbl -> put_Secure(This,val) ) 

#define IImap_get_LastImapResponse(This,LastImapResponse)	\
    ( (This)->lpVtbl -> get_LastImapResponse(This,LastImapResponse) ) 

#define IImap_get_HierarchySeparator(This,HierarchySeparator)	\
    ( (This)->lpVtbl -> get_HierarchySeparator(This,HierarchySeparator) ) 

#define IImap_get_Capabilities(This,Capabilities)	\
    ( (This)->lpVtbl -> get_Capabilities(This,Capabilities) ) 

#define IImap_get_Exists(This,Exists)	\
    ( (This)->lpVtbl -> get_Exists(This,Exists) ) 

#define IImap_get_Recent(This,Recent)	\
    ( (This)->lpVtbl -> get_Recent(This,Recent) ) 

#define IImap_get_Unseen(This,Unseen)	\
    ( (This)->lpVtbl -> get_Unseen(This,Unseen) ) 

#define IImap_get_UidNext(This,UidNext)	\
    ( (This)->lpVtbl -> get_UidNext(This,UidNext) ) 

#define IImap_get_BearerToken(This,Val)	\
    ( (This)->lpVtbl -> get_BearerToken(This,Val) ) 

#define IImap_put_BearerToken(This,Val)	\
    ( (This)->lpVtbl -> put_BearerToken(This,Val) ) 

#define IImap_SetSecure(This,Port)	\
    ( (This)->lpVtbl -> SetSecure(This,Port) ) 

#define IImap_Connect(This,Host,Account,Password)	\
    ( (This)->lpVtbl -> Connect(This,Host,Account,Password) ) 

#define IImap_Disconnect(This)	\
    ( (This)->lpVtbl -> Disconnect(This) ) 

#define IImap_IsConnected(This,IsConnected)	\
    ( (This)->lpVtbl -> IsConnected(This,IsConnected) ) 

#define IImap_Select(This,Mailbox)	\
    ( (This)->lpVtbl -> Select(This,Mailbox) ) 

#define IImap_Examine(This,Mailbox)	\
    ( (This)->lpVtbl -> Examine(This,Mailbox) ) 

#define IImap_Status(This,Mailbox)	\
    ( (This)->lpVtbl -> Status(This,Mailbox) ) 

#define IImap_Close(This)	\
    ( (This)->lpVtbl -> Close(This) ) 

#define IImap_Create(This,MailboxName)	\
    ( (This)->lpVtbl -> Create(This,MailboxName) ) 

#define IImap_Delete(This,MailboxName)	\
    ( (This)->lpVtbl -> Delete(This,MailboxName) ) 

#define IImap_Rename(This,Source,Target)	\
    ( (This)->lpVtbl -> Rename(This,Source,Target) ) 

#define IImap_Subscribe(This,MailboxName)	\
    ( (This)->lpVtbl -> Subscribe(This,MailboxName) ) 

#define IImap_Unsubscribe(This,MailboxName)	\
    ( (This)->lpVtbl -> Unsubscribe(This,MailboxName) ) 

#define IImap_Copy(This,IdSet,Mailbox)	\
    ( (This)->lpVtbl -> Copy(This,IdSet,Mailbox) ) 

#define IImap_Store(This,IdSet,Flags,Option)	\
    ( (This)->lpVtbl -> Store(This,IdSet,Flags,Option) ) 

#define IImap_Noop(This)	\
    ( (This)->lpVtbl -> Noop(This) ) 

#define IImap_Check(This)	\
    ( (This)->lpVtbl -> Check(This) ) 

#define IImap_Expunge(This)	\
    ( (This)->lpVtbl -> Expunge(This) ) 

#define IImap_GetPendingExpunged(This,pVal)	\
    ( (This)->lpVtbl -> GetPendingExpunged(This,pVal) ) 

#define IImap_GetPendingFetchData(This,ppVal)	\
    ( (This)->lpVtbl -> GetPendingFetchData(This,ppVal) ) 

#define IImap_ListSubscribed(This,Reference,Mailbox)	\
    ( (This)->lpVtbl -> ListSubscribed(This,Reference,Mailbox) ) 

#define IImap_List(This,Reference,Mailbox)	\
    ( (This)->lpVtbl -> List(This,Reference,Mailbox) ) 

#define IImap_ListCount(This,Count)	\
    ( (This)->lpVtbl -> ListCount(This,Count) ) 

#define IImap_ListAttributes(This,Index,__MIDL__IImap0000)	\
    ( (This)->lpVtbl -> ListAttributes(This,Index,__MIDL__IImap0000) ) 

#define IImap_ListHasAttribute(This,Index,Attribute,__MIDL__IImap0001)	\
    ( (This)->lpVtbl -> ListHasAttribute(This,Index,Attribute,__MIDL__IImap0001) ) 

#define IImap_ListName(This,Index,__MIDL__IImap0002)	\
    ( (This)->lpVtbl -> ListName(This,Index,__MIDL__IImap0002) ) 

#define IImap_FetchFirstEmail(This,Criteria,ppVal)	\
    ( (This)->lpVtbl -> FetchFirstEmail(This,Criteria,ppVal) ) 

#define IImap_FetchNextEmail(This,ppVal)	\
    ( (This)->lpVtbl -> FetchNextEmail(This,ppVal) ) 

#define IImap_FetchFirstEmailHeader(This,Criteria,ppVal)	\
    ( (This)->lpVtbl -> FetchFirstEmailHeader(This,Criteria,ppVal) ) 

#define IImap_FetchNextEmailHeader(This,ppVal)	\
    ( (This)->lpVtbl -> FetchNextEmailHeader(This,ppVal) ) 

#define IImap_FetchFirst(This,Criteria,DataItems,ppVal)	\
    ( (This)->lpVtbl -> FetchFirst(This,Criteria,DataItems,ppVal) ) 

#define IImap_FetchNext(This,ppVal)	\
    ( (This)->lpVtbl -> FetchNext(This,ppVal) ) 

#define IImap_Append(This,Mailbox,pVal,Flags,DateTime)	\
    ( (This)->lpVtbl -> Append(This,Mailbox,pVal,Flags,DateTime) ) 

#define IImap_HasCapability(This,Capability,CapabilitySupported)	\
    ( (This)->lpVtbl -> HasCapability(This,Capability,CapabilitySupported) ) 

#define IImap_FormatDate(This,Year,Month,Day,DateString)	\
    ( (This)->lpVtbl -> FormatDate(This,Year,Month,Day,DateString) ) 

#define IImap_FormatTime(This,Hour,Minute,Second,OffsetMinute,DateString)	\
    ( (This)->lpVtbl -> FormatTime(This,Hour,Minute,Second,OffsetMinute,DateString) ) 

#define IImap_Idle(This)	\
    ( (This)->lpVtbl -> Idle(This) ) 

#define IImap_IdleDone(This)	\
    ( (This)->lpVtbl -> IdleDone(This) ) 

#define IImap_get_IdleResetTimeMin(This,Val)	\
    ( (This)->lpVtbl -> get_IdleResetTimeMin(This,Val) ) 

#define IImap_put_IdleResetTimeMin(This,Val)	\
    ( (This)->lpVtbl -> put_IdleResetTimeMin(This,Val) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __IImap_INTERFACE_DEFINED__ */


#ifndef __IConstants_INTERFACE_DEFINED__
#define __IConstants_INTERFACE_DEFINED__

/* interface IConstants */
/* [unique][helpstring][nonextensible][dual][uuid][object] */ 


EXTERN_C const IID IID_IConstants;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("AD78421F-9ECA-4BFD-81E6-94712D62DEFD")
    IConstants : public IDispatch
    {
    public:
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_EMAIL_MESSAGE_PRIORITY_HIGHEST( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_EMAIL_MESSAGE_PRIORITY_HIGH( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_EMAIL_MESSAGE_PRIORITY_MEDIUM( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_EMAIL_MESSAGE_PRIORITY_LOW( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_EMAIL_MESSAGE_PRIORITY_LOWEST( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_EMAIL_MESSAGE_ENCODING_DEFAULT( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_EMAIL_MESSAGE_ENCODING_THAI( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_EMAIL_MESSAGE_ENCODING_JAPANESE( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_EMAIL_MESSAGE_ENCODING_CHINESE_SIMP( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_EMAIL_MESSAGE_ENCODING_KOREAN( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_EMAIL_MESSAGE_ENCODING_CHINESE_TRAD( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_EMAIL_MESSAGE_ENCODING_CENTRALEUROPE( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_EMAIL_MESSAGE_ENCODING_RUSSIAN( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_EMAIL_MESSAGE_ENCODING_WESTERN( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_EMAIL_MESSAGE_ENCODING_GREEK( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_EMAIL_MESSAGE_ENCODING_TURKISH( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_EMAIL_MESSAGE_ENCODING_HEBREW( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_EMAIL_MESSAGE_ENCODING_ARABIC( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_EMAIL_MESSAGE_ENCODING_BALTIC( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_EMAIL_MESSAGE_ENCODING_VIETNAMESE( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_EMAIL_MESSAGE_ENCODING_UTF7( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_EMAIL_MESSAGE_ENCODING_UTF8( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_SMTP_AUTH_AUTO( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_SMTP_AUTH_PLAIN( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_SMTP_AUTH_LOGIN( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_SMTP_AUTH_MD5CRAM( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_SMTP_AUTH_OAUTH2( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_POP3_AUTH_PLAIN( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_POP3_AUTH_APOP( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_POP3_AUTH_AUTO( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_POP3_AUTH_OAUTH2( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_ALL( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_ANSWERED( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_BCC( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_BEFORE( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_BODY( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_CC( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_DELETED( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_DRAFT( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_FLAGGED( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_FROM( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_HEADER( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_KEYWORD( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_LARGER( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_NEW( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_NOT( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_OLD( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_ON( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_OR( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_RECENT( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_SEEN( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_SENTBEFORE( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_SENTON( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_SENTSINCE( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_SINCE( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_SMALLER( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_SUBJECT( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_TEXT( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_TO( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_UID( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_UNANSWERED( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_UNDELETED( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_UNDRAFT( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_UNFLAGGED( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_UNKEYWORD( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_SK_UNSEEN( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_FM_ALL( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_FM_FAST( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_FM_FULL( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_FDI_BODY( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_FDI_HEADER( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_FDI_HEADER_FIELDS( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_FDI_HEADER_FIELDS_NOT( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_FDI_MIME( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_FDI_TEXT( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_FDI_BODY_PEEK( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_FDI_BODYSTRUCTURE( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_FDI_ENVELOPE( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_FDI_FLAGS( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_FDI_INTERNALDATE( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_FDI_RFC822( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_FDI_RFC822_HEADER( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_FDI_RFC822_SIZE( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_FDI_RFC822_TEXT( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_FDI_UID( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_MBX_FLAG_NOINFERIORS( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_MBX_FLAG_NOSELECT( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_MBX_FLAG_MARKED( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_MBX_FLAG_UNMARKED( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_MBX_FLAG_ALL( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_MBX_FLAG_ARCHIVE( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_MBX_FLAG_DRAFTS( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_MBX_FLAG_FLAGGED( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_MBX_FLAG_JUNK( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_MBX_FLAG_SENT( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_MBX_FLAG_TRASH( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_MBX_FLAG_HASNOCHILDREN( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_MBX_FLAG_HASCHILDREN( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_MAIL_FLAG_SEEN( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_MAIL_FLAG_ANSWERED( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_MAIL_FLAG_FLAGGED( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_MAIL_FLAG_DELETED( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_MAIL_FLAG_DRAFT( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_MAIL_FLAG_RECENT( 
            /* [retval][out] */ BSTR *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_FD_TYPE_INTEGER( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_FD_TYPE_STRING( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_FD_TYPE_STRING_LITERAL( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_FD_TYPE_LIST( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_FD_TYPE_ATOM( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_FD_TYPE_NIL( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_STO_SET( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_STO_ADD( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_STO_REMOVE( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_STO_SILENT( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_AUTH_AUTO( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_AUTH_LOGIN( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_AUTH_PLAIN( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IMAP_AUTH_OAUTH2( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_OAUTH2_FLOW_UNDEFINED( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_OAUTH2_FLOW_AUTHCODE( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_OAUTH2_FLOW_DEVICECODE( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IPVERSION_4( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IPVERSION_6( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_IPVERSION_6_4( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE MessagePriorityToString( 
            /* [in] */ LONG lVal,
            /* [retval][out] */ BSTR *strVal) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE MessageEncodingToString( 
            /* [in] */ LONG lVal,
            /* [retval][out] */ BSTR *strVal) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE SmtpAuthToString( 
            /* [in] */ LONG lVal,
            /* [retval][out] */ BSTR *strVal) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Pop3AuthToString( 
            /* [in] */ LONG lVal,
            /* [retval][out] */ BSTR *strVal) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE ImapAuthToString( 
            /* [in] */ LONG lVal,
            /* [retval][out] */ BSTR *strVal) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE ImapFetchDataTypeToString( 
            /* [in] */ LONG lVal,
            /* [retval][out] */ BSTR *strVal) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE ImapStoreOptionToString( 
            /* [in] */ LONG lVal,
            /* [retval][out] */ BSTR *strVal) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct IConstantsVtbl
    {
        BEGIN_INTERFACE
        
        DECLSPEC_XFGVIRT(IUnknown, QueryInterface)
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            IConstants * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        DECLSPEC_XFGVIRT(IUnknown, AddRef)
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            IConstants * This);
        
        DECLSPEC_XFGVIRT(IUnknown, Release)
        ULONG ( STDMETHODCALLTYPE *Release )( 
            IConstants * This);
        
        DECLSPEC_XFGVIRT(IDispatch, GetTypeInfoCount)
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfoCount )( 
            IConstants * This,
            /* [out] */ UINT *pctinfo);
        
        DECLSPEC_XFGVIRT(IDispatch, GetTypeInfo)
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfo )( 
            IConstants * This,
            /* [in] */ UINT iTInfo,
            /* [in] */ LCID lcid,
            /* [out] */ ITypeInfo **ppTInfo);
        
        DECLSPEC_XFGVIRT(IDispatch, GetIDsOfNames)
        HRESULT ( STDMETHODCALLTYPE *GetIDsOfNames )( 
            IConstants * This,
            /* [in] */ REFIID riid,
            /* [size_is][in] */ LPOLESTR *rgszNames,
            /* [range][in] */ UINT cNames,
            /* [in] */ LCID lcid,
            /* [size_is][out] */ DISPID *rgDispId);
        
        DECLSPEC_XFGVIRT(IDispatch, Invoke)
        /* [local] */ HRESULT ( STDMETHODCALLTYPE *Invoke )( 
            IConstants * This,
            /* [annotation][in] */ 
            _In_  DISPID dispIdMember,
            /* [annotation][in] */ 
            _In_  REFIID riid,
            /* [annotation][in] */ 
            _In_  LCID lcid,
            /* [annotation][in] */ 
            _In_  WORD wFlags,
            /* [annotation][out][in] */ 
            _In_  DISPPARAMS *pDispParams,
            /* [annotation][out] */ 
            _Out_opt_  VARIANT *pVarResult,
            /* [annotation][out] */ 
            _Out_opt_  EXCEPINFO *pExcepInfo,
            /* [annotation][out] */ 
            _Out_opt_  UINT *puArgErr);
        
        DECLSPEC_XFGVIRT(IConstants, get_EMAIL_MESSAGE_PRIORITY_HIGHEST)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_EMAIL_MESSAGE_PRIORITY_HIGHEST )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_EMAIL_MESSAGE_PRIORITY_HIGH)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_EMAIL_MESSAGE_PRIORITY_HIGH )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_EMAIL_MESSAGE_PRIORITY_MEDIUM)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_EMAIL_MESSAGE_PRIORITY_MEDIUM )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_EMAIL_MESSAGE_PRIORITY_LOW)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_EMAIL_MESSAGE_PRIORITY_LOW )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_EMAIL_MESSAGE_PRIORITY_LOWEST)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_EMAIL_MESSAGE_PRIORITY_LOWEST )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_EMAIL_MESSAGE_ENCODING_DEFAULT)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_EMAIL_MESSAGE_ENCODING_DEFAULT )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_EMAIL_MESSAGE_ENCODING_THAI)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_EMAIL_MESSAGE_ENCODING_THAI )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_EMAIL_MESSAGE_ENCODING_JAPANESE)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_EMAIL_MESSAGE_ENCODING_JAPANESE )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_EMAIL_MESSAGE_ENCODING_CHINESE_SIMP)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_EMAIL_MESSAGE_ENCODING_CHINESE_SIMP )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_EMAIL_MESSAGE_ENCODING_KOREAN)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_EMAIL_MESSAGE_ENCODING_KOREAN )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_EMAIL_MESSAGE_ENCODING_CHINESE_TRAD)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_EMAIL_MESSAGE_ENCODING_CHINESE_TRAD )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_EMAIL_MESSAGE_ENCODING_CENTRALEUROPE)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_EMAIL_MESSAGE_ENCODING_CENTRALEUROPE )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_EMAIL_MESSAGE_ENCODING_RUSSIAN)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_EMAIL_MESSAGE_ENCODING_RUSSIAN )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_EMAIL_MESSAGE_ENCODING_WESTERN)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_EMAIL_MESSAGE_ENCODING_WESTERN )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_EMAIL_MESSAGE_ENCODING_GREEK)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_EMAIL_MESSAGE_ENCODING_GREEK )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_EMAIL_MESSAGE_ENCODING_TURKISH)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_EMAIL_MESSAGE_ENCODING_TURKISH )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_EMAIL_MESSAGE_ENCODING_HEBREW)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_EMAIL_MESSAGE_ENCODING_HEBREW )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_EMAIL_MESSAGE_ENCODING_ARABIC)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_EMAIL_MESSAGE_ENCODING_ARABIC )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_EMAIL_MESSAGE_ENCODING_BALTIC)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_EMAIL_MESSAGE_ENCODING_BALTIC )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_EMAIL_MESSAGE_ENCODING_VIETNAMESE)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_EMAIL_MESSAGE_ENCODING_VIETNAMESE )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_EMAIL_MESSAGE_ENCODING_UTF7)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_EMAIL_MESSAGE_ENCODING_UTF7 )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_EMAIL_MESSAGE_ENCODING_UTF8)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_EMAIL_MESSAGE_ENCODING_UTF8 )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_SMTP_AUTH_AUTO)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_SMTP_AUTH_AUTO )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_SMTP_AUTH_PLAIN)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_SMTP_AUTH_PLAIN )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_SMTP_AUTH_LOGIN)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_SMTP_AUTH_LOGIN )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_SMTP_AUTH_MD5CRAM)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_SMTP_AUTH_MD5CRAM )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_SMTP_AUTH_OAUTH2)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_SMTP_AUTH_OAUTH2 )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_POP3_AUTH_PLAIN)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_POP3_AUTH_PLAIN )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_POP3_AUTH_APOP)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_POP3_AUTH_APOP )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_POP3_AUTH_AUTO)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_POP3_AUTH_AUTO )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_POP3_AUTH_OAUTH2)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_POP3_AUTH_OAUTH2 )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_ALL)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_ALL )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_ANSWERED)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_ANSWERED )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_BCC)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_BCC )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_BEFORE)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_BEFORE )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_BODY)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_BODY )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_CC)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_CC )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_DELETED)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_DELETED )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_DRAFT)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_DRAFT )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_FLAGGED)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_FLAGGED )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_FROM)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_FROM )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_HEADER)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_HEADER )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_KEYWORD)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_KEYWORD )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_LARGER)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_LARGER )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_NEW)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_NEW )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_NOT)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_NOT )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_OLD)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_OLD )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_ON)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_ON )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_OR)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_OR )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_RECENT)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_RECENT )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_SEEN)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_SEEN )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_SENTBEFORE)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_SENTBEFORE )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_SENTON)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_SENTON )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_SENTSINCE)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_SENTSINCE )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_SINCE)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_SINCE )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_SMALLER)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_SMALLER )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_SUBJECT)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_SUBJECT )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_TEXT)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_TEXT )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_TO)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_TO )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_UID)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_UID )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_UNANSWERED)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_UNANSWERED )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_UNDELETED)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_UNDELETED )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_UNDRAFT)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_UNDRAFT )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_UNFLAGGED)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_UNFLAGGED )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_UNKEYWORD)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_UNKEYWORD )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_SK_UNSEEN)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_SK_UNSEEN )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_FM_ALL)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_FM_ALL )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_FM_FAST)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_FM_FAST )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_FM_FULL)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_FM_FULL )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_FDI_BODY)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_FDI_BODY )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_FDI_HEADER)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_FDI_HEADER )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_FDI_HEADER_FIELDS)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_FDI_HEADER_FIELDS )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_FDI_HEADER_FIELDS_NOT)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_FDI_HEADER_FIELDS_NOT )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_FDI_MIME)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_FDI_MIME )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_FDI_TEXT)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_FDI_TEXT )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_FDI_BODY_PEEK)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_FDI_BODY_PEEK )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_FDI_BODYSTRUCTURE)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_FDI_BODYSTRUCTURE )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_FDI_ENVELOPE)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_FDI_ENVELOPE )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_FDI_FLAGS)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_FDI_FLAGS )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_FDI_INTERNALDATE)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_FDI_INTERNALDATE )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_FDI_RFC822)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_FDI_RFC822 )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_FDI_RFC822_HEADER)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_FDI_RFC822_HEADER )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_FDI_RFC822_SIZE)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_FDI_RFC822_SIZE )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_FDI_RFC822_TEXT)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_FDI_RFC822_TEXT )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_FDI_UID)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_FDI_UID )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_MBX_FLAG_NOINFERIORS)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_MBX_FLAG_NOINFERIORS )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_MBX_FLAG_NOSELECT)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_MBX_FLAG_NOSELECT )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_MBX_FLAG_MARKED)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_MBX_FLAG_MARKED )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_MBX_FLAG_UNMARKED)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_MBX_FLAG_UNMARKED )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_MBX_FLAG_ALL)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_MBX_FLAG_ALL )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_MBX_FLAG_ARCHIVE)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_MBX_FLAG_ARCHIVE )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_MBX_FLAG_DRAFTS)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_MBX_FLAG_DRAFTS )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_MBX_FLAG_FLAGGED)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_MBX_FLAG_FLAGGED )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_MBX_FLAG_JUNK)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_MBX_FLAG_JUNK )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_MBX_FLAG_SENT)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_MBX_FLAG_SENT )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_MBX_FLAG_TRASH)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_MBX_FLAG_TRASH )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_MBX_FLAG_HASNOCHILDREN)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_MBX_FLAG_HASNOCHILDREN )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_MBX_FLAG_HASCHILDREN)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_MBX_FLAG_HASCHILDREN )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_MAIL_FLAG_SEEN)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_MAIL_FLAG_SEEN )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_MAIL_FLAG_ANSWERED)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_MAIL_FLAG_ANSWERED )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_MAIL_FLAG_FLAGGED)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_MAIL_FLAG_FLAGGED )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_MAIL_FLAG_DELETED)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_MAIL_FLAG_DELETED )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_MAIL_FLAG_DRAFT)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_MAIL_FLAG_DRAFT )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_MAIL_FLAG_RECENT)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_MAIL_FLAG_RECENT )( 
            IConstants * This,
            /* [retval][out] */ BSTR *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_FD_TYPE_INTEGER)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_FD_TYPE_INTEGER )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_FD_TYPE_STRING)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_FD_TYPE_STRING )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_FD_TYPE_STRING_LITERAL)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_FD_TYPE_STRING_LITERAL )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_FD_TYPE_LIST)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_FD_TYPE_LIST )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_FD_TYPE_ATOM)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_FD_TYPE_ATOM )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_FD_TYPE_NIL)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_FD_TYPE_NIL )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_STO_SET)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_STO_SET )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_STO_ADD)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_STO_ADD )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_STO_REMOVE)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_STO_REMOVE )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_STO_SILENT)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_STO_SILENT )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_AUTH_AUTO)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_AUTH_AUTO )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_AUTH_LOGIN)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_AUTH_LOGIN )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_AUTH_PLAIN)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_AUTH_PLAIN )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IMAP_AUTH_OAUTH2)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IMAP_AUTH_OAUTH2 )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_OAUTH2_FLOW_UNDEFINED)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_OAUTH2_FLOW_UNDEFINED )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_OAUTH2_FLOW_AUTHCODE)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_OAUTH2_FLOW_AUTHCODE )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_OAUTH2_FLOW_DEVICECODE)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_OAUTH2_FLOW_DEVICECODE )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IPVERSION_4)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IPVERSION_4 )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IPVERSION_6)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IPVERSION_6 )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, get_IPVERSION_6_4)
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_IPVERSION_6_4 )( 
            IConstants * This,
            /* [retval][out] */ LONG *pVal);
        
        DECLSPEC_XFGVIRT(IConstants, MessagePriorityToString)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *MessagePriorityToString )( 
            IConstants * This,
            /* [in] */ LONG lVal,
            /* [retval][out] */ BSTR *strVal);
        
        DECLSPEC_XFGVIRT(IConstants, MessageEncodingToString)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *MessageEncodingToString )( 
            IConstants * This,
            /* [in] */ LONG lVal,
            /* [retval][out] */ BSTR *strVal);
        
        DECLSPEC_XFGVIRT(IConstants, SmtpAuthToString)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *SmtpAuthToString )( 
            IConstants * This,
            /* [in] */ LONG lVal,
            /* [retval][out] */ BSTR *strVal);
        
        DECLSPEC_XFGVIRT(IConstants, Pop3AuthToString)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Pop3AuthToString )( 
            IConstants * This,
            /* [in] */ LONG lVal,
            /* [retval][out] */ BSTR *strVal);
        
        DECLSPEC_XFGVIRT(IConstants, ImapAuthToString)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *ImapAuthToString )( 
            IConstants * This,
            /* [in] */ LONG lVal,
            /* [retval][out] */ BSTR *strVal);
        
        DECLSPEC_XFGVIRT(IConstants, ImapFetchDataTypeToString)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *ImapFetchDataTypeToString )( 
            IConstants * This,
            /* [in] */ LONG lVal,
            /* [retval][out] */ BSTR *strVal);
        
        DECLSPEC_XFGVIRT(IConstants, ImapStoreOptionToString)
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *ImapStoreOptionToString )( 
            IConstants * This,
            /* [in] */ LONG lVal,
            /* [retval][out] */ BSTR *strVal);
        
        END_INTERFACE
    } IConstantsVtbl;

    interface IConstants
    {
        CONST_VTBL struct IConstantsVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define IConstants_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define IConstants_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define IConstants_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define IConstants_GetTypeInfoCount(This,pctinfo)	\
    ( (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo) ) 

#define IConstants_GetTypeInfo(This,iTInfo,lcid,ppTInfo)	\
    ( (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo) ) 

#define IConstants_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)	\
    ( (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) ) 

#define IConstants_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)	\
    ( (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) ) 


#define IConstants_get_EMAIL_MESSAGE_PRIORITY_HIGHEST(This,pVal)	\
    ( (This)->lpVtbl -> get_EMAIL_MESSAGE_PRIORITY_HIGHEST(This,pVal) ) 

#define IConstants_get_EMAIL_MESSAGE_PRIORITY_HIGH(This,pVal)	\
    ( (This)->lpVtbl -> get_EMAIL_MESSAGE_PRIORITY_HIGH(This,pVal) ) 

#define IConstants_get_EMAIL_MESSAGE_PRIORITY_MEDIUM(This,pVal)	\
    ( (This)->lpVtbl -> get_EMAIL_MESSAGE_PRIORITY_MEDIUM(This,pVal) ) 

#define IConstants_get_EMAIL_MESSAGE_PRIORITY_LOW(This,pVal)	\
    ( (This)->lpVtbl -> get_EMAIL_MESSAGE_PRIORITY_LOW(This,pVal) ) 

#define IConstants_get_EMAIL_MESSAGE_PRIORITY_LOWEST(This,pVal)	\
    ( (This)->lpVtbl -> get_EMAIL_MESSAGE_PRIORITY_LOWEST(This,pVal) ) 

#define IConstants_get_EMAIL_MESSAGE_ENCODING_DEFAULT(This,pVal)	\
    ( (This)->lpVtbl -> get_EMAIL_MESSAGE_ENCODING_DEFAULT(This,pVal) ) 

#define IConstants_get_EMAIL_MESSAGE_ENCODING_THAI(This,pVal)	\
    ( (This)->lpVtbl -> get_EMAIL_MESSAGE_ENCODING_THAI(This,pVal) ) 

#define IConstants_get_EMAIL_MESSAGE_ENCODING_JAPANESE(This,pVal)	\
    ( (This)->lpVtbl -> get_EMAIL_MESSAGE_ENCODING_JAPANESE(This,pVal) ) 

#define IConstants_get_EMAIL_MESSAGE_ENCODING_CHINESE_SIMP(This,pVal)	\
    ( (This)->lpVtbl -> get_EMAIL_MESSAGE_ENCODING_CHINESE_SIMP(This,pVal) ) 

#define IConstants_get_EMAIL_MESSAGE_ENCODING_KOREAN(This,pVal)	\
    ( (This)->lpVtbl -> get_EMAIL_MESSAGE_ENCODING_KOREAN(This,pVal) ) 

#define IConstants_get_EMAIL_MESSAGE_ENCODING_CHINESE_TRAD(This,pVal)	\
    ( (This)->lpVtbl -> get_EMAIL_MESSAGE_ENCODING_CHINESE_TRAD(This,pVal) ) 

#define IConstants_get_EMAIL_MESSAGE_ENCODING_CENTRALEUROPE(This,pVal)	\
    ( (This)->lpVtbl -> get_EMAIL_MESSAGE_ENCODING_CENTRALEUROPE(This,pVal) ) 

#define IConstants_get_EMAIL_MESSAGE_ENCODING_RUSSIAN(This,pVal)	\
    ( (This)->lpVtbl -> get_EMAIL_MESSAGE_ENCODING_RUSSIAN(This,pVal) ) 

#define IConstants_get_EMAIL_MESSAGE_ENCODING_WESTERN(This,pVal)	\
    ( (This)->lpVtbl -> get_EMAIL_MESSAGE_ENCODING_WESTERN(This,pVal) ) 

#define IConstants_get_EMAIL_MESSAGE_ENCODING_GREEK(This,pVal)	\
    ( (This)->lpVtbl -> get_EMAIL_MESSAGE_ENCODING_GREEK(This,pVal) ) 

#define IConstants_get_EMAIL_MESSAGE_ENCODING_TURKISH(This,pVal)	\
    ( (This)->lpVtbl -> get_EMAIL_MESSAGE_ENCODING_TURKISH(This,pVal) ) 

#define IConstants_get_EMAIL_MESSAGE_ENCODING_HEBREW(This,pVal)	\
    ( (This)->lpVtbl -> get_EMAIL_MESSAGE_ENCODING_HEBREW(This,pVal) ) 

#define IConstants_get_EMAIL_MESSAGE_ENCODING_ARABIC(This,pVal)	\
    ( (This)->lpVtbl -> get_EMAIL_MESSAGE_ENCODING_ARABIC(This,pVal) ) 

#define IConstants_get_EMAIL_MESSAGE_ENCODING_BALTIC(This,pVal)	\
    ( (This)->lpVtbl -> get_EMAIL_MESSAGE_ENCODING_BALTIC(This,pVal) ) 

#define IConstants_get_EMAIL_MESSAGE_ENCODING_VIETNAMESE(This,pVal)	\
    ( (This)->lpVtbl -> get_EMAIL_MESSAGE_ENCODING_VIETNAMESE(This,pVal) ) 

#define IConstants_get_EMAIL_MESSAGE_ENCODING_UTF7(This,pVal)	\
    ( (This)->lpVtbl -> get_EMAIL_MESSAGE_ENCODING_UTF7(This,pVal) ) 

#define IConstants_get_EMAIL_MESSAGE_ENCODING_UTF8(This,pVal)	\
    ( (This)->lpVtbl -> get_EMAIL_MESSAGE_ENCODING_UTF8(This,pVal) ) 

#define IConstants_get_SMTP_AUTH_AUTO(This,pVal)	\
    ( (This)->lpVtbl -> get_SMTP_AUTH_AUTO(This,pVal) ) 

#define IConstants_get_SMTP_AUTH_PLAIN(This,pVal)	\
    ( (This)->lpVtbl -> get_SMTP_AUTH_PLAIN(This,pVal) ) 

#define IConstants_get_SMTP_AUTH_LOGIN(This,pVal)	\
    ( (This)->lpVtbl -> get_SMTP_AUTH_LOGIN(This,pVal) ) 

#define IConstants_get_SMTP_AUTH_MD5CRAM(This,pVal)	\
    ( (This)->lpVtbl -> get_SMTP_AUTH_MD5CRAM(This,pVal) ) 

#define IConstants_get_SMTP_AUTH_OAUTH2(This,pVal)	\
    ( (This)->lpVtbl -> get_SMTP_AUTH_OAUTH2(This,pVal) ) 

#define IConstants_get_POP3_AUTH_PLAIN(This,pVal)	\
    ( (This)->lpVtbl -> get_POP3_AUTH_PLAIN(This,pVal) ) 

#define IConstants_get_POP3_AUTH_APOP(This,pVal)	\
    ( (This)->lpVtbl -> get_POP3_AUTH_APOP(This,pVal) ) 

#define IConstants_get_POP3_AUTH_AUTO(This,pVal)	\
    ( (This)->lpVtbl -> get_POP3_AUTH_AUTO(This,pVal) ) 

#define IConstants_get_POP3_AUTH_OAUTH2(This,pVal)	\
    ( (This)->lpVtbl -> get_POP3_AUTH_OAUTH2(This,pVal) ) 

#define IConstants_get_IMAP_SK_ALL(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_ALL(This,pVal) ) 

#define IConstants_get_IMAP_SK_ANSWERED(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_ANSWERED(This,pVal) ) 

#define IConstants_get_IMAP_SK_BCC(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_BCC(This,pVal) ) 

#define IConstants_get_IMAP_SK_BEFORE(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_BEFORE(This,pVal) ) 

#define IConstants_get_IMAP_SK_BODY(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_BODY(This,pVal) ) 

#define IConstants_get_IMAP_SK_CC(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_CC(This,pVal) ) 

#define IConstants_get_IMAP_SK_DELETED(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_DELETED(This,pVal) ) 

#define IConstants_get_IMAP_SK_DRAFT(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_DRAFT(This,pVal) ) 

#define IConstants_get_IMAP_SK_FLAGGED(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_FLAGGED(This,pVal) ) 

#define IConstants_get_IMAP_SK_FROM(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_FROM(This,pVal) ) 

#define IConstants_get_IMAP_SK_HEADER(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_HEADER(This,pVal) ) 

#define IConstants_get_IMAP_SK_KEYWORD(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_KEYWORD(This,pVal) ) 

#define IConstants_get_IMAP_SK_LARGER(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_LARGER(This,pVal) ) 

#define IConstants_get_IMAP_SK_NEW(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_NEW(This,pVal) ) 

#define IConstants_get_IMAP_SK_NOT(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_NOT(This,pVal) ) 

#define IConstants_get_IMAP_SK_OLD(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_OLD(This,pVal) ) 

#define IConstants_get_IMAP_SK_ON(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_ON(This,pVal) ) 

#define IConstants_get_IMAP_SK_OR(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_OR(This,pVal) ) 

#define IConstants_get_IMAP_SK_RECENT(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_RECENT(This,pVal) ) 

#define IConstants_get_IMAP_SK_SEEN(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_SEEN(This,pVal) ) 

#define IConstants_get_IMAP_SK_SENTBEFORE(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_SENTBEFORE(This,pVal) ) 

#define IConstants_get_IMAP_SK_SENTON(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_SENTON(This,pVal) ) 

#define IConstants_get_IMAP_SK_SENTSINCE(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_SENTSINCE(This,pVal) ) 

#define IConstants_get_IMAP_SK_SINCE(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_SINCE(This,pVal) ) 

#define IConstants_get_IMAP_SK_SMALLER(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_SMALLER(This,pVal) ) 

#define IConstants_get_IMAP_SK_SUBJECT(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_SUBJECT(This,pVal) ) 

#define IConstants_get_IMAP_SK_TEXT(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_TEXT(This,pVal) ) 

#define IConstants_get_IMAP_SK_TO(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_TO(This,pVal) ) 

#define IConstants_get_IMAP_SK_UID(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_UID(This,pVal) ) 

#define IConstants_get_IMAP_SK_UNANSWERED(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_UNANSWERED(This,pVal) ) 

#define IConstants_get_IMAP_SK_UNDELETED(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_UNDELETED(This,pVal) ) 

#define IConstants_get_IMAP_SK_UNDRAFT(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_UNDRAFT(This,pVal) ) 

#define IConstants_get_IMAP_SK_UNFLAGGED(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_UNFLAGGED(This,pVal) ) 

#define IConstants_get_IMAP_SK_UNKEYWORD(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_UNKEYWORD(This,pVal) ) 

#define IConstants_get_IMAP_SK_UNSEEN(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_SK_UNSEEN(This,pVal) ) 

#define IConstants_get_IMAP_FM_ALL(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_FM_ALL(This,pVal) ) 

#define IConstants_get_IMAP_FM_FAST(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_FM_FAST(This,pVal) ) 

#define IConstants_get_IMAP_FM_FULL(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_FM_FULL(This,pVal) ) 

#define IConstants_get_IMAP_FDI_BODY(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_FDI_BODY(This,pVal) ) 

#define IConstants_get_IMAP_FDI_HEADER(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_FDI_HEADER(This,pVal) ) 

#define IConstants_get_IMAP_FDI_HEADER_FIELDS(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_FDI_HEADER_FIELDS(This,pVal) ) 

#define IConstants_get_IMAP_FDI_HEADER_FIELDS_NOT(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_FDI_HEADER_FIELDS_NOT(This,pVal) ) 

#define IConstants_get_IMAP_FDI_MIME(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_FDI_MIME(This,pVal) ) 

#define IConstants_get_IMAP_FDI_TEXT(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_FDI_TEXT(This,pVal) ) 

#define IConstants_get_IMAP_FDI_BODY_PEEK(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_FDI_BODY_PEEK(This,pVal) ) 

#define IConstants_get_IMAP_FDI_BODYSTRUCTURE(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_FDI_BODYSTRUCTURE(This,pVal) ) 

#define IConstants_get_IMAP_FDI_ENVELOPE(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_FDI_ENVELOPE(This,pVal) ) 

#define IConstants_get_IMAP_FDI_FLAGS(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_FDI_FLAGS(This,pVal) ) 

#define IConstants_get_IMAP_FDI_INTERNALDATE(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_FDI_INTERNALDATE(This,pVal) ) 

#define IConstants_get_IMAP_FDI_RFC822(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_FDI_RFC822(This,pVal) ) 

#define IConstants_get_IMAP_FDI_RFC822_HEADER(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_FDI_RFC822_HEADER(This,pVal) ) 

#define IConstants_get_IMAP_FDI_RFC822_SIZE(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_FDI_RFC822_SIZE(This,pVal) ) 

#define IConstants_get_IMAP_FDI_RFC822_TEXT(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_FDI_RFC822_TEXT(This,pVal) ) 

#define IConstants_get_IMAP_FDI_UID(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_FDI_UID(This,pVal) ) 

#define IConstants_get_IMAP_MBX_FLAG_NOINFERIORS(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_MBX_FLAG_NOINFERIORS(This,pVal) ) 

#define IConstants_get_IMAP_MBX_FLAG_NOSELECT(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_MBX_FLAG_NOSELECT(This,pVal) ) 

#define IConstants_get_IMAP_MBX_FLAG_MARKED(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_MBX_FLAG_MARKED(This,pVal) ) 

#define IConstants_get_IMAP_MBX_FLAG_UNMARKED(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_MBX_FLAG_UNMARKED(This,pVal) ) 

#define IConstants_get_IMAP_MBX_FLAG_ALL(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_MBX_FLAG_ALL(This,pVal) ) 

#define IConstants_get_IMAP_MBX_FLAG_ARCHIVE(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_MBX_FLAG_ARCHIVE(This,pVal) ) 

#define IConstants_get_IMAP_MBX_FLAG_DRAFTS(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_MBX_FLAG_DRAFTS(This,pVal) ) 

#define IConstants_get_IMAP_MBX_FLAG_FLAGGED(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_MBX_FLAG_FLAGGED(This,pVal) ) 

#define IConstants_get_IMAP_MBX_FLAG_JUNK(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_MBX_FLAG_JUNK(This,pVal) ) 

#define IConstants_get_IMAP_MBX_FLAG_SENT(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_MBX_FLAG_SENT(This,pVal) ) 

#define IConstants_get_IMAP_MBX_FLAG_TRASH(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_MBX_FLAG_TRASH(This,pVal) ) 

#define IConstants_get_IMAP_MBX_FLAG_HASNOCHILDREN(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_MBX_FLAG_HASNOCHILDREN(This,pVal) ) 

#define IConstants_get_IMAP_MBX_FLAG_HASCHILDREN(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_MBX_FLAG_HASCHILDREN(This,pVal) ) 

#define IConstants_get_IMAP_MAIL_FLAG_SEEN(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_MAIL_FLAG_SEEN(This,pVal) ) 

#define IConstants_get_IMAP_MAIL_FLAG_ANSWERED(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_MAIL_FLAG_ANSWERED(This,pVal) ) 

#define IConstants_get_IMAP_MAIL_FLAG_FLAGGED(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_MAIL_FLAG_FLAGGED(This,pVal) ) 

#define IConstants_get_IMAP_MAIL_FLAG_DELETED(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_MAIL_FLAG_DELETED(This,pVal) ) 

#define IConstants_get_IMAP_MAIL_FLAG_DRAFT(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_MAIL_FLAG_DRAFT(This,pVal) ) 

#define IConstants_get_IMAP_MAIL_FLAG_RECENT(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_MAIL_FLAG_RECENT(This,pVal) ) 

#define IConstants_get_IMAP_FD_TYPE_INTEGER(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_FD_TYPE_INTEGER(This,pVal) ) 

#define IConstants_get_IMAP_FD_TYPE_STRING(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_FD_TYPE_STRING(This,pVal) ) 

#define IConstants_get_IMAP_FD_TYPE_STRING_LITERAL(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_FD_TYPE_STRING_LITERAL(This,pVal) ) 

#define IConstants_get_IMAP_FD_TYPE_LIST(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_FD_TYPE_LIST(This,pVal) ) 

#define IConstants_get_IMAP_FD_TYPE_ATOM(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_FD_TYPE_ATOM(This,pVal) ) 

#define IConstants_get_IMAP_FD_TYPE_NIL(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_FD_TYPE_NIL(This,pVal) ) 

#define IConstants_get_IMAP_STO_SET(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_STO_SET(This,pVal) ) 

#define IConstants_get_IMAP_STO_ADD(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_STO_ADD(This,pVal) ) 

#define IConstants_get_IMAP_STO_REMOVE(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_STO_REMOVE(This,pVal) ) 

#define IConstants_get_IMAP_STO_SILENT(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_STO_SILENT(This,pVal) ) 

#define IConstants_get_IMAP_AUTH_AUTO(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_AUTH_AUTO(This,pVal) ) 

#define IConstants_get_IMAP_AUTH_LOGIN(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_AUTH_LOGIN(This,pVal) ) 

#define IConstants_get_IMAP_AUTH_PLAIN(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_AUTH_PLAIN(This,pVal) ) 

#define IConstants_get_IMAP_AUTH_OAUTH2(This,pVal)	\
    ( (This)->lpVtbl -> get_IMAP_AUTH_OAUTH2(This,pVal) ) 

#define IConstants_get_OAUTH2_FLOW_UNDEFINED(This,pVal)	\
    ( (This)->lpVtbl -> get_OAUTH2_FLOW_UNDEFINED(This,pVal) ) 

#define IConstants_get_OAUTH2_FLOW_AUTHCODE(This,pVal)	\
    ( (This)->lpVtbl -> get_OAUTH2_FLOW_AUTHCODE(This,pVal) ) 

#define IConstants_get_OAUTH2_FLOW_DEVICECODE(This,pVal)	\
    ( (This)->lpVtbl -> get_OAUTH2_FLOW_DEVICECODE(This,pVal) ) 

#define IConstants_get_IPVERSION_4(This,pVal)	\
    ( (This)->lpVtbl -> get_IPVERSION_4(This,pVal) ) 

#define IConstants_get_IPVERSION_6(This,pVal)	\
    ( (This)->lpVtbl -> get_IPVERSION_6(This,pVal) ) 

#define IConstants_get_IPVERSION_6_4(This,pVal)	\
    ( (This)->lpVtbl -> get_IPVERSION_6_4(This,pVal) ) 

#define IConstants_MessagePriorityToString(This,lVal,strVal)	\
    ( (This)->lpVtbl -> MessagePriorityToString(This,lVal,strVal) ) 

#define IConstants_MessageEncodingToString(This,lVal,strVal)	\
    ( (This)->lpVtbl -> MessageEncodingToString(This,lVal,strVal) ) 

#define IConstants_SmtpAuthToString(This,lVal,strVal)	\
    ( (This)->lpVtbl -> SmtpAuthToString(This,lVal,strVal) ) 

#define IConstants_Pop3AuthToString(This,lVal,strVal)	\
    ( (This)->lpVtbl -> Pop3AuthToString(This,lVal,strVal) ) 

#define IConstants_ImapAuthToString(This,lVal,strVal)	\
    ( (This)->lpVtbl -> ImapAuthToString(This,lVal,strVal) ) 

#define IConstants_ImapFetchDataTypeToString(This,lVal,strVal)	\
    ( (This)->lpVtbl -> ImapFetchDataTypeToString(This,lVal,strVal) ) 

#define IConstants_ImapStoreOptionToString(This,lVal,strVal)	\
    ( (This)->lpVtbl -> ImapStoreOptionToString(This,lVal,strVal) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */



/* [id][propget] */ HRESULT STDMETHODCALLTYPE IConstants_get_IPVERSION_4_Proxy( 
    IConstants * This,
    /* [retval][out] */ LONG *pVal);


void __RPC_STUB IConstants_get_IPVERSION_4_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [id][propget] */ HRESULT STDMETHODCALLTYPE IConstants_get_IPVERSION_6_Proxy( 
    IConstants * This,
    /* [retval][out] */ LONG *pVal);


void __RPC_STUB IConstants_get_IPVERSION_6_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [id][propget] */ HRESULT STDMETHODCALLTYPE IConstants_get_IPVERSION_6_4_Proxy( 
    IConstants * This,
    /* [retval][out] */ LONG *pVal);


void __RPC_STUB IConstants_get_IPVERSION_6_4_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [id] */ HRESULT STDMETHODCALLTYPE IConstants_MessagePriorityToString_Proxy( 
    IConstants * This,
    /* [in] */ LONG lVal,
    /* [retval][out] */ BSTR *strVal);


void __RPC_STUB IConstants_MessagePriorityToString_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [id] */ HRESULT STDMETHODCALLTYPE IConstants_MessageEncodingToString_Proxy( 
    IConstants * This,
    /* [in] */ LONG lVal,
    /* [retval][out] */ BSTR *strVal);


void __RPC_STUB IConstants_MessageEncodingToString_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [id] */ HRESULT STDMETHODCALLTYPE IConstants_SmtpAuthToString_Proxy( 
    IConstants * This,
    /* [in] */ LONG lVal,
    /* [retval][out] */ BSTR *strVal);


void __RPC_STUB IConstants_SmtpAuthToString_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [id] */ HRESULT STDMETHODCALLTYPE IConstants_Pop3AuthToString_Proxy( 
    IConstants * This,
    /* [in] */ LONG lVal,
    /* [retval][out] */ BSTR *strVal);


void __RPC_STUB IConstants_Pop3AuthToString_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [id] */ HRESULT STDMETHODCALLTYPE IConstants_ImapAuthToString_Proxy( 
    IConstants * This,
    /* [in] */ LONG lVal,
    /* [retval][out] */ BSTR *strVal);


void __RPC_STUB IConstants_ImapAuthToString_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [id] */ HRESULT STDMETHODCALLTYPE IConstants_ImapFetchDataTypeToString_Proxy( 
    IConstants * This,
    /* [in] */ LONG lVal,
    /* [retval][out] */ BSTR *strVal);


void __RPC_STUB IConstants_ImapFetchDataTypeToString_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [id] */ HRESULT STDMETHODCALLTYPE IConstants_ImapStoreOptionToString_Proxy( 
    IConstants * This,
    /* [in] */ LONG lVal,
    /* [retval][out] */ BSTR *strVal);


void __RPC_STUB IConstants_ImapStoreOptionToString_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);



#endif 	/* __IConstants_INTERFACE_DEFINED__ */



#ifndef __AxEmail_LIBRARY_DEFINED__
#define __AxEmail_LIBRARY_DEFINED__

/* library AxEmail */
/* [helpstring][version][uuid] */ 


EXTERN_C const IID LIBID_AxEmail;

EXTERN_C const CLSID CLSID_Message;

#ifdef __cplusplus

class DECLSPEC_UUID("1A9CF5C5-C6E4-48B1-910A-74437BA16414")
Message;
#endif

EXTERN_C const CLSID CLSID_OAuth2;

#ifdef __cplusplus

class DECLSPEC_UUID("FD456C7C-370E-4C9D-8EF5-750A13AAC1ED")
OAuth2;
#endif

EXTERN_C const CLSID CLSID_Smtp;

#ifdef __cplusplus

class DECLSPEC_UUID("CA181116-E4BA-4F09-9176-328CDF8409D5")
Smtp;
#endif

EXTERN_C const CLSID CLSID_Pop3;

#ifdef __cplusplus

class DECLSPEC_UUID("6F7E09C2-CAFF-4501-9E34-F395DF830B87")
Pop3;
#endif

EXTERN_C const CLSID CLSID_ImapFetchData;

#ifdef __cplusplus

class DECLSPEC_UUID("56BC74E1-2204-4049-9B1F-336ED3D57A8C")
ImapFetchData;
#endif

EXTERN_C const CLSID CLSID_Imap;

#ifdef __cplusplus

class DECLSPEC_UUID("B5BB4EE0-3F88-41A8-BC18-65C90A2CFE9E")
Imap;
#endif

EXTERN_C const CLSID CLSID_Constants;

#ifdef __cplusplus

class DECLSPEC_UUID("5F45F782-073A-4D8D-ADB9-23C9F3F34684")
Constants;
#endif
#endif /* __AxEmail_LIBRARY_DEFINED__ */

/* Additional Prototypes for ALL interfaces */

unsigned long             __RPC_USER  BSTR_UserSize(     unsigned long *, unsigned long            , BSTR * ); 
unsigned char * __RPC_USER  BSTR_UserMarshal(  unsigned long *, unsigned char *, BSTR * ); 
unsigned char * __RPC_USER  BSTR_UserUnmarshal(unsigned long *, unsigned char *, BSTR * ); 
void                      __RPC_USER  BSTR_UserFree(     unsigned long *, BSTR * ); 

unsigned long             __RPC_USER  BSTR_UserSize64(     unsigned long *, unsigned long            , BSTR * ); 
unsigned char * __RPC_USER  BSTR_UserMarshal64(  unsigned long *, unsigned char *, BSTR * ); 
unsigned char * __RPC_USER  BSTR_UserUnmarshal64(unsigned long *, unsigned char *, BSTR * ); 
void                      __RPC_USER  BSTR_UserFree64(     unsigned long *, BSTR * ); 

/* end of Additional Prototypes */

#ifdef __cplusplus
}
#endif

#endif


