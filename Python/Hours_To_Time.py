# Hours_To_Time.py
# Stefan Grace
# Python 3.5.2
# Created: 2017-11-06
# Modified: 2017-11-06

# This program takes an amout of time in hours
# and displays it in years, days and hours


def hours_to_time(hours):
    days = hours // 24
    hours %= 24
    years = days // 365
    days %= 365
    display(years, days, hours)

def display(years, days, hours):
    year = "year"
    day = "day"
    hour = "hour"
    if years != 1: year += "s"
    if days != 1: day += "s"
    if hours != 1: hour += "s"
    output = ""
    if len(output) != 0 or years != 0:
        output += str(years) + " " + year + ", " 
    if len(output) != 0 or days != 0:
        output += str(days) + " " + day + ", "
    if len(output) != 0 or hours != 0:
        output += str(hours) + " " + hour
    print(output)
    print()

while True:
    try: hours_to_time(int(input("Enter a number of hours: ")))
    except: None

