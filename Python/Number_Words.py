# Number_Words.py
# Stefan Grace
# Python 3.5.2
# Created: 2017-10-16
# Modified: 2017-10-18


ones = ["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"]
teens = ["ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"]
tens = ["", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"] 

def number_to_word_1000(number):
    word = ""
    ones_digit = number % 10
    tens_digit = (number % 100) // 10
    hundreds_digit = (number % 1000) // 100
    if tens_digit == 1:
        word = teens[ones_digit]
    elif ones_digit != 0 or number == 0:
        word = ones[ones_digit] + word
    if tens_digit >= 2 and ones_digit != 0:
        hyphen = "-"
    else:
        hyphen = ""
    word = tens[tens_digit] + hyphen + word
    if hundreds_digit != 0:
        if ones_digit + tens_digit != 0:
            word = ones[hundreds_digit] + " hundred and " + word
        else:
            word = ones[hundreds_digit] + " hundred"
    return word

def number_to_word(number):
    word = ""
    hundreds_digit = (number % 1000) // 100
    thousands = number // 1000
    word = number_to_word_1000(number)
    if thousands != 0:
        if hundreds_digit == 0:
            and_ = "and "
        else:
            and_ = ""
        if number % 1000 == 0:
            word = number_to_word_1000(thousands) + " thousand"
        else:
            word = number_to_word_1000(thousands) + " thousand " + and_ + word
    return word    

def single_number():
    while True:
        try:
            number = (int(input("Enter a number: ")))
            print(number_to_word(number))
            print("")
            break
        except:
            None

def count_to_number():
    while True:
        try:
            number = (int(input("Enter a number: ")))
            for i in range(number+1):
                print(number_to_word(i))
            print("")
            break
        except:
            None

while True:
    print("0 - Exit")
    print("1 - Select a single number")
    print("2 - Select a number to count to")
    try:
        choice = int(input(""))
        if choice == 0:
            exit()
        if choice == 1:
            single_number()
        if choice == 2:
            count_to_number()
    except:
        None




