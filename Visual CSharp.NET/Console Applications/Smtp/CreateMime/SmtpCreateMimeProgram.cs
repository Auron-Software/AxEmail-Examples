//-----------------------------------------------------------------------
// <copyright file="SmtpCreateMimeProgram.cs" company="Auron">
//     Copyright (c) Auron Software - www.auronsoftware.com
// </copyright>
// <author>Dennis van de Giessen</author>
//-----------------------------------------------------------------------

namespace SmtpCreateMimeProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using AxEmail;

    class SmtpCreateMimeProgram
    {
        static void Main(string[] args)
        {
            AxEmail.Message objMail = new AxEmail.Message();
            AxEmail.Constants objConstants = new AxEmail.Constants();
            string strFromAddress, strTo, strCc, strBcc, strAttachment, strMIMEFile;
            strMIMEFile = string.Empty;

            objMail.Clear();

            strFromAddress = ReadInput("FROM address (the sender's e-mail address)", true);
            objMail.FromAddress = strFromAddress;
            objMail.FromName = strFromAddress;	// You can assign any displayable name

            strTo = ReadInput("ToAddress", false);
            objMail.AddTo(strTo, strTo);
            Console.WriteLine("AddTo, result: " + objMail.LastError + " (" + objMail.GetErrorDescription(objMail.LastError) + ")");

            if (objMail.LastError == 0)
            {
                strCc = ReadInput("CcAddress (optional)", true);
                if (strCc != string.Empty)
                {
                    objMail.AddCc(strCc, strCc);
                    Console.WriteLine("AddCc, result: " + objMail.LastError + " (" + objMail.GetErrorDescription(objMail.LastError) + ")");
                }
            }

            if (objMail.LastError == 0)
            {
                strBcc = ReadInput("BccAddress (optional)", true);
                if (strBcc != string.Empty)
                {
                    objMail.AddBcc(strBcc, strBcc);
                    Console.WriteLine("AddBcc, result: " + objMail.LastError + " (" + objMail.GetErrorDescription(objMail.LastError) + ")");
                }
            }

            if (objMail.LastError == 0)
            {
                objMail.Encoding = objConstants.EMAIL_MESSAGE_ENCODING_DEFAULT;
                objMail.Priority = objConstants.EMAIL_MESSAGE_PRIORITY_MEDIUM;

                objMail.Subject = ReadInput("Subject", false);
                objMail.BodyPlainText = ReadInput("Message", false);

                strAttachment = ReadInput("Attachment File (optional)", true);
                if (strAttachment != string.Empty)
                {
                    objMail.AddAttachment(strAttachment);
                    Console.WriteLine("AddAttachment, result: " + objMail.LastError + " (" + objMail.GetErrorDescription(objMail.LastError) + ")");
                }
            }

            if (objMail.LastError == 0)
            {
                strMIMEFile = ReadInput("Save information to the following MIME file: ", false);

                objMail.Encode();
                Console.WriteLine("Encode, result: " + objMail.LastError + " (" + objMail.GetErrorDescription(objMail.LastError) + ")");
            }

            if (objMail.LastError == 0)
            {
                objMail.SaveMIME(strMIMEFile);
                Console.WriteLine("SaveMIME, result: " + objMail.LastError + " (" + objMail.GetErrorDescription(objMail.LastError) + ")");
            }

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
