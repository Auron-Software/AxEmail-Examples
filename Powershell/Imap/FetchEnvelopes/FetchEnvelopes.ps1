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
$objConstants = new-object -comobject AxEmail.Constants

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
$strMailbox      = ReadInput "Enter Mailbox" "INBOX" $False

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

# Fetch envelope data from the server
# The Imap component has built in support for Email headers and Email messages.
# Envelope data is a subset of the normal header data and can be fetched through a general
# FetchData call which can be used for any kind of custom fetch request you may need.
#
# This is the IMAP RFC information about the contents of an 'Envelope structure':
#      ENVELOPE
#         A parenthesized list that describes the envelope structure of a
#         message.  This is computed by the server by parsing the
#         [RFC-2822] header into the component parts, defaulting various
#         fields as necessary.
#
#         The fields of the envelope structure are in the following
#         order: date, subject, from, sender, reply-to, to, cc, bcc,
#         in-reply-to, and message-id.  The date, subject, in-reply-to,
#         and message-id fields are strings.  The from, sender, reply-to,
#         to, cc, and bcc fields are parenthesized lists of address
#         structures.
#
#         An address structure is a parenthesized list that describes an
#         electronic mail address.  The fields of an address structure
#         are in the following order: personal name, [SMTP]
#         at-domain-list (source route), mailbox name, and host name.

$objFetchData = $objImap.FetchFirst($objConstants.IMAP_SK_ALL, $objConstants.IMAP_FM_ALL)
while ($objImap.LastError -eq 0)
{  
  # Get the top-level envelope element from the fetch data
  $objEnvelope = $objFetchData.GetSubDataByName("ENVELOPE")
  $objFrom = $objEnvelope.GetSubData(2).GetSubData(0)
  $objTo = $objEnvelope.GetSubData(4).GetSubData(0)
  
  write-host "Email UID: " $objFetchData.GetSubDataByName("UID").Value
  write-host "  Date: "    $objEnvelope.GetSubData(0).Value
  write-host "  From: "    $objFrom.GetSubData(2).Value "@" $objFrom.GetSubData(3).Value
  write-host "  To: "      $objTo.GetSubData(2).Value "@" $objTo.GetSubData(3).Value
  write-host "  Subject: " $objEnvelope.GetSubData(1).Value
  write-host
  
  $objFetchData = $objImap.FetchNext()
}

#Disconnect
$objImap.Disconnect()
write-host "Disconnected."
write-host "Ready."
exit
