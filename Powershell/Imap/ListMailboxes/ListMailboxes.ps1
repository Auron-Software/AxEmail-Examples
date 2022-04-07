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

# List mailboxes. This command lists all mailboxes directly under the top level
# To find sub mailboxes for the mailbox 'INBOX' use: objImap.List "INBOX", "%"
$objImap.List("", "%")
write-host "List, result: " $objImap.LastError " (" $objImap.GetErrorDescription( $objImap.LastError ) ")"
write-host

$nCount = $objImap.ListCount()
write-host "Found " $objImap.ListCount " mailboxes:"
if ($nCount -gt 0)
{
  for ($i = 0; $i -lt $nCount; $i++)
  {  
    $strMailboxName = $objImap.ListName($i)
    $strMailboxAttributes = $objImap.ListAttributes($i)
    
    write-host "  "  $strMailboxName ": " $strMailboxAttributes
  }
}

#Disconnect
$objImap.Disconnect()
write-host "Disconnected."
write-host "Ready."
exit
