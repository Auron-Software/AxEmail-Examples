Imports System.IO

Module OAuth2Program

  Sub Main()
    Dim objOAuth2 As AxEmail.OAuth2 = New AxEmail.OAuth2()
    Dim objConstants As AxEmail.Constants = New AxEmail.Constants()

    Console.WriteLine("Auron Email Component {0}" & vbLf & "Build: {1}" & vbLf & "Module: {2}" & vbLf & "License Status: {3}" & vbLf & "License Key: {4}" & vbLf, objOAuth2.Version, objOAuth2.Build, objOAuth2.[Module], objOAuth2.LicenseStatus, objOAuth2.LicenseKey)
    objOAuth2.LogFile = Path.GetTempPath() & "OAuth2.log"
    Console.WriteLine("Log file used: {0}" & vbLf, objOAuth2.LogFile)

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

    objOAuth2.Login()
    Console.WriteLine("Login, result: {0} ({1})", objOAuth2.LastError, objOAuth2.GetErrorDescription(objOAuth2.LastError))
    If objOAuth2.LastError <> 0 Then Return

    objOAuth2.WaitForTokens(90000)
    Console.WriteLine("WaitForTokens, result: {0} ({1})", objOAuth2.LastError, objOAuth2.GetErrorDescription(objOAuth2.LastError))
    If objOAuth2.LastError <> 0 Then Return

    Console.WriteLine()
    Console.WriteLine("Bearer token: {0}", objOAuth2.BearerToken)
    Console.WriteLine("Refresh token: {0}", objOAuth2.RefreshToken)
    Console.WriteLine("Bearer token timeout: {0} seconds", objOAuth2.BearerExpInSeconds)
  End Sub

End Module
