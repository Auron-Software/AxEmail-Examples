' *************************************************************************************
' SendMail.vbs
'   Send a mail. Load the mail recipients, message, attachements etc. from a mime file
'   (c) Copyright Auron Software B.V.
'   https://www.auronsoftware.com
' *************************************************************************************

Option Explicit

Dim objSmtp, objMail, fso, objConstants
Dim strSmtpServer, strSmtpAccount, strSmtpPassword, strMIMEFile
Dim strRecipient, strAttachment

Set objSmtp        = CreateObject("AxEmail.Smtp")
Set objMail              = CreateObject("AxEmail.Message")
Set objConstants         = CreateObject("AxEmail.Constants")


' A license key is required to unlock this component after the trial period has expired.
' Assign the LicenseKey property every time a new instance of this component is created (see code below). 
' Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry.
' For details, see manual, chapter "Product Activation".
' objSmtp.LicenseKey = "XXXXX-XXXXX-XXXXX"

' Component info
Wscript.Echo "Auron Email Component " & objSmtp.Version
Wscript.Echo "Build: " & objSmtp.Build & vbCrLf & "Module: " & objSmtp.Module
Wscript.Echo "License Status: " & objSmtp.LicenseStatus & vbCrLf & "License Key: " & objSmtp.LicenseKey & vbCrLf

' Set Logfile
Set fso = CreateObject("Scripting.FileSystemObject")
objSmtp.LogFile = fso.GetSpecialFolder(2) & "\Smtp.log"
WScript.Echo "Log file: " & objSmtp.LogFile & vbCrLf

 
' Mail: Load MIME
strMIMEFile  = ReadInput( "Enter MIME file name:", "c:\myemail.mim", False )    
objMail.LoadMIME( strMIMEFile )
Wscript.Echo "LoadMIME, result: " & objMail.LastError & " (" & objMail.GetErrorDescription( objMail.LastError ) & ")"
If( objMail.LastError <> 0 ) Then
  WScript.Quit
End If


' Smtp: Server, Account, Password
strSmtpServer = ReadInput( "Mail server:", "smtp.gmail.com", False )
strSmtpAccount = ReadInput( "Login (optional):", "", True )
If( strSmtpAccount <> "" ) Then
  strSmtpPassword = ReadInput( "Password:", "", True )
End If

' Smtp: Set secure if mail server is a secure (TLS/SSL) mailserver)
If( LCase( strSmtpServer ) = "smtp.gmail.com" ) Then
  objSmtp.SetSecure 465
  WScript.Echo "SetSecure, result: " & objSmtp.LastError & " (" & objSmtp.GetErrorDescription( objSmtp.LastError ) & ")"   
End If
If( objSmtp.LastError <> 0 ) Then
  WScript.Quit
End If

' Smtp: Connect
objSmtp.Connect strSmtpServer, strSmtpAccount, strSmtpPassword  
Wscript.Echo "Connect, result: " & objSmtp.LastError & " (" & objSmtp.GetErrorDescription( objSmtp.LastError ) & ")"
If( objSmtp.LastError <> 0 ) Then
    WScript.Quit
End If


If( objMail.LastError = 0 And objSmtp.LastError = 0) Then
    ' Send mail now
    Wscript.Echo "Sending..."
    objSmtp.Send ( objMail )
    WScript.Echo "Send, result: " & objSmtp.LastError & " (" & objSmtp.GetErrorDescription( objSmtp.LastError ) & ")"
    If( objSmtp.LastSmtpResponse <> "" ) Then
        WScript.Echo "Last response from SMTP Server: " & objSmtp.LastSmtpResponse 
    End If  
End If

' Disconnect
objSmtp.Disconnect
WScript.Echo "Disconnected."

WScript.Echo "Ready."


' *************************************************************************************

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

