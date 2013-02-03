<%@ Page Title="" Language="C#" MasterPageFile="~/AdminSite.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="AdminSite.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphSideBar" runat="server">
    <%if (AdminSite.Common.Common.showSideBar)
      {
          if (AdminSite.Common.Common.selectedMenu.Equals("Services", StringComparison.InvariantCultureIgnoreCase))
          {
          %>
          <%--Services Side Navigations--%>
        <ul class="nav nav-list">
          <li class="nav-header">Services</li>
          <li class="active"><a href="#">Add New Service</a></li>
          <li><a href="Admin.aspx?ctl=0">Manage Services</a></li>
        </ul>
        <%
        }
          if (AdminSite.Common.Common.selectedMenu.Equals("Products", StringComparison.InvariantCultureIgnoreCase))
          {%>
              <%--Products Side Navigations--%>
            <ul class="nav nav-list">
              <li class="nav-header"><%= Session["loginUser"].ToString()%></li>
              <li class="active"><a href="#">Add New Product</a></li>
              <li><a href="Admin.aspx?ctl=0">Manage Products</a></li>
            </ul>
      <%}
      
      }%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContentArea" runat="server">
    <%if (AdminSite.Common.Common.showSideBar)
      { %>
    <div class="navbar navbar-inverse">
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
              <a class="brand" href="Admin.aspx?ctl=1">Control Panel</a>
              <ul class="nav">
                <li class="active">
                    <a href="#">Services</a>
                    <%AdminSite.Common.Common.selectedMenu = "Services"; %>
                </li>
                <li><a href="#">Products</a><%AdminSite.Common.Common.selectedMenu = "Products"; %></li>
                <li><a href="#">Clients</a></li>
                <li><a href="#">Status</a></li>
                <li class="dropdown">
                    <a href="#" class="dropdown-toggle" data-toggle="dropdown">Services<b class="caret"></b></a>
                        <ul class="dropdown-menu">
                          <li><a href="#">Add New Service</a></li>
                          <li><a href="#">Manage Service</a></li>
                        </ul>
                </li>
              </ul>

 
                <form class="navbar-search pull-left">
                  <input type="text" class="search-query" placeholder="Search">
                </form>

              <!-- Everything you want hidden at 940px or less, place within here -->
              <div class="nav-collapse collapse">
                <!-- .nav, .navbar-search, .navbar-form, etc -->
                <ul class="nav">
                    <li><a href="Admin.aspx?ctl=0">Sign Out</a></li>
                </ul>
              </div>
 
            </div>
          </div>
        </div>
    </div>
    <%} %>
    &nbsp;<asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
</asp:Content>
