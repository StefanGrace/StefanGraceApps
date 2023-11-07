#define script_draw_circle
// Draws a circle with a black 4 pixel outline and a white center in the center of the room
// argument0 is the radius of the circle
draw_circle_color(room_width /2, room_height / 2, argument0, c_black, c_black, false);
draw_circle_color(room_width /2, room_height / 2, argument0 - 4, c_white, c_white, false);
