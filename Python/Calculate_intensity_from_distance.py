def calculate_intensity(distance, dimensions):
    return 1 / (distance ** (dimensions - 1))

distance = float(input("Distance: "))
dimensions = int(input("Dimensions: "))

print(calculate_intensity(distance, dimensions))
