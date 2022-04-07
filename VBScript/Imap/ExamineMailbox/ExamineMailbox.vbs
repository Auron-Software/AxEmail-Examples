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
strMailbox        = ReadInput( "Enter mailbox to examine", "INBOX", false )

' Set secure if necessary
If( LCase( strServer ) = "imap.gmail.com" ) Then
  objImap.SetSecure
  Wscript.Echo "SetSecure, result: " & objImap.LastError & " (" & objImap.GetErrorDescription( objImap.LastError ) & ")"    
End If

' Connect to IMAP server
objImap.Connect strServer, strServerAccount, strServerPassword
Wscript.Echo "Connect, result: " & objImap.LastError & " (" & objImap.GetErrorDescription( objImap.LastError ) & ")"

' Examine the given mailbox. This will leave unseen massages marked as unseen. 
' use: objImap.Select strMailbox to have unseen emails automatically marked as 'seen'.
objImap.Examine strMailbox

' Fetch email header info for all messages in the given mailbox
Set objEmail = objImap.FetchFirstEmailHeader( objConstants.IMAP_SK_ALL )
While objImap.LastError = 0

  WScript.Echo "MessageID        : " & objEmail.ImapUID
  WScript.Echo "   From          : " & objEmail.FromAddress
  WScript.Echo "   From Name     : " & objEmail.FromName
  WScript.Echo "   To            : " & objEmail.ToAddress
  WScript.Echo "   Subject       : " & objEmail.Subject
  WScript.Echo "   Date          : " & objEmail.Date  
  WScript.Echo vbCrLf 

  Set objEmail = objImap.FetchNextEmailHeader
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

