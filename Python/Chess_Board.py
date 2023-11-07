# Chess Board 

# Stefan Grace

# 22/03/2015

SQUARES = int(input("How many times do you want to double 1? "))
squareNumber = 1
number = 1
while squareNumber <= SQUARES:
    print("Square :",squareNumber,", Grains :",number)
    number = number * 2
    squareNumber = squareNumber + 1
