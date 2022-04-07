'-----------------------------------------------------------------------
' <copyright file="SmtpSendMimeProgram.vb" company="Auron">
'     Copyright (c) Auron Software - www.auronsoftware.com
' </copyright>
' <author>Dennis van de Giessen</author>
'-----------------------------------------------------------------------

Imports AxEmail
Imports System.IO

Module SmtpSendMimeProgram

    Sub Main()
        Dim strMIMEFile As String, strHost As String = String.Empty, strAccount As String = String.Empty, strPassword As String = String.Empty, strYN As String = String.Empty

        Dim objMail As AxEmail.Message = New AxEmail.Message
        Dim objSmtp As AxEmail.Smtp = New AxEmail.Smtp
        Dim objConstants As AxEmail.Constants = New AxEmail.Constants

        ' Use SetLicense with the license key to unlock this component. SetLicense will need to be called 
        ' everytime a new instance of this component is created. Alternatively, use SaveLicense to store the
        ' license key in the registry. You only need to call SaveLicense once.
        ' SetLicense is the recommended method when distributing this component with your own software.
        '
        ' objSmtp.SetLicense( "XXXXX-XXXXX-XXXXX" ) 
        
        ' Component info
        Console.WriteLine("Auron Email Component {0}{1}Build: {2}{3}Module: {4}{5}License Status: {6}{7}License Key: {8}{9}", objSmtp.Version, Environment.NewLine, objSmtp.Build, Environment.NewLine, objSmtp.Module, Environment.NewLine, objSmtp.LicenseStatus, Environment.NewLine, objSmtp.LicenseKey, Environment.NewLine)

        ' Set Logfile (optional, for debugging purposes)
        objSmtp.LogFile = Path.GetTempPath() & "Smtp.log"
        Console.WriteLine("Log file used: {0}{1}", objSmtp.LogFile, Environment.NewLine)

        ' Mail: Clear (good practise)
        objMail.Clear()


        strMIMEFile = ReadInput("Load MIME information to the following MIME file: ", False)
        objMail.LoadMIME(strMIMEFile)
        Console.WriteLine("LoadMIME, result: " & objMail.LastError.ToString() & " (" & objMail.GetErrorDescription(objMail.LastError) & ")")
        If (objMail.LastError <> 0) Then
            Exit Sub
        End If

        ' Smtp: Clear (good practise)
        objSmtp.Clear()

        ' Smtp: Host
        strHost = ReadInput("SMTP server", False)

        ' Smtp: Secure
        Do
            strYN = ReadInput("Is " & strHost & " a secure SMTP server (y/n)?", False).ToUpper()
        Loop Until strYN.StartsWith("Y") Or strYN.StartsWith("N")
        If (strYN.StartsWith("Y")) Then
            objSmtp.SetSecure(465)
            Console.WriteLine("SetSecure, result: " & objMail.LastError.ToString() & " (" & objMail.GetErrorDescription(objMail.LastError) & ")")
            If (objSmtp.LastError <> 0) Then
                Exit Sub
            End If
        End If

        ' Smtp: Account/Password (optional)
        strAccount = ReadInput("SMTP server account (optional)", True)
        If (strAccount.Length > 0) Then
            strPassword = ReadInput("SMTP server password", True)
        End If

        ' Smtp: Connect
        objSmtp.Connect(strHost, strAccount, strPassword)   ' Pass additional Account and Password parameters if server requires authentication
        Console.WriteLine("Connect, result: " & objSmtp.LastError.ToString() & " (" & objSmtp.GetErrorDescription(objSmtp.LastError) & ")")
        If (objSmtp.LastError <> 0) Then
            Exit Sub
        End If

        ' Smtp: Send
        objSmtp.Send(objMail)
        Console.WriteLine("Send, result: " & objSmtp.LastError & " (" & objSmtp.GetErrorDescription(objSmtp.LastError) & ")")
        Console.WriteLine("Last response from SMTP Server: " & objSmtp.LastSmtpResponse)

        ' Smtp: Disconnect
        objSmtp.Disconnect()
        Console.WriteLine("Disconnected.")
        Console.WriteLine("Ready.")
        Console.WriteLine("Press <ENTER> to continue.")
        Console.ReadLine()
    End Sub

    Private Function ReadInput(ByVal strTitle, ByVal bAllowEmpty) As String
        Dim strInput As String = String.Empty
        Dim strReturn As String = String.Empty

        Console.WriteLine(strTitle)
        Do
            Console.Write("  > ")
            strInput = Console.ReadLine()
            If (strInput.Length > 0) Then
                strReturn = strInput
            End If
        Loop Until strReturn <> String.Empty Or bAllowEmpty

        ReadInput = strReturn
    End Function
End Module
