<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctlAddClient.ascx.cs" Inherits="AdminSite.Controls.ctlAddClient" %>
<div class="span2">
    <ul class="nav nav-list">
      <li class="nav-header">Clients</li>
      <li id="home"><a href="Admin.aspx?ctl=8">Home</a></li>
      <li id="add" class="active"><a href="Admin.aspx?ctl=9">Add Clients</a></li>
      <li id="manage"><a href="Admin.aspx?ctl=10">Manage Clients</a></li>
    </ul>
</div>
<div class="span8">
    <div class="page-header">
      <h1>Clients<small> Add Client</small></h1>
    </div>
    <form id="Form1" name="frmAddClient" class="form-horizontal" runat="server">
        <div class="alert alert-error" id="divStatusError" runat="server">
            <asp:Label ID="labelStatusError" runat="server"></asp:Label>
        </div>
        <div class="alert alert-success" id="divStatusSuccess" runat="server">
          <asp:Label ID="lblStatusSuccess" runat="server"></asp:Label>
        </div>
      <div class="control-group">
        <label class="control-label" for="txtClientName">Client Name</label>
        <div class="controls">
          <asp:TextBox ID="txtClientName" runat="server" placeHolder="Type Client Name..."></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvClientName" ControlToValidate="txtClientName" runat="server" ForeColor="Red" Text="*" />
        </div>
      </div>
      <div class="control-group">
        <label class="control-label" for="txtDescription">Description</label>
        <div class="controls">
          <asp:TextBox ID="txtDescription" runat="server" placeHolder="Type Description..." TextMode="MultiLine" MaxLength="100" Height="50px" Width="400px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvDescription" ControlToValidate="txtDescription" runat="server" ForeColor="Red" Text="*" />
        </div>
      </div>
      <div class="control-group">
        <label class="control-label" for="txtAddress">Address</label>
        <div class="controls">
          <asp:TextBox ID="txtAddress" runat="server" placeHolder="Type Address..." TextMode="MultiLine" MaxLength="100" Height="50px" Width="400px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtAddress" runat="server" ForeColor="Red" Text="*" />
        </div>
      </div>
      <div class="control-group">
        <label class="control-label" for="txtContactPerson">Contact Person</label>
        <div class="controls">
          <asp:TextBox ID="txtContactPerson" runat="server" placeHolder="Type Contact Person..."></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtContactPerson" runat="server" ForeColor="Red" Text="*" />
        </div>
      </div>
      <div class="control-group">
        <label class="control-label" for="txtContactNo">Contact No</label>
        <div class="controls">
          <asp:TextBox ID="txtContactNo" runat="server" placeHolder="Type Contact Number..."></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtContactNo" runat="server" ForeColor="Red" Text="*" />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Mismatch Format (e.g. +92-321-9570199)" ForeColor="Red" ValidationExpression="(\+){1}[0-9]{2}(\-){1}[0-9]{3}(\-){1}[0-9]{7}" ControlToValidate="txtContactNo"></asp:RegularExpressionValidator>
        </div>
      </div>
      <div class="control-group">
        <label class="control-label" for="txtClientURL">Client Profile URL</label>
        <div class="controls">
          <asp:TextBox ID="txtClientURL" runat="server" placeHolder="Type Client URL here..."></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="txtClientURL" runat="server" ForeColor="Red" Text="*" />
        </div>
      </div>
      <div class="control-group">
        <label class="control-label" for="fuLogo">Add Logo</label>
        <div class="controls">
            <asp:FileUpload ID="fuLogo" runat="server"/>
        </div>
      </div>
      <div class="control-group">
        <div class="controls">
            <asp:Button ID="btnAddClient" class="btn" runat="server" Text="Add Client" 
                onclick="btnAddClient_Click"/>
        </div>
      </div>
    </form>
</div>