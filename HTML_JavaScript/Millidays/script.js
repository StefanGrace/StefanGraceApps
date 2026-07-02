function getDayProgress() {
    var time = new Date();
    return (time.getHours() / 24) + (time.getMinutes() / 1440) + (time.getSeconds() / 86_400) + (time.getMilliseconds() / 86_400_000);
}

function updateOutput() {
    var outputText = (getDayProgress() * 1000).toFixed(2).padStart(6, '0');
    document.getElementById("clock").innerHTML = outputText;
    document.title = outputText;
}

updateOutput();
setInterval(updateOutput, 50);