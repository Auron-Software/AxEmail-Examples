<?php
  $arrMails = array();
  $strResult = 'n/a';
  
  $objImap = new COM ("AxEmail.Imap", NULL, CP_UTF8);
      
  // A license key is required to unlock this component after the trial period has expired.
  // Assign the LicenseKey property every time a new instance of this component is created (see code below). 
  // Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry.
  // For details, see manual, chapter "Product Activation".
  //
  // $objImap->LicenseKey = "XXXXX-XXXXX-XXXXX"; 

  $objImap->LogFile = sys_get_temp_dir()."Imap.log"; 
  // Windows default: 'C:\Windows\Temp\Imap.log'
  
  if (isset($_POST['btnListMessages']))
  {
    $objEmailConstants = new COM("AxEmail.Constants", NULL, CP_UTF8);
    $objEmail = new COM("AxEmail.Message", NULL, CP_UTF8);
    
    $objImap->Authentication = $objEmailConstants->IMAP_AUTH_AUTO;
    
    if (isset($_POST['cbxSecure']))
      $objImap->SetSecure(); // 993 is the default secure IMAP port
    
    if ($objImap->LastError == 0)
    {
      $objImap->Connect($_POST['txtHost'], $_POST['txtAccount'], $_POST['txtPassword']);
    }
    
    if ($objImap->LastError == 0)
    {
      $nCnt = 0;      
      $objEmail = $objImap->FetchFirstEmailHeader($objEmailConstants->IMAP_SK_ALL);
      while ($objImap->LastError == 0)
      {
        $nCnt++;
        if ($nCnt == 100) break;
        $arrMails[] = $objEmail;
        $objEmail = $objImap->FetchNextEmailHeader();
      }
    }
        
    $strResult = $objImap->LastError . ": " . $objImap->GetErrorDescription($objImap->LastError);    
  }

// HTML-CSS layout includes, no code there!
include('css/Header.html'); 
include('css/Menu.html'); 
?>
    <div class="container">
      <h1>Auron Email Component PHP IMAP Sample</h1>
      <hr />
      <p>
      The Internet Message Access Protocol (IMAP) is a widely used protocol for accessing and maintaining a set of remote mailboxes. 
      </p>
      <form action="imap.php" method="post">
        <h2>Component:</h2>
        <h3>Build: <?php echo $objImap->Build ?>; Module: <?php echo $objImap->Module ?></h3>
      
        <!-- Host, Secure -->
        <label for="Host">Mailserver:</label>
        <p>
          <input type="text" id="Host" name="txtHost" value="imap.gmail.com" />
          
          <input type="checkbox" class="cbFix" id="Secure" name="cbxSecure" checked />
          <label for="Secure">Secure</label>
        </p>
        
        <!-- Account -->
        <label for="Account">Account:</label>
        <p>
          <input type="text" id="Account" name="txtAccount" value="user@gmail.com" />
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
          <input type="submit" name="btnListMessages" value="List First 100 Messages" />
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