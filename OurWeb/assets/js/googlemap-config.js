  function initialize() {
    var myLatlng = new google.maps.LatLng(51.8097, 4.6581);
    var myOptions = {
      zoom: 8,
      center: myLatlng,
      mapTypeId: google.maps.MapTypeId.ROADMAP
    }
    var map = new google.maps.Map(document.getElementById("map_canvas"), myOptions);
	
var contentString = '<div id="mapcontent">'+
    '<div id="siteNotice">'+
    '</div>'+
	<!-- your content goes here -->
    '<h1 id="firstHeading" class="firstHeading">Lorem ipsum</h1>'+
    '<div id="bodyContent">'+
    '<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>' +
    '<p>Nulla sodales ullamcorper sodales. </p>'+
	<!-- //your content -->
    '</div>'+
    '</div>';

var infowindow = new google.maps.InfoWindow({
    content: contentString
});

var marker = new google.maps.Marker({
    position: myLatlng,
    map: map,
    title:"Our location"
});

google.maps.event.addListener(marker, 'click', function() {
  infowindow.open(map,marker);
});
  }
