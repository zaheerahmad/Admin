<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctlServices.ascx.cs" Inherits="AdminSite.Controls.ctlServices" %>
<link href="~/assets/bootstrap/css/bootstrap.min.css" rel="stylesheet" media="screen"/>
<link href="~/assets/bootstrap/css/bootstrap-responsive.css" rel="stylesheet"/>

<script type="text/javascript">
    $(document).ready(function () {
        $("li#add").click(function () {
            $("li.#home").css({ "class": "active" });
        });
    });
</script>
<div class="span2">
    <ul class="nav nav-list">
      <li class="nav-header">Sercices</li>
      <li id="home" class="active"><a href="Admin.aspx?ctl=5">Home</a></li>
      <li id="add"><a href="Admin.aspx?ctl=2">Add Services</a></li>
      <li id="manage"><a href="Admin.aspx?ctl=3">Manage Services</a></li>
    </ul>
</div>
<div class="span8">
    <div class="page-header">
      <h1>Services<small> Welcome to Services Control</small></h1>
    </div>
</div>