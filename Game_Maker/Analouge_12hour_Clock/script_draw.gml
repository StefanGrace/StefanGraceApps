#define script_draw
draw_set_font(font);
draw_set_halign(fa_center);
draw_set_valign(fa_middle);
draw_set_circle_precision(240);
draw_set_color(c_black);

// Draw clock
draw_circle_color(room_width /2, room_height / 2, 290, c_white, c_white, false);

// Draw circle
script_draw_circle(260);

// Draw tick marks
var i;
for (i = 0; i < 60; i += 1) 
{
    script_angle_to_location(i / 60, 250);
    var tick_x;
    var tick_y;
    tick_x = pos_x;
    tick_y = pos_y
    script_angle_to_location(i / 60, 270);
    var line_thickness;
    if (i mod 5 == 0) {line_thickness = 6;} else {line_thickness = 2;}
    draw_line_width(tick_x, tick_y, pos_x, pos_y, line_thickness);
}

// Draw hour numbers
var i;
for (i = 1; i <= 12; i += 1) 
{
    script_angle_to_location(i / 12, 220);
    draw_text(pos_x, pos_y, i);
}

// Draw hour hand
script_angle_to_location(((current_hour mod 12) + ((current_minute + (current_second / 60 )) / 60 )) / 12, 170);
draw_line_width(room_width /2, room_height /2, pos_x, pos_y, 6);

// Draw minute hand
script_angle_to_location((current_minute + (current_second / 60 )) / 60, 250);
draw_line_width(room_width /2, room_height /2, pos_x, pos_y, 4);

// Draw second hand
script_angle_to_location(current_second / 60, 250);
draw_line_width_color(room_width /2, room_height /2, pos_x, pos_y, 2, c_red, c_red);
