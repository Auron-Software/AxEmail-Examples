using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Imap
{
  class ImapProgram
  {
    static void Main(string[] args)
    {
      AxEmail.Imap objImap = new AxEmail.Imap();
      AxEmail.Constants objConstants = new AxEmail.Constants();
      AxEmail.Message objMessage = null;
      string strHost, strAccount, strPassword, strYN;

      Console.WriteLine("Auron Email Component {0}\nBuild: {1}\nModule: {2}\nLicense Status: {3}\nLicense Key: {4}\n", objImap.Version, objImap.Build, objImap.Module, objImap.LicenseStatus, objImap.LicenseKey);

      // Set Logfile (optional, for debugging purposes)
      objImap.LogFile = Path.GetTempPath() + "objImap.log";
      Console.WriteLine("Log file used: {0}\n", objImap.LogFile);

      strHost = ReadInput("Enter IMAP server (IP address or host name):", false);
      strAccount = ReadInput("Enter IMAP account:", false);
      strPassword = ReadInput("Enter IMAP password:", false);

      do
      {
        strYN = ReadInput("Is " + strHost + " a secure POP3 server (y/n)?", false).ToUpper();
      } while (!strYN.StartsWith("Y") && !strYN.StartsWith("N"));

      if (strYN.StartsWith("Y"))
      {
        objImap.SetSecure();
        Console.WriteLine("SetSecure, result: " + objImap.LastError + " (" + objImap.GetErrorDescription(objImap.LastError) + ")");
      }

      // Use SetLicense with the license key to unlock this component. SetLicense will need to be called 
      // everytime a new instance of this component is created. Alternatively, use SaveLicense to store the
      // license key in the registry. You only need to call SaveLicense once.
      // SetLicense is the recommended method when distributing this component with your own software.
      //
      // objImap.SetLicense( "XXXXX-XXXXX-XXXXX" )

      // Connects to the IMAP server
      objImap.Connect(strHost, strAccount, strPassword);
      Console.WriteLine("Connect, result: " + objImap.LastError + " (" + objImap.GetErrorDescription(objImap.LastError) + ")");

      if (objImap.LastError == 0)
      {
        objMessage = objImap.FetchFirstEmailHeader(objConstants.IMAP_SK_ALL);
        Console.WriteLine("FetchFirstEmailHeader, result: " + objImap.LastError + " (" + objImap.GetErrorDescription(objImap.LastError) + ")");
        while (objImap.LastError == 0)
        {
          Console.WriteLine("MessageID        : " + objMessage.ID);
          Console.WriteLine("   From          : " + objMessage.FromAddress);
          Console.WriteLine("   From Name     : " + objMessage.FromName);
          Console.WriteLine("   To            : " + objMessage.ToAddress);
          Console.WriteLine("   Subject       : " + objMessage.Subject);
          Console.WriteLine("   Date          : " + objMessage.Date);
          Console.WriteLine(string.Empty);

          objMessage = objImap.FetchNextEmailHeader();
          Console.WriteLine("FetchNextEmailHeader, result: " + objImap.LastError + " (" + objImap.GetErrorDescription(objImap.LastError) + ")");
        }
      }

      objImap.Disconnect();
      Console.WriteLine("Disconnected.");
      Console.WriteLine("Ready.");
      Console.WriteLine("Press <ENTER> to continue.");
      Console.ReadLine();
    }

    static private string ReadInput(string strTitle, bool bAllowEmpty)
    {
      string strInput, strReturn = string.Empty;

      Console.WriteLine(strTitle);
      do
      {
        Console.Write("  > ");
        strInput = Console.ReadLine();
        if (strInput.Length > 0)
          strReturn = strInput;
      } while (strReturn == string.Empty && !bAllowEmpty);

      return strReturn;
    }
  }
}
