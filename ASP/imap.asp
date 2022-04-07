<%
  ' A license key is required to unlock this component after the trial period has expired.
  ' Assign the LicenseKey property every time a new instance of this component is created (see code below). 
  ' Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry.
  ' For details, see manual, chapter "Product Activation".
  '
  ' objImap.LicenseKey = "XXXXX-XXXXX-XXXXX"    
%>

<%  
  strLastError = ""
        
  Set objImap       = CreateObject("AxEmail.Imap")
  Set objEmail      = CreateObject("AxEmail.Message")
  Set objConstants  = CreateObject("AxEmail.Constants")

  Set dctMessages   = CreateObject("Scripting.Dictionary")
  Set fso = CreateObject("Scripting.FileSystemObject")
  strLogfile = fso.GetSpecialFolder(2) & "\Imap.log"
  objImap.LogFile = strLogfile

  If(Request("btnSendMessage") <> "") Then
    objImap.Authentication = objConstants.IMAP_AUTH_AUTO
            
    If(Request("chkSecure") <> "") Then        
      objImap.SetSecure
    End If
    
    If (objImap.LastError = 0) Then
      objImap.Connect Request("txtHost"), Request("txtAccount"), Request("txtPassword")
      strLastError = objImap.LastError & ": " & objImap.GetErrorDescription(objImap.LastError)
    End If    

    If (objImap.LastError = 0) Then
    
      nCnt = 0
    
      Set objEmail = objImap.FetchFirstEmailHeader(objConstants.IMAP_SK_ALL)
      Do While objImap.LastError = 0
        dctMessages.Add objEmail.ImapUid, objEmail
                
        If nCnt = 100 Then Exit Do
        nCnt = nCnt + 1
        
        Set objEmail = objImap.FetchNextEmailHeader()
      Loop      
    End If
    strLastError = objImap.LastError & ": " & objImap.GetErrorDescription(objImap.LastError)
  End If  
%>

<%
' HTML-CSS layout includes below, no code there!
%>
<!-- #include file="css/Header.html" -->
<!-- #include file="css/Menu.html" -->
    <div class="container">
      <h1>Auron Email Component - ASP IMAP Sample</h1>
      <hr />
      <p>
        The Internet Message Access Protocol (IMAP) is a widely used protocol for accessing and maintaining a set of remote mailboxes. 
        <br /><br />
        <b>If SSL/TLS Encryption does not work please make sure the Application Pool user has a user certificate store available.</b>
      </p>
      <form action="imap.asp" method="post">
        <h2>Component:</h2>
        <h3>Module [<% = objImap.Module %>]; Build [<% = objImap.Build %>]</h3>

        <!-- Host -->
        <label for="Host">Mailserver:</label>
        <p>
          <input type="text" id="Host" name="txtHost" value="imap.gmail.com" />
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
          <input type="submit" name="btnSendMessage" value="List First 100 Messages" />
        </p>

        <!-- Messages Listbox -->
        <label for="Received">Messages received:</label>
        <p>
          <select id="Received" name="lvMessages" class="FullWidth" size="10">
          <%
            For each Mail in dctMessages.Items
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