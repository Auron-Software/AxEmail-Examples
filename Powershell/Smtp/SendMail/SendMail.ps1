# ********************************************************************
#
# Auron Email Component
#
# Send a simple e-mail
#
# (c) Copyright Auron Software - www.auronsoftware.com
#
# ********************************************************************

# ***************************************************************************
# Function ReadInput
# ***************************************************************************
Function ReadInput($strPrompt, $strDefaultValue, $bAllowEmpty)
{ 
  $strReturn = ""  
  If ($strDefaultValue -ne "")
  {
     $strPrompt += " (leave blanc for " + $strDefaultValue + ")"
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
# The script itself
# ***************************************************************************
cls

$objSmtp = new-object -comobject AxEmail.Smtp
$objConstants = new-object -comobject AxEmail.Constants
$objMail = new-object -comobject AxEmail.Message

# A license key is required to unlock this component after the trial period has expired.
# Assign the LicenseKey property every time a new instance of this component is created (see code below). 
# Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry.
# For details, see manual, chapter "Product Activation".
# 
# $objSmtp.LicenseKey = "XXXXX-XXXXX-XXXXX"  

$strInfo = "Auron Email Component " + $objSmtp.Version + "`r`n"
$strInfo = $strInfo + "Build : " + $objSmtp.Build + "`r`n"
$strInfo = $strInfo + "Module: " + $objSmtp.Module + "`r`n"
$strInfo = $strInfo + "LicenseStatus: " + $objSmtp.LicenseStatus + "`r`n"
If( $objSmtp.LicenseKey -ne "" )
{
  $strInfo = $strInfo + "LicenseKey: " + $objSmtp.LicenseKey + "`r`n"
}
write-host $strInfo
write-host ""

# Set Logfile
$objSmtp.Logfile = $env:temp + "\SMTP_SendMail.txt"
write-host "Log file can be found here:"
write-host $objSmtp.Logfile
write-host ""

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

# Smtp: Mail Server
$strSmtpServer = ReadInput "Mail server:" "smtp.gmail.com" $False
$strSmtpAccount = ReadInput "Login (optional):" "" $True 
If( $strSmtpAccount -ne "" ) 
{
  $strSmtpPassword = ReadInput "Password:" "" $True
}

# Smtp: Secure
If( $strSmtpServer.ToLower() -eq "smtp.gmail.com" )
{
  $objSmtp.SetSecure(465)
  $strResult = "SetSecure, result: " + $objSmtp.LastError + " (" + $objSmtp.GetErrorDescription($objSmtp.LastError) + ")"
  write-host $strResult 
}
if($objSmtp.LastError -ne 0)
{
  exit
}

# Smtp: Connect
$objSmtp.Connect($strSmtpServer, $strSmtpAccount, $strSmtpPassword)
$strResult = "Connect, result: " + $objSmtp.LastError + " (" + $objSmtp.GetErrorDescription($objSmtp.LastError) + ")"
write-host $strResult 
if($objSmtp.LastError -ne 0)
{
  exit
}

# Smtp: Send
$objSmtp.Send($objMail)
$strResult = "Send, result: " + $objSmtp.LastError + " (" + $objSmtp.GetErrorDescription($objSmtp.LastError) + ")"
write-host $strResult 
write-host "Last response from SMTP Server:" $objSmtp.LastSmtpResponse 
 

$objSmtp.Disconnect()

write-host "Disconnected."

write-host "Ready."