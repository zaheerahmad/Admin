<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctlPortfolio.ascx.cs" Inherits="OurWeb.Admin.Controls.ctlPortfolio" %>
<link href="~/assets/bootstrap/css/bootstrap.min.css" rel="stylesheet" media="screen"/>
<link href="~/assets/bootstrap/css/bootstrap-responsive.css" rel="stylesheet"/>
<div class="span2">
    <ul class="nav nav-list">
      <li class="nav-header">Portfolio</li>
      <li id="home" class="active"><a href="Admin.aspx?ctl=14">Home</a></li>
      <li id="add"><a href="Admin.aspx?ctl=15">Add Portfolio</a></li>
      <li id="manage"><a href="Admin.aspx?ctl=16">Manage Portfolio</a></li>
    </ul>
</div>
<div class="span8">
    <div class="page-header">
      <h1>Portfolio<small> Welcome to Portfolio Control</small></h1>
    </div>
</div>