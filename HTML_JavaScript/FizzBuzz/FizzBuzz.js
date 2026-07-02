// FizzBuzz
// Stefan Grace
// 2017-09-24

for (i = 1; i <= 100; i++)
{
	outputText = "";
	if(i % 3 === 0) {outputText += "Fizz";}
	if(i % 5 === 0) {outputText += "Buzz";}
	if(outputText === "") {output = i;} else {output = outputText;}
	console.log(output);
}