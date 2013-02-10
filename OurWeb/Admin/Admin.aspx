<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminSite.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="AdminSite.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphMainContentArea" runat="server">
<div class="span12">
    <%if (AdminSite.Common.Common.showSideBar)
      { %>
    <div class="navbar navbar-fixed-top">
        <div class="navbar">
          <div class="navbar-inner">
            <div class="container">
              <!-- .btn-navbar is used as the toggle for collapsed navbar content -->
              <a class="btn btn-navbar" data-toggle="collapse" data-target=".nav-collapse">
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
              </a>
 
              <!-- Be sure to leave the brand out there if you want it shown -->
              <a class="brand" href="Admin.aspx?ctl=1"><i class="icon-home icon-black"></i>Control Panel</a>
              <ul class="nav">
                <li>
                    <a href="Admin.aspx?ctl=5">Services</a>
                </li>
                <li>
                    <a href="Admin.aspx?ctl=6">News</a>
                </li>
                <li>
                    <a href="Admin.aspx?ctl=8">Clients</a>
                </li>
                <li>
                    <a href="Admin.aspx?ctl=11">Projects</a>
                </li>
                <li><a href="../Home.aspx">Sign Out</a></li>
            </div>
          </div>
        </div>
    </div>
    <%} %>
    
</div>
&nbsp;<br /><br /><asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
</asp:Content>
