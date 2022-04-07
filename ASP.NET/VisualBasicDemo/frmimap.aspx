<%@ Page Language="vb" MasterPageFile="Layout.Master" AutoEventWireup="false" CodeBehind="frmimap.aspx.vb" Inherits="VisualBasicDemo.frmimap" %>

		<asp:Content runat="server" ContentPlaceHolderID="container">
            <h1>Auron Email Component - ASP .NET VB IMAP</h1>
			<hr />
			<p>
				The Internet Message Access Protocol is a widely used protocol for accessing and maintaining a set of remote mailboxes. This is mostly used by more advanced email clients.<br />
				For more details about using Auron Email Component with ASP .NET, <a href="https://www.auronsoftware.com/knowledge-base/#email-component"
          					target="_blank">click here</a>.<br />
			</p>
			<form id="form1" runat="server">
				<h2>Component:</h2>
				<h3><asp:Label ID="lblInfo" runat="server" CssClass="FullWidth"></asp:Label></h3>
				
				<!-- Host, Secure -->
				<asp:Label ID="lblHost" runat="server" Text="IMAP Host:"></asp:Label>
				<p>
					<asp:TextBox ID="txtHost" runat="server">imap.mycompany.com</asp:TextBox>
					<asp:CheckBox ID="cbSecure" runat="server" CssClass="cbFix" Text=" Secure" />
				</p>
				
				<!-- Account -->
				<asp:Label ID="lblAccount" runat="server" Text="IMAP Account:"></asp:Label>
				<p>
					<asp:TextBox ID="txtAccount" runat="server">user@mycompany.com</asp:TextBox>
				</p>
				
				<!-- Password -->
				<asp:Label ID="lblPassword" runat="server" Text="IMAP Password:"></asp:Label>
				<p>
					<asp:TextBox ID="txtPassword" runat="server" TextMode="Password">secret</asp:TextBox>
				</p>
				
				<!-- Empty row -->
				<div class="clearRow"></div>
				
				<!-- List Messages button -->
				<div class="clearLabel"></div>
				<p>
					<asp:Button ID="btnListMessages" runat="server" Text="List Messages"/>
				</p>
				
				<!-- Messages Listbox -->
				<asp:Label ID="lblMessagesReceived" runat="server" Text="Messages received:"></asp:Label>
				<p>
					<asp:ListBox ID="lvMessages" runat="server" CssClass="FullWidth" Rows="10"></asp:ListBox>
				</p>
				
				<!-- Result -->
				<asp:Label ID="lblResult" runat="server" Font-Bold="true" Text="Result:"></asp:Label>
				<p>
					<asp:TextBox ID="txtResult" runat="server" CssClass="FullWidth Bold"></asp:TextBox>
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