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

' Set secure if necessary
If( LCase( strServer ) = "imap.gmail.com" ) Then
  objImap.SetSecure
  Wscript.Echo "SetSecure, result: " & objImap.LastError & " (" & objImap.GetErrorDescription( objImap.LastError ) & ")"    
End If

' Connect to IMAP server
objImap.Connect strServer, strServerAccount, strServerPassword
Wscript.Echo "Connect, result: " & objImap.LastError & " (" & objImap.GetErrorDescription( objImap.LastError ) & ")"

' List mailboxes. This command lists all mailboxes directly under the top level
' To find sub mailboxes for the mailbox 'INBOX' use: objImap.List "INBOX", "%"
objImap.List "", "%"
Wscript.Echo "List, result: " & objImap.LastError & " (" & objImap.GetErrorDescription( objImap.LastError ) & ")"
WScript.Echo

nCount = objImap.ListCount
WScript.Echo "Found " & objImap.ListCount & " mailboxes:"
If nCount > 0 Then
  For i = 0 to nCount - 1
    strMailboxName = objImap.ListName(i)
    strMailboxAttributes = objImap.ListAttributes(i)
    
    WScript.Echo "  "  & strMailboxName & ": " & strMailboxAttributes
  Next
End If

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

