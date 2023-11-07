// Stefan Grace
// 2017-12-31

var leadingZero = function(x) {
	if (x < 10){
		return ("0" + String(x))
	} else {
		return (String(x))
	}
};

var update = function() {
	var d = new Date();
	document.getElementById("datetime").innerHTML = String(d.getFullYear()) + "-" + leadingZero(d.getMonth() + 1) + "-" + leadingZero(d.getDate()) + " " 
	+ leadingZero(d.getHours()) + ":" + leadingZero(d.getMinutes()) + ":" + leadingZero(d.getSeconds()) /*+ "." + String(Math.floor(d.getMilliseconds()/100))*/;
};

update();

setInterval(function(){update()}, 100);
