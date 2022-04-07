'-----------------------------------------------------------------------
' <copyright file="Pop3Program.vb" company="Auron">
'     Copyright (c) Auron Software - www.auronsoftware.com
' </copyright>
' <author>Dennis van de Giessen</author>
'-----------------------------------------------------------------------

Imports AxEmail
Imports System.IO

Module Pop3Program

    Sub Main()
        Dim objPop3 As Pop3 = New Pop3
        Dim objPop3Mail As AxEmail.Message = Nothing
        Dim objConstants As AxEmail.Constants = New AxEmail.Constants
        Dim strYN, strHost, strAccount, strPassword As String
        Dim i As System.Int32 = 0, numMessages As System.Int32 = 0

        ' A license key is required to unlock this component after the trial period has expired.
        ' Assign the LicenseKey property every time a new instance of this component is created (see code below). 
        ' Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry.
        ' For details, see manual, chapter "Product Activation".
        ' objPop3.LicenseKey = "XXXXX-XXXXX-XXXXX"
        
        ' Component info
        Console.WriteLine("Auron Email Component {0}{1}Build: {2}{3}Module: {4}{5}License Status: {6}{7}License Key: {8}{9}", objPop3.Version, Environment.NewLine, objPop3.Build, Environment.NewLine, objPop3.Module, Environment.NewLine, objPop3.LicenseStatus, Environment.NewLine, objPop3.LicenseKey, Environment.NewLine)

        ' Set Logfile (optional, for debugging purposes)
        objPop3.LogFile = Path.GetTempPath() & "Pop3.log"
        Console.WriteLine("Log file used: {0}{1}", objPop3.LogFile, Environment.NewLine)

        strHost = ReadInput("Enter POP3 server (IP address or host name): ", False)
        strAccount = ReadInput("Enter POP3 account: ", False)
        strPassword = ReadInput("Enter POP3 password: ", False)

        Do
            strYN = ReadInput("Is " & strHost & " a secure POP3 server (y/n)?", False).ToUpper()
        Loop Until (strYN.StartsWith("Y") Or strYN.StartsWith("N"))

        If (strYN.StartsWith("Y")) Then
            objPop3.SetSecure(995)
            Console.WriteLine("SetSecure, result: " & objPop3.LastError.ToString() & " (" & objPop3.GetErrorDescription(objPop3.LastError) & ")")
        End If

        objPop3.Connect(strHost, strAccount, strPassword)
        Console.WriteLine("Connect, result: " & objPop3.LastError.ToString() & " (" & objPop3.GetErrorDescription(objPop3.LastError) & ")")

        If (objPop3.LastError = 0) Then
            numMessages = objPop3.CountMessages()
            Console.WriteLine("CountMessages, result: " & objPop3.LastError.ToString() & " (" & objPop3.GetErrorDescription(objPop3.LastError) & ")")
            Console.WriteLine("#Messages in inbox: " & numMessages.ToString())

            ' List all messages
            Console.WriteLine("Listing messages...")
            For i = 1 To numMessages

                objPop3Mail = objPop3.GetEmailHeader(i)
                Console.WriteLine("GetEmailHeader, result: " & objPop3.LastError.ToString() & " (" & objPop3.GetErrorDescription(objPop3.LastError) & ")")
                If (objPop3.LastError = 0) Then
                    Console.WriteLine("MessageID        : " & objPop3Mail.ID)
                    Console.WriteLine("   From          : " & objPop3Mail.FromAddress)
                    Console.WriteLine("   From Name     : " & objPop3Mail.FromName)
                    Console.WriteLine("   To            : " & objPop3Mail.ToAddress)
                    Console.WriteLine("   Subject       : " & objPop3Mail.Subject)
                    Console.WriteLine("   Date          : " & objPop3Mail.Date)
                    Console.WriteLine(String.Empty)
                End If
            Next
        End If

        objPop3.Disconnect()
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
