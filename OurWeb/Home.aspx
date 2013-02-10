<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="OurWeb.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphRotator" runat="server">
    <div class="nivo">
        <div id="slider-wrapper">
            <div id="slider" class="nivoSlider">
				<img src="assets/nivo-slider/demo/images/img14.jpg" alt="" />
                <img src="assets/nivo-slider/demo/images/img15.jpg" alt="" title="#img3" />
                <img src="assets/nivo-slider/demo/images/img16.jpg" alt="" title="#img5" />
                <img src="assets/nivo-slider/demo/images/img17.jpg" alt="" />
            </div>
            <div id="img3" class="nivo-html-caption">
                <strong>This</strong> is an example of a <em>HTML</em> caption with <a href="#">a link</a>.
            </div>                            
            <div id="img5" class="nivo-html-caption">
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi molestie elementum turpis, non lobortis lorem bibendum non. Sed hendrerit velit et dolor commodo euaccumsan diam fermentum. <br /><br />Donec est augue, tristique in imperdiet a, suscipit id ipsum. Donec porta, risus non hendrerit vestibulum, augue risus aliquam enim, in tincidunt arcu ligula sit amet orci. In hac habitasse platea dictumst. Curabitur eros lorem, commodo at consequat ut, adipiscing at felis.
            </div>         
        </div>                        
      </div>
    <div class="clear"></div> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
</asp:Content>
