// Stefan Grace
// 2018-04-18

var update = function () {
	var ppi;
	var screenSize = document.getElementById("screen-size").value;
	var width = document.getElementById("width").value;
	var height = document.getElementById("height").value;
	if (parseFloat(screenSize) === 0 || parseFloat(width) === 0 || parseFloat(height) === 0) {
		ppi = "";
	} else {
		ppi = String(Math.round(Math.sqrt(Math.pow(width, 2) + Math.pow(height, 2)) / screenSize)) + " PPI";
	}
	document.getElementById("ppi").innerHTML = ppi;
};

update();

setInterval(function(){update()}, 500);

