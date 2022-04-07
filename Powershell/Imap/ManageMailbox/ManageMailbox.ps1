# ***************************************************************************
#
# Auron Email Component
# Delete messages from mailbox on a IMAP server
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
# MAIN SCRIPT
# ***************************************************************************
cls

$objImap = new-object -comobject AxEmail.Imap

# A license key is required to unlock this component after the trial period has expired.
# Assign the LicenseKey property every time a new instance of this component is created (see code below). 
# Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry.
# For details, see manual, chapter "Product Activation".
# 
# $objImap.LicenseKey = "XXXXX-XXXXX-XXXXX"  

# Display Serial Port Component Version
write-host "Auron Email Component " $objImap.Version "`nBuild: " $objImap.Build "`nModule: "  $objImap.Module "`nLicense Status: " $objImap.LicenseStatus "`nLicense Key: " $objImap.LicenseKey "`n`n";

# Logfile
$objImap.Logfile = $env:temp + "\Imap.log"
write-host "Log file used: " $objImap.Logfile "`n"

# Read IMAP properties
$strImap   = ReadInput "Enter IMAP Server" "imap.gmail.com" $False 
$strImapAccount  = ReadInput "Enter IMAP Account" "" $False 
$strImapPassword = ReadInput "Enter IMAP Password" "" $False
$strNewMailbox = ReadInput "Enter New Mailbox Name" "AxTestMailbox" $False

# Set secure of if necessary
If ($strImap.ToLower() -eq "imap.gmail.com")
{
  $objImap.SetSecure()
  $strResult = "SetSecure, result: " + $objImap.LastError + " (" + $objImap.GetErrorDescription($objImap.LastError) + ")"
  write-host $strResult 
}

# Connect to the IMAP server
If ($objImap.LastError -eq 0)
{
  $objImap.Connect($strImap, $strImapAccount, $strImapPassword)
  $strResult = "Connect, result: " + $objImap.LastError + " (" + $objImap.GetErrorDescription($objImap.LastError) + ")"
  write-host $strResult 
}

$objImap.Create($strNewMailbox)
write-host "Create, result: " $objImap.LastError " (" $objImap.GetErrorDescription( $objImap.LastError ) ")"

$objImap.Rename($strNewMailbox, $strNewMailbox + "_renamed")
write-host "Rename, result: " $objImap.LastError " (" $objImap.GetErrorDescription( $objImap.LastError ) ")"

$objImap.Delete($strNewMailbox + "_renamed")
write-host "Delete, result: " $objImap.LastError " (" $objImap.GetErrorDescription( $objImap.LastError ) ")"

#Disconnect
$objImap.Disconnect()
write-host "Disconnected."
write-host "Ready."
exit
