# Digit_Sum.py
# Stefan Grace
# Created: 2017-10-02
# Modified: 2017-10-02
# This program takes a numbers as an input and outputs the sum of it's digits

def digit_sum(x):
    digits_to_check = 100
    digits = []
    for i in range(digits_to_check):
        digits.append(0)
    j = 1
    k = 0
    total = 0
    while j < 10 ** digits_to_check:
        digits[k] = ((x % (j * 10)) - (x % j)) / j
        j *= 10
        k += 1
    for i in range(0,digits_to_check):
        total += digits[i]
    return total
while True:
    print (int(digit_sum(int(input("Input a Number: ")))))
