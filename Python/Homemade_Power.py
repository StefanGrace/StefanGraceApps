# Homemade_Power.py
# Stefan Grace
# Python 3.10.0
# Created: 2022-06-20
# Modified: 2022-06-20

# Homemade power function which uses only multiplication
# Only works with positive integers (and 0)
# Enter negitive number to exit the program


# Homemade power function
def power(num1, num2):
    answer = 1
    for i in range(num2):
        answer = answer * num1
    return answer

# User interface
input1 = 0
input2 = 0
while input1 >= 0 and input2 >= 0:
    try:
        input1 = int(input("Enter first number: "))
        if input1 >= 0 and input2 >= 0:
            input2 = int(input("Enter second number: "))
            if input1 >= 0 and input2 >= 0:
                print(power(input1, input2))
    except:
        print("You must enter an interger")



