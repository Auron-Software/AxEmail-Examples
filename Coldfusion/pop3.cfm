<cfobject type="com" Action="Create" class="AxEmail.Pop3"      name="objPop3">
<cfobject type="com" Action="Create" class="AxEmail.Constants"  name="objEmailConstants">
<cfobject type="com" Action="Create" class="AxEmail.Message"  name="objEmail">

<cfscript>
  arrMails = ArrayNew(1);
  strResult = "n/a";
  
  <!--- A license key is required to unlock this component after the trial period has expired. --->
  <!--- Assign the LicenseKey property every time a new instance of this component is created (see code below). --->
  <!--- Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry. --->
  <!--- For details, see manual, chapter "Product Activation". ---> 
  <!--- objPop3.LicenseKey = "XXXXX-XXXXX-XXXXX"; --->

  objPop3.LogFile = "C:\Windows\Windows\Temp\AxEmail.Pop3.log";
  
  if (IsDefined("Form.btnListMessages"))
  {
    objPop3.Authentication = objEmailConstants.POP3_AUTH_AUTO;
    
    if (IsDefined("Form.cbxSecure"))
    {
      objPop3.SetSecure(995);
    }
    
    if (objPop3.LastError == 0)
    {
      objPop3.Connect(Form.txtHost, Form.txtAccount, Form.txtPassword);
      strResult = objPop3.LastError & ': ' & objPop3.GetErrorDescription(objPop3.LastError);
    }
    
    if (objPop3.LastError == 0)
    {
      numMessages = objPop3.CountMessages();
      strResult = objPop3.LastError & ': ' & objPop3.GetErrorDescription(objPop3.LastError);
    
      if (objPop3.LastError == 0)
      {
        for (i = 1; i LTE numMessages; i++)
        {
          objEmail = objPop3.GetEmailHeader(i);
          strResult = objPop3.LastError & ': ' & objPop3.GetErrorDescription(objPop3.LastError);
          
          if (objPop3.LastError == 0)
          {          
            ArrayAppend(arrMails, objEmail);
          }
        }
      }
    }
  }
</cfscript>

<!--- HTML-CSS layout includes, no code there! --->
<cfinclude template = "css/Header.html">
<cfinclude template = "css/Menu.html">
    <div class="container">
      <h1>Auron Email Component Coldfusion POP3 Sample</h1>
      <hr />
      <p>
        Simple Mail Transfer Protocol (SMTP) is an Internet standard for electronic mail (e-mail) 
        transmission across Internet Protocol (IP) networks.
        SMTP is specified for outgoing mail transport and uses TCP port 25 by default.
      </p>
      <form action="pop3.cfm" method="post">
      <cfoutput>
        <h2>Auron Email Component:</h2>
        <h3>Build: #objPop3.Build#; Module: #objPop3.Module#</h3>
        
        <!-- Host, Secure -->
        <label for="Host">Mailserver:</label>
        <p>
          <input type="text" id="Host" name="txtHost" value="pop3.mycompany.com" />
          
          <input type="checkbox" class="cbFix" id="Secure" name="cbxSecure" value="1" />
          <label for="Secure">Secure</label>
        </p>
        
        <!-- Account -->
        <label for="Account">Account:</label>
        <p>
          <input type="text" id="Account" name="txtAccount" value="user@mycompany.com" />
        </p>
        
        <!-- Password -->
        <label for="Password">Password:</label>
        <p>
          <input type="password" id="Password" name="txtPassword" value="" />
        </p>
        
        <!-- Empty row -->
        <div class="clearRow"></div>
        
        <!-- List Messages button -->
        <div class="clearLabel"></div>
        <p>
          <input type="submit" name="btnListMessages" value="List Messages" />
        </p>
        
        <!-- Messages Listbox -->
        <label for="Received">Messages received:</label>
        <p>
          <select id="Received" name="lvMessages" size="10">
          <cfloop array=#arrMails# index="Mail">
            <cfoutput><option>#Mail.Date#: #Mail.FromAddress#; Subject #Mail.Subject#</option></cfoutput>
          </cfloop>
          </select>
        </p>
        
        <!-- Result -->
        <label for="Result" class="Bold">Result:</label>
        <p>
          <input type="text" id="Result" name="txtResult" class="FullWidth Bold" class="FullWidth" value="#strResult#" />
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