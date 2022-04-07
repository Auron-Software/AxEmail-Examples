<%
' HTML-CSS layout includes below, no code there!
%>
<!-- #include file="css/Header.html" -->
<!-- #include file="css/Menu.html" -->

<%
  ' A license key is required to unlock this component after the trial period has expired.
  ' Assign the LicenseKey property every time a new instance of this component is created (see code below). 
  ' Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry.
  ' For details, see manual, chapter "Product Activation".
  '
  ' objSmtp.LicenseKey = "XXXXX-XXXXX-XXXXX"    
%>
 
<%
  strLastError = ""
  
  Set objSmtp       = CreateObject("AxEmail.Smtp")
  Set objEmail      = CreateObject("AxEmail.Message")
  Set objConstants  = CreateObject("AxEmail.Constants")
  
  Set fso = CreateObject("Scripting.FileSystemObject")
  strLogfile = fso.GetSpecialFolder(2) & "\Smtp.log"
  
  objSmtp.LogFile =  strLogfile 
  
  If(Request("btnSendMessage") <> "") Then         
    objEmail.FromName = Request("txtFromName")
    objEmail.FromAddress = Request("txtFromAddress")
           
    If (Request("txtToAddress") <> "") Then
      objEmail.AddTo  Request("txtToAddress"),  Request("txtToAddress")
    End If
    
    If (objEmail.LastError = 0 AND Request("txtCcAddress") <> "") Then     
      objEmail.AddCC  Request("txtCcAddress"),  Request("txtCcAddress")
    End If
    
    If (objEmail.LastError = 0 AND Request("txtBccAddress") <> "") Then    
      objEmail.AddBcc Request("txtBccAddress"), Request("txtBccAddress")
    End If
    
    If (objEmail.LastError = 0) Then
      objEmail.Subject  = Request("txtSubject")
      objEmail.Encoding = Request("ddlEncoding")
      
      Select Case Request("ddlPriority")
        case "Highest Priority"
          objEmail.Priority = objConstants.EMAIL_MESSAGE_PRIORITY_HIGHEST
        case "High Priority"
          objEmail.Priority = objConstants.EMAIL_MESSAGE_PRIORITY_HIGH
        case "Normal Priority"
          objEmail.Priority = objConstants.EMAIL_MESSAGE_PRIORITY_MEDIUM
        case "Low Priority"
          objEmail.Priority = objConstants.EMAIL_MESSAGE_PRIORITY_LOW
        case "Lowest Priority"
          objEmail.Priority = objConstants.EMAIL_MESSAGE_PRIORITY_LOWEST
      End Select
      
      objEmail.BodyPlainText = Request("txtPlainBody")
      objEmail.BodyHtml      = Request("txtHtmlBody")
    End If
    
    If(Request("chkSecure") <> "") Then        
      objSmtp.SetSecure
    End If
    
    If (objEmail.LastError = 0) Then
      objSmtp.Connect Request("txtHost"), Request("txtAccount"), Request("txtPassword")
    End If
    
    If (objEmail.LastError = 0 AND objSmtp.LastError = 0) Then
      objSmtp.Send(objEmail)
    End If
    
    If (objEmail.LastError <> 0) Then
      strLastError = objEmail.LastError & ": " & objEmail.GetErrorDescription(objEmail.LastError)
    Else
      strLastError = objSmtp.LastError & ": " & objSmtp.GetErrorDescription(objSmtp.LastError)     
    End If

    strLastSmtpResponse = objSmtp.LastSmtpResponse

    objSmtp.Disconnect()
  End If
%>


<div class="container">
  <h1>Auron Email Component ASP Sample - SMTP</h1>
  <hr />
  <p>
    Simple Mail Transfer Protocol (SMTP) is an Internet standard for electronic mail (e-mail) 
    transmission across Internet Protocol (IP) networks.
    SMTP is specified for outgoing mail transport and uses TCP port 25 by default.<br />
    <br />
    <b>If SSL/TLS Encryption does not work please make sure the Application Pool user has a user certificate store available.</b>
  </p>
  <form action="smtp.asp" method="post">
    <h2>Component:</h2>
    <h3>Module [<% = objSmtp.Module %>]; Build [<% = objSmtp.Build %>]</h3>

    <!-- Server -->   
    <label for="Server">Mailserver:</label>
    <p>
      <input type="text" id="Server" name="txtHost" value="smtp.mycompany.com" />
    </p>
    
    <!-- Secure -->
    <label for="Secure">Secure connect:</label>
    <p>
      <input type="checkbox" id="Secure" name="chkSecure" checked />
    </p>

    <div class="clearRow"></div>
    
    <!-- Account Text -->
    <div class="clearLabel"></div>
    <p style="margin-left: 576px; margin-Top:-5px;">
        since the default ASP user has no user certificate store.
    </p>

    <!-- Password -->
    <label for="Password">Password:</label>
    <p>
      <input type="password" id="Password" name="txtPassword" />
    </p>

    <!-- Empty row -->
    <div class="clearRow"></div> 
    
    <!-- Sender Name --> 
    <label for="Sender">From name:</label>
    <p>
      <input type="text" id="Sender" name="txtFromName" />
    </p>

    <!-- Sender Email --> 
    <label for="Sender">From e-mail:</label>
    <p>
      <input type="text" id="Sender" name="txtFromAddress" />
    </p>

    <!-- Empty row -->
    <div class="clearRow"></div>

    <!-- To -->
    <label for="To">To:</label>
    <p>
      <input type="text" id="To" name="txtToAddress" value="john@mycompany.com" />
    </p>

    <!-- Cc -->
    <label for="Cc">Cc:</label>
    <p>
      <input type="text" id="Cc" name="txtCcAddress" />
    </p>

    <!-- Bcc -->
    <label for="Bcc">Bcc:</label>
    <p>
      <input type="text" id="Bcc" name="txtBccAddress" />
    </p>

    <!-- Empty row -->
    <div class="clearRow"></div>

    <!-- Subject -->
    <label for="Subject">Subject:</label>
    <p>
      <input type="text" id="Subject" name="txtSubject" />
    </p>

    <!-- PlainBody -->
    <label for="PlainBody">Body:</label>
    <p>
      <textarea id="PlainBody" name="txtPlainBody" style="height: 60px;"></textarea>
    </p>

    <!-- HtmlBody -->
    <label for="HtmlBody">Body HTML (optional):</label>
    <p>
      <textarea id="HtmlBody" name="txtHtmlBody" style="height: 60px;"></textarea>
    </p>

    <!-- Empty row -->
    <div class="clearRow"></div>

    <!-- Char. Set -->
    <label for="CharSet">Char. Set:</label>
    <p>
      <select name="ddlEncoding">
        <option value="0">Standard</option>
        <option value="65001">UTF8</option>
      </select>
    </p>

    <!-- Priority -->
    <label for="Priority">Priority:</label>
    <p>
      <select name="ddlPriority">
        <option>Highest Priority</option>
        <option>High Priority</option>
        <option selected="true">Normal Priority</option>
        <option>Low Priority</option>
        <option>Lowest Priority</option>
      </select>
    </p>

    <!-- SendButton -->
    <div class="clearLabel"></div>
    <p>
      <input type="submit" name="btnSendMessage" value="Send Message" />
    </p>

    <!-- Empty row -->
    <div class="clearRow"></div>

    <!-- Result -->
    <label for="Result" class="Bold">Result:</label>
    <p>
      <input type="text" id="Result" class="FullWidth Bold" name="txtResult" value="<% = strLastError %>" />
    </p>

    <!-- Last SMTP Response-->
    <label for="LastSmtpResponse">Last SMTP Response:</label>
    <p>
      <input type="text" id="LastSmtpResponse" class="FullWidth" name="LastSmtpResponse" value="<% = strLastSmtpResponse %>" />
    </p>
    
    <!-- Logfile -->
    <label for="Logfile">Logfile:</label>
    <p>
      <input type="text" id="LogFile" name="txtLogFile" class="FullWidth" value="<% = strLogfile %>" />
    </p>
  </form>
  <p>
    This demo uses the Auron Email, an <a href="https://www.auronsoftware.com" target="_blank">Auron Software</a> product.<br />
    <a href="Default.asp">Back to main page</a>
  </p>
</div><!-- /container -->
<%
' HTML-CSS layout include below, no code there!
%>
<!-- #include file="css/Footer.html" -->