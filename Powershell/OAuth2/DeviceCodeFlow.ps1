# ********************************************************************
#
# Auron Email Component
# OAuth2 authrization using the device code flow
# (c) Copyright Auron Software - www.auronsoftware.com
#
# ********************************************************************

cls

$objOAuth2 = new-object -comobject AxEmail.OAuth2
$objConstants = new-object -comobject AxEmail.Constants

# A license key is required to unlock this component after the trial period has expired.
# Assign the LicenseKey property every time a new instance of this component is created (see code below). 
# Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry.
# For details, see manual, chapter "Product Activation".
# 
# $objOAuth2.LicenseKey = "XXXXX-XXXXX-XXXXX"  

$strInfo = "Auron Email Component " + $objOAuth2.Version + "`r`n"
$strInfo = $strInfo + "Build : " + $objOAuth2.Build + "`r`n"
$strInfo = $strInfo + "Module: " + $objOAuth2.Module + "`r`n"
$strInfo = $strInfo + "LicenseStatus: " + $objOAuth2.LicenseStatus + "`r`n"
If( $objOAuth2.LicenseKey -ne "" )
{
  $strInfo = $strInfo + "LicenseKey: " + $objOAuth2.LicenseKey + "`r`n"
}
write-host $strInfo
write-host ""

# Set Logfile
$objOAuth2.Logfile = $env:temp + "\OAuth2.txt"
write-host "Log file can be found here:"
write-host $objOAuth2.Logfile
write-host ""

# To use a different service please update the scope, device code url and token exchange url accordingly
$objOAuth2.Flow = $objConstants.OAUTH2_FLOW_DEVICECODE
$objOAuth2.ClientID = "8533e03f-4ea5-4448-bdb5-4c60ea323aae" # Enter your client id (Create an application in the Azure console)
$objOAuth2.ClientSecret = "" # Leave empty when using Microsoft device code flow
$objOAuth2.Scope = "offline_access https://outlook.office.com/IMAP.AccessAsUser.All https://outlook.office.com/SMTP.Send https://outlook.office.com/POP.AccessAsUser.All"
$objOAuth2.DeviceCodeUrl = "https://login.microsoftonline.com/common/oauth2/v2.0/devicecode"
$objOAuth2.TokenExchangeUrl = "https://login.microsoftonline.com/common/oauth2/v2.0/token"

# Test if the client ID is set
If ($objOAuth2.ClientID -eq "")
{
  write-host
  write-host "NOTE: Please open this source file to verify your client id and other OAuth2 parameters."
  Exit
}

$objOAuth2.Login()
$strResult = "Login, result: " + $objOAuth2.LastError + " (" + $objOAuth2.GetErrorDescription($objOAuth2.LastError) + ")"
write-host $strResult 

$strResult = "Please enter user code: [" + $objOAuth2.UserCode + "]"
write-host $strResult
write-host

# Wait for the user to enter the usercode.
$objOAuth2.WaitForTokens($objOAuth2.UserCodeExpInSeconds * 1000)
$strResult = "WaitForTokens, result: " + $objOAuth2.LastError + " (" + $objOAuth2.GetErrorDescription($objOAuth2.LastError) + ")"
write-host $strResult 

# Display the bearer and refresh tokens. The bearer token needs to be passed to the SMTP, IMAP or POP object.
write-host
write-host "Bearer token: " $objOAuth2.BearerToken
write-host "Refresh token: " $objOAuth2.RefreshToken
write-host "Bearer timeout: " $objOAuth2.BearerExpInSeconds " seconds"
