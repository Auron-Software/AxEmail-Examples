' *************************************************************************************
' CreateMime.vbs
'   Create a MIME message
'   (c) Copyright Auron Software B.V.
'   https://www.auronsoftware.com
' *************************************************************************************

Option Explicit

Dim objMail, objConstants
Dim strRecipient, strAttachment, strMIMEFile

Set objMail          = CreateObject("AxEmail.Message")
Set objConstants     = CreateObject("AxEmail.Constants")

objMail.Clear

objMail.FromAddress  = ReadInput( "FROM e-mail address:", "me@mydomain.local", False )      ' Some mail servers (including MS Exchange) require an existing mail address on that server

strRecipient = ReadInput( "TO e-mail address:", "you@yourdomain.local", False )
objMail.AddTo strRecipient, strRecipient    
WScript.Echo "AddTo, result: " & objMail.LastError & " (" & objMail.GetErrorDescription( objMail.LastError ) & ")"

If (objMail.LastError = 0) Then
  strRecipient = ReadInput( "CC e-mail address (optional):", "", True )
  If( strRecipient <> "" ) Then 
    objMail.AddCc strRecipient, strRecipient 
    WScript.Echo "AddCc, result: " & objMail.LastError & " (" & objMail.GetErrorDescription( objMail.LastError ) & ")" 
  End If  
End If

If (objMail.LastError = 0) Then
  strRecipient = ReadInput( "BCC e-mail address (optional):", "", True )
  If( strRecipient <> "" ) Then 
    objMail.AddBcc strRecipient, strRecipient  
    WScript.Echo "AddBcc, result: " & objMail.LastError & " (" & objMail.GetErrorDescription( objMail.LastError ) & ")"     
  End If  
End If

If (objMail.LastError = 0) Then
  strAttachment = ReadInput( "Attachment (optional):", "", True )
  If( strAttachment <> "" ) Then 
    objMail.AddAttachment strAttachment  
    WScript.Echo "AddAttachment, result: " & objMail.LastError & " (" & objMail.GetErrorDescription( objMail.LastError ) & ")"     
  End If  
End If

If (objMail.LastError = 0) Then
  objMail.Subject       = ReadInput( "Subject:", "Auron Email Component message.", False )
  objMail.BodyPlainText = ReadInput( "Message (Plain Text):", "Hello, world!", False)
  objMail.BodyHtml      = ReadInput( "Message (Html):", "<b>Hello, world!</b>", False)
  objMail.Priority     = objConstants.EMAIL_MESSAGE_PRIORITY_MEDIUM  ' Normal (default) priority
  objMail.Encoding     = objConstants.EMAIL_MESSAGE_ENCODING_DEFAULT

  strMIMEFile = ReadInput( "Save information to MIME file:", "c:\myemail.mim", True )

  'Encode MIME
  objMail.Encode()
  WScript.Echo "Encode, result: " & objMail.LastError & " (" & objMail.GetErrorDescription( objMail.LastError ) & ")"
End If

If (objMail.LastError = 0) Then
  ' Save MIME file now
  objMail.SaveMIME( strMIMEFile )
  WScript.Echo "SaveMIME, result: " & objMail.LastError & " (" & objMail.GetErrorDescription( objMail.LastError ) & ")"
End If

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





