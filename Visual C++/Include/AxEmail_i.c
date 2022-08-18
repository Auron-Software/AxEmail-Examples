

/* this ALWAYS GENERATED file contains the IIDs and CLSIDs */

/* link this file in with the server and any clients */


 /* File created by MIDL compiler version 7.00.0555 */
/* at Sat Jan 12 14:25:53 2019
 */
/* Compiler settings for AxEmail.idl:
    Oicf, W1, Zp8, env=Win64 (32b run), target_arch=AMD64 7.00.0555 
    protocol : dce , ms_ext, c_ext, robust
    error checks: allocation ref bounds_check enum stub_data 
    VC __declspec() decoration level: 
         __declspec(uuid()), __declspec(selectany), __declspec(novtable)
         DECLSPEC_UUID(), MIDL_INTERFACE()
*/
/* @@MIDL_FILE_HEADING(  ) */

#pragma warning( disable: 4049 )  /* more than 64k source lines */


#ifdef __cplusplus
extern "C"{
#endif 


#include <rpc.h>
#include <rpcndr.h>

#ifdef _MIDL_USE_GUIDDEF_

#ifndef INITGUID
#define INITGUID
#include <guiddef.h>
#undef INITGUID
#else
#include <guiddef.h>
#endif

#define MIDL_DEFINE_GUID(type,name,l,w1,w2,b1,b2,b3,b4,b5,b6,b7,b8) \
        DEFINE_GUID(name,l,w1,w2,b1,b2,b3,b4,b5,b6,b7,b8)

#else // !_MIDL_USE_GUIDDEF_

#ifndef __IID_DEFINED__
#define __IID_DEFINED__

typedef struct _IID
{
    unsigned long x;
    unsigned short s1;
    unsigned short s2;
    unsigned char  c[8];
} IID;

#endif // __IID_DEFINED__

#ifndef CLSID_DEFINED
#define CLSID_DEFINED
typedef IID CLSID;
#endif // CLSID_DEFINED

#define MIDL_DEFINE_GUID(type,name,l,w1,w2,b1,b2,b3,b4,b5,b6,b7,b8) \
        const type name = {l,w1,w2,{b1,b2,b3,b4,b5,b6,b7,b8}}

#endif !_MIDL_USE_GUIDDEF_

MIDL_DEFINE_GUID(IID, IID_IMessage,0xCC87528F,0xD4BF,0x4BFE,0x8D,0xF7,0x9B,0xFB,0x57,0xD3,0x38,0x10);


MIDL_DEFINE_GUID(IID, IID_ISmtp,0xFE73AE95,0xA7C6,0x4E98,0x8A,0xF2,0xCA,0xB9,0x4A,0xAE,0x74,0x3A);


MIDL_DEFINE_GUID(IID, IID_IPop3,0x7D24A1B3,0x4808,0x4208,0x9A,0x9F,0x2A,0x28,0x12,0x56,0x74,0x4A);


MIDL_DEFINE_GUID(IID, IID_IImapFetchData,0xE867B037,0x8B16,0x4C91,0xB4,0xF3,0x91,0xA5,0xA5,0xB9,0x03,0x2F);


MIDL_DEFINE_GUID(IID, IID_IImap,0x2F17D77B,0x374D,0x431E,0x87,0x72,0x8F,0xD1,0xB2,0x0D,0x15,0x16);


MIDL_DEFINE_GUID(IID, IID_IConstants,0xAD78421F,0x9ECA,0x4BFD,0x81,0xE6,0x94,0x71,0x2D,0x62,0xDE,0xFD);


MIDL_DEFINE_GUID(IID, LIBID_AxEmail,0x3BCF1B58,0x7071,0x4564,0x9D,0x1D,0xFA,0x00,0x8B,0x19,0x17,0x9A);


MIDL_DEFINE_GUID(CLSID, CLSID_Message,0x1A9CF5C5,0xC6E4,0x48B1,0x91,0x0A,0x74,0x43,0x7B,0xA1,0x64,0x14);


MIDL_DEFINE_GUID(CLSID, CLSID_Smtp,0xCA181116,0xE4BA,0x4F09,0x91,0x76,0x32,0x8C,0xDF,0x84,0x09,0xD5);


MIDL_DEFINE_GUID(CLSID, CLSID_Pop3,0x6F7E09C2,0xCAFF,0x4501,0x9E,0x34,0xF3,0x95,0xDF,0x83,0x0B,0x87);


MIDL_DEFINE_GUID(CLSID, CLSID_ImapFetchData,0x56BC74E1,0x2204,0x4049,0x9B,0x1F,0x33,0x6E,0xD3,0xD5,0x7A,0x8C);


MIDL_DEFINE_GUID(CLSID, CLSID_Imap,0xB5BB4EE0,0x3F88,0x41A8,0xBC,0x18,0x65,0xC9,0x0A,0x2C,0xFE,0x9E);


MIDL_DEFINE_GUID(CLSID, CLSID_Constants,0x5F45F782,0x073A,0x4D8D,0xAD,0xB9,0x23,0xC9,0xF3,0xF3,0x46,0x84);

#undef MIDL_DEFINE_GUID

#ifdef __cplusplus
}
#endif



