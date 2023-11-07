# Money_To_Cash.py
# Stefan Grace
# Python 3.5.2
# Created: 2017-10-26
# Modified: 2017-10-26

# This program takes an amount of money and tells you what coins and notes
# you would need to make it and gives you a remainder.

money = float(input("Enter an amount of money: $"))

dollar = [{100:0}, {50:0}, {20:0},
          {10:0}, {5:0}, {2:0},
          {1:0}, {0.5:0}, {0.2:0}, {0.1:0}]

for i in dollar:
    for j in i:
        while money + 0.0000001 >= j:
            i[j] += 1
            money -= j
        if i[j] != 0:
            if j >= 5:
                word = "note"
            else:
                word = "coin"
            if i[j] > 1:
                word = word + "s"
            if j >= 1:
                print("%s $%s %s" % (i[j], j, word))
            else:
                print("%s %sc %s" % (i[j], int(j*100), word))

if money > 0:
    print("Remaineder: %sc" % (round(money*100)))

    
