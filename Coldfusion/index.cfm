<!--- HTML-CSS layout includes, no code there! --->
<cfinclude template = "css/Header.html">
<cfinclude template = "css/Menu.html">
    <div class="container">
      <h1>Auron Email Component Coldfusion Samples</h1>
      <hr />
      <p>
        Auron Email Component can also be used client-side (i.e. connected to the client's
        PC). There's an HTML sample included with the product.<br />
        For more details, <a href="https://www.auronsoftware.com/knowledge-base/#email-component" target="_blank">click here</a>.
      </p>
      <div class="content">
        <h1>Table of contents</h1>
        <input type="button" class="Button" onclick="window.location='smtp.cfm';"      value="E-mail via SMTP" />
        <input type="button" class="Button" onclick="window.location='pop3.cfm';"      value="E-mail via POP3" />
      </div><!-- /content -->
      <p>
        This demo uses the Auron Email Component, an <a href="https://www.auronsoftware.com" target="_blank">Auron Software</a> product.<br />
      </p>
    </div><!-- /container -->
<!--- HTML-CSS layout includes, no code there! --->
<cfinclude template = "css/Footer.html">