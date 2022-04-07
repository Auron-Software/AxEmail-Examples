# ********************************************************************
#
# Auron Email Component
# OAuth2 authrization using the authorization code flow
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
$objOAuth2.Flow = $objConstants.OAUTH2_FLOW_AUTHCODE
$objOAuth2.ClientID = "" # Enter your client id (Create an application in the google cloud console)
$objOAuth2.ClientSecret = "" # Leave empty when using Microsoft device code flow
$objOAuth2.RedirectUrl = "http://localhost:7999/oauth2test/"   # Must be the URL used when creating your google application
$objOAuth2.Scope = "https://mail.google.com/"
$objOAuth2.AuthCodeUrl = "https://accounts.google.com/o/oauth2/v2/auth"
$objOAuth2.TokenExchangeUrl = "https://oauth2.googleapis.com/token"

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

# Wait for the user to login; specify a max time in milliseconds to wait for the user to finish
$objOAuth2.WaitForTokens(60000) 
$strResult = "WaitForTokens, result: " + $objOAuth2.LastError + " (" + $objOAuth2.GetErrorDescription($objOAuth2.LastError) + ")"
write-host $strResult 

# Display the bearer and refresh tokens. The bearer token needs to be passed to the SMTP, IMAP or POP object.
write-host
write-host "Bearer token: " $objOAuth2.BearerToken
write-host "Refresh token: " $objOAuth2.RefreshToken
write-host "Bearer timeout: " $objOAuth2.BearerExpInSeconds " seconds"
