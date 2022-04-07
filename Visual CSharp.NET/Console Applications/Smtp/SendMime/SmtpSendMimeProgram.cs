//-----------------------------------------------------------------------
// <copyright file="SmtpSendMimeProgram.cs" company="Auron">
//     Copyright (c) Auron Software - www.auronsoftware.com
// </copyright>
// <author>Dennis van de Giessen</author>
//-----------------------------------------------------------------------

namespace SmtpSendMimeProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using AxEmail;
    using System.IO;

    class SmtpSendMimeProgram
    {
        static void Main(string[] args)
        {
            string strMIMEFile, strHost = string.Empty, strYN = string.Empty, strAccount = string.Empty, strPassword = string.Empty;

            AxEmail.Message objMail = new AxEmail.Message();
            AxEmail.Smtp objSmtp = new AxEmail.Smtp();

            // Smtp: Clear (good practise)
            objSmtp.Clear();

            // A license key is required to unlock this component after the trial period has expired.
            // Assign the LicenseKey property every time a new instance of this component is created (see code below). 
            // Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry.
            // For details, see manual, chapter "Product Activation".
            /*
            objSmtp.LicenseKey = "XXXXX-XXXXX-XXXXX";
            */

            // Component info
            Console.WriteLine("Auron Email Component {0}\nBuild: {1}\nModule: {2}\nLicense Status: {3}\nLicense Key: {4}\n", objSmtp.Version, objSmtp.Build, objSmtp.Module, objSmtp.LicenseStatus, objSmtp.LicenseKey);

            // Set Logfile (optional, for debugging purposes)
            objSmtp.LogFile = Path.GetTempPath() + "Smtp.log";
            Console.WriteLine("Log file used: {0}\n", objSmtp.LogFile);

            // Mail: Clear (good practise)
            objMail.Clear();

            // Mime: Load
            strMIMEFile = ReadInput("Load MIME information from the following MIME file: ", false);
            objMail.LoadMIME(strMIMEFile);
            Console.WriteLine("LoadMIME, result: " + objMail.LastError + " (" + objMail.GetErrorDescription(objMail.LastError) + ")");
            if (objMail.LastError != 0L)
                return;       

            // Smtp: Host
             strHost = ReadInput("SMTP server", false);

            // Smtp: Secure
            do
            { strYN = ReadInput("Is " + strHost + " a secure SMTP server (y/n)?", false).ToUpper(); }
            while (!strYN.StartsWith("Y") && !strYN.StartsWith("N"));

            if (strYN.StartsWith("Y"))
            {
                objSmtp.SetSecure(465);
                Console.WriteLine("SetSecure, result: " + objSmtp.LastError + " (" + objSmtp.GetErrorDescription(objSmtp.LastError) + ")");
                if (objMail.LastError != 0)
                    return;
            }
            
            // Smtp: Account/Password (optional)
            strAccount = ReadInput("SMTP server account (optional)", true);
            if (strAccount.Length > 0)
                strPassword = ReadInput("SMTP server password", true);

            // Smtp: Connect
            objSmtp.Connect(strHost, strAccount, strPassword);   // Pass additional Account and Password parameters if server requires authentication
            Console.WriteLine("Connect, result: " + objSmtp.LastError + " (" + objSmtp.GetErrorDescription(objSmtp.LastError) + ")");
            if (objSmtp.LastError != 0)
                return;


            // Smtp: Send
            objSmtp.Send(objMail);
            Console.WriteLine("Send, result: " + objSmtp.LastError + " (" + objSmtp.GetErrorDescription(objSmtp.LastError) + ")");
            Console.WriteLine("Last response from SMTP Server: " + objSmtp.LastSmtpResponse);   
           
            // Smtp: Disconnect 
            objSmtp.Disconnect();
            Console.WriteLine("Disconnected.");

            Console.WriteLine("Ready.");
            System.Threading.Thread.Sleep(3000); // Sleep for 3 second before exit
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
