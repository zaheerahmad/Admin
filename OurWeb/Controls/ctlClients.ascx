<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctlClients.ascx.cs" Inherits="OurWeb.Controls.ctlClients" %>
<script type="text/javascript">
    $(document).ready(function () {
        $(".rotate").each(
	function (intIndex) {
	    $(this).cycle({
	        fx: 'fade',
	        speed: 300,
	        timeout: 0,
	        pager: ".controls" + intIndex
	    });
	});
    });
</script>
<script type="text/javascript">
    var external_pajinate_items_number = 12;
</script>
<script type="text/javascript" src="../assets/js/jquery.pajinate.js"></script>
<script type="text/javascript" src="../assets/js/jquery-workarounds.js"></script>
<script type="text/javascript">
    $(document).ready(function () {
        $('.project-list').pajinate({ items_per_page: external_pajinate_items_number });
    });
</script>
<!-- header -->
        <div id="header">
        	
            <a href="Home.aspx?ctl=3" class="button small float-right">Get in touch</a>
            <a href="Home.aspx?ctl=1" class="button blue float-right">Check our works</a>
            
            <h2>Clients</h2> <p>Duis autem vel eum iriure dolor in hendrerit in vulputate</p>
            
        </div>
        <!-- //header -->
        
        <!-- path -->
        <div id="path">
        	
            <strong>You are here:</strong> <a href="Home.aspx?ctl=0">Home</a> / <a href="Home.aspx?ctl=4">Clients</a>
            
        </div>
        <!-- //path -->
                
        <!-- content -->
        <div id="content">
         
            <!-- all projects list holder -->
            <div class="project-list">
            <div class="page_navigation nav_top float-right"><div></div></div>
            <div class="clear"></div>
            <ul class="list-contents">
                    <% OurWeb.Dao.ClientController controller = new OurWeb.Dao.ClientController();
                       foreach (OurWeb.Model.Client client in controller.FetchAll())
                       {
                         %>
                	<li>
                    	<div class="image"><img src="../upload/ClientLogos/<%=client.ClientLogo %>" alt="" class="curved shaded" width="200" height="125"/></div>
                        <h5><a href="<%=client.ClientURL %>" target="_blank"><%=client.ClientName%></a></h5>
                        <%--<p>
                            <%=c%>
                        </p>--%>
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
            <div class="page_navigation nav_bottom float-right"><div></div></div>	
            <div class="clear"></div>    
            </div>
            <!-- //all projects list holder -->

            
            <div class="clear"></div>
        </div>
        <!-- //content -->