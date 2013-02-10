<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctlClient.ascx.cs" Inherits="AdminSite.Controls.ctlClient" %>
<link href="~/assets/bootstrap/css/bootstrap.min.css" rel="stylesheet" media="screen"/>
<link href="~/assets/bootstrap/css/bootstrap-responsive.css" rel="stylesheet"/>
<div class="span2">
    <ul class="nav nav-list">
      <li class="nav-header">Clients</li>
      <li id="home" class="active"><a href="Admin.aspx?ctl=8">Home</a></li>
      <li id="add"><a href="Admin.aspx?ctl=9">Add Clients</a></li>
      <li id="manage"><a href="Admin.aspx?ctl=10">Manage Clients</a></li>
    </ul>
</div>
<div class="span8">
    <div class="page-header">
      <h1>Clients<small> Welcome to Clients Control</small></h1>
    </div>
</div>