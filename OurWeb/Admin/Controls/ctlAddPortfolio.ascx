<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctlAddPortfolio.ascx.cs" Inherits="OurWeb.Admin.Controls.ctlAddPortfolio" %>
<link href="~/assets/bootstrap/css/bootstrap.min.css" rel="stylesheet" media="screen"/>
<link href="~/assets/bootstrap/css/bootstrap-responsive.css" rel="stylesheet"/>
<script type="text/javascript" src="~/assets/Scripts/jquery-1.4.1.min.js"></script>>

<div class="span2">
    <ul class="nav nav-list">
      <li class="nav-header">Portfolio</li>
      <li id="home"><a href="Admin.aspx?ctl=14">Home</a></li>
      <li id="add" class="active"><a href="Admin.aspx?ctl=15">Add Portfolio</a></li>
      <li id="manage"><a href="Admin.aspx?ctl=16">Manage Portfolio</a></li>
    </ul>
</div>

<div class="span8">
    <div class="page-header">
      <h1>Portfolio<small> Add Project</small></h1>
    </div>
    <form id="Form1" name="frmAddProject" class="form-horizontal" runat="server">
        <div class="alert alert-error" id="divStatusError" runat="server">
            <asp:Label ID="labelStatusError" runat="server"></asp:Label>
        </div>
        <div class="alert alert-success" id="divStatusSuccess" runat="server">
          <asp:Label ID="lblStatusSuccess" runat="server"></asp:Label>
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
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="txtProjectDescription" ValidationExpression=".{20,}" runat="server" ErrorMessage="*Description should be atleast 20 characters long" ForeColor="Red"></asp:RegularExpressionValidator>
        </div>
      </div>
      <div class="control-group">
        <label class="control-label" for="txtAssignedResource">Tools and Techniques</label>
        <div class="controls">
            <asp:CheckBoxList ID="chkBoxList1" runat="server" CellSpacing="50" RepeatColumns="4" RepeatDirection="Vertical" RepeatLayout="Table" TextAlign="Right" Width = "100%">
            </asp:CheckBoxList>
        </div>
      </div>
      <div class="control-group">
        <label class="control-label" for="txtProjectURL">Project URL (If any)</label>
        <div class="controls">
          <asp:TextBox ID="txtProjectURL" runat="server" placeHolder="Type Project URL..."></asp:TextBox>
        </div>
      </div>
      <div class="control-group">
        <label class="control-label" for="txtProjectURL">Portfolio Image(s)</label>
        <div class="controls">
          <asp:FileUpload ID="fuPortfolioImage" runat="server" />
        </div>
      </div>
      <div class="control-group">
        <div class="controls">
            <asp:Button ID="btnAddProject" class="btn" runat="server" Text="Add Project" 
                onclick="btnAddProject_Click" />
        </div>
      </div>
    </form>
</div>