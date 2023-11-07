#Ordinal_Numbers.py
#Stefan Garce
#Created: 2017-09-04
#Modified: 2017-09-04
#This program prints the ordinal numbers 1 to 1000


NUMBER = 1000

for i in range(1,NUMBER+1):
    ordinal = "th"
    if ((i%100)//10!=1):
        if(i%10==1):
            ordinal = "st"
        if(i%10==2):
            ordinal = "nd"
        if(i%10==3):
            ordinal = "rd"
    print(str(i)+ordinal)
    
