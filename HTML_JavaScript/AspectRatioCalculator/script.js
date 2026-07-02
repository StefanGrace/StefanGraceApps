function isCleanDivison(a, b) {
    return (a / b) % 1 == 0
}

function isEven(a) {
    return a % 2 == 0;
}

function update() {
    var ar;
    var width = document.getElementById("width").value;
    var height = document.getElementById("height").value;
    
    var i = 1;
    var newX = width;
    var newY = height;
    while (i < width && i < height)
    {
        if (isCleanDivison(width, i) && isCleanDivison(height, i))
        {
            newX = width / i;
            newY = height / i;
        }
        i++;
    }
    if (isEven(newX) && isEven(newY))
    {
        newX /= 2;
        newY /= 2;
    }
    x = newX;
    y = newY;
    
    ar = x + ":" + y;
    
    if (x == 0 || y == 0) {
        ar = "";
    }
    if (x == 8 && y == 5) {
        ar = "16:10";
    }
    if (x == 683 && y == 384) {
        ar = "16:9";
        
    }
    if (x % 1 != 0 || y % 1 != 0) {
        ar = "Must enter an integer";
    } 
    
    document.getElementById("aspect-ratio").innerHTML = ar;
};

update();

setInterval(function(){update()}, 100);