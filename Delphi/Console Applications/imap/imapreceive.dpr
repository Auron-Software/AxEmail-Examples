program imapreceive;

{$APPTYPE CONSOLE}
uses
  SysUtils, ActiveX, Windows,
  AxEmail_TLB in '..\..\typelib-imports\AxEmail_TLB.pas';

var
  objImap: Imap;
  objConstants: Constants;
  objImapMail: Message;
  strImap: WideString;
  strImapAccount: WideString;
  strImapPassword: WideString;
  strLogPath: String;
  arrTempPath: array[0..MAX_PATH] of Char;

begin
  CoInitialize(nil);

  // Create Imap Object
  objImap := CoImap.Create;
  objConstants := CoConstants.Create;

  // A license key is required to unlock this component after the trial period
  // has expired. Assign the LicenseKey property every time a new instance of
  // this component is created (see code below). Alternatively, the LicenseKey
  // property can be set automatically. This requires the license key to be
  // stored in the registry. For details, see manual, chapter
  // "Product Activation".
  {
  objImap.LicenseKey = 'XXXXX-XXXXX-XXXXX';
  }

  WriteLn('Auron Email Component ' + objImap.Version);
  WriteLn('Build: ' + objImap.Build);
  WriteLn('Module: ' + objImap.Module);
  WriteLn('License Status: ' + objImap.LicenseStatus);
  if (objImap.LicenseKey <> '') then
  begin  
    WriteLn('License Key: ' + objImap.LicenseKey);    
  end; 

  // Set a log file. This will log all communication with the server
  GetTempPath(MAX_PATH, arrTempPath);
  strLogPath := StrPas(arrTempPath);
  strLogPath := strLogPath + 'imap.log';
  objImap.LogFile := strLogPath;
  Writeln('Log file set to: ' + strLogPath);
  Writeln;

  // Read Imap Properties
  WriteLn('Enter IMAP Server, Leave emtpy for imap.gmail.com');
  ReadLn(strImap);
  if (strImap = '') then
  begin
    strImap := 'pop.gmail.com';
    WriteLn(strImap);      
  end;

  WriteLn;
  WriteLn('Enter IMAP Account');
  ReadLn(strImapAccount);

  if (strImapAccount <> '') then
  begin
    WriteLn;
    WriteLn('Enter IMAP Password');
    ReadLn(strImapPassword);
  end;

  // Set secure if necessary
  if (AnsiLowerCase(strImap) = 'pop.gmail.com') then
  begin
    objImap.SetSecure(993);
    WriteLn;
    WriteLn('SetSecure, result: ' + IntToStr(objImap.LastError) + ' (' +
      objImap.GetErrorDescription(objImap.LastError) + ')');
  end;

  if (objImap.LastError = 0) then
  begin
    // Connect to the IMAP Server
    objImap.Connect(strImap, strImapAccount, strImapPassword);
    WriteLn('Connect, result: ' + IntToStr(objImap.LastError) + ' (' +
      objImap.GetErrorDescription(objImap.LastError) + ')');
  end;

  if (objImap.LastError = 0) then
  begin
    // List all messages
    objImapMail := objImap.FetchFirstEmailHeader(objConstants.IMAP_SK_ALL);
    while objImap.LastError = 0 do
    begin
       WriteLn('MessageID      : ' + IntToStr(objImapMail.ImapUid));
       WriteLn('   From        : ' + objImapMail.FromAddress);
       WriteLn('   From Name   : ' + objImapMail.FromName);
       WriteLn('   To          : ' + objImapMail.ToAddress);
       WriteLn('   Subject     : ' + objImapMail.Subject);
       WriteLn('   Date        : ' + objImapMail.Date);
       objImapMail := objImap.FetchNextEmailHeader();
    end;
  end;

  // Disconnect
  objImap.Disconnect;
  WriteLn('Disconnected');
  WriteLn('Ready');
  WriteLn;
  Writeln('Press ENTER to close the program');
  readln;
end.


