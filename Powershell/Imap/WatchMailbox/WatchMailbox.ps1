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
$strImap         = ReadInput "Enter IMAP Server" "imap.gmail.com" $False 
$strImapAccount  = ReadInput "Enter IMAP Account" "" $False 
$strImapPassword = ReadInput "Enter IMAP Password" "" $False
$strMailbox      = ReadInput "Enter Mailbox Name" "INBOX" $False

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

# Select a mailbox first to be able to watch it
$objImap.Select($strMailbox)
write-host "Select, result: " $objImap.LastError " (" $objImap.GetErrorDescription( $objImap.LastError ) ")"

# Another client can open the same mailbox and update, add or delete messages. 
# The IMAP server will send unsolicited expunge message status and fetch data to all 
# other clients to keep them up to date.
while ($objImap.IsConnected)
{
  # While connected regularly execute the NOOP command (No Operation) to retrieve 
  # pending unsolicited information from the IMAP server
  $objImap.Noop()
  
  # Print an overview of the mailbox message and unseen messages
  write-host $objImap.Exists " Messages, " $objImap.Unseen " Unseen"
  
  # Get the message sequence ID's of the messages that have been deleted
  $nExpunged = $objImap.GetPendingExpunged()
  while ($objImap.LastError -eq 0)
  {  
    write-host "unsolicited expunge: " $nExpunged
    $nExpunged = $objImap.GetPendingExpunged()
  }
  
  # Get the message flags of the messages who's flags have been updated.
  $objFetchData = $objImap.GetPendingFetchData()
  while ($objImap.LastError -eq 0)
  {
    write-host "unsolicited fetch data: " $objFetchData.Text
    $objFetchData = $objImap.GetPendingFetchData()
  }
  
  $objImap.Sleep(5000)
}

#Disconnect
$objImap.Disconnect()
write-host "Disconnected."
write-host "Ready."
exit
