using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAuth2
{
  class OAuth2Program
  {
    // You'll need this function to refresh a bearer token when it's expired
    // Call it right after expiration and before checking your email. This way 
    // the user doesn't have to login again.
    static void RefreshBearerToken(ref string sBearer, ref string sRefresh, out int nNewTimeoutSec)
    {
      nNewTimeoutSec = 0;
      AxEmail.OAuth2 objOAuth2 = new AxEmail.OAuth2();

      objOAuth2.ClientID = "";     // TODO: Input your client ID from the google cloud portal
      objOAuth2.ClientSecret = ""; // TODO: Input your client secret from the google cloud portal
      objOAuth2.TokenExchangeUrl = "https://oauth2.googleapis.com/token";

      objOAuth2.BearerToken = sBearer;
      objOAuth2.RefreshToken = sRefresh;

      objOAuth2.RefreshBearerToken();
      Console.WriteLine("RefreshBearerToken, result: {0} ({1})",
        objOAuth2.LastError, objOAuth2.GetErrorDescription(objOAuth2.LastError));
      if (objOAuth2.LastError != 0) return;

      sBearer = objOAuth2.BearerToken;
      sRefresh = objOAuth2.RefreshToken;
      nNewTimeoutSec = objOAuth2.BearerExpInSeconds;

      Console.WriteLine();
      Console.WriteLine("Bearer token: {0}", objOAuth2.BearerToken);
      Console.WriteLine("Refresh token: {0}", objOAuth2.RefreshToken);
      Console.WriteLine("Bearer token timeout: {0} seconds", objOAuth2.BearerExpInSeconds);
    }

    static void Main(string[] args)
    {
      AxEmail.OAuth2 objOAuth2 = new AxEmail.OAuth2();
      AxEmail.Constants objConstants = new AxEmail.Constants();

      // A license key is required to unlock this component after the trial period has expired.
      // Assign the LicenseKey property every time a new instance of this component is created (see code below). 
      // Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry.
      // For details, see manual, chapter "Product Activation".
      /*
      objOAuth2.LicenseKey = "XXXXX-XXXXX-XXXXX";
      */

      // Component info
      Console.WriteLine("Auron Email Component {0}\nBuild: {1}\nModule: {2}\nLicense Status: {3}\nLicense Key: {4}\n",
        objOAuth2.Version, objOAuth2.Build, objOAuth2.Module, objOAuth2.LicenseStatus, objOAuth2.LicenseKey);

      // Set Logfile (optional, for debugging purposes)
      objOAuth2.LogFile = Path.GetTempPath() + "OAuth2.log";
      Console.WriteLine("Log file used: {0}\n", objOAuth2.LogFile);

      // Setup oauth parameters
      objOAuth2.Flow = objConstants.OAUTH2_FLOW_AUTHCODE;
      objOAuth2.ClientID = "";     // TODO: Input your client ID from the google cloud portal
      objOAuth2.ClientSecret = ""; // TODO: Input your client secret from the google cloud portal
      objOAuth2.RedirectUrl = "http://localhost:7999/oauth2test/";
      objOAuth2.Scope = "https://mail.google.com/";
      objOAuth2.AuthCodeUrl = "https://accounts.google.com/o/oauth2/v2/auth";
      objOAuth2.TokenExchangeUrl = "https://oauth2.googleapis.com/token";

      if (objOAuth2.ClientID == "")
      {
        Console.WriteLine();
        Console.WriteLine("NOTE: Please open this source file to verify your client id and other OAuth2 paramters");
        return;
      }

      // Show the login browser window or user code browser window if device code flow is selected
      objOAuth2.Login();
      Console.WriteLine("Login, result: {0} ({1})", 
        objOAuth2.LastError, objOAuth2.GetErrorDescription(objOAuth2.LastError));
      if (objOAuth2.LastError != 0) return;

      // Wait for the token exchange to happen
      objOAuth2.WaitForTokens(90000);
      Console.WriteLine("WaitForTokens, result: {0} ({1})",
        objOAuth2.LastError, objOAuth2.GetErrorDescription(objOAuth2.LastError));
      if (objOAuth2.LastError != 0) return;

      // use the bearer token to login on SMTP, POP3 or IMAP. 
      // use the refresh token to silently refresh you bearer token after it expires
      Console.WriteLine();
      Console.WriteLine("Bearer token: {0}", objOAuth2.BearerToken);
      Console.WriteLine("Refresh token: {0}", objOAuth2.RefreshToken);
      Console.WriteLine("Bearer token timeout: {0} seconds", objOAuth2.BearerExpInSeconds);
    }
  }
}
