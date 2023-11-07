$(document).ready(function() {

	//Advanced JS Feature 1: Date Picker
	$("#advanced-js-1").datepicker({
		changeMonth: true,
		changeYear: true,
		dateFormat: "yy-mm-dd",
		numberOfMonths: 1
	});
	
	//Advanced JS Feature 2: Drag and Drop
	$('#phone-draggable').draggable();
	$('#drop-target').droppable({
		drop: function(event, ui) {
			$('#drop-message').html("You have dragged the phone into the box.");
		}
	});
	
	//Advanced JS Feature 4: Geo Location
	$('#advanced-js-4').click(function(){
		if (navigator.geolocation) {
			navigator.geolocation.getCurrentPosition(function(position){
				console.log(position.coords.latitude );
				$('#geo-location').html("Latitude: " + position.coords.latitude + "<br>Longitude: " + position.coords.longitude);
			});
		} else {
			$('#geo-location').html("Geolocation is not supported by this browser.");
		}
	});
	
	//Advanced JS Feature 5: Animation
	$('#move-right').click(function(){
		$('#advanced-js-5').animate({'left':'20%'});
	});
	$('#move-left').click(function(){
		$('#advanced-js-5').animate({'left':'0px'});
	});
	$('#expand').click(function(){
		$('#advanced-js-5').animate({'width':'225px', 'height':'150px'});
	});
	$('#shrink').click(function(){
		$('#advanced-js-5').animate({'width':'150px', 'height':'100px'});
	});
	
});