#define script_english
// script_english
// Stefan Grace
// Created: 2016-08-26
// Modified: 2020-02-05
// This script sets the language to English

// General
global.text_index = "Index"
global.text_characters = "Characters"
global.text_objects = "Objects"
global.text_exit = "Exit"
global.text_next_page = "Next Page"
global.text_previous_page = "Prev Page"
global.text_dark = "Dark"
global.text_light = "Light"
global.text_kills = "Kills"
global.text_tunnels = "Tunnels"
global.text_weakness = "Weakness"
global.text_toughness = "Toughness" 
global.text_special = "Special"
global.text_weak = "Weak"
global.text_medium = "Medium"
global.text_high = "High"
global.text_very_high = "Very High"
global.text_extremely_high = "Extremely High" 
global.text_triangle = "Triangle"
global.text_square = "Square"
global.text_big = "Big"
global.text_purple = "Purple"
global.text_all = "All"
global.text_next_click = '(Click the "Next Page" button to continue)'
global.text_hit = "hit"
global.text_vs = "vs"
global.text_dies = "dies"

// Character Descriptions
global.description[0] = "Basic weakest character in the game."
global.description[1] = "Strong fighting character."
global.description[2] = "Strongest all round killing character."
global.description[3] = "Specialized killing character."
global.description[4] = "Used for tunnelling."
global.description[5] = "Used for tunnelling through diamond."
global.description[6] = "Infiltrates boxes of 4."
global.description[7] = "Specialized killing character."
global.description[8] = "Stuns charters."
global.description[9] = "Hybrid killer/ tunneler."
global.description[10] = "Can shoot other characters."
global.description[11] = "Blows up the surrounding area."
global.description[12] = "Can charm other charters."
global.description[13] = "Giant, Toughest character in the game."
global.description[14] = "Hybrid- catapult/ Killer."
global.description[15] = "Protects from arrows, boulders and bombs."
global.description[16] = "One-off use, stuns all charters."
global.description[17] = "Heals and cures stuns."
global.description[18] = "Blows up a row and a column."
global.description[19] = "Stealthy assassinating character."
global.description[20] = "One-off killing character."
global.description[21] = "Twin character."
global.description[22] = "Makes diamond."
global.description[23] = "Spawns q`s."
global.description[24] = "Catapults nuclear bombs."
global.description[27] = "Stealther."
global.description[28] = "Takes all remaining moves to go a line of yellow."
global.description[29] = "Casts an AOE stun"
global.description[30] = "Teleports other characters."
global.description[31] = "Is a moveable block of concrete."
global.description[32] = "Leaves a trail of mud."
global.description[33] = "G/W hybrid." 
global.description[35] = "Can transform infinite times"


// Character Special
global.special_b[0] = "Can get into a box of 4 and remove 1 character of the oppositions choice."
global.special_s[0] = "Stuns"
global.special_s[1] = "for 1 move"
global.special_s[2] = "Characters cannot use their functions, i.e. Cast, when stunned." 
global.special_r[0] = "Can shoot all characters except Y, up to 5 tiles away."
global.special_r[1] = "Press CTRL + ARROW to shoot."
global.special_r[2] = "Takes 1 move to shoot."
global.special_m[0] = "detonates to blow up 9 adjacent tiles (single use)."
global.special_m[1] = "Press CTRL to detonate."
global.special_m[2] = "Takes 1 move to detonate."
global.special_f[0] = "Charms"
global.special_f[1] = "to make them into yours."
global.special_g[0] = "takes up 4 spaces, can get through anything and turns it into yellow. Takes 3 hits to kill."
global.special_c[0] = "Catapults boulders 5 tiles away, can catapult over anything. Boulders kill on impact. (only horizontal)"
global.special_c[2] = "Press CTRL + ARROW to catapult."
global.special_c[3] = "Cannot fire into double boxing."
global.special_c[4] = "Cannot fire into a tile containing a G"
global.special_y[0] = "Blocks arrows, boulders and bombs. Can destroy boulders and bombs by moving though the same tile as it. Standing beneath boulders stops them getting into that tile."
global.special_z[0] = "Stuns all charters except W. If the enemy has no W they are not out. If they have a W then they must move it. If they are unable to move there W they are out. (single use)" 
global.special_z[3] = "Takes 1 move to detonate."
global.special_z[4] = "Freezes enemy nuclear war heads."
global.special_z[5] = "Dose not stop nuclear war head from going off."
global.special_w[0] = "W heals G`s from 5 tiles away or curs stuns from 5 tiles away."
global.special_w[1] = "Press CTRL + ARROW to cast."
global.special_w[2] = "Takes 1 move to cast."
global.special_w[3] = "Is resistant to stuns, including Z."
global.special_w[4] = "Must be in yellow to heal or cure stun."
global.special_w[5] = "Can not heal or cure stun a charter in the same tile as it."
global.special_j[0] = "Blows up the row and a column that the J is in. (single use)"
global.special_v[0] = "Can move diagonally to kill anything, is not killed it's self, only diagonal moves kill." 
global.special_v[1] = "Normally it is killed. Cannot move into Rock/ diamond. If V moves diagonally into G," 
global.special_v[2] = "G looses 1 hit and V dies."
global.special_v[3] = "Use the Q E Z C keys to move diagonally."
global.special_p[0] = "Can kill any character, but is killed itself."
global.special_p[1] = "Takes 1 hit off a G."
global.special_p[2] = "Destroys all characters in a tile."
global.special_t[0] = "T only works with 2 or more. Dose not get used up, 1 move to detonate per T. Dose not blow up the tile that the T is in."
global.special_t[2] = "Multiple T `s can blow at once, if a tile is formed, then the middle is also completely detonated."
global.special_t[3] = "(6 moves)"
global.special_t[4] = "Press CTRL to detonate."
global.special_t[5] = "Blocked by concrete."
global.special_d[0] = "Leaves a trial of diamond in a tile as it moves out of it. Dose not turn the tile it is in into diamond."
global.special_d[1] = "Teleports and angers can't be turned into diamond."
global.special_q[0] = "Spawns 4 lowercase q`s, 1 on each side that is yellow. 4 moves to spawn. If 1 side is not yellow, no q will be there, but it will still take 4 moves."
global.special_q[1] = "Press CTRL to spawn"
global.special_q[2] = "If in a Gigga Port, Q will still take only 4 moves, but will spawn 8 q`s"
global.special_q[3] = "In Gigga Ports/ Teleports, Q will spawn q`s on both sides of the Gigga Port/ Teleport for no extra moves." 
global.special_n[0] = "Same as C but fires nuclear bombs. They do not necessarily explode on impact"
global.special_gigga_g[0] = "Gigga G takes up 4 tiles."
global.special_gigga_g[1] = "Gigga G has 5 hits."
global.special_gigga_g[2] = "When Gigga G moves, it leaves 4 tile of yellow behind."
global.special_gigga_g[3] = "Small G can not attack small G etc."
global.special_gigga_g[4] = "Gigga G can destroy its own G with no loss of hits"
global.special_gigga_g[5] = "When 2 G`s fight, the one with the least hits dies. The one with the most hits looses the amount of hits that the other G has."
global.special_gigga_g[6] = "The tile the Gigga G is in counts as 1 tile, not 4, therefore explosions which act upon multiple tile that the G is in will knock a maximum of 1 hit off the G."
global.special_question_mark[0] = "? starts off completely useless, but can use 1 move to turn into any character, taking up 4 or less spaces, (not Gigga G or Terror G)."
global.special_question_mark[1] = "Press SHIFT to change."
global.special_question_mark[2] = "Irreversible change."
global.special_u[0] = 'Can enter "stealth" mode.'
global.special_u[1] = 'Takes 1 move to enter "stealth" mode.'
global.special_u[2] = '"Stealth" mode enables it to get through medium (even steel) with out leaving yellow. When it comes back into yellow, it exits "stealth" mode automatically.'
global.special_u[3] = 'When it comes out of "stealth" mode it can kill any character without dyeing, like a V.'
global.special_u[4] = 'Cannot travel diagonally like a V.'
global.special_u[5] = 'Normally if it hits another character, U dies.'
global.special_u[6] = 'If it moves out of "stealth" mode onto a G, G looses 1 hit and U dies.'
global.special_u[7] = '1 move to climb barrier/ gate.'
global.special_l[0] = "When L reaches a plane where there is a straight line of yellow (vertical or horizontal). It may travel as far as it wants up it, by the reminder of moves. (like an anger)."
global.special_dollar_sign[0] = "Must cast on a character, not an empty tile, stuns a 5x5 area of oppositions characters except W. Stunned for 1 turn."
global.special_dollar_sign[1] = "Press control, then click on the character you wish to stun."
global.special_dollar_sign[2] = "Take 1 move to stun."
global.special_pi[0] = "Pi is a block of concrete that can move only through yellow. Can not get into a tile with another character in it, neither can character. Can not be shot/ boulders. Blocks explosions. Pi can move into an adjacent block of concrete, leaving behind it's own block of concrete."
global.special_pi[1] = "If Pi enters mud, the Pi symbol will disappear and leave behind concrete."
global.special_pi[2] = "Cannot do angers or teleports."
global.special_i[0] = "Same rules apply as with as D."
global.special_i[1] = "Cannot get trough rock."
global.special_big_w[0] = "Big W starts with 0 extra lives and can have a maximum of 4."
global.special_big_w[1] = "Has the same killing capabilities as a G. will loose 1 life when attacked by an X. normal G killing rules will apply when killing G's."
global.special_big_w[2] = "Cannot get through rock/ diamond, etc. or into a box with you own characters."
global.special_big_w[3] = "Can cast a life drain off any G from up to 5 spaces away. This will transfer 1 hit from the G to the W, until the W is fully healed. Can transfer hits from Big W to your own G but not the opponents G."
global.special_big_w[4] = "W vs. W:  W cannot transfer hits between any other Big W. cannot get into tile with other Big W`s. Can be healed by small W."
global.special_terra_g[0] = "Takes up 16 tiles."
global.special_terra_g[1] = "Terra G has 10 hits."
global.special_terra_g[2] = "Normal G rules apply."
global.special_at[0] = "Can change place with any other character on the grid."
global.special_at[1] = "Press control then select another character."
global.special_at[2] = "Takes 2 moves."
global.special_purple_question_mark[0] = "Press shift to transform into any character. Stays purple. Can be changed infinite times."

// Character Personalities
global.personality[0] = "O doesn't like to fight. She prefers listening to music, gardening and hanging out with her tight friends circle."
global.personality[1] = "X is a front line fighter and all round soldier. Just last year he received  a Victoria cross for his efforts."
global.personality[11] = "Everyone knows M for his short fuse and explosive temper. That said, he still puts his life on the line for his team."
global.personality[14] = '"Did you hear about the brave stone", jokes C, "he was a little bolder". Thankfully his catapulting skills are better than his joke telling.'
global.personality[19] = "To do his job v needs to be smart, cunning and able to plan ahead. He's won the regional chess tournament the last 3 years straight."
global.personality[23] = "As the queen bee of OXTriangle, Q likes to be at the front of the que. She considers her q's to be, well, lower class."
global.personality[25] = "As the oldest of the G brothers, terra G thinks he's the toughest guy on the block. Don't tell anyone this but he's terra-fied of spiders."
global.personality[28] = "After L won the school cross country for the third year running, everyone thought he had cheated. What they didn't know was how. He dreams one day of running his own courier franchise."
global.personality[30] = '@ loves to keep in touch with the other he characters. He can be contacted by email: "@@oxtriangle.co.nz".'
global.personality[35] = "His favorite color is purple."


// Object Names
global.text_boulder = "Boulder"
global.text_red_anger = "Red Anger"
global.text_bomb = "Bomb"
global.text_orange_anger = "Orange Anger"
global.text_barrier = "Barrier"
global.text_double_boxing = "Double Boxing"
global.text_arrow = "Arrow"
global.text_blue_anger = "Blue Anger"
global.text_diamond_bomb = "Diamond Bomb"
global.text_concrete = "Concrete"
global.text_nuclear_bomb = "Nuclear Bomb"
global.text_teleport = "Teleport"
global.text_purple_anger = "Purple Anger"
global.text_concreate_bomb = "Concreate Bomb"
global.text_nwh = "Nuclear War Head"
global.text_time_bomb = "Time Bomb"
global.text_mud = "Mud"
global.text_switch_gate = "Switch/Gate"

// Object Descriptions
global.description[100] = "Falls down always though yellow. Crushes all characters in it's path."
global.description[101] = "When you go through a red anger you are able to kill the opponent's characters"
global.description[102] = "Falls like a boulder, but for every tile of yellow it falls trough it can travel 1 tile trough rock"
global.description[103] = "When you go through an orange anger you are able tunnel rock"
global.description[104] = "TO BE WRITTEN"
global.description[105] = "TO BE WRITTEN"
global.description[106] = "A player can enter the arrow from any 3 sides that is not the head. Can only exit from head."
global.description[107] = "When you go through a blue anger you are able to tunnel diamond"
global.description[108] = "Same as bomb, but can get through rock and diamond."
global.description[110] = "Same as a boulder but detonates like a M when it hits something, e.g. rock, diamond, barrier."
global.description[111] = "When you go though a teleport, you can come out the other side"
global.description[112] = "When you go through a purple anger you are able to kill the opponent's characters, tunnel rock and tunnel diamond"
global.description[113] = "Same as bomb, but can get though rock, diamond and concrete."
global.description[114] = "Can be controlled by any player and destroys 7X7 area when activated (level 5)."
global.description[115] = "Time bomb detonates a 7x7 area, including off the edge. 1 move to set off. Time bomb will count down at the end of the player who set it offs, go. Starts to count down the first player change after the bomb is set off. When the number would reach -1 the bomb detonates. Can be pushed like a bolder."
global.description[116] = "When a character enters mud it becomes stuck in the mud. Including G`s, U`s, bombs and arrows etc. and cannot move out until mud is destroyed, but can still cast and shoot."
global.description[117] = "A gate can be opened by a switch that has the same number. Always opens from side without blocks. 1 move to open or close, adjacent to switch. Dose not kill or blocked by characters when opening. 2 gates can  be any length  as long as they are the same"


// Object Special
global.special_arrow[0] = "Boulders follow the same rules."
global.special_concrete[0] = "Can not be blown up."
global.special_concrete[1] = "Blocks paths that have been blown up, e.g. J, Nuclear war head."
global.special_concrete[2] = "Cannot be catapulted over."
global.special_concrete[3] = "Can be broken down by G."
global.special_nuclear_bomb[0] = "Blows up when it hits a G"
global.special_nuclear_bomb[1] = "Blows up when it hits an up arrow"
global.special_nuclear_bomb[2] = "When it hits a G it knocks off 2 hits, 1 for the impact and 1 for the explosion."
global.special_nwh[0] = "To detonate, click the center, then click where you want to detonate"
global.special_nwh[1] = "To raze a level a character must occupy each switch 1 round."
global.special_nwh[2] = "If another player captures it, the number must decrees to 0 before increasing."
global.special_nwh[3] = "Steel indestructible center decrees 1 level per detonation."
global.special_mud[0] = "When a tile of mud is destroyed each adjacent tile also blows up - chain effect."
global.special_mud[1] = "They all blow up."
global.special_switch_gate[0] = "Click on the switch to activate."
global.special_switch_gate[1] = "Gates cannot be destroyed by G`s."
global.special_gigga_port[0] = "Same as teleport but takes up 4 tiles."
global.special_gigga_port[1] = "Indestructible."
global.special_gigga_port[2] = "Can move G and Gigga G."
global.special_gigga_port[3] = "Cannot move terror G."
global.special_gigga_port[4] = "J explosion in the port dose 2 lines on each Gigga port."
global.special_gigga_port[5] = "Gigga port always teleports J explosions, boulder, bombs and arrows."
global.special_gigga_port[6] = "M in port."
global.special_gigga_port[7] = "Gigga port counts as 1 tile, only 1 bomb/ boulder can fit in a Gigga port at 1 time, no other character will fit in it at this time."
#define script_french
// script_french
// Stefan Grace
// Created: 2017-06-09
// Modified: 2020-02-05
// This script sets the language to French

// General
global.text_index = "Indice"
global.text_characters = "Caractère"
global.text_objects = "Objets"
global.text_exit = "Sortie"
global.text_next_page = "Page suivante"
global.text_previous_page = "Page Précédente"
global.text_kills = "Tue"
global.text_tunnels = "Tunnels"
global.text_weakness = "La faiblesse"
global.text_toughness = "Dureté" 
global.text_special = "Spécial"
global.text_weak = "Faible"
global.text_medium = "Moyen"
global.text_high = "Haute"
global.text_very_high = "Très haut"
global.text_extremely_high = "Très haut" 
global.text_triangle = "Triangle"
global.text_square = "Carré"
global.text_big = "Gros"
global.text_purple = "Violet"
global.text_all = "Tout"
global.text_next_click = '(Cliquez sur le bouton "Page suivante" pour continuer)'
global.text_hit = "frappé"
global.text_vs = "contre"
global.text_dies = "meurt"

// Character Descriptions
global.description[0] = "Caractère le plus bas de base du jeu."
global.description[1] = "Caractère de combat fort."
global.description[2] = "Le caractère le plus fort de tous les matins."
global.description[3] = "Personnage de meurtre spécialisé."
global.description[4] = "Utilisé pour le tunneling."
global.description[5] = "Utilisé pour le tunnel à travers le diamant."
global.description[6] = "Infiltre des boîtes de 4."
global.description[7] = "Personnage de meurtre spécialisé."
global.description[8] = "Étourdit les chartes."
global.description[9] = "Tueur / tuner hybride."
global.description[10] = "Peut tirer sur d'autres personnages."
global.description[11] = "Explique les environs."
global.description[12] = "Peut chariner d'autres chartes."
global.description[13] = "Géant, le personnage le plus dur du jeu."
global.description[14] = "Hybrid- catapult/ Killer."
global.description[15] = "Protège des flèches, des rochers et des bombes."
global.description[16] = "Une utilisation unique, étourdit tous les personnages."
global.description[17] = "Guérit et guérit."
global.description[18] = "Explique une rangée et une colonne."
global.description[19] = "Caractère d'assassinat furtif."
global.description[20] = "Caractère unique de tuerie."
global.description[21] = "Caractère jumelé."
global.description[22] = "Fait du diamant."
global.description[23] = "Spawns q`s."
global.description[24] = "Bombes nucléaires de catapultes."
global.description[27] = "Stealther."
global.description[28] = "Prend tous les mouvements restants pour aller une ligne de jaune."
global.description[29] = "Émet un étourdissement AOE"
global.description[30] = "Teleports other characters"
global.description[31] = "Est un bloc mobile de béton."
global.description[32] = "Laisse une trace de boue."
global.description[33] = "G / W hybride." 
global.description[35] = "Peut transformer des temps infinis"


// Character Special
global.special_b[0] = "Peut entrer dans une boîte de 4 et supprimer 1 caractère du choix des oppositions."
global.special_s[0] = "Sutns"
global.special_s[1] = "Pour 1 mouvement"
global.special_s[2] = "Les personnages ne peuvent pas utiliser leurs fonctions, c'est-à-dire Cast, lorsqu'ils sont étourdis." 
global.special_r[0] = "Peut tirer sur tous les personnages, sauf Y, jusqu'à 5 carrés."
global.special_r[1] = "Appuyez sur CTRL + ARROW pour tirer."
global.special_r[2] = "Prend 1 mouvement pour tirer."
global.special_m[0] = "Détonne de faire sauter 9 carrés adjacents (usage unique)."
global.special_m[1] = "Appuyez sur CTRL pour détoner."
global.special_m[2] = "Prend 1 mouvement pour détoner."
global.special_f[0] = "Charms"
global.special_f[1] = "Pour les transformer en vôtre."
global.special_g[0] = "Prend 4 espaces, peut parcourir n'importe quoi et le transforme en jaune. Prend 3 hits à tuer."
global.special_c[0] = "Catapultes à des carrés de 5 carrés, peuvent se préoccuper de tout. Les rochers tue sur l'impact. (Uniquement horizontal)"
global.special_c[2] = "Appuyez sur CTRL + FLÈCHE pour catapulter."
global.special_c[3] = "Ne peut pas tirer en double boxe."
global.special_c[4] = "Ne peut pas tirer dans une boîte contenant un G"
global.special_y[0] = "Bloque les flèches, les rochers et les bombes. Peut détruire les rochers et les bombes en se déplaçant sur le même carré que lui. Debout sous les rochers les arrête d'entrer dans cette boîte."
global.special_z[0] = "Étonne tous les caractères sauf W. Si l'ennemi n'a pas de W, ils ne sortent pas. S'ils ont un W, ils doivent le déplacer. S'ils sont incapables de déménager là-bas, ils sortent. (usage unique)" 
global.special_z[3] = "Prend un mouvement pour détoner."
global.special_z[4] = "Gèle les têtes de guerre nucléaire ennemies."
global.special_z[5] = "N'empêche pas l'ogive nucléaire de partir."
global.special_w[0] = "Weals G's à partir de 5 carrés ou curs stuns à partir de 5 carrés."
global.special_w[1] = "Appuyez sur CTRL + FLÈCHE pour lancer."
global.special_w[2] = "Prend un mouvement pour lancer."
global.special_w[3] = "Est résistant aux étourdissements, y compris Z."
global.special_w[4] = "Doit être en jaune pour guérir ou guérir l'étourdissement."
global.special_w[5] = "Ne peut pas soigner ou guérison étourdir une charte dans le même carré que lui."
global.special_j[0] = "Blows up the row et une colonne dans laquelle J est disponible. (Usage unique)"
global.special_v[0] = "Peut se déplacer en diagonale pour tuer tout, ne pas être tué seul, seules les tirs diagonaux tuent." 
global.special_v[1] = "Normalement, il est tué. Ne peut pas se déplacer dans Rock / Diamond. Si V se déplace en diagonale en G," 
global.special_v[2] = "G perd 1 frappe et V décède."
global.special_v[3] = "Utilisez les touches Q E Z C pour vous déplacer en diagonale."
global.special_p[0] = "Peut tuer n'importe quel personnage, mais est tué lui-même."
global.special_p[1] = "Prend 1 coup d'un G."
global.special_p[2] = "Détruit tous les caractères dans un carré."
global.special_t[0] = "T fonctionne uniquement avec 2 ou plus. Ne se gaspille pas, 1 bouge pour détoner par T. La dose ne fait pas exploser le carré dans lequel se trouve le T."
global.special_t[2] = "Les T multiples peuvent souffler à la fois, si un carré est formé, alors le milieu est également complètement détoné."
global.special_t[3] = "(6 mouvements)"
global.special_t[4] = "Je ne sais pas le contrôler."
global.special_t[5] = "Bloqué par le béton."
global.special_d[0] = "Laisse un essai de diamant dans une boîte en sortant de celle-ci. Ne tourne pas la boîte dans le diamant."
global.special_d[1] = "Les téléports et les irritations ne peuvent pas être transformés en diamants."
global.special_q[0] = "Moteures 4 q minuscules, 1 de chaque côté qui est jaune. 4 se déplace pour engendrer. Si 1 côté n'est pas jaune, aucun q ne sera là, mais il faudra encore 4 mouvements."
global.special_q[1] = "Appuyez sur CTRL pour générer"
global.special_q[2] = "Si dans un port Gigga, Q ne prend encore que 4 mouvements, mais engendrera 8 q`s"
global.special_q[3] = "Dans Gigga Ports / Teleports, Q engendrera des Q sur les deux côtés du Gigga Port / Teleport sans déplacement supplémentaire." 
global.special_n[0] = "Identique à C, mais lance des bombes nucléaires. Ils ne explosent pas nécessairement sur l'impact"
global.special_gigga_g[0] = "Gigga G occupe 4 places."
global.special_gigga_g[1] = "Gigga G a 5 succès."
global.special_gigga_g[2] = "Lorsque Giga G se déplace, il laisse 4 carrés de jaune derrière."
global.special_gigga_g[3] = "Le petit G ne peut pas attaquer le petit G e.t.c."
global.special_gigga_g[4] = "Gigga G peut détruire son propre G sans perte de hits"
global.special_gigga_g[5] = "Quand le combat de 2 G, celui qui a le moins de succès meurt. Celui qui a le plus de succès perd la quantité de hits que l'autre G a."
global.special_gigga_g[6] = "Le carré, le Gigga G, compte en 1 carré, pas 4, donc les explosions qui agissent sur des carrés multiples auxquels G est entré frappent un maximum de 1 frappent le G."
global.special_question_mark[0] = "? Commence complètement inutile, mais peut utiliser 1 mouvement pour se transformer en n'importe quel personnage, occupant 4 espaces ou moins (pas Gigga G ou Terror G)."
global.special_question_mark[1] = "Appuyez sur SHIFT pour changer."
global.special_question_mark[2] = "Changement irréversible."
global.special_u[0] = 'Peut entrer dans le mode "furtif".'
global.special_u[1] = 'Prend 1 mouvement pour entrer dans le mode "furtif".'
global.special_u[2] = 'Le mode "Stealth" lui permet de passer par le moyen (même lacier) sans sortir du jaune. Quand il revient en jaune, il sort automatiquement du mode "furtif".'
global.special_u[3] = 'Quand il sort du mode "furtif", il peut tuer n`importe quel caractère sans mourir, comme un V.'
global.special_u[4] = 'Ne peut pas voyager en diagonale comme un V.'
global.special_u[5] = 'Normalement, si elle frappe un autre personnage, U meurt.'
global.special_u[6] = 'Si elle passe du mode "furtif" sur un G, G perd 1 frappe et U meurt.'
global.special_u[7] = '1 passage à la barrière de barrière / porte.'
global.special_l[0] = "Lorsque L atteint un plan où il y a une ligne droite de jaune (verticale ou horizontale). Il peut voyager aussi loin qu'il le veut, par le rappel des mouvements. (Comme une colère)."
global.special_dollar_sign[0] = "Doit jeter un personnage, pas un carré vide, étourdit une zone de 5x5 de caractères opposés sauf W. Stunned pour 1 tour."
global.special_dollar_sign[1] = "Je ne sais pas le contrôler."
global.special_dollar_sign[2] = "Prenez 1 déplacer pour étourdir."
global.special_pi[0] = "Pi est un bloc de béton qui ne peut se déplacer que par le jaune. Ne peut pas entrer dans un carré avec un autre personnage, un personnage de niter can. Ne peut pas être tourné / roque. Bloque les explosions. Pi peut se déplacer dans un bloc adjacent de béton, laissant derrière lui son propre bloc de béton."
global.special_pi[1] = "Si Pi entre dans la boue, le symbole Pi disparaîtra et laissera derrière lui le béton."
global.special_pi[2] = "Impossible de faire des ennuis ou des téléports."
global.special_i[0] = "Les mêmes règles s'appliquent qu'avec D."
global.special_i[1] = "Ne peut pas traverser le rock."
global.special_big_w[0] = "Big W commence avec 0 vies supplémentaires et peut avoir un maximum de 4."
global.special_big_w[1] = "A-t-il les mêmes capacités de destruction qu'un G. perdra 1 vie lorsqu'elle sera attaquée par un X. Les règles normales de destruction de G s'appliqueront lors de la mort de G."
global.special_big_w[2] = "Ne peut pas passer par rock / diamond, etc. ou dans une boîte avec vos propres personnages."
global.special_big_w[3] = "Vous pouvez jeter une vidange de n'importe quel G à partir de 5 espaces. Cela transférera 1 coup de G vers W, jusqu'à ce que le W soit complètement guéri. Peut transférer les coups de Big W à votre propre G, mais pas les adversaires G."
global.special_big_w[4] = "W vs. W: W ne peut pas transférer les coups entre un autre Big W. ne peut pas entrer dans la boîte avec d'autres Big W. Peut être guéri par le petit W."
global.special_terra_g[0] = "Capture 16 carrés."
global.special_terra_g[1] = "Terra G a 10 hits."
global.special_terra_g[2] = "Les règles G normales s'appliquent."
global.special_at[0] = "Peut changer de place avec n'importe quel autre personnage sur la grille."
global.special_at[1] = "Appuyez sur contrôle puis sélectionnez un autre caractère."
global.special_at[2] = "Prend 2 mouvements."
global.special_purple_question_mark[0] = "Appuyez sur Maj pour vous transformer en n'importe quel personnage. Reste violet. Peut être changé à l'infini."

// Character Personalities
global.personality[0] = "O dosent like to fight. She prefers listening to music, gardening and hanging out with her tight friends circle."
global.personality[1] = "X est un combattant de première ligne et un soldat polyvalent. L'année dernière, il a reçu une croix de Victoria pour ses efforts."
global.personality[11] = "Tout le monde connaît M pour son fusible court et son tempérament explosif. Cela dit, il met toujours sa vie en jeu pour son équipe."
global.personality[14] = '"Avez-vous entendu parler de la pierre courageuse", plaisante C, "il était un peu plus audacieux". Heureusement, ses compétences de catapultage sont meilleures que ses blagues.'
global.personality[19] = "Pour faire son travail, il doit être intelligent, rusé et capable de planifier à l'avance. Il a remporté le tournoi d'échecs régional les 3 dernières années consécutives."
global.personality[23] = "En tant que reine des abeilles de OXTriangle, Q aime être à l'avant du que. Elle considère que ses q sont, eh bien, de la classe inférieure."
global.personality[25] = "En tant que plus âgé des frères G, Terra G pense qu'il est le gars le plus dur du quartier. Ne le dis à personne, mais il a peur des araignées."
global.personality[28] = "Après que L ait remporté le cross-country pour la troisième année consécutive, tout le monde pensait qu'il avait triché. Ce qu'ils ne savaient pas, c'était comment. Il rêve un jour de diriger sa propre franchise corrier."
global.personality[30] = '@ aime rester en contact avec les autres personnages. Il peut être contacté par email: "@@ oxtriangle.co.nz".'
global.personality[35] = "Sa couleur préférée est le violet."

// Object Names
global.text_boulder = "Rocher"
global.text_red_anger = "Red Anger"
global.text_bomb = "Bombe"
global.text_orange_anger = "Orange Anger"
global.text_barrier = "Barrière"
global.text_double_boxing = "Double boxe"
global.text_arrow = "Flèche"
global.text_blue_anger = "Blue Anger"
global.text_diamond_bomb = "Diamond Bomb"
global.text_concrete = "Béton"
global.text_nuclear_bomb = "bombe nucléaire"
global.text_teleport = "Téléportation"
global.text_purple_anger = "Purple Anger"
global.text_concreate_bomb = "Pompe à béton"
global.text_nwh = "Tête de guerre nucléaire"
global.text_time_bomb = "Bombe à retardement"
global.text_mud = "Boue"
global.text_switch_gate = "Switch/Gate"

// Object Descriptions
global.description[100] = "Chute toujours toujours jaune. Éclate tous les personnages dans son chemin."
global.description[101] = "Lorsque vous traversez une colère rouge, vous pouvez tuer les personnages adverses"
global.description[102] = "Chutes comme un rocher, mais pour chaque carré de jaune il tombe à travers il peut voyager 1 carré de roche"
global.description[103] = "Lorsque vous traversez une colère orange, vous êtes capable de creuser un tunnel"
global.description[104] = "ÊTRE ÉCRIT"
global.description[105] = "ÊTRE ÉCRIT"
global.description[106] = "Un joueur peut entrer dans la flèche de tous les 3 côtés qui ne sont pas la tête. Peut sortir de la tête."
global.description[107] = "Lorsque vous passez par un ange bleu, vous êtes en mesure de creuser un tunnel avec le diamant"
global.description[108] = "Tout comme la bombe, mais peut traverser le rock et le diamant."
global.description[110] = "Identique à un rocher mais détonne comme un M quand il frappe quelque chose, par ex. Roche, diamant, barrière."
global.description[111] = "Lorsque vous passez par une téléportation, vous pouvez sortir de l'autre côté"
global.description[112] = "Lorsque vous traversez une colère violette, vous pouvez tuer les personnages adverses, la roche tunnel et le diamant tunnel"
global.description[113] = "Identique à la bombe, mais peut traverser le rock, le diamant et le béton."
global.description[114] = "Peut être contrôlé par n'importe quel joueur et détruit la zone 7X7 lorsqu'il est activé (niveau 5)."
global.description[115] = "Le coup de foudre détonne une zone 7x7, y compris hors du bord. 1 déménager pour démarrer. La bombe à retardement compte à la fin du joueur qui l'a déclenché, allez. Commence à compter le changement du premier joueur après la désactivation de la bombe. Lorsque le nombre atteindrait -1, la bombe détonerait. Peut être poussé comme un plus audacieux."
global.description[116] = "Quand un personnage pénètre dans la boue, il devient coincé dans la boue. Y compris G`s, U`s, bombes et flèches e.t.c. Et ne peut pas déménager jusqu'à ce que la boue soit détruite, mais peut encore lancer et tirer."
global.description[117] = "Une porte peut être ouverte par un commutateur qui a le même nombre. Toujours ouvert du côté sans blocs. 1 se déplace pour ouvrir ou fermer, à côté du commutateur. Dose ne pas tuer ou bloquer par les caractères lors de l'ouverture. 2 portes peuvent être n'importe quelle longueur aussi longtemps qu'elles sont identiques"


// Object Special
global.special_arrow[0] = "Les rochers suivent les mêmes règles."
global.special_concrete[0] = "Ne peut pas être explosé."
global.special_concrete[1] = "Bloque les chemins qui ont été détruits, par ex. J, tête de guerre nucléaire."
global.special_concrete[2] = "Ne peut pas être catapulté."
global.special_concrete[3] = "Peut être décomposé par G."
global.special_nuclear_bomb[0] = "Blows up quand il frappe un G"
global.special_nuclear_bomb[1] = "Blows up quand il frappe une flèche vers le haut"
global.special_nuclear_bomb[2] = "Quand il frappe un G, il frappe 2 coups, 1 pour l'impact et 1 pour l'explosion."
global.special_nwh[0] = "Pour détoner, cliquez sur le centre, puis cliquez sur l'endroit où vous souhaitez exploser"
global.special_nwh[1] = "Pour obtenir un niveau, un personnage doit occuper chaque commutateur 1 tour."
global.special_nwh[2] = "Si un autre joueur le capture, le nombre doit décrémenter à 0 avant d'augmenter."
global.special_nwh[3] = "e centre indestructible en acier détermine 1 niveau par détonation."
global.special_nwh[4] = "Détruit complètement G`s."
global.special_mud[0] = "Quand un carré de boue est détruit, chaque carré adjacent coule aussi - effet de chaîne."
global.special_mud[1] = "Ils explosent tous."
global.special_switch_gate[0] = "Appuyez sur ALT pour activer."
global.special_switch_gate[1] = "Gates ne peut pas être détruit par G`s."
global.special_gigga_port[0] = "Le même que le télé-télé, mais prend 4 carrés."
global.special_gigga_port[1] = "Indestructible."
global.special_gigga_port[2] = "Peut déplacer G et Gigga G."
global.special_gigga_port[3] = "Ne peut pas déplacer la terreur G."
global.special_gigga_port[4] = "J explosion dans le port dose 2 lignes sur chaque port Gigga."
global.special_gigga_port[5] = "Le port Gigga téléporte toujours des explosions J, des blocs, des bombes et des flèches."
global.special_gigga_port[6] = "M dans le port."
global.special_gigga_port[7] = "Le port de Gigga compte 1 carré, une seule bombe / roque peut être installée dans un port Gigga à la fois, aucun autre personnage n'entre en forme à ce momen"
#define script_spanish
// script_spanish
// Stefan Grace
// Created: 2020-02-05
// Modified: 2020-02-05
// This script sets the language to Spanish

// General
global.text_index = "Índice"
global.text_characters = "Caracteres"
global.text_objects = "Objetos"
global.text_exit = "Salida"
global.text_next_page = "Siguiente página"
global.text_previous_page = "Pagina anterior"
global.text_dark = "Oscuro"
global.text_light = "Ligero"
global.text_kills = "Mata"
global.text_tunnels = "Túneles"
global.text_weakness = "Debilidad"
global.text_toughness = "Dureza" 
global.text_special = "Especial"
global.text_weak = "Débiles"
global.text_medium = "Medio"
global.text_high = "Alto"
global.text_very_high = "Muy alto"
global.text_extremely_high = "Extremadamente alto" 
global.text_triangle = "Triángulo"
global.text_square = "Cuadrado"
global.text_big = "Grande"
global.text_purple = "Morado"
global.text_all = "Todos"
global.text_next_click = '(Haga clic en el botón "Siguiente página" para continuar)'
global.text_hit = "golpear"
global.text_vs = "vs"
global.text_dies = "muere"

// Character Descriptions
global.description[0] = "El personaje básico más débil del juego."
global.description[1] = "Fuerte personaje de lucha."
global.description[2] = "El personaje asesino más fuerte en todos los aspectos."
global.description[3] = "Personaje asesino especializado."
global.description[4] = "Utilizado para tunelizar."
global.description[5] = "Utilizado para hacer túneles a través del diamante."
global.description[6] = "Infiltra cajas de 4."
global.description[7] = "Personaje asesino especializado."
global.description[8] = "Aturde las cartas."
global.description[9] = "Asesino / sintonizador híbrido."
global.description[10] = "Puede disparar a otros personajes."
global.description[11] = "Explota los alrededores."
global.description[12] = "Puede encantar otras cartas."
global.description[13] = "El personaje gigante y más duro del juego."
global.description[14] = "Híbrido-catapulta / Killer."
global.description[15] = "Protege de flechas, rocas y bombas."
global.description[16] = "Uso único, aturde a todos los personajes."
global.description[17] = "Cura y cura los aturdimientos."
global.description[18] = "Explota una fila y una columna."
global.description[19] = "Carácter asesino sigiloso."
global.description[20] = "Carácter asesino único."
global.description[21] = "Personaje gemelo."
global.description[22] = "Hace diamantes."
global.description[23] = "Genera q`s."
global.description[24] = "Catapultas bombas nucleares."
global.description[27] = "Stealther."
global.description[28] = "Toma todos los movimientos restantes para ir una línea amarilla."
global.description[29] = "Lanza un aturdimiento AOE"
global.description[30] = "Teletransporta a otros personajes."
global.description[31] = "Es un bloque de hormigón móvil."
global.description[32] = "Deja un rastro de barro."
global.description[33] = "G / W híbrido." 
global.description[35] = "Puede transformarse infinitas veces"


// Character Special
global.special_b[0] = "Puede entrar en una caja de 4 y eliminar 1 personaje de la elección de oposiciones."
global.special_s[0] = "Sutns"
global.special_s[1] = "para 1 movimiento"
global.special_s[2] = "Los personajes no pueden usar sus funciones, es decir, Cast, cuando están aturdidos." 
global.special_r[0] = "Puede disparar a todos los personajes excepto Y, hasta 5 casillas de distancia"
global.special_r[1] = "Presione CTRL + FLECHA para disparar."
global.special_r[2] = "Toma 1 movimiento para disparar."
global.special_m[0] = "detona para volar 9 casillas adyacentes (un solo uso)."
global.special_m[1] = "Presione CTRL para detonar."
global.special_m[2] = "Toma 1 movimiento para detonar."
global.special_f[0] = "Encantos"
global.special_f[1] = "Para convertirlos en el tuyo."
global.special_g[0] = "Ocupa 4 espacios, puede atravesar cualquier cosa y lo convierte en amarillo. Toma 3 golpes para matar."
global.special_c[0] = "Las rocas de las catapultas a 5 casillas de distancia, pueden detenerse sobre cualquier cosa. Las rocas matan en el impacto. (solo horizontal)"
global.special_c[2] = "Presione CTRL + FLECHA para catapultar."
global.special_c[3] = "No se puede disparar en doble boxeo."
global.special_c[4] = "No se puede disparar en una caja que contiene un G"
global.special_y[0] = "Bloquea flechas, cantos rodados y bombas. Puede destruir rocas y bombas moviéndose a través de la misma casilla. Pararse debajo de los cantos rodados les impide entrar en esa caja."
global.special_z[0] = "Aturde a todos los personajes excepto WITH. Si el enemigo no tiene W, no está fuera. Si tienen una W, deben moverla. Si no pueden moverse allí, están fuera. (de un solo uso)" 
global.special_z[3] = "Toma 1 movimiento para detonar."
global.special_z[4] = "Congela las ojivas nucleares enemigas."
global.special_z[5] = "No impide que la cabeza de guerra nuclear explote."
global.special_w[0] = "W cura G`s a 5 casillas de distancia o cura aturdimientos a 5 casillas de distancia."
global.special_w[1] = "Presione CTRL + FLECHA para lanzar."
global.special_w[2] = "Toma 1 movimiento para lanzar."
global.special_w[3] = "Es resistente a los aturdimientos, incluido Z."
global.special_w[4] = "Debe estar en amarillo para curar o curar el aturdimiento."
global.special_w[5] = "No se puede curar o curar aturdir una carta en el mismo cuadro que él."
global.special_j[0] = "Explota la fila y una columna en la que está la J (uso único)"
global.special_v[0] = "Puede moverse en diagonal para matar cualquier cosa, no se mata por sí mismo, solo los movimientos en diagonal matan." 
global.special_v[1] = "Normalmente se mata. No se puede mover a Roca / diamante. Si V se mueve diagonalmente a G," 
global.special_v[2] = "G pierde 1 golpe y V muere."
global.special_v[3] = "Use las teclas Q E Z C para moverse en diagonal."
global.special_p[0] = "Puede matar a cualquier personaje, pero se mata a sí mismo."
global.special_p[1] = "Toma 1 hit de una G."
global.special_p[2] = "Destruye todos los personajes en un cuadrado."
global.special_t[0] = "T solo funciona con 2 o más. La dosis no se agota, 1 movimiento para detonar por T. La dosis no explota el cuadrado en el que está la T."
global.special_t[2] = "Múltiples T `s pueden soplar a la vez, si se forma un cuadrado, entonces el medio también está completamente detonado."
global.special_t[3] = "(6 movimientos)"
global.special_t[4] = "Presione CTRL para detonar."
global.special_t[5] = "Bloqueado por hormigón."
global.special_d[0] = "Deja una prueba de diamante en una caja a medida que sale de ella. La dosis no convierte la caja en la que se encuentra en diamante."
global.special_d[1] = "Teletransportes y enojos no pueden convertirse en diamantes."
global.special_q[0] = "Genera 4 q minúsculas, 1 en cada lado que es amarillo. 4 movimientos para generar. Si 1 lado no es amarillo, no habrá q, pero aún necesitará 4 movimientos."
global.special_q[1] = "Presione CTRL para generar"
global.special_q[2] = "Si está en un puerto Giga, Q solo tomará 4 movimientos, pero generará 8 q`s"
global.special_q[3] = "En Gigga Ports / Teleports, Q generará q`s en ambos lados del Gigga Port / Teleport sin movimientos adicionales." 
global.special_n[0] = "Igual que C pero dispara bombas nucleares. No necesariamente explotan en el impacto"
global.special_gigga_g[0] = "Gigga G ocupa 4 casillas."
global.special_gigga_g[1] = "Gigga G tiene 5 resultados."
global.special_gigga_g[2] = "Cuando Gigga G se mueve, deja 4 casillas amarillas detrás."
global.special_gigga_g[3] = "Small G no puede atacar a Small G e.t.c."
global.special_gigga_g[4] = "Gigga G puede destruir su propio G sin pérdida de golpes."
global.special_gigga_g[5] = "Cuando la pelea de 2 G, el que tiene menos golpes muere. El que tiene más golpes pierde la cantidad de golpes que tiene el otro G."
global.special_gigga_g[6] = "El cuadrado en el que se encuentra el Gigga G cuenta como 1 cuadrado, no 4, por lo tanto, las explosiones que actúan sobre múltiples cuadrados en los que se encuentra la G derribarán un máximo de 1 golpe de la G."
global.special_question_mark[0] = "? comienza completamente inútil, pero puede usar 1 movimiento para convertirse en cualquier personaje, ocupando 4 o menos espacios (no Gigga G o Terror G)."
global.special_question_mark[1] = "Presione SHIFT para cambiar."
global.special_question_mark[2] = "Cambio irreversible."
global.special_u[0] = 'Puede ingresar al modo "sigiloso".'
global.special_u[1] = 'Toma 1 movimiento para ingresar al modo "sigiloso".'
global.special_u[2] = 'El modo "Stealth" le permite pasar a través del medio (incluso acero) sin dejar amarillo. Cuando vuelve a amarillo, sale del modo "sigiloso" automáticamente.'
global.special_u[3] = 'Cuando sale del modo "sigiloso" puede matar a cualquier personaje sin morir, como una V.'
global.special_u[4] = 'No puede viajar en diagonal como una V.'
global.special_u[5] = 'Normalmente si golpea a otro personaje, U muere.'
global.special_u[6] = 'Si sale del modo "sigilo" en una G, G pierde 1 golpe y U muere.'
global.special_u[7] = '1 movimiento para subir la barrera / puerta.'
global.special_l[0] = "Cuando L llega a un plano donde hay una línea recta de color amarillo (vertical u horizontal). Puede viajar tan lejos como quiera, recordando movimientos. (como una ira)"
global.special_dollar_sign[0] = "Debe lanzar sobre un personaje, no un cuadrado vacío, aturde un área de 5x5 de personajes de oposición, excepto W. Aturdido durante 1 turno."
global.special_dollar_sign[1] = "Presiona control, luego haz clic en el personaje que deseas aturdir."
global.special_dollar_sign[2] = "Toma 1 movimiento para aturdir."
global.special_pi[0] = "Pi es un bloque de concreto que solo puede moverse a través del amarillo. No se puede entrar en un cuadrado con otro personaje en él, niter puede personaje. No se puede disparar / cantos rodados. Bloquea explosiones. Pi puede moverse hacia un bloque de concreto adyacente, dejando atrás su propio bloque de concreto."
global.special_pi[1] = "Si Pi entra en el lodo, el símbolo de Pi desaparecerá y dejará hormigón."
global.special_pi[2] = "No se pueden enojar ni teletransportarse."
global.special_i[0] = "Se aplican las mismas reglas que con D."
global.special_i[1] = "No se puede atravesar la roca."
global.special_big_w[0] = "Big W comienza con 0 vidas extra y puede tener un máximo de 4."
global.special_big_w[1] = "Tiene las mismas capacidades de matar que un G. perderá 1 vida cuando sea atacado por una X. Se aplicarán las reglas normales de asesinato de G al matar a los G."
global.special_big_w[2] = "No puedes atravesar roca / diamante, etc., o entrar en una caja con tus propios personajes."
global.special_big_w[3] = "Puede lanzar un drenaje vital de cualquier G desde hasta 5 espacios de distancia. Esto transferirá 1 golpe de la G a la W, hasta que la W esté completamente curada. Puede transferir golpes de Big W a tu propia G pero no a los oponentes G."
global.special_big_w[4] = "W contra W: W no puede transferir golpes entre ningún otro Big W. no puede entrar en la caja con otros Big W`s. Puede ser curado por una pequeña W."
global.special_terra_g[0] = "Ocupa 16 casillas."
global.special_terra_g[1] = "Terra G tiene 10 golpes."
global.special_terra_g[2] = "Se aplican las reglas normales de G."
global.special_at[0] = "Puede cambiar de lugar con cualquier otro personaje en la cuadrícula."
global.special_at[1] = "Presione control y luego seleccione otro personaje."
global.special_at[2] = "Toma 2 movimientos."
global.special_purple_question_mark[0] = "Presione Mayús para transformarse en cualquier personaje. Se queda morado. Se puede cambiar infinitas veces."

// Character Personalities
global.personality[0] = "O no le gusta pelear. Ella prefiere escuchar música, cultivar un huerto y pasar el rato con su apretado círculo de amigos."
global.personality[1] = "X es un luchador de primera línea y un soldado general. El año pasado recibió una cruz Victoria por sus esfuerzos."
global.personality[11] = "Todos conocen a M por su fusible corto y su temperamento explosivo. Dicho esto, todavía pone su vida en juego para su equipo."
global.personality[14] = '"¿Has oído hablar de la piedra valiente", bromea C, "era un poco más audaz". Afortunadamente, sus habilidades de catapultar son mejores que sus chistes..'
global.personality[19] = "Para hacer su trabajo, v debe ser inteligente, astuto y capaz de planificar con anticipación. Ha ganado el torneo regional de ajedrez en los últimos 3 años seguidos."
global.personality[23] = "Como la abeja reina de OXTriangle, a Q le gusta estar al frente de la cola. Ella considera que sus q son, bueno, de clase baja."
global.personality[25] = "Como el mayor de los hermanos G, terra G cree que es el tipo más duro de la cuadra. No le digas esto a nadie, pero está aterrorizado por las arañas."
global.personality[28] = "Después de que L ganó el cross country de la escuela por tercer año consecutivo, todos pensaron que había hecho trampa. Lo que no sabían era cómo. Sueña un día con dirigir su propia franquicia de corredores."
global.personality[30] = '@ le encanta mantenerse en contacto con los otros personajes. Puede ser contactado por correo electrónico: "@@ oxtriangle.co.nz".'
global.personality[35] = "Su color favorito es el morado."


// Object Names
global.text_boulder = "Roca"
global.text_red_anger = "Ira roja"
global.text_bomb = "Bomba"
global.text_orange_anger = "Ira naranja"
global.text_barrier = "Barrera"
global.text_double_boxing = "Doble boxeo"
global.text_arrow = "Flecha"
global.text_blue_anger = "Ira azul"
global.text_diamond_bomb = "Bomba de diamante"
global.text_concrete = "Hormigón"
global.text_nuclear_bomb = "Bomba nuclear"
global.text_teleport = "Teletransporte"
global.text_purple_anger = "Ira púrpura"
global.text_concreate_bomb = "Bomba de hormigón"
global.text_nwh = "Cabeza explosiva nuclear"
global.text_time_bomb = "Bomba de tiempo"
global.text_mud = "Barro"
global.text_switch_gate = "Switch/Gate"

// Object Descriptions
global.description[100] = "Se cae siempre aunque sea amarillo. Aplasta a todos los personajes en su camino."
global.description[101] = "Cuando pasas por un enojo rojo, puedes matar a los personajes del oponente"
global.description[102] = "Cae como una roca, pero por cada cuadrado de color amarillo que cae puede atravesar una roca cuadrada"
global.description[103] = "Cuando pasas por una rabia anaranjada eres capaz de hacer un túnel de roca"
global.description[104] = "Estar escrito"
global.description[105] = "Estar escrito"
global.description[106] = "Un jugador puede ingresar la flecha desde 3 lados que no sea la cabeza. Solo puede salir de la cabeza."
global.description[107] = "Cuando pasas por un ángel azul, puedes hacer un túnel con un diamante"
global.description[108] = "Igual que la bomba, pero puede atravesar rocas y diamantes."
global.description[110] = "Igual que una roca pero detona como una M cuando golpea algo, p. roca, diamante, barrera."
global.description[111] = "Cuando pasas por un teletransporte, puedes salir del otro lado"
global.description[112] = "Cuando pasas por un enojo púrpura, puedes matar a los personajes del oponente, la roca del túnel y el diamante del túnel"
global.description[113] = "Igual que la bomba, pero puede atravesar rocas, diamantes y hormigón."
global.description[114] = "Puede ser controlado por cualquier jugador y destruye el área 7X7 cuando se activa (nivel 5)."
global.description[115] = "La bomba de tiempo detona un área de 7x7, incluso fuera del borde. 1 movimiento para partir. La bomba de tiempo hará una cuenta regresiva al final del jugador que la activó, vaya. Comienza a contar el cambio de primer jugador después de que la bomba estalle. Cuando el número alcanza -1, la bomba detona. Puede ser empujado como un audaz."
global.description[116] = "Cuando un personaje entra en el barro, se queda atrapado en el barro. Incluyendo G`s, U`s, bombas y flechas e.t.c. y no puede moverse hasta que se destruya el lodo, pero aún puede lanzar y disparar."
global.description[117] = "Una puerta puede abrirse mediante un interruptor que tiene el mismo número. Siempre se abre desde el lado sin bloques. 1 movimiento para abrir o cerrar, adyacente al interruptor. Dosis no matada o bloqueada por personajes al abrir. 2 puertas pueden tener cualquier longitud siempre que sean iguales"


// Object Special
global.special_arrow[0] = "Los cantos rodados siguen las mismas reglas."
global.special_concrete[0] = "No puede explotar."
global.special_concrete[1] = "Bloquea los caminos que se han volado, p. Ej. J, cabeza de guerra nuclear."
global.special_concrete[2] = "No se puede catapultar."
global.special_concrete[3] = "Puede ser descompuesto por G."
global.special_nuclear_bomb[0] = "Explota cuando golpea un G"
global.special_nuclear_bomb[1] = "Hace estallar cuando golpea una flecha hacia arriba"
global.special_nuclear_bomb[2] = "Cuando golpea una G, produce 2 golpes, 1 por el impacto y 1 por la explosión."
global.special_nwh[0] = "Para detonar, haga clic en el centro, luego haga clic donde desee detonar"
global.special_nwh[1] = "Para ascender un nivel, un personaje debe ocupar cada interruptor 1 ronda."
global.special_nwh[2] = "Si otro jugador lo captura, el número debe decretar a 0 antes de aumentar."
global.special_nwh[3] = "El centro indestructible de acero decreta 1 nivel por detonación."
global.special_mud[0] = "Cuando se destruye un cuadrado de lodo, cada cuadrado adyacente también explota: efecto de cadena."
global.special_mud[1] = "Todos ellos explotan."
global.special_switch_gate[0] = "Presione ALT para activar."
global.special_switch_gate[1] = "Las puertas no pueden ser destruidas por G`s."
global.special_gigga_port[0] = "Lo mismo que teletransportarse pero ocupa 4 cuadrados.."
global.special_gigga_port[1] = "Indestructible."
global.special_gigga_port[2] = "Puede mover G y Gigga G."
global.special_gigga_port[3] = "No se puede mover el terror G."
global.special_gigga_port[4] = "J explosión en el puerto hace 2 líneas en cada puerto Giga."
global.special_gigga_port[5] = "El puerto de Gigga siempre teletransporta explosiones J, rocas, bombas y flechas.."
global.special_gigga_port[6] = "M en puerto."
global.special_gigga_port[7] = "El puerto Gigga cuenta como 1 casilla, solo 1 bomba / roca puede caber en un puerto Gigga a la vez, ningún otro personaje encajará en este momento."
#define script_german
// script_german
// Stefan Grace
// Created: 2020-02-05
// Modified: 2020-02-05
// This script sets the language to Gernam

// General
global.text_index = "Index"
global.text_characters = "Zeichen"
global.text_objects = "Objekte"
global.text_exit = "Ausgang"
global.text_next_page = "Nächste Seite"
global.text_previous_page = "Vorherige Seite"
global.text_dark = "Oscuro"
global.text_light = "Licht"
global.text_kills = "Dunkel"
global.text_tunnels = "Tunnel"
global.text_weakness = "Die Schwäche"
global.text_toughness = "Zähigkeit" 
global.text_special = "Besondere"
global.text_weak = "Schwach"
global.text_medium = "Mittel"
global.text_high = "Hoch"
global.text_very_high = "Sehr hoch"
global.text_extremely_high = "Extrem hoch" 
global.text_triangle = "Dreieck"
global.text_square = "Platz"
global.text_big = "Groß"
global.text_purple = "Lila"
global.text_all = "Alle"
global.text_next_click = '(Klicken Sie auf die Schaltfläche "Nächste Seite", um fortzufahren)'
global.text_hit = "schlagen"
global.text_vs = "vs"
global.text_dies = "stirbt"

// Character Descriptions
global.description[0] = "Grund schwächster Charakter im Spiel."
global.description[1] = "Starker Kampfcharakter."
global.description[2] = "Stärkster Allround-Killing-Charakter."
global.description[3] = "Spezialisierter Tötungscharakter."
global.description[4] = "Wird für den Tunnelbau verwendet."
global.description[5] = "Wird zum Tunneln durch Diamanten verwendet."
global.description[6] = "Infiltriert Kartons mit 4 Stück."
global.description[7] = "Spezialisierter Tötungscharakter."
global.description[8] = "Betäubt Charter."
global.description[9] = "Hybrid Killer / Tuner."
global.description[10] = "Kann andere Charaktere schießen."
global.description[11] = "Sprengt die Umgebung."
global.description[12] = "Kann andere Urkunden verzaubern."
global.description[13] = "Riesiger, härtester Charakter im Spiel."
global.description[14] = "Hybrid-Katapult / Killer."
global.description[15] = "Schützt vor Pfeilen, Steinen und Bomben."
global.description[16] = "Einmaliger Gebrauch, betäubt alle Charaktere."
global.description[17] = "Heilt und heilt Betäubungen."
global.description[18] = "Sprengt eine Zeile und eine Spalte."
global.description[19] = "Stealthy Attentatscharakter."
global.description[20] = "Einmaliger Tötungscharakter."
global.description[21] = "Zwillingscharakter."
global.description[22] = "Macht Diamant."
global.description[23] = "Spawns q`s."
global.description[24] = "Katapulte Atombomben."
global.description[27] = "Stealther."
global.description[28] = "Führt alle verbleibenden Züge aus, um eine gelbe Linie zu bilden."
global.description[29] = "Wirkt einen AOE-Stun"
global.description[30] = "Teleportiert andere Charaktere."
global.description[31] = "Ist ein beweglicher Betonblock."
global.description[32] = "Hinterlässt eine Spur von Schlamm."
global.description[33] = "G / W-Hybrid." 
global.description[35] = "Kann unendlich viele Zeiten verändern"

// Character Special
global.special_b[0] = "Kann in eine Schachtel mit 4 Charakteren kommen und 1 Charakter der Wahl der Gegner entfernen."
global.special_s[0] = "Sutns"
global.special_s[1] = "für 1 Zug"
global.special_s[2] = "Charaktere können ihre Funktionen nicht nutzen, d. H. Wirken, wenn sie betäubt sind." 
global.special_r[0] = "Kann alle Charaktere mit Ausnahme von Y in einem Abstand von bis zu 5 Feldern abschießen."
global.special_r[1] = "Drücken Sie zum Aufnehmen STRG + PFEIL."
global.special_r[2] = "Zum Schießen ist 1 Bewegung erforderlich."
global.special_m[0] = "detoniert, um 9 benachbarte Felder in die Luft zu jagen (Einmalgebrauch)."
global.special_m[1] = "Drücke STRG, um zu detonieren."
global.special_m[2] = "1 Bewegung zur Detonation erforderlich."
global.special_f[0] = "Reize"
global.special_f[1] = "um sie zu deinem zu machen."
global.special_g[0] = "nimmt 4 Felder ein, kann alles durchstehen und verwandelt es in gelb. Benötigt 3 Treffer, um zu töten."
global.special_c[0] = "Katapulte Felsbrocken, 5 Quadrate entfernt, können über alles springen. Felsbrocken töten beim Aufprall. (nur horizontal)"
global.special_c[2] = "Drücken Sie STRG + PFEIL, um zu katapultieren."
global.special_c[3] = "Kann nicht in Doppelboxen schießen."
global.special_c[4] = "Kann nicht in eine Kiste mit einem G schießen"
global.special_y[0] = "Blockiert Pfeile, Felsbrocken und Bomben. Kann Steine und Bomben zerstören, indem du dich auf dem gleichen Feld wie sie bewegst. Wenn sie unter Felsbrocken stehen, gelangen sie nicht in diese Kiste."
global.special_z[0] = "Betäubt alle Zeichen außer WITH. Wenn der Feind kein W hat, ist er nicht draußen. Wenn sie ein W haben, müssen sie es bewegen. Wenn sie sich nicht dorthin bewegen können, sind sie draußen. (Einweg)" 
global.special_z[3] = "1 Bewegung zur Detonation erforderlich."
global.special_z[4] = "Friert feindliche Atomsprengköpfe ein."
global.special_z[5] = "Verhindert nicht, dass der Atomkrieg losgeht."
global.special_w[0] = "W heilt G`s von 5 Feldern oder Curs betäubt von 5 Feldern."
global.special_w[1] = "Drücken Sie STRG + PFEIL, um die Übertragung durchzuführen."
global.special_w[2] = "Benötigt 1 Zug zum Wirken."
global.special_w[3] = "Ist beständig gegen Betäubungen, einschließlich Z."
global.special_w[4] = "Muss gelb sein, um Betäubung zu heilen oder zu heilen."
global.special_w[5] = "Kann nicht heilen oder heilen, betäuben Sie eine Charta auf dem gleichen Feld wie sie."
global.special_j[0] = "Sprengt die Zeile und eine Spalte, in der sich das J befindet. (Einmaliger Gebrauch)"
global.special_v[0] = "Kann sich diagonal bewegen, um etwas zu töten, wird nicht selbst getötet, nur diagonale Bewegungen töten." 
global.special_v[1] = "Normalerweise wird es getötet. Kann nicht in Rock / Diamond eindringen. Wenn sich V diagonal nach G bewegt," 
global.special_v[2] = "G verliert 1 Treffer und V stirbt."
global.special_v[3] = "Verwenden Sie die Tasten Q E Z C, um sich diagonal zu bewegen."
global.special_p[0] = "Kann jeden Charakter töten, wird aber selbst getötet."
global.special_p[1] = "Nimmt 1 Treffer von einem G."
global.special_p[2] = "Zerstört alle Charaktere in einem Quadrat."
global.special_t[0] = "T funktioniert nur mit 2 oder mehr. Die Dosis wird nicht aufgebraucht, 1 Zug pro T wird gezündet. Die Dosis sprengt nicht das Feld, in dem sich das T befindet."
global.special_t[2] = "Es können mehrere T`s gleichzeitig blasen, wenn sich ein Quadrat bildet, dann wird auch die Mitte vollständig detoniert."
global.special_t[3] = "(6 Züge)"
global.special_t[4] = "Drücke STRG, um zu detonieren."
global.special_t[5] = "Durch Beton blockiert."
global.special_d[0] = "Hinterlässt eine Diamantprobe in einer Schachtel, wenn sie herauskommt. Verwandeln Sie die Schachtel, in der sie sich befindet, nicht in einen Diamanten."
global.special_d[1] = "Teleports und Angers können nicht in Diamanten verwandelt werden."
global.special_q[0] = "Spawns 4 Kleinbuchstaben q`s, 1 auf jeder Seite, die gelb ist. 4 Züge zum Laichen. Wenn 1 Seite nicht gelb ist, ist kein q vorhanden, aber es werden noch 4 Züge benötigt."
global.special_q[1] = "Drücke STRG, um zu spawnen"
global.special_q[2] = "In einem Giga-Port benötigt Q immer noch 4 Züge, erzeugt aber 8 Qs"
global.special_q[3] = "In Gigga Ports / Teleports wird Q auf beiden Seiten des Gigga Ports / Teleports für keine zusätzlichen Züge erscheinen." 
global.special_n[0] = "Wie C, feuert aber Atombomben ab. Sie explodieren nicht unbedingt beim Aufprall"
global.special_gigga_g[0] = "Gigga G nimmt 4 Felder ein."
global.special_gigga_g[1] = "Gigga G hat 5 Treffer."
global.special_gigga_g[2] = "Gigga G hat 5 Treffer."
global.special_gigga_g[3] = "Kleines G kann kleines G nicht angreifen."
global.special_gigga_g[4] = "Gigga G kann sein eigenes G zerstören, ohne Treffer zu verlieren"
global.special_gigga_g[5] = "Wenn 2 G kämpfen, stirbt der mit den wenigsten Treffern. Derjenige mit den meisten Treffern verliert die Anzahl der Treffer, die der andere G hat."
global.special_gigga_g[6] = "Das Feld, in dem sich der Gigga G befindet, zählt als 1 Feld, nicht als 4, daher schlagen Explosionen, die auf mehrere Felder wirken, in denen sich der G befindet, maximal 1 Treffer vom G ab."
global.special_question_mark[0] = "? Beginnt völlig nutzlos, kann aber mit einem Zug in einen beliebigen Charakter verwandelt werden, der 4 oder weniger Leerzeichen einnimmt (nicht Gigga G oder Terror G).."
global.special_question_mark[1] = "Drücken Sie zum Ändern die UMSCHALTTASTE."
global.special_question_mark[2] = "Irreversible Veränderung."
global.special_u[0] = 'Kann in den "Stealth" -Modus wechseln.'
global.special_u[1] = 'Benötigt 1 Zug, um in den "Stealth" -Modus zu wechseln.'
global.special_u[2] = '"Stealth" -Modus ermöglicht es ihm, durch Medium (sogar Stahl) zu gelangen, ohne gelb zu hinterlassen. Wenn es wieder gelb wird, verlässt es automatisch den "Stealth" -Modus.'
global.special_u[3] = 'Wenn es aus dem "Stealth" -Modus kommt, kann es jeden Charakter töten, ohne zu sterben, wie ein V.'
global.special_u[4] = 'Kann nicht diagonal reisen wie ein V.'
global.special_u[5] = 'Normalerweise stirbt U, wenn es einen anderen Charakter trifft.'
global.special_u[6] = 'Wenn es aus dem "Stealth" -Modus auf ein G wechselt, verliert G 1 Treffer und U stirbt.'
global.special_u[7] = '1 Bewegung, um die Schranke / das Tor zu besteigen.'
global.special_l[0] = "Wenn L eine Ebene erreicht, in der es eine gerade gelbe Linie gibt (vertikal oder horizontal). Es kann so weit reisen, wie es will, durch die Erinnerung an Bewegungen. (wie ein Zorn)."
global.special_dollar_sign[0] = "Muss auf einen Charakter gewirkt werden, nicht auf ein leeres Quadrat. Betäubt ein Gebiet von 5x5 gegnerischen Charakteren mit Ausnahme von W. 1 Runde lang betäubt."
global.special_dollar_sign[1] = "Drücke die Steuerungstaste und klicke dann auf den Charakter, den du betäuben möchtest."
global.special_dollar_sign[2] = "Mach 1 Zug, um zu betäuben."
global.special_pi[0] = "Pi ist ein Betonblock, der sich nur durch Gelb bewegen kann. Kann nicht in ein Feld mit einem anderen Zeichen kommen, kann Niter Zeichen. Kann nicht geschossen werden. Blockiert Explosionen. Pi kann sich in einen angrenzenden Betonblock bewegen und seinen eigenen Betonblock zurücklassen."
global.special_pi[1] = "Wenn Pi in den Schlamm eindringt, verschwindet das Pi-Symbol und hinterlässt Beton."
global.special_pi[2] = "Kann nicht ärgern oder teleportieren."
global.special_i[0] = "Es gelten die gleichen Regeln wie bei D."
global.special_i[1] = "Kann nicht durch Fels kommen."
global.special_big_w[0] = "Big W beginnt mit 0 Extraleben und kann maximal 4 haben."
global.special_big_w[1] = "Hat die gleichen Tötungsfähigkeiten wie ein G. verliert 1 Lebenspunkt, wenn er von einem X angegriffen wird. Es gelten die normalen G-Tötungsregeln, wenn Gs getötet werden."
global.special_big_w[2] = "Kann nicht durch Stein / Diamant usw. oder in eine Kiste mit eigenen Charakteren gelangen."
global.special_big_w[3] = "Kann einen Lebensentzug aus bis zu 5 Feldern Entfernung von G werfen. Dies überträgt 1 Treffer vom G auf das W, bis das W vollständig geheilt ist. Kann Treffer von Big W auf dein eigenes G übertragen, aber nicht auf die Gegner G."
global.special_big_w[4] = "W vs. W: W kann keine Treffer zwischen anderen Big Ws übertragen. Kann von kleinen W geheilt werden."
global.special_terra_g[0] = "Nimmt 16 Felder ein."
global.special_terra_g[1] = "Terra G hat 10 Treffer."
global.special_terra_g[2] = "Es gelten die normalen G-Regeln."
global.special_at[0] = "Kann mit jedem anderen Charakter auf dem Gitter den Platz wechseln."
global.special_at[1] = "Drücken Sie die Steuertaste und wählen Sie ein anderes Zeichen aus.."
global.special_at[2] = "Nimmt 2 Züge."
global.special_purple_question_mark[0] = "Drücke die Umschalttaste, um dich in einen beliebigen Charakter zu verwandeln. Bleibt lila. Kann unendlich oft geändert werden."

// Character Personalities
global.personality[0] = "O kämpft nicht gern. Sie hört am liebsten Musik, arbeitet im Garten und hängt mit ihrem engen Freundeskreis zusammen."
global.personality[1] = "X ist ein Frontkämpfer und Allround-Soldat. Erst letztes Jahr erhielt er ein Victoria-Kreuz für seine Bemühungen."
global.personality[11] = "Jeder kennt M wegen seiner kurzen Zündschnur und seines explosiven Temperaments. Trotzdem setzt er sein Leben für sein Team aufs Spiel."
global.personality[14] = '"Haben Sie von dem mutigen Stein gehört ", scherzt C," er war ein bisschen mutiger. "'
global.personality[19] = "Um seine Arbeit zu erledigen, muss v klug, gerissen und in der Lage sein, vorausschauend zu planen. Er hat in den letzten drei aufeinanderfolgenden Jahren das regionale Schachspiel gewonnen."
global.personality[23] = "Als Bienenkönigin von OXTriangle steht Q gerne an vorderster Front. Sie hält ihre Qs für eine niedrigere Klasse."
global.personality[25] = "Als ältester der G-Brüder glaubt terra G, er sei der härteste Typ auf dem Block. Erzählen Sie niemandem davon, aber er ist voller Spinnen."
global.personality[28] = "Nachdem L das dritte Jahr in Folge das Cross Country der Schule gewonnen hatte, dachten alle, er hätte geschummelt. Was sie nicht wussten, war wie. Eines Tages träumt er davon, sein eigenes Corrier-Franchise zu leiten."
global.personality[30] = '@ liebt es, mit den anderen Charakteren in Kontakt zu bleiben. Er kann per E-Mail kontaktiert werden: "@@oxtriangle.co.nz".'
global.personality[35] = "Seine Lieblingsfarbe ist lila."

// Object Names
global.text_boulder = "Felsbrocken"
global.text_red_anger = "Rote Wut"
global.text_bomb = "Bomb"
global.text_orange_anger = "Bombe"
global.text_barrier = "Barriere"
global.text_double_boxing = "Doppeltes Boxen"
global.text_arrow = "Pfeil"
global.text_blue_anger = "Blauer Zorn"
global.text_diamond_bomb = "Diamantbombe"
global.text_concrete = "Beton"
global.text_nuclear_bomb = "Atombombe"
global.text_teleport = "Teleportieren"
global.text_purple_anger = "Lila Wut"
global.text_concreate_bomb = "Konkrete Bombe"
global.text_nwh = "Nuklearer Sprengkopf"
global.text_time_bomb = "Zeitbombe"
global.text_mud = "Schlamm"
global.text_switch_gate = "Schalter / Tor"

// Object Descriptions
global.description[100] = "Fällt immer gelb runter. Zerquetscht alle Charaktere im Pfad."
global.description[101] = "Wenn du durch einen roten Zorn gehst, kannst du die Charaktere des Gegners töten"
global.description[102] = "Fällt wie ein Felsbrocken, aber für jedes gelbe Quadrat, durch das es fällt, kann es 1 Quadrat durch Felsen ziehen"
global.description[103] = "Wenn Sie durch eine orange Wut gehen, können Sie Tunnelrock"
global.description[104] = "GESCHRIEBEN WERDEN"
global.description[105] = "GESCHRIEBEN WERDEN"
global.description[106] = "Ein Spieler kann den Pfeil von 3 beliebigen Seiten eingeben, die nicht der Kopf sind. Kann nur aus dem Kopf austreten."
global.description[107] = "Wenn Sie durch einen blauen Engel gehen, können Sie Diamanten tunneln"
global.description[108] = "Wie Bombe, aber durch Stein und Diamant hindurch."
global.description[110] = "Wie ein Felsbrocken, aber detoniert wie ein M, wenn er auf etwas trifft, z. Stein, Diamant, Barriere."
global.description[111] = "Wenn Sie durch einen Teleporter gehen, können Sie die andere Seite herauskommen"
global.description[112] = "Durchlebst du einen violetten Zorn, kannst du die gegnerischen Charaktere, den Tunnelstein und den Tunneldiamanten töten"
global.description[113] = "Wie Bombe, kann aber durch Fels, Diamant und Beton gelangen."
global.description[114] = "Kann von jedem Spieler kontrolliert werden und zerstört bei Aktivierung 7X7-Gebiete (Level 5)."
global.description[115] = "Die Zeitbombe detoniert einen 7x7-Bereich, einschließlich des Randbereichs. 1 Bewegung zum Aufbruch. Die Zeitbombe zählt am Ende des Spielers ab, der sie ausgelöst hat. Startet den Countdown des ersten Spielerwechsels nach dem Abfeuern der Bombe. Wenn die Zahl -1 erreichen würde, detoniert die Bombe. Kann wie ein Kühner geschoben werden."
global.description[116] = "Wenn ein Charakter Schlamm betritt, bleibt er im Schlamm stecken. Einschließlich G`s, U`s, Bomben und Pfeile e.t.c. und kann nicht ausziehen, bis der Schlamm zerstört ist, kann aber trotzdem werfen und schießen."
global.description[117] = "Ein Tor kann durch einen Schalter mit derselben Nummer geöffnet werden. Öffnet immer von der Seite ohne Blöcke. 1 Bewegung zum Öffnen oder Schließen neben dem Schalter. Beim Öffnen nicht töten oder durch Zeichen blockieren. 2 Tore können beliebig lang sein, solange sie gleich sind"

// Object Special
global.special_arrow[0] = "Felsbrocken folgen den gleichen Regeln."
global.special_concrete[0] = "Kann nicht gesprengt werden."
global.special_concrete[1] = "Blockiert in die Luft gesprengte Pfade, z. J, Atomkriegskopf."
global.special_concrete[2] = "Kann nicht über katapultiert werden."
global.special_concrete[3] = "Kann von G. aufgeschlüsselt werden"
global.special_nuclear_bomb[0] = "Sprengt, wenn es ein G trifft"
global.special_nuclear_bomb[1] = "Sprengt, wenn es einen Aufwärtspfeil trifft"
global.special_nuclear_bomb[2] = "Wenn es ein G trifft, schlägt es 2 Treffer ab, 1 für den Aufprall und 1 für die Explosion."
global.special_nwh[0] = "Klicken Sie zur Detonation auf die Mitte und dann auf die Stelle, an der Sie die Detonation durchführen möchten"
global.special_nwh[1] = "Um ein Level zu rauben, muss ein Charakter 1 Runde lang jeden Schalter besetzen."
global.special_nwh[2] = "Wenn ein anderer Spieler es erobert, muss die Zahl vor dem Erhöhen auf 0 gesetzt werden."
global.special_nwh[3] = "Das unzerstörbare Stahlzentrum verfügt über 1 Stufe pro Detonation."
global.special_mud[0] = "Wenn ein Lehmquadrat zerstört wird, sprengt jedes benachbarte Quadrat auch den Ketteneffekt."
global.special_mud[1] = "Sie alle sprengen."
global.special_switch_gate[0] = "Drücken Sie zum Aktivieren ALT."
global.special_switch_gate[1] = "Tore können nicht von G`s zerstört werden."
global.special_gigga_port[0] = "Wie beim Teleportieren, nimmt jedoch 4 Felder ein."
global.special_gigga_port[1] = "Unzerstörbar."
global.special_gigga_port[2] = "Kann G und Gigga G bewegen."
global.special_gigga_port[3] = "Kann Terror G nicht bewegen."
global.special_gigga_port[4] = "J Explosion im Port führt 2 Leitungen an jedem Giga-Port aus."
global.special_gigga_port[5] = "Gigga Hafen teleportiert immer J Explosionen, Felsbrocken, Bomben und Pfeile."
global.special_gigga_port[6] = "M im Hafen."
global.special_gigga_port[7] = "Gigga-Port zählt als 1 Feld, nur 1 Bombe / Felsbrocken kann zu einem Zeitpunkt in einen Gigga-Port passen, kein anderer Charakter wird zu diesem Zeitpunkt hineinpassen."
#define script_start
// script_start
// Stefan Grace
// Created: 2017-06-11
// Modified: 2020-02-05
// This script is executed when the Alumax starts

script_execute(script_english)

if (file_exists(working_directory+"\Settings\Language.txt"))
{
    var file;
    file = file_text_open_read(working_directory+"\Settings\Language.txt")
    global.language = file_text_read_real(file)
    file_text_close(file)
    if (global.language==1) script_execute(script_french)
    if (global.language==2) script_execute(script_spanish)
    if (global.language==3) script_execute(script_german)
}

if (file_exists(working_directory+"\Alumax\Page.txt"))
{
    var file;
    var page_id;
    file = file_text_open_read(working_directory+"\Alumax\Page.txt")
    page_id = file_text_read_real(file)
    file_text_close(file)
    file = file_text_open_write(working_directory+"\Alumax\Page.txt")
    file_text_write_real(file,0)
    if (page_id>0) script_execute(script_go_to_page,page_id)
    file_text_close(file)
}

if (file_exists(working_directory+"\Settings\Dark.txt"))
{
    var file;
    file = file_text_open_read(working_directory + "\Settings\Dark.txt")
    global.dark = file_text_read_real(file)
    if (global.dark) 
    {
        draw_set_color(c_white)
        with (object_button_dark) instance_change(object_button_light,true)
    }
    file_text_close(file)
}


#define script_index_draw
// script_index_draw
// Stefan Grace
// Created: 2016-08-27
// Modified: 2019-03-19
// This script draws the text on the Alumax Index


// Dark Mode
if (global.dark)
{
    draw_rectangle_color(333,47,1027,271,0,0,0,0,0)
    draw_rectangle_color(400,287,964,353,0,0,0,0,0)
}


// OXTriangle Logo
draw_sprite(sprite_logo,0,333,47)


// Text
draw_set_halign(fa_center)
draw_set_valign(fa_center)
draw_set_font(font_index)
if (global.var_alumax_index==0) draw_text(680,320,"Alumax - "+global.text_index)
if (global.var_alumax_index==1) draw_text(680,320,"Alumax - "+global.text_characters)
if (global.var_alumax_index==2) draw_text(680,320,"Alumax - "+global.text_objects)
draw_set_valign(0)
draw_set_halign(0)
#define script_button_text
// script_button_text
// Stefan Grace
// Created: 2016-08-27
// Modifed: 2016-10-31
// This script draws the text on buttons and makes the text and buttons change color

/* 
argument0
    0 = Normal Button
    1 = Index Button
    2 = Item Button
    
argument1
    0 = font_index
    1 = font_small 
*/

var y_plus;

if (argument1==0) draw_set_font(font_index)
if (argument1==1) draw_set_font(font_small)
draw_set_halign(fa_center)
draw_set_valign(fa_center)

if(position_meeting(mouse_x,mouse_y,self))
{
    if mouse_button  
    {  
        if (argument0==0) draw_sprite(sprite_button_pressed,0,x,y)
        if (argument0==1) draw_sprite(sprite_button_index_pressed,0,x,y)
        if (argument0==2) draw_sprite(sprite_button_item_pressed,0,x,y)
        if (argument1==0) draw_text_color(x,y,button_name,c_blue,c_blue,c_blue,c_blue,100)
        if (argument1==1) draw_text_ext_color(x,y,button_name,button_spacing,button_length,c_blue,c_blue,c_blue,c_blue,100)
    }
    else
    {
        if (argument0==0) draw_sprite(sprite_button_hot,0,x,y)
        if (argument0==1) draw_sprite(sprite_button_index_hot,0,x,y)
        if (argument0==2) draw_sprite(sprite_button_item_hot,0,x,y)
        if (argument1==0) draw_text_color(x,y,button_name,c_blue,c_blue,c_blue,c_blue,100)
        if (argument1==1) draw_text_ext_color(x,y,button_name,button_spacing,button_length,c_blue,c_blue,c_blue,c_blue,100)
    }
}

else
{
    if (argument0==0) draw_sprite(sprite_button_normal,0,x,y)
    if (argument0==1) draw_sprite(sprite_button_index_normal,0,x,y)
    if (argument0==2) draw_sprite(sprite_button_item_normal,0,x,y)
    if (argument1==0) draw_text_color(x,y,button_name,c_black,c_black,c_black,c_black,100)
    if (argument1==1) draw_text_ext_color(x,y,button_name,button_spacing,button_length,c_black,c_black,c_black,c_black,100)
}

draw_set_valign(0)
draw_set_halign(0)
#define script_index
// script_index
// Stefan Grace
// Created: 2016-09-29
// Modified: 2016-09-29
// This script enters the index menu

game_restart()

#define script_characters
// script_characters
// Stefan Grace
// Created: 2016-09-29
// Modified: 2016-10-02
// This script enters the characters menu

global.var_alumax_index = 1
with(object_button_characters) instance_destroy()
with(object_button_objects) instance_destroy()
instance_create(175,700,object_button_index)
instance_create(280,420,object_button_o)
instance_create(350,420,object_button_x)
instance_create(420,420,object_button_triangle)
instance_create(490,420,object_button_a)
instance_create(560,420,object_button_square)
instance_create(630,420,object_button_k)
instance_create(700,420,object_button_b)
instance_create(770,420,object_button_e)
instance_create(840,420,object_button_s)
instance_create(910,420,object_button_h)
instance_create(980,420,object_button_r)
instance_create(1050,420,object_button_m)
instance_create(280,490,object_button_f)
instance_create(350,490,object_button_g)
instance_create(420,490,object_button_c)
instance_create(490,490,object_button_y)
instance_create(560,490,object_button_z)
instance_create(630,490,object_button_w)
instance_create(700,490,object_button_j)
instance_create(770,490,object_button_v)
instance_create(840,490,object_button_p)
instance_create(910,490,object_button_t)
instance_create(980,490,object_button_d)
instance_create(1050,490,object_button_q)
instance_create(280,560,object_button_n)
instance_create(350,560,object_button_gigga_g)
instance_create(420,560,object_button_question_mark)
instance_create(490,560,object_button_u)
instance_create(560,560,object_button_l)
instance_create(630,560,object_button_dollar_sign)
instance_create(700,560,object_button_at_sign)
instance_create(770,560,object_button_pi)
instance_create(840,560,object_button_i)
instance_create(910,560,object_button_big_w)
instance_create(980,560,object_button_terra_g)
instance_create(1050,560,object_button_purple_question_mark)
#define script_objects
// script_characters
// Stefan Grace
// Created: 2016-10-29
// Modified: 2016-10-31
// This script enters the objects menu

global.var_alumax_index = 2
with(object_button_characters) instance_destroy()
with(object_button_objects) instance_destroy()
instance_create(175,700,object_button_index)
instance_create(280,420,object_button_boulder)
instance_create(350,420,object_button_red_anger)
instance_create(420,420,object_button_bomb)
instance_create(490,420,object_button_orange_anger)
instance_create(560,420,object_button_barrier)
instance_create(630,420,object_button_double_boxing)
instance_create(700,420,object_button_arrow)
instance_create(770,420,object_button_blue_anger)
instance_create(840,420,object_button_diamond_bomb)
instance_create(910,420,object_button_concrete)
instance_create(980,420,object_button_nuclear_bomb)
instance_create(1050,420,object_button_teleport)
instance_create(280,490,object_button_purple_anger)
instance_create(350,490,object_button_concreate_bomb)
instance_create(420,490,object_button_nwh)
instance_create(490,490,object_button_time_bomb)
instance_create(560,490,object_button_mud)
instance_create(630,490,object_button_switch_gate)
instance_create(700,490,object_button_gigga_port)


/* UNUSED LINE OF CODE
instance_create(770,490,object_button_v)
instance_create(840,490,object_button_p)
instance_create(910,490,object_button_t)
instance_create(980,490,object_button_d)
instance_create(1050,490,object_button_q)
instance_create(280,560,object_button_n)
instance_create(350,560,object_button_gigga_g)
instance_create(420,560,object_button_question_mark)
instance_create(490,560,object_button_u)
instance_create(560,560,object_button_l)
instance_create(630,560,object_button_dollar_sign)
instance_create(700,560,object_button_at_sign)
instance_create(770,560,object_button_pi)
instance_create(840,560,object_button_i)
instance_create(910,560,object_button_big_w)
instance_create(980,560,object_button_terra_g)
instance_create(1050,560,object_button_purple_question_mark)
*/
#define script_go_to_page
// script_go_to_page
// Stefan Grace
// Created: 2016-09-30
// Modified: 2020-02-26
// This script takes you to the page about the character or object you have clicked on

/* Arguments

    Characters
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
        
    Objects
        100 - Boulder
        101 - Red Anger
        102 - Bomb
        103 - Orange Anger
        104 - Barrier
        105 - Double Boxing
        106 - Arrow
        107 - Blue Anger
        108 - Diamond Bomb
        109 - Concrete
        110 - Nuclear Bomb
        111 - Teleport
        112 - Purple Anger
        113 - Concreate Bomb
        114 - Nuclear War Head
        115 - Time Bomb
        116 - Mud
        117 - Switch/Gate
        118 - Gigga Port
*/


if (((argument0 == 29 || argument0 == 34 || argument0 == 35) xor !keyboard_check(vk_control)) 
|| (mouse_x >= x-(sprite_width/2) && mouse_y >= y-(sprite_height/2) && mouse_x < x+(sprite_width/2) && mouse_y < y+(sprite_height/2)))
{
    global.var_page = argument0
    room_goto(room_page)
}
#define script_page
// script_page
// Stefan Grace
// Created: 2016-09-30
// Modified: 2019-03-19
// This script does the maths behind drawing out the item pages

// Next Button
if (global.var_page==21 or global.var_page==25 or global.var_page==27 or global.var_page==118) instance_create(455,700,object_button_next_page)

// Dark Mode
if (global.dark)
{
    with (object_button_dark) instance_change(object_button_light,true)
}

// Character Name
array_characters[0] = "O"
array_characters[1] = "X"
array_characters[2] = global.text_triangle
array_characters[3] = "A"
array_characters[4] = global.text_square
array_characters[5] = "K"
array_characters[6] = "B"
array_characters[7] = "E"
array_characters[8] = "S"
array_characters[9] = "H"
array_characters[10] = "R"
array_characters[11] = "M"
array_characters[12] = "F"
array_characters[13] = "G"
array_characters[14] = "C"
array_characters[15] = "Y"
array_characters[16] = "Z"
array_characters[17] = "W"
array_characters[18] = "J"
array_characters[19] = "V"
array_characters[20] = "P"
array_characters[21] = "T"
array_characters[22] = "D"
array_characters[23] = "Q"
array_characters[24] = "N"
array_characters[25] = "Gigga G"
array_characters[26] = "?"
array_characters[27] = "U"
array_characters[28] = "L"
array_characters[29] = "$"
array_characters[30] = "@"
array_characters[31] = "Pi"
array_characters[32] = "I"
array_characters[33] = global.text_big+" W"
array_characters[34] = "Terra G" 
array_characters[35] = global.text_purple+" ?"

// Object Name
array_characters[100] = global.text_boulder
array_characters[101] = global.text_red_anger
array_characters[102] = global.text_bomb
array_characters[103] = global.text_orange_anger
array_characters[104] = global.text_barrier
array_characters[105] = global.text_double_boxing
array_characters[106] = global.text_arrow
array_characters[107] = global.text_blue_anger
array_characters[108] = global.text_diamond_bomb
array_characters[109] = global.text_concrete
array_characters[110] = global.text_nuclear_bomb
array_characters[111] = global.text_teleport
array_characters[112] = global.text_purple_anger
array_characters[113] = global.text_concreate_bomb
array_characters[114] = global.text_nwh
array_characters[115] = global.text_time_bomb
array_characters[116] = global.text_mud
array_characters[117] = global.text_switch_gate
array_characters[118] = "GiggaPort"

// Description
global.description[26] = "?????????????"

// Kills
array_kills[1] = "O,"+global.text_triangle+","+global.text_square+",K,B,E,R,M,G,C,Y,Z,W,J,V,P,T,D,Q,N,?,U,L,$,@,I"
array_kills[2] = "O,A,"+global.text_square+",K,B,E,H,R,M,G,C,Y,Z,W,J,V,P,T,D,Q,N,?,U,L,$,@,I"
array_kills[3] = "X,H,R,M,G,Y,Z,W,J,V,T,D,Q,N,?,U,L,$,I"
array_kills[7] = "O,"+global.text_square+",K,B,S,H,R,M,F,G,C,Y,Z,W,J,V,P,T,D,Q,N,?,U,L,$,@,I"
array_kills[9] = "X,S,F,G,V,U"
array_kills[14] = "O,"+global.text_square+",K,B,R,M,G,Y,Z,W,J,V,P,T,D,Q,N,?,U,L,$,@,I"

// Weakness
array_weakness[1] = "A,H"
array_weakness[2] = "X"
array_weakness[3] = global.text_triangle
array_weakness[7] = "X,"+global.text_triangle
array_weakness[8] = "H,E,F"
array_weakness[9] = global.text_triangle+",E,A"
array_weakness[12] = "H,E"
array_weakness[13] = "R"
array_weakness[31] = "G"

// Toughness
array_toughness[0] = global.text_weak
array_toughness[1] = global.text_high
array_toughness[2] = global.text_very_high
array_toughness[3] = global.text_very_high
array_toughness[4] = global.text_weak
array_toughness[5] = global.text_weak
array_toughness[6] = global.text_weak
array_toughness[7] = global.text_high
array_toughness[8] = global.text_high
array_toughness[9] = global.text_medium
array_toughness[10] = global.text_weak
array_toughness[11] = global.text_weak
array_toughness[12] = global.text_high
array_toughness[13] = global.text_extremely_high+" (x3)"
array_toughness[14] = global.text_medium
array_toughness[15] = global.text_weak
array_toughness[16] = global.text_weak
array_toughness[17] = global.text_weak
array_toughness[18] = global.text_weak 
array_toughness[19] = global.text_weak
array_toughness[20] = global.text_weak
array_toughness[21] = global.text_weak
array_toughness[22] = global.text_weak
array_toughness[23] = global.text_weak
array_toughness[24] = global.text_weak
array_toughness[26] = global.text_weak
array_toughness[27] = global.text_weak
array_toughness[28] = global.text_weak
array_toughness[29] = global.text_weak
array_toughness[30] = global.text_weak
array_toughness[31] = global.text_very_high
array_toughness[32] = global.text_weak
array_toughness[35] = global.text_weak

// Special
array_special[6] = global.special_b[0]
array_special[8] = global.special_s[0]+" (O,X,"+global.text_triangle+",A,"+global.text_square+",K,B,R,M,G,C,Y,Z,J,V,P,T,D,Q,N,?,U,L,$,@,I) "+global.special_s[1]+"# #"+global.special_s[2]
array_special[10] = global.special_r[0]+"# #* "+global.special_r[1]+"# #* "+global.special_r[2]
array_special[12] = global.special_f[0]+" (O,X,"+global.text_triangle+",A,"+global.text_square+",K,B,S,R,M,C,Y,Z,W,J,V,P,T,D,Q,N,?,U,L,$,@,I)#"+global.special_f[1]
array_special[15] = global.special_y[0]
array_special[16] = global.special_z[0]+"# #* "+global.special_m[1]+"# #* "+global.special_z[3]+"# #* "+global.special_z[4]+"# #* "+global.special_z[5]
array_special[17] = global.special_w[0]+"# #* "+global.special_w[1]+"# #* "+global.special_w[2]+"# #* "+global.special_w[3]+"# #* "+global.special_w[4]+"# #* "+global.special_w[5]
array_special[20] = global.special_p[0]+"# #* "+global.special_p[1]+"# #* "+global.special_p[2]
array_special[22] = global.special_d[0]+"# #* "+global.special_d[1]
array_special[24] = global.special_n[0]
array_special[26] = global.special_question_mark[0]+"# #* "+global.special_question_mark[1]+"# #* "+global.special_question_mark[2]
array_special[29] = global.special_dollar_sign[0]+"# #* "+global.special_dollar_sign[1]+"# #* "+global.special_dollar_sign[2]
array_special[30] = global.special_at[0]+"# #* "+global.special_at[1]+"# #* "+global.special_at[2]
array_special[35] = global.special_purple_question_mark[0]




#define script_page_draw
// script_page_draw
// Stefan Grace
// Created: 2016-09-30
// Modified: 2020-02-26
// This scrips draws out the items pages

// Dark Mode
if (global.dark)
{
    draw_rectangle_color(122,58,1242,150,0,0,0,0,0)
    draw_rectangle_color(122,167,1242,660,0,0,0,0,0)
}

// Heading
draw_set_valign(fa_center)
draw_set_font(font_heading)
draw_text(140,105,array_characters[global.var_page])
draw_set_valign(0)

// Page
draw_set_font(font_text)

// O
if (global.var_page==0) draw_text_ext(140,175,global.description[global.var_page]+"# #"+global.text_toughness+": "+array_toughness[global.var_page],line_spacing,line_length)

// X
if (global.var_page==1) 
{
    draw_text_ext(140,175,global.description[global.var_page]+"# #"+global.text_kills+": "+array_kills[global.var_page]+"# #"+global.text_tunnels+":",line_spacing,line_length)
    draw_sprite(sprite_rock,0,140,315)
    draw_text_ext(140,385,global.text_weakness+": "+array_weakness[global.var_page]+"# #"+global.text_toughness+": "+array_toughness[global.var_page],line_spacing,line_length)
}

// Triangle, A
if (global.var_page==2 or global.var_page==3) draw_text_ext(140,175,global.description[global.var_page]+"# #"+global.text_kills+": "+array_kills[global.var_page]+"# #"+global.text_weakness+": "+array_weakness[global.var_page]+"# #"+global.text_toughness+": "+array_toughness[global.var_page],line_spacing,line_length)

// Square
if (global.var_page==4)
{
    draw_text_ext(140,175,global.description[global.var_page]+"# #"+global.text_tunnels+":",line_spacing,line_length)
    draw_sprite(sprite_rock,0,140,260)
    draw_text_ext(140,315,global.text_toughness+": "+array_toughness[global.var_page],line_spacing,line_length)
}

// K
if (global.var_page==5)
{
    draw_text_ext(140,175,global.description[global.var_page]+"# #"+global.text_tunnels+":",line_spacing,line_length)
    draw_sprite(sprite_diamond,0,140,260)
    draw_text_ext(140,315,global.text_toughness+": "+array_toughness[global.var_page],line_spacing,line_length)
}

// B, D
if (global.var_page==6 or global.var_page==22)
{
    draw_text_ext(140,175,global.description[global.var_page]+"# #"+global.text_tunnels+":",line_spacing,line_length)
    draw_sprite(sprite_rock,0,140,260)
    draw_sprite(sprite_diamond,0,175,260)
    draw_text_ext(140,315,global.text_toughness+": "+array_toughness[global.var_page]+"# #"+global.text_special+": "+array_special[global.var_page],line_spacing,line_length)        
}

// E
if (global.var_page==7)
{
    draw_text_ext(140,175,global.description[global.var_page]+"# #"+global.text_kills+": "+array_kills[global.var_page]+"# #"+global.text_tunnels+":",line_spacing,line_length)
    draw_sprite(sprite_rock,0,140,315)
    draw_sprite(sprite_diamond,0,175,315)
    draw_sprite(sprite_arrow_down,-1,140,315)
    draw_sprite(sprite_arrow_down,-1,175,315)
    draw_text_ext(140,375,global.text_weakness+": "+array_weakness[global.var_page]+"# #"+global.text_toughness+": "+array_toughness[global.var_page],line_spacing,line_length)
}

// S, F
if (global.var_page==8 or global.var_page==12) draw_text_ext(140,175,global.description[global.var_page]+"# #"+global.text_weakness+": "+array_weakness[global.var_page]+"# #"+global.text_toughness+": "+array_toughness[global.var_page]+"# #"+global.text_special+": "+array_special[global.var_page],line_spacing,line_length)

// H
if (global.var_page==9)
{
    draw_text_ext(140,175,global.description[global.var_page]+"# #"+global.text_kills+": "+array_kills[global.var_page]+"# #"+global.text_tunnels+":",line_spacing,line_length)
    draw_sprite(sprite_rock,0,140,315)
    draw_sprite(sprite_diamond,0,175,315)
    draw_sprite(sprite_arrow_horizontal,-1,140,315)
    draw_sprite(sprite_arrow_horizontal,-1,175,315)
    draw_text_ext(140,375,global.text_weakness+": "+array_weakness[global.var_page]+"# #"+global.text_toughness+": "+array_toughness[global.var_page],line_spacing,line_length)
}

// R, Y, Z, W, P, N, ?, $, @, Purple ?
if (global.var_page==10 or global.var_page==15 or global.var_page==16 or global.var_page==17 or global.var_page==20 or global.var_page==24 or global.var_page==26 or global.var_page==29 or global.var_page==30 or global.var_page==35)
{
    draw_text_ext(140,175,global.description[global.var_page]+"# #"+global.text_toughness+": "+array_toughness[global.var_page]+"# #"+global.text_special+": "+array_special[global.var_page],line_spacing,line_length)
}

// M
if (global.var_page==11)
{
    draw_text_ext(140,175,global.description[global.var_page]+"# #"+global.text_toughness+": "+array_toughness[global.var_page]+"# #"+global.text_special+": "+global.special_m[0],line_spacing,line_length)
    draw_sprite(sprite_yellow,0,140,315)
    draw_sprite(sprite_yellow,0,175,315)
    draw_sprite(sprite_yellow,0,210,315)
    draw_sprite(sprite_yellow,0,140,350)
    draw_sprite(sprite_yellow,0,175,350)
    draw_sprite(sprite_yellow,0,210,350)
    draw_sprite(sprite_yellow,0,140,385)
    draw_sprite(sprite_yellow,0,175,385)
    draw_sprite(sprite_yellow,0,210,385)
    draw_set_font(font_character)
    draw_text_color(177,350,"M",0,0,0,0,1)
    draw_set_font(font_text)
    draw_text_ext(140,440,"* "+global.special_m[1]+"# #* "+global.special_m[2],line_spacing,line_length)
}

// G
if (global.var_page==13)
{
    draw_text_ext(140,175,global.description[global.var_page]+"# #"+global.text_kills+": "+global.text_all+"# #"+global.text_weakness+": "+array_weakness[global.var_page]+"# #"+global.text_toughness+": "+array_toughness[global.var_page]+"# #"+global.text_special+": "+global.special_g[0],line_spacing,line_length)
    if (global.dark) draw_sprite(sprite_diagram_g_dark,0,140,455) else draw_sprite(sprite_diagram_g,0,140,455)
}

// C
if (global.var_page==14) draw_text(140,175,global.description[global.var_page]+"# #"+global.text_kills+": "+array_kills[global.var_page]+"# #"+global.text_toughness+": "+array_toughness[global.var_page]+"# #"+global.text_special+": "+global.special_c[0]+"# #* "+global.special_c[2]+"# #* "+global.special_c[3]+"# #* "+global.special_c[4])

// J
if (global.var_page==18)
{
    // Text
    draw_text_ext(140,175,global.description[global.var_page]+"# #"+global.text_toughness+": "+array_toughness[global.var_page]+"# #"+global.text_special+": "+global.special_j[0],line_spacing,line_length)
    // Line 0
    draw_sprite(sprite_rock,0,140,315)
    draw_sprite(sprite_rock,0,175,315)
    draw_sprite(sprite_yellow,0,210,315)
    draw_sprite(sprite_rock,0,245,315)
    draw_sprite(sprite_rock,0,280,315)
    // Line 1
    draw_sprite(sprite_rock,0,140,350)
    draw_sprite(sprite_rock,0,175,350)
    draw_sprite(sprite_yellow,0,210,350)
    draw_sprite(sprite_rock,0,245,350)
    draw_sprite(sprite_rock,0,280,350)
    // Line 2
    draw_sprite(sprite_yellow,0,140,385)
    draw_sprite(sprite_yellow,0,175,385)
    draw_sprite(sprite_yellow,0,210,385)
    draw_sprite(sprite_yellow,0,245,385)
    draw_sprite(sprite_yellow,0,280,385)
    // Line 3
    draw_sprite(sprite_rock,0,140,420)
    draw_sprite(sprite_rock,0,175,420)
    draw_sprite(sprite_yellow,0,210,420)
    draw_sprite(sprite_rock,0,245,420)
    draw_sprite(sprite_rock,0,280,420)
    // Line 3
    draw_sprite(sprite_rock,0,140,455)
    draw_sprite(sprite_rock,0,175,455)
    draw_sprite(sprite_yellow,0,210,455)
    draw_sprite(sprite_rock,0,245,455)
    draw_sprite(sprite_rock,0,280,455)
    // Character
    draw_set_font(font_character)
    draw_text_color(212,385,"J",0,0,0,0,1)
    draw_set_font(font_text)
    // Text
    draw_text_ext(140,500,"* "+global.special_m[1]+"# #* "+global.special_m[2],line_spacing,line_length)
}

// V
if (global.var_page==19) draw_text_ext(140,175,global.description[global.var_page]+"# #"+global.text_kills+": "+global.text_all+"# #"+global.text_toughness+": "+array_toughness[global.var_page]+"# #"+global.text_special+": "+global.special_v[0]+"#"+global.special_v[1]+"#"+global.special_v[2]+"# #* "+global.special_v[3],line_spacing,line_length)

// T
if (global.var_page==21)
{
    if (global.var_page_num==0)
        {
            draw_text_ext(140,175,global.description[global.var_page]+"# #"+global.text_toughness+": "+array_toughness[global.var_page]+"# #"+global.text_special+": "+global.special_t[0],line_spacing,line_length)
            draw_sprite(sprite_rock,0,140,350)
            draw_sprite(sprite_yellow,0,175,350)
            draw_sprite(sprite_yellow,0,210,350)
            draw_sprite(sprite_yellow,0,245,350)
            draw_sprite(sprite_yellow,0,280,350)
            draw_sprite(sprite_yellow,0,315,350)
            draw_sprite(sprite_rock,0,350,350)
            draw_set_font(font_character)
            draw_text_color(140,350,"T",0,0,0,0,1)
            draw_text_color(350,350,"T",0,0,0,0,1)
            draw_set_font(font_text)
            draw_text_ext(140,420,global.special_t[2],line_spacing,line_length)
            draw_text(140,595,global.text_next_click)
        }
    if (global.var_page_num==1)
    {
        // Line 0
        draw_sprite(sprite_rock,0,140,175)
        draw_sprite(sprite_yellow,0,175,175)
        draw_sprite(sprite_yellow,0,210,175)
        draw_sprite(sprite_yellow,0,245,175)
        draw_sprite(sprite_yellow,0,280,175)
        draw_sprite(sprite_yellow,0,315,175)
        draw_sprite(sprite_yellow,0,350,175)
        draw_sprite(sprite_rock,0,385,175)
        // Line 1
        draw_sprite(sprite_yellow,0,140,210)
        draw_sprite(sprite_yellow,0,175,210)
        draw_sprite(sprite_yellow,0,210,210)
        draw_sprite(sprite_yellow,0,245,210)
        draw_sprite(sprite_yellow,0,280,210)
        draw_sprite(sprite_yellow,0,315,210)
        draw_sprite(sprite_yellow,0,350,210)
        draw_sprite(sprite_yellow,0,385,210)
        // Line 2
        draw_sprite(sprite_yellow,0,140,245)
        draw_sprite(sprite_yellow,0,175,245)
        draw_sprite(sprite_yellow,0,210,245)
        draw_sprite(sprite_yellow,0,245,245)
        draw_sprite(sprite_yellow,0,280,245)
        draw_sprite(sprite_yellow,0,315,245)
        draw_sprite(sprite_yellow,0,350,245)
        draw_sprite(sprite_yellow,0,385,245)
        // Line 3
        draw_sprite(sprite_yellow,0,140,280)
        draw_sprite(sprite_yellow,0,175,280)
        draw_sprite(sprite_yellow,0,210,280)
        draw_sprite(sprite_yellow,0,245,280)
        draw_sprite(sprite_yellow,0,280,280)
        draw_sprite(sprite_yellow,0,315,280)
        draw_sprite(sprite_yellow,0,350,280)
        draw_sprite(sprite_yellow,0,385,280)
        // Line 4
        draw_sprite(sprite_yellow,0,140,315)
        draw_sprite(sprite_yellow,0,175,315)
        draw_sprite(sprite_yellow,0,210,315)
        draw_sprite(sprite_yellow,0,245,315)
        draw_sprite(sprite_yellow,0,280,315)
        draw_sprite(sprite_yellow,0,315,315)
        draw_sprite(sprite_yellow,0,350,315)
        draw_sprite(sprite_yellow,0,385,315)
        // Line 5
        draw_sprite(sprite_rock,0,140,350)
        draw_sprite(sprite_yellow,0,175,350)
        draw_sprite(sprite_yellow,0,210,350)
        draw_sprite(sprite_yellow,0,245,350)
        draw_sprite(sprite_rock,0,280,350)
        draw_sprite(sprite_yellow,0,315,350)
        draw_sprite(sprite_yellow,0,350,350)
        draw_sprite(sprite_yellow,0,385,350)
        // Line 6
        draw_sprite(sprite_rock,0,140,385)
        draw_sprite(sprite_rock,0,175,385)
        draw_sprite(sprite_rock,0,210,385)
        draw_sprite(sprite_rock,0,245,385)
        draw_sprite(sprite_yellow,0,280,385)
        draw_sprite(sprite_yellow,0,315,385)
        draw_sprite(sprite_yellow,0,350,385)
        draw_sprite(sprite_yellow,0,385,385)
        // Line 7
        draw_sprite(sprite_rock,0,140,420)
        draw_sprite(sprite_rock,0,175,420)
        draw_sprite(sprite_rock,0,210,420)
        draw_sprite(sprite_rock,0,245,420)
        draw_sprite(sprite_yellow,0,280,420)
        draw_sprite(sprite_yellow,0,315,420)
        draw_sprite(sprite_yellow,0,350,420)
        draw_sprite(sprite_yellow,0,385,420)
        // Line 8
        draw_sprite(sprite_rock,0,140,455)
        draw_sprite(sprite_rock,0,175,455)
        draw_sprite(sprite_rock,0,210,455)
        draw_sprite(sprite_rock,0,245,455)
        draw_sprite(sprite_rock,0,280,455)
        draw_sprite(sprite_yellow,0,315,455)
        draw_sprite(sprite_yellow,0,350,455)
        draw_sprite(sprite_rock,0,385,455)
        // Characters
        draw_set_font(font_character)
        draw_text_color(142,175,"T",0,0,0,0,1)
        draw_text_color(387,175,"T",0,0,0,0,1)
        draw_text_color(142,350,"T",0,0,0,0,1)
        draw_text_color(282,455,"T",0,0,0,0,1)
        draw_text_color(387,455,"T",0,0,0,0,1)
        draw_text_color(283,350,"T",0,0,0,0,1)
        draw_set_font(font_text)
        // Text
        draw_text_ext(142,490,global.special_t[3]+"# #* "+global.special_t[4]+"# #* "+global.special_t[5],line_spacing,line_length)
    }
}

// Q
if (global.var_page==23)
{
    draw_text_ext(140,175,global.description[global.var_page]+"# #"+global.text_toughness+": "+array_toughness[global.var_page]+"# #"+global.text_special+": "+global.special_q[0],line_spacing,line_length)
    draw_sprite(sprite_rock,0,140,350)
    draw_sprite(sprite_yellow,0,175,350)
    draw_sprite(sprite_rock,0,210,350)
    draw_sprite(sprite_yellow,0,140,385)
    draw_sprite(sprite_yellow,0,175,385)
    draw_sprite(sprite_yellow,0,210,385)
    draw_sprite(sprite_rock,0,140,420)
    draw_sprite(sprite_yellow,0,175,420)
    draw_sprite(sprite_rock,0,210,420)
    draw_set_font(font_character)
    draw_text_color(177,385,"Q",0,0,0,0,1)
    draw_text_color(177,350,"q",0,0,0,0,1)
    draw_text_color(142,385,"q",0,0,0,0,1)
    draw_text_color(212,385,"q",0,0,0,0,1)
    draw_text_color(177,420,"q",0,0,0,0,1)
    draw_set_font(font_text)
    draw_text_ext(140,465,"* "+global.special_q[1]+"# #* "+global.special_q[2]+"# #* "+global.special_q[3],line_spacing,line_length)
}

// Gigga G
if (global.var_page==25)
{
    if (global.var_page_num==0)
    {
        draw_text_ext(140,175,"* "+global.special_gigga_g[0],line_spacing,line_length)
        draw_sprite(sprite_yellow,0,140,210)
        draw_sprite(sprite_yellow,0,175,210)
        draw_sprite(sprite_yellow,0,140,245)
        draw_sprite(sprite_yellow,0,175,245)
        draw_sprite(sprite_gigga_g,0,140,210)
        draw_text_ext(140,315,"* "+global.special_gigga_g[1]+"# #* "+global.special_gigga_g[2],line_spacing,line_length)
        draw_sprite(sprite_yellow,0,140,400)
        draw_sprite(sprite_yellow,0,175,400)
        draw_sprite(sprite_yellow,0,140,435)
        draw_sprite(sprite_yellow,0,175,435)
        draw_text_ext(140,505,"* "+global.special_gigga_g[3]+"# #* "+global.special_gigga_g[4]+"# #"+global.text_next_click,line_spacing,line_length)
    }
    if (global.var_page_num==1)
    {
       draw_text_ext(140,175,"* "+global.special_gigga_g[5],line_spacing,line_length)
       if (global.dark) draw_sprite(sprite_diagram_gigga_g_dark,0,140,235) else draw_sprite(sprite_diagram_gigga_g,0,140,235)
       draw_set_halign(fa_center)
       draw_text(184,308,"(2 "+global.text_hit+")")
       draw_text(275,308,"(3 "+global.text_hit+")")
       draw_text(236,273,global.text_vs)
       draw_text(179,400,global.text_dies)
       draw_set_halign(0)
       draw_text_ext(140,488,"* "+global.special_gigga_g[6],line_spacing,line_length)
    }
}

// U
if (global.var_page==27)
{
    if (global.var_page_num==0) draw_text_ext(140,175,global.description[global.var_page]+"# #"+global.text_toughness+": "+array_toughness[global.var_page]+"# #"+global.text_special+": "+global.special_u[0]+"# #* "+global.special_u[1]+"# #* "+global.special_u[2]+"# #* "+global.special_u[3]+"# #* "+global.special_u[4]+"# # #"+global.text_next_click,line_spacing,line_length)
    if (global.var_page_num==1) draw_text_ext(140,175,"* "+global.special_u[5]+"# #* "+global.special_u[6]+"# #* "+global.special_u[7],line_spacing,line_length)
}

// L
if (global.var_page==28)
{
    draw_text_ext(140,175,global.description[global.var_page]+"# #"+global.text_tunnels+":",line_spacing,line_length)
    draw_sprite(sprite_rock,0,140,260)
    draw_text_ext(140,315,global.text_toughness+": "+array_toughness[global.var_page]+"# #"+global.text_special+": "+global.special_l[0],line_spacing,768)
    // Line 0
    draw_sprite(sprite_rock,0,1085,315)
    draw_sprite(sprite_yellow,0,1120,315)
    draw_sprite(sprite_yellow,0,1155,315)
    // Line 1
    draw_sprite(sprite_rock,0,1085,350)
    draw_sprite(sprite_yellow,0,1120,350)
    draw_sprite(sprite_rock,0,1155,350)
    // Line 2
    draw_sprite(sprite_rock,0,1085,385)
    draw_sprite(sprite_yellow,0,1120,385)
    draw_sprite(sprite_rock,0,1155,385)
    // Line 3
    draw_sprite(sprite_yellow,0,1085,420)
    draw_sprite(sprite_yellow,0,1120,420)
    draw_sprite(sprite_rock,0,1155,420)
    // line 4
    draw_sprite(sprite_rock,0,1085,455)
    draw_sprite(sprite_yellow,0,1120,455)
    draw_sprite(sprite_rock,0,1155,455)
    // Line 5
    draw_sprite(sprite_rock,0,1085,490)
    draw_sprite(sprite_yellow,0,1120,490)
    draw_sprite(sprite_rock,0,1155,490)
    // Line 6
    draw_sprite(sprite_rock,0,1085,525)
    draw_sprite(sprite_yellow,0,1120,525)
    draw_sprite(sprite_rock,0,1155,525)
    // Line 7
    draw_sprite(sprite_rock,0,1085,560)
    draw_sprite(sprite_yellow,0,1120,560)
    draw_sprite(sprite_rock,0,1155,560)
    // Line 8
    draw_sprite(sprite_yellow,0,1085,595)
    draw_sprite(sprite_yellow,0,1120,595)
    draw_sprite(sprite_rock,0,1155,595)
    // Character
    draw_set_font(font_character)
    draw_text_color(1122,595,"L",0,0,0,0,1)
    draw_set_font(font_text)
    // Arrow
    draw_sprite(sprite_diagram_l,0,1120,315)
}

// Pi
if (global.var_page==31)
{
    draw_text_ext(140,175,global.description[global.var_page],line_spacing,line_length)
    draw_sprite(sprite_concreet,0,140,225)
    draw_sprite(sprite_pi,0,157,242)
    draw_text_ext(140,295,global.text_special+": "+global.special_pi[0]+"# #* "+global.special_pi[1],line_spacing,line_length)
}

// I
if (global.var_page==32) 
{
    draw_text_ext(140,175,global.description[global.var_page]+"# #"+global.text_tunnels+":",line_spacing,line_length)
    draw_sprite(sprite_mud,0,140,260)
    draw_text_ext(140,330,"* "+global.special_i[0]+"# #* "+global.special_i[1],line_spacing,line_length)
}

// Big W
if (global.var_page==33)
{
    draw_text_ext(140,175,global.description[global.var_page],line_spacing,line_length)
    draw_sprite(sprite_big_w,0,140,225)
    draw_text_ext(140,295,"* "+global.special_big_w[0]+"# #* "+global.special_big_w[1]+"# #* "+global.special_big_w[2]+"# #* "+global.special_big_w[3]+"# #* "+global.special_big_w[4],line_spacing,line_length)

}

// Terra G
if (global.var_page==34)
{
    draw_text_ext(140,175,"* "+global.special_terra_g[0],line_spacing,line_length)
    draw_sprite(sprite_yellow,0,140,225)
    draw_sprite(sprite_yellow,0,175,225)
    draw_sprite(sprite_yellow,0,210,225)
    draw_sprite(sprite_yellow,0,245,225)
    draw_sprite(sprite_yellow,0,140,260)
    draw_sprite(sprite_yellow,0,175,260)
    draw_sprite(sprite_yellow,0,210,260)
    draw_sprite(sprite_yellow,0,245,260)
    draw_sprite(sprite_yellow,0,140,295)
    draw_sprite(sprite_yellow,0,175,295)
    draw_sprite(sprite_yellow,0,210,295)
    draw_sprite(sprite_yellow,0,245,295)
    draw_sprite(sprite_yellow,0,140,330)
    draw_sprite(sprite_yellow,0,175,330)
    draw_sprite(sprite_yellow,0,210,330)
    draw_sprite(sprite_yellow,0,245,330)
    draw_sprite(sprite_yellow,0,140,225)
    draw_sprite(sprite_terra_g,0,140,225)
    draw_text_ext(140,400,"* "+global.special_terra_g[1]+"# #* "+global.special_terra_g[2],line_spacing,line_length)
}

// Boulder, Red Anger, Bomb, Orange Anger, Barrier, Double Boxing, Blue Anger, Diamond Bomb, Teleport, Purple Anger, Concreate Bomb, Time Bomb
if (global.var_page==100 or global.var_page==101 or global.var_page==102 or global.var_page==103 or global.var_page==104 or global.var_page==105 or global.var_page==107 or global.var_page==108 or global.var_page==111 or global.var_page==112 or global.var_page==113 or global.var_page==115)
{
    if (global.var_page!=104) draw_sprite(sprite_yellow,0,140,175)
    if (global.var_page==100) draw_sprite(sprite_boulder,0,140,175)
    if (global.var_page==101) draw_sprite(sprite_red_anger,-1,140,175)
    if (global.var_page==102) draw_sprite(sprite_bomb,0,140,175)
    if (global.var_page==103) draw_sprite(sprite_orange_anger,-1,140,175)
    if (global.var_page==107) draw_sprite(sprite_blue_anger,-1,140,175)
    if (global.var_page==111) draw_sprite(sprite_teleport,-1,140,175)
    if (global.var_page==107) draw_sprite(sprite_blue_anger,-1,140,175)
    if (global.var_page==112) draw_sprite(sprite_purple_anger,-1,140,175)
    if (global.var_page==113) draw_sprite(sprite_concreate_bomb,0,140,175)
    if (global.var_page==115) draw_sprite(sprite_time_bomb,0,140,175)
    if (global.var_page==104)
    { 
        draw_sprite(sprite_barrier_horizontal,0,140,175)
        draw_sprite(sprite_barrier_vertical,0,210,175)
    }
    if (global.var_page==105)
    {
        draw_sprite(sprite_double_boxing_rock,0,140,175)
        draw_sprite(sprite_double_boxing_rock,0,158,175)
        draw_sprite(sprite_double_boxing_rock,0,140,193)
        draw_sprite(sprite_double_boxing_rock,0,158,193)
    }
    draw_text_ext(140,245,global.description[global.var_page],line_spacing,line_length)
}
    
// Arrow
if (global.var_page==106)
{
    draw_text_ext(140,175,global.description[global.var_page],line_spacing,line_length)
    draw_sprite(sprite_arrow_right,-1,140,215)
    draw_text_ext(140,260,"* "+global.special_arrow[0],line_spacing,line_length)
}

// Concrete
if (global.var_page==109)
{
    draw_text_ext(140,175,"* "+global.special_concrete[0]+"# #* "+global.special_concrete[1],line_spacing,line_length)
    draw_text_ext(140,425,"* "+global.special_concrete[2]+"# #* "+global.special_concrete[3],line_spacing,line_length)
    
    // Line 0 
    draw_sprite(sprite_rock,0,140,285)
    draw_sprite(sprite_concreet,0,175,285)
    draw_sprite(sprite_rock,0,210,285)
    draw_sprite(sprite_rock,0,245,285)
    draw_sprite(sprite_yellow,0,280,285)
    draw_sprite(sprite_rock,0,315,285)
    // Line 1
    draw_sprite(sprite_rock,0,140,320)
    draw_sprite(sprite_concreet,0,175,320)
    draw_sprite(sprite_yellow,0,210,320)
    draw_sprite(sprite_yellow,0,245,320)
    draw_sprite(sprite_yellow,0,280,320)
    draw_sprite(sprite_yellow,0,315,320)
    // Line 2 
    draw_sprite(sprite_rock,0,140,355)
    draw_sprite(sprite_concreet,0,175,355)
    draw_sprite(sprite_rock,0,210,355)
    draw_sprite(sprite_rock,0,245,355)
    draw_sprite(sprite_yellow,0,280,355)
    draw_sprite(sprite_rock,0,315,355)
    // J
    draw_set_font(font_character)
    draw_text_color(282,320,"J",0,0,0,0,1)
    draw_set_font(font_text)
}

// Nuclear Bomb
if (global.var_page==110)
{
    draw_text_ext(140,175,global.description[global.var_page],line_spacing,line_length)
    draw_sprite(sprite_yellow,0,140,225)
    draw_sprite(sprite_nuclear_bomb,0,140,225)
    draw_text_ext(140,295,"* "+global.special_nuclear_bomb[0]+"# #* "+global.special_nuclear_bomb[1]+"# #* "+global.special_nuclear_bomb[2],line_spacing,line_length)
}

// NWH
if (global.var_page==114)
{
    draw_text_ext(140,175,global.description[global.var_page],line_spacing,line_length)
    draw_text_ext(140,425,"* "+global.special_nwh[0]+"# #* "+global.special_nwh[1]+"# #* "+global.special_nwh[2]+"# #* "+global.special_nwh[3],line_spacing,line_length)
    // Line 0
    draw_sprite(sprite_steel,0,140,215)
    draw_sprite(sprite_steel,0,175,215)
    draw_sprite(sprite_rock,0,210,215)
    draw_sprite(sprite_arrow_up,-1,210,215)
    draw_sprite(sprite_steel,0,245,215)
    draw_sprite(sprite_steel,0,280,215)
    // Line 1
    draw_sprite(sprite_steel,0,140,250)
    draw_sprite(sprite_rock,0,175,250)
    draw_sprite(sprite_rock,0,210,250)
    draw_sprite(sprite_rock,0,245,250)
    draw_sprite(sprite_steel,0,280,250)
    // Line 2
    draw_sprite(sprite_steel,0,140,285)
    draw_sprite(sprite_rock,0,175,285)
    draw_sprite(sprite_nwh,0,210,285)
    draw_text_color(220,290,"0",$00FF00,$00FF00,$00FF00,$00FF00,100)
    draw_sprite(sprite_rock,0,245,285)
    draw_sprite(sprite_steel,0,280,285)
    // Line 3
    draw_sprite(sprite_steel,0,140,320)
    draw_sprite(sprite_rock,0,175,320)
    draw_sprite(sprite_rock,0,210,320)
    draw_sprite(sprite_rock,0,245,320) 
    draw_sprite(sprite_steel,0,280,320)
    // Line 4
    draw_sprite(sprite_steel,0,140,355)
    draw_sprite(sprite_steel,0,175,355)
    draw_sprite(sprite_diamond,0,210,355)
    draw_sprite(sprite_steel,0,245,355)
    draw_sprite(sprite_steel,0,280,355)
}

// Mud
if (global.var_page==116)
{
    draw_text_ext(140,175,global.description[global.var_page]+"# #* "+global.special_mud[0]+"# #e.g.",line_spacing,line_length)
    var y_place;
    y_place = 350
    var x_pos;
        x_pos = 140
        repeat(3)
        {
            y_pos = y_place
            repeat(2)
            {
                draw_sprite(sprite_mud,0,x_pos,y_pos)
                y_pos += 35
            }
            x_pos += 35
        }
    draw_sprite(sprite_mud,0,140,y_place+70)
    draw_sprite(sprite_rock,0,175,y_place+70)
    draw_sprite(sprite_rock,0,210,y_place+70)
    draw_sprite(sprite_rock,0,140,y_place+105)
    draw_sprite(sprite_yellow,0,175,y_place+105)
    draw_set_font(font_character)
    draw_text(175,y_place+105,"M")
    draw_set_font(font_text)
    draw_sprite(sprite_rock,0,210,y_place+105)
    draw_text_ext(140,500,"* "+global.special_mud[1],line_spacing,line_length)
}

// Switch/Gate
if (global.var_page==117)
{
    draw_text_ext(140,175,global.description[global.var_page]+"# #* "+global.special_switch_gate[0]+"# #* "+global.special_switch_gate[1],line_spacing,line_length)
}

// Gigga Port
if (global.var_page==118)
{
    if (global.var_page_num==0)
    {
        draw_text_ext(140,175,"* "+global.special_gigga_port[0],line_spacing,line_length)
        draw_sprite(sprite_gigga_port,-1,140,215)
        draw_text_ext(140,285,"* "+global.special_gigga_port[1]+"# #* "+global.special_gigga_port[2]+"# #* "+global.special_gigga_port[3]+"# #* "+global.special_gigga_port[4],line_spacing,line_length)
        var y_place;
        y_place = 490
        draw_sprite(sprite_rock,0,140,y_place)
        draw_sprite(sprite_yellow,0,175,y_place)
        draw_sprite(sprite_yellow,0,210,y_place)
        draw_sprite(sprite_rock,0,245,y_place)
        draw_sprite(sprite_yellow,0,140,y_place+35)
        draw_sprite(sprite_gigga_port,-1,175,y_place+35)
        draw_sprite(sprite_yellow,0,245,y_place+35)
        draw_sprite(sprite_yellow,0,140,y_place+70)
        draw_sprite(sprite_yellow,0,245,y_place+70)
        draw_sprite(sprite_rock,0,140,y_place+105)
        draw_sprite(sprite_yellow,0,175,y_place+105)
        draw_sprite(sprite_yellow,0,210,y_place+105)
        draw_sprite(sprite_rock,0,245,y_place+105)
        draw_set_font(font_character)
        draw_text(175,y_place+35,"J")
        draw_set_font(font_text)
    }
    if (global.var_page_num==1)
    {
        draw_text_ext(140,175,"* "+global.special_gigga_port[5],line_spacing,line_length)
        var y_place;
        y_place = 215
        draw_sprite(sprite_rock,0,140,y_place)
        var y_pos;
        y_pos = y_place
        repeat(5)
        {
            draw_sprite(sprite_yellow,0,175,y_pos)
            y_pos += 35
        }
        draw_sprite(sprite_rock,0,210,y_place)
        draw_sprite(sprite_gigga_port,-1,245,y_place)
        var x_pos;
        x_pos = 315
        repeat(4)
        {
            y_pos = y_place
            repeat(3)
            {
                draw_sprite(sprite_rock,0,x_pos,y_pos)
                y_pos += 35
            }
            x_pos += 35
        }
        draw_sprite(sprite_yellow,0,140,y_place+35)
        draw_sprite(sprite_yellow,0,210,y_place+35)
        y_pos = y_place+70
        repeat(3)
        {
            draw_sprite(sprite_rock,0,140,y_pos)
            y_pos += 35
        }
        x_pos = 210
        repeat(3)
        {
            y_pos = y_place+70
            repeat(3)
            {
                draw_sprite(sprite_rock,0,x_pos,y_pos)
                y_pos += 35
            }
            x_pos += 35
        }
        draw_sprite(sprite_gigga_port,-1,315,y_place+105)
        draw_sprite(sprite_rock,0,385,y_place+105)
        draw_sprite(sprite_rock,0,420,y_place+105)
        draw_sprite(sprite_yellow,0,385,y_place+140)
        draw_sprite(sprite_yellow,0,420,y_place+140)
        draw_set_font(font_character)
        draw_text_color(177,y_place+35,"J",0,0,0,0,1)
        draw_set_font(font_text)
        draw_text_ext(140,400,"* "+global.special_gigga_port[6],line_spacing,line_length)
        y_place = 435
        x_pos = 140
        repeat(4)
        {
            draw_sprite(sprite_yellow,0,x_pos,y_place)
            x_pos += 35
        }
        draw_sprite(sprite_yellow,0,140,y_place+35)
        draw_sprite(sprite_gigga_port,-1,175,y_place+35)
        draw_sprite(sprite_yellow,0,245,y_place+35)
        draw_sprite(sprite_yellow,0,140,y_place+70)
        draw_sprite(sprite_yellow,0,245,y_place+70)
        x_pos = 140
        repeat(4)
        {
            draw_sprite(sprite_yellow,0,x_pos,y_place+105)
            x_pos += 35
        }
        draw_set_font(font_character)
        draw_text_color(177,y_place+35,"M",0,0,0,0,1)
        draw_set_font(font_text)
        draw_text_ext(140,600,"* "+global.special_gigga_port[7],line_spacing,line_length)
    }
}
#define script_next_page
// script_next_page
// Stefan Grace
// Created: 2016-10-03
// Modified: 2016-10-04
// This script goes the the next page when an item has multiple pages

global.var_page_num = 1
instance_change(object_button_previous_page,true)
#define script_previous_page
// script_previous_page
// Stefan Grace
// Created: 2016-10-03
// Modified: 2016-10-04
// This script goes the the previous page when an item has multiple pages

global.var_page_num = 0
instance_change(object_button_next_page,true)
#define script_dark
// script_dark
// Stefan Grace
// Created: 2019-03-19
// Modified: 2019-03-19
// This script activates the dark color scheme

draw_set_color(c_white)
global.dark = true
alarm[0] = 1
if (file_exists(working_directory+"\Settings\Dark.txt"))
{
    var file;
    file = file_text_open_write(working_directory + "\Settings\Dark.txt")
    file_text_write_real(file,global.dark)
    file_text_close(file)
}

#define script_light
// script_light
// Stefan Grace
// Created: 2019-03-19
// Modified: 2019-03-19
// This script activates the light (default) color scheme

draw_set_color(c_black)
global.dark = false
alarm[0] = 1
if (file_exists(working_directory+"\Settings\Dark.txt"))
{
    var file;
    file = file_text_open_write(working_directory + "\Settings\Dark.txt")
    file_text_write_real(file,global.dark)
    file_text_close(file)
}

