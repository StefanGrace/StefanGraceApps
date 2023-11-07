#define script_angle_to_location
// Convert distance round circle (0 - 1) to radians
var radins;
radins = argument0 * 2 * pi;

// Convert angle (radians) to x and y (0 being the center of the circle)
pos_x = sin(radins) * argument1;
pos_y = cos(radins) * argument1 * -1;

// Change the center from being 0 to being the center of the room
pos_x += room_width / 2;
pos_y += room_height / 2;
