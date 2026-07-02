# Prime_Test.py
# Stefan Grace
# Created: 2018-01-02
# Modified: 2018-01-02
# This program tells you if a number is prime or not

def is_prime(number):
    if number < 0:
        number *= -1
    if number == 1 or number == 0:
        return False
    for i in range(2, int(number ** 0.5) + 1, 1):
        if number % i == 0:
            return False
    return True

while True:
    try:
        print(is_prime(int(input("Enter a number: "))))
    except:
        print("Please enter an interger")
