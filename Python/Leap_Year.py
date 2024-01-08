# Leap_Year.py
# Stefan Grace
# Created: 2024-01-09
# Modified: 2024-01-09

def is_leap_year(year):
    if year % 4 == 0:
        if year % 100 == 0:
            return year % 400 == 0
        else:
            return True
    else:
        return False


while True:    
    try:
        year = input("Enter a year: ")
        if year == "":
            break
        word_not = ""
        if not is_leap_year(int(year)):
            word_not = " not"
        print (year + " is" + word_not + " a leap year")
    except:
        print ("Year must be a number")
    print ("")
