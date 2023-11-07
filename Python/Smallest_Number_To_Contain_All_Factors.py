# Smallest_Number_To_Contain_All_Factors.py
# Stefan Grace
# Created: 2020-05-24
# Modified: 2020-05-24
# This program finds the smallest number to contain all factors upto a given number


def getNumber(input):
    hasAllFactors = False
    i = 0
    while not(hasAllFactors):
        i += 1
        hasAllFactors = True
        j = input
        while j > 0:
            test = (i / j) % 1
            if (i / j) % 1 != 0:
                hasAllFactors = False
            j -= 1
    return i

while True:
    try:
        print(getNumber(int(input())))
    except:
        print("Input Error!")
