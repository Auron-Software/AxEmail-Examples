# ***************************************************************************
#
# Auron Email Component
#
# Create a MIME message
#
# (c) Copyright Auron Software - www.auronsoftware.com
#   
# ***************************************************************************

# ***************************************************************************
# Function ReadInput
# ***************************************************************************
Function ReadInput($strPrompt, $strDefaultValue, $bAllowEmpty)
{ 
  $strReturn = ""  
  If ($strDefaultValue -ne "")
  {
     $strPrompt += " (leave empty for " + $strDefaultValue + ")"
  }
  
  Do 
  {       
    write-host $strPrompt
    $strReturn = read-host
    
    If ($strReturn -eq "" -and $strDefaultValue -ne "")
    {
      $strReturn = $strDefaultValue
      write-host $strReturn
    }
    elseif ($strReturn -eq "" -and $bAllowEmpty -eq $True)
    {
      break
    }   
  } While ($strReturn -eq "") 
  
  write-host ""
  return $strReturn
}


# ***************************************************************************
# MAIN SCRIPT
# ***************************************************************************
cls

$objMail = new-object -comobject AxEmail.Message
$objConstants = new-object -comobject AxEmail.Constants

# Mail: Clear
$objMail.Clear()

# Mail: From  
$objMail.FromAddress  = ReadInput "FROM e-mail address:" "" $True       # Some mail servers (including MS Exchange) require an existing mail address on that server

# Mail: Subject  
  $objMail.Subject      = ReadInput "Subject:" "" $False
  
# Mail: Body 
$objMail.BodyPlainText  = ReadInput "Message (Plain Text):" "Hello, world!" $False
$objMail.BodyHtml       = ReadInput "Message (Html):" "<b>Hello, world!</b>" $False
  
# Mail: Priority  
$objMail.Priority       = $objConstants.EMAIL_MESSAGE_PRIORITY_MEDIUM   # Normal (default) priority

# Mail: Encoding
$objMail.Encoding       = $objConstants.EMAIL_MESSAGE_ENCODING_DEFAULT


# Mail: To
$strRecipient = ReadInput "To e-mail address:" "" $False
$objMail.AddTo($strRecipient, $strRecipient)
$strResult = "AddTo, result: " + $objMail.LastError + " (" + $objMail.GetErrorDescription($objMail.LastError) + ")"
write-host $strResult 
if($objMail.LastError -ne 0)
{
  exit
}

# Mail: Cc
$strRecipient = ReadInput "CC e-mail address (optional):" "" $True
if ($strRecipient -ne "")
{
  $objMail.AddCc($strRecipient, $strRecipient)
  $strResult = "AddCc, result: " + $objMail.LastError + " (" + $objMail.GetErrorDescription($objMail.LastError) + ")"
  write-host $strResult 
}
if($objMail.LastError -ne 0)
{
  exit
}

# Mail: Attachment
$strAttachment = ReadInput "Attachment (optional):" "" $True
if ($strAttachment -ne "")
{
  $objMail.AddAttachment($strAttachment)
  $strResult = "AddAttachment, result: " + $objMail.LastError + " (" + $objMail.GetErrorDescription($objMail.LastError) + ")"
  write-host $strResult 
}
if($objMail.LastError -ne 0)
{
  exit
}

# Mail: Encode MIME
$objMail.Encode()
$strResult = "Encode, result: " + $objMail.LastError + " (" + $objMail.GetErrorDescription($objMail.LastError) + ")"
write-host $strResult 
if($objMail.LastError -ne 0)
{
  exit
}

# Mail: Save MIME file now
$strMIMEFile            = ReadInput "Save information to MIME file:" "c:\myemail.mim" $False
$objMail.SaveMIME($strMIMEFile)
$strResult = "SaveMIME, result: " + $objMail.LastError + " (" + $objMail.GetErrorDescription($objMail.LastError) + ")"
write-host $strResult 

write-host "Ready."



