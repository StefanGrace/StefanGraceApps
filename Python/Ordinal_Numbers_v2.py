# Ordinal_Numbers_v2.py
# Stefan Grace
# Created: 2017-09-04
# Modified: 2022-12-16
# This program prints the ordinal numbers within a user-specified range


# Collect user input
start = -1
while start < 0:
    try:
        start = int(input("Enter start number: "))
        if (start < 0):
            print("Can't be negative")
    except:
        print("Must an integer")
end = start - 1
while end < start:
    try:
        end = int(input("Enter end number: "))
        if (end < start):
            print ("End number can't be smaller than start number")
    except:
        print("Must an integer")
        
# Print ordinal numbers
for i in range(start, end + 1):
    ordinal = "th" # default
    if ((i % 100) // 10 != 1): # if the penultimate digit is not 1
        if(i % 10 == 1): # if the last digit is 1 
            ordinal = "st"
        if(i % 10 == 2): # if the last digit is 2 
            ordinal = "nd"
        if(i % 10 == 3): # if the last digit is 3 
            ordinal = "rd"
    print(str(i) + ordinal)
    
