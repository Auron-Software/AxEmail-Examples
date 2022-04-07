<%@ Page ValidateRequest="false" Language="C#" MasterPageFile="Layout.Master" AutoEventWireup="true" CodeBehind="frmsmtp.aspx.cs" Inherits="CSharpDemo.frmsmtp" %>

		<asp:Content runat="server" ContentPlaceHolderID="container">
            <h1>Auron Email Component - ASP .NET C# SMTP</h1>
			<hr />
			<p>
				Simple Mail Transfer Protocol (SMTP) is an Internet standard for electronic mail (e-mail) transmission across Internet Protocol (IP) networks. SMTP is specified for outgoing mail transport and uses TCP port 25 by default. <br />
				For more details about using Auron Email Component with ASP .NET, <a href="https://www.auronsoftware.com/knowledge-base/#email-component"
					target="_blank">click here</a>.<br />
			</p>
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
					<asp:TextBox ID="txtPassword" runat="server" 
						TextMode="Password"></asp:TextBox>
				</p>
				
				<!-- Empty row -->
				<div class="clearRow"></div> 
				
				<!-- Sender name -->
				<asp:Label ID="lblSenderName" runat="server" Text="Sender name:"></asp:Label>
				<p>
					<asp:TextBox ID="txtFromName" runat="server"></asp:TextBox>
				</p>
				
				<!-- Sender email -->
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
					<asp:Button ID="btnSend" Text="Send" runat="server" onclick="btnSend_Click" />
				</p>
				
				<!-- Empty row -->
				<div class="clearRow"></div>
				
				<!-- Result -->
				<asp:Label ID="lblResult" runat="server" Text="Result:" Font-Bold="true"></asp:Label>
				<p>
					<asp:TextBox ID="txtResult" CssClass="FullWidth" Font-Bold="true" runat="server"></asp:TextBox>
				</p>
				
				
				<!-- Result -->
				<asp:Label ID="lblLastResponse" runat="server" Text="Last Response:"></asp:Label>
				<p>
					<asp:TextBox ID="txtLastSmtpResponse" CssClass="FullWidth" runat="server"></asp:TextBox>
				</p>				
				
				<!-- Log File-->
				<asp:Label ID="lblLogFile" runat="server" Text="Logfile:"></asp:Label>
				<p>
				    <asp:TextBox ID="txtLogFile" runat="server" CssClass="FullWidth"></asp:TextBox>
				</p>
			</form>
			<p>
				This demo uses the Auron Email Component, an <a href="https://www.auronsoftware.com" target="_blank">Auron Software</a> product.<br />
				<a href="Default.aspx">Back to main page</a> 
			</p>
		</asp:Content>