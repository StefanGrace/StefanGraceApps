#define script_start
// script_start
// Stefan Grace
// Created: 2018-01-09
// Modified: 2021-02-15


zones[1] = "Extra-Terrestrial";
zones[2] = "Martian";
zones[3] = "Pinball";

zone = global.zone_select + 1;
act = global.act_select + 1;
alarm[0] = 1;
right_bound = room_width;
bottom_bound = room_height;
left_bound = 0;

if (zone != 1 || act != 1) {x = 640;}

if (zone == 1) {
    if (act == 2) {
        room_goto(room_extra_terrestrial_act2);
        y = 840;
        bottom_bound = 1800;
    }
} else if (zone == 2) {
    if (act == 1) {
        room_goto(room_martian_act1);
        y = 3008;
    } else if (act == 2) {
        room_goto(room_martian_act2);
        y = 2080;
    } 
} else if (zone == 3) {
    if (act == 1) {
        room_goto(room_pinball_act1);
        y = 1424;
    } else if (act == 2) {
        room_goto(room_pinball_act2);
        y = 1088;
    }                                                                                 
} 

instance_create(x, y, object_View);
instance_create(0, 0, object_UI);
facing = 1;
lives = 3;
bind_x = x;
bind_y = y;
bind_time = time;
showing_title = true;
title_time = time;
dead_sonic_speed = -20;
#define script_sonic
// script_sonic
// Stefan Grace
// Created: 2018-01-07
// Modified: 2021-02-23



// Walk
if (keyboard_check(vk_right) && !crouch && x + sprite_width < right_bound && !place_meeting(x + 10, y, object_Wall) && !place_meeting(x + 10, y, object_Gate)) {
    if (spin) {
        if (hspeed < 0) {hspeed += 1;}
    } else {
        if (hspeed < sonic_speed) {hspeed += 1;}
        facing = 1;
    }
} else if (keyboard_check(vk_left) && !crouch && x - sprite_width > left_bound && !place_meeting(x - 10, y, object_Wall) && !place_meeting(x - 10, y, object_Gate)) {
    if (spin) {
        if (hspeed > 0) {hspeed -= 1;}
    } else {
        if (hspeed > -sonic_speed) {hspeed -= 1;}
        facing = -1;
    }    
} else if (!spin) {
    if (hspeed >= 1) {
        hspeed -= 1;
    } else if (hspeed <= -1) {
        hspeed += 1;
    } else {
        hspeed = 0;
    }
}
if (spin && floor((time * 30) mod 4) == 0) {
    if (hspeed >= 1) {
        hspeed -= 1;
    } else if (hspeed <= -1) {
        hspeed += 1;
    } else {
        hspeed = 0;
    }
}
if (hspeed == 0) {spin = false;}
if ((x - sprite_width <= left_bound || place_meeting(x - 10, y, object_Wall) || place_meeting(x - 10, y, object_Gate)) && hspeed < 0)
|| ((x + sprite_width >= right_bound || place_meeting(x + 10, y, object_Wall) || place_meeting(x + 10, y, object_Gate)) && hspeed > 0){
    hspeed = 0;
}


// Hit top platform
if ((place_meeting(x, y - 10, object_Top)) && vspeed < 0) {vspeed = 0;}


// Fall
if (!place_meeting(x, y + 1, object_Platform) && !place_meeting(x, y, object_Platform_Flat) && !place_meeting(x, y, object_Flashing_Platform)
&& !place_meeting(x, y, object_Ladder) && !place_meeting(x, y, object_Rising_Platform)) {
    if (vspeed < sonic_speed) {vspeed += 1;}
    if (vspeed > sonic_speed) {vspeed -= 1;}
} else {
    vspeed = 0;
    jump = false;
}


// Jump
if (keyboard_check(ord("A")) || keyboard_check(ord("D")) || keyboard_check(vk_space)) {
    if (place_meeting(x, y + 1, object_Platform) || place_meeting(x, y, object_Platform_Flat) || place_meeting(x, y, object_Flashing_Platform)) {
        vspeed = -20;
        if (!jump) {sound_play(sound_jump);}
        spin = false;
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
if (place_meeting(x, y, object_Spring_Weak)) {
    vspeed = -25;
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
if (place_meeting(x, y, object_Platform) || place_meeting(x, y, object_Rising_Platform)|| place_meeting(x, y, object_Balloon)) {
    y -= floor(sqrt(sqr(hspeed))); 
}
if (place_meeting(x, y, object_Balloon)) {
    vspeed = -5;
}


// Spin/ Crouch
if ((keyboard_check(vk_down) || keyboard_check(ord("S"))) && !place_meeting(x, y, object_Spring_Woosh)) {
    if (!spin and hspeed != 0) {sound_play(sound_spin);}
    spin = hspeed != 0;
    crouch = hspeed == 0;    
} else {
    crouch = false;
}


// Look up
look_up = (keyboard_check(vk_up) || keyboard_check(ord("W"))) && hspeed == 0 && vspeed == 0 && !place_meeting(x, y, object_Ladder) && !place_meeting(x, y, object_Spring_Woosh);


// Ladder
if (place_meeting(x, y, object_Ladder) && (keyboard_check(vk_up) || keyboard_check(ord("W")))) {y -= 10;}


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
if (!showing_bonuses && !game_over && !dead) {
    minutes = floor(time / 60);
    seconds = floor(time mod 60);
    if (seconds < 10) {seconds = "0" + string(seconds);}
}
steps += 1;


// Rings 
if (place_meeting(x, y, object_TV_Ring) && (spin || jump)) {
    with (object_TV_Ring){
        if (place_meeting(x, y, other)) {
            other.rings += 10;
            instance_change(object_TV_Got, false);
        }
    }
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
            other.rings += 1;
            if (lost_ring) {
                instance_destroy();
            } else { 
                instance_change(object_Ring_Got, false);
            }
        }
    }
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
        if (place_meeting(x, y, other)) {
            instance_change(object_TV_Got, false);
            with (other) {script_extra_life();}
        }
    }
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
    x = round(x);
    y = round(y);
    bind_x = x;
    bind_y = y;
    bind_time = time;
    sound_play(sound_lamp_post);
}


// Spikes
if (place_meeting(x, y, object_Spikes)) {
    if (place_meeting(x, y, object_Spikes_Upsidedown)) {
        vspeed = 15;
    } else if (place_meeting(x, y, object_Spikes_Right)) {
        hspeed = 15;
    } else if (place_meeting(x, y, object_Spikes_Left)) {
        hspeed = -15;
    } else {
        vspeed = -15;
    }
    script_execute(script_hit);
}


// Danger
if (place_meeting(x, y, object_Danger)) {
    script_execute(script_hit);
}


// Stop Flashing
if (flashing && time - flash_start > 2) {
    flashing = false;
}


// Mobs 
if (place_meeting(x, y, object_Mob) && !dead) {
    if (spin || jump || super_sonic) {
        with (object_Mob){
            if (place_meeting(x, y, other)) {
                if (mob_id == 1 && yellow) {
                    with (other) {script_execute(script_hit);}
                } else {
                    instance_change(object_Mod_Exploding, false);
                    score += 100;
                    sound_play(sound_mob_kill);
                }
            }
        }
    } else {
        script_execute(script_hit);
    }
}


// End TV
if (place_meeting(x, y, object_End_TV)) {
    with (object_End_TV){
        if (place_meeting(x, y, other)) {instance_change(object_End_TV_Got, false);}
    }
    if (zone == 1 && act == 1) {
        var i;
        for (i = 704; i < 880; i += 32) {instance_create(9776, i, object_Wall);}
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
    showing_title = true;
    title_time = time;
    room_goto_next();
    x = round(x);
    y = round(y);
    if (zone == 1) {
        if (act == 1) {
            x -= 9808;
        } else {
            x -= 9088;
        }
    } else if (zone == 2) {
        if (act == 1) {
            x -= 10560;
            bg = 0;
        } else {
            x -= 9648;
        } 
    } else if (zone == 3) {
        x -= 4992;
    } 
    if (act == 2) {
        zone += 1;
        act = 1;
    } else {
        act += 1;
    }
    alarm[0] = 1;
    bind_x = 640;
    bind_y = y;
    left_bound = 0;
} else if (showing_bonuses && time - bonuses_time > 4) {
    score += time_bonus + ring_bonus;
    time_bonus = 0;
    ring_bonus = 0;
}
if (showing_title && time - title_time > 3) {showing_title = false;}
if (showing_bonuses && zone == 2 && act == 2) {
    if (bg < 1) {    
        bg += 1 / 120;
        background_color = merge_color($DFAEE3, make_color_rgb(140, 74, 176), bg);
    }
}


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
} else if (boss) {
    if (!sound_isplaying(sound_boss)) {sound_play(sound_boss);}
} else if (super_sonic) {
    if (!sound_isplaying(sound_super_sonic)) {sound_play(sound_super_sonic);}
} else if (zone == 1) {
    if (!sound_isplaying(sound_extra_terrestrial)) {sound_play(sound_extra_terrestrial);} 
} else if (zone == 2) {
    if (!sound_isplaying(sound_martian)) {sound_play(sound_martian);} 
} else if (zone == 3) {
    if (!sound_isplaying(sound_pinball)) {sound_play(sound_pinball);} 
}


// Boss
if (x > room_width - 1280 && !boss_done_extra_terrestrial && zone == 1 && act = 2) {
    boss = true;
    left_bound = room_width - 1280;
    right_bound = 10400;
    top_bound = object_Dr_Robonic.y - 360;
    bottom_bound = object_Dr_Robonic.y + 360;
} else if (x > 8624 && x < 9648 && y < 2672 && !boss_done_martian && zone == 2 && act == 2) {
    boss = true;
    left_bound = 8368;
    right_bound = 9648;
    top_bound = 0;
    bottom_bound = room_height;
} else if (x > 6016 && !boss_done_pinball && zone == 3 && act == 2) {
    boss = true;
    left_bound = 6016;
    right_bound = 6912;
    top_bound = 0;
    bottom_bound = room_height;
}

if (boss) {
    if (place_meeting(x, y, object_Dr_Robonic) && !boss_hitting && !dead && !game_over) {
        boss_hit_time = time;
        boss_hit += 1;
        boss_hitting = true;
        if (zone == 1) {vspeed *= -1;}
        sound_play(sound_boss_hit);
    }
    if (zone == 3) {
        if (time - boss_hit_time > 1) {boss_hitting = false;}
    } else {
        if (time - boss_hit_time > 0.7) {boss_hitting = false;}
    }
} else {
    boss_hitting = false;
}

if (y > 1440 && boss_done_extra_terrestrial && zone == 1 && act == 2) {
    if (bg < 1) {    
        bg += 1 / 60;
        background_color = merge_color($000000, $DFAEE3, bg);
    }
}


// Pause
if (keyboard_check(vk_enter)) {
    sound_stop_all();
    message_alpha(0);
    show_message("");
}


// Kill
if (keyboard_check(ord("K")) && !been_killed) {
    been_killed = true;
    script_execute(script_die);
}
if (!keyboard_check(ord("K"))) {
    been_killed = false;
}


// Star
if ((place_meeting(x, y, object_Star) || place_meeting(x, y, object_Bouncer)) && !dead && !game_over) {
    with (object_Star) {
        if (place_meeting(x, y, other)) {instance_change(object_Star_Hit, true);}
    }
    with (object_Bouncer_Green) {
        if (place_meeting(x, y, other)) {instance_change(object_Bouncer_Lime, true);}
    }    
    with (object_Bouncer_Yellow) {
        if (place_meeting(x, y, other)) {instance_change(object_Bouncer_Orange, true);}
    }  
    with (object_Bouncer_Red) {
        if (place_meeting(x, y, other)) {instance_change(object_Bouncer_Gone, true);}
    }      
    hspeed *= -1;
    vspeed *= -1;
    score += 10;
    sound_play(sound_star);
} 


// Tornado
if (place_meeting(x, y, object_Tornado) && !dead && !game_over) {
    y -= 60;
}


// Destructible Block
if (place_meeting(x, y, object_Destructible_Block)) {
    if (spin) {
        sound_play(sound_boss_hit);
        with (object_Destructible_Block) {
            if (place_meeting(x, y, other)) {instance_change(object_Destructible_Block_Destroyed, false);}
        }
        facing = 1;
        if (zone == 2 && act == 1) {
            path_start(path_tunnel_martian_act_1, 20, 0, true);
        } else if (zone == 2 && act == 2) {
            path_start(path_tunnel_martian_act_2, 20, 0, true);
        }
    }
}


// Game Over
if (game_over) {
    game_over_time += 1 / 30;
    hspeed = 0;
    vspeed = 0;
}
if (game_over_time > 12) {game_restart();}


// Dead
if (dead) {
    dead_time += 1 / 30;
    hspeed = 0;
    vspeed = 0;
    if (dead_sonic_y < -300) {
        dead_sonic_speed += 5;
    }
    dead_sonic_y += dead_sonic_speed;
}
if (dead_time > 2) {script_dead();}


// Spring Woosh
if (place_meeting(x, y, object_Spring_Woosh)) {
    hspeed = 0;
    vspeed = 0;
    with (object_Spring_Woosh) {
        if (place_meeting(x, y, other)) {other.x = x + 24; other.y = y - 34;}
    }
    if (keyboard_check(vk_down) || keyboard_check(ord("S")) || keyboard_check(ord("A")) || keyboard_check(ord("D")) || keyboard_check(vk_space)) {
        with (object_Spring_Woosh) {
            if (place_meeting(x, y, other)) {
                if (other.woosh < 64) {
                    other.y += 1;
                    other.woosh += 1;
                }
            }
        }
    } else if (woosh > 0) {
        if (place_meeting(x, y, object_Tunnle_Pinball_Act1_T1)) {
            if (woosh > 16) {
                path_start(path_tunnle_pinball_act_1_t1, woosh, 0, true);
            } else {
                y -= 90;
            }
        } else if (place_meeting(x, y, object_Tunnle_Pinball_Act1_T3)) {
            if (woosh > 16) {
                path_start(path_tunnle_pinball_act_1_t3, woosh, 0, true);
            } else {
                y -= 90;
            }
        } else if (place_meeting(x, y, object_Tunnle_Pinball_Act2_T1)) {
            if (keyboard_check(vk_right)) {
                if (woosh > 16) {
                    path_start(path_tunnle_pinball_act_2_t1_p2, woosh, 0, true);
                } else {
                    y -= 90;
                }
            } else {
                if (woosh > 16) {
                    path_start(path_tunnle_pinball_act_2_t1_p3, woosh, 0, true);
                } else {
                    y -= 90;
                }
            }
        } else if (place_meeting(x, y, object_Tunnle_Pinball_Act2_T2)) {
            if (woosh > 24) {
                path_start(path_tunnle_pinball_act_2_t2_p2, woosh, 0, true);
            } else {
                y -= 90;
            }
        } else if (place_meeting(x, y, object_Tunnle_Pinball_Act2_T4)) {
            if (woosh > 16) {
                path_start(path_tunnle_pinball_act_2_t4, woosh, 0, true);
            } else {
                y -= 90;
            }
        } else if (act == 1 && y > 2016) {
            if (woosh < 40) {
                y -= 90;
                vspeed = -woosh;
            } else {
                path_start(path_tunnle_pinball_act_1_t2, woosh, 0, true);
            }
        } else {
            y -= 90;
            vspeed = -woosh;
        }
        woosh = 0;
        sound_play(sound_woosh);
    }    
}


// Tunnles
if (zone == 3 && act == 2) {
    if (path_index == -1) {
        if (x > 1280 && x < 1408 && y > 1888 && y < 1904) {
            path_start(path_tunnle_pinball_act_2_t1_p1, sonic_speed, 0, true);
        } else if (x > 2048 && x < 2176 && y > 2096 && y < 2160) {
            path_start(path_tunnle_pinball_act_2_t1_p4, sonic_speed, 0, true);
        } else if (x > 2272 && x < 2304 && y > 2144 && y < 2272) {
            path_start(path_tunnle_pinball_act_2_t1_p5, sonic_speed, 0, true);
        } else if (x > 1648 && x < 1664 && y > 2656 && y < 2748) {
            path_start(path_tunnle_pinball_act_2_t1_p6, sonic_speed, 0, true);
        } else if (x > 3088 && x < 3104 && y > 3024 && y < 3184) {
            path_start(path_tunnle_pinball_act_2_t2_p1, sonic_speed, 0, true);
        } else if (x > 3456 && x < 3584 && y > 2528 && y < 2544) {
            path_start(path_tunnle_pinball_act_2_t3_p1, sonic_speed, 0, true);
        } else if (x > 3968 && x < 4096 && y > 2528 && y < 2672) {
            path_start(path_tunnle_pinball_act_2_t3_p2, sonic_speed, 0, true);
        }
    }
}


// Credits
if (zone == 3 && act == 2 && x > 6576 && y > 2480) {
    depth = -80;
    fade_to_credits = (576 - (7152 - x)) / 576;
    if (fade_to_credits >= 1 || fade_to_credits < 0) {
        with (object_UI) {instance_destroy();}
        with (object_View) {instance_destroy();}
        room_goto(room_credits);
        instance_destroy();
    }
}


// Spiral
if (place_meeting(x, y, object_Spiral_Start)) {
    if (hspeed > 0 && path_index == -1) {
        with (object_Spiral) {
            if (place_meeting(x, y, other)) {
                other.x = x + 128;
                other.y = y + 480;
            }
        }
        path_start(path_spiral, 20, 0, false);
    }
} else if (place_meeting(x, y, object_Spiral_End)) {
    if (hspeed < 0 && path_index == -1) {
        with (object_Spiral) {
            if (place_meeting(x, y, other)) {
                other.x = x + 416;
                other.y = y + 480;
            }
        }
        path_start(path_spiral_reverse, 20, 0, false);
    }
}
#define script_draw
// script_draw
// Stefan Grace
// Created: 2018-01-07
// Modifed: 2021-02-15


// Sonic
if (game_over) {
    draw_set_font(font_game_over);
    draw_set_halign(fa_center);
    draw_set_valign(fa_middle);
    draw_text_color(view_xview[0] + 640, view_yview[0] + 360, "Game Over", c_white, c_white, c_black, c_black, 1);
    draw_set_valign(0);
} else if (dead) {
    draw_sprite(sprite_sonic_dead, 0, x, y + dead_sonic_y);
    if (dead_time > 1.5 && lives > 0) {
        draw_set_alpha(1 - ((2 - dead_time) * 2));
        draw_rectangle_color(x - 1920, y - 1080, x + 1920, y + 1080, c_black, c_black, c_black, c_black, false);
        draw_set_alpha(1);
    }
} else {
    if (shield) {
        draw_set_alpha(0.5);
        draw_ellipse_color(x - 50, y - 50, x + 50, y + 50, $FF8000, $FF1010, false);
        draw_set_alpha(1);
    }
    if (spin || jump || place_meeting (x, y, object_Tunnle) || path_index != -1) {
        draw_sprite_ext(sprite_sonic_spin, floor((time * 30) mod 5), round(x), round(y), facing, 1, 0, c_white, 1);
    } else if (crouch) {
        draw_sprite_ext(sprite_sonic_crouch, 0, round(x), round(y), facing, 1, 0, c_white, 1);
    } else if (flashing) {
        draw_sprite_ext(sprite_sonic_flash, floor((time * 10) mod 2), round(x), round(y), facing, 1, 0, c_white, 1);
    } else if (look_up) {
        draw_sprite_ext(sprite_sonic_look_up, 0, round(x), round(y), facing, 1, 0, c_white, 1);
    } else if (hspeed >= sonic_speed || hspeed <= sonic_speed * -1) {
        draw_sprite_ext(sprite_sonic_running, floor((time * 30) mod 5), round(x), round(y), facing, 1, 0, c_white, 1);
    } else if (hspeed != 0) {
        draw_sprite_ext(sprite_sonic_walking, floor((time * 15) mod 3), round(x), round(y), facing, 1, 0, c_white, 1);
    } else {
        draw_sprite_ext(sprite_sonic, 0, round(x), round(y), facing, 1, 0, c_white, 1);
    }
    if (super_sonic) {
        draw_sprite(sprite_super_sonic, floor((time * 10) mod 2), round(x), round(y));
    }
}

// Fade to Credits
if (fade_to_credits != 0) {
    draw_set_alpha(fade_to_credits);
    draw_rectangle_color(x - 1920, y - 720, x + 1280, y + 720, c_black, c_black, c_black, c_black, false);
    draw_set_alpha(1);
}
#define script_draw_ui
// script_draw_ui
// Stefan Grace
// Created: 2021-02-15
// Modified: 2021-02-16

/* Draws the UI at a shallower depth than the sonic by using a separate object,
so that foreground objects that appear in front of Sonic don't appear in front of UI */


var rings time minutes seconds time_color rings_color time_bonus ring_bonus zones zone act showing_bonuses showing_title;
rings = object_Sonic.rings;
time = object_Sonic.time;
minutes = object_Sonic.minutes;
seconds = object_Sonic.seconds;
time_color = object_Sonic.time_color;
rings_color = object_Sonic.rings_color;
time_bonus = object_Sonic.time_bonus;
ring_bonus = object_Sonic.ring_bonus;
zone = object_Sonic.zone;
act = object_Sonic.act;
showing_bonuses = object_Sonic.showing_bonuses;
showing_title = object_Sonic.showing_title;


// Display
draw_set_font(font_display);
draw_set_halign(fa_left);
draw_text_color(view_xview[0] + 50, view_yview[0] + 10, "Score: ", c_yellow, c_yellow, c_black, c_black, 1);
draw_text_color(view_xview[0] + 50, view_yview[0] + 40, "Time: ", time_color, time_color, c_black, c_black, 1);
draw_text_color(view_xview[0] + 50, view_yview[0] + 70, "Rings: ", rings_color, rings_color, c_black, c_black, 1);
draw_set_halign(fa_right);
draw_text_color(view_xview[0] + 240, view_yview[0] + 10, score, c_white, c_white, c_black, c_black, 1);
draw_text_color(view_xview[0] + 200, view_yview[0] + 40, string(minutes) + ":" + string(seconds), c_white, c_white, c_black, c_black, 1);
draw_text_color(view_xview[0] + 200, view_yview[0] + 70, rings, c_white, c_white, c_black, c_black, 1);
draw_sprite(sprite_lives,0, view_xview[0] + 50, view_yview[0] + 680);
draw_set_font(font_lives);
draw_set_halign(fa_left);
draw_text_color(view_xview[0] + 85, view_yview[0] + 680, "Sonic", c_yellow, c_yellow, c_black, c_black, 1);
draw_text_color(view_xview[0] + 85, view_yview[0] + 698, "x", c_white, c_white, c_black, c_black, 1);
draw_set_halign(fa_right);
draw_text_color(view_xview[0] + 130, view_yview[0] + 698, lives, c_white, c_white, c_black, c_black, 1);

// Bonuses
if (showing_bonuses) {
    draw_set_halign(fa_left);
    draw_set_font(font_title);
    draw_text_color(view_xview[0] + 300, view_yview[0] + 100, "Sonic Has Passed Act " + string(act), c_white, c_white, c_black, c_black, 1);
    draw_set_font(font_display);
    draw_text_color(view_xview[0] + 300, view_yview[0] + 250, "Score: ", c_yellow, c_yellow, c_black, c_black, 1);
    draw_text_color(view_xview[0] + 300, view_yview[0] + 300, "Time Bonus: ", c_yellow, c_yellow, c_black, c_black, 1);
    draw_text_color(view_xview[0] + 300, view_yview[0] + 350, "Ring Bonus: ", c_yellow, c_yellow, c_black, c_black, 1);
    draw_set_halign(fa_right);
    draw_text_color(view_xview[0] + 550, view_yview[0] + 250, score, c_white, c_white, c_black, c_black, 1);
    draw_text_color(view_xview[0] + 550, view_yview[0] + 300, time_bonus, c_white, c_white, c_black, c_black, 1);
    draw_text_color(view_xview[0] + 550, view_yview[0] + 350, ring_bonus, c_white, c_white, c_black, c_black, 1);
}

// Title
if (showing_title) {
    draw_set_halign(fa_center);
    draw_set_valign(fa_middle);
    draw_set_font(font_title);
    draw_text_color(view_xview[0] + 640, view_yview[0] + 360, string(object_Sonic.zones[zone]) + "#Zone Act " + string(act), c_white, c_white, c_black, c_black, 1);
    draw_set_valign(0);
}


#define script_view
// script_view
// Stefan Grace
// Created: 2018-01-07
// Modifed: 2021-02-13

if (!object_Sonic.showing_bonuses && !object_Sonic.boss) {
    x = object_Sonic.x;
    if (object_Sonic.boss_done_extra_terrestrial) {
        if (x < object_Sonic.left_bound + 640) {x = object_Sonic.left_bound + 640;}
    }
    if (object_Sonic.crouch){
        if (y < object_Sonic.y + 300) {y += 5;}
    } else if (object_Sonic.look_up) {
        if (y > object_Sonic.y - 300) {y -= 5;}
    } else {
        y = object_Sonic.y;
    }
    if (object_Sonic.zone == 1 && object_Sonic.act == 2) {
        if (!object_Sonic.boss_done_extra_terrestrial) {
            if (y > 1440) {y = 1440;}
        }
    }
}

if (object_Sonic.boss) {
    if (object_Sonic.zone == 1) {
        x = 9760;
        y = object_Dr_Robonic.y;
    } else if (object_Sonic.zone == 2) {
        x = 9008;
        if (object_Sonic.crouch){
            if (y < object_Sonic.y + 300) {y += 5;}
        } else if (object_Sonic.look_up) {
            if (y > object_Sonic.y - 300) {y -= 5;}
        } else {
            y = object_Sonic.y;
        }
    } else if (object_Sonic.zone == 3) {
        x = 6464;
        if (object_Sonic.crouch){
            if (y < object_Sonic.y + 300) {y += 5;}
        } else if (object_Sonic.look_up) {
            if (y > object_Sonic.y - 300) {y -= 5;}
        } else {
            y = object_Sonic.y;
        }
    }
}
#define script_die
// script_die
// Stefan Grace
// Created: 2018-01-07
// Modified: 2021-02-15


if (lives > 0 && !dead) {lives -= 1;}

if (!sound_isplaying(sound_die) && !dead) {sound_play(sound_die);}

depth = -80;

dead = true;

spin = 0;
jump = 0;

#define script_dead
// script_dead
// Stefan Grace
// Created: 2021-02-14
// Modified: 2021-02-14

if (lives > 0) {
    dead = false;
    dead_time = 0;
    dead_sonic_speed = -20;
    dead_sonic_y = 0;
    depth = -20;
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
    with (object_Ring) {instance_change(object_Ring_Got, false);}
    with (object_Ring_Got) {instance_change(object_Ring, false);}
    with (object_Mob_Dead) {instance_change(object_Mob, false);}
    with (object_Destructible_Block_Destroyed) {instance_change(object_Destructible_Block, false);}
    with (object_Rising_Platform) {y = ystart; vspeed = 0;}
    with (object_Moving_Platform) {x = xstart; y = ystart; hspeed = 0; vspeed = 0;}
    with (object_Gate_Open) {instance_change(object_Gate, false);}
    with (object_Gate_Open_Horizontal) {instance_change(object_Gate_Horizontal, false);}
    var i bouncers;
    bouncers[0] = object_Bouncer_Lime;
    bouncers[1] = object_Bouncer_Yellow;
    bouncers[2] = object_Bouncer_Orange;
    bouncers[3] = object_Bouncer_Red;
    bouncers[4] = object_Bouncer_Gone;
    for (i = 0; i < 5; i += 1) { 
        with (bouncers[i]) {
            switch (original_color) {
                case c_green: instance_change(object_Bouncer_Green, false); break;
                case c_yellow: instance_change(object_Bouncer_Yellow, false); break;
                case c_red: instance_change(object_Bouncer_Red, false); break;
            }
        }
        
    }
    if (zone == 1) {
        sound_play(sound_extra_terrestrial);
    } else if (zone == 2) {
        sound_play(sound_martian);
    } else if (zone == 3) {
        sound_play(sound_pinball);
    }
    showing_title = true;
    title_time = time;
    boss = false;
    boss_hit = 0;
    if (zone == 1) {
        with (object_Dr_Robonic) {
            vspeed = 0;
            y = ystart;
        }
    }
    left_bound = 0;
    right_bound = room_width
    top_bound = 0;
    bottom_bound = room_height;
    if (zone == 1 && act == 2) {
        if (boss_done_extra_terrestrial) {
            left_bound = room_width - 1280;
        } else {
            bottom_bound = 1800;
        }
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

#define script_stay_on_platform
// script_stay_on_platform
// Stefan Grace
// Created: 2021-01-19
// Modified: 2021-01-25
// Makes Sonic stay on moving platforms


var x_move y_move;
x_move = x - last_x;
y_move = y - last_y;

if (place_meeting(x, y - 8, object_Sonic)) {
    if (!object_Sonic.jump) {
        object_Sonic.x += x_move;
        object_Sonic.y += y_move;
    }
}

last_x = x;
last_y = y;
#define script_draw_platform_rock
// script_draw_platform_rock
// Stefan Grace
// Created: 2021-01-20
// Modified: 2021-01-20

draw_sprite(sprite_rock_left, 0, x, y);
draw_sprite(sprite_rock, 0, x + 32, y);
draw_sprite(sprite_rock, 0, x + 64, y);
draw_sprite(sprite_rock_right, 0, x + 96, y);
