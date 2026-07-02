log_bases = [1, 0, -1, -10]

import math
print("Real: ")
for base in log_bases:
    print("Log_" + str(base) + "(100) = ", end="")
    try:
        print (math.log(100, base))
    except Exception as e:
        print(e)


import cmath
print()
print("Complex: ")
for base in log_bases:
    print("Log_" + str(base) + "(100) = ", end="")
    try:
        print (cmath.log(100, base))
    except Exception as e:
        print(e)

