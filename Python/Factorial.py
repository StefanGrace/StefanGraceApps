# Factorial
# Stefan Grace
# Created: 2017-09-21
# Modified: 2017-09-21

while True:
    try:
        number = int(input("Input a number: "))
        break
    except:
        print("Please enter an interger")
start = number
loop = number
while (loop>2):
    loop -= 1
    number *= loop
if (number==0):
    number = 1
if (number>=0):
    print(start,"Factorial is",number)
else:
    print("You can't factorial a negitive number")
