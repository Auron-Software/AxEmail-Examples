#ifndef AXEMAILCONSTANTS_H
#define AXEMAILCONSTANTS_H

#define AXEMAIL_IPVERSION_4      0
#define AXEMAIL_IPVERSION_6      1
#define AXEMAIL_IPVERSION_6_4    2


#define AXEMAIL_SMTP_AUTH_AUTO 0					  // Auto detect ( default )
#define AXEMAIL_SMTP_AUTH_PLAIN 1					  // AUTH-PLAIN
#define AXEMAIL_SMTP_AUTH_LOGIN 2					  // AUTH-LOGIN
#define AXEMAIL_SMTP_AUTH_MD5CRAM 3					// AUTH-CRAM-MD5
#define AXEMAIL_SMTP_AUTH_OAUTH2 4          // AUTH XOAUTH2

#define AXEMAIL_SMTP_SERVER_PORT 25
#define AXEMAIL_SMTP_SERVER_PORT_SSL 465

#define AXEMAIL_POP3_SERVER_PORT 110
#define AXEMAIL_POP3_SERVER_PORT_SSL 995

#define AXEMAIL_POP3_AUTH_AUTO 0			// Auto detect ( default )
#define AXEMAIL_POP3_AUTH_PLAIN 1			// Plain text login
#define AXEMAIL_POP3_AUTH_APOP 2			// APOP authentication
#define AXEMAIL_POP3_AUTH_OAUTH2 3			// OAUTH2 authentication

#define AUOA2_FLOW_UNDEFINED 0
#define AUOA2_FLOW_AUTHCODE 1
#define AUOA2_FLOW_DEVICECODE 2

// See http://msdn.microsoft.com/en-us/library/dd317756%28v=vs.85%29.aspx
#define AXEMAIL_MESSAGEENCODING_DEFAULT			    0			// Default Encoding
#define AXEMAIL_MESSAGEENCODING_THAI				  874			// windows-874		ANSI/OEM Thai (same as 28605, ISO 8859-15); Thai (Windows)
#define AXEMAIL_MESSAGEENCODING__SHIFTJIS		  932			// iso-2022-jp		ANSI/OEM Japanese; Japanese
#define AXEMAIL_MESSAGEENCODING_CHINESE_SIMP		  936			// gb2312			ANSI/OEM Simplified Chinese (PRC, Singapore); Chinese Simplified (GB2312)
#define AXEMAIL_MESSAGEENCODING_KOREAN			  949			// ks_c_5601-1987	ANSI/OEM Korean (Unified Hangul Code)
#define AXEMAIL_MESSAGEENCODING_CHINESE_TRAD		  950			// big5				ANSI/OEM Traditional Chinese (Taiwan; Hong Kong SAR, PRC); Chinese Traditional (Big5)
#define AXEMAIL_MESSAGEENCODING_UTF16			 1200			// UTF-16 (LE)
#define AXEMAIL_MESSAGEENCODING_WESTERN			 1252			// iso-8859-1		ANSI Latin 1; Western European (Windows)
#define AXEMAIL_MESSAGEENCODING_VIETNAMESE		 1258			// windows-1258
#define AXEMAIL_MESSAGEENCODING_ASCII			20127			// us-ascii 7bit
#define AXEMAIL_MESSAGEENCODING_CENTRALEUROPE	28592			// iso-8859-2
#define AXEMAIL_MESSAGEENCODING_TURKISH			28593			// iso-8859-3
#define AXEMAIL_MESSAGEENCODING_BALTIC			28594			// iso-8859-4
#define AXEMAIL_MESSAGEENCODING_RUSSIAN			28595			// iso-8859-5
#define AXEMAIL_MESSAGEENCODING_ARABIC			28596			// iso-8859-6
#define AXEMAIL_MESSAGEENCODING_GREEK			28597			// iso-8859-7
#define AXEMAIL_MESSAGEENCODING_HEBREW			28598			// iso-8859-8
#define AXEMAIL_MESSAGEENCODING_JAPANESE			50220			// iso-2022-jp		ISO 2022 Japanese with no halfwidth Katakana; Japanese (JIS)
#define AXEMAIL_MESSAGEENCODING_SHIFTJIS			50221			// iso-2022-jp		ISO 2022 Japanese with halfwidth Katakana; Japanese (JIS-Allow 1 byte Kana)
#define AXEMAIL_MESSAGEENCODING_UTF7				65000			// UTF-7
#define AXEMAIL_MESSAGEENCODING_UTF8				65001			// UTF-8

// Priorities
#define AXEMAIL_MESSAGEPRIORITY_UNDEFINED			0
#define AXEMAIL_MESSAGEPRIORITY_HIGHEST 				1			// Highest priority
#define AXEMAIL_MESSAGEPRIORITY_HIGH 				2			// High priority 
#define AXEMAIL_MESSAGEPRIORITY_MEDIUM				3			// Normal priority (default)
#define AXEMAIL_MESSAGEPRIORITY_LOW					4			// Low priority
#define AXEMAIL_MESSAGEPRIORITY_LOWEST				5			// Lowest priority	

#define AXIMAP_AUTH_AUTO                    0
#define AXIMAP_AUTH_LOGIN                   1
#define AXIMAP_AUTH_PLAIN                   2
#define AXIMAP_AUTH_OAUTH2                  3

// search keys
#define AXIMAP_SK_ALL                       L"ALL"                 // All messages in the mailbox; the default initial key for ANDing.
#define AXIMAP_SK_ANSWERED                  L"ANSWERED"            // Messages with the \Answered flag set.
#define AXIMAP_SK_BCC                       L"BCC"                 // <string> Messages that contain the specified string in the envelope structure's BCC field.
#define AXIMAP_SK_BEFORE                    L"BEFORE"              // <date> Messages whose internal date (disregarding time and timezone) is earlier than the specified date.
#define AXIMAP_SK_BODY                      L"BODY"                // <string> Messages that contain the specified string in the body of the message.
#define AXIMAP_SK_CC                        L"CC"                  // <string> Messages that contain the specified string in the envelope structure's CC field.
#define AXIMAP_SK_DELETED                   L"DELETED"             // Messages with the \Deleted flag set.
#define AXIMAP_SK_DRAFT                     L"DRAFT"               // Messages with the \Draft flag set.
#define AXIMAP_SK_FLAGGED                   L"FLAGGED"             // Messages with the \Flagged flag set.
#define AXIMAP_SK_FROM                      L"FROM"                // <string> Messages that contain the specified string in the envelope structure's FROM field.
#define AXIMAP_SK_HEADER                    L"HEADER"              // <field-name> <string> Messages that have a header with the specified field-name (as defined in [RFC-2822]) and that contains the specified string in the text of the header (what comes after the colon). If the string to search is zero-length, this matches all messages that have a header line with the specified field-name regardless of the contents.
#define AXIMAP_SK_KEYWORD                   L"KEYWORD"             // <flag> Messages with the specified keyword flag set.
#define AXIMAP_SK_LARGER                    L"LARGER"              // <n> Messages with an [RFC-2822] size larger than the specified number of octets.
#define AXIMAP_SK_NEW                       L"NEW"                 // Messages that have the \Recent flag set but not the \Seen flag. This is functionally equivalent to "(RECENT UNSEEN)".
#define AXIMAP_SK_NOT                       L"NOT"                 // <search-key> Messages that do not match the specified search key.
#define AXIMAP_SK_OLD                       L"OLD"                 // Messages that do not have the \Recent flag set. This is functionally equivalent to "NOT RECENT" (as opposed to "NOT NEW").
#define AXIMAP_SK_ON                        L"ON"                  // <date> Messages whose internal date (disregarding time and timezone) is within the specified date.
#define AXIMAP_SK_OR                        L"OR"                  // <search-key1> <search-key2> Messages that match either search key.
#define AXIMAP_SK_RECENT                    L"RECENT"              // Messages that have the \Recent flag set.
#define AXIMAP_SK_SEEN                      L"SEEN"                // Messages that have the \Seen flag set.
#define AXIMAP_SK_SENTBEFORE                L"SENTBEFORE"          // <date> Messages whose [RFC-2822] Date: header (disregarding time and timezone) is earlier than the specified date.
#define AXIMAP_SK_SENTON                    L"SENTON"              // <date> Messages whose [RFC-2822] Date: header (disregarding time and timezone) is within the specified date.
#define AXIMAP_SK_SENTSINCE                 L"SENTSINCE"           // <date> Messages whose [RFC-2822] Date: header (disregarding time and timezone) is within or later than the specified date.
#define AXIMAP_SK_SINCE                     L"SINCE"               // <date> Messages whose internal date (disregarding time and timezone) is within or later than the specified date.
#define AXIMAP_SK_SMALLER                   L"SMALLER"             // <n> Messages with an [RFC-2822] size smaller than the specified number of octets.
#define AXIMAP_SK_SUBJECT                   L"SUBJECT"             // <string> Messages that contain the specified string in the envelope structure's SUBJECT field.
#define AXIMAP_SK_TEXT                      L"TEXT"                // <string> Messages that contain the specified string in the header or body of the message.
#define AXIMAP_SK_TO                        L"TO"                  // <string> Messages that contain the specified string in the envelope structure's TO field.
#define AXIMAP_SK_UID                       L"UID"                 // <sequence set> Messages with unique identifiers corresponding to the specified unique identifier set. Sequence set ranges are permitted.
#define AXIMAP_SK_UNANSWERED                L"UNANSWERED"          // Messages that do not have the \Answered flag set.
#define AXIMAP_SK_UNDELETED                 L"UNDELETED"           // Messages that do not have the \Deleted flag set.
#define AXIMAP_SK_UNDRAFT                   L"UNDRAFT"             // Messages that do not have the \Draft flag set.
#define AXIMAP_SK_UNFLAGGED                 L"UNFLAGGED"           // Messages that do not have the \Flagged flag set.
#define AXIMAP_SK_UNKEYWORD                 L"UNKEYWORD"           // <flag> Messages that do not have the specified keyword flag set.
#define AXIMAP_SK_UNSEEN                    L"UNSEEN"              // Messages that do not have the \Seen flag set.

// fetch macros; use either just the macro or a combination of the data items
#define AXIMAP_FM_ALL                       L"ALL"                 // Macro equivalent to: (FLAGS INTERNALDATE RFC822.SIZE ENVELOPE)
#define AXIMAP_FM_FAST                      L"FAST"                // Macro equivalent to: (FLAGS INTERNALDATE RFC822.SIZE)
#define AXIMAP_FM_FULL                      L"FULL"                // Macro equivalent to: (FLAGS INTERNALDATE RFC822.SIZE ENVELOPE BODY)

// fetchable data items
#define AXIMAP_FDI_BODY                     L"BODY"                // Non-extensible form of BODYSTRUCTURE. or [<section>]<<partial>> The text of a particular body section. The section
#define AXIMAP_FDI_HEADER                   L"HEADER"              // Part specifiers for BODY, BODY.PEEK and RFC822
#define AXIMAP_FDI_HEADER_FIELDS            L"HEADER.FIELDS"       // Part specifiers for BODY, BODY.PEEK and RFC822
#define AXIMAP_FDI_HEADER_FIELDS_NOT        L"HEADER.FIELDS_NOT"   // Part specifiers for BODY, BODY.PEEK and RFC822
#define AXIMAP_FDI_MIME                     L"MIME"                // Part specifiers for BODY, BODY.PEEK and RFC822
#define AXIMAP_FDI_TEXT                     L"TEXT"                // Part specifiers for BODY, BODY.PEEK and RFC822
#define AXIMAP_FDI_BODY_PEEK                L"BODY.PEEK"           // [<section>]<<partial>> An alternate form of BODY[<section>] that does not implicitly set the \Seen flag.
#define AXIMAP_FDI_BODYSTRUCTURE            L"BODYSTRUCTURE"       // The [MIME-IMB] body structure of the message.  This is computed by the server by parsing the [MIME-IMB] header fields in the [RFC-2822] header and [MIME-IMB] headers.
#define AXIMAP_FDI_ENVELOPE                 L"ENVELOPE"            // The envelope structure of the message.  This is computed by the server by parsing the [RFC-2822] header into the component parts, defaulting various fields as necessary.
#define AXIMAP_FDI_FLAGS                    L"FLAGS"               // The flags that are set for this message.
#define AXIMAP_FDI_INTERNALDATE             L"INTERNALDATE"        // The internal date of the message.
#define AXIMAP_FDI_RFC822                   L"RFC822"              // Functionally equivalent to BODY[], differing in the syntax of the resulting untagged FETCH data (RFC822 is returned).
#define AXIMAP_FDI_RFC822_HEADER            L"RFC822.HEADER"       // Functionally equivalent to BODY.PEEK[HEADER], differing in the syntax of the resulting untagged FETCH data (RFC822.HEADER is returned).
#define AXIMAP_FDI_RFC822_SIZE              L"RFC822.SIZE"         // The [RFC-2822] size of the message.
#define AXIMAP_FDI_RFC822_TEXT              L"RFC822.TEXT"         // Functionally equivalent to BODY[TEXT], differing in the syntax of the resulting untagged FETCH data (RFC822.TEXT is returned).
#define AXIMAP_FDI_UID                      L"UID"                 // The unique identifier for the message.

#define AXIMAP_FD_TYPE_INTEGER              1
#define AXIMAP_FD_TYPE_STRING               2
#define AXIMAP_FD_TYPE_STRING_LITERAL       3
#define AXIMAP_FD_TYPE_LIST                 4
#define AXIMAP_FD_TYPE_ATOM                 5
#define AXIMAP_FD_TYPE_NIL                  6

#define AXIMAP_STO_SET                      1                   
#define AXIMAP_STO_ADD                      2
#define AXIMAP_STO_REMOVE                   3
#define AXIMAP_STO_SILENT                   4                      // 'Or' this flag

#define AXIMAP_MBX_FLAG_NOINFERIORS         "\\Noinferiors"  
#define AXIMAP_MBX_FLAG_NOSELECT            "\\Noselect"     
#define AXIMAP_MBX_FLAG_MARKED              "\\Marked"       
#define AXIMAP_MBX_FLAG_UNMARKED            "\\Unmarked"     
#define AXIMAP_MBX_FLAG_ALL                 "\\All"          
#define AXIMAP_MBX_FLAG_ARCHIVE             "\\Archive"      
#define AXIMAP_MBX_FLAG_DRAFTS              "\\Drafts"       
#define AXIMAP_MBX_FLAG_FLAGGED             "\\Flagged"      
#define AXIMAP_MBX_FLAG_JUNK                "\\Junk"         
#define AXIMAP_MBX_FLAG_SENT                "\\Sent"         
#define AXIMAP_MBX_FLAG_TRASH               "\\Trash"        
#define AXIMAP_MBX_FLAG_HASNOCHILDREN       "\\HasNoChildren"
#define AXIMAP_MBX_FLAG_HASCHILDREN         "\\HasChildren"  

#define AXIMAP_MAIL_FLAG_SEEN               L"\\Seen"              // Message has been read
#define AXIMAP_MAIL_FLAG_ANSWERED           L"\\Answered"          // Message has been answered
#define AXIMAP_MAIL_FLAG_FLAGGED            L"\\Flagged"           // Message is "flagged" for urgent/special attention
#define AXIMAP_MAIL_FLAG_DELETED            L"\\Deleted"           // Message is "deleted" for removal by later EXPUNGE
#define AXIMAP_MAIL_FLAG_DRAFT              L"\\Draft"             // Message has not completed composition (marked as a draft).
#define AXIMAP_MAIL_FLAG_RECENT             L"\\Recent"            // Message is "recently" arrived in this mailbox. 

#endif // AXEMAILCONSTANTS_H