<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="OurWeb.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphRotator" runat="server">
    <div class="nivo">
    <% AdminSite.Dao.ServiceController serviceController = new AdminSite.Dao.ServiceController();%>
        <div id="slider-wrapper">
            <div id="slider" class="nivoSlider">
                <%
                   foreach (AdminSite.Model.Service service in serviceController.FetchAll())
                   {
                     %>
				        <img src="upload/ServicesImages/<%=service.ServiceImage %>" alt="" title="#<%=service.ServiceId %>" width="750" height="400"/>
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
<!-- //set size -->
            
            <div class="separator"></div>
            
            <!-- set size -->
            <div class="set-size">
            
            <!-- testimonials -->
            <div id="testimonials" class="float-left">
            	<h5>Testimonials</h5>
                <small>Lorem ipsum dolor sit ame</small>
            	<ul>
                	<li>
                    	<div class="text curved shaded">
                        	<p>Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliqup ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate</p>
                        <div class="clear"></div>
                        </div>
                        
                        <div class="author">Steve Jobs, Apple</div>
                    </li>
                	<li>
                    	<div class="text curved shaded">
                        	<p>Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliqup ex ea commodo consequat.</p>
                        <div class="clear"></div>
                        </div>
                        
                        <div class="author">Steve Jobs, Apple</div>
                    </li>
                	<li>
                    	<div class="text curved shaded">
                        	<p>Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliqup ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate</p>
                        <div class="clear"></div>
                        </div>
                        
                        <div class="author">Bill Gates, Microsoft</div>
                    </li>                                        
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
</asp:Content>
