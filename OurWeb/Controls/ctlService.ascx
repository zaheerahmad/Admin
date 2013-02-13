<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctlService.ascx.cs" Inherits="OurWeb.Controls.ctlService" %>
<!-- header -->
        <div id="header">
        	
            <a href="#" class="button small float-right">Get in touch</a>
            <a href="Home.aspx?ctl=1" class="button blue float-right">Check our works</a>
            
            <h2>Services</h2> <p>Duis autem vel eum iriure dolor in hendrerit in vulputate</p>
            
        </div>
        <!-- //header -->
        
        <!-- path -->
        <div id="path">
        	
            <strong>You are here:</strong> <a href="#">Home</a> / <a href="#">Services</a>
            
        </div>
        <!-- //path -->
                
        <!-- content -->
        <div id="content">
         
            <!-- set size -->
            <div class="set-size">
            
            <!-- list of services items -->
            <div class="list-services">
            	<ul>
                    <% AdminSite.Dao.ServiceController controller = new AdminSite.Dao.ServiceController();
                       foreach (AdminSite.Model.Service service in controller.FetchAll())
                       {
                         %>
                	<li>
                    	<div class="image"><img src="../upload/ServicesImages/<%=service.ServiceImage %>" alt="" width="300" height="116"/></div>
                        <h5><img src="../assets/images/ico1.jpg" alt="" /><%=service.ServiceTitle %></h5>
                        <p>
                            <%=service.ServiceDescription %>
                        </p>
                        <%--<ul class="list checked">
                            <li><a href="#">Lorem ipsum dolor</a></li>
                            <li><a href="#">Sit amet consectetuer</a></li>
                            <li><a href="#">Tincidunt ut</a></li>
                            <li><a href="#">Laoreet dolore magna</a></li>
                            <li><a href="#">Erat volutpat</a></li>
                        </ul>     --%>                   
                    </li>
                    <%} %>
                </ul>
                
                <div class="clear"></div>
        </div>
        </div>
        </div>
        <!-- //content -->