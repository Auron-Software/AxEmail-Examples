<cfobject type="com" Action="Create" class="AxEmail.Smtp"      name="objSmtp">
<cfobject type="com" Action="Create" class="AxEmail.Message"  name="objEmail">
<cfobject type="com" Action="Create" class="AxEmail.Constants"  name="objConstants">

<cfscript>
  strResult = "n/a";
  objSmtp.LogFile = "C:\Windows\Windows\Temp\AxEmail.Smtp.log";

  <!--- A license key is required to unlock this component after the trial period has expired. --->
  <!--- Assign the LicenseKey property every time a new instance of this component is created (see code below). --->
  <!--- Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry. --->
  <!--- For details, see manual, chapter "Product Activation". ---> 
  <!--- objSmtp.LicenseKey = "XXXXX-XXXXX-XXXXX"; --->

  
  if (IsDefined("Form.btnSendMessage"))
  {
    if (IsDefined("Form.cbxSecure"))
    {
      objSmtp.SetSecure(465); // 465 is the generic secure SMTP port
    }
    
    if (objSmtp.LastError == 0)
    {
      objSmtp.Connect(Form.txtHost, Form.txtAccount, Form.txtPassword);
      strResult = objSmtp.LastError & ': ' & objSmtp.GetErrorDescription(objSmtp.LastError);
    }
    
    if (objSmtp.LastError == 0)
    {
      objEmail.Clear();
    
      objEmail.FromName = Form.txtFromName;
      objEmail.FromAddress = Form.txtFromAddress;
      
      if (Form.txtToAddress != "" && objSmtp.LastError == 0)
      {
        objEmail.AddTo (Form.txtToAddress,  Form.txtToAddress);
      }
      
      if (Form.txtCcAddress != "" && objEmail.LastError == 0 && objSmtp.LastError == 0)
      {
        objEmail.AddCc (Form.txtCcAddress,  Form.txtCcAddress);
      }
      
      if (Form.txtBccAddress != "" && objEmail.LastError == 0 && objSmtp.LastError == 0)
      {
        objEmail.AddBcc(Form.txtBccAddress, Form.txtBccAddress);
      }
      
      if (objEmail.LastError == 0 && objSmtp.LastError == 0)
      {
        objEmail.Subject  = Form.txtSubject;
        objEmail.Encoding = Form.ddlEncoding;
        
        switch (Form.ddlPriority)
        {
          case "Highest Priority":
          {
            objEmail.Priority = objConstants.EMAIL_MESSAGE_PRIORITY_HIGHEST;
            break;
          }
          case "High Priority":
          {
            objEmail.Priority = objConstants.EMAIL_MESSAGE_PRIORITY_HIGH;
            break;
          }
          case "Normal Priority":
          {
            objEmail.Priority = objConstants.EMAIL_MESSAGE_PRIORITY_MEDIUM;
            break;
          }
          case "Low Priority":
          {
            objEmail.Priority = objConstants.EMAIL_MESSAGE_PRIORITY_LOW;
            break;
          }
          case "Lowest Priority":
          {
            objEmail.Priority = objConstants.EMAIL_MESSAGE_PRIORITY_LOWEST;
            break;
          }
        }
        
        objEmail.BodyPlainText = Form.txtPlainBody;
        objEmail.BodyHtml      = Form.txtHtmlBody ;
        
        obj = objEmail;
        objSmtp.Send(obj);
      }
      
      if (objEmail.LastError != 0)
      {
        strResult = objEmail.LastError & ': ' & objEmail.GetErrorDescription(objEmail.LastError);  
      }
      else
      {
        strResult = objSmtp.LastError & ': ' & objSmtp.GetErrorDescription(objSmtp.LastError);
      }   
      
      objSmtp.Disconnect();
    }
  }
</cfscript>

<!--- HTML-CSS layout includes, no code there! --->
<cfinclude template = "css/Header.html">
<cfinclude template = "css/Menu.html">
    <div class="container">
      <h1>Auron Email Component Coldfusion SMTP Sample</h1>
      <hr />
      <p>
        Simple Mail Transfer Protocol (SMTP) is an Internet standard for electronic mail (e-mail) 
        transmission across Internet Protocol (IP) networks.
        SMTP is specified for outgoing mail transport and uses TCP port 25 by default.
      </p>
      <form action="smtp.cfm" method="post">
      <cfoutput>
        <h2>Auron Email Component:</h2>
        <h3>Build: #objSmtp.Build#; Module: #objSmtp.Module#</h3>
        
        <!-- Server, Secure -->   
        <label for="Server">Mailserver:</label>
        <p>
          <input type="text" id="Server" name="txtHost" value="smtp.mycompany.com" />
          
          <input type="checkbox" class="cbFix" id="Secure" name="cbxSecure" value="1" />
          <label for="Secure">Secure</label>
        </p>
        
        <!-- Account -->
        <label for="Account">Account*:</label>
        <p>
          <input type="text" id="Account" name="txtAccount" />
          *Only use when server requires authentication
        </p>
        
        <!-- Password -->
        <label for="Password">Password*:</label>
        <p>
          <input type="password" id="Password" name="txtPassword" />
        </p>
        
        <!-- Empty row -->
        <div class="clearRow"></div> 
        
        <!-- Sender Name --> 
        <label for="Sender">Sender name:</label>
        <p>
          <input type="text" id="Sender" name="txtFromName" />
        </p>
        
        <!-- Sender Email --> 
        <label for="Sender">Sender e-mail:</label>
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
        <label for="Result"class="Bold">Result:</label>
        <p>
          <input type="text" id="Result" class="FullWidth Bold" name="txtResult" value="#strResult#" />
        </p>
      </cfoutput>
      </form>
      <p>
        This demo uses the Auron Email Component, an <a href="https://www.auronsoftware.com" target="_blank">Auron Software</a> product.<br />
        <a href="index.cfm">Back to main page</a>
      </p>
    </div><!-- /container -->
<!--- HTML-CSS layout includes, no code there! --->
<cfinclude template = "css/Footer.html">