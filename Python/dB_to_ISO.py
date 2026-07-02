# dB_to_ISO.py
# Stefan Grace
# Created: 2025-05-17
# Modified: 2025-05-17
# Converts camera gain (dB) to camera ISO (assuming 0 dB = ISO 100)

while (True):
    user_input = input("Enter dB: ")
    if (user_input == ""):
        break
    try:
        dB = float(user_input)
        iso = 100 * (2 ** (dB / 6))
        print("ISO " +  str(int(iso)))
    except:
        print("dB must be a number")
    print("")
        


