#define script_draw
if (on) {
    draw_sprite(sprite_switch, 0, 166, 79);
} else {
    draw_sprite(sprite_switch, 0, 106, 79);
}

switch (mode) {
    case "solid": draw_sprite(sprite_switch, 0, 15, 428); break;
    case "pulse": draw_sprite(sprite_switch, 0, 15, 482); break;
    case "cycle": draw_sprite(sprite_switch, 0, 15, 538); break;
}

switch (speed_mode) {
    case "slow": draw_sprite(sprite_switch, 0, 124, 428); break;
    case "med": draw_sprite(sprite_switch, 0, 124, 482); break;
    case "fast": draw_sprite(sprite_switch, 0, 124, 538); break;
}

switch (transition) {
    case "cut": draw_sprite(sprite_switch, 0, 233, 428); break;
    case "fast_fade": draw_sprite(sprite_switch, 0, 233, 482); break;
    case "slow_fade": draw_sprite(sprite_switch, 0, 233, 538); break;
}

draw_sprite_ext(sprite_lights_pink, 0, 0, 0, 1, 1, 0, c_white, lights_pink);
draw_sprite_ext(sprite_lights_orange, 0, 0, 0, 1, 1, 0, c_white, lights_orange);
draw_sprite_ext(sprite_lights_green, 0, 0, 0, 1, 1, 0, c_white, lights_green);
draw_sprite_ext(sprite_lights_cyan, 0, 0, 0, 1, 1, 0, c_white, lights_cyan);

#define script_click
// POWER SWITCH
// off
if (mouse_x > 101 && mouse_x < 152 && mouse_y > 73 && mouse_y < 115) {
    on = false;
// on
} else if (mouse_x > 114 && mouse_x < 202 && mouse_y > 73 && mouse_y < 115) {
    on = true;
    clock = 0;

// MODE SWITCH
// solid
} else if (mouse_x > 9 && mouse_x < 50 && mouse_y > 423 && mouse_y < 471) {
    mode = "solid";
// pulse
} else if (mouse_x > 9 && mouse_x < 50 && mouse_y > 470 && mouse_y < 525) {
    mode = "pulse";
    clock = 0;
// cycle
} else if (mouse_x > 9 && mouse_x < 50 && mouse_y > 524 && mouse_y < 574) {
    mode = "cycle";
    clock = 0;

// SPEED SWITCH
// slow
} else if (mouse_x > 118 && mouse_x < 159 && mouse_y > 423 && mouse_y < 471) {
    speed_mode = "slow";
    clock = 0;
// med
} else if (mouse_x > 118 && mouse_x < 159 && mouse_y > 470 && mouse_y < 525) {
    speed_mode = "med";
    clock = 0;
// fast
} else if (mouse_x > 118 && mouse_x < 159 && mouse_y > 524 && mouse_y < 574) {
    speed_mode = "fast";
    clock = 0;

// TRANSITION SWITCH
// cut
} else if (mouse_x > 227 && mouse_x < 269 && mouse_y > 423 && mouse_y < 471) {
    transition = "cut";
    clock = 0;
// fast fade
} else if (mouse_x > 227 && mouse_x < 269 && mouse_y > 470 && mouse_y < 525) {
    transition = "fast_fade";
    clock = 0;
// slow fade
} else if (mouse_x > 227 && mouse_x < 269 && mouse_y > 524 && mouse_y < 574) {
    transition = "slow_fade";
    clock = 0;
}

#define script_step
if (!on) {
    lights_pink = 0.0;
    lights_orange = 0.0;
    lights_green = 0.0;
    lights_cyan = 0.0;
} else {
    switch (mode) {
        case "solid":
            lights_pink = 1.0;
            lights_orange = 1.0;
            lights_green = 1.0;
            lights_cyan = 1.0;
            break;
        case "pulse":
            switch (speed_mode) {
                case "slow":
                    if (floor(clock / 60) mod 2 == 1) {
                        script_change_lights(0, 0, 0, 0);
                    } else {
                        script_change_lights(1, 1, 1, 1);
                    }
                    break;
                case "med":
                    if (floor(clock / 30) mod 2 == 1) {
                        script_change_lights(0, 0, 0, 0);
                    } else {
                        script_change_lights(1, 1, 1, 1);
                    }
                    break;
                case "fast":
                    if (floor(clock / 15) mod 2 == 1) {
                        script_change_lights(0, 0, 0, 0);
                    } else {
                        script_change_lights(1, 1, 1, 1);
                    }
                    break;
            }
            break;
        case "cycle":
            switch (speed_mode) {
                case "slow":
                    var light_cycle;
                    light_cycle = floor(clock / 60) mod 4
                    break;
                case "med":
                    var light_cycle;
                    light_cycle = floor(clock / 30) mod 4
                    break;
                case "fast":
                    var light_cycle;
                    light_cycle = floor(clock / 15) mod 4
                    break;
            }
            switch (light_cycle) {
                case 0: script_change_lights(1, 0, 0, 0); break;
                case 1: script_change_lights(0, 1, 0, 0); break;
                case 2: script_change_lights(0, 0, 1, 0); break;
                case 3: script_change_lights(0, 0, 0, 1); break;
            }    
            break;
    }
}

clock += 1;

#define script_change_lights
/* arguments
    argument0 - pink
    argument1 - orange
    argument2 - green
    argument3 - cyan
*/

script_change_light("lights_pink", argument0);
script_change_light("lights_orange", argument1);
script_change_light("lights_green", argument2);
script_change_light("lights_cyan", argument3);

#define script_change_light
/* arguments
    argument0 - light
    argument1 - target value
*/

var increment;

switch (transition) {
    case "cut": increment = 1; break;
    case "slow_fade": 
        switch (speed_mode) {
            case "slow": increment = 1/60; break;
            case "med": increment = 1/30; break;
            case "fast": increment = 1/15; break;
        }
        break;
    case "fast_fade": 
        switch (speed_mode) {
            case "slow": increment = 1/20; break;
            case "med": increment = 1/10; break;
            case "fast": increment = 1/5; break;
        }
        break;
}

if (argument1 == 0) {
    increment = -increment;
}

switch (argument0) {
    case "lights_pink": lights_pink += increment; break;
    case "lights_orange": lights_orange += increment; break;
    case "lights_green": lights_green += increment; break;
    case "lights_cyan": lights_cyan += increment; break;
}

if (lights_pink > 1) {lights_pink = 1;}
if (lights_orange > 1) {lights_orange = 1;}
if (lights_green > 1) {lights_green = 1;}
if (lights_cyan > 1) {lights_cyan = 1;}

if (lights_pink < 0) {lights_pink = 0;}
if (lights_orange < 0) {lights_orange = 0;}
if (lights_green < 0) {lights_green = 0;}
if (lights_cyan < 0) {lights_cyan = 0;}

