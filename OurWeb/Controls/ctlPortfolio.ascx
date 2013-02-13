<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctlPortfolio.ascx.cs" Inherits="OurWeb.Controls.ctlPortfolio" %>
<script type="text/javascript" src="js/jquery.cycle.all.min.js"></script>
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
        	
            <h2>Works</h2> <p>Duis autem vel eum iriure dolor in hendrerit in vulputate</p>
            
            <!-- filters -->
            <div id="filters">
                <ul>
                	<li><strong>Filter in categories:</strong></li>
                    <li><a class="button-normal current" href="#all" rel="all">All</a></li>
					<li><a class="button-normal" href="#webdesign" rel="webdesign">Web design</a></li>
                    <li><a class="button-normal" href="#prints" rel="prints">Print design</a></li>
                    <li><a class="button-normal" href="#branding" rel="branding">Branding</a></li>
                    <li><a class="button-normal" href="#other" rel="other">Other</a></li>
                </ul>
            <div class="clear"></div>                
            </div>
            <!-- //filters -->            
            
        </div>
        <!-- //header -->
        
        <!-- path -->
        <div id="path">
        	
            <strong>You are here:</strong> <a href="#">Home</a> / <a href="#">Works</a>
            
        </div>
        <!-- //path -->
        <!-- content -->
        <div id="content">
        
            
            <!-- all projects list holder -->
            <div class="project-list">
            <div class="page_navigation nav_top float-right"><div></div></div>
            <div class="clear"></div>
            <ul class="list-contents">
            <% OurWeb.Dao.PortfolioController controller = new OurWeb.Dao.PortfolioController();
               foreach (OurWeb.Model.Portfolio portfolio in controller.FetchAll())
               {
                 %>
                <li class="all webdesign">
                            <div class="image"><a href="#" class="more normal"></a><img src="../upload/PortFolios/<%=portfolio.PortfolioImage %>" alt="" class="curved shaded" width="220" height="125"/></div>
                            <div class="data">
                            <h5><%=portfolio.ProjectName%></h5>
                            <small><a href="<%=portfolio.ProjectURL%>" target="_blank"><%=portfolio.ProjectURL%></a></small>
                            <p><%=portfolio.ProjectDescription.Substring(0,20)%></p>
                            
                            </div>
                            
                            <div class="lightbox-work">
                            <a href="#" class="lightbox-close"></a>
                            	
                                <div class="work-slider">	
                                
                                	<ul class="rotate">
                                    	<li><a href="#"><img src="../upload/PortFolios/<%=portfolio.PortfolioImage %>" alt="" width="660" height="375"/></a></li>
                                        <%--<li><a href="#"><img src="../assets/images/works/prev2.jpg" alt="" /></a></li>
                                        <li><a href="#"><img src="../assets/images/works/prev3.jpg" alt="" /></a></li>
                                        <li><a href="#"><img src="../assets/images/works/prev4.jpg" alt="" /></a></li>--%>
                                    </ul>
                                <div class="clear"></div>
                                <div class="controls controls0"></div>
                                </div>
                                
                                <h4><%=portfolio.ProjectName%></h4>
                            <small><a href="<%=portfolio.ProjectURL%>" target="_blank"><%=portfolio.ProjectURL%></a></small>
                            <p><%=portfolio.ProjectDescription%></p>
                            <div class="clear"></div>
                            </div>
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