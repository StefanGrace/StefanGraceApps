# Power.py
# Stefan Grace
# Python 3.7.3
# Created: 2020-05-11
# Modified: 2020-05-11

# Homemade power function which uses homemade
# multiplication function which uses only addition,
# only works with positive integers (and 0)


def multiply(num1, num2):
    answer = 0
    for i in range(num2):
        answer = answer + num1
    return answer

def power(num1, num2):
    answer = 1
    for i in range(num2):
        answer = multiply(answer, num1)
    return answer

try:
    input1 = int(input("Enter first number: "))
    input2 = int(input("Enter second number: "))
    print(power(input1, input2))
except:
    print("You must enter an interger")



