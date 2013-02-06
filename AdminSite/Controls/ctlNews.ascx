<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctlNews.ascx.cs" Inherits="AdminSite.Controls.ctlNews" %>
<link href="~/assets/bootstrap/css/bootstrap.min.css" rel="stylesheet" media="screen"/>
<link href="~/assets/bootstrap/css/bootstrap-responsive.css" rel="stylesheet"/>
<div class="span2">
    <ul class="nav nav-list">
      <li class="nav-header">News</li>
      <li id="home" class="active"><a href="Admin.aspx?ctl=6">Home</a></li>
      <li id="add"><a href="Admin.aspx?ctl=4">Add News</a></li>
      <li id="manage"><a href="Admin.aspx?ctl=7">Manage News</a></li>
    </ul>
</div>
<div class="span8">
    <div class="page-header">
      <h1>News<small> Welcome to News Control</small></h1>
    </div>
</div>