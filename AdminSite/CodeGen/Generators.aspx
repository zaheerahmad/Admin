<%@ Page Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" Inherits="Generators"  Title="Generators"
	ValidateRequest="false" Codebehind="Generators.aspx.cs" %>

<%@ Register Src="ClassGenerator.ascx" TagName="ClassGenerator" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphFull" runat="Server">
	<div id="divWarning" runat="server" visible="false">
		<p>
			The template directory is missing or incorrect.<br />
			Please make sure that you have specified a valid to the templates in the <span style="color: #ff0000">
				templateDirectory</span> parameter in web.config.
		</p>
	</div>
	<uc1:ClassGenerator ID="ClassGenerator1" runat="server" />
	
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphLeft" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphRight" runat="Server">
</asp:Content>
