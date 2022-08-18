# ********************************************************************
#
# Auron Email Component
# OAuth2 Refresh bearer token
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
$objOAuth2.ClientID = "" # Enter your client id (Create an application in the Azure console)
$objOAuth2.ClientSecret = "" # Leave empty when using Microsoft device code flow
$objOAuth2.TokenExchangeUrl = "https://login.microsoftonline.com/common/oauth2/v2.0/token"

$objOAuth2.BearerToken = "" # Set to the bearer token you've received during authorization
$objOAuth2.RefreshToken = "" # Set to the refres token you've received during authorization

$objOAuth2.RefreshBearerToken()
$strResult = "WaitForTokens, result: " + $objOAuth2.LastError + " (" + $objOAuth2.GetErrorDescription($objOAuth2.LastError) + ")"
write-host $strResult 

# Display the bearer and refresh tokens. The bearer token needs to be passed to the SMTP, IMAP or POP object.
write-host
write-host "Bearer token: " $objOAuth2.BearerToken
write-host "Refresh token: " $objOAuth2.RefreshToken
write-host "Bearer timeout: " $objOAuth2.BearerExpInSeconds " seconds"
