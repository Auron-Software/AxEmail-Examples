<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="Layout.Master" CodeBehind="Default.aspx.vb" Inherits="VisualBasicDemo._Default" %>

		<asp:Content runat="server" ContentPlaceHolderID="container">
            <h1>Auron Email Component - ASP .NET VB</h1>
			<hr />
			<p>Auron Email Component can also be used client-side (i.e. connected to the client's PC).
			 There's an HTML sample included with the product.<br />
			 For more details, <a href="https://www.auronsoftware.com/knowledge-base/#email-component" target="_blank">click here</a>.
			</p>
			<div class="content">
				<h1>Table of contents</h1>				
				<button onclick="window.location='frmsmtp.aspx'" 
					class="Button" type="button">SMTP Send</button>
				
				<button onclick="window.location='frmpop3.aspx'" 
					class="Button" type="button">POP3 Receive</button>

				<button onclick="window.location='frmimap.aspx'" 
					class="Button" type="button">IMAP Receive</button>
			</div>
			<p>
				This demo uses the Auron Email Component, an <a href="https://www.auronsoftware.com" target="_blank">Auron Software</a> product.
			</p>
		</asp:Content>