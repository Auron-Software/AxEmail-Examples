# ***************************************************************************
#
# Auron Email Component
# Delete messages from mailbox on a POP3 server
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

$objPop3 = new-object -comobject AxEmail.Pop3

# A license key is required to unlock this component after the trial period has expired.
# Assign the LicenseKey property every time a new instance of this component is created (see code below). 
# Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry.
# For details, see manual, chapter "Product Activation".
# 
# $objPop3.LicenseKey = "XXXXX-XXXXX-XXXXX"  

# Display Serial Port Component Version
write-host "Auron Email Component " $objPop3.Version "`nBuild: " $objPop3.Build "`nModule: "  $objPop3.Module "`nLicense Status: " $objPop3.LicenseStatus "`nLicense Key: " $objPop3.LicenseKey "`n`n";

# Logfile
$objPop3.Logfile = $env:temp + "\Pop3.log"
write-host "Log file used: " $objPop3.Logfile "`n"

# Read POP3 properties
$strPop3   = ReadInput "Enter POP3 Server" "pop.gmail.com" $False 
$strPop3Account  = ReadInput "Enter POP3 Account" "" $False 
$strPop3Password = ReadInput "Enter POP3 Password" "" $False

# Set secure of if necessary
If ($strPop3.ToLower() -eq "pop.gmail.com")
{
  $objPop3.SetSecure(995)
  $strResult = "SetSecure, result: " + $objPop3.LastError + " (" + $objPop3.GetErrorDescription($objPop3.LastError) + ")"
  write-host $strResult 
}

# Connect to the POP3 server
If ($objPop3.LastError -eq 0)
{
  $objPop3.Connect($strPop3, $strPop3Account, $strPop3Password)
  $strResult = "Connect, result: " + $objPop3.LastError + " (" + $objPop3.GetErrorDescription($objPop3.LastError) + ")"
  write-host $strResult 
}

# Count messages

If ($objPop3.LastError -eq 0)
{
  $nMessages = $objPop3.CountMessages()
  $strResult = "CountMessages, result: " + $objPop3.LastError + " (" + $objPop3.GetErrorDescription($objPop3.LastError) + ")"
  write-host $strResult 
}

If ($objPop3.LastError -eq 0)
{
write-host "#New message(s) on server:" $nMessages

  # Iterate over all messages
  If ($nMessages -gt 0)
  {
    write-host "Listing messages..."
    For ($i = 1; $i -le $nMessages; $i++)
    {
      $objPop3Mail = $objPop3.GetEmailHeader($i)
      $strResult = "GetEmailHeader( " + $i + " ), result: " + $objPop3.LastError + " (" + $objPop3.GetErrorDescription($objPop3.LastError) + ")"
      write-host $strResult 
      
      if ($objPop3.LastError -eq 0)
      {
        write-host "Message #"$objPop3Mail.ID
        write-host " From:" $objPop3Mail.FromAddress
        
        If ($objPop3Mail.Subject.Length -gt 50)
        {
          write-host " Subject:" $objPop3Mail.Subject.SubString(0,50)
        }
        else
        {      
          write-host " Subject:" $objPop3Mail.Subject              
        }
      }
    }
    
    $nMessageID = -1
    While ($nMessageID -ne 0)
    {
      $nMessageID = ReadInput "Which message do you want to delete ? (type 0 to cancel)" "1" $False
      If ($nMessageID -gt 0)
      {
        write-host " "
        $objPop3.DeleteMessage($nMessageID)
        $strResult = "DeleteMessage, result: " + $objPop3.LastError + " (" + $objPop3.GetErrorDescription($objPop3.LastError) + ")"
        write-host $strResult 
      }      
    } 
  }
}

$objPop3.Disconnect()
write-host "Disconnected."
write-host "Ready."
exit
