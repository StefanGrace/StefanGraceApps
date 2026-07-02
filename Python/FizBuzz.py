# FizzBuzz.py
# Stefan Grace
# 2017-08-01

i = 1
while (i<=100):
    if (i%3==0):
        if (i%5==0):
            print ("FizzBuzz")
        else:
            print ("Fiz")
    elif (i%5==0):
        print ("Buzz")
    else:
        print (i)
    i += 1
