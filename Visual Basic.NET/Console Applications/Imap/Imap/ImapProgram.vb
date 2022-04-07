Imports System.IO
Imports AxEmail

Module ImapProgram

  Sub Main()
    Dim objImap As AxEmail.Imap = New AxEmail.Imap
    Dim objConstants As AxEmail.Constants = New AxEmail.Constants
    Dim objMessage As AxEmail.Message = Nothing
    Dim strYN As String = ""
    Dim strHost As String = ""
    Dim strAccount As String = ""
    Dim strPassword As String = ""
    Console.WriteLine("Auron Email Component {0}" & vbLf & "Build: {1}" & vbLf & "Module: {2}" & vbLf & "License Status: {3}" & vbLf & "License Key: {4}" & vbLf, objImap.Version, objImap.Build, objImap.Module, objImap.LicenseStatus, objImap.LicenseKey)
    ' Set Logfile (optional, for debugging purposes)
    objImap.LogFile = Path.GetTempPath & "objImap.log"
    Console.WriteLine("Log file used: {0}" & vbLf, objImap.LogFile)
    strHost = ImapProgram.ReadInput("Enter IMAP server (IP address or host name):", False)
    strAccount = ImapProgram.ReadInput("Enter IMAP account:", False)
    strPassword = ImapProgram.ReadInput("Enter IMAP password:", False)

    Do Until (Not strYN.StartsWith("Y") _
                AndAlso Not strYN.StartsWith("N"))
      strYN = ImapProgram.ReadInput("Is " & strHost & " a secure POP3 server (y/n)?", False).ToUpper

    Loop

    If strYN.StartsWith("Y") Then
      objImap.SetSecure()
      Console.WriteLine("SetSecure, result: " _
                      & objImap.LastError & " (" _
                      & objImap.GetErrorDescription(objImap.LastError) & ")")
    End If

    ' Use SetLicense with the license key to unlock this component. SetLicense will need to be called 
    ' everytime a new instance of this component is created. Alternatively, use SaveLicense to store the
    ' license key in the registry. You only need to call SaveLicense once.
    ' SetLicense is the recommended method when distributing this component with your own software.
    '
    ' objImap.SetLicense( "XXXXX-XXXXX-XXXXX" )
    ' Connects to the IMAP server
    objImap.Connect(strHost, strAccount, strPassword)
    Console.WriteLine("Connect, result: " _
                    & objImap.LastError & " (" _
                    & objImap.GetErrorDescription(objImap.LastError) & ")")
    If (objImap.LastError = 0) Then
      objMessage = objImap.FetchFirstEmailHeader(objConstants.IMAP_SK_ALL)
      Console.WriteLine("FetchFirstEmailHeader, result: " _
                      & objImap.LastError & " (" _
                      & objImap.GetErrorDescription(objImap.LastError) + ")")

      While (objImap.LastError = 0)
        Console.WriteLine("MessageID        : " & objMessage.ID)
        Console.WriteLine("   From          : " & objMessage.FromAddress)
        Console.WriteLine("   From Name     : " & objMessage.FromName)
        Console.WriteLine("   To            : " & objMessage.ToAddress)
        Console.WriteLine("   Subject       : " & objMessage.Subject)
        Console.WriteLine("   Date          : " & objMessage.Date)
        Console.WriteLine(String.Empty)
        objMessage = objImap.FetchNextEmailHeader
        Console.WriteLine("FetchNextEmailHeader, result: " _
                        & objImap.LastError & " (" _
                        & objImap.GetErrorDescription(objImap.LastError) & ")")

      End While

    End If

    objImap.Disconnect()
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
