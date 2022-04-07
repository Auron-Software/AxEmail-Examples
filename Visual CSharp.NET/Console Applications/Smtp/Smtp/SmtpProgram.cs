//-----------------------------------------------------------------------
// <copyright file="SmtpProgram.cs" company="Auron">
//     Copyright (c) Auron Software - www.auronsoftware.com
// </copyright>
// <author>Dennis van de Giessen</author>
//-----------------------------------------------------------------------

namespace SmtpProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using AxEmail;
    using System.IO;

    class SmtpProgram
    {
        static void Main(string[] args)
        {
            AxEmail.Message objMail = new AxEmail.Message();
            AxEmail.Smtp objSmtp = new AxEmail.Smtp();
            AxEmail.Constants objConstants = new AxEmail.Constants();
            string strHost = string.Empty, strAccount = string.Empty, strPassword = string.Empty, strFromAddress = string.Empty, strTo = string.Empty, strCc = string.Empty, strBcc = string.Empty, strAttachment = string.Empty, strYN = string.Empty;

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

            // Mail: Encoding
            objMail.Encoding = objConstants.EMAIL_MESSAGE_ENCODING_DEFAULT;

            // Mail: Priority
            objMail.Priority = objConstants.EMAIL_MESSAGE_PRIORITY_MEDIUM;

            // Mail: From
            strFromAddress = ReadInput("E-mail From:", true);
            objMail.FromAddress = strFromAddress;
            objMail.FromName = strFromAddress; // You can assign any displayable name

            // Mail: Subject
            objMail.Subject = ReadInput("Subject:", false);

            // Mail: Body
            objMail.BodyPlainText = ReadInput("Message:", false);

            // Mail: To recipients
            strTo = ReadInput("E-mail to:", false);
            objMail.AddTo(strTo, strTo);
            Console.WriteLine("AddTo, result: " + objMail.LastError + " (" + objMail.GetErrorDescription(objMail.LastError) + ")");
            if( objMail.LastError != 0 )
                return;

            // Mail: Cc recipients
            strCc = ReadInput("E-mail CC (optional):", true);
            if( strCc != string.Empty )
            {
                objMail.AddCc(strCc, strCc);
                Console.WriteLine("AddCc, result: " + objMail.LastError + " (" + objMail.GetErrorDescription(objMail.LastError) + ")");
                if (objMail.LastError != 0)
                    return;
            }

            // Mail: Attachment
            strAttachment = ReadInput("Attachment File (optional):", true);
            if (strAttachment != string.Empty)
            {
                objMail.AddAttachment(strAttachment);
                Console.WriteLine("AddAttachment, result: " + objMail.LastError + " (" + objMail.GetErrorDescription(objMail.LastError) + ")");
                if( objMail.LastError != 0 )
                    return;
            }

            // Smtp: Clear (good practise)
            objSmtp.Clear();

            // Smtp: Host
            strHost = ReadInput("SMTP server", false);

            // Smtp: Secure if secure communications is required
            do
            { strYN = ReadInput("Is " + strHost + " a secure SMTP server (y/n)?", false).ToUpper(); }
            while (!strYN.StartsWith("Y") && !strYN.StartsWith("N"));
            if (strYN.StartsWith("Y"))
            {
                objSmtp.SetSecure(465);
                Console.WriteLine("SetSecure, result: " + objSmtp.LastError + " (" + objSmtp.GetErrorDescription(objSmtp.LastError) + ")");
                if( objSmtp.LastError != 0 )
                    return;           
            }

            // Smtp Account/password(optional)
            strAccount = ReadInput("SMTP server account (optional)", true);
            if (strAccount.Length > 0)
                strPassword = ReadInput("SMTP server password", true);

            // Smtp: Connect
            objSmtp.Connect(strHost, strAccount, strPassword);   // Pass additional Account and Password parameters if server requires authentication
            Console.WriteLine("Connect, result: " + objSmtp.LastError + " (" + objSmtp.GetErrorDescription(objSmtp.LastError) + ")");
            if( objSmtp.LastError != 0 )
                return;            

            // Smtp: Send
            objSmtp.Send(objMail);
            Console.WriteLine("Send, result: " + objSmtp.LastError + " (" + objSmtp.GetErrorDescription(objSmtp.LastError) + ")");
            Console.WriteLine("Last response from SMTP Server: " + objSmtp.LastSmtpResponse);   

            // Disconnects the SMTP server
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
