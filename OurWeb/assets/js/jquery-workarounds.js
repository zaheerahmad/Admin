function simple_tooltip(target_items, name){
 $(target_items).each(function(i){
		$("body").append("<div class='"+name+"' id='"+name+i+"'>"+$(this).attr('title')+"</div>");
		var my_tooltip = $("#"+name+i);

		if($(this).attr("title") != "" && $(this).attr("title") != "undefined" ){

		$(this).removeAttr("title").mouseover(function(){
					my_tooltip.css({display:"none"}).fadeIn(400);
		}).mousemove(function(kmouse){
				var border_top = $(window).scrollTop();
				var border_right = $(window).width();
				var left_pos;
				var top_pos;
				var offset = -8;
				if(border_right - (offset *2) >= my_tooltip.width() + kmouse.pageX){
					left_pos = kmouse.pageX+offset-25;
					} else{
					left_pos = border_right-my_tooltip.width()-offset-25;
					}

				if(border_top + (offset *2)>= kmouse.pageY - my_tooltip.height()){
					top_pos = border_top +offset;
					} else{
					top_pos = kmouse.pageY-my_tooltip.height()+(offset*2);
					}

				my_tooltip.css({left:left_pos, top:top_pos});
		}).mouseout(function(){
				my_tooltip.css({left:"-9999px"});
		});

		}

	});
}

$(document).ready(function () {
							
$(".list-services ul li:nth-child(3n)").addClass("removed");
$(".list-items ul li:nth-child(4n)").addClass("removed");
$(".sub-menu ul li ul li:last-child a").addClass("last-child");
$(".sub-menu ul li:last-child a").addClass("last-child");
$(".new ul li:last-child").addClass("last-child");
$(".list.bordered li:last-child").addClass("last-child");




simple_tooltip(".tooltip","tooltip-cloud");	

/* top menu */
$("#top-menu > .main > li").mouseenter(function() {
	$(this).addClass("current-dynamic");
	$(this).find(".sub").animate({
								 height: "show"
								 },100);
	return false;
}).mouseleave(function(){
	$(this).removeClass("current-dynamic");
	$(this).find(".sub").animate({
								 height: "hide"
								 },100);
	return false;
	});
/* -- */

/* sub menu */
$(".sub-menu > ul > li > a").click(function(){
$(this).parent().parent().find("ul").animate({
		height: "hide"
		},200);

		$(this).parent().parent().find("li").removeClass("current");
		
$(this).parent().find("ul").animate({
		height: "toggle"
		},200);

		$(this).parent().has("ul").addClass("current");
return false;
});
/* -- */

/* scroll menu */
$('.scrollmenu a').click(function() {
	var curList = $(".scrollmenu li a.current").attr("rel");
	var listID = $(this).attr("rel");
	if (listID != curList) {
		$("#"+curList).fadeOut(150, function() {
			$("#"+listID).fadeIn(150);
		});
	} 
	var ul = $(this).closest('ul'),
	len = ul.children().length,
	ix = $(this).parent().index(),
	c = 'selected',
	h = $(this).outerHeight();
	
	if ( $(".scrollmenu").hasClass("non-scrollable") )
	{	

	} else {
		ix = ix < 2 ? 2 : ix > len - 3 ? len - 3 : ix;
		ul.animate({'marginTop': (2 - ix) * h});	
	}

	$(this).addClass('selected current').parent().siblings().children('.' + c).removeClass();
							
								  
});
/* -- */

/* tabs */
$(".tabs .nav li a").click(function(){
	var curList = $(".tabs .nav li a.current").attr("rel");
	var curListHeight = $(".tabs .cnt").height();
	$(".tabs .nav li a").removeClass("current");
	$(this).addClass("current");
	var listID = $(this).attr("rel");
	if (listID != curList) {
		$("#"+curList).fadeOut(0, function() {
			$("#"+listID).fadeIn();
			var newHeight = $("#"+listID).height();
		});
	}        
	return false;
});


/* -- */

/* toggles */
$(".toggles > ul > li > a").click(function(){
	if($(this).hasClass("current")){
	$(this).parent().find("p").slideUp("normal");
	$(this).removeClass("current");
	}
	else {
	$(this).parent().find("p").slideDown("normal");
	$(this).addClass("current");
	}
	return false;
});


/* -- */

/* portfolio filtering & pagination usage, pagination plugin is also in js/jquery.paginate.js */
var activeFiltersList = $("#filters ul li a").text();
var filterDefault = document.location.hash.replace("#","");

// checking each element in filters list, and if they match then add class current so they can be highlighted on page load
if (filterDefault) {
	$("#filters ul li a").each(function() {
		if($(this).attr("rel") == filterDefault) {
						 $(this).addClass("current");
		}
	});
}

// checking each element in project list, and if they match with the filter, if yes then show them
if (filterDefault) {
$(".project-list .list-contents li").each(function() {
	if(!$(this).hasClass(filterDefault)) {
		$(this).hide();
	}
	else {
		$(this).show();
	}
});
}
else {
	var filterDefault = "all";
}


// filter choosen elements
$("#filters ul li a").click(function() {
	
	
	$("#filters ul li a.current").removeClass("current");
	$(this).addClass("current");
	
	var filterBy = $(this).attr("href").replace("#","");

	
	$(".project-list").hide().fadeIn(400);
	$(".project-list > ul > li").each(function() {
		if(!$(this).hasClass(filterBy)) {
			$(this).hide();
		}
		else {
			$(this).fadeIn(400);
		}
		
	});
	
	
	var items_size = $(".project-list ul li:visible").size();
	if(items_size < external_pajinate_items_number)
	{
		$(".page_navigation").hide();
	}
	else {
		$(".page_navigation").show();
	}
	
	$('.project-list').pajinate({items_per_page : external_pajinate_items_number});

return false;
});

$(".project-list ul li .image a.more").click(function(){
	$("#lightbox").css("filter", "alpha(opacity=90)");
	$("#lightbox").fadeIn(300);
	$(this).parent().parent().find(".lightbox-work").fadeIn(300);
	})
	$("#lightbox, .lightbox-close").click(function(){
		$("#lightbox, .lightbox-work").fadeOut(300);
});
/* -- */


/* login box */
$("#login-box").click(function(){
	$("#lightbox").css("filter", "alpha(opacity=90)");
	$("#lightbox, #loginbox-panel").fadeIn(300);
	})
	$("#lightbox, #lightbox-close").click(function(){
		$("#lightbox, #loginbox-panel").fadeOut(300);
});
/* -- */

/* autoclear function for inputs */
$('.autoclear').click(function() {
if (this.value == this.defaultValue) {
this.value = '';
}
});
$('.autoclear').blur(function() {
if (this.value == '') {
this.value = this.defaultValue;
}
});

$('.gotop').click(function(){
	$('html, body').animate({scrollTop:0}, 'slow');
	return false;
});

});

