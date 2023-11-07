# Seconds_To_Time.py
# Stefan Grace
# Python 3.5.2
# Created: 2017-11-06
# Modified: 2017-11-06

# This program takes an amout of time in seconds and
# displays it in years, days, hours, minutes and seconds


def seconds_to_time(seconds):
    minutes = seconds // 60
    seconds %= 60
    hours = minutes // 60
    minutes %= 60
    days = hours // 24
    hours %= 24
    years = days // 365
    days %= 365
    display(years, days, hours, minutes, seconds)

def display(years, days, hours, minutes, seconds):
    year = "year"
    day = "day"
    hour = "hour"
    minute = "minute"
    second = "second"
    if years != 1: year += "s"
    if days != 1: day += "s"
    if hours != 1: hour += "s"
    if minutes != 1: minute += "s"
    if seconds != 1: second += "s"
    output = ""
    if len(output) != 0 or years != 0:
        output += str(years) + " " + year + ", " 
    if len(output) != 0 or days != 0:
        output += str(days) + " " + day + ", "
    if len(output) != 0 or hours != 0:
        output += str(hours) + " " + hour + ", "
    if len(output) != 0 or minutes != 0:
        output += str(minutes) + " " + minute + ", "
    if len(output) != 0 or seconds != 0:
        output += str(seconds) + " " + second
    print(output)
    print()

while True:
    try: seconds_to_time(int(input("Enter a number of seconds: ")))
    except: None

