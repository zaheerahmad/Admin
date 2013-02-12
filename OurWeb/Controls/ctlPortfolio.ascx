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
<script type="text/javascript" src="js/jquery.pajinate.js"></script>
<script type="text/javascript" src="js/jquery-workarounds.js"></script>
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
                        <li class="all webdesign">
                            <% OurWeb.Dao.PortfolioController portfolioController = new OurWeb.Dao.PortfolioController();
                               foreach (OurWeb.Model.Portfolio portfolio in portfolioController.FetchAll())
                               {
                                 %>
                            <div class="image">
                                <a href="#" class="more normal"></a>
                                <img src="upload/PortFolios/<%=portfolio.PortfolioImage %>" alt="" class="curved shaded" />
                             </div>
                            <div class="data">
                            <h5><%=portfolio.ProjectName%></h5>
                            <small><%=portfolio.ProjectURL%></small><br />
                            <p><%=portfolio.ProjectDescription%></p>
                            </div>
                            
                            <div class="lightbox-work">
                            <a href="#" class="lightbox-close"></a>
                            	
                                <div class="work-slider">	
                                
                                	<ul class="rotate">
                                    	<li><a href="#"><img src="images/works/prev1.jpg" alt="" /></a></li>
                                        <li><a href="#"><img src="images/works/prev2.jpg" alt="" /></a></li>
                                        <li><a href="#"><img src="images/works/prev3.jpg" alt="" /></a></li>
                                        <li><a href="#"><img src="images/works/prev4.jpg" alt="" /></a></li>
                                    </ul>
                                <div class="clear"></div>
                                <div class="controls controls0"></div>
                                </div>
                                
                                <h4>Giant Mutant Birds</h4>
                                <small>Web design / print</small>
                                <p>
Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi.
                                </p>
                            <div class="clear"></div>
                            </div>
                            <%} %>
                        </li>
                    </ul>
                    <div class="clear"></div>
                <div class="page_navigation nav_bottom float-right"><div></div></div>	
                <div class="clear"></div>    
                </div>
                <!-- //all projects list holder -->

            
            <div class="clear"></div>
            
        </div>
        <!-- //content -->