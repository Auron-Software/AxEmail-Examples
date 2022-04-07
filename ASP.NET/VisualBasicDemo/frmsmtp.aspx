<%@ Page ValidateRequest="false" Language="vb" MasterPageFile="Layout.Master" AutoEventWireup="false" CodeBehind="frmsmtp.aspx.vb" Inherits="VisualBasicDemo.frmsmtp" %>

		<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="container">
            <h1>Auron Email Component - ASP .NET VB SMTP</h1>
			<form id="form1" runat="server">
				<h2>Component:</h2>
				<h3><asp:Label ID="lblInfo" runat="server" CssClass="FullWidth"></asp:Label></h3>
				
				<!-- Server, Secure -->
				<asp:Label ID="lblServer" runat="server" Text="Mailserver:"></asp:Label>
				<p>
					<asp:TextBox ID="txtServer" runat="server">smtp.mycompany.com</asp:TextBox>
					<asp:CheckBox ID="cbSecure" runat="server" CssClass="cbFix" Text=" Secure" />
				</p>
				
				<!-- Account -->
				<asp:Label ID="lblAccount"  runat="server" Text="Account*:"></asp:Label>
				<p>
					<asp:TextBox ID="txtAccount" runat="server"></asp:TextBox>
					*Only use when server requires authentication 
				</p>
				
				<!-- Password -->
				<asp:Label ID="lblPassword"  runat="server" Text="Password*:"></asp:Label>
				<p>
					<asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
				</p>
				
				<!-- Empty row -->
				<div class="clearRow"></div>
				
				<!-- sender name -->
				<asp:Label ID="lblSenderName" runat="server" Text="Sender name:"></asp:Label>  
				<p>
					<asp:TextBox ID="txtFromName" runat="server"></asp:TextBox>
				</p>
				
				<!-- Sender e-mail -->
				<asp:Label ID="lblSenderEmail" runat="server" Text="Sender e-mail:"></asp:Label>
				<p>
					<asp:TextBox ID="txtFromAddress" runat="server"></asp:TextBox>
				</p>
				
				<!-- Empty row -->
				<div class="clearRow"></div>
				
				<!-- To -->
				<asp:Label ID="lblTo" runat="server" Text="To:"></asp:Label>
				<p>
					<asp:TextBox ID="txtToAddress" runat="server">john@mycompany.com</asp:TextBox>
				</p>
				
				<!-- Cc -->
				<asp:Label ID="lblCc" runat="server" Text="Cc:"></asp:Label>
				<p>
					<asp:TextBox ID="txtCcAddress" runat="server"></asp:TextBox>
				</p>
				
				<!-- Bcc -->
				<asp:Label ID="lblBcc" runat="server" Text="Bcc:"></asp:Label>
				<p>
					<asp:TextBox ID="txtBccAddress" runat="server"></asp:TextBox>
				</p>
				
				<!-- Empty row -->
				<div class="clearRow"></div>
				
				<!-- Subject -->
				<asp:Label ID="lblSubject" runat="server" Text="Subject:"></asp:Label>
				<p>
					<asp:TextBox ID="txtSubject" runat="server"></asp:TextBox>
				</p>
				
				<!-- PlainBody -->
				<asp:Label ID="lblPlainBody" runat="server" Text="Body:"></asp:Label>
				<p>
					<asp:TextBox ID="txtPlainBody" runat="server" TextMode="MultiLine" Height="55px"></asp:TextBox>
				</p>
				
				<!-- HtmlBody -->
				<asp:Label ID="lblHtmlBody" runat="server" Text="Body HTML (optional):"></asp:Label>
				<p>
					<asp:TextBox ID="txtHtmlBody" runat="server" TextMode="MultiLine" Height="55px"></asp:TextBox>
				</p>
				
				<!-- Empty row -->
				<div class="clearRow"></div>	 
				
				<!-- Character Set -->
				<asp:Label ID="lblCharSet" runat="server" Text="Char. Set:"></asp:Label>
				<p>
					<asp:DropDownList ID="ddlEncoding" runat="server"></asp:DropDownList>
				</p>
				
				<!-- Priority -->
				<asp:Label ID="lblPriority" runat="server" Text="Priority:"></asp:Label>
				<p>
					<asp:DropDownList ID="ddlPriority" runat="server"></asp:DropDownList>
				</p>
				
				<!-- SendButton -->		
				<div class="clearLabel"></div>	
				<p>
					<asp:Button ID="btnSend" Text="Send" runat="server" />
				</p>
				
				<!-- Empty row -->
				<div class="clearRow"></div>
				
				<!-- Result -->
				<asp:Label ID="lblResult" runat="server" Text="Result:" Font-Bold="true"></asp:Label>
				<p>
					<asp:TextBox ID="txtResult" Text="" Font-Bold="true" CssClass="FullWidth" runat="server"></asp:TextBox>
				</p>
				
				<!-- Result -->
				<asp:Label ID="lblLastSmtpResponse" runat="server" Text="Last SMTP Response:"></asp:Label>
				<p>
					<asp:TextBox ID="txtLastSmtpResponse" Text="" CssClass="FullWidth" runat="server"></asp:TextBox>
				</p>				
				
				<!-- Logfile -->
				<asp:Label ID="lblLogFile" runat="server" Text="Logfile:"></asp:Label>
				<p>
				    <asp:TextBox ID="txtLogfile" runat="server" CssClass="FullWidth"></asp:TextBox>
				</p>
			</form>
			<p>
				This demo uses the Auron Email Component, an <a href="https://www.auronsoftware.com" target="_blank">Auron Software</a> product.<br />
				<a href="Default.aspx">Back to main page</a> 
			</p>
		</asp:Content>