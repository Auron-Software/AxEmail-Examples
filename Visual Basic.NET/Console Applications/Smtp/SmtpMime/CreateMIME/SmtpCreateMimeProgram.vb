'-----------------------------------------------------------------------
' <copyright file="SmtpCreateMimeProgram.vb" company="Auron">
'     Copyright (c) Auron Software - www.auronsoftware.com
' </copyright>
' <author>Dennis van de Giessen</author>
'-----------------------------------------------------------------------

Imports AxEmail

Module SmtpCreateMimeProgram
    Sub Main()
        Dim objMail As AxEmail.Message = New AxEmail.Message
        Dim objConstants As AxEmail.Constants = New AxEmail.Constants
        Dim strFromAddress, strTo, strCc, strBcc, strAttachment, strMIMEFile As String
        strMIMEFile = String.Empty

        objMail.Clear()

        strFromAddress = ReadInput("FromAddress (the sender's e-mail address)", True)
        objMail.FromAddress = strFromAddress
        objMail.FromName = strFromAddress ' You can assign any displayable name

        strTo = ReadInput("ToAddress", False)
        objMail.AddTo(strTo, strTo)
        Console.WriteLine("AddTo, result: " & objMail.LastError & " (" & objMail.GetErrorDescription(objMail.LastError) & ")")

        If (objMail.LastError = 0) Then
            strCc = ReadInput("CcAddress (optional)", True)
            If (strCc <> String.Empty) Then
                objMail.AddCc(strCc, strCc)
                Console.WriteLine("AddCc, result: " & objMail.LastError & " (" & objMail.GetErrorDescription(objMail.LastError) & ")")
            End If
        End If

        If (objMail.LastError = 0) Then
            strBcc = ReadInput("BccAddress (optional)", True)
            If (strBcc <> String.Empty) Then
                objMail.AddBcc(strBcc, strBcc)
                Console.WriteLine("AddBcc, result: " & objMail.LastError & " (" & objMail.GetErrorDescription(objMail.LastError) & ")")
            End If
        End If

        If (objMail.LastError = 0) Then
            objMail.Encoding = objConstants.EMAIL_MESSAGE_ENCODING_DEFAULT
            objMail.Priority = objConstants.EMAIL_MESSAGE_PRIORITY_MEDIUM

            objMail.Subject = ReadInput("Subject: ", False)
            objMail.BodyPlainText = ReadInput("Message", False)

            strAttachment = ReadInput("Attachment File (optional)", True)
            If (strAttachment <> String.Empty) Then
                objMail.AddAttachment(strAttachment)
                Console.WriteLine("AddAttachment, result: " & objMail.LastError & " (" & objMail.GetErrorDescription(objMail.LastError) & ")")
            End If
        End If

        If (objMail.LastError = 0) Then
            strMIMEFile = ReadInput("Save information to the following MIME file: ", False)

            objMail.Encode()
            Console.WriteLine("Encode, result: " & objMail.LastError & " (" & objMail.GetErrorDescription(objMail.LastError) & ")")
        End If

        If (objMail.LastError = 0) Then
            objMail.SaveMIME(strMIMEFile)
            Console.WriteLine("SaveMIME, result: " & objMail.LastError & " (" & objMail.GetErrorDescription(objMail.LastError) & ")")
        End If

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
