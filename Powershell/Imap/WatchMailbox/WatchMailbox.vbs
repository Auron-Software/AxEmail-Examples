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

' Another client can open the same mailbox and update, add or delete messages. 
' The IMAP server will send unsolicited expunge message status and fetch data to all 
' other clients to keep them up to date.
While objImap.IsConnected

  ' While connected regularly execute the NOOP command (No Operation) to retrieve 
  ' pending unsolicited information from the IMAP server
  objImap.Noop()
  
  ' Print an overview of the mailbox message and unseen messages
  WScript.Echo objImap.Exists & " Messages, " & objImap.Unseen & " Unseen"
  
  ' Get the message sequence ID's of the messages that have been deleted
  nExpunged = objImap.GetPendingExpunged
  While objImap.LastError = 0
    WScript.Echo "unsolicited expunge: " & nExpunged
    nExpunged = objImap.GetPendingExpunged
  WEnd
  
  ' Get the message flags of the messages who's flags have been updated.
  Set objFetchData = objImap.GetPendingFetchData
  While objImap.LastError = 0
    WScript.Echo "unsolicited fetch data: " & objFetchData.Text
    Set objFetchData = objImap.GetPendingFetchData
  WEnd
  
  objImap.Sleep 5000
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

