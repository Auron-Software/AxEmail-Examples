<%
  ' A license key is required to unlock this component after the trial period has expired.
  ' Assign the LicenseKey property every time a new instance of this component is created (see code below). 
  ' Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry.
  ' For details, see manual, chapter "Product Activation".
  '
  ' objPop3.LicenseKey = "XXXXX-XXXXX-XXXXX"    
%>

<%
  Dim arrMessages()
  strLastError = ""

  Set objPop3            = CreateObject("AxEmail.Pop3")
  Set objEmail           = CreateObject("AxEmail.Message")
  Set objEmailConstants  = CreateObject("AxEmail.Constants")
  Set fso                = CreateObject("Scripting.FileSystemObject")
  
  strLogfile = fso.GetSpecialFolder(2) & "\Pop3.log"
  objPop3.LogFile = strLogfile
  
  If(Request("btnSendMessage") <> "") Then
    objPop3.Authentication = objEmailConstants.POP3_AUTH_AUTO
    
    If(Request("chkSecure") <> "") Then        
      objPop3.SetSecure
    End If
        
    If (objPop3.LastError = 0) Then
      objPop3.Connect Request("txtHost"), Request("txtAccount"), Request("txtPassword")
      strLastError = objPop3.LastError & ": " & objPop3.GetErrorDescription(objPop3.LastError)
    End If    
  
    If (objPop3.LastError = 0) Then
      numMessages = objPop3.CountMessages()
      strLastError = objPop3.LastError & ": " & objPop3.GetErrorDescription(objPop3.LastError)
  
      Dim ReceivedMail
      Redim arrMessages(numMessages - 1)
  
      If (objPop3.LastError = 0) Then
        For i=1 to numMessages
          Set ReceivedMail = objPop3.GetEmailheader(i)
          
          If (objPop3.LastError = 0) Then
            Set arrMessages(i - 1) = ReceivedMail
          End If
        Next
      End If
    End If
    strLastError = objPop3.LastError & ": " & objPop3.GetErrorDescription(objPop3.LastError)
  End If  
%>

<%
' HTML-CSS layout includes below, no code there!
%>
<!-- #include file="css/Header.html" -->
<!-- #include file="css/Menu.html" -->
    <div class="container">
      <h1>Auron Email Component - ASP POP3 Sample</h1>
      <hr />
      <p>
        In computing, the Post Office Protocol (POP) is an application-layer Internet standard protocol
        used by local e-mail clients to retrieve e-mail from a remote server over a TCP/IP connection and uses TCP port 110 by default.<br />
        <br />
        <b>If SSL/TLS Encryption does not work please make sure the Application Pool user has a user certificate store available.</b>
      </p>
      <form action="pop3.asp" method="post">
        <h2>Component:</h2>
        <h3>Module [<% = objPop3.Module %>]; Build [<% = objPop3.Build %>]</h3>

        <!-- Host, Secure -->
        <label for="Host">Mailserver:</label>
        <p>
          <input type="text" id="Host" name="txtHost" value="pop3.mycompany.com" />   
        </p>

        <!-- Secure -->
        <label for="Secure">Secure connect:</label>
        <p>
          <input type="checkbox" id="Secure" name="chkSecure" checked />
        </p>

        <div class="clearRow"></div>

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
          <input type="submit" name="btnSendMessage" value="List Messages" />
        </p>

        <!-- Messages Listbox -->
        <label for="Received">Messages received:</label>
        <p>
          <select id="Received" name="lvMessages" class="FullWidth" size="10">
          <%
          For each Mail in arrMessages
            Response.Write("<option>" & Mail.Date & ": " & Mail.FromAddress & "; Subject: " & Mail.Subject & "</Message>")
          Next
          %>
          </select>
        </p>

        <!-- Result -->
        <label for="Result" class="Bold">Result:</label>
        <p>
          <input type="text" id="Result" name="txtResult" class="FullWidth Bold" class="FullWidth" value="<% = strLastError %>" />
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