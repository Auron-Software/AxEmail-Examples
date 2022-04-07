//-----------------------------------------------------------------------
// <copyright file="Pop3Program.cs" company="Auron">
//     Copyright (c) Auron Software - www.auronsoftware.com
// </copyright>
// <author>Dennis van de Giessen</author>
//-----------------------------------------------------------------------

namespace Pop3Program
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using AxEmail;
    using System.IO;

    class Pop3Program
    {
        static void Main(string[] args)
        {
            Pop3 objPop3 = new Pop3();
            AxEmail.Message objMail = null;
            string strHost, strAccount, strPassword, strYN;
            System.Int32 i = 0, numMessages = 0;

            // A license key is required to unlock this component after the trial period has expired.
            // Assign the LicenseKey property every time a new instance of this component is created (see code below). 
            // Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry.
            // For details, see manual, chapter "Product Activation".
            /*
            objPop3.LicenseKey = "XXXXX-XXXXX-XXXXX";
            */

            // Component info
            Console.WriteLine("Auron Email Component {0}\nBuild: {1}\nModule: {2}\nLicense Status: {3}\nLicense Key: {4}\n", objPop3.Version, objPop3.Build, objPop3.Module, objPop3.LicenseStatus, objPop3.LicenseKey);

            // Set Logfile (optional, for debugging purposes)
            objPop3.LogFile = Path.GetTempPath() + "Pop3.log";
            Console.WriteLine("Log file used: {0}\n", objPop3.LogFile);

            strHost = ReadInput("Enter POP3 server (IP address or host name):", false);
            strAccount = ReadInput("Enter POP3 account:", false);
            strPassword = ReadInput("Enter POP3 password:", false);

            do
            { strYN = ReadInput("Is " + strHost + " a secure POP3 server (y/n)?", false).ToUpper(); }

            // Set Secure if secure communications is required
            while (!strYN.StartsWith("Y") && !strYN.StartsWith("N"));

            if (strYN.StartsWith("Y"))
            {
                objPop3.SetSecure(995);
                Console.WriteLine("SetSecure, result: " + objPop3.LastError + " (" + objPop3.GetErrorDescription(objPop3.LastError) + ")");
            }
                       
            // Use SetLicense with the license key to unlock this component. SetLicense will need to be called 
            // everytime a new instance of this component is created. Alternatively, use SaveLicense to store the
            // license key in the registry. You only need to call SaveLicense once.
            // SetLicense is the recommended method when distributing this component with your own software.
            //
            // objPop3.SetLicense( "XXXXX-XXXXX-XXXXX" )

            // Connects to the POP3 server
            objPop3.Connect(strHost, strAccount, strPassword);
            Console.WriteLine("Connect, result: " + objPop3.LastError + " (" + objPop3.GetErrorDescription(objPop3.LastError) + ")");

            if (objPop3.LastError == 0)
            {
                // Counts the messages
                numMessages = objPop3.CountMessages();
                Console.WriteLine("CountMessages, result: " + objPop3.LastError + " (" + objPop3.GetErrorDescription(objPop3.LastError) + ")"); 
                Console.WriteLine("# New message(s) on server: " + numMessages.ToString());

                // List all messages
                Console.WriteLine("Listing messages...");
                for (i = 1; i <= numMessages; i++)
                {
                    // Gets the Email header for the current message
                    objMail = (AxEmail.Message)objPop3.GetEmailHeader(i);
                    Console.WriteLine("GetEmailHeader, result: " + objPop3.LastError + " (" + objPop3.GetErrorDescription(objPop3.LastError) + ")");  
                    
                    if (objPop3.LastError == 0)
                    {
                        Console.WriteLine("MessageID        : " + objMail.ID);
                        Console.WriteLine("   From          : " + objMail.FromAddress);
                        Console.WriteLine("   From Name     : " + objMail.FromName);
                        Console.WriteLine("   To            : " + objMail.ToAddress);
                        Console.WriteLine("   Subject       : " + objMail.Subject);
                        Console.WriteLine("   Date          : " + objMail.Date);   
                        Console.WriteLine(string.Empty);
                    }
                }
            }

            objPop3.Disconnect();
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
