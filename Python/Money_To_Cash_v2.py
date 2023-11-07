# Money_To_Cash_v2.py
# Stefan Grace
# Python 3.10.0
# Created: 2017-10-26
# Modified: 2021-12-22

# This program takes an amount of money and tells you what coins and notes
# you would need to make it and gives you a remainder.


def money_to_cash(money):
    
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
        print("Remainder: %sc" % (round(money*100)))

    
money = 1.0
while money > 0:
    try:
        money = float(input("Enter an amount of money (0 to exit): $"))
        money_to_cash(money)
    except:
        print("must be a number")
    print("")
