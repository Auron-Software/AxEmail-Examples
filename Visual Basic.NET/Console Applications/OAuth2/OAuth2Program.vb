Imports System.IO

Module OAuth2Program

  ' You'll need this function to refresh a bearer token when it's expired
  ' Call it right after expiration And before checking your email. This way 
  ' the user doesn't have to login again.
  Private Sub RefreshBearerToken(ByRef sBearer As String, ByRef sRefresh As String, ByRef nNewTimeoutSec As Integer)
    nNewTimeoutSec = 0
    Dim objOAuth2 As AxEmail.OAuth2 = New AxEmail.OAuth2()

    objOAuth2.ClientID = "" ' TODO : Input your client ID from the google cloud portal
    objOAuth2.ClientSecret = "" ' TODO : Input your client secret from the google cloud portal
    objOAuth2.TokenExchangeUrl = "https://oauth2.googleapis.com/token"
    objOAuth2.BearerToken = sBearer
    objOAuth2.RefreshToken = sRefresh

    objOAuth2.RefreshBearerToken()
    Console.WriteLine("RefreshBearerToken, result: {0} ({1})", objOAuth2.LastError, objOAuth2.GetErrorDescription(objOAuth2.LastError))
    If objOAuth2.LastError <> 0 Then Return

    sBearer = objOAuth2.BearerToken
    sRefresh = objOAuth2.RefreshToken
    nNewTimeoutSec = objOAuth2.BearerExpInSeconds

    Console.WriteLine()
    Console.WriteLine("Bearer token: {0}", objOAuth2.BearerToken)
    Console.WriteLine("Refresh token: {0}", objOAuth2.RefreshToken)
    Console.WriteLine("Bearer token timeout: {0} seconds", objOAuth2.BearerExpInSeconds)
  End Sub

  Sub Main()
    Dim objOAuth2 As AxEmail.OAuth2 = New AxEmail.OAuth2()
    Dim objConstants As AxEmail.Constants = New AxEmail.Constants()

    ' A license key Is required to unlock this component after the trial period has expired.
    ' Assign the LicenseKey property every time a New instance of this component Is created (see code below). 
    ' Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry.
    ' For details, see manual, chapter "Product Activation".
    ' 
    ' objOAuth2.LicenseKey = "XXXXX-XXXXX-XXXXX";
    ' 

    ' Component info
    Console.WriteLine("Auron Email Component {0}" & vbLf & "Build: {1}" & vbLf & "Module: {2}" & vbLf & "License Status: {3}" & vbLf & "License Key: {4}" & vbLf, objOAuth2.Version, objOAuth2.Build, objOAuth2.[Module], objOAuth2.LicenseStatus, objOAuth2.LicenseKey)

    ' Set Logfile (optional, for debugging purposes)
    objOAuth2.LogFile = Path.GetTempPath() & "OAuth2.log"
    Console.WriteLine("Log file used: {0}" & vbLf, objOAuth2.LogFile)

    ' Setup oauth parameters
    objOAuth2.Flow = objConstants.OAUTH2_FLOW_AUTHCODE
    objOAuth2.ClientID = ""
    objOAuth2.ClientSecret = ""
    objOAuth2.RedirectUrl = "http://localhost:7999/oauth2test/"
    objOAuth2.Scope = "https://mail.google.com/"
    objOAuth2.AuthCodeUrl = "https://accounts.google.com/o/oauth2/v2/auth"
    objOAuth2.TokenExchangeUrl = "https://oauth2.googleapis.com/token"

    If objOAuth2.ClientID = "" Then
      Console.WriteLine()
      Console.WriteLine("NOTE: Please open this source file to verify your client id and other OAuth2 paramters")
      Return
    End If

    ' Show the login browser window or user code browser window if device code flow is selected
    objOAuth2.Login()
    Console.WriteLine("Login, result: {0} ({1})", objOAuth2.LastError, objOAuth2.GetErrorDescription(objOAuth2.LastError))
    If objOAuth2.LastError <> 0 Then Return

    ' Wait for the token exchange to happen
    objOAuth2.WaitForTokens(90000)
    Console.WriteLine("WaitForTokens, result: {0} ({1})", objOAuth2.LastError, objOAuth2.GetErrorDescription(objOAuth2.LastError))
    If objOAuth2.LastError <> 0 Then Return

    ' Use the bearer token to login on SMTP, POP3 Or IMAP. 
    ' Use the refresh token to silently refresh you bearer token after it expires
    Console.WriteLine()
    Console.WriteLine("Bearer token: {0}", objOAuth2.BearerToken)
    Console.WriteLine("Refresh token: {0}", objOAuth2.RefreshToken)
    Console.WriteLine("Bearer token timeout: {0} seconds", objOAuth2.BearerExpInSeconds)
  End Sub

End Module
