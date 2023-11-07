# Pixel_Density_Calculator.py
# Stefan Grace
# Python 3.6.3
# Created: 2018-04-17
# Modified: 2018-04-17

# This program takes the diagonal screen size in inches and the resolution
# and calculates the pixel density in pixels per inch 


# Get input from user
size = float(input("Enter diagonal screen size in inches: "))
width = float(input("Enter Horizontal Resolution: "))
height = float(input("Enter Vertical Resolution: "))

# Calculate pixel density 
ppi = (((width ** 2) + (height ** 2)) ** 0.5) / size

# Display output
print("Pixel density is %s pixles per inch" % (ppi))
