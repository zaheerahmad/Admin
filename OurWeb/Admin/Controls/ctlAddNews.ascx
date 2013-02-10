<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctlAddNews.ascx.cs" Inherits="AdminSite.Controls.ctlAddNews" %>
<link href="~/assets/bootstrap/css/bootstrap.min.css" rel="stylesheet" media="screen"/>
<link href="~/assets/bootstrap/css/bootstrap-responsive.css" rel="stylesheet"/>
<div class="span2">
    <ul class="nav nav-list">
      <li class="nav-header">News</li>
      <li id="home"><a href="Admin.aspx?ctl=6">Home</a></li>
      <li id="add" class="active"><a href="Admin.aspx?ctl=4">Add News</a></li>
      <li id="manage"><a href="Admin.aspx?ctl=7">Manage News</a></li>
    </ul>
</div>
<div class="span8">
    <div class="page-header">
      <h1>News<small> Add News</small></h1>
    </div>
    <form id="Form1" name="frmAddNews" class="form-horizontal" runat="server">
        <div class="alert alert-error" id="divStatusError" runat="server">
            <asp:Label ID="labelStatusError" runat="server"></asp:Label>
        </div>
        <div class="alert alert-success" id="divStatusSuccess" runat="server">
          <asp:Label ID="lblStatusSuccess" runat="server"></asp:Label>
        </div>        
      <div class="control-group">
        <label class="control-label" for="txtNewsTitle">News Title</label>
        <div class="controls">
          <asp:TextBox ID="txtNewsTitle" runat="server" placeHolder="Type News Title..."></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvNewsTitle" ControlToValidate="txtNewsTitle" runat="server" ForeColor="Red" Text="*" />
        </div>
      </div>
      <div class="control-group">
        <label class="control-label" for="txtNewsDescription">News Description</label>
        <div class="controls">
          <asp:TextBox ID="txtNewsDescription" runat="server" placeHolder="Type News Description..." TextMode="MultiLine" MaxLength="100" Height="50px" Width="400px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvNewsDescription" ControlToValidate="txtNewsDescription" runat="server" ForeColor="Red" Text="*" />
        </div>
      </div>
      <div class="control-group">
        <label class="control-label" for="fuNewsPicture">Add News Picture</label>
        <div class="controls">
            <asp:FileUpload ID="fuNewsPicture" runat="server"/>
        </div>
      </div>
      <div class="control-group">
        <div class="controls">
            <asp:Button ID="btnAddNews" class="btn" runat="server" Text="Add News" onclick="btnAddNews_Click" 
                />
        </div>
      </div>
    </form>
</div>