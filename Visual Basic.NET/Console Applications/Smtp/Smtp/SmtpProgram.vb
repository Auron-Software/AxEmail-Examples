'-----------------------------------------------------------------------
' <copyright file="SmtpProgram.vb" company="Auron">
'     Copyright (c) Auron Software - www.auronsoftware.com
' </copyright>
' <author>Dennis van de Giessen</author>
'-----------------------------------------------------------------------

Imports AxEmail
Imports System.IO

Module SmtpProgram

    Sub Main()
        Dim objSmtpMail As AxEmail.Message = New AxEmail.Message
        Dim objSmtp As AxEmail.Smtp = New AxEmail.Smtp
        Dim objConstants As AxEmail.Constants = New AxEmail.Constants

        Dim strHost As String = String.Empty, strAccount As String = String.Empty, strPassword As String = String.Empty, strFromAddress As String = String.Empty, strTo As String = String.Empty, strCc As String = String.Empty, strBcc As String = String.Empty, strAttachment As String = String.Empty, strYN As String = String.Empty

        ' A license key is required to unlock this component after the trial period has expired.
        ' Assign the LicenseKey property every time a new instance of this component is created (see code below). 
        ' Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry.
        ' For details, see manual, chapter "Product Activation".
        ' objSmtp.LicenseKey = "XXXXX-XXXXX-XXXXX"
        
        ' Component info
        Console.WriteLine("Auron Email Component {0}{1}Build: {2}{3}Module: {4}{5}License Status: {6}{7}License Key: {8}{9}", objSmtp.Version, Environment.NewLine, objSmtp.Build, Environment.NewLine, objSmtp.Module, Environment.NewLine, objSmtp.LicenseStatus, Environment.NewLine, objSmtp.LicenseKey, Environment.NewLine)

        ' Set Logfile (optional, for debugging purposes)
        objSmtp.LogFile = Path.GetTempPath() & "Smtp.log"
        Console.WriteLine("Log file used: {0}{1}", objSmtp.LogFile, Environment.NewLine)

        ' Mail: Clear (good practise)
        objSmtpMail.Clear()

        ' Mail: Encoding
        objSmtpMail.Encoding = objConstants.EMAIL_MESSAGE_ENCODING_DEFAULT

        ' Mail: Priority
        objSmtpMail.Priority = objConstants.EMAIL_MESSAGE_PRIORITY_MEDIUM

        ' Mail: From
        strFromAddress = ReadInput("E-mail From:", True)
        objSmtpMail.FromAddress = strFromAddress
        objSmtpMail.FromName = strFromAddress ' You can assign any displayable name

        ' Mail: Subject
        objSmtpMail.Subject = ReadInput("Subject:", False)

        ' Mail: Body
        objSmtpMail.BodyPlainText = ReadInput("Message:", False)

        ' Mail: TO recipient(s)
        strTo = ReadInput("E-mail to:", False)
        objSmtpMail.AddTo(strTo, strTo)
        Console.WriteLine("AddTo, result: " & objSmtpMail.LastError & " (" & objSmtpMail.GetErrorDescription(objSmtpMail.LastError) & ")")
        If (objSmtpMail.LastError <> 0) Then
            Exit Sub
        End If

        ' Mail: CC recipient(s)
        strCc = ReadInput("E-mail CC (optional):", True)
        If (strCc <> "") Then
            objSmtpMail.AddCc(strCc, strCc)
            Console.WriteLine("AddCc, result: " & objSmtpMail.LastError & " (" & objSmtpMail.GetErrorDescription(objSmtpMail.LastError) & ")")
            If (objSmtpMail.LastError <> 0) Then
                Exit Sub
            End If
        End If

        ' Mail: Attachments
        strAttachment = ReadInput("Attachment File (optional): ", True)
        If (strAttachment <> String.Empty) Then
            objSmtpMail.AddAttachment(strAttachment)
            Console.WriteLine("AddAttachment, result: " & objSmtpMail.LastError & " (" & objSmtpMail.GetErrorDescription(objSmtpMail.LastError) & ")")
            If (objSmtpMail.LastError <> 0) Then
                Exit Sub
            End If
        End If

        ' SMTP: Host
        strHost = ReadInput("SMTP server:", False)
        Do
            strYN = ReadInput("Is " & strHost & " a secure SMTP server (y/n)?", False).ToUpper()
        Loop Until (strYN.StartsWith("Y") Or strYN.StartsWith("N"))
        objSmtp.Clear()
        If (strYN.StartsWith("Y")) Then
            objSmtp.SetSecure(465)
            Console.WriteLine("SetSecure, result: " & objSmtp.LastError & " (" & objSmtp.GetErrorDescription(objSmtp.LastError) & ")")
            If (objSmtp.LastError <> 0) Then
                Exit Sub
            End If
        End If

        ' SMTP Account (optional)
        strAccount = ReadInput("SMTP server account (optional):", True)
        If (strAccount.Length > 0) Then
            strPassword = ReadInput("SMTP server password:", True)
        End If


        ' SMTP: Connect
        objSmtp.Connect(strHost, strAccount, strPassword)    ' Pass additional Account and Password parameters if server requires authentication
        Console.WriteLine("Connect, result: " & objSmtp.LastError & " (" & objSmtp.GetErrorDescription(objSmtp.LastError) & ")")
        If (objSmtp.LastError <> 0) Then
            Exit Sub
        End If

        ' SMTP: Send
        objSmtp.Send(objSmtpMail)
        Console.WriteLine("Send, result: " & objSmtp.LastError & " (" & objSmtp.GetErrorDescription(objSmtp.LastError) & ")")
        Console.WriteLine("Last response from SMTP Server: " & objSmtp.LastSmtpResponse)

        ' SMTP: Disconnect
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
