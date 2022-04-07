<?php
  $arrMails = array();
  $strResult = 'n/a';
  
  $objPop3 = new COM ("AxEmail.Pop3", NULL, CP_UTF8);
      
  // A license key is required to unlock this component after the trial period has expired.
  // Assign the LicenseKey property every time a new instance of this component is created (see code below). 
  // Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry.
  // For details, see manual, chapter "Product Activation".
  //
  // $objPop3->LicenseKey = "XXXXX-XXXXX-XXXXX"; 

  $objPop3->LogFile = sys_get_temp_dir()."Pop3.log"; 
  // Windows default: 'C:\Windows\Temp\Pop3.log'
  
  if (isset($_POST['btnListMessages']))
  {
    $objEmailConstants = new COM("AxEmail.Constants", NULL, CP_UTF8);
    $objEmail = new COM("AxEmail.Message", NULL, CP_UTF8);
    
    $objPop3->Authentication = $objEmailConstants->POP3_AUTH_AUTO;
    
    if (isset($_POST['cbxSecure']))
      $objPop3->SetSecure(995); // 995 is the default secure POP3 port
    
    if ($objPop3->LastError == 0)
    {
      $objPop3->Connect($_POST['txtHost'], $_POST['txtAccount'], $_POST['txtPassword']);
    }
    
    if ($objPop3->LastError == 0)
    {
      $numMessages = $objPop3->CountMessages();
    }
    
    if ($objPop3->LastError == 0)
    {
      for ($i = 1; $i <= $numMessages; $i++)
      {
        $objEmail = $objPop3->GetEmailHeader($i);
        
        
        if ($objPop3->LastError == 0)
          $arrMails[] = $objEmail;
      }
    }
    
    $strResult = $objPop3->LastError . ": " . $objPop3->GetErrorDescription($objPop3->LastError);    
  }

// HTML-CSS layout includes, no code there!
include('css/Header.html'); 
include('css/Menu.html'); 
?>
    <div class="container">
      <h1>Auron Email Component PHP POP3 Sample</h1>
      <hr />
      <p>
        Simple Mail Transfer Protocol (SMTP) is an Internet standard for electronic mail (e-mail) 
        transmission across Internet Protocol (IP) networks.
        SMTP is specified for outgoing mail transport and uses TCP port 25 by default.
      </p>
      <form action="pop3.php" method="post">
        <h2>Component:</h2>
        <h3>Build: <?php echo $objPop3->Build ?>; Module: <?php echo $objPop3->Module ?></h3>
      
        <!-- Host, Secure -->
        <label for="Host">Mailserver:</label>
        <p>
          <input type="text" id="Host" name="txtHost" value="pop3.mycompany.com" />
          
          <input type="checkbox" class="cbFix" id="Secure" name="cbxSecure" checked />
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
          <select id="Received" class="FullWidth" name="lvMessages" size="10">
          <?php
          foreach($arrMails as $Mail)
          {
            echo '
            <option>'.$Mail->Date . ": " . $Mail->FromAddress . "; Subject " . $Mail->Subject.'</option>';
          }
          ?>
          </select>
        </p>
        
        <!-- Result -->
        <label for="Result" class="Bold">Result:</label>
        <p>
          <input type="text" id="Result" name="txtResult" class="FullWidth Bold" class="FullWidth" value="<?php echo $strResult; ?>" />
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