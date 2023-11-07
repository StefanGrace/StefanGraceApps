userInput = 1
while not (userInput==0):
    userInput = int(input("Select a Number (0 to Exit): "))
    number = 1
    numberOfFactors = 0
    print (" ")
    print ("List of Factors:")
    while number < (userInput-1):
        number = number + 1
        factorNumber = userInput % number
        if factorNumber == 0:
            factor = True
        else:
            factor = False
        if factor:
            print (str(number))
            numberOfFactors = numberOfFactors + 1         
    print (" ")
    print ("Number of Factors: " + str(numberOfFactors))
    print ("____________________________________")
    print (" ")
    print (" ")
print("Goodby")
exit
