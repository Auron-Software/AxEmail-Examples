' ********************************************************************
'
' Auron Email Component
' OAuth2 authrization using the authorization code flow
' (c) Copyright Auron Software - www.auronsoftware.com
'
' ********************************************************************

Set objOAuth2 = CreateObject("AxEmail.OAuth2")
Set objConstants = CreateObject("AxEmail.Constants")

' A license key is required to unlock this component after the trial period has expired.
' Assign the LicenseKey property every time a new instance of this component is created (see code below). 
' Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry.
' For details, see manual, chapter "Product Activation".
' objOAuth2.LicenseKey = "XXXXX-XXXXX-XXXXX"

' Component info
Wscript.Echo "Auron Email Component " & objOAuth2.Version
Wscript.Echo "Build: " & objOAuth2.Build & vbCrLf & "Module: " & objOAuth2.Module
Wscript.Echo "License Status: " & objOAuth2.LicenseStatus & vbCrLf & "License Key: " & objOAuth2.LicenseKey & vbCrLf

' Set Logfile
Set fso = CreateObject("Scripting.FileSystemObject")
objOAuth2.LogFile = fso.GetSpecialFolder(2) & "\OAuth2.log"
WScript.Echo "Log file: " & objOAuth2.LogFile

' This example works with Google to gain access to a users e-mail using IMAP, SMTP and POP3.
' To use a different service please update the scope, device code url and token exchange url accordingly
objOAuth2.Flow = objConstants.OAUTH2_FLOW_AUTHCODE
objOAuth2.ClientID = "" ' Enter your client id (Create an application in the google cloud console)
objOAuth2.ClientSecret = "" ' Enter your client secret
objOAuth2.RedirectUrl = "http://localhost:7999/oauth2test/"   ' Must be the URL used when creating your google application
objOAuth2.Scope = "https://mail.google.com/"
objOAuth2.AuthCodeUrl = "https://accounts.google.com/o/oauth2/v2/auth"
objOAuth2.TokenExchangeUrl = "https://oauth2.googleapis.com/token"

' Test if the client ID is set
If objOAuth2.ClientID = "" Then
  WScript.Echo
  WScript.Echo "NOTE: Please open this source file to verify your client id and other OAuth2 parameters."
  WScript.Quit 1
End If

' Collect device and usercode and show the login page
objOAuth2.Login
WScript.Echo "Login result " & objOAuth2.LastError & _
  ": " & objOAuth2.GetErrorDescription(objOAuth2.LastError)

' Wait for the user to login
objOAuth2.WaitForTokens(60000)
WScript.Echo "WaitForTokens result " & objOAuth2.LastError & _
  ": " & objOAuth2.GetErrorDescription(objOAuth2.LastError)

' Display the bearer and refresh tokens. The bearer token needs to be passed to the SMTP, IMAP or POP object.
WScript.Echo
WScript.Echo "Bearer token: " & objOAuth2.BearerToken
WScript.Echo "Refresh token: " & objOAuth2.RefreshToken
WScript.Echo "Bearer timeout: " & objOAuth2.BearerExpInSeconds & " seconds"
