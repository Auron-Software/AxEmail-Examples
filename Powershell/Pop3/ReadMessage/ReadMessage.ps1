# ***************************************************************************
#
# Auron Email Component
# List mailbox messages on a POP3 server
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

if ($objPop3.LastError -eq 0)
{
  # Connect to the POP3 server
  $objPop3.Connect($strPop3, $strPop3Account, $strPop3Password)
  $strResult = "Connect, result: " + $objPop3.LastError + " (" + $objPop3.GetErrorDescription($objPop3.LastError) + ")"
  write-host $strResult 
}

if ($objPop3.LastError -eq 0)
{
  # Count messages
  $nMessages = $objPop3.CountMessages()
  $strResult = "CountMessages, result: " + $objPop3.LastError + " (" + $objPop3.GetErrorDescription($objPop3.LastError) + ")"
  write-host $strResult 
}

if ($objPop3.LastError -eq 0)
{
  write-host "New message(s) on server:" $nMessages
  # Let user select a message
  $nMessageID = 1
  if ($nMessages -gt 0)
  {
    While ($nMessageID -ne 0)
    {  
      $nMessageID = ReadInput ("Select Message ID [1 - " +  $nMessages + "] (type 0 to cancel)") "1" $False
      
      if ($nMessageID -eq 0)
      {
        break
      }
      # Get message details of this particular message
      $objPop3Mail = $objPop3.GetEmailMessage($nMessageID)
      $strResult = "GetEmailMessage, result: " + $objPop3.LastError + " (" + $objPop3.GetErrorDescription($objPop3.LastError) + ")"
      write-host $strResult 
      
      if ($objPop3.LastError -eq 0)
      {
        write-host "MessageID         : " $objPop3Mail.ID
        write-host "  From            : " $objPop3Mail.FromAddress
        write-host "  To              : " $objPop3Mail.ToAddress
        write-host "  Cc              : " $objPop3Mail.CcAddress
        write-host "  Reply Address   : " $objPop3Mail.ReplyAddress	
        write-host "  Subject         : " $objPop3Mail.Subject
        write-host "  Priority        : " $objPop3Mail.Priority
        write-host "  Date            : " $objPop3Mail.Date
        write-host "  UIDL            : " $objPop3Mail.GetHeaderValue("X-UIDL")
        write-host "  Header          : " $objPop3Mail.Header
        write-host "  Body(Plain Text): " $objPop3Mail.BodyPlainText
        write-host "  Body(Html)      : " $objPop3Mail.BodyHtml     
        
        $nAttachments = $objPop3Mail.CountAttachments()
        $strResult = "CountAttachments, result: " + $objPop3.LastError + " (" + $objPop3.GetErrorDescription($objPop3.LastError) + ")"
        
        write-host "  #Attachments    : " $nAttachments 
        write-host $strResult         

        For ($i = 1; $i -le $nAttachments; $i++)
        {
          #write-host "Attachment" $i":" $objPop3Mail.GetAttachmentName($i) "size:" $objPop3Mail.GetAttachmentSize($i)
          Write-host "Attachment:" $i
          write-host "  Name:" $objPop3Mail.GetAttachmentName($i)
          $strResult = "GetAttachmentName, result: " + $objPop3.LastError + " (" + $objPop3.GetErrorDescription($objPop3.LastError) + ")"
          write-host $strResult 
          write-host "  Size:" $objPop3Mail.GetAttachmentSize($i)
          $strResult = "GetAttachmentSize, result: " + $objPop3.LastError + " (" + $objPop3.GetErrorDescription($objPop3.LastError) + ")"
          write-host $strResult 
          
          # To save the attachment, call SaveAttachment
          # $objPop3Mail.SaveAttachment($i, "c:\temp\file.ext")
        }    
      }
    }
  }
}

$objPop3.Disconnect()
write-host "Disconnected."
write-host "Ready."
exit