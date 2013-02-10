<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctlProject.ascx.cs" Inherits="OurWeb.Admin.Controls.ctlProject" %>
<link href="~/assets/bootstrap/css/bootstrap.min.css" rel="stylesheet" media="screen"/>
<link href="~/assets/bootstrap/css/bootstrap-responsive.css" rel="stylesheet"/>
<div class="span2">
    <ul class="nav nav-list">
      <li class="nav-header">Project</li>
      <li id="home" class="active"><a href="Admin.aspx?ctl=11">Home</a></li>
      <li id="add"><a href="Admin.aspx?ctl=12">Add Project</a></li>
      <li id="manage"><a href="Admin.aspx?ctl=13">Manage Project</a></li>
    </ul>
</div>
<div class="span8">
    <div class="page-header">
      <h1>Project<small> Welcome to Project Control</small></h1>
    </div>
</div>