# Percent_Chance_Simulator.py
# Stefan Grace
# Created: 2017-10-09
# Modified: 2017-10-09

from random import random

# Set constants
TRIALS = 1000000
CHANCE = 1
OUT_OF = 100

# Main program
times_happend = 0
for i in range(TRIALS):
    happend = 0
    for j in range(OUT_OF):
        number = random() * OUT_OF
        if number < CHANCE:
            happend = 1
    times_happend += happend
    percent = (times_happend / TRIALS) * 100
print("%s out of %s, or %s percent" % (times_happend, TRIALS, percent))
