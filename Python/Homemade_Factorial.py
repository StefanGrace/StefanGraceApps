# Homemade_Factorial.py
# Stefan Grace
# Created: 2022-07-31
# Modified: 2022-07-31

number = int(input("Enter number: "))
result = 1

while (number > 1):
    result *= number
    number -= 1

print(result)
