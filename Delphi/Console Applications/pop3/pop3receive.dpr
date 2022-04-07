program pop3receive;

{$APPTYPE CONSOLE}
uses
  SysUtils, ActiveX, Windows,
  AxEmail_TLB in '..\..\typelib-imports\AxEmail_TLB.pas';

var
  objPop3: Pop3;
  objPop3Mail: Message;
  strPop3: WideString;
  strPop3Account: WideString;
  strPop3Password: WideString;
  numMessages: Integer;
  i: Integer;
  strLogPath: String;
  arrTempPath: array[0..MAX_PATH] of Char;

begin
  CoInitialize(nil);

  // Create Pop3 Object
  objPop3 := CoPop3.Create;

  // A license key is required to unlock this component after the trial period
  // has expired. Assign the LicenseKey property every time a new instance of
  // this component is created (see code below). Alternatively, the LicenseKey
  // property can be set automatically. This requires the license key to be
  // stored in the registry. For details, see manual, chapter
  // "Product Activation".
  {
  objPop3.LicenseKey = 'XXXXX-XXXXX-XXXXX';
  }

  WriteLn('Auron Email Component ' + objPop3.Version);
  WriteLn('Build: ' + objPop3.Build);
  WriteLn('Module: ' + objPop3.Module);
  WriteLn('License Status: ' + objPop3.LicenseStatus);
  if (objPop3.LicenseKey <> '') then
  begin  
    WriteLn('License Key: ' + objPop3.LicenseKey);    
  end; 

  // Set a log file. This will log all communication with the server
  GetTempPath(MAX_PATH, arrTempPath);
  strLogPath := StrPas(arrTempPath);
  strLogPath := strLogPath + 'pop3.log';
  objPop3.LogFile := strLogPath;
  Writeln('Log file set to: ' + strLogPath);
  Writeln;

  // Read Pop3 Properties
  WriteLn('Enter POP3 Server, Leave emtpy for pop.gmail.com');
  ReadLn(strPop3);
  if (strPop3 = '') then
  begin  
    strPop3 := 'pop.gmail.com';
    WriteLn(strPop3);      
  end;

  WriteLn;
  WriteLn('Enter POP3 Account');
  ReadLn(strPop3Account);

  if (strPop3Account <> '') then
  begin    
    WriteLn;
    WriteLn('Enter POP3 Password');
    ReadLn(strPop3Password);
  end;

  // Set secure if necessary
  if (AnsiLowerCase(strPop3) = 'pop.gmail.com') then
  begin
    objPop3.SetSecure(995);
    WriteLn;
    WriteLn('SetSecure, result: ' + IntToStr(objPop3.LastError) + ' (' +
      objPop3.GetErrorDescription(objPop3.LastError) + ')');
  end;

  if (objPop3.LastError = 0) then
  begin
    // Connect to the POP3 Server
    objPop3.Connect(strPop3, strPop3Account, strPop3Password);
    WriteLn('Connect, result: ' + IntToStr(objPop3.LastError) + ' (' +
      objPop3.GetErrorDescription(objPop3.LastError) + ')');
  end;

  if (objPop3.LastError = 0) then
  begin
    // Count messages
    numMessages := objPop3.CountMessages;
    WriteLn('CountMessages, result: ' + IntToStr(objPop3.LastError) + ' (' +
      objPop3.GetErrorDescription(objPop3.LastError) + ')');
  end;

  if (objPop3.LastError = 0) then
  begin
    // List all messages
    if (numMessages > 0) then
    begin
      WriteLn('Listing messages...');
      for I := 1 to numMessages do
        objPop3Mail := objPop3.GetEmailHeader(I);
        WriteLn('GetEmailHeader, result: ' + IntToStr(objPop3.LastError) +
          ' (' + objPop3.GetErrorDescription(objPop3.LastError) + ')');
        if (objPop3.LastError = 0) then
        begin
          WriteLn('MessageID      : ' + IntToStr(objPop3Mail.Id));
          WriteLn('   From        : ' + objPop3Mail.FromAddress);
          WriteLn('   From Name   : ' + objPop3Mail.FromName);
          WriteLn('   To          : ' + objPop3Mail.ToAddress);
          WriteLn('   Subject     : ' + objPop3Mail.Subject);
          WriteLn('   Date        : ' + objPop3Mail.Date);
        end;
    end;
  end;

  // Disconnect
  objPop3.Disconnect;
  WriteLn('Disconnected');
  WriteLn('Ready');
  WriteLn;
  Writeln('Press ENTER to close the program');
  readln;
end.


