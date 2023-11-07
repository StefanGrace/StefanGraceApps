#define script_draw
draw_set_font(font);
draw_set_halign(fa_center);
draw_set_valign(fa_middle);
draw_set_circle_precision(240);
draw_set_color(c_black);

// Draw clock
draw_circle_color(room_width /2, room_height / 2, 290, c_white, c_white, false);

// Draw outer circle
script_draw_circle(240);

// Draw inner circle
script_draw_circle(160);

// Draw tick marks
var i;
for (i = 0; i < 60; i += 1) 
{
    script_angle_to_location(i / 60, 230);
    var tick_x;
    var tick_y;
    tick_x = pos_x;
    tick_y = pos_y
    script_angle_to_location(i / 60, 250);
    draw_line_width(tick_x, tick_y, pos_x, pos_y, 2);
}

// Draw hour numbers
var i;
for (i = 0; i < 24; i += 1) 
{
    script_angle_to_location(i / 24, 180);
    draw_text(pos_x, pos_y, script_zero_pad(i));
}

// Draw minute numbers
var i;
for (i = 0; i < 60; i += 5) 
{
    script_angle_to_location(i / 60, 260);
    draw_text(pos_x, pos_y, script_zero_pad(i));
}

// Draw hour hand
script_angle_to_location((current_hour + ((current_minute + (current_second / 60 )) / 60 )) / 24, 150);
draw_line_width(room_width /2, room_height /2, pos_x, pos_y, 6);

// Draw minute hand
script_angle_to_location((current_minute + (current_second / 60 )) / 60, 230);
draw_line_width(room_width /2, room_height /2, pos_x, pos_y, 4);

// Draw second hand
script_angle_to_location(current_second / 60, 230);
draw_line_width_color(room_width /2, room_height /2, pos_x, pos_y, 2, c_red, c_red);
