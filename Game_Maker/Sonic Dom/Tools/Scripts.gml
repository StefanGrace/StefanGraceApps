#define script_start
// script_start
// Stefan Grace
// Created: 2018-01-09
// Modifed: 2018-02-26


zones[1] = "Mystic Forest";
zones[2] = "Artic";
zones[3] = "Volcanic ";
zones[4] = "Dungeon";
zones[5] = "Seabed";
zones[6] = "Rainbow";
zones[7] = "Future";

zone = global.zone_select + 1;
act = global.act_select + 1;
right_bound = 8440;
bottom_bound = room_height;
if (zone == 1) {
    if (act == 2) {
        with (object_End_TV) {
            if (x > 7700 && x < 7800) {instance_change(object_End_TV_Got, false);}
        }
        right_bound = 14940;
        left_bound = 7120;
        x = 7760;
        y = 2992;
    } else if (act == 3) {
        with (object_End_TV) {
            if (x > 14111 && x < 14300) {instance_change(object_End_TV_Got, false);}
        }
        left_bound = 13616;
        right_bound = 23792;
        x = 14256;
        y = 2960;
    }
} else if (zone == 2) {
    room_goto(room_arctic);
    if (act == 1) {
        right_bound = 11216;
        left_bound = 22528 - 21600;
        x = 23168 - 21600;
        y = 3280;
    } else if (act == 2) {
        alarm[1] = 1;
        right_bound = 18864;
        left_bound = 31536 - 21600;
        x = 32176 - 21600;
        y = 2992;
    } else if (act == 3) {
        alarm[2] = 1;
        right_bound = 25968;
        left_bound = 17584;
        x = 18224;
        y = 2672;
    }
} else if (zone == 3) {
    room_goto(room_volcanic);
    if (act == 1) {
        right_bound = 9888;
        left_bound = 736;
        x = 1376;
        y = 3600;
    } else if (act == 2) {
        alarm[3] = 1;
        right_bound = 15056;
        left_bound = 8608;
        x = 9248;
        y = 3200;
    } else if (act == 3) {
        alarm[4] = 1;
        right_bound = 23680;
        left_bound = 13776;
        x = 14416;
        y = 2416;
    }
} else if (zone == 4) {
    room_goto(room_dungeon);
    if (act == 1) {
        right_bound = room_width;
        left_bound = 0;
        x = 1024;
        y = 1168;
    } else if (act == 2) {
        alarm[5] = 1;
        right_bound = 999999;
        left_bound = 7376;
        x = 8016;
        y = 2720;
    } else if (act == 3) {
        alarm[6] = 1;
        right_bound = 999999;
        left_bound = 12848;
        x = 13488;
        y = 3024;
    }
} else if (zone == 5) {
    room_goto(room_seabed);
    if (act == 1) {
        right_bound = 9696;
        left_bound = 0;
        x = 1792;
        y = 3376;
    } else if (act == 2) {
        alarm[7] = 1;
        right_bound = 16384;
        left_bound = 8416;
        x = 9056;
        y = 3360;
    } else if (act == 3) {
        alarm[8] = 1;
        right_bound = 999999;
        left_bound = 15104;
        x = 15744;
        y = 2976;
    }
} else if (zone == 6) {
    room_goto(room_rainbow);
    bottom_bound = room_height;
    if (act == 1) {
        right_bound = 11168;
        left_bound = 0;
        x = 1152;
        y = 1728;
    } else if (act == 2) {
        alarm[9] = 1;
        right_bound = 21840;
        left_bound = 9888;
        x = 10528;
        y = 512;
    } else if (act == 3) {
        alarm[10] = 1;
        right_bound = 32592;
        left_bound = 20560;
        x = 21200;
        y = 1168;
    }
} else if (zone == 7) {
    room_goto(room_future);
    bottom_bound = room_height;
    if (act == 1) {
        right_bound = 9472;
        left_bound = 0;
        x = 640;
        y = 1552;
    } else if (act == 2) {
        alarm[11] = 1;
        right_bound = 18144;
        left_bound = 8192;
        x = 8832;
        y = 1040;
    } else if (act == 3) {
        alarm[11] = 1;
        right_bound = 999999;
        left_bound = 16864;
        x = 17504;
        y = 1568;
    }
}
instance_create(x, y, object_View);
facing = 1;
lives = 3;
bind_x = x;
bind_y = y;
bind_time = time;
showing_title = true;
title_time = time;


#define script_draw
// script_draw
// Stefan Grace
// Created: 2018-01-07
// Modifed: 2018-01-09


// Display
draw_set_font(font_display);
draw_set_halign(fa_left);
draw_text_color(view_xview[0] + 50,view_yview[0] + 10, "Score: ", c_yellow, c_yellow, c_black, c_black, 1);
draw_text_color(view_xview[0] + 50,view_yview[0] + 40, "Time: ", time_color, time_color, c_black, c_black, 1);
draw_text_color(view_xview[0] + 50,view_yview[0] + 70, "Rings: ", rings_color, rings_color, c_black, c_black, 1);
draw_set_halign(fa_right);
draw_text_color(view_xview[0] + 240,view_yview[0] + 10, score, c_white, c_white, c_black, c_black, 1);
draw_text_color(view_xview[0] + 200,view_yview[0] + 40, string(minutes) + ":" + string(seconds), c_white, c_white, c_black, c_black, 1);
draw_text_color(view_xview[0] + 200,view_yview[0] + 70, rings, c_white, c_white, c_black, c_black, 1);
draw_sprite(sprite_lives,0,view_xview[0] + 50,view_yview[0] + 680);
draw_set_font(font_lives);
draw_set_halign(fa_left);
draw_text_color(view_xview[0] + 85,view_yview[0] + 680, "Sonic", c_yellow, c_yellow, c_black, c_black, 1);
draw_text_color(view_xview[0] + 85,view_yview[0] + 698, "x", c_white, c_white, c_black, c_black, 1);
draw_set_halign(fa_right);
draw_text_color(view_xview[0] + 130,view_yview[0] + 698, lives, c_white, c_white, c_black, c_black, 1);

// Sonic
if (game_over) {
    draw_set_font(font_game_over);
    draw_set_halign(fa_center);
    draw_set_valign(fa_middle);
    draw_text_color(view_xview[0] + 640, view_yview[0] + 360, "Game Over", c_white, c_white, c_black, c_black, 1);
    draw_set_valign(0);
} else {
    if (shield) {
        draw_ellipse_color(x - 50, y - 50, x + 50, y + 50, $FF8000, $FF8000, false);
    }
    if (spin || jump) {
        draw_sprite_ext(sprite_sonic_spin, floor((time * 30) mod 5), x, y, facing, 1, 0, c_white, 1);
    } else if (crouch) {
        draw_sprite_ext(sprite_sonic_crouch, 0, x, y, facing, 1, 0, c_white, 1);
    } else if (flashing) {
        draw_sprite_ext(sprite_sonic_flash, floor((time * 10) mod 2), x, y, facing, 1, 0, c_white, 1);
    } else if (look_up) {
        draw_sprite_ext(sprite_sonic_look_up, 0, x, y, facing, 1, 0, c_white, 1);
    } else if (hspeed >= sonic_speed || hspeed <= sonic_speed * -1) {
        draw_sprite_ext(sprite_sonic_running, floor((time * 30) mod 5), x, y, facing, 1, 0, c_white, 1);
    } else if (hspeed != 0) {
        draw_sprite_ext(sprite_sonic_walking, floor((time * 15) mod 3), x, y, facing, 1, 0, c_white, 1);
    } else {
        draw_sprite_ext(sprite_sonic, 0, x, y, facing, 1, 0, c_white, 1);
    }
    if (super_sonic) {
        draw_sprite(sprite_super_sonic, floor((time * 10) mod 2), x, y);
    }
}

// Bonuses
if (showing_bonuses) {
    draw_set_halign(fa_left);
    draw_set_font(font_title);
    draw_text_color(view_xview[0] + 300, view_yview[0] + 100, "Sonic Has Passed Act " + string(act), c_white, c_white, c_black, c_black, 1);
    draw_set_font(font_display);
    draw_text_color(view_xview[0] + 300,view_yview[0] + 250, "Score: ", c_yellow, c_yellow, c_black, c_black, 1);
    draw_text_color(view_xview[0] + 300,view_yview[0] + 300, "Time Bonus: ", c_yellow, c_yellow, c_black, c_black, 1);
    draw_text_color(view_xview[0] + 300,view_yview[0] + 350, "Ring Bonus: ", c_yellow, c_yellow, c_black, c_black, 1);
    draw_set_halign(fa_right);
    draw_text_color(view_xview[0] + 550,view_yview[0] + 250, score, c_white, c_white, c_black, c_black, 1);
    draw_text_color(view_xview[0] + 550,view_yview[0] + 300, time_bonus, c_white, c_white, c_black, c_black, 1);
    draw_text_color(view_xview[0] + 550,view_yview[0] + 350, ring_bonus, c_white, c_white, c_black, c_black, 1);
}

// Title
if (showing_title) {
    draw_set_halign(fa_center);
    draw_set_valign(fa_middle);
    draw_set_font(font_title);
    draw_text_color(view_xview[0] + 640, view_yview[0] + 360, string(zones[zone]) + "#Zone Act " + string(act), c_white, c_white, c_black, c_black, 1);
    draw_set_valign(0);
}
#define script_sonic
// script_sonic
// Stefan Grace
// Created: 2018-01-07
// Modifed: 2018-02-27


// Walk
if (keyboard_check(vk_right) && x + sprite_width < right_bound && !place_meeting(x + 10, y, object_Wall) && !place_meeting(x + 10, y, object_Gate)) {
    if (hspeed < sonic_speed) {hspeed += 1;}
    facing = 1;
} else if (keyboard_check(vk_left) && x - sprite_width > left_bound && !place_meeting(x - 10, y, object_Wall) && !place_meeting(x - 10, y, object_Gate)) {
    if (hspeed > sonic_speed * -1) {hspeed -= 1;}
    facing = -1;
} else if (!spin || floor((time * 30) mod 3) == 0) {
    if (hspeed >= 1) {
        hspeed -= 1;
    } else if (hspeed <= -1) {
        hspeed += 1;
    } else {
        hspeed = 0;
        spin = false;
    }
}
if ((x - sprite_width <= left_bound || place_meeting(x - 10, y, object_Wall) || place_meeting(x - 10, y, object_Gate)) && hspeed < 0)
|| ((x + sprite_width >= right_bound || place_meeting(x + 10, y, object_Wall) || place_meeting(x + 10, y, object_Gate)) && hspeed > 0){
    hspeed = 0;
}

// Hit top platform
if ((place_meeting(x, y - 10, object_Top)) && vspeed < 0) {vspeed = 0;}

// Fall
if ((!place_meeting(x, y + 1, object_Platform) && !place_meeting(x, y, object_Falling_Platform) && !place_meeting(x, y + 2, object_Lava_Boat)) 
&& !place_meeting(x, y, object_Ladder) && !place_meeting(x, y, object_Tilting_Platform) && !place_meeting(x, y, object_Rising_Platform)) {
    if (vspeed < sonic_speed) {vspeed += 1;}
} else {
    vspeed = 0;
    jump = false;
}

// Jump
if (keyboard_check(ord("A"))) {
    if (place_meeting(x, y + 1, object_Platform) || place_meeting(x, y, object_Falling_Platform) || place_meeting(x, y + 5, object_Lava_Boat) 
    || place_meeting(x, y + 5, object_Tilting_Platform)) {
        vspeed = -20;
        jump = true;
    }
}

// Spring
if (place_meeting(x, y, object_Spring)) {
    vspeed = -35;
    if (!spring_sound_playing){
        sound_play(sound_spring);
        spring_sound_playing = true;
        spring_sound_time = time;
    }
}
if (place_meeting(x, y, object_Spring_Left)) {
    hspeed = -35;
    if (!spring_sound_playing){
        sound_play(sound_spring);
        spring_sound_playing = true;
        spring_sound_time = time;
    }
}
if (place_meeting(x, y, object_Spring_Right)) {
    hspeed = 35;
    if (!spring_sound_playing){
        sound_play(sound_spring);
        spring_sound_playing = true;
        spring_sound_time = time;
    }
}
if (spring_sound_playing) {
    if (time - spring_sound_time > 1) {spring_sound_playing = false;}
}

// Stay on platform
if (place_meeting(x, y, object_Platform) || place_meeting(x, y, object_Tilting_Platform) || place_meeting(x, y, object_Rising_Platform)) {
    y -= floor(sqrt(sqr(hspeed))); 
}

// Spin/ Crouch
if (keyboard_check(vk_down)) {
    spin = hspeed != 0;
    crouch = hspeed == 0;    
} else {
    crouch = false;
}

// Look up
look_up = keyboard_check(vk_up) && hspeed == 0 && vspeed == 0 && !place_meeting(x, y, object_Ladder);

// Ladder
if (place_meeting(x, y, object_Ladder) && keyboard_check(vk_up)) {y -= 10;}

// Time
if (time < 599 || showing_bonuses) {
    time += 1 / 30;
} else {
    script_execute(script_die);
}
if (minutes < 9) {
    time_color = c_yellow;
} else {
    time_color = c_red;
}
if (!showing_bonuses) {
    minutes = floor(time / 60);
    seconds = floor(time mod 60);
    if (seconds < 10) {seconds = "0" + string(seconds);}
}
steps += 1;

// Rings 
if (place_meeting(x, y, object_TV_Ring) && (spin || jump)) {
    with (object_TV_Ring){
        if (place_meeting(x, y, other)) {instance_change(object_TV_Got, false);}
    }
    rings += 10;
    if (rings mod 2 > 0) {
            sound_play(sound_ring_left);
        } else {
            sound_play(sound_ring_right);
        }
        ring_sound_playing = true;
        ring_sound_time = time;
}
if (place_meeting(x, y, object_Ring)) {
    with (object_Ring) {
        if (place_meeting(x, y, other)) {
            if (lost_ring) {
                instance_destroy();
            } else { 
                instance_change(object_Ring_Got, false);
            }
        }
    }
    rings += 1;
    if (!ring_sound_playing){
        if (rings mod 2 > 0) {
            sound_play(sound_ring_left);
        } else {
            sound_play(sound_ring_right);
        }
        ring_sound_playing = true;
        ring_sound_time = time;
    }
}
if (ring_sound_playing) {
    if (time - ring_sound_time > 0.5) {ring_sound_playing = false;}
}
if (rings > 0) {
    rings_color = c_yellow;
} else {
    rings_color = c_red;
}

// Shield
if (place_meeting(x, y, object_TV_Shield) && (spin || jump)) {
    with (object_TV_Shield) {
        if (place_meeting(x, y, other)) {instance_change(object_TV_Got, false);}
    }
    shield = true;
    sound_play(sound_shield);
}

// Super Sonic 
if (place_meeting(x, y, object_TV_Super_Sonic) && (spin || jump)) {
    with (object_TV_Super_Sonic) {
        if (place_meeting(x, y, other)) {instance_change(object_TV_Got, false);}
    }
    super_sonic = true;
    super_sonic_time = time;
}
if (time - super_sonic_time > 20) {super_sonic = false;}

// Extra Life
if (place_meeting(x, y, object_TV_Sonic) && (spin || jump)) {
    with (object_TV_Sonic){
        if (place_meeting(x, y, other)) {instance_change(object_TV_Got, false);}
    }
    script_execute(script_extra_life);
}
if (rings >= 200 && !got_life_from_200_rings) {
    got_life_from_200_rings = true;
    script_execute(script_extra_life);
} else if (rings >= 100 && !got_life_from_100_rings) {
    got_life_from_100_rings = true;
    script_execute(script_extra_life);
}
if (keyboard_check(ord("E")) && !got_life_from_key) {
    got_life_from_key = true;
    script_execute(script_extra_life);
}
if (!keyboard_check(ord("E"))) {
    got_life_from_key = false;
}
if (rings < 100) {
    got_life_from_100_rings = false;
    got_life_from_200_rings = false;
}
if (just_got_extra_life) {
    if (time - extra_life_time > 4) {just_got_extra_life = false;}
}

// Game Restart
if (keyboard_check(ord("R"))) {game_restart();}

// Fall off the edge
if (y > bottom_bound || y > room_height) {script_execute(script_die);}

// Lamp Post
if (place_meeting(x, y, object_Lamp_Post)) {
    with (object_Lamp_Post){
        if (place_meeting(x, y, other)) {instance_change(object_Lamp_Post_Got, false);}
    }
    bind_x = x;
    bind_y = y;
    bind_time = time;
    sound_play(sound_lamp_post);
}

// Spikes
if (place_meeting(x, y, object_Spikes) /*&& vspeed > 0*/) {
    vspeed = -15;
    script_execute(script_hit);
}

// Fire, Lava, Arrows, Spike Ball, Fuzz Ball, Saw, Lightning
if (place_meeting(x, y, object_Fire) || place_meeting(x, y, object_Lava) || place_meeting(x, y, object_Mini_Fire) || place_meeting(x, y, object_Lava_Stream) 
|| place_meeting(x, y, object_Arrow) || place_meeting(x, y, object_Arrow_Up) || place_meeting(x, y, object_Arrow_Down) || place_meeting(x, y, object_Spike_Ball)
|| place_meeting(x, y, object_Ball) || place_meeting(x, y, object_Fuzz_Ball_Left) || place_meeting(x, y, object_Fuzz_Ball_Right) 
|| place_meeting(x, y, object_Saw) || place_meeting(x, y, object_Lightning)) {
    script_execute(script_hit);
}

// Stop Flashing
if (flashing && time - flash_start > 2) {
    flashing = false;
}

// Game Over
//if (game_over) {game_over_time += 1 / 30;}
//if (game_over_time > 12) {game_restart();}

// Mobs 
if (place_meeting(x, y, object_Mob)) {
    if (spin || jump || super_sonic) {
        with (object_Mob){
            if (place_meeting(x, y, other)) {instance_change(object_Mob_Dead, false);}
        }
        score += 100;
        sound_play(sound_mob_kill);
    } else {
        script_execute(script_hit);
    }
}

// End TV
if (place_meeting(x, y, object_End_TV)) {
    with (object_End_TV){
        if (place_meeting(x, y, other)) {instance_change(object_End_TV_Got, false);}
    }
    if (time < 30) {
        time_bonus = 50000;
    } else if (time < 45) {
        time_bonus = 10000;
    } else if (time < 60) {
        time_bonus = 5000;
    } else if (time < 90) {
        time_bonus = 4000;
    } else if (time < 120) {
        time_bonus = 3000;
    } else if (time < 180) {
        time_bonus = 2000;
    } else if (time < 240) {
        time_bonus = 1000;
    } else if (time < 300) {
        time_bonus = 500;
    } else {
        time_bonus = 0;
    } 
    ring_bonus = rings * 100;
    left_bound = x - 640;
    right_bound = x + 640;
    showing_bonuses = true;
    bonuses_time = time;
}
if (showing_bonuses && time - bonuses_time > 6) {
    showing_bonuses = false;
    super_sonic = false;
    shield = false;
    time = 0;
    rings = 0;
    bind_time = time;
    bind_x = x;
    bind_y = y;
    showing_title = true;
    title_time = time;
    right_bound = room_width;
    if (act < 3) {
        act += 1;
        if (zone == 1) {
            if (act == 2) {
                right_bound = 14940;
            } else if (act == 3) {
                right_bound = 23792;
            }
        } else if (zone == 2) {
            if (act == 2) {
                right_bound = 18864;
            } else if (act == 3) {
                right_bound = 25968;
            }
        } else if (zone == 3) {
            if (act == 2) {
                right_bound = 15056;
            } else if (act == 3) {
                right_bound = 23680;
            }
        } else if (zone == 4) {
            if (act == 2) {
                right_bound = 14128;
            } else if (act == 3) {
                right_bound = 22144;
            }
        }
    } else {
        room_goto_next();
        if (zone == 1) {
            x -= 21600;
            right_bound = 11216;
            left_bound = 912;
            bind_x = x;
        } else if (zone == 2) {
            x -= 23952;
            right_bound = 11216;
            left_bound = 0;
            bind_x = x;
        } else if (zone == 3) {
            x -= 22016;
            right_bound = 9888;
            left_bound = 0;
            bind_x = x;
        } else if (zone == 4) {
            x -= 19712;
            right_bound = 9696;
            left_bound = 0;
            bind_x = x;
        } else if (zone == 5) {
            x -= 23712;
            right_bound = 999999;
            left_bound = 0;
            bind_x = x;
        } else if (zone == 6) {
            x -= 31312;
            right_bound = 999999;
            left_bound = 0;
            bind_x = x;
        }
        zone += 1;
        act = 1;
    }
} else if (showing_bonuses && time - bonuses_time > 4) {
    score += time_bonus + ring_bonus;
    time_bonus = 0;
    ring_bonus = 0;
}
if (showing_title && time - title_time > 3) {showing_title = false;}

// Music
if (game_over) {
    if (!sound_isplaying(sound_game_over)) {sound_play(sound_game_over);}
} else if (showing_bonuses) {
    if (time - bonuses_time < 4) {
        if (!sound_isplaying(sound_level_complete)) {sound_play(sound_level_complete);}
    } else if (time - bonuses_time < 5){
        if (!sound_isplaying(sound_score_add)) {sound_play(sound_score_add);}
    }
} else if (just_got_extra_life) {
    if (!sound_isplaying(sound_extra_life)) {sound_play(sound_extra_life);}
} else if (drowning_timer > 17) {
    if (drowning_timer < 28) {
        if (!sound_isplaying(sound_drowning_timer)) {sound_play(sound_drowning_timer);}
    } else {
        if (!sound_isplaying(sound_drown)) {sound_play(sound_drown);}
    }
} else if (boss) {
    if (!sound_isplaying(sound_boss)) {sound_play(sound_boss);}
} else if (super_sonic) {
    if (!sound_isplaying(sound_super_sonic)) {sound_play(sound_super_sonic);}
} else if (zone == 1) {
    if (!sound_isplaying(sound_mystic_forest)) {sound_play(sound_mystic_forest);}
} else if (zone == 2) {
    if (!sound_isplaying(sound_arctic)) {sound_play(sound_arctic);}
} else if (zone == 3) {
    if (!sound_isplaying(sound_volcanic)) {sound_play(sound_volcanic);}
} else if (zone == 4) {
    if (!sound_isplaying(sound_dungeon)) {sound_play(sound_dungeon);}
} else if (zone == 5) {
    if (!sound_isplaying(sound_seabed)) {sound_play(sound_seabed);}
} else if (zone == 6) {
    if (!sound_isplaying(sound_rainbow)) {sound_play(sound_rainbow);}
} else if (zone == 7) {
    if (!sound_isplaying(sound_future)) {sound_play(sound_future);}
}

// Fire
if (x > 18240 && x < 20176 && !fire_has_happend && zone == 1) {
    instance_create(17904, 2864, object_Fire)
    fire_has_happend = true;
}
if (zone == 1 && act == 3) {
    if (x > 20176 && instance_number(object_Fire) > 0) {
        with (object_Fire) {instance_destroy()};
    }
}

// Boss
if (x > 21024 && x < 21400 && !boss_done_mystic_forest && zone == 1) {
    boss = true;
    left_bound = 20721;
    right_bound = 21999;
    top_bound = 2968;
    bottom_bound = 3688;
} else if (x > 24064 && x < 24832 && !boss_done_arctic && zone == 2) {
    boss = true;
    left_bound = 24064;
    right_bound = 24832;
    top_bound = 2632;
    bottom_bound = 3352;
} else if (x > 21136 && x < 22400 && !boss_done_volcanic && zone == 3) {
    boss = true;
    left_bound = 21136;
    right_bound = 22400;
    top_bound = 480;
    bottom_bound = 1200;
} else if (x > 19712 && x < 20800 && !boss_done_dungeon && zone == 4) {
    boss = true;
    left_bound = 19712;
    right_bound = 20800;
    top_bound = 0;
    bottom_bound = room_height;
} else if (x > 21984 && x < 23264 && !boss_done_seabed && zone == 5) {
    boss = true;
    left_bound = 21984;
    right_bound = 23264;
    top_bound = 2616;
    bottom_bound = 3336;
} else if (x > 28560 && x < 29840 && !boss_done_rainbow && zone == 6) {
    boss = true;
    left_bound = 28560;
    right_bound = 29840;
    top_bound = 424;
    bottom_bound = 1144;
} else if (x > 23648 && !boss_done_future && zone == 7) {
    boss = true;
    left_bound = 23648;
    right_bound = room_width;
    top_bound = 944;
    bottom_bound = 1664;
}

if (boss) {
    if (place_meeting(x, y, object_Dr_Robonic) && !boss_hitting) {
        boss_hit_time = time;
        boss_hit += 1;
        boss_hitting = true;
        sound_play(sound_boss_hit);
    }
    if (time - boss_hit_time > 0.7) {boss_hitting = false;}
}

// Pause
if (keyboard_check(vk_enter)) {
    sound_stop_all();
    message_alpha(0);
    show_message("");
}

// Drowning
if (place_meeting(x, y, object_Water)) {
    drowning_timer += 1 / 30;
    if (place_meeting(x, y, object_Bubbles)) {
        if (!bubble_sound_played) {sound_play(sound_bubble);}
        bubble_sound_played = true;
        bubble_sound_time = time;
    }
    if (!place_meeting(x, y, object_Bubbles)) {
        if (time - bubble_sound_time > 1.5) {bubble_sound_played = false;}
    }
}
if (drowning_timer > 0) {
    if (!place_meeting(x, y, object_Water) || place_meeting(x, y, object_Bubbles)) {drowning_timer = 0;}
    if (drowning_timer > 30) {script_execute(script_die);}
}

// Boulder
if (place_meeting(x, y, object_Boulder)) {
    if (object_Boulder.hspeed > 0) {script_execute(script_die);}
}

// Lava Rise 
if (zone == 3) {
    if (x > 19888 && y < 2912 && !lava_risen) {lava_rising = true;}
    if (lava_level == 0) {lava_level = 3152;}
    if (lava_level < 1040) {
        lava_speed = 5;
    } else if (lava_level < 1728) {
        lava_speed = 10;
    } else {
        lava_speed = 15;
    }
    if (lava_rising) {
        if (lava_level >= 560) {
            if (steps mod lava_speed == 0) {
                var i;
                for (i = 19152; i <= 20208; i += 32) {
                    instance_create(i, lava_level, object_Lava);  
                }
                lava_level -= 32;
            }
        } else {
            lava_rising = false;
            lava_risen = true;
            var i;
            for (i = 20240; i <= 20400; i += 32) {
                instance_create(i, 560, object_Lava);
            } 
            for (i = 592; i <= 944; i += 16) {
                instance_create(i + 19840, i, object_Lava_Stream);
            }
            for (i = 976; i < room_height; i += 32) {
                instance_create(20816, i, object_Lava_Fall);
            } 
        }
    }
} 

// Water Rise
if (zone = 5) {
    if (x > 19312 && !water_risen) {water_rising = true;}
    if (water_level == 0) {water_level = 4032;}
    water_speed = 5;
    if (water_rising) {
        if (water_level >= 2672) {
            if (steps mod water_speed == 0) {
                var i;
                for (i = 18080; i <= 21824; i += 32) {
                    instance_create(i, water_level, object_Water);  
                }
                water_level -= 32;
            }
        } else {
            water_rising = false;
            water_risen = true;
        }
    }
}

// Kill
if (keyboard_check(ord("K")) && !been_killed) {
    been_killed = true;
    script_execute(script_die);
}
if (!keyboard_check(ord("K"))) {
    been_killed = false;
}

// Rising Platform
/*if (place_meeting(x, y + 2, object_Rising_Platform)) {
    vspeed = -5;
    left_bound = 23616;
    object_Platform.vspeed = -5;
}*/

// Star
if (place_meeting(x, y, object_Star)) {
    with (object_Star) {
        if (place_meeting(x, y, other)) {instance_change(object_Star_Hit, true);}
    }
    hspeed *= -1;
    vspeed *= -1;
    score += 10;
    sound_play(sound_star);
} 
#define script_view
// script_view
// Stefan Grace
// Created: 2018-01-07
// Modifed: 2018-02-27


if (!object_Sonic.showing_bonuses && !object_Sonic.boss) {
    x = object_Sonic.x;
    if (object_Sonic.crouch){
        if (y < object_Sonic.y + 300) {y += 5;}
    } else if (object_Sonic.look_up){
        if (y > object_Sonic.y - 300) {y -= 5;}
    } else {
        y = object_Sonic.y;
    }
}

if (object_Sonic.boss) {
    if (object_Sonic.zone == 1) {
        x = 21360;
        y = 3088;
    } else if (object_Sonic.zone == 2) {
        x = 24432;
        y = 2992;
    } else if (object_Sonic.zone == 3) {
        x = 21744;
        y = 840;
    } else if (object_Sonic.zone == 4) {
        x = 20256;
        y = object_Sonic.y;
    } else if (object_Sonic.zone == 5) {
        x = 22624;
        y = 2976;
    } else if (object_Sonic.zone == 6) {
        x = 29200;
        y = 784;
    } else if (object_Sonic.zone == 7) {
        x = 24288;
        y = 1304;
    }
}


#define script_die
// script_die
// Stefan Grace
// Created: 2018-01-07
// Modifed: 2018-02-16

if (lives > 0) {lives -= 1;}
if (lives > 0) { 
    x = bind_x;
    y = bind_y;
    hspeed = 0;
    vspeed = 0;
    rings = 0;
    shield = false;
    super_sonic = false;
    time = bind_time;
    drowning_timer = 0;
    just_got_extra_life = false;
    boss_hit_time = 0;
    flashing = false;
    if (lava_rising || lava_risen) {
        lava_rising = false;
        lava_risen = false;
        lava_level = 0;
        with (object_Lava) {
            if (x > 19136 && x < 20272 && y < 3184) {instance_destroy();}
        }   
        with (object_Lava_Stream) {instance_destroy();}
        with (object_Lava_Fall) {instance_destroy();}
    }
    with (object_TV_Got) {
        if (tv_type == 1) {
            instance_change(object_TV_Ring, false);
        } else if (tv_type == 2) {
            instance_change(object_TV_Shield, false);
        } else if (tv_type == 3) {
            instance_change(object_TV_Super_Sonic, false);
        } else if (tv_type == 4) {
            instance_change(object_TV_Sonic, false);
        }
    }
    with (object_Ring_Got) {instance_change(object_Ring, false);}
    with (object_Mob_Dead) {instance_change(object_Mob, false);}
    with (object_Falling_Platform_Fallen) {instance_change(object_Falling_Platform, true);}
    object_Falling_Platform.alarm[0] = -1;
    if (x < 20176) {fire_has_happend = false;}
    with (object_Fire) {instance_destroy();}
    if (zone == 1) {
        sound_play(sound_mystic_forest);
    } else if (zone == 2) {
        sound_play(sound_arctic);
    } else if (zone == 3) {
        sound_play(sound_volcanic);
    } else if (zone == 4) {
        sound_play(sound_dungeon);
    } else if (zone == 5) {
        sound_play(sound_seabed);
    } else if (zone == 6) {
        sound_play(sound_rainbow);
        object_Moving_Cloud.y = 736;
    } else if (zone == 7) {
        sound_play(sound_future);
    }
    with (object_Boulder) {
        x = xstart; 
        y = ystart;
    }
    with (object_Lava_Boat) {
        x = xstart; 
        y = ystart;
        moving = false;
    }
    with (object_Movable_Block) {
        x = 11235; 
        y = ystart;
    }
    with (object_Movable_Block_2) {
        x = 20258;
        y = ystart;
    }
    showing_title = true;
    title_time = time;
    boss = false;
    boss_hit = 0;
    if (zone == 1 && act == 3) {
        left_bound = 13616;
        bottom_bound = room_height;
        top_bound = 0;
    } else if (zone == 2 && act == 3) {
        left_bound = 17584;
        bottom_bound = room_height;
        top_bound = 0;
    } else if (zone == 3 && act == 3) {
        left_bound = 13776;
        bottom_bound = room_height;
        top_bound = 0;
    } else if (zone == 4 && act == 3) {
        left_bound = 12848;
        bottom_bound = room_height;
        top_bound = 0;
    } else if (zone == 5 && act == 3) {
        left_bound = 15104;
        bottom_bound = room_height;
        top_bound = 0;
    }else if (zone == 6 && act == 3) {
        left_bound = 20560;
        bottom_bound = room_height;
        top_bound = 0;
    }

} else {
    game_over = true;
}
#define script_hit
// script_hit
// Stefan Grace
// Created: 2018-01-08
// Modifed: 2018-01-11


if (flashing || super_sonic) {
    exit;
} else if (shield) {
    shield = false;
    flashing = true;
    flash_start = time;
} else if (rings > 0) {
    repeat(rings) {
        instance_create(x + (floor(random(512)) - 256), y - floor(random(256)), object_Ring);
    }
    rings = 0;
    flashing = true;
    flash_start = time;
    sound_play(sound_loose_rings);
} else {
    script_execute(script_die);
}


#define script_extra_life
// script_extra_life
// Stefan Grace
// Created: 2018-01-11
// Modifed: 2018-01-11


lives += 1;
just_got_extra_life = true;
extra_life_time = time;
#define script_moving
// script_moving_v
// Stefan Grace
// Created: 2018-01-22
// Modifed: 2018-01-22
// This script makes platforms move 

if (place_meeting(x, y, other)) {
    x = other.x
    y = other.y
}

