<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctlAddProject.ascx.cs" Inherits="OurWeb.Admin.Controls.ctlAddProject" %>
<link href="~/assets/bootstrap/css/bootstrap.min.css" rel="stylesheet" media="screen"/>
<link href="~/assets/bootstrap/css/bootstrap-responsive.css" rel="stylesheet"/>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="Anthem" Namespace="Anthem" TagPrefix="anthem" %>
<%@ Register assembly="eWorld.UI" namespace="eWorld.UI" tagprefix="ew" %>
<div class="span2">
    <ul class="nav nav-list">
      <li class="nav-header">Project</li>
      <li id="home"><a href="Admin.aspx?ctl=11">Home</a></li>
      <li id="add" class="active"><a href="Admin.aspx?ctl=12">Add Project</a></li>
      <li id="manage"><a href="Admin.aspx?ctl=13">Manage Project</a></li>
    </ul>
</div>
<div class="span8">
    <div class="page-header">
      <h1>Project<small> Add Project</small></h1>
    </div>
    <form id="Form1" name="frmAddProject" class="form-horizontal" runat="server">
        <div class="alert alert-error" id="divStatusError" runat="server">
            <asp:Label ID="labelStatusError" runat="server"></asp:Label>
        </div>
        <div class="alert alert-success" id="divStatusSuccess" runat="server">
          <asp:Label ID="lblStatusSuccess" runat="server"></asp:Label>
        </div>
      <div class="control-group">
        <label class="control-label" for="txtClientName">Client Name</label>
        <div class="controls">
            <asp:DropDownList ID="ddlClients" runat="server">
            </asp:DropDownList>
        </div>
      </div>
      <div class="control-group">
        <label class="control-label" for="txtProjectName">Project Name</label>
        <div class="controls">
          <asp:TextBox ID="txtProjectName" runat="server" placeHolder="Type Project Name..."></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvProjectName" ControlToValidate="txtProjectName" runat="server" ForeColor="Red" Text="*" />
        </div>
      </div>
      <div class="control-group">
        <label class="control-label" for="txtProjectDescription">Project Description</label>
        <div class="controls">
          <asp:TextBox ID="txtProjectDescription" runat="server" placeHolder="Type Project Description..." TextMode="MultiLine" MaxLength="100" Height="50px" Width="400px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtProjectDescription" runat="server" ForeColor="Red" Text="*" />
        </div>
      </div>
      <div class="control-group">
        <label class="control-label" for="cpExpiryDate">Start Date</label>
        <div class="controls">
          <ew:CalendarPopup ID="cpStartDate" runat="server" />
        </div>
      </div>
      <div class="control-group">
        <label class="control-label" for="txtContactNo">Estimated End Date</label>
        <div class="controls">
          <ew:CalendarPopup ID="cpEndDate" runat="server" />
        </div>
      </div>
      <div class="control-group">
        <label class="control-label" for="txtAssignedResource">Assigned Resource</label>
        <div class="controls">
          <asp:TextBox ID="txtAssignedResourceName" runat="server" placeHolder="Type Assigned Resource Name..."></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtAssignedResourceName" runat="server" ForeColor="Red" Text="*" />
        </div>
      </div>
      <div class="control-group">
        <label class="control-label" for="txtProjectURL">Project URL (If any)</label>
        <div class="controls">
          <asp:TextBox ID="txtProjectURL" runat="server" placeHolder="Type Project URL..."></asp:TextBox>
        </div>
      </div>
      <div class="control-group">
        <div class="controls">
            <asp:Button ID="btnAddProject" class="btn" runat="server" Text="Add Project" 
                onclick="btnAddProject_Click"/>
        </div>
      </div>
    </form>
<//div>