program smtpsend;

{$APPTYPE CONSOLE}

uses
  SysUtils, ActiveX, Windows,
  AxEmail_TLB in '..\..\typelib-imports\AxEmail_TLB.pas';

var
  objSmtp : Smtp;
  objMail : Message;
  objConstants : Constants;
  strSmtpServer, strSmtpAccount, strSmtpPassword : WideString;
  strLogPath: String;
  arrTempPath: array[0..MAX_PATH] of Char;
  strToAddress, strFromAddress, strBccAddress, strCcAddress, strAttachment : WideString;
  strSubject, strBodyPlain, strBodyHtml : WideString;
begin
  CoInitialize(nil);

  // Create Smtp Object
  objSmtp := CoSmtp.Create;
  objConstants := CoConstants.Create;
  objMail := CoMessage.Create;
   
  // A license key is required to unlock this component after the trial period
  // has expired. Assign the LicenseKey property every time a new instance of
  // this component is created (see code below). Alternatively, the LicenseKey
  // property can be set automatically. This requires the license key to be
  // stored in the registry. For details, see manual, chapter
  // "Product Activation".
  {
  objSmtp.LicenseKey = 'XXXXX-XXXXX-XXXXX';
  }

  WriteLn('Auron Email Component ' + objSmtp.Version);
  WriteLn('Build: ' + objSmtp.Build);
  WriteLn('Module: ' + objSmtp.Module);
  WriteLn('License Status: ' + objSmtp.LicenseStatus);
  if (objSmtp.LicenseKey <> '') then
  begin  
    WriteLn('License Key: ' + objSmtp.LicenseKey);    
  end; 

  // Set a log file. This will log all communication with the Server device
  GetTempPath(MAX_PATH, arrTempPath);
  strLogPath := StrPas(arrTempPath);
  strLogPath := strLogPath + 'smtp.log';
  objSmtp.LogFile := strLogPath;
  Writeln('Log file set to: ' + strLogPath);
  Writeln;

  // Prompt user for SMTP info
  WriteLn('Mail server: (leave empty for smtp.gmail.com)');
  ReadLn(strSmtpServer);
  if (strSmtpServer = '') then
  begin
    strSmtpServer := 'smtp.gmail.com';
    WriteLn(strSmtpServer);
  end;

  WriteLn;
  WriteLn('Login (optional)');
  ReadLn(strSmtpAccount);

  if (strSmtpAccount <> '') then
  begin
    WriteLn;
    WriteLn('Password:');
    ReadLn(strSmtpPassword);
  end;

  // Set secure of mail server is a secure (TLS/SSL) mailserver
  if (AnsiLowerCase(strSmtpServer) = 'smtp.gmail.com') then
  begin
    objSmtp.SetSecure(465);
    WriteLn;
    WriteLn('SetSecure, result: ' + IntToStr(objSmtp.LastError) + ' (' + objSmtp.GetErrorDescription(objSmtp.LastError) + ')');
  end;

  if (objSmtp.LastError = 0) then
  begin
    // Connect to SMTP mailserver. If server credentials are required, pass Account name as additional parameters
    // If port other than default port 23 is required, set the HostPort property first.
    objSmtp.Connect(strSmtpServer,strSmtpAccount,strSmtpPassword);
    WriteLn('Connect, result: ' + IntToStr(objSmtp.LastError) + ' (' + objSmtp.GetErrorDescription(objSmtp.LastError) + ')');
  end;

  if (objSmtp.LastError = 0) then
  begin
    // Set mail properties
    WriteLn;
    WriteLn('FromAddress:');
    ReadLn(strFromAddress);
    objMail.FromAddress := strFromAddress;

    //Set ToAddress
    WriteLn;
    WriteLn('ToAddress:');
    ReadLn(strToAddress);
    if (strToAddress <> '') then
    begin
      objMail.AddTo(strToAddress, strToAddress);
      WriteLn('AddTo, result: ' + IntToStr(objMail.LastError) + ' (' + objMail.GetErrorDescription(objMail.LastError) + ')');
    end;
  end;

  if (objSmtp.LastError = 0) and (objMail.LastError = 0) then
  begin
    //Set CcAddress
    WriteLn;
    WriteLn('CcAddress (optional):');
    ReadLn(strCcAddress);
    if (strCcAddress <> '') then
    begin
      objMail.AddCc(strCcAddress, strCcAddress);
      WriteLn('AddCc, result: ' + IntToStr(objMail.LastError) + ' (' + objMail.GetErrorDescription(objMail.LastError) + ')');
    end;
  end;

  if (objSmtp.LastError = 0) and (objMail.LastError = 0) then
  begin
    //Set BccAddress
    WriteLn;
    WriteLn('BccAddress (optional):');
    ReadLn(strBccAddress);
    if (strBccAddress <> '') then
    begin
      objMail.AddBcc(strBccAddress, strBccAddress);
      WriteLn('AddBcc, result: ' + IntToStr(objMail.LastError) + ' (' + objMail.GetErrorDescription(objMail.LastError) + ')');
    end;
  end;

  if (objSmtp.LastError = 0) and (objMail.LastError = 0) then
  begin
    WriteLn;
    WriteLn('Attachment (optional):');
    ReadLn(strAttachment);
    if (strAttachment <> '') then
    begin
      objMail.AddAttachment(strAttachment);
      WriteLn('AddAttachment, result: ' + IntToStr(objSmtp.LastError) + ' (' + objSmtp.GetErrorDescription(objSmtp.LastError) + ')');
    end;
  end;

  if (objSmtp.LastError = 0) and (objMail.LastError = 0) then
  begin
    WriteLn;
    WriteLn('Subject: (leave empty for Auron Email Component Message)');
    ReadLn(strSubject);
    if (strSubject = '') then
    begin
      strSubject := 'Auron Email Component Message';
      WriteLn(strSubject);
    end;
    objMail.Subject := strSubject;

    WriteLn;
    WriteLn('Message (Plain Text): (leave empty for Hello World)');
    ReadLn(strBodyPlain);
    if (strBodyPlain = '') then
    begin
      strBodyPlain := 'Hello World';
      WriteLn(strBodyPlain);
    end;
    objMail.BodyPlainText := strBodyPlain;

    WriteLn;
    WriteLn('Message (Html): (leave empty for <b>Hello World</b>)');
    ReadLn(strBodyHtml);
      if (strBodyHtml = '') then
    begin
      strBodyHtml := '<b>Hello World</b>';
      WriteLn(strBodyHtml);
    end;
    objMail.BodyHtml := strBodyHtml;

    objMail.Priority := objConstants.EMAIL_MESSAGE_PRIORITY_MEDIUM;  // Normal (default) priority

    // Send mail now
    WriteLn('Sending Message...');
    objSmtp.Send(objMail);
    WriteLn;
    WriteLn('Send, result: ' + IntToStr(objSmtp.LastError) + ' (' + objSmtp.GetErrorDescription(objSmtp.LastError) + ')');
  end;

  if (objSmtp.LastError = 0) and (objMail.LastError = 0) then
    begin
       if (objSmtp.LastSmtpResponse <> '') then
    begin
      WriteLn('Last response from SMTP Server: ' + objSmtp.LastSmtpResponse);
    end;
  end;

  // Disconnect
  objSmtp.Disconnect();
  WriteLn('Disconnected');
  WriteLn('Ready');
  WriteLn;
  Writeln('Press ENTER to close the program');
  Readln;
  Exit;
end.
