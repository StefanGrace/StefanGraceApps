# Prime_List.py
# Stefan Grace
# Created: 2018-01-02
# Modified: 2018-01-02
# This program builds a list of prime numbers up a given number

def is_prime(number):
    if number < 0:
        number *= -1
    if number == 1 or number == 0:
        return False
    for i in range(2, int(number ** 0.5) + 1, 1):
        if number % i == 0:
            return False
    return True

def print_prime_list(number):
    for i in range(number):
        if is_prime(i):
            print(i)

while True:
    try:
        print_prime_list(int(input("Enter a number: ")))
    except:
        print("Please enter an interger")
