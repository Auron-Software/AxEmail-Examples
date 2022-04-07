<?php
  $strResult = 'n/a';
  
  $objSmtp = new COM ("AxEmail.Smtp", NULL, CP_UTF8); 
      
  // A license key is required to unlock this component after the trial period has expired.
  // Assign the LicenseKey property every time a new instance of this component is created (see code below). 
  // Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry.
  // For details, see manual, chapter "Product Activation".
  //
  // $objSmtp->LicenseKey = "XXXXX-XXXXX-XXXXX";
 
  $objSmtp->LogFile = sys_get_temp_dir()."Smtp.log"; 
  // Windows default: 'C:\Windows\Temp\Smtp.log'
  
  if (isset($_POST['btnSendMessage']))
  {
    $objEmail  = new COM ("AxEmail.Message", NULL, CP_UTF8);
    $objEmailConstants = new COM ("AxEmail.Constants", NULL, CP_UTF8);    
 
    $objEmail->FromName = $_POST['txtFromName'];
    $objEmail->FromAddress = $_POST['txtFromAddress'];      
    
    
    if ($_POST['txtToAddress'] != "")
    {
      $objEmail->AddTo ($_POST['txtToAddress'],  $_POST['txtToAddress']);
    }    
    
    if ($_POST['txtCcAddress'] != "" && $objEmail->LastError == 0)
    {
    $objEmail->AddCc ($_POST['txtCcAddress'],  $_POST['txtCcAddress']);
    }
    
    if ($objEmail->LastError == 0 && $_POST['txtBccAddress'] != "")
    {
      $objEmail->AddBcc($_POST['txtBccAddress'], $_POST['txtBccAddress']);
    }
    
    if ($objEmail->LastError == 0)
    {
      $objEmail->Subject  = $_POST['txtSubject'];
      $objEmail->Priority = $_POST['ddlPriority'];
      
      $objEmail->BodyPlainText = $_POST['txtPlainBody'];
      $objEmail->BodyHtml    = $_POST['txtHtmlBody'];
      
      if (isset($_POST['cbxSecure']))
        $objSmtp->SetSecure(465); // 465 is the generic secure SMTP port
    }
    
    if ($objEmail->LastError == 0 && $objSmtp->LastError == 0)
    {    
      $objSmtp->Connect($_POST['txtHost'], $_POST['txtAccount'], $_POST['txtPassword']); 
    }
    
    if ($objEmail->LastError == 0 && $objSmtp->LastError == 0)
    { 
      $objSmtp->Send($objEmail);
    }
    
    if ($objEmail->LastError != 0)
    {
      $strResult = $objEmail->LastError . ": " . $objEmail->GetErrorDescription($objEmail->LastError);
    }
    else
    {
      $strResult = $objSmtp->LastError . ": " . $objSmtp->GetErrorDescription($objSmtp->LastError);
    }
    
    $objSmtp->Disconnect();
    
  }

// HTML-CSS layout includes, no code there!
include('css/Header.html'); 
include('css/Menu.html'); 
?>
    <div class="container">
      <h1>Auron Email Component PHP SMTP Sample</h1>
      <hr />
      <p>
        Simple Mail Transfer Protocol (SMTP) is an Internet standard for electronic mail (e-mail) 
        transmission across Internet Protocol (IP) networks.
        SMTP is specified for outgoing mail transport and uses TCP port 25 by default.
      </p>
      <form action="smtp.php" method="post">
        <h2>Component:</h2>
        <h3>Build: <?php echo $objSmtp->Build ?>; Module: <?php echo $objSmtp->Module ?></h3>
      
        <!-- Server, Secure -->
        <label for="Server">Mailserver:</label>
        <p>
          <input type="text" id="Server" name="txtHost" value="smtp.mycompany.com" />
          
          <input type="checkbox" class="cbFix" id="Secure" name="cbxSecure" checked />
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
          <input type="text" id="To" name="txtToAddress" value="[ToAddress]" />
          Note: Use ';' to split multiple email adresses
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
        
        <!-- Priority -->
        <label for="Priority">Priority:</label>
        <p>
          <select name="ddlPriority">
            <option value="1">Highest Priority</option>
            <option value="2">High Priority</option>
            <option value="3" selected="true">Normal Priority</option>
            <option value="4">Low Priority</option>
            <option value="5">Lowest Priority</option>
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
          <input type="text" id="Result" class="FullWidth Bold" name="txtResult" value="<?php echo $strResult; ?>" />
        </p>
      </form>
      <p>
        This demo uses the Auron Email Component, an <a href="https://www.auronsoftware.com" target="_blank">Auron Software</a> product.<br />
        <a href="index.php">Back to main page</a> 
      </p>
    </div><!-- /container -->
<?php 
//HTML-CSS layout include, no code there!
include('css/Footer.html'); ?>