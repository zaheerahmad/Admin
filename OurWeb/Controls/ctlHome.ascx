﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctlHome.ascx.cs" Inherits="OurWeb.Controls.ctlHome" %>
<!-- rotator -->
<div id="rotator">
   <div class="nivo">
    <% AdminSite.Dao.ServiceController serviceController = new AdminSite.Dao.ServiceController();%>
        <div id="slider-wrapper">
            <div id="slider" class="nivoSlider">
                <%
                   foreach (AdminSite.Model.Service service in serviceController.FetchAll())
                   {
                     %>
				        <img src="upload/ServicesImages/<%=service.ServiceImage %>" alt="" title="#<%=service.ServiceId %>" width="654" height="356"/>
                <%} %>
            </div>
            <%
              foreach (AdminSite.Model.Service service in serviceController.FetchAll())
              { 
                  
                  %>
                  <div id="<%=service.ServiceId %>" class="nivo-html-caption">
                    <strong><%=service.ServiceTitle %></strong> <%=service.ServiceDescription %>
                </div>

                  <%}%>
        </div>                        
      </div>
    <div class="clear"></div> 
</div>
<!-- //rotator -->
<!-- content -->
<div id="content">
    <!-- //set size -->
            
            <div class="separator"></div>
            
            <!-- set size -->
            <div class="set-size">
            
            <!-- testimonials -->
            <div id="testimonials" class="float-left">
            	<h5>News</h5>
                <ul>
                <% AdminSite.Dao.NewsController newsController = new AdminSite.Dao.NewsController();
                   foreach (AdminSite.Model.News news in newsController.FetchAll())
                   {
                   %>
                   
                   <li>
                    	<div class="text curved shaded">
                        	<strong><%=news.NewsTitle %></strong><br /><p><%=news.NewsDescription %></p>
                        <div class="clear"></div>
                        </div>
                        
                        <%--<div class="author">Steve Jobs, Apple</div>--%>
                    </li>

                   <%
                   }
                     %>
                     </ul>
            </div>
            <!-- //testimonials -->
            
            <!-- newsletter -->
            <div id="newsletter" class="float-right">
            	<h5>Newsletter</h5>
                <small>Duis autem vel eum iriure dolor in</small>
                <p>
                Souvlaki ignitus carborundum e pluribus unum. Defacto lingo est igpay atinlay. Marquee selectus non provisio incongruous feline nolo contendre. 
                </p>
                <form action="#">
                
                	<fieldset>
                    	
                        <input type="text" value="enter your e-mail here..." class="input-text autoclear" /><input type="submit" value="" class="input-submit" />
                        
                    </fieldset>
                
                </form>
                <p>
                Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit. lobortis 
                </p>
            </div>
            <!-- //newsletter -->
            
            </div>
            <!-- //set size -->
            
            <div class="clear"></div>
</div>
<!-- //content -->