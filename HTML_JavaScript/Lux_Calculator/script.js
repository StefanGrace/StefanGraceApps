function calculateLux() {
    
    // Collect input values
    var fNumber = document.getElementById("aperture").value;
    var shutterUnit = document.getElementById("shutter-unit").value;
    var inputShutterValue = document.getElementById("shutter-speed").value;
    var iso = document.getElementById("iso").value;
    
    // Calculate shutter speed value
    var shutterSpeed;
    switch(shutterUnit){
        case "fraction": shutterSpeed = 1 / inputShutterValue; break;
        case "seconds": shutterSpeed = inputShutterValue; break;
    }
    
    // Calculate lux
    var ev = Math.log2((fNumber ** 2) / shutterSpeed);
    var ev100 = ev - Math.log2(iso / 100);
    var lux = 2.5 * (2 ** ev100);
    
    // Wite output to HTML page with a maximum of 4 decimal places
    document.getElementById("lux").innerHTML = "Lux: " + lux.toLocaleString(undefined, {
        minimumFractionDigits: 0,
        maximumFractionDigits: 4
    });
}

// Make it so that clicking the "Calculate" button calls the calculateLux() function
var calculateButton = document.getElementById("calculate");
calculateButton.addEventListener("click", calculateLux);

// Make it so that pressing Enter calls the calculateLux() function
document.addEventListener("keydown", function(event) {
    if (event.key === "Enter") {
        calculateLux();
    }
});
