#FizzBuzz_Example
#Stefan Grace
#2017-08-25

for i in range(1,101):
    output_text=""
    if(i%3==0):
        output_text+="Fizz"
    if(i%5==0):
        output_text+="Buzz"
    if(len(output_text)==0):
        output=i
    else:
        output=output_text
    print(output)
        
