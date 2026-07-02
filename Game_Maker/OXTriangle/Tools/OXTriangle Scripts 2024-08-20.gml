#define Press_Arrow
// Press_Arrow
// Stefan Grace
// Created: 2020-02-24
// Modified: 2020-02-24
// This script preforms the apporiate arrow key press events when an alternate input method is used

/* arguments
    argument0 - key

*/

if (keyboard_check(vk_left) or keyboard_check(vk_up) or keyboard_check(vk_right) or keyboard_check(vk_down)) exit
if (keyboard_check(ord("A")) + keyboard_check(ord("W")) + keyboard_check(ord("D")) + keyboard_check(ord("S")) > 1) exit 
event_perform(ev_keypress, argument0)/*
with (Rock) event_perform(ev_keypress, argument0)
with (Dimond) event_perform(ev_keypress, argument0)
with (Mud) event_perform(ev_keypress, argument0)*/
#define Press_Down
Press_Arrow(vk_down)
#define Press_Left
Press_Arrow(vk_left)
#define Press_Right
Press_Arrow(vk_right)
#define Press_Up
Press_Arrow(vk_up)
#define Joy
// Joy
// Stefan Grace
// Created: 2020-02-24
// Modified: 2020-02-24
// This script make it so you can use a joystick as arrow keys

/* arguments
    argument0 - key
*/

if (!global.joy_press) 
{
    Press_Arrow(argument0)
    global.joy_press = true
}
#define Joy_Left
Joy(vk_left)
#define Joy_Right
Joy(vk_right)
#define Joy_Up
Joy(vk_up)
#define Joy_Down
Joy(vk_down)
#define Character_Select
// Character_Select
// Stefan Grace
// Created: 2020-02-24
// Modified: 2020-02-24
// This script clycles through selecting characters when the enter key is pressed

repeat(2)
{
    var i;
    for (i = i_place; i < 22; i += 1)
    {
        var j;
        for (j = j_place; j < 38; j += 1)
        {
            var k;
            for (k = k_place; k <= 17; k += 17)
            {
                var l;
                for (l = l_place; l <= 17; l += 17)
                {
                    with (Black_Inactive)
                    {
                        if (y == (i*grid_size) + k and x == (j*grid_size) + l) 
                        {
                            if (character_id != 13) 
                            {
                                Character_Click_Black_Script()
                                exit
                            }
                            else 
                            {
                                G_Click_Black()
                                exit
                            }
                        }
                    }
                    with (Red_Inactive)
                    {
                        if (y == (i*grid_size) + k and x == (j*grid_size) + l) 
                        {
                            if (character_id != 13) 
                            {
                                Character_Click_Red_Script()
                                exit
                            }
                            else 
                            {
                                G_Click_Red()
                                exit
                            }
                        }
                    }
                    l_place = l + 17
                }
                l_place = 0
                k_place = k + 17
            }
            k_place = 0
            j_place = j + 1
        }
        j_place = 0
        i_place = i + 1
    }
    i_place = 0
}
#define Character_Select_Reverse
// Character_Select_Reverse
// Stefan Grace
// Created: 2020-02-24
// Modified: 2020-02-24
// This script clycles through in reverse selecting characters when the backspace key is pressed

repeat(2)
{
    var i;
    for (i = i_place; i >= 0; i -= 1)
    {
        var j;
        for (j = j_place; j >= 0; j -= 1)
        {
            var k;
            for (k = k_place; k >= 0; k -= 17)
            {
                var l;
                for (l = l_place; l >= 0; l -= 17)
                {
                    with (Black_Inactive)
                    {
                        if (y == (i*grid_size) + k and x == (j*grid_size) + l) 
                        {
                            if (character_id != 13) 
                            {
                                Character_Click_Black_Script()
                                exit
                            }
                            else 
                            {
                                G_Click_Black()
                                exit
                            }
                        }
                    }
                    with (Red_Inactive)
                    {
                        if (y == (i*grid_size) + k and x == (j*grid_size) + l) 
                        {
                            if (character_id != 13) 
                            {
                                Character_Click_Red_Script()
                                exit
                            }
                            else 
                            {
                                G_Click_Red()
                                exit
                            }
                        }
                    }
                    l_place = l - 17
                }
                l_place = 17
                k_place = k - 17
            }
            k_place = 17
            j_place = j - 1
        }
        j_place = 38
        i_place = i - 1
    }
    i_place = 22
}
#define Joy1
if (!Level_Number_Object.joy_button_press[1]) 
{
    Level_Number_Object.joy_button_press[1] = true
    event_perform(ev_keypress,vk_control)   
}

#define View_Alumax
// View Alumax
// Stefan Grace
// Created: 2015-06-26
// Modified: 2017-08-09
// This script is executed when the use clicks the 'View Alumax' link in the top left corner of a massage at the start of a level

var alumax_page;
if (global.levelnumber==1) alumax_page = 3
if (global.levelnumber==4) alumax_page = 100
if (global.levelnumber==5) alumax_page = 101
if (global.levelnumber==6) alumax_page = 4
if (global.levelnumber==9) alumax_page = 5
if (global.levelnumber==10) alumax_page = 102
if (global.levelnumber==11) alumax_page = 6
if (global.levelnumber==12) alumax_page = 103
if (global.levelnumber==13) alumax_page = 7
if (global.levelnumber==14) alumax_page = 104
if (global.levelnumber==15) alumax_page = 8
if (global.levelnumber==17) alumax_page = 105
if (global.levelnumber==18) alumax_page = 9
if (global.levelnumber==19) alumax_page = 106
if (global.levelnumber==20) alumax_page = 10
if (global.levelnumber==21) alumax_page = 11
if (global.levelnumber==22) alumax_page = 107
if (global.levelnumber==23) alumax_page = 12
if (global.levelnumber==25) alumax_page = 13
if (global.levelnumber==26) alumax_page = 108
if (global.levelnumber==27) alumax_page = 14
var file;
if (file_exists(working_directory+"\Alumax\Page.txt"))
{
    file = file_text_open_write(working_directory + "\Alumax\Page.txt")
}
file_text_write_real(file,alumax_page)
file_text_close(file)
script_execute(Alumax_Creation)


#define Alumax_Message
// Alumax Message
// Stefan Grace
// Created: I don't know
// Modified: 2020-02-10

show_message (global.text_alumax_message)
script_execute(Alumax_Creation)

/* UNUSED LINES OF CODE
show_message ("Alumax is not yet Implemented.#Coming Soon!!!")
*/
#define Alumax_Creation
// Alumax Creation
// Stefan Grace
// Created: 2015-06-16
// Modified: 2017-12-23

script_execute(Save_Global)
if (file_exists(working_directory+"\Alumax\Alumax.exe")) 
{
    execute_shell(working_directory+"\Alumax\Alumax.exe",0)
}

#define Big_G_Mask
// Big_G_Mask
// Stefan Grace
// Created: 2018-10-23
// Modified: 2018-10-24
// This scirpt updates the mask for Gigga G and Terror G

if (g_type == 1)
{
    if (mask_index != Gigga_Colission_Mask) mask_index = Gigga_Colission_Mask
}
if (g_type == 2)
{
    if (mask_index != Terror_Colission_Mask) mask_index = Terror_Colission_Mask
}
#define Big_G_Movable_Detect
if (argument0 != 0)
{

}
var movable;
movable = true
var i;
for (i = 0; i < Get_G_Size(g_type); i += grid_size)
{ 
    with(Yellow)
    {
        if (x == other.x + argument0 and y == other.y + i)
        {
            movable = false
        }
    }
}

return movable
#define Big_W_Drain_Life
if (Red_Blue_G.g_hit > 4 or Red_Blue_G.g_hit > 4) exit
g_hit -= 1
Red_Blue_G.g_hit += 1
Black_Blue_G.g_hit += 1
score -= 1
#define Big_W_Give_Life
if (g_hit >= Get_Max_Hits(g_type)) exit
g_hit += 1
Red_Blue_G.g_hit -= 1
Black_Blue_G.g_hit -= 1
score -= 1
#define Big_W_Life_Give_Script
// Big_W_Life_Give_Script
// Stefan Grace
// Created: 2018-11-01
// Modified: 2018-11-01


global.big_w_life_giving = true
with(Message_Object) instance_destroy()
global.message_type = 23
script_execute(Local_Message_Create)


#define Big_W_Lifedrain
// Big_W_Lifedrain
// Stefan Grace
// Created: 2017-12-21
// Modified: 2018-11-01

if (g_type!=3) exit

global.big_w_life_draining = false;
global.big_w_life_giving = false;
with(Move_Message) instance_destroy()

var x_jump;
var y_jump;
var i;
var j;
var g_in_range;
g_in_range = false
for (j = 0; j < 4; j+= 1)
{
    switch(j)
    {
        case 0:
            x_jump = 1 * grid_size
            y_jump = 0 * grid_size
            break
        case 1:
            x_jump = 0 * grid_size
            y_jump = 1 * grid_size
            break
        case 2:
            x_jump = -1 * grid_size
            y_jump = 0 * grid_size
            break
        case 3:
            x_jump = 0 * grid_size
            y_jump = -1 * grid_size
            break
    }
    for (i = 1; i <= 5; i += 1)
    {
        if (!place_meeting(x + (x_jump * i), y + (y_jump * i), Yellow))
        {
            i = 6
        }
        if (place_meeting(x + (x_jump * i), y + (y_jump * i), Red_Stuned_G))
        or (place_meeting(x + (x_jump * i), y + (y_jump * i), Black_Stuned_G))
        or (place_meeting(x + (x_jump * i), y + (y_jump * i), Red_G))
        or (place_meeting(x + (x_jump * i), y + (y_jump * i), Black_G))
        {
            g_in_range = true;
            
        }
    }
}

if (g_in_range)
{
    global.message_type = 24
    script_execute(Local_Message_Create)
    instance_create(Message_Object.x + 100, Message_Object.y + 50, Life_Drain_Button)
    instance_create(Message_Object.x + 100, Message_Object.y + 105, Life_Give_Button)
}
else
{
    show_message(global.text_no_g_in_range)
}


/*
with(all)
{
    if (character_id==13 and g_type!=3 and other.g_hit<=4)
    {
        if (place_meeting(x+grid_size,y,other) and argument0==0)
        or (place_meeting(x,y+grid_size,other) and argument0==1)
        or (place_meeting(x-grid_size,y,other) and argument0==2)
        or (place_meeting(x,y-grid_size,other) and argument0==3)
        {
            g_hit -= 1
            other.g_hit += 1
            score -= 1
        }
    }
}
*/
#define Big_W_Lifedrain_Script
// Big_W_Lifedrain_Script
// Stefan Grace
// Created: 2018-10-31
// Modified: 2018-10-31


global.big_w_life_draining = true
with(Message_Object) instance_destroy()
global.message_type = 23
script_execute(Local_Message_Create)


#define Big_W_Port
// Big_W_Port
// Stefan Grace
// Created: 2017-12-21
// Modified: 2020-02-11
// This script allows Big W to go thoug a Teleport


var port_side;
var port_color;

with(Teleport) if (place_meeting(x,y,other)) 
{
    port_side = side
    port_color = color
    with(Teleport) if (side!=port_side and color==port_color)
    {
        Red_Blue_G.x = x
        Red_Blue_G.y = y
        Black_Blue_G.x = x
        Black_Blue_G.y = y
    }
}
#define Big_W_Range_Detect
// Big_W_Range_Detect
// Stefan Grace
// Created: 2018-11-01
// Modified: 2018-11-04
// This script returns weather there is a blue Big W within range

return Character_Range_Detect(2)

#define Blue_Attack_G
// Blue_Attack_G
// Stefan Grace
// Created: 2020-02-10
// Modified: 2020-02-10

// Makes a stunned G, Gigga G or Terror lose a hit when a blue (clicked on) 
// character enters any of tiles that it is on

/* arguments
    argument0 = stun (S)
        true = stun
        false = kill
*/

g_size = Get_G_Size(g_type)
var i;
for (i = 0; i < g_size; i += grid_size) 
{
    var j;
    for (j = 0; j < g_size; j += grid_size) 
    {
        if (x + i == other.x and y + j == other.y) 
        {
            if (argument0) 
            {
                S_Stuned = 1
            }
            else 
            {
                g_hit -= 1
            }
        }
    }
}
#define Blue_Attack_G_Teleport
// Blue_Attack_G_Teleport
// Stefan Grace
// Created: 2020-02-14
// Modified: 2020-02-14
// This script blue (clicked on) characters attack or stun G or Big W in the other side of a teleport

/* arguments
    argument0 = stun (S)
        true = stun
        false = kill
        
    argument1 = teleport color
*/


with(Teleport)
{
    if (place_meeting(x,y,other) and color == argument1)
    {
        with(other)
        {
            if (argument0) 
            {
                S_Stuned = 1
            }
            else 
            {
                g_hit -= 1
            }
        }
    }
}
#define G_Die
// G_Die
// Stefan Grace
// Created: 2017-08-07
// Modified: 2017-08-07
// This scipt makes G's die when they have less than 1 hit left

if (g_hit<1) instance_destroy()
#define G_Draw
// G_Draw
// Stefan Grace
// Created: 2017-08-07
// Modified: 2018-11-01
// This script draws out G's with the right amount of hits in the right color

/* arguments
   
     argument0 - color
        0 - Blue
        1 - Red
        2 - Black
        3 - Green                
        4 - Yellow
        5 - Purple
        6 - Dark Blue

*/

if (S_Stuned>0 and g_type != 1 and g_type != 2) draw_sprite_ext(Ice,0,x-1,y-1,2,2,0,c_white,1) 

if (g_type==0) // G
{
    if (argument0==0)
    {
        if (g_hit==1) draw_sprite(G_Bl_1hit,0,x,y)
        if (g_hit==2) draw_sprite(G_Bl_2hit,0,x,y)
        if (g_hit==3) draw_sprite(G_Bl_3hit,0,x,y)
    }
    else if (argument0==1)
    {
        if (g_hit==1) draw_sprite(G_R_1hit,0,x,y)
        if (g_hit==2) draw_sprite(G_R_2hit,0,x,y)
        if (g_hit==3) draw_sprite(G_R_3hit,0,x,y)
    }
    else if (argument0==2)
    {
        if (g_hit==1) draw_sprite(G_B_1hit,0,x,y)
        if (g_hit==2) draw_sprite(G_B_2hit,0,x,y)
        if (g_hit==3) draw_sprite(G_B_3hit,0,x,y)
    }
    else if (argument0==3)
    {
        if (g_hit==1) draw_sprite(G_G_1hit,0,x,y)
        if (g_hit==2) draw_sprite(G_G_2hit,0,x,y)
        if (g_hit==3) draw_sprite(G_G_3hit,0,x,y)
    }
    else if (argument0==4)
    {
        if (g_hit==1) draw_sprite(G_Y_1hit,0,x,y)
        if (g_hit==2) draw_sprite(G_Y_2hit,0,x,y)
        if (g_hit==3) draw_sprite(G_Y_3hit,0,x,y)
    }
    else if (argument0==5)
    {
        if (g_hit==1) draw_sprite(G_P_1hit,0,x,y)
        if (g_hit==2) draw_sprite(G_P_2hit,0,x,y)
        if (g_hit==3) draw_sprite(G_P_3hit,0,x,y)
    }
    else if (argument0==6)
    {
        if (g_hit==1) draw_sprite(G_DB_1hit,0,x,y)
        if (g_hit==2) draw_sprite(G_DB_2hit,0,x,y)
        if (g_hit==3) draw_sprite(G_DB_3hit,0,x,y)
    }
}
else if (g_type==1) // Gigga G 
{
    
    if (place_meeting(x,y,Mud))
    {
        draw_sprite(Gigga_Mud,0,x,y)
    }
    else if (place_meeting(x,y,Rock))
    {
        draw_sprite(Gigga_Rock,0,x,y)
    }
    else if (place_meeting(x,y,Dimond))
    {
        draw_sprite(Gigga_Dimond,0,x,y)
    }
    else if (place_meeting(x,y,Concreet))
    {
        draw_sprite(Gigga_Concreet,0,x,y)
    }
    else 
    {
        draw_sprite(Gigga_Yellow,0,x,y)
    }
    if (S_Stuned>0)
    {
        draw_sprite_ext(Ice,0,x-2,y-2,4,4,0,c_white,1)
    }
    if (argument0==0)
    {
        if (g_hit==1) draw_sprite(GiggaG_Bl_1hit,0,x,y)
        if (g_hit==2) draw_sprite(GiggaG_Bl_2hit,0,x,y)
        if (g_hit==3) draw_sprite(GiggaG_Bl_3hit,0,x,y)
        if (g_hit==4) draw_sprite(GiggaG_Bl_4hit,0,x,y)
        if (g_hit==5) draw_sprite(GiggaG_Bl_5hit,0,x,y)
    }
    else if (argument0==1)
    {
        if (g_hit==1) draw_sprite(GiggaG_R_1hit,0,x,y)
        if (g_hit==2) draw_sprite(GiggaG_R_2hit,0,x,y)
        if (g_hit==3) draw_sprite(GiggaG_R_3hit,0,x,y)
        if (g_hit==4) draw_sprite(GiggaG_R_4hit,0,x,y)
        if (g_hit==5) draw_sprite(GiggaG_R_5hit,0,x,y)
    }
    else if (argument0==2)
    {
        if (g_hit==1) draw_sprite(GiggaG_B_1hit,0,x,y)
        if (g_hit==2) draw_sprite(GiggaG_B_2hit,0,x,y)
        if (g_hit==3) draw_sprite(GiggaG_B_3hit,0,x,y)
        if (g_hit==4) draw_sprite(GiggaG_B_4hit,0,x,y)
        if (g_hit==5) draw_sprite(GiggaG_B_5hit,0,x,y)
    }
    else if (argument0==3)
    {
        if (g_hit==1) draw_sprite(GiggaG_G_1hit,0,x,y)
        if (g_hit==2) draw_sprite(GiggaG_G_2hit,0,x,y)
        if (g_hit==3) draw_sprite(GiggaG_G_3hit,0,x,y)
        if (g_hit==4) draw_sprite(GiggaG_G_4hit,0,x,y)
        if (g_hit==5) draw_sprite(GiggaG_G_5hit,0,x,y)
    }
}
else if (g_type==2) // Tera G
{

    if (place_meeting(x,y,Mud))
    {
        draw_sprite(Terror_Mud,0,x,y)
    }
    else if (place_meeting(x,y,Rock))
    {
        draw_sprite(Terror_Rock,0,x,y)
    }
    else if (place_meeting(x,y,Dimond))
    {
        draw_sprite(Terror_Dimond,0,x,y)
    }
    else if (place_meeting(x,y,Concreet))
    {
        draw_sprite(Terror_Concreet,0,x,y)
    }
    else 
    {
        draw_sprite(Terror_Yellow,0,x,y)
    }
    if (S_Stuned>0)
    {
        draw_sprite_ext(Ice,0,x-4,y-4,8,8,0,c_white,1)
    }
    if (argument0==0)
    {
        if (g_hit==1) draw_sprite(Terror_G_Bl_1hit,0,x,y)
        if (g_hit==2) draw_sprite(Terror_G_Bl_2hit,0,x,y)
        if (g_hit==3) draw_sprite(Terror_G_Bl_3hit,0,x,y)
        if (g_hit==4) draw_sprite(Terror_G_Bl_4hit,0,x,y)
        if (g_hit==5) draw_sprite(Terror_G_Bl_5hit,0,x,y)
        if (g_hit==6) draw_sprite(Terror_G_Bl_6hit,0,x,y)
        if (g_hit==7) draw_sprite(Terror_G_Bl_7hit,0,x,y)
        if (g_hit==8) draw_sprite(Terror_G_Bl_8hit,0,x,y)
        if (g_hit==9) draw_sprite(Terror_G_Bl_9hit,0,x,y)
        if (g_hit==10) draw_sprite(Terror_G_Bl_10hit,0,x,y)
    }
    else if (argument0==1)
    {
        if (g_hit==1) draw_sprite(Terror_G_R_1hit,0,x,y)
        if (g_hit==2) draw_sprite(Terror_G_R_2hit,0,x,y)
        if (g_hit==3) draw_sprite(Terror_G_R_3hit,0,x,y)
        if (g_hit==4) draw_sprite(Terror_G_R_4hit,0,x,y)
        if (g_hit==5) draw_sprite(Terror_G_R_5hit,0,x,y)
        if (g_hit==6) draw_sprite(Terror_G_R_6hit,0,x,y)
        if (g_hit==7) draw_sprite(Terror_G_R_7hit,0,x,y)
        if (g_hit==8) draw_sprite(Terror_G_R_8hit,0,x,y)
        if (g_hit==9) draw_sprite(Terror_G_R_9hit,0,x,y)
        if (g_hit==10) draw_sprite(Terror_G_R_10hit,0,x,y)
    }
    else if (argument0==2)
    {
        if (g_hit==1) draw_sprite(Terror_G_B_1hit,0,x,y)
        if (g_hit==2) draw_sprite(Terror_G_B_2hit,0,x,y)
        if (g_hit==3) draw_sprite(Terror_G_B_3hit,0,x,y)
        if (g_hit==4) draw_sprite(Terror_G_B_4hit,0,x,y)
        if (g_hit==5) draw_sprite(Terror_G_B_5hit,0,x,y)
        if (g_hit==6) draw_sprite(Terror_G_B_6hit,0,x,y)
        if (g_hit==7) draw_sprite(Terror_G_B_7hit,0,x,y)
        if (g_hit==8) draw_sprite(Terror_G_B_8hit,0,x,y)
        if (g_hit==9) draw_sprite(Terror_G_B_9hit,0,x,y)
        if (g_hit==10) draw_sprite(Terror_G_B_10hit,0,x,y)
    }
    else if (argument0==3)
    {
        if (g_hit==1) draw_sprite(Terror_G_G_1hit,0,x,y)
        if (g_hit==2) draw_sprite(Terror_G_G_2hit,0,x,y)
        if (g_hit==3) draw_sprite(Terror_G_G_3hit,0,x,y)
        if (g_hit==4) draw_sprite(Terror_G_G_4hit,0,x,y)
        if (g_hit==5) draw_sprite(Terror_G_G_5hit,0,x,y)
        if (g_hit==6) draw_sprite(Terror_G_G_6hit,0,x,y)
        if (g_hit==7) draw_sprite(Terror_G_G_7hit,0,x,y)
        if (g_hit==8) draw_sprite(Terror_G_G_8hit,0,x,y)
        if (g_hit==9) draw_sprite(Terror_G_G_9hit,0,x,y)
        if (g_hit==10) draw_sprite(Terror_G_G_10hit,0,x,y)
    }
}
else // Big W
{
    if (argument0==0)
    {
        if (g_hit==1) draw_sprite(Big_W_Bl_1hit,0,x,y)
        if (g_hit==2) draw_sprite(Big_W_Bl_2hit,0,x,y)
        if (g_hit==3) draw_sprite(Big_W_Bl_3hit,0,x,y)
        if (g_hit==4) draw_sprite(Big_W_Bl_4hit,0,x,y)
        if (g_hit==5) draw_sprite(Big_W_Bl_5hit,0,x,y)
    }
    else if (argument0==1)
    {
        if (g_hit==1) draw_sprite(Big_W_R_1hit,0,x,y)
        if (g_hit==2) draw_sprite(Big_W_R_2hit,0,x,y)
        if (g_hit==3) draw_sprite(Big_W_R_3hit,0,x,y)
        if (g_hit==4) draw_sprite(Big_W_R_4hit,0,x,y)
        if (g_hit==5) draw_sprite(Big_W_R_5hit,0,x,y)
    }
    else if (argument0==2)
    {
        if (g_hit==1) draw_sprite(Big_W_B_1hit,0,x,y)
        if (g_hit==2) draw_sprite(Big_W_B_2hit,0,x,y)
        if (g_hit==3) draw_sprite(Big_W_B_3hit,0,x,y)
        if (g_hit==4) draw_sprite(Big_W_B_4hit,0,x,y)
        if (g_hit==5) draw_sprite(Big_W_B_5hit,0,x,y)
    }
    else if (argument0==3)
    {
        if (g_hit==1) draw_sprite(Big_W_G_1hit,0,x,y)
        if (g_hit==2) draw_sprite(Big_W_G_2hit,0,x,y)
        if (g_hit==3) draw_sprite(Big_W_G_3hit,0,x,y)
        if (g_hit==4) draw_sprite(Big_W_G_4hit,0,x,y)
        if (g_hit==5) draw_sprite(Big_W_G_5hit,0,x,y)
    }
    else if (argument0==4)
    {
        if (g_hit==1) draw_sprite(Big_W_Y_1hit,0,x,y)
        if (g_hit==2) draw_sprite(Big_W_Y_2hit,0,x,y)
        if (g_hit==3) draw_sprite(Big_W_Y_3hit,0,x,y)
        if (g_hit==4) draw_sprite(Big_W_Y_4hit,0,x,y)
        if (g_hit==5) draw_sprite(Big_W_Y_5hit,0,x,y)
    }
    else if (argument0==5)
    {
        if (g_hit==1) draw_sprite(Big_W_P_1hit,0,x,y)
        if (g_hit==2) draw_sprite(Big_W_P_2hit,0,x,y)
        if (g_hit==3) draw_sprite(Big_W_P_3hit,0,x,y)
        if (g_hit==4) draw_sprite(Big_W_P_4hit,0,x,y)
        if (g_hit==5) draw_sprite(Big_W_P_5hit,0,x,y)
    }
    else if (argument0==6)
    {
        if (g_hit==1) draw_sprite(Big_W_DB_1hit,0,x,y)
        if (g_hit==2) draw_sprite(Big_W_DB_2hit,0,x,y)
        if (g_hit==3) draw_sprite(Big_W_DB_3hit,0,x,y)
        if (g_hit==4) draw_sprite(Big_W_DB_4hit,0,x,y)
        if (g_hit==5) draw_sprite(Big_W_DB_5hit,0,x,y)
    }
}
#define G_Explode
// G_Explode
// Stefan Grcae
// Created: 2018-10-25
// Modified: 2018-11-08
// This script makes explosions take 1 hit off a G, Gigga G or Terror G

if (place_meeting(x,y,other)) 
{
    if (instance_number(NWH_Explosion_Center) > 0)
    {
        instance_destroy()
    }
    else 
    {
        if (!been_exploded) 
        {
            g_hit -= 1
            been_exploded = true;
            alarm[0] = 3
        }
    }
}
    

#define G_Fight
// G_Fight
// Stefan Grace
// Created: 2018-10-25
// Modified: 2018-10-25
// This script makes G's loose hits or die when they interact with the opponent's G of a differnt size

if(place_meeting(x,y,other))
{
    hits_to_be_removed = other.g_hit
    other.hits_to_be_removed = g_hit
    if (other.g_hit - other.hits_to_be_removed > 0) 
    {
        other.g_hit -= other.hits_to_be_removed
    }
    else
    {
        other.alarm[1] = 1
    }
    if (g_hit - hits_to_be_removed > 0) 
    {
        g_hit -= hits_to_be_removed
    }
    else
    {
        alarm[1] = 1
    }
}

#define G_Kill_Own_G
if (place_meeting(x,y,other))
{
	var g_rank;
	if (g_type == 3)
	{
		g_rank = -1
	}
	else
	{
		g_rank = g_type
	}
	var other_g_rank
	if (other.g_type == 3)
	{
		other_g_rank = -1
	}
	else
	{
		other_g_rank = other.g_type
	}
	if (other_g_rank > g_rank)
	{
		instance_destroy()
	}
	else
	{
		with(other) instance_destroy()
	}
}
#define G_Move
// G_Move
// Stefan Grace
// Created: 2016-08-23
// Modified: 2020-02-24
// This script controls G, Gigga G, Terror G and Big W

/* arguments

argument0 = Direction
    0 = Left
    1 = Up
    2 = Right
    3 = Down
*/


if (global.game_frozen>0) exit
if (instance_number(Level_Cover) > 0) exit

if (S_Stuned>0) 
{
    show_message (global.text_s_stun)
    exit
}

// Stop the player pressing 2 arrow keys at once
if (Key_Mash_Detect(argument0)) exit

if (g_type==3) // Big W
{
    // Barria
    if (argument0==0) and (place_meeting(x,y,Barria_Vertical)) exit
    if (argument0==1) and (place_meeting(x,y,Barria_Horizontal)) exit
    if (argument0==2) and (place_meeting(x+grid_size,y,Barria_Vertical)) exit
    if (argument0==3) and (place_meeting(x,y+grid_size,Barria_Horizontal)) exit
    // Arrow
    if (argument0==0) and ((place_meeting(x-35,y,Right_Arrow)) or (place_meeting(x-35,y,Horizontal_Arrow))) exit
    if (argument0==1) and ((place_meeting(x,y-35,Down_Arrow)) or (place_meeting(x,y-35,Vertical_Arrow))) exit
    if (argument0==2) and ((place_meeting(x+35,y,Left_Arrow)) or (place_meeting(x+35,y,Horizontal_Arrow))) exit
    if (argument0==3) and ((place_meeting(x,y+35,Up_Arrow)) or (place_meeting(x,y+35,Vertical_Arrow))) exit
    if (!(argument0==0)) and (place_meeting(x,y,Left_Arrow)) exit 
    if (!(argument0==1)) and (place_meeting(x,y,Up_Arrow)) exit 
    if (!(argument0==2)) and (place_meeting(x,y,Right_Arrow)) exit 
    if (!(argument0==3)) and (place_meeting(x,y,Down_Arrow)) exit 
    if ((argument0==0) or (argument0==2)) and (place_meeting(x,y,Vertical_Arrow)) exit
    if ((argument0==1) or (argument0==3)) and (place_meeting(x,y,Horizontal_Arrow)) exit
}

if (place_meeting(x,y,Mud)) exit

var X_Jump;
var Y_Jump;
X_Jump = 0
Y_Jump = 0
if (argument0==0) X_Jump = 0-grid_size
if (argument0==1) Y_Jump = 0-grid_size
if (argument0==2) X_Jump = grid_size
if (argument0==3) Y_Jump = grid_size

if (g_type==3) // Big W
{
    // Boulder
    if (argument0==0) or (argument0==2)
    {
        if (place_meeting(x+X_Jump,y+Y_Jump,Boulder)) and (!(place_meeting(x+X_Jump*2,y+Y_Jump,Yellow))) exit
        if (place_meeting(x+X_Jump,y+Y_Jump,Boulder)) and (place_meeting(x+X_Jump*2,y+Y_Jump,Boulder)) and (!(place_meeting(x+X_Jump*3,y+Y_Jump,Yellow))) exit
        if (place_meeting(x+X_Jump,y+Y_Jump,Boulder)) and (place_meeting(x+X_Jump*2,y+Y_Jump,Boulder)) and (place_meeting(x+X_Jump*3,y+Y_Jump,Boulder)) and (!(place_meeting(x+X_Jump*4,y+Y_Jump,Yellow))) exit
        if (place_meeting(x+X_Jump,y+Y_Jump,Boulder)) and (place_meeting(x+X_Jump*2,y+Y_Jump,Boulder)) and (place_meeting(x+X_Jump*3,y+Y_Jump,Boulder)) and (place_meeting(x+X_Jump*4,y+Y_Jump,Boulder)) and (!(place_meeting(x+X_Jump*5,y+Y_Jump,Yellow))) exit
        if (place_meeting(x+X_Jump,y+Y_Jump,Boulder)) and (place_meeting(x+X_Jump,y+Y_Jump,Mud)) exit
    }
    if (argument0==1) or (argument0==3)
    {
        if (place_meeting(x+X_Jump,y+Y_Jump,Boulder)) exit
    }
    if (argument0==2) and (place_meeting(x+X_Jump,y,Boulder)) and ((place_meeting(x+X_Jump*2,y,Left_Arrow)) or (place_meeting(x+X_Jump*2,y,Horizontal_Arrow))) exit
    if (argument0==0) and (place_meeting(x+X_Jump,y,Boulder)) and ((place_meeting(x+X_Jump*2,y,Right_Arrow)) or (place_meeting(x+X_Jump*2,y,Horizontal_Arrow))) exit
    if (argument0==2) and (place_meeting(x+X_Jump,y,Boulder)) and (place_meeting(x+X_Jump*2,y,Barria_Vertical)) exit
    if (argument0==0) and (place_meeting(x+X_Jump,y,Boulder)) and (place_meeting(x+X_Jump,y,Barria_Vertical)) exit
    if (argument0==2) and (place_meeting(x+X_Jump,y,Boulder)) and ((place_meeting(x+X_Jump,y,Left_Arrow)) or (place_meeting(x+X_Jump,y,Horizontal_Arrow))) exit
    if (argument0==0) and (place_meeting(x+X_Jump,y,Boulder)) and ((place_meeting(x+X_Jump,y,Right_Arrow)) or (place_meeting(x+X_Jump,y,Horizontal_Arrow))) exit
    if ((argument0==0) or (argument0==2)) and (place_meeting(x+X_Jump,y,Boulder)) and ((place_meeting(x+X_Jump,y,Up_Arrow)) or (place_meeting(x+X_Jump,y,Horizontal_Arrow))) exit
    if ((argument0==0) or (argument0==2)) and (place_meeting(x+X_Jump,y,Boulder)) and ((place_meeting(x+X_Jump,y,Down_Arrow)) or (place_meeting(x+X_Jump,y,Horizontal_Arrow))) exit
    if ((argument0==0) or (argument0==2)) and (place_meeting(x+X_Jump,y,Boulder)) and ((place_meeting(x+X_Jump,y,Vertical_Arrow)) or (place_meeting(x+X_Jump,y,Horizontal_Arrow))) exit
    // Anger Colors
    if (place_meeting(x+X_Jump,y+Y_Jump,Red_Anger))
    {
        score = 1+1
        background_index[0] = -1
        background_color = c_red
        Kill = 1
        RockTunnle = 0
        DimondTunnle = 0
        script_execute(Red_Stun)
        script_execute(Black_Stun)
        global.anger = 1
    }
    if (place_meeting(x+X_Jump,y+Y_Jump,Orange_Anger))
    {
        score = 1+1
        background_index[0] = -1
        background_color = $4080FF
        Kill = 0
        RockTunnle = 1
        DimondTunnle = 0
        script_execute(Red_Stun)
        script_execute(Black_Stun)
        global.anger = 1
    }
    if (place_meeting(x+X_Jump,y+Y_Jump,Blue_Anger))
    {
        score = 1+1
        background_index[0] = -1
        background_color = $FFFF00
        Kill = 0
        RockTunnle = 0
        DimondTunnle = 1
        script_execute(Red_Stun)
        script_execute(Black_Stun)
        global.anger = 1
    }
    if (place_meeting(x+X_Jump,y+Y_Jump,Purple_Anger))
    {
        score = 1+1
        background_index[0] = -1
        background_color = $FF00FF
        Kill = 1
        RockTunnle = 1
        DimondTunnle = 1
        script_execute(Red_Stun)
        script_execute(Black_Stun)
        global.anger = 1
    }
    // Anger Numbers
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_00)) score = 0+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_02)) score = 2+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_03)) score = 3+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_04)) score = 4+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_05)) score = 5+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_06)) score = 6+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_07)) score = 7+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_08)) score = 8+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_09)) score = 9+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_10)) score = 10+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_11)) score = 11+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_12)) score = 12+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_13)) score = 13+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_14)) score = 14+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_15)) score = 15+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_16)) score = 16+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_17)) score = 17+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_18)) score = 18+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_19)) score = 19+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_20)) score = 20+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_21)) score = 21+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_22)) score = 22+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_23)) score = 23+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_24)) score = 24+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_25)) score = 25+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_26)) score = 26+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_27)) score = 27+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_28)) score = 28+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_29)) score = 29+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_30)) score = 30+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_31)) score = 31+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_32)) score = 32+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_33)) score = 33+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_34)) score = 34+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_35)) score = 35+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_36)) score = 36+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_37)) score = 37+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_38)) score = 38+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_39)) score = 39+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_40)) score = 40+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_41)) score = 41+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_42)) score = 42+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_43)) score = 43+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_44)) score = 44+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_45)) score = 45+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_46)) score = 46+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_47)) score = 47+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_48)) score = 48+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_49)) score = 49+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_50)) score = 50+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_51)) score = 51+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_52)) score = 52+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_53)) score = 53+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_54)) score = 54+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_55)) score = 55+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_56)) score = 56+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_57)) score = 57+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_58)) score = 58+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_59)) score = 59+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_60)) score = 60+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_61)) score = 61+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_62)) score = 62+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_63)) score = 63+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_64)) score = 64+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_65)) score = 65+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_66)) score = 66+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_67)) score = 67+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_68)) score = 68+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_69)) score = 69+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_70)) score = 70+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_71)) score = 71+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_72)) score = 72+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_73)) score = 73+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_74)) score = 74+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_75)) score = 75+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_76)) score = 76+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_77)) score = 77+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_78)) score = 78+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_79)) score = 79+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_80)) score = 80+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_81)) score = 81+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_82)) score = 82+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_83)) score = 83+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_84)) score = 84+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_85)) score = 85+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_86)) score = 86+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_87)) score = 87+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_88)) score = 88+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_89)) score = 89+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_90)) score = 90+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_91)) score = 91+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_92)) score = 92+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_93)) score = 93+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_94)) score = 94+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_95)) score = 95+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_96)) score = 96+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_97)) score = 97+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_98)) score = 98+1
    if (place_meeting(x+X_Jump,y+Y_Jump,Anger_99)) score = 99+1
    // Rock and Dimond
    if (RockTunnle>0) with (Rock) if (place_meeting(x,y,other)) instance_destroy()
    if (DimondTunnle>0) with (Dimond) if (place_meeting(x,y,other)) instance_destroy()
    // Own Characters
    var character_detect;
    with(Character)
    {
        if (((player==1 and other.player==1) or (player==2 and other.player==2)) and place_meeting(x-X_Jump,y-Y_Jump,other) and character_id!=13) character_detect = true
    }
    var big_w_player;
    big_w_player = player
    with(Teleport) // Stops Big W getting into teleport if there is own character in other side and makes Big W interact with opponent's character on other side
    {
        if (place_meeting(x-X_Jump,y-Y_Jump,other))
        {
            var port_color;
            var port_side;
            port_color = color
            port_side = side
            with (Teleport)
            {
                if (color==port_color and side!=port_side)
                {
                    with (Character)
                    {
                        if (place_meeting(x,y,other))
                        {
                            if ((player==1 and big_w_player==1) or (player==2 and big_w_player==2) or g_type==3) character_detect = true
                            if (((player==1 and big_w_player==2) or (player==2 and big_w_player==1)) and !character_detect) alarm[11] = 2
                        }
                    }
                }
            }
        }
    }
    if (character_detect) exit
}

if (g_type == 1)
{
    X_Jump *= 2
    Y_Jump *= 2
}
if (g_type == 2)
{
    X_Jump *= 4
    Y_Jump *= 4
}

var g_in_the_way;
g_in_the_way = false
with(Red_Stuned_G)
{
    if (g_type == other.g_type)
    {
        var g_size;
        switch(g_type)
        {
            case 1:
                g_size = 2
                break
            case 2:
                g_size = 4
                break
            default:
                g_size = 1
                break
        }
        var other_g_size;
        switch(other.g_type)
        {
            case 1:
                other_g_size = 2
                break
            case 2:
                other_g_size = 4
                break
            default:
                other_g_size = 1
                break
        }
        if (argument0==0) 
        {
            if (x + (g_size * grid_size) == other.x and y >= other.y - ((g_size - 1) * grid_size) and y <= other.y + ((other_g_size - 1) * grid_size)) g_in_the_way = true
        }
        else if (argument0==2)
        {
            if (x - (other_g_size * grid_size) == other.x and y >= other.y - ((g_size - 1) * grid_size) and y <= other.y + ((other_g_size - 1) * grid_size)) g_in_the_way = true
        }
        else if (argument0==1)
        {
            if (y + (g_size * grid_size) == other.y and x >= other.x - ((g_size - 1) * grid_size) and x <= other.x + ((other_g_size - 1) * grid_size)) g_in_the_way = true
        }
        else if (argument0==3)
        {
            if (y - (other_g_size * grid_size) == other.y and x >= other.x - ((g_size - 1) * grid_size) and x <= other.x + ((other_g_size - 1) * grid_size)) g_in_the_way = true
        }
    }
}
with(Red_G)
{
    if (g_type == other.g_type)
    {
        var g_size;
        switch(g_type)
        {
            case 1:
                g_size = 2
                break
            case 2:
                g_size = 4
                break
            default:
                g_size = 1
                break
        }
        var other_g_size;
        switch(other.g_type)
        {
            case 1:
                other_g_size = 2
                break
            case 2:
                other_g_size = 4
                break
            default:
                other_g_size = 1
                break
        }
        if (argument0==0) 
        {
            if (x + (g_size * grid_size) == other.x and y >= other.y - ((g_size - 1) * grid_size) and y <= other.y + ((other_g_size - 1) * grid_size)) g_in_the_way = true
        }
        else if (argument0==2)
        {
            if (x - (other_g_size * grid_size) == other.x and y >= other.y - ((g_size - 1) * grid_size) and y <= other.y + ((other_g_size - 1) * grid_size)) g_in_the_way = true
        }
        else if (argument0==1)
        {
            if (y + (g_size * grid_size) == other.y and x >= other.x - ((g_size - 1) * grid_size) and x <= other.x + ((other_g_size - 1) * grid_size)) g_in_the_way = true
        }
        else if (argument0==3)
        {
            if (y - (other_g_size * grid_size) == other.y and x >= other.x - ((g_size - 1) * grid_size) and x <= other.x + ((other_g_size - 1) * grid_size)) g_in_the_way = true
        }
    }
}
with(Black_Stuned_G)
{
    if (g_type == other.g_type)
    {
        var g_size;
        switch(g_type)
        {
            case 1:
                g_size = 2
                break
            case 2:
                g_size = 4
                break
            default:
                g_size = 1
                break
        }
        var other_g_size;
        switch(other.g_type)
        {
            case 1:
                other_g_size = 2
                break
            case 2:
                other_g_size = 4
                break
            default:
                other_g_size = 1
                break
        }
        if (argument0==0) 
        {
            if (x + (g_size * grid_size) == other.x and y >= other.y - ((g_size - 1) * grid_size) and y <= other.y + ((other_g_size - 1) * grid_size)) g_in_the_way = true
        }
        else if (argument0==2)
        {
            if (x - (other_g_size * grid_size) == other.x and y >= other.y - ((g_size - 1) * grid_size) and y <= other.y + ((other_g_size - 1) * grid_size)) g_in_the_way = true
        }
        else if (argument0==1)
        {
            if (y + (g_size * grid_size) == other.y and x >= other.x - ((g_size - 1) * grid_size) and x <= other.x + ((other_g_size - 1) * grid_size)) g_in_the_way = true
        }
        else if (argument0==3)
        {
            if (y - (other_g_size * grid_size) == other.y and x >= other.x - ((g_size - 1) * grid_size) and x <= other.x + ((other_g_size - 1) * grid_size)) g_in_the_way = true
        }
    }
}
with(Black_G)
{
    if (g_type == other.g_type)
    {
        var g_size;
        switch(g_type)
        {
            case 1:
                g_size = 2
                break
            case 2:
                g_size = 4
                break
            default:
                g_size = 1
                break
        }
        var other_g_size;
        switch(other.g_type)
        {
            case 1:
                other_g_size = 2
                break
            case 2:
                other_g_size = 4
                break
            default:
                other_g_size = 1
                break
        }
        if (argument0==0) 
        {
            if (x + (g_size * grid_size) == other.x and y >= other.y - ((g_size - 1) * grid_size) and y <= other.y + ((other_g_size - 1) * grid_size)) g_in_the_way = true
        }
        else if (argument0==2)
        {
            if (x - (other_g_size * grid_size) == other.x and y >= other.y - ((g_size - 1) * grid_size) and y <= other.y + ((other_g_size - 1) * grid_size)) g_in_the_way = true
        }
        else if (argument0==1)
        {
            if (y + (g_size * grid_size) == other.y and x >= other.x - ((g_size - 1) * grid_size) and x <= other.x + ((other_g_size - 1) * grid_size)) g_in_the_way = true
        }
        else if (argument0==3)
        {
            if (y - (other_g_size * grid_size) == other.y and x >= other.x - ((g_size - 1) * grid_size) and x <= other.x + ((other_g_size - 1) * grid_size)) g_in_the_way = true
        }
    }
}
with(Green_G) 
{
    if (g_type >= other.g_type)
    {
        var g_size;
        switch(g_type)
        {
            case 1:
                g_size = 2
                break
            case 2:
                g_size = 4
                break
            default:
                g_size = 1
                break
        }
        var other_g_size;
        switch(other.g_type)
        {
            case 1:
                other_g_size = 2
                break
            case 2:
                other_g_size = 4
                break
            default:
                other_g_size = 1
                break
        }
        if (argument0==0) 
        {
            if (x + (g_size * grid_size) == other.x and y >= other.y - ((g_size - 1) * grid_size) and y <= other.y + ((other_g_size - 1) * grid_size)) g_in_the_way = true
        }
        else if (argument0==2)
        {
            if (x - (other_g_size * grid_size) == other.x and y >= other.y - ((g_size - 1) * grid_size) and y <= other.y + ((other_g_size - 1) * grid_size)) g_in_the_way = true
        }
        else if (argument0==1)
        {
            if (y + (g_size * grid_size) == other.y and x >= other.x - ((g_size - 1) * grid_size) and x <= other.x + ((other_g_size - 1) * grid_size)) g_in_the_way = true
        }
        else if (argument0==3)
        {
            if (y - (other_g_size * grid_size) == other.y and x >= other.x - ((g_size - 1) * grid_size) and x <= other.x + ((other_g_size - 1) * grid_size)) g_in_the_way = true
        }
    }
}

// Makes G lose hits when there is a character that can attack it on the other side of a teleport
var gX_Jump gY_Jump;
gX_Jump = X_Jump / (Get_G_Size(g_type) / grid_size)
gY_Jump = Y_Jump / (Get_G_Size(g_type) / grid_size)
show_debug_message(string(gX_Jump)+" "+string(gY_Jump))
if (place_meeting(x+gX_Jump,y+gY_Jump,Teleport)) 
{
    var killers_in_port;
    killers_in_port = 0
    var g_player;
    if (instance_number(Go_Number_Red)>0) g_player = 1
    if (instance_number(Go_Number_Black)>0) g_player = 2
    var other_g_type;
    other_g_type = g_type
    var other_g_hit;
    other_g_hit = g_hit
    with(Teleport)
    {
        if (place_meeting(x-gX_Jump,y-gY_Jump,other))
        {
            var port_color;
            var port_side;
            port_color = color
            port_side = side
            with (Teleport)
            {
                if (color==port_color and side!=port_side)
                {
                    with (Character)
                    {
                        if (place_meeting(x,y,other))
                        {
                            switch(character_id)
                            {   case 13:
                                    if (g_type == other_g_type)
                                    { 
                                        exit
                                    }
                                    else 
                                    {
                                        if (player != g_player) 
                                        {
                                            killers_in_port += g_hit
                                            g_hit -= other_g_hit
                                        }
                                        else
                                        {
                                            instance_destroy()
                                        }
                                    }
                                    break 
                                case 1:
                                case 2:
                                case 3:
                                case 7:
                                case 9:
                                case 14:
                                case 20:
                                    if (player != g_player)
                                    {
                                        killers_in_port += 1
                                    }
                                    break
                            }
                        }
                    }
                }
            }
        }
    }
    g_hit -= killers_in_port
}

if (((place_meeting(x+X_Jump,y+Y_Jump,Yellow) 
or place_meeting(x+X_Jump,y+Y_Jump,Rock) 
or place_meeting(x+X_Jump,y+Y_Jump,Dimond) 
or place_meeting(x+X_Jump,y+Y_Jump,Concreet)
or place_meeting(x+X_Jump,y+Y_Jump,Double_Boxing)) 
and g_type!=3) or (place_meeting(x+X_Jump,y+Y_Jump,Yellow) or (place_meeting(x+X_Jump,y+Y_Jump,Rock) and RockTunnle>0) or (place_meeting(x+X_Jump,y+Y_Jump,Dimond) and DimondTunnle>0) and g_type==3))
and (!g_in_the_way)
{
    if (g_type == 1)
    {
        X_Jump /= 2
        Y_Jump /= 2
    }
    if (g_type == 2)
    {
        X_Jump /= 4
        Y_Jump /= 4
    }
    // Steel
    if (place_meeting(x+X_Jump,y+Y_Jump,Steel)) exit
    // Gates
    var gate_in_the_way;
    gate_in_the_way = false
    if (argument0==0) with (Barria_Vertical) if (place_meeting(x,y,other) and gate) gate_in_the_way = true
    if (argument0==1) with (Barria_Horizontal) if (place_meeting(x,y,other) and gate) gate_in_the_way = true
    if (argument0==2) with (Barria_Vertical) if (place_meeting(x-X_Jump,y,other) and gate) gate_in_the_way = true
    if (argument0==3) with (Barria_Horizontal) if (place_meeting(x,y-Y_Jump,other) and gate) gate_in_the_way = true 
    if (g_type == 1 or g_type == 2) // to make it so Big G's can't get through adjacent barriers
    {
        if (argument0==0 or argument0==2) with (Barria_Horizontal) if (place_meeting(x-X_Jump,y,other) and place_meeting(x-X_Jump,y-grid_size,other) and gate) gate_in_the_way = true 
        if (argument0==1 or argument0==3) with (Barria_Vertical) if (place_meeting(x,y-Y_Jump,other) and place_meeting(x-grid_size,y-Y_Jump,other) and gate) gate_in_the_way = true 
    }
    if (gate_in_the_way) exit
    //////// DOES THE ACTUAL MOVEMENT /////////
    x += X_Jump
    y += Y_Jump
    ///////////////////////////////////////////
    if (Kill==0)
    {
        if (instance_number(Go_Number_Black)>0)
        {
            if (place_meeting(x,y,Red_Stuned_X)) g_hit -= 1
            if (place_meeting(x,y,Red_Stuned_Triangle)) g_hit -= 1
            if (place_meeting(x,y,Red_Stuned_A)) g_hit -= 1
            if (place_meeting(x,y,Red_Stuned_E)) g_hit -= 1
            if (place_meeting(x,y,Red_Stuned_S)) S_Stuned = 1
            if (place_meeting(x,y,Red_Stuned_H)) g_hit -= 1
            if (place_meeting(x,y,Red_Stuned_C)) g_hit -= 1
            if (place_meeting(x,y,Red_Stuned_P)) g_hit -= 1
            with(Red_Stuned_G) script_execute(G_Fight)
            with(Black_G) script_execute(G_Kill_Own_G)
        }
        if (instance_number(Go_Number_Red)>0)
        {
            if (place_meeting(x,y,Black_Stuned_X)) g_hit -= 1
            if (place_meeting(x,y,Black_Stuned_Triangle)) g_hit -= 1
            if (place_meeting(x,y,Black_Stuned_A)) g_hit -= 1
            if (place_meeting(x,y,Black_Stuned_E)) g_hit -= 1
            if (place_meeting(x,y,Black_Stuned_S)) S_Stuned = 1
            if (place_meeting(x,y,Black_Stuned_H)) g_hit -= 1
            if (place_meeting(x,y,Black_Stuned_C)) g_hit -= 1
            if (place_meeting(x,y,Black_Stuned_P)) g_hit -= 1
            with(Black_Stuned_G) script_execute(G_Fight)
            with(Red_G) script_execute(G_Kill_Own_G)
        }
    }
    if (g_type!=3) 
    {
        script_execute(Object_Destroy)
        with (Teleport) if (place_meeting(x,y,other)) alarm[1] = 1
    }
    script_execute(Character_Explosion_Destroy)
    with (Concreet) if (place_meeting(x,y,other)) instance_destroy()
    with (Red_Stuned_Pi) if (place_meeting(x,y,other)) instance_destroy()
    with (Red_Pi) if (place_meeting(x,y,other)) instance_destroy()
    with (Black_Stuned_Pi) if (place_meeting(x,y,other)) instance_destroy()
    with (Black_Pi) if (place_meeting(x,y,other)) instance_destroy()
    with (Green_Pi) if (place_meeting(x,y,other)) instance_destroy()
    with (Green_G) if (place_meeting(x,y,other)) instance_destroy()
    if (argument0==0) with (Barria_Vertical) if (place_meeting(x+X_Jump,y,other)) instance_destroy()
    if (argument0==1) with (Barria_Horizontal) if (place_meeting(x,y+Y_Jump,other)) instance_destroy()
    if (argument0==2) with (Barria_Vertical) if (place_meeting(x,y,other)) instance_destroy()
    if (argument0==3) with (Barria_Horizontal) if (place_meeting(x,y,other)) instance_destroy() 
    if (g_type == 1 or g_type == 2) // to make it so Big G's destroy adjacent barriers
    {
        if (argument0==0 or argument0==2) with (Barria_Horizontal) if (place_meeting(x,y,other) and place_meeting(x,y-grid_size,other)) instance_destroy()
        if (argument0==1 or argument0==3) with (Barria_Vertical) if (place_meeting(x,y,other) and place_meeting(x-grid_size,y,other)) instance_destroy()
    }
    if (!place_meeting(x,y,Yellow)) instance_create(x,y,Yellow)
    if (g_type == 1) // to make Gigga G's leave yellow behind them
    {
        instance_create(x+grid_size,y,Yellow)
        instance_create(x,y+grid_size,Yellow)
        instance_create(x+grid_size,y+grid_size,Yellow)
    } 
    if (g_type == 2) // to make Terror G's leave yellow behind them
    {
        var i;
        for (i = 0; i < 4; i += 1)
        {
            var j;
            for (j = 0; j < 4; j += 1)
            {
                instance_create(x + (grid_size * i), y + (grid_size * j), Yellow)
            }
        }
    } 
    score -= 1
}
#define Get_G_Size
// Get_G_Size
// Stefan Grace
// Created: 2018-11-01
// Modified: 2018-11-01

/* arguments
    argument0 - g_type
        0 - Normal G
        1 - Gigga G
        2 - Terror G
        3 - Big W
*/


var g_size;
switch(argument0)
{
    case 1:
        g_size = grid_size * 2
        break
    case 2:
        g_size = grid_size * 4
        break
    default:
        g_size = grid_size
        break
}
return g_size
#define Get_Max_Hits
var max_hits;
switch(argument0)
{
    case 0:
        max_hits = 3
        break
    case 1:
        max_hits = 5
        break
    case 2:
        max_hits = 10
        break
    case 3:
        max_hits = 5
        break
}
return max_hits
#define Make_Big_W
// Make_Big_W
// Stefan Grace
// Created: 2017-12-20
// Modified: 2017-12-20


g_type = 3
g_hit = 1
#define Make_Gigga_G
// Make_Gigga_G
// Stefan Grace
// Created: 2017-12-14
// Modified: 2017-12-14


g_type = 1
g_hit = 5
#define Make_Terror_G
// Make_Terror_G
// Stefan Grace
// Created: 2018-10-24
// Modified: 2018-10-24


g_type = 2
g_hit = 10
#define G_Click_Black
if (global.big_w_life_draining)
{
    if (Big_W_Range_Detect()) Big_W_Drain_Life() 
}
else if (global.big_w_life_giving)
{
    if (Big_W_Range_Detect()) Big_W_Give_Life() 
}
else if (global.Black_B_Killing_Left+global.Black_B_Killing_Up+global.Black_B_Killing_Right+global.Black_B_Killing_Down == 0)
{
    Character_Click_Black()
    if (!global.at_swapping > 0 and !global.big_w_life_draining and !global.w_casting and instance_number(Level_Cover) == 0)
    {
        instance_change(Black_Blue_G, false)
    }
}
#define G_Click_Red
if (global.big_w_life_draining)
{
    if (Big_W_Range_Detect()) Big_W_Drain_Life() 
}
else if (global.big_w_life_giving)
{
    if (Big_W_Range_Detect()) Big_W_Give_Life() 
}
else if (global.Red_B_Killing_Left+global.Red_B_Killing_Up+global.Red_B_Killing_Right+global.Red_B_Killing_Down == 0)
{
    Character_Click_Red()
    if (!global.at_swapping > 0 and !global.big_w_life_draining and !global.w_casting and instance_number(Level_Cover) == 0)
    {
        instance_change(Red_Blue_G, false)
    }
}
#define Pi_Move
// Pi_Move
// Stefan Grace
// Created: 2017-08-15
// Modified: 2020-02-24

/* arguments

argument0 = Direction
    0 = Left
    1 = Up
    2 = Right
    3 = Down
*/


// Game Frozen
if (global.game_frozen>0) exit

// $ Stuned
if (S_Stuned>0) exit

// Stop the player pressing 2 arrow keys at once
if (Key_Mash_Detect(argument0)) exit

// Barria
if (argument0==0) and (place_meeting(x,y,Barria_Vertical)) exit
if (argument0==1) and (place_meeting(x,y,Barria_Horizontal)) exit
if (argument0==2) and (place_meeting(x+grid_size,y,Barria_Vertical)) exit
if (argument0==3) and (place_meeting(x,y+grid_size,Barria_Horizontal)) exit

// Arrow
if (argument0==0) and ((place_meeting(x-35,y,Right_Arrow)) or (place_meeting(x-35,y,Horizontal_Arrow))) exit
if (argument0==1) and ((place_meeting(x,y-35,Down_Arrow)) or (place_meeting(x,y-35,Vertical_Arrow))) exit
if (argument0==2) and ((place_meeting(x+35,y,Left_Arrow)) or (place_meeting(x+35,y,Horizontal_Arrow))) exit
if (argument0==3) and ((place_meeting(x,y+35,Up_Arrow)) or (place_meeting(x,y+35,Vertical_Arrow))) exit
if (!(argument0==0)) and (place_meeting(x,y,Left_Arrow)) exit 
if (!(argument0==1)) and (place_meeting(x,y,Up_Arrow)) exit 
if (!(argument0==2)) and (place_meeting(x,y,Right_Arrow)) exit 
if (!(argument0==3)) and (place_meeting(x,y,Down_Arrow)) exit 
if ((argument0==0) or (argument0==2)) and (place_meeting(x,y,Vertical_Arrow)) exit
if ((argument0==1) or (argument0==3)) and (place_meeting(x,y,Horizontal_Arrow)) exit

// Sets X_Jump and Y_Jump
var X_Jump;
var Y_Jump;
X_Jump = 0
Y_Jump = 0
if (argument0==0) X_Jump = -35
if (argument0==1) Y_Jump = -35
if (argument0==2) X_Jump = 35
if (argument0==3) Y_Jump = 35

// Detect Character
var character_detect;
with(all)
{
    if ((character_id>0 or character_o>0) and place_meeting(x-X_Jump,y-Y_Jump,other)) character_detect = true
}
if (character_detect) exit

// Angers
if place_meeting(x+X_Jump,y+Y_Jump,Red_Anger)
or place_meeting(x+X_Jump,y+Y_Jump,Orange_Anger)
or place_meeting(x+X_Jump,y+Y_Jump,Blue_Anger)
or place_meeting(x+X_Jump,y+Y_Jump,Purple_Anger)
{
    exit
}

// Teleport
if (place_meeting(x+X_Jump,y+Y_Jump,Teleport)) exit

// Boulder
if (argument0==0) or (argument0==2)
{
    if (place_meeting(x+X_Jump,y+Y_Jump,Boulder)) and (!(place_meeting(x+X_Jump*2,y+Y_Jump,Yellow))) exit
    if (place_meeting(x+X_Jump,y+Y_Jump,Boulder)) and (place_meeting(x+X_Jump*2,y+Y_Jump,Boulder)) and (!(place_meeting(x+X_Jump*3,y+Y_Jump,Yellow))) exit
    if (place_meeting(x+X_Jump,y+Y_Jump,Boulder)) and (place_meeting(x+X_Jump*2,y+Y_Jump,Boulder)) and (place_meeting(x+X_Jump*3,y+Y_Jump,Boulder)) and (!(place_meeting(x+X_Jump*4,y+Y_Jump,Yellow))) exit
    if (place_meeting(x+X_Jump,y+Y_Jump,Boulder)) and (place_meeting(x+X_Jump*2,y+Y_Jump,Boulder)) and (place_meeting(x+X_Jump*3,y+Y_Jump,Boulder)) and (place_meeting(x+X_Jump*4,y+Y_Jump,Boulder)) and (!(place_meeting(x+X_Jump*5,y+Y_Jump,Yellow))) exit
    if (place_meeting(x+X_Jump,y+Y_Jump,Boulder)) and (place_meeting(x+X_Jump,y+Y_Jump,Mud)) exit
}
if (argument0==1) or (argument0==3)
{
    if (place_meeting(x+X_Jump,y+Y_Jump,Boulder)) exit
}
if (argument0==2) and (place_meeting(x+X_Jump,y,Boulder)) and ((place_meeting(x+X_Jump*2,y,Left_Arrow)) or (place_meeting(x+X_Jump*2,y,Horizontal_Arrow))) exit
if (argument0==0) and (place_meeting(x+X_Jump,y,Boulder)) and ((place_meeting(x+X_Jump*2,y,Right_Arrow)) or (place_meeting(x+X_Jump*2,y,Horizontal_Arrow))) exit
if (argument0==2) and (place_meeting(x+X_Jump,y,Boulder)) and (place_meeting(x+X_Jump*2,y,Barria_Vertical)) exit
if (argument0==0) and (place_meeting(x+X_Jump,y,Boulder)) and (place_meeting(x+X_Jump,y,Barria_Vertical)) exit
if (argument0==2) and (place_meeting(x+X_Jump,y,Boulder)) and ((place_meeting(x+X_Jump,y,Left_Arrow)) or (place_meeting(x+X_Jump,y,Horizontal_Arrow))) exit
if (argument0==0) and (place_meeting(x+X_Jump,y,Boulder)) and ((place_meeting(x+X_Jump,y,Right_Arrow)) or (place_meeting(x+X_Jump,y,Horizontal_Arrow))) exit
if ((argument0==0) or (argument0==2)) and (place_meeting(x+X_Jump,y,Boulder)) and ((place_meeting(x+X_Jump,y,Up_Arrow)) or (place_meeting(x+X_Jump,y,Horizontal_Arrow))) exit
if ((argument0==0) or (argument0==2)) and (place_meeting(x+X_Jump,y,Boulder)) and ((place_meeting(x+X_Jump,y,Down_Arrow)) or (place_meeting(x+X_Jump,y,Horizontal_Arrow))) exit
if ((argument0==0) or (argument0==2)) and (place_meeting(x+X_Jump,y,Boulder)) and ((place_meeting(x+X_Jump,y,Vertical_Arrow)) or (place_meeting(x+X_Jump,y,Horizontal_Arrow))) exit

// Yellow
if (place_meeting(x+X_Jump,y+Y_Jump,Yellow))
{
    with (Concreet)
    {
        if (place_meeting(x,y,other))
        {
            x += X_Jump
            y += Y_Jump
        }
    }
    instance_create(x,y,Yellow)
    x += X_Jump
    y += Y_Jump
    score -= 1
    with (Yellow)
    {
        if (place_meeting(x,y,other)) instance_destroy()
    }
    if (place_meeting(x,y,Mud)) 
    {
        with (Mud)
        {
            if (place_meeting(x,y,other)) instance_destroy()
        }
        instance_destroy()
    }
    exit
}

// Concreet
if (place_meeting(x+X_Jump,y+Y_Jump,Concreet))
{
    x += X_Jump
    y += Y_Jump
    score -= 1
    exit
}
#define Pi_Draw
// Pi_Draw
// Stefan Grace
// Created: 2017-08-15
// Modified: 2017-12-23
// This script draws Pi's out in the right color

/* arguments

    argument0 - state
        0 - Red Stuned
        1 - Red
        2 - Red Blue
        3 - Black Stuned
        4 - Black
        5 - Black Blue
        6 - Green
*/


if (S_Stuned>0) draw_sprite_ext(Ice,0,x-1,y-1,2,2,0,c_white,1) 

var color;
if (argument0==0)
{
    if (global.dollar_sign_stunning>0 and mouse_x>x and mouse_x<x+sprite_width and mouse_y>y and mouse_y<y+sprite_height) 
    {
        color = character_color_blue
    }
    else
    {
        if (purple==0) color = character_color_red else color = character_color_purple
    }
}
if (argument0==1)
{
    if (mouse_x>x and mouse_x<x+sprite_width and mouse_y>y and mouse_y<y+sprite_height)
    {
        color = character_color_blue
    }
    else if (purple==0)
    {
        color = character_color_red
    }
    else
    {
        color = character_color_purple
    }
}
if (argument0==2 or argument0==5) color = character_color_blue
if (argument0==3)
{
    if (global.dollar_sign_stunning>0 and mouse_x>x and mouse_x<x+sprite_width and mouse_y>y and mouse_y<y+sprite_height) 
    {
        color = character_color_blue
    }
    else
    {
        if (purple==0) color = character_color_black else color = character_color_dark_blue
    }
}
if (argument0==4)
{
    if (mouse_x>x and mouse_x<x+sprite_width and mouse_y>y and mouse_y<y+sprite_height)
    {
        color = character_color_blue
    }
    else if (purple==0)
    {
        color = character_color_black
    }
    else
    {
        color = character_color_dark_blue
    }
}
if (argument0==6) color = character_color_green

if (color==character_color_red) draw_sprite(Red_Pi_Sprite,0,x,y)
if (color==character_color_black) draw_sprite(Black_Pi_Sprite,0,x,y)
if (color==character_color_blue) draw_sprite(Blue_Pi,0,x,y)
if (color==character_color_green) draw_sprite(Green_Pi_Sprite,0,x,y)
if (color==character_color_purple) draw_sprite(Purple_Pi,0,x,y)
if (color==character_color_dark_blue) draw_sprite(Dark_Blue_Pi,0,x,y)

#define Pi_Step
// Pi_Step
// Stefan Grace
// Created: 2017-08-15
// Modified: 2017-09-24
// This script is executed on all Pi's every step

if (place_meeting(x,y,Boulder)) script_execute(Boulder_Crush_Blue)
#define Boulder_Fall
// Boulder_Fall
// Stefan Grace
// Created: 2017-07-31
// Modified: 2024-07-29
// This script make bouders and bombs fall and get pushed

// Mud
if (place_meeting(x,y,Mud))
{
    bomb_fall = 0
    global.game_frozen = 0 
    falling = 0
    fall_step = 0
    catapulted = 0
    exit
}

// Push
repeat(36)
{
    // Black Blue
    if (place_meeting(x,y,Black_Blue) and !place_meeting(x,y,Black_Blue_Y))
    // Red Blue
    or (place_meeting(x,y,Red_Blue) and !place_meeting(x,y,Red_Blue_Y)) 
    // Boulder
    or place_meeting(x,y,Boulder)
    {
        if (left_pressed) {x -= grid_size;}
        if (right_pressed) {x += grid_size;}
    }
}

// Stops the bomb/ boulder falling when there is an object in the way
if place_meeting(x,y+grid_size,Boulder)
or place_meeting(x,y+grid_size,Double_Boxing)
or place_meeting(x,y+grid_size,Up_Arrow)
or place_meeting(x,y+grid_size,Vertical_Arrow)
or place_meeting(x,y,Left_Arrow)
or place_meeting(x,y,Right_Arrow)
or place_meeting(x,y,Horizontal_Arrow)
or place_meeting(x,y,Up_Arrow)
or place_meeting(x,y+grid_size,Barria_Horizontal)
or place_meeting(x,y+grid_size,Black_Blue_Y)
or place_meeting(x,y+grid_size,Red_Blue_Y)
or place_meeting(x,y+grid_size,Black_Y)
or place_meeting(x,y+grid_size,Red_Y)
or place_meeting(x,y+grid_size,Black_Stuned_Y)
or place_meeting(x,y+grid_size,Red_Stuned_Y)
or place_meeting(x,y+grid_size,Green_Y)
{
    script_execute(Bomb_Detonate)
    bomb_fall = 0
    global.game_frozen = 0 
    falling = 0
    fall_step = 0
    catapulted = 0
    exit
}

// Stops the bomb/ boulder falling when there is a G in the way and takes 1 hit off the G
if place_meeting(x,y+grid_size,Red_Stuned_G)
or place_meeting(x,y+grid_size,Red_G)
or place_meeting(x,y+grid_size,Black_Stuned_G)
or place_meeting(x,y+grid_size,Black_G)
or place_meeting(x,y+grid_size,Red_Blue_G)
or place_meeting(x,y+grid_size,Black_Blue_G)
or place_meeting(x,y+grid_size,Green_G)

{
    if (falling>0) 
    {
        with (Red_G) if (place_meeting(x,y-grid_size,other) and place_meeting(x,y,Yellow)) g_hit -= 1
        with (Black_Stuned_G) if (place_meeting(x,y-grid_size,other) and place_meeting(x,y,Yellow)) g_hit -= 1
        with (Black_G) if (place_meeting(x,y-grid_size,other) and place_meeting(x,y,Yellow)) g_hit -= 1
        with (Red_Blue_G) if (place_meeting(x,y-grid_size,other) and place_meeting(x,y,Yellow)) g_hit -= 1
        with (Black_Blue_G) if (place_meeting(x,y-grid_size,other) and place_meeting(x,y,Yellow)) g_hit -= 1
        with (Green_G) if (place_meeting(x,y-grid_size,other) and place_meeting(x,y,Yellow)) g_hit -= 1
    }
    script_execute(Bomb_Detonate)
    bomb_fall = 0
    global.game_frozen = 0 
    falling = 0
    fall_step = 0
    catapulted = 0
    exit
}

// Fall
if (!place_meeting(x,y+grid_size,Character) or falling>0 or catapulted>0)
{
    if (place_meeting(x,y+grid_size,Yellow) or (bomb_fall>0 and ((place_meeting(x,y+grid_size,Rock) and rock_tunnle>0) or (place_meeting(x,y+grid_size,Dimond) and dimond_tunnle>0) or (place_meeting(x,y+grid_size,Concreet) and concreet_tunnle>0))))
    {
        if (fall_step==0) 
        {        
            global.game_frozen = 1
            falling = 1
            if (!(sound_isplaying(Boulder_Sound) or global.boulder_sound_playing)) 
            {
                sound_play(Boulder_Sound) 
                global.boulder_sound_playing = true
                alarm[2] = 60
            }
            if (place_meeting(x,y+grid_size,Yellow)) bomb_fall += 1 else bomb_fall -= 1
            y += grid_size
        }
        fall_step += 1
        if (fall_step==3) fall_step = 0
    }
    else
    {
        script_execute(Bomb_Detonate)
        global.game_frozen = 0 
        falling = 0
        catapulted = 0
    }
}
#define Time_Bomb_Script
// Time_Bomb_Script
// Stefan Grace
// Created: 2017-09-03
// Modified: 2018-11-08
// This script controls Time Bombs

if (time_bomb==0) exit

// Makes the countdown decrease by 1 each turn if the time bomb has been set
if (set==0) exit
if (score==0)
{
    score_has_gone_above_0 = 0
    {
        if (score_has_reached_0==0)
        {
            countdown -= 1
            score_has_reached_0 = 2
        }
    }
}
if (score>0 and score_has_gone_above_0==0 and score_has_reached_0>0) 
{
    score_has_gone_above_0 = 1
    score_has_reached_0 -= 1
}

// Makes the bomb explode when the countdown would reach -1
if (countdown<0)
{
    instance_create(x+17,y+17,Explosion_M_Object)
    if (!(sound_isplaying(M_Sound))) sound_play(M_Sound)
    instance_create(x,y,Time_Bomb_Explosion_Center)
    instance_destroy()
}

#define Time_Bomb_Set
// Time_Bomb_Set
// Stefan Grace
// Created: 2017-10-01
// Modified: 2017-10-01
// This script is executed when the time bomb gets clicked on

// Makes a character set the bomb
if (time_bomb>0 and set==0)
{
    with(all)
    {
        if (player==1 and instance_number(Go_Number_Red)>0)
        or (player==2 and instance_number(Go_Number_Black)>0)
        {
            if place_meeting(x+grid_size,y,other)
            or place_meeting(x-grid_size,y,other) 
            or place_meeting(x,y+grid_size,other)
            or place_meeting(x,y-grid_size,other)
            {
                with(other) set = 1
                score -= 1
            } 
        }
    }
}


#define Bomb_Detonate
// Bomb_Detonate
// Stefan Grace
// Created: 2017-10-14
// Modified: 2017-10-14
// This script make a Nuclear Bomb or J Bomb Detonate if it is not in a Teleport or if it gets stuck in a Teleport

if (nuclear==1) and (falling>0) 
{
    if (place_meeting(x,y,Teleport)) 
    {
        alarm[0] = 15
        teleport_y = y
    }
    else 
    {
        script_execute(M_Detonate)
    }
}
if (j_bomb==1) and (falling>0) 
{
    if (place_meeting(x,y,Teleport)) 
    {
        alarm[1] = 15
        teleport_y = y
    }
    else 
    {
        script_execute(J_Detonate)
    }
}

#define Box_Four_Detect
// Box_Four_Detect
// Stefan Grace
// Created: 2016-07-07
// Modified: 2016-07-22
// This script detects if the box a character is moving into is full

/*
argument0 = Direction
    0 = Left
    1 = Up
    2 = Right
    3 = Down
    
grid_align
    0 = Top Left
    1 = Top Right
    2 = Bottom Left
    3 = Bottom Right
*/

// This block of code detects where the character is in the box
if (place_snapped(35,35)) grid_align = 0 
else if ((x mod 35) > 10) and ((y mod 35) < 10) grid_align = 1
else if ((x mod 35) < 10) and ((y mod 35) > 10) grid_align = 2
else grid_align = 3

// This block of code detects if the box a character is moving into is full
repeat_num = 0
while (repeat_num<4)
{
    // grid_align==0, argument0==0
    if (repeat_num==0) and (grid_align==0) and (argument0==0) script_execute(Place_Meeting_Detect,-35,0)
    if (repeat_num==1) and (grid_align==0) and (argument0==0) script_execute(Place_Meeting_Detect,-17,0)
    if (repeat_num==2) and (grid_align==0) and (argument0==0) script_execute(Place_Meeting_Detect,-35,17)
    if (repeat_num==3) and (grid_align==0) and (argument0==0) script_execute(Place_Meeting_Detect,-17,17)
    // grid_align==1
    if (repeat_num==0) and (grid_align==1) and (argument0==0) script_execute(Place_Meeting_Detect,-52,0)
    if (repeat_num==1) and (grid_align==1) and (argument0==0) script_execute(Place_Meeting_Detect,-35,0)
    if (repeat_num==2) and (grid_align==1) and (argument0==0) script_execute(Place_Meeting_Detect,-52,17)
    if (repeat_num==3) and (grid_align==1) and (argument0==0) script_execute(Place_Meeting_Detect,-35,17)
    // grid_align==2
    if (repeat_num==0) and (grid_align==2) and (argument0==0) script_execute(Place_Meeting_Detect,-35,-17)
    if (repeat_num==1) and (grid_align==2) and (argument0==0) script_execute(Place_Meeting_Detect,-17,-17)
    if (repeat_num==2) and (grid_align==2) and (argument0==0) script_execute(Place_Meeting_Detect,-35,0)
    if (repeat_num==3) and (grid_align==2) and (argument0==0) script_execute(Place_Meeting_Detect,-17,0)
    // grid_align==3
    if (repeat_num==0) and (grid_align==3) and (argument0==0) script_execute(Place_Meeting_Detect,-52,-17)
    if (repeat_num==1) and (grid_align==3) and (argument0==0) script_execute(Place_Meeting_Detect,-35,-17)
    if (repeat_num==2) and (grid_align==3) and (argument0==0) script_execute(Place_Meeting_Detect,-52,0)
    if (repeat_num==3) and (grid_align==3) and (argument0==0) script_execute(Place_Meeting_Detect,-35,0)
    // agrid_align==0, rgument0==1
    if (repeat_num==0) and (grid_align==0) and (argument0==1) script_execute(Place_Meeting_Detect,0,-35)
    if (repeat_num==1) and (grid_align==0) and (argument0==1) script_execute(Place_Meeting_Detect,17,-35)
    if (repeat_num==2) and (grid_align==0) and (argument0==1) script_execute(Place_Meeting_Detect,0,-17)
    if (repeat_num==3) and (grid_align==0) and (argument0==1) script_execute(Place_Meeting_Detect,17,-17)
    // grid_align==1
    if (repeat_num==0) and (grid_align==1) and (argument0==1) script_execute(Place_Meeting_Detect,-17,-35)
    if (repeat_num==1) and (grid_align==1) and (argument0==1) script_execute(Place_Meeting_Detect,0,-35)
    if (repeat_num==2) and (grid_align==1) and (argument0==1) script_execute(Place_Meeting_Detect,-17,-17)
    if (repeat_num==3) and (grid_align==1) and (argument0==1) script_execute(Place_Meeting_Detect,0,-17)
    // agrid_align==2
    if (repeat_num==0) and (grid_align==2) and (argument0==1) script_execute(Place_Meeting_Detect,0,-52)
    if (repeat_num==1) and (grid_align==2) and (argument0==1) script_execute(Place_Meeting_Detect,17,-52)
    if (repeat_num==2) and (grid_align==2) and (argument0==1) script_execute(Place_Meeting_Detect,0,-35)
    if (repeat_num==3) and (grid_align==2) and (argument0==1) script_execute(Place_Meeting_Detect,17,-35)
    // grid_align==3
    if (repeat_num==0) and (grid_align==3) and (argument0==1) script_execute(Place_Meeting_Detect,-17,-17)
    if (repeat_num==1) and (grid_align==3) and (argument0==1) script_execute(Place_Meeting_Detect,0,-17)
    if (repeat_num==2) and (grid_align==3) and (argument0==1) script_execute(Place_Meeting_Detect,-17,-35)
    if (repeat_num==3) and (grid_align==3) and (argument0==1) script_execute(Place_Meeting_Detect,0,-35)
    // grid_align==0, argument0==2
    if (repeat_num==0) and (grid_align==0) and (argument0==2) script_execute(Place_Meeting_Detect,35,0)
    if (repeat_num==1) and (grid_align==0) and (argument0==2) script_execute(Place_Meeting_Detect,52,0)
    if (repeat_num==2) and (grid_align==0) and (argument0==2) script_execute(Place_Meeting_Detect,35,17)
    if (repeat_num==3) and (grid_align==0) and (argument0==2) script_execute(Place_Meeting_Detect,52,17)
     // grid_align==1
    if (repeat_num==0) and (grid_align==1) and (argument0==2) script_execute(Place_Meeting_Detect,18,0)
    if (repeat_num==1) and (grid_align==1) and (argument0==2) script_execute(Place_Meeting_Detect,35,0)
    if (repeat_num==2) and (grid_align==1) and (argument0==2) script_execute(Place_Meeting_Detect,18,17)
    if (repeat_num==3) and (grid_align==1) and (argument0==2) script_execute(Place_Meeting_Detect,35,17)
    // grid_align==2
    if (repeat_num==0) and (grid_align==2) and (argument0==2) script_execute(Place_Meeting_Detect,35,-17)
    if (repeat_num==1) and (grid_align==2) and (argument0==2) script_execute(Place_Meeting_Detect,52,-17)
    if (repeat_num==2) and (grid_align==2) and (argument0==2) script_execute(Place_Meeting_Detect,35,0)
    if (repeat_num==3) and (grid_align==2) and (argument0==2) script_execute(Place_Meeting_Detect,52,0)
    // grid_align==3
    if (repeat_num==0) and (grid_align==3) and (argument0==2) script_execute(Place_Meeting_Detect,18,-17)
    if (repeat_num==1) and (grid_align==3) and (argument0==2) script_execute(Place_Meeting_Detect,35,-17)
    if (repeat_num==2) and (grid_align==3) and (argument0==2) script_execute(Place_Meeting_Detect,18,0)
    if (repeat_num==3) and (grid_align==3) and (argument0==2) script_execute(Place_Meeting_Detect,35,0)
    // grid_align==0, argument0==3
    if (repeat_num==0) and (grid_align==0) and (argument0==3) script_execute(Place_Meeting_Detect,0,35)
    if (repeat_num==1) and (grid_align==0) and (argument0==3) script_execute(Place_Meeting_Detect,0,52)
    if (repeat_num==2) and (grid_align==0) and (argument0==3) script_execute(Place_Meeting_Detect,17,35)
    if (repeat_num==3) and (grid_align==0) and (argument0==3) script_execute(Place_Meeting_Detect,17,52)
    // grid_align==1
    if (repeat_num==0) and (grid_align==1) and (argument0==3) script_execute(Place_Meeting_Detect,-17,35)
    if (repeat_num==1) and (grid_align==1) and (argument0==3) script_execute(Place_Meeting_Detect,0,35)
    if (repeat_num==2) and (grid_align==1) and (argument0==3) script_execute(Place_Meeting_Detect,-17,52)
    if (repeat_num==3) and (grid_align==1) and (argument0==3) script_execute(Place_Meeting_Detect,0,52)
    // grid_align==2
    if (repeat_num==0) and (grid_align==2) and (argument0==3) script_execute(Place_Meeting_Detect,0,17)
    if (repeat_num==1) and (grid_align==2) and (argument0==3) script_execute(Place_Meeting_Detect,0,35)
    if (repeat_num==2) and (grid_align==2) and (argument0==3) script_execute(Place_Meeting_Detect,17,17)
    if (repeat_num==3) and (grid_align==2) and (argument0==3) script_execute(Place_Meeting_Detect,17,35)
    // grid_align==3
    if (repeat_num==0) and (grid_align==3) and (argument0==3) script_execute(Place_Meeting_Detect,-17,17)
    if (repeat_num==1) and (grid_align==3) and (argument0==3) script_execute(Place_Meeting_Detect,0,17)
    if (repeat_num==2) and (grid_align==3) and (argument0==3) script_execute(Place_Meeting_Detect,-17,35)
    if (repeat_num==3) and (grid_align==3) and (argument0==3) script_execute(Place_Meeting_Detect,0,35)
    repeat_num = repeat_num+1
}
#define Box_Four_Place_Full_Clear
boxfull_topleft = 0
boxfull_topright = 0
boxfull_bottomleft = 0
boxfull_bottomright = 0
#define Place_Meeting_Detect
// Black
if (place_meeting(x+argument0,y+argument1,Black_O)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_X)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Triangle)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_A)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Square)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_K)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_B)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_E)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_S)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_H)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_R)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_M)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_F)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_C)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Y)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Z)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_W)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_J)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_V)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_P)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_T)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_D)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Q)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_N)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Question_Mark)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_U)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_L)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Dollar_Sign)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_At)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_I)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Lowercase_Q)) script_execute(Box_Full_Detect)

// Black_Stuned
if (place_meeting(x+argument0,y+argument1,Black_Stuned_O)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Stuned_X)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Stuned_Triangle)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Stuned_A)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Stuned_Square)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Stuned_K)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Stuned_B)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Stuned_E)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Stuned_S)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Stuned_H)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Stuned_R)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Stuned_M)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Stuned_F)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Stuned_C)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Stuned_Y)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Stuned_Z)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Stuned_W)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Stuned_J)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Stuned_V)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Stuned_P)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Stuned_T)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Stuned_D)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Stuned_Q)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Stuned_N)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Stuned_Question_Mark)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Stuned_U)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Stuned_L)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Stuned_Dollar_Sign)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Stuned_At)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Stuned_I)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Black_Stuned_Lowercase_Q)) script_execute(Box_Full_Detect)

// Red
if (place_meeting(x+argument0,y+argument1,Red_O)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_X)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Triangle)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_A)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Square)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_K)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_B)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_E)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_S)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_H)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_R)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_M)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_F)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_C)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Y)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Z)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_W)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_J)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_V)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_P)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_T)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_D)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Q)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_N)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Question_Mark)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_U)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_L)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Dollar_Sign)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_At)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_I)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Lowercase_Q)) script_execute(Box_Full_Detect)

// Red_Stuned
if (place_meeting(x+argument0,y+argument1,Red_Stuned_O)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Stuned_X)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Stuned_Triangle)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Stuned_A)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Stuned_Square)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Stuned_K)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Stuned_B)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Stuned_E)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Stuned_S)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Stuned_H)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Stuned_R)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Stuned_M)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Stuned_F)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Stuned_C)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Stuned_Y)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Stuned_Z)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Stuned_W)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Stuned_J)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Stuned_V)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Stuned_P)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Stuned_T)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Stuned_D)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Stuned_Q)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Stuned_N)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Stuned_Question_Mark)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Stuned_U)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Stuned_L)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Stuned_Dollar_Sign)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Stuned_At)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Stuned_I)) script_execute(Box_Full_Detect)
if (place_meeting(x+argument0,y+argument1,Red_Stuned_Lowercase_Q)) script_execute(Box_Full_Detect)
#define Box_Full_Detect
if (repeat_num==0) boxfull_topleft = 1
if (repeat_num==1) boxfull_topright = 1
if (repeat_num==2) boxfull_bottomleft = 1
if (repeat_num==3) boxfull_bottomright = 1
#define No_Kill
if (Kill==1) script_execute(Blue_Kill_Stuned)

        
    
#define Both_Kill
script_execute(Blue_Kill_Stuned)
script_execute(Stuned_Kill_Blue)

        
    
#define Blue_Kill_Stuned
if (place_snapped(35,35))
{
    if (place_meeting(x,y,other)) 
    {
        with (other) script_execute(Character_Die)
    }
    if (place_meeting(x+17,y,other)) 
    {
        with (other) script_execute(Character_Die)
    }
    if (place_meeting(x,y+17,other))
    {
        with (other) script_execute(Character_Die)
    }
    if (place_meeting(x+17,y+17,other))
    {
        with (other) script_execute(Character_Die)
    }
}
if (place_meeting(x,y,Teleport))
{
    var teleport_x;
    var teleport_y;
    with(Teleport)
    {
        if (place_meeting(x,y,other))
        {
            var port_color;
            var port_side;
            port_color = color
            port_side = side
            with (Teleport)
            {
                if (color==port_color and side!=port_side)
                {
                    teleport_x = x
                    teleport_y = y
                }
            }
        }
    }
    if (other.x - (other.x mod grid_size) == teleport_x and other.y - (other.y mod grid_size) == teleport_y) 
    {
        with (other) script_execute(Character_Die)
    }
}

#define Stuned_Kill_Blue
if (Kill==0)
{
    if (place_snapped(35,35))
    {
        if (place_meeting(x,y,other)) script_execute(Character_Die)
        if (place_meeting(x+17,y,other)) script_execute(Character_Die)
        if (place_meeting(x,y+17,other)) script_execute(Character_Die)
        if (place_meeting(x+17,y+17,other)) script_execute(Character_Die)
    }
    if (place_meeting(x,y,Teleport))
    {
        var teleport_x;
        var teleport_y;
        with(Teleport)
        {
            if (place_meeting(x,y,other))
            {
                var port_color;
                var port_side;
                port_color = color
                port_side = side
                with (Teleport)
                {
                    if (color==port_color and side!=port_side)
                    {
                        teleport_x = x
                        teleport_y = y
                    }
                }
            }
        }
        if (other.x - (other.x mod grid_size) == teleport_x and other.y - (other.y mod grid_size) == teleport_y) 
        {
            script_execute(Character_Die)
        }
    }
}
else script_execute(Blue_Kill_Stuned)
#define Blue_Stun_Stuned
if (Kill==0)
{
    if (place_snapped(35,35))
    {
        if (place_meeting(x,y,other)) other.S_Stuned = 1
        if (place_meeting(x+17,y,other)) other.S_Stuned = 1
        if (place_meeting(x,y+17,other)) other.S_Stuned = 1
        if (place_meeting(x+17,y+17,other)) other.S_Stuned = 1
    }
    if (place_meeting(x,y,Teleport))
    {
        var teleport_x;
        var teleport_y;
        with(Teleport)
        {
            if (place_meeting(x,y,other))
            {
                var port_color;
                var port_side;
                port_color = color
                port_side = side
                with (Teleport)
                {
                    if (color==port_color and side!=port_side)
                    {
                        teleport_x = x
                        teleport_y = y
                    }
                }
            }
        }
        if (other.x - (other.x mod grid_size) == teleport_x and other.y - (other.y mod grid_size) == teleport_y) 
        {
            other.S_Stuned = 1
        }
    }
}
else script_execute(Blue_Kill_Stuned)
#define Stuned_Stun_Blue
if (Kill==0)
{
    if (place_snapped(35,35))
    {
        if (place_meeting(x,y,other)) S_Stuned = 1
        if (place_meeting(x+17,y,other)) S_Stuned = 1
        if (place_meeting(x,y+17,other)) S_Stuned = 1
        if (place_meeting(x+17,y+17,other)) S_Stuned = 1
    }
    if (place_meeting(x,y,Teleport))
    {
        var teleport_x;
        var teleport_y;
        with(Teleport)
        {
            if (place_meeting(x,y,other))
            {
                var port_color;
                var port_side;
                port_color = color
                port_side = side
                with (Teleport)
                {
                    if (color==port_color and side!=port_side)
                    {
                        teleport_x = x
                        teleport_y = y
                    }
                }
            }
        }
        if (other.x - (other.x mod grid_size) == teleport_x and other.y - (other.y mod grid_size) == teleport_y) 
        {
            S_Stuned = 1
        }
    }
}
else script_execute(Blue_Kill_Stuned)
#define Blue_Charm_Stuned
if (Kill==0)
{
    if (place_snapped(35,35))
    {
        if (place_meeting(x,y,other)) with (other) script_execute(Charm_Script)
        if (place_meeting(x+17,y,other)) with (other) script_execute(Charm_Script)
        if (place_meeting(x,y+17,other)) with (other) script_execute(Charm_Script)
        if (place_meeting(x+17,y+17,other)) with (other) script_execute(Charm_Script)
    }
    if (place_meeting(x,y,Teleport))
    {
        var teleport_x;
        var teleport_y;
        with(Teleport)
        {
            if (place_meeting(x,y,other))
            {
                var port_color;
                var port_side;
                port_color = color
                port_side = side
                with (Teleport)
                {
                    if (color==port_color and side!=port_side)
                    {
                        teleport_x = x
                        teleport_y = y
                    }
                }
            }
        }
        if (other.x - (other.x mod grid_size) == teleport_x and other.y - (other.y mod grid_size) == teleport_y) 
        {
            with (other) script_execute(Charm_Script)
        }
    }
}
else script_execute(Blue_Kill_Stuned)
#define Stuned_Charm_Blue
if (Kill==0)
{
    if (place_snapped(35,35))
    {
        if (place_meeting(x,y,other)) script_execute(Charm_Script,1)
        if (place_meeting(x+17,y,other)) script_execute(Charm_Script,1)
        if (place_meeting(x,y+17,other)) script_execute(Charm_Script,1)
        if (place_meeting(x+17,y+17,other)) script_execute(Charm_Script,1)
    }
    if (place_meeting(x,y,Teleport))
    {
        var teleport_x;
        var teleport_y;
        with(Teleport)
        {
            if (place_meeting(x,y,other))
            {
                var port_color;
                var port_side;
                port_color = color
                port_side = side
                with (Teleport)
                {
                    if (color==port_color and side!=port_side)
                    {
                        teleport_x = x
                        teleport_y = y
                    }
                }
            }
        }
        if (other.x - (other.x mod grid_size) == teleport_x and other.y - (other.y mod grid_size) == teleport_y) 
        {
            script_execute(Charm_Script,1)
        }
    }
}
else script_execute(Blue_Kill_Stuned)
#define Anger_Clear
Kill = 0
RockTunnle = 0
DimondTunnle = 0
#define At_Swap
// At_Swap
// Stefan Grace
// Created: 2017-12-19
// Modified: 2017-12-23

if (S_Stuned>0) exit
global.at_swapping = 1
global.message_type = 21
script_execute(Local_Message_Create)

#define Auto_Stack
if (place_snapped(35,y)) x += 17
else 
{
    x -= 17
    y += 17
}
#define Auto_Stack_Detect_Black
// Auto_Stack_Detect_Black
// Stefan Grace
// Created: 2017-07-24
// Modified: 2017-12-12

with(all) 
{
    if (player==2)
    {
        if(place_meeting(x,y,other) and character_id!=13)
        {
            with(other) script_execute(Auto_Stack)
        }
    }
}
#define Auto_Stack_Detect_Red
// Auto_Stack_Detect_Red
// Stefan Grace
// Created: 2017-07-24
// Modified: 2017-12-12

with(all) 
{
    if (player==1)
    {
        if(place_meeting(x,y,other) and character_id!=13)
        {
            with(other) script_execute(Auto_Stack)
        }
    }
}
#define B_Detect
// B_Detect
// Stefan Grace
// Created: 2020-02-19
// Modified: 2020-02-25
// This scrip detects if the is a B in range that is infiltrating a box of 4

var b_place_x b_place_y;
if (global.Black_B_Killing_Left+global.Red_B_Killing_Left>0)
{
    b_place_x = grid_size
    b_place_y = 0
}
else if (global.Black_B_Killing_Up+global.Red_B_Killing_Up>0)
{
    b_place_x = 0
    b_place_y = grid_size
}
else if (global.Black_B_Killing_Right+global.Red_B_Killing_Right>0)
{
    b_place_x = 0-grid_size
    b_place_y = 0
}
else if (global.Black_B_Killing_Down+global.Red_B_Killing_Down>0)
{
    b_place_x = 0
    b_place_y = 0-grid_size
}
else
{
    return false
}

if (place_meeting(x,y,Teleport))
{
     with (Teleport)
     {
        if (place_meeting(x,y,other))
        {
            var port_color;
            var port_side;
            port_color = color
            port_side = side
            with (Teleport)
            {
                if (color==port_color and side!=port_side)
                {
                    if (instance_number(Go_Number_Black)>0)
                    {
                        if (place_meeting(x + b_place_x, y + b_place_y, Black_Blue_B)) return true
                    }
                    if (instance_number(Go_Number_Red)>0)
                    {
                        if (place_meeting(x + b_place_x, y + b_place_y, Red_Blue_B)) return true
                    }
                }
            }
        }
    }
}

if (instance_number(Go_Number_Black)>0)
{
    return ((x - (x mod grid_size)) + b_place_x == Black_Blue_B.x - (Black_Blue_B.x mod grid_size) and (y - (y mod grid_size)) + b_place_y == Black_Blue_B.y - (Black_Blue_B.y mod grid_size))
}

if (instance_number(Go_Number_Red)>0)
{
    return ((x - (x mod grid_size)) + b_place_x == Red_Blue_B.x - (Red_Blue_B.x mod grid_size) and (y - (y mod grid_size)) + b_place_y == Red_Blue_B.y - (Red_Blue_B.y mod grid_size))
}


#define B_Kill_Black
// B_Kill_Black
// Stefan Grace
// Created: 2016-07-20
// Modified: 2020-02-19
// This script is executed when a Black B infiltrates a Red box of 4 or when a Black $ casts an AOE stun on a Red Character


if (global.Black_B_Killing_Left>0)
{
    if (B_Detect())
    {
        global.Black_B_Killing_Left = 0
        with(Message_Object) instance_destroy()
        with(Black_Blue_B) alarm[1] = 1
        instance_destroy()
    }
}

if (global.Black_B_Killing_Up>0)
{
    if (B_Detect())
    {
        global.Black_B_Killing_Up = 0
        with(Message_Object) instance_destroy()
        with(Black_Blue_B) alarm[2] = 1
        instance_destroy()
    }
}

if (global.Black_B_Killing_Right>0)
{
    if (B_Detect())
    {
        global.Black_B_Killing_Right = 0
        with(Message_Object) instance_destroy()
        with(Black_Blue_B) alarm[3] = 1
        instance_destroy()
    }
}

if (global.Black_B_Killing_Down>0)
{
    if (B_Detect())
    {
        global.Black_B_Killing_Down = 0
        with(Message_Object) instance_destroy()
        with(Black_Blue_B) alarm[4] = 1
        instance_destroy()
    }
}

if (global.dollar_sign_stunning>0 and Dollar_Sign_Range_Detect()) script_execute(Dollar_Sign_Stun_Create,1)

#define B_Kill_Red
// B_Kill_Red
// Stefan Grace
// Created: 2016-07-20
// Modified: 2020-02-23
// This script is executed when a Red B infiltrates a Red box of 4 or when a Red $ casts an AOE stun on a Red Character


if (global.Red_B_Killing_Left>0)
{
    if (B_Detect())
    {
        global.Red_B_Killing_Left = 0
        with(Message_Object) instance_destroy()
        with(Red_Blue_B) alarm[1] = 1
        instance_destroy()
    }
}

if (global.Red_B_Killing_Up>0)
{
    if (B_Detect())
    {
        global.Red_B_Killing_Up = 0
        with(Message_Object) instance_destroy()
        with(Red_Blue_B) alarm[2] = 1
        instance_destroy()
    }
}

if (global.Red_B_Killing_Right>0)
{
    if (B_Detect())
    {
        global.Red_B_Killing_Right = 0
        with(Message_Object) instance_destroy()
        with(Red_Blue_B) alarm[3] = 1
        instance_destroy()
    }
}

if (global.Red_B_Killing_Down>0)
{
    if (B_Detect())
    {
        global.Red_B_Killing_Down = 0
        with(Message_Object) instance_destroy()
        with(Red_Blue_B) alarm[4] = 1
        instance_destroy()
    }
}

if (global.dollar_sign_stunning>0 and Dollar_Sign_Range_Detect()) script_execute(Dollar_Sign_Stun_Create,2)
#define Black_Stun
with(Black_X) instance_change(Black_Stuned_X,false)
with(Black_O) instance_change(Black_Stuned_O,false)
with(Black_Triangle) instance_change(Black_Stuned_Triangle,false)
with(Black_A) instance_change(Black_Stuned_A,false)
with(Black_Square) instance_change(Black_Stuned_Square,false)
with(Black_K) instance_change(Black_Stuned_K,false)
with(Black_B) instance_change(Black_Stuned_B,false)
with(Black_E) instance_change(Black_Stuned_E,false)
with(Black_S) instance_change(Black_Stuned_S,false)
with(Black_H) instance_change(Black_Stuned_H,false)
with(Black_R) instance_change(Black_Stuned_R,false)
with(Black_M) instance_change(Black_Stuned_M,false)
with(Black_F) instance_change(Black_Stuned_F,false)
with(Black_G) instance_change(Black_Stuned_G,false)
with(Black_C) instance_change(Black_Stuned_C,false)
with(Black_Y) instance_change(Black_Stuned_Y,false)
with(Black_Z) instance_change(Black_Stuned_Z,false)
with(Black_W) instance_change(Black_Stuned_W,false)
with(Black_J) instance_change(Black_Stuned_J,false)
with(Black_V) instance_change(Black_Stuned_V,false)
with(Black_P) instance_change(Black_Stuned_P,false)
with(Black_T) instance_change(Black_Stuned_T,false)
with(Black_D) instance_change(Black_Stuned_D,false)
with(Black_Q) instance_change(Black_Stuned_Q,false)
with(Black_N) instance_change(Black_Stuned_N,false)
with(Black_Question_Mark) instance_change(Black_Stuned_Question_Mark,false)
with(Black_U) instance_change(Black_Stuned_U,false)
with(Black_L) instance_change(Black_Stuned_L,false)
with(Black_Dollar_Sign) instance_change(Black_Stuned_Dollar_Sign,false)
with(Black_At) instance_change(Black_Stuned_At,false)
with(Black_Pi) instance_change(Black_Stuned_Pi,false)
with(Black_I) instance_change(Black_Stuned_I,false)
with(Black_Lowercase_Q) instance_change(Black_Stuned_Lowercase_Q,false)
#define Black_Unstun
with(Black_Stuned_X) instance_change(Black_X,false)
with(Black_Stuned_O) instance_change(Black_O,false)
with(Black_Stuned_Triangle) instance_change(Black_Triangle,false)
with(Black_Stuned_A) instance_change(Black_A,false)
with(Black_Stuned_Square) instance_change(Black_Square,false)
with(Black_Stuned_K) instance_change(Black_K,false)
with(Black_Stuned_B) instance_change(Black_B,false)
with(Black_Stuned_E) instance_change(Black_E,false)
with(Black_Stuned_S) instance_change(Black_S,false)
with(Black_Stuned_H) instance_change(Black_H,false)
with(Black_Stuned_R) instance_change(Black_R,false)
with(Black_Stuned_M) instance_change(Black_M,false)
with(Black_Stuned_F) instance_change(Black_F,false)
with(Black_Stuned_G) instance_change(Black_G,false)
with(Black_Stuned_C) instance_change(Black_C,false)
with(Black_Stuned_Y) instance_change(Black_Y,false)
with(Black_Stuned_Z) instance_change(Black_Z,false)
with(Black_Stuned_W) instance_change(Black_W,false)
with(Black_Stuned_J) instance_change(Black_J,false)
with(Black_Stuned_V) instance_change(Black_V,false)
with(Black_Stuned_P) instance_change(Black_P,false)
with(Black_Stuned_T) instance_change(Black_T,false)
with(Black_Stuned_D) instance_change(Black_D,false)
with(Black_Stuned_Q) instance_change(Black_Q,false)
with(Black_Stuned_N) instance_change(Black_N,false)
with(Black_Stuned_Question_Mark) instance_change(Black_Question_Mark,false)
with(Black_Stuned_U) instance_change(Black_U,false)
with(Black_Stuned_L) instance_change(Black_L,false)
with(Black_Stuned_Dollar_Sign) instance_change(Black_Dollar_Sign,false)
with(Black_Stuned_At) instance_change(Black_At,false)
with(Black_Stuned_Pi) instance_change(Black_Pi,false)
with(Black_Stuned_I) instance_change(Black_I,false)
with(Black_Stuned_Lowercase_Q) instance_change(Black_Lowercase_Q,false)
#define Blue_Step
// Blue_Step
// Stefan Grace
// Created: 2017-07-24
// Modified: 2020-02-12
// This script is executed on blue (selected) characters every step

// Kills the character if it shoud be killed
if (to_be_killed) instance_destroy()

// Clears the anger atrributes from a character at the end of the turn
if (score<1) alarm[0] = 2

// Makes the character get crushed by a boulder
if (place_meeting(x,y,Boulder)) 
{
    if (character_id!=15) 
    {
        script_execute(Boulder_Crush_Blue) 
    }
    else
    {
        with (Boulder)
        {
            if (place_meeting(x,y,other)) instance_destroy()
        }
    }
}

// Controlls the auto stack
if (instance_number(Go_Number_Black)>0)
{
    repeat(4) script_execute(Auto_Stack_Detect_Black)
    script_execute(Auto_Stack_Detect_Red)
}
if (instance_number(Go_Number_Red)>0)
{
    repeat(4) script_execute(Auto_Stack_Detect_Red)
    script_execute(Auto_Stack_Detect_Black)
}

// Makes blue character interact with opponent's G or Big W in other side of teleport
if (place_meeting(x,y,Teleport))
{
    with (Teleport)
    {
        if (place_meeting(x,y,other))
        {
            var port_color;
            var port_side;
            port_color = color
            port_side = side
            with (Teleport)
            {
                if (color==port_color and side!=port_side)
                {
                    if (instance_number(Go_Number_Black)>0 and place_meeting(x,y,Red_Stuned_G)) 
                    {
                        with (Black_Blue_X) 
                        {
                            if (character_id==1)
                            or (character_id==2)
                            or (character_id==3)
                            or (character_id==7)
                            or (character_id==9)
                            or (character_id==14)
                            or (character_id==20)
                            or (Kill>0)
                            {
                                with(Red_Stuned_G) Blue_Attack_G_Teleport(false, port_color)
                            }
                            else if (character_id==8)
                            {
                                with(Red_Stuned_G) Blue_Attack_G_Teleport(true, port_color)
                            }
                            instance_destroy()
                        }
                        
                    }
                    else if (instance_number(Go_Number_Red)>0 and place_meeting(x,y,Black_Stuned_G)) 
                    {
                        with (Red_Blue) 
                        {
                            if (character_id==1)
                            or (character_id==2)
                            or (character_id==3)
                            or (character_id==7)
                            or (character_id==9)
                            or (character_id==14)
                            or (character_id==20)
                            or (Kill>0)
                            {
                                with(Black_Stuned_G) Blue_Attack_G_Teleport(false, port_color)
                            }
                            else if (character_id==8)
                            {
                                with(Black_Stuned_G) Blue_Attack_G_Teleport(true, port_color)
                            }
                            instance_destroy()
                        }
                    }
                }
            }
        }
    }
}

// Makes the character interact with a G
if (place_meeting(x,y,Red_Stuned_G))
{
    if (instance_number(Go_Number_Black)>0)
    {
        if (character_id==1)
        or (character_id==2)
        or (character_id==3)
        or (character_id==7)
        or (character_id==9)
        or (character_id==14)
        or (character_id==20)
        or (Kill>0)
        {
            with(Red_Stuned_G)
            {
                Blue_Attack_G(false)
            }
        }
        else if (character_id==8)
        {
            with(Red_Stuned_G)
            {
                Blue_Attack_G(true)
            }
        }
    }
    instance_destroy()
}  
else if (place_meeting(x,y,Black_Stuned_G))
{
    if (instance_number(Go_Number_Red)>0)
    {
        if (character_id==1)
        or (character_id==2)
        or (character_id==3)
        or (character_id==7)
        or (character_id==9)
        or (character_id==14)
        or (character_id==20)
        or (Kill>0)
            with(Black_Stuned_G)
            {
                Blue_Attack_G(false)
            }
        else if (character_id==8)
            with(Black_Stuned_G)
            {
                Blue_Attack_G(true)
            }
    }
    instance_destroy()
}  
if (place_meeting(x,y,Black_G) or place_meeting(x,y,Red_G)) instance_destroy()
#define Boulder_Crush_Blue
// Boulder_Crush_Blue
// Stefan Grace
// Created: 2016-07-05
// Modified: 2024-07-29
// This script kills the selected (blue) character when a boulder falls on it

if (!(keyboard_check(vk_left) || keyboard_check(ord("A")) || (keyboard_check(vk_right) || keyboard_check(ord("D")) 
|| Tablet_UI_Left_Button.clicked || Tablet_UI_Right_Button.clicked ||abs(joystick_xpos(0)) > 0.1)))
{
    instance_destroy()
}
#define C_Catapult
// C_Catapult 
// Stefan Grace
// Created: 2017-08-04
// Modified: 2024-07-28
// This script makes the C catapult a boulder and N catapult nuclear bomb when the control key is held down


if (global.game_frozen>0) exit
if keyboard_check(vk_control) || global.tablet_function_button_active || joystick_check_button(0, 1)
{
    if (S_Stuned>0)
    {
        show_message(global.text_c_stun)
        exit
    }
    var catapult_sqaures;
    if (argument0==0) catapult_sqaures = -5
    if (argument0==2) catapult_sqaures = 5
    if place_meeting(x+(catapult_sqaures*grid_size),y,Yellow) and (!(place_meeting(x+(catapult_sqaures*grid_size),y,Boulder)))
    and (!(place_meeting(x+((catapult_sqaures*grid_size)*(1/5)),y,Concreet)))
    and (!(place_meeting(x+((catapult_sqaures*grid_size)*(2/5)),y,Concreet)))
    and (!(place_meeting(x+((catapult_sqaures*grid_size)*(3/5)),y,Concreet)))
    and (!(place_meeting(x+((catapult_sqaures*grid_size)*(4/5)),y,Concreet)))
    {
        if (character_id==24) instance_create((x-(x mod grid_size))+(catapult_sqaures*grid_size),y+(y mod grid_size),Nuclear_Bomb_Object)
        instance_create((x-(x mod grid_size))+(catapult_sqaures*grid_size),y+(y mod grid_size),Boulder)
        score -= 1
        with (Boulder) if place_meeting(x-(catapult_sqaures*grid_size),y,other) catapulted = 1
    }
}
else script_execute(Character_Move,argument0)
#define Character_Click_Black
// Character_Click_Black
// Stefan Grace
// Created: 2016-07-05
// Modified: 2020-02-21
// This scrip makes any other selected charater become unselected when Player 2 clicks on a character

if (instance_number(Level_Cover) > 0) exit

if (global.levelnumber == 0)
{
    if (global.level0messagenumber >= 6 and !global.black_level_0_message_7_hasbeenshown)
    {
        with (Message_Object) instance_destroy()
        global.level0messagenumber = 7
        global.message_type = 57
        instance_create(70, 70, Message_Object)
        global.black_level_0_message_7_hasbeenshown = true
    }
}

if (global.dollar_sign_stunning != 0) // Cancel the $ stun if the player click on another one of their own characters
{
    global.dollar_sign_stunning = 0 
    with (Message_Object) instance_destroy()
}

if (global.big_w_life_draining) // Cancel the Big W life drian if the player click on another one of their own characters
{
    global.big_w_life_draining = false;
    with (Message_Object) instance_destroy()
}

if (global.big_w_life_giving) // Cancel the Big W life give if the player click on another one of their own characters
{
    global.big_w_life_giving = false;
    with (Message_Object) instance_destroy()
}

if (global.w_casting)
{
    if (S_Stuned > 0 and W_Range_Detect()) 
    {    
        S_Stuned = 0 
        score -= 1
    }
    else if (character_id == 13 and g_hit < Get_Max_Hits(g_type) and W_Range_Detect())
    {
        g_hit += 1
        score -= 1 
    }
    exit
}

if (global.Black_B_Killing_Left+global.Black_B_Killing_Up+global.Black_B_Killing_Right+global.Black_B_Killing_Down) exit

if (global.at_swapping == 0)
{
    
    with(Black_Blue_O) instance_change(Black_O,false)
    with(Black_Blue_X) instance_change(Black_X,false)
    with(Black_Blue_Triangle) instance_change(Black_Triangle,false)
    with(Black_Blue_A) instance_change(Black_A,false)
    with(Black_Blue_Square) instance_change(Black_Square,false)
    with(Black_Blue_K) instance_change(Black_K,false)
    with(Black_Blue_B) instance_change(Black_B,false)
    with(Black_Blue_E) instance_change(Black_E,false)
    with(Black_Blue_S) instance_change(Black_S,false)
    with(Black_Blue_H) instance_change(Black_H,false)
    with(Black_Blue_R) instance_change(Black_R,false)
    with(Black_Blue_M) instance_change(Black_M,false)
    with(Black_Blue_F) instance_change(Black_F,false)
    with(Black_Blue_G) instance_change(Black_G,false)
    with(Black_Blue_C) instance_change(Black_C,false)
    with(Black_Blue_Y) instance_change(Black_Y,false)
    with(Black_Blue_Z) instance_change(Black_Z,false)
    with(Black_Blue_W) instance_change(Black_W,false)
    with(Black_Blue_J) instance_change(Black_J,false)
    with(Black_Blue_V) instance_change(Black_V,false)
    with(Black_Blue_P) instance_change(Black_P,false)
    with(Black_Blue_T) instance_change(Black_T,false)
    with(Black_Blue_D) instance_change(Black_D,false)
    with(Black_Blue_Q) instance_change(Black_Q,false)
    with(Black_Blue_N) instance_change(Black_N,false)
    with(Black_Blue_Question_Mark) instance_change(Black_Question_Mark,false)
    with(Black_Blue_U) instance_change(Black_U,false)
    with(Black_Blue_L) instance_change(Black_L,false)
    with(Black_Blue_Dollar_Sign) instance_change(Black_Dollar_Sign,false)
    with(Black_Blue_At) instance_change(Black_At,false)
    with(Black_Blue_Pi) instance_change(Black_Pi,false)
    with(Black_Blue_I) instance_change(Black_I,false)
    with(Black_Blue_Lowercase_Q) instance_change(Black_Lowercase_Q,false)
}
else 
{ 
    if (character_id == 13 and (g_type == 1 or g_type == 2)) 
    {
        show_message(global.text_at_not_swap_big_g)
        exit
    }
    var x_temp;
    var y_temp;
    x_temp = x
    y_temp = y
    if (character_id==31) with(Concreet) if (place_meeting(x,y,other)) instance_change(Yellow,false)
    x = Black_Blue_At.x
    y = Black_Blue_At.y
    Black_Blue_At.x = x_temp
    Black_Blue_At.y = y_temp
    move_snap(grid_size,grid_size)
    if (character_id==13) {g_hit += 1; instance_create(x,y,Explosion)}
    if (character_id==31) with(Yellow) if (place_meeting(x,y,other)) instance_change(Concreet,false)
    score -= 2
    with(Message_Object) instance_destroy()
    Level_Number_Object.alarm[0] = 1 
}


#define Character_Click_Black_Script
// Character_Click_Black_Script
// Stefan Grace
// Created: 2020-02-21
// Modified: 2020-02-22
// This scrip is executed when a black character is clicked on

if (instance_number(Level_Cover)+global.t_detonating > 0) exit

script_execute(Character_Click_Black)
script_execute(Character_Turn_Blue_Black)
#define Character_Click_Red
// Character_Click_Red
// Stefan Grace
// Created: 2016-07-05
// Modified: 2020-02-21
// This scrip makes any other selected charater become unselected when Player 1 clicks on a character

if (instance_number(Level_Cover) > 0) exit

if (global.levelnumber == 0)
{
    if (global.level0messagenumber >= 6 and !global.red_level_0_message_7_hasbeenshown)
    {
        with (Message_Object) instance_destroy()
        global.level0messagenumber = 7
        global.message_type = 57
        instance_create(875, 560, Message_Object)
        global.red_level_0_message_7_hasbeenshown = true
    }
}

if (global.dollar_sign_stunning != 0) // Cancel the $ stun if the player click on another one of their own characters
{
    global.dollar_sign_stunning = 0 
    with (Message_Object) instance_destroy()
}

if (global.big_w_life_draining) // Cancel the Big W life drian if the player click on another one of their own characters
{
    global.big_w_life_draining = false;
    with (Message_Object) instance_destroy()
}

if (global.big_w_life_giving) // Cancel the Big W life give if the player click on another one of their own characters
{
    global.big_w_life_giving = false;
    with (Message_Object) instance_destroy()
}

if (global.w_casting)
{
    if (S_Stuned > 0 and W_Range_Detect()) 
    {
        S_Stuned = 0 
        score -= 1
    }
    else if (character_id == 13 and g_hit < Get_Max_Hits(g_type) and W_Range_Detect())
    {
        g_hit += 1
        score -= 1 
    }
    exit
}

if (global.at_swapping==0)
{
    with(Red_Blue_O) instance_change(Red_O,false)
    with(Red_Blue_X) instance_change(Red_X,false)
    with(Red_Blue_Triangle) instance_change(Red_Triangle,false)
    with(Red_Blue_A) instance_change(Red_A,false)
    with(Red_Blue_Square) instance_change(Red_Square,false)
    with(Red_Blue_K) instance_change(Red_K,false)
    with(Red_Blue_B) instance_change(Red_B,false)
    with(Red_Blue_E) instance_change(Red_E,false)
    with(Red_Blue_S) instance_change(Red_S,false)
    with(Red_Blue_H) instance_change(Red_H,false)
    with(Red_Blue_R) instance_change(Red_R,false)
    with(Red_Blue_M) instance_change(Red_M,false)
    with(Red_Blue_F) instance_change(Red_F,false)
    with(Red_Blue_G) instance_change(Red_G,false)
    with(Red_Blue_C) instance_change(Red_C,false)
    with(Red_Blue_Y) instance_change(Red_Y,false)
    with(Red_Blue_Z) instance_change(Red_Z,false)
    with(Red_Blue_W) instance_change(Red_W,false)
    with(Red_Blue_J) instance_change(Red_J,false)
    with(Red_Blue_V) instance_change(Red_V,false)
    with(Red_Blue_P) instance_change(Red_P,false)
    with(Red_Blue_T) instance_change(Red_T,false)
    with(Red_Blue_D) instance_change(Red_D,false)
    with(Red_Blue_Q) instance_change(Red_Q,false)
    with(Red_Blue_N) instance_change(Red_N,false)
    with(Red_Blue_Question_Mark) instance_change(Red_Question_Mark,false)
    with(Red_Blue_U) instance_change(Red_U,false)
    with(Red_Blue_L) instance_change(Red_L,false)
    with(Red_Blue_Dollar_Sign) instance_change(Red_Dollar_Sign,false)
    with(Red_Blue_At) instance_change(Red_At,false)
    with(Red_Blue_Pi) instance_change(Red_Pi,false)
    with(Red_Blue_I) instance_change(Red_I,false)
    with(Red_Blue_Lowercase_Q) instance_change(Red_Lowercase_Q,false)
}
else
{
    if (character_id == 13 and (g_type == 1 or g_type == 2)) 
    {
        show_message(global.text_at_not_swap_big_g)
        exit
    }
    var x_temp;
    var y_temp;
    x_temp = x
    y_temp = y
    if (character_id==31) with(Concreet) if (place_meeting(x,y,other)) instance_change(Yellow,false)
    x = Red_Blue_At.x
    y = Red_Blue_At.y
    Red_Blue_At.x = x_temp
    Red_Blue_At.y = y_temp
    move_snap(grid_size,grid_size)
    if (character_id==13) {g_hit += 1; instance_create(x,y,Explosion)}
    if (character_id==31) with(Yellow) if (place_meeting(x,y,other)) instance_change(Concreet,false)
    score -= 2
    with(Message_Object) instance_destroy()
    Level_Number_Object.alarm[0] = 1
} 
#define Character_Click_Red_Script
// Character_Click_Red_Script
// Stefan Grace
// Created: 2020-02-21
// Modified: 2020-02-22
// This scrip is executed when a red character is clicked on

if (instance_number(Level_Cover)+global.t_detonating > 0) exit

script_execute(Character_Click_Red)
script_execute(Character_Turn_Blue_Red)
#define Character_Destroy
// Character_Destroy
// Stefan Grace
// Created: 2016-07-16
// Modified: 2020-02-13
// This script is executed when a selected (blue) character is killed

if (((Kill==1) or (RockTunnle==1) or (DimondTunnle==1)) and !v_diagonal_not_anger) score = 0 // This line of code sets the moves to 0 if the character is killed after going through an anger
#define Character_Die
to_be_killed = true
#define Character_Draw
// Character_Draw
// Stefan Grace
// Created: 2017-08-08
// Modified: 2020-02-23
// This script draws out the small characters

/* variables

    type
        0 - Red Stuned
        1 - Red
        2 - Red Blue
        3 - Black Stuned
        4 - Black
        5 - Black Blue
        6 - Green
*/

// Sets things up
draw_set_font(Character_Font)
draw_set_halign(fa_center)
draw_set_valign(fa_center)

// Decides what color the character should be
var color;
if (type==0) 
{
    if (mouse_x>=x and mouse_x<x+17 and mouse_y>y and mouse_y<y+17 and instance_number(Level_Cover)==0)
    and (B_Detect() or Dollar_Sign_Range_Detect())
    {
        color = character_color_blue   
    }
    else if (purple==0) 
    {
        color = character_color_red
    }
    else
    { 
        color = character_color_purple
    }
}
if (type==1) 
{
    if (mouse_x>=x and mouse_x<x+17 and mouse_y>y and mouse_y<y+17 and instance_number(Level_Cover)==0 
    and global.Red_B_Killing_Left+global.Red_B_Killing_Up+global.Red_B_Killing_Right+global.Red_B_Killing_Down == 0)
    {
        color = character_color_blue   
    }
    else if (purple==0)
    {
        color = character_color_red
    }
    else
    {         
        color = character_color_purple                                        
    }                                                                                        
}                                                                                                                                                
if (type==2 or type==5) color = character_color_blue
if (type==3) 
{
    if (mouse_x>=x and mouse_x<x+17 and mouse_y>y and mouse_y<y+17 and instance_number(Level_Cover)==0)
    and (B_Detect() or Dollar_Sign_Range_Detect())
    {
        color = character_color_blue   
    }
    else if (purple==0)
    {
        color = character_color_black
    }
    else
    { 
        color = character_color_dark_blue
    }
}
if (type==4) 
{
    if (mouse_x>=x and mouse_x<x+17 and mouse_y>y and mouse_y<y+17 and instance_number(Level_Cover)==0
    and global.Black_B_Killing_Left+global.Black_B_Killing_Up+global.Black_B_Killing_Right+global.Black_B_Killing_Down == 0)
    {
        color = character_color_blue  
    }
    else if (purple==0)
    {
        color = character_color_black
    }
    else
    { 
        color = character_color_dark_blue
    }
}
if (type==6) 
{
    color = character_color_green
}

// Make the character look yellow if it is an an enviroment of the same color
if (color==character_color_black and place_meeting(x,y,Steel))
or (color==character_color_red and place_meeting(x,y,Red_Anger))
or (color==character_color_blue and place_meeting(x,y,Blue_Anger))
or (color==character_color_green and place_meeting(x,y,Dimond))
or (color==character_color_purple and place_meeting(x,y,Purple_Anger))
{
    color = character_color_yellow
}

// Makes an icy looking box apear round the character when it is stunded
if (S_Stuned>0) draw_sprite(Ice,0,x,y) 

// Decides what the character should look like
draw_set_color(color) 
if (character_id==2)
{
    if (color==character_color_black) draw_sprite(Black_Triangle_Sprite,0,x,y)
    else if (color==character_color_red) draw_sprite(Red_Triangle_Sprite,0,x,y)
    else if (color==character_color_blue) draw_sprite(Blue_Triangle,0,x,y)
    else if (color==character_color_green) draw_sprite(Green_Triangle_Sprite,0,x,y)
    else if (color==character_color_yellow) draw_sprite(Yellow_Triangle,0,x,y)    
    else if (color==character_color_dark_blue) draw_sprite(Dark_Blue_Triangle,0,x,y) 
    else if (color==character_color_purple) draw_sprite(Purple_Triangle,0,x,y)     
}
else if (character_id==4)
{
    if (color==character_color_black) draw_sprite(Black_Square_Sprite,0,x,y)
    else if (color==character_color_red) draw_sprite(Red_Square_Sprite,0,x,y)
    else if (color==character_color_blue) draw_sprite(Blue_Square,0,x,y)
    else if (color==character_color_green) draw_sprite(Green_Square_Sprite,0,x,y)
    else if (color==character_color_yellow) draw_sprite(Yellow_Square,0,x,y)    
    else if (color==character_color_dark_blue) draw_sprite(Dark_Blue_Square,0,x,y) 
    else if (color==character_color_purple) draw_sprite(Purple_Square,0,x,y) 
}
else
{
    draw_text(x+9,y+9,global.character_text[character_id])
}

// Puts things back 
draw_set_halign(0)
draw_set_valign(0)
draw_set_color(0)
#define Character_Jump
if (!(place_meeting(x,y,Red_Anger) or place_meeting(x,y,Orange_Anger) or place_meeting(x,y,Blue_Anger) or place_meeting(x,y,Purple_Anger) or place_meeting(x,y,Teleport)))
{
    if (character_id==22) with(Yellow) if (place_meeting(x,y,other)) instance_change(Dimond,false)
    if (character_id==32) with(Yellow) if (place_meeting(x,y,other)) instance_create(x-(x mod grid_size),y-(y mod grid_size),Mud)
}
x += argument0
y += argument1
move_snap(35,35)
score -= 1
#define Character_Jump_Double_Boxing
// Character_Jump_Double_Boxing
// Stefan Grace
// Created: 2016-08-10
// Modified: 2017-12-14
// This script moves characters in Double Boxing

/* aruguments

argument0 = X Jump

argument1 = Y Jump

argument2 = Rock Tunnle
    0 = No
    1 = Yes

argument3 = Dimond Tunnle
    0 = No
    1 = Yes
*/


// D and I
if (!(place_meeting(x,y,Red_Anger) or place_meeting(x,y,Orange_Anger) or place_meeting(x,y,Blue_Anger) or place_meeting(x,y,Purple_Anger) or place_meeting(x,y,Teleport)))
{
    if (character_id==22) with(Yellow) if (place_meeting(x,y,other)) instance_change(Dimond,false)
    if (character_id==32) with(Yellow) if (place_meeting(x,y,other)) instance_create(x-(x mod grid_size),y-(y mod grid_size),Mud)
}

// Yellow
if (place_meeting(x+argument0,y+argument1,Double_Boxing_Yellow))
{
    script_execute(Character_Move_Double_Boxing,argument0,argument1)
    exit
}

// Rock
if ((argument2>0) or (RockTunnle==1)) and (place_meeting(x+argument0,y+argument1,Double_Boxing_Rock))
{
    script_execute(Character_Move_Double_Boxing,argument0,argument1)
    exit
}

// Dimond
if ((argument3>0) or (DimondTunnle==1)) and (place_meeting(x+argument0,y+argument1,Double_Boxing_Dimond))
{
    script_execute(Character_Move_Double_Boxing,argument0,argument1)
    exit
}
#define Character_Move
// Character_Move
// Stefan Grace
// Created: 2016-07-08
// Modified: 2020-02-24
// This script makes any character move in the chosen direction

/* arguments

argument0 = Direction
    0 = Left
    1 = Up
    2 = Right
    3 = Down
    4 = Top Left (V)
    5 = Top Right (V)
    6 = Bottom Left (V)
    7 = Bottom Right (V)

argument1 = Rock Tunnel
    0 = No
    1 = Yes

argument2 = Dimond Tunnel
    0 = No
    1 = Yes
    
argument3 = B
    0 = No
    1 = Yes
*/


// Game Frozen
//if (global.game_frozen>0) exit

// Stops a character from moving while the ? select screen of menu is showing
if (instance_number(Level_Cover) > 0) exit

// Stop a character from moving while the a boulder or bomb is falling
var boulder_falling;
with (Boulder)
{
    if (falling) boulder_falling = true
}
if (boulder_falling) exit

// Stop the player pressing 2 arrow keys at once
if (Key_Mash_Detect(argument0)) exit

// S Stuned
if (S_Stuned>0) 
{
    show_message (global.text_s_stun)
    exit
}

// Barria
if (character_id!=27 or score<2)
{
    if (argument0==0) and (place_meeting(x,y,Barria_Vertical)) exit
    if (argument0==1) and (place_meeting(x,y,Barria_Horizontal)) exit
    if (argument0==2) and (place_meeting(x+35,y,Barria_Vertical)) exit
    if (argument0==3) and (place_meeting(x,y+35,Barria_Horizontal)) exit
}
else 
{
    if (argument0==0) and (place_meeting(x,y,Barria_Vertical)) score -= 1
    if (argument0==1) and (place_meeting(x,y,Barria_Horizontal)) score -= 1
    if (argument0==2) and (place_meeting(x+35,y,Barria_Vertical)) score -= 1
    if (argument0==3) and (place_meeting(x,y+35,Barria_Horizontal)) score -= 1
}

// Mud
if (place_meeting(x,y,Mud) and character_id!=32) exit // can't move out of mud if it's NOT an I

// Arrow
if (argument0==0) and ((place_meeting(x-35,y,Right_Arrow)) or (place_meeting(x-35,y,Horizontal_Arrow))) exit
if (argument0==1) and ((place_meeting(x,y-35,Down_Arrow)) or (place_meeting(x,y-35,Vertical_Arrow))) exit
if (argument0==2) and ((place_meeting(x+35,y,Left_Arrow)) or (place_meeting(x+35,y,Horizontal_Arrow))) exit
if (argument0==3) and ((place_meeting(x,y+35,Up_Arrow)) or (place_meeting(x,y+35,Vertical_Arrow))) exit
if (!(argument0==0)) and (place_meeting(x,y,Left_Arrow)) exit 
if (!(argument0==1)) and (place_meeting(x,y,Up_Arrow)) exit 
if (!(argument0==2)) and (place_meeting(x,y,Right_Arrow)) exit 
if (!(argument0==3)) and (place_meeting(x,y,Down_Arrow)) exit 
if ((argument0==0) or (argument0==2)) and (place_meeting(x,y,Vertical_Arrow)) exit
if ((argument0==1) or (argument0==3)) and (place_meeting(x,y,Horizontal_Arrow)) exit

// Sets X_Jump and Y_Jump
var X_Jump;
var Y_Jump;
X_Jump = 0
Y_Jump = 0
if (argument0==0) X_Jump = -35
if (argument0==1) Y_Jump = -35
if (argument0==2) X_Jump = 35
if (argument0==3) Y_Jump = 35
if (argument0==4) {X_Jump = -35; Y_Jump = -35} 
if (argument0==5) {X_Jump = 35; Y_Jump = -35} 
if (argument0==6) {X_Jump = -35; Y_Jump = 35} 
if (argument0==7) {X_Jump = 35; Y_Jump = 35} 


// Green G
if (place_meeting(x+X_Jump,y+Y_Jump,Green_G)) exit

// Big W
var big_w_block;
if (player==1) 
{
    with(Red_G) if (place_meeting(x-X_Jump,y-Y_Jump,other) and g_type==3) big_w_block = 1
    with(Red_Stuned_G) if (place_meeting(x-X_Jump,y-Y_Jump,other) and g_type==3) big_w_block = 1
}
if (player==2) 
{
    with(Black_G) if (place_meeting(x-X_Jump,y-Y_Jump,other) and g_type==3) big_w_block = 1
    with(Black_Stuned_G) if (place_meeting(x-X_Jump,y-Y_Jump,other) and g_type==3) big_w_block = 1
}
if (big_w_block>0) exit

// Double Boxing
if (Double_Boxing_Entry_Message_Shown==1)
{
    X_Jump = 0
    Y_Jump = 0
    if (Original_Dir==0) X_Jump = -35
    if (Original_Dir==1) Y_Jump = -35
    if (Original_Dir==2) X_Jump = 35
    if (Original_Dir==3) Y_Jump = 35 
}
if ((place_meeting(x+X_Jump,y+Y_Jump,Double_Boxing)) or (place_meeting(x,y,Double_Boxing)) and argument0 < 4)
{
    if (!(place_meeting(x,y,Double_Boxing))) // Returns true if the character is NOT inside Double Boxing
    {
        if (Double_Boxing_Entry_Message_Shown==0) // Returns true if the Double Boxing Entry Message has NOT been shown
        {
            Double_Boxing_Entry_Message_Shown = 1
            Original_Dir = argument0
            Original_Rock_Tunnle = argument1
            Original_Dimond_Tunnle = argument2
            if ((argument0 mod 2)==0) global.message_type = 10 else global.message_type = 11
            script_execute(Local_Message_Create)
            exit
        }
        if (Double_Boxing_Entry_Message_Shown==1) // Returns true if the Double Boxing Message has been shown
        {
            var X_Jump_Double_Boxing;
            var Y_Jump_Double_Boxing;
            var X_Side_Double_Boxing;
            var Y_Side_Double_Boxing;
            X_Jump_Double_Boxing = 0
            Y_Jump_Double_Boxing = 0
            X_Side_Double_Boxing = 0
            Y_Side_Double_Boxing = 0
            
            if ((x mod 35)<10) Y_Jump_Double_Boxing = Y_Jump else Y_Jump_Double_Boxing = (Y_Jump div 2)
            if (!((argument0 mod 2)==(Original_Dir mod 2))) // Makes it so nothing happens if the wrong arrows are pressed
            {
                Double_Boxing_Entry_Message_Shown = 0
                with(Message_Object) instance_destroy()
            }
            else exit
            if (Original_Dir==0)
            {
                if ((x mod 35)>10) X_Jump_Double_Boxing = X_Jump else X_Jump_Double_Boxing = (X_Jump div 2) 
                if (argument0==1)
                {
                    if ((y mod 35)>10) X_Side_Double_Boxing = -17
                    script_execute(Character_Jump_Double_Boxing,X_Jump_Double_Boxing,X_Side_Double_Boxing,Original_Rock_Tunnle,Original_Dimond_Tunnle)
                    exit
                } 
                if (argument0==3)
                {
                    if ((y mod 35)<10) X_Side_Double_Boxing = 17
                    script_execute(Character_Jump_Double_Boxing,X_Jump_Double_Boxing,X_Side_Double_Boxing,Original_Rock_Tunnle,Original_Dimond_Tunnle)
                    exit
                }
            } 
            if (Original_Dir==1)
            {
                if ((y mod 35)>10) Y_Jump_Double_Boxing = Y_Jump else Y_Jump_Double_Boxing = (Y_Jump div 2) 
                if (argument0==0)
                {
                    if ((x mod 35)>10) Y_Side_Double_Boxing = -17
                    script_execute(Character_Jump_Double_Boxing,Y_Side_Double_Boxing,Y_Jump_Double_Boxing,Original_Rock_Tunnle,Original_Dimond_Tunnle)
                    exit
                } 
                if (argument0==2)
                {
                    if ((x mod 35)<10) Y_Side_Double_Boxing = 17
                    script_execute(Character_Jump_Double_Boxing,Y_Side_Double_Boxing,Y_Jump_Double_Boxing,Original_Rock_Tunnle,Original_Dimond_Tunnle)
                    exit
                }
            } 
            if (Original_Dir==2)
            {
                if ((x mod 35)<10) X_Jump_Double_Boxing = X_Jump else X_Jump_Double_Boxing = (X_Jump div 2) 
                if (argument0==1)
                {
                    if ((y mod 35)>10) X_Side_Double_Boxing = -17
                    script_execute(Character_Jump_Double_Boxing,X_Jump_Double_Boxing,X_Side_Double_Boxing,Original_Rock_Tunnle,Original_Dimond_Tunnle)
                    exit
                } 
                if (argument0==3)
                {
                    if ((y mod 35)<10) X_Side_Double_Boxing = 17
                    script_execute(Character_Jump_Double_Boxing,X_Jump_Double_Boxing,X_Side_Double_Boxing,Original_Rock_Tunnle,Original_Dimond_Tunnle)
                    exit
                }
            } 
            if (Original_Dir==3)
            {
                if ((y mod 35)<10) Y_Jump_Double_Boxing = Y_Jump else Y_Jump_Double_Boxing = (Y_Jump div 2) 
                if (argument0==0)
                {
                    if ((x mod 35)>10) Y_Side_Double_Boxing = -17
                    script_execute(Character_Jump_Double_Boxing,Y_Side_Double_Boxing,Y_Jump_Double_Boxing,Original_Rock_Tunnle,Original_Dimond_Tunnle)
                    exit
                } 
                if (argument0==2)
                {
                    if ((x mod 35)<10) Y_Side_Double_Boxing = 17
                    script_execute(Character_Jump_Double_Boxing,Y_Side_Double_Boxing,Y_Jump_Double_Boxing,Original_Rock_Tunnle,Original_Dimond_Tunnle)
                    exit
                }
            } 
        }
        
    }
    if (place_meeting(x,y,Double_Boxing)) // Returns true if the character is inside Double Boxing
    {
        var X_Jump_Double_Boxing;
        var Y_Jump_Double_Boxing;
        X_Jump_Double_Boxing = X_Jump div 2
        Y_Jump_Double_Boxing = Y_Jump div 2
        if (place_meeting(x+X_Jump_Double_Boxing,y+Y_Jump_Double_Boxing,Double_Boxing)) // Returns true if the character is moving from Double Boxing into Double Boxing
        {
            script_execute(Character_Jump_Double_Boxing,X_Jump_Double_Boxing,Y_Jump_Double_Boxing,argument1,argument2)
            exit
        }
        else 
        {
            var Double_Boxing_X;
            var Double_Boxing_Y;
            Double_Boxing_X = x
            Double_Boxing_Y = y
            with(Double_Boxing_Yellow)
            {
                if ((Double_Boxing_X==x) or (Double_Boxing_X==x-1)) and ((Double_Boxing_Y==y) or (Double_Boxing_Y==y-1)) instance_change(Double_Boxing_Dimond,false) 
            }
            if ((x mod 35)>10) x = x-1
            if ((y mod 35)>10) y = y-1
        }
    }
}


// Box of 4
script_execute(Box_Four_Detect,argument0)
if (boxfull_topleft==1) and (boxfull_topright==1) and (boxfull_bottomleft==1) and (boxfull_bottomright==1)
{
    if (argument3==0)
    {
        if (!long) show_message (global.text_box_four_message)
        script_execute(Box_Four_Place_Full_Clear)
        exit
    }
    // B
    if (argument3==1)
    {
        var b_player;
        b_player = player
        var own_characters;
        own_characters = 0
        with(Character)
        {
            if (player == b_player)
            {
                var i;
                for (i = 0; i < 17; i += 17)
                {
                    var j;
                    for (j = 0; j < 17; j += 17)
                    {
                        if (x - (x mod grid_size) - X_Jump == other.x + i and y - (y mod grid_size) - Y_Jump == other.y + j) own_characters += 1 
                    }
                }
            }
        }
        if (own_characters > 3) 
        {
            show_message (global.text_box_four_message)
            script_execute(Box_Four_Place_Full_Clear)
            exit
        }
        if (argument0==0) and (instance_number(Go_Number_Red)==1) global.Red_B_Killing_Left = 1
        if (argument0==1) and (instance_number(Go_Number_Red)==1) global.Red_B_Killing_Up = 1
        if (argument0==2) and (instance_number(Go_Number_Red)==1) global.Red_B_Killing_Right = 1 
        if (argument0==3) and (instance_number(Go_Number_Red)==1) global.Red_B_Killing_Down = 1 
        if (argument0==0) and (instance_number(Go_Number_Black)==1) global.Black_B_Killing_Left = 1
        if (argument0==1) and (instance_number(Go_Number_Black)==1) global.Black_B_Killing_Up = 1
        if (argument0==2) and (instance_number(Go_Number_Black)==1) global.Black_B_Killing_Right = 1 
        if (argument0==3) and (instance_number(Go_Number_Black)==1) global.Black_B_Killing_Down = 1
        global.message_type = 20
        script_execute(Local_Message_Create)
        script_execute(Box_Four_Place_Full_Clear)
        exit
    }
}
script_execute(Box_Four_Place_Full_Clear) 

// Teleport
if (place_meeting(x+X_Jump,y+Y_Jump,Teleport))
{
    /* Counts the number of characters in both sides of the teleport, adds them together
    and if that number is greater than 3, any character other than B is unable to enter */
    var black_characters_in_port;
    black_characters_in_port = 0
    var red_characters_in_port;
    red_characters_in_port = 0
    with (Teleport)
    {
        if (place_meeting(x-X_Jump,y-Y_Jump,other))
        {
            with (Black_Character)
            {
                if (place_meeting(x,y,other)) black_characters_in_port += 1
            }
            with (Red_Character)
            {
                if (place_meeting(x,y,other)) red_characters_in_port += 1
            }
            var port_color;
            var port_side;
            port_color = color
            port_side = side
            with (Teleport)
            {
                if (color==port_color and side!=port_side)
                {
                    with (Black_Character)
                    {
                        if (place_meeting(x,y,other)) black_characters_in_port += 1
                    }
                     with (Red_Character)
                    {
                        if (place_meeting(x,y,other)) red_characters_in_port += 1
                    }
                }
            }
        }
    }
    if (argument0 == 0)
    {
        if (black_characters_in_port + red_characters_in_port > 3)
        {
            show_message(global.text_teleport_full)
            exit
        }
    }
    else
    {
        if (player == 1 and red_characters_in_port > 3)
        or (player == 2 and black_characters_in_port > 3)
        {
            show_message(global.text_teleport_full)
            exit
        }
        else if (black_characters_in_port + red_characters_in_port > 3)
        {
            if (argument0==0) and (instance_number(Go_Number_Red)==1) global.Red_B_Killing_Left = 1
            if (argument0==1) and (instance_number(Go_Number_Red)==1) global.Red_B_Killing_Up = 1
            if (argument0==2) and (instance_number(Go_Number_Red)==1) global.Red_B_Killing_Right = 1 
            if (argument0==3) and (instance_number(Go_Number_Red)==1) global.Red_B_Killing_Down = 1 
            if (argument0==0) and (instance_number(Go_Number_Black)==1) global.Black_B_Killing_Left = 1
            if (argument0==1) and (instance_number(Go_Number_Black)==1) global.Black_B_Killing_Up = 1
            if (argument0==2) and (instance_number(Go_Number_Black)==1) global.Black_B_Killing_Right = 1 
            if (argument0==3) and (instance_number(Go_Number_Black)==1) global.Black_B_Killing_Down = 1
            global.message_type = 20
            script_execute(Local_Message_Create)
            exit
        }
    }
}
if (place_meeting(x+X_Jump,y+Y_Jump,Teleport))
{
    /* Stops any character from entering a teleport when there is a Big W in the other side */
    var big_w_in_port;
    big_w_in_port = false
    with (Teleport)
    {
        if (place_meeting(x-X_Jump,y-Y_Jump,other))
        {
            var port_color;
            var port_side;
            port_color = color
            port_side = side
            with (Teleport)
            {
                if (color==port_color and side!=port_side)
                {
                    if (instance_number(Go_Number_Black) > 0)
                    {
                        with (Black_G)
                        {
                            if (g_type == 3 and place_meeting(x,y,other)) big_w_in_port = true
                        }
                    }
                    else
                    {
                        with (Red_G)
                        {
                            if (g_type == 3 and place_meeting(x,y,other)) big_w_in_port = true
                        }
                    }
                }
            }
        }
    }
    if (big_w_in_port) exit
}

// Boulder
if (character_id!=15)
{
    if (argument0==0) or (argument0==2)
    {
        if (place_meeting(x+X_Jump,y+Y_Jump,Boulder)) and (!(place_meeting(x+X_Jump*2,y+Y_Jump,Yellow))) exit
        if (place_meeting(x+X_Jump,y+Y_Jump,Boulder)) and (place_meeting(x+X_Jump*2,y+Y_Jump,Boulder)) and (!(place_meeting(x+X_Jump*3,y+Y_Jump,Yellow))) exit
        if (place_meeting(x+X_Jump,y+Y_Jump,Boulder)) and (place_meeting(x+X_Jump*2,y+Y_Jump,Boulder)) and (place_meeting(x+X_Jump*3,y+Y_Jump,Boulder)) and (!(place_meeting(x+X_Jump*4,y+Y_Jump,Yellow))) exit
        if (place_meeting(x+X_Jump,y+Y_Jump,Boulder)) and (place_meeting(x+X_Jump*2,y+Y_Jump,Boulder)) and (place_meeting(x+X_Jump*3,y+Y_Jump,Boulder)) and (place_meeting(x+X_Jump*4,y+Y_Jump,Boulder)) and (!(place_meeting(x+X_Jump*5,y+Y_Jump,Yellow))) exit
        if (place_meeting(x+X_Jump,y+Y_Jump,Boulder)) and (place_meeting(x+X_Jump,y+Y_Jump,Mud)) exit
    }
    if (argument0==1) or (argument0==3)
    {
        if (place_meeting(x+X_Jump,y+Y_Jump,Boulder)) exit
    }
    if (argument0==2) and (place_meeting(x+X_Jump,y,Boulder)) and ((place_meeting(x+X_Jump*2,y,Left_Arrow)) or (place_meeting(x+X_Jump*2,y,Horizontal_Arrow))) exit
    if (argument0==0) and (place_meeting(x+X_Jump,y,Boulder)) and ((place_meeting(x+X_Jump*2,y,Right_Arrow)) or (place_meeting(x+X_Jump*2,y,Horizontal_Arrow))) exit
    if (argument0==2) and (place_meeting(x+X_Jump,y,Boulder)) and (place_meeting(x+X_Jump*2,y,Barria_Vertical)) exit
    if (argument0==0) and (place_meeting(x+X_Jump,y,Boulder)) and (place_meeting(x+X_Jump,y,Barria_Vertical)) exit
    if (argument0==2) and (place_meeting(x+X_Jump,y,Boulder)) and ((place_meeting(x+X_Jump,y,Left_Arrow)) or (place_meeting(x+X_Jump,y,Horizontal_Arrow))) exit
    if (argument0==0) and (place_meeting(x+X_Jump,y,Boulder)) and ((place_meeting(x+X_Jump,y,Right_Arrow)) or (place_meeting(x+X_Jump,y,Horizontal_Arrow))) exit
    if ((argument0==0) or (argument0==2)) and (place_meeting(x+X_Jump,y,Boulder)) and ((place_meeting(x+X_Jump,y,Up_Arrow)) or (place_meeting(x+X_Jump,y,Horizontal_Arrow))) exit
    if ((argument0==0) or (argument0==2)) and (place_meeting(x+X_Jump,y,Boulder)) and ((place_meeting(x+X_Jump,y,Down_Arrow)) or (place_meeting(x+X_Jump,y,Horizontal_Arrow))) exit
    if ((argument0==0) or (argument0==2)) and (place_meeting(x+X_Jump,y,Boulder)) and ((place_meeting(x+X_Jump,y,Vertical_Arrow)) or (place_meeting(x+X_Jump,y,Horizontal_Arrow))) exit
}
else if (place_meeting(x,y-grid_size,Boulder) and argument0==1)
{
    with(Boulder)
    {
        if (place_meeting(x,y+grid_size,other)) instance_destroy()
    }
}

// Anger Colors
if (place_meeting(x+X_Jump,y+Y_Jump,Red_Anger))
{
    score = 1+1
    background_index[0] = -1
    background_color = c_red
    Kill = 1
    RockTunnle = 0
    DimondTunnle = 0
    script_execute(Red_Stun)
    script_execute(Black_Stun)
    global.anger = 1
}
if (place_meeting(x+X_Jump,y+Y_Jump,Orange_Anger))
{
    score = 1+1
    background_index[0] = -1
    background_color = $4080FF
    Kill = 0
    RockTunnle = 1
    DimondTunnle = 0
    script_execute(Red_Stun)
    script_execute(Black_Stun)
    global.anger = 1
}
if (place_meeting(x+X_Jump,y+Y_Jump,Blue_Anger))
{
    score = 1+1
    background_index[0] = -1
    background_color = $FFFF00
    Kill = 0
    RockTunnle = 0
    DimondTunnle = 1
    script_execute(Red_Stun)
    script_execute(Black_Stun)
    global.anger = 1
}
if (place_meeting(x+X_Jump,y+Y_Jump,Purple_Anger))
{
    score = 1+1
    background_index[0] = -1
    background_color = $FF00FF
    Kill = 1
    RockTunnle = 1
    DimondTunnle = 1
    script_execute(Red_Stun)
    script_execute(Black_Stun)
    global.anger = 1
}

// Anger Numbers
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_00)) score = 0+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_02)) score = 2+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_03)) score = 3+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_04)) score = 4+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_05)) score = 5+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_06)) score = 6+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_07)) score = 7+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_08)) score = 8+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_09)) score = 9+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_10)) score = 10+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_11)) score = 11+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_12)) score = 12+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_13)) score = 13+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_14)) score = 14+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_15)) score = 15+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_16)) score = 16+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_17)) score = 17+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_18)) score = 18+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_19)) score = 19+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_20)) score = 20+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_21)) score = 21+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_22)) score = 22+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_23)) score = 23+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_24)) score = 24+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_25)) score = 25+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_26)) score = 26+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_27)) score = 27+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_28)) score = 28+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_29)) score = 29+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_30)) score = 30+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_31)) score = 31+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_32)) score = 32+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_33)) score = 33+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_34)) score = 34+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_35)) score = 35+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_36)) score = 36+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_37)) score = 37+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_38)) score = 38+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_39)) score = 39+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_40)) score = 40+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_41)) score = 41+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_42)) score = 42+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_43)) score = 43+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_44)) score = 44+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_45)) score = 45+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_46)) score = 46+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_47)) score = 47+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_48)) score = 48+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_49)) score = 49+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_50)) score = 50+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_51)) score = 51+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_52)) score = 52+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_53)) score = 53+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_54)) score = 54+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_55)) score = 55+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_56)) score = 56+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_57)) score = 57+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_58)) score = 58+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_59)) score = 59+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_60)) score = 60+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_61)) score = 61+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_62)) score = 62+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_63)) score = 63+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_64)) score = 64+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_65)) score = 65+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_66)) score = 66+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_67)) score = 67+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_68)) score = 68+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_69)) score = 69+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_70)) score = 70+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_71)) score = 71+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_72)) score = 72+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_73)) score = 73+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_74)) score = 74+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_75)) score = 75+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_76)) score = 76+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_77)) score = 77+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_78)) score = 78+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_79)) score = 79+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_80)) score = 80+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_81)) score = 81+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_82)) score = 82+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_83)) score = 83+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_84)) score = 84+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_85)) score = 85+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_86)) score = 86+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_87)) score = 87+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_88)) score = 88+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_89)) score = 89+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_90)) score = 90+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_91)) score = 91+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_92)) score = 92+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_93)) score = 93+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_94)) score = 94+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_95)) score = 95+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_96)) score = 96+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_97)) score = 97+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_98)) score = 98+1
if (place_meeting(x+X_Jump,y+Y_Jump,Anger_99)) score = 99+1

// V 
if (argument0>3)
{
    if (place_meeting(x,y,Double_Boxing)) exit // Stops V from leaving Double Boxing diagoannly
    if (Kill == 0) alarm[1] = 2
    if (Kill + RockTunnle + DimondTunnle == 0) v_diagonal_not_anger = true
    Kill = 1
    var character_in_range;
    character_in_range = false
    var v_player;
    v_player = player
    with(all) // Makes it so V can only move if there is something to kill
    {
        if (character_id + character_o > 0)
        {
            if (player!=v_player)
            {
                var tile_x;
                var tile_y;
                tile_x = x - (x mod grid_size)
                tile_y = y - (y mod grid_size)
                var i;
                for (i = 0; i <= 17; i += 17) 
                {
                    var j;
                    for (j = 0; j <= 17; j += 17) 
                    {
                        if place_meeting((tile_x-X_Jump)+i,(tile_y-Y_Jump)+j,other)
                        {
                            character_in_range = true
                        }  
                    }
                }                   
            }
        }   
    }
    with(Teleport) // Allows V to move diagonally into a teleport if there is an opponent's character in the other side
    {
        if (place_meeting(x-X_Jump,y-Y_Jump,other))
        {
            var port_color;
            var port_side;
            port_color = color
            port_side = side
            with (Teleport)
            {
                if (color==port_color and side!=port_side)
                {
                    with (all)
                    {
                        if (character_id + character_o > 0)
                        {
                            if (place_meeting(x,y,other) and player!=v_player)
                            {
                                character_in_range = true
                            }
                        }
                    }
                }
            }
        }
    }
    if (!character_in_range) 
    {
        show_message (global.text_v_diagonal)
        exit
    }
    var characters_in_tile;
    characters_in_tile = 0
    with(all) // Stops V for getting into a box of 4
    {
        if (character_id + character_o > 0 and character_id != 13) 
        {
            var tile_x;
            var tile_y;
            tile_x = x - (x mod grid_size)
            tile_y = y - (y mod grid_size)
            var i;
            for (i = 0; i <= 17; i += 17) 
            {    
                var j;
                for (j = 0; j <= 17; j += 17) 
                {
                    if place_meeting((tile_x-X_Jump)+i,(tile_y-Y_Jump)+j,other)
                    {
                        characters_in_tile += 1;
                    }  
                }
            }  
        }
    }
    if (characters_in_tile > 3) 
    {
        show_message (global.text_box_four_message)
        exit
    }
}
    
// U
if (character_id==27)
{
    if place_meeting(x+X_Jump,y+Y_Jump,Black_Pi) or place_meeting(x+X_Jump,y+Y_Jump,Black_Stuned_Pi)
    or place_meeting(x+X_Jump,y+Y_Jump,Red_Pi) or place_meeting(x+X_Jump,y+Y_Jump,Red_Stuned_Pi) or place_meeting(x+X_Jump,y+Y_Jump,Green_Pi)
    {
        exit
    }
    if (place_meeting(x+X_Jump,y+Y_Jump,Yellow) and (!place_meeting(x,y,Yellow)))
    {
        Kill = 1
        alarm[1] = 2
        script_execute(Character_Jump,X_Jump,Y_Jump)
        exit
    }
    if (place_meeting(x+X_Jump,y+Y_Jump,Rock) and RockTunnle==0)
    or (place_meeting(x+X_Jump,y+Y_Jump,Dimond) and DimondTunnle==0)
    or place_meeting(x+X_Jump,y+Y_Jump,Concreet) or place_meeting(x+X_Jump,y+Y_Jump,Steel)
    {
        if (place_meeting(x,y,Yellow))
        {
            if (score>=2)
            {
                score -= 1
                script_execute(Character_Jump,X_Jump,Y_Jump)
            }
            exit
        }
        else
        {
            script_execute(Character_Jump,X_Jump,Y_Jump)
            exit
        }
    }
}

// Yellow
if (place_meeting(x+X_Jump,y+Y_Jump,Yellow))
{
    if (character_id == 32) with (Mud) if (place_meeting(x-X_Jump,y-Y_Jump,other)) instance_destroy()
    script_execute(Character_Jump,X_Jump,Y_Jump)
    exit
}

// Rock
if ((argument1==1) or (RockTunnle==1)) and (place_meeting(x+X_Jump,y+Y_Jump,Rock))
{
    with (Rock) if (place_meeting(x-X_Jump,y-Y_Jump,other)) instance_change(Yellow,false)
    script_execute(Character_Jump,X_Jump,Y_Jump)
    exit
}

// Dimond
if ((argument2==1) or (DimondTunnle==1)) and (place_meeting(x+X_Jump,y+Y_Jump,Dimond))
{
    with (Dimond) if (place_meeting(x-X_Jump,y-Y_Jump,other)) instance_change(Yellow,false)
    script_execute(Character_Jump,X_Jump,Y_Jump)
    exit
}
#define Character_Move_Double_Boxing
if (!((place_meeting(x+argument0,y+argument1,Red_O)) 
or (place_meeting(x+argument0,y+argument1,Red_Stuned_O)) 
or (place_meeting(x+argument0,y+argument1,Black_O)) 
or (place_meeting(x+argument0,y+argument1,Black_Stuned_O)) 
or (place_meeting(x+argument0,y+argument1,Red_X)) 
or (place_meeting(x+argument0,y+argument1,Red_Stuned_X)) 
or (place_meeting(x+argument0,y+argument1,Black_X)) 
or (place_meeting(x+argument0,y+argument1,Black_Stuned_X)) 
or (place_meeting(x+argument0,y+argument1,Red_Triangle)) 
or (place_meeting(x+argument0,y+argument1,Red_Stuned_Triangle)) 
or (place_meeting(x+argument0,y+argument1,Black_Triangle)) 
or (place_meeting(x+argument0,y+argument1,Black_Stuned_Triangle)) 
or (place_meeting(x+argument0,y+argument1,Red_A)) 
or (place_meeting(x+argument0,y+argument1,Red_Stuned_A)) 
or (place_meeting(x+argument0,y+argument1,Black_A)) 
or (place_meeting(x+argument0,y+argument1,Black_Stuned_A)) 
or (place_meeting(x+argument0,y+argument1,Red_Square)) 
or (place_meeting(x+argument0,y+argument1,Red_Stuned_Square)) 
or (place_meeting(x+argument0,y+argument1,Black_Square)) 
or (place_meeting(x+argument0,y+argument1,Black_Stuned_Square)) 
or (place_meeting(x+argument0,y+argument1,Red_K)) 
or (place_meeting(x+argument0,y+argument1,Red_Stuned_K)) 
or (place_meeting(x+argument0,y+argument1,Black_K)) 
or (place_meeting(x+argument0,y+argument1,Black_Stuned_K)) 
or (place_meeting(x+argument0,y+argument1,Red_B)) 
or (place_meeting(x+argument0,y+argument1,Red_Stuned_B)) 
or (place_meeting(x+argument0,y+argument1,Black_B)) 
or (place_meeting(x+argument0,y+argument1,Black_Stuned_B)) 
or (place_meeting(x+argument0,y+argument1,Red_E)) 
or (place_meeting(x+argument0,y+argument1,Red_Stuned_E)) 
or (place_meeting(x+argument0,y+argument1,Black_E)) 
or (place_meeting(x+argument0,y+argument1,Black_Stuned_E)) 
or (place_meeting(x+argument0,y+argument1,Red_S)) 
or (place_meeting(x+argument0,y+argument1,Red_Stuned_S)) 
or (place_meeting(x+argument0,y+argument1,Black_S)) 
or (place_meeting(x+argument0,y+argument1,Black_Stuned_S)) 
or (place_meeting(x+argument0,y+argument1,Red_H)) 
or (place_meeting(x+argument0,y+argument1,Red_Stuned_H)) 
or (place_meeting(x+argument0,y+argument1,Black_H)) 
or (place_meeting(x+argument0,y+argument1,Black_Stuned_H)) 
or (place_meeting(x+argument0,y+argument1,Red_R)) 
or (place_meeting(x+argument0,y+argument1,Red_Stuned_R)) 
or (place_meeting(x+argument0,y+argument1,Black_R)) 
or (place_meeting(x+argument0,y+argument1,Black_Stuned_R))
or (place_meeting(x+argument0,y+argument1,Red_M)) 
or (place_meeting(x+argument0,y+argument1,Red_Stuned_M)) 
or (place_meeting(x+argument0,y+argument1,Black_M)) 
or (place_meeting(x+argument0,y+argument1,Black_Stuned_M))
or (place_meeting(x+argument0,y+argument1,Red_F)) 
or (place_meeting(x+argument0,y+argument1,Red_Stuned_F)) 
or (place_meeting(x+argument0,y+argument1,Black_F)) 
or (place_meeting(x+argument0,y+argument1,Black_Stuned_F))
or (place_meeting(x+argument0,y+argument1,Red_C)) 
or (place_meeting(x+argument0,y+argument1,Red_Stuned_C)) 
or (place_meeting(x+argument0,y+argument1,Black_C)) 
or (place_meeting(x+argument0,y+argument1,Black_Stuned_C))
or (place_meeting(x+argument0,y+argument1,Red_Y)) 
or (place_meeting(x+argument0,y+argument1,Red_Stuned_Y)) 
or (place_meeting(x+argument0,y+argument1,Black_Y)) 
or (place_meeting(x+argument0,y+argument1,Black_Stuned_Y))
or (place_meeting(x+argument0,y+argument1,Red_Z)) 
or (place_meeting(x+argument0,y+argument1,Red_Stuned_Z)) 
or (place_meeting(x+argument0,y+argument1,Black_Z)) 
or (place_meeting(x+argument0,y+argument1,Black_Stuned_Z))
or (place_meeting(x+argument0,y+argument1,Red_W)) 
or (place_meeting(x+argument0,y+argument1,Red_Stuned_W)) 
or (place_meeting(x+argument0,y+argument1,Black_W)) 
or (place_meeting(x+argument0,y+argument1,Black_Stuned_W))
or (place_meeting(x+argument0,y+argument1,Red_J)) 
or (place_meeting(x+argument0,y+argument1,Red_Stuned_J)) 
or (place_meeting(x+argument0,y+argument1,Black_J)) 
or (place_meeting(x+argument0,y+argument1,Black_Stuned_J))
or (place_meeting(x+argument0,y+argument1,Red_V)) 
or (place_meeting(x+argument0,y+argument1,Red_Stuned_V)) 
or (place_meeting(x+argument0,y+argument1,Black_V)) 
or (place_meeting(x+argument0,y+argument1,Black_Stuned_V))
or (place_meeting(x+argument0,y+argument1,Red_P)) 
or (place_meeting(x+argument0,y+argument1,Red_Stuned_P)) 
or (place_meeting(x+argument0,y+argument1,Black_P)) 
or (place_meeting(x+argument0,y+argument1,Black_Stuned_P))
or (place_meeting(x+argument0,y+argument1,Red_T)) 
or (place_meeting(x+argument0,y+argument1,Red_Stuned_T)) 
or (place_meeting(x+argument0,y+argument1,Black_T)) 
or (place_meeting(x+argument0,y+argument1,Black_Stuned_T))
or (place_meeting(x+argument0,y+argument1,Red_D)) 
or (place_meeting(x+argument0,y+argument1,Red_Stuned_D)) 
or (place_meeting(x+argument0,y+argument1,Black_D)) 
or (place_meeting(x+argument0,y+argument1,Black_Stuned_D))
or (place_meeting(x+argument0,y+argument1,Red_Q)) 
or (place_meeting(x+argument0,y+argument1,Red_Stuned_Q)) 
or (place_meeting(x+argument0,y+argument1,Black_Q)) 
or (place_meeting(x+argument0,y+argument1,Black_Stuned_Q))
or (place_meeting(x+argument0,y+argument1,Red_N)) 
or (place_meeting(x+argument0,y+argument1,Red_Stuned_N)) 
or (place_meeting(x+argument0,y+argument1,Black_N)) 
or (place_meeting(x+argument0,y+argument1,Black_Stuned_N))
or (place_meeting(x+argument0,y+argument1,Red_Question_Mark)) 
or (place_meeting(x+argument0,y+argument1,Red_Stuned_Question_Mark)) 
or (place_meeting(x+argument0,y+argument1,Black_Question_Mark)) 
or (place_meeting(x+argument0,y+argument1,Black_Stuned_Question_Mark))
or (place_meeting(x+argument0,y+argument1,Red_U)) 
or (place_meeting(x+argument0,y+argument1,Red_Stuned_U)) 
or (place_meeting(x+argument0,y+argument1,Black_U)) 
or (place_meeting(x+argument0,y+argument1,Black_Stuned_U))
or (place_meeting(x+argument0,y+argument1,Red_L)) 
or (place_meeting(x+argument0,y+argument1,Red_Stuned_L)) 
or (place_meeting(x+argument0,y+argument1,Black_L)) 
or (place_meeting(x+argument0,y+argument1,Black_Stuned_L))
or (place_meeting(x+argument0,y+argument1,Red_Dollar_Sign)) 
or (place_meeting(x+argument0,y+argument1,Red_Stuned_Dollar_Sign)) 
or (place_meeting(x+argument0,y+argument1,Black_Dollar_Sign)) 
or (place_meeting(x+argument0,y+argument1,Black_Stuned_Dollar_Sign))
or (place_meeting(x+argument0,y+argument1,Red_At)) 
or (place_meeting(x+argument0,y+argument1,Red_Stuned_At)) 
or (place_meeting(x+argument0,y+argument1,Black_At)) 
or (place_meeting(x+argument0,y+argument1,Black_Stuned_At))
or (place_meeting(x+argument0,y+argument1,Red_I)) 
or (place_meeting(x+argument0,y+argument1,Red_Stuned_I)) 
or (place_meeting(x+argument0,y+argument1,Black_I)) 
or (place_meeting(x+argument0,y+argument1,Black_Stuned_I))
or (place_meeting(x+argument0,y+argument1,Red_Lowercase_Q)) 
or (place_meeting(x+argument0,y+argument1,Red_Stuned_Lowercase_Q)) 
or (place_meeting(x+argument0,y+argument1,Black_Lowercase_Q)) 
or (place_meeting(x+argument0,y+argument1,Black_Stuned_Lowercase_Q))
))
{
    x = x+argument0
    y = y+argument1
    if ((x mod 35)<10) or ((x mod 35)>32) move_snap(35,0)
    if ((y mod 35)<10) or ((y mod 35)>32) move_snap(0,35)
    score -= 1
    script_execute(Double_Boxing_Turn_Yellow,argument0,argument1)
}
else
{
    if (character_id==6)
    {
        x = x+argument0
        y = y+argument1
        if ((x mod 35)<10) or ((x mod 35)>32) move_snap(35,0)
        if ((y mod 35)<10) or ((y mod 35)>32) move_snap(0,35)
        score -= 1
        script_execute(Double_Boxing_Turn_Yellow,argument0,argument1)
        with(all)
        {
            if((player==1 or player==2) and x<other.x+2 and x>other.x-2 and y<other.y+2 and y>other.y-2 and (!(type==2 or type==5))) instance_destroy()
        }
    }
    else
    {
        message_background (Message_background)
        message_button (Message_button) 
        message_button_font (font,11,blue,bold)
        show_message (global.text_box_full_db)
    }
}
#define Character_Range_Detect
// Character_Range_Detect
// Stefan Grace
// Created: 2018-11-04
// Modified: 2018-11-04
// This script returns weather there is a blue character within range

/* arguments
argument0 = character
    0 - W
    1 - $
    2 - Big W
*/

var character_in_range;
w_in_range = false;
var x_jump;
var y_jump;
var i;
var j;
for (j = 0; j < 4; j+= 1)
{
    switch(j)
    {
        case 0:
            x_jump = 1 * grid_size
            y_jump = 0 * grid_size
            break
        case 1:
            x_jump = 0 * grid_size
            y_jump = 1 * grid_size
            break
        case 2:
            x_jump = -1 * grid_size
            y_jump = 0 * grid_size
            break
        case 3:
            x_jump = 0 * grid_size
            y_jump = -1 * grid_size
            break
    }
    for (i = 1; i <= 5; i += 1)
    {
        if (!place_meeting(x + (x_jump * i), y + (y_jump * i), Yellow))
        {
            i = 6
        }
        var x_offset;
        var y_offset;
        if (x mod grid_size == 0)
        {
            x_offset = 0
        }
        else
        {
            x_offset = -17
        }
        if (y mod grid_size == 0)
        {
            y_offset = 0
        }
        else 
        {
            y_offset = -17
        }
        if (argument0 == 0) // W
        {
            // W in Top Left of Tile
            if (place_meeting(x + (x_jump * i) + x_offset, y + (y_jump * i) + y_offset, Red_Blue_W))
            or (place_meeting(x + (x_jump * i) + x_offset, y + (y_jump * i) + y_offset, Black_Blue_W))
            // W in Top Right of Tile
            or (place_meeting(x + (x_jump * i) + 17 + x_offset, y + (y_jump * i) + y_offset, Red_Blue_W))
            or (place_meeting(x + (x_jump * i) + 17 + x_offset, y + (y_jump * i) + y_offset, Black_Blue_W))
            // W in Bottom Left of Tile
            or (place_meeting(x + (x_jump * i) + x_offset, y + (y_jump * i) + 17 + y_offset, Red_Blue_W))
            or (place_meeting(x + (x_jump * i) + x_offset, y + (y_jump * i) + 17 + y_offset, Black_Blue_W))
            // W in Bottom Right of Tile
            or (place_meeting(x + (x_jump * i) + 17 + x_offset, y + (y_jump * i) + 17 + y_offset, Red_Blue_W))
            or (place_meeting(x + (x_jump * i) + 17 + x_offset, y + (y_jump * i) + 17 + y_offset, Black_Blue_W))
            {
                character_in_range = true;
            }
        } 
        else if (argument0 == 1) // $
        {
            // $ in Top Left of Tile
            if (place_meeting(x + (x_jump * i) + x_offset, y + (y_jump * i) + y_offset, Red_Blue_Dollar_Sign))
            or (place_meeting(x + (x_jump * i) + x_offset, y + (y_jump * i) + y_offset, Black_Blue_Dollar_Sign))
            // $ in Top Right of Tile
            or (place_meeting(x + (x_jump * i) + 17 + x_offset, y + (y_jump * i) + y_offset, Red_Blue_Dollar_Sign))
            or (place_meeting(x + (x_jump * i) + 17 + x_offset, y + (y_jump * i) + y_offset, Black_Blue_Dollar_Sign))
            // $ in Bottom Left of Tile
            or (place_meeting(x + (x_jump * i) + x_offset, y + (y_jump * i) + 17 + y_offset, Red_Blue_Dollar_Sign))
            or (place_meeting(x + (x_jump * i) + x_offset, y + (y_jump * i) + 17 + y_offset, Black_Blue_Dollar_Sign))
            // $ in Bottom Right of Tile
            or (place_meeting(x + (x_jump * i) + 17 + x_offset, y + (y_jump * i) + 17 + y_offset, Red_Blue_Dollar_Sign))
            or (place_meeting(x + (x_jump * i) + 17 + x_offset, y + (y_jump * i) + 17 + y_offset, Black_Blue_Dollar_Sign))
            {
                character_in_range = true;
            }/*
            with(Teleport)
            {
                if (place_meeting(x-X_Jump,y-Y_Jump,other))
                {
                    var port_color;
                    var port_side;
                    port_color = color
                    port_side = side
                    with (Teleport)
                    {
                        if (color==port_color and side!=port_side)
                        {
                            if (place_meeting(x, y, Red_Blue_Dollar_Sign) or place_meeting(x, y, Red_Blue_Dollar_Sign)) character_in_range = true;

                        }
                    }
                }
            }*/

        }
        else if (argument0 == 2) // Big W
        {
            // Big W in Top Left of Tile
            if (place_meeting(x + (x_jump * i) + x_offset, y + (y_jump * i) + y_offset, Red_Blue_G))
            or (place_meeting(x + (x_jump * i) + x_offset, y + (y_jump * i) + y_offset, Black_Blue_G))
            // Big W in Top Right of Tile
            or (place_meeting(x + (x_jump * i) + 17 + x_offset, y + (y_jump * i) + y_offset, Red_Blue_G))
            or (place_meeting(x + (x_jump * i) + 17 + x_offset, y + (y_jump * i) + y_offset, Black_Blue_G))
            // Big W in Bottom Left of Tile
            or (place_meeting(x + (x_jump * i) + x_offset, y + (y_jump * i) + 17 + y_offset, Red_Blue_G))
            or (place_meeting(x + (x_jump * i) + x_offset, y + (y_jump * i) + 17 + y_offset, Black_Blue_G))
            // Big W in Bottom Right of Tile
            or (place_meeting(x + (x_jump * i) + 17 + x_offset, y + (y_jump * i) + 17 + y_offset, Red_Blue_G))
            or (place_meeting(x + (x_jump * i) + 17 + x_offset, y + (y_jump * i) + 17 + y_offset, Black_Blue_G))
            {
                character_in_range = true;
            }
        }

    }
}
return character_in_range;
#define Character_Turn_Blue_Black
// Character_Turn_Blue_Black
// Stefan Grace
// Created: 2020-02-20
// Modified: 2020-03-03
// This script turns black characters into black blue characters when they are clicked on

if (global.at_swapping+global.w_casting+global.Black_B_Killing_Left+global.Black_B_Killing_Up+global.Black_B_Killing_Right+global.Black_B_Killing_Down == 0)
{
    switch(character_id)
    {
        case 0:
            instance_change(Black_Blue_O, false)
            break
        case 1:
            instance_change(Black_Blue_X, false)
            break
        case 2:
            instance_change(Black_Blue_Triangle, false)
            break
        case 3:
            instance_change(Black_Blue_A, false)
            break
        case 4:
            instance_change(Black_Blue_Square, false)
            break
        case 5:
            instance_change(Black_Blue_K, false)
            break
        case 6:
            instance_change(Black_Blue_B, false)
            break
        case 7:
            instance_change(Black_Blue_E, false)
            break
        case 8:
            instance_change(Black_Blue_S, false)
            break
        case 9:
            instance_change(Black_Blue_H, false)
            break
        case 10:
            instance_change(Black_Blue_R, false)
            break
        case 11:
            instance_change(Black_Blue_M, false)
            break
        case 12:
            instance_change(Black_Blue_F, false)
            break
        case 13:
            instance_change(Black_Blue_G, false)
            break
        case 14:
            instance_change(Black_Blue_C, false)
            break
        case 15:
            instance_change(Black_Blue_Y, false)
            break
        case 16:
            instance_change(Black_Blue_Z, false)
            break
        case 17:
            instance_change(Black_Blue_W, false)
            break
        case 18:
            instance_change(Black_Blue_J, false)
            break
        case 19:
            instance_change(Black_Blue_V, false)
            break
        case 20:
            instance_change(Black_Blue_P, false)
            break
        case 21:
            instance_change(Black_Blue_T, false)
            break
        case 22:
            instance_change(Black_Blue_D, false)
            break
        case 23:
            instance_change(Black_Blue_Q, false)
            break
        case 24:
            instance_change(Black_Blue_N, false)
            break
        case 26:
            instance_change(Black_Blue_Question_Mark, false)
            break
        case 27:
            instance_change(Black_Blue_U, false)
            break
        case 28:
            instance_change(Black_Blue_L, false)
            break
        case 29:
            instance_change(Black_Blue_Dollar_Sign, false)
            break
        case 30:
            instance_change(Black_Blue_At, false)
            break
        case 31:
            instance_change(Black_Blue_Pi, false)
            break
        case 32:
            instance_change(Black_Blue_I, false)
            break
        case 100:
            instance_change(Black_Blue_Lowercase_Q, false)
    }
    
}

#define Character_Turn_Blue_Red
// Character_Turn_Blue_Red
// Stefan Grace
// Created: 2020-02-21
// Modified: 2020-03-03
// This script turns red characters into red blue characters when they are clicked on

if (global.at_swapping+global.w_casting+global.Red_B_Killing_Left+global.Red_B_Killing_Up+global.Red_B_Killing_Right+global.Red_B_Killing_Down == 0)
{
    switch(character_id)
    {
        case 0:
            instance_change(Red_Blue_O, false)
            break
        case 1:
            instance_change(Red_Blue_X, false)
            break
        case 2:
            instance_change(Red_Blue_Triangle, false)
            break
        case 3:
            instance_change(Red_Blue_A, false)
            break
        case 4:
            instance_change(Red_Blue_Square, false)
            break
        case 5:
            instance_change(Red_Blue_K, false)
            break
        case 6:
            instance_change(Red_Blue_B, false)
            break
        case 7:
            instance_change(Red_Blue_E, false)
            break
        case 8:
            instance_change(Red_Blue_S, false)
            break
        case 9:
            instance_change(Red_Blue_H, false)
            break
        case 10:
            instance_change(Red_Blue_R, false)
            break
        case 11:
            instance_change(Red_Blue_M, false)
            break
        case 12:
            instance_change(Red_Blue_F, false)
            break
        case 13:
            instance_change(Red_Blue_G, false)
            break
        case 14:
            instance_change(Red_Blue_C, false)
            break
        case 15:
            instance_change(Red_Blue_Y, false)
            break
        case 16:
            instance_change(Red_Blue_Z, false)
            break
        case 17:
            instance_change(Red_Blue_W, false)
            break
        case 18:
            instance_change(Red_Blue_J, false)
            break
        case 19:
            instance_change(Red_Blue_V, false)
            break
        case 20:
            instance_change(Red_Blue_P, false)
            break
        case 21:
            instance_change(Red_Blue_T, false)
            break
        case 22:
            instance_change(Red_Blue_D, false)
            break
        case 23:
            instance_change(Red_Blue_Q, false)
            break
        case 24:
            instance_change(Red_Blue_N, false)
            break
        case 26:
            instance_change(Red_Blue_Question_Mark, false)
            break
        case 27:
            instance_change(Red_Blue_U, false)
            break
        case 28:
            instance_change(Red_Blue_L, false)
            break
        case 29:
            instance_change(Red_Blue_Dollar_Sign, false)
            break
        case 30:
            instance_change(Red_Blue_At, false)
            break
        case 31:
            instance_change(Red_Blue_Pi, false)
            break
        case 32:
            instance_change(Red_Blue_I, false)
            break
        case 100:
            instance_change(Red_Blue_Lowercase_Q, false)
    }
    
}

#define Character_Type
// Character_Type
// Stefan Grace
// Created: 2017-09-02
// Modified: 2017-09-02
// This script sets the player and state of a character based on the type

/* arguments

    argument0 - type
        0 - Red Stuned
        1 - Red
        2 - Red Blue
        3 - Black Stuned
        4 - Black
        5 - Black Blue
        6 - Green
*/

/* variables

    type
        0 - Red Stuned
        1 - Red
        2 - Red Blue                
        3 - Black Stuned
        4 - Black
        5 - Black Blue
        6 - Green
        
    player 
        1 - Player 1 (Red)
        2 - Player 2 (Black)
        3 - Neutral (Green)
        
    state
        1 - Stuned
        2 - None
        3 - Blue
*/

// type
type = argument0

// player
if (argument0<=2) player = 1
if (argument0>=3 and argument0<=5) player = 2
if (argument0==6) player = 3

// state
if (argument0==0 or argument0==3) state = 1
if (argument0==1 or argument0==4) state = 2
if (argument0==2 or argument0==5) state = 3
        
#define Charm_Script
// Charm_Script
// Stefan Grace
// Created: 2017-08-04
// Modified: 2017-12-21
// This scipt makes F's charm characters

/* arguments

argument0
    0 - Blue_Charm_Stuned
    1 - Stuned_Charm_Blue
*/

// Black
if (instance_number(Go_Number_Black)>0 and argument0==0) or (instance_number(Go_Number_Red)>0 and argument0==1) 
{
    if (argument0==1) script_execute(Auto_Stack)
    if (character_id==0) instance_change(Black_O,true)
    if (character_id==1) instance_change(Black_X,true)
    if (character_id==2) instance_change(Black_Triangle,true)
    if (character_id==3) instance_change(Black_A,true)
    if (character_id==4) instance_change(Black_Square,true)
    if (character_id==5) instance_change(Black_K,true)
    if (character_id==6) instance_change(Black_B,true)
    if (character_id==7) instance_change(Black_E,true)
    if (character_id==8) instance_change(Black_S,true)
    if (character_id==9) instance_change(Black_H,true)
    if (character_id==10) instance_change(Black_R,true)
    if (character_id==11) instance_change(Black_M,true)
    if (character_id==12) instance_change(Black_F,true)
    if (character_id==14) instance_change(Black_C,true)
    if (character_id==15) instance_change(Black_Y,true)
    if (character_id==16) instance_change(Black_Z,true)
    if (character_id==17) instance_change(Black_W,true)
    if (character_id==18) instance_change(Black_J,true)
    if (character_id==19) instance_change(Black_V,true)
    if (character_id==20) instance_change(Black_P,true)
    if (character_id==21) instance_change(Black_T,true)
    if (character_id==22) instance_change(Black_D,true)
    if (character_id==23) instance_change(Black_Q,true)
    if (character_id==24) instance_change(Black_N,true)
    if (character_id==26) instance_change(Black_Question_Mark,true)
    if (character_id==27) instance_change(Black_U,true)
    if (character_id==28) instance_change(Black_L,true)
    if (character_id==29) instance_change(Black_Dollar_Sign,true)
    if (character_id==30) instance_change(Black_At,true)
    if (character_id==32) instance_change(Black_I,true)
    if (character_id==100) instance_change(Black_Lowercase_Q,true)
    if (global.anger>0) script_execute(Black_Stun)
}

// Red
if (instance_number(Go_Number_Red)>0 and argument0==0) or (instance_number(Go_Number_Black)>0 and argument0==1)
{
    if (argument0==1) script_execute(Auto_Stack)
    if (character_id==0) instance_change(Red_O,true)
    if (character_id==1) instance_change(Red_X,true)
    if (character_id==2) instance_change(Red_Triangle,true)
    if (character_id==3) instance_change(Red_A,true)
    if (character_id==4) instance_change(Red_Square,true)
    if (character_id==5) instance_change(Red_K,true)
    if (character_id==6) instance_change(Red_B,true)
    if (character_id==7) instance_change(Red_E,true)
    if (character_id==8) instance_change(Red_S,true)
    if (character_id==9) instance_change(Red_H,true)
    if (character_id==10) instance_change(Red_R,true)
    if (character_id==11) instance_change(Red_M,true)
    if (character_id==12) instance_change(Red_F,true)
    if (character_id==14) instance_change(Red_C,true)
    if (character_id==15) instance_change(Red_Y,true)
    if (character_id==16) instance_change(Red_Z,true)
    if (character_id==17) instance_change(Red_W,true)
    if (character_id==18) instance_change(Red_J,true)
    if (character_id==19) instance_change(Red_V,true)
    if (character_id==20) instance_change(Red_P,true)
    if (character_id==21) instance_change(Red_T,true)
    if (character_id==22) instance_change(Red_D,true)
    if (character_id==23) instance_change(Red_Q,true)
    if (character_id==24) instance_change(Red_N,true)
    if (character_id==26) instance_change(Red_Question_Mark,true)
    if (character_id==27) instance_change(Red_U,true)
    if (character_id==28) instance_change(Red_L,true)
    if (character_id==29) instance_change(Red_Dollar_Sign,true)
    if (character_id==30) instance_change(Red_At,true)
    if (character_id==32) instance_change(Red_I,true)
    if (character_id==100) instance_change(Red_Lowercase_Q,true)
    if (global.anger>0) script_execute(Red_Stun)
}

#define Dollar_Sign_Range_Detect
// Dollar_Sign_Range_Detect
// Stefan Grace
// Created: 2018-10-31
// Modified: 2018-10-31
// This script returns weather there is a blue $ within range

return Character_Range_Detect(1)
#define Dollar_Sign_Stun_Create
// Dollar_Sign_Create
// Stefan Grace
// Created: 2017-12-23
// Modified: 2018-10-31

/* arguments
    argument0 - player
        1 - Player 1
        2 - Player 2
*/

if (character_id == 17) exit

script_execute(Teleport_Explosion,2)

var i;
var j;
for (i = -2; i < 3; i += 1)
{
    for (j = -2; j < 3; j += 1)
    {
        instance_create((x-(x mod grid_size))-(i*grid_size),(y-(y mod grid_size))-(j*grid_size),Dollar_Sign_Stun)
    }
}

with(all)
{
    if (character_id!=17 and player==argument0)
    {
        if (place_meeting(x,y,Dollar_Sign_Stun)) S_Stuned = 1
    }
}

Dollar_Sign_Stun.alarm[0] = 3
score -= 1
global.dollar_sign_stunning = 0
with(Message_Object) instance_destroy()
#define Dollar_Sign_Stun_Set
// Dollar_Sign_Set
// Stefan Grace
// Created: 2017-12-23
// Modified: 2017-12-23

if (S_Stuned>0) exit 
global.dollar_sign_stunning = 1
global.message_type = 23
script_execute(Local_Message_Create)

#define Double_Boxing_Turn_Yellow
// Double_Boxing_Turn_Yellow
// Stefan Grace
// Created: 2016-08-15
// Modified: 2016-08-15
// This script makes Double Boxing turn yellow when a character moves into it and turn dimond when a character moves out of it

/* aruguments

argument0 = X Jump

argument1 = Y Jump
*/

var Double_Boxing_X;
var Double_Boxing_Y;

Double_Boxing_X = x
Double_Boxing_Y = y

// This block of code makes Double Boxing Rock and Double Boxing Dimond turn yellow when a character moves into it
with(Double_Boxing_Rock)
{
    if ((Double_Boxing_X==x) or (Double_Boxing_X==x-1)) and ((Double_Boxing_Y==y) or (Double_Boxing_Y==y-1)) instance_change(Double_Boxing_Yellow,false)

}
with(Double_Boxing_Dimond)
{
    if ((Double_Boxing_X==x) or (Double_Boxing_X==x-1)) and ((Double_Boxing_Y==y) or (Double_Boxing_Y==y-1)) instance_change(Double_Boxing_Yellow,false)

}

// This block of code makes Double Boxing turn into Dimond when a character moves out of it
with(Double_Boxing_Yellow)
{
    if ((x==(Double_Boxing_X-argument0)) or (x-1==(Double_Boxing_X-argument0))) and ((y==(Double_Boxing_Y-argument1)) or (y-1==(Double_Boxing_Y-argument1))) instance_change(Double_Boxing_Dimond,false)
}

#define Ice_Script
// Ice_Script
// Stefan Grace
// Created: 2017-07-16
// Modified: 2017-07-16
// This script makes an icy looking box apear round a character when it is stunded by an 'S'

if (S_Stuned>0) draw_sprite(Ice,0,x,y) 
if(argument0==0) draw_sprite(Black_X_Sprite,0,x,y)

#define J_Detonate
// J_Detonate
// Stefan Grace
// Created: 2017-08-10
// Modified: 2020-02-15
// This script is executed when a J or J Bomb detonates

if (S_Stuned>0) exit

var explosion_x;
var explosion_y;
explosion_x = x-(x mod 35)
explosion_y = y-(y mod 35)
if (character_id==18) score -= 1
if (!(sound_isplaying(J_Sound))) sound_play(J_Sound)
script_execute(Teleport_Explosion,1)
var x_amount;
var y_amount;
var amount;
var i;
amount = grid_size
x_amount = -1*grid_size
y_amount = 0
repeat(2) // This repeat loop makes the horizontal line
{
    for(i=0; i<36; i+=1)
    {
        x_amount += amount
        if (x_amount + explosion_x < grid_size or x_amount + explosion_x > 36 * grid_size) break // Stops J explosion from blowing up off the edge horizontaly
        instance_create(explosion_x+x_amount,explosion_y,Explosion)
        instance_create(explosion_x+x_amount,explosion_y,Explosion_J_Horizontal_Object)
        with (Concreet) if (place_meeting(x+(0-amount),y,Explosion_J_Horizontal_Object)) i = 36
    }
    amount = -1*grid_size
    x_amount = 0
}
amount = grid_size
repeat(2) // This repeat loop makes the vertical line
{
    for(i=0; i<36; i+=1)
    {
        y_amount += amount
        if (y_amount + explosion_y < grid_size or y_amount + explosion_y > 20 * grid_size) break // Stops J explosion from blowing up off the edge verticaly
        instance_create(explosion_x,explosion_y+y_amount,Explosion)
        instance_create(explosion_x,explosion_y+y_amount,Explosion_J_Vertical_Object)
        with (Concreet) if (place_meeting(x,y+(0-amount),Explosion_J_Vertical_Object)) i = 36
    }
    amount = -1*grid_size
    y_amount = 0
}
instance_create(explosion_x,explosion_y+y_amount,Explosion_J_Vertical_Object)

#define Key_Mash_Detect
// Key_Mash_Detect
// Stefan Grace
// Created: 2020-02-24
// Modified: 2020-02-24
// This script detects if 2 arrow keys are being pressed at the same time

/* arguments

argument0 = Direction
    0 = Left
    1 = Up
    2 = Right
    3 = Down
*/

switch(argument0)
{
    case 0: 
        if (keyboard_check(vk_up) or keyboard_check(vk_right) or keyboard_check(vk_down)) return true
        break
    case 1: 
        if (keyboard_check(vk_left) or keyboard_check(vk_right) or keyboard_check(vk_down)) return true
        break
    case 2: 
        if (keyboard_check(vk_up) or keyboard_check(vk_left) or keyboard_check(vk_down)) return true
        break
    case 3: 
        if (keyboard_check(vk_up) or keyboard_check(vk_right) or keyboard_check(vk_left)) return true
        break
}
if (keyboard_check(vk_left) or keyboard_check(vk_up) or keyboard_check(vk_right) or keyboard_check(vk_down))
and (keyboard_check(ord("A")) or keyboard_check(ord("W")) or keyboard_check(ord("D")) or keyboard_check(ord("S")))
{
    return true
}

return false

#define L_Long
// L_Long
// Stefan Grace
// Created: 2018-11-05
// Modified: 2024-07-28
// This script makes L do it's long thing

/* arguments

argument0 = Direction
    0 = Left
    1 = Up
    2 = Right
    3 = Down
*/


if (keyboard_check(vk_control)) || global.tablet_function_button_active || joystick_check_button(0, 1)
{
    long = true
    var i;
    var hit_anger;
    hit_anger = false
    score = 50
    for(i = 0; i < 37 and !hit_anger; i += 1)
    {
        Character_Move(argument0)
        if (place_meeting(x,y,Red_Anger))
        or (place_meeting(x,y,Orange_Anger))
        or (place_meeting(x,y,Blue_Anger))
        or (place_meeting(x,y,Purple_Anger))
        {
            hit_anger = true
        }
    } 
    if (!hit_anger) score = 0
}
else 
{
    long = false
    Character_Move(argument0, 1)
}
#define Lowercase_Q_Create
character_id = 100
move_snap(grid_size,grid_size)
repeat(4)
{
    script_execute(Auto_Stack_Detect_Black)
    script_execute(Auto_Stack_Detect_Red)
}
#define M_Detonate
// M_Detonate
// Stefan Grace
// Created: 2016-08-23
// Modified: 2017-12-23
// This script is executed when an M or Nuclear Bomb detonates


if (S_Stuned>0) exit

var Explosion_X;
var Explosion_Y;
Explosion_X = x-(x mod 35)
Explosion_Y = y-(y mod 35)
if (character_id==11) score -= 1
if (!(sound_isplaying(M_Sound))) sound_play(M_Sound)
script_execute(Teleport_Explosion,0)
instance_create(Explosion_X-35,Explosion_Y-35,Explosion)
instance_create(Explosion_X,Explosion_Y-35,Explosion)
instance_create(Explosion_X+35,Explosion_Y-35,Explosion)
instance_create(Explosion_X-35,Explosion_Y,Explosion)
instance_create(Explosion_X,Explosion_Y,Explosion)
instance_create(Explosion_X+35,Explosion_Y,Explosion)
instance_create(Explosion_X-35,Explosion_Y+35,Explosion)
instance_create(Explosion_X,Explosion_Y+35,Explosion)
instance_create(Explosion_X+35,Explosion_Y+35,Explosion)
instance_create(Explosion_X+17,Explosion_Y+17,Explosion_M_Object)

/* UNUSED LINES OF CODE
if (global.game_frozen>0) exit
*/
#define Neutral_Character_Script
// Neutral_Character_Script
// Stefan Grace
// Created: 2017-07-30
// Modified: 2017-12-21
// This script controlls neutral characters

/* arguments
    argument 0 - character
*/

// Red Get
if (place_meeting(x,y,Red_Blue_O))
or (place_meeting(x,y,Red_Blue_X))
or (place_meeting(x,y,Red_Blue_Triangle))
or (place_meeting(x,y,Red_Blue_A))
or (place_meeting(x,y,Red_Blue_Square))
or (place_meeting(x,y,Red_Blue_K))
or (place_meeting(x,y,Red_Blue_B))
or (place_meeting(x,y,Red_Blue_E))
or (place_meeting(x,y,Red_Blue_S))
or (place_meeting(x,y,Red_Blue_H))
or (place_meeting(x,y,Red_Blue_R))
or (place_meeting(x,y,Red_Blue_M))
or (place_meeting(x,y,Red_Blue_F))
or (place_meeting(x,y,Red_Blue_C))
or (place_meeting(x,y,Red_Blue_Y))
or (place_meeting(x,y,Red_Blue_Z))
or (place_meeting(x,y,Red_Blue_W))
or (place_meeting(x,y,Red_Blue_J))
or (place_meeting(x,y,Red_Blue_V))
or (place_meeting(x,y,Red_Blue_P))
or (place_meeting(x,y,Red_Blue_T))
or (place_meeting(x,y,Red_Blue_D))
or (place_meeting(x,y,Red_Blue_Q))
or (place_meeting(x,y,Red_Blue_N))
or (place_meeting(x,y,Red_Blue_Question_Mark))
or (place_meeting(x,y,Red_Blue_U))
or (place_meeting(x,y,Red_Blue_L))
or (place_meeting(x,y,Red_Blue_Dollar_Sign))
or (place_meeting(x,y,Red_Blue_At))
or (place_meeting(x,y,Red_Blue_I))
or (place_meeting(x,y,Red_Blue_Lowercase_Q))
{
    if (argument0==0) instance_change(Red_O,true)
    if (argument0==1) instance_change(Red_X,true)
    if (argument0==2) instance_change(Red_Triangle,true)
    if (argument0==3) instance_change(Red_A,true)
    if (argument0==4) instance_change(Red_Square,true)
    if (argument0==5) instance_change(Red_K,true)
    if (argument0==6) instance_change(Red_B,true)
    if (argument0==7) instance_change(Red_E,true)
    if (argument0==8) instance_change(Red_S,true)
    if (argument0==9) instance_change(Red_H,true)
    if (argument0==10) instance_change(Red_R,true)
    if (argument0==11) instance_change(Red_M,true)
    if (argument0==12) instance_change(Red_F,true)
    if (argument0==14) instance_change(Red_C,true)
    if (argument0==15) instance_change(Red_Y,true)
    if (argument0==16) instance_change(Red_Z,true)
    if (argument0==17) instance_change(Red_W,true)
    if (argument0==18) instance_change(Red_J,true)
    if (argument0==19) instance_change(Red_V,true)
    if (argument0==20) instance_change(Red_P,true)
    if (argument0==21) instance_change(Red_T,true)
    if (argument0==22) instance_change(Red_D,true)
    if (argument0==23) instance_change(Red_Q,true)
    if (argument0==24) instance_change(Red_N,true)
    if (argument0==26) instance_change(Red_Question_Mark,true)
    if (argument0==27) instance_change(Red_U,true)
    if (argument0==28) instance_change(Red_L,true)
    if (argument0==29) instance_change(Red_Dollar_Sign,true)
    if (argument0==30) instance_change(Red_At,true)
    if (argument0==32) instance_change(Red_I,true)
    if (argument0==100) instance_change(Red_Lowercase_Q,true)
    if (global.anger>0) script_execute(Red_Stun)
}

// Black Get
if (place_meeting(x,y,Black_Blue_O))
or (place_meeting(x,y,Black_Blue_X))
or (place_meeting(x,y,Black_Blue_Triangle))
or (place_meeting(x,y,Black_Blue_A))
or (place_meeting(x,y,Black_Blue_Square))
or (place_meeting(x,y,Black_Blue_K))
or (place_meeting(x,y,Black_Blue_B))
or (place_meeting(x,y,Black_Blue_E))
or (place_meeting(x,y,Black_Blue_S))
or (place_meeting(x,y,Black_Blue_H))
or (place_meeting(x,y,Black_Blue_R))
or (place_meeting(x,y,Black_Blue_M))
or (place_meeting(x,y,Black_Blue_F))
or (place_meeting(x,y,Black_Blue_C))
or (place_meeting(x,y,Black_Blue_Y))
or (place_meeting(x,y,Black_Blue_Z))
or (place_meeting(x,y,Black_Blue_W))
or (place_meeting(x,y,Black_Blue_J))
or (place_meeting(x,y,Black_Blue_V))
or (place_meeting(x,y,Black_Blue_P))
or (place_meeting(x,y,Black_Blue_T))
or (place_meeting(x,y,Black_Blue_D))
or (place_meeting(x,y,Black_Blue_Q))
or (place_meeting(x,y,Black_Blue_N))
or (place_meeting(x,y,Black_Blue_Question_Mark))
or (place_meeting(x,y,Black_Blue_U))
or (place_meeting(x,y,Black_Blue_L))
or (place_meeting(x,y,Black_Blue_Dollar_Sign))
or (place_meeting(x,y,Black_Blue_At))
or (place_meeting(x,y,Black_Blue_I))
or (place_meeting(x,y,Black_Blue_Lowercase_Q))
{
    if (argument0==0) instance_change(Black_O,true)
    if (argument0==1) instance_change(Black_X,true)
    if (argument0==2) instance_change(Black_Triangle,true)
    if (argument0==3) instance_change(Black_A,true)
    if (argument0==4) instance_change(Black_Square,true)
    if (argument0==5) instance_change(Black_K,true)
    if (argument0==6) instance_change(Black_B,true)
    if (argument0==7) instance_change(Black_E,true)
    if (argument0==8) instance_change(Black_S,true)
    if (argument0==9) instance_change(Black_H,true)
    if (argument0==10) instance_change(Black_R,true)
    if (argument0==11) instance_change(Black_M,true)
    if (argument0==12) instance_change(Black_F,true)
    if (argument0==14) instance_change(Black_C,true)
    if (argument0==15) instance_change(Black_Y,true)
    if (argument0==16) instance_change(Black_Z,true)
    if (argument0==17) instance_change(Black_W,true)
    if (argument0==18) instance_change(Black_J,true)
    if (argument0==19) instance_change(Black_V,true)
    if (argument0==20) instance_change(Black_P,true)
    if (argument0==21) instance_change(Black_T,true)
    if (argument0==22) instance_change(Black_D,true)
    if (argument0==23) instance_change(Black_Q,true)
    if (argument0==24) instance_change(Black_N,true)
    if (argument0==26) instance_change(Black_Question_Mark,true)
    if (argument0==27) instance_change(Black_U,true)
    if (argument0==28) instance_change(Black_L,true)
    if (argument0==29) instance_change(Black_Dollar_Sign,true)
    if (argument0==30) instance_change(Black_At,true)
    if (argument0==32) instance_change(Black_I,true)
    if (argument0==100) instance_change(Black_Lowercase_Q,true)
    if (global.anger>0) script_execute(Black_Stun)
}

// Destroys the neutral character when it gets crushed by a boulder
if (place_meeting(x,y,Boulder)) instance_destroy()

// Destroys the neutral character when a G goes into it
if (place_meeting(x,y,Red_Blue_G)) instance_destroy()
if (place_meeting(x,y,Black_Blue_G)) instance_destroy()
#define Q_Port
// Q_Port
// Stefan Grace
// Created: 2017-12-21
// Modified: 2020-02-28
// This script makes Q's spawn q's at both sides of a teleport


if (score<4) exit

var spawned_q;
spawned_q = Q_Spawn()

var temp_x;
var temp_y;
var port_side;
var port_color;
temp_x = x
temp_y = y

if (place_meeting(x,y,Teleport)) with(Teleport) if (place_meeting(x,y,other))
{
    port_side = side
    port_color = color
    with(Teleport) if (side!=port_side and color==port_color)
    {
        Red_Blue_Q.x = x
        Red_Blue_Q.y = y
        Black_Blue_Q.x = x
        Black_Blue_Q.y = y
        with(Red_Blue_Q) spawned_q += Q_Spawn()
        with(Black_Blue_Q) spawned_q += Q_Spawn()
        Red_Blue_Q.x = temp_x
        Red_Blue_Q.y = temp_y
        Black_Blue_Q.x = temp_x
        Black_Blue_Q.y = temp_y
    }
}

if (spawned_q > 0) score -= 4
#define Q_Spawn
// Q_Spawn
// Stefan Grace
// Created: 2017-12-21
// Modified: 2020-02-28
// This script makes Q's spawn 4 q's


if (S_Stuned>0) exit

var leftfull;
var topfull;
var rightfull;
var bottomfull;

leftfull = 0
topfull = 0
rightfull = 0
bottomfull = 0

script_execute(Box_Four_Detect,0)
if (boxfull_topleft==1) and (boxfull_topright==1) and (boxfull_bottomleft==1) and (boxfull_bottomright==1) leftfull = 1
script_execute(Box_Four_Place_Full_Clear)

script_execute(Box_Four_Detect,1)
if (boxfull_topleft==1) and (boxfull_topright==1) and (boxfull_bottomleft==1) and (boxfull_bottomright==1) topfull = 1
script_execute(Box_Four_Place_Full_Clear)

script_execute(Box_Four_Detect,2)
if (boxfull_topleft==1) and (boxfull_topright==1) and (boxfull_bottomleft==1) and (boxfull_bottomright==1) rightfull = 1
script_execute(Box_Four_Place_Full_Clear)

script_execute(Box_Four_Detect,3)
if (boxfull_topleft==1) and (boxfull_topright==1) and (boxfull_bottomleft==1) and (boxfull_bottomright==1) bottomfull = 1
script_execute(Box_Four_Place_Full_Clear)

var spawned_q;
spawned_q = 0

if (player==1)
{
    if (Kill+RockTunnle+DimondTunnle==0) // if the Q has just been through an anger
    {
        if(place_meeting(x-grid_size,y,Yellow) and (!place_meeting(x-grid_size,y,Red_G)) and leftfull==0) {instance_create(x-grid_size,y,Red_Lowercase_Q); spawned_q += 1}
        if(place_meeting(x,y-grid_size,Yellow) and (!place_meeting(x,y-grid_size,Red_G)) and topfull==0) {instance_create(x,y-grid_size,Red_Lowercase_Q); spawned_q += 1}
        if(place_meeting(x+grid_size,y,Yellow) and (!place_meeting(x+grid_size,y,Red_G)) and rightfull==0) {instance_create(x+grid_size,y,Red_Lowercase_Q); spawned_q += 1}
        if(place_meeting(x,y+grid_size,Yellow) and (!place_meeting(x,y+grid_size,Red_G)) and bottomfull==0) {instance_create(x,y+grid_size,Red_Lowercase_Q); spawned_q += 1}
    }
    else 
    {
        if(place_meeting(x-grid_size,y,Yellow) and (!place_meeting(x-grid_size,y,Red_G)) and leftfull==0) {instance_create(x-grid_size,y,Red_Stuned_Lowercase_Q); spawned_q += 1}
        if(place_meeting(x,y-grid_size,Yellow) and (!place_meeting(x,y-grid_size,Red_G)) and topfull==0) {instance_create(x,y-grid_size,Red_Stuned_Lowercase_Q); spawned_q += 1}
        if(place_meeting(x+grid_size,y,Yellow) and (!place_meeting(x+grid_size,y,Red_G)) and rightfull==0) {instance_create(x+grid_size,y,Red_Stuned_Lowercase_Q); spawned_q += 1}
        if(place_meeting(x,y+grid_size,Yellow) and (!place_meeting(x,y+grid_size,Red_G)) and bottomfull==0) {instance_create(x,y+grid_size,Red_Stuned_Lowercase_Q); spawned_q += 1}
    }
}
else if (player==2)
{
    if (Kill+RockTunnle+DimondTunnle==0) // if the Q has just been through an anger
    {
        if(place_meeting(x-grid_size,y,Yellow) and (!place_meeting(x-grid_size,y,Red_G)) and leftfull==0) {instance_create(x-grid_size,y,Black_Lowercase_Q); spawned_q += 1}
        if(place_meeting(x,y-grid_size,Yellow) and (!place_meeting(x,y-grid_size,Red_G)) and topfull==0) {instance_create(x,y-grid_size,Black_Lowercase_Q); spawned_q += 1}
        if(place_meeting(x+grid_size,y,Yellow) and (!place_meeting(x+grid_size,y,Red_G)) and rightfull==0) {instance_create(x+grid_size,y,Black_Lowercase_Q); spawned_q += 1}
        if(place_meeting(x,y+grid_size,Yellow) and (!place_meeting(x,y+grid_size,Red_G)) and bottomfull==0) {instance_create(x,y+grid_size,Black_Lowercase_Q); spawned_q += 1}
    }
    else 
    {
        if(place_meeting(x-grid_size,y,Yellow) and (!place_meeting(x-grid_size,y,Red_G)) and leftfull==0) {instance_create(x-grid_size,y,Black_Stuned_Lowercase_Q); spawned_q += 1}
        if(place_meeting(x,y-grid_size,Yellow) and (!place_meeting(x,y-grid_size,Red_G)) and topfull==0) {instance_create(x,y-grid_size,Black_Stuned_Lowercase_Q); spawned_q += 1}
        if(place_meeting(x+grid_size,y,Yellow) and (!place_meeting(x+grid_size,y,Red_G)) and rightfull==0) {instance_create(x+grid_size,y,Black_Stuned_Lowercase_Q); spawned_q += 1}
        if(place_meeting(x,y+grid_size,Yellow) and (!place_meeting(x,y+grid_size,Red_G)) and bottomfull==0) {instance_create(x,y+grid_size,Black_Stuned_Lowercase_Q); spawned_q += 1}
    }
}

return spawned_q
#define R_Shoot
// R_Shoot
// Stefan Grace
// Created: 2016-07-21
// Modified: 2024-07-28
// This script makes the R fire an arrow when the control key is held down

/* arguments

argument0 = Direction
    0 = Left
    1 = Up
    2 = Right
    3 = Down
*/


var something_to_shoot;
var i;
var k;
var x_skip;
var y_skip;
var material_in_the_way;

if (global.game_frozen>0) exit
if keyboard_check(vk_control) || global.tablet_function_button_active || joystick_check_button(0, 1)
{
    if (S_Stuned>0)
    {
        show_message(global.text_r_stun)
        exit
    }
    if (argument0==0) 
    {
        x_skip = grid_size
        y_skip = 0
    }
    else if (argument0==1)
    {
        x_skip = 0
        y_skip = grid_size
    }
    else if (argument0==2)
    {
        x_skip = grid_size * -1
        y_skip = 0
    }
    else 
    {
        x_skip = 0
        y_skip = grid_size * -1
    }
    if (instance_number(Go_Number_Black)>0)
    {
        with(all) 
        {
            if (player==1)
            {
                for (i = 1; i<=5; i += 1)
                {
                    if (x - (x mod grid_size) == (other.x - (other.x mod grid_size)) - (x_skip * i) and y - (y mod grid_size) == (other.y - (other.y mod grid_size)) - (y_skip * i))
                    {
                        for (j = 0; j<=i; j +=1)
                        {
                             if (place_meeting((x - (x mod grid_size)) + (j * x_skip), (y - (y mod grid_size)) + (j * y_skip), Rock)) 
                             or (place_meeting((x - (x mod grid_size)) + (j * x_skip), (y - (y mod grid_size)) + (j * y_skip), Dimond)) 
                             or (place_meeting((x - (x mod grid_size)) + (j * x_skip), (y - (y mod grid_size)) + (j * y_skip), Concreet)) 
                             or (place_meeting((x - (x mod grid_size)) + (j * x_skip), (y - (y mod grid_size)) + (j * y_skip), Double_Boxing)) 
                             or (place_meeting((x - (x mod grid_size)) + (j * x_skip), (y - (y mod grid_size)) + (j * y_skip), Mud))
                             {
                                material_in_the_way = true;
                             }
                        }
                        if (!material_in_the_way) something_to_shoot = true;
                    }
                }
            }
        }
    } 
    else
    {
        with(all) 
        {
            if (player==2)
            {
                for (i = 1; i<=5; i += 1)
                {
                    if (x - (x mod grid_size) == (other.x - (other.x mod grid_size)) - (x_skip * i) and y - (y mod grid_size) == (other.y - (other.y mod grid_size)) - (y_skip * i))
                    {
                        for (j = 0; j<=i; j +=1)
                        {
                             if (place_meeting((x - (x mod grid_size)) + (j * x_skip), (y - (y mod grid_size)) + (j * y_skip), Rock)) 
                             or (place_meeting((x - (x mod grid_size)) + (j * x_skip), (y - (y mod grid_size)) + (j * y_skip), Dimond)) 
                             or (place_meeting((x - (x mod grid_size)) + (j * x_skip), (y - (y mod grid_size)) + (j * y_skip), Concreet)) 
                             or (place_meeting((x - (x mod grid_size)) + (j * x_skip), (y - (y mod grid_size)) + (j * y_skip), Double_Boxing)) 
                             or (place_meeting((x - (x mod grid_size)) + (j * x_skip), (y - (y mod grid_size)) + (j * y_skip), Mud))
                             {
                                material_in_the_way = true;
                             }
                        }
                        if (!material_in_the_way) something_to_shoot = true;
                    }
                }
            }
        }
    }
    if (!something_to_shoot) exit
    global.R_Arrow_Point = argument0
    instance_create(x+(17 - x mod 35),y+(17 - y mod 35),R_Arrow)
    instance_create(x+(17 - x mod 35),y+(17 - y mod 35),R_Arrow_Mask)
    sound_play(R_Sound)
    score -= 1
}
else script_execute(Character_Move,argument0)
#define Red_Stun
with(Red_X) instance_change(Red_Stuned_X,false)
with(Red_O) instance_change(Red_Stuned_O,false)
with(Red_Triangle) instance_change(Red_Stuned_Triangle,false)
with(Red_A) instance_change(Red_Stuned_A,false)
with(Red_Square) instance_change(Red_Stuned_Square,false)
with(Red_K) instance_change(Red_Stuned_K,false)
with(Red_B) instance_change(Red_Stuned_B,false)
with(Red_E) instance_change(Red_Stuned_E,false)
with(Red_S) instance_change(Red_Stuned_S,false)
with(Red_H) instance_change(Red_Stuned_H,false)
with(Red_R) instance_change(Red_Stuned_R,false)
with(Red_M) instance_change(Red_Stuned_M,false)
with(Red_F) instance_change(Red_Stuned_F,false)
with(Red_G) instance_change(Red_Stuned_G,false)
with(Red_C) instance_change(Red_Stuned_C,false)
with(Red_Y) instance_change(Red_Stuned_Y,false)
with(Red_Z) instance_change(Red_Stuned_Z,false)
with(Red_W) instance_change(Red_Stuned_W,false)
with(Red_J) instance_change(Red_Stuned_J,false)
with(Red_V) instance_change(Red_Stuned_V,false)
with(Red_P) instance_change(Red_Stuned_P,false)
with(Red_T) instance_change(Red_Stuned_T,false)
with(Red_D) instance_change(Red_Stuned_D,false)
with(Red_Q) instance_change(Red_Stuned_Q,false)
with(Red_N) instance_change(Red_Stuned_N,false)
with(Red_Question_Mark) instance_change(Red_Stuned_Question_Mark,false)
with(Red_U) instance_change(Red_Stuned_U,false)
with(Red_L) instance_change(Red_Stuned_L,false)
with(Red_Dollar_Sign) instance_change(Red_Stuned_Dollar_Sign,false)
with(Red_At) instance_change(Red_Stuned_At,false)
with(Red_Pi) instance_change(Red_Stuned_Pi,false)
with(Red_I) instance_change(Red_Stuned_I,false)
with(Red_Lowercase_Q) instance_change(Red_Stuned_Lowercase_Q,false)
#define Red_Unstun
with(Red_Stuned_X) instance_change(Red_X,false)
with(Red_Stuned_O) instance_change(Red_O,false)
with(Red_Stuned_Triangle) instance_change(Red_Triangle,false)
with(Red_Stuned_A) instance_change(Red_A,false)
with(Red_Stuned_Square) instance_change(Red_Square,false)
with(Red_Stuned_K) instance_change(Red_K,false)
with(Red_Stuned_B) instance_change(Red_B,false)
with(Red_Stuned_E) instance_change(Red_E,false)
with(Red_Stuned_S) instance_change(Red_S,false)
with(Red_Stuned_H) instance_change(Red_H,false)
with(Red_Stuned_R) instance_change(Red_R,false)
with(Red_Stuned_M) instance_change(Red_M,false)
with(Red_Stuned_F) instance_change(Red_F,false)
with(Red_Stuned_G) instance_change(Red_G,false)
with(Red_Stuned_C) instance_change(Red_C,false)
with(Red_Stuned_Y) instance_change(Red_Y,false)
with(Red_Stuned_Z) instance_change(Red_Z,false)
with(Red_Stuned_W) instance_change(Red_W,false)
with(Red_Stuned_J) instance_change(Red_J,false)
with(Red_Stuned_V) instance_change(Red_V,false)
with(Red_Stuned_P) instance_change(Red_P,false)
with(Red_Stuned_T) instance_change(Red_T,false)
with(Red_Stuned_D) instance_change(Red_D,false)
with(Red_Stuned_Q) instance_change(Red_Q,false)
with(Red_Stuned_N) instance_change(Red_N,false)
with(Red_Stuned_Question_Mark) instance_change(Red_Question_Mark,false)
with(Red_Stuned_U) instance_change(Red_U,false)
with(Red_Stuned_L) instance_change(Red_L,false)
with(Red_Stuned_Dollar_Sign) instance_change(Red_Dollar_Sign,false)
with(Red_Stuned_At) instance_change(Red_At,false)
with(Red_Stuned_Pi) instance_change(Red_Pi,false)
with(Red_Stuned_I) instance_change(Red_I,false)
with(Red_Stuned_Lowercase_Q) instance_change(Red_Lowercase_Q,false)
#define S_Stun_Script
if (other.Kill==1) instance_destroy() else S_Stuned = 1
#define T_Detonate_Black
// T_Detonate_Black
// Stefan Grace
// Created: 2017-12-22
// Modified: 2020-02-22
// This script makes the T detonate after the other T has been clicked

if (instance_number(Level_Cover)+global.Black_B_Killing_Left+global.Black_B_Killing_Up+global.Black_B_Killing_Right+global.Black_B_Killing_Down > 0) exit

if (global.t_detonating==0)
{
    script_execute(Character_Click_Black)
    if (global.at_swapping==0 and !global.w_casting) instance_change(Black_Blue_T,false)
    exit
}

// Detects which direction the blue T is in
var t_left;
var t_up;
var t_right;
var t_down;
t_left = 0
t_up = 0
t_right = 0
t_down = 0
for (i = 2; i < 37; i += 1)
{
    // left
    if (place_meeting((x-(x mod grid_size))-(i*grid_size),(y-(y mod grid_size)),Black_Blue_T)) t_left += 1
    if (place_meeting(((x-(x mod grid_size))-(i*grid_size))+17,(y-(y mod grid_size)),Black_Blue_T)) t_left += 1
    if (place_meeting((x-(x mod grid_size))-(i*grid_size),(y-(y mod grid_size))+17,Black_Blue_T)) t_left += 1
    if (place_meeting(((x-(x mod grid_size))-(i*grid_size))+17,(y-(y mod grid_size))+17,Black_Blue_T)) t_left += 1
    // up
    if (place_meeting((x-(x mod grid_size)),(y-(y mod grid_size))-(i*grid_size),Black_Blue_T)) t_up += 1
    if (place_meeting((x-(x mod grid_size))+17,(y-(y mod grid_size))-(i*grid_size),Black_Blue_T)) t_up += 1
    if (place_meeting((x-(x mod grid_size)),((y-(y mod grid_size))-(i*grid_size))+17,Black_Blue_T)) t_up += 1
    if (place_meeting((x-(x mod grid_size))+17,((y-(y mod grid_size))-(i*grid_size))+17,Black_Blue_T)) t_up += 1
    // right
    if (place_meeting((x-(x mod grid_size))+(i*grid_size),(y-(y mod grid_size)),Black_Blue_T)) t_right += 1
    if (place_meeting(((x-(x mod grid_size))+(i*grid_size))+17,(y-(y mod grid_size)),Black_Blue_T)) t_right += 1
    if (place_meeting((x-(x mod grid_size))+(i*grid_size),(y-(y mod grid_size))+17,Black_Blue_T)) t_right += 1
    if (place_meeting(((x-(x mod grid_size))+(i*grid_size))+17,(y-(y mod grid_size))+17,Black_Blue_T)) t_right += 1
    // down
    if (place_meeting((x-(x mod grid_size)),(y-(y mod grid_size))+(i*grid_size),Black_Blue_T)) t_down += 1
    if (place_meeting((x-(x mod grid_size))+17,(y-(y mod grid_size))+(i*grid_size),Black_Blue_T)) t_down += 1
    if (place_meeting((x-(x mod grid_size)),((y-(y mod grid_size))+(i*grid_size))+17,Black_Blue_T)) t_down += 1
    if (place_meeting((x-(x mod grid_size))+17,((y-(y mod grid_size))+(i*grid_size))+17,Black_Blue_T)) t_down += 1
}

// Makes T explosions get blocked by concreet
var stopped_exploding;
var blocked_by_concreet;
stopped_exploding = 0
blocked_by_concreet = 0
for (i = 1; i < 37; i += 1)
{
    if (t_left>0 and stopped_exploding==0)
    {
        if (!place_meeting((x-(x mod grid_size))-(i*grid_size),(y-(y mod grid_size)),Black_Blue_T))
        and (!place_meeting(((x-(x mod grid_size))-(i*grid_size))+17,(y-(y mod grid_size)),Black_Blue_T))
        and (!place_meeting((x-(x mod grid_size))-(i*grid_size),((y-(y mod grid_size)))+17,Black_Blue_T))
        and (!place_meeting(((x-(x mod grid_size))-(i*grid_size))+17,((y-(y mod grid_size)))+17,Black_Blue_T))
        {
            if (place_meeting((x-(x mod grid_size))-(i*grid_size),(y-(y mod grid_size)),Concreet)) blocked_by_concreet = 1
        }
        else
        {
            stopped_exploding = 1
        }
    }
    if (t_up>0 and stopped_exploding==0)
    {
        if (!place_meeting((x-(x mod grid_size)),(y-(y mod grid_size))-(i*grid_size),Black_Blue_T)) 
        and (!place_meeting(((x-(x mod grid_size)))+17,((y-(y mod grid_size))-(i*grid_size)),Black_Blue_T)) 
        and (!place_meeting(((x-(x mod grid_size))),((y-(y mod grid_size))-(i*grid_size))+17,Black_Blue_T)) 
        and (!place_meeting(((x-(x mod grid_size)))+17,((y-(y mod grid_size))-(i*grid_size))+17,Black_Blue_T)) 
        {
            if (place_meeting((x-(x mod grid_size)),(y-(y mod grid_size))-(i*grid_size),Concreet)) blocked_by_concreet = 1
        }
        else
        {
            stopped_exploding = 1
        }
    }
    if (t_right>0 and stopped_exploding==0)
    {
        if (!place_meeting((x-(x mod grid_size))+(i*grid_size),(y-(y mod grid_size)),Black_Blue_T))
        and (!place_meeting((x-(x mod grid_size))+(i*grid_size)+17,(y-(y mod grid_size)),Black_Blue_T))
        and (!place_meeting((x-(x mod grid_size))+(i*grid_size),(y-(y mod grid_size))+17,Black_Blue_T))
        and (!place_meeting((x-(x mod grid_size))+(i*grid_size)+17,(y-(y mod grid_size))+17,Black_Blue_T))
        {
            if (place_meeting((x-(x mod grid_size))+(i*grid_size),(y-(y mod grid_size)),Concreet)) blocked_by_concreet = 1
        }
        else
        {
            stopped_exploding = 1
        }
    }
    if (t_down>0 and stopped_exploding==0)
    {
        if (!place_meeting((x-(x mod grid_size)),(y-(y mod grid_size))+(i*grid_size),Black_Blue_T)) 
        and (!place_meeting((x-(x mod grid_size))+17,(y-(y mod grid_size))+(i*grid_size),Black_Blue_T)) 
        and (!place_meeting((x-(x mod grid_size)),(y-(y mod grid_size))+(i*grid_size)+17,Black_Blue_T)) 
        and (!place_meeting((x-(x mod grid_size))+17,(y-(y mod grid_size))+(i*grid_size)+17,Black_Blue_T)) 
        {
            if (place_meeting((x-(x mod grid_size)),(y-(y mod grid_size))+(i*grid_size),Concreet)) blocked_by_concreet = 1
        }
        else
        {
            stopped_exploding = 1
        }
    }
}
if (blocked_by_concreet>0)
{
    global.t_detonating = 0
    with(Message_Object) instance_destroy()
    show_message(global.text_message_t_concreet)
    exit
}


// Makes the explosion happen and stop when it gets to the blue T
var stopped_exploding;
stopped_exploding = 0
for (i = 1; i < 37; i += 1)
{
    if (t_left>0 and stopped_exploding==0)
    {
        if (!place_meeting((x-(x mod grid_size))-(i*grid_size),(y-(y mod grid_size)),Black_Blue_T))
        and (!place_meeting(((x-(x mod grid_size))-(i*grid_size))+17,(y-(y mod grid_size)),Black_Blue_T))
        and (!place_meeting((x-(x mod grid_size))-(i*grid_size),((y-(y mod grid_size)))+17,Black_Blue_T))
        and (!place_meeting(((x-(x mod grid_size))-(i*grid_size))+17,((y-(y mod grid_size)))+17,Black_Blue_T))
        {
            instance_create((x-(x mod grid_size))-(i*grid_size),(y-(y mod grid_size)),Explosion)
            instance_create((x-(x mod grid_size))-(i*grid_size),(y-(y mod grid_size)),Explosion_T_Horizontal_Object)
        }
        else
        {
            stopped_exploding = 1
        }
    }
    if (t_up>0 and stopped_exploding==0)
    {
        if (!place_meeting((x-(x mod grid_size)),(y-(y mod grid_size))-(i*grid_size),Black_Blue_T)) 
        and (!place_meeting(((x-(x mod grid_size)))+17,((y-(y mod grid_size))-(i*grid_size)),Black_Blue_T)) 
        and (!place_meeting(((x-(x mod grid_size))),((y-(y mod grid_size))-(i*grid_size))+17,Black_Blue_T)) 
        and (!place_meeting(((x-(x mod grid_size)))+17,((y-(y mod grid_size))-(i*grid_size))+17,Black_Blue_T))
        {
            instance_create((x-(x mod grid_size)),(y-(y mod grid_size))-(i*grid_size),Explosion)
            instance_create((x-(x mod grid_size)),(y-(y mod grid_size))-(i*grid_size),Explosion_T_Vertical_Object)
        }
        else
        {
            stopped_exploding = 1
        }
    }
    if (t_right>0 and stopped_exploding==0)
    {
        if (!place_meeting((x-(x mod grid_size))+(i*grid_size),(y-(y mod grid_size)),Black_Blue_T))
        and (!place_meeting((x-(x mod grid_size))+(i*grid_size)+17,(y-(y mod grid_size)),Black_Blue_T))
        and (!place_meeting((x-(x mod grid_size))+(i*grid_size),(y-(y mod grid_size))+17,Black_Blue_T))
        and (!place_meeting((x-(x mod grid_size))+(i*grid_size)+17,(y-(y mod grid_size))+17,Black_Blue_T))
        {
            instance_create((x-(x mod grid_size))+(i*grid_size),(y-(y mod grid_size)),Explosion)
            instance_create((x-(x mod grid_size))+(i*grid_size),(y-(y mod grid_size)),Explosion_T_Horizontal_Object)
        }
        else
        {
            stopped_exploding = 1
        }
    }
    if (t_down>0 and stopped_exploding==0)
    {
        if (!place_meeting((x-(x mod grid_size)),(y-(y mod grid_size))+(i*grid_size),Black_Blue_T)) 
        and (!place_meeting((x-(x mod grid_size))+17,(y-(y mod grid_size))+(i*grid_size),Black_Blue_T)) 
        and (!place_meeting((x-(x mod grid_size)),(y-(y mod grid_size))+(i*grid_size)+17,Black_Blue_T)) 
        and (!place_meeting((x-(x mod grid_size))+17,(y-(y mod grid_size))+(i*grid_size)+17,Black_Blue_T))
        {
            instance_create((x-(x mod grid_size)),(y-(y mod grid_size))+(i*grid_size),Explosion)
            instance_create((x-(x mod grid_size)),(y-(y mod grid_size))+(i*grid_size),Explosion_T_Vertical_Object)
        }
        else
        {
            stopped_exploding = 1
        }
    }
}

global.t_detonating = 0
with(Message_Object) instance_destroy()
score -= 2
#define T_Detonate_Red
// T_Detonate_Red
// Stefan Grace
// Created: 2017-12-22
// Modified: 2020-02-22
// This script makes the T detonate after the other T has been clicked

if (instance_number(Level_Cover)+global.Red_B_Killing_Left+global.Red_B_Killing_Up+global.Red_B_Killing_Right+global.Red_B_Killing_Down > 0) exit

if (global.t_detonating==0)
{
    script_execute(Character_Click_Red)
    if (global.at_swapping==0 and !global.w_casting) instance_change(Red_Blue_T,false)
    exit
}

// Detects which direction the blue T is in
var t_left;
var t_up;
var t_right;
var t_down;
t_left = 0
t_up = 0
t_right = 0
t_down = 0
for (i = 2; i < 37; i += 1)
{
    // left
    if (place_meeting((x-(x mod grid_size))-(i*grid_size),(y-(y mod grid_size)),Red_Blue_T)) t_left += 1
    if (place_meeting(((x-(x mod grid_size))-(i*grid_size))+17,(y-(y mod grid_size)),Red_Blue_T)) t_left += 1
    if (place_meeting((x-(x mod grid_size))-(i*grid_size),(y-(y mod grid_size))+17,Red_Blue_T)) t_left += 1
    if (place_meeting(((x-(x mod grid_size))-(i*grid_size))+17,(y-(y mod grid_size))+17,Red_Blue_T)) t_left += 1
    // up
    if (place_meeting((x-(x mod grid_size)),(y-(y mod grid_size))-(i*grid_size),Red_Blue_T)) t_up += 1
    if (place_meeting((x-(x mod grid_size))+17,(y-(y mod grid_size))-(i*grid_size),Red_Blue_T)) t_up += 1
    if (place_meeting((x-(x mod grid_size)),((y-(y mod grid_size))-(i*grid_size))+17,Red_Blue_T)) t_up += 1
    if (place_meeting((x-(x mod grid_size))+17,((y-(y mod grid_size))-(i*grid_size))+17,Red_Blue_T)) t_up += 1
    // right
    if (place_meeting((x-(x mod grid_size))+(i*grid_size),(y-(y mod grid_size)),Red_Blue_T)) t_right += 1
    if (place_meeting(((x-(x mod grid_size))+(i*grid_size))+17,(y-(y mod grid_size)),Red_Blue_T)) t_right += 1
    if (place_meeting((x-(x mod grid_size))+(i*grid_size),(y-(y mod grid_size))+17,Red_Blue_T)) t_right += 1
    if (place_meeting(((x-(x mod grid_size))+(i*grid_size))+17,(y-(y mod grid_size))+17,Red_Blue_T)) t_right += 1
    // down
    if (place_meeting((x-(x mod grid_size)),(y-(y mod grid_size))+(i*grid_size),Red_Blue_T)) t_down += 1
    if (place_meeting((x-(x mod grid_size))+17,(y-(y mod grid_size))+(i*grid_size),Red_Blue_T)) t_down += 1
    if (place_meeting((x-(x mod grid_size)),((y-(y mod grid_size))+(i*grid_size))+17,Red_Blue_T)) t_down += 1
    if (place_meeting((x-(x mod grid_size))+17,((y-(y mod grid_size))+(i*grid_size))+17,Red_Blue_T)) t_down += 1
}

// Makes T explosions get blocked by concreet
var stopped_exploding;
var blocked_by_concreet;
stopped_exploding = 0
blocked_by_concreet = 0
for (i = 1; i < 37; i += 1)
{
    if (t_left>0 and stopped_exploding==0)
    {
        if (!place_meeting((x-(x mod grid_size))-(i*grid_size),(y-(y mod grid_size)),Red_Blue_T))
        and (!place_meeting(((x-(x mod grid_size))-(i*grid_size))+17,(y-(y mod grid_size)),Red_Blue_T))
        and (!place_meeting((x-(x mod grid_size))-(i*grid_size),((y-(y mod grid_size)))+17,Red_Blue_T))
        and (!place_meeting(((x-(x mod grid_size))-(i*grid_size))+17,((y-(y mod grid_size)))+17,Red_Blue_T))
        {
            if (place_meeting((x-(x mod grid_size))-(i*grid_size),(y-(y mod grid_size)),Concreet)) blocked_by_concreet = 1
        }
        else
        {
            stopped_exploding = 1
        }
    }
    if (t_up>0 and stopped_exploding==0)
    {
        if (!place_meeting((x-(x mod grid_size)),(y-(y mod grid_size))-(i*grid_size),Red_Blue_T)) 
        and (!place_meeting(((x-(x mod grid_size)))+17,((y-(y mod grid_size))-(i*grid_size)),Red_Blue_T)) 
        and (!place_meeting(((x-(x mod grid_size))),((y-(y mod grid_size))-(i*grid_size))+17,Red_Blue_T)) 
        and (!place_meeting(((x-(x mod grid_size)))+17,((y-(y mod grid_size))-(i*grid_size))+17,Red_Blue_T)) 
        {
            if (place_meeting((x-(x mod grid_size)),(y-(y mod grid_size))-(i*grid_size),Concreet)) blocked_by_concreet = 1
        }
        else
        {
            stopped_exploding = 1
        }
    }
    if (t_right>0 and stopped_exploding==0)
    {
        if (!place_meeting((x-(x mod grid_size))+(i*grid_size),(y-(y mod grid_size)),Red_Blue_T))
        and (!place_meeting((x-(x mod grid_size))+(i*grid_size)+17,(y-(y mod grid_size)),Red_Blue_T))
        and (!place_meeting((x-(x mod grid_size))+(i*grid_size),(y-(y mod grid_size))+17,Red_Blue_T))
        and (!place_meeting((x-(x mod grid_size))+(i*grid_size)+17,(y-(y mod grid_size))+17,Red_Blue_T))
        {
            if (place_meeting((x-(x mod grid_size))+(i*grid_size),(y-(y mod grid_size)),Concreet)) blocked_by_concreet = 1
        }
        else
        {
            stopped_exploding = 1
        }
    }
    if (t_down>0 and stopped_exploding==0)
    {
        if (!place_meeting((x-(x mod grid_size)),(y-(y mod grid_size))+(i*grid_size),Red_Blue_T)) 
        and (!place_meeting((x-(x mod grid_size))+17,(y-(y mod grid_size))+(i*grid_size),Red_Blue_T)) 
        and (!place_meeting((x-(x mod grid_size)),(y-(y mod grid_size))+(i*grid_size)+17,Red_Blue_T)) 
        and (!place_meeting((x-(x mod grid_size))+17,(y-(y mod grid_size))+(i*grid_size)+17,Red_Blue_T)) 
        {
            if (place_meeting((x-(x mod grid_size)),(y-(y mod grid_size))+(i*grid_size),Concreet)) blocked_by_concreet = 1
        }
        else
        {
            stopped_exploding = 1
        }
    }
}
if (blocked_by_concreet>0)
{
    global.t_detonating = 0
    with(Message_Object) instance_destroy()
    show_message(global.text_message_t_concreet)
    exit
}


// Makes the explosion happen and stop when it gets to the blue T
var stopped_exploding;
stopped_exploding = 0
for (i = 1; i < 37; i += 1)
{
    if (t_left>0 and stopped_exploding==0)
    {
        if (!place_meeting((x-(x mod grid_size))-(i*grid_size),(y-(y mod grid_size)),Red_Blue_T))
        and (!place_meeting(((x-(x mod grid_size))-(i*grid_size))+17,(y-(y mod grid_size)),Red_Blue_T))
        and (!place_meeting((x-(x mod grid_size))-(i*grid_size),((y-(y mod grid_size)))+17,Red_Blue_T))
        and (!place_meeting(((x-(x mod grid_size))-(i*grid_size))+17,((y-(y mod grid_size)))+17,Red_Blue_T))
        {
            instance_create((x-(x mod grid_size))-(i*grid_size),(y-(y mod grid_size)),Explosion)
            instance_create((x-(x mod grid_size))-(i*grid_size),(y-(y mod grid_size)),Explosion_T_Horizontal_Object)
        }
        else
        {
            stopped_exploding = 1
        }
    }
    if (t_up>0 and stopped_exploding==0)
    {
        if (!place_meeting((x-(x mod grid_size)),(y-(y mod grid_size))-(i*grid_size),Red_Blue_T)) 
        and (!place_meeting(((x-(x mod grid_size)))+17,((y-(y mod grid_size))-(i*grid_size)),Red_Blue_T)) 
        and (!place_meeting(((x-(x mod grid_size))),((y-(y mod grid_size))-(i*grid_size))+17,Red_Blue_T)) 
        and (!place_meeting(((x-(x mod grid_size)))+17,((y-(y mod grid_size))-(i*grid_size))+17,Red_Blue_T))
        {
            instance_create((x-(x mod grid_size)),(y-(y mod grid_size))-(i*grid_size),Explosion)
            instance_create((x-(x mod grid_size)),(y-(y mod grid_size))-(i*grid_size),Explosion_T_Vertical_Object)
        }
        else
        {
            stopped_exploding = 1
        }
    }
    if (t_right>0 and stopped_exploding==0)
    {
        if (!place_meeting((x-(x mod grid_size))+(i*grid_size),(y-(y mod grid_size)),Red_Blue_T))
        and (!place_meeting((x-(x mod grid_size))+(i*grid_size)+17,(y-(y mod grid_size)),Red_Blue_T))
        and (!place_meeting((x-(x mod grid_size))+(i*grid_size),(y-(y mod grid_size))+17,Red_Blue_T))
        and (!place_meeting((x-(x mod grid_size))+(i*grid_size)+17,(y-(y mod grid_size))+17,Red_Blue_T))
        {
            instance_create((x-(x mod grid_size))+(i*grid_size),(y-(y mod grid_size)),Explosion)
            instance_create((x-(x mod grid_size))+(i*grid_size),(y-(y mod grid_size)),Explosion_T_Horizontal_Object)
        }
        else
        {
            stopped_exploding = 1
        }
    }
    if (t_down>0 and stopped_exploding==0)
    {
        if (!place_meeting((x-(x mod grid_size)),(y-(y mod grid_size))+(i*grid_size),Red_Blue_T)) 
        and (!place_meeting((x-(x mod grid_size))+17,(y-(y mod grid_size))+(i*grid_size),Red_Blue_T)) 
        and (!place_meeting((x-(x mod grid_size)),(y-(y mod grid_size))+(i*grid_size)+17,Red_Blue_T)) 
        and (!place_meeting((x-(x mod grid_size))+17,(y-(y mod grid_size))+(i*grid_size)+17,Red_Blue_T))
        {
            instance_create((x-(x mod grid_size)),(y-(y mod grid_size))+(i*grid_size),Explosion)
            instance_create((x-(x mod grid_size)),(y-(y mod grid_size))+(i*grid_size),Explosion_T_Vertical_Object)
        }
        else
        {
            stopped_exploding = 1
        }
    }
}

global.t_detonating = 0
with(Message_Object) instance_destroy()
score -= 2
#define T_Set
// T_Set
// Stefan Grace
// Created: 2017-12-22
// Modified: 2017-12-22
// This script sets the T up ready to be detonated when CTRL key is pressed


if (score<2) exit

var t_line;
t_line = 0
var i;
if (player==1)
{
    for (i = -36; i < 37; i += 1)
    {
        // x
        if (place_meeting((x-(x mod grid_size))+(i*grid_size),(y-(y mod grid_size)),Red_T)) t_line += 1
        if (place_meeting((x-(x mod grid_size))+(i*grid_size)+17,(y-(y mod grid_size)),Red_T)) t_line += 1
        if (place_meeting((x-(x mod grid_size))+(i*grid_size),(y-(y mod grid_size))+17,Red_T)) t_line += 1
        if (place_meeting((x-(x mod grid_size))+(i*grid_size)+17,(y-(y mod grid_size))+17,Red_T)) t_line += 1
        // y
        if (place_meeting((x-(x mod grid_size)),(y-(y mod grid_size))+(i*grid_size),Red_T)) t_line += 1
        if (place_meeting((x-(x mod grid_size))+17,(y-(y mod grid_size))+(i*grid_size),Red_T)) t_line += 1
        if (place_meeting((x-(x mod grid_size)),(y-(y mod grid_size))+17+(i*grid_size),Red_T)) t_line += 1
        if (place_meeting((x-(x mod grid_size))+17,(y-(y mod grid_size))+17+(i*grid_size),Red_T)) t_line += 1
    }
}
if (player==2)
{
    for (i = -36; i < 37; i += 1)
    {
        // x
        if (place_meeting((x-(x mod grid_size))+(i*grid_size),(y-(y mod grid_size)),Black_T)) t_line += 1
        if (place_meeting((x-(x mod grid_size))+(i*grid_size)+17,(y-(y mod grid_size)),Black_T)) t_line += 1
        if (place_meeting((x-(x mod grid_size))+(i*grid_size),(y-(y mod grid_size))+17,Black_T)) t_line += 1
        if (place_meeting((x-(x mod grid_size))+(i*grid_size)+17,(y-(y mod grid_size))+17,Black_T)) t_line += 1
        // y
        if (place_meeting((x-(x mod grid_size)),(y-(y mod grid_size))+(i*grid_size),Black_T)) t_line += 1
        if (place_meeting((x-(x mod grid_size))+17,(y-(y mod grid_size))+(i*grid_size),Black_T)) t_line += 1
        if (place_meeting((x-(x mod grid_size)),(y-(y mod grid_size))+17+(i*grid_size),Black_T)) t_line += 1
        if (place_meeting((x-(x mod grid_size))+17,(y-(y mod grid_size))+17+(i*grid_size),Black_T)) t_line += 1
    }
}

if (t_line==0)
{
    show_message(global.text_message_t_noline)
    exit
}

global.t_detonating = 1
global.message_type = 22
script_execute(Local_Message_Create)
#define W_Heal_Cure_Stun
// W_Heal_Cure_Stun
// Stefan Grace
// Created: 2018-11-01
// Modified: 2018-11-04

with(Move_Message) instance_destroy()
global.w_casting = true
global.message_type = 23
script_execute(Local_Message_Create)

#define W_Range_Detect
// W_Range_Detect
// Stefan Grace
// Created: 2018-11-01
// Modified: 2018-11-04
// This script returns weather there is a blue W within range

return Character_Range_Detect(0)
#define Z_Stun
// Z_Stun
// Stefan Grace
// Created: 2017-12-13
// Modified: 2017-12-13

/* arguments
    argument0 - Player to be stuned
    1 - Player 1
    2 - Player 2
*/


if (S_Stuned>0) exit

with(all)
{
    if (player==argument0 and character_id!=17) S_Stuned = 1
}

score -= 1

instance_destroy()
#define Connect_4_Script
// Connect_4_Script
// Stefan Grace
// Created: 2016-07-31
// Modified: 2016-08-01
// This script controls the Connect 4 room

// This block of code changes the go number into the player's turn
if (instance_number(Go_Number_Red)>0) with(Go_Number_Red) instance_change(Connect_4_P1_Turn,false)
if (instance_number(Go_Number_Black)>0) with(Go_Number_Black) instance_change(Connect_4_P2_Turn,false)

// This block of code gets rid of the Draw Mode button
if (instance_number(Draw_Mode_Red)>0) with(Draw_Mode_Red) instance_destroy()
if (instance_number(Draw_Mode_Black)>0) with(Draw_Mode_Black) instance_destroy()

// This block of code resets the level if it fills up before the level has been won
if (instance_number(Connect_4_O)+instance_number(Connect_4_X)+instance_number(Connect_4_O_Yellow)+instance_number(Connect_4_X_Yellow)+instance_number(Rock)+instance_number(Dimond))>719
{
    with(Connect_4_X) instance_destroy()
    with(Connect_4_O) instance_destroy()
    with(Connect_4_X_Yellow) instance_destroy()
    with(Connect_4_O_Yellow) instance_destroy()
    with(Red_Vertical_Line) instance_destroy()
    with(Red_Horizontal_Line) instance_destroy()
    with(Red_Diagonal_Line_TL_BR) instance_destroy()
    with(Red_Diagonal_Line_TR_BL) instance_destroy()
    with(Black_Vertical_Line) instance_destroy()
    with(Black_Horizontal_Line) instance_destroy()
    with(Black_Diagonal_Line_TL_BR) instance_destroy()
    with(Black_Diagonal_Line_TR_BL) instance_destroy()
}

// This block of code makes the player who reaches 5 points first win
if (global.Player_One_Lines>4) and (instance_number(Player_One_Winz)==0) instance_create(0,0,Player_One_Winz)
if (global.Player_Two_Lines>4) and (instance_number(Player_Two_Winz)==0) instance_create(0,0,Player_Two_Winz)

#define Connect_4_Fall
// Connect_4_Fall
// Stefan Grace
// Created: 2016-07-31
// Modified: 2016-08-01
// This script makes the 'X's and 'O's and fall on Connect 4

if !(place_meeting(x,y+35,Connect_4_X)) and !(place_meeting(x,y+35,Connect_4_O)) and !(place_meeting(x,y+35,Connect_4_X_Yellow)) and !(place_meeting(x,y+35,Connect_4_O_Yellow)) and ((place_meeting(x,y+35,Yellow))) y = y+35
#define Line_Get
// Line_Get
// Stefan Grace
// Created: 2016-07-31
// Modified: 2017-07-23
// This script is executed when a player gets 4 in a line on connect 4

/*
argument0
    0 = Player 1
    1 = Player 2
*/


if (argument0==0) global.Player_One_Lines = global.Player_One_Lines+1
if (argument0==1) global.Player_Two_Lines = global.Player_Two_Lines+1
with(Connect_4_X) instance_change(Connect_4_X_Yellow,false)
with(Connect_4_O) instance_change(Connect_4_O_Yellow,false)
if global.level16message2hasshown == 0
{
    global.level16message2hasshown = 1
    global.level16messagenumber = 2
    global.message_type = 40
    instance_create(105,210,Message_Object)
}

#define Draw_Mode_Check
// Draw_Mode_Check
// Stefan Grace
// Created: 2016-08-02
// Modified: 2017-07-18
// This script resest the bases if draw mode is activated by both players

if (global.D_M_Red_on>0) and (global.D_M_Black_on>0) 
{
    if (global.D_M_Count<3)
    {
        global.D_M_Red_on = 0
        global.D_M_Black_on = 0
        global.D_M_Count += 1
        script_execute(Base_Clear)
        script_execute(Base_Create)
        if (instance_number(Go_Number_Red)>0) script_execute(Red_Unstun)
        if (instance_number(Go_Number_Black)>0) script_execute(Black_Unstun)
    }
    else
    {
        global.D_M_Count = 0
        room_restart()
    }
}

#define Base_Clear
// Base_Clear
// Stefan Grace
// Created: 2016-08-02
// Modified: 2017-07-18
// This script clears the bases

// Level 0
if (global.levelnumber==0)
{
    with(all)
    {
        if (x>769) and (x<805) and (y>664) and (y<700) instance_destroy() 
        if (x>524) and (x<560) and (y>069) and (y<105) instance_destroy()
    }
    instance_create(770,665,Yellow)
    instance_create(525,070,Yellow)
}

// Level 1
if (global.levelnumber==1)
{
    with(all)
    {
        if (x>769) and (x<840) and (y>664) and (y<700) instance_destroy()
        if (x>384) and (x<455) and (y>139) and (y<175) instance_destroy()
    }
    instance_create(770,665,Yellow)
    instance_create(805,665,Yellow)
    instance_create(385,140,Yellow)
    instance_create(420,140,Yellow)
}

// Level 2
if (global.levelnumber==2)
{
    with(all)
    {
        if (x>944) and (x<980) and (y>629) and (y<700) instance_destroy()
        if (x>314) and (x<350) and (y>069) and (y<140) instance_destroy()
    }
    instance_create(945,630,Yellow)
    instance_create(945,665,Yellow)
    instance_create(315,070,Yellow)
    instance_create(315,105,Yellow)
}

// Level 3
if (global.levelnumber==3)
{
    with(all)
    {
        if (x>909) and (x<980) and (y>654) and (y<690) instance_destroy()
        if (x>909) and (x<980) and (y>069) and (y<105) instance_destroy()
    }
    instance_create(910,665,Yellow)
    instance_create(945,665,Yellow)
    instance_create(910,70,Yellow)
    instance_create(345,70,Yellow)
}

// Level 4
if (global.levelnumber==4)
{
    with(all)
    {
        if (x>1224) and (x<1295) and (y>664) and (y<735) instance_destroy()
        if (x>34) and (x<105) and (y>665) and (y<735) instance_destroy()
    }
    instance_create(1225,665,Yellow)
    instance_create(1260,665,Yellow)
    instance_create(1225,700,Yellow)
    instance_create(1260,700,Yellow)
    instance_create(35,665,Yellow)
    instance_create(70,665,Yellow)
    instance_create(35,700,Yellow)
    instance_create(70,700,Yellow)
}

// Level 5
if (global.levelnumber==5)
{
    with(all)
    {
        if (x>909) and (x<980) and (y>069) and (y<140) instance_destroy()
        if (x>349) and (x<420) and (y>629) and (y<700) instance_destroy()
    }
    instance_create(910,70,Yellow)
    instance_create(945,70,Yellow)
    instance_create(910,105,Yellow)
    instance_create(945,105,Yellow)
    instance_create(350,630,Yellow)
    instance_create(385,630,Yellow)
    instance_create(350,665,Yellow)
    instance_create(350,665,Yellow)
}

// Level 6
if (global.levelnumber==6)
{
    with(all)
    {
        if (x>349) and (x<420) and (y>664) and (y<700) instance_destroy()
        if (x>384) and (x<420) and (y>699) and (y<735) instance_destroy()
        if (x>874) and (x<910) and (y>034) and (y<105) instance_destroy()
        if (x>909) and (x<945) and (y>069) and (y<105) instance_destroy()
    }
    instance_create(350,665,Yellow)
    instance_create(385,665,Yellow)
    instance_create(385,700,Yellow)
    instance_create(875,35,Yellow)
    instance_create(875,70,Yellow)
    instance_create(910,70,Yellow)
}
        
// Level 7
if (global.levelnumber==7)
{
    with(all)
    {
        if (x>34) and (x<105) and (y>314) and (y<420) instance_destroy()
        if (x>1224) and (x<1295) and (y>314) and (y<420) instance_destroy()
    }
    instance_create(35,315,Yellow)
    instance_create(70,315,Yellow)
    instance_create(35,350,Yellow)
    instance_create(70,350,Yellow)
    instance_create(35,385,Yellow)
    instance_create(70,385,Yellow)
    instance_create(1225,315,Yellow)
    instance_create(1260,315,Yellow)
    instance_create(1225,350,Yellow)
    instance_create(1260,350,Yellow)
    instance_create(1225,385,Yellow)
    instance_create(1260,385,Yellow)
}

// Level 8
if (global.levelnumber==8)
{
    with(all)
    {
        if (x>1224) and (x<1295) and (y>594) and (y<700) instance_destroy()
        if (x>34) and (x<105) and (y>594) and (y<700) instance_destroy()
    }
    instance_create(1225,595,Yellow)
    instance_create(1260,595,Yellow)
    instance_create(1225,630,Yellow)
    instance_create(1260,630,Yellow)
    instance_create(1225,665,Yellow)
    instance_create(1260,665,Yellow)
    instance_create(35,595,Yellow)
    instance_create(70,595,Yellow)
    instance_create(35,630,Yellow)
    instance_create(70,630,Yellow)
    instance_create(35,665,Yellow)
    instance_create(70,665,Yellow)
}

// Level 9
if (global.levelnumber==9)
{
    with(all)
    {
        if (x>1119) and (x<1190) and (y>629) and (y<735) instance_destroy()
        if (x>1084) and (x<1120) and (y>699) and (y<735) instance_destroy()
        if (x>34) and (x<105) and (y>629) and (y<735) instance_destroy()
        if (x>104) and (x<140) and (y>699) and (y<735) instance_destroy()
    }
    instance_create(1120,630,Yellow)
    instance_create(1155,630,Yellow)
    instance_create(1120,665,Yellow)
    instance_create(1155,665,Yellow)
    instance_create(1120,700,Yellow)
    instance_create(1155,700,Yellow)
    instance_create(1085,700,Yellow)
    instance_create(35,630,Yellow)
    instance_create(70,630,Yellow)
    instance_create(35,665,Yellow)
    instance_create(70,665,Yellow)
    instance_create(35,700,Yellow)
    instance_create(70,700,Yellow)
    instance_create(105,700,Yellow)
}

// Level 10
if (global.levelnumber==10)
{
    with(all)
    {
        if (x>34) and (x<70) and (y>629) and (y<735) instance_destroy()
        if (x>104) and (x<140) and (y>664) and (y<735) instance_destroy()
        if (x>174) and (x<210) and (y>699) and (y<735) instance_destroy()
        if (x>244) and (x<280) and (y>699) and (y<735) instance_destroy()
        if (x>1259) and (x<1295) and (y>629) and (y<735) instance_destroy()
        if (x>1189) and (x<1225) and (y>664) and (y<735) instance_destroy()
        if (x>1119) and (x<1155) and (y>699) and (y<735) instance_destroy()
        if (x>1049) and (x<1085) and (y>699) and (y<735) instance_destroy()
    }
    instance_create(1260,630,Yellow)
    instance_create(1260,665,Yellow)
    instance_create(1260,700,Yellow)
    instance_create(1190,665,Yellow)
    instance_create(1190,700,Yellow)
    instance_create(1120,700,Yellow)
    instance_create(1050,700,Yellow)
    instance_create(35,630,Yellow)
    instance_create(35,665,Yellow)
    instance_create(35,700,Yellow)
    instance_create(105,665,Yellow)
    instance_create(105,700,Yellow)
    instance_create(175,700,Yellow)
    instance_create(245,700,Yellow)
}

// Level 11
if (global.levelnumber==11)
{
    with(all)
    {
        if (x>34) and (x<105) and (y>629) and (y<735) instance_destroy()
        if (x>1224) and (x<1295) and (y>629) and (y<735) instance_destroy()
    }
    instance_create(35,630,Yellow)
    instance_create(70,630,Yellow)
    instance_create(35,665,Yellow)
    instance_create(70,665,Yellow)
    instance_create(35,700,Yellow)
    instance_create(70,700,Yellow)
    instance_create(1260,630,Yellow)
    instance_create(1225,630,Yellow)
    instance_create(1260,665,Yellow)
    instance_create(1225,665,Yellow)
    instance_create(1260,700,Yellow)
    instance_create(1225,700,Yellow)
}

// Level 12
if (global.levelnumber==12)
{
    with(all)
    {
        if (x>34) and (x<105) and (y>314) and (y<385) instance_destroy()
        if (x>34) and (x<70) and (y>384) and (y<419) instance_destroy()
        if (x>1224) and (x<1295) and (y>314) and (y<385) instance_destroy()
        if (x>1259) and (x<1295) and (y>384) and (y<419) instance_destroy()
    }
    instance_create(1260,315,Yellow)
    instance_create(1225,315,Yellow)
    instance_create(1260,350,Yellow)
    instance_create(1225,350,Yellow)
    instance_create(1260,385,Yellow)
    instance_create(35,315,Yellow)
    instance_create(70,315,Yellow)
    instance_create(35,350,Yellow)
    instance_create(70,350,Yellow)
    instance_create(35,385,Yellow)
}

// Level 13
if (global.levelnumber==13)
{
    with(all)
    {
        if (x>34) and (x<140) and (y>244) and (y<315) instance_destroy()
        if (x>34) and (x<70) and (y>314) and (y<350) instance_destroy()
        if (x>1189) and (x<1295) and (y>244) and (y<315) instance_destroy()
        if (x>1259) and (x<1295) and (y>314) and (y<350) instance_destroy()
    }
    instance_create(1260,245,Yellow)
    instance_create(1225,245,Yellow)
    instance_create(1190,245,Yellow)
    instance_create(1260,280,Yellow)
    instance_create(1225,280,Yellow)
    instance_create(1190,280,Yellow)
    instance_create(1260,315,Yellow)
    instance_create(35,245,Yellow)
    instance_create(70,245,Yellow)
    instance_create(105,245,Yellow)
    instance_create(35,280,Yellow)
    instance_create(70,280,Yellow)
    instance_create(105,280,Yellow)
    instance_create(35,315,Yellow)
}

// Level 14
if (global.levelnumber==14)
{
    with(all)
    {
        if (x>34) and (x<105) and (y>594) and (y<735) instance_destroy()
        if (x>1224) and (x<1295) and (y>594) and (y<735) instance_destroy()
    }
    instance_create(1260,595,Yellow)
    instance_create(1225,595,Yellow)
    instance_create(1260,630,Yellow)
    instance_create(1225,630,Yellow)
    instance_create(1260,665,Yellow)
    instance_create(1225,665,Yellow)
    instance_create(1260,700,Yellow)
    instance_create(1225,700,Yellow)
    instance_create(35,595,Yellow)
    instance_create(70,595,Yellow)
    instance_create(35,630,Yellow)
    instance_create(70,630,Yellow)
    instance_create(35,665,Yellow)
    instance_create(70,665,Yellow)
    instance_create(35,700,Yellow)
    instance_create(70,700,Yellow)
}

// Level 15
if (global.levelnumber==15)
{
    with(all)
    {
        if (x>34) and (x<140) and (y>629) and (y<700) instance_destroy()
        if (x>34) and (x<105) and (y>699) and (y<735) instance_destroy()
        if (x>1189) and (x<1295) and (y>629) and (y<700) instance_destroy()
        if (x>1224) and (x<1295) and (y>699) and (y<735) instance_destroy()
    }
    instance_create(35,630,Yellow)
    instance_create(70,630,Yellow)
    instance_create(105,630,Yellow)
    instance_create(35,665,Yellow)
    instance_create(70,665,Yellow)
    instance_create(105,665,Yellow)
    instance_create(35,700,Yellow)
    instance_create(70,700,Yellow)
    instance_create(1260,630,Yellow)
    instance_create(1225,630,Yellow)
    instance_create(1190,630,Yellow)
    instance_create(1260,665,Yellow)
    instance_create(1225,665,Yellow)
    instance_create(1190,665,Yellow)
    instance_create(1260,700,Yellow)
    instance_create(1225,700,Yellow)
}

// Level 17
if (global.levelnumber==17)
{
    with(all)
    {
        if (x>34) and (x<140) and (y>629) and (y<735) instance_destroy()
        if (x>1189) and (x<1295) and (y>629) and (y<735) instance_destroy()
    }
    instance_create(35,630,Yellow)
    instance_create(70,630,Yellow)
    instance_create(105,630,Yellow)
    instance_create(35,665,Yellow)
    instance_create(70,665,Yellow)
    instance_create(105,665,Yellow)
    instance_create(35,700,Yellow)
    instance_create(70,700,Yellow)
    instance_create(105,700,Yellow)
    instance_create(1260,630,Yellow)
    instance_create(1225,630,Yellow)
    instance_create(1190,630,Yellow)
    instance_create(1260,665,Yellow)
    instance_create(1225,665,Yellow)
    instance_create(1190,665,Yellow)
    instance_create(1260,700,Yellow)
    instance_create(1225,700,Yellow)
    instance_create(1190,700,Yellow)
}

// Level 18
if (global.levelnumber==18)
{
    with(all)
    {
        if ((x>=1*grid_size) and (x<2*grid_size)) or ((x>=36*grid_size) and (x<37*grid_size))
        {
            if ((y>=1*grid_size) and (y<2*grid_size)) or ((y>=3*grid_size) and (y<4*grid_size)) or ((y>=5*grid_size) and (y<6*grid_size)) or ((y>=7*grid_size) and (y<8*grid_size)) or ((y>=9*grid_size) and (y<11*grid_size)) instance_destroy()
            if ((y>=12*grid_size) and (y<13*grid_size)) or ((y>=14*grid_size) and (y<15*grid_size)) or ((y>=16*grid_size) and (y<17*grid_size)) or ((y>=18*grid_size) and (y<19*grid_size)) or ((y>=20*grid_size) and (y<21*grid_size)) instance_destroy()
        }
    }
    instance_create(1*grid_size,1*grid_size,Yellow)
    instance_create(3*grid_size,1*grid_size,Yellow)
    instance_create(5*grid_size,1*grid_size,Yellow)
    instance_create(7*grid_size,1*grid_size,Yellow)
    instance_create(9*grid_size,1*grid_size,Yellow)
    instance_create(10*grid_size,1*grid_size,Yellow)
    instance_create(12*grid_size,1*grid_size,Yellow)
    instance_create(14*grid_size,1*grid_size,Yellow)
    instance_create(16*grid_size,1*grid_size,Yellow)
    instance_create(18*grid_size,1*grid_size,Yellow)
    instance_create(20*grid_size,1*grid_size,Yellow)
    instance_create(1*grid_size,36*grid_size,Yellow)
    instance_create(3*grid_size,36*grid_size,Yellow)
    instance_create(5*grid_size,36*grid_size,Yellow)
    instance_create(7*grid_size,36*grid_size,Yellow)
    instance_create(9*grid_size,36*grid_size,Yellow)
    instance_create(10*grid_size,36*grid_size,Yellow)
    instance_create(12*grid_size,36*grid_size,Yellow)
    instance_create(14*grid_size,36*grid_size,Yellow)
    instance_create(16*grid_size,36*grid_size,Yellow)
    instance_create(18*grid_size,36*grid_size,Yellow)
    instance_create(20*grid_size,36*grid_size,Yellow)
}
#define English
// English
// Stefan Grace
// Created: 2016-07-14
// Modified: 2024-08-05
// This script sets the language to English


// General
global.text_current_language = "English"
global.text_name = "Name"
global.text_player = "Player"
global.text_wins = "Winz"
global.text_player_change = "Player Change"
global.text_level = "Level"
global.text_starts = "Starts"
global.text_random = "Random"
global.text_player_select = "Select Which Player Starts"
global.text_draw = "Draw"
global.text_draw_mode = "Draw Mode: "
global.text_on = "On"
global.text_off = "Off"
global.text_test_level = "Test Level"
global.text_connect_4 = "Connect 4"
global.text_turn = "Turn"
global.text_points = "Points"
global.text_help = "Help"
global.text_view = "View"
global.text_view_alumax = "View Alumax"
global.text_matches = "Matches"
global.text_cancel = "Cancel"
global.text_click = "Click"

// Button Names
global.text_main_menu = "Main Menu"
global.text_next = "Next"
global.text_no = "No"
global.text_play = "Play"
global.text_quit = "Quit"
global.text_yes = "Yes"
global.text_back = "Back"
global.text_continue = "Continue"
global.text_restart = "Restart"
global.text_alumax = "Alumax"
global.text_reset = "Reset"
global.text_settings = "Settings"
global.text_date_time = "Date & Time"
global.text_music = "Music"
global.text_ok = "OK"
global.text_language = "Language"
global.text_life_drain = "Life Drain"
global.text_life_give = "Life Give"
global.text_cheats = "Cheats"
global.text_backgrounds = "Backgrounds"
global.text_tablet_mode = "Tablet Mode"
global.text_space = "Space"
global.text_backspace = "Backspace"
global.text_menu = "Menu"
global.text_transform = "Transform"
global.text_port = "Port"
global.text_detonate = "Detonate"
global.text_cast = "Cast"
global.text_swap = "Swap"
global.text_spawn = "Spawn"
global.text_fullscreen = "Fullscreen"
global.text_shoot = "Shoot" 
global.text_catapult = "Catapult"
global.text_long = "Long"
global.text_level_designer = "Level Designer"

// Date & Time Buttons
global.text_year = "Year"
global.text_month = "Month"
global.text_day = "Day"
global.text_date = "Date"
global.text_time = "Time"
global.text_twelve_hour = "12 Hour"
global.text_twentyfour_hour = "24 Hour"
global.text_number = "Number"
global.text_word = "Word"
global.text_digit = "Digit"

// Date & Time Room
global.text_date_order = "Date Order"
global.text_year_format = "Year Format"
global.text_date_time_order = "Date Time Order"
global.text_time_format = "Time Format"
global.text_month_format = "Month Format"

// Months
global.Months[1] = "Jan"
global.Months[2] = "Feb"
global.Months[3] = "Mar"
global.Months[4] = "Apr"
global.Months[5] = "May"
global.Months[6] = "Jun"
global.Months[7] = "Jul"
global.Months[8] = "Aug"
global.Months[9] = "Sep"
global.Months[10] = "Oct"
global.Months[11] = "Nov"
global.Months[12] = "Dec"

// System Messages
global.text_alumax_message = "Welcome to the Alumax. The Alumax is a place where you can lookup Characters and Objects."
global.text_box_four_message = "Only 4 characters can occupy a tile at any one time"
global.text_player_name_change_a = "Please enter a name that is 1 to "
global.text_player_name_change_b = " characters in length."
global.text_reset_message_a = "Are you sure you want to reset?"
global.text_reset_message_b = "You will lose all progress on all levels!"
global.text_reset_message_c = "The game has been reset."
global.text_reset_message_d = "Click OK to continue"
global.text_b_help = "To choose which character you want to lose, just click on it"
global.text_box_full_db = "Only 1 character can fit in a quarter tile of double boxing at any one time."
global.text_s_stun = "A character cannot move while it is stunned."
global.text_r_stun = "An R cannot shoot when it is stunned."
global.text_load_game = "Do you want to continue where you left off?"
global.text_c_stun = "A C cannot catapult when it is stunned."
global.text_no_g_in_range = "No G in range."
global.text_at_not_swap_big_g = "@ cannot be swapped with Gigga G or Terror G."
global.text_v_diagonal = "V can only move diagonal to kill opponent's characters."
global.text_teleport_full = "Only 4 characters can fit in a teleport at any one time"

// Level Messages
global.text_message_level[0] = "White represents rock."
global.text_message_level[1] = "A kills X, but can be killed by Triangle."
global.text_message_level[2] = "Neutral characters can be captured by ether player."
global.text_message_level[4] = "This is a boulder, it will fall when pushed."
global.text_message_level[5] = "This anger will give you the power to kill anything for 5 moves."
global.text_message_level[6] = "Square can tunnel rock."
global.text_message_level[7] = "Diamond cannot be tunnelled by X or Square."
global.text_message_level[9] = "K can tunnel diamond."
global.text_message_level[10] = "This is a bomb. When it falls it blows a tunnel."
global.text_message_level[11] = "B can infiltrate boxes of 4."
global.text_message_level[12] = "Orange anger lets you tunnel rock."
global.text_message_level[13] = "E kills O and Square and can tunnel downwards through rock and diamond."
global.text_message_level[14] = "Barriers cannot be tunnelled through."
global.text_message_level[15] = "S stuns all characters except E and H."
global.text_message_level[17] = "Double Boxing turns to diamond when passed through"
global.text_message_level[18] = "H kills and tunnels horizontally."
global.text_message_level[19] = "Arrow tiles can be moved through in 1 direction only."
global.text_message_level[20] = "R fires arrows up to 5 tiles away."
global.text_message_level[21] = "M explodes to destroy 9 tiles."
global.text_message_level[22] = "Blue Anger enables characters to tunnel diamond."
global.text_message_level[23] = "F charms enemy characters."
global.text_message_level[25] = "G crushes tiles with his hammer."
global.text_message_level[26] = "Diamond Bomb blows a tunnel through rock and diamond."
global.text_message_level[27] = "C catapults boulders 5 tiles away."
global.text_message_level[28] = "Concreate cannot be tunnelled, exploded or catapulted over."

// Other Messages
global.text_choose_which_character_you_want_to_lose = "choose which character you want to lose." 
global.text_double_boxing_entry_horizontal = "To select which box you go into, use the Up and Down arrows."
global.text_double_boxing_entry_vertical = "To select which box you go into, use the Left and Right arrows."
global.text_message_neutral_characters_in_diamond = "When a neutral character is located in diamond, it appears yellow."
global.text_level_16_instruction[0] = "Click anywhere to drop a bolder."
global.text_level_16_instruction[1] = "Connect 4 boulders in a row to score."
global.text_level_16_instruction[2] = "First to five wins."
global.text_level_24_instruction[0] = "Click on a tile to reveal the symbol behind."
global.text_level_24_instruction[1] = "Match symbols to win."
global.text_message_at_swapping = "Click on the character that you want to swap places with."
global.text_message_t_noline = "T must be inline with another T to detonate."
global.text_message_t_detonate = "Click on the other T that you want to detonate."
global.text_message_t_concreet = "T explosions are blocked by concrete."
global.text_message_dollar_sign_stunning = "Click on the character that you want to cast on. Must be within 5 tiles."
global.text_level_0_intro[0] = "controls red characters"
global.text_level_0_intro[1] = "controls black characters"
global.text_level_0_intro[2] = "X kills Triangle and O and tunnels rock into yellow."
global.text_level_0_intro[3] = "Triangle kills O but can be killed by X and can only move though yellow."
global.text_level_0_intro[4] = "O gets killed by X and Triangle. You win when the opponent loses their O."
global.text_level_0_intro[5] = 'or Random to decide who starts.'
global.text_level_0_intro[6] = "click on a character to select it, when a character is selected it appears blue."
global.text_level_0_intro[7] = "To move a character, use the arrow keys."

#define French
// French
// Stefan Grace
// Created: 2016-07-15
// Modified: 2024-07-27
// This script sets the language to French

// General
global.text_current_language = "Francais"
global.text_name = "Prenom"
global.text_player = "Joueur"
global.text_wins = "Victoires"
global.text_player_change = "Joueur Change"
global.text_level = "Niveau"
global.text_starts = "Departs"
global.text_random = "Aleatoire"
global.text_player_select = "Sélectionnez Quel joueur commence"
global.text_draw = "Dessiner"
global.text_draw_mode = "Mode Dessin: "
global.text_on = "Sur"
global.text_off = "De"
global.text_test_level = "Niveau dessai"
global.text_turn = "Tour"
global.text_help = "Aidez-moi"
global.text_view = "Vue"
global.text_view_alumax = "Vue Alumax"
global.text_matches = "Egal"
global.text_cancel = "Annuler"
global.text_click = "Cliquez sur"

// Button Names
global.text_main_menu = "Menu principal"
global.text_next = "Prochain"
global.text_no = "Non"
global.text_play = "Jouer"
global.text_quit = "Quitter"
global.text_yes = "Oui"
global.text_back = "Back"
global.text_continue = "Arriere"
global.text_restart = "Redemarrer"
global.text_alumax = "Alumax"
global.text_reset = "Reinitialiser"
global.text_settings = "Parametres"
global.text_date_time = "Date et heure"
global.text_music = "la musique"
global.text_ok = "D'accord"
global.text_language = "La langue"
global.text_life_drain = "Drain de vie"
global.text_life_give = "La vie donne"
global.text_cheats = "Astuces"
global.text_backgrounds = "Contexte"
global.text_tablet_mode = "Mode tablette"
global.text_space = "Espace"
global.text_backspace = "Retour arrière"
global.text_menu = "Menu"
global.text_transform = "Transformer"
global.text_port = "Port"
global.text_detonate = "Exploser"
global.text_cast = "Casting"
global.text_swap = "Echanger"
global.text_spawn = "Frayer"
global.text_fullscreen = "Plein écran"


// Date & Time Buttons
global.text_year = "An"
global.text_month = "Mois"
global.text_day = "Journee"
global.text_date = "Date"
global.text_time = "Temps"
global.text_twelve_hour = "12 heures"
global.text_twentyfour_hour = "24 heures"
global.text_number = "Nombre"
global.text_word = "Mot"
global.text_digit = "Chiffre"

// Date & Time Room
global.text_date_order = "Date de Commande"
global.text_year_format = "Annee Format"
global.text_date_time_order = "Date Heure"
global.text_time_format = "Format de lheure"
global.text_month_format = "Mois Format"

// Months
global.Months[1] = "Jan"
global.Months[2] = "Fev"
global.Months[3] = "Mar"
global.Months[4] = "Avr"
global.Months[5] = "Mai"
global.Months[6] = "Jui"
global.Months[7] = "Jul"
global.Months[8] = "Aot"
global.Months[9] = "Sep"
global.Months[10] = "Oct"
global.Months[11] = "Nov"
global.Months[12] = "Déc"

// System Messages
global.text_alumax_message = "Bienvenue sur le Alumax. Le Alumax est un endroit ou vous pouvez rechercher les caracteres et les objets."
global.text_box_four_message = "Seuls 4 caracteres peuvent occuper une boîte a tout moment"
global.text_player_name_change_a = "Sil vous plait entrer un nom qui est de 1 a "
global.text_player_name_change_b = " caracteres."
global.text_reset_message_a = "Etes-vous sur de vouloir reinitialiser?"
global.text_reset_message_b = "Vous perdrez tous les progres a tous les niveaux!"
global.text_reset_message_c = "Le jeu a ete reinitialise."
global.text_reset_message_d = "Cliquez sur OK pour continuer"
global.text_b_help = "Pour choisir le personnage que vous voulez perdre, cliquez dessus"
global.text_box_full_db = "Un seul personnage peut tenir dans un quart de tuile de double boxe a la fois."
global.text_s_stun = "Un personnage ne peut pas bouger tant qu'il est etourdi."
global.text_r_stun = "Un R ne peut pas tirer lorsqu'il est etourdi."
global.text_load_game = "Voulez-vous charger votre jeu precedent?"
global.text_c_stun = "Un C ne peut pas catapulter lorsqu'il est etourdi."
global.text_no_g_in_range = "Pas de G a portee."
global.text_at_not_swap_big_g = "@ ne peut pas etre echange avec Gigga G ou Terror G"
global.text_v_diagonal = "V ne peut se déplacer qu'en diagonale pour tuer les personnages de l'adversaire."
global.text_teleport_full = "Seuls 4 personnages peuvent entrer dans une téléportation à la fois"

// Level Messages
global.text_message_level[0] = "Le blanc represente la roche."
global.text_message_level[1] = "A tue X, mais peut etre tue par Triangle."
global.text_message_level[2] = "Les personnages neutres peuvent etre captures par le joueur ether."
global.text_message_level[4] = "Ceci est un rocher, il tombera lorsqu'il sera pousse."
global.text_message_level[5] = "Cette colere vous donnera le pouvoir de tuer n'importe quoi pendant 5 mouvements."
global.text_message_level[6] = "Carre peut creuser un tunnel de roche."
global.text_message_level[7] = "Le diamant ne peut pas etre tunnelise par X ou Square."
global.text_message_level[9] = "K can tunnel diamond."
global.text_message_level[10] = "Ceci est une bombe. Quand il tombe, il souffle un tunnel."
global.text_message_level[11] = "B peut infiltrer des boîtes de 4."
global.text_message_level[12] = "La colere orange vous permet de creuser des tunnels de roche."
global.text_message_level[13] = "E tue O et Square et peut creuser un tunnel vers le bas a travers la roche et le diamant."
global.text_message_level[14] = "Les barrieres ne peuvent pas etre franchies."
global.text_message_level[15] = "S etourdit tous les personnages sauf E et H."
global.text_message_level[17] = "La double boxe se transforme en diamant lorsqu'elle passe"
global.text_message_level[18] = "H tue et tunnels horizontalement."
global.text_message_level[19] = "Les tuiles Fleche ne peuvent etre deplacees que dans une seule direction."
global.text_message_level[20] = "R tire des fleches jusqu'a 5 tuiles."
global.text_message_level[21] = "M explose pour detruire 9 tuiles."
global.text_message_level[22] = "Blue Anger permet aux personnages de percer le diamant."
global.text_message_level[23] = "F charme les personnages ennemis."
global.text_message_level[25] = "G ecrase les carreaux avec son marteau."
global.text_message_level[26] = "Diamond Bomb souffle un tunnel a travers la roche et le diamant."
global.text_message_level[27] = "C catapulte des rochers a 5 tuiles."
global.text_message_level[28] = "Le beton ne peut pas être tunnelise, explose ou catapulte."

// Other Messages
global.text_choose_which_character_you_want_to_lose = "choisissez le personnage que vous voulez perdre." 
global.text_double_boxing_entry_horizontal = "Pour selectionner la case dans laquelle vous allez, utilisez les fleches haut et bas."
global.text_double_boxing_entry_vertical = "Pour selectionner la case dans laquelle vous allez, utilisez les fleches gauche et droite."
global.text_message_neutral_characters_in_diamond = "Lorsqu'un caractere neutre se trouve dans le diamant, il apparait en jaune."
global.text_level_16_instruction[0] = "Cliquez n'importe ou pour deposer un texte plus audacieux."
global.text_level_16_instruction[1] = "Connectez 4 rochers d'affilee pour marquer."
global.text_level_16_instruction[2] = "Premier a cinq victoires."
global.text_level_24_instruction[0] = "Cliquez sur une tuile pour reveler le symbole derriere."
global.text_level_24_instruction[1] = "Faites correspondre les symboles pour gagner."
global.text_message_at_swapping = "Cliquez sur le personnage avec lequel vous souhaitez echanger des lieux."
global.text_message_t_noline = "T doit etre aligne avec un autre T pour exploser."
global.text_message_t_detonate = "Cliquez sur l'autre T que vous souhaitez faire exploser."
global.text_message_t_concreet = "Les explosions sont bloquees par du béton."
global.text_message_dollar_sign_stunning = "Cliquez sur le personnage que vous souhaitez lancer. Doit etre a moins de 5 tuiles."
global.text_level_0_intro[0] = "controle les caracteres rouges"
global.text_level_0_intro[1] = "controle les caracteres noirs"
global.text_level_0_intro[2] = "X tue Triangle et O et les tunnels basculent en jaune."
global.text_level_0_intro[3] = "Le triangle vous tue mais peut etre tue par X et ne peut se deplacer qu'en jaune."
global.text_level_0_intro[4] = "O se fait tuer par X et Triangle. Vous gagnez lorsque l'adversaire perd son O."
global.text_level_0_intro[5] = 'ou aleatoire pour decider qui commence.'
global.text_level_0_intro[6] = "cliquez sur un personnage pour le selectionner, quand un personnage est selectionne il apparait en bleu."
global.text_level_0_intro[7] = "Pour deplacer un personnage, utilisez les touches flechees."

#define Spanish
// Spanish
// Stefan Grace
// Created: 2016-07-29
// Modified: 2024-07-27
// This script sets the language to Spanish


// General
global.text_current_language = "Espanol"
global.text_name = "Nombre"
global.text_player = "Jugador"
global.text_wins = "Victorias"
global.text_player_change = "Cambio del jugador"
global.text_level = "Nivel"
global.text_starts = "Empieza"
global.text_random = "Aleatorio"
global.text_player_select = "Seleccionar que jugador comienza"
global.text_draw = "Dibujar"
global.text_draw_mode = "Modo Draw: "
global.text_on = "En"
global.text_off = "Apagado"
global.text_test_level = "prueba de nivel"
global.text_connect_4 = "Conectar 4"
global.text_turn = "Giro"
global.text_points = "Puntos"
global.text_help = "Ayuda"
global.text_view = "Ver"
global.text_view_alumax = "Ver Alumax"
global.text_matches = "Partidos"
global.text_cancel = "Cancelar"
global.text_click = "Hacer clic"

// Button Names
global.text_main_menu = "Menu principal"
global.text_next = "Siguiente"
global.text_no = "No"
global.text_play = "Jugar"
global.text_quit = "Dejar"
global.text_yes = "Si"
global.text_back = "Espalda"
global.text_continue = "Continuar"
global.text_restart = "Reiniciar"
global.text_alumax = "Alumax"
global.text_reset = "Reiniciar"
global.text_settings = "ajustes"
global.text_date_time = "Fecha y hora"
global.text_music = "Musica"
global.text_ok = "DE ACUERDO"
global.text_language = "Idioma"
global.text_life_drain = "Drenaje de la vida"
global.text_life_give = "Vida dar"
global.text_cheats = "Trucos"
global.text_backgrounds = "Antecedentes"
global.text_tablet_mode = "Modo tableta"
global.text_space = "Espacio"
global.text_backspace = "Retroceso"
global.text_menu = "Menu"
global.text_transform = "Transformar"
global.text_port = "Puerto"
global.text_detonate = "Detonar"
global.text_cast = "Elenco"
global.text_swap = "Intercambio"
global.text_spawn = "Aparecer"
global.text_fullscreen = "Pantalla completa"

// Date & Time Buttons
global.text_year = "Ano"
global.text_month = "Mes"
global.text_day = "Dia"
global.text_date = "Fecha"
global.text_time = "Hora"
global.text_twelve_hour = "12 horas"
global.text_twentyfour_hour = "24 horas"
global.text_number = "Numero"
global.text_word = "Palabra"
global.text_digit = "Digito"

// Date & Time Room
global.text_date_order = "fecha del pedido"
global.text_year_format = "Formato ano"
global.text_date_time_order = "Fecha Hora Orden"
global.text_time_format = "Formato de tiempo"
global.text_month_format = "Formato mes"

// Months
global.Months[1] = "Ene"
global.Months[2] = "Feb"
global.Months[3] = "Mar"
global.Months[4] = "Abr"
global.Months[5] = "May"
global.Months[6] = "Jun"
global.Months[7] = "Jul"
global.Months[8] = "Ago"
global.Months[9] = "Sep"
global.Months[10] = "Oct"
global.Months[11] = "Nov"
global.Months[12] = "Dic"

// System Messages
global.text_alumax_message = "Bienvenido a Alumax. Alumax es un lugar donde puedes buscar personajes y objetos."
global.text_box_four_message = "Solo 4 personajes pueden ocupar una casilla a la vez"
global.text_player_name_change_a = "Por favor, introduzca un nombre que tenga entre "
global.text_player_name_change_b = " caracteres de longitud."
global.text_reset_message_a = "Estas seguro de que quieres restablecer?"
global.text_reset_message_b = "Perderas todo el progreso en todos los niveles!"
global.text_reset_message_c = "El juego se ha reiniciado."
global.text_reset_message_d = "Haga clic en OK para continuar."
global.text_b_help = "Para elegir que personaje quieres perder, simplemente haz clic en el."
global.text_box_full_db = "Solo puede caber 1 personaje en un cuarto de casilla de doble casilla a la vez."
global.text_s_stun = "Un personaje no puede moverse mientras esta aturdido."
global.text_r_stun = "Un R no puede disparar cuando esta aturdido."
global.text_load_game = "Quieres cargar tu juego anterior?"
global.text_c_stun = "Un C no puede catapultarse cuando esta aturdido."
global.text_no_g_in_range = "No hay G en el rango."
global.text_at_not_swap_big_g = "@ no se puede intercambiar con Gigga G o Terror G"
global.text_v_diagonal = "V solo puede moverse en diagonal para matar a los personajes del oponente."
global.text_teleport_full = "Solo pueden caber 4 personajes en un teletransporte a la vez."

// Level Messages
global.text_message_level[0] = "El blanco representa la roca."
global.text_message_level[1] = "A mata a X, pero Triangle puede matarlo."
global.text_message_level[2] = "Los personajes neutrales pueden ser capturados por el jugador ether."
global.text_message_level[4] = "Esta es una roca, se caera cuando se empuja."
global.text_message_level[5] = "Esta ira te dará el poder de matar cualquier cosa por 5 movimientos."
global.text_message_level[6] = "Plaza puede túnel de roca."
global.text_message_level[7] = "El diamante no puede ser tunelizado por X o Square."
global.text_message_level[9] = "K puede hacer un túnel de diamante."
global.text_message_level[10] = "Esto es una bomba Cuando cae, sopla un túnel."
global.text_message_level[11] = "B puede infiltrarse en cajas de 4."
global.text_message_level[12] = "La ira naranja te permite hacer túneles de roca."
global.text_message_level[13] = "E mata a O y Square y puede hacer un túnel hacia abajo a través de rocas y diamantes."
global.text_message_level[14] = "Las barreras no pueden ser tunelizadas."
global.text_message_level[15] = "S aturde a todos los personajes excepto E y H."
global.text_message_level[17] = "El boxeo doble se convierte en diamante cuando se pasa"
global.text_message_level[18] = "H mata y hace túneles horizontalmente."
global.text_message_level[19] = "Las fichas de flecha se pueden mover solo en 1 dirección."
global.text_message_level[20] = "R dispara flechas de hasta 5 fichas de distancia."
global.text_message_level[21] = "M explota para destruir 9 fichas."
global.text_message_level[22] = "La ira azul permite a los personajes hacer un túnel con diamantes."
global.text_message_level[23] = "F encanta a los personajes enemigos."
global.text_message_level[25] = "G aplasta azulejos con su martillo."
global.text_message_level[26] = "Diamond Bomb sopla un túnel a través de rocas y diamantes."
global.text_message_level[27] = "C catapulta rocas a 5 fichas de distancia."
global.text_message_level[28] = "El concreto no puede ser tunelado, explotado o catapultado."

// Other Messages
global.text_choose_which_character_you_want_to_lose = "elige qué personaje quieres perder." 
global.text_double_boxing_entry_horizontal = "Para seleccionar en qué cuadro entrar, use las flechas hacia arriba y hacia abajo."
global.text_double_boxing_entry_vertical = "Para seleccionar en qué cuadro entrar, use las flechas izquierda y derecha."
global.text_message_neutral_characters_in_diamond = "Cuando un personaje neutral se encuentra en el diamante, aparece amarillo."
global.text_level_16_instruction[0] = "Haga clic en cualquier lugar para soltar un negrita."
global.text_level_16_instruction[1] = "Conecte 4 cantos rodados en una fila para anotar."
global.text_level_16_instruction[2] = "Primero a cinco victorias."
global.text_level_24_instruction[0] = "Haga clic en un mosaico para revelar el símbolo detrás."
global.text_level_24_instruction[1] = "Empareja símbolos para ganar."
global.text_message_at_swapping = "Haga clic en el personaje con el que desea intercambiar lugares."
global.text_message_t_noline = "T debe estar en línea con otra T para detonar."
global.text_message_t_detonate = "Haga clic en la otra T que desea detonar."
global.text_message_t_concreet = "Las explosiones T son bloqueadas por concreto."
global.text_message_dollar_sign_stunning = "Haz clic en el personaje que quieras lanzar. Debe estar dentro de 5 fichas."
global.text_level_0_intro[0] = "controla caracteres rojos"
global.text_level_0_intro[1] = "controla caracteres negros"
global.text_level_0_intro[2] = "X mata a Triangle y O y los túneles se oscurecen en amarillo."
global.text_level_0_intro[3] = "El triángulo mata a O pero X puede matarlo y solo puede moverse aunque sea amarillo."
global.text_level_0_intro[4] = "O es asesinado por X y Triangle. Ganas cuando el oponente pierde su O."
global.text_level_0_intro[5] = 'o al azar para decidir quién comienza.'
global.text_level_0_intro[6] = "haga clic en un personaje para seleccionarlo, cuando se selecciona un personaje aparece azul."
global.text_level_0_intro[7] = "Para mover un personaje, usa las teclas de flecha."
#define German
// German
// Stefan Grace
// Created: 2016-07-14
// Modified: 2024-07-27
// This script sets the language to German

// General
global.text_current_language = "Deutsche"
global.text_name = "Name"
global.text_player = "Spieler"
global.text_wins = "Siege"
global.text_player_change = "Spieler wechseln"
global.text_level = "Ebene"
global.text_starts = "Startet"
global.text_random = "Zufallig"
global.text_player_select = "Wahlen Sie, welcher Spieler beginnt"
global.text_draw = "Zeichnen"
global.text_draw_mode = "Draw-Modus: "
global.text_on = "Auf"
global.text_off = "Aus"
global.text_test_level = "Teststufe"
global.text_view = "Aussicht"
global.text_view_alumax = "Aussicht Alumax"
global.text_matches = "Streichhölzer"
global.text_cancel = "Stornieren"
global.text_click = "Klicken"

// Button Names
global.text_main_menu = "Hauptmenü"
global.text_next = "Nachster"
global.text_no = "Nein"
global.text_play = "Spielen"
global.text_quit = "Verlassen"
global.text_yes = "ja"
global.text_back = "Zuruck"
global.text_continue = "Fortsetzen"
global.text_restart = "Neustart"
global.text_alumax = "Alumax"
global.text_reset = "zurückstellen "
global.text_settings = "Einstellungen"
global.text_date_time = "Terminzeit"
global.text_music = "Musik"
global.text_ok = "OK"
global.text_language = "Sprache"
global.text_life_drain = "Lebensentzug"
global.text_life_give = "Leben geben"
global.text_cheats = "Cheats"
global.text_backgrounds = "Hintergrunde"
global.text_tablet_mode = "Tablet-Modus"
global.text_space = "Raum"
global.text_backspace = "Rucktaste"
global.text_menu = "Speisekarte"
global.text_transform = "Verwandeln"
global.text_port = "Hafen"
global.text_detonate = "Detonieren"
global.text_cast = "GieBen"
global.text_swap = "Tauschen"
global.text_spawn = "Laichen"
global.text_fullscreen = "Ganzer Bildschirm"

// Date & Time Buttons
global.text_year = "Jahr"
global.text_month = "Monat"
global.text_day = "Tag"
global.text_date = "Datum"
global.text_time = "Zeit"
global.text_twelve_hour = "12 Stunden"
global.text_twentyfour_hour = "24 Stunden"
global.text_number = "Nummer"
global.text_word = "Wort"
global.text_digit = "Ziffer"

// Date & Time Room
global.text_date_order = "Datum Reihenfolge"
global.text_year_format = "Jahr Format"
global.text_date_time_order = "Datum Zeit bestellen"
global.text_time_format = "Zeitformat"
global.text_month_format = "Monat Format"

// Months
global.Months[1] = "Jan"
global.Months[2] = "Feb"
global.Months[3] = "Bes"
global.Months[4] = "Apr"
global.Months[5] = "Kan"
global.Months[6] = "Jun"
global.Months[7] = "Jul"
global.Months[8] = "Aug"
global.Months[9] = "Sep"
global.Months[10] = "Okt"
global.Months[11] = "Nov"
global.Months[12] = "Dez"

// System Messages
global.text_alumax_message = "Willkommen im Alumax. Im Alumax konnen Sie Charaktere und Objekte nachschlagen."
global.text_box_four_message = "Es konnen immer nur 4 Charaktere gleichzeitig ein Plattchen besetzen"
global.text_player_name_change_a = "Bitte geben Sie einen Namen ein, der 1 bis "
global.text_player_name_change_b = " zeichen in der Lange."
global.text_reset_message_a = "Mochten Sie wirklich zurucksetzen?"
global.text_reset_message_b = "Sie verlieren samtliche Fortschritte auf allen Ebenen!"
global.text_reset_message_c = "Das Spiel wurde zuruckgesetzt."
global.text_reset_message_d = "Klicken Sie auf OK, um fortzufahren"
global.text_b_help = "Um auszuwahlen, welchen Charakter Sie verlieren mochten, klicken Sie einfach darauf"
global.text_box_full_db = "In ein Viertelfeld einer Doppelbox passt immer nur ein Charakter."
global.text_s_stun = "Ein Charakter kann sich nicht bewegen, wahrend er betaubt ist."
global.text_r_stun = "Ein R kann nicht schieBen, wenn er betaubt ist."
global.text_load_game = "Mochten Sie Ihr vorheriges Spiel laden?"
global.text_c_stun = "Ein C kann nicht katapultiert werden, wenn es betaubt ist."
global.text_no_g_in_range = "Kein G in Reichweite."
global.text_at_not_swap_big_g = "@ kann nicht mit Gigga G oder Terror G getauscht werden"
global.text_v_diagonal = "V kann sich nur diagonal bewegen, um die Charaktere des Gegners zu toten."
global.text_teleport_full = "In einen Teleport passen immer nur 4 Charaktere."

// Level Messages
global.text_message_level[0] = "WeiB steht fur Fels."
global.text_message_level[1] = "A kills X, but can be killed by Triangle."
global.text_message_level[2] = "Neutrale Charaktere konnen vom Ather-Spieler erfasst werden."
global.text_message_level[4] = "Dies ist ein Felsbrocken, der beim Schieben herunterfallt."
global.text_message_level[5] = "Dieser Zorn gibt dir die Kraft, 5 Zuge lang alles zu toten."
global.text_message_level[6] = "Square kann Rock tunneln."
global.text_message_level[7] = "Diamant kann nicht mit X oder Square getunnelt werden."
global.text_message_level[9] = "K kann Diamanten tunneln."
global.text_message_level[10] = "Das ist eine Bombe. Wenn es fallt, bläst es einen Tunnel."
global.text_message_level[11] = "B kann 4er Kisten infiltrieren."
global.text_message_level[12] = "Orange Wut lasst dich rocken."
global.text_message_level[13] = "E tötet O und Square und kann durch Fels und Diamant nach unten tunneln."
global.text_message_level[14] = "Barrieren konnen nicht durchfahren werden."
global.text_message_level[15] = "S betäubt alle Charaktere außer E und H."
global.text_message_level[17] = "Double Boxing verwandelt sich in Diamant, wenn es passiert wird."
global.text_message_level[18] = "H tötet und tunnelt horizontal."
global.text_message_level[19] = "Pfeilplattchen können nur in 1 Richtung durchlaufen werden."
global.text_message_level[20] = "R feuert Pfeile bis zu 5 Kacheln entfernt ab."
global.text_message_level[21] = "M explodiert und zerstort 9 Kacheln."
global.text_message_level[22] = "Mit Blue Anger konnen Charaktere Diamanten tunneln."
global.text_message_level[23] = "F bezaubert feindliche Charaktere."
global.text_message_level[25] = "G zerquetscht Fliesen mit seinem Hammer."
global.text_message_level[26] = "Diamantbombe bläst einen Tunnel durch Stein und Diamant."
global.text_message_level[27] = "C catapults boulders 5 tiles away."
global.text_message_level[28] = "Beton kann nicht getunnelt, gesprengt oder überfahren werden."

// Other Messages
global.text_choose_which_character_you_want_to_lose = "Wähle den Charakter, den du verlieren möchtest." 
global.text_double_boxing_entry_horizontal = "Verwenden Sie die Aufwärts- und Abwärtspfeile, um auszuwählen, in welches Feld Sie gehen."
global.text_double_boxing_entry_vertical = "Verwenden Sie die Pfeile nach links und nach rechts, um auszuwählen, in welches Feld Sie gehen."
global.text_message_neutral_characters_in_diamond = "Wenn sich ein neutrales Zeichen in einer Raute befindet, erscheint es gelb."
global.text_level_16_instruction[0] = "Klicken Sie auf eine beliebige Stelle, um einen Fettdruck abzulegen."
global.text_level_16_instruction[1] = "Verbinde 4 Steine in einer Reihe, um Punkte zu erzielen."
global.text_level_16_instruction[2] = "Erster bis fünf Siege."
global.text_level_24_instruction[0] = "Klicken Sie auf eine Kachel, um das Symbol dahinter anzuzeigen."
global.text_level_24_instruction[1] = "Finde passende Symbole, um zu gewinnen."
global.text_message_at_swapping = "Klicken Sie auf das Zeichen, mit dem Sie die Plätze tauschen möchten."
global.text_message_t_noline = "T muss in einer Linie mit einem anderen T sein, um zu detonieren."
global.text_message_t_detonate = "Klicken Sie auf das andere T, das Sie zur Detonation bringen möchten."
global.text_message_t_concreet = "T Explosionen werden durch Beton blockiert."
global.text_message_dollar_sign_stunning = "Klicken Sie auf den Charakter, auf den Sie wirken möchten. Muss innerhalb von 5 Kacheln liegen."
global.text_level_0_intro[0] = "steuert rote Zeichen"
global.text_level_0_intro[1] = "steuert schwarze Zeichen"
global.text_level_0_intro[2] = "X tötet Triangle und O und Tunnel färben sich gelb."
global.text_level_0_intro[3] = "Triangle tötet DICH, kann aber von X getötet werden und sich nur durch Gelb bewegen."
global.text_level_0_intro[4] = "O wird von X und Triangle getötet. Sie gewinnen, wenn der Gegner sein O verliert."
global.text_level_0_intro[5] = 'oder Zufällig, um zu entscheiden, wer anfängt.'
global.text_level_0_intro[6] = "Klicken Sie auf ein Zeichen, um es auszuwählen. Wenn Sie ein Zeichen auswählen, wird es blau angezeigt."

#define Room_Creation
// Room_Creation
// Stefan Grace
// Created: 2016-07-01
// Modified: 2024-07-27
// This Script is executed when the level starts

global.message_type = 0
script_execute(Base_Create)
script_execute(Double_Boxing_Create)
script_execute(Neutral_Character_Create)
script_execute(Background_Script)
script_execute(Ask_To_Load_Save)
script_execute(Create_Tablet_UI)
global.anger = 0
#define Base_Create
// Base_Create
// Stefan Grace
// Created: 2016-08-02
// Modified: 2018-06-10
// This script creates the characters in the bases


// Test Level 9
if (global.levelnumber==-9)
{
    // Red
    instance_create(1*grid_size,20*grid_size,Red_Stuned_O)
    instance_create(2*grid_size,20*grid_size,Red_Stuned_X)
    instance_create(3*grid_size,20*grid_size,Red_Stuned_Z)
    instance_create(4*grid_size,20*grid_size,Red_Stuned_W)
    instance_create(5*grid_size,20*grid_size,Red_Stuned_J)
    instance_create(6*grid_size,20*grid_size,Red_Stuned_V)
    instance_create(7*grid_size,20*grid_size,Red_Stuned_P)
    instance_create(8*grid_size,20*grid_size,Red_Stuned_T)
    instance_create(9*grid_size,20*grid_size,Red_Stuned_D)
    instance_create(10*grid_size,20*grid_size,Red_Stuned_Q)
    instance_create(11*grid_size,20*grid_size,Red_Stuned_N)
    instance_create(12*grid_size,20*grid_size,Red_Stuned_Question_Mark)
    instance_create(13*grid_size,20*grid_size,Red_Stuned_U)
    instance_create(14*grid_size,20*grid_size,Red_Stuned_L)
    instance_create(15*grid_size,20*grid_size,Red_Stuned_Dollar_Sign)
    instance_create(16*grid_size,20*grid_size,Red_Stuned_At)
    instance_create(17*grid_size,20*grid_size,Red_Stuned_I)
    // Black
    instance_create(36*grid_size,20*grid_size,Black_Stuned_O)
    instance_create(35*grid_size,20*grid_size,Black_Stuned_X)
    instance_create(34*grid_size,20*grid_size,Black_Stuned_Z)
    instance_create(33*grid_size,20*grid_size,Black_Stuned_W)
    instance_create(32*grid_size,20*grid_size,Black_Stuned_J)
    instance_create(31*grid_size,20*grid_size,Black_Stuned_V)
    instance_create(30*grid_size,20*grid_size,Black_Stuned_P)
    instance_create(29*grid_size,20*grid_size,Black_Stuned_T)
    instance_create(28*grid_size,20*grid_size,Black_Stuned_D)
    instance_create(27*grid_size,20*grid_size,Black_Stuned_Q)
    instance_create(26*grid_size,20*grid_size,Black_Stuned_N)
    instance_create(25*grid_size,20*grid_size,Black_Stuned_Question_Mark)
    instance_create(24*grid_size,20*grid_size,Black_Stuned_U)
    instance_create(23*grid_size,20*grid_size,Black_Stuned_L)
    instance_create(22*grid_size,20*grid_size,Black_Stuned_Dollar_Sign)
    instance_create(21*grid_size,20*grid_size,Black_Stuned_At)
    instance_create(20*grid_size,20*grid_size,Black_Stuned_I)
}

// Level 0
if (global.levelnumber==0)
{
    // Red
    instance_create(770,665,Red_Stuned_X)
    instance_create(787,665,Red_Stuned_O)
    instance_create(770,682,Red_Stuned_Triangle)
    // Black
    instance_create(525,70,Black_Stuned_X)
    instance_create(542,70,Black_Stuned_O)
    instance_create(525,87,Black_Stuned_Triangle)
}

// Level 1
if (global.levelnumber==1)
{
    // Red
    instance_create(770,665,Red_Stuned_A)
    instance_create(805,665,Red_Stuned_X)
    instance_create(805+17,665,Red_Stuned_Triangle)
    instance_create(805,665+17,Red_Stuned_O)
    instance_create(805+17,665+17,Red_Stuned_O)
    // Black
    instance_create(385,140,Black_Stuned_X)
    instance_create(385+17,140,Black_Stuned_Triangle)
    instance_create(385,140+17,Black_Stuned_O)
    instance_create(385+17,140+17,Black_Stuned_O)
    instance_create(420,140,Black_Stuned_A)
}

// Level 2
if (global.levelnumber==2)
{
    // Red
    instance_create(945,630,Red_Stuned_X)
    instance_create(945+17,630,Red_Stuned_X)
    instance_create(945,630+17,Red_Stuned_A)
    instance_create(945,665,Red_Stuned_O)
    instance_create(945+17,665,Red_Stuned_O)
    instance_create(945,665+17,Red_Stuned_O)
    // Black
    instance_create(315,70,Black_Stuned_O)
    instance_create(315+17,70,Black_Stuned_O)
    instance_create(315,70+17,Black_Stuned_O)
    instance_create(315,105,Black_Stuned_X)
    instance_create(315+17,105,Black_Stuned_X)
    instance_create(315,105+17,Black_Stuned_A)
}

// Level 3
if (global.levelnumber==3)
{
    // Red
    instance_create(910,665,Red_Stuned_Triangle)
    instance_create(910+17,665,Red_Stuned_Triangle)
    instance_create(910,665+17,Red_Stuned_O)
    instance_create(945,665,Red_Stuned_A)
    instance_create(945+17,665,Red_Stuned_O)
    instance_create(945,665+17,Red_Stuned_O)
    // Black
    instance_create(910,70,Black_Stuned_Triangle)
    instance_create(910+17,70,Black_Stuned_Triangle)
    instance_create(910,70+17,Black_Stuned_O)
    instance_create(945,70,Black_Stuned_A)
    instance_create(945+17,70,Black_Stuned_O)
    instance_create(945,70+17,Black_Stuned_O)
}

// Level 4
if (global.levelnumber==4)
{
    // Red
    instance_create(1225,665,Red_Stuned_Triangle)
    instance_create(1225+17,665,Red_Stuned_Triangle)
    instance_create(1225,665+17,Red_Stuned_O)
    instance_create(1260,665,Red_Stuned_X)
    instance_create(1260+17,665,Red_Stuned_X)
    instance_create(1260,665+17,Red_Stuned_O)
    instance_create(1225,700,Red_Stuned_A)
    instance_create(1225,700+17,Red_Stuned_A)
    instance_create(1260,700,Red_Stuned_O)
    instance_create(1260+17,700,Red_Stuned_O)
    instance_create(1260+17,700,Red_Stuned_O)
    // Black
    instance_create(35,665,Black_Stuned_X)
    instance_create(35+17,665,Black_Stuned_X)
    instance_create(35,665+17,Black_Stuned_O)
    instance_create(70,665,Black_Stuned_Triangle)
    instance_create(70+17,665,Black_Stuned_Triangle)
    instance_create(70,665+17,Black_Stuned_O)
    instance_create(35,700,Black_Stuned_O)
    instance_create(35+17,700,Black_Stuned_O)
    instance_create(35,700+17,Black_Stuned_O)
    instance_create(70,700,Black_Stuned_A)
    instance_create(70+17,700,Black_Stuned_A)
}    

// Level 5
if (global.levelnumber==5)
{
    // Red
    instance_create(910,70,Red_Stuned_O)
    instance_create(910+17,70,Red_Stuned_Triangle)
    instance_create(910,70+17,Red_Stuned_Triangle)
    instance_create(945,70,Red_Stuned_X)
    instance_create(945+17,70,Red_Stuned_X)
    instance_create(945,70+17,Red_Stuned_O)
    instance_create(910,105,Red_Stuned_A)
    instance_create(910+17,105,Red_Stuned_A)
    instance_create(945,105,Red_Stuned_O)
    instance_create(945+17,105,Red_Stuned_O)
    instance_create(945,105+17,Red_Stuned_O)
    // Black
    instance_create(350,630,Black_Stuned_X)
    instance_create(350+17,630,Black_Stuned_X)
    instance_create(350,630+17,Black_Stuned_O)
    instance_create(385,630,Black_Stuned_O)
    instance_create(385+17,630,Black_Stuned_Triangle)
    instance_create(385,630+17,Black_Stuned_Triangle)
    instance_create(350,665,Black_Stuned_O)
    instance_create(350+17,665,Black_Stuned_O)
    instance_create(350,665+17,Black_Stuned_O)
    instance_create(385,665,Black_Stuned_A)
    instance_create(385+17,665,Black_Stuned_A)
}

// Level 6
if (global.levelnumber==6)
{
    // Red
    instance_create(350,665,Red_Stuned_Square)
    instance_create(350+17,665,Red_Stuned_O)
    instance_create(350,665+17,Red_Stuned_O)
    instance_create(385,665,Red_Stuned_A)
    instance_create(385+17,665,Red_Stuned_A)
    instance_create(385,665+17,Red_Stuned_O)
    instance_create(385,700,Red_Stuned_Triangle)
    instance_create(385+17,700,Red_Stuned_Triangle)
    // Black
    instance_create(875,35,Black_Stuned_Triangle)
    instance_create(875+17,35,Black_Stuned_Triangle)
    instance_create(875,70,Black_Stuned_A)
    instance_create(875+17,70,Black_Stuned_A)
    instance_create(875,70+17,Black_Stuned_O)
    instance_create(875,70,Black_Stuned_A)
    instance_create(910,70,Black_Stuned_Square)
    instance_create(910+17,70,Black_Stuned_O)
    instance_create(910,70+17,Black_Stuned_O)
}

// Level 7
if (global.levelnumber==7)
{
    // Red
    instance_create(35,315,Red_Stuned_O)
    instance_create(35+17,315,Red_Stuned_O)
    instance_create(35,315+17,Red_Stuned_O)
    instance_create(70,315,Red_Stuned_A)
    instance_create(70+17,315,Red_Stuned_A)
    instance_create(70,315+17,Red_Stuned_A)
    instance_create(35,350,Red_Stuned_O)
    instance_create(35+17,350,Red_Stuned_O)
    instance_create(35,350+17,Red_Stuned_O)
    instance_create(70,350,Red_Stuned_Triangle)
    instance_create(70+17,350,Red_Stuned_Triangle)
    instance_create(70,350+17,Red_Stuned_Triangle)
    instance_create(35,385,Red_Stuned_X)
    instance_create(35+17,385,Red_Stuned_X)
    instance_create(35,385+17,Red_Stuned_X)
    instance_create(70,385,Red_Stuned_Square)
    instance_create(70+17,385,Red_Stuned_Square)
    instance_create(70,385+17,Red_Stuned_Square)
    // Black
    instance_create(1225,315,Black_Stuned_A)
    instance_create(1225+17,315,Black_Stuned_A)
    instance_create(1225,315+17,Black_Stuned_A)
    instance_create(1260,315,Black_Stuned_O)
    instance_create(1260+17,315,Black_Stuned_O)
    instance_create(1260,315+17,Black_Stuned_O)
    instance_create(1225,350,Black_Stuned_Triangle)
    instance_create(1225+17,350,Black_Stuned_Triangle)
    instance_create(1225,350+17,Black_Stuned_Triangle)
    instance_create(1260,350,Black_Stuned_O)
    instance_create(1260+17,350,Black_Stuned_O)
    instance_create(1260,350+17,Black_Stuned_O)
    instance_create(1225,385,Black_Stuned_Square)
    instance_create(1225+17,385,Black_Stuned_Square)
    instance_create(1225,385+17,Black_Stuned_Square)
    instance_create(1260,385,Black_Stuned_X)
    instance_create(1260+17,385,Black_Stuned_X)
    instance_create(1260,385+17,Black_Stuned_X)
}

// Level 8
if (global.levelnumber==8)
{
    // Red
    instance_create(1225,595,Red_Stuned_O)
    instance_create(1225+17,595,Red_Stuned_O)
    instance_create(1225,595+17,Red_Stuned_O)
    instance_create(1260,595,Red_Stuned_O)
    instance_create(1260+17,595,Red_Stuned_O)
    instance_create(1260,595+17,Red_Stuned_O)
    instance_create(1225,630,Red_Stuned_X)
    instance_create(1225+17,630,Red_Stuned_X)
    instance_create(1225,630+17,Red_Stuned_X)
    instance_create(1260,630,Red_Stuned_A)
    instance_create(1260+17,630,Red_Stuned_A)
    instance_create(1260,630+17,Red_Stuned_A)
    instance_create(1225,665,Red_Stuned_Square)
    instance_create(1225+17,665,Red_Stuned_Square)
    instance_create(1225,665+17,Red_Stuned_Square)
    instance_create(1260,665,Red_Stuned_Triangle)
    instance_create(1260+17,665,Red_Stuned_Triangle)
    instance_create(1260,665+17,Red_Stuned_Triangle)
    // Black
    instance_create(35,595,Black_Stuned_O)
    instance_create(35+17,595,Black_Stuned_O)
    instance_create(35,595+17,Black_Stuned_O)
    instance_create(70,595,Black_Stuned_O)
    instance_create(70+17,595,Black_Stuned_O)
    instance_create(70,595+17,Black_Stuned_O)
    instance_create(35,630,Black_Stuned_X)
    instance_create(35+17,630,Black_Stuned_X)
    instance_create(35,630+17,Black_Stuned_X)
    instance_create(70,630,Black_Stuned_A)
    instance_create(70+17,630,Black_Stuned_A)
    instance_create(70,630+17,Black_Stuned_A)
    instance_create(35,665,Black_Stuned_Square)
    instance_create(35+17,665,Black_Stuned_Square)
    instance_create(35,665+17,Black_Stuned_Square)
    instance_create(70,665,Black_Stuned_Triangle)
    instance_create(70+17,665,Black_Stuned_Triangle)
    instance_create(70,665+17,Black_Stuned_Triangle)
}

// Level 9
if (global.levelnumber==9)
{
    // Red
    instance_create(1120,630,Red_Stuned_O)
    instance_create(1120+17,630,Red_Stuned_O)
    instance_create(1120,630+17,Red_Stuned_O)
    instance_create(1155,630,Red_Stuned_O)
    instance_create(1155+17,630,Red_Stuned_O)
    instance_create(1155,630+17,Red_Stuned_O)
    instance_create(1120,665,Red_Stuned_X)
    instance_create(1120+17,665,Red_Stuned_X)
    instance_create(1120,665+17,Red_Stuned_X)
    instance_create(1155,665,Red_Stuned_A)
    instance_create(1155+17,665,Red_Stuned_A)
    instance_create(1155,665+17,Red_Stuned_A)
    instance_create(1120,700,Red_Stuned_Triangle)
    instance_create(1120+17,700,Red_Stuned_Triangle)
    instance_create(1120,700+17,Red_Stuned_Triangle)
    instance_create(1155,700,Red_Stuned_Square)
    instance_create(1155+17,700,Red_Stuned_Square)
    instance_create(1155,700+17,Red_Stuned_Square)
    instance_create(1085,700,Red_Stuned_K)
    // Black
    instance_create(35,630,Black_Stuned_O)
    instance_create(35+17,630,Black_Stuned_O)
    instance_create(35,630+17,Black_Stuned_O)
    instance_create(70,630,Black_Stuned_O)
    instance_create(70+17,630,Black_Stuned_O)
    instance_create(70,630+17,Black_Stuned_O)
    instance_create(35,665,Black_Stuned_X)
    instance_create(35+17,665,Black_Stuned_X)
    instance_create(35,665+17,Black_Stuned_X)
    instance_create(70,665,Black_Stuned_A)
    instance_create(70+17,665,Black_Stuned_A)
    instance_create(70,665+17,Black_Stuned_A)
    instance_create(35,700,Black_Stuned_Triangle)
    instance_create(35+17,700,Black_Stuned_Triangle)
    instance_create(35,700+17,Black_Stuned_Triangle)
    instance_create(70,700,Black_Stuned_Square)
    instance_create(70+17,700,Black_Stuned_Square)
    instance_create(70,700+17,Black_Stuned_Square)
    instance_create(105,700,Black_Stuned_K)
}

// Level 10
if (global.levelnumber==10)
{
    // Red
    instance_create(1260,630,Red_Stuned_Square)
    instance_create(1260+17,630,Red_Stuned_Square)
    instance_create(1260,630+17,Red_Stuned_Square)
    instance_create(1260,665,Red_Stuned_A)
    instance_create(1260+17,665,Red_Stuned_A)
    instance_create(1260,665+17,Red_Stuned_A)
    instance_create(1260,700,Red_Stuned_X)
    instance_create(1260+17,700,Red_Stuned_X)
    instance_create(1260,700+17,Red_Stuned_X)
    instance_create(1190,665,Red_Stuned_O)
    instance_create(1190+17,665,Red_Stuned_O)
    instance_create(1190,665+17,Red_Stuned_O)
    instance_create(1190,700,Red_Stuned_Triangle)
    instance_create(1190+17,700,Red_Stuned_Triangle)
    instance_create(1190,700+17,Red_Stuned_Triangle)
    instance_create(1120,700,Red_Stuned_O)
    instance_create(1120+17,700,Red_Stuned_O)
    instance_create(1120,700+17,Red_Stuned_O)
    instance_create(1050,700,Red_Stuned_K)
    // Black
    instance_create(35,630,Black_Stuned_Square)
    instance_create(35+17,630,Black_Stuned_Square)
    instance_create(35,630+17,Black_Stuned_Square)
    instance_create(35,665,Black_Stuned_A)
    instance_create(35+17,665,Black_Stuned_A)
    instance_create(35,665+17,Black_Stuned_A)
    instance_create(35,700,Black_Stuned_X)
    instance_create(35+17,700,Black_Stuned_X)
    instance_create(35,700+17,Black_Stuned_X)
    instance_create(105,665,Black_Stuned_O)
    instance_create(105+17,665,Black_Stuned_O)
    instance_create(105,665+17,Black_Stuned_O)
    instance_create(105,700,Black_Stuned_Triangle)
    instance_create(105+17,700,Black_Stuned_Triangle)
    instance_create(105,700+17,Black_Stuned_Triangle)
    instance_create(175,700,Black_Stuned_O)
    instance_create(175+17,700,Black_Stuned_O)
    instance_create(175,700+17,Black_Stuned_O)
    instance_create(245,700,Black_Stuned_K)
}

// Level 11
if (global.levelnumber==11)
{
    // Red
    instance_create(35,630,Red_Stuned_Triangle)
    instance_create(35+17,630,Red_Stuned_Triangle)
    instance_create(35,630+17,Red_Stuned_Triangle)
    instance_create(70,630,Red_Stuned_B)
    instance_create(70+17,630,Red_Stuned_Square)
    instance_create(70,630+17,Red_Stuned_Square)
    instance_create(35,665,Red_Stuned_A)
    instance_create(35+17,665,Red_Stuned_A)
    instance_create(35,665+17,Red_Stuned_A)
    instance_create(70,665,Red_Stuned_O)
    instance_create(70+17,665,Red_Stuned_O)
    instance_create(70,665+17,Red_Stuned_O)
    instance_create(35,700,Red_Stuned_X)
    instance_create(35+17,700,Red_Stuned_X)
    instance_create(35,700+17,Red_Stuned_X)
    instance_create(70,700,Red_Stuned_O)
    instance_create(70+17,700,Red_Stuned_O)
    instance_create(70,700+17,Red_Stuned_O)
    // Black
    instance_create(1260,630,Black_Stuned_Triangle)
    instance_create(1260+17,630,Black_Stuned_Triangle)
    instance_create(1260,630+17,Black_Stuned_Triangle)
    instance_create(1225,630,Black_Stuned_B)
    instance_create(1225+17,630,Black_Stuned_Square)
    instance_create(1225,630+17,Black_Stuned_Square)
    instance_create(1260,665,Black_Stuned_A)
    instance_create(1260+17,665,Black_Stuned_A)
    instance_create(1260,665+17,Black_Stuned_A)
    instance_create(1225,665,Black_Stuned_O)
    instance_create(1225+17,665,Black_Stuned_O)
    instance_create(1225,665+17,Black_Stuned_O)
    instance_create(1260,700,Black_Stuned_X)
    instance_create(1260+17,700,Black_Stuned_X)
    instance_create(1260,700+17,Black_Stuned_X)
    instance_create(1225,700,Black_Stuned_O)
    instance_create(1225+17,700,Black_Stuned_O)
    instance_create(1225,700+17,Black_Stuned_O)
}

// Level 12
if (global.levelnumber==12)
{
    // Red    
    instance_create(1260,315,Red_Stuned_O)
    instance_create(1260+17,315,Red_Stuned_O)
    instance_create(1260,315+17,Red_Stuned_O)
    instance_create(1225,315,Red_Stuned_Triangle)
    instance_create(1225+17,315,Red_Stuned_Triangle)
    instance_create(1225,315+17,Red_Stuned_Triangle)
    instance_create(1260,350,Red_Stuned_O)
    instance_create(1260+17,350,Red_Stuned_O)
    instance_create(1260,350+17,Red_Stuned_O)
    instance_create(1225,350,Red_Stuned_K)
    instance_create(1225+17,350,Red_Stuned_K)
    instance_create(1225,350+17,Red_Stuned_K)
    instance_create(1260,385,Red_Stuned_A)
    instance_create(1260+17,385,Red_Stuned_A)
    instance_create(1260,385+17,Red_Stuned_A)
    // Black    
    instance_create(35,315,Black_Stuned_O)
    instance_create(35+17,315,Black_Stuned_O)
    instance_create(35,315+17,Black_Stuned_O)
    instance_create(70,315,Black_Stuned_Triangle)
    instance_create(70+17,315,Black_Stuned_Triangle)
    instance_create(70,315+17,Black_Stuned_Triangle)
    instance_create(35,350,Black_Stuned_O)
    instance_create(35+17,350,Black_Stuned_O)
    instance_create(35,350+17,Black_Stuned_O)
    instance_create(70,350,Black_Stuned_K)
    instance_create(70+17,350,Black_Stuned_K)
    instance_create(70,350+17,Black_Stuned_K)
    instance_create(35,385,Black_Stuned_A)
    instance_create(35+17,385,Black_Stuned_A)
    instance_create(35,385+17,Black_Stuned_A)
}

// Level 13
if (global.levelnumber==13)
{
    // Red
    instance_create(1260,245,Red_Stuned_O)
    instance_create(1260+17,245,Red_Stuned_O)
    instance_create(1260,245+17,Red_Stuned_O)
    instance_create(1225,245,Red_Stuned_O)
    instance_create(1225+17,245,Red_Stuned_O)
    instance_create(1225,245+17,Red_Stuned_O)
    instance_create(1190,245,Red_Stuned_Triangle)
    instance_create(1190+17,245,Red_Stuned_Triangle)
    instance_create(1190,245+17,Red_Stuned_Triangle)
    instance_create(1260,280,Red_Stuned_X)
    instance_create(1260+17,280,Red_Stuned_X)
    instance_create(1260,280+17,Red_Stuned_X)
    instance_create(1225,280,Red_Stuned_A)
    instance_create(1225+17,280,Red_Stuned_A)
    instance_create(1225,280+17,Red_Stuned_A)
    instance_create(1190,280,Red_Stuned_X)
    instance_create(1190+17,280,Red_Stuned_X)
    instance_create(1190,280+17,Red_Stuned_X)
    instance_create(1260,315,Red_Stuned_E)
    // Black
    instance_create(35,245,Black_Stuned_O)
    instance_create(35+17,245,Black_Stuned_O)
    instance_create(35,245+17,Black_Stuned_O)
    instance_create(70,245,Black_Stuned_O)
    instance_create(70+17,245,Black_Stuned_O)
    instance_create(70,245+17,Black_Stuned_O)
    instance_create(105,245,Black_Stuned_Triangle)
    instance_create(105+17,245,Black_Stuned_Triangle)
    instance_create(105,245+17,Black_Stuned_Triangle)
    instance_create(35,280,Black_Stuned_X)
    instance_create(35+17,280,Black_Stuned_X)
    instance_create(35,280+17,Black_Stuned_X)
    instance_create(70,280,Black_Stuned_A)
    instance_create(70+17,280,Black_Stuned_A)
    instance_create(70,280+17,Black_Stuned_A)
    instance_create(105,280,Black_Stuned_X)
    instance_create(105+17,280,Black_Stuned_X)
    instance_create(105,280+17,Black_Stuned_X)
    instance_create(35,315,Black_Stuned_E)
}

// Level 14
if (global.levelnumber==14)
{
    // Red
    instance_create(1260,595,Red_Stuned_Square)
    instance_create(1260+17,595,Red_Stuned_Square)
    instance_create(1260,595+17,Red_Stuned_Square)
    instance_create(1225,595,Red_Stuned_E)
    instance_create(1225+17,595,Red_Stuned_E)
    instance_create(1260,630,Red_Stuned_Triangle)
    instance_create(1260+17,630,Red_Stuned_Triangle)
    instance_create(1260,630+17,Red_Stuned_Triangle)
    instance_create(1225,630,Red_Stuned_K)
    instance_create(1225+17,630,Red_Stuned_K)
    instance_create(1225,630+17,Red_Stuned_B)
    instance_create(1260,665,Red_Stuned_O)
    instance_create(1260+17,665,Red_Stuned_O)
    instance_create(1260,665+17,Red_Stuned_O)
    instance_create(1225,665,Red_Stuned_A)
    instance_create(1225+17,665,Red_Stuned_A)
    instance_create(1225,665+17,Red_Stuned_A)
    instance_create(1260,700,Red_Stuned_O)
    instance_create(1260+17,700,Red_Stuned_O)
    instance_create(1260,700+17,Red_Stuned_O)
    instance_create(1225,700,Red_Stuned_X)
    instance_create(1225+17,700,Red_Stuned_X)
    instance_create(1225,700+17,Red_Stuned_X)
    // Black
    instance_create(35,595,Black_Stuned_Square)
    instance_create(35+17,595,Black_Stuned_Square)
    instance_create(35,595+17,Black_Stuned_Square)
    instance_create(70,595,Black_Stuned_E)
    instance_create(70+17,595,Black_Stuned_E)
    instance_create(35,630,Black_Stuned_Triangle)
    instance_create(35+17,630,Black_Stuned_Triangle)
    instance_create(35,630+17,Black_Stuned_Triangle)
    instance_create(70,630,Black_Stuned_K)
    instance_create(70+17,630,Black_Stuned_K)
    instance_create(70,630+17,Black_Stuned_B)
    instance_create(35,665,Black_Stuned_O)
    instance_create(35+17,665,Black_Stuned_O)
    instance_create(35,665+17,Black_Stuned_O)
    instance_create(70,665,Black_Stuned_A)
    instance_create(70+17,665,Black_Stuned_A)
    instance_create(70,665+17,Black_Stuned_A)
    instance_create(35,700,Black_Stuned_O)
    instance_create(35+17,700,Black_Stuned_O)
    instance_create(35,700+17,Black_Stuned_O)
    instance_create(70,700,Black_Stuned_X)
    instance_create(70+17,700,Black_Stuned_X)
    instance_create(70,700+17,Black_Stuned_X)
}

// Level 15
if (global.levelnumber==15)
{
    // Black
    instance_create(35,630,Black_Stuned_Triangle)
    instance_create(35+17,630,Black_Stuned_Triangle)
    instance_create(35,630+17,Black_Stuned_Triangle)
    instance_create(70,630,Black_Stuned_Square)
    instance_create(70+17,630,Black_Stuned_Square)
    instance_create(70,630+17,Black_Stuned_Square)
    instance_create(105,630,Black_Stuned_E)
    instance_create(35,665,Black_Stuned_O)
    instance_create(35+17,665,Black_Stuned_O)
    instance_create(35,665+17,Black_Stuned_O)
    instance_create(70,665,Black_Stuned_X)
    instance_create(70+17,665,Black_Stuned_X)
    instance_create(70,665+17,Black_Stuned_X)
    instance_create(105,665,Black_Stuned_S) 
    instance_create(105+17,665,Black_Stuned_S)
    instance_create(105,665+17,Black_Stuned_S)
    instance_create(35,700,Black_Stuned_O)
    instance_create(35+17,700,Black_Stuned_O)
    instance_create(35,700+17,Black_Stuned_O)
    instance_create(70,700,Black_Stuned_A)
    instance_create(70+17,700,Black_Stuned_A)
    instance_create(70,700+17,Black_Stuned_A)
    // Red
    instance_create(1260,630,Red_Stuned_Triangle)
    instance_create(1260+17,630,Red_Stuned_Triangle)
    instance_create(1260,630+17,Red_Stuned_Triangle)
    instance_create(1225,630,Red_Stuned_Square)
    instance_create(1225+17,630,Red_Stuned_Square)
    instance_create(1225,630+17,Red_Stuned_Square)
    instance_create(1190,630,Red_Stuned_E)
    instance_create(1260,665,Red_Stuned_O)
    instance_create(1260+17,665,Red_Stuned_O)
    instance_create(1260,665+17,Red_Stuned_O)
    instance_create(1225,665,Red_Stuned_X)
    instance_create(1225+17,665,Red_Stuned_X)
    instance_create(1225,665+17,Red_Stuned_X)
    instance_create(1190,665,Red_Stuned_S) 
    instance_create(1190+17,665,Red_Stuned_S)
    instance_create(1190,665+17,Red_Stuned_S)
    instance_create(1260,700,Red_Stuned_O)
    instance_create(1260+17,700,Red_Stuned_O)
    instance_create(1260,700+17,Red_Stuned_O)
    instance_create(1225,700,Red_Stuned_A)
    instance_create(1225+17,700,Red_Stuned_A)
    instance_create(1225,700+17,Red_Stuned_A)
}

// Level 17
if (global.levelnumber==17)
{
    // Black
    instance_create(35,630,Black_Stuned_O)
    instance_create(35+17,630,Black_Stuned_O)
    instance_create(35,630+17,Black_Stuned_O)
    instance_create(70,630,Black_Stuned_Square)
    instance_create(70+17,630,Black_Stuned_Square)
    instance_create(70,630+17,Black_Stuned_Square)
    instance_create(105,630,Black_Stuned_K)
    instance_create(105+17,630,Black_Stuned_K)
    instance_create(105,630+17,Black_Stuned_B)
    instance_create(35,665,Black_Stuned_X)
    instance_create(35+17,665,Black_Stuned_X)
    instance_create(35,665+17,Black_Stuned_X)
    instance_create(70,665,Black_Stuned_A)
    instance_create(70+17,665,Black_Stuned_A)
    instance_create(70,665+17,Black_Stuned_A)
    instance_create(105,665,Black_Stuned_E)
    instance_create(105+17,665,Black_Stuned_E)
    instance_create(35,700,Black_Stuned_Triangle)
    instance_create(35+17,700,Black_Stuned_Triangle)
    instance_create(35,700+17,Black_Stuned_Triangle)
    instance_create(70,700,Black_Stuned_O)
    instance_create(70+17,700,Black_Stuned_O)
    instance_create(70,700+17,Black_Stuned_O)
    instance_create(105,700,Black_Stuned_S)
    instance_create(105+17,700,Black_Stuned_S)
    // Red
    instance_create(1260,630,Red_Stuned_O)
    instance_create(1260+17,630,Red_Stuned_O)
    instance_create(1260,630+17,Red_Stuned_O)
    instance_create(1225,630,Red_Stuned_Square)
    instance_create(1225+17,630,Red_Stuned_Square)
    instance_create(1225,630+17,Red_Stuned_Square)
    instance_create(1190,630,Red_Stuned_K)
    instance_create(1190+17,630,Red_Stuned_K)
    instance_create(1190,630+17,Red_Stuned_B)
    instance_create(1260,665,Red_Stuned_X)
    instance_create(1260+17,665,Red_Stuned_X)
    instance_create(1260,665+17,Red_Stuned_X)
    instance_create(1225,665,Red_Stuned_A)
    instance_create(1225+17,665,Red_Stuned_A)
    instance_create(1225,665+17,Red_Stuned_A)
    instance_create(1190,665,Red_Stuned_E)
    instance_create(1190+17,665,Red_Stuned_E)
    instance_create(1260,700,Red_Stuned_Triangle)
    instance_create(1260+17,700,Red_Stuned_Triangle)
    instance_create(1260,700+17,Red_Stuned_Triangle)
    instance_create(1225,700,Red_Stuned_O)
    instance_create(1225+17,700,Red_Stuned_O)
    instance_create(1225,700+17,Red_Stuned_O)
    instance_create(1190,700,Red_Stuned_S)
    instance_create(1190+17,700,Red_Stuned_S)
}
    
// Level 18
if (global.levelnumber==18)
{
    // Black
    instance_create(35,35,Black_Stuned_A)
    instance_create(35,105,Black_Stuned_H)
    instance_create(35,175,Black_Stuned_A)
    instance_create(35,245,Black_Stuned_O)
    instance_create(35,315,Black_Stuned_O)
    instance_create(35+17,315,Black_Stuned_O)
    instance_create(35,315+17,Black_Stuned_O)
    instance_create(35,350,Black_Stuned_O)
    instance_create(35+17,350,Black_Stuned_O)
    instance_create(35,350+17,Black_Stuned_O)
    instance_create(35,420,Black_Stuned_S)
    instance_create(35,490,Black_Stuned_H)
    instance_create(35,560,Black_Stuned_A)
    instance_create(35,630,Black_Stuned_H)
    instance_create(35,700,Black_Stuned_E)
    // Red
    instance_create(1260,35,Red_Stuned_A)
    instance_create(1260,105,Red_Stuned_H)
    instance_create(1260,175,Red_Stuned_A)
    instance_create(1260,245,Red_Stuned_O)
    instance_create(1260,315,Red_Stuned_O)
    instance_create(1260+17,315,Red_Stuned_O)
    instance_create(1260,315+17,Red_Stuned_O)
    instance_create(1260,350,Red_Stuned_O)
    instance_create(1260+17,350,Red_Stuned_O)
    instance_create(1260,350+17,Red_Stuned_O)
    instance_create(1260,420,Red_Stuned_S)
    instance_create(1260,490,Red_Stuned_H)
    instance_create(1260,560,Red_Stuned_A)
    instance_create(1260,630,Red_Stuned_H)
    instance_create(1260,700,Red_Stuned_E)
}

// Level 19
if (global.levelnumber==19)
{
    // Black
    instance_create(1*grid_size,18*grid_size,Black_Stuned_X)
    instance_create((1*grid_size)+17,18*grid_size,Black_Stuned_X)
    instance_create(2*grid_size,18*grid_size,Black_Stuned_O)
    instance_create((2*grid_size)+17,(18*grid_size),Black_Stuned_O)
    instance_create((3*grid_size),(18*grid_size),Black_Stuned_H)
    instance_create((3*grid_size)+17,(18*grid_size),Black_Stuned_H)
    instance_create((4*grid_size),(18*grid_size),Black_Stuned_Triangle)
    instance_create((4*grid_size)+17,(18*grid_size),Black_Stuned_Triangle)
    instance_create((1*grid_size),(19*grid_size),Black_Stuned_Square)
    instance_create((1*grid_size)+17,(19*grid_size),Black_Stuned_Square)
    instance_create((2*grid_size),(19*grid_size),Black_Stuned_A)
    instance_create((2*grid_size)+17,(19*grid_size),Black_Stuned_A)
    instance_create((3*grid_size),(19*grid_size),Black_Stuned_E)
    instance_create((3*grid_size)+17,(19*grid_size),Black_Stuned_E)
    instance_create((4*grid_size),(19*grid_size),Black_Stuned_K)
    instance_create((1*grid_size),(20*grid_size),Black_Stuned_S)
    instance_create((1*grid_size)+17,(20*grid_size),Black_Stuned_S)
    // Red
    instance_create(36*grid_size,18*grid_size,Red_Stuned_X)
    instance_create((36*grid_size)+17,18*grid_size,Red_Stuned_X)
    instance_create(35*grid_size,18*grid_size,Red_Stuned_O)
    instance_create((35*grid_size)+17,(18*grid_size),Red_Stuned_O)
    instance_create((34*grid_size),(18*grid_size),Red_Stuned_H)
    instance_create((34*grid_size)+17,(18*grid_size),Red_Stuned_H)
    instance_create((33*grid_size),(18*grid_size),Red_Stuned_Triangle)
    instance_create((33*grid_size)+17,(18*grid_size),Red_Stuned_Triangle)
    instance_create((36*grid_size),(19*grid_size),Red_Stuned_Square)
    instance_create((36*grid_size)+17,(19*grid_size),Red_Stuned_Square)
    instance_create((35*grid_size),(19*grid_size),Red_Stuned_A)
    instance_create((35*grid_size)+17,(19*grid_size),Red_Stuned_A)
    instance_create((34*grid_size),(19*grid_size),Red_Stuned_E)
    instance_create((34*grid_size)+17,(19*grid_size),Red_Stuned_E)
    instance_create((33*grid_size),(19*grid_size),Red_Stuned_K)
    instance_create((36*grid_size),(20*grid_size),Red_Stuned_S)
    instance_create((36*grid_size)+17,(20*grid_size),Red_Stuned_S)
}

// Level 20
if (global.levelnumber==20)
{
    // Black
    instance_create((1*grid_size),(1*grid_size),Black_Stuned_O)
    instance_create((1*grid_size)+17,(1*grid_size),Black_Stuned_O)
    instance_create((1*grid_size),(1*grid_size)+17,Black_Stuned_O)
    instance_create((2*grid_size),(1*grid_size),Black_Stuned_O)
    instance_create((2*grid_size)+17,(1*grid_size),Black_Stuned_O)
    instance_create((2*grid_size),(1*grid_size)+17,Black_Stuned_O)
    instance_create((3*grid_size),(1*grid_size),Black_Stuned_X)
    instance_create((3*grid_size)+17,(1*grid_size),Black_Stuned_X)
    instance_create((3*grid_size),(1*grid_size)+17,Black_Stuned_X)
    instance_create((1*grid_size),(2*grid_size),Black_Stuned_B)
    instance_create((1*grid_size)+17,(2*grid_size),Black_Stuned_R)
    instance_create((2*grid_size),(2*grid_size),Black_Stuned_Square)
    instance_create((2*grid_size)+17,(2*grid_size),Black_Stuned_Square)
    instance_create((3*grid_size),(2*grid_size),Black_Stuned_A)
    instance_create((3*grid_size)+17,(2*grid_size),Black_Stuned_A)
    instance_create((3*grid_size),(2*grid_size)+17,Black_Stuned_A)
    instance_create((1*grid_size),(3*grid_size),Black_Stuned_Triangle)
    instance_create((1*grid_size)+17,(3*grid_size),Black_Stuned_Triangle)
    instance_create((1*grid_size),(3*grid_size)+17,Black_Stuned_Triangle)
    instance_create((2*grid_size),(3*grid_size),Black_Stuned_E)
    instance_create((2*grid_size)+17,(3*grid_size),Black_Stuned_E)
    instance_create((3*grid_size),(3*grid_size),Black_Stuned_S)
    instance_create((3*grid_size)+17,(3*grid_size),Black_Stuned_S)
    // Red
    instance_create((36*grid_size),(1*grid_size),Red_Stuned_O)
    instance_create((36*grid_size)+17,(1*grid_size),Red_Stuned_O)
    instance_create((36*grid_size),(1*grid_size)+17,Red_Stuned_O)
    instance_create((35*grid_size),(1*grid_size),Red_Stuned_O)
    instance_create((35*grid_size)+17,(1*grid_size),Red_Stuned_O)
    instance_create((35*grid_size),(1*grid_size)+17,Red_Stuned_O)
    instance_create((34*grid_size),(1*grid_size),Red_Stuned_X)
    instance_create((34*grid_size)+17,(1*grid_size),Red_Stuned_X)
    instance_create((34*grid_size),(1*grid_size)+17,Red_Stuned_X)
    instance_create((36*grid_size),(2*grid_size),Red_Stuned_B)
    instance_create((36*grid_size)+17,(2*grid_size),Red_Stuned_R)
    instance_create((35*grid_size),(2*grid_size),Red_Stuned_Square)
    instance_create((35*grid_size)+17,(2*grid_size),Red_Stuned_Square)
    instance_create((34*grid_size),(2*grid_size),Red_Stuned_A)
    instance_create((34*grid_size)+17,(2*grid_size),Red_Stuned_A)
    instance_create((34*grid_size),(2*grid_size)+17,Red_Stuned_A)
    instance_create((36*grid_size),(3*grid_size),Red_Stuned_Triangle)
    instance_create((36*grid_size)+17,(3*grid_size),Red_Stuned_Triangle)
    instance_create((36*grid_size),(3*grid_size)+17,Red_Stuned_Triangle)
    instance_create((35*grid_size),(3*grid_size),Red_Stuned_E)
    instance_create((35*grid_size)+17,(3*grid_size),Red_Stuned_E)
    instance_create((34*grid_size),(3*grid_size),Red_Stuned_S)
    instance_create((34*grid_size)+17,(3*grid_size),Red_Stuned_S)
}

// Level 21
if (global.levelnumber==21)
{
    // Black
    instance_create(1*grid_size,20*grid_size,Black_Stuned_O)
    // Red
    instance_create(36*grid_size,1*grid_size,Red_Stuned_O)
}

// Level 22
if (global.levelnumber==22)
{
    // Black
    instance_create((1*grid_size),(18*grid_size),Black_Stuned_E)
    instance_create((1*grid_size)+17,(18*grid_size),Black_Stuned_E)
    instance_create((1*grid_size),(18*grid_size)+17,Black_Stuned_H)
    instance_create((2*grid_size),(18*grid_size),Black_Stuned_H)
    instance_create((2*grid_size)+17,(18*grid_size),Black_Stuned_R)
    instance_create((2*grid_size),(18*grid_size)+17,Black_Stuned_M)
    instance_create((1*grid_size),(19*grid_size),Black_Stuned_O)
    instance_create((1*grid_size)+17,(19*grid_size),Black_Stuned_O)
    instance_create((1*grid_size),(19*grid_size)+17,Black_Stuned_O)
    instance_create((2*grid_size),(19*grid_size),Black_Stuned_Square)
    instance_create((2*grid_size)+17,(19*grid_size),Black_Stuned_Square)
    instance_create((2*grid_size),(19*grid_size)+17,Black_Stuned_Square)
    instance_create((3*grid_size),(19*grid_size),Black_Stuned_Triangle)
    instance_create((3*grid_size)+17,(19*grid_size),Black_Stuned_Triangle)
    instance_create((3*grid_size),(19*grid_size)+17,Black_Stuned_Triangle)
    instance_create((1*grid_size),(20*grid_size),Black_Stuned_O)
    instance_create((1*grid_size)+17,(20*grid_size),Black_Stuned_O)
    instance_create((1*grid_size),(20*grid_size)+17,Black_Stuned_O)
    instance_create((2*grid_size),(20*grid_size),Black_Stuned_X)
    instance_create((2*grid_size)+17,(20*grid_size),Black_Stuned_X)
    instance_create((2*grid_size),(20*grid_size)+17,Black_Stuned_X)
    instance_create((3*grid_size),(20*grid_size),Black_Stuned_A)
    instance_create((3*grid_size)+17,(20*grid_size),Black_Stuned_A)
    instance_create((3*grid_size),(20*grid_size)+17,Black_Stuned_A)
    // Red
    instance_create((36*grid_size),(18*grid_size),Red_Stuned_E)
    instance_create((36*grid_size)+17,(18*grid_size),Red_Stuned_E)
    instance_create((36*grid_size),(18*grid_size)+17,Red_Stuned_H)
    instance_create((35*grid_size),(18*grid_size),Red_Stuned_H)
    instance_create((35*grid_size)+17,(18*grid_size),Red_Stuned_R)
    instance_create((35*grid_size),(18*grid_size)+17,Red_Stuned_M)
    instance_create((36*grid_size),(19*grid_size),Red_Stuned_O)
    instance_create((36*grid_size)+17,(19*grid_size),Red_Stuned_O)
    instance_create((36*grid_size),(19*grid_size)+17,Red_Stuned_O)
    instance_create((35*grid_size),(19*grid_size),Red_Stuned_Square)
    instance_create((35*grid_size)+17,(19*grid_size),Red_Stuned_Square)
    instance_create((35*grid_size),(19*grid_size)+17,Red_Stuned_Square)
    instance_create((34*grid_size),(19*grid_size),Red_Stuned_Triangle)
    instance_create((34*grid_size)+17,(19*grid_size),Red_Stuned_Triangle)
    instance_create((34*grid_size),(19*grid_size)+17,Red_Stuned_Triangle)
    instance_create((36*grid_size),(20*grid_size),Red_Stuned_O)
    instance_create((36*grid_size)+17,(20*grid_size),Red_Stuned_O)
    instance_create((36*grid_size),(20*grid_size)+17,Red_Stuned_O)
    instance_create((35*grid_size),(20*grid_size),Red_Stuned_X)
    instance_create((35*grid_size)+17,(20*grid_size),Red_Stuned_X)
    instance_create((35*grid_size),(20*grid_size)+17,Red_Stuned_X)
    instance_create((34*grid_size),(20*grid_size),Red_Stuned_A)
    instance_create((34*grid_size)+17,(20*grid_size),Red_Stuned_A)
    instance_create((34*grid_size),(20*grid_size)+17,Red_Stuned_A)
}

// Level 23
if (global.levelnumber==23)
{
    // Black
    instance_create((1*grid_size),(6*grid_size),Black_Stuned_S)
    instance_create((1*grid_size)+17,(6*grid_size),Black_Stuned_F)
    instance_create((1*grid_size),(7*grid_size),Black_Stuned_K)
    instance_create((1*grid_size)+17,(7*grid_size),Black_Stuned_B)
    instance_create((1*grid_size),(8*grid_size),Black_Stuned_Triangle)
    instance_create((1*grid_size)+17,(8*grid_size),Black_Stuned_Triangle)
    instance_create((1*grid_size),(9*grid_size),Black_Stuned_A)
    instance_create((1*grid_size)+17,(9*grid_size),Black_Stuned_A)
    instance_create((1*grid_size),(10*grid_size),Black_Stuned_O)
    instance_create((1*grid_size)+17,(10*grid_size),Black_Stuned_O)
    instance_create((1*grid_size),(11*grid_size),Black_Stuned_O)
    instance_create((1*grid_size)+17,(11*grid_size),Black_Stuned_O)
    instance_create((1*grid_size),(12*grid_size),Black_Stuned_X)
    instance_create((1*grid_size)+17,(12*grid_size),Black_Stuned_X)
    instance_create((1*grid_size),(13*grid_size),Black_Stuned_Square)
    instance_create((1*grid_size)+17,(13*grid_size),Black_Stuned_Square)
    instance_create((1*grid_size),(14*grid_size),Black_Stuned_H)
    instance_create((1*grid_size)+17,(14*grid_size),Black_Stuned_H)
    instance_create((1*grid_size),(15*grid_size),Black_Stuned_E)
    instance_create((1*grid_size)+17,(15*grid_size),Black_Stuned_E)
    instance_create((1*grid_size),(16*grid_size),Black_Stuned_M)
    // Red
    instance_create((36*grid_size),(6*grid_size),Red_Stuned_S)
    instance_create((36*grid_size)+17,(6*grid_size),Red_Stuned_F)
    instance_create((36*grid_size),(7*grid_size),Red_Stuned_K)
    instance_create((36*grid_size)+17,(7*grid_size),Red_Stuned_B)
    instance_create((36*grid_size),(8*grid_size),Red_Stuned_Triangle)
    instance_create((36*grid_size)+17,(8*grid_size),Red_Stuned_Triangle)
    instance_create((36*grid_size),(9*grid_size),Red_Stuned_A)
    instance_create((36*grid_size)+17,(9*grid_size),Red_Stuned_A)
    instance_create((36*grid_size),(10*grid_size),Red_Stuned_O)
    instance_create((36*grid_size)+17,(10*grid_size),Red_Stuned_O)
    instance_create((36*grid_size),(11*grid_size),Red_Stuned_O)
    instance_create((36*grid_size)+17,(11*grid_size),Red_Stuned_O)
    instance_create((36*grid_size),(12*grid_size),Red_Stuned_X)
    instance_create((36*grid_size)+17,(12*grid_size),Red_Stuned_X)
    instance_create((36*grid_size),(13*grid_size),Red_Stuned_Square)
    instance_create((36*grid_size)+17,(13*grid_size),Red_Stuned_Square)
    instance_create((36*grid_size),(14*grid_size),Red_Stuned_H)
    instance_create((36*grid_size)+17,(14*grid_size),Red_Stuned_H)
    instance_create((36*grid_size),(15*grid_size),Red_Stuned_E)
    instance_create((36*grid_size)+17,(15*grid_size),Red_Stuned_E)
    instance_create((36*grid_size),(16*grid_size),Red_Stuned_M)
}

// Level 25
if (global.levelnumber==25)
{
    // Black
    instance_create((1*grid_size),(18*grid_size),Black_Stuned_A)
    instance_create((1*grid_size)+17,(18*grid_size),Black_Stuned_A)
    instance_create((1*grid_size),(18*grid_size)+17,Black_Stuned_S)
    instance_create((2*grid_size),(18*grid_size),Black_Stuned_K)
    instance_create((2*grid_size)+17,(18*grid_size),Black_Stuned_B)
    instance_create((2*grid_size),(18*grid_size)+17,Black_Stuned_M)
    instance_create((3*grid_size),(18*grid_size),Black_Stuned_Square)
    instance_create((3*grid_size)+17,(18*grid_size),Black_Stuned_M)
    instance_create((1*grid_size),(19*grid_size),Black_Stuned_O)
    instance_create((1*grid_size)+17,(19*grid_size),Black_Stuned_O)
    instance_create((1*grid_size),(19*grid_size)+17,Black_Stuned_O)
    instance_create((2*grid_size),(19*grid_size),Black_Stuned_X)
    instance_create((2*grid_size)+17,(19*grid_size),Black_Stuned_X)
    instance_create((2*grid_size),(19*grid_size)+17,Black_Stuned_H)
    instance_create((3*grid_size),(19*grid_size),Black_Stuned_E)
    instance_create((3*grid_size)+17,(19*grid_size),Black_Stuned_E)
    instance_create((3*grid_size),(19*grid_size)+17,Black_Stuned_Square)
    instance_create((1*grid_size),(20*grid_size),Black_Stuned_G)
    instance_create((2*grid_size),(20*grid_size),Black_Stuned_O)
    instance_create((2*grid_size)+17,(20*grid_size),Black_Stuned_O)
    instance_create((2*grid_size),(20*grid_size)+17,Black_Stuned_O)
    instance_create((3*grid_size),(20*grid_size),Black_Stuned_Triangle)
    instance_create((3*grid_size)+17,(20*grid_size),Black_Stuned_Triangle)
    instance_create((3*grid_size),(20*grid_size)+17,Black_Stuned_F)
    // Red
    instance_create((36*grid_size),(18*grid_size),Red_Stuned_A)
    instance_create((36*grid_size)+17,(18*grid_size),Red_Stuned_A)
    instance_create((36*grid_size),(18*grid_size)+17,Red_Stuned_S)
    instance_create((35*grid_size),(18*grid_size),Red_Stuned_K)
    instance_create((35*grid_size)+17,(18*grid_size),Red_Stuned_B)
    instance_create((35*grid_size),(18*grid_size)+17,Red_Stuned_M)
    instance_create((34*grid_size),(18*grid_size),Red_Stuned_Square)
    instance_create((34*grid_size)+17,(18*grid_size),Red_Stuned_M)
    instance_create((36*grid_size),(19*grid_size),Red_Stuned_O)
    instance_create((36*grid_size)+17,(19*grid_size),Red_Stuned_O)
    instance_create((36*grid_size),(19*grid_size)+17,Red_Stuned_O)
    instance_create((35*grid_size),(19*grid_size),Red_Stuned_X)
    instance_create((35*grid_size)+17,(19*grid_size),Red_Stuned_X)
    instance_create((35*grid_size),(19*grid_size)+17,Red_Stuned_H)
    instance_create((34*grid_size),(19*grid_size),Red_Stuned_E)
    instance_create((34*grid_size)+17,(19*grid_size),Red_Stuned_E)
    instance_create((34*grid_size),(19*grid_size)+17,Red_Stuned_Square)
    instance_create((36*grid_size),(20*grid_size),Red_Stuned_G)
    instance_create((35*grid_size),(20*grid_size),Red_Stuned_O)
    instance_create((35*grid_size)+17,(20*grid_size),Red_Stuned_O)
    instance_create((35*grid_size),(20*grid_size)+17,Red_Stuned_O)
    instance_create((34*grid_size),(20*grid_size),Red_Stuned_Triangle)
    instance_create((34*grid_size)+17,(20*grid_size),Red_Stuned_Triangle)
    instance_create((34*grid_size),(20*grid_size)+17,Red_Stuned_F)
}

// Level 26
if (global.levelnumber==26)
{
    // Black
    instance_create((1*grid_size),(18*grid_size),Black_Stuned_X)
    instance_create((1*grid_size)+17,(18*grid_size),Black_Stuned_X)
    instance_create((1*grid_size),(18*grid_size)+17,Black_Stuned_X)
    instance_create((2*grid_size),(18*grid_size),Black_Stuned_H)
    instance_create((2*grid_size)+17,(18*grid_size),Black_Stuned_H)
    instance_create((3*grid_size),(18*grid_size),Black_Stuned_A)
    instance_create((3*grid_size)+17,(18*grid_size),Black_Stuned_A)
    instance_create((3*grid_size),(18*grid_size)+17,Black_Stuned_A)
    instance_create((1*grid_size),(19*grid_size),Black_Stuned_O)
    instance_create((1*grid_size)+17,(19*grid_size),Black_Stuned_O)
    instance_create((1*grid_size),(19*grid_size)+17,Black_Stuned_O)
    instance_create((2*grid_size),(19*grid_size),Black_Stuned_Square)
    instance_create((2*grid_size)+17,(19*grid_size),Black_Stuned_Square)
    instance_create((3*grid_size),(19*grid_size),Black_Stuned_F)
    instance_create((3*grid_size)+17,(19*grid_size),Black_Stuned_R)
    instance_create((1*grid_size),(20*grid_size),Black_Stuned_O)
    instance_create((1*grid_size)+17,(20*grid_size),Black_Stuned_O)
    instance_create((1*grid_size),(20*grid_size)+17,Black_Stuned_O)
    instance_create((2*grid_size),(20*grid_size),Black_Stuned_Triangle)
    instance_create((2*grid_size)+17,(20*grid_size),Black_Stuned_Triangle)
    instance_create((2*grid_size),(20*grid_size)+17,Black_Stuned_Triangle)
    instance_create((3*grid_size),(20*grid_size),Black_Stuned_S)
    instance_create((3*grid_size)+17,(20*grid_size),Black_Stuned_S)
    // Red
    instance_create((36*grid_size),(18*grid_size),Red_Stuned_X)
    instance_create((36*grid_size)+17,(18*grid_size),Red_Stuned_X)
    instance_create((36*grid_size),(18*grid_size)+17,Red_Stuned_X)
    instance_create((35*grid_size),(18*grid_size),Red_Stuned_H)
    instance_create((35*grid_size)+17,(18*grid_size),Red_Stuned_H)
    instance_create((34*grid_size),(18*grid_size),Red_Stuned_A)
    instance_create((34*grid_size)+17,(18*grid_size),Red_Stuned_A)
    instance_create((34*grid_size),(18*grid_size)+17,Red_Stuned_A)
    instance_create((36*grid_size),(19*grid_size),Red_Stuned_O)
    instance_create((36*grid_size)+17,(19*grid_size),Red_Stuned_O)
    instance_create((36*grid_size),(19*grid_size)+17,Red_Stuned_O)
    instance_create((35*grid_size),(19*grid_size),Red_Stuned_Square)
    instance_create((35*grid_size)+17,(19*grid_size),Red_Stuned_Square)
    instance_create((34*grid_size),(19*grid_size),Red_Stuned_F)
    instance_create((34*grid_size)+17,(19*grid_size),Red_Stuned_R)
    instance_create((36*grid_size),(20*grid_size),Red_Stuned_O)
    instance_create((36*grid_size)+17,(20*grid_size),Red_Stuned_O)
    instance_create((36*grid_size),(20*grid_size)+17,Red_Stuned_O)
    instance_create((35*grid_size),(20*grid_size),Red_Stuned_Triangle)
    instance_create((35*grid_size)+17,(20*grid_size),Red_Stuned_Triangle)
    instance_create((35*grid_size),(20*grid_size)+17,Red_Stuned_Triangle)
    instance_create((34*grid_size),(20*grid_size),Red_Stuned_S)
    instance_create((34*grid_size)+17,(20*grid_size),Red_Stuned_S)
}

// Level 27
if (global.levelnumber==27)
{
    // Black
    instance_create((1*grid_size),17*grid_size,Black_Stuned_B); instance_create((1*grid_size)+17,17*grid_size,Black_Stuned_K)
    instance_create((1*grid_size),18*grid_size,Black_Stuned_H); instance_create((1*grid_size)+17,18*grid_size,Black_Stuned_H)
    instance_create((2*grid_size),18*grid_size,Black_Stuned_E); instance_create((2*grid_size)+17,18*grid_size,Black_Stuned_E)
    instance_create((3*grid_size),18*grid_size,Black_Stuned_M); instance_create((3*grid_size)+17,18*grid_size,Black_Stuned_M)
    instance_create((4*grid_size),18*grid_size,Black_Stuned_S); instance_create((4*grid_size)+17,18*grid_size,Black_Stuned_S)
    instance_create((1*grid_size),(19*grid_size),Black_Stuned_X); instance_create((1*grid_size)+17,19*grid_size,Black_Stuned_X); instance_create((1*grid_size),(19*grid_size)+17,Black_Stuned_X)
    instance_create((2*grid_size),(19*grid_size),Black_Stuned_A); instance_create((2*grid_size)+17,19*grid_size,Black_Stuned_A); instance_create((2*grid_size),(19*grid_size)+17,Black_Stuned_A)
    instance_create((3*grid_size),(19*grid_size),Black_Stuned_Triangle); instance_create((3*grid_size)+17,19*grid_size,Black_Stuned_Triangle); instance_create((3*grid_size),(19*grid_size)+17,Black_Stuned_Triangle)
    instance_create((4*grid_size),(19*grid_size),Black_Stuned_Square); instance_create((4*grid_size)+17,19*grid_size,Black_Stuned_Square)
    instance_create((1*grid_size),(20*grid_size),Black_Stuned_G)
    instance_create((2*grid_size),(20*grid_size),Black_Stuned_C); instance_create((2*grid_size)+17,(20*grid_size),Black_Stuned_F); instance_create((2*grid_size),(20*grid_size)+17,Black_Stuned_R)
    instance_create((3*grid_size),(20*grid_size),Black_Stuned_O); instance_create((3*grid_size)+17,(20*grid_size),Black_Stuned_O); instance_create((3*grid_size),(20*grid_size)+17,Black_Stuned_O)
    instance_create((4*grid_size),(20*grid_size),Black_Stuned_O); instance_create((4*grid_size)+17,(20*grid_size),Black_Stuned_O); instance_create((4*grid_size),(20*grid_size)+17,Black_Stuned_O)
    // Red
    instance_create((36*grid_size),17*grid_size,Red_Stuned_B); instance_create((36*grid_size)+17,17*grid_size,Red_Stuned_K)
    instance_create((36*grid_size),18*grid_size,Red_Stuned_H); instance_create((36*grid_size)+17,18*grid_size,Red_Stuned_H)
    instance_create((35*grid_size),18*grid_size,Red_Stuned_E); instance_create((35*grid_size)+17,18*grid_size,Red_Stuned_E)
    instance_create((34*grid_size),18*grid_size,Red_Stuned_M); instance_create((34*grid_size)+17,18*grid_size,Red_Stuned_M)
    instance_create((33*grid_size),18*grid_size,Red_Stuned_S); instance_create((33*grid_size)+17,18*grid_size,Red_Stuned_S)
    instance_create((36*grid_size),(19*grid_size),Red_Stuned_X); instance_create((36*grid_size)+17,19*grid_size,Red_Stuned_X); instance_create((36*grid_size),(19*grid_size)+17,Red_Stuned_X)
    instance_create((35*grid_size),(19*grid_size),Red_Stuned_A); instance_create((35*grid_size)+17,19*grid_size,Red_Stuned_A); instance_create((35*grid_size),(19*grid_size)+17,Red_Stuned_A)
    instance_create((34*grid_size),(19*grid_size),Red_Stuned_Triangle); instance_create((34*grid_size)+17,19*grid_size,Red_Stuned_Triangle); instance_create((34*grid_size),(19*grid_size)+17,Red_Stuned_Triangle)
    instance_create((33*grid_size),(19*grid_size),Red_Stuned_Square); instance_create((33*grid_size)+17,19*grid_size,Red_Stuned_Square)
    instance_create((36*grid_size),(20*grid_size),Red_Stuned_G)
    instance_create((35*grid_size),(20*grid_size),Red_Stuned_C); instance_create((35*grid_size)+17,(20*grid_size),Red_Stuned_F); instance_create((35*grid_size),(20*grid_size)+17,Red_Stuned_R)
    instance_create((34*grid_size),(20*grid_size),Red_Stuned_O); instance_create((34*grid_size)+17,(20*grid_size),Red_Stuned_O); instance_create((34*grid_size),(20*grid_size)+17,Red_Stuned_O)
    instance_create((33*grid_size),(20*grid_size),Red_Stuned_O); instance_create((33*grid_size)+17,(20*grid_size),Red_Stuned_O); instance_create((33*grid_size),(20*grid_size)+17,Red_Stuned_O)
}

// Level 28
if (global.levelnumber==28)
{
    // Black
    instance_create((1*grid_size),(17*grid_size),Black_Stuned_O); instance_create((1*grid_size)+17,(17*grid_size),Black_Stuned_O); instance_create((1*grid_size),(17*grid_size)+17,Black_Stuned_O);
    instance_create((2*grid_size),(17*grid_size),Black_Stuned_O); instance_create((2*grid_size)+17,(17*grid_size),Black_Stuned_O); instance_create((2*grid_size),(17*grid_size)+17,Black_Stuned_O);
    instance_create((3*grid_size),(17*grid_size),Black_Stuned_A); instance_create((3*grid_size)+17,(17*grid_size),Black_Stuned_A); 
    instance_create((1*grid_size),(18*grid_size),Black_Stuned_X); instance_create((1*grid_size)+17,(18*grid_size),Black_Stuned_X); instance_create((1*grid_size),(18*grid_size)+17,Black_Stuned_X);
    instance_create((2*grid_size),(18*grid_size),Black_Stuned_Triangle); instance_create((2*grid_size)+17,(18*grid_size),Black_Stuned_Triangle); instance_create((2*grid_size),(18*grid_size)+17,Black_Stuned_Triangle);
    instance_create((3*grid_size),(18*grid_size),Black_Stuned_S); instance_create((3*grid_size)+17,(18*grid_size),Black_Stuned_S); 
    instance_create((1*grid_size),(19*grid_size),Black_Stuned_R); instance_create((1*grid_size)+17,(19*grid_size),Black_Stuned_F); instance_create((1*grid_size),(19*grid_size)+17,Black_Stuned_C);
    instance_create((2*grid_size),(19*grid_size),Black_Stuned_S); instance_create((2*grid_size)+17,(19*grid_size),Black_Stuned_Square); 
    instance_create((3*grid_size),(19*grid_size),Black_Stuned_K); instance_create((3*grid_size)+17,(19*grid_size),Black_Stuned_B); instance_create((3*grid_size),(19*grid_size)+17,Black_Stuned_M);
    instance_create((1*grid_size),(20*grid_size),Black_Stuned_G);
    instance_create((2*grid_size),(20*grid_size),Black_Stuned_H); instance_create((2*grid_size)+17,(20*grid_size),Black_Stuned_H); 
    instance_create((3*grid_size),(20*grid_size),Black_Stuned_M); instance_create((3*grid_size)+17,(20*grid_size),Black_Stuned_E);
    // Red
    instance_create((36*grid_size),(17*grid_size),Red_Stuned_O); instance_create((36*grid_size)+17,(17*grid_size),Red_Stuned_O); instance_create((36*grid_size),(17*grid_size)+17,Red_Stuned_O);
    instance_create((35*grid_size),(17*grid_size),Red_Stuned_O); instance_create((35*grid_size)+17,(17*grid_size),Red_Stuned_O); instance_create((35*grid_size),(17*grid_size)+17,Red_Stuned_O);
    instance_create((34*grid_size),(17*grid_size),Red_Stuned_A); instance_create((34*grid_size)+17,(17*grid_size),Red_Stuned_A); 
    instance_create((36*grid_size),(18*grid_size),Red_Stuned_X); instance_create((36*grid_size)+17,(18*grid_size),Red_Stuned_X); instance_create((36*grid_size),(18*grid_size)+17,Red_Stuned_X);
    instance_create((35*grid_size),(18*grid_size),Red_Stuned_Triangle); instance_create((35*grid_size)+17,(18*grid_size),Red_Stuned_Triangle); instance_create((35*grid_size),(18*grid_size)+17,Red_Stuned_Triangle);
    instance_create((34*grid_size),(18*grid_size),Red_Stuned_S); instance_create((34*grid_size)+17,(18*grid_size),Red_Stuned_S); 
    instance_create((36*grid_size),(19*grid_size),Red_Stuned_R); instance_create((36*grid_size)+17,(19*grid_size),Red_Stuned_F); instance_create((36*grid_size),(19*grid_size)+17,Red_Stuned_C);
    instance_create((35*grid_size),(19*grid_size),Red_Stuned_S); instance_create((35*grid_size)+17,(19*grid_size),Red_Stuned_Square); 
    instance_create((34*grid_size),(19*grid_size),Red_Stuned_K); instance_create((34*grid_size)+17,(19*grid_size),Red_Stuned_B); instance_create((34*grid_size),(19*grid_size)+17,Red_Stuned_M);
    instance_create((36*grid_size),(20*grid_size),Red_Stuned_G);
    instance_create((35*grid_size),(20*grid_size),Red_Stuned_H); instance_create((35*grid_size)+17,(20*grid_size),Red_Stuned_H); 
    instance_create((34*grid_size),(20*grid_size),Red_Stuned_M); instance_create((34*grid_size)+17,(20*grid_size),Red_Stuned_E);
}
#define Double_Boxing_Create
// Double_Boxing_Create
// Stefan Grace
// Created: 2016-07-09
// Modifed: 2018-04-16
// This script creates Double Boxing in the correct place when the room starts

// Test Level 7
if (global.levelnumber==-7)
{
    // Double_Boxing
    instance_create(630,420,Double_Boxing)
    instance_create(665,420,Double_Boxing)
    instance_create(630,455,Double_Boxing)
    instance_create(665,455,Double_Boxing)
    instance_create(630,490,Double_Boxing)
    instance_create(945,595,Double_Boxing)
    instance_create(980,595,Double_Boxing)
    instance_create(1015,595,Double_Boxing)
    instance_create(1050,595,Double_Boxing)
    instance_create(945,630,Double_Boxing)
    instance_create(980,630,Double_Boxing)
    instance_create(1015,630,Double_Boxing)
    instance_create(1050,630,Double_Boxing)
    instance_create(945,665,Double_Boxing)
    instance_create(980,665,Double_Boxing)
    instance_create(1015,665,Double_Boxing)
    instance_create(1050,665,Double_Boxing)
    // Double_Boxing_Yellow
    instance_create(1050,665,Double_Boxing_Yellow)
    instance_create(1050+18,665,Double_Boxing_Yellow)
    instance_create(1050,665+18,Double_Boxing_Yellow)
    instance_create(1050+18,665+18,Double_Boxing_Yellow)
    instance_create(945,595,Double_Boxing_Yellow)
    instance_create(945+18,595,Double_Boxing_Yellow)
    instance_create(945,595+18,Double_Boxing_Yellow)
    instance_create(945+18,595+18,Double_Boxing_Yellow)
    // Double_Boxing_Rock
    instance_create(630,420,Double_Boxing_Rock)
    instance_create(630+18,420,Double_Boxing_Rock)
    instance_create(630,420+18,Double_Boxing_Rock)
    instance_create(630+18,420+18,Double_Boxing_Rock)
    instance_create(665,420,Double_Boxing_Rock)
    instance_create(665+18,420,Double_Boxing_Rock)
    instance_create(665,420+18,Double_Boxing_Rock)
    instance_create(665+18,420+18,Double_Boxing_Rock)
    instance_create(630,455,Double_Boxing_Rock)
    instance_create(630+18,455,Double_Boxing_Rock)
    instance_create(630,455+18,Double_Boxing_Rock)
    instance_create(630+18,455+18,Double_Boxing_Rock)
    instance_create(665,455,Double_Boxing_Rock)
    instance_create(665+18,455,Double_Boxing_Rock)
    instance_create(665,455+18,Double_Boxing_Rock)
    instance_create(665+18,455+18,Double_Boxing_Rock)
    instance_create(630,490,Double_Boxing_Rock)
    instance_create(630+18,490,Double_Boxing_Rock)
    instance_create(630,490+18,Double_Boxing_Rock)
    instance_create(630+18,490+18,Double_Boxing_Rock)
    instance_create(980,595,Double_Boxing_Rock)
    instance_create(980+18,595,Double_Boxing_Rock)
    instance_create(980,595+18,Double_Boxing_Rock)
    instance_create(980+18,595+18,Double_Boxing_Rock)
    instance_create(1015,595,Double_Boxing_Rock)
    instance_create(1015+18,595,Double_Boxing_Rock)
    instance_create(1015,595+18,Double_Boxing_Rock)
    instance_create(1015+18,595+18,Double_Boxing_Rock)
    instance_create(945,630,Double_Boxing_Rock)
    instance_create(945+18,630,Double_Boxing_Rock)
    instance_create(945,630+18,Double_Boxing_Rock)
    instance_create(945+18,630+18,Double_Boxing_Rock)
    instance_create(980,630,Double_Boxing_Rock)
    instance_create(980+18,630,Double_Boxing_Rock)
    instance_create(980,630+18,Double_Boxing_Rock)
    instance_create(980+18,630+18,Double_Boxing_Rock)
    instance_create(1015,630,Double_Boxing_Rock)
    instance_create(1015+18,630,Double_Boxing_Rock)
    instance_create(1015,630+18,Double_Boxing_Rock)
    instance_create(1015+18,630+18,Double_Boxing_Rock)
    instance_create(1050,630,Double_Boxing_Rock)
    instance_create(1050+18,630,Double_Boxing_Rock)
    instance_create(1050,630+18,Double_Boxing_Rock)
    instance_create(1050+18,630+18,Double_Boxing_Rock)
    instance_create(980,665,Double_Boxing_Rock)
    instance_create(980+18,665,Double_Boxing_Rock)
    instance_create(980,665+18,Double_Boxing_Rock)
    instance_create(980+18,665+18,Double_Boxing_Rock)
    instance_create(1015,665,Double_Boxing_Rock)
    instance_create(1015+18,665,Double_Boxing_Rock)
    instance_create(1015,665+18,Double_Boxing_Rock)
    instance_create(1015+18,665+18,Double_Boxing_Rock)
    // Double_Boxing_Dimond
    instance_create(1050,595,Double_Boxing_Dimond)
    instance_create(1050+18,595,Double_Boxing_Dimond)
    instance_create(1050,595+18,Double_Boxing_Dimond)
    instance_create(1050+18,595+18,Double_Boxing_Dimond)
}

// Test Level 9
if (global.levelnumber==-9)
{
    instance_create(15*grid_size,15*grid_size,Double_Boxing)
    instance_create(15*grid_size,15*grid_size,Double_Boxing_Yellow)
    instance_create((15*grid_size)+18,15*grid_size,Double_Boxing_Yellow)
    instance_create(15*grid_size,(15*grid_size)+18,Double_Boxing_Yellow)
    instance_create((15*grid_size)+18,(15*grid_size)+18,Double_Boxing_Yellow)
}

// Level 17
if (global.levelnumber==17)
{
    // Double_Boxing
    //instance_create(630,35,Double_Boxing)
    instance_create(630,70,Double_Boxing)
    instance_create(630,105,Double_Boxing)
    instance_create(630,140,Double_Boxing)
    instance_create(630,175,Double_Boxing)
    instance_create(630,210,Double_Boxing)
    instance_create(630,245,Double_Boxing)
    instance_create(630,280,Double_Boxing)
    instance_create(630,315,Double_Boxing)
    instance_create(630,350,Double_Boxing)
    instance_create(630,385,Double_Boxing)
    instance_create(630,420,Double_Boxing)
    instance_create(630,455,Double_Boxing)
    instance_create(630,490,Double_Boxing)
    instance_create(630,525,Double_Boxing)
    instance_create(630,560,Double_Boxing)
    instance_create(630,595,Double_Boxing)
    instance_create(630,630,Double_Boxing)
    instance_create(630,665,Double_Boxing)
    instance_create(630,700,Double_Boxing)
    // Double_Boxing_Rock
    //instance_create(630,35,Double_Boxing_Rock)
    instance_create(630,70,Double_Boxing_Rock)
    instance_create(630,105,Double_Boxing_Rock)
    instance_create(630,140,Double_Boxing_Rock)
    instance_create(630,175,Double_Boxing_Rock)
    instance_create(630,210,Double_Boxing_Rock)
    instance_create(630,245,Double_Boxing_Rock)
    instance_create(630,280,Double_Boxing_Rock)
    instance_create(630,315,Double_Boxing_Rock)
    instance_create(630,350,Double_Boxing_Rock)
    instance_create(630,385,Double_Boxing_Rock)
    instance_create(630,420,Double_Boxing_Rock)
    instance_create(630,455,Double_Boxing_Rock)
    instance_create(630,490,Double_Boxing_Rock)
    instance_create(630,525,Double_Boxing_Rock)
    instance_create(630,560,Double_Boxing_Rock)
    instance_create(630,595,Double_Boxing_Rock)
    instance_create(630,630,Double_Boxing_Rock)
    instance_create(630,665,Double_Boxing_Rock)
    instance_create(630,700,Double_Boxing_Rock)
    //instance_create(630+18,35,Double_Boxing_Rock)
    instance_create(630+18,70,Double_Boxing_Rock)
    instance_create(630+18,105,Double_Boxing_Rock)
    instance_create(630+18,140,Double_Boxing_Rock)
    instance_create(630+18,175,Double_Boxing_Rock)
    instance_create(630+18,210,Double_Boxing_Rock)
    instance_create(630+18,245,Double_Boxing_Rock)
    instance_create(630+18,280,Double_Boxing_Rock)
    instance_create(630+18,315,Double_Boxing_Rock)
    instance_create(630+18,350,Double_Boxing_Rock)
    instance_create(630+18,385,Double_Boxing_Rock)
    instance_create(630+18,420,Double_Boxing_Rock)
    instance_create(630+18,455,Double_Boxing_Rock)
    instance_create(630+18,490,Double_Boxing_Rock)
    instance_create(630+18,525,Double_Boxing_Rock)
    instance_create(630+18,560,Double_Boxing_Rock)
    instance_create(630+18,595,Double_Boxing_Rock)
    instance_create(630+18,630,Double_Boxing_Rock)
    instance_create(630+18,665,Double_Boxing_Rock)
    instance_create(630+18,700,Double_Boxing_Rock)
    //instance_create(630,35+18,Double_Boxing_Rock)
    instance_create(630,70+18,Double_Boxing_Rock)
    instance_create(630,105+18,Double_Boxing_Rock)
    instance_create(630,140+18,Double_Boxing_Rock)
    instance_create(630,175+18,Double_Boxing_Rock)
    instance_create(630,210+18,Double_Boxing_Rock)
    instance_create(630,245+18,Double_Boxing_Rock)
    instance_create(630,280+18,Double_Boxing_Rock)
    instance_create(630,315+18,Double_Boxing_Rock)
    instance_create(630,350+18,Double_Boxing_Rock)
    instance_create(630,385+18,Double_Boxing_Rock)
    instance_create(630,420+18,Double_Boxing_Rock)
    instance_create(630,455+18,Double_Boxing_Rock)
    instance_create(630,490+18,Double_Boxing_Rock)
    instance_create(630,525+18,Double_Boxing_Rock)
    instance_create(630,560+18,Double_Boxing_Rock)
    instance_create(630,595+18,Double_Boxing_Rock)
    instance_create(630,630+18,Double_Boxing_Rock)
    instance_create(630,665+18,Double_Boxing_Rock)
    instance_create(630,700+18,Double_Boxing_Rock)
    //instance_create(630+18,35+18,Double_Boxing_Rock)
    instance_create(630+18,70+18,Double_Boxing_Rock)
    instance_create(630+18,105+18,Double_Boxing_Rock)
    instance_create(630+18,140+18,Double_Boxing_Rock)
    instance_create(630+18,175+18,Double_Boxing_Rock)
    instance_create(630+18,210+18,Double_Boxing_Rock)
    instance_create(630+18,245+18,Double_Boxing_Rock)
    instance_create(630+18,280+18,Double_Boxing_Rock)
    instance_create(630+18,315+18,Double_Boxing_Rock)
    instance_create(630+18,350+18,Double_Boxing_Rock)
    instance_create(630+18,385+18,Double_Boxing_Rock)
    instance_create(630+18,420+18,Double_Boxing_Rock)
    instance_create(630+18,455+18,Double_Boxing_Rock)
    instance_create(630+18,490+18,Double_Boxing_Rock)
    instance_create(630+18,525+18,Double_Boxing_Rock)
    instance_create(630+18,560+18,Double_Boxing_Rock)
    instance_create(630+18,595+18,Double_Boxing_Rock)
    instance_create(630+18,630+18,Double_Boxing_Rock)
    instance_create(630+18,665+18,Double_Boxing_Rock)
    instance_create(630+18,700+18,Double_Boxing_Rock)
}

// Level 20
if (global.levelnumber==20)
{
    var x_place;
    var y_place;
    // Strip of double boxing with dimond along the bottom
    x_place = 2
    repeat (34)
    {
        instance_create(x_place*grid_size,19*grid_size,Double_Boxing)
        instance_create(x_place*grid_size,19*grid_size,Double_Boxing_Dimond)
        instance_create((x_place*grid_size)+18,19*grid_size,Double_Boxing_Dimond)
        instance_create(x_place*grid_size,(19*grid_size)+18,Double_Boxing_Dimond)
        instance_create((x_place*grid_size)+18,(19*grid_size)+18,Double_Boxing_Dimond)
        x_place += 1
    }
    // Double strip of double boxing with dimond down the middle
    y_place = 1
    repeat (15)
    {
        instance_create((18*grid_size),(y_place*grid_size),Double_Boxing)
        instance_create((18*grid_size),(y_place*grid_size),Double_Boxing_Dimond)
        instance_create((18*grid_size)+18,(y_place*grid_size),Double_Boxing_Dimond)
        instance_create((18*grid_size),(y_place*grid_size)+18,Double_Boxing_Dimond)
        instance_create((18*grid_size)+18,(y_place*grid_size)+18,Double_Boxing_Dimond)
        instance_create((19*grid_size),(y_place*grid_size),Double_Boxing)
        instance_create((19*grid_size),(y_place*grid_size),Double_Boxing_Dimond)
        instance_create((19*grid_size)+18,(y_place*grid_size),Double_Boxing_Dimond)
        instance_create((19*grid_size),(y_place*grid_size)+18,Double_Boxing_Dimond)
        instance_create((19*grid_size)+18,(y_place*grid_size)+18,Double_Boxing_Dimond)
        y_place += 1
    }
    // Small double strip (2x3) of double boxing with rock down the middle
    y_place = 16
    repeat (3)
    {
        instance_create((18*grid_size),(y_place*grid_size),Double_Boxing)
        instance_create((18*grid_size),(y_place*grid_size),Double_Boxing_Rock)
        instance_create((18*grid_size)+18,(y_place*grid_size),Double_Boxing_Rock)
        instance_create((18*grid_size),(y_place*grid_size)+18,Double_Boxing_Rock)
        instance_create((18*grid_size)+18,(y_place*grid_size)+18,Double_Boxing_Rock)
        instance_create((19*grid_size),(y_place*grid_size),Double_Boxing)
        instance_create((19*grid_size),(y_place*grid_size),Double_Boxing_Rock)
        instance_create((19*grid_size)+18,(y_place*grid_size),Double_Boxing_Rock)
        instance_create((19*grid_size),(y_place*grid_size)+18,Double_Boxing_Rock)
        instance_create((19*grid_size)+18,(y_place*grid_size)+18,Double_Boxing_Rock)
        y_place += 1
    }
    // Double boxing strip down the sides with dimond
    y_place = 8
    repeat (5)
    {
        instance_create((14*grid_size),(y_place*grid_size),Double_Boxing)
        instance_create((14*grid_size),(y_place*grid_size),Double_Boxing_Dimond)
        instance_create((14*grid_size)+18,(y_place*grid_size),Double_Boxing_Dimond)
        instance_create((14*grid_size),(y_place*grid_size)+18,Double_Boxing_Dimond)
        instance_create((14*grid_size)+18,(y_place*grid_size)+18,Double_Boxing_Dimond)
        instance_create((23*grid_size),(y_place*grid_size),Double_Boxing)
        instance_create((23*grid_size),(y_place*grid_size),Double_Boxing_Dimond)
        instance_create((23*grid_size)+18,(y_place*grid_size),Double_Boxing_Dimond)
        instance_create((23*grid_size),(y_place*grid_size)+18,Double_Boxing_Dimond)
        instance_create((23*grid_size)+18,(y_place*grid_size)+18,Double_Boxing_Dimond)
        y_place += 1
    }
    // Double boxing at the middle bottom with dimond
    instance_create((15*grid_size),(12*grid_size),Double_Boxing)
    instance_create((15*grid_size),(12*grid_size),Double_Boxing_Dimond)
    instance_create((15*grid_size)+18,(12*grid_size),Double_Boxing_Dimond)
    instance_create((15*grid_size),(12*grid_size)+18,Double_Boxing_Dimond)
    instance_create((15*grid_size)+18,(12*grid_size)+18,Double_Boxing_Dimond)
    instance_create((16*grid_size),(12*grid_size),Double_Boxing)
    instance_create((16*grid_size),(12*grid_size),Double_Boxing_Dimond)
    instance_create((16*grid_size)+18,(12*grid_size),Double_Boxing_Dimond)
    instance_create((16*grid_size),(12*grid_size)+18,Double_Boxing_Dimond)
    instance_create((16*grid_size)+18,(12*grid_size)+18,Double_Boxing_Dimond)
    instance_create((21*grid_size),(12*grid_size),Double_Boxing)
    instance_create((21*grid_size),(12*grid_size),Double_Boxing_Dimond)
    instance_create((21*grid_size)+18,(12*grid_size),Double_Boxing_Dimond)
    instance_create((21*grid_size),(12*grid_size)+18,Double_Boxing_Dimond)
    instance_create((21*grid_size)+18,(12*grid_size)+18,Double_Boxing_Dimond)
    instance_create((22*grid_size),(12*grid_size),Double_Boxing)
    instance_create((22*grid_size),(12*grid_size),Double_Boxing_Dimond)
    instance_create((22*grid_size)+18,(12*grid_size),Double_Boxing_Dimond)
    instance_create((22*grid_size),(12*grid_size)+18,Double_Boxing_Dimond)
    instance_create((22*grid_size)+18,(12*grid_size)+18,Double_Boxing_Dimond)
    // Double boxing at the middle top with dimond and yellow
    instance_create((15*grid_size),(8*grid_size),Double_Boxing)
    instance_create((15*grid_size),(8*grid_size),Double_Boxing_Dimond)
    instance_create((15*grid_size)+18,(8*grid_size),Double_Boxing_Dimond)
    instance_create((15*grid_size),(8*grid_size)+18,Double_Boxing_Dimond)
    instance_create((15*grid_size)+18,(8*grid_size)+18,Double_Boxing_Dimond)
    instance_create((16*grid_size),(8*grid_size),Double_Boxing)
    instance_create((16*grid_size),(8*grid_size),Double_Boxing_Dimond)
    instance_create((16*grid_size)+18,(8*grid_size),Double_Boxing_Yellow)
    instance_create((16*grid_size),(8*grid_size)+18,Double_Boxing_Dimond)
    instance_create((16*grid_size)+18,(8*grid_size)+18,Double_Boxing_Yellow)
    instance_create((21*grid_size),(8*grid_size),Double_Boxing)
    instance_create((21*grid_size),(8*grid_size),Double_Boxing_Yellow)
    instance_create((21*grid_size)+18,(8*grid_size),Double_Boxing_Dimond)
    instance_create((21*grid_size),(8*grid_size)+18,Double_Boxing_Yellow)
    instance_create((21*grid_size)+18,(8*grid_size)+18,Double_Boxing_Dimond)
    instance_create((22*grid_size),(8*grid_size),Double_Boxing)
    instance_create((22*grid_size),(8*grid_size),Double_Boxing_Dimond)
    instance_create((22*grid_size)+18,(8*grid_size),Double_Boxing_Dimond)
    instance_create((22*grid_size),(8*grid_size)+18,Double_Boxing_Dimond)
    instance_create((22*grid_size)+18,(8*grid_size)+18,Double_Boxing_Dimond)
}

// Level 22
if (global.levelnumber==22)
{
    var x_place;
    var y_place;
    // Double line down
    x_place = 18
    y_place = 1
    repeat(20)
    {
        instance_create(x_place*grid_size,y_place*grid_size,Double_Boxing)
        instance_create((x_place+1)*grid_size,y_place*grid_size,Double_Boxing)
        instance_create((x_place*grid_size),(y_place*grid_size),Double_Boxing_Dimond)
        instance_create((x_place*grid_size)+18,(y_place*grid_size),Double_Boxing_Dimond)
        instance_create((x_place*grid_size),(y_place*grid_size)+18,Double_Boxing_Dimond)
        instance_create((x_place*grid_size)+18,(y_place*grid_size)+18,Double_Boxing_Dimond)
        instance_create(((x_place+1)*grid_size),(y_place*grid_size),Double_Boxing_Dimond)
        instance_create(((x_place+1)*grid_size)+18,(y_place*grid_size),Double_Boxing_Dimond)
        instance_create(((x_place+1)*grid_size),(y_place*grid_size)+18,Double_Boxing_Dimond)
        instance_create(((x_place+1)*grid_size)+18,(y_place*grid_size)+18,Double_Boxing_Dimond)
        y_place += 1
    }
    // Single lines across
    y_place = 6
    repeat(2)
    {
        x_place = 11
        repeat(14)
        {
            instance_create(x_place*grid_size,y_place*grid_size,Double_Boxing) 
            instance_create((x_place*grid_size),(y_place*grid_size),Double_Boxing_Dimond)
            instance_create((x_place*grid_size)+18,(y_place*grid_size),Double_Boxing_Dimond)
            instance_create((x_place*grid_size),(y_place*grid_size)+18,Double_Boxing_Dimond)
            instance_create((x_place*grid_size)+18,(y_place*grid_size)+18,Double_Boxing_Dimond)
            if (x_place==17) x_place += 3 else x_place += 1
        }
        y_place = 15
    }
}

// Level 25
if (global.levelnumber==25)
{
    var x_place;
    var y_place;
    x_place = 22
    y_place = 16
    // Double_Boxing
    /*
    var i;
    var j;
    for (i = x_place; i <= x_place+2; i += 1)
    {
        for (j = y_place; i <= y_place+4; i += 1)
        {
            instance_create(i*grid_size,j*grid_size,Double_Boxing)
        }
    } 
    */
    // Row 0
    instance_create((x_place)*grid_size,(y_place)*grid_size,Double_Boxing)
    instance_create((x_place+1)*grid_size,(y_place)*grid_size,Double_Boxing)
    instance_create((x_place+2)*grid_size,(y_place)*grid_size,Double_Boxing)
    // Row 1
    instance_create((x_place)*grid_size,(y_place+1)*grid_size,Double_Boxing)
    instance_create((x_place+1)*grid_size,(y_place+1)*grid_size,Double_Boxing)
    instance_create((x_place+2)*grid_size,(y_place+1)*grid_size,Double_Boxing)
    // Row 2
    instance_create((x_place)*grid_size,(y_place+2)*grid_size,Double_Boxing)
    instance_create((x_place+1)*grid_size,(y_place+2)*grid_size,Double_Boxing)
    instance_create((x_place+2)*grid_size,(y_place+2)*grid_size,Double_Boxing)
    // Row 3
    instance_create((x_place)*grid_size,(y_place+3)*grid_size,Double_Boxing)
    instance_create((x_place+1)*grid_size,(y_place+3)*grid_size,Double_Boxing)
    instance_create((x_place+2)*grid_size,(y_place+3)*grid_size,Double_Boxing)
    // Row 4
    instance_create((x_place)*grid_size,(y_place+4)*grid_size,Double_Boxing)
    instance_create((x_place+1)*grid_size,(y_place+4)*grid_size,Double_Boxing)
    instance_create((x_place+2)*grid_size,(y_place+4    )*grid_size,Double_Boxing)
    // Line 0, Col 0
    instance_create((x_place*grid_size),(y_place*grid_size),Double_Boxing_Rock)
    instance_create((x_place*grid_size)+18,(y_place*grid_size),Double_Boxing_Dimond)
    instance_create((x_place*grid_size),(y_place*grid_size)+18,Double_Boxing_Dimond)
    instance_create((x_place*grid_size)+18,(y_place*grid_size)+18,Double_Boxing_Dimond)
    // Line 0, Col 1
    instance_create(((x_place+1)*grid_size),(y_place*grid_size),Double_Boxing_Dimond)
    instance_create(((x_place+1)*grid_size)+18,(y_place*grid_size),Double_Boxing_Dimond)
    instance_create(((x_place+1)*grid_size),(y_place*grid_size)+18,Double_Boxing_Rock)
    instance_create(((x_place+1)*grid_size)+18,(y_place*grid_size)+18,Double_Boxing_Rock)
    // Line 0, Col 2
    instance_create(((x_place+2)*grid_size),(y_place*grid_size),Double_Boxing_Dimond)
    instance_create(((x_place+2)*grid_size)+18,(y_place*grid_size),Double_Boxing_Rock)
    instance_create(((x_place+2)*grid_size),(y_place*grid_size)+18,Double_Boxing_Dimond)
    instance_create(((x_place+2)*grid_size)+18,(y_place*grid_size)+18,Double_Boxing_Dimond)
    // Line 1, Col 0
    var line;
    line = 1
    instance_create((x_place*grid_size),((y_place+line)*grid_size),Double_Boxing_Dimond)
    instance_create((x_place*grid_size)+18,((y_place+line)*grid_size),Double_Boxing_Rock)
    instance_create((x_place*grid_size),((y_place+line)*grid_size)+18,Double_Boxing_Dimond)
    instance_create((x_place*grid_size)+18,((y_place+line)*grid_size)+18,Double_Boxing_Rock)
    // Line 1, Col 1
    instance_create(((x_place+1)*grid_size),((y_place+line)*grid_size),Double_Boxing_Rock)
    instance_create(((x_place+1)*grid_size)+18,((y_place+line)*grid_size),Double_Boxing_Rock)
    instance_create(((x_place+1)*grid_size),((y_place+line)*grid_size)+18,Double_Boxing_Rock)
    instance_create(((x_place+1)*grid_size)+18,((y_place+line)*grid_size)+18,Double_Boxing_Rock)
    // Line 1, Col 2
    instance_create(((x_place+2)*grid_size),((y_place+line)*grid_size),Double_Boxing_Rock)
    instance_create(((x_place+2)*grid_size)+18,((y_place+line)*grid_size),Double_Boxing_Dimond)
    instance_create(((x_place+2)*grid_size),((y_place+line)*grid_size)+18,Double_Boxing_Rock)
    instance_create(((x_place+2)*grid_size)+18,((y_place+line)*grid_size)+18,Double_Boxing_Dimond)
    // Line 2, Col 0
    line = 2
    instance_create((x_place*grid_size),((y_place+line)*grid_size),Double_Boxing_Dimond)
    instance_create((x_place*grid_size)+18,((y_place+line)*grid_size),Double_Boxing_Dimond)
    instance_create((x_place*grid_size),((y_place+line)*grid_size)+18,Double_Boxing_Rock)
    instance_create((x_place*grid_size)+18,((y_place+line)*grid_size)+18,Double_Boxing_Dimond)
    // Line 2, Col 1
    instance_create(((x_place+1)*grid_size),((y_place+line)*grid_size),Double_Boxing_Rock)
    instance_create(((x_place+1)*grid_size)+18,((y_place+line)*grid_size),Double_Boxing_Rock)
    instance_create(((x_place+1)*grid_size),((y_place+line)*grid_size)+18,Double_Boxing_Dimond)
    instance_create(((x_place+1)*grid_size)+18,((y_place+line)*grid_size)+18,Double_Boxing_Dimond)
    // Line 2, Col 2
    instance_create(((x_place+2)*grid_size),((y_place+line)*grid_size),Double_Boxing_Dimond)
    instance_create(((x_place+2)*grid_size)+18,((y_place+line)*grid_size),Double_Boxing_Dimond)
    instance_create(((x_place+2)*grid_size),((y_place+line)*grid_size)+18,Double_Boxing_Dimond)
    instance_create(((x_place+2)*grid_size)+18,((y_place+line)*grid_size)+18,Double_Boxing_Rock)
    // Line 3, Col 0
    line = 3
    instance_create((x_place*grid_size),((y_place+line)*grid_size),Double_Boxing_Rock)
    instance_create((x_place*grid_size)+18,((y_place+line)*grid_size),Double_Boxing_Rock)
    instance_create((x_place*grid_size),((y_place+line)*grid_size)+18,Double_Boxing_Rock)
    instance_create((x_place*grid_size)+18,((y_place+line)*grid_size)+18,Double_Boxing_Rock)
    // Line 3, Col 1
    instance_create(((x_place+1)*grid_size),((y_place+line)*grid_size),Double_Boxing_Rock)
    instance_create(((x_place+1)*grid_size)+18,((y_place+line)*grid_size),Double_Boxing_Rock)
    instance_create(((x_place+1)*grid_size),((y_place+line)*grid_size)+18,Double_Boxing_Rock)
    instance_create(((x_place+1)*grid_size)+18,((y_place+line)*grid_size)+18,Double_Boxing_Rock)
    // Line 3, Col 2
    instance_create(((x_place+2)*grid_size),((y_place+line)*grid_size),Double_Boxing_Dimond)
    instance_create(((x_place+2)*grid_size)+18,((y_place+line)*grid_size),Double_Boxing_Dimond)
    instance_create(((x_place+2)*grid_size),((y_place+line)*grid_size)+18,Double_Boxing_Rock)
    instance_create(((x_place+2)*grid_size)+18,((y_place+line)*grid_size)+18,Double_Boxing_Dimond)
    // Line 4, Col 0
    line = 4
    instance_create((x_place*grid_size),((y_place+line)*grid_size),Double_Boxing_Dimond)
    instance_create((x_place*grid_size)+18,((y_place+line)*grid_size),Double_Boxing_Dimond)
    instance_create((x_place*grid_size),((y_place+line)*grid_size)+18,Double_Boxing_Rock)
    instance_create((x_place*grid_size)+18,((y_place+line)*grid_size)+18,Double_Boxing_Dimond)
    // Line 4, Col 1
    instance_create(((x_place+1)*grid_size),((y_place+line)*grid_size),Double_Boxing_Rock)
    instance_create(((x_place+1)*grid_size)+18,((y_place+line)*grid_size),Double_Boxing_Rock)
    instance_create(((x_place+1)*grid_size),((y_place+line)*grid_size)+18,Double_Boxing_Dimond)
    instance_create(((x_place+1)*grid_size)+18,((y_place+line)*grid_size)+18,Double_Boxing_Dimond)
    // Line 4, Col 2
    instance_create(((x_place+2)*grid_size),((y_place+line)*grid_size),Double_Boxing_Dimond)
    instance_create(((x_place+2)*grid_size)+18,((y_place+line)*grid_size),Double_Boxing_Dimond)
    instance_create(((x_place+2)*grid_size),((y_place+line)*grid_size)+18,Double_Boxing_Dimond)
    instance_create(((x_place+2)*grid_size)+18,((y_place+line)*grid_size)+18,Double_Boxing_Rock)
}

// Level 27
if (global.levelnumber==27) 
{
    var i;
    var j;
    var k;
    var l;
    // Outer Lower Column
    l = 16
    repeat(2) // Column
    {
        for (i = 7; i <= 20; i += 1) // Row
        {
            instance_create(l*grid_size,i*grid_size,Double_Boxing)
            for (j = 0; j <= 18; j += 18) // Sub Row
            {
                for (k = 0; k <= 18; k += 18) // Sub Column
                {
                    instance_create((l*grid_size)+j,(i*grid_size)+k,Double_Boxing_Dimond)
                }
            }
        }
        l = 22
    }
    // Inner Upper Column
    l = 18
    repeat(2) // Column
    {
        for (i = 2; i <= 7; i += 1) // Row
        {
            instance_create(l*grid_size,i*grid_size,Double_Boxing)
            for (j = 0; j <= 18; j += 18) // Sub Row
            {
                for (k = 0; k <= 18; k += 18) // Sub Column
                {
                    instance_create((l*grid_size)+j,(i*grid_size)+k,Double_Boxing_Dimond)
                }
            }
        }
        l = 20
    }
    // Top Middle Single Tile
    instance_create(19*grid_size, 2*grid_size, Double_Boxing)
    instance_create(19*grid_size, 2*grid_size, Double_Boxing_Dimond)
    instance_create(19*grid_size+18, 2*grid_size, Double_Boxing_Dimond)
    instance_create(19*grid_size, 2*grid_size+18, Double_Boxing_Dimond)
    instance_create(19*grid_size+18, 2*grid_size+18, Double_Boxing_Dimond)
    // Top Left Single Tile
    instance_create(17*grid_size, 7*grid_size, Double_Boxing)
    instance_create(17*grid_size, 7*grid_size, Double_Boxing_Dimond)
    instance_create(17*grid_size+18, 7*grid_size, Double_Boxing_Dimond)
    instance_create(17*grid_size, 7*grid_size+18, Double_Boxing_Dimond)
    instance_create(17*grid_size+18, 7*grid_size+18, Double_Boxing_Dimond)
    // Top Left Single Tile
    instance_create(21*grid_size, 7*grid_size, Double_Boxing)
    instance_create(21*grid_size, 7*grid_size, Double_Boxing_Dimond)
    instance_create(21*grid_size+18, 7*grid_size, Double_Boxing_Dimond)
    instance_create(21*grid_size, 7*grid_size+18, Double_Boxing_Dimond)
    instance_create(21*grid_size+18, 7*grid_size+18, Double_Boxing_Dimond)
    
}
#define Neutral_Character_Create
// Neutral_Character_Create
// Stefan Grace
// Created: 2017-07-16
// Modified: 2018-06-10
// This script creates the neutral (free, green) characters on each level

// Level 2
if (global.levelnumber==2)
{
    instance_create(595,210,Green_O)
    instance_create(630,210,Green_Triangle)
    instance_create(665,210,Green_O)
    instance_create(595,525,Green_O)
    instance_create(630,525,Green_Triangle)
    instance_create(665,525,Green_O)
}


// Level 3
if (global.levelnumber==3)
{
    instance_create(630,210,Green_O)
    instance_create(665,210,Green_O)
    instance_create(630,525,Green_O)
    instance_create(665,525,Green_O)
    instance_create(350,105,Green_X)
    instance_create(385,350,Green_A)
    instance_create(350,630,Green_X)
    instance_create(035,035,Green_Triangle)
    instance_create(035,700,Green_Triangle)
    instance_create(1260,35,Green_O)
    instance_create(1260,700,Green_O)   
}

// Level 4
if (global.levelnumber==4)
{
    instance_create(35,105,Green_X)
    instance_create(245,35,Green_Triangle)
    instance_create(630,35,Green_A)
    instance_create(1050,35,Green_Triangle)
    instance_create(1260,105,Green_X)
    instance_create(630,455,Green_O)
    instance_create(210,630,Green_O)
    instance_create(945,630,Green_O)
    instance_create(595,700,Green_A)
}   

// Level 5
if (global.levelnumber==5)
{
    instance_create(35,35,Green_X)
    instance_create(35+17,35,Green_A)
    instance_create(35,35+17,Green_Triangle)
    instance_create(35,70,Green_O)
    instance_create(35+17,70,Green_O)
    instance_create(665,140,Green_X)
    instance_create(595,245,Green_Triangle)
    instance_create(735,245,Green_A)
    instance_create(595,455,Green_Triangle)
    instance_create(770,455,Green_A)
    instance_create(665,525,Green_X)
    instance_create(1260,665,Green_O)
    instance_create(1260+17,665,Green_O)
    instance_create(1260,700,Green_X)
    instance_create(1260+17,700,Green_A)
    instance_create(1260,700+17,Green_Triangle)
}

// Level 6
if (global.levelnumber==6)
{
    instance_create(35,35,Green_X)
    instance_create(1260,35,Green_X)
    instance_create(525,245,Green_O)
    instance_create(735,245,Green_O)
    instance_create(35,350,Green_X)
    instance_create(1260,350,Green_X)
}

// Level 7
if (global.levelnumber==7)
{
    instance_create(420,35,Green_Square)
    instance_create(875,35,Green_Square)
    instance_create(490,175,Green_X)
    instance_create(770,315,Green_X)
    instance_create(385,420,Green_Triangle)
    instance_create(735,455,Green_Triangle)
    instance_create(35,700,Green_A)
    instance_create(945,700,Green_A)
}

// Level 8
if (global.levelnumber==8)
{
    instance_create(455,385,Green_Square)
    instance_create(455+17,385,Green_Square)
    instance_create(455,385+17,Green_Square)
    instance_create(490,385,Green_A)
    instance_create(490+17,385,Green_A)
    instance_create(490,385+17,Green_A)
    instance_create(525,385,Green_X)
    instance_create(525+17,385,Green_X)
    instance_create(525,385+17,Green_X)
    instance_create(560,385,Green_O)
    instance_create(560+17,385,Green_O)
    instance_create(560,385+17,Green_O)
    instance_create(875,385,Green_Square)
    instance_create(875+17,385,Green_Square)
    instance_create(875,385+17,Green_Square)
    instance_create(840,385,Green_A)
    instance_create(840+17,385,Green_A)
    instance_create(840,385+17,Green_A)
    instance_create(805,385,Green_X)
    instance_create(805+17,385,Green_X)
    instance_create(805,385+17,Green_X)
    instance_create(770,385,Green_O)
    instance_create(770+17,385,Green_O)
    instance_create(770,385+17,Green_O)
}

// Level 9
if (global.levelnumber==9)
{
    instance_create(490,105,Green_X)
    instance_create(490+17,105,Green_X)
    instance_create(735,105,Green_X)
    instance_create(735+17,105,Green_X)
    instance_create(455,245,Green_Triangle)
    instance_create(455+17,245,Green_Triangle)
    instance_create(735,245,Green_Triangle)
    instance_create(735+17,245,Green_Triangle)
    instance_create(490,280,Green_A)
    instance_create(490+17,280,Green_A)
    instance_create(700,280,Green_A)
    instance_create(700+17,280,Green_A)
}

// Level 10
if (global.levelnumber==10)
{
    instance_create(420,175,Green_X)
    instance_create(490,175,Green_A)
    instance_create(630,175,Green_K)
    instance_create(805,175,Green_A)
    instance_create(875,175,Green_X)
    instance_create(420,245,Green_Triangle)
    instance_create(875,245,Green_Triangle)
    instance_create(420,350,Green_Square)
    instance_create(875,350,Green_Square)
    instance_create(420,455,Green_Triangle)
    instance_create(875,455,Green_Triangle)
    instance_create(420,525,Green_X)
    instance_create(490,525,Green_A)
    instance_create(665,525,Green_K)
    instance_create(805,525,Green_A)
    instance_create(875,525,Green_X)
}

// Level 11
if (global.levelnumber==11)
{
    instance_create(35,35,Green_X)
    instance_create(210,35,Green_A)
    instance_create(1085,35,Green_A)
    instance_create(1260,35,Green_X)
    instance_create(35,175,Green_Triangle)
    instance_create(210,175,Green_O)
    instance_create(1085,175,Green_O)
    instance_create(1260,175,Green_Triangle)
}

// Level 12
if (global.levelnumber==12)
{
    instance_create(525,35,Green_X)
    instance_create(560,35,Green_Square)
    instance_create(875,280,Green_X)
    instance_create(875+17,280,Green_B)
    instance_create(560,385,Green_X)
    instance_create(560+17,385,Green_B)
    instance_create(595,700,Green_B)
    instance_create(595+17,700,Green_Square)
    instance_create(630,700,Green_X)
}

// Level 13
if (global.levelnumber==13)
{
    instance_create(315,35,Green_Square)
    instance_create(525,35,Green_A)
    instance_create(980,35,Green_Square)
    instance_create(665,280,Green_O)
    instance_create(910,280,Green_O)
    instance_create(770,385,Green_X)
    instance_create(385,560,Green_Triangle)
    instance_create(665,560,Green_O)
    instance_create(875,560,Green_E)
    instance_create(910,560,Green_E)
}

// Level 14
if (global.levelnumber==14)
{
    instance_create(980,35,Green_E)
    instance_create(210,140,Green_E)
    instance_create(35,280,Green_Square)
    instance_create(525,455,Green_X)
    instance_create(1050,455,Green_Square)
    instance_create(770,700,Green_A)

}

// Level 15
if (global.levelnumber==15)
{
    instance_create(385,245,Green_S)
    instance_create(910,245,Green_S)
    instance_create(665,385,Green_S)
    instance_create(770,385,Green_Square)
    instance_create(595,420,Green_X)
    instance_create(630,420,Green_A)
    instance_create(737,420,Green_O)
    instance_create(665,490,Green_E)
    instance_create(770,490,Green_Triangle)
    instance_create(560,525,Green_K)
    instance_create(630,525,Green_O)
    instance_create(735,525,Green_B)
    instance_create(525,595,Green_O)
    instance_create(595,595,Green_S)
    instance_create(560,630,Green_B)
    instance_create(665,630,Green_E)
}

// Level 17
if (global.levelnumber==17)
{
    instance_create(35,35,Green_O)
    instance_create(1260,35,Green_O)
    instance_create(490,140,Green_S)
    instance_create(875,140,Green_S)
    instance_create(140,315,Green_B)
    instance_create(1155,280,Green_B)
}

// Level 19
if (global.levelnumber==19)
{
    instance_create((17*grid_size),(4*grid_size),Green_X)
    instance_create((17*grid_size)+17,(4*grid_size),Green_X)
    instance_create((18*grid_size),(4*grid_size),Green_O)
    instance_create((18*grid_size)+17,(4*grid_size),Green_O)
    instance_create((19*grid_size),(4*grid_size),Green_A)
    instance_create((19*grid_size)+17,(4*grid_size),Green_A)
    instance_create((17*grid_size),(5*grid_size),Green_B)
    instance_create((17*grid_size)+17,(5*grid_size),Green_E)
    instance_create((17*grid_size),(5*grid_size)+17,Green_E)
    instance_create((18*grid_size),(5*grid_size),Green_S)
    instance_create((18*grid_size)+17,(5*grid_size),Green_S)
    instance_create((19*grid_size),(5*grid_size),Green_H)
    instance_create((19*grid_size)+17,(5*grid_size),Green_H)
    instance_create((17*grid_size),(6*grid_size),Green_Triangle)
    instance_create((17*grid_size)+17,(6*grid_size),Green_Triangle)
    instance_create((18*grid_size),(6*grid_size),Green_Square)
    instance_create((18*grid_size)+17,(6*grid_size),Green_Square)
}

// Level 20
if (global.levelnumber==20)
{
    instance_create((9*grid_size),(8*grid_size),Green_A)
    instance_create((28*grid_size),(8*grid_size),Green_A) 
    instance_create((1*grid_size),(10*grid_size),Green_O)
    instance_create((15*grid_size),(10*grid_size),Green_R)
    instance_create((16*grid_size),(10*grid_size),Green_X)
    instance_create((17*grid_size),(10*grid_size),Green_Square)
    instance_create((20*grid_size),(10*grid_size),Green_Square)
    instance_create((21*grid_size),(10*grid_size),Green_X)
    instance_create((22*grid_size),(10*grid_size),Green_R)
    instance_create((36*grid_size),(10*grid_size),Green_O)
    instance_create((1*grid_size),(11*grid_size),Green_E)
    instance_create((36*grid_size),(11*grid_size),Green_E)
}

// Level 21
if (global.levelnumber==21)
{
    instance_create((1*grid_size),(1*grid_size),Green_O)
    instance_create((21*grid_size),(1*grid_size),Green_A)
    instance_create((31*grid_size),(1*grid_size),Green_R)
    instance_create((7*grid_size),(2*grid_size),Green_X)
    instance_create((9*grid_size),(2*grid_size),Green_M)
    instance_create((29*grid_size),(2*grid_size),Green_M)
    instance_create((1*grid_size),(3*grid_size),Green_M)
    instance_create((16*grid_size),(3*grid_size),Green_M)
    instance_create((8*grid_size),(4*grid_size),Green_Triangle)
    instance_create((24*grid_size),(4*grid_size),Green_H)
    instance_create((12*grid_size),(5*grid_size),Green_E)
    instance_create((6*grid_size),(6*grid_size),Green_Triangle)
    instance_create((24*grid_size),(6*grid_size),Green_M)
    instance_create((9*grid_size),(7*grid_size),Green_S)
    instance_create((14*grid_size),(8*grid_size),Green_M)
    instance_create((27*grid_size),(8*grid_size),Green_B)
    instance_create((32*grid_size),(8*grid_size),Green_A)
    instance_create((2*grid_size),(9*grid_size),Green_Square)
    instance_create((24*grid_size),(9*grid_size),Green_M)
    instance_create((17*grid_size),(10*grid_size),Green_X)
    instance_create((17*grid_size)+17,(10*grid_size),Green_X)
    instance_create((17*grid_size),(10*grid_size)+17,Green_R)
    instance_create((19*grid_size),(10*grid_size),Green_A)
    instance_create((19*grid_size)+17,(10*grid_size),Green_A)
    instance_create((31*grid_size),(10*grid_size),Green_O)
    instance_create((35*grid_size),(10*grid_size),Green_M)
    instance_create((2*grid_size),(11*grid_size),Green_M)
    instance_create((19*grid_size),(11*grid_size),Green_Triangle)
    instance_create((20*grid_size),(11*grid_size),Green_Triangle)
    instance_create((5*grid_size),(12*grid_size),Green_A)
    instance_create((9*grid_size),(12*grid_size),Green_H)
    instance_create((28*grid_size),(12*grid_size),Green_S)
    instance_create((35*grid_size),(12*grid_size),Green_Square)
    instance_create((16*grid_size),(14*grid_size),Green_M)
    instance_create((30*grid_size),(14*grid_size),Green_M)
    instance_create((8*grid_size),(15*grid_size),Green_M)
    instance_create((22*grid_size),(15*grid_size),Green_M)
    instance_create((12*grid_size),(16*grid_size),Green_B)
    instance_create((16*grid_size),(17*grid_size),Green_M)
    instance_create((22*grid_size),(17*grid_size),Green_E)
    instance_create((12*grid_size),(18*grid_size),Green_A)
    instance_create((30*grid_size),(18*grid_size),Green_X)
    instance_create((7*grid_size),(20*grid_size),Green_R)
    instance_create((16*grid_size),(20*grid_size),Green_O)
    instance_create((20*grid_size),(20*grid_size),Green_Triangle)
    instance_create((26*grid_size),(20*grid_size),Green_Triangle)
    instance_create((29*grid_size),(20*grid_size),Green_M)
    instance_create((35*grid_size),(20*grid_size),Green_O)
    instance_create((36*grid_size),(20*grid_size),Green_M)
}

// Level 22
if (global.levelnumber==22)
{
    instance_create(420,70,Green_M)
    instance_create(875,70,Green_M)
    instance_create(595,140,Green_B)
    instance_create(700,140,Green_B)
    instance_create(595,595,Green_B)
    instance_create(700,595,Green_B)
    instance_create(420,665,Green_M)
    instance_create(875,665,Green_M)
}

// Level 23
if (global.levelnumber==23)
{
    instance_create((6*grid_size),(19*grid_size),Green_R)
    instance_create((31*grid_size),(19*grid_size),Green_R)
    instance_create((12*grid_size),(2*grid_size),Green_Square)
    instance_create((25*grid_size),(2*grid_size),Green_Square)
    instance_create((12*grid_size),(19*grid_size),Green_Square)
    instance_create((25*grid_size),(19*grid_size),Green_Square)
    var h_center;
    var v_center;
    var h_offset;
    var v_offset;
    var flip;
    h_center = 19*grid_size
    v_center = 10*grid_size
    h_offset = 0
    v_offset = 0
    flip = -1
    repeat(2)
    {    
        instance_create((1*grid_size*flip)+h_center+h_offset,(7*grid_size*flip)+v_center+v_offset,Green_O)
        instance_create((0*grid_size*flip)+h_center+h_offset,(7*grid_size*flip)+v_center+v_offset,Green_S)
        instance_create((3*grid_size*flip)+h_center+h_offset,(2*grid_size*flip)+v_center+v_offset,Green_H)
        instance_create((2*grid_size*flip)+h_center+h_offset,(2*grid_size*flip)+v_center+v_offset,Green_A)
        instance_create((-1*grid_size*flip)+h_center+h_offset,(2*grid_size*flip)+v_center+v_offset,Green_A)
        instance_create((-2*grid_size*flip)+h_center+h_offset,(2*grid_size*flip)+v_center+v_offset,Green_E)
        instance_create((7*grid_size*flip)+h_center+h_offset,(1*grid_size*flip)+v_center+v_offset,Green_F)
        instance_create((3*grid_size*flip)+h_center+h_offset,(1*grid_size*flip)+v_center+v_offset,Green_Triangle)
        instance_create((2*grid_size*flip)+h_center+h_offset,(1*grid_size*flip)+v_center+v_offset,Green_X)
        instance_create((-1*grid_size*flip)+h_center+h_offset,(1*grid_size*flip)+v_center+v_offset,Green_X)
        instance_create((-2*grid_size*flip)+h_center+h_offset,(1*grid_size*flip)+v_center+v_offset,Green_Triangle)
        instance_create((-6*grid_size*flip)+h_center+h_offset,(1*grid_size*flip)+v_center+v_offset,Green_M)
        flip = 1
        h_offset = -1*grid_size
    }
}

// Level 25
if (global.levelnumber==25)
{
    instance_create((19*grid_size),(2*grid_size),Green_O)
    instance_create((19*grid_size),(6*grid_size),Green_R)
    instance_create((21*grid_size),(6*grid_size),Green_M)
    instance_create((15*grid_size),(10*grid_size),Green_G)
    instance_create((19*grid_size),(19*grid_size),Green_O)
}

// Level 26
if (global.levelnumber==26)
{
    var i;
    for(i = 9; i <= 19; i += 1)
    {
        instance_create((7*grid_size),(i*grid_size),Green_G)
        instance_create((30*grid_size),(i*grid_size),Green_G)
    }
    for(i = 5; i <= 18; i += 1)
    {
        instance_create((13*grid_size),(i*grid_size),Green_G)
        instance_create((24*grid_size),(i*grid_size),Green_G)
    }
    for(i = 13; i <= 17; i += 1)
    {
        instance_create((9*grid_size),(i*grid_size),Green_G)
        instance_create((28*grid_size),(i*grid_size),Green_G)
    }
    for(i = 7; i <= 30; i += 1)
    {
        instance_create((i*grid_size),(20*grid_size),Green_G)
    }
    for(i = 8; i <= 12; i += 1)
    {
        instance_create((i*grid_size),(9*grid_size),Green_G)
        instance_create(((i+17)*grid_size),(9*grid_size),Green_G)
    }
    for(i = 1; i <= 19; i += 1)
    {
        instance_create((18*grid_size),(i*grid_size),Green_G)
        instance_create((19*grid_size),(i*grid_size),Green_G)
        if (i==5) i = 8
    }
    instance_create((14*grid_size),(12*grid_size),Green_S)
    instance_create((23*grid_size),(12*grid_size),Green_S)
    instance_create((14*grid_size),(13*grid_size),Green_Square)
    instance_create((23*grid_size),(13*grid_size),Green_Square)
    instance_create((12*grid_size),(22*grid_size),Green_R)
    instance_create((25*grid_size),(22*grid_size),Green_R)
    instance_create((12*grid_size),(24*grid_size),Green_M)
    instance_create((25*grid_size),(24*grid_size),Green_M)
    instance_create((10*grid_size),(24*grid_size),Green_M)
    instance_create((27*grid_size),(24*grid_size),Green_M)
    instance_create((8*grid_size),(19*grid_size),Green_X)
    instance_create((12*grid_size),(19*grid_size),Green_F)
    instance_create((14*grid_size),(19*grid_size),Green_X)
    instance_create((15*grid_size),(19*grid_size),Green_O)
    instance_create((16*grid_size),(19*grid_size),Green_Triangle)
    instance_create((17*grid_size),(19*grid_size),Green_A)
    instance_create((20*grid_size),(19*grid_size),Green_X)
    instance_create((21*grid_size),(19*grid_size),Green_O)
    instance_create((22*grid_size),(19*grid_size),Green_Triangle)
    instance_create((23*grid_size),(19*grid_size),Green_A)
    instance_create((25*grid_size),(19*grid_size),Green_F)
    instance_create((29*grid_size),(19*grid_size),Green_X)
}

// Level 27
if (global.levelnumber==27)
{
    // Middle Column
    var x_pos;
    x_pos = 19*grid_size
    instance_create(x_pos,3*grid_size,Green_M)
    instance_create(x_pos,4*grid_size,Green_M)
    instance_create(x_pos,5*grid_size,Green_X)
    instance_create(x_pos,6*grid_size,Green_A)
    instance_create(x_pos,7*grid_size,Green_X)
    instance_create(x_pos,8*grid_size,Green_A)
    instance_create(x_pos,9*grid_size,Green_F)
    instance_create(x_pos,10*grid_size,Green_R)
    instance_create(x_pos,11*grid_size,Green_O)
    instance_create(x_pos,12*grid_size,Green_O); instance_create(x_pos+17,12*grid_size,Green_Triangle)
    instance_create(x_pos,13*grid_size,Green_O)
    instance_create(x_pos,14*grid_size,Green_B)
    instance_create(x_pos,15*grid_size,Green_E)
    instance_create(x_pos,16*grid_size,Green_K)
    instance_create(x_pos,17*grid_size,Green_H)
    instance_create(x_pos,18*grid_size,Green_S)
    instance_create(x_pos,19*grid_size,Green_Square)
    // Left C
    instance_create(14*grid_size,1*grid_size,Green_C)
    // Right C
    instance_create(24*grid_size,1*grid_size,Green_C)
}

// Level 28
if (global.levelnumber==28)
{
    // Left
    instance_create(420,35,Green_X)
    instance_create(490,35,Green_M)
    instance_create(560,35,Green_M)
    instance_create(420,105,Green_Triangle)
    instance_create(490,105,Green_F)
    instance_create(560,105,Green_R)
    instance_create(420,175,Green_Square)
    instance_create(490,175,Green_F)
    instance_create(560,175,Green_S)
    instance_create(420,245,Green_A)
    instance_create(490,245,Green_E)
    instance_create(560,245,Green_H)
    // Right
    instance_create(735,35,Green_M)
    instance_create(805,35,Green_M)
    instance_create(875,35,Green_X)
    instance_create(735,105,Green_R)
    instance_create(805,105,Green_F)
    instance_create(875,105,Green_Triangle)
    instance_create(735,175,Green_S)
    instance_create(805,175,Green_F)
    instance_create(875,175,Green_Square)
    instance_create(735,245,Green_A)
    instance_create(805,245,Green_E)
    instance_create(875,245,Green_H)
}
#define Create_Tablet_UI
if (global.tablet_mode)
{
    if (global.levelnumber != 16 and global.levelnumber != 24) 
    {
        instance_create(735, 350, Tablet_UI)
    }
    else
    {
        instance_create(630, 735, Tablet_UI_Menu_Button)
    }
}
#define Memory_Start
// Memory_Start
// Stefan Grace
// Created: 2017-09-20
// Modified: 2017-09-24
// This script is executed at the start of the Memory level (Level 24)

var i;
var j;
var k;
var tile_id;
var tile_id_sum;
var tiles;

// Sets up the message variables
global.message_type = 41
level24messagenumber = 0

// Makes an order array of the numbers 0 to 99
for(i = 0; i<100; i += 1)
{
    tile_id[i] = i
}

// Makes a shuffeld array of the numbers 0 to 99
while (tile_id_sum!=-100)
{
    tile_id_sum = 0
    j = random(100)
    j = j-(j mod 1)
    if (tile_id[j]>=0) 
    {
        tiles[k] = tile_id[j]
        tile_id[j] = -1
        k += 1
    } 
    for(i = 0; i<100; i += 1)
    {   
        tile_id_sum += tile_id[i]
    }
}

// Makes an array of 100 tiles (10 of each type)
for(i = 0; i<100; i += 1)
{
    tile_type[i] = tiles[i] mod 10   
}

// Sets the flip animation to 1 for each tile
for(i = 0; i<100; i+= 1)
{
    flip_animation[i] = 1
}
#define Memory_Draw
// Memory_Draw
// Stefan Grace
// Created: 2017-09-20
// Modified: 2024-07-25
// This script draws out the tiles and scores on the memory level

var i;
var j;

// Draws out the tiles
for (i = 0; i<10; i += 1)
{
    for (j = 0; j<10; j += 1)
    {
        if (tile_matched[i+(j*10)]>0) // If the tile has been matched
        {
            draw_sprite(Yellow_Sprite,0,(i+14)*grid_size,(j+6)*grid_size) 
        }
        if (tile_matched[i+(j*10)]==0 and tile_clicked[i+(j*10)]==0) // If the tile has not been matched or clicked
        {
            draw_sprite_ext(Rock_Sprite,0,((i+14)*grid_size)+(17-(flip_animation[i+(j*10)]*17)),(j+6)*grid_size,flip_animation[i+(j*10)],1,0,c_white,1)
        }
        if (tile_clicked[i+(j*10)]>0) // If the tile has been clciked but not matched
        {
            draw_sprite_ext(Yellow_Sprite,0,((i+14)*grid_size)+(17-(flip_animation[i+(j*10)]*17)),(j+6)*grid_size,flip_animation[i+(j*10)],1,0,c_white,1) 
            /* G               */ if (tile_type[i+(j*10)]==0) draw_sprite_ext(G_R_3hit,0,((i+14)*grid_size)+(17-(flip_animation[i+(j*10)]*17)),(j+6)*grid_size,flip_animation[i+(j*10)],1,0,c_white,1) // G
            /* Red Anger       */ if (tile_type[i+(j*10)]==1) draw_sprite_ext(Red_Anger_Sprite,animation mod 90,((i+14)*grid_size)+(17-(flip_animation[i+(j*10)]*17)),(j+6)*grid_size,flip_animation[i+(j*10)],1,0,c_white,1) // Red Anger
            /* Tunnling Bomb   */ if (tile_type[i+(j*10)]==2) draw_sprite_ext(Tunnling_Bomb_Sprite,0,((i+14)*grid_size)+(17-(flip_animation[i+(j*10)]*17)),(j+6)*grid_size,flip_animation[i+(j*10)],1,0,c_white,1) // Tunnling Bomb
            /* Arrow           */ if (tile_type[i+(j*10)]==3) draw_sprite_ext(Right_Arrow_Sprite,animation mod 30,((i+14)*grid_size)+(17-(flip_animation[i+(j*10)]*17)),(j+6)*grid_size,flip_animation[i+(j*10)],1,0,c_white,1) // Arrow
            /* Dimond          */ if (tile_type[i+(j*10)]==4) draw_sprite_ext(Dimond_Sprite,0,((i+14)*grid_size)+(17-(flip_animation[i+(j*10)]*17)),(j+6)*grid_size,flip_animation[i+(j*10)],1,0,c_white,1) // Dimond
            /* Go Number Black */ if (tile_type[i+(j*10)]==5) draw_sprite_ext(Go_Number_Black_Sprite,0,((i+14)*grid_size)+(17-(flip_animation[i+(j*10)]*17)),(j+6)*grid_size,flip_animation[i+(j*10)],1,0,c_white,1) // Go Number Black
            /* Alumax          */ if (tile_type[i+(j*10)]==6) draw_sprite_ext(Alumax_Sprite,0,((i+14)*grid_size)+(17-(flip_animation[i+(j*10)]*17)),(j+6)*grid_size,flip_animation[i+(j*10)],1,0,c_white,1) // Alumax
            /* R Arrow         */ if (tile_type[i+(j*10)]==7) draw_sprite_ext(R_Arrow_Sprite,0,((i+14)*grid_size)+(17-(flip_animation[i+(j*10)]*17))+17,((j+6)*grid_size)+17,flip_animation[i+(j*10)],1,180,c_white,1) // R Arrow
            /* Boulder         */ if (tile_type[i+(j*10)]==8) draw_sprite_ext(Boulder_Sprite,0,((i+14)*grid_size)+(17-(flip_animation[i+(j*10)]*17)),(j+6)*grid_size,flip_animation[i+(j*10)],1,0,c_white,1) // Boulder
            /* Teleport        */ if (tile_type[i+(j*10)]==9) draw_sprite_ext(Teleport_Dark_Blue,animation mod 20,((i+14)*grid_size)+(17-(flip_animation[i+(j*10)]*17)),(j+6)*grid_size,flip_animation[i+(j*10)],1,0,c_white,1) // Teleport
            if (tile_type[i+(j*10)]==1 or tile_type[i+(j*10)]==5) // If the tile has a number on it
            {
                draw_set_halign(fa_center)
                draw_set_valign(fa_center)
                draw_set_font(Go_Number)
                draw_set_color(c_black)
                draw_text(((i+14)*grid_size)+17,((j+6)*grid_size)+17,tile_type[i+(j*10)])
                draw_set_halign(0)
                draw_set_valign(0)                
            }
        }
    }
}
animation += 1

// Draws out the scores
if (instance_number(Player_Select)==0)
{
    draw_sprite(Player_Select_Sprite,0,455,0)
    draw_sprite(Connect_4_P1_Sprite,0,350,0)
    draw_sprite(Connect_4_P2_Sprite,0,805,0)
    draw_set_font(Player_Select_Font)
    draw_set_color(c_black)
    draw_set_halign(fa_center)
    draw_set_valign(fa_middle)
    draw_text(room_width/2,17,global.text_matches)
    draw_set_font(Go_Number)
    draw_set_color(c_red)
    draw_text(350+106,17,global.Player_One+": "+string(player_matches[1]))
    draw_set_font(Go_Number)
    draw_set_color(c_black)
    draw_text(805+106,17,global.Player_Two+": "+string(player_matches[2]))
    draw_set_halign(0)
    draw_set_halign(0)
}

// Draws out the keyboard numbers
if (key_stage > 0)
{
    if (player_turn == 1)
    {
        draw_set_color(c_red)
    }
    else
    {
        draw_set_color(c_black)
    }
    draw_set_font(Go_Number)
    draw_set_halign(fa_center)
    draw_set_valign(fa_middle)
    var i;
    var num;
    if (key_stage == 1)
    {
        for (i = 0; i < 10; i += 1)
        {
            if (player_turn == 1) 
            {
                draw_sprite(Go_Number_Red_Sprite, 0, (i+14)*grid_size, 5*grid_size)
            } 
            else 
            {
                draw_sprite(Go_Number_Black_Sprite, 0, (i+14)*grid_size, 5*grid_size)
            }
            if (i < 9) {num = i + 1;} else {num = 0;} 
            draw_text(((i+14)*grid_size)+17, (5*grid_size)+17, string(num))
        }
    }
    else 
    {
        var selected_col_num;
        if (selected_col > 0) {selected_col_num = selected_col - 1;} else {selected_col_num = 9} 
        if (player_turn == 1) 
        {
            draw_sprite(Go_Number_Red_Sprite, 0, (selected_col_num+14)*grid_size, 5*grid_size)
        } 
        else 
        {
            draw_sprite(Go_Number_Black_Sprite, 0, (selected_col_num+14)*grid_size, 5*grid_size)
        }

        for (i = 0; i < 10; i += 1)
        {
            if (player_turn == 1) 
            {
                draw_sprite(Go_Number_Red_Sprite, 0, 13*grid_size, (i+6)*grid_size)
            } 
            else 
            {
                draw_sprite(Go_Number_Black_Sprite, 0, 13*grid_size, (i+6)*grid_size)
            }
            if (i < 9) {num = i + 1;} else {num = 0} 
            draw_text((13*grid_size)+17, ((i+6)*grid_size)+17, string(num))
        }
    }
    draw_set_halign(0)
    draw_set_valign(0)
}

#define Memory_Click
// Memory_Click
// Stefan Grace
// Created: 2017-09-20
// Modified: 2023-01-14
// This script draws turns over the tiles where they are clicked

// Stops the user from clicking a tile before the game has started
if (player_turn==0) exit


if (argument0 == 0) // If the script has been initiated with the mouse
{
    // Stops the user from clicking outside of the memory tiles
    if (mouse_x<14*grid_size)
    or (mouse_x>24*grid_size)
    or (mouse_y<6*grid_size)
    or (mouse_y>16*grid_size)
    {
        exit
    }

    // Stops the user from clicking a tile when 2 tiles have already been clicked
    if (tile_clicked_sum>=1) exit
    var a;
    var b;
    var c;
    var i;

    // Converts mouse_x to horizonal tile index
    a = mouse_x - (mouse_x mod grid_size)
    a /= grid_size
    a -= 14

    // Converts mouse_y to vertical tile index
    b = mouse_y - (mouse_y mod grid_size)
    b /= grid_size
    b -= 6
}
else // If the script has been initiated with the keyboard
{
    if (argument1 == 0) {a = 9;} else {a = argument1 - 1;}
    if (argument2 == 0) {b = 9;} else {b = argument2 - 1;}
}

// Converts the horizonal and vertical tile indexes into a tile id
c = a+(b*10)

// Stops the user from clicking a tile that is alreay matched
if (tile_matched[c]>0) exit

// Stops the user from clicking a tile that is alreay clicked
if (tile_clicked[c]>0) exit

// Makes the message come up when the user clicks a tile for the first time
if (!message_has_shown)
{
    level24messagenumber = 1
    message_has_shown = true
    if (instance_number(Message_Object) == 0) 
    {
        global.message_type = 41
        instance_create(945, 315, Message_Object)
    }
}

// Sets last_tile_clicked to the id of the tile that was last clciked
for(i = 0; i<100; i += 1)
{
    if (tile_clicked[i]>0) last_tile_clicked = i
}

// Starts the tile flip animation when the tile has been clicked
flip_animation[c] -= 0.2

// Sets tile_clicked_id to c
tile_clicked_id = c

// Counts how many tiles have been clicked
for(i = 0; i<100; i += 1)
{   
    tile_clicked_sum += tile_clicked[i]
}


        
#define Memory_Match
// Memory_Match
// Stefan Grace
// Created: 2017-09-22
// Modified: 2017-09-24

// Checks if both tiles that have been clciked are the same type, 
// then if so changes them into matched tiles, 
// if not changes them back to unfliped and changes the player turn
if (tile_type[tile_clicked_id]==tile_type[last_tile_clicked])
{
    tile_matched[tile_clicked_id] = 1
    tile_matched[last_tile_clicked] = 1
    player_matches[player_turn] += 1
    tile_clicked[tile_clicked_id] = 0
    tile_clicked[last_tile_clicked] = 0
}
else
{
    if(player_turn==1) 
    {    
        player_turn = 2
    }
    else 
    {
        player_turn = 1
    }
    flip_animation[tile_clicked_id] -= 0.2
    flip_animation[last_tile_clicked] -= 0.2
}
tile_clicked_sum = 0
alarm_0_set = 0
#define Memory_Script
// Memory_Script
// Stefan Grace
// Created: 2017-09-22
// Modified: 2017-09-24
// This script is executed every step on the Memory level (Level 24)

var i;
var tile_matched_sum;

// Changes the go number into the player's turn
if (instance_number(Go_Number_Red)>0) 
{
    with(Go_Number_Red) instance_change(Connect_4_P1_Turn,false)
    player_turn = 1
}
if (instance_number(Go_Number_Black)>0) 
{
    with(Go_Number_Black) instance_change(Connect_4_P2_Turn,false)
    player_turn = 2
}

// Gets rid of the Draw Mode button
if (instance_number(Draw_Mode_Red)>0) with(Draw_Mode_Red) instance_destroy()
if (instance_number(Draw_Mode_Black)>0) with(Draw_Mode_Black) instance_destroy()

// Changes the Player's turn
if (player_turn==1) with(Connect_4_P2_Turn) instance_change(Connect_4_P1_Turn,false)
if (player_turn==2) with(Connect_4_P1_Turn) instance_change(Connect_4_P2_Turn,false)

// Makes the player that has the heighest matches win when all tiles have been matched
for (i = 0; i<100; i += 1)
{
    tile_matched_sum += tile_matched[i]
}
if (tile_matched_sum>=100)
{
    if (player_matches[1]>player_matches[2]) and (instance_number(Player_One_Winz)==0) instance_create(0,0,Player_One_Winz)
    if (player_matches[1]<player_matches[2]) and (instance_number(Player_Two_Winz)==0) instance_create(0,0,Player_Two_Winz)
    if (player_matches[1]==player_matches[2]) 
    {
        for (i = 0; i<100; i += 1)
        {
            tile_matched[i] = 0
            tile_clicked[i] = 0
        }
        script_execute(Memory_Start)
    }
}

// If 2 tiles have been clicked wait 1 second, then if they are both the same type change them into matched 
if (tile_clicked_sum>=1 and alarm_0_set==0) 
{
    alarm[0] = 30
    alarm_0_set = 1
    with(Message_Object) instance_destroy()
}

// Controls the flip animation
for(i = 0; i<100; i += 1)
{   
    if (flip_animation[i]<1)
    {
        if (flip_has_hit_0[i]==0)
        {
            if(flip_animation[i]>0.2) 
            {
                flip_animation[i] -= 0.2 
            }
            else 
            {
                flip_has_hit_0[i] = 1
                if (tile_clicked[i]==0) tile_clicked[i] = 1 else tile_clicked[i] = 0
            }
        }
        else
        {
            flip_animation[i] += 0.2 
        }
    }
    else
    {
        flip_has_hit_0[i] = 0
    }
}

#define Memory_Keyboard
if (player_turn==0) exit

if (key_stage < 2)
{
    selected_col = argument0
    key_stage = 2
}
else
{
    Memory_Click(1, selected_col, argument0)
    key_stage = 0
}
#define Music_Script
// Music_Script
// Stefan Grace
// Created: 2016-07-03
// Modified: 2016-07-03
// This script plays the music

if ((global.Music_Playing==1) and (!(sound_isplaying(OXTriangle_Music))))
{
    if (Last_Music==0)
    {
        random_number = random(5)
        if (random_number<1) script_execute(Music_One_Script)
        else if (random_number<2) script_execute(Music_Two_Script)
        else if (random_number<3) script_execute(Music_Three_Script)
        else if (random_number<4) script_execute(Music_Four_Script)
        else script_execute(Music_Five_Script)
    }
    else if (Last_Music==1) 
    {
        random_number = random(4)
        if (random_number<1) script_execute(Music_Two_Script)
        else if (random_number<2) script_execute(Music_Three_Script)
        else if (random_number<3) script_execute(Music_Four_Script)
        else script_execute(Music_Five_Script)
    }
    else if (Last_Music==2)
    {
        random_number = random(4)
        if (random_number<1) script_execute(Music_One_Script)
        else if (random_number<2) script_execute(Music_Three_Script)
        else if (random_number<3) script_execute(Music_Four_Script)
        else script_execute(Music_Five_Script)
    }
    else if (Last_Music==3)
    {
        random_number = random(4)
        if (random_number<1) script_execute(Music_One_Script)
        else if (random_number<2) script_execute(Music_Two_Script)
        else if (random_number<3) script_execute(Music_Four_Script)
        else script_execute(Music_Five_Script)
    }
    else if (Last_Music==4)
    {
        random_number = random(4)
        if (random_number<1) script_execute(Music_One_Script)
        else if (random_number<2) script_execute(Music_Two_Script)
        else if (random_number<3) script_execute(Music_Three_Script)
        else script_execute(Music_Five_Script)
    }
    else if (Last_Music==5)
    {
        random_number = random(4)
        if (random_number<1) script_execute(Music_One_Script)
        else if (random_number<2) script_execute(Music_Two_Script)
        else if (random_number<3) script_execute(Music_Three_Script)
        else script_execute(Music_Four_Script)
    }   
    sound_play(OXTriangle_Music)
}
#define Music_One_Script
OXTriangle_Music = sound_add("Music/Bit_Quest.mp3",3,false)
Last_Music = 1
#define Music_Two_Script
OXTriangle_Music = sound_add("Music/Mellowtron.mp3",3,false)
Last_Music = 2
#define Music_Three_Script
OXTriangle_Music = sound_add("Music/Move_Forward.mp3",3,false)
Last_Music = 3
#define Music_Four_Script
OXTriangle_Music = sound_add("Music/The_Complex.mp3",3,false)
Last_Music = 4
#define Music_Five_Script
OXTriangle_Music = sound_add("Music/Walk_Home_Solar.mp3",3,false)
Last_Music = 5
#define Anger_Number_Script
// Anger_Number_Script
// Stefan Grace
// Created: I don't know
// Modified: 2016-07-18
// This script displays the number on an anger

/*
argument0 = Anger Color
    0 = Red
    1 = Orange
    2 = Blue
    3 = Purple
*/

// This block of code sets the font
draw_set_font(Go_Number)
draw_set_color(c_black)

// This block of code displays the correct color anger
if (argument0==0) draw_sprite(Red_Anger_Sprite,-1,x,y)
if (argument0==1) draw_sprite(Orange_Anger_Sprite,-1,x,y)
if (argument0==2) draw_sprite(Blue_Anger_Sprite,-1,x,y)
if (argument0==3) draw_sprite(Purple_Anger_Sprite,-1,x,y)

// This block of code displays the number in the correct place
if (((!(Number==1)) and (Number<10)) or (place_meeting(x,y,Anger_01))) draw_text(x+10,y+2,Number)
if (Number>=10) draw_text(x+3,y+2,Number)
#define Go_Number_Script
// Go_Number_Script
// Stefan Grace
// Created: I don't know
// Modified: 2024-07-24
// This script displays the go number

/*
argument0 = Player Number
    1 = Player 1
    2 = Player 2
*/

if (score < 100) 
{ 
    draw_set_font(Go_Number)
}
else
{
    draw_set_font(Go_Number_Small)
}


if (argument0 == 1)
{
    draw_sprite(Go_Number_Red_Sprite,0,x,y)
    draw_set_color(c_red)
}
else if (argument0 == 2)
{
    draw_sprite(Go_Number_Black_Sprite,0,x,y)
    draw_set_color(c_black)
}

draw_set_halign(fa_center)
draw_set_valign(fa_middle)
draw_text(x + (sprite_width / 2), y + (sprite_height / 2), score)
draw_set_halign(0)
draw_set_valign(0)
#define Level_Number_Script
// Level_Number_Script
// Stefan Grace
// Created: 2016-07-02
// Modified: 2024-07-24
// This script draws the green level number in the bottom right corner

draw_set_halign(fa_center)
draw_set_valign(fa_middle)
draw_set_color(c_lime)
draw_set_font(Go_Number)

draw_sprite(Level_Number_Sprite, 0, x, y)
draw_text(x + (sprite_width / 2), y + (sprite_height / 2), global.levelnumber)

draw_set_halign(0)
draw_set_valign(0)
#define NWH_Count_Script
// NWH_Count_Script
// Stefan Grace
// Created: 2016-06-29
// Modified: 2018-11-06

/* arguments

argument0 - Player
    1 - Player 1
    2 - Player 2
*/


var place_fill_red;
var place_fill_black;
var i;
for (i = 0; i < 6; i += 1)
{
    place_fill_red_red[i] = false
    place_fill_black[i] = false
}
with(all)
{
    var tile_x;
    var tile_y;
    tile_x = x - (x mod grid_size)
    tile_y = y - (y mod grid_size)
    if (character_id + character_o > 0)
    {
        if (player == 1 and argument0 == 1)
        {
            if (tile_x == other.x - grid_size)
            {
                if (tile_y == other.y - grid_size) place_fill_red[0] = true
                else if (tile_y == other.y) place_fill_red[1] = true
                else if (tile_y == other.y + grid_size) place_fill_red[2] = true
            }
            else if (tile_x == other.x + grid_size)
            {
                if (tile_y == other.y - grid_size) place_fill_red[3] = true
                else if (tile_y == other.y) place_fill_red[4] = true
                else if (tile_y == other.y + grid_size) place_fill_red[5] = true
            }
        } 
        if (player == 2 and argument0 == 2)
        {
            if (tile_x == other.x - grid_size)
            {
                if (tile_y == other.y - grid_size) place_fill_black[0] = true
                else if (tile_y == other.y) place_fill_black[1] = true
                else if (tile_y == other.y + grid_size) place_fill_black[2] = true
            }
            else if (tile_x == other.x + grid_size)
            {
                if (tile_y == other.y - grid_size) place_fill_black[3] = true
                else if (tile_y == other.y) place_fill_black[4] = true
                else if (tile_y == other.y + grid_size) place_fill_black[5] = true
            }
        } 
    }
}
var places_filled_red;
places_filled_red = 0
var places_filled_black;
places_filled_black = 0
var i;
for (i = 0; i < 6; i += 1)
{
    if (place_fill_red[i]) places_filled_red += 1
    if (place_fill_black[i]) places_filled_black += 1
}
if (places_filled_red >= 6)
{
    if (count < 5) count += 1
}
if (places_filled_black >= 6)
{
    if (count > -5) count -= 1
}
#define NWH_Detonate_Script
// Nuclear War Head Detonate Scrip 
// Stefan Grace
// Created: 2016-06-29
// Modified: 2016-06-29
// This scrip makes the Nuclear War Head detonate when the player click on it and then clicks in another place

if(instance_number(NWH_Target)==0) instance_create(mouse_x,mouse_y,NWH_Target)

#define NWH_Target_Mouse_Script
// Nuclear War Head Detonate Scrip 
// Stefan Grace
// Created: 2016-07-18
// Modified: 2018-11-07
// This scrip makes the Nuclear War Head Target follow the mouse

if Target_Clicked==0
{
    x=mouse_x-(mouse_x mod grid_size)
    y=mouse_y-(mouse_y mod grid_size)
}
else
{
    if(place_meeting(x,y,NWH_Missile))
    {
        instance_create(x,y,NWH_Ring)
        with(NWH_Missile) instance_destroy()
        if (!(sound_isplaying(M_Sound))) sound_play(M_Sound)
        instance_create(x,y,NWH_Explosion_Center)
        global.game_frozen = 0
        instance_destroy()
    }
}
#define NWH_Set_Script
// Nuclear War Head Set Scrip 
// Stefan Grace
// Created: 2016-07-18
// Modified: 2017-08-26

if(instance_number(NWH_Missile)==0 and instance_number(NWH_Target)>0)
{
    instance_create(x,y,NWH_Missile)
}
#define NWH_Missile_Script
// Nuclear War Head Missile Scrip 
// Stefan Grace
// Created: 2016-07-18
// Modified: 2017-11-03
// This script controls the Nuclear War Head Missile 

if (y>-100 and !gone_up) 
{
    y -= 4
    //x += x - ((sqr(NWH_Target.x) / sqrt(NWH_Target.x)) / 500)
    if (x>NWH_Target.x) x -= 2
    if (x<NWH_Target.x) x += 2
    image_angle = 90
}
else if (turned<20)
{
    //image_angle = (((point_direction(x,y,NWH_Target.x,NWH_Target.y) * turned) + (90 * (20 - turned))) / 40) + 180
    turned += 1
}
else
{
    move_towards_point(NWH_Target.x,NWH_Target.y,4)
    gone_up = true
    image_angle = point_direction(x,y,NWH_Target.x,NWH_Target.y)
}




#define NWH_Ring_Draw
// NWH_Ring_Draw
// Stefan Grace
// Created: 2017-08-29
// Modified: 2017-08-29
// This script draw the NWH explosion ring

var j;
for(j=0;j<50;j+=0.5)
{
    draw_circle_color(x,y,i+j,c_orange,c_orange,true)
}
i+=5
#define NWH_Draw
// NWH_Draw
// Stefan Grace
// Created: 2018-11-06
// Modified: 2018-11-06
// This script draws the center of the NWH including the number

draw_sprite(NWH_Sprite,0,x,y)
draw_set_halign(fa_center)
draw_set_valign(fa_middle)
draw_set_font(NWH_Font)
if (count > 0) 
{
    draw_set_color(character_color_red)
}
else if (count < 0) 
{
    draw_set_color(character_color_black)
}
else
{
    draw_set_color(character_color_green)
}
draw_text(x + 17,y + 17,sqrt(sqr(count)))
draw_set_halign(0)
draw_set_valign(0)
#define Old_Alumax_message
message_background (Message_background)
message_button (Message_button) 
message_button_font (font,11,blue,bold)
show_message ("Alumax is not yet Implemented.#Coming Soon!!!")

#define Start_Level_0
// Start Level 0
// Stefan Grace
// Created: 2015-06-18
// Modifed: 2015-06-18

//if (global.Level_0_Save > 0) game_load(Save_Level_0)
//else global.Level_0_Save = 1

//room_goto(Level_0)
#define Level_Number
draw_set_font(Go_Number);
draw_text_color(0,0,global.levelnumber,c_green,c_green,c_green,c_green,100);
#define Level_Number_10
draw_set_font(Go_Number);
draw_text_color(3,3,score,c_green,c_green,c_green,c_green,100);
#define Box_Of_Four_Red_Message
message_background (Message_background)
message_button (Message_button) 
message_button_font (font,11,blue,bold)
show_message ("Only 4 characters can occupy a box at any one time")
box_of_4_red = 1
#define Go_Number_Red_10
draw_set_font(Go_Number);
draw_text_color(3,3,score,c_red,c_red,c_red,c_red,100);
#define Go_Number_Black_10
draw_set_font(Go_Number);
draw_text_color(3,3,score,c_black,c_black,c_black,c_black,100);
#define Go_Number_Back
draw_set_font(Go_Number);
draw_text_color(10,3,score,c_black,c_black,c_black,c_black,100);
#define Anger_Number_10
draw_set_font(Go_Number);
draw_text_color(x+3,y+2,Number,c_black,c_black,c_black,c_black,100);
#define Red_X_Kill_Script
// X_Kill_Script
// Stefan Grace
// Created: 2016-07-16
// Modified: 2016-07-16
// This script makes two characters interact when they are both in the same box but in differnt places

/*
argument0
    0 = No Kill
    1 = Blue Kills Stuned
    2 = Stuned Kills Blue
*/

with Red_Blue_X 
{
    if (place_snapped(35,35)) global.other_is_snapped = 1
}
if (global.other_is_snapped==1)
{
    if ((place_meeting(Red_Blue_X,x-17,y)) or (place_meeting(Red_Blue_X,x,y-17)) or (place_meeting(Red_Blue_X,x-17,y-17)))
    {
        if ((Red_Blue_X.Kill==1) or (argument0==1)) instance_destroy()
        if (argument0==2) with(Red_Blue_X) instance_destroy()
    }
    global.other_is_snapped = 0
}
#define Alumax_Characters_Code
// Alumax Characters Script
// Stefan Grace
// Created: 2015-06-19
// Modifed: 2015-06-24

with(Alumax_Backdrop) sprite_index = Alumax_Characters //changes 'Alumax - Index' to 'Alumax - Characters'
with(Objects_Button) instance_destroy() //gets rid of the objects button
instance_create(35,642,Index_Button) //creates the index button

//creates character buttons
instance_create(315,490,O_Button_Object)
instance_create(420,490,X_Button_Object)
instance_create(525,490,Triangle_Button_Object)
instance_create(630,490,A_Button_Object)
instance_create(735,490,Square_Button_Object)
instance_create(840,490,K_Button_Object)
instance_create(945,490,B_Button_Object)

//gets rid of the character button
instance_destroy()
#define Alumax_Objects_Code
// Alumax Objects Script
// Stefan Grace
// Created: 2015-06-19
// Modified: 2015-06-19

with(Alumax_Backdrop) sprite_index = Alumax_Objects
with(Character_Button) instance_destroy()
instance_create(35,642,Index_Button)
instance_create(315,490,Boulder_Button_Object)
instance_create(420,490,Bomb_Button_Object)
instance_destroy()
#define Alumax_Index_Code
// Alumax Index Script
// Stefan Grace
// Created: 2015-06-19
// Modified: 2015-06-24

with(Alumax_Backdrop) sprite_index = Alumax_index
instance_create(280,495,Character_Button)
instance_create(700,495,Objects_Button)
if(instance_number(O_Button_Object) > 0) script_execute(Remove_Character_Buttons,0,0,0,0,0)
if(instance_number(Boulder_Button_Object) > 0) script_execute(Remove_Object_Buttons,0,0,0,0,0)
instance_destroy()
#define Alumax_Exit_Code
// Alumax Exit
// Stefan Grace
// Created: 2015-06-16
// Modified: 2016-07-02

with(Alumax_Wood) instance_destroy()
with(Character_Button) instance_destroy()
with(Objects_Button) instance_destroy()
with(Alumax_Backdrop) instance_destroy()
with(Index_Button) instance_destroy()
if(instance_number(O_Button_Object) > 0) script_execute(Remove_Character_Buttons,0,0,0,0,0)
if(instance_number(Boulder_Button_Object) > 0) script_execute(Remove_Object_Buttons,0,0,0,0,0)
instance_destroy()

#define Remove_Character_Buttons
// Remove Character Buttons
// Stefan Grace
// Created: 2015-06-24
// Modifed: 2015-06-24

with(O_Button_Object) instance_destroy()
with(X_Button_Object) instance_destroy()
with(Triangle_Button_Object) instance_destroy()
with(A_Button_Object) instance_destroy()
with(Square_Button_Object) instance_destroy()
with(K_Button_Object) instance_destroy()
with(B_Button_Object) instance_destroy()

#define Remove_Object_Buttons
// Remove Object Buttons
// Stefan Grace
// Created: 2015-06-24
// Modifed: 2015-06-24

with(Boulder_Button_Object) instance_destroy()
with(Bomb_Button_Object) instance_destroy()

#define Get_Neutral_Characters_Red
// Get_Neutral_Characters
// Stefan Grace
// Created: 2016-08-26
// Modified: 2016-08-26
// This script makes Player 1's character get neutral characters

if (place_meeting(x,y,Green_O)) with(Green_O) instance_change(Red_O,false)
#define Joy_Move
if (Joy_Press==0)
{
    script_execute(Character_Move,argument0,argument1,argument2)
    Joy_Press=1
    alarm[1] = 15
}
#define Boulder_Push
// Boulder_Push
// Stefan Grace
// Created: 2016-07-19
// Modified: 2016-07-19
// This is is executed when a charater pushed a boulder

if keyboard_check(vk_left) x = x-35
if keyboard_check(vk_right) x = x+35
#define Character_Kill_G
// Character_Kill_G
// Stefan Grace
// Created: 2017-12-12
// Modified: 2017-12-12

// Kill
/*
with(all)
{
    if (Kill>0 
    or character_id==1 
    or character_id==2
    or character_id==3
    or character_id==7
    or character_id==9
    or character_id==14
    ){
        if(place_meeting(x,y,other))
        {
            with(other) g_hit -= 1
        }
    }
}*/
#define Rock_In_The_Way_Detect
var k;
if (argument0 > 0) k = 1; else if (argument0 < 0) k = -1; else k = 0
var rock_in_the_way;
var j;
for (j = argument0; j != 0; j -= k)
{
    if (!place_meeting(x - (j * grid_size), y, Yellow) and argument1 == 0)
    {
        rock_in_the_way = true;
    }
    else if (!place_meeting(x, y - (j * grid_size), Yellow) and argument1 == 1)
    {
        rock_in_the_way = true;
    }
}
return rock_in_the_way
#define Box_Four_Message
message_background (Message_background)
message_button (Message_button) 
message_button_font (font,11,blue,bold)
show_message (global.text_box_four_message)
#define Character_Teleport_Interaction
if (place_meeting(x,y,Teleport))
{
    var teleport_x;
    var teleport_y;
    with(Teleport)
    {
        if (place_meeting(x,y,other))
        {
            var port_color;
            var port_side;
            port_color = color
            port_side = side
            with (Teleport)
            {
                if (color==port_color and side!=port_side)
                {
                    teleport_x = x
                    teleport_y = y
                }
            }
        }
    }
    if (other.x - (other.x mod grid_size) == teleport_x and other.y - (other.y mod grid_size) == teleport_y) 
    {
        return true
    }
}
return false
#define Teleport_Character
// Teleport_Character
// Stefan Grace
// Created: 2017-10-01
// Modified: 2017-10-01
// This script teleports characters when the ALT key is pressed

var port_color;
var port_side;
port_color = color
port_side = side

with(all)
{
    if (place_meeting(x,y,other) and (type==2 or type==5) and global.gone_port==0)
    {
        global.gone_port = 1
        with(other) alarm [0] = 1
        with(Teleport)
        {
            if (color==port_color and side!=port_side)
            {
                other.x = x
                other.y = y
            }
        }
    }
}
#define Teleport_Draw
// Draws the Teleport
if (color==0) draw_sprite(Teleport_Brown,-1,x,y)
if (color==1) draw_sprite(Teleport_Dark_Blue,-1,x,y)
if (color==2) draw_sprite(Teleport_Forest_Green,-1,x,y)
if (color==3) draw_sprite(Teleport_Grey,-1,x,y)
if (color==4) draw_sprite(Teleport_Green,-1,x,y)
if (color==5) draw_sprite(Teleport_Light_Blue,-1,x,y)
if (color==6) draw_sprite(Teleport_Orange,-1,x,y)
if (color==7) draw_sprite(Teleport_Pink,-1,x,y)

// Draws Boulders and Bombs that are in the Teleport
var port_color;
var port_side;
var boulder_bomb_type;
port_color = color
port_side = side
with(Boulder)
{
    if (place_meeting(x,y,other))
    {
        if (time_bomb>0) 
        {
            boulder_bomb_type = 6
        }
        else if (j_bomb>0)
        {
            boulder_bomb_type = 5
        }
        else if (nuclear>0)
        {
            boulder_bomb_type = 4
        }
        else if (concreet_tunnle>0)
        {
            boulder_bomb_type = 3
        }
        else if (dimond_tunnle>0)
        {
            boulder_bomb_type = 2
        }
        else if (rock_tunnle>0)
        {
            boulder_bomb_type = 1
        }
        else 
        {
            boulder_bomb_type = 0
        }
        with(Teleport)
        {
            if (color==port_color and side!=port_side)
            {
                if (boulder_bomb_type==0) draw_sprite(Boulder_Sprite,0,x,y)
                if (boulder_bomb_type==1) draw_sprite(Tunnling_Bomb_Sprite,0,x,y)
                if (boulder_bomb_type==2) draw_sprite(Dimond_Bomb_Sprite,0,x,y)
                if (boulder_bomb_type==3) draw_sprite(Concreet_Bomb_Sprite,0,x,y)
                if (boulder_bomb_type==4) draw_sprite(Nuclear_Bomb_Sprite,0,x,y)
                if (boulder_bomb_type==5) draw_sprite(J_Bomb_Sprite,0,x,y)
                if (boulder_bomb_type==6) draw_sprite(Time_Bomb_Sprite,0,x,y)
            }
        }
    }
}
#define Teleport_Explosion
// Teleport_Explosion
// Stefan Grace
// Created: 2017-08-19
// Modified: 2017-12-23
// This scirpt teleports M and J explosions

/* arguments

argument 0 - explosion type
    0 - M
    1 - J
    2 - $

*/

with (Teleport)
{
    if (place_meeting(x,y,other))
    {
        var port_color;
        var port_side;
        port_color = color
        port_side = side
        with (Teleport)
        {
            if (color==port_color and side!=port_side) 
            {
                if (argument0==0) script_execute(M_Detonate)
                if (argument0==1) script_execute(J_Detonate)
                if (argument0==2) script_execute(Dollar_Sign_Stun_Create)
            }
        }
    }
}
#define Teleport_Step
var port_color;
var port_side;
port_color = color
port_side = side
with (Boulder) 
{
    if (place_meeting(x,y,other) and global.gone_port==0)
    {
        global.gone_port = 1
        with (other) alarm[0] = 1
        with (Teleport)
        {
            if (color==port_color and side!=port_side)
            {
                other.x = x
                other.y = y
            }
        }
    } 
}
with (R_Arrow) 
{
    if (place_meeting(x,y,other) and global.gone_port==0)
    {
        global.gone_port = 1
        with (other) alarm[0] = 1
        with (Teleport)
        {
            if (color==port_color and side!=port_side)
            {
                other.x = x
                other.y = y
            }
        }
    }
}
with (Explosion) 
{
    if (place_meeting(x,y,other) and global.gone_port==0)
    {
        global.gone_port = 1
        with (other) alarm[0] = 1
        with (Teleport)
        {
            if (color==port_color and side!=port_side)
            {
                instance_create(x,y,Explosion)
            }
        }
    }
}
with (Red_Blue_G) 
{
    if (g_type!=3) if (place_meeting(x,y,other) and global.gone_port==0)
    {
        global.gone_port = 1
        with (other) alarm[0] = 1
        with (Teleport)
        {
            if (color==port_color and side!=port_side)
            {
                instance_create(x,y,Explosion)
            }
        }
    }
}
with (Black_Blue_G) 
{
    if (g_type!=3) if (place_meeting(x,y,other) and global.gone_port==0)
    {
        global.gone_port = 1
        with (other) alarm[0] = 1
        with (Teleport)
        {
            if (color==port_color and side!=port_side)
            {
                instance_create(x,y,Explosion)
            }
        }
    }
}
#define Gate_Toggle
gate_open = !gate_open
score -= 1
if (gate_open)
{
    Gate_Destroy()
    Gate_Open_Create()
    sound_stop(Gate_Close_Sound)
    sound_stop(Gate_Open_Sound)
    sound_play(Gate_Open_Sound)
}
else
{
    Gate_Destroy()
    Gate_Closed_Create()
    sound_stop(Gate_Open_Sound)
    sound_stop(Gate_Close_Sound)
    sound_play(Gate_Close_Sound)
}
#define Gate_Closed_Create
for (i=grid_size; i<=gate_size*2*grid_size; i+=grid_size)
{
    if (gate_type==0) barria_objects[(i-1)/grid_size] = instance_create(x,y+i,Barria_Vertical)
    if (gate_type==1) barria_objects[(i-1)/grid_size] = instance_create(x+i,y,Barria_Horizontal)
    if (gate_type==2) barria_objects[(i-1)/grid_size] = instance_create(x+grid_size,y+i,Barria_Vertical)
    if (gate_type==3) barria_objects[(i-1)/grid_size] = instance_create(x+i,y+grid_size,Barria_Horizontal)
    barria_objects[(i-1)/grid_size].gate = true
}
#define Gate_Open_Create
var index;
index = 0
var i;
for (i=grid_size; i<=gate_size*grid_size; i+=grid_size)
{
        if (gate_type==0) 
        {
            barria_objects[index] = instance_create(x-i,y+grid_size,Barria_Horizontal)
            barria_objects[index+1] = instance_create(x-i,y+grid_size+(grid_size*2*gate_size),Barria_Horizontal)
        }
        else if (gate_type==1) 
        {
            barria_objects[index] = instance_create(x+grid_size,y-i,Barria_Vertical)
            barria_objects[index+1] = instance_create(x+grid_size+(grid_size*2*gate_size),y-i,Barria_Vertical)
        }
        else if (gate_type==2) 
        {
            barria_objects[index] = instance_create(x+i,y+grid_size,Barria_Horizontal)
            barria_objects[index+1] = instance_create(x+i,y+grid_size+(grid_size*2*gate_size),Barria_Horizontal)
        }
        else if (gate_type==3) 
        {
            barria_objects[index] = instance_create(x+grid_size,y+i,Barria_Vertical)
            barria_objects[index+1] = instance_create(x+grid_size+(grid_size*2*gate_size),y+i,Barria_Vertical)
        }
        barria_objects[index].gate = true
        barria_objects[index+1].gate = true
        index += 2
}
#define Gate_Destroy
var i;
for (i = 0; i < 36; i += 1)
{
    if (barria_objects[i] != 0) with(barria_objects[i]) instance_destroy()
}
#define Enter_Design_Mode
room_goto(Level_Designer)
global.levelnumber = 100
global.designing = true
#define Draw_Item_Select_Button
// Draw_Item_Select_Button
// Stefan Grace
// Created: 2024-08-05
// Modified: 2024-08-05
// This script draw the item select buttons at the top of the Level Designer


draw_set_font(Level_Designer_Item_Select_Font)
draw_set_halign(fa_center)
draw_set_valign(fa_middle)
draw_set_color(button_color)

if (Level_Designer_Control.item_select == selection_index)
{
    draw_rectangle(x, y, x + sprite_width, y + sprite_height, false)
    draw_set_color(c_white)
}
else
{
    var button_sprite;
    switch (button_color)
    {
        case c_red: button_sprite = Player_One_Sprite; break;
        case c_black: button_sprite = Player_Two_Sprite; break;
        case c_lime: button_sprite = Player_Random_Sprite; break;
        default: button_sprite = Level_Design_Button_Sprite; break;
    }
    draw_sprite(button_sprite, 0, x, y)
}

draw_text(x + round(sprite_width / 2), y + round(sprite_height / 2), button_text)
draw_set_halign(0)
draw_set_valign(0)



#define Set_Design_Item_Select
Level_Designer_Control.object_select = -1
Level_Designer_Control.item_select = selection_index
#define Level_Designer_Draw
var char_draw_offset; char_draw_offset = 9;
var dray_y; draw_y = 21 * grid_size;
draw_set_font(Character_Font)
draw_set_halign(fa_center)
draw_set_valign(fa_center)

switch(item_select)
{
    case 1: // Player 1 characters
    case 2: // Player 2 character
    case 3: // Neutral character
        var num_tiles;
        var background;
        switch (item_select)
        {
            case 1:
            case 2:
                num_tiles = 36
                background = Yellow_Sprite
                break;
            case 3:
                num_tiles = 35
                background = Yellow_Sprite
                break;
        }
        var i;
        for(i = 0; i < num_tiles; i += 1)
        {
            switch(item_select)
            {
                case 1: draw_set_color(character_color_red); break;
                case 2: draw_set_color(character_color_black); break;
                case 3: draw_set_color(character_color_green); break;        
            }
            if (object_select == i || object_mouse_select == i)
            {
                draw_set_color(character_color_blue)
            }
            var draw_x; draw_x = (i * grid_size) + grid_size;
            draw_sprite(background, 0, draw_x, draw_y)
            var sprite;
            switch (i)
            {
                case 2:
                    
                    switch (draw_get_color())
                    {
                        case character_color_red: sprite = Red_Triangle_Sprite; break;
                        case character_color_black: sprite = Black_Triangle_Sprite; break;
                        case character_color_green: sprite = Green_Triangle_Sprite; break;
                        case character_color_blue: sprite = Blue_Triangle; break;
                    }
                    draw_sprite(sprite, 0, draw_x, draw_y)
                    break
                case 4:
                    switch (draw_get_color())
                    {
                        case character_color_red: sprite = Red_Square_Sprite; break;
                        case character_color_black: sprite = Black_Square_Sprite; break;
                        case character_color_green: sprite = Green_Square_Sprite; break;
                        case character_color_blue: sprite = Blue_Square; break;
                    }
                    draw_sprite(sprite, 0, draw_x, draw_y)
                    break
                case 13:
                    switch (draw_get_color())
                    {
                        case character_color_red: sprite = G_R_3hit; break;
                        case character_color_black: sprite = G_B_3hit; break;
                        case character_color_green: sprite = G_G_3hit; break;
                        case character_color_blue: sprite = G_Bl_3hit; break;
                    }
                    draw_sprite(sprite, 0, draw_x, draw_y)
                    break;
                case 25:
                    draw_text(draw_x + 17, draw_y + 17, "Gigga#G")
                    break;
                case 31:
                    switch (draw_get_color())
                    {
                        case character_color_red: sprite = Red_Pi_Sprite; break;
                        case character_color_black: sprite = Black_Pi_Sprite; break;
                        case character_color_green: sprite = Green_Pi_Sprite; break;
                        case character_color_blue: sprite = Blue_Pi; break;
                    }
                    draw_sprite(Concreet_Sprite, 0, draw_x, draw_y)
                    draw_sprite(sprite, 0, draw_x, draw_y)
                    break;
                case 33:
                    switch (draw_get_color())
                    {
                        case character_color_red: sprite = Big_W_R_1hit; break;
                        case character_color_black: sprite = Big_W_B_1hit; break;
                        case character_color_green: sprite = Big_W_G_1hit; break;
                        case character_color_blue: sprite = Big_W_Bl_1hit; break;
                    }
                    draw_sprite(sprite, 0, draw_x, draw_y)
                    break;
                case 34:
                    draw_text(draw_x + 17, draw_y + 17, "Terror#G")
                    break;
                case 35:
                    switch (draw_get_color())
                    {
                        case character_color_red: draw_set_color(character_color_purple); break;
                        case character_color_black: draw_set_color(character_color_dark_blue); break;
                    }
                    draw_text(draw_x + char_draw_offset, draw_y + char_draw_offset, "?")
                    break;                  
                default:
                    draw_text(draw_x + char_draw_offset, draw_y + char_draw_offset, global.character_text[i])
                    break; 
            }
            
        }
        break;
    
    case 4: // Materials
        var i;
        for(i = 0; i < 10; i += 1)
        {
            var draw_x; draw_x = (i * grid_size) + grid_size;
            var sprite;
            switch (i)
            {
                case 0: sprite = Yellow_Sprite; break;
                case 1: sprite = Rock_Sprite; break;
                case 2: sprite = Dimond_Sprite; break;
                case 3: sprite = Concreet_Sprite; break;
                case 4: sprite = Mud_Sprite; break;
                case 5: sprite = Double_Boxing_Yellow_Sprite break;
                case 6: sprite = Double_Boxing_Rock_Sprite; break;
                case 7: sprite = Double_Boxing_Dimond_Sprite; break;
                case 8: sprite = Horizontal_Barria; break;
                case 9: sprite = Vertical_Barria; break;
            }
            switch (i)
            {
                case 5:
                case 6:
                case 7:
                    draw_sprite(sprite, -1, draw_x, draw_y)
                    draw_sprite(sprite, -1, draw_x + 18, draw_y)
                    draw_sprite(sprite, -1, draw_x, draw_y + 18)
                    draw_sprite(sprite, -1, draw_x + 18, draw_y + 18)
                    break;
                default: 
                    draw_sprite(sprite, -1, draw_x, draw_y)
                    break;
            }
            
        }
        break;
        
    case 5: // Angers/Ports
        var i;
        for(i = 0; i < 12; i += 1)
        {
            var draw_x; draw_x = (i * grid_size) + grid_size;
            var sprite;
            switch (i)
            {
                case 0: sprite = Red_Anger_Sprite; break;
                case 1: sprite = Blue_Anger_Sprite; break;
                case 2: sprite = Orange_Anger_Sprite; break;
                case 3: sprite = Purple_Anger_Sprite; break;
                case 4: sprite = Teleport_Dark_Blue; break;
                case 5: sprite = Teleport_Brown; break;
                case 6: sprite = Teleport_Forest_Green; break;
                case 7: sprite = Teleport_Grey; break;
                case 8: sprite = Teleport_Green; break;
                case 9: sprite = Teleport_Light_Blue; break;
                case 10: sprite = Teleport_Orange; break;
                case 11: sprite = Teleport_Pink; break;
            }
            draw_sprite(Yellow_Sprite, 0, draw_x, draw_y)
            draw_sprite(sprite, animation_frame, draw_x, draw_y)
        }
        break;
        
    case 6: // Boulder/Bombs
        var i;
        for(i = 0; i < 6; i += 1)
        {
            var draw_x; draw_x = (i * grid_size) + grid_size;
            var sprite;
            switch (i)
            {
                case 0: sprite = Boulder_Sprite; break;
                case 1: sprite = Tunnling_Bomb_Sprite; break;
                case 2: sprite = Dimond_Bomb_Sprite; break;
                case 3: sprite = Nuclear_Bomb_Sprite; break;
                case 4: sprite = J_Bomb_Sprite; break;
                case 5: sprite = Time_Bomb_Sprite; break;
            }
            draw_sprite(Yellow_Sprite, 0, draw_x, draw_y)
            draw_sprite(sprite, 5, draw_x, draw_y)
        }
        break;
        
    case 7: // Other
        var i;
        for(i = 0; i < 11; i += 1)
        {
            var draw_x; draw_x = (i * grid_size) + grid_size;
            var sprite;
            switch (i)
            {
                case 0: sprite = Up_Arrow_Sprite; break;
                case 1: sprite = Down_Arrow_Sprite; break;
                case 2: sprite = Left_Arrow_Sprite; break;
                case 3: sprite = Right_Arrow_Sprite; break;
                case 4: sprite = Horizontal_Arrow_Sprite; break;
                case 5: sprite = Vertical_Arrow_Sprite; break;
                case 6: sprite = Steel_Sprite; break;
                case 7: sprite = Switch_Sprite; break;
                case 8: sprite = Gate_Vertical_Sprite; break;
                case 9: sprite = Gate_Horizontal_Sprite; break;
                case 10: sprite = Steel_Sprite; break;
            }
            draw_sprite(Rock_Sprite, 0, draw_x, draw_y)
            draw_sprite(sprite, animation_frame, draw_x, draw_y)
            switch (i)
            {
                case 10: 
                    draw_set_color(c_red)
                    draw_text(draw_x + 17, draw_y + 17, "NWH")
                    break;
            }
        }
        break;
}

draw_set_halign(0)
draw_set_valign(0)

animation_frame += 1
#define Level_Designer_Script
if (mouse_y >= 21 * grid_size && mouse_y < 22 * grid_size)
{
    object_mouse_select = floor(mouse_x / grid_size) - 1
}
else
{
    object_mouse_select = -1
}
#define Level_Designer_Click
if (mouse_x >= grid_size && mouse_x < 37 * grid_size)
{
    if (mouse_y >= 21 * grid_size && mouse_y < 22 * grid_size)
    {
        object_select = object_mouse_select
    }
    else if (mouse_y >= grid_size && item_select > 0 && object_select > -1)
    {
        var tile_x; tile_x = floor(mouse_x / grid_size) * grid_size;
        var tile_y; tile_y = floor(mouse_y / grid_size) * grid_size;
        switch (item_select)
        {
            case 1: // Player 1 characters
            case 2: // Player 2 character
            case 3: // Neutral character      
                break;
                
            case 4: // Materials              
                switch (object_select)
                {
                    case 0: 
                        Clear_Tile(tile_x, tile_y);
                        instance_create(tile_x, tile_y, Yellow);
                        break;
                    case 1: 
                        Clear_Tile(tile_x, tile_y);
                        instance_create(tile_x, tile_y, Rock); 
                        break;
                    case 2: 
                        Clear_Tile(tile_x, tile_y);    
                        instance_create(tile_x, tile_y, Dimond);
                        break;
                    case 3: 
                        Clear_Tile(tile_x, tile_y);
                        instance_create(tile_x, tile_y, Concreet); 
                        break;
                    case 4:
                        Clear_Tile(tile_x, tile_y);
                        instance_create(tile_x, tile_y, Yellow);
                        instance_create(tile_x, tile_y, Mud);
                        break;
                    case 5:
                        Create_Double_Boxing(tile_x, tile_y, Double_Boxing_Yellow);
                        break;
                    case 6:
                        Create_Double_Boxing(tile_x, tile_y, Double_Boxing_Rock);
                        break;
                    case 7:
                        Create_Double_Boxing(tile_x, tile_y, Double_Boxing_Dimond);
                        break;
                    case 8:
                        instance_create(tile_x, tile_y, Barria_Horizontal_Image);
                        break;
                    case 9:
                        instance_create(tile_x, tile_y, Barria_Vertical_Image);
                        break;
                    
                }
                break;
            
            case 5: // Angers/Ports  
                var port_color, anger_color; 
                port_color = -1;
                anger_color = -1;
                switch (object_select)
                {
                    case 0: anger_color = Red_Anger; break;
                    case 1: anger_color = Orange_Anger; break;
                    case 2: anger_color = Blue_Anger; break;
                    case 3: anger_color = Purple_Anger; break;
                    case 4: port_color = 1; break;
                    case 5: port_color = 0; break;
                    case 6: port_color = 2; break;
                    case 7: port_color = 3; break;
                    case 8: port_color = 4; break;
                    case 9: port_color = 5; break;
                    case 10: port_color = 6; break;
                    case 11: port_color = 7; break;
                }
                
                if (anger_color != -1)
                {
                    Clear_Tile(tile_x, tile_y);
                    instance_create(tile_x, tile_y, Yellow);
                    instance_create(tile_x, tile_y, anger_color);
                }
                
                if (port_color != -1)
                {   
                    var port_number; 
                    port_number = 0;
                    with (Teleport)
                    {
                        if (color == port_color) {port_number += 1;}
                    }
                    if (port_number < 2)
                    {
                        Clear_Tile(tile_x, tile_y);
                        instance_create(tile_x, tile_y, Yellow);
                        var port;
                        port = instance_create(tile_x, tile_y, Teleport);
                        port.side = port_number + 1;
                        port.color = port_color;
                    }
                    else
                    {
                        show_message("Each teleport color can only have 2 sides.");
                    }
                }
                break;
        }
    }
}
#define Create_Double_Boxing
/* arguments
    argument0 - tile_x
    argument1 - tile_y
    argument2 - type of Double Boxing

*/

var tile_x; tile_x = argument0;
var tile_y; tile_y = argument1;

var double_boxing_present;
with (Double_Boxing)
{
    if (x == tile_x && y == tile_y) {double_boxing_present = true;}
}

if (!double_boxing_present) 
{
    Clear_Tile(tile_x, tile_y);
    instance_create(tile_x, tile_y, Double_Boxing);
    instance_create(tile_x, tile_y, argument2);
    instance_create(tile_x + 18, tile_y, argument2);
    instance_create(tile_x, tile_y + 18, argument2);
    instance_create(tile_x + 18, tile_y + 18, argument2);
}
else
{
    var db_tile_x, db_tile_y;
    
    if (mouse_x - tile_x < 18)
    {
        db_tile_x = tile_x;
    }
    else
    {
        db_tile_x = tile_x + 18;
    }
    
    if (mouse_y - tile_y < 18)
    {
        db_tile_y = tile_y;
    }
    else
    {
        db_tile_y = tile_y + 18;
    }
    
    instance_create(db_tile_x, db_tile_y, argument2);
}
#define Clear_Tile
var tile_x; tile_x = argument0;
var tile_y; tile_y = argument1;

objects_to_remove[0] = Tile;
objects_to_remove[1] = Double_Boxing;
objects_to_remove[2] = Teleport;

var i;
for (i = 0; i < 3; i += 1)
{
    with (objects_to_remove[i])
    {
        if (x == tile_x && y == tile_y) {instance_destroy();}
    }
}

with (Double_Boxing_Tile)
{
    if ((x == tile_x || x = tile_x + 18) && (y == tile_y || y == tile_y + 18)) {instance_destroy();}
}
#define READ_ME
/* READ_ME

THIS SCRIPT IS JUST COMMENT AND CONTAINS NO ACTUAL CODE

Stefan Grace

READ_ME last updated: 2020-02-24

In-game cheats:
To get to the test levels, press the delete key on the 1st level select menu
To destory any character, boulder or bomb, right click on it
To turn Rock, Dimond, Concreet or Steel into yellow, middle click on it
To increase the go number by 1, left click on it or press num pad +
To decrease the go number by 1, right click on it or press num pad -
To increase the go number by 10, press num pad 1
To set the go number to 0, middle click on it or press 0

Variables:
The built-in 'score' variable is the current go number (the number of goes that are currently left)
The built-in 'lives' variable is the total go number for the level
 
Places where characters are referred to (places that need to be updated every time you add a new character, "*" at start means it hasn't updated done yet):
---SCRIPTS---
Character_Click_Black
Character_Click_Red
Red_Stun
Black_Stun
Red_Unstun
Black_Unstun
Character_Move_Double_Boxing
Place_Meeting_Detect
Neutral_Character_Script
Boulder_Fall
Charm_Script
---OBJECTS---
All Stuned Character - Step Event
R_Arrow - Collison Events

Character IDs:
0 - O
1 - X
2 - Triangle
3 - A
4 - Square
5 - K
6 - B
7 - E
8 - S
9 - H
10 - R
11 - M
12 - F
13 - G
14 - C
15 - Y
16 - Z
17 - W
18 - J
19 - V
20 - P
21 - T
22 - D
23 - Q
24 - N
25 - Gigga G
26 - ?
27 - U
28 - L
29 - $
30 - @
31 - Pi
32 - I
33 - Big W
34 - Terra G
35 - Purple ?

Any questions, 
email: stefangrace@hotmail.co.nz
*/
#define Game_Start_Script
// Game_Start_Script
// Stefan Grace
// Created: 2017-06-20
// Modified: 2022-08-21
// This script is executed when the game starts

// Language
script_execute(English)
if (file_exists(working_directory+"\Settings\Language.txt"))
{
    var file;
    file = file_text_open_read(working_directory+"\Settings\Language.txt")
    global.Language = file_text_read_real(file)
    file_text_close(file)
    if (global.Language==1) script_execute(French)
    if (global.Language==2) script_execute(Spanish)
    if (global.Language==3) script_execute(German)
}

// Player 1 Name
global.Player_One = global.text_player+" 1"
if (file_exists(working_directory+"\Settings\Player_1_Name.txt"))
{
    var file;
    file = file_text_open_read(working_directory+"\Settings\Player_1_Name.txt")
    global.Player_One = file_text_read_string(file)
    file_text_close(file)
}

// Player 2 Name
global.Player_Two = global.text_player+" 2"
if (file_exists(working_directory+"\Settings\Player_2_Name.txt"))
{
    var file;
    file = file_text_open_read(working_directory+"\Settings\Player_2_Name.txt")
    global.Player_Two = file_text_read_string(file)
    file_text_close(file)
}

// Message Apperance
message_background(Message_background)
message_button(Message_button) 
message_button_font(font,18,c_blue,bold)
message_size(636,172)
message_text_font(font,18,c_white,bold)

// Character Text
global.character_text[0] = "O"
global.character_text[1] = "X"
global.character_text[2] = "Triangle"
global.character_text[3] = "A"
global.character_text[4] = "Square"
global.character_text[5] = "K"
global.character_text[6] = "B"
global.character_text[7] = "E"
global.character_text[8] = "S"
global.character_text[9] = "H"
global.character_text[10] = "R"
global.character_text[11] = "M"
global.character_text[12] = "F"
global.character_text[13] = "G"
global.character_text[14] = "C"
global.character_text[15] = "Y"
global.character_text[16] = "Z"
global.character_text[17] = "W"
global.character_text[18] = "J"
global.character_text[19] = "V"
global.character_text[20] = "P"
global.character_text[21] = "T"
global.character_text[22] = "D"
global.character_text[23] = "Q"
global.character_text[24] = "N"
global.character_text[25] = "Gigga G"
global.character_text[26] = "?"
global.character_text[27] = "U"
global.character_text[28] = "L"
global.character_text[29] = "$"
global.character_text[30] = "@"
global.character_text[31] = "Pi"
global.character_text[32] = "I"
global.character_text[33] = "Big W"
global.character_text[34] = "Terra G"
global.character_text[35] = "Purple ?"
global.character_text[100] = "q"

// Music
Last_Music = 0
if (file_exists(working_directory+"\Settings\Music.txt"))
{
    var file;
    file = file_text_open_read(working_directory+"\Settings\Music.txt")
    global.Music_Playing = file_text_read_real(file)
    file_text_close(file)
}

// Date and Time Format Settings
var date_time_val;
if (file_exists(working_directory+"\Settings\Date_Time.txt"))
{
    var file;
    file = file_text_open_read(working_directory+"\Settings\Date_Time.txt")
    date_time_val = file_text_read_real(file)
    file_text_close(file)
    global.Date_Order = date_time_val mod 10
    global.Time_Format = ((date_time_val mod 100) - (date_time_val mod 10))/10
    global.Date_Time_Order = ((date_time_val mod 1000) - (date_time_val mod 100))/100
    global.Year_Format = ((date_time_val mod 10000) - (date_time_val mod 1000))/1000
    global.Month_Format = ((date_time_val mod 100000) - (date_time_val mod 10000))/10000
}

// Show Backgrounds
Last_Music = 0
if (file_exists(working_directory+"\Settings\Show_Backgrounds.txt"))
{
    var file;
    file = file_text_open_read(working_directory+"\Settings\Show_Backgrounds.txt")
    global.show_backgrounds = file_text_read_real(file)
    file_text_close(file)
}

// Show Backgrounds
global.show_backgrounds = true
if (file_exists(working_directory+"\Settings\Show_Backgrounds.txt"))
{
    var file;
    file = file_text_open_read(working_directory+"\Settings\Show_Backgrounds.txt")
    global.show_backgrounds = file_text_read_real(file)
    file_text_close(file)
}

// Cheats
global.cheats = true
if (file_exists(working_directory+"\Settings\Cheats.txt"))
{
    var file;
    file = file_text_open_read(working_directory+"\Settings\Cheats.txt")
    global.cheats = file_text_read_real(file)
    file_text_close(file)
}

// Tablet Mode
global.tablet_mode = false
if (file_exists(working_directory+"\Settings\Tablet_Mode.txt"))
{
    var file;
    file = file_text_open_read(working_directory+"\Settings\Tablet_Mode.txt")
    global.tablet_mode = file_text_read_real(file)
    file_text_close(file)
}

// Fullscreen
if (file_exists(working_directory+"\Settings\Fullscreen.txt"))
{
    var file;
    file = file_text_open_read(working_directory+"\Settings\Fullscreen.txt")
    window_set_fullscreen(file_text_read_real(file))
    file_text_close(file)
}

// Window caption
show_score = false;
#define B_help
show_message (global.text_b_help)

#define Background_Reset
// Background_Reset
// Stefan Grace
// Created: 2016-07-18
// Modified: 2017-07-20
// This scrip resets the background when the player's turn is up

if (global.levelnumber<10) background_index[0] = Nature_Background
if (global.levelnumber>9) and (global.levelnumber<20) background_index[0] = Underwater_Background
if (global.levelnumber>19) and (global.levelnumber<30) background_index[0] = Bush_Background
#define Background_Script
// Background_Script
// Stefan Grace
// Created: 2017-12-23
// Modified: 2024-07-22
// This script sets the background for the level

/* arguments
    argument0
        0 - Level start
        1 - Player change
*/

if (global.show_backgrounds) 
{
    var bg_image;
    if (global.levelnumber < 10)
    {
        bg_image = "Backgrounds\0_Waterfall.jpg"
    }
    else if (global.levelnumber < 20)
    {
        bg_image = "Backgrounds\1_Mountain.jpg"
    }
    else if (global.levelnumber < 30)
    {
        bg_image = "Backgrounds\2_Bush.jpg"
    }
    
    if (file_exists(bg_image))
    {
        background_replace(Background, bg_image, 1, 0, 0)
        sprite_replace(Background_Sprite, bg_image, 0, 0, 1, 0, 0, 0, 0)
        background_index[0] = Background
        if (argument0==0) instance_create(0, 0, Background_Object)
    }
    else 
    {
        background_index[0] = -1
        background_color = $000000
        instance_create(0, 0, Wood_Object)
    }
}
else
{
    background_index[0] = -1
    background_color = $000000
    instance_create(0, 0, Wood_Object)
}





#define Big_Explosion_Script
// Big_Explosion_Script
// Stefan Grace
// Created: 2017-08-26
// Modified: 2018-11-08
// This script makes a big explosion the width and height of argument0

if (place_meeting(x,y,Concreet)) 
{
    instance_destroy()
}
else
{   
    var start;
    start = ((argument0 / 2) - 0.5) * -1
    var stop;
    stop = (argument0 / 2) + 0.5
    var i;
    var j;
    for(i = start; i < stop; i += 1)
    {
        for(j = start; j < stop; j += 1)
        {
            if !place_meeting(x + (i * grid_size), y + (j * grid_size), Concreet)
            {
                instance_create(x + (i * grid_size), y + (j * grid_size), NWH_To_Be_Exploded)
            }
        }
    }
}
#define Bring_Up_Menu
// Bring_Up_Menu
// Stefan Grace
// Created: 2016-07-02
// Modified: 2017-07-23
// This script brings up the menu in a level when the esape key is pressed

if (instance_number(Level_Cover) > 0) exit

if (instance_number(Player_One_Winz)==0 and instance_number(Player_Two_Winz)==0) instance_create(room_width/2,room_height/2,Menu) else room_goto(Main_Menu_Room)
// global.game_frozen = 1

#define Button_Text
// Button_Text
// Stefan Grace
// Created: 2016-06-24
// Modifed: 2020-02-28
// This script draws the text on buttons and makes the text and buttons change color

/* 
argument0
    0 = Normal Button
    1 = Play Button
    2 = Character Button
    3 = Small Button
    4 = OSK Button
*/

var x_plus, y_plus;

draw_set_font(Button_Font)
draw_set_halign(fa_center)
draw_set_valign(fa_middle)
y_plus = round(sprite_height / 2)
x_plus = round(sprite_width / 2)


if (mouse_x >= x and mouse_y > y and mouse_x < x + sprite_width and mouse_y < y + sprite_height) // if mouse in inside button
or (place_meeting(x, y, Hand))
{
    if (mouse_button || joystick_check_button(0, 2))  
    {  
        if (argument0==0) 
        {
            draw_sprite(Pressed_Button,0,x,y)
        }
        else if (argument0==1) 
        {
            draw_sprite(Play_Pressed,0,x,y)
            draw_set_font(Play_Button_Font)
        }
        else if (argument0==2) 
        {
            draw_sprite(Character_Pressed,0,x,y)
        }
        else if (argument0==3)
        {
            draw_set_font(Small_Button_Font)
            draw_sprite(Small_Pressed,0,x,y)
        }
        else if (argument0==4)
        {
            draw_set_font(Small_Button_Font)
            draw_sprite(OSK_Pressed,0,x,y)
        }
        draw_set_color(c_blue)
    }
    else
    {
        if (argument0==0) 
        {
            draw_sprite(Hot_Button,0,x,y)
        }
        else if (argument0==1) 
        {
            draw_sprite(Play_Hot,0,x,y)
            draw_set_font(Play_Button_Font)
        }
        else if (argument0==2) 
        {
            draw_sprite(Character_Hot,0,x,y)
        }
        else if (argument0==3)
        {
            draw_set_font(Small_Button_Font)
            draw_sprite(Small_Hot,0,x,y)
        }
        else if (argument0==4)
        {
            draw_set_font(Small_Button_Font)
            draw_sprite(OSK_Hot,0,x,y)
        }
        draw_set_color(c_blue)
    }
}
else
{
    if (argument0==0) 
    {
        draw_sprite(Normal_Button,0,x,y)
    }
    else if (argument0==1) 
    {
        draw_sprite(Play_Normal,0,x,y)
         draw_set_font(Play_Button_Font)
    }
    else if (argument0==2) 
    {
        draw_sprite(Character_Normal,0,x,y)
    }
    else if (argument0==3) 
    {
        draw_set_font(Small_Button_Font)
        draw_sprite(Small_Normal,0,x,y)
    }
    else if (argument0==4) 
    {
        draw_set_font(Small_Button_Font)
        draw_sprite(OSK_Normal,0,x,y)
    }
    draw_set_color(c_black)
    
}

draw_text(x + x_plus, y + y_plus, Button_Name)

draw_set_valign(0)
draw_set_halign(0)
#define Button_Text_Center
// Button_Text_Center
// Stefan Grace
// Created: 2016-07-14
// Modified: 2024-07-24
// This script centers text on buttons

/* THIS SCRIPT IS NOW REDUNDANT */

/*
var repeat_times;
Button_Name_Center = Button_Name
if (argument0==0) repeat_times = 13-(string_length(Button_Name))
if (argument0==1) repeat_times = 20-(string_length(Button_Name))
if (argument0==2) repeat_times = 8-(string_length(Button_Name))
repeat(repeat_times) Button_Name_Center = " "+Button_Name_Center
*/
#define Character_Explosion_Destroy
with(all) 
{
    if (character_id+character_o>0)
    {
        if (character_id!=13 and character_id!=31)
        {
            if (place_meeting(x,y,other)) instance_destroy()
        }
    }
}
#define Continue_Script
// Continue_Sript
// Stefan Grace
// Craeted: 2017-07-22
// Modifed: 2017-07-23
// This script gets rid of the menu when the continue button is clicked

global.game_frozen = 0
with(Menu) instance_destroy()
with(Main_Menu_Button) instance_destroy()
with(Restart) instance_destroy()
with(Music_Button) instance_destroy()
instance_destroy()
#define Date_Time_Room_Background
// Date_Time_Room_Background
// Stefan Grace
// Created: 2016-06-26
// Modifed: 2016-07-14
// This script displays the text on the date time room

// This block of code sets the font and color of the text
draw_set_font(Room_Font)
draw_set_color(c_white)

// This block of code displays the text
draw_text(910,105,global.text_date_order)
draw_text(70,385,global.text_year_format)
draw_text(35,105,global.text_date_time_order)
draw_text(490,385,global.text_time_format)
draw_text(490,105,global.text_month_format)
#define Date_Time_Script
//Date & Time
//Stefan Grace
//Created 2016-05-16
//Modifed 2016-07-30
//This Scrip assembles the currect date and time


//This block of code makes the elements have leading zeros if they are less than ten
if (current_month<10) global.current_month_leading_zero=string("0")+string(current_month) else global.current_month_leading_zero = current_month
if (current_day<10) global.current_day_leading_zero=string("0")+string(current_day) else global.current_day_leading_zero = current_day 
if (current_hour<10) global.current_hour_leading_zero=string("0")+string(current_hour) else global.current_hour_leading_zero = current_hour 
if (current_minute<10) global.current_minute_leading_zero=string("0")+string(current_minute) else global.current_minute_leading_zero = current_minute
if (current_second<10) global.current_second_leading_zero=string("0")+string(current_second) else global.current_second_leading_zero = current_second 

//This block of code makes the year be 2 digit if the setting is enabeld
if (global.Year_Format==0) global.current_year_digits=current_year else global.current_year_digits=(current_year mod 100)
if (global.current_year_digits<10) global.current_year_digits = string(global.current_year_digits)+string("0")

//This block of code makes the months be displays as words insted of numbers if the option is enabled
if (global.Month_Format==1) global.current_month_leading_zero = global.Months[current_month]

//This block of code makes the time be 12 hour is the setting is enabeld
if (global.Time_Format==1)
{
    if (current_hour<12) global.AmPm="AM" else global.AmPm="PM"
    if (current_hour==0) global.current_hour_twelve=12
    if (current_hour>0 and current_hour<12) global.current_hour_twelve=current_hour
    if (current_hour>12) global.current_hour_twelve=current_hour-12
}

//This block of code assembels the elements of the date and time
if (global.Date_Order==0) global.date_text = string(global.current_year_digits)+"-"+string(global.current_month_leading_zero)+"-"+string(global.current_day_leading_zero)
if (global.Date_Order==1) global.date_text = string(global.current_month_leading_zero)+"/"+string(global.current_day_leading_zero)+"/"+string(global.current_year_digits)
if (global.Date_Order==2) global.date_text = string(global.current_day_leading_zero)+"/"+string(global.current_month_leading_zero)+"/"+string(global.current_year_digits)
if (global.Time_Format==0) global.time_text = string(global.current_hour_leading_zero)+":"+string(global.current_minute_leading_zero)+":"+string(global.current_second_leading_zero)
if (global.Time_Format==1) global.time_text = string(global.current_hour_twelve)+":"+string(global.current_minute_leading_zero)+string(" ")+string(global.AmPm)
if (global.Date_Time_Order==0) global.date_time_text = string(global.date_text)+string(" ")+string(global.time_text)
if (global.Date_Time_Order==1) global.date_time_text = string(global.time_text)+string(" ")+string(global.date_text)

#define Draw_Mode_Script
// Draw_Mode_Script
// Stefan Grace
// Created: 2016-07-14
// Modifed: 2016-07-14
// This script toggels Draw Mode


if (clicked==0)
{
    if (argument0==1)
    {
        if (global.D_M_Red_on==0)
        {
            global.D_M_Red_on = 1
            clicked = 1
            alarm[0] = 20
        }
        else if (global.D_M_Red_on==1)
        {
            global.D_M_Red_on = 0
            clicked = 1
            alarm[0] = 20
        }
    }
    if (argument0==2)
    {
        if (global.D_M_Black_on==0)
        {
            global.D_M_Black_on = 1
            clicked = 1
            alarm[0] = 20
        }
        else if (global.D_M_Black_on==1)
        {
            global.D_M_Black_on = 0
            clicked = 1
            alarm[0] = 20
        }
    }
}
#define Explosion_Script
// Explosion_Script
// Stefan Grace
// Created: 2016-08-23
// Modified: 2018-11-08
// This script controls all explosions

// Makes it not explode outside the room
if (x<0) or (y<0) or (x>room_width-35) or (y>room_height) instance_destroy()

// Makes concreet block explosions
if (place_meeting(x,y,Concreet)) instance_destroy()

// Makes it explode explodable things
script_execute(Object_Destroy)
script_execute(Character_Explosion_Destroy)
with (Mud) if (place_meeting(x,y,other)) instance_change(Mud_Explode,true)
with (Teleport) if (place_meeting(x,y,other)) alarm [1] = 1
alarm[2] = 1

// Makes explotions take 1 hit off a G
with (Red_Stuned_G) script_execute(G_Explode)
with (Black_Stuned_G) script_execute(G_Explode)
with (Red_G) script_execute(G_Explode)
with (Black_G) script_execute(G_Explode)
with (Red_Blue_G) script_execute(G_Explode)
with (Black_Blue_G) script_execute(G_Explode)
with (Green_G)
{
    script_execute(G_Explode)
    if (place_meeting(x,y,other))
    {
        if (g_type == 1 or g_type == 2)
        {
            with (Rock) if (place_meeting(x,y,other)) instance_destroy()
            with (Dimond) if (place_meeting(x,y,other)) instance_destroy()
            with (Mud) if (place_meeting(x,y,other)) instance_change(Mud_Explode,true)
        }
    }
}

// Makes HWH explosions not explode off the edge
if (instance_number(NWH_Explosion_Center) > 0)
{
    if (x<=0) or (y<=0) or (x>=room_width-36) or (y>=room_height-35) instance_destroy()
}

// Makes it not explode non-explodeage things
if (place_meeting(x,y,Steel)) 
or (place_meeting(x,y,Date_Time))
or (place_meeting(x,y,Go_Number_Black))
or (place_meeting(x,y,Go_Number_Red))
or (place_meeting(x,y,Draw_Mode_Black))
or (place_meeting(x,y,Draw_Mode_Red))
or (place_meeting(x,y,Level_Number_Object))
or (place_meeting(x,y,NWH_Object))
or (place_meeting(x,y,Gate_Object))
or (place_meeting(x,y,Switch))
{
    alarm[1] = 2
}
else
{
    // Turns the explotion into yellow
    alarm[0] = 2
}
#define Go_To_Level_Script
// Go_To_Level_Script
// Stefan Grace
// Craeted: 2017-07-23
// Modified: 2018-06-10
// This script goes to the specified level when the thumbnail is clicked

/* Arguments
argument0 - Level Number
*/

/*
if show_question(global.text_load_game)
{
    var fname;
    fname = "Saves\Save_Level_"+string(argument0)
    game_load(fname)
}
*/
//else
{
    global.onlevel = 1
    global.levelnumber = argument0
    if (argument0==-1) room_goto(Test_Level_1)
    if (argument0==-2) room_goto(Test_Level_2)
    if (argument0==-3) room_goto(Test_Level_3)
    if (argument0==-4) room_goto(Test_Level_4)
    if (argument0==-5) room_goto(Test_Level_5)
    if (argument0==-6) room_goto(Test_Level_6)
    if (argument0==-7) room_goto(Test_Level_7)
    if (argument0==-8) room_goto(Test_Level_8)
    if (argument0==-9) room_goto(Test_Level_9)
    if (argument0==-10) room_goto(Test_Level_10)
    if (argument0==0) room_goto(Level_0)
    if (argument0==1) room_goto(Level_1)
    if (argument0==2) room_goto(Level_2)
    if (argument0==3) room_goto(Level_3)
    if (argument0==4) room_goto(Level_4)
    if (argument0==5) room_goto(Level_5)
    if (argument0==6) room_goto(Level_6)
    if (argument0==7) room_goto(Level_7)
    if (argument0==8) room_goto(Level_8)
    if (argument0==9) room_goto(Level_9)
    if (argument0==10) room_goto(Level_10)
    if (argument0==11) room_goto(Level_11)
    if (argument0==12) room_goto(Level_12)
    if (argument0==13) room_goto(Level_13)
    if (argument0==14) room_goto(Level_14)
    if (argument0==15) room_goto(Level_15)
    if (argument0==16) room_goto(Level_16)
    if (argument0==17) room_goto(Level_17)
    if (argument0==18) room_goto(Level_18)
    if (argument0==19) room_goto(Level_19)
    if (argument0==20) room_goto(Level_20)
    if (argument0==21) room_goto(Level_21)
    if (argument0==22) room_goto(Level_22)
    if (argument0==23) room_goto(Level_23)
    if (argument0==24) room_goto(Level_24)
    if (argument0==25) room_goto(Level_25)
    if (argument0==26) room_goto(Level_26)
    if (argument0==27) room_goto(Level_27)
    if (argument0==28) room_goto(Level_28)
}
#define Language_Change
if global.Language==0
{
    global.Language=1
    script_execute(French)
    exit
}
else if global.Language==1
{
    global.Language=2
    script_execute(Spanish)
    exit
}
else if global.Language==2
{
    global.Language=3
    script_execute(German)
    exit
}
else if global.Language==3
{
    global.Language=0
    script_execute(English)
    exit
}

#define Level_Clicked
global.Date_Order = 0
global.Time_Format = 0
global.Date_Time_Order = 0
global.Year_Format = 0
global.Month_Format = 0

#define Local_Message_Create
// Local_Message_Create
// Stefan Grace
// Craeted: 2017-07-22
// Modified: 2017-07-22
// This script creates the B and Double Boxing messages in the correct place

/* Top Left     */ if (x<room_width/2) and (y<room_height/2) instance_create(x+grid_size,y,Message_Object)
/* Top Right    */ if (x>=room_width/2) and (y<room_height/2) instance_create(x-(sprite_get_width(Message_Sprite)+grid_size),y,Message_Object)
/* Bottom Left  */ if (x<room_width/2) and (y>=room_height/2) instance_create(x+grid_size,y-sprite_get_height(Message_Sprite),Message_Object) 
/* Bottom Right */ if (x>=room_width/2) and (y>=room_height/2) instance_create(x-(sprite_get_width(Message_Sprite)+grid_size),y-sprite_get_height(Message_Sprite),Message_Object)
#define Main_Menu_Code
// Main_Menu_Code
// Stefan Grace
// Created: 2015-06-18
// Modified: 2024-07-27
// This script is activated when the player clicks the Main Menu button



//this block of code saves the level 
if (global.levelnumber>=0) && (global.onlevel==1)  && !keyboard_check(vk_shift)
&& (instance_number(Player_Winz) == 0) && (instance_number(Player_Select) == 0)
{
    Save_Level()
}


//this block of code goes to the main menu room
global.onlevel = false;
room_goto(Main_Menu_Room)

//this block of code stops the music playing
sound_stop_all()

#define Message_Draw_Script
// Message_Draw_Script
// Stefan Grace
// Created: 2017-07-22
// Modified: 2020-05-11

/* Message Types
0 - Level Start
10 - Double Boxing Horizonal
11 - Double Boxing Vertical
20 - B
21 - @
22 - T
23 - $
24 - Big W
30 - Neutral characters in dimond
40 - Level 16 Instruction
41 - Level 24 Instructions
50 - Level 0 Introduction
*/

draw_set_font(Message_Font)
draw_set_halign(fa_center)
draw_set_valign(fa_center)
draw_set_color($84180B)
draw_sprite(Message_Sprite,0,x,y)
if (global.message_type==0) 
{
    draw_text_ext(x+(sprite_width/2),y+(sprite_height/2)+5,global.text_message_level[global.levelnumber],message_line_spacing,sprite_width-5)
    if (global.levelnumber>0)
    {
        draw_text_color(x+145,y+25,global.text_view_alumax,c_blue,c_blue,c_blue,c_blue,100)
        var underline_lenghth;
        underline = ""
        repeat(string_length(global.text_view_alumax)) underline += "_"
        draw_text_color(x+145,y+25,underline,c_blue,c_blue,c_blue,c_blue,100)    
    }
}
if (global.message_type==10) draw_text_ext(x+(sprite_width/2),y+(sprite_height/2)+5,global.text_double_boxing_entry_horizontal,message_line_spacing,sprite_width-5)
if (global.message_type==11) draw_text_ext(x+(sprite_width/2),y+(sprite_height/2)+5,global.text_double_boxing_entry_vertical,message_line_spacing,sprite_width-5)
if (global.message_type==20) 
{
    var player_name;
    if (instance_number(Go_Number_Red)>0) player_name = global.Player_Two
    if (instance_number(Go_Number_Black)>0) player_name = global.Player_One
    draw_text_ext(x+(sprite_width/2),y+(sprite_height/2)+5,player_name+", "+global.text_choose_which_character_you_want_to_lose,message_line_spacing,sprite_width-5)
    draw_text_color(x+80,y+25,global.text_help,c_blue,c_blue,c_blue,c_blue,100)
    var underline_lenghth;
    underline = ""
    repeat(string_length(global.text_help)) underline += "_"
    draw_text_color(x+80,y+25,underline,c_blue,c_blue,c_blue,c_blue,100)
}
if (global.message_type==21) draw_text_ext(x+(sprite_width/2),y+(sprite_height/2)+5,global.text_message_at_swapping,message_line_spacing,sprite_width-5)
if (global.message_type==22) draw_text_ext(x+(sprite_width/2),y+(sprite_height/2)+5,global.text_message_t_detonate,message_line_spacing,sprite_width-5)
if (global.message_type==23) draw_text_ext(x+(sprite_width/2),y+(sprite_height/2)+5,global.text_message_dollar_sign_stunning,message_line_spacing,sprite_width-5)
if (global.message_type==30) draw_text_ext(x+(sprite_width/2),y+(sprite_height/2)+5,global.text_message_neutral_characters_in_diamond,message_line_spacing,sprite_width-5)
if (global.message_type==40) draw_text_ext(x+(sprite_width/2),y+(sprite_height/2)+5,global.text_level_16_instruction[global.level16messagenumber],message_line_spacing,sprite_width-5)
if (global.message_type==41) draw_text_ext(x+(sprite_width/2),y+(sprite_height/2)+5,global.text_level_24_instruction[Memory_Control.level24messagenumber],message_line_spacing,sprite_width-5)
if (global.message_type==50) draw_text_ext(x+(sprite_width/2),y+(sprite_height/2)+5,global.Player_One+" "+global.text_level_0_intro[0],message_line_spacing,sprite_width-5)
if (global.message_type==51) draw_text_ext(x+(sprite_width/2),y+(sprite_height/2)+5,global.Player_Two+" "+global.text_level_0_intro[1],message_line_spacing,sprite_width-5)
if (global.message_type==52) draw_text_ext(x+(sprite_width/2),y+(sprite_height/2)+5,global.text_level_0_intro[2],message_line_spacing,sprite_width-5)
if (global.message_type==53) draw_text_ext(x+(sprite_width/2),y+(sprite_height/2)+5,global.text_level_0_intro[3],message_line_spacing,sprite_width-5)
if (global.message_type==54) draw_text_ext(x+(sprite_width/2),y+(sprite_height/2)+5,global.text_level_0_intro[4],message_line_spacing,sprite_width-5)
if (global.message_type==55) draw_text_ext(x+(sprite_width/2),y+(sprite_height/2)+5,global.text_click+' '+global.Player_One+', '+global.Player_Two+" "+global.text_level_0_intro[5],message_line_spacing,sprite_width-5)
if (global.message_type==56) 
{
    var player_name;
    player_name = ""
    if (instance_number(Go_Number_Red)>0) player_name = global.Player_One
    if (instance_number(Go_Number_Black)>0) player_name = global.Player_Two
    draw_text_ext(x+(sprite_width/2),y+(sprite_height/2)+5,player_name+", "+global.text_level_0_intro[6],message_line_spacing,sprite_width-5)
}
if (global.message_type==57) draw_text_ext(x+(sprite_width/2),y+(sprite_height/2)+5,global.text_level_0_intro[7],message_line_spacing,sprite_width-5)
draw_set_halign(0)
draw_set_valign(0)
#define Mouse_Drag_Script
// Mouse_Drag_Script
// Stefan Grace
// Created: 2017-07-22
// Modified: 2020-03-01
// This script makes it so you can drag objects around with the mouse

/* arguments
argument0 = item to move
    1 = Message
    2 = Tablet UI
*/

if mouse_x > x and mouse_x < x+sprite_width and mouse_y > y and mouse_y < y+sprite_height
{
    mouse_clicked = 1
}

if mouse_button == mb_left and mouse_clicked == 1
{
    x = mouse_x - (sprite_width/2)
    y = mouse_y - (sprite_height/2)
}

if mouse_button != mb_left
{
    mouse_clicked = 0
}

// Make it so you can move the message with the IJKL keys insted of mouse
if (argument0 < 1)
{
    var key_speed joy_speed;
    key_speed = 3
    joy_speed = 10
    if (keyboard_check(ord("I"))) y -= key_speed
    if (keyboard_check(ord("J"))) x -= key_speed
    if (keyboard_check(ord("K"))) y += key_speed
    if (keyboard_check(ord("L"))) x += key_speed
    if (abs(joystick_zpos(0)) > 0.1) x += joystick_zpos(0) * joy_speed
    if (abs(joystick_rpos(0)) > 0.1) y += joystick_rpos(0) * joy_speed
}

x = round(x)
y = round(y)
#define Object_Destroy
// Enviroments
with (Yellow) if (place_meeting(x,y,other)) instance_destroy()
with (Rock) if (place_meeting(x,y,other)) instance_destroy()
with (Dimond) if (place_meeting(x,y,other)) instance_destroy()

// Objects
with (Boulder) if (place_meeting(x,y,other)) instance_destroy()

// Arrows
with (Right_Arrow) if (place_meeting(x,y,other)) instance_destroy()
with (Left_Arrow) if (place_meeting(x,y,other)) instance_destroy()
with (Up_Arrow) if (place_meeting(x,y,other)) instance_destroy()
with (Down_Arrow) if (place_meeting(x,y,other)) instance_destroy()
with (Horizontal_Arrow) if (place_meeting(x,y,other)) instance_destroy()
with (Vertical_Arrow) if (place_meeting(x,y,other)) instance_destroy()

// Anger Colors
with (Red_Anger) if (place_meeting(x,y,other)) instance_destroy()
with (Orange_Anger) if (place_meeting(x,y,other)) instance_destroy()
with (Blue_Anger) if (place_meeting(x,y,other)) instance_destroy()
with (Purple_Anger) if (place_meeting(x,y,other)) instance_destroy()


// Anger Numbers
with (Anger_00) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_01) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_02) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_03) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_04) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_05) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_06) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_07) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_08) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_09) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_10) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_11) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_12) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_13) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_14) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_15) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_16) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_17) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_18) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_19) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_20) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_21) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_22) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_23) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_24) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_25) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_26) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_27) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_28) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_29) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_30) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_31) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_32) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_33) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_34) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_35) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_36) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_37) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_38) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_39) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_40) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_41) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_42) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_43) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_44) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_45) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_46) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_47) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_48) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_49) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_50) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_51) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_52) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_53) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_54) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_55) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_56) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_57) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_58) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_59) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_60) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_61) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_62) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_63) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_64) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_65) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_66) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_67) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_68) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_69) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_70) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_71) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_72) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_73) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_74) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_75) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_76) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_77) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_78) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_79) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_80) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_81) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_82) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_83) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_84) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_85) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_86) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_87) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_88) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_89) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_90) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_91) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_92) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_93) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_94) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_95) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_96) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_97) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_98) if (place_meeting(x,y,other)) instance_destroy()
with (Anger_99) if (place_meeting(x,y,other)) instance_destroy()

// Double Boxing
with (Double_Boxing) if (place_meeting(x,y,other)) instance_destroy()
with (Double_Boxing_Yellow) if (place_meeting(x,y,other)) instance_destroy()
with (Double_Boxing_Rock) if (place_meeting(x,y,other)) instance_destroy()
with (Double_Boxing_Dimond) if (place_meeting(x,y,other)) instance_destroy()
#define P_One_Name_OK_Script
// P_One_Name_OK_Script
// Stefan Grace
// Created: 2016-07-03
// Modified: 2016-07-03
// This script sets Player 1's name when the OK button is clicked or the ENTER key is pressed

if (string_length(keyboard_string)==0)
{
    message_background (Message_background)
    message_button (Message_button) 
    message_button_font (font,11,blue,bold)
    show_message (string(global.text_player_name_change_a)+string(global.MAX_LENGTH)+string(global.text_player_name_change_b))
}
else
{
    global.Player_One = keyboard_string
    room_goto(Settings_Room)
}
#define P_Two_Name_OK_Script
// P_Two_Name_OK_Script
// Stefan Grace
// Created: 2016-07-03
// Modified: 2016-07-03
// This script sets Player 2's name when the OK button is clicked or the ENTER key is pressed

if (string_length(keyboard_string)==0)
{
    message_background (Message_background)
    message_button (Message_button) 
    message_button_font (font,11,blue,bold)
    show_message (string(global.text_player_name_change_a)+string(global.MAX_LENGTH)+string(global.text_player_name_change_b))

}
else
{
    global.Player_Two = keyboard_string
    room_goto(Settings_Room)
}
#define Player_One_Select_Script
// Player_One_Select_Script
// Stefan Grace
// Created: 2016-07-19
// Modified: 2019-04-04
// This script is executed when Player 1 is selected to start the level 

script_execute(Red_Unstun)
script_execute(Player_Select_Script)
instance_create(0,0,Go_Number_Red)
instance_create(1120,0,Draw_Mode_Red)
if (global.levelnumber == 0) script_execute(Level_0_Intro, 1)
#define Player_Two_Select_Script
// Player_Two_Select_Script
// Stefan Grace
// Created: 2016-07-19
// Modified: 2019-04-04
// This script is executed when Player 2 is selected to start the level 

script_execute(Black_Unstun)
script_execute(Player_Select_Script)
instance_create(0,0,Go_Number_Black)
instance_create(1120,0,Draw_Mode_Black)
if (global.levelnumber == 0) script_execute(Level_0_Intro, 2)

#define Player_Select_Script
with(Player_One_Select) instance_destroy()
with(Player_Two_Select) instance_destroy()
with(Player_Select) instance_destroy()
with(Player_Random) instance_destroy()

if(global.levelnumber==16)
{
    global.message_type = 40
    instance_create(105, 210, Message_Object)
}

if(global.levelnumber==24)
{
    global.message_type = 41
    instance_create(945, 315, Message_Object)
}
#define Player_Win_Script
// Player_Win_Script
// Stefan Grace
// Created: 2016-07-18
// Modified: 2016-08-07
// This scirpt checks if either player has any 'O's left

if ((instance_number(Player_One_Winz)==0) and (instance_number(Black_Stuned_O)==0) and (instance_number(Black_O)==0) and (instance_number(Black_Blue_O)==0)) instance_create(0,0,Player_One_Winz)
if ((instance_number(Player_Two_Winz)==0) and (instance_number(Red_Stuned_O)==0) and (instance_number(Red_O)==0) and (instance_number(Red_Blue_O)==0)) instance_create(0,0,Player_Two_Winz)


/* UNUSED LINES OF CODE
// This scirpt checks if either player has any survival characters left
and (instance_number(Black_Stuned_Square)==0) and (instance_number(Black_Square)==0) and (instance_number(Black_Blue_Square)==0) and (instance_number(Black_Stuned_Triangle)==0) and (instance_number(Black_Triangle)==0) and (instance_number(Black_Blue_Triangle)==0) and (instance_number(Black_Stuned_E)==0) and (instance_number(Black_E)==0) and (instance_number(Black_Blue_E)==0) and (instance_number(Black_Stuned_R)==0) and (instance_number(Black_R)==0) and (instance_number(Black_Blue_R)==0)
and (instance_number(Red_Stuned_Square)==0) and (instance_number(Red_Square)==0) and (instance_number(Red_Blue_Square)==0) and (instance_number(Red_Stuned_Triangle)==0) and (instance_number(Red_Triangle)==0) and (instance_number(Red_Blue_Triangle)==0) and (instance_number(Red_Stuned_E)==0) and (instance_number(Red_E)==0) and (instance_number(Red_Blue_E)==0) and (instance_number(Red_Stuned_R)==0) and (instance_number(Red_R)==0) and (instance_number(Red_Blue_R)==0)
*/
#define Player_Winz_Script
with (Player_Change_Black) instance_destroy()
with (Player_Change_Red) instance_destroy()
alarm[0] = 120
script_execute(Character_Click_Black)
script_execute(Character_Click_Red)
script_execute(Red_Stun)
script_execute(Black_Stun)
script_execute(Delete_Save)
with (Message_Object) instance_destroy()
with (X_Message) instance_destroy()
with (Move_Message) instance_destroy()
with (Tablet_UI_Parent) instance_destroy()
alarm[1] = 2
#define Purple_Pi_Create
// Purple_Pi_Create
// Stefan Grace
// Created: 2017-12-23
// Modified: 2017-12-23


move_snap(grid_size,grid_size)
with(Yellow)
{
    if(place_meeting(x,y,other)) instance_destroy()
}
with(Rock)
{
    if(place_meeting(x,y,other)) instance_destroy()
}
with(Dimond)
{
    if(place_meeting(x,y,other)) instance_destroy()
}
instance_create(x,y,Concreet)
#define Question_Mark_Change
// Question_Mark_Change
// Stefan Grace
// Created: 2017-12-24
// Modified: 2020-02-14

/*
arguments
    argument0 - Character ID    
*/


with(Character)
{
    if (character_id==26 or purple>0)
    {
        if (state==3)
        {
            if (character_id==31) with(Concreet) if(place_meeting(x,y,other)) {instance_destroy(); instance_create(x,y,Yellow)} // to get rid of the concreet if a puple pi turns into somthing else
            character_id = argument0
            if (player==1)
            {
                if (argument0==0) instance_change(Red_Blue_O,false)
                if (argument0==1) instance_change(Red_Blue_X,false)
                if (argument0==2) instance_change(Red_Blue_Triangle,false)
                if (argument0==3) instance_change(Red_Blue_A,false)
                if (argument0==4) instance_change(Red_Blue_Square,false)
                if (argument0==5) instance_change(Red_Blue_K,false)
                if (argument0==6) instance_change(Red_Blue_B,false)
                if (argument0==7) instance_change(Red_Blue_E,false)
                if (argument0==8) instance_change(Red_Blue_S,false)
                if (argument0==9) instance_change(Red_Blue_H,false)
                if (argument0==10) instance_change(Red_Blue_R,false)
                if (argument0==11) instance_change(Red_Blue_M,false)
                if (argument0==12) instance_change(Red_Blue_F,false)
                if (argument0==13) {g_hit = 4; g_type = 0; move_snap(grid_size,grid_size); instance_change(Red_Blue_G,false); instance_create(x,y,Explosion)}
                if (argument0==14) instance_change(Red_Blue_C,false)
                if (argument0==15) instance_change(Red_Blue_Y,false)
                if (argument0==16) instance_change(Red_Blue_Z,false)
                if (argument0==17) instance_change(Red_Blue_W,false)
                if (argument0==18) instance_change(Red_Blue_J,false)
                if (argument0==19) instance_change(Red_Blue_V,false)
                if (argument0==20) instance_change(Red_Blue_P,false)
                if (argument0==21) instance_change(Red_Blue_T,false)
                if (argument0==22) instance_change(Red_Blue_D,false)
                if (argument0==23) instance_change(Red_Blue_Q,false)
                if (argument0==24) instance_change(Red_Blue_N,false)
                if (argument0==26) instance_change(Red_Blue_Question_Mark,false)
                if (argument0==27) instance_change(Red_Blue_U,false)
                if (argument0==28) instance_change(Red_Blue_L,false)
                if (argument0==29) instance_change(Red_Blue_Dollar_Sign,false)
                if (argument0==30) instance_change(Red_Blue_At,false)
                if (argument0==31) {instance_change(Red_Blue_Pi,false); script_execute(Purple_Pi_Create)}
                if (argument0==32) instance_change(Red_Blue_I,false)
                if (argument0==33) {g_hit = 1; g_type = 3; character_id = 13; instance_change(Red_Blue_G,false); move_snap(grid_size,grid_size)}
            }
            else if (player==2)
            {
                if (argument0==0) instance_change(Black_Blue_O,false)
                if (argument0==1) instance_change(Black_Blue_X,false)
                if (argument0==2) instance_change(Black_Blue_Triangle,false)
                if (argument0==3) instance_change(Black_Blue_A,false)
                if (argument0==4) instance_change(Black_Blue_Square,false)
                if (argument0==5) instance_change(Black_Blue_K,false)
                if (argument0==6) instance_change(Black_Blue_B,false)
                if (argument0==7) instance_change(Black_Blue_E,false)
                if (argument0==8) instance_change(Black_Blue_S,false)
                if (argument0==9) instance_change(Black_Blue_H,false)
                if (argument0==10) instance_change(Black_Blue_R,false)
                if (argument0==11) instance_change(Black_Blue_M,false)
                if (argument0==12) instance_change(Black_Blue_F,false)
                if (argument0==13) {g_hit = 4; g_type = 0; move_snap(grid_size,grid_size); instance_change(Black_Blue_G,false); instance_create(x,y,Explosion)}
                if (argument0==14) instance_change(Black_Blue_C,false)
                if (argument0==15) instance_change(Black_Blue_Y,false)
                if (argument0==16) instance_change(Black_Blue_Z,false)
                if (argument0==17) instance_change(Black_Blue_W,false)
                if (argument0==18) instance_change(Black_Blue_J,false)
                if (argument0==19) instance_change(Black_Blue_V,false)
                if (argument0==20) instance_change(Black_Blue_P,false)
                if (argument0==21) instance_change(Black_Blue_T,false)
                if (argument0==22) instance_change(Black_Blue_D,false)
                if (argument0==23) instance_change(Black_Blue_Q,false)
                if (argument0==24) instance_change(Black_Blue_N,false)
                if (argument0==26) instance_change(Black_Blue_Question_Mark,false)
                if (argument0==27) instance_change(Black_Blue_U,false)
                if (argument0==28) instance_change(Black_Blue_L,false)
                if (argument0==29) instance_change(Black_Blue_Dollar_Sign,false)
                if (argument0==30) instance_change(Black_Blue_At,false)
                if (argument0==31) {instance_change(Black_Blue_Pi,false); script_execute(Purple_Pi_Create)}
                if (argument0==32) instance_change(Black_Blue_I,false)
                if (argument0==33) {g_hit = 1; g_type = 3; character_id = 13; instance_change(Black_Blue_G,false); move_snap(grid_size,grid_size)}
            }
            score -= 1
            script_execute(Question_Mark_Display_Remove)
            with(Cancel) instance_destroy()
        }
    }
}

#define Question_Mark_Display
// Question_Mark_Display
// Stefan Grace
// Created: 2017-12-23
// Modified: 2020-02-27


var x_plus;
var y_plus;
x_plus = 0
y_plus = -200

var hide_pi;
hide_pi = false

with (Black_Blue)
{
    if (S_Stuned > 0) exit
}

with (Red_Blue)
{
    if (S_Stuned > 0) exit
}

with (X_Message) Close_Message()

with(Character)
{
    if (character_id==26 or purple>0)
    {
        if (state==3)
        {
            with(all)
            {
                if (character_id>0 or character_o>0)
                {
                    if (x - (x mod grid_size) == other.x - (other.x mod grid_size)) and (y - (y mod grid_size) == other.y - (other.y mod grid_size))
                    {
                        hide_pi = true
                    }
                }
            }
            instance_create(0,0,Wood_Object_Level_Cover)
            if (character_id!=0) instance_create(280+x_plus,420+y_plus,Character_Button_O)
            if (character_id!=1) instance_create(350+x_plus,420+y_plus,Character_Button_X)
            if (character_id!=2) instance_create(420+x_plus,420+y_plus,Character_Button_Triangle)
            if (character_id!=3) instance_create(490+x_plus,420+y_plus,Character_Button_A)
            if (character_id!=4) instance_create(560+x_plus,420+y_plus,Character_Button_Square)
            if (character_id!=5) instance_create(630+x_plus,420+y_plus,Character_Button_K)
            if (character_id!=6) instance_create(700+x_plus,420+y_plus,Character_Button_B)
            if (character_id!=7) instance_create(770+x_plus,420+y_plus,Character_Button_E)
            if (character_id!=8) instance_create(840+x_plus,420+y_plus,Character_Button_S)
            if (character_id!=9) instance_create(910+x_plus,420+y_plus,Character_Button_H)
            if (character_id!=10) instance_create(980+x_plus,420+y_plus,Character_Button_R)
            if (character_id!=11) instance_create(280+x_plus,490+y_plus,Character_Button_M)
            if (character_id!=12) instance_create(350+x_plus,490+y_plus,Character_Button_F)
            if (character_id!=13 or g_type!=0) instance_create(420+x_plus,490+y_plus,Character_Button_G)
            if (character_id!=14) instance_create(490+x_plus,490+y_plus,Character_Button_C)
            if (character_id!=15) instance_create(560+x_plus,490+y_plus,Character_Button_Y)
            if (character_id!=16) instance_create(630+x_plus,490+y_plus,Character_Button_Z)
            if (character_id!=17) instance_create(700+x_plus,490+y_plus,Character_Button_W)
            if (character_id!=18) instance_create(770+x_plus,490+y_plus,Character_Button_J)
            if (character_id!=19) instance_create(840+x_plus,490+y_plus,Character_Button_V)
            if (character_id!=20) instance_create(910+x_plus,490+y_plus,Character_Button_P)
            if (character_id!=21) instance_create(980+x_plus,490+y_plus,Character_Button_T)
            if (character_id!=22) instance_create(280+x_plus,560+y_plus,Character_Button_D)
            if (character_id!=23) instance_create(350+x_plus,560+y_plus,Character_Button_Q)
            if (character_id!=24) instance_create(420+x_plus,560+y_plus,Character_Button_N)
            if (character_id!=26) instance_create(490+x_plus,560+y_plus,Character_Button_Question_Mark)
            if (character_id!=27) instance_create(560+x_plus,560+y_plus,Character_Button_U)
            if (character_id!=28) instance_create(630+x_plus,560+y_plus,Character_Button_L)
            if (character_id!=29) instance_create(700+x_plus,560+y_plus,Character_Button_Dollar_Sign)
            if (character_id!=30) instance_create(770+x_plus,560+y_plus,Character_Button_At)
            if (character_id!=31 and !place_meeting(x,y,Steel) and !place_meeting(x,y,Double_Boxing) /*and !hide_pi*/) instance_create(840+x_plus,560+y_plus,Character_Button_Pi)
            if (character_id!=32) instance_create(910+x_plus,560+y_plus,Character_Button_I)
            if ((character_id!=13 or g_type!=3) /*and !hide_pi*/) instance_create(980+x_plus,560+y_plus,Character_Button_Big_W)
            instance_create(490,600,Cancel)
        }
    }
}
#define Question_Mark_Display_Remove
// Question_Mark_Display_Remove
// Stefan Grace
// Created: 2017-12-23
// Modified: 2017-12-23


with(Wood_Object_Level_Cover) instance_destroy()
with(Character_Button_O) instance_destroy()
with(Character_Button_X) instance_destroy()
with(Character_Button_Triangle) instance_destroy()
with(Character_Button_A) instance_destroy()
with(Character_Button_Square) instance_destroy()
with(Character_Button_K) instance_destroy()
with(Character_Button_B) instance_destroy()
with(Character_Button_E) instance_destroy()
with(Character_Button_S) instance_destroy()
with(Character_Button_H) instance_destroy()
with(Character_Button_R) instance_destroy()
with(Character_Button_M) instance_destroy()
with(Character_Button_F) instance_destroy()
with(Character_Button_G) instance_destroy()
with(Character_Button_C) instance_destroy()
with(Character_Button_Y) instance_destroy()
with(Character_Button_Z) instance_destroy()
with(Character_Button_W) instance_destroy()
with(Character_Button_J) instance_destroy()
with(Character_Button_V) instance_destroy()
with(Character_Button_P) instance_destroy()
with(Character_Button_T) instance_destroy()
with(Character_Button_D) instance_destroy()
with(Character_Button_Q) instance_destroy()
with(Character_Button_N) instance_destroy()
with(Character_Button_Question_Mark) instance_destroy()
with(Character_Button_U) instance_destroy()
with(Character_Button_L) instance_destroy()
with(Character_Button_Dollar_Sign) instance_destroy()
with(Character_Button_At) instance_destroy()
with(Character_Button_Pi) instance_destroy()
with(Character_Button_I) instance_destroy()
with(Character_Button_Big_W) instance_destroy()
instance_destroy()
#define R_Arrow_Black_Kill_Red
if (instance_number(Go_Number_Black)==1)
{
    with other instance_destroy()
    instance_destroy()
}
#define R_Arrow_Red_Kill_Black
if (instance_number(Go_Number_Red)==1)
{
    with other instance_destroy()
    instance_destroy()
}
#define Reset_Code
// Reset Script
// Stefan Grace
// Created: 2015-06-19
// Modifed: 2016-07-14
// This script resets the whole game when the player cicks  the 'reset' button

//sets the appreance of the message
message_background (Message_background)
message_button (Message_button) 
message_button_font (font,11,blue,bold)

//resets the game
if(show_question(global.text_reset_message_a+"#"+global.text_reset_message_b))
{
    global.Level_0_Save = 0
    global.Level_1_Save = 0
    global.Level_2_Save = 0
    global.Level_3_Save = 0
    global.Level_4_Save = 0
    global.Level_5_Save = 0
    global.Level_6_Save = 0
    global.Level_7_Save = 0
    global.Level_8_Save = 0
    global.Level_9_Save = 0
    global.Level_10_Save = 0
    global.Level_11_Save = 0
    global.Level_12_Save = 0
    global.Date_Order = 0
    global.Time_Format = 0
    global.Date_Time_Order = 0
    global.Year_Format = 0
    global.Month_Format = 0
    room_goto(Main_Menu_Room)
    show_message(global.text_reset_message_c+"#"+global.text_reset_message_d) 
}

#define Save_Global
// Save_Global
// Stefan Grace
// Created: before 2017-06-20
// Modified: 2022-08-21
// This script saves some important global variables to txt files

var dir file;

dir = working_directory + "\Settings\"
if (!directory_exists(dir)) directory_create(dir)

// Language
if (file_exists(working_directory+"\Settings\Language.txt"))
{
    file = file_text_open_write(working_directory + "\Settings\Language.txt")
    file_text_write_string(file, string(global.Language))
    file_text_close(file)
}

// Player 1 Name
if (file_exists(working_directory+"\Settings\Player_1_Name.txt"))
{
    file = file_text_open_write(working_directory + "\Settings\Player_1_Name.txt")
    file_text_write_string(file,global.Player_One)
    file_text_close(file)
}

// Player 2 Name
if (file_exists(working_directory+"\Settings\Player_2_Name.txt"))
{
    file = file_text_open_write(working_directory + "\Settings\Player_2_Name.txt")
    file_text_write_string(file,global.Player_Two)
    file_text_close(file)
}

// Music
if (file_exists(working_directory+"\Settings\Music.txt"))
{
    file = file_text_open_write(working_directory + "\Settings\Music.txt")
    file_text_write_real(file,global.Music_Playing)
    file_text_close(file)
}

// Date and Time Format Settings
if (file_exists(working_directory+"\Settings\Date_Time.txt"))
{
    var date_time_val;
    date_time_val = global.Date_Order + (global.Time_Format*10) + (global.Date_Time_Order*100) + (global.Year_Format*1000) + (global.Month_Format*10000)
    file = file_text_open_write(working_directory + "\Settings\Date_Time.txt")
    file_text_write_real(file,date_time_val)
    file_text_close(file)
}

// Show Backgrounds
if (file_exists(working_directory+"\Settings\Show_Backgrounds.txt"))
{
    file = file_text_open_write(working_directory + "\Settings\Show_Backgrounds.txt")
    file_text_write_real(file,global.show_backgrounds)
    file_text_close(file)
}

// Cheats
if (file_exists(working_directory+"\Settings\Cheats.txt"))
{
    file = file_text_open_write(working_directory + "\Settings\Cheats.txt")
    file_text_write_real(file,global.cheats)
    file_text_close(file)
}

// Tablet Mode
if (file_exists(working_directory+"\Settings\Tablet_Mode.txt"))
{
    file = file_text_open_write(working_directory + "\Settings\Tablet_Mode.txt")
    file_text_write_real(file,global.tablet_mode)
    file_text_close(file)
}

// Fullscreen
if (file_exists(working_directory+"\Settings\Fullscreen.txt"))
{
    file = file_text_open_write(working_directory + "\Settings\Fullscreen.txt")
    file_text_write_real(file, window_get_fullscreen());
    file_text_close(file)
}
#define Stuned_Step_After_Kill_Check
// Stuned_Step_After_Kill_Check
// Stefan Grace
// Created: 2017-08-12
// Modified: 2017-08-12
// This script is executed on all stuned characters each step after the character has checked what it should kill and be killed by

if (to_be_killed) instance_destroy()

#define Take_Screen_Shot
var current_month_leading_zero;
var current_day_leading_zero;
var current_hour_leading_zero;
var current_minute_leading_zero;
var current_second_leading_zero;

var date_text;
var time_text;
var level_name;
var date_time_text;

var fname;
var dir;


// Add leading zeros to date elements
if (current_month<10) current_month_leading_zero=string("0")+string(current_month) else current_month_leading_zero = current_month
if (current_day<10) current_day_leading_zero=string("0")+string(current_day) else current_day_leading_zero = current_day 
if (current_hour<10) current_hour_leading_zero=string("0")+string(current_hour) else current_hour_leading_zero = current_hour 
if (current_minute<10) current_minute_leading_zero=string("0")+string(current_minute) else current_minute_leading_zero = current_minute
if (current_second<10) current_second_leading_zero=string("0")+string(current_second) else current_second_leading_zero = current_second 

// Assesemble the date elements
date_text = string(current_year)+"-"+string(current_month_leading_zero)+"-"+string(current_day_leading_zero)
time_text = string(current_hour_leading_zero)+"-"+string(current_minute_leading_zero)+"-"+string(current_second_leading_zero)
date_time_text = date_text+" "+time_text

// Create the level name
if (!global.onlevel)
{
    level_name = "Menu"
}
else if (global.levelnumber < -10)
{
    level_name = "Test Level " + string(-global.levelnumber)
}
else if (global.levelnumber < 0)
{
    level_name = "Test Level 0" + string(-global.levelnumber)
}
else if (global.levelnumber < 10)
{
    level_name = "Level 0" + string(global.levelnumber) 
}
else 
{
    level_name = "Level " + string(global.levelnumber)
}


// Save the screenshot to the BMP file
fname = level_name + " " + date_time_text + ".bmp"
dir = working_directory + "\Screenshots\"
if (!directory_exists(dir)) directory_create(dir)

screen_save(dir + fname)
#define Tunnle
if vk_right or vk_left or vk_down or vk_up 
instance_change (Yellow,false);
#define Level_0_Intro
// Level_0_Intro
// Stefan Grace
// Created: 2019-04-04
// Modified: 2019-04-04

/* arguments

    argument0 - Player
        1 - Player 1
        2 - Player 2
*/


with(Message_Object) instance_destroy()
global.level0messagenumber = 6
global.message_type = 56
if (argument0 == 1)
{   
    if (!global.red_level_0_message_6_hasbeenshown)
    {
        instance_create(875, 560, Message_Object)
        global.red_level_0_message_6_hasbeenshown = true
    }
} 
else 
{
    if (!global.black_level_0_message_6_hasbeenshown)
    {
        instance_create(70, 70, Message_Object)
        global.black_level_0_message_6_hasbeenshown =  true
    }
}

/*
if (instance_number(argument0 == 1))
{
    Move_Message.x = 875
    Move_Message.y = 560
} 
else 
{
    Move_Message.x = 70
    Move_Message.y = 70
}
*/
#define Close_Message
if global.levelnumber==12 and global.level12messagenumber==0
{
    global.message_type = 30
    global.level12messagenumber = 1
    Move_Message.x = 490
    Move_Message.y = 175
    exit
}

if global.levelnumber==0 
{
    if (global.level0messagenumber==0)
    {
        global.level0messagenumber = 1
        global.message_type = 50
        Move_Message.x = 875
        Move_Message.y = 560
        exit
    }
    else if (global.level0messagenumber==1)
    {
        global.level0messagenumber = 2
        global.message_type = 51
        Move_Message.x = 70
        Move_Message.y = 70
        exit
    }
    else if (global.level0messagenumber==2)
    {
        global.level0messagenumber = 3
        global.message_type = 52
        Move_Message.x = 385
        Move_Message.y = 120
        exit
    }
    else if (global.level0messagenumber==3)
    {
        global.level0messagenumber = 4
        global.message_type = 53
        exit
    }
    else if (global.level0messagenumber==4)
    {
        global.level0messagenumber = 5
        global.message_type = 54
        exit
        
    }
    else if (global.level0messagenumber==5)
    {
        global.level0messagenumber = 6
        global.message_type = 55
        Move_Message.x = 490
        Move_Message.y = 70
        instance_create(315,0,Player_One_Select)
        instance_create(455,0,Player_Select)
        instance_create(875,0,Player_Two_Select)
        instance_create(1190,0,Player_Random)
        exit
    }/*
    else if (global.level0messagenumber==7)
    {
        global.level0messagenumber = 3
        global.message_type = 52
        Move_Message.x = 385
        Move_Message.y = 105
        exit
    }*/
    
    
}
if (global.at_swapping != 0) global.at_swapping = 0
if (global.dollar_sign_stunning != 0) global.dollar_sign_stunning = 0
if (global.big_w_life_draining) global.big_w_life_draining = false
if (global.big_w_life_giving) global.big_w_life_giving = false
if (global.w_casting) global.w_casting = false
if (global.t_detonating != 0) global.t_detonating = 0
if (global.Red_B_Killing_Left != 0) global.Red_B_Killing_Left = 0
if (global.Red_B_Killing_Up != 0) global.Red_B_Killing_Up = 0
if (global.Red_B_Killing_Right != 0) global.Red_B_Killing_Right = 0
if (global.Red_B_Killing_Down != 0) global.Red_B_Killing_Down = 0
if (global.Black_B_Killing_Left != 0) global.Black_B_Killing_Left = 0
if (global.Black_B_Killing_Up != 0) global.Black_B_Killing_Up = 0
if (global.Black_B_Killing_Right != 0) global.Black_B_Killing_Right = 0
if (global.Black_B_Killing_Down != 0) global.Black_B_Killing_Down = 0
with (Message_Object) instance_destroy()
with (Move_Message) instance_destroy()
global.mouse_has_clicked = true
Connect_4_Control.alarm[1] = 30
instance_destroy()

#define Save_Level
// Save_Level
// Stefan Grace
// Created: 2023-08-07
// Modified: 2024-07-27
// This script saves the level data to a TXT file

// Uses the Connect_4_Save script if on Level 16
if (global.levelnumber == 16)
{
    Connect_4_Save()
    exit
}

// Generate level data text with a line for each row
var level_text;
var i;
for (i = 0; i < room_height; i += grid_size)
{
    level_text[i / grid_size] = "";
    var j;
    for (j = 0; j < room_width - 1; j += grid_size)
    {
        var tile_letter;
        tile_letter = "E"
        with(Yellow)
        {
            if (x == j and y == i) {tile_letter = "Y"}
        }
        with(Rock)
        {
            if (x == j and y == i) {tile_letter = "R"}
        }
        with(Dimond)
        {
            if (x == j and y == i) {tile_letter = "D"}
        }
        with(Concreet)
        {
            if (x == j and y == i) {tile_letter = "C"}
        }
        with(Mud)
        {
            if (x == j and y == i) {tile_letter = "M"}
        }
        with(Steel)
        {
            if (x == j and y == i) {tile_letter = "S"}
        }
        with(Double_Boxing)
        {
            if (x == j and y == i) {tile_letter = "B"}
        }
        level_text[i / grid_size] += tile_letter
    }
}

// Save character states
var red_chars;
var black_chars;
var green_chars;
var red_chars_text;
var black_chars_text;
var green_chars_text;
var i;
i = 0
with (Red_Character)
{
    red_chars[i] = id
    i += 1
}
red_chars_text = ""
var j;
for (j = 0; j < i; j += 1)
{
    var char_letter;
    switch (red_chars[j].character_id)
    {
        case 2: char_letter = "d"; break;
        case 4: char_letter = "s"; break;
        case 25: char_letter = "g"; break;
        case 31: char_letter = "p"; break;
        case 33: char_letter = "w"; break;
        case 34: char_letter = "t"; break;
        case 35: char_letter = "m"; break;
        default: char_letter = global.character_text[red_chars[j].character_id]; break;
    }
    red_chars_text += char_letter
    red_chars_text += string_replace_all(string_format(red_chars[j].x, 4, 0)," ", "0")    
    red_chars_text += string_replace_all(string_format(red_chars[j].y, 4, 0)," ", "0")   
}
i = 0;
with (Black_Character)
{
    black_chars[i] = id
    i += 1
}
black_chars_text = ""
var j;
for (j = 0; j < i; j += 1)
{
    var char_letter;
    switch (black_chars[j].character_id)
    {
        case 2: char_letter = "d"; break;
        case 4: char_letter = "s"; break;
        case 25: char_letter = "g"; break;
        case 31: char_letter = "p"; break;
        case 33: char_letter = "w"; break;
        case 34: char_letter = "t"; break;
        case 35: char_letter = "m"; break;
        default: char_letter = global.character_text[black_chars[j].character_id]; break;
    }
    black_chars_text += char_letter
    black_chars_text += string_replace_all(string_format(black_chars[j].x, 4, 0)," ", "0")    
    black_chars_text += string_replace_all(string_format(black_chars[j].y, 4, 0)," ", "0")   
}
i = 0;
with (Green_Character)
{
    green_chars[i] = id
    i += 1
}
green_chars_text = ""
var j;
for (j = 0; j < i; j += 1)
{
    var char_letter;
    switch (green_chars[j].character_id)
    {
        case 2: char_letter = "d"; break;
        case 4: char_letter = "s"; break;
        case 25: char_letter = "g"; break;
        case 31: char_letter = "p"; break;
        case 33: char_letter = "w"; break;
        case 34: char_letter = "t"; break;
        case 35: char_letter = "m"; break;
        default: char_letter = global.character_text[green_chars[j].character_id]; break;
    }
    green_chars_text += char_letter
    green_chars_text += string_replace_all(string_format(green_chars[j].x, 4, 0)," ", "0")    
    green_chars_text += string_replace_all(string_format(green_chars[j].y, 4, 0)," ", "0")   
}

// Pick file name
var file_path, lvl_num_text;
lvl_num_text = string_replace_all(string_format(global.levelnumber, 2, 0), " ", "0")
file_path = working_directory + "\Saves\Level_" + lvl_num_text + ".txt"

// Check that file is not read-only
if (file_attributes(file_path, fa_readonly)) {exit}

// Blank the file first    
var file;
file = file_text_open_write(file_path)
file_text_write_string(file, "")
file_text_close(file)

// Write level data text to file    
file = file_text_open_append(file_path)
var i;
for (i = 0; i < 22; i += 1) 
{
   file_text_write_string(file, level_text[i])
   file_text_writeln(file)
}
file_text_write_string(file, red_chars_text)
file_text_writeln(file)
file_text_write_string(file, black_chars_text)
file_text_writeln(file)
file_text_write_string(file, green_chars_text)
file_text_close(file)

#define Char_IDs_to_text
var chars;
chars = argument0
var chars_text;
chars_text = ""



var j;
for (j = 0; j < argument1; j += 1)
{
    var char_letter;
    switch (chars[j].character_id)
    {
        case 2: char_letter = "d"; break;
        case 4: char_letter = "s"; break;
        case 25: char_letter = "g"; break;
        case 31: char_letter = "p"; break;
        case 33: char_letter = "w"; break;
        case 34: char_letter = "t"; break;
        case 35: char_letter = "m"; break;
        default: char_letter = global.character_text[chars[j].character_id]; break;
    }
    chars_text += char_letter
    chars_text += string_replace_all(string_format(chars[j].x, 4, 0)," ", "0")    
    chars_text += string_replace_all(string_format(chars[j].y, 4, 0)," ", "0")   
}

return chars_text
#define Connect_4_Save
// Connect_4_Save
// Stefan Grace
// Created: 2024-07-25
// Modified: 2024-07-26
// This script saves the Connect 4 data to a TXT file

// Generate level data text with a line for each row
var level_text;
var i;
for (i = 0; i < room_height; i += grid_size)
{
    level_text[i / grid_size] = "";
    var j;
    for (j = grid_size; j < room_width - 1; j += grid_size)
    {
        var tile_letter;
        tile_letter = "."
        with(Connect_4_X)
        {
            if (x == j and y == i) {tile_letter = "R"}
        }
        with(Connect_4_O)
        {
            if (x == j and y == i) {tile_letter = "B"}
        }
        with(Connect_4_X_Yellow)
        {
            if (x == j and y == i) {tile_letter = "r"}
        }
        with(Connect_4_O_Yellow)
        {
            if (x == j and y == i) {tile_letter = "b"}
        }
        level_text[i / grid_size] += tile_letter
    }
}

// Save player turn and points
var turn_points_text;
if (instance_number(Connect_4_P1_Turn) > 0) 
{
    turn_points_text = "1"
}
else if (instance_number(Connect_4_P2_Turn) > 0)
{
    turn_points_text = "2"
}
else
{
    exit
}

turn_points_text += string(global.Player_One_Lines)
turn_points_text += string(global.Player_Two_Lines)
turn_points_text += string(global.level16messagenumber)
turn_points_text += string(global.level16message2hasshown)

// Save lines
var red_v_lines_text;
red_v_lines_text = ""
with (Red_Vertical_Line)
{
    red_v_lines_text += string_replace_all(string_format(x, 4, 0)," ", "0")
    red_v_lines_text += string_replace_all(string_format(y, 4, 0)," ", "0")
}

var red_h_lines_text;
red_h_lines_text = ""
with (Red_Horizontal_Line)
{
    red_h_lines_text += string_replace_all(string_format(x, 4, 0)," ", "0")
    red_h_lines_text += string_replace_all(string_format(y, 4, 0)," ", "0")
}

var red_tlbr_lines_text;
red_tlbr_lines_text = ""
with (Red_Diagonal_Line_TL_BR)
{
    red_tlbr_lines_text += string_replace_all(string_format(x, 4, 0)," ", "0")
    red_tlbr_lines_text += string_replace_all(string_format(y, 4, 0)," ", "0")
}

var red_trbl_lines_text;
red_trbl_lines_text = ""
with (Red_Diagonal_Line_TR_BL)
{
    red_trbl_lines_text += string_replace_all(string_format(x, 4, 0)," ", "0")
    red_trbl_lines_text += string_replace_all(string_format(y, 4, 0)," ", "0")
}

var black_v_lines_text;
black_v_lines_text = ""
with (Black_Vertical_Line)
{
    black_v_lines_text += string_replace_all(string_format(x, 4, 0)," ", "0")
    black_v_lines_text += string_replace_all(string_format(y, 4, 0)," ", "0")
}

var black_h_lines_text;
black_h_lines_text = ""
with (Black_Horizontal_Line)
{
    black_h_lines_text += string_replace_all(string_format(x, 4, 0)," ", "0")
    black_h_lines_text += string_replace_all(string_format(y, 4, 0)," ", "0")
}

var black_tlbr_lines_text;
black_tlbr_lines_text = ""
with (Black_Diagonal_Line_TL_BR)
{
    black_tlbr_lines_text += string_replace_all(string_format(x, 4, 0)," ", "0")
    black_tlbr_lines_text += string_replace_all(string_format(y, 4, 0)," ", "0")
}

var black_trbl_lines_text;
black_trbl_lines_text = ""
with (Black_Diagonal_Line_TR_BL)
{
    black_trbl_lines_text += string_replace_all(string_format(x, 4, 0)," ", "0")
    black_trbl_lines_text += string_replace_all(string_format(y, 4, 0)," ", "0")
}


// Pick file name
var file_path, lvl_num_text;
lvl_num_text = string_replace_all(string_format(global.levelnumber, 2, 0), " ", "0")
file_path = working_directory + "\Saves\Level_" + lvl_num_text + ".txt"

// Check that file is not read-only
if (file_attributes(file_path, fa_readonly)) {exit}

// Blank the file first    
var file;
file = file_text_open_write(file_path)
file_text_write_string(file, "")
file_text_close(file)

// Write level data text to file    
file = file_text_open_append(file_path)
var i;
for (i = 0; i < 22; i += 1) 
{
   file_text_write_string(file, level_text[i])
   file_text_writeln(file)
}
file_text_write_string(file, turn_points_text)
file_text_writeln(file)
file_text_write_string(file, red_v_lines_text)
file_text_writeln(file)
file_text_write_string(file, red_h_lines_text)
file_text_writeln(file)
file_text_write_string(file, red_tlbr_lines_text)
file_text_writeln(file)
file_text_write_string(file, red_trbl_lines_text)
file_text_writeln(file)
file_text_write_string(file, black_v_lines_text)
file_text_writeln(file)
file_text_write_string(file, black_h_lines_text)
file_text_writeln(file)
file_text_write_string(file, black_tlbr_lines_text)
file_text_writeln(file)
file_text_write_string(file, black_trbl_lines_text)
file_text_close(file)

#define Connect_4_Load
// Connect_4_Load
// Stefan Grace
// Created: 2024-07-25
// Modified: 2024-07-27
// This script loads the Connect 4 data from a TXT file

// Read data from file
var filename level_data; 
filename = working_directory + "\Saves\Level_16.txt"
if (file_exists(filename)) 
{
    var file;
    file = file_text_open_read(filename)
    var i;
    for (i = 0; i < 31; i += 1)
    {
        level_data[i] = file_text_read_string(file)
        file_text_readln(file)
    }
    file_text_close(file)
}

// Load player points and turn points form level data
if (string_char_at(level_data[22], 1) == "1")
{
    with (Connect_4_P1_Turn) instance_destroy()
    instance_create(0, 0, Connect_4_P1_Turn)
}
else if (string_char_at(level_data[22], 1) == "2")
{
    with (Connect_4_P2_Turn) instance_destroy()
    instance_create(0, 0, Connect_4_P2_Turn)
}
else
{
    exit
}

global.Player_One_Lines = real(string_char_at(level_data[22], 2))
global.Player_Two_Lines = real(string_char_at(level_data[22], 3))
global.level16messagenumber = real(string_char_at(level_data[22], 5))
global.level16message2hasshown = real(string_char_at(level_data[22], 5))

// Create boulders from level data
var i;
for (i = 0; i < 22; i += 1)
{
    var j;
    for (j = 0; j < 38; j += 1)
    {
        switch (string_char_at(level_data[i], j))
        {
            case "R": instance_create(j * grid_size, i * grid_size, Connect_4_X); break;
            case "B": instance_create(j * grid_size, i * grid_size, Connect_4_O); break;
            case "r": instance_create(j * grid_size, i * grid_size, Connect_4_X_Yellow); break;
            case "b": instance_create(j * grid_size, i * grid_size, Connect_4_O_Yellow); break;
        }
    }
}

// Create lines from level data
var j;
for (j = 23; j < 31; j += 1)
{
    var line;
    switch (j)
    {
        case 23: line = Red_Vertical_Line; break;
        case 24: line = Red_Horizontal_Line; break;
        case 25: line = Red_Diagonal_Line_TL_BR; break;
        case 26: line = Red_Diagonal_Line_TR_BL; break;
        case 27: line = Black_Vertical_Line; break;
        case 28: line = Black_Horizontal_Line; break;
        case 29: line = Black_Diagonal_Line_TL_BR; break;
        case 30: line = Black_Diagonal_Line_TR_BL; break;
    }

    var i;
    for (i = 0; i < string_length(level_data[j]); i += 8)
    {
        var line_x line_y;
        line_x = real(string_copy(level_data[j], i + 1, 4))
        line_y = real(string_copy(level_data[j], i + 5, 4))
        show_debug_message("x: " + string_copy(level_data[j], i + 1, 4));
        show_debug_message("y: " + string_copy(level_data[j], i + 5, 4));
        instance_create(line_x, line_y, line)
    }
}

// Remove player select UI
with(Player_One_Select) instance_destroy()
with(Player_Two_Select) instance_destroy()
with(Player_Select) instance_destroy()
with(Player_Random) instance_destroy()








#define Ask_To_Load_Save
if (!file_exists(working_directory + "\Saves\Level_" + string_replace_all(string_format(global.levelnumber, 2, 0), " ", "0") + ".txt"))
{
    exit
}

switch (global.levelnumber)
{
    case 16: 
        switch (show_message_ext(global.text_load_game, "&" + global.text_continue, "&" + global.text_restart, global.text_cancel))
        {
            case 1:
                Connect_4_Load()
                with(Background_Object) instance_destroy()
                break;
            case 2:
                Delete_Save()
                break;
            default:
                room_goto(Level_Select_1)
                break;
        }
        break;
}
#define Delete_Save
var file_path, lvl_num_text;
lvl_num_text = string_replace_all(string_format(global.levelnumber, 2, 0), " ", "0")
file_path = working_directory + "\Saves\Level_" + lvl_num_text + ".txt"
if (file_exists(file_path) && !file_attributes(file_path, fa_readonly)) file_delete(file_path)
