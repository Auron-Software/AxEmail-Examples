# ****************************************************************************
#
# Auron Email Component
#
# Send a mail. Load the mail recipients, message, attachements etc.
# from a mime file
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
     $strPrompt += " leave empty for " + $strDefaultValue
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

# Clear (good practise)
$objSmtp.Clear()

# A license key is required to unlock this component after the trial period has expired.
# Assign the LicenseKey property every time a new instance of this component is created (see code below). 
# Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry.
# For details, see manual, chapter "Product Activation".
# 
# $objSmtp.LicenseKey = "XXXXX-XXXXX-XXXXX"  
# Display Serial Port Component Version
write-host "Auron Email Component " $objSmtp.Version "`nBuild: " $objSmtp.Build "`nModule: "  $objSmtp.Module "`nLicense Status: " $objSmtp.LicenseStatus "`nLicense Key: " $objSmtp.LicenseKey "`n`n";

# Logfile
$objSmtp.Logfile = $env:temp + "\Pop3.log"
write-host "Log file used: " $objSmtp.Logfile "`n"

# Mail: Load mime
$strMIMEFile = ReadInput "Enter MIME file name:" "c:\myemail.mim" $False
$objMail.Clear()
$objMail.LoadMIME($strMIMEFile)
$strResult = "LoadMIME, result: " + $objMail.LastError + " (" + $objMail.GetErrorDescription($objMail.LastError) + ")"
write-host $strResult 
if($objMail.LastError -ne 0)
{
  exit
}

  
# Smtp: credentials
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