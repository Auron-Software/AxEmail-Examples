' ********************************************************************
'
' Auron Email Component
' List mailbox messages on a IMAP server
' (c) Copyright Auron Software - www.auronsoftware.com
'
' ********************************************************************

' Create Imap object
Set objImap = CreateObject( "AxEmail.Imap" )
Set objConstants = CreateObject( "AxEmail.Constants" )

' A license key is required to unlock this component after the trial period has expired.
' Assign the LicenseKey property every time a new instance of this component is created (see code below). 
' Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry.
' For details, see manual, chapter "Product Activation".
' objImap.LicenseKey = "XXXXX-XXXXX-XXXXX"

' Component info
Wscript.Echo "Auron Email Component " & objImap.Version
Wscript.Echo "Build: " & objImap.Build & vbCrLf & "Module: " & objImap.Module
Wscript.Echo "License Status: " & objImap.LicenseStatus & vbCrLf & "License Key: " & objImap.LicenseKey & vbCrLf

' Set Logfile
Set fso = CreateObject("Scripting.FileSystemObject")
objImap.LogFile = fso.GetSpecialFolder(2) & "\Imap.log"
WScript.Echo "Log file: " & objImap.LogFile

' Read connection properties
strServer         = ReadInput( "Enter IMAP Server", "imap.gmail.com", false )
strServerAccount  = ReadInput( "Enter IMAP Account", "", false )
strServerPassword = ReadInput( "Enter IMAP Password", "", false )
strMailbox = ReadInput( "Enter Mailbox name", "INBOX", false )

' Set secure if necessary
If( LCase( strServer ) = "imap.gmail.com" ) Then
  objImap.SetSecure
  Wscript.Echo "SetSecure, result: " & objImap.LastError & " (" & objImap.GetErrorDescription( objImap.LastError ) & ")"    
End If

' Connect to IMAP server
objImap.Connect strServer, strServerAccount, strServerPassword
Wscript.Echo "Connect, result: " & objImap.LastError & " (" & objImap.GetErrorDescription( objImap.LastError ) & ")"

' Select a mailbox first to be able to watch it
objImap.Select strMailbox
Wscript.Echo "Select, result: " & objImap.LastError & " (" & objImap.GetErrorDescription( objImap.LastError ) & ")"

' Fetch envelope data from the server
' The Imap component has built in support for Email headers and Email messages.
' Envelope data is a subset of the normal header data and can be fetched through a general
' FetchData call which can be used for any kind of custom fetch request you may need.

' This is the IMAP RFC information about the contents of an 'Envelope structure':
'      ENVELOPE
'         A parenthesized list that describes the envelope structure of a
'         message.  This is computed by the server by parsing the
'         [RFC-2822] header into the component parts, defaulting various
'         fields as necessary.
'
'         The fields of the envelope structure are in the following
'         order: date, subject, from, sender, reply-to, to, cc, bcc,
'         in-reply-to, and message-id.  The date, subject, in-reply-to,
'         and message-id fields are strings.  The from, sender, reply-to,
'         to, cc, and bcc fields are parenthesized lists of address
'         structures.
'
'         An address structure is a parenthesized list that describes an
'         electronic mail address.  The fields of an address structure
'         are in the following order: personal name, [SMTP]
'         at-domain-list (source route), mailbox name, and host name.

Set objFetchData = objImap.FetchFirst(objConstants.IMAP_SK_ALL, objConstants.IMAP_FM_ALL)
While objImap.LastError = 0
  
  ' Get the top-level envelope element from the fetch data
  Set objEnvelope = objFetchData.GetSubDataByName("ENVELOPE")
  Set objFrom = objEnvelope.GetSubData(2).GetSubData(0)
  Set objTo = objEnvelope.GetSubData(4).GetSubData(0)
  
  WScript.Echo "Email UID: " & objFetchData.GetSubDataByName("UID").Value
  WScript.Echo "  Date: "    & objEnvelope.GetSubData(0).Value
  WScript.Echo "  From: "    & objFrom.GetSubData(2).Value & "@" & objFrom.GetSubData(3).Value
  WScript.Echo "  To: "      & objTo.GetSubData(2).Value & "@" & objTo.GetSubData(3).Value
  WScript.Echo "  Subject: " & objEnvelope.GetSubData(1).Value
  WScript.Echo
  
  Set objFetchData = objImap.FetchNext
WEnd


' Disconnect from server
objImap.Disconnect

' ***************************************************************************
' Function ReadInput
' ***************************************************************************
Function ReadInput( ByVal strTitle, ByVal strDefault, ByVal bAllowEmpty )

  Dim strInput, strReturn

  Do
    strInput = inputbox( strTitle, "Enter value", strDefault )
    If ( strInput <> "" ) Then
       strReturn = strInput
    End If
  Loop until strReturn <> "" Or bAllowEmpty

  ReadInput = strReturn
End Function

