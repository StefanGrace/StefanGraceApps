# Homemade_Log.py
# Stefan Grace
# Created: 2023-03-29
# Modified: 2023-03-29

def log(x, base):
    i = 0
    while (x != 1):
        if (x > 1):
            x /= base
            i += 1
        else:
            x *= base
            i -= 1
    return i

x = float(input("Enter number: "))
base = float(input("Enter base: "))
print(log(x, base))
