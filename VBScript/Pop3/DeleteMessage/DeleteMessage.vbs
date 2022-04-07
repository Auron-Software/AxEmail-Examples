' ********************************************************************
'
' Auron Auron Email Component
' Delete messages from mailbox on a POP3 server
' (c) Copyright Auron Software - www.auronsoftware.com
'
' ********************************************************************


Option Explicit

Dim objPop3, objPop3Mail, fso
Dim strPop3, strPop3Account, strPop3Password
Dim numMessages, numMessageID, i

' Create POP3 object
Set objPop3 = CreateObject( "AxEmail.Pop3" )

' A license key is required to unlock this component after the trial period has expired.
' Assign the LicenseKey property every time a new instance of this component is created (see code below). 
' Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry.
' For details, see manual, chapter "Product Activation".
' objPop3.LicenseKey = "XXXXX-XXXXX-XXXXX"

' Component info
Wscript.Echo "Auron Email Component " & objPop3.Version
Wscript.Echo "Build: " & objPop3.Build & vbCrLf & "Module: " & objPop3.Module
Wscript.Echo "License Status: " & objPop3.LicenseStatus & vbCrLf & "License Key: " & objPop3.LicenseKey & vbCrLf

' Set Logfile
Set fso = CreateObject("Scripting.FileSystemObject")
objPop3.LogFile = fso.GetSpecialFolder(2) & "\Pop3.log"
WScript.Echo "Log file: " & objPop3.LogFile

' Read POP3 properties
strPop3   = ReadInput( "Enter POP3 Server", "pop.gmail.com", false )
strPop3Account  = ReadInput( "Enter POP3 Account", "", false )
strPop3Password = ReadInput( "Enter POP3 Password", "", false )

' Set secure if necessary
If( LCase( strPop3 ) = "pop.gmail.com" ) Then
  objPop3.SetSecure 995
  Wscript.Echo "SetSecure, result: " & objPop3.LastError & " (" & objPop3.GetErrorDescription( objPop3.LastError ) & ")"  
End If

If (objPop3.LastError = 0) Then
  ' Connect to the POP3 server
  objPop3.Connect strPop3, strPop3Account, strPop3Password
  Wscript.Echo "Connect, result: " & objPop3.LastError & " (" & objPop3.GetErrorDescription( objPop3.LastError ) & ")"
End If

If (objPop3.LastError = 0) Then
  ' Count messages
  numMessages = objPop3.CountMessages()
  Wscript.Echo "CountMessages, result: " & objPop3.LastError & " (" & objPop3.GetErrorDescription( objPop3.LastError ) & ")"  
End If

If (objPop3.LastError = 0) Then
  WScript.Echo "#New message(s) on server: " & numMessages

  ' Iterate over all messages
  If( numMessages > 0 ) Then

    WScript.Echo "Listing messages..."
    For i = 1 to numMessages
      Set objPop3Mail = objPop3.GetEmailHeader ( i )
      Wscript.Echo "GetEmailHeader (" &  i & "), result: " & objPop3.LastError & " (" & objPop3.GetErrorDescription( objPop3.LastError ) & ")"      
      If( objPop3.LastError = 0 ) Then
        WScript.Echo "Message #" & objPop3Mail.ID & vbCrLf & _
                   "  From: " & objPop3Mail.FromAddress & vbCrLf & _
                   "  Subject: " & Left( objPop3Mail.Subject, 50 )
      End If
    Next

    Do
      numMessageID = CInt( ReadInput( "Which message do you want to delete ? (type 0 to cancel)", "1", false ) )
      If( numMessageID > 0 ) Then  
        WScript.Echo 
        objPop3.DeleteMessage( numMessageID )
        WScript.Echo "DeleteMessage, result: " & objPop3.LastError & " (" & objPop3.GetErrorDescription( objPop3.LastError ) & ")"
      End If
    Loop Until numMessageID <= 0
  End If
End If

' Disconnect
objPop3.Disconnect
WScript.Echo "Disconnected."

WScript.Echo "Ready."


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
   
   
   

