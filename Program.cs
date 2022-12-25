﻿using fnvHashFinder;
using System.Diagnostics;

string ExportFolder = null;
string gunOps = null;

//Dictionary Attack
string[] Attack1Types =
{
"",
};

string[] Attack2Types =
{
"",
};

string[] Attack3Types =
{
"",
};

string[] Attack4Types =
{
"",
};

string[] Attack5Types =
{
"",
};

string[] Attack6Types =
{
"",
};

string[] Attack7Types =
{
"",
};

string[] Attack8Types =
{
"",
};

string[] Attack9Types =
{
"",
};

string[] Attack10Types =
{
"",
};

string[] Attack11Types =
{
"",
};

string[] Attack12Types =
{
"",
};

string[] Attack13Types =
{
"",
};

string[] Attack14Types =
{
"",
};

string[] Attack15Types =
{
"",
};

string[] Attack16Types =
{
"",
};

string[] Attack17Types =
{
"",
};

string[] Attack18Types =
{
"",
};

string[] Attack19Types =
{
"",
};

string[] Attack20Types =
{
"",
};

// You can add Direct names under any of the types
string[] ModelTypes =
{
            "",
            "_anim",
            "_armorheavy",
            "_armorheavy1",
            "_armorlight",
            "_armorlight1",
            "_armormedium",
            "_armormedium1",
            "_arms",
            "_arms1",
            "_arms1_cst",
            "_arms1_viewbody",
            "_arms1_viewbody1",
            "_arms1_viewbody1_cst",
            "_arms2",
            "_arms2_cst",
            "_arms2_viewbody",
            "_arms2_viewbody2",
            "_arms2_viewbody2_cst",
            "_arms3",
            "_arms3_cst",
            "_arms3_viewbody",
            "_arms3_viewbody3",
            "_arms3_viewbody3_cst",
            "_arms4",
            "_arms4_cst",
            "_arms4_viewbody",
            "_arms4_viewbody4",
            "_arms4_viewbody4_cst",
            "_arms5",
            "_arms5_cst",
            "_arms5_viewbody",
            "_arms5_viewbody5",
            "_arms5_viewbody5_cst",
            "_arms6",
            "_arms6_cst",
            "_arms6_viewbody",
            "_arms6_viewbody6",
            "_arms6_viewbody6_cst",
            "_arms7",
            "_arms7_cst",
            "_arms7_viewbody",
            "_arms7_viewbody7",
            "_arms7_viewbody7_cst",
            "_arms8",
            "_arms8_cst",
            "_arms8_viewbody",
            "_arms8_viewbody8",
            "_arms8_viewbody8_cst",
            "_arms9",
            "_arms9_cst",
            "_arms9_viewbody",
            "_arms9_viewbody9",
            "_arms9_viewbody9_cst",
            "_arms_cst",
            "_arms_viewbody",
            "_arms_viewbody1",
            "_arms_viewbody2",
            "_arms_viewbody3",
            "_arms_viewbody4",
            "_arms_viewbody5",
            "_arms_viewbody6",
            "_arms_viewbody7",
            "_arms_viewbody8",
            "_arms_viewbody9",
            "_fb",
            "_fb1",
            "_fb2",
            "_fb3",
            "_fb4",
            "_fb5",
            "_fb6",
            "_fb7",
            "_fb8",
            "_fb9",
            "_frontend",
            "_head",
            "_head1",
            "_head1_cst",
            "_head2",
            "_head2_cst",
            "_head3",
            "_head3_cst",
            "_head4",
            "_head4_cst",
            "_head5",
            "_head5_cst",
            "_head6",
            "_head6_cst",
            "_head7",
            "_head7_cst",
            "_head8",
            "_head8_cst",
            "_head9",
            "_head9_cst",
            "_head_cst",
            "_left_prop",
            "_lod0",
            "_lod1",
            "_lod2",
            "_lod3",
            "_lod4",
            "_lod5",
            "_lod6",
            "_lod7",
            "_lowerbody",
            "_lowerbody1",
            "_lowerbody1_cst",
            "_lowerbody2",
            "_lowerbody2_cst",
            "_lowerbody3",
            "_lowerbody3_cst",
            "_lowerbody4",
            "_lowerbody4_cst",
            "_lowerbody5",
            "_lowerbody5_cst",
            "_lowerbody6",
            "_lowerbody6_cst",
            "_lowerbody7",
            "_lowerbody7_cst",
            "_lowerbody8",
            "_lowerbody8_cst",
            "_lowerbody9",
            "_lowerbody9_cst",
            "_lowerbody_cst",
            "_lowerbody_viewbody",
            "_lowerbody_viewbody1",
            "_lowerbody_viewbody1_cst",
            "_lowerbody_viewbody2",
            "_lowerbody_viewbody2_cst",
            "_lowerbody_viewbody3",
            "_lowerbody_viewbody3_cst",
            "_lowerbody_viewbody4",
            "_lowerbody_viewbody4_cst",
            "_lowerbody_viewbody5",
            "_lowerbody_viewbody5_cst",
            "_lowerbody_viewbody6",
            "_lowerbody_viewbody6_cst",
            "_lowerbody_viewbody7",
            "_lowerbody_viewbody7_cst",
            "_lowerbody_viewbody8",
            "_lowerbody_viewbody8_cst",
            "_lowerbody_viewbody9",
            "_lowerbody_viewbody9_cst",
            "_mag_view",
            "_mag_world",
            "_projectile",
            "_projectile_dead",
            "_prop",
            "_prop_animate",
            "_right_prop",
            "_shell_view",
            "_torso",
            "_torso1",
            "_torso1_armorheavy1",
            "_torso1_armorlight1",
            "_torso1_armormedium1",
            "_torso1_cst",
            "_torso1_viewbody_cst",
            "_torso2",
            "_torso2_cst",
            "_torso2_viewbody_cst",
            "_torso3",
            "_torso3_cst",
            "_torso3_viewbody_cst",
            "_torso4",
            "_torso4_cst",
            "_torso4_viewbody_cst",
            "_torso5",
            "_torso5_cst",
            "_torso5_viewbody_cst",
            "_torso6",
            "_torso6_cst",
            "_torso6_viewbody_cst",
            "_torso7",
            "_torso7_cst",
            "_torso7_viewbody_cst",
            "_torso8",
            "_torso8_cst",
            "_torso8_viewbody_cst",
            "_torso9",
            "_torso9_cst",
            "_torso9_viewbody_cst",
            "_torso_armorheavy1",
            "_torso_armorlight1",
            "_torso_armormedium1",
            "_torso_cst",
            "_torso_viewbody",
            "_view",
            "_view_ms",
            "_view_pc",
            "_view_sy",
            "_viewarms",
            "_viewarms1",
            "_viewarms1_cst",
            "_viewarms2",
            "_viewarms2_cst",
            "_viewarms3",
            "_viewarms3_cst",
            "_viewarms4",
            "_viewarms4_cst",
            "_viewarms5",
            "_viewarms5_cst",
            "_viewarms6",
            "_viewarms6_cst",
            "_viewarms7",
            "_viewarms7_cst",
            "_viewarms8",
            "_viewarms8_cst",
            "_viewarms9",
            "_viewarms9_cst",
            "_viewarms_cst",
            "_viewbody",
            "_viewbody1",
            "_viewbody1_cst",
            "_viewbody2",
            "_viewbody2_cst",
            "_viewbody3",
            "_viewbody3_cst",
            "_viewbody4",
            "_viewbody4_cst",
            "_viewbody5",
            "_viewbody5_cst",
            "_viewbody6",
            "_viewbody6_cst",
            "_viewbody7",
            "_viewbody7_cst",
            "_viewbody8",
            "_viewbody8_cst",
            "_viewbody9",
            "_viewbody9_cst",
            "_viewlegs",
            "_viewlegs1",
            "_viewlegs1_cst",
            "_viewlegs2",
            "_viewlegs2_cst",
            "_viewlegs3",
            "_viewlegs3_cst",
            "_viewlegs4",
            "_viewlegs4_cst",
            "_viewlegs5",
            "_viewlegs5_cst",
            "_viewlegs6",
            "_viewlegs6_cst",
            "_viewlegs7",
            "_viewlegs7_cst",
            "_viewlegs8",
            "_viewlegs8_cst",
            "_viewlegs9",
            "_viewlegs9_cst",
            "_viewlegs_cst",
            "_world",
            "_world_dead",
            "_world_ms",
            "_world_pc",
            "_world_sy",
        };
string[] AnimTypes =
{
            "",
            "_ads_2x_down",
            "_ads_2x_up",
            "_acknowledge",
            "_acknowledge_additive",
            "_acknowledge_bare_hands",
            "_acknowledge_bare_hands_additive",
            "_acknowledge_dw",
            "_acknowledge_lh",
            "_acknowledge_lh_additive",
            "_acknowledge_rh",
            "_acknowledge_rh_additive",
            "_active_idle",
            "_active_idle_l",
            "_active_idle_r",
            "_additive",
            "_additive_empty",
            "_ads_3x_down",
            "_ads_3x_down",
            "_ads_4x_down",
            "_ads_4x_up",
            "_ads_acog_down",
            "_ads_acog_up",
            "_ads_base_down",
            "_ads_base_up",
            "_ads_down",
            "_ads_dualoptic_lower_up",
            "_ads_dualoptic_upper_down",
            "_ads_dualoptic_upper_up",
            "_ads_elo2_down",
            "_ads_elo2_up",
            "_ads_elo3_down",
            "_ads_elo3_up",
            "_ads_elo_down",
            "_ads_elo_up",
            "_ads_fire",
            "_ads_fire_last",
            "_ads_holo_down",
            "_ads_holo_up",
            "_ads_idle",
            "_ads_ir_down",
            "_ads_ir_up",
            "_ads_iron_sights_down",
            "_ads_iron_sights_up",
            "_ads_mms_down",
            "_ads_mms_up",
            "_ads_optics_fire",
            "_ads_rechamber",
            "_ads_reddot_down",
            "_ads_reddot_up",
            "_ads_reflex2_down",
            "_ads_reflex2_up",
            "_ads_reflex3_down",
            "_ads_reflex3_up",
            "_ads_reflex4_down",
            "_ads_reflex4_up",
            "_ads_reflex_down",
            "_ads_reflex_up",
            "_ads_scope3x_down",
            "_ads_scope3x_up",
            "_ads_scope4x_down",
            "_ads_scope4x_up",
            "_ads_scope_down",
            "_ads_scope_up",
            "_ads_thermal_down",
            "_ads_thermal_up",
            "_ads_up",
            "_alt_ads_base_down",
            "_alt_ads_base_up",
            "_alt_crawl_b",
            "_alt_crawl_f",
            "_alt_crawl_in",
            "_alt_crawl_l",
            "_alt_crawl_out",
            "_alt_crawl_r",
            "_alt_fire",
            "_alt_gunbutt_swipe",
            "_alt_idle",
            "_alt_lower",
            "_alt_pullout",
            "_alt_pullout_quick",
            "_alt_putaway",
            "_alt_putaway_quick",
            "_alt_raise",
            "_alt_reload",
            "_alt_sprint_in",
            "_alt_sprint_loop",
            "_alt_sprint_out",
            "_alt_sprint_pullout",
            "_alt_sprint_putaway",
            "_alt_super_sprint_in",
            "_alt_swim_uw_pullout",
            "_alt_swim_uw_putaway",
            "_arabian_inspect",
            "_attacking",
            "_attacking_additive",
            "_attacking_bare_hands",
            "_attacking_bare_hands_additive",
            "_attacking_dw",
            "_attacking_lh",
            "_attacking_lh_additive",
            "_attacking_rh",
            "_attacking_rh_additive",
            "_cancel",
            "_cancel_additive",
            "_cancel_additive_lh",
            "_cancel_additive_rh",
            "_cancel_bare_hands",
            "_cancel_bare_hands_additive",
            "_cancel_dw",
            "_cancel_lh",
            "_cancel_rh",
            "_celebration",
            "_celebration_additive",
            "_celebration_additive_lh",
            "_celebration_additive_rh",
            "_celebration_bare_hands",
            "_celebration_bare_hands_additive",
            "_celebration_dw",
            "_celebration_lh",
            "_celebration_rh",
            "_crawl_b",
            "_crawl_f",
            "_crawl_in",
            "_crawl_l",
            "_crawl_out",
            "_crawl_r",
            "_defending",
            "_defending_bare_hands",
            "_defending_bare_hands_additive",
            "_defending_dw",
            "_defending_lh",
            "_defending_lh_additive",
            "_defending_rh",
            "_defending_rh_additive",
            "_dinotoy_inspect",
            "_draw",
            "_draw_ads",
            "_draw_cancel",
            "_draw_loop",
            "_drink",
            "_drop",
            "_dw_active_idle_l",
            "_dw_active_idle_r",
            "_dw_ads_base_down",
            "_dw_ads_base_up",
            "_dw_crawl_b",
            "_dw_crawl_f",
            "_dw_crawl_in",
            "_dw_crawl_l",
            "_dw_crawl_out",
            "_dw_crawl_r",
            "_dw_fall",
            "_dw_fire_l",
            "_dw_fire_last_l",
            "_dw_fire_last_r",
            "_dw_fire_r",
            "_dw_first_raise",
            "_dw_first_raise_quick",
            "_dw_gunbutt_miss",
            "_dw_gunbutt_swipe",
            "_dw_idle",
            "_dw_idle_empty_l",
            "_dw_idle_empty_r",
            "_dw_idle_l",
            "_dw_idle_r",
            "_dw_inspect",
            "_dw_jump",
            "_dw_jump_land",
            "_dw_melee_l",
            "_dw_melee_r",
            "_dw_pullout",
            "_dw_pullout_quick",
            "_dw_putaway",
            "_dw_putaway_quick",
            "_dw_reload_empty_l",
            "_dw_reload_empty_r",
            "_dw_reload_l",
            "_dw_reload_r",
            "_dw_slide",
            "_dw_sprint_in",
            "_dw_sprint_loop",
            "_dw_sprint_out",
            "_dw_sprint_pullout",
            "_dw_sprint_putaway",
            "_dw_supersprint_in",
            "_dw_supersprint_loop",
            "_dw_supersprint_out",
            "_dw_supersprint_pullout",
            "_dw_supersprint_putaway",
            "_dw_swim_uw_pullout",
            "_dw_swim_uw_putaway",
            "_dw_walk_f",
            "_evil_inspect",
            "_fall",
            "_fem_prone_fire",
            "_fem_prone_reload",
            "_fem_prone_reload_empty",
            "_fem_stand_fire",
            "_fem_stand_reload",
            "_fem_stand_reload_empty",
            "_ferfluid_inspect",
            "_finger_pose_l",
            "_finger_pose_r",
            "_fire",
            "_fire_acog_ads",
            "_fire_ads",
            "_fire_ads_acog",
            "_fire_ads_elo",
            "_fire_ads_holo",
            "_fire_ads_last",
            "_fire_ads_last_acog",
            "_fire_ads_reflex",
            "_fire_delay",
            "_fire_fail",
            "_fire_l",
            "_fire_last",
            "_fire_last_ads",
            "_fire_r",
            "_first_raise",
            "_first_raise_ext",
            "_first_raise_foregrip",
            "_first_raise_quick",
            "_flanking",
            "_flanking_bare_hands",
            "_flanking_bare_hands_additive",
            "_flanking_dw",
            "_flanking_lh",
            "_flanking_lh_additive",
            "_flanking_rh",
            "_flanking_rh_additive",
            "_group_up",
            "_group_up_additive",
            "_group_up_bare_hands",
            "_group_up_bare_hands_additive",
            "_group_up_dw",
            "_group_up_lh",
            "_group_up_lh_additive",
            "_group_up_rh",
            "_group_up_rh_additive",
            "_gunbutt_strike",
            "_gunbutt_swipe",
            "_hello",
            "_hello_additive",
            "_hello_bare_hands",
            "_hello_bare_hands_additive",
            "_hello_dw",
            "_hello_lh",
            "_hello_rh",
            "_idle",
            "_idle_active",
            "_idle_ads",
            "_idle_empty",
            "_idle_l",
            "_idle_r",
            "_inspect",
            "_inspect_alt",
            "_inspect_dragon",
            "_inspect_endgame",
            "_inspect_ext",
            "_inspect_fastmag",
            "_inspect_ghostship",
            "_inspect_grip",
            "_inspect_krieger",
            "_inspect_manguish",
            "_inspect_mixclip",
            "_inspect_monte",
            "_inspect_sultan",
            "_inspect_ultrafunk",
            "_inspect_unicorn",
            "_jump",
            "_jump_land",
            "_lastshot",
            "_male_prone_fire",
            "_male_prone_reload",
            "_male_prone_reload_empty",
            "_male_stand_fire",
            "_male_stand_reload",
            "_male_stand_reload_empty",
            "_melee",
            "_melee_01",
            "_melee_02",
            "_melee_03",
            "_melee_04",
            "_melee_05",
            "_melee_06",
            "_melee_07",
            "_melee_08",
            "_melee_09",
            "_melee_empty",
            "_melee_finisher",
            "_melee_hit",
            "_melee_in",
            "_melee_l",
            "_melee_l_in",
            "_melee_l_out",
            "_melee_miss",
            "_melee_miss_01",
            "_melee_miss_02",
            "_melee_miss_03",
            "_melee_miss_04",
            "_melee_miss_05",
            "_melee_miss_06",
            "_melee_miss_07",
            "_melee_miss_08",
            "_melee_miss_09",
            "_melee_out",
            "_melee_r",
            "_melee_swipe",
            "_melee_swipe_01",
            "_melee_swipe_02",
            "_melee_swipe_03",
            "_melee_swipe_04",
            "_melee_swipe_05",
            "_melee_swipe_06",
            "_melee_swipe_07",
            "_melee_swipe_08",
            "_melee_swipe_09",
            "_need_help",
            "_need_help_additive",
            "_need_help_additive_lh",
            "_need_help_additive_rh",
            "_need_help_bare_hands",
            "_need_help_bare_hands_additive",
            "_need_help_dw",
            "_need_help_lh",
            "_need_help_rh",
            "_need_ride",
            "_need_ride_additive_lh",
            "_need_ride_additive_rh",
            "_need_ride_bare_hands",
            "_need_ride_bare_hands_additive",
            "_need_ride_dw",
            "_need_ride_lh",
            "_need_ride_rh",
            "_negative",
            "_negative_additive_lh",
            "_negative_additive_rh",
            "_negative_bare_hands",
            "_negative_bare_hands_additive",
            "_negative_dw",
            "_negative_lh",
            "_negative_rh",
            "_pullout",
            "_pullout_alt",
            "_pullout_empty",
            "_pullout_fast",
            "_pullout_first",
            "_pullout_first_quick",
            "_pullout_quick",
            "_pullpin",
            "_pullpin_additive",
            "_pullpin_additive_lh",
            "_pullpin_additive_rh",
            "_pullpin_bare_hands",
            "_pullpin_bare_hands_additive",
            "_pullpin_dw",
            "_pullpin_lh",
            "_pullpin_rh",
            "_putaway",
            "_putaway_alt",
            "_putaway_empty",
            "_putaway_quick",
            "_raise",
            "_ratrod_inspect",
            "_rechamber",
            "_rechamber_ads",
            "_reload",
            "_reload_ads",
            "_reload_ads_empty",
            "_reload_ads_empty_ext",
            "_reload_ads_empty_fast",
            "_reload_ads_empty_fastmag",
            "_reload_ads_empty_mixclip",
            "_reload_ads_empty_quick",
            "_reload_ads_end",
            "_reload_ads_ext",
            "_reload_ads_ext_empty",
            "_reload_ads_fast",
            "_reload_ads_fast_empty",
            "_reload_ads_fastmag",
            "_reload_ads_in",
            "_reload_ads_loop",
            "_reload_ads_mixclip",
            "_reload_ads_mixclip_empty",
            "_reload_ads_out",
            "_reload_ads_quick",
            "_reload_ads_quick_empty",
            "_reload_ads_start",
            "_reload_empty",
            "_reload_empty_ads",
            "_reload_empty_ext",
            "_reload_empty_ext_ads",
            "_reload_empty_fast",
            "_reload_empty_fast_ads",
            "_reload_empty_fast_ext",
            "_reload_empty_fast_mag",
            "_reload_empty_fastmag",
            "_reload_empty_fastmag_ads",
            "_reload_empty_mixclip",
            "_reload_empty_mixclip_ads",
            "_reload_empty_quick",
            "_reload_empty_quick_ads",
            "_reload_end",
            "_reload_end_ads",
            "_reload_ext",
            "_reload_ext_ads",
            "_reload_ext_empty",
            "_reload_ext_empty_ads",
            "_reload_extmag",
            "_reload_extmag_ads",
            "_reload_extmag_empty",
            "_reload_extmag_empty_ads",
            "_reload_fast",
            "_reload_fast_ads",
            "_reload_fast_empty",
            "_reload_fast_empty_ads",
            "_reload_fast_ext",
            "_reload_fast_mag",
            "_reload_fastmag",
            "_reload_fastmag_ads",
            "_reload_fastmag_empty",
            "_reload_fastmag_empty_ads",
            "_reload_in",
            "_reload_in_ads",
            "_reload_loop",
            "_reload_loop_ads",
            "_reload_mixclip",
            "_reload_mixclip_ads",
            "_reload_mixclip_empty",
            "_reload_mixclip_empty_ads",
            "_reload_out",
            "_reload_out_ads",
            "_reload_quick",
            "_reload_quick_ads",
            "_reload_quick_empty",
            "_reload_quick_empty_ads",
            "_reload_start",
            "_reload_start_ads",
            "_runman_inspect",
            "_sanim",
            "_slide",
            "_sprint_in",
            "_sprint_loop",
            "_sprint_out",
            "_sprint_pullout",
            "_sprint_putaway",
            "_super_sprint_in",
            "_super_sprint_loop",
            "_super_sprint_out",
            "_super_sprint_pullout",
            "_super_sprint_putaway",
            "_supersprint_in",
            "_supersprint_loop",
            "_supersprint_out",
            "_supersprint_pullout",
            "_supersprint_putaway",
            "_swim_from_land",
            "_swim_melee_swipe",
            "_swim_over_melee_swipe",
            "_swim_pullout",
            "_swim_putaway",
            "_swim_to_land",
            "_swim_uw_ads",
            "_swim_uw_ads_fire",
            "_swim_uw_b",
            "_swim_uw_f",
            "_swim_uw_fire",
            "_swim_uw_fire_ads",
            "_swim_uw_idle",
            "_swim_uw_in",
            "_swim_uw_l",
            "_swim_uw_out",
            "_swim_uw_pullout",
            "_swim_uw_putaway",
            "_swim_uw_r",
            "_swim_uw_sprint_in",
            "_swim_uw_sprint_out",
            "_taunt",
            "_taunt_additive",
            "_taunt_additive_dw",
            "_taunt_additive_lh",
            "_taunt_additive_rh",
            "_taunt_bare_hands",
            "_taunt_bare_hands_additive",
            "_taunt_dw",
            "_taunt_lh",
            "_taunt_rh",
            "_thanks",
            "_thanks_additive",
            "_thanks_additive_dw",
            "_thanks_additive_lh",
            "_thanks_additive_rh",
            "_thanks_bare_hands",
            "_thanks_bare_hands_additive",
            "_thanks_dw",
            "_thanks_lh",
            "_thanks_rh",
            "_throw",
            "_throw_back",
            "_throw_back_lh",
            "_throw_back_rh",
            "_throw_bare_hands",
            "_throw_bare_hands_additive",
            "_throw_dw",
            "_throw_lh",
            "_throw_rh",
            "_walk",
            "_walk_f",
        };
string[] AIAnimTypes =
{
            "",
            "_aim_2",
            "_aim_4",
            "_aim_6",
            "_aim_8",
            "_aim_idle",
            "_arrival",
            "_arrival_01",
            "_arrive",
            "_chaingun_aim_2",
            "_chaingun_aim_4",
            "_chaingun_aim_6",
            "_chaingun_aim_8",
            "_chaingun_destroyed_pain",
            "_chaingun_fire",
            "_chaingun_intro_sprint_to_aim_5",
            "_death_02",
            "_exit",
            "_head_stun_intro",
            "_head_stun_loop",
            "_head_stun_outro",
            "_idle_01",
            "_idle_v1",
            "_jump_across_128",
            "_jump_across_256",
            "_jump_dn_128",
            "_jump_dn_160",
            "_jump_dn_36",
            "_jump_dn_48",
            "_jump_dn_72",
            "_jump_dn_96",
            "_jump_down_128",
            "_jump_down_160",
            "_jump_down_190",
            "_jump_down_36",
            "_jump_down_48",
            "_jump_down_72",
            "_jump_down_96",
            "_jump_up_128",
            "_jump_up_160",
            "_jump_up_244_down_36",
            "_jump_up_36",
            "_jump_up_36_down_244",
            "_jump_up_48",
            "_jump_up_72",
            "_jump_up_96",
            "_mantle_36",
            "_mantle_48",
            "_mantle_72",
            "_mantle_96",
            "_mantle_over_128",
            "_mantle_over_36",
            "_mantle_over_48",
            "_mantle_over_72",
            "_mantle_over_96",
            "_melee_01",
            "_melee_a",
            "_melee_attack_v1",
            "_melee_b",
            "_pain_01",
            "_pain_b",
            "_pain_f",
            "_pain_faceplate",
            "_pain_head",
            "_pain_l",
            "_pain_long",
            "_pain_med",
            "_pain_r",
            "_pain_short",
            "_powercore_pain",
            "_ranged_attack_v1",
            "_ranged_attack_v1_end",
            "_ranged_attack_v1_loop",
            "_ranged_attack_v2",
            "_run_01",
            "_run_02",
            "_run_aim_2",
            "_run_aim_4",
            "_run_aim_6",
            "_run_aim_8",
            "_run_jump_across_128",
            "_run_jump_across_256",
            "_run_jump_down_128",
            "_run_jump_down_160",
            "_run_jump_down_256",
            "_run_jump_down_36",
            "_run_jump_down_48",
            "_run_jump_down_72",
            "_run_jump_down_96",
            "_run_jump_up_128",
            "_run_jump_up_160",
            "_run_jump_up_256",
            "_run_jump_up_36",
            "_run_jump_up_48",
            "_run_jump_up_72",
            "_run_jump_up_96",
            "_run_turn_l_135",
            "_run_turn_l_180",
            "_run_turn_l_45",
            "_run_turn_l_90",
            "_run_turn_r_135",
            "_run_turn_r_180",
            "_run_turn_r_45",
            "_run_turn_r_90",
            "_run_v1",
            "_sprint_01",
            "_sprint_02",
            "_sprint_v1",
            "_sprint_jump_dn_32",
            "_sprint_jump_dn_36",
            "_sprint_jump_dn_48",
            "_sprint_jump_dn_72",
            "_sprint_jump_dn_96",
            "_sprint_jump_dn_128",
            "_sprint_jump_dn_160",
            "_sprint_jump_up_32",
            "_sprint_jump_up_36",
            "_sprint_jump_up_48",
            "_sprint_jump_up_72",
            "_sprint_jump_up_96",
            "_sprint_jump_up_128",
            "_sprint_jump_up_160",
            "_stalk_turn_l_135",
            "_stalk_turn_l_180",
            "_stalk_turn_l_90",
            "_stalk_turn_r_135",
            "_stalk_turn_r_180",
            "_stalk_turn_r_90",
            "_stn_turn_l_135",
            "_stn_turn_l_180",
            "_stn_turn_l_45",
            "_stn_turn_l_90",
            "_stn_turn_r_135",
            "_stn_turn_r_180",
            "_stn_turn_r_45",
            "_stn_turn_r_90",
            "_stumble_intro",
            "_stumble_outro",
            "_sweep",
            "_teleport_end",
            "_teleport_start",
            "_trot_01",
            "_trv_jump_dn_128",
            "_trv_jump_dn_36",
            "_trv_jump_dn_48",
            "_trv_jump_dn_72",
            "_trv_jump_dn_96",
            "_trv_jump_up_128",
            "_trv_jump_up_36",
            "_trv_jump_up_48",
            "_trv_jump_up_72",
            "_trv_jump_up_96",
            "_trv_mantle_36",
            "_trv_mantle_48",
            "_trv_mantle_72",
            "_trv_mantle_96",
            "_turn_l_135",
            "_turn_l_180",
            "_turn_l_45",
            "_turn_l_90",
            "_turn_r_135",
            "_turn_r_180",
            "_turn_r_45",
            "_turn_r_90",
            "_walk_01",
            "_walk_basic",
            "_walk_jump_dn_32",
            "_walk_jump_dn_36",
            "_walk_jump_dn_48",
            "_walk_jump_dn_96",
            "_walk_jump_dn_128",
            "_walk_jump_dn_160",
            "_walk_jump_up_32",
            "_walk_jump_up_36",
            "_walk_jump_up_48",
            "_walk_jump_up_96",
            "_walk_jump_up_128",
            "_walk_jump_up_160",
            "_walk_to_sprint_01",
            "_walk_turn_l_135",
            "_walk_turn_l_180",
            "_walk_turn_l_45",
            "_walk_turn_l_90",
            "_walk_turn_r_135",
            "_walk_turn_r_180",
            "_walk_turn_r_45",
            "_walk_turn_r_90",
            "_walk_v1",
        };
string[] ImageTypes =
{
            "",
            "_c",
            "_col",
            "_cos",
            "_cst_c",
            "_cst_e",
            "_cst_g",
            "_cst_m",
            "_cst_n",
            "_cst_o",
            "_cst_s",
            "_e",
            "_g",
            "_m",
            "_n",
            "_nml",
            "_o",
            "_r",
            "_render",
            "_render_xl",
            "_s",
            "_spc",
            "_t",
            "xl",
        };
string[] ImageSequenceTypes =
{
            "",
            "_bp_0",
            "_bp_0b",
            "_bp_1",
            "_bp_10",
            "_bp_10b",
            "_bp_11",
            "_bp_11b",
            "_bp_12",
            "_bp_12b",
            "_bp_13",
            "_bp_13b",
            "_bp_14",
            "_bp_14b",
            "_bp_15",
            "_bp_15b",
            "_bp_16",
            "_bp_16b",
            "_bp_17",
            "_bp_17b",
            "_bp_18",
            "_bp_18b",
            "_bp_19",
            "_bp_19b",
            "_bp_1b",
            "_bp_2",
            "_bp_20",
            "_bp_20b",
            "_bp_21",
            "_bp_21b",
            "_bp_22",
            "_bp_22b",
            "_bp_23",
            "_bp_23b",
            "_bp_24",
            "_bp_24b",
            "_bp_25",
            "_bp_25b",
            "_bp_26",
            "_bp_26b",
            "_bp_27",
            "_bp_27b",
            "_bp_28",
            "_bp_28b",
            "_bp_29",
            "_bp_29b",
            "_bp_2b",
            "_bp_3",
            "_bp_30",
            "_bp_30b",
            "_bp_31",
            "_bp_31b",
            "_bp_32",
            "_bp_32b",
            "_bp_33",
            "_bp_33b",
            "_bp_34",
            "_bp_34b",
            "_bp_35",
            "_bp_35b",
            "_bp_36",
            "_bp_36b",
            "_bp_37",
            "_bp_37b",
            "_bp_38",
            "_bp_38b",
            "_bp_39",
            "_bp_39b",
            "_bp_3b",
            "_bp_4",
            "_bp_40",
            "_bp_40b",
            "_bp_41",
            "_bp_41b",
            "_bp_42",
            "_bp_42b",
            "_bp_43",
            "_bp_43b",
            "_bp_44",
            "_bp_44b",
            "_bp_45",
            "_bp_45b",
            "_bp_46",
            "_bp_46b",
            "_bp_47",
            "_bp_47b",
            "_bp_48",
            "_bp_48b",
            "_bp_49",
            "_bp_49b",
            "_bp_4b",
            "_bp_5",
            "_bp_50",
            "_bp_50b",
            "_bp_51",
            "_bp_51b",
            "_bp_52",
            "_bp_52b",
            "_bp_53",
            "_bp_53b",
            "_bp_54",
            "_bp_54b",
            "_bp_55",
            "_bp_55b",
            "_bp_56",
            "_bp_56b",
            "_bp_57",
            "_bp_57b",
            "_bp_58",
            "_bp_58b",
            "_bp_59",
            "_bp_59b",
            "_bp_5b",
            "_bp_6",
            "_bp_60",
            "_bp_60b",
            "_bp_61",
            "_bp_61b",
            "_bp_62",
            "_bp_62b",
            "_bp_63",
            "_bp_63b",
            "_bp_64",
            "_bp_64b",
            "_bp_65",
            "_bp_65b",
            "_bp_66",
            "_bp_66b",
            "_bp_67",
            "_bp_67b",
            "_bp_68",
            "_bp_68b",
            "_bp_69",
            "_bp_69b",
            "_bp_6b",
            "_bp_7",
            "_bp_70",
            "_bp_70b",
            "_bp_71",
            "_bp_71b",
            "_bp_72",
            "_bp_72b",
            "_bp_73",
            "_bp_73b",
            "_bp_74",
            "_bp_74b",
            "_bp_75",
            "_bp_75b",
            "_bp_76",
            "_bp_76b",
            "_bp_77",
            "_bp_77b",
            "_bp_78",
            "_bp_78b",
            "_bp_79",
            "_bp_79b",
            "_bp_7b",
            "_bp_8",
            "_bp_80",
            "_bp_80b",
            "_bp_81",
            "_bp_81b",
            "_bp_82",
            "_bp_82b",
            "_bp_83",
            "_bp_83b",
            "_bp_84",
            "_bp_84b",
            "_bp_85",
            "_bp_85b",
            "_bp_86",
            "_bp_86b",
            "_bp_87",
            "_bp_87b",
            "_bp_88",
            "_bp_88b",
            "_bp_89",
            "_bp_89b",
            "_bp_8b",
            "_bp_9",
            "_bp_90",
            "_bp_90b",
            "_bp_91",
            "_bp_91b",
            "_bp_92",
            "_bp_92b",
            "_bp_93",
            "_bp_93b",
            "_bp_94",
            "_bp_94b",
            "_bp_95",
            "_bp_95b",
            "_bp_96",
            "_bp_96b",
            "_bp_97",
            "_bp_97b",
            "_bp_98",
            "_bp_98b",
            "_bp_99",
            "_bp_99b",
            "_bp_9b",
            "_sig_01",
            "_sig_02",
            "_sig_03",
        };
string[] ImageWpnAttachmentTypes =
{
            "",
            "_acc_bpu",
            "_accessories",
            "_ammo",
            "_attachments",
            "_barrel",
            "_barrel_alt",
            "_barrel_assembly",
            "_barrel_base",
            "_barrel_bolt",
            "_barrel_bpu",
            "_barrel_mip",
            "_base",
            "_base_mag",
            "_base_mip",
            "_base_muzzle_sight",
            "_bipod",
            "_bipod_base",
            "_bipod_bpu",
            "_blade",
            "_body",
            "_body_alt_bpu",
            "_body_base",
            "_body_bpu",
            "_body_front",
            "_body_rear",
            "_bolt",
            "_bow",
            "_bullet",
            "_cap",
            "_carry_handle",
            "_carryhandle",
            "_charging_handle",
            "_charginghandle",
            "_cheekrest",
            "_cheekrest_pro",
            "_clip",
            "_clothes",
            "_compensator",
            "_confetti", // is this a BP name?
			"_cover_base",
            "_decal",
            "_decals",
            "_dress",
            "_ext_mag",
            "_extclip_01",
            "_firingpin",
            "_foregrip",
            "_forend",
            "_forend_alt_bpu",
            "_forgrip",
            "_front",
            "_frontsight",
            "_fur",
            "_glass",
            "_grip",
            "_grip_alt",
            "_grip_base",
            "_grip_mip",
            "_grip_speed",
            "_grips",
            "_hammer",
            "_hammer_mip",
            "_handguard",
            "_handguard_base",
            "_handguard_grip",
            "_handle_bpu",
            "_harness",
            "_head",
            "_heavy_barrel_01",
            "_heavy_barrel_01_pro",
            "_heavy_barrel_02",
            "_hilt",
            "_iron_sight_base",
            "_iron_sights",
            "_irons",
            "_irons_mip",
            "_ironsights",
            "_ironsights_base",
            "_lens",
            "_light",
            "_long_barrel_01",
            "_long_barrel_01_pro",
            "_lower",
            "_mag",
            "_mag_alt",
            "_mag_alt_bpu",
            "_mag_base",
            "_mag_bpu",
            "_magazine",
            "_magwell",
            "_metal",
            "_metal_mag",
            "_meter",
            "_misc",
            "_misc_alt_bpu",
            "_misc_bpu",
            "_mixbarrel_01_pro",
            "_mixclip_01",
            "_mixmuzzle_base",
            "_muzzle",
            "_muzzle_base",
            "_muzzle_bpu",
            "_muzzle_clip",
            "_optic_rail",
            "_other",
            "_parts",
            "_patch_tape",
            "_pieces",
            "_plastic",
            "_power",
            "_power_wave",
            "_quickdraw",
            "_rail",
            "_rail_bpu",
            "_rail_mount",
            "_rear_iron_mount",
            "_rear_sight",
            "_rear_upper",
            "_rearsight",
            "_rearsight_top",
            "_receiver",
            "_receiver_base",
            "_receiver_bottom",
            "_receiver_bpu",
            "_receiver_lower",
            "_receiver_lower_alt",
            "_receiver_top",
            "_receiver_upper",
            "_receiver_upper_alt",
            "_receiver_v2",
            "_reciever",
            "_reciever_base",
            "_reciever_bpu",
            "_reciever_lower",
            "_reciever_lower_alt",
            "_reciever_upper",
            "_reciever_upper_alt",
            "_reciever_v2",
            "_reticle",
            "_scope",
            "_scope_bpu",
            "_scope_front",
            "_scope_front_v2",
            "_scope_rear",
            "_scope_rear_v2",
            "_scope_strap",
            "_scope_strap_v2",
            "_scope_straps",
            "_secondary",
            "_shell",
            "_shroud",
            "_shroud_base",
            "_shroud_cap",
            "_sight",
            "_sight_front_off",
            "_sight_misc",
            "_sight_misc_base",
            "_sight_rear",
            "_sight_rear_alt",
            "_sights",
            "_sights_alt_bpu",
            "_sights_bpu",
            "_slide_01",
            "_sling_clamp",
            "_starsmoon", // is this a BP name?
			"_stock",
            "_stock_base",
            "_stock_base_1",
            "_stock_base_wrap",
            "_stock_bpu",
            "_stock_lower",
            "_stock_mag",
            "_stock_mag_base",
            "_stock_mag_base_alt",
            "_stock_mount",
            "_stock_v2",
            "_stockhinge",
            "_strap_bo1",
            "_strap_parts",
            "_suppressor",
            "_suppressor_01",
            "_tape",
            "_top",
            "_triggergroup",
            "_upper",
            "_wires",
        };
string[] ImageWpnBlueprintTypes =
{
            "",
            "_84",
            "_aagirl",
            "_aconstrictor",
            "_adder",
            "_anime_soviet_tank_girl",
            "_anime_tank",
            "_anime_tank_anime_tank",
            "_animeninja",
            "_animesg",
            "_animewidow",
            "_apex",
            "_arctic",
            "_arcticwind",
            "_armadillo",
            "_avalanche",
            "_beachcomber",
            "_beta",
            "_betty",
            "_blackt",
            "_bloodhawk",
            "_bluereaper",
            "_boar",
            "_brawler",
            "_bsilver",
            "_btank",
            "_bw",
            "_bwidow",
            "_carbonchrome",
            "_carnival",
            "_cfiber",
            "_charden",
            "_clean",
            "_cmoney",
            "_code",
            "_concrete",
            "_confront",
            "_counter",
            "_crowstorm",
            "_crypto",
            "_density",
            "_devil",
            "_devilwoman",
            "_dfoilage",
            "_dieh",
            "_dinotoy",
            "_dozer",
            "_dpharao",
            "_eclipse",
            "_electro",
            "_evil",
            "_eyerelief",
            "_ferfluid",
            "_fighter",
            "_finec2",
            "_firestorm",
            "_fishtank",
            "_fixit",
            "_flak",
            "_frogmen",
            "_frostbite",
            "_gambit",
            "_gcompany",
            "_ghost",
            "_ghostwood",
            "_gigaswatt",
            "_gladiator",
            "_glitch",
            "_great",
            "_grunge",
            "_hcover",
            "_highstakes",
            "_holiday",
            "_horror",
            "_ivory",
            "_jefe",
            "_jokerh",
            "_junglewarfare",
            "_kingscrp",
            "_lastzombie",
            "_leagueplay",
            "_leprecon",
            "_lochness",
            "_lunar",
            "_mallrat",
            "_maneater",
            "_manguish",
            "_mdriving",
            "_mechanic",
            "_media",
            "_midnight",
            "_milspec",
            "_mind",
            "_mindfry",
            "_moa",
            "_moonshine",
            "_muerte",
            "_nature",
            "_nightfall",
            "_nocturne",
            "_noir",
            "_nonuke",
            "_nt6_bus",
            "_nvidia",
            "_ole",
            "_opulence",
            "_overkill",
            "_peace",
            "_polar",
            "_primal",
            "_primal_v2",
            "_racer",
            "_ram",
            "_rbaron",
            "_rebel",
            "_rebirth",
            "_red",
            "_renegade",
            "_resist",
            "_rifleer",
            "_ripper",
            "_rockcold",
            "_runman",
            "_russian",
            "_samurai",
            "_schwagger",
            "_scorpion",
            "_scrap",
            "_six",
            "_smooth",
            "_smoulder",
            "_somberv",
            "_soul",
            "_sovietops",
            "_space",
            "_spirit",
            "_stamp",
            "_sterile",
            "_street",
            "_summer",
            "_taffy",
            "_teal",
            "_titanium",
            "_trawler",
            "_tunnel",
            "_valya",
            "_verde",
            "_voodoo",
            "_wanker",
            "_warlord",
            "_weapon_wetop",
            "_zslayer",
        };
string[] MaterialTypes =
{
            "",
            "_cst",
        };
string[] VoxTypes =
{
            "",
            // Fireteam Announcers
            "_bb_control_start_00",
            "_bb_control_start_hardcore_00",
            "_bb_ctf_start_00",
            "_bb_ctf_start_hardcore_00",
            "_bb_dbl_start_00",
            "_bb_dbl_start_hardcore_00",
            "_bb_demo_start_00",
            "_bb_demo_start_hardcore_00",
            "_bb_dom_start_00",
            "_bb_dom_start_harcore_00",
            "_bb_drp_start_00",
            "_bb_drp_start_hardcore_00",
            "_bb_dty_start_00",
            "_bb_dty_start_hardcore_00",
            "_bb_elm_start_00",
            "_bb_elm_start_hardcore_00",
            "_bb_ffa_start_00",
            "_bb_ffa_start_hardcore_00",
            "_bb_gg_start_00",
            "_bb_gg_start_hardcore_00",
            "_bb_gnf_start_00",
            "_bb_gnf_start_hardcore_00",
            "_bb_infect_start_00",
            "_bb_infect_start_hardcore_00",
            "_bb_kc_start_00",
            "_bb_kc_start_hardcore_00",
            "_bb_koth_start_00",
            "_bb_koth_start_hardcore_00",
            "_bb_oic_start_00",
            "_bb_oic_start_hardcore_00",
            "_bb_prop_hunt_start_00",
            "_bb_prop_hunt_start_hardcore_00",
            "_bb_sat_start_00",
            "_bb_sat_start_hardcore_00",
            "_bb_sd_start_00",
            "_bb_sd_start_hardcore_00",
            "_bb_sns_start_00",
            "_bb_sns_start_hardcore_00",
            "_bb_stk_start_00",
            "_bb_stk_start_hardcore_00",
            "_bb_tdm_start_00",
            "_bb_tdm_start_hardcore_00",
            "_bb_vip_start_00",
            "_bb_vip_start_hardcore_00",
            "_bb_war_start_00",
            "_bb_war_start_hardcore_00",
            "_cntrl_take_final_mult_def_00",
            "_cntrl_take_final_mult_def_01",
            "_cntrl_take_final_mult_def_02",
            "_cntrl_take_final_mult_def_03",
            "_cntrl_take_final_tgts_mult_ofs_00",
            "_cntrl_take_final_tgts_mult_ofs_01",
            "_cntrl_take_final_tgts_mult_ofs_02",
            "_cntrl_take_final_tgts_mult_ofs_03",
            "_cntrl_take_mult_def_00",
            "_cntrl_take_mult_def_01",
            "_cntrl_take_mult_def_02",
            "_cntrl_take_mult_def_03",
            "_control_cap_a_def_00",
            "_control_cap_a_def_01",
            "_control_cap_a_def_02",
            "_control_cap_a_def_03",
            "_control_cap_a_ofs_00",
            "_control_cap_a_ofs_01",
            "_control_cap_a_ofs_02",
            "_control_cap_a_ofs_03",
            "_control_cap_all_def_00",
            "_control_cap_all_def_01",
            "_control_cap_all_def_02",
            "_control_cap_all_def_03",
            "_control_cap_all_ofs_00",
            "_control_cap_all_ofs_01",
            "_control_cap_all_ofs_02",
            "_control_cap_all_ofs_03",
            "_control_cap_b_def_00",
            "_control_cap_b_def_01",
            "_control_cap_b_def_02",
            "_control_cap_b_def_03",
            "_control_cap_b_ofs_00",
            "_control_cap_b_ofs_01",
            "_control_cap_b_ofs_02",
            "_control_cap_b_ofs_03",
            "_control_cap_c_def_00",
            "_control_cap_c_def_01",
            "_control_cap_c_def_02",
            "_control_cap_c_def_03",
            "_control_cap_c_ofs_00",
            "_control_cap_c_ofs_01",
            "_control_cap_c_ofs_02",
            "_control_cap_c_ofs_03",
            "_control_cont_a_def_00",
            "_control_cont_a_def_01",
            "_control_cont_a_def_02",
            "_control_cont_a_def_03",
            "_control_cont_a_ofs_00",
            "_control_cont_a_ofs_01",
            "_control_cont_a_ofs_02",
            "_control_cont_a_ofs_03",
            "_control_cont_all_def_00",
            "_control_cont_all_def_01",
            "_control_cont_all_def_02",
            "_control_cont_all_def_03",
            "_control_cont_all_ofs_00",
            "_control_cont_all_ofs_01",
            "_control_cont_all_ofs_02",
            "_control_cont_all_ofs_03",
            "_control_cont_b_def_00",
            "_control_cont_b_def_01",
            "_control_cont_b_def_02",
            "_control_cont_b_def_03",
            "_control_cont_b_ofs_00",
            "_control_cont_b_ofs_01",
            "_control_cont_b_ofs_02",
            "_control_cont_b_ofs_03",
            "_control_cont_c_def_00",
            "_control_cont_c_def_01",
            "_control_cont_c_def_02",
            "_control_cont_c_def_03",
            "_control_cont_c_ofs_00",
            "_control_cont_c_ofs_01",
            "_control_cont_c_ofs_02",
            "_control_cont_c_ofs_03",
            "_control_ft_start_00",
            "_control_ft_start_hardcore_00",
            "_control_low_lives_00",
            "_control_low_lives_01",
            "_control_low_lives_02",
            "_control_low_lives_03",
            "_control_low_lives_emy_00",
            "_control_low_lives_emy_01",
            "_control_low_lives_emy_02",
            "_control_low_lives_emy_03",
            "_control_no_lives_00",
            "_control_no_lives_01",
            "_control_no_lives_02",
            "_control_no_lives_03",
            "_control_no_lives_emy_00",
            "_control_no_lives_emy_01",
            "_control_no_lives_emy_02",
            "_control_no_lives_emy_03",
            "_control_orders_def_00",
            "_control_orders_def_01",
            "_control_orders_ofs_00",
            "_control_orders_ofs_01",
            "_control_start_00",
            "_control_start_hardcore_00",
            "_control_taking_a_def_00",
            "_control_taking_a_def_01",
            "_control_taking_a_def_02",
            "_control_taking_a_def_03",
            "_control_taking_a_ofs_00",
            "_control_taking_a_ofs_01",
            "_control_taking_a_ofs_02",
            "_control_taking_a_ofs_03",
            "_control_taking_b_def_00",
            "_control_taking_b_def_01",
            "_control_taking_b_def_02",
            "_control_taking_b_def_03",
            "_control_taking_b_ofs_00",
            "_control_taking_b_ofs_01",
            "_control_taking_b_ofs_02",
            "_control_taking_b_ofs_03",
            "_control_taking_c_def_00",
            "_control_taking_c_def_01",
            "_control_taking_c_def_02",
            "_control_taking_c_def_03",
            "_control_taking_c_ofs_00",
            "_control_taking_c_ofs_01",
            "_control_taking_c_ofs_02",
            "_control_taking_c_ofs_03",
            "_control_taking_mult_ofs_00",
            "_control_taking_mult_ofs_01",
            "_control_taking_mult_ofs_02",
            "_control_taking_mult_ofs_03",
            "_ctf_captured_00",
            "_ctf_captured_01",
            "_ctf_dropped_00",
            "_ctf_dropped_01",
            "_ctf_enemy_captured_00",
            "_ctf_enemy_captured_01",
            "_ctf_enemy_dropped_00",
            "_ctf_enemy_dropped_01",
            "_ctf_enemy_dropped_02",
            "_ctf_enemy_returned_00",
            "_ctf_enemy_returned_01",
            "_ctf_enemy_taken_00",
            "_ctf_enemy_taken_01",
            "_ctf_ft_start_00",
            "_ctf_ft_start_hardcore_00",
            "_ctf_returned_00",
            "_ctf_returned_01",
            "_ctf_returned_02",
            "_ctf_start_00",
            "_ctf_start_hardcore_00",
            "_ctf_taken_00",
            "_ctf_taken_01",
            "_dbl_all_invst_down_dblagt_00",
            "_dbl_all_invst_down_dblagt_01",
            "_dbl_atpsy_dblagt_00",
            "_dbl_atpsy_dblagt_01",
            "_dbl_bomb_armed_00",
            "_dbl_bomb_armed_01",
            "_dbl_fldmic_destroy_00",
            "_dbl_fldmic_destroy_01",
            "_dbl_ft_start_00",
            "_dbl_ft_start_hardcore_00",
            "_dbl_msg_decd1_dblagt_00",
            "_dbl_msg_decd1_dblagt_01",
            "_dbl_msg_decd1_op_00",
            "_dbl_msg_decd1_op_01",
            "_dbl_msg_decd2_dblagt_00",
            "_dbl_msg_decd2_dblagt_01",
            "_dbl_msg_decd2_op_00",
            "_dbl_msg_decd2_op_01",
            "_dbl_msg_decd3_dblagt_00",
            "_dbl_msg_decd3_dblagt_01",
            "_dbl_msg_decd3_op_00",
            "_dbl_msg_decd3_op_01",
            "_dbl_rnd_end_oprt_dead_oprt_00",
            "_dbl_rnd_end_oprt_dead_oprt_01",
            "_dbl_start_00",
            "_dbl_start_hardcore_00",
            "_demo_ft_start_00",
            "_demo_ft_start_hardcore_00",
            "_demo_start_00",
            "_demo_start_hardcore_00",
            "_dom_enemy_a_00",
            "_dom_enemy_a_01",
            "_dom_enemy_a_02",
            "_dom_enemy_a_03",
            "_dom_enemy_b_00",
            "_dom_enemy_b_01",
            "_dom_enemy_b_02",
            "_dom_enemy_b_03",
            "_dom_enemy_c_00",
            "_dom_enemy_c_01",
            "_dom_enemy_c_02",
            "_dom_enemy_c_03",
            "_dom_enemy_d_00",
            "_dom_enemy_d_01",
            "_dom_enemy_d_02",
            "_dom_enemy_d_03",
            "_dom_enemy_e_00",
            "_dom_enemy_e_01",
            "_dom_enemy_e_02",
            "_dom_enemy_e_03",
            "_dom_enemy_f_00",
            "_dom_enemy_f_01",
            "_dom_enemy_f_02",
            "_dom_enemy_f_03",
            "_dom_ft_start_00",
            "_dom_ft_start_hardcore_00",
            "_dom_losing_a_00",
            "_dom_losing_a_01",
            "_dom_losing_b_00",
            "_dom_losing_b_01",
            "_dom_losing_c_00",
            "_dom_losing_c_01",
            "_dom_losing_d_00",
            "_dom_losing_d_01",
            "_dom_losing_e_00",
            "_dom_losing_e_01",
            "_dom_losing_f_00",
            "_dom_losing_f_01",
            "_dom_lost_a_00",
            "_dom_lost_a_01",
            "_dom_lost_b_00",
            "_dom_lost_b_01",
            "_dom_lost_c_00",
            "_dom_lost_c_01",
            "_dom_lost_d_00",
            "_dom_lost_d_01",
            "_dom_lost_e_00",
            "_dom_lost_e_01",
            "_dom_lost_f_00",
            "_dom_lost_f_01",
            "_dom_near_drawing_00",
            "_dom_near_drawing_01",
            "_dom_near_drawing_02",
            "_dom_near_drawing_03",
            "_dom_near_losing_00",
            "_dom_near_losing_01",
            "_dom_near_losing_02",
            "_dom_near_losing_03",
            "_dom_near_losing_final_00",
            "_dom_near_losing_final_01",
            "_dom_near_losing_final_02",
            "_dom_near_losing_final_03",
            "_dom_near_winning_00",
            "_dom_near_winning_01",
            "_dom_near_winning_02",
            "_dom_near_winning_03",
            "_dom_near_winning_final_00",
            "_dom_near_winning_final_01",
            "_dom_near_winning_final_02",
            "_dom_near_winning_final_03",
            "_dom_secured_a_00",
            "_dom_secured_a_01",
            "_dom_secured_a_02",
            "_dom_secured_a_03",
            "_dom_secured_b_00",
            "_dom_secured_b_01",
            "_dom_secured_b_02",
            "_dom_secured_b_03",
            "_dom_secured_c_00",
            "_dom_secured_c_01",
            "_dom_secured_c_02",
            "_dom_secured_c_03",
            "_dom_secured_d_00",
            "_dom_secured_d_01",
            "_dom_secured_d_02",
            "_dom_secured_d_03",
            "_dom_secured_e_00",
            "_dom_secured_e_01",
            "_dom_secured_e_02",
            "_dom_secured_e_03",
            "_dom_secured_f_00",
            "_dom_secured_f_01",
            "_dom_secured_f_02",
            "_dom_secured_f_03",
            "_dom_securing_a_00",
            "_dom_securing_a_01",
            "_dom_securing_a_02",
            "_dom_securing_a_03",
            "_dom_securing_b_00",
            "_dom_securing_b_01",
            "_dom_securing_b_02",
            "_dom_securing_b_03",
            "_dom_securing_c_00",
            "_dom_securing_c_01",
            "_dom_securing_c_02",
            "_dom_securing_c_03",
            "_dom_securing_d_00",
            "_dom_securing_d_01",
            "_dom_securing_d_02",
            "_dom_securing_d_03",
            "_dom_securing_e_00",
            "_dom_securing_e_01",
            "_dom_securing_e_02",
            "_dom_securing_e_03",
            "_dom_securing_f_00",
            "_dom_securing_f_01",
            "_dom_securing_f_02",
            "_dom_securing_f_03",
            "_dom_start_00",
            "_dom_start_hardcore_00",
            "_dom_they_take_00",
            "_dom_they_take_01",
            "_dom_they_take_02",
            "_dom_we_take_00",
            "_dom_we_take_01",
            "_dom_we_take_02",
            "_draw_00",
            "_draw_01",
            "_drp_ft_start_00",
            "_drp_ft_start_hardcore_00",
            "_drp_lose_00",
            "_drp_lose_01",
            "_drp_lose_02",
            "_drp_lose_03",
            "_drp_losing_00",
            "_drp_losing_01",
            "_drp_start_00",
            "_drp_start_hardcore_00",
            "_drp_they_drop_00",
            "_drp_they_drop_01",
            "_drp_they_drop_death_00",
            "_drp_they_drop_death_01",
            "_drp_we_drop_00",
            "_drp_we_drop_01",
            "_drp_we_drop_death_00",
            "_drp_we_drop_death_01",
            "_drp_win_00",
            "_drp_win_01",
            "_drp_win_02",
            "_drp_win_03",
            "_drp_winning_00",
            "_drp_winning_01",
            "_dty_bomb_active_five_00",
            "_dty_bomb_active_five_01",
            "_dty_bomb_active_four_00",
            "_dty_bomb_active_four_01",
            "_dty_bomb_active_one_00",
            "_dty_bomb_active_one_01",
            "_dty_bomb_active_three_00",
            "_dty_bomb_active_three_01",
            "_dty_bomb_active_two_00",
            "_dty_bomb_active_two_01",
            "_dty_bomb_armed_00",
            "_dty_bomb_armed_01",
            "_dty_bomb_detonated_00",
            "_dty_bomb_detonated_01",
            "_dty_bomb_offline_00",
            "_dty_bomb_offline_01",
            "_dty_bomb_offline_mult_00",
            "_dty_bomb_offline_mult_01",
            "_dty_bomb_online_00",
            "_dty_bomb_online_01",
            "_dty_bomb_primed_00",
            "_dty_bomb_primed_01",
            "_dty_bomb_self_destruct_00",
            "_dty_bomb_self_destruct_01",
            "_dty_bomb_we_armed_00",
            "_dty_bomb_we_armed_01",
            "_dty_bomb_we_detonated_00",
            "_dty_bomb_we_detonated_01",
            "_dty_bomb_we_primed_00",
            "_dty_bomb_we_primed_01",
            "_dty_ft_start_00",
            "_dty_ft_start_hardcore_00",
            "_dty_ft_wiped_00",
            "_dty_ft_wiped_01",
            "_dty_ft_wiped_02",
            "_dty_ft_wiped_03",
            "_dty_ft_wiped_friendly_00",
            "_dty_ft_wiped_friendly_01",
            "_dty_ft_wiped_friendly_02",
            "_dty_ft_wiped_friendly_03",
            "_dty_mode_orders_00",
            "_dty_mode_orders_01",
            "_dty_rad_expand_00",
            "_dty_rad_expand_01",
            "_dty_rad_expand_02",
            "_dty_rad_expand_03",
            "_dty_rad_recede_00",
            "_dty_rad_recede_01",
            "_dty_rad_recede_02",
            "_dty_rad_recede_03",
            "_dty_rad_stage_five_00",
            "_dty_rad_stage_five_01",
            "_dty_rad_stage_five_02",
            "_dty_rad_stage_five_03",
            "_dty_rad_stage_four_00",
            "_dty_rad_stage_four_01",
            "_dty_rad_stage_four_02",
            "_dty_rad_stage_four_03",
            "_dty_rad_stage_one_00",
            "_dty_rad_stage_one_01",
            "_dty_rad_stage_one_02",
            "_dty_rad_stage_one_03",
            "_dty_rad_stage_three_00",
            "_dty_rad_stage_three_01",
            "_dty_rad_stage_three_02",
            "_dty_rad_stage_three_03",
            "_dty_rad_stage_two_00",
            "_dty_rad_stage_two_01",
            "_dty_rad_stage_two_02",
            "_dty_rad_stage_two_03",
            "_dty_respawn_disabled_00",
            "_dty_respawn_disabled_01",
            "_dty_respawn_disabled_02",
            "_dty_respawn_disabled_03",
            "_dty_respawn_enabled_00",
            "_dty_respawn_enabled_01",
            "_dty_respawn_enabled_02",
            "_dty_respawn_enabled_03",
            "_dty_score_50_00",
            "_dty_score_50_01",
            "_dty_score_50_02",
            "_dty_score_50_03",
            "_dty_score_75_00",
            "_dty_score_75_01",
            "_dty_score_75_02",
            "_dty_score_75_03",
            "_dty_start_00",
            "_dty_start_hardcore_00",
            "_dty_supply_drop_incoming_00",
            "_dty_supply_drop_incoming_01",
            "_dty_supply_drop_incoming_02",
            "_dty_supply_drop_incoming_03",
            "_dty_uranium_max_hold_00",
            "_dty_uranium_max_hold_01",
            "_dty_uranium_max_hold_02",
            "_dty_uranium_max_hold_03",
            "_dty_uranium_respawn_00",
            "_dty_uranium_respawn_01",
            "_dty_uranium_respawn_02",
            "_dty_uranium_respawn_03",
            "_dty_uranium_revealed_00",
            "_dty_uranium_revealed_01",
            "_dty_uranium_revealed_02",
            "_dty_uranium_revealed_03",
            "_dty_veh_drop_incoming_00",
            "_dty_veh_drop_incoming_01",
            "_dty_veh_drop_incoming_02",
            "_dty_veh_drop_incoming_03",
            "_dty_veh_earned_00",
            "_dty_veh_earned_01",
            "_dty_veh_earned_02",
            "_dty_veh_earned_03",
            "_dty_veh_spawn_00",
            "_dty_veh_spawn_01",
            "_dty_veh_spawn_02",
            "_dty_veh_spawn_03",
            "_elm_ft_start_00",
            "_elm_ft_start_hardcore_00",
            "_elm_start_00",
            "_elm_start_hardcore_00",
            "_encourage_last_00",
            "_encourage_last_01",
            "_encourage_last_enemy_00",
            "_encourage_last_enemy_01",
            "_encourage_lost_00",
            "_encourage_lost_01",
            "_encourage_win_00",
            "_encourage_win_01",
            "_ffa_ft_start_00",
            "_ffa_ft_start_hardcore_00",
            "_ffa_start_00",
            "_ffa_start_hardcore_00",
            "_fta_drop_zone_approach_00",
            "_fta_drop_zone_approach_01",
            "_fta_drop_zone_approach_02",
            "_fta_drop_zone_approach_03",
            "_fta_drop_zone_over_00",
            "_fta_drop_zone_over_01",
            "_fta_drop_zone_over_02",
            "_fta_drop_zone_over_03",
            "_fta_encourage_last_00",
            "_fta_encourage_last_01",
            "_fta_encourage_last_enemy_00",
            "_fta_encourage_last_enemy_01",
            "_fta_encourage_lost_00",
            "_fta_encourage_lost_01",
            "_fta_encourage_win_00",
            "_fta_encourage_win_01",
            "_fta_generic_boost_00",
            "_fta_generic_boost_01",
            "_fta_generic_boost_02",
            "_fta_generic_boost_03",
            "_fta_generic_boost_04",
            "_fta_losing_00",
            "_fta_losing_01",
            "_fta_losing_02",
            "_fta_losing_03",
            "_fta_mission_fail_00",
            "_fta_mission_fail_01",
            "_fta_mission_fail_02",
            "_fta_mission_fail_03",
            "_fta_mission_success_00",
            "_fta_mission_success_01",
            "_fta_mission_success_02",
            "_fta_mission_success_03",
            "_fta_player_kicked_00",
            "_fta_player_kicked_01",
            "_fta_timesup_00",
            "_fta_timesup_01",
            "_fta_timesup_02",
            "_fta_timesup_03",
            "_fta_winning_00",
            "_fta_winning_01",
            "_fta_winning_02",
            "_fta_winning_03",
            "_ftb_drop_zone_approach_00",
            "_ftb_drop_zone_approach_01",
            "_ftb_drop_zone_approach_02",
            "_ftb_drop_zone_approach_03",
            "_ftb_drop_zone_over_00",
            "_ftb_drop_zone_over_01",
            "_ftb_drop_zone_over_02",
            "_ftb_drop_zone_over_03",
            "_ftb_encourage_last_00",
            "_ftb_encourage_last_01",
            "_ftb_encourage_last_enemy_00",
            "_ftb_encourage_last_enemy_01",
            "_ftb_encourage_lost_00",
            "_ftb_encourage_lost_01",
            "_ftb_encourage_win_00",
            "_ftb_encourage_win_01",
            "_ftb_generic_boost_00",
            "_ftb_generic_boost_01",
            "_ftb_generic_boost_02",
            "_ftb_generic_boost_03",
            "_ftb_generic_boost_04",
            "_ftb_losing_00",
            "_ftb_losing_01",
            "_ftb_losing_02",
            "_ftb_losing_03",
            "_ftb_mission_fail_00",
            "_ftb_mission_fail_01",
            "_ftb_mission_fail_02",
            "_ftb_mission_fail_03",
            "_ftb_mission_success_00",
            "_ftb_mission_success_01",
            "_ftb_mission_success_02",
            "_ftb_mission_success_03",
            "_ftb_player_kicked_00",
            "_ftb_player_kicked_01",
            "_ftb_timesup_00",
            "_ftb_timesup_01",
            "_ftb_timesup_02",
            "_ftb_timesup_03",
            "_ftb_winning_00",
            "_ftb_winning_01",
            "_ftb_winning_02",
            "_ftb_winning_03",
            "_generic_boost_00",
            "_generic_boost_01",
            "_generic_boost_02",
            "_generic_boost_03",
            "_generic_boost_04",
            "_generic_boost_05",
            "_generic_boost_06",
            "_generic_boost_07",
            "_generic_boost_08",
            "_generic_boost_09",
            "_generic_capture_start_00",
            "_generic_capture_start_01",
            "_generic_capture_start_02",
            "_generic_capture_start_03",
            "_generic_defend_start_00",
            "_generic_defend_start_01",
            "_generic_defend_start_02",
            "_generic_defend_start_03",
            "_generic_destroy_start_00",
            "_generic_destroy_start_01",
            "_generic_destroy_start_02",
            "_generic_destroy_start_03",
            "_generic_destroy_start_04",
            "_generic_destroy_start_05",
            "_generic_destroy_start_06",
            "_generic_destroy_start_07",
            "_generic_mode_orders_00",
            "_generic_mode_orders_01",
            "_generic_mode_orders_02",
            "_generic_mode_orders_03",
            "_generic_objective_losing_00",
            "_generic_objective_losing_01",
            "_generic_objective_lost_00",
            "_generic_objective_lost_01",
            "_generic_objective_lost_02",
            "_generic_objective_lost_03",
            "_generic_objective_secured_00",
            "_generic_objective_secured_01",
            "_generic_objective_secured_02",
            "_generic_objective_secured_03",
            "_generic_objective_securing_00",
            "_generic_objective_securing_01",
            "_gg_ft_start_00",
            "_gg_ft_start_hardcore_00",
            "_gg_humiliation_00",
            "_gg_start_00",
            "_gg_start_hardcore_00",
            "_gnf_ft_start_00",
            "_gnf_ft_start_hardcore_00",
            "_gnf_overtime_00",
            "_gnf_overtime_01",
            "_gnf_start_00",
            "_gnf_start_hardcore_00",
            "_halftime_00",
            "_infect_infected_00",
            "_infect_infected_01",
            "_infect_last_life_00",
            "_infect_last_life_01",
            "_infect_last_life_enemy_00",
            "_infect_last_life_enemy_01",
            "_infect_lives_low_00",
            "_infect_lives_low_01",
            "_infect_mission_order_attack_00",
            "_infect_mission_order_attack_01",
            "_infect_mission_order_defend_00",
            "_infect_start_00",
            "_infect_start_hardcore_00",
            "_kc_ft_start_00",
            "_kc_ft_start_hardcore_00",
            "_kc_start_00",
            "_kc_start_hardcore_00",
            "_koth_captured_00",
            "_koth_captured_01",
            "_koth_contested_00",
            "_koth_contested_01",
            "_koth_ft_start_00",
            "_koth_ft_start_hardcore_00",
            "_koth_located_00",
            "_koth_located_01",
            "_koth_lost_00",
            "_koth_lost_01",
            "_koth_online_00",
            "_koth_online_01",
            "_koth_secured_00",
            "_koth_secured_01",
            "_koth_start_00",
            "_koth_start_hardcore_00",
            "_lead_lost_00",
            "_lead_lost_01",
            "_lead_lost_02",
            "_lead_lost_03",
            "_lead_lost_04",
            "_lead_taken_00",
            "_lead_taken_01",
            "_lead_taken_02",
            "_lead_taken_03",
            "_lead_taken_04",
            "_lives_low_00",
            "_lives_low_01",
            "_lives_none_00",
            "_lives_none_01",
            "_losing_00",
            "_losing_01",
            "_losing_02",
            "_losing_03",
            "_mission_fail_00",
            "_mission_fail_01",
            "_mission_fail_02",
            "_mission_fail_03",
            "_mission_fail_04",
            "_mission_fail_05",
            "_mission_success_00",
            "_mission_success_01",
            "_mission_success_02",
            "_mission_success_03",
            "_mission_success_04",
            "_mission_success_05",
            "_oic_ft_start_00",
            "_oic_ft_start_hardcore_00",
            "_oic_start_00",
            "_oic_start_hardcore_00",
            "_overtime_00",
            "_overtime_01",
            "_overtime_02",
            "_player_kicked_00",
            "_player_kicked_01",
            "_prop_hunt_ft_start_00",
            "_prop_hunt_ft_start_hardcore_00",
            "_prop_hunt_last_life_00",
            "_prop_hunt_last_life_01",
            "_prop_hunt_last_life_enemy_00",
            "_prop_hunt_last_life_enemy_01",
            "_prop_hunt_lives_low_00",
            "_prop_hunt_lives_low_01",
            "_prop_hunt_lives_low_enemy_00",
            "_prop_hunt_lives_low_enemy_01",
            "_prop_hunt_start_00",
            "_prop_hunt_start_hardcore_00",
            "_round_win_comeback_00",
            "_round_win_comeback_01",
            "_round_win_streak_3_00",
            "_round_win_streak_3_01",
            "_round_win_streak_4_00",
            "_round_win_streak_4_01",
            "_round_win_streak_5_00",
            "_round_win_streak_5_01",
            "_round_win_streak_6_00",
            "_round_win_streak_6_01",
            "_round_win_streak_7_00",
            "_round_win_streak_7_01",
            "_round_win_streak_8_00",
            "_round_win_streak_8_01",
            "_sat_ft_start_00",
            "_sat_ft_start_hardcore_00",
            "_sat_link_establish_a_00",
            "_sat_link_establish_a_01",
            "_sat_link_establish_a_enemy_00",
            "_sat_link_establish_a_enemy_01",
            "_sat_link_establish_b_00",
            "_sat_link_establish_b_01",
            "_sat_link_establish_b_enemy_00",
            "_sat_link_establish_b_enemy_01",
            "_sat_link_establish_c_00",
            "_sat_link_establish_c_01",
            "_sat_link_establish_c_enemy_00",
            "_sat_link_establish_c_enemy_01",
            "_sat_link_establish_d_00",
            "_sat_link_establish_d_01",
            "_sat_link_establish_d_enemy_00",
            "_sat_link_establish_d_enemy_01",
            "_sat_link_establish_e_00",
            "_sat_link_establish_e_01",
            "_sat_link_establish_e_enemy_00",
            "_sat_link_establish_e_enemy_01",
            "_sat_link_establish_f_00",
            "_sat_link_establish_f_01",
            "_sat_link_establish_f_enemy_00",
            "_sat_link_establish_f_enemy_01",
            "_sat_link_establish_g_00",
            "_sat_link_establish_g_01",
            "_sat_link_establish_g_enemy_00",
            "_sat_link_establish_g_enemy_01",
            "_sat_link_need_pwr_a_00",
            "_sat_link_need_pwr_a_01",
            "_sat_link_need_pwr_b_00",
            "_sat_link_need_pwr_b_01",
            "_sat_link_need_pwr_c_00",
            "_sat_link_need_pwr_c_01",
            "_sat_link_need_pwr_d_00",
            "_sat_link_need_pwr_d_01",
            "_sat_link_need_pwr_e_00",
            "_sat_link_need_pwr_e_01",
            "_sat_link_need_pwr_f_00",
            "_sat_link_need_pwr_f_01",
            "_sat_link_need_pwr_g_00",
            "_sat_link_need_pwr_g_01",
            "_sat_mode_orders_00",
            "_sat_mode_orders_01",
            "_sat_start_00",
            "_sat_start_hardcore_00",
            "_sd_bomb_defuse_00",
            "_sd_bomb_defuse_01",
            "_sd_bomb_defuse_02",
            "_sd_bomb_defuse_03",
            "_sd_bomb_defused_00",
            "_sd_bomb_defused_01",
            "_sd_bomb_defused_02",
            "_sd_bomb_defused_03",
            "_sd_bomb_dropped_00",
            "_sd_bomb_dropped_01",
            "_sd_bomb_dropped_02",
            "_sd_bomb_dropped_03",
            "_sd_bomb_enemy_00",
            "_sd_bomb_enemy_01",
            "_sd_bomb_enemy_02",
            "_sd_bomb_plant_00",
            "_sd_bomb_plant_01",
            "_sd_bomb_plant_02",
            "_sd_bomb_plant_03",
            "_sd_bomb_planted_00",
            "_sd_bomb_planted_01",
            "_sd_bomb_planted_02",
            "_sd_bomb_planted_03",
            "_sd_bomb_planted_04",
            "_sd_bomb_planted_05",
            "_sd_bomb_taken_00",
            "_sd_bomb_taken_01",
            "_sd_bomb_taken_02",
            "_sd_ft_start_00",
            "_sd_ft_start_hardcore_00",
            "_sd_start_00",
            "_sd_start_hardcore_00",
            "_sns_ft_start_00",
            "_sns_ft_start_hardcore_00",
            "_sns_start_00",
            "_sns_start_hardcore_00",
            "_ss_artillery_enemy_00",
            "_ss_artillery_enemy_01",
            "_ss_artillery_enemy_mult_00",
            "_ss_artillery_enemy_mult_01",
            "_ss_artillery_enemy_raise_00",
            "_ss_artillery_enemy_raise_01",
            "_ss_care_enemy_arrive_00",
            "_ss_care_enemy_arrive_01",
            "_ss_care_enemy_arrive_mult_00",
            "_ss_care_enemy_arrive_mult_01",
            "_ss_chop_gun_enemy_arrive_00",
            "_ss_chop_gun_enemy_arrive_01",
            "_ss_chop_gun_enemy_arrive_mult_00",
            "_ss_chop_gun_enemy_arrive_mult_01",
            "_ss_ctrl_missile_enemy_online_00",
            "_ss_ctrl_missile_enemy_online_01",
            "_ss_ctrl_missile_enemy_online_alt_00",
            "_ss_ctrl_missile_enemy_online_alt_01",
            "_ss_ctrl_missile_enemy_online_mult_00",
            "_ss_ctrl_missile_enemy_online_mult_01",
            "_ss_ctrl_missile_enemy_online_mult_alt_00",
            "_ss_ctrl_missile_enemy_online_mult_alt_01",
            "_ss_cuav_enemy_online_00",
            "_ss_cuav_enemy_online_01",
            "_ss_cuav_enemy_online_mult_00",
            "_ss_cuav_enemy_online_mult_01",
            "_ss_gunship_enemy_arrive_00",
            "_ss_gunship_enemy_arrive_01",
            "_ss_gunship_enemy_arrive_mult_00",
            "_ss_gunship_enemy_arrive_mult_01",
            "_ss_hover_jet_enemy_arrive_00",
            "_ss_hover_jet_enemy_arrive_01",
            "_ss_hover_jet_enemy_arrive_mult_00",
            "_ss_hover_jet_enemy_arrive_mult_01",
            "_ss_jet_fighter_enemy_arrive_00",
            "_ss_jet_fighter_enemy_arrive_01",
            "_ss_jet_fighter_enemy_arrive_mult_00",
            "_ss_jet_fighter_enemy_arrive_mult_01",
            "_ss_lgt_chop_enemy_arrive_00",
            "_ss_lgt_chop_enemy_arrive_01",
            "_ss_lgt_chop_enemy_arrive_mult_00",
            "_ss_lgt_chop_enemy_arrive_mult_01",
            "_ss_napalm_enemy_arrive_00",
            "_ss_napalm_enemy_arrive_01",
            "_ss_napalm_enemy_arrive_mult_00",
            "_ss_napalm_enemy_arrive_mult_01",
            "_ss_napalm_enemy_raise_00",
            "_ss_napalm_enemy_raise_01",
            "_ss_rcxd_enemy_online_00",
            "_ss_rcxd_enemy_online_01",
            "_ss_rcxd_enemy_online_mult_00",
            "_ss_rcxd_enemy_online_mult_01",
            "_ss_recon_enemy_arrive_alt_00",
            "_ss_recon_enemy_arrive_alt_01",
            "_ss_recon_enemy_arrive_mult_alt_00",
            "_ss_recon_enemy_arrive_mult_alt_01",
            "_ss_sentry_enemy_online_00",
            "_ss_sentry_enemy_online_01",
            "_ss_sentry_enemy_online_mult_00",
            "_ss_sentry_enemy_online_mult_01",
            "_ss_strafe_enemy_arrive_00",
            "_ss_strafe_enemy_arrive_01",
            "_ss_strafe_enemy_arrive_mult_00",
            "_ss_strafe_enemy_arrive_mult_01",
            "_ss_uav_enemy_arrive_00",
            "_ss_uav_enemy_arrive_01",
            "_ss_uav_enemy_arrive_mult_00",
            "_ss_uav_enemy_arrive_mult_01",
            "_stk_ft_start_00",
            "_stk_ft_start_hardcore_00",
            "_stk_start_00",
            "_stk_start_hardcore_00",
            "_suddendeath_00",
            "_switchingsides_00",
            "_switchingsides_01",
            "_tdm_ft_start_00",
            "_tdm_ft_start_hardcore_00",
            "_tdm_start_00",
            "_tdm_start_hardcore_00",
            "_timesup_00",
            "_timesup_01",
            "_timesup_02",
            "_timesup_03",
            "_vip_exfil_start_attacker_00",
            "_vip_exfil_start_attacker_01",
            "_vip_exfil_start_defender_00",
            "_vip_exfil_start_defender_01",
            "_vip_exfil_start_defender_a_00",
            "_vip_exfil_start_defender_a_01",
            "_vip_exfil_start_defender_b_00",
            "_vip_exfil_start_defender_b_01",
            "_vip_exfil_start_vip_attacker_00",
            "_vip_exfil_start_vip_attacker_01",
            "_vip_ft_start_00",
            "_vip_ft_start_hardcore_00",
            "_vip_mode_orders_attacker_00",
            "_vip_mode_orders_attacker_01",
            "_vip_mode_orders_defender_00",
            "_vip_mode_orders_defender_01",
            "_vip_mode_orders_vip_00",
            "_vip_mode_orders_vip_01",
            "_vip_start_00",
            "_vip_start_hardcore_00",
            "_vip_vip_exfilled_attacker_00",
            "_vip_vip_exfilled_attacker_01",
            "_vip_vip_exfilled_defender_00",
            "_vip_vip_exfilled_defender_01",
            "_vip_vip_exfilled_vip_attacker_00",
            "_vip_vip_exfilled_vip_attacker_01",
            "_vip_vip_killed_attacker_00",
            "_vip_vip_killed_attacker_01",
            "_vip_vip_killed_defender_00",
            "_vip_vip_killed_defender_01",
            "_vip_vip_under_fire_attacker_00",
            "_vip_vip_under_fire_attacker_01",
            "_vip_vip_under_fire_vip_attacker_00",
            "_vip_vip_under_fire_vip_attacker_01",
            "_war_build_momentum_00",
            "_war_build_momentum_01",
            "_war_build_momentum_02",
            "_war_build_momentum_03",
            "_war_ft_start_00",
            "_war_ft_start_hardcore_00",
            "_war_losing_final_00",
            "_war_losing_final_01",
            "_war_losing_final_02",
            "_war_losing_final_03",
            "_war_losing_neutral_00",
            "_war_losing_neutral_01",
            "_war_losing_neutral_02",
            "_war_losing_neutral_03",
            "_war_losing_ours_00",
            "_war_losing_ours_01",
            "_war_losing_ours_02",
            "_war_losing_ours_03",
            "_war_losing_theirs_00",
            "_war_losing_theirs_01",
            "_war_losing_theirs_02",
            "_war_losing_theirs_03",
            "_war_lost_neutral_00",
            "_war_lost_neutral_01",
            "_war_lost_neutral_02",
            "_war_lost_neutral_03",
            "_war_lost_ours_00",
            "_war_lost_ours_01",
            "_war_lost_ours_02",
            "_war_lost_ours_03",
            "_war_lost_theirs_00",
            "_war_lost_theirs_01",
            "_war_lost_theirs_02",
            "_war_lost_theirs_03",
            "_war_mode_orders_00",
            "_war_mode_orders_01",
            "_war_momentum_built_00",
            "_war_momentum_built_01",
            "_war_momentum_built_02",
            "_war_momentum_built_03",
            "_war_round_end_losing_00",
            "_war_round_end_losing_01",
            "_war_round_end_losing_02",
            "_war_round_end_losing_03",
            "_war_round_end_near_draw_00",
            "_war_round_end_near_draw_01",
            "_war_round_end_near_draw_02",
            "_war_round_end_near_draw_03",
            "_war_round_end_near_losing_final_00",
            "_war_round_end_near_losing_final_01",
            "_war_round_end_near_losing_final_02",
            "_war_round_end_near_losing_final_03",
            "_war_round_end_near_winning_00",
            "_war_round_end_near_winning_01",
            "_war_round_end_near_winning_02",
            "_war_round_end_near_winning_03",
            "_war_round_end_near_winning_final_00",
            "_war_round_end_near_winning_final_01",
            "_war_round_end_near_winning_final_02",
            "_war_round_end_near_winning_final_03",
            "_war_start_00",
            "_war_start_hardcore_00",
            "_war_taking_final_00",
            "_war_taking_final_01",
            "_war_taking_final_02",
            "_war_taking_final_03",
            "_war_taking_neutral_00",
            "_war_taking_neutral_01",
            "_war_taking_neutral_02",
            "_war_taking_neutral_03",
            "_war_taking_ours_00",
            "_war_taking_ours_01",
            "_war_taking_ours_02",
            "_war_taking_ours_03",
            "_war_taking_theirs_00",
            "_war_taking_theirs_01",
            "_war_taking_theirs_02",
            "_war_taking_theirs_03",
            "_war_zone_available_was_neutral_00",
            "_war_zone_available_was_neutral_01",
            "_war_zone_available_was_neutral_02",
            "_war_zone_available_was_neutral_03",
            "_war_zone_available_was_ours_00",
            "_war_zone_available_was_ours_01",
            "_war_zone_available_was_ours_02",
            "_war_zone_available_was_ours_03",
            "_war_zone_available_was_theirs_00",
            "_war_zone_available_was_theirs_01",
            "_war_zone_available_was_theirs_02",
            "_war_zone_available_was_theirs_03",
            "_winning_00",
            "_winning_01",
            "_winning_02",
            "_winning_03",
            // Operator Voicelines
            "_boost_draw_00",
            "_boost_draw_01",
            "_boost_draw_02",
            "_boost_draw_03",
            "_boost_loss_00",
            "_boost_loss_01",
            "_boost_loss_02",
            "_boost_loss_03",
            "_boost_win_00",
            "_boost_win_01",
            "_boost_win_02",
            "_boost_win_03",
            "_callout_base_acknow_00",
            "_callout_base_acknow_01",
            "_callout_base_acknow_02",
            "_callout_base_acknow_03",
            "_callout_base_cancel_00",
            "_callout_base_cancel_01",
            "_callout_base_cancel_02",
            "_callout_base_cancel_03",
            "_callout_base_celebrat_1_00",
            "_callout_base_form_up_00",
            "_callout_base_form_up_01",
            "_callout_base_form_up_02",
            "_callout_base_form_up_03",
            "_callout_base_good_job_00",
            "_callout_base_good_job_01",
            "_callout_base_good_job_02",
            "_callout_base_good_job_03",
            "_callout_base_need_assist_00",
            "_callout_base_need_assist_01",
            "_callout_base_need_assist_02",
            "_callout_base_need_assist_03",
            "_callout_base_need_ride_00",
            "_callout_base_need_ride_01",
            "_callout_base_need_ride_02",
            "_callout_base_need_ride_03",
            "_callout_base_negative_00",
            "_callout_base_negative_01",
            "_callout_base_negative_02",
            "_callout_base_negative_03",
            "_callout_base_shout_out_1_00",
            "_callout_base_social_hello_00",
            "_callout_base_social_hello_01",
            "_callout_base_social_hello_02",
            "_callout_base_social_hello_03",
            "_callout_base_social_thank_00",
            "_callout_base_social_thank_01",
            "_callout_base_social_thank_02",
            "_callout_base_social_thank_03",
            "_callout_base_sorry_00",
            "_callout_base_sorry_01",
            "_callout_base_sorry_02",
            "_callout_base_sorry_03",
            "_callout_base_taunt_1_00",
            "_congrat_lrg_00",
            "_congrat_lrg_01",
            "_congrat_lrg_02",
            "_congrat_lrg_03",
            "_congrat_sml_00",
            "_congrat_sml_01",
            "_congrat_sml_02",
            "_congrat_sml_03",
            "_eq_ammo_pack_dstr_00",
            "_eq_ammo_pack_dstr_01",
            "_eq_ammo_pack_dstr_02",
            "_eq_ammo_pack_dstr_03",
            "_eq_ammo_pack_fail_00",
            "_eq_ammo_pack_fail_01",
            "_eq_ammo_pack_fail_02",
            "_eq_ammo_pack_fail_03",
            "_eq_ammo_pack_threat_00",
            "_eq_ammo_pack_threat_01",
            "_eq_ammo_pack_threat_02",
            "_eq_ammo_pack_threat_03",
            "_eq_ammo_pack_use_00",
            "_eq_ammo_pack_use_01",
            "_eq_ammo_pack_use_02",
            "_eq_ammo_pack_use_03",
            "_eq_concussion_threat_00",
            "_eq_concussion_threat_01",
            "_eq_concussion_threat_02",
            "_eq_concussion_threat_03",
            "_eq_concussion_use_00",
            "_eq_concussion_use_01",
            "_eq_concussion_use_02",
            "_eq_concussion_use_03",
            "_eq_cover_dstr_00",
            "_eq_cover_dstr_01",
            "_eq_cover_dstr_02",
            "_eq_cover_dstr_03",
            "_eq_cover_fail_00",
            "_eq_cover_fail_01",
            "_eq_cover_fail_02",
            "_eq_cover_fail_03",
            "_eq_cover_threat_00",
            "_eq_cover_threat_01",
            "_eq_cover_threat_02",
            "_eq_cover_threat_03",
            "_eq_cover_use_00",
            "_eq_cover_use_01",
            "_eq_cover_use_02",
            "_eq_cover_use_03",
            "_eq_flash_threat_00",
            "_eq_flash_threat_01",
            "_eq_flash_threat_02",
            "_eq_flash_threat_03",
            "_eq_flash_use_00",
            "_eq_flash_use_01",
            "_eq_flash_use_02",
            "_eq_flash_use_03",
            "_eq_frag_threat_00",
            "_eq_frag_threat_01",
            "_eq_frag_threat_02",
            "_eq_frag_threat_03",
            "_eq_frag_use_00",
            "_eq_frag_use_01",
            "_eq_frag_use_02",
            "_eq_frag_use_03",
            "_eq_gas_dstr_00",
            "_eq_gas_dstr_01",
            "_eq_gas_dstr_02",
            "_eq_gas_dstr_03",
            "_eq_gas_fail_00",
            "_eq_gas_fail_01",
            "_eq_gas_fail_02",
            "_eq_gas_fail_03",
            "_eq_gas_threat_00",
            "_eq_gas_threat_01",
            "_eq_gas_threat_02",
            "_eq_gas_threat_03",
            "_eq_gas_use_00",
            "_eq_gas_use_01",
            "_eq_gas_use_02",
            "_eq_gas_use_03",
            "_eq_jammer_dstr_00",
            "_eq_jammer_dstr_01",
            "_eq_jammer_dstr_02",
            "_eq_jammer_dstr_03",
            "_eq_jammer_fail_00",
            "_eq_jammer_fail_01",
            "_eq_jammer_fail_02",
            "_eq_jammer_fail_03",
            "_eq_jammer_threat_00",
            "_eq_jammer_threat_01",
            "_eq_jammer_threat_02",
            "_eq_jammer_threat_03",
            "_eq_jammer_use_00",
            "_eq_jammer_use_01",
            "_eq_jammer_use_02",
            "_eq_jammer_use_03",
            "_eq_landmine_dstr_00",
            "_eq_landmine_dstr_01",
            "_eq_landmine_dstr_02",
            "_eq_landmine_dstr_03",
            "_eq_landmine_fail_00",
            "_eq_landmine_fail_01",
            "_eq_landmine_fail_02",
            "_eq_landmine_fail_03",
            "_eq_landmine_threat_00",
            "_eq_landmine_threat_01",
            "_eq_landmine_threat_02",
            "_eq_landmine_threat_03",
            "_eq_landmine_use_00",
            "_eq_landmine_use_01",
            "_eq_landmine_use_02",
            "_eq_landmine_use_03",
            "_eq_listen_dstr_00",
            "_eq_listen_dstr_01",
            "_eq_listen_dstr_02",
            "_eq_listen_dstr_03",
            "_eq_listen_fail_00",
            "_eq_listen_fail_01",
            "_eq_listen_fail_02",
            "_eq_listen_fail_03",
            "_eq_listen_threat_00",
            "_eq_listen_threat_01",
            "_eq_listen_threat_02",
            "_eq_listen_threat_03",
            "_eq_listen_use_00",
            "_eq_listen_use_01",
            "_eq_listen_use_02",
            "_eq_listen_use_03",
            "_eq_missile_trrt_dstr_00",
            "_eq_missile_trrt_dstr_01",
            "_eq_missile_trrt_dstr_02",
            "_eq_missile_trrt_dstr_03",
            "_eq_missile_trrt_threat_00",
            "_eq_missile_trrt_threat_01",
            "_eq_missile_trrt_threat_02",
            "_eq_missile_trrt_threat_03",
            "_eq_missile_trrt_use_00",
            "_eq_missile_trrt_use_01",
            "_eq_missile_trrt_use_02",
            "_eq_missile_trrt_use_03",
            "_eq_molo_threat_00",
            "_eq_molo_threat_01",
            "_eq_molo_threat_02",
            "_eq_molo_threat_03",
            "_eq_molo_use_00",
            "_eq_molo_use_01",
            "_eq_molo_use_02",
            "_eq_molo_use_03",
            "_eq_nightingale_threat_00",
            "_eq_nightingale_threat_01",
            "_eq_nightingale_threat_02",
            "_eq_nightingale_threat_03",
            "_eq_nightingale_use_00",
            "_eq_nightingale_use_01",
            "_eq_nightingale_use_02",
            "_eq_nightingale_use_03",
            "_eq_satchel_threat_00",
            "_eq_satchel_threat_01",
            "_eq_satchel_threat_02",
            "_eq_satchel_threat_03",
            "_eq_satchel_use_00",
            "_eq_satchel_use_01",
            "_eq_satchel_use_02",
            "_eq_satchel_use_03",
            "_eq_semtex_stuck_00",
            "_eq_semtex_stuck_01",
            "_eq_semtex_stuck_02",
            "_eq_semtex_stuck_03",
            "_eq_semtex_threat_00",
            "_eq_semtex_threat_01",
            "_eq_semtex_threat_02",
            "_eq_semtex_threat_03",
            "_eq_semtex_use_00",
            "_eq_semtex_use_01",
            "_eq_semtex_use_02",
            "_eq_semtex_use_03",
            "_eq_smoke_threat_00",
            "_eq_smoke_threat_01",
            "_eq_smoke_threat_02",
            "_eq_smoke_threat_03",
            "_eq_smoke_use_00",
            "_eq_smoke_use_01",
            "_eq_smoke_use_02",
            "_eq_smoke_use_03",
            "_eq_stim_shot_threat_00",
            "_eq_stim_shot_threat_01",
            "_eq_stim_shot_threat_02",
            "_eq_stim_shot_threat_03",
            "_eq_throw_knife_use_00",
            "_eq_throw_knife_use_01",
            "_eq_throw_knife_use_02",
            "_eq_throw_knife_use_03",
            "_eq_trophy_dstr_00",
            "_eq_trophy_dstr_01",
            "_eq_trophy_dstr_02",
            "_eq_trophy_dstr_03",
            "_eq_trophy_threat_00",
            "_eq_trophy_threat_01",
            "_eq_trophy_threat_02",
            "_eq_trophy_threat_03",
            "_eq_trophy_use_00",
            "_eq_trophy_use_01",
            "_eq_trophy_use_02",
            "_eq_trophy_use_03",
            "_execution_00",
            "_exert_blind_00",
            "_exert_blind_01",
            "_exert_blind_02",
            "_exert_blind_03",
            "_exert_blind_04",
            "_exert_bludgeoned_00",
            "_exert_bludgeoned_01",
            "_exert_bludgeoned_02",
            "_exert_bludgeoned_03",
            "_exert_bludgeoned_04",
            "_exert_bludgeoned_05",
            "_exert_bludgeoned_06",
            "_exert_breath_hurt_00",
            "_exert_breath_hurt_01",
            "_exert_breath_hurt_02",
            "_exert_breath_hurt_03",
            "_exert_bullet_pain_00",
            "_exert_bullet_pain_01",
            "_exert_bullet_pain_02",
            "_exert_bullet_pain_03",
            "_exert_bullet_pain_04",
            "_exert_bullet_pain_05",
            "_exert_bullet_pain_06",
            "_exert_bullet_pain_07",
            "_exert_bullet_pain_08",
            "_exert_bullet_pain_09",
            "_exert_bullet_pain_10",
            "_exert_bullet_pain_11",
            "_exert_bullet_pain_12",
            "_exert_bullet_pain_13",
            "_exert_bullet_pain_14",
            "_exert_bullet_pain_15",
            "_exert_bullet_pain_vocal_00",
            "_exert_bullet_pain_vocal_01",
            "_exert_bullet_pain_vocal_02",
            "_exert_bullet_pain_vocal_03",
            "_exert_bullet_pain_vocal_04",
            "_exert_bullet_pain_vocal_05",
            "_exert_burn_dead_00",
            "_exert_burn_dead_01",
            "_exert_burn_dead_02",
            "_exert_burn_dmg_00",
            "_exert_burn_dmg_01",
            "_exert_burn_dmg_02",
            "_exert_burn_dmg_03",
            "_exert_burn_dmg_04",
            "_exert_burn_dmg_05",
            "_exert_burn_dmg_06",
            "_exert_burn_dmg_07",
            "_exert_concuss_00",
            "_exert_concuss_01",
            "_exert_concuss_02",
            "_exert_concuss_03",
            "_exert_concuss_04",
            "_exert_death_00",
            "_exert_death_01",
            "_exert_death_02",
            "_exert_death_03",
            "_exert_death_04",
            "_exert_death_05",
            "_exert_death_06",
            "_exert_death_07",
            "_exert_death_08",
            "_exert_death_09",
            "_exert_death_10",
            "_exert_death_11",
            "_exert_death_12",
            "_exert_death_13",
            "_exert_death_fall_00",
            "_exert_death_fall_01",
            "_exert_death_fall_02",
            "_exert_death_throat_cut_00",
            "_exert_death_throat_cut_01",
            "_exert_death_throat_cut_02",
            "_exert_death_veh_fly_00",
            "_exert_death_veh_fly_01",
            "_exert_death_veh_fly_02",
            "_exert_death_veh_fly_03",
            "_exert_death_veh_fly_04",
            "_exert_death_veh_hit_00",
            "_exert_death_veh_hit_01",
            "_exert_death_veh_hit_02",
            "_exert_death_veh_hit_03",
            "_exert_death_veh_hit_04",
            "_exert_death_veh_under_00",
            "_exert_death_veh_under_01",
            "_exert_death_veh_under_02",
            "_exert_death_veh_under_03",
            "_exert_death_veh_under_04",
            "_exert_electro_00",
            "_exert_electro_01",
            "_exert_electro_02",
            "_exert_electro_03",
            "_exert_explo_dead_00",
            "_exert_explo_dead_01",
            "_exert_explo_dead_02",
            "_exert_explo_dead_03",
            "_exert_gas_cough_00",
            "_exert_gas_cough_01",
            "_exert_gas_cough_02",
            "_exert_gas_cough_03",
            "_exert_gas_cough_04",
            "_exert_gas_cough_05",
            "_exert_gas_death_00",
            "_exert_gas_death_01",
            "_exert_gas_death_02",
            "_exert_gas_death_03",
            "_exert_gas_gag_00",
            "_exert_gas_gag_01",
            "_exert_gas_gag_02",
            "_exert_gas_gag_03",
            "_exert_gas_gag_04",
            "_exert_gas_gag_05",
            "_exert_gas_gasp_00",
            "_exert_gas_gasp_01",
            "_exert_gas_gasp_02",
            "_exert_gas_gasp_03",
            "_exert_gas_gasp_04",
            "_exert_land_light_00",
            "_exert_land_light_01",
            "_exert_land_light_02",
            "_exert_land_light_03",
            "_exert_land_light_04",
            "_exert_land_light_05",
            "_exert_land_light_06",
            "_exert_land_light_07",
            "_exert_mant_heavy_00",
            "_exert_mant_heavy_01",
            "_exert_mant_heavy_02",
            "_exert_mant_heavy_03",
            "_exert_mant_heavy_04",
            "_exert_mant_heavy_05",
            "_exert_mant_heavy_06",
            "_exert_mant_light_00",
            "_exert_mant_light_01",
            "_exert_mant_light_02",
            "_exert_mant_light_03",
            "_exert_mant_light_04",
            "_exert_mant_light_05",
            "_exert_mant_light_06",
            "_exert_mant_light_07",
            "_exert_melee_heavy_00",
            "_exert_melee_heavy_01",
            "_exert_melee_heavy_02",
            "_exert_melee_heavy_03",
            "_exert_melee_heavy_04",
            "_exert_melee_heavy_05",
            "_exert_melee_heavy_06",
            "_exert_melee_heavy_07",
            "_exert_melee_light_00",
            "_exert_melee_light_01",
            "_exert_melee_light_02",
            "_exert_melee_light_03",
            "_exert_melee_light_04",
            "_exert_melee_light_05",
            "_exert_melee_light_06",
            "_exert_melee_light_07",
            "_exert_punch_give_00",
            "_exert_punch_give_01",
            "_exert_punch_give_02",
            "_exert_punch_give_03",
            "_exert_punch_give_04",
            "_exert_punch_give_05",
            "_exert_punch_give_06",
            "_exert_punch_give_07",
            "_exert_punch_take_00",
            "_exert_punch_take_01",
            "_exert_punch_take_02",
            "_exert_punch_take_03",
            "_exert_punch_take_04",
            "_exert_punch_take_05",
            "_exert_punch_take_06",
            "_exert_punch_take_07",
            "_exert_razor_wire_00",
            "_exert_razor_wire_01",
            "_exert_razor_wire_02",
            "_exert_razor_wire_03",
            "_exert_razor_wire_04",
            "_exert_razor_wire_05",
            "_exert_self_heal_00",
            "_exert_self_heal_01",
            "_exert_self_heal_02",
            "_exert_self_heal_03",
            "_exert_sniper_exhale_00",
            "_exert_sniper_exhale_01",
            "_exert_sniper_exhale_02",
            "_exert_sniper_exhale_03",
            "_exert_sniper_gasp_00",
            "_exert_sniper_gasp_01",
            "_exert_sniper_gasp_02",
            "_exert_sniper_gasp_03",
            "_exert_sniper_hold_00",
            "_exert_sniper_hold_01",
            "_exert_sniper_hold_02",
            "_exert_sniper_hold_03",
            "_exert_stabbed_00",
            "_exert_stabbed_01",
            "_exert_stabbed_02",
            "_exert_stabbed_03",
            "_exert_stabbed_04",
            "_exert_stabbed_05",
            "_exert_stabbed_06",
            "_exert_stabbed_07",
            "_exert_suppressed_00",
            "_exert_suppressed_01",
            "_exert_suppressed_02",
            "_exert_suppressed_03",
            "_exert_suppressed_04",
            "_exert_throw_00",
            "_exert_throw_01",
            "_exert_throw_02",
            "_exert_throw_03",
            "_exert_throw_04",
            "_exert_throw_05",
            "_exert_underwater_air_low_00",
            "_exert_underwater_air_low_01",
            "_exert_underwater_air_low_02",
            "_exert_underwater_air_low_03",
            "_exert_underwater_air_low_04",
            "_exert_underwater_air_low_05",
            "_exert_underwater_air_low_06",
            "_exert_underwater_air_low_07",
            "_exert_underwater_drown_00",
            "_exert_underwater_drown_01",
            "_exert_underwater_drown_02",
            "_exert_underwater_drown_03",
            "_exert_underwater_emerge_breath_00",
            "_exert_underwater_emerge_breath_01",
            "_exert_underwater_emerge_breath_02",
            "_exert_underwater_emerge_breath_03",
            "_exert_underwater_emerge_breath_04",
            "_exert_underwater_emerge_gasp_00",
            "_exert_underwater_emerge_gasp_01",
            "_exert_underwater_emerge_gasp_02",
            "_exert_underwater_emerge_gasp_03",
            "_exert_underwater_emerge_gasp_04",
            "_exert_underwater_pain_00",
            "_exert_underwater_pain_01",
            "_exert_underwater_pain_02",
            "_exert_underwater_pain_03",
            "_exert_underwater_pain_04",
            "_exert_underwater_pain_05",
            "_exert_underwater_pain_06",
            "_exert_underwater_pain_07",
            "_kill_generic_infantry_00",
            "_kill_generic_infantry_01",
            "_kill_generic_infantry_02",
            "_kill_generic_infantry_03",
            "_kill_generic_infantry_04",
            "_kill_generic_infantry_05",
            "_kill_generic_infantry_06",
            "_kill_generic_infantry_07",
            "_kill_generic_infantry_08",
            "_kill_generic_infantry_09",
            "_kill_generic_infantry_10",
            "_kill_generic_infantry_11",
            "_kill_generic_infantry_12",
            "_kill_generic_infantry_13",
            "_kill_generic_infantry_14",
            "_kill_generic_infantry_15",
            "_kill_generic_infantry_fm_00",
            "_kill_generic_infantry_fm_01",
            "_kill_generic_infantry_fm_02",
            "_kill_generic_infantry_fm_03",
            "_kill_generic_infantry_fm_04",
            "_kill_generic_infantry_fm_05",
            "_kill_generic_infantry_fm_06",
            "_kill_generic_infantry_fm_07",
            "_kill_generic_infantry_ml_00",
            "_kill_generic_infantry_ml_01",
            "_kill_generic_infantry_ml_02",
            "_kill_generic_infantry_ml_03",
            "_kill_generic_infantry_ml_04",
            "_kill_generic_infantry_ml_05",
            "_kill_generic_infantry_ml_06",
            "_kill_generic_infantry_ml_07",
            "_kill_sniper_00",
            "_kill_sniper_01",
            "_kill_sniper_02",
            "_kill_sniper_03",
            "_kill_team_00",
            "_kill_team_01",
            "_kill_team_02",
            "_kill_team_03",
            "_kill_team_react_00",
            "_kill_team_react_01",
            "_kill_team_react_02",
            "_kill_team_react_03",
            "_kill_team_warn_00",
            "_kill_team_warn_01",
            "_kill_team_warn_02",
            "_kill_team_warn_03",
            "_menu_select_00",
            "_menu_select_01",
            "_menu_select_02",
            "_menu_select_03",
            "_objective_cap_start_00",
            "_objective_cap_start_01",
            "_objective_cap_start_02",
            "_objective_cap_start_03",
            "_objective_cap_start_04",
            "_objective_cap_start_05",
            "_objective_captured_00",
            "_objective_captured_01",
            "_objective_captured_02",
            "_objective_captured_03",
            "_objective_captured_04",
            "_objective_captured_05",
            "_ping_danger_000_00",
            "_ping_danger_000_01",
            "_ping_danger_015_00",
            "_ping_danger_015_01",
            "_ping_danger_030_00",
            "_ping_danger_030_01",
            "_ping_danger_045_00",
            "_ping_danger_045_01",
            "_ping_danger_060_00",
            "_ping_danger_060_01",
            "_ping_danger_075_00",
            "_ping_danger_075_01",
            "_ping_danger_090_00",
            "_ping_danger_090_01",
            "_ping_danger_105_00",
            "_ping_danger_105_01",
            "_ping_danger_120_00",
            "_ping_danger_120_01",
            "_ping_danger_135_00",
            "_ping_danger_135_01",
            "_ping_danger_150_00",
            "_ping_danger_150_01",
            "_ping_danger_165_00",
            "_ping_danger_165_01",
            "_ping_danger_180_00",
            "_ping_danger_180_01",
            "_ping_danger_195_00",
            "_ping_danger_195_01",
            "_ping_danger_210_00",
            "_ping_danger_210_01",
            "_ping_danger_225_00",
            "_ping_danger_225_01",
            "_ping_danger_240_00",
            "_ping_danger_240_01",
            "_ping_danger_255_00",
            "_ping_danger_255_01",
            "_ping_danger_270_00",
            "_ping_danger_270_01",
            "_ping_danger_285_00",
            "_ping_danger_285_01",
            "_ping_danger_300_00",
            "_ping_danger_300_01",
            "_ping_danger_315_00",
            "_ping_danger_315_01",
            "_ping_danger_330_00",
            "_ping_danger_330_01",
            "_ping_danger_345_00",
            "_ping_danger_345_01",
            "_ping_danger_ack_00",
            "_ping_danger_ack_01",
            "_ping_danger_ack_02",
            "_ping_danger_ack_03",
            "_ping_danger_ack_04",
            "_ping_danger_ack_05",
            "_ping_danger_ack_06",
            "_ping_danger_ack_07",
            "_ping_enemy_gear_ack_00",
            "_ping_enemy_gear_ack_01",
            "_ping_enemy_gear_ack_02",
            "_ping_enemy_gear_ack_03",
            "_ping_enemy_gear_ack_04",
            "_ping_enemy_gear_ack_05",
            "_ping_enemy_gear_lethal_00",
            "_ping_enemy_gear_lethal_01",
            "_ping_enemy_gear_lethal_02",
            "_ping_enemy_gear_lethal_03",
            "_ping_enemy_gear_lethal_landmine_00",
            "_ping_enemy_gear_lethal_landmine_01",
            "_ping_enemy_gear_tactical_00",
            "_ping_enemy_gear_tactical_01",
            "_ping_enemy_gear_tactical_02",
            "_ping_enemy_gear_tactical_03",
            "_ping_enemy_gear_tactical_ammo_pack_00",
            "_ping_enemy_gear_tactical_ammo_pack_01",
            "_ping_enemy_gear_tactical_cover_00",
            "_ping_enemy_gear_tactical_cover_01",
            "_ping_enemy_gear_tactical_gas_00",
            "_ping_enemy_gear_tactical_gas_01",
            "_ping_enemy_gear_tactical_jammer_00",
            "_ping_enemy_gear_tactical_jammer_01",
            "_ping_enemy_gear_tactical_listen_00",
            "_ping_enemy_gear_tactical_listen_01",
            "_ping_enemy_gear_tactical_missile_trrt_00",
            "_ping_enemy_gear_tactical_missile_trrt_01",
            "_ping_enemy_gear_tactical_trophy_00",
            "_ping_enemy_gear_tactical_trophy_01",
            "_ping_enemy_veh_00",
            "_ping_enemy_veh_01",
            "_ping_gear_lethal_00",
            "_ping_gear_lethal_01",
            "_ping_gear_lethal_02",
            "_ping_gear_lethal_03",
            "_ping_gear_lethal_landmine_00",
            "_ping_gear_lethal_landmine_01",
            "_ping_gear_tactical_00",
            "_ping_gear_tactical_01",
            "_ping_gear_tactical_02",
            "_ping_gear_tactical_03",
            "_ping_gear_tactical_ammo_pack_00",
            "_ping_gear_tactical_ammo_pack_01",
            "_ping_gear_tactical_cover_00",
            "_ping_gear_tactical_cover_01",
            "_ping_gear_tactical_gas_00",
            "_ping_gear_tactical_gas_01",
            "_ping_gear_tactical_jammer_00",
            "_ping_gear_tactical_jammer_01",
            "_ping_gear_tactical_listen_00",
            "_ping_gear_tactical_listen_01",
            "_ping_gear_tactical_missile_trrt_00",
            "_ping_gear_tactical_missile_trrt_01",
            "_ping_gear_tactical_trophy_00",
            "_ping_gear_tactical_trophy_01",
            "_ping_item_00",
            "_ping_item_01",
            "_ping_item_02",
            "_ping_item_03",
            "_ping_item_ack_00",
            "_ping_item_ack_01",
            "_ping_item_ack_02",
            "_ping_item_ack_03",
            "_ping_item_ack_04",
            "_ping_item_ack_05",
            "_ping_item_ack_06",
            "_ping_item_ack_07",
            "_ping_item_ammo_00",
            "_ping_item_ammo_01",
            "_ping_item_ammo_02",
            "_ping_item_ammo_03",
            "_ping_item_ammo_assault_00",
            "_ping_item_ammo_assault_01",
            "_ping_item_ammo_lrg_cal_00",
            "_ping_item_ammo_lrg_cal_01",
            "_ping_item_ammo_shotgun_00",
            "_ping_item_ammo_shotgun_01",
            "_ping_item_ammo_sml_cal_00",
            "_ping_item_ammo_sml_cal_01",
            "_ping_item_ammo_sniper_00",
            "_ping_item_ammo_sniper_01",
            "_ping_item_ammo_special_00",
            "_ping_item_ammo_special_01",
            "_ping_item_armor_00",
            "_ping_item_armor_01",
            "_ping_item_armor_02",
            "_ping_item_armor_03",
            "_ping_item_armor_plate_00",
            "_ping_item_armor_plate_01",
            "_ping_item_armor_satchel_00",
            "_ping_item_armor_satchel_01",
            "_ping_item_attach_00",
            "_ping_item_attach_01",
            "_ping_item_attach_02",
            "_ping_item_attach_03",
            "_ping_item_bag_generic_00",
            "_ping_item_bag_generic_01",
            "_ping_item_container_00",
            "_ping_item_container_01",
            "_ping_item_first_aid_00",
            "_ping_item_first_aid_01",
            "_ping_item_gun_00",
            "_ping_item_gun_01",
            "_ping_item_gun_02",
            "_ping_item_gun_03",
            "_ping_item_gun_ar_00",
            "_ping_item_gun_ar_01",
            "_ping_item_gun_handgun_00",
            "_ping_item_gun_handgun_01",
            "_ping_item_gun_launcher_00",
            "_ping_item_gun_launcher_01",
            "_ping_item_gun_lmg_00",
            "_ping_item_gun_lmg_01",
            "_ping_item_gun_shotgun_00",
            "_ping_item_gun_shotgun_01",
            "_ping_item_gun_smg_00",
            "_ping_item_gun_smg_01",
            "_ping_item_gun_sniper_00",
            "_ping_item_gun_sniper_01",
            "_ping_item_lethal_00",
            "_ping_item_lethal_01",
            "_ping_item_lethal_02",
            "_ping_item_lethal_03",
            "_ping_item_lethal_frag_00",
            "_ping_item_lethal_frag_01",
            "_ping_item_lethal_molo_00",
            "_ping_item_lethal_molo_01",
            "_ping_item_lethal_satchel_00",
            "_ping_item_lethal_satchel_01",
            "_ping_item_lethal_semtex_00",
            "_ping_item_lethal_semtex_01",
            "_ping_item_lethal_throw_knife_00",
            "_ping_item_lethal_throw_knife_01",
            "_ping_item_melee_00",
            "_ping_item_melee_01",
            "_ping_item_rad_vest_00",
            "_ping_item_rad_vest_01",
            "_ping_item_self_rev_00",
            "_ping_item_self_rev_01",
            "_ping_item_ss_artillery_00",
            "_ping_item_ss_artillery_01",
            "_ping_item_ss_bow_00",
            "_ping_item_ss_bow_01",
            "_ping_item_ss_care_00",
            "_ping_item_ss_care_01",
            "_ping_item_ss_chop_gun_00",
            "_ping_item_ss_chop_gun_01",
            "_ping_item_ss_ctrl_missile_00",
            "_ping_item_ss_ctrl_missile_01",
            "_ping_item_ss_cuav_00",
            "_ping_item_ss_cuav_01",
            "_ping_item_ss_death_machine_00",
            "_ping_item_ss_death_machine_01",
            "_ping_item_ss_flamethrower_00",
            "_ping_item_ss_flamethrower_01",
            "_ping_item_ss_generic_00",
            "_ping_item_ss_generic_01",
            "_ping_item_ss_grenade_launcher_00",
            "_ping_item_ss_grenade_launcher_01",
            "_ping_item_ss_gunship_00",
            "_ping_item_ss_gunship_01",
            "_ping_item_ss_hand_cannon_00",
            "_ping_item_ss_hand_cannon_01",
            "_ping_item_ss_hover_jet_00",
            "_ping_item_ss_hover_jet_01",
            "_ping_item_ss_jet_fighter_00",
            "_ping_item_ss_jet_fighter_01",
            "_ping_item_ss_lgt_chop_00",
            "_ping_item_ss_lgt_chop_01",
            "_ping_item_ss_napalm_00",
            "_ping_item_ss_napalm_01",
            "_ping_item_ss_rcxd_00",
            "_ping_item_ss_rcxd_01",
            "_ping_item_ss_recon_00",
            "_ping_item_ss_recon_01",
            "_ping_item_ss_sentry_00",
            "_ping_item_ss_sentry_01",
            "_ping_item_ss_strafe_00",
            "_ping_item_ss_strafe_01",
            "_ping_item_ss_uav_00",
            "_ping_item_ss_uav_01",
            "_ping_item_tactical_00",
            "_ping_item_tactical_01",
            "_ping_item_tactical_02",
            "_ping_item_tactical_03",
            "_ping_item_tactical_concussion_00",
            "_ping_item_tactical_concussion_01",
            "_ping_item_tactical_flash_00",
            "_ping_item_tactical_flash_01",
            "_ping_item_tactical_nightingale_00",
            "_ping_item_tactical_nightingale_01",
            "_ping_item_tactical_smoke_00",
            "_ping_item_tactical_smoke_01",
            "_ping_item_tactical_stim_shot_00",
            "_ping_item_tactical_stim_shot_01",
            "_ping_item_uranium_00",
            "_ping_item_uranium_01",
            "_ping_item_uranium_pouch_00",
            "_ping_item_uranium_pouch_01",
            "_ping_item_veh_00",
            "_ping_item_veh_01",
            "_ping_item_veh_bike_00",
            "_ping_item_veh_bike_01",
            "_ping_item_veh_combat_00",
            "_ping_item_veh_combat_01",
            "_ping_item_veh_fav_00",
            "_ping_item_veh_fav_01",
            "_ping_item_veh_gunboat_00",
            "_ping_item_veh_gunboat_01",
            "_ping_item_veh_hind_00",
            "_ping_item_veh_hind_01",
            "_ping_item_veh_snow_00",
            "_ping_item_veh_snow_01",
            "_ping_item_veh_tank_00",
            "_ping_item_veh_tank_01",
            "_ping_item_veh_wakerun_00",
            "_ping_item_veh_wakerun_01",
            "_ping_item_wpn_cache_00",
            "_ping_item_wpn_cache_01",
            "_ping_location_00",
            "_ping_location_01",
            "_ping_location_02",
            "_ping_location_03",
            "_ping_location_ack_00",
            "_ping_location_ack_01",
            "_ping_location_ack_02",
            "_ping_location_ack_03",
            "_ping_need_item_ammo_00",
            "_ping_need_item_ammo_01",
            "_ping_need_item_ammo_assault_00",
            "_ping_need_item_ammo_assault_01",
            "_ping_need_item_ammo_lrg_cal_00",
            "_ping_need_item_ammo_lrg_cal_01",
            "_ping_need_item_ammo_shotgun_00",
            "_ping_need_item_ammo_shotgun_01",
            "_ping_need_item_ammo_sml_cal_00",
            "_ping_need_item_ammo_sml_cal_01",
            "_ping_need_item_ammo_sniper_00",
            "_ping_need_item_ammo_sniper_01",
            "_ping_need_item_ammo_special_00",
            "_ping_need_item_ammo_special_01",
            "_ping_need_item_armor_00",
            "_ping_need_item_armor_01",
            "_ping_need_item_first_aid_00",
            "_ping_need_item_first_aid_01",
            "_ping_objective_00",
            "_ping_objective_01",
            "_ping_objective_02",
            "_ping_objective_03",
            "_ping_objective_ack_00",
            "_ping_objective_ack_01",
            "_ping_objective_ack_02",
            "_ping_objective_ack_03",
            "_ping_objective_bomb_00",
            "_ping_objective_bomb_01",
            "_ping_objective_bomb_02",
            "_ping_objective_bomb_03",
            "_ping_objective_bomb_site_00",
            "_ping_objective_bomb_site_01",
            "_ping_objective_bomb_site_02",
            "_ping_objective_bomb_site_03",
            "_ping_objective_control_point_00",
            "_ping_objective_control_point_01",
            "_ping_objective_control_point_02",
            "_ping_objective_control_point_03",
            "_ping_objective_flag_00",
            "_ping_objective_flag_01",
            "_ping_objective_flag_02",
            "_ping_objective_flag_03",
            "_ping_objective_hardpoint_00",
            "_ping_objective_hardpoint_01",
            "_ping_objective_hardpoint_02",
            "_ping_objective_hardpoint_03",
            "_ping_objective_next_hardpoint_00",
            "_ping_objective_next_hardpoint_01",
            "_ping_objective_next_hardpoint_02",
            "_ping_objective_next_hardpoint_03",
            "_ping_vip_exfil_site_00",
            "_ping_vip_exfil_site_01",
            "_ping_vip_exfil_site_02",
            "_ping_vip_exfil_site_03",
            "_promotion_reaction_00",
            "_promotion_reaction_01",
            "_promotion_reaction_02",
            "_promotion_reaction_03",
            "_se_dstr_veh_satchel_00",
            "_se_dstr_veh_satchel_01",
            "_se_kill_backfire_00",
            "_se_kill_backfire_01",
            "_se_kill_backstabber_00",
            "_se_kill_backstabber_01",
            "_se_kill_blindfire_00",
            "_se_kill_blindfire_01",
            "_se_kill_comeback_00",
            "_se_kill_comeback_01",
            "_se_kill_first_00",
            "_se_kill_first_01",
            "_se_kill_gunbutt_00",
            "_se_kill_gunbutt_01",
            "_se_kill_hatchet_bounce_00",
            "_se_kill_hatchet_bounce_01",
            "_se_kill_hatchet_longshot_00",
            "_se_kill_hatchet_longshot_01",
            "_se_kill_mult_2_00",
            "_se_kill_mult_2_01",
            "_se_kill_mult_4_00",
            "_se_kill_mult_4_01",
            "_se_kill_mult_6_00",
            "_se_kill_mult_6_01",
            "_se_kill_mult_blind_00",
            "_se_kill_mult_blind_01",
            "_se_kill_mult_clear_obj_00",
            "_se_kill_mult_clear_obj_01",
            "_se_kill_mult_clear_obj_02",
            "_se_kill_mult_clear_obj_03",
            "_se_kill_mult_concuss_00",
            "_se_kill_mult_concuss_01",
            "_se_kill_mult_frag_00",
            "_se_kill_mult_frag_01",
            "_se_kill_mult_gas_00",
            "_se_kill_mult_gas_01",
            "_se_kill_mult_jammer_00",
            "_se_kill_mult_jammer_01",
            "_se_kill_mult_landmine_00",
            "_se_kill_mult_landmine_01",
            "_se_kill_mult_listen_00",
            "_se_kill_mult_listen_01",
            "_se_kill_mult_molo_00",
            "_se_kill_mult_molo_01",
            "_se_kill_mult_nightingale_00",
            "_se_kill_mult_nightingale_01",
            "_se_kill_mult_one_bullet_00",
            "_se_kill_mult_one_bullet_01",
            "_se_kill_mult_satchel_00",
            "_se_kill_mult_satchel_01",
            "_se_kill_mult_semtex_00",
            "_se_kill_mult_semtex_01",
            "_se_kill_one_bullet_sniper_00",
            "_se_kill_one_bullet_sniper_01",
            "_se_kill_point_blank_00",
            "_se_kill_point_blank_01",
            "_se_kill_point_blank_02",
            "_se_kill_point_blank_03",
            "_se_kill_quad_obit_feed_00",
            "_se_kill_quad_obit_feed_01",
            "_se_kill_revenge_00",
            "_se_kill_revenge_01",
            "_se_kill_revenge_02",
            "_se_kill_revenge_03",
            "_se_kill_savior_00",
            "_se_kill_savior_01",
            "_se_kill_savior_02",
            "_se_kill_savior_03",
            "_se_kill_semtex_stuck_00",
            "_se_kill_semtex_stuck_01",
            "_se_kill_streak_10_00",
            "_se_kill_streak_10_01",
            "_se_kill_streak_15_00",
            "_se_kill_streak_15_01",
            "_se_kill_streak_20_00",
            "_se_kill_streak_20_01",
            "_se_kill_streak_25_00",
            "_se_kill_streak_25_01",
            "_se_kill_streak_30_00",
            "_se_kill_streak_30_01",
            "_se_kill_streak_5_00",
            "_se_kill_streak_5_01",
            "_se_kill_survivor_00",
            "_se_kill_survivor_01",
            "_se_kill_survivor_02",
            "_se_kill_survivor_03",
            "_se_kill_veh_00",
            "_se_kill_veh_01",
            "_se_shutdown_bow_00",
            "_se_shutdown_bow_01",
            "_se_shutdown_death_machine_00",
            "_se_shutdown_death_machine_01",
            "_se_shutdown_flamethrower_00",
            "_se_shutdown_flamethrower_01",
            "_se_shutdown_grenade_launcher_00",
            "_se_shutdown_grenade_launcher_01",
            "_se_shutdown_hand_cannon_00",
            "_se_shutdown_hand_cannon_01",
            "_spawn_sqd_00",
            "_spawn_sqd_01",
            "_spawn_sqd_02",
            "_spawn_sqd_03",
            "_spawn_sqd_04",
            "_spawn_sqd_05",
            "_spawn_sqd_06",
            "_spawn_sqd_07",
            "_ss_artillery_use_00",
            "_ss_artillery_use_01",
            "_ss_artillery_use_02",
            "_ss_artillery_use_03",
            "_ss_bow_dstr_00",
            "_ss_bow_dstr_01",
            "_ss_bow_dstr_02",
            "_ss_bow_dstr_03",
            "_ss_bow_threat_00",
            "_ss_bow_threat_01",
            "_ss_bow_threat_02",
            "_ss_bow_threat_03",
            "_ss_bow_use_00",
            "_ss_bow_use_01",
            "_ss_bow_use_02",
            "_ss_bow_use_03",
            "_ss_care_dstr_00",
            "_ss_care_dstr_01",
            "_ss_care_dstr_02",
            "_ss_care_dstr_03",
            "_ss_care_threat_00",
            "_ss_care_threat_01",
            "_ss_care_threat_02",
            "_ss_care_threat_03",
            "_ss_care_use_00",
            "_ss_care_use_01",
            "_ss_care_use_02",
            "_ss_care_use_03",
            "_ss_chop_gun_dstr_00",
            "_ss_chop_gun_dstr_01",
            "_ss_chop_gun_dstr_02",
            "_ss_chop_gun_dstr_03",
            "_ss_chop_gun_threat_00",
            "_ss_chop_gun_threat_01",
            "_ss_chop_gun_threat_02",
            "_ss_chop_gun_threat_03",
            "_ss_chop_gun_use_00",
            "_ss_chop_gun_use_01",
            "_ss_chop_gun_use_02",
            "_ss_chop_gun_use_03",
            "_ss_ctrl_missile_dstr_00",
            "_ss_ctrl_missile_dstr_01",
            "_ss_ctrl_missile_dstr_02",
            "_ss_ctrl_missile_dstr_03",
            "_ss_ctrl_missile_dstr_alt_00",
            "_ss_ctrl_missile_dstr_alt_01",
            "_ss_ctrl_missile_dstr_alt_02",
            "_ss_ctrl_missile_dstr_alt_03",
            "_ss_ctrl_missile_threat_00",
            "_ss_ctrl_missile_threat_01",
            "_ss_ctrl_missile_threat_02",
            "_ss_ctrl_missile_threat_03",
            "_ss_ctrl_missile_threat_alt_00",
            "_ss_ctrl_missile_threat_alt_01",
            "_ss_ctrl_missile_threat_alt_02",
            "_ss_ctrl_missile_threat_alt_03",
            "_ss_ctrl_missile_use_00",
            "_ss_ctrl_missile_use_01",
            "_ss_ctrl_missile_use_02",
            "_ss_ctrl_missile_use_03",
            "_ss_ctrl_missile_use_alt_00",
            "_ss_ctrl_missile_use_alt_01",
            "_ss_ctrl_missile_use_alt_02",
            "_ss_ctrl_missile_use_alt_03",
            "_ss_cuav_dstr_00",
            "_ss_cuav_dstr_01",
            "_ss_cuav_dstr_02",
            "_ss_cuav_dstr_03",
            "_ss_cuav_threat_00",
            "_ss_cuav_threat_01",
            "_ss_cuav_threat_02",
            "_ss_cuav_threat_03",
            "_ss_cuav_use_00",
            "_ss_cuav_use_01",
            "_ss_cuav_use_02",
            "_ss_cuav_use_03",
            "_ss_death_machine_dstr_00",
            "_ss_death_machine_dstr_01",
            "_ss_death_machine_dstr_02",
            "_ss_death_machine_dstr_03",
            "_ss_death_machine_threat_00",
            "_ss_death_machine_threat_01",
            "_ss_death_machine_threat_02",
            "_ss_death_machine_threat_03",
            "_ss_death_machine_use_00",
            "_ss_death_machine_use_01",
            "_ss_death_machine_use_02",
            "_ss_death_machine_use_03",
            "_ss_flamethrower_dstr_00",
            "_ss_flamethrower_dstr_01",
            "_ss_flamethrower_dstr_02",
            "_ss_flamethrower_dstr_03",
            "_ss_flamethrower_threat_00",
            "_ss_flamethrower_threat_01",
            "_ss_flamethrower_threat_02",
            "_ss_flamethrower_threat_03",
            "_ss_flamethrower_use_00",
            "_ss_flamethrower_use_01",
            "_ss_flamethrower_use_02",
            "_ss_flamethrower_use_03",
            "_ss_grenade_launcher_dstr_00",
            "_ss_grenade_launcher_dstr_01",
            "_ss_grenade_launcher_dstr_02",
            "_ss_grenade_launcher_dstr_03",
            "_ss_grenade_launcher_threat_00",
            "_ss_grenade_launcher_threat_01",
            "_ss_grenade_launcher_threat_02",
            "_ss_grenade_launcher_threat_03",
            "_ss_grenade_launcher_use_00",
            "_ss_grenade_launcher_use_01",
            "_ss_grenade_launcher_use_02",
            "_ss_grenade_launcher_use_03",
            "_ss_gunship_dstr_00",
            "_ss_gunship_dstr_01",
            "_ss_gunship_dstr_02",
            "_ss_gunship_dstr_03",
            "_ss_gunship_threat_00",
            "_ss_gunship_threat_01",
            "_ss_gunship_threat_02",
            "_ss_gunship_threat_03",
            "_ss_gunship_use_00",
            "_ss_gunship_use_01",
            "_ss_gunship_use_02",
            "_ss_gunship_use_03",
            "_ss_hand_cannon_dstr_00",
            "_ss_hand_cannon_dstr_01",
            "_ss_hand_cannon_dstr_02",
            "_ss_hand_cannon_dstr_03",
            "_ss_hand_cannon_threat_00",
            "_ss_hand_cannon_threat_01",
            "_ss_hand_cannon_threat_02",
            "_ss_hand_cannon_threat_03",
            "_ss_hand_cannon_use_00",
            "_ss_hand_cannon_use_01",
            "_ss_hand_cannon_use_02",
            "_ss_hand_cannon_use_03",
            "_ss_hover_jet_dstr_00",
            "_ss_hover_jet_dstr_01",
            "_ss_hover_jet_dstr_02",
            "_ss_hover_jet_dstr_03",
            "_ss_hover_jet_threat_00",
            "_ss_hover_jet_threat_01",
            "_ss_hover_jet_threat_02",
            "_ss_hover_jet_threat_03",
            "_ss_hover_jet_use_00",
            "_ss_hover_jet_use_01",
            "_ss_hover_jet_use_02",
            "_ss_hover_jet_use_03",
            "_ss_jet_fighter_use_00",
            "_ss_jet_fighter_use_01",
            "_ss_jet_fighter_use_02",
            "_ss_jet_fighter_use_03",
            "_ss_lgt_chop_dstr_00",
            "_ss_lgt_chop_dstr_01",
            "_ss_lgt_chop_dstr_02",
            "_ss_lgt_chop_dstr_03",
            "_ss_lgt_chop_threat_00",
            "_ss_lgt_chop_threat_01",
            "_ss_lgt_chop_threat_02",
            "_ss_lgt_chop_threat_03",
            "_ss_lgt_chop_use_00",
            "_ss_lgt_chop_use_01",
            "_ss_lgt_chop_use_02",
            "_ss_lgt_chop_use_03",
            "_ss_napalm_use_00",
            "_ss_napalm_use_01",
            "_ss_napalm_use_02",
            "_ss_napalm_use_03",
            "_ss_rcxd_dstr_00",
            "_ss_rcxd_dstr_01",
            "_ss_rcxd_dstr_02",
            "_ss_rcxd_dstr_03",
            "_ss_rcxd_threat_00",
            "_ss_rcxd_threat_01",
            "_ss_rcxd_threat_02",
            "_ss_rcxd_threat_03",
            "_ss_rcxd_use_00",
            "_ss_rcxd_use_01",
            "_ss_rcxd_use_02",
            "_ss_rcxd_use_03",
            "_ss_recon_dstr_alt_00",
            "_ss_recon_dstr_alt_01",
            "_ss_recon_dstr_alt_02",
            "_ss_recon_dstr_alt_03",
            "_ss_recon_threat_alt_00",
            "_ss_recon_threat_alt_01",
            "_ss_recon_threat_alt_02",
            "_ss_recon_threat_alt_03",
            "_ss_recon_use_alt_00",
            "_ss_recon_use_alt_01",
            "_ss_recon_use_alt_02",
            "_ss_recon_use_alt_03",
            "_ss_sentry_dstr_00",
            "_ss_sentry_dstr_01",
            "_ss_sentry_dstr_02",
            "_ss_sentry_dstr_03",
            "_ss_sentry_threat_00",
            "_ss_sentry_threat_01",
            "_ss_sentry_threat_02",
            "_ss_sentry_threat_03",
            "_ss_sentry_use_00",
            "_ss_sentry_use_01",
            "_ss_sentry_use_02",
            "_ss_sentry_use_03",
            "_ss_strafe_dstr_00",
            "_ss_strafe_dstr_01",
            "_ss_strafe_dstr_02",
            "_ss_strafe_dstr_03",
            "_ss_strafe_threat_00",
            "_ss_strafe_threat_01",
            "_ss_strafe_threat_02",
            "_ss_strafe_threat_03",
            "_ss_strafe_use_00",
            "_ss_strafe_use_01",
            "_ss_strafe_use_02",
            "_ss_strafe_use_03",
            "_ss_uav_dstr_00",
            "_ss_uav_dstr_01",
            "_ss_uav_dstr_02",
            "_ss_uav_dstr_03",
            "_ss_uav_threat_00",
            "_ss_uav_threat_01",
            "_ss_uav_threat_02",
            "_ss_uav_threat_03",
            "_ss_uav_use_00",
            "_ss_uav_use_01",
            "_ss_uav_use_02",
            "_ss_uav_use_03",
            "_threat_infantry_00",
            "_threat_infantry_01",
            "_threat_infantry_02",
            "_threat_infantry_03",
            "_threat_infantry_04",
            "_threat_infantry_05",
            "_threat_infantry_06",
            "_threat_infantry_07",
            "_threat_infantry_08",
            "_threat_infantry_09",
            "_threat_infantry_10",
            "_threat_infantry_11",
            "_threat_infantry_12",
            "_threat_infantry_13",
            "_threat_infantry_14",
            "_threat_infantry_15",
            "_threat_infantry_fm_00",
            "_threat_infantry_fm_01",
            "_threat_infantry_fm_02",
            "_threat_infantry_fm_03",
            "_threat_infantry_fm_04",
            "_threat_infantry_fm_05",
            "_threat_infantry_fm_06",
            "_threat_infantry_fm_07",
            "_threat_infantry_ml_00",
            "_threat_infantry_ml_01",
            "_threat_infantry_ml_02",
            "_threat_infantry_ml_03",
            "_threat_infantry_ml_04",
            "_threat_infantry_ml_05",
            "_threat_infantry_ml_06",
            "_threat_infantry_ml_07",
            "_threat_sniper_00",
            "_threat_sniper_01",
            "_zm_eq_generic_use_fail_00",
            "_zm_eq_generic_use_fail_01",
            "_zm_eq_generic_use_fail_02",
            "_zm_eq_generic_use_fail_03",
            "_zm_eq_generic_use_fail_04",
            "_zm_eq_generic_use_fail_05",
            "_zm_eq_generic_use_fail_06",
            "_zm_eq_generic_use_fail_07",
            "_zm_eq_monkey_bomb_use_00",
            "_zm_eq_monkey_bomb_use_01",
            "_zm_eq_monkey_bomb_use_02",
            "_zm_eq_monkey_bomb_use_03",
            "_zm_eq_razor_wire_use_00",
            "_zm_eq_razor_wire_use_01",
            "_zm_eq_razor_wire_use_02",
            "_zm_eq_razor_wire_use_03",
            "_zm_exfil_call_in_00",
            "_zm_exfil_call_in_01",
            "_zm_exfil_call_in_02",
            "_zm_exfil_call_in_03",
            "_zm_exfil_call_in_04",
            "_zm_exfil_call_in_05",
            "_zm_kill_zombie_generic_00",
            "_zm_kill_zombie_generic_01",
            "_zm_kill_zombie_generic_02",
            "_zm_kill_zombie_generic_03",
            "_zm_kill_zombie_generic_04",
            "_zm_kill_zombie_generic_05",
            "_zm_kill_zombie_generic_06",
            "_zm_kill_zombie_generic_07",
            "_zm_kill_zombie_headshot_00",
            "_zm_kill_zombie_headshot_01",
            "_zm_kill_zombie_headshot_02",
            "_zm_kill_zombie_headshot_03",
            "_zm_kill_zombie_headshot_04",
            "_zm_kill_zombie_headshot_05",
            "_zm_pick_up_box_equipment_00",
            "_zm_pick_up_box_equipment_01",
            "_zm_pick_up_box_equipment_02",
            "_zm_pick_up_box_equipment_03",
            "_zm_pick_up_box_equipment_04",
            "_zm_pick_up_box_equipment_05",
            "_zm_pick_up_box_equipment_06",
            "_zm_pick_up_box_equipment_07",
            "_zm_pick_up_box_equipment_08",
            "_zm_pick_up_box_equipment_09",
            "_zm_pick_up_box_equipment_10",
            "_zm_pick_up_box_equipment_11",
            "_zm_pick_up_box_self_revive_00",
            "_zm_pick_up_box_self_revive_01",
            "_zm_pick_up_box_self_revive_02",
            "_zm_pick_up_box_self_revive_03",
            "_zm_pick_up_box_self_revive_04",
            "_zm_pick_up_box_self_revive_05",
            "_zm_pick_up_box_self_revive_06",
            "_zm_pick_up_box_self_revive_07",
            "_zm_pick_up_box_self_revive_08",
            "_zm_pick_up_box_self_revive_09",
            "_zm_pick_up_box_self_revive_10",
            "_zm_pick_up_box_self_revive_11",
            "_zm_pick_up_weapon_assault_rifle_00",
            "_zm_pick_up_weapon_assault_rifle_01",
            "_zm_pick_up_weapon_assault_rifle_02",
            "_zm_pick_up_weapon_assault_rifle_03",
            "_zm_pick_up_weapon_assault_rifle_04",
            "_zm_pick_up_weapon_assault_rifle_05",
            "_zm_pick_up_weapon_assault_rifle_06",
            "_zm_pick_up_weapon_assault_rifle_07",
            "_zm_pick_up_weapon_assault_rifle_08",
            "_zm_pick_up_weapon_assault_rifle_09",
            "_zm_pick_up_weapon_assault_rifle_10",
            "_zm_pick_up_weapon_assault_rifle_11",
            "_zm_pick_up_weapon_generic_00",
            "_zm_pick_up_weapon_generic_01",
            "_zm_pick_up_weapon_generic_02",
            "_zm_pick_up_weapon_generic_03",
            "_zm_pick_up_weapon_generic_04",
            "_zm_pick_up_weapon_generic_05",
            "_zm_pick_up_weapon_generic_06",
            "_zm_pick_up_weapon_generic_07",
            "_zm_pick_up_weapon_generic_08",
            "_zm_pick_up_weapon_generic_09",
            "_zm_pick_up_weapon_generic_10",
            "_zm_pick_up_weapon_generic_11",
            "_zm_pick_up_weapon_launcher_00",
            "_zm_pick_up_weapon_launcher_01",
            "_zm_pick_up_weapon_launcher_02",
            "_zm_pick_up_weapon_launcher_03",
            "_zm_pick_up_weapon_launcher_04",
            "_zm_pick_up_weapon_launcher_05",
            "_zm_pick_up_weapon_launcher_06",
            "_zm_pick_up_weapon_launcher_07",
            "_zm_pick_up_weapon_launcher_08",
            "_zm_pick_up_weapon_launcher_09",
            "_zm_pick_up_weapon_launcher_10",
            "_zm_pick_up_weapon_launcher_11",
            "_zm_pick_up_weapon_lmg_00",
            "_zm_pick_up_weapon_lmg_01",
            "_zm_pick_up_weapon_lmg_02",
            "_zm_pick_up_weapon_lmg_03",
            "_zm_pick_up_weapon_lmg_04",
            "_zm_pick_up_weapon_lmg_05",
            "_zm_pick_up_weapon_lmg_06",
            "_zm_pick_up_weapon_lmg_07",
            "_zm_pick_up_weapon_lmg_08",
            "_zm_pick_up_weapon_lmg_09",
            "_zm_pick_up_weapon_lmg_10",
            "_zm_pick_up_weapon_lmg_11",
            "_zm_pick_up_weapon_pistol_00",
            "_zm_pick_up_weapon_pistol_01",
            "_zm_pick_up_weapon_pistol_02",
            "_zm_pick_up_weapon_pistol_03",
            "_zm_pick_up_weapon_pistol_04",
            "_zm_pick_up_weapon_pistol_05",
            "_zm_pick_up_weapon_pistol_06",
            "_zm_pick_up_weapon_pistol_07",
            "_zm_pick_up_weapon_pistol_08",
            "_zm_pick_up_weapon_pistol_09",
            "_zm_pick_up_weapon_pistol_10",
            "_zm_pick_up_weapon_pistol_11",
            "_zm_pick_up_weapon_ray_gun_00",
            "_zm_pick_up_weapon_ray_gun_01",
            "_zm_pick_up_weapon_ray_gun_02",
            "_zm_pick_up_weapon_ray_gun_03",
            "_zm_pick_up_weapon_ray_gun_04",
            "_zm_pick_up_weapon_ray_gun_05",
            "_zm_pick_up_weapon_ray_gun_06",
            "_zm_pick_up_weapon_ray_gun_07",
            "_zm_pick_up_weapon_shotgun_00",
            "_zm_pick_up_weapon_shotgun_01",
            "_zm_pick_up_weapon_shotgun_02",
            "_zm_pick_up_weapon_shotgun_03",
            "_zm_pick_up_weapon_shotgun_04",
            "_zm_pick_up_weapon_shotgun_05",
            "_zm_pick_up_weapon_shotgun_06",
            "_zm_pick_up_weapon_shotgun_07",
            "_zm_pick_up_weapon_shotgun_08",
            "_zm_pick_up_weapon_shotgun_09",
            "_zm_pick_up_weapon_shotgun_10",
            "_zm_pick_up_weapon_shotgun_11",
            "_zm_pick_up_weapon_smg_00",
            "_zm_pick_up_weapon_smg_01",
            "_zm_pick_up_weapon_smg_02",
            "_zm_pick_up_weapon_smg_03",
            "_zm_pick_up_weapon_smg_04",
            "_zm_pick_up_weapon_smg_05",
            "_zm_pick_up_weapon_smg_06",
            "_zm_pick_up_weapon_smg_07",
            "_zm_pick_up_weapon_smg_08",
            "_zm_pick_up_weapon_smg_09",
            "_zm_pick_up_weapon_smg_10",
            "_zm_pick_up_weapon_smg_11",
            "_zm_pick_up_weapon_sniper_rifle_00",
            "_zm_pick_up_weapon_sniper_rifle_01",
            "_zm_pick_up_weapon_sniper_rifle_02",
            "_zm_pick_up_weapon_sniper_rifle_03",
            "_zm_pick_up_weapon_sniper_rifle_04",
            "_zm_pick_up_weapon_sniper_rifle_05",
            "_zm_pick_up_weapon_sniper_rifle_06",
            "_zm_pick_up_weapon_sniper_rifle_07",
            "_zm_pick_up_weapon_sniper_rifle_08",
            "_zm_pick_up_weapon_sniper_rifle_09",
            "_zm_pick_up_weapon_sniper_rifle_10",
            "_zm_pick_up_weapon_sniper_rifle_11",
            "_zm_pick_up_weapon_tactical_rifle_00",
            "_zm_pick_up_weapon_tactical_rifle_01",
            "_zm_pick_up_weapon_tactical_rifle_02",
            "_zm_pick_up_weapon_tactical_rifle_03",
            "_zm_pick_up_weapon_tactical_rifle_04",
            "_zm_pick_up_weapon_tactical_rifle_05",
            "_zm_pick_up_weapon_tactical_rifle_06",
            "_zm_pick_up_weapon_tactical_rifle_07",
            "_zm_pick_up_weapon_tactical_rifle_08",
            "_zm_pick_up_weapon_tactical_rifle_09",
            "_zm_pick_up_weapon_tactical_rifle_10",
            "_zm_pick_up_weapon_tactical_rifle_11",
            "_zm_pick_up_weapon_ww_generic_00",
            "_zm_pick_up_weapon_ww_generic_01",
            "_zm_pick_up_weapon_ww_generic_02",
            "_zm_pick_up_weapon_ww_generic_03",
            "_zm_pick_up_weapon_ww_generic_04",
            "_zm_pick_up_weapon_ww_generic_05",
            "_zm_pick_up_weapon_ww_generic_06",
            "_zm_pick_up_weapon_ww_generic_07",
            "_zm_pick_up_weapon_ww_generic_08",
            "_zm_pick_up_weapon_ww_generic_09",
            "_zm_pick_up_weapon_ww_generic_10",
            "_zm_pick_up_weapon_ww_generic_11",
            "_zm_ping_danger_boss_gen_00",
            "_zm_ping_danger_boss_gen_01",
            "_zm_ping_danger_boss_gen_02",
            "_zm_ping_danger_boss_gen_03",
            "_zm_ping_danger_boss_orda_00",
            "_zm_ping_danger_boss_orda_01",
            "_zm_ping_danger_boss_orda_02",
            "_zm_ping_danger_boss_orda_03",
            "_zm_ping_danger_elite_gen_00",
            "_zm_ping_danger_elite_gen_01",
            "_zm_ping_danger_elite_gen_02",
            "_zm_ping_danger_elite_gen_03",
            "_zm_ping_danger_special_00",
            "_zm_ping_danger_special_01",
            "_zm_ping_danger_special_02",
            "_zm_ping_danger_special_03",
            "_zm_ping_item_aetherium_00",
            "_zm_ping_item_aetherium_01",
            "_zm_ping_item_aetherium_02",
            "_zm_ping_item_aetherium_03",
            "_zm_ping_item_gun_ray_gun_00",
            "_zm_ping_item_gun_ray_gun_01",
            "_zm_ping_item_gun_ww_00",
            "_zm_ping_item_gun_ww_01",
            "_zm_ping_item_intel_00",
            "_zm_ping_item_intel_01",
            "_zm_ping_item_lethal_monkey_bomb_00",
            "_zm_ping_item_lethal_monkey_bomb_01",
            "_zm_ping_item_quest_00",
            "_zm_ping_item_quest_01",
            "_zm_ping_item_salvage_00",
            "_zm_ping_item_salvage_01",
            "_zm_ping_item_tactical_loot_chest_00",
            "_zm_ping_item_tactical_loot_chest_01",
            "_zm_ping_item_tactical_mystery_box_00",
            "_zm_ping_item_tactical_mystery_box_01",
            "_zm_ping_item_tactical_supply_drop_00",
            "_zm_ping_item_tactical_supply_drop_01",
            "_zm_ping_item_tactical_wall_buy_00",
            "_zm_ping_item_tactical_wall_buy_01",
            "_zm_ping_ntrct_ammo_cache_00",
            "_zm_ping_ntrct_ammo_cache_01",
            "_zm_ping_ntrct_arsenal_00",
            "_zm_ping_ntrct_arsenal_01",
            "_zm_ping_ntrct_beacon_00",
            "_zm_ping_ntrct_beacon_01",
            "_zm_ping_ntrct_craft_table_00",
            "_zm_ping_ntrct_craft_table_01",
            "_zm_ping_ntrct_gen_00",
            "_zm_ping_ntrct_gen_01",
            "_zm_ping_ntrct_lock_door_00",
            "_zm_ping_ntrct_lock_door_01",
            "_zm_ping_ntrct_obstruct_00",
            "_zm_ping_ntrct_obstruct_01",
            "_zm_ping_ntrct_pap_00",
            "_zm_ping_ntrct_pap_01",
            "_zm_ping_ntrct_pc_00",
            "_zm_ping_ntrct_pc_01",
            "_zm_ping_ntrct_perk_can_gen_00",
            "_zm_ping_ntrct_perk_can_gen_01",
            "_zm_ping_ntrct_power_00",
            "_zm_ping_ntrct_power_01",
            "_zm_ping_ntrct_trap_00",
            "_zm_ping_ntrct_trap_01",
            "_zm_ping_ntrct_workbench_00",
            "_zm_ping_ntrct_workbench_01",
            "_zm_ping_objective_exfil_radio_00",
            "_zm_ping_objective_exfil_radio_01",
            "_zm_ping_perk_deadshot_00",
            "_zm_ping_perk_deadshot_01",
            "_zm_ping_perk_death_prcpt_00",
            "_zm_ping_perk_death_prcpt_01",
            "_zm_ping_perk_elemental_00",
            "_zm_ping_perk_elemental_01",
            "_zm_ping_perk_generic_00",
            "_zm_ping_perk_generic_01",
            "_zm_ping_perk_juggernog_00",
            "_zm_ping_perk_juggernog_01",
            "_zm_ping_perk_mule_kick_00",
            "_zm_ping_perk_mule_kick_01",
            "_zm_ping_perk_revive_00",
            "_zm_ping_perk_revive_01",
            "_zm_ping_perk_speed_cola_00",
            "_zm_ping_perk_speed_cola_01",
            "_zm_ping_perk_stamin_00",
            "_zm_ping_perk_stamin_01",
            "_zm_ping_perk_tombstone_00",
            "_zm_ping_perk_tombstone_01",
            "_zm_ping_perk_wonderfizz_00",
            "_zm_ping_perk_wonderfizz_01",
            "_zm_ping_support_gen_00",
            "_zm_ping_support_gen_01",
            "_zm_revive_downed_00",
            "_zm_revive_downed_01",
            "_zm_revive_downed_02",
            "_zm_revive_downed_03",
            "_zm_revive_downed_04",
            "_zm_revive_downed_05",
            "_zm_revive_downed_06",
            "_zm_revive_downed_07",
            "_zm_revive_revive_00",
            "_zm_revive_revive_01",
            "_zm_revive_revive_02",
            "_zm_revive_revive_03",
            "_zm_revive_revive_04",
            "_zm_revive_revive_05",
            "_zm_revive_revive_06",
            "_zm_revive_revive_07",
            "_zm_revive_revive_response_00",
            "_zm_revive_revive_response_01",
            "_zm_revive_revive_response_02",
            "_zm_revive_revive_response_03",
            "_zm_revive_revive_response_04",
            "_zm_revive_revive_response_05",
            "_zm_revive_revive_response_06",
            "_zm_revive_revive_response_07",
            "_zm_se_critical_finish_00",
            "_zm_se_critical_finish_01",
            "_zm_se_critical_finish_02",
            "_zm_se_critical_finish_03",
            "_zm_se_kill_boss_00",
            "_zm_se_kill_boss_01",
            "_zm_se_kill_boss_02",
            "_zm_se_kill_boss_03",
            "_zm_se_kill_elite_00",
            "_zm_se_kill_elite_01",
            "_zm_se_kill_elite_02",
            "_zm_se_kill_elite_03",
            "_zm_se_kill_elite_04",
            "_zm_se_kill_elite_05",
            "_zm_se_kill_mult_aether_shroud_00",
            "_zm_se_kill_mult_aether_shroud_01",
            "_zm_se_kill_mult_aether_shroud_02",
            "_zm_se_kill_mult_aether_shroud_03",
            "_zm_se_kill_mult_energy_mine_00",
            "_zm_se_kill_mult_energy_mine_01",
            "_zm_se_kill_mult_energy_mine_02",
            "_zm_se_kill_mult_energy_mine_03",
            "_zm_se_kill_mult_explo_shot_00",
            "_zm_se_kill_mult_explo_shot_01",
            "_zm_se_kill_mult_explo_shot_02",
            "_zm_se_kill_mult_explo_shot_03",
            "_zm_se_kill_mult_frost_blast_00",
            "_zm_se_kill_mult_frost_blast_01",
            "_zm_se_kill_mult_frost_blast_02",
            "_zm_se_kill_mult_frost_blast_03",
            "_zm_se_kill_mult_heal_aura_00",
            "_zm_se_kill_mult_heal_aura_01",
            "_zm_se_kill_mult_heal_aura_02",
            "_zm_se_kill_mult_heal_aura_03",
            "_zm_se_kill_mult_melee_00",
            "_zm_se_kill_mult_melee_01",
            "_zm_se_kill_mult_melee_02",
            "_zm_se_kill_mult_melee_03",
            "_zm_se_kill_mult_monkey_00",
            "_zm_se_kill_mult_monkey_01",
            "_zm_se_kill_mult_monkey_02",
            "_zm_se_kill_mult_monkey_03",
            "_zm_se_kill_mult_monkey_04",
            "_zm_se_kill_mult_monkey_05",
            "_zm_se_kill_mult_one_shot_00",
            "_zm_se_kill_mult_one_shot_01",
            "_zm_se_kill_mult_one_shot_02",
            "_zm_se_kill_mult_one_shot_03",
            "_zm_se_kill_mult_ring_fire_00",
            "_zm_se_kill_mult_ring_fire_01",
            "_zm_se_kill_mult_ring_fire_02",
            "_zm_se_kill_mult_ring_fire_03",
            "_zm_se_kill_mult_streak_10_00",
            "_zm_se_kill_mult_streak_10_01",
            "_zm_se_kill_mult_streak_10_02",
            "_zm_se_kill_mult_streak_10_03",
            "_zm_se_kill_mult_streak_10_04",
            "_zm_se_kill_mult_streak_10_05",
            "_zm_se_kill_mult_streak_15_00",
            "_zm_se_kill_mult_streak_15_01",
            "_zm_se_kill_mult_streak_15_02",
            "_zm_se_kill_mult_streak_15_03",
            "_zm_se_kill_mult_streak_15_04",
            "_zm_se_kill_mult_streak_15_05",
            "_zm_se_kill_mult_streak_20_00",
            "_zm_se_kill_mult_streak_20_01",
            "_zm_se_kill_mult_streak_20_02",
            "_zm_se_kill_mult_streak_20_03",
            "_zm_se_kill_mult_streak_25_00",
            "_zm_se_kill_mult_streak_25_01",
            "_zm_se_kill_mult_streak_25_02",
            "_zm_se_kill_mult_streak_25_03",
            "_zm_se_kill_mult_streak_5_00",
            "_zm_se_kill_mult_streak_5_01",
            "_zm_se_kill_mult_streak_5_02",
            "_zm_se_kill_mult_streak_5_03",
            "_zm_se_kill_mult_streak_5_04",
            "_zm_se_kill_mult_streak_5_05",
            "_zm_se_kill_mult_tank_taunt_00",
            "_zm_se_kill_mult_tank_taunt_01",
            "_zm_se_kill_mult_tank_taunt_02",
            "_zm_se_kill_mult_tank_taunt_03",
            "_zm_se_kill_mult_toxic_growth_00",
            "_zm_se_kill_mult_toxic_growth_01",
            "_zm_se_kill_mult_toxic_growth_02",
            "_zm_se_kill_mult_toxic_growth_03",
            "_zm_se_kill_mult_ww_ancient_00",
            "_zm_se_kill_mult_ww_ancient_01",
            "_zm_se_kill_mult_ww_ancient_02",
            "_zm_se_kill_mult_ww_ancient_03",
            "_zm_se_kill_mult_ww_science_00",
            "_zm_se_kill_mult_ww_science_01",
            "_zm_se_kill_mult_ww_science_02",
            "_zm_se_kill_mult_ww_science_03",
            "_zm_se_kill_special_00",
            "_zm_se_kill_special_01",
            "_zm_se_kill_special_02",
            "_zm_se_kill_special_03",
            "_zm_se_kill_special_04",
            "_zm_se_kill_special_05",
        };
string[] LanguageTypes =
{
            "",
            // BO4 & CW Sound Extensions
            ".fl75.pc.all.snd",
            ".fn75.pc.all.snd",
            ".ll100.pc.snd",
            ".ll75.pc.all.snd",
            ".ln100.pc.snd",
            ".ln75.pc.all.snd",
            ".ln75.pc.bp.snd",
            ".ln75.pc.ea.snd",
            ".ln75.pc.en.snd",
            ".ln75.pc.es.snd",
            ".ln75.pc.fj.snd",
            ".ln75.pc.fr.snd",
            ".ln75.pc.ge.snd",
            ".ln75.pc.it.snd",
            ".ln75.pc.ko.snd",
            ".ln75.pc.po.snd",
            ".ln75.pc.ru.snd",
            ".lr75.pc.all.snd",
            ".pl100.pc.snd",
            ".pl75.pc.all.snd",
            ".pn100.pc.snd",
            ".pn75.pc.all.snd",
            ".pn75.pc.bp.snd",
            ".pn75.pc.ea.snd",
            ".pn75.pc.en.snd",
            ".pn75.pc.es.snd",
            ".pn75.pc.fj.snd",
            ".pn75.pc.fr.snd",
            ".pn75.pc.ge.snd",
            ".pn75.pc.it.snd",
            ".pn75.pc.ko.snd",
            ".pn75.pc.po.snd",
            ".pn75.pc.ru.snd",
            ".rl75.pc.all.snd",
            ".rn75.pc.all.snd",
            ".rn75.pc.bp.snd",
            ".rn75.pc.ea.snd",
            ".rn75.pc.en.snd",
            ".rn75.pc.es.snd",
            ".rn75.pc.fj.snd",
            ".rn75.pc.fr.snd",
            ".rn75.pc.ge.snd",
            ".rn75.pc.it.snd",
            ".rn75.pc.ko.snd",
            ".rn75.pc.ms.snd",
            ".rn75.pc.po.snd",
            ".rn75.pc.ru.snd",
            ".rr75.pc.all.snd",
            ".sl100.pc.snd",
            ".sl75.pc.all.snd",
            ".sn100.pc.snd",
            ".sn75.pc.all.snd",
            ".sn75.pc.bp.snd",
            ".sn75.pc.ea.snd",
            ".sn75.pc.en.snd",
            ".sn75.pc.es.snd",
            ".sn75.pc.fj.snd",
            ".sn75.pc.fr.snd",
            ".sn75.pc.ge.snd",
            ".sn75.pc.it.snd",
            ".sn75.pc.ko.snd",
            ".sn75.pc.po.snd",
            ".sn75.pc.ru.snd",
            ".sr75.pc.all.snd",
        };
string[] StringTypes =
{
            "",
        };

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("                         __,,,,_");
Console.WriteLine("          _ __..-;''`--/'/ /.',-`-.");
Console.WriteLine("      (`/' ` |  \\ \\ \\ / / / / .-'/`,_");
Console.WriteLine("     /'`\\ \\   |  \\ | \\| // // / -.,/_,'-,");
Console.WriteLine("    /<7' ;  \\ \\  | ; ||/ /| | \\/    |`-/,/-.,_,/')");
Console.WriteLine("   /  _.-, `,-\\,__|  _-| / \\ \\/|_/  |    '-/.;.\'");
Console.WriteLine("   `-`  f/ ;      / __/ \\__ `/ |__/ |");
Console.WriteLine("    fnv `-'      |  -| =|\\_  \\  |-' |");
Console.WriteLine("    Hash      __/   /_..-' `  ),'  //");
Console.WriteLine("    Finder   ((__.-'((___..-'' \\__.'");
Console.WriteLine("\nA Multi-purpose Tool that verifies pre-defined assets\n");
Console.WriteLine("Specify xAsset Directory:");
ExportFolder = Console.ReadLine();
while (true)
{
    Console.WriteLine("[1] Scan All   [2] Credit");
    string searchType = Console.ReadLine();
    if (searchType == "1")
    {
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        Console.WriteLine("Scanning for Assets...");
        Task.WaitAll(Task.Factory.StartNew(() => SearchForSpecificGunOps(gunOps)));
        Console.WriteLine("Scan completed.");
        stopWatch.Stop();
        TimeSpan ts = stopWatch.Elapsed;
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
        ts.Hours, ts.Minutes, ts.Seconds,
        ts.Milliseconds / 10);
        Console.WriteLine("Scan time:" + elapsedTime);
    }
    else if (searchType == "2")
    {
        Console.WriteLine("\nThis Project was made possible by:\n");
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine("Scobalula");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("itsNatoriousB");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("Cortland");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("Amorfirion");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("Dark7x");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("DeltaDriver");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("pmr360\n");
        System.Threading.Thread.Sleep(1000);
    }
}

void SearchForSpecificGunOps(string specificGunOps)
{
    foreach (string aiAnimType in AIAnimTypes)
    {
        foreach (string animType in AnimTypes)
        {
            // BO4 & CW AI Anims
            CheckAnimName("ai_t8_zm_twrs_hllpht" + specificGunOps + aiAnimType);
            CheckAnimName("ai_t8_zm_twrs_tgr" + specificGunOps + aiAnimType);
            CheckAnimName("ai_t8_zm_twrs_zg_dstyr" + specificGunOps + aiAnimType);
            CheckAnimName("ai_t8_zm_twrs_zg_mrdr" + specificGunOps + aiAnimType);
            CheckAnimName("ai_t8_zm_zod_bltfthr" + specificGunOps + aiAnimType);
            CheckAnimName("ai_t8_zm_zod_catalyst_electric" + specificGunOps + aiAnimType);
            CheckAnimName("ai_t8_zm_zod_catalyst_plasma" + specificGunOps + aiAnimType);
            CheckAnimName("ai_t8_zm_zod_catalyst_water" + specificGunOps + aiAnimType);
            CheckAnimName("ai_t8_zm_zod_stoker" + specificGunOps + aiAnimType);
            CheckAnimName("ai_t9_zm_abom" + specificGunOps + aiAnimType);
            CheckAnimName("ai_t9_zm_avogadro" + specificGunOps + aiAnimType);
            CheckAnimName("ai_t9_zm_hulkingsum" + specificGunOps + aiAnimType);
            CheckAnimName("ai_t9_zm_mechz" + specificGunOps + aiAnimType);
            CheckAnimName("ai_t9_zm_plague_hound" + specificGunOps + aiAnimType);
            CheckAnimName("ai_t9_zm_raz" + specificGunOps + aiAnimType);
            CheckAnimName("ai_t9_zm_steiner_base_com" + specificGunOps + aiAnimType);
            // BO4 Weapon Animations
            CheckAnimName("vm_acidgat" + specificGunOps + animType);
            CheckAnimName("vm_action_figure" + specificGunOps + animType);
            CheckAnimName("vm_ar_accurate" + specificGunOps + animType);
            CheckAnimName("vm_ar_an94_t8" + specificGunOps + animType);
            CheckAnimName("vm_ar_damage" + specificGunOps + animType);
            CheckAnimName("vm_ar_double_barrel" + specificGunOps + animType);
            CheckAnimName("vm_ar_fastfire" + specificGunOps + animType);
            CheckAnimName("vm_ar_galil" + specificGunOps + animType);
            CheckAnimName("vm_ar_k57" + specificGunOps + animType);
            CheckAnimName("vm_ar_peacekeeper_t8" + specificGunOps + animType);
            CheckAnimName("vm_ar_standard" + specificGunOps + animType);
            CheckAnimName("vm_ar_stealth" + specificGunOps + animType);
            CheckAnimName("vm_argus_t8" + specificGunOps + animType);
            CheckAnimName("vm_ballistic_knife_t8" + specificGunOps + animType);
            CheckAnimName("vm_ballistic_knife_t8_dw" + specificGunOps + animType);
            CheckAnimName("vm_blundergat" + specificGunOps + animType);
            CheckAnimName("vm_bowie_knife_t8" + specificGunOps + animType);
            CheckAnimName("vm_cackling_kaftar" + specificGunOps + animType);
            CheckAnimName("vm_combat_knife" + specificGunOps + animType);
            CheckAnimName("vm_demo_hammer" + specificGunOps + animType);
            CheckAnimName("vm_dg1" + specificGunOps + animType);
            CheckAnimName("vm_dg2" + specificGunOps + animType);
            CheckAnimName("vm_escargot" + specificGunOps + animType);
            CheckAnimName("vm_essex_model_07" + specificGunOps + animType);
            CheckAnimName("vm_hades" + specificGunOps + animType);
            CheckAnimName("vm_hellion_salvo" + specificGunOps + animType);
            CheckAnimName("vm_hitchcock_m9" + specificGunOps + animType);
            CheckAnimName("vm_homunculus" + specificGunOps + animType);
            CheckAnimName("vm_koshka" + specificGunOps + animType);
            CheckAnimName("vm_lmg_mk48" + specificGunOps + animType);
            CheckAnimName("vm_m1897_trebuchet" + specificGunOps + animType);
            CheckAnimName("vm_magmagat" + specificGunOps + animType);
            CheckAnimName("vm_midburst" + specificGunOps + animType);
            CheckAnimName("vm_money_bag_t8" + specificGunOps + animType);
            CheckAnimName("vm_mp40" + specificGunOps + animType);
            CheckAnimName("vm_mx9" + specificGunOps + animType);
            CheckAnimName("vm_pistol_auto" + specificGunOps + animType);
            CheckAnimName("vm_pistol_burst" + specificGunOps + animType);
            CheckAnimName("vm_pistol_revolver" + specificGunOps + animType);
            CheckAnimName("vm_pistol_standard" + specificGunOps + animType);
            CheckAnimName("vm_pistol_webley" + specificGunOps + animType);
            CheckAnimName("vm_polynesian_club_t8" + specificGunOps + animType);
            CheckAnimName("vm_raygun" + specificGunOps + animType);
			CheckAnimName("vm_reaper_lmg" + specificGunOps + animType);
            CheckAnimName("vm_serket_s_kiss" + specificGunOps + animType);
            CheckAnimName("vm_shotgun_full_auto" + specificGunOps + animType);
            CheckAnimName("vm_shotgun_pump" + specificGunOps + animType);
            CheckAnimName("vm_shotgun_semiauto" + specificGunOps + animType);
            CheckAnimName("vm_slaybell" + specificGunOps + animType);
            CheckAnimName("vm_smg_accurate" + specificGunOps + animType);
            CheckAnimName("vm_smg_capacity" + specificGunOps + animType);
            CheckAnimName("vm_smg_fastburst" + specificGunOps + animType);
            CheckAnimName("vm_smg_fastfire" + specificGunOps + animType);
            CheckAnimName("vm_smg_folding" + specificGunOps + animType);
            CheckAnimName("vm_smg_handling" + specificGunOps + animType);
            CheckAnimName("vm_smg_minigun" + specificGunOps + animType);
            CheckAnimName("vm_smg_thompson" + specificGunOps + animType);
            CheckAnimName("vm_smg_vmp_t8" + specificGunOps + animType);
            CheckAnimName("vm_sniper_damagesemi" + specificGunOps + animType);
            CheckAnimName("vm_sniper_fast_rechamber" + specificGunOps + animType);
            CheckAnimName("vm_sniper_locus_t8" + specificGunOps + animType);
            CheckAnimName("vm_sniper_mini14" + specificGunOps + animType);
            CheckAnimName("vm_sniper_power_semi" + specificGunOps + animType);
            CheckAnimName("vm_sniper_vanguard" + specificGunOps + animType);
            CheckAnimName("vm_special_crossbow" + specificGunOps + animType);
            CheckAnimName("vm_spork" + specificGunOps + animType);
            CheckAnimName("vm_stop_sign" + specificGunOps + animType);
            CheckAnimName("vm_sumarbrandr" + specificGunOps + animType);
            CheckAnimName("vm_titan" + specificGunOps + animType);
            CheckAnimName("vm_tr_damageburst_t8" + specificGunOps + animType);
            CheckAnimName("vm_tr_flechette" + specificGunOps + animType);
            CheckAnimName("vm_tr_power_semi" + specificGunOps + animType);
            CheckAnimName("vm_tr_swordfish" + specificGunOps + animType);
            CheckAnimName("vm_ww_akud" + specificGunOps + animType);
            // CW Weapon Animations
            CheckAnimName("" + specificGunOps + animType);
            CheckAnimName("pt_ar_accurate_t9" + specificGunOps + animType);
            CheckAnimName("pt_ar_british_t9" + specificGunOps + animType);
            CheckAnimName("pt_ar_damage_t9" + specificGunOps + animType);
            CheckAnimName("pt_ar_fastfire_t9" + specificGunOps + animType);
            CheckAnimName("pt_ar_fasthandling_t9" + specificGunOps + animType);
            CheckAnimName("pt_ar_mobility_t9" + specificGunOps + animType);
            CheckAnimName("pt_ar_season6_t9" + specificGunOps + animType);
            CheckAnimName("pt_ar_slowfire_t9" + specificGunOps + animType);
            CheckAnimName("pt_ar_slowhandling_t9" + specificGunOps + animType);
            CheckAnimName("pt_ar_soviet_t9" + specificGunOps + animType);
            CheckAnimName("pt_ar_standard_t9" + specificGunOps + animType);
            CheckAnimName("pt_ballistic_knife_t9" + specificGunOps + animType);
            CheckAnimName("pt_baseball_bat_t9" + specificGunOps + animType);
            CheckAnimName("pt_battle_axe_t9" + specificGunOps + animType);
            CheckAnimName("pt_br_freefall" + specificGunOps + animType);
            CheckAnimName("pt_br_parachute" + specificGunOps + animType);
            CheckAnimName("pt_brawler_t9" + specificGunOps + animType);
            CheckAnimName("pt_cane_t9" + specificGunOps + animType);
            CheckAnimName("pt_com_t9" + specificGunOps + animType);
            CheckAnimName("pt_combat_knife_t9" + specificGunOps + animType);
            CheckAnimName("pt_concussion_grenade_t9" + specificGunOps + animType);
            CheckAnimName("pt_crossbow_t9" + specificGunOps + animType);
            CheckAnimName("pt_dual_sai_t9" + specificGunOps + animType);
            CheckAnimName("pt_etool_t9" + specificGunOps + animType);
            CheckAnimName("pt_flamethrower_t9" + specificGunOps + animType);
            CheckAnimName("pt_frag_grenade_t9" + specificGunOps + animType);
            CheckAnimName("pt_grapple_gun_t9" + specificGunOps + animType);
            CheckAnimName("pt_hammer_sickle_t9" + specificGunOps + animType);
            CheckAnimName("pt_hatchet_t9" + specificGunOps + animType);
            CheckAnimName("pt_launcher_freefire_t9" + specificGunOps + animType);
            CheckAnimName("pt_launcher_standard_t9" + specificGunOps + animType);
            CheckAnimName("pt_lmg_accurate_t9" + specificGunOps + animType);
            CheckAnimName("pt_lmg_fastfire_t9" + specificGunOps + animType);
            CheckAnimName("pt_lmg_light_t9" + specificGunOps + animType);
            CheckAnimName("pt_lmg_slowfire_t9" + specificGunOps + animType);
            CheckAnimName("pt_mace_t9" + specificGunOps + animType);
            CheckAnimName("pt_machete_t9" + specificGunOps + animType);
            CheckAnimName("pt_minigun_t9" + specificGunOps + animType);
            CheckAnimName("pt_nailgun_t9" + specificGunOps + animType);
            CheckAnimName("pt_pistol_burst_t9" + specificGunOps + animType);
            CheckAnimName("pt_pistol_fullauto_t9" + specificGunOps + animType);
            CheckAnimName("pt_pistol_revolver_t9" + specificGunOps + animType);
            CheckAnimName("pt_pistol_semiauto_t9" + specificGunOps + animType);
            CheckAnimName("pt_pistol_shotgun_t9" + specificGunOps + animType);
            CheckAnimName("pt_raygun_t9" + specificGunOps + animType);
            CheckAnimName("pt_scythe_t9" + specificGunOps + animType);
            CheckAnimName("pt_semtex_grenade_t9" + specificGunOps + animType);
            CheckAnimName("pt_shotgun_fullauto_t9" + specificGunOps + animType);
            CheckAnimName("pt_shotgun_leveraction_t9" + specificGunOps + animType);
            CheckAnimName("pt_shotgun_pump_t9" + specificGunOps + animType);
            CheckAnimName("pt_shotgun_semiauto_t9" + specificGunOps + animType);
            CheckAnimName("pt_sledgehammer_t9" + specificGunOps + animType);
            CheckAnimName("pt_smg_accurate_t9" + specificGunOps + animType);
            CheckAnimName("pt_smg_burst_t9" + specificGunOps + animType);
            CheckAnimName("pt_smg_capacity_t9" + specificGunOps + animType);
            CheckAnimName("pt_smg_cqb_t9" + specificGunOps + animType);
            CheckAnimName("pt_smg_fastfire_t9" + specificGunOps + animType);
            CheckAnimName("pt_smg_flechette_t9" + specificGunOps + animType);
            CheckAnimName("pt_smg_handling_t9" + specificGunOps + animType);
            CheckAnimName("pt_smg_heavy_t9" + specificGunOps + animType);
            CheckAnimName("pt_smg_season6_t9" + specificGunOps + animType);
            CheckAnimName("pt_smg_semiauto_t9" + specificGunOps + animType);
            CheckAnimName("pt_smg_spray_t9" + specificGunOps + animType);
            CheckAnimName("pt_smg_standard_t9" + specificGunOps + animType);
            CheckAnimName("pt_smoke_grenade_t9" + specificGunOps + animType);
            CheckAnimName("pt_sniper_accurate_t9" + specificGunOps + animType);
            CheckAnimName("pt_sniper_cannon_t9" + specificGunOps + animType);
            CheckAnimName("pt_sniper_powersemi_t9" + specificGunOps + animType);
            CheckAnimName("pt_sniper_quickscope_t9" + specificGunOps + animType);
            CheckAnimName("pt_sniper_standard_t9" + specificGunOps + animType);
            CheckAnimName("pt_special_grenade_launcher" + specificGunOps + animType);
            CheckAnimName("pt_tr_damagesemi_t9" + specificGunOps + animType);
            CheckAnimName("pt_tr_fastburst_t9" + specificGunOps + animType);
            CheckAnimName("pt_tr_longburst_t9" + specificGunOps + animType);
            CheckAnimName("pt_tr_powerburst_t9" + specificGunOps + animType);
            CheckAnimName("pt_tr_precisionsemi_t9" + specificGunOps + animType);
            CheckAnimName("pt_wakizashi_t9" + specificGunOps + animType);
            CheckAnimName("pt_zm_crystal_axe_melee_t9" + specificGunOps + animType);
            CheckAnimName("pt_zm_crystal_axe_smg_t9" + specificGunOps + animType);
            CheckAnimName("pt_zm_mega_barrel_blazer_beam_t9" + specificGunOps + animType);
            CheckAnimName("pt_zm_mega_barrel_micro_missile_t9" + specificGunOps + animType);
            CheckAnimName("pt_zm_mega_barrel_pistol_t9" + specificGunOps + animType);
            CheckAnimName("pt_zm_ray_rifle_t9" + specificGunOps + animType);
            CheckAnimName("pt_zm_silver_ww_t9" + specificGunOps + animType);
            CheckAnimName("vm_ar_accurate_t9" + specificGunOps + animType);
            CheckAnimName("vm_ar_british_t9" + specificGunOps + animType);
            CheckAnimName("vm_ar_damage_t9" + specificGunOps + animType);
            CheckAnimName("vm_ar_fastfire_t9" + specificGunOps + animType);
            CheckAnimName("vm_ar_fasthandling_t9" + specificGunOps + animType);
            CheckAnimName("vm_ar_mobility_t9" + specificGunOps + animType);
            CheckAnimName("vm_ar_season6_t9" + specificGunOps + animType);
            CheckAnimName("vm_ar_slowfire_t9" + specificGunOps + animType);
            CheckAnimName("vm_ar_slowhandling_t9" + specificGunOps + animType);
            CheckAnimName("vm_ar_soviet_t9" + specificGunOps + animType);
            CheckAnimName("vm_ar_standard_t9" + specificGunOps + animType);
            CheckAnimName("vm_ballistic_knife_t9" + specificGunOps + animType);
            CheckAnimName("vm_baseball_bat_t9" + specificGunOps + animType);
            CheckAnimName("vm_battle_axe_t9" + specificGunOps + animType);
            CheckAnimName("vm_br_freefall" + specificGunOps + animType);
            CheckAnimName("vm_br_parachute" + specificGunOps + animType);
            CheckAnimName("vm_brawler_t9" + specificGunOps + animType);
            CheckAnimName("vm_cane_t9" + specificGunOps + animType);
            CheckAnimName("vm_com_t9" + specificGunOps + animType);
            CheckAnimName("vm_combat_knife_t9" + specificGunOps + animType);
            CheckAnimName("vm_concussion_grenade_t9" + specificGunOps + animType);
            CheckAnimName("vm_crossbow_t9" + specificGunOps + animType);
            CheckAnimName("vm_dual_sai_t9" + specificGunOps + animType);
            CheckAnimName("vm_etool_t9" + specificGunOps + animType);
            CheckAnimName("vm_flamethrower_t9" + specificGunOps + animType);
            CheckAnimName("vm_frag_grenade_t9" + specificGunOps + animType);
            CheckAnimName("vm_grapple_gun_t9" + specificGunOps + animType);
            CheckAnimName("vm_hammer_sickle_t9" + specificGunOps + animType);
            CheckAnimName("vm_hatchet_t9" + specificGunOps + animType);
            CheckAnimName("vm_launcher_freefire_t9" + specificGunOps + animType);
            CheckAnimName("vm_launcher_standard_t9" + specificGunOps + animType);
            CheckAnimName("vm_lmg_accurate_t9" + specificGunOps + animType);
            CheckAnimName("vm_lmg_fastfire_t9" + specificGunOps + animType);
            CheckAnimName("vm_lmg_light_t9" + specificGunOps + animType);
            CheckAnimName("vm_lmg_slowfire_t9" + specificGunOps + animType);
            CheckAnimName("vm_mace_t9" + specificGunOps + animType);
            CheckAnimName("vm_machete_t9" + specificGunOps + animType);
            CheckAnimName("vm_minigun_t9" + specificGunOps + animType);
            CheckAnimName("vm_nailgun_t9" + specificGunOps + animType);
            CheckAnimName("vm_pistol_burst_t9" + specificGunOps + animType);
            CheckAnimName("vm_pistol_fullauto_t9" + specificGunOps + animType);
            CheckAnimName("vm_pistol_revolver_t9" + specificGunOps + animType);
            CheckAnimName("vm_pistol_semiauto_t9" + specificGunOps + animType);
            CheckAnimName("vm_pistol_shotgun_t9" + specificGunOps + animType);
            CheckAnimName("vm_ray_gun_t9" + specificGunOps + animType);
            CheckAnimName("vm_scythe_t9" + specificGunOps + animType);
            CheckAnimName("vm_semtex_grenade_t9" + specificGunOps + animType);
            CheckAnimName("vm_shotgun_fullauto_t9" + specificGunOps + animType);
            CheckAnimName("vm_shotgun_leveraction_t9" + specificGunOps + animType);
            CheckAnimName("vm_shotgun_pump_t9" + specificGunOps + animType);
            CheckAnimName("vm_shotgun_semiauto_t9" + specificGunOps + animType);
            CheckAnimName("vm_sledgehammer_t9" + specificGunOps + animType);
            CheckAnimName("vm_smg_accurate_t9" + specificGunOps + animType);
            CheckAnimName("vm_smg_burst_t9" + specificGunOps + animType);
            CheckAnimName("vm_smg_capacity_t9" + specificGunOps + animType);
            CheckAnimName("vm_smg_cqb_t9" + specificGunOps + animType);
            CheckAnimName("vm_smg_fastfire_t9" + specificGunOps + animType);
            CheckAnimName("vm_smg_flechette_t9" + specificGunOps + animType);
            CheckAnimName("vm_smg_handling_t9" + specificGunOps + animType);
            CheckAnimName("vm_smg_heavy_t9" + specificGunOps + animType);
            CheckAnimName("vm_smg_season6_t9" + specificGunOps + animType);
            CheckAnimName("vm_smg_semiauto_t9" + specificGunOps + animType);
            CheckAnimName("vm_smg_spray_t9" + specificGunOps + animType);
            CheckAnimName("vm_smg_standard_t9" + specificGunOps + animType);
            CheckAnimName("vm_smoke_grenade_t9" + specificGunOps + animType);
            CheckAnimName("vm_sniper_accurate_t9" + specificGunOps + animType);
            CheckAnimName("vm_sniper_cannon_t9" + specificGunOps + animType);
            CheckAnimName("vm_sniper_powersemi_t9" + specificGunOps + animType);
            CheckAnimName("vm_sniper_quickscope_t9" + specificGunOps + animType);
            CheckAnimName("vm_sniper_standard_t9" + specificGunOps + animType);
            CheckAnimName("vm_special_grenade_launcher" + specificGunOps + animType);
            CheckAnimName("vm_tr_damagesemi_t9" + specificGunOps + animType);
            CheckAnimName("vm_tr_fastburst_t9" + specificGunOps + animType);
            CheckAnimName("vm_tr_longburst_t9" + specificGunOps + animType);
            CheckAnimName("vm_tr_powerburst_t9" + specificGunOps + animType);
            CheckAnimName("vm_tr_precisionsemi_t9" + specificGunOps + animType);
            CheckAnimName("vm_wakizashi_t9" + specificGunOps + animType);
            CheckAnimName("vm_zm_crystal_axe_melee_t9" + specificGunOps + animType);
            CheckAnimName("vm_zm_crystal_axe_smg_t9" + specificGunOps + animType);
            CheckAnimName("vm_zm_mega_barrel_blazer_beam_t9" + specificGunOps + animType);
            CheckAnimName("vm_zm_mega_barrel_micro_missile_t9" + specificGunOps + animType);
            CheckAnimName("vm_zm_mega_barrel_pistol_t9" + specificGunOps + animType);
            CheckAnimName("vm_zm_ray_rifle_t9" + specificGunOps + animType);
            CheckAnimName("vm_zm_silver_ww_t9" + specificGunOps + animType);
        }
    }
    foreach (string modelType in ModelTypes)
    {
        // CW Operator Models & Skins
        CheckModelName("" + specificGunOps + modelType);
        CheckModelName("c_t9_aml_komodo_dragon" + specificGunOps + modelType);
        CheckModelName("c_t9_aml_rabbit" + specificGunOps + modelType);
        CheckModelName("c_t9_aml_rottweiler" + specificGunOps + modelType);
        CheckModelName("c_t9_aml_snow_leopard" + specificGunOps + modelType);
        CheckModelName("c_t9_base_female_nude" + specificGunOps + modelType);
        CheckModelName("c_t9_base_male_nude_2" + specificGunOps + modelType);
        CheckModelName("c_t9_base_male_nude_buff" + specificGunOps + modelType);
        CheckModelName("c_t9_cp_rus_pl_f_agent_global_infil_combat" + specificGunOps + modelType);
        CheckModelName("c_t9_cp_rus_pl_f_agent_hub_infil" + specificGunOps + modelType);
        CheckModelName("c_t9_cp_rus_pl_f_agent_nam_infil_combat" + specificGunOps + modelType);
        CheckModelName("c_t9_cp_rus_pl_m_agent_global_infil_combat" + specificGunOps + modelType);
        CheckModelName("c_t9_cp_rus_pl_m_agent_global_undrcvr_civ" + specificGunOps + modelType);
        CheckModelName("c_t9_cp_rus_pl_m_agent_hub_infil_combat" + specificGunOps + modelType);
        CheckModelName("c_t9_cp_usa_pl_mason_infil_takedown" + specificGunOps + modelType);
        CheckModelName("c_t9_cp_usa_pl_mason_yam_winter" + specificGunOps + modelType);
        CheckModelName("c_t9_cub_pl_dgi_barrio" + specificGunOps + modelType);
        CheckModelName("c_t9_cub_pl_dgi_bongo" + specificGunOps + modelType);
        CheckModelName("c_t9_cub_pl_dgi_brawler" + specificGunOps + modelType);
        CheckModelName("c_t9_cub_pl_dgi_commando" + specificGunOps + modelType);
        CheckModelName("c_t9_cub_pl_dgi_el_jefe" + specificGunOps + modelType);
        CheckModelName("c_t9_cub_pl_dgi_flick" + specificGunOps + modelType);
        CheckModelName("c_t9_cub_pl_dgi_general" + specificGunOps + modelType);
        CheckModelName("c_t9_cub_pl_dgi_havana" + specificGunOps + modelType);
        CheckModelName("c_t9_cub_pl_dgi_hitman" + specificGunOps + modelType);
        CheckModelName("c_t9_cub_pl_dgi_infiltration" + specificGunOps + modelType);
        CheckModelName("c_t9_cub_pl_dgi_jack" + specificGunOps + modelType);
        CheckModelName("c_t9_cub_pl_dgi_jack_ms" + specificGunOps + modelType);
        CheckModelName("c_t9_cub_pl_dgi_jack_pc" + specificGunOps + modelType);
        CheckModelName("c_t9_cub_pl_dgi_jack_sy" + specificGunOps + modelType);
        CheckModelName("c_t9_cub_pl_dgi_lucha" + specificGunOps + modelType);
        CheckModelName("c_t9_cub_pl_dgi_mechanic" + specificGunOps + modelType);
        CheckModelName("c_t9_cub_pl_dgi_rebel_leader" + specificGunOps + modelType);
        CheckModelName("c_t9_cub_pl_dgi_sicario" + specificGunOps + modelType);
        CheckModelName("c_t9_cub_pl_dgi_slasher" + specificGunOps + modelType);
        CheckModelName("c_t9_cub_pl_dgi_tropas_ms" + specificGunOps + modelType);
        CheckModelName("c_t9_cub_pl_dgi_tropas_pc" + specificGunOps + modelType);
        CheckModelName("c_t9_cub_pl_dgi_tropas_sy" + specificGunOps + modelType);
        CheckModelName("c_t9_cub_pl_dgi_warlord" + specificGunOps + modelType);
        CheckModelName("c_t9_eg_pl_quicksand" + specificGunOps + modelType);
        CheckModelName("c_t9_eg_pl_quicksand_khopesh" + specificGunOps + modelType);
        CheckModelName("c_t9_eg_pl_quicksand_slither" + specificGunOps + modelType);
        CheckModelName("c_t9_esp_pl_goe_bomber" + specificGunOps + modelType);
        CheckModelName("c_t9_esp_pl_goe_bomber_scrapmetal" + specificGunOps + modelType);
        CheckModelName("c_t9_fin_pl_wraith" + specificGunOps + modelType);
        CheckModelName("c_t9_fin_pl_wraith_automaton" + specificGunOps + modelType);
        CheckModelName("c_t9_fin_pl_wraith_burnout" + specificGunOps + modelType);
        CheckModelName("c_t9_fin_pl_wraith_freya" + specificGunOps + modelType);
        CheckModelName("c_t9_fin_pl_wraith_havoc" + specificGunOps + modelType);
        CheckModelName("c_t9_fin_pl_wraith_white_queen" + specificGunOps + modelType);
        CheckModelName("c_t9_fra_pl_dgse_amped" + specificGunOps + modelType);
        CheckModelName("c_t9_fra_pl_dgse_arc" + specificGunOps + modelType);
        CheckModelName("c_t9_fra_pl_dgse_dakar" + specificGunOps + modelType);
        CheckModelName("c_t9_fra_pl_dgse_gign" + specificGunOps + modelType);
        CheckModelName("c_t9_fra_pl_dgse_infiltration" + specificGunOps + modelType);
        CheckModelName("c_t9_fra_pl_dgse_mademoiselle" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_female" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_female_ms" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_female_pc" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_female_sy" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_male_ms" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_male_pc" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_male_sy" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_empire_ms" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_empire_pc" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_empire_sy" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_faze_ms" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_faze_pc" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_faze_sy" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_guerillas_ms" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_guerillas_pc" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_guerillas_sy" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_legion_ms" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_legion_pc" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_legion_sy" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_mutineers_ms" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_mutineers_pc" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_mutineers_sy" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_optic_ms" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_optic_pc" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_optic_sy" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_rokkr_ms" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_rokkr_pc" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_rokkr_sy" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_royalravens_ms" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_royalravens_pc" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_royalravens_sy" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_subliners_ms" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_subliners_pc" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_subliners_sy" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_surge_ms" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_surge_pc" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_surge_sy" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_thieves_ms" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_thieves_pc" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_thieves_sy" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_ultra_ms" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_ultra_pc" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_esports_watch_ultra_sy" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter1" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter1_hunter_dash" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter1_hunter_eagleeye" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter1_hunter_frontline" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter1_hunter_inferno" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter1_hunter_killer" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter1_hunter_rescue" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter2" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter2_vargas_bacano" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter2_vargas_bull_bull_ms" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter2_vargas_bull_bull_pc" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter2_vargas_bull_bull_sy" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter2_vargas_bunker" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter2_vargas_finishline" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter2_vargas_major" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter2_vargas_steel" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter2_vargas_stovepipe" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter3" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter3_stone_ash" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter3_stone_bollocks_ms" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter3_stone_bollocks_pc" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter3_stone_bollocks_sy" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter3_stone_bugscreen" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter3_stone_carver" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter3_stone_infestation" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter3_stone_insurgent" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter3_stone_jammy" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter3_stone_ripper" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter3_stone_seige" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter3_stone_squelch" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter3_stone_stoned" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter3_stone_storefront" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter4" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter4_song_backflip" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter4_song_bloom" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter4_song_busted" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter4_song_counter" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter4_song_dagger" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter4_song_flare" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter4_song_mechanic_ms" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter4_song_mechanic_pc" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter4_song_mechanic_sy" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter4_song_observer" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter4_song_tiger" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter5" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter5_powers_cameroon" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter5_powers_desert" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter5_powers_driver" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter5_powers_dust" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter5_powers_ffl" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter5_powers_gun" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter5_powers_stealth" + specificGunOps + modelType);
        CheckModelName("c_t9_gen_pl_starter5_powers_swift" + specificGunOps + modelType);
        CheckModelName("c_t9_ger_pl_maxis_berlin" + specificGunOps + modelType);
        CheckModelName("c_t9_ger_pl_maxis_bride" + specificGunOps + modelType);
        CheckModelName("c_t9_ger_pl_maxis_dark" + specificGunOps + modelType);
        CheckModelName("c_t9_ger_pl_maxis_lumens" + specificGunOps + modelType);
        CheckModelName("c_t9_ger_pl_maxis_phantom" + specificGunOps + modelType);
        CheckModelName("c_t9_ger_pl_maxis_scythe" + specificGunOps + modelType);
        CheckModelName("c_t9_ger_pl_maxis_traveler" + specificGunOps + modelType);
        CheckModelName("c_t9_ger_pl_west_bomber" + specificGunOps + modelType);
        CheckModelName("c_t9_ger_pl_west_carnage" + specificGunOps + modelType);
        CheckModelName("c_t9_ger_pl_west_gothic" + specificGunOps + modelType);
        CheckModelName("c_t9_ger_pl_west_gsg9_3" + specificGunOps + modelType);
        CheckModelName("c_t9_ger_pl_west_gsg9_hardhat" + specificGunOps + modelType);
        CheckModelName("c_t9_ger_pl_west_infiltration" + specificGunOps + modelType);
        CheckModelName("c_t9_ger_pl_west_judge_dredd" + specificGunOps + modelType);
        CheckModelName("c_t9_ger_pl_west_klown" + specificGunOps + modelType);
        CheckModelName("c_t9_ger_pl_west_nightops" + specificGunOps + modelType);
        CheckModelName("c_t9_ger_pl_west_paratrooper" + specificGunOps + modelType);
        CheckModelName("c_t9_ger_pl_west_patrol" + specificGunOps + modelType);
        CheckModelName("c_t9_ger_pl_west_police" + specificGunOps + modelType);
        CheckModelName("c_t9_ger_pl_west_professor" + specificGunOps + modelType);
        CheckModelName("c_t9_ger_pl_west_racer" + specificGunOps + modelType);
        CheckModelName("c_t9_ger_pl_west_raider" + specificGunOps + modelType);
        CheckModelName("c_t9_ger_pl_west_stalker" + specificGunOps + modelType);
        CheckModelName("c_t9_ger_pl_west_stealth" + specificGunOps + modelType);
        CheckModelName("c_t9_ger_pl_west_stronghold" + specificGunOps + modelType);
        CheckModelName("c_t9_ger_pl_west_swat" + specificGunOps + modelType);
        CheckModelName("c_t9_ger_pl_west_tagger_ii" + specificGunOps + modelType);
        CheckModelName("c_t9_ger_pl_west_winter" + specificGunOps + modelType);
        CheckModelName("c_t9_isr_pl_lazar_idf" + specificGunOps + modelType);
        CheckModelName("c_t9_jpn_pl_kitsune" + specificGunOps + modelType);
        CheckModelName("c_t9_jpn_pl_kitsune_biteme" + specificGunOps + modelType);
        CheckModelName("c_t9_jpn_pl_kitsune_boss" + specificGunOps + modelType);
        CheckModelName("c_t9_jpn_pl_kitsune_ultra" + specificGunOps + modelType);
        CheckModelName("c_t9_jpn_pl_kitsune_yokai" + specificGunOps + modelType);
        CheckModelName("c_t9_lao_pl_serpent" + specificGunOps + modelType);
        CheckModelName("c_t9_lao_pl_serpent_haggler" + specificGunOps + modelType);
        CheckModelName("c_t9_lao_pl_serpent_hollow" + specificGunOps + modelType);
        CheckModelName("c_t9_lao_pl_serpent_overgrowth" + specificGunOps + modelType);
        CheckModelName("c_t9_lao_pl_serpent_shadow" + specificGunOps + modelType);
        CheckModelName("c_t9_lao_pl_serpent_warlord" + specificGunOps + modelType);
        CheckModelName("c_t9_nic_pl_smuggler" + specificGunOps + modelType);
        CheckModelName("c_t9_nic_pl_smuggler_mural" + specificGunOps + modelType);
        CheckModelName("c_t9_nic_pl_smuggler_stinger" + specificGunOps + modelType);
        CheckModelName("c_t9_nic_pl_smuggler_whiskey" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_f_agent_global_undrcvr_civ" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_f_agent_global_undrcvr_civ_asian" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_f_agent_global_undrcvr_civ_asian2" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_f_agent_global_undrcvr_civ_black" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_f_agent_global_undrcvr_civ_black2" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_f_agent_global_undrcvr_civ_mideast" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_f_agent_global_undrcvr_civ_mideast2" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_f_agent_global_undrcvr_civ_white" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_f_agent_global_undrcvr_civ_white2" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_f_agent_kgb_exfil_asian" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_f_agent_kgb_exfil_asian2" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_f_agent_kgb_exfil_black" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_f_agent_kgb_exfil_black2" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_f_agent_kgb_exfil_mideast" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_f_agent_kgb_exfil_mideast2" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_f_agent_kgb_exfil_white" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_f_agent_kgb_exfil_white2" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_f_agent_kgb_undrcvr_asian" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_f_agent_kgb_undrcvr_asian2" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_f_agent_kgb_undrcvr_black" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_f_agent_kgb_undrcvr_black2" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_f_agent_kgb_undrcvr_mideast" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_f_agent_kgb_undrcvr_mideast2" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_f_agent_kgb_undrcvr_white" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_f_agent_kgb_undrcvr_white2" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_m_agent_kgb_officer_exfil" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_m_agent_kgb_officer_exfil_asian" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_m_agent_kgb_officer_exfil_asian2" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_m_agent_kgb_officer_exfil_black" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_m_agent_kgb_officer_exfil_black2" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_m_agent_kgb_officer_exfil_body_asian" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_m_agent_kgb_officer_exfil_body_asian2" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_m_agent_kgb_officer_exfil_body_black" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_m_agent_kgb_officer_exfil_body_black2" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_m_agent_kgb_officer_exfil_body_mideast" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_m_agent_kgb_officer_exfil_body_mideast2" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_m_agent_kgb_officer_exfil_body_white" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_m_agent_kgb_officer_exfil_body_white2" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_m_agent_kgb_officer_exfil_mideast" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_m_agent_kgb_officer_exfil_mideast2" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_m_agent_kgb_officer_exfil_white" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_m_agent_kgb_officer_exfil_white2" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_m_agent_undcvr_kgb_guard" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_m_agent_undcvr_kgb_guard_asian" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_m_agent_undcvr_kgb_guard_asian2" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_m_agent_undcvr_kgb_guard_black" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_m_agent_undcvr_kgb_guard_black2" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_m_agent_undcvr_kgb_guard_mideast" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_m_agent_undcvr_kgb_guard_mideast2" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_m_agent_undcvr_kgb_guard_white" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_m_agent_undcvr_kgb_guard_white2" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_m_agent_undcvr_takedown" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_m_agent_undcvr_takedown_body" + specificGunOps + modelType);
        CheckModelName("c_t9_pl_mason_infil_stealth_viewmodel" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_kgb_assassin" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_kgb_breakout" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_kgb_bunny" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_kgb_burglar" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_kgb_funnybone" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_kgb_ghost" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_kgb_gunshow" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_kgb_hash" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_kgb_infantry" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_kgb_infiltration" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_kgb_lab" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_kgb_mach1_ms" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_kgb_mach1_pc" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_kgb_mach1_sy" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_kgb_poison" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_kgb_punk" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_kgb_shadow" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_kgb_smoker" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_kgb_spyglass" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_kgb_tacticalgoth" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_kgb_thekid" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_kgb_urban" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_kgb_valentines" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_kgb_winter" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_mason_winter_yam" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_spetsnaz_afghan_sniper" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_spetsnaz_chernobyl" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_spetsnaz_grudge" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_spetsnaz_infiltration" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_spetsnaz_melted" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_stitch_01" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_stitch_brute" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_stitch_cultist" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_stitch_cultist_ms" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_stitch_cultist_pc" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_stitch_cultist_sy" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_stitch_echo" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_stitch_manga" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_stitch_prisoner" + specificGunOps + modelType);
        CheckModelName("c_t9_rus_pl_stitch_torn" + specificGunOps + modelType);
        CheckModelName("c_t9_sa_pl_deathstalker" + specificGunOps + modelType);
        CheckModelName("c_t9_sa_pl_deathstalker_bearclaw" + specificGunOps + modelType);
        CheckModelName("c_t9_sa_pl_deathstalker_bearclaw_ms" + specificGunOps + modelType);
        CheckModelName("c_t9_sa_pl_deathstalker_bearclaw_pc" + specificGunOps + modelType);
        CheckModelName("c_t9_sa_pl_deathstalker_bearclaw_sy" + specificGunOps + modelType);
        CheckModelName("c_t9_sa_pl_deathstalker_snake" + specificGunOps + modelType);
        CheckModelName("c_t9_uk_pl_kingsley" + specificGunOps + modelType);
        CheckModelName("c_t9_uk_pl_mi6_aftermath" + specificGunOps + modelType);
        CheckModelName("c_t9_uk_pl_mi6_badblood" + specificGunOps + modelType);
        CheckModelName("c_t9_uk_pl_mi6_checker" + specificGunOps + modelType);
        CheckModelName("c_t9_uk_pl_mi6_clandestine" + specificGunOps + modelType);
        CheckModelName("c_t9_uk_pl_mi6_coal" + specificGunOps + modelType);
        CheckModelName("c_t9_uk_pl_mi6_derby" + specificGunOps + modelType);
        CheckModelName("c_t9_uk_pl_mi6_doubleagent" + specificGunOps + modelType);
        CheckModelName("c_t9_uk_pl_mi6_dystopia" + specificGunOps + modelType);
        CheckModelName("c_t9_uk_pl_mi6_fob" + specificGunOps + modelType);
        CheckModelName("c_t9_uk_pl_mi6_football" + specificGunOps + modelType);
        CheckModelName("c_t9_uk_pl_mi6_glam" + specificGunOps + modelType);
        CheckModelName("c_t9_uk_pl_mi6_guard" + specificGunOps + modelType);
        CheckModelName("c_t9_uk_pl_mi6_handler" + specificGunOps + modelType);
        CheckModelName("c_t9_uk_pl_mi6_heist" + specificGunOps + modelType);
        CheckModelName("c_t9_uk_pl_mi6_ignite" + specificGunOps + modelType);
        CheckModelName("c_t9_uk_pl_mi6_infiltration" + specificGunOps + modelType);
        CheckModelName("c_t9_uk_pl_mi6_napalm" + specificGunOps + modelType);
        CheckModelName("c_t9_uk_pl_mi6_racer" + specificGunOps + modelType);
        CheckModelName("c_t9_uk_pl_mi6_scorch" + specificGunOps + modelType);
        CheckModelName("c_t9_uk_pl_mi6_sis" + specificGunOps + modelType);
        CheckModelName("c_t9_uk_pl_mi6_skyhook_ms" + specificGunOps + modelType);
        CheckModelName("c_t9_uk_pl_mi6_skyhook_pc" + specificGunOps + modelType);
        CheckModelName("c_t9_uk_pl_mi6_skyhook_sy" + specificGunOps + modelType);
        CheckModelName("c_t9_uk_pl_mi6_snapshot" + specificGunOps + modelType);
        CheckModelName("c_t9_uk_pl_mi6_standoff" + specificGunOps + modelType);
        CheckModelName("c_t9_uk_pl_mi6_survivor" + specificGunOps + modelType);
        CheckModelName("c_t9_uk_pl_mi6_tagger" + specificGunOps + modelType);
        CheckModelName("c_t9_uk_pl_mi6_uncharted" + specificGunOps + modelType);
        CheckModelName("c_t9_uk_pl_mi6_xray" + specificGunOps + modelType);
        CheckModelName("c_t9_uk_pl_price" + specificGunOps + modelType);
        CheckModelName("c_t9_uk_pl_sas_blackknight" + specificGunOps + modelType);
        CheckModelName("c_t9_uk_pl_sas_gridlock" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_adler_airborne" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_adler_buoy" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_adler_control" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_adler_detective" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_adler_detective_ms" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_adler_detective_pc" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_adler_detective_sy" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_adler_game_fuel" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_adler_gator" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_adler_gunslinger" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_adler_hostage" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_adler_infiltration" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_adler_lancer" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_adler_miami" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_adler_pressed" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_adler_ranger" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_adler_red" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_adler_renegade" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_adler_slayer" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_adler_tropic" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_adler_vbss" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_adler_wire" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_bulldozer_01" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_bulldozer_boom" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_bulldozer_forged" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_bulldozer_hawk" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_bulldozer_panda" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_bulldozer_toxin" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_cia_adler_bloodhound" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_cia_adler_traveler" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_cia_advisor" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_cia_agent" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_cia_big_joke_3" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_cia_boss" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_cia_captain" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_cia_climber" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_cia_commando" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_cia_covert" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_cia_grit" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_cia_infiltration" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_cia_kick" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_cia_logger" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_cia_macv" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_cia_macv_code_ms" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_cia_macv_code_pc" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_cia_macv_code_sy" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_cia_penumbra_ms" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_cia_penumbra_pc" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_cia_penumbra_sy" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_cia_regulator" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_cia_snatch" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_cia_sogman" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_cia_tee" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_deltaforce_brutalist" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_deltaforce_brutalist_ms" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_deltaforce_brutalist_pc" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_deltaforce_brutalist_sy" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_deltaforce_cyclone" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_deltaforce_dynamite" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_deltaforce_halo" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_deltaforce_infiltration" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_deltaforce_infiltration_body" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_deltaforce_jungle_warfare" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_deltaforce_urgentfury" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_ghostface" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_hudson" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_hudson_hazmat_ms" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_hudson_hazmat_pc" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_hudson_hazmat_sy" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_hudson_rock" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_mason" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_mason_ultra" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_masongame" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_mcclane" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_navyseal_air_ms" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_navyseal_air_pc" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_navyseal_air_sy" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_navyseal_blue_devil" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_navyseal_breaker" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_navyseal_business" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_navyseal_clown" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_navyseal_dissident" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_navyseal_endurance_ms" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_navyseal_endurance_pc" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_navyseal_endurance_sy" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_navyseal_frank" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_navyseal_frogman" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_navyseal_gigawatt" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_navyseal_grip" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_navyseal_grunge" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_navyseal_hopper" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_navyseal_hunter" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_navyseal_infiltration" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_navyseal_knucklehead" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_navyseal_land_ms" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_navyseal_land_pc" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_navyseal_land_sy" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_navyseal_maverick" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_navyseal_ringleader" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_navyseal_sea_ms" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_navyseal_sea_pc" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_navyseal_sea_sy" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_navyseal_slugger" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_navyseal_sniper" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_navyseal_solitude" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_navyseal_strike" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_navyseal_wolf" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_rambo" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_spy_female_investigator" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_spy_investigator" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_surge" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_surge_meta" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_vip" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_vip2_axis_side" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_weaver_aftermath" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_weaver_cosmodrome" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_weaver_rebirth" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_weaver_sonsoforda" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_woods_biker" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_woods_conquer" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_woods_dapper" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_woods_dope" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_woods_eagleclaw" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_woods_eliminator" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_woods_fisherman" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_woods_haha" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_woods_holidaywoods" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_woods_infiltration" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_woods_mellow" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_woods_payback" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_woods_pow" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_woods_pow_body" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_woods_rogue" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_woods_sandstorm" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_woods_slaughter" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_woods_swamp" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_woods_trucker" + specificGunOps + modelType);
        CheckModelName("c_t9_usa_pl_woods_whirlwind" + specificGunOps + modelType);
        // CW Weapon Models & Blueprints
        CheckModelName("wpn_t9_ar_damage" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damage_8bit" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damage_achill" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damage_animedark" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damage_arvnr1" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damage_batts" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damage_catbud" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damage_champs_ms" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damage_champs_pc" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damage_champs_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damage_checkmate" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damage_chrome" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damage_cubarevo" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damage_czar" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damage_evil" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damage_go_bananas" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damage_grey_ranger" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damage_halloween" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damage_heartbreak" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damage_modernp" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damage_moonshine" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damage_motocross" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damage_nightf" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damage_ole" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damage_penumbra" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damage_psa" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damage_ram" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damage_resist" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damage_roadwar" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damage_s05challenge_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damage_strace" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damage_tchern" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damage_ufo" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damage_wargames" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damage_yokai" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_damagenificent" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire_animeskater" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire_arcade" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire_bowling" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire_bwarrior_ms" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire_bwarrior_pc" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire_bwarrior_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire_dbreath" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire_dynasty" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire_egyptian" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire_guerilla" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire_hcover" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire_hollywood" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire_jet" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire_junglewarfare" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire_kwanzaa" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire_legion_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire_leprecon" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire_lifesaver" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire_maneater" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire_medical" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire_ninja" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire_nugget" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire_opulence" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire_reactor" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire_renegade" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire_smoulder" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire_spacehead" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire_stamp" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire_ultrafunk" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire_wsow_ms" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire_wsow_pc" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire_wsow_solo" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire_wsow_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_fastfire_zombied" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6_ace" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6_bee" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6_blazer" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6_boar_ms" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6_boar_pc" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6_boar_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6_burgertown" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6_cdl_ms" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6_cdl_pc" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6_cdl_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6_coyote" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6_darkaether" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6_dragon" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6_draid" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6_especial" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6_fchance" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6_glitch" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6_ilazar" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6_leagueplay" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6_lfg" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6_midnight_express" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6_rbaron" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6_rdecree" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6_rebel" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6_rebirth" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6_redbaron" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6_royal" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6_space" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6_spirit" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6_stitch" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6_surge" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6_tagger3" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6_typhoon" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_krig6_undead" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_animemon" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_arabian" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_armored" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_brutus" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_caiman" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_carolina" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_charden" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_codemam" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_codemam_ms" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_codemam_pc" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_codemam_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_declar" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_devilwoman" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_firework" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_frogmen" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_gigaswatt" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_gladia" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_hologram" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_jester" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_junglec" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_knight" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_law" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_leagueplay" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_mrfix" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_mvs" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_oktober" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_poison" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_predator" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_resist" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_spacegun" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_titanium" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_voodoo" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_wasteland" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_wonder" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_wonder_catapillar" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_zenya" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_zslayer" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mercenary_ztheme" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mobility" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mobility_aagirl" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mobility_arcticwind" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mobility_bloodhawk_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mobility_camera" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mobility_colds" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mobility_commando" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mobility_ddaemon" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mobility_dfoilage" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mobility_electro" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mobility_fastlane" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mobility_fchina2" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mobility_firestorm" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mobility_flashf" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mobility_frostbite" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mobility_gaudy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mobility_importer" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mobility_lochness" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mobility_lucha" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mobility_lunar" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mobility_milboots" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mobility_muerte" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mobility_nature" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mobility_peace" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mobility_poseidon" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mobility_shark" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mobility_sneaker" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mobility_soul" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mobility_supers" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mobility_tattoo" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ar_mobility_wanker" + specificGunOps + modelType);
        CheckModelName("wpn_t9_boomstick_prop_weapon" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_ar_damage_bthroat" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_ar_damage_confront_ms" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_ar_damage_confront_pc" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_ar_damage_confront_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_ar_damage_fires" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_ar_damage_nocturne" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_ar_damage_tagger" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_ar_damage_vcp" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_ar_fastfire_aconstrictor" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_ar_fastfire_carbongold_ms" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_ar_fastfire_carbongold_pc" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_ar_fastfire_carbongold_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_ar_fastfire_mallrat" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_ar_fastfire_sterile" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_ar_fastfire_street" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_ar_krig6_ace" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_ar_krig6_confront" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_ar_krig6_eclipse" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_ar_krig6_geo_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_ar_krig6_opulence" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_ar_krig6_reaper" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_ar_krig6_rebirth" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_ar_krig6_samurai" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_ar_mercenary_bluereaper" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_ar_mercenary_miami" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_ar_mercenary_rifleer" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_ar_mercenary_sea_ms" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_ar_mercenary_sea_pc" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_ar_mercenary_sea_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_ar_mercenary_tagger" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_ar_mobility_spirit" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_lmg_accurate_cb_opulence" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_lmg_light" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_lmg_light_bcowboy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_lmg_light_beachcomber" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_lmg_light_gambit" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_lmg_light_six" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_lmg_light_trawler" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_loot_ar_fasthandling_sterile" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_loot_ar_slowfire_muzzle_waterpark" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_loot_ar_slowfire_waterpark" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_loot_ar_slowhandling_420" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_loot_shotgun_fullauto_maelstrom" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_loot_shotgun_fullauto_red" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_loot_smg_accurate_jet" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_loot_smg_fastfire_gknight" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_loot_smg_spray_jetfighter" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_pistol_burst_avalanche" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_pistol_burst_cb_bullshark" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_pistol_burst_cb_dw_primal_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_pistol_burst_cb_rbaron" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_pistol_burst_devil" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_pistol_burst_primal_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_pistol_revolver_84" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_pistol_revolver_adder" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_pistol_revolver_noir" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_pistol_revolver_scorpion" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_pistol_revolver_six" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_pistol_semiauto_air_dw_ms" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_pistol_semiauto_air_dw_pc" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_pistol_semiauto_air_dw_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_pistol_semiauto_air_ms" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_pistol_semiauto_air_pc" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_pistol_semiauto_air_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_pistol_semiauto_arvnr1_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_pistol_semiauto_code_dw_ms" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_pistol_semiauto_code_dw_pc" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_pistol_semiauto_code_dw_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_pistol_semiauto_code_ms" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_pistol_semiauto_code_pc" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_pistol_semiauto_code_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_pistol_semiauto_dw_fixit" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_pistol_semiauto_fixit" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_pistol_semiauto_midnight" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_pistol_semiauto_mvice" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_pistol_semiauto_rifleer" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_pistol_semiauto_teal" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_shotgun_pump_land_ms" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_shotgun_pump_land_pc" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_shotgun_pump_land_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_shotgun_pump_nightfall" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_shotgun_pump_nt6_bus" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_shotgun_pump_ripper" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_shotgun_pump_schwagger" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_shotgun_semiauto_cb_gnr" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_shotgun_semiauto_cb_predator" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_shotgun_semiauto_cb_taffy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_shotgun_semiauto_cb_valya" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_shotgun_semiauto_cb_zslayer" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_shotgun_semiauto_uglysweater" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_smg_burst_absinthe" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_smg_burst_flak" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_smg_burst_forged" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_smg_burst_kwanzaa" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_smg_burst_mechanic" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_smg_burst_red" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_smg_burst_runman" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_smg_capacity_alleywayamb" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_smg_capacity_bluereaper" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_smg_capacity_fulltank" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_smg_capacity_gcompany" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_smg_capacity_muzzle_bluereaper" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_smg_capacity_prpsunder" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_smg_capacity_rocketscience" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_smg_handling_avalanche" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_smg_handling_beta" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_smg_handling_density" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_smg_handling_schwagger" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_smg_heavy_brawler" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_smg_heavy_dinotoy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_smg_heavy_polar" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_smg_heavy_smdest" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_smg_standard_cb_blkmamba" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_smg_standard_cb_bwidow" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_smg_standard_cb_crypto" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_smg_standard_cb_urbangold" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_smg_standard_roman" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_sniper_powersemi_frostbite" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_sniper_powersemi_frostbite_frontend" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_sniper_powersemi_scope_ads_frostbite" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_sniper_powersemi_scope_frostbite" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_sniper_quickscope_collectors" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_sniper_quickscope_collectors_scope" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_sniper_quickscope_scope_collectors_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_sniper_standard_crypto" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_sniper_standard_crypto_scope" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_sniper_standard_crypto_scope_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_sniper_standard_ghostwood" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_sniper_standard_ghostwood_scope" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_sniper_standard_ghostwood_scope_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_sniper_standard_moa_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_sniper_standard_scope_ads_moa_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_sniper_standard_scope_ads_urbangold" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_sniper_standard_scope_crypto" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_sniper_standard_scope_ghostwood" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_sniper_standard_scope_moa_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_sniper_standard_scope_teal" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_sniper_standard_scope_urbangold" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_sniper_standard_teal" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_sniper_standard_teal_scope" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_sniper_standard_teal_scope_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_sniper_standard_urbangold" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_damagesemi_adder" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_damagesemi_armyrv" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_damagesemi_bwidow" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_damagesemi_crowstorm_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_damagesemi_fighter" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_damagesemi_six" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_damagesemi_soviet_ops" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_longburst_code_ms" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_longburst_code_pc" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_longburst_code_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_longburst_confront_ms" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_longburst_confront_pc" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_longburst_confront_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_longburst_gaudy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_longburst_pink" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_longburst_resp" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_longburst_twotone" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_longburst_verde" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_powerburst_cb_cupid" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_powerburst_cb_lurker" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_powerburst_cb_midnight_xp" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_powerburst_cb_racer02" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_powerburst_cb_scope_ads_lurker" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_powerburst_cb_scope_ads_midnight_xp" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_powerburst_cb_scope_ads_target_practice" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_powerburst_cb_scope_cupid" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_powerburst_cb_scope_cupid_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_powerburst_cb_scope_fcarbon" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_powerburst_cb_scope_fcarbon_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_powerburst_cb_scope_lunar" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_powerburst_cb_scope_lunar_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_powerburst_cb_scope_lurker" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_powerburst_cb_scope_midnight_xp" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_powerburst_cb_scope_racer02" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_powerburst_cb_scope_racer02_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_powerburst_cb_scope_target_practice" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_powerburst_cb_target_practice" + specificGunOps + modelType);
        CheckModelName("wpn_t9_bp_tr_precisionsemi_arrow" + specificGunOps + modelType);
        CheckModelName("wpn_t9_cigar_prop" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_ammo_pack" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_ammo_pack_fx2" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_ammo_pack_fx_ammo1" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_ammo_pack_fx_base" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_ammo_pack_fx_bigmag" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_ammo_pack_fx_cover" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_ammo_pack_prop" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_ammo_pack_prop_cac" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_armor_plate" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_ascender" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_claymore" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_data_pad" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_flashbang" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_flashbang_projectile" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_garrot_wire_prop_weapon" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_gersh_device" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_grenade_concussion" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_grenade_concussion_projectile" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_grenade_decoy_projectile" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_grenade_frag" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_grenade_frag_projectile" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_grenade_frag_prop_weapon" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_grenade_semtex" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_grenade_semtex_projectile" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_hatchet" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_hatchet_projectile" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_hatchet_prop_weapon" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_jammer" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_jammer_fx_base" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_jammer_fx_left_panel" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_jammer_fx_round_atenna" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_jammer_fx_small_atenna" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_jammer_fx_tiny_atenna" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_land_mine" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_listening_device" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_listening_device_fx_dish" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_listening_device_fx_leg" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_listening_device_fx_mic" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_listening_device_fx_radio" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_map_streak" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_medical_injection_sml" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_mobile_cover" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_molotov" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_nightingale" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_nightingale_projectile" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_parachute" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_rcxd_remote" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_satchel_charge" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_satchel_charge_clacker" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_satchel_charge_projectile" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_small_radio" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_smoke_grenade" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_smoke_grenade_projectile" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_smoke_grenade_red" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_smoke_grenade_yellow" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_teargas_mine" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_teargas_mine_fx_cap" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_teargas_mine_fx_lever" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_teargas_mine_fx_pin_1" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_teargas_mine_fx_pin_2" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_teargas_mine_fx_pin_3" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_teargas_mine_sprung" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_trophy_system" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_trophy_system_fx_head_01" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_trophy_system_fx_leg_01" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_trophy_system_fx_main" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_trophy_system_fx_plate" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_trophy_system_knob_01" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_ultimate_turret" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_ultimate_turret_fx_ammo" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_ultimate_turret_fx_barrel" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_ultimate_turret_fx_camera" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_ultimate_turret_fx_handle" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_ultimate_turret_fx_legs" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_ultimate_turret_fx_main" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_ultimate_turret_pickup" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_ultimate_turret_prop" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_vip_harness" + specificGunOps + modelType);
        CheckModelName("wpn_t9_eqp_zipline_trolley" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ges_bottle_vodka_accessory" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ges_bullet_127_108mm_cartridge" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ges_bunny_reaper_accessory" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ges_ferrofluid_accessory" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ges_fortunecookie_accessory" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ges_jack_o_lantern_accessory" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ges_microphone_accessory" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ges_scorpion_accessory" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ges_teabag_accessory" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ges_zombie_arm_accessory" + specificGunOps + modelType);
        CheckModelName("wpn_t9_ges_zombie_head_accessory" + specificGunOps + modelType);
        CheckModelName("wpn_t9_grenade_frag_prop" + specificGunOps + modelType);
        CheckModelName("wpn_t9_grenade_launcher" + specificGunOps + modelType);
        CheckModelName("wpn_t9_grenade_launcher_bomber" + specificGunOps + modelType);
        CheckModelName("wpn_t9_grenade_launcher_oozeball" + specificGunOps + modelType);
        CheckModelName("wpn_t9_grenade_launcher_projectile" + specificGunOps + modelType);
        CheckModelName("wpn_t9_grenade_launcher_shadow" + specificGunOps + modelType);
        CheckModelName("wpn_t9_knife_ballistic" + specificGunOps + modelType);
        CheckModelName("wpn_t9_knife_ballistic_babayaga" + specificGunOps + modelType);
        CheckModelName("wpn_t9_knife_ballistic_oktober" + specificGunOps + modelType);
        CheckModelName("wpn_t9_knife_ballistic_projectile" + specificGunOps + modelType);
        CheckModelName("wpn_t9_knife_ballistic_spycraft" + specificGunOps + modelType);
        CheckModelName("wpn_t9_knife_bowie_predator_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_knife_combat_american" + specificGunOps + modelType);
        CheckModelName("wpn_t9_knife_combat_american_cmoney" + specificGunOps + modelType);
        CheckModelName("wpn_t9_knife_combat_american_lile" + specificGunOps + modelType);
        CheckModelName("wpn_t9_knife_combat_american_prop" + specificGunOps + modelType);
        CheckModelName("wpn_t9_knife_combat_babayaga_le" + specificGunOps + modelType);
        CheckModelName("wpn_t9_knife_combat_bope" + specificGunOps + modelType);
        CheckModelName("wpn_t9_knife_combat_le" + specificGunOps + modelType);
        CheckModelName("wpn_t9_knife_combat_le_oktober" + specificGunOps + modelType);
        CheckModelName("wpn_t9_knife_combat_russian_aagirl" + specificGunOps + modelType);
        CheckModelName("wpn_t9_knife_combat_russian_go_bananas" + specificGunOps + modelType);
        CheckModelName("wpn_t9_knife_combat_scream" + specificGunOps + modelType);
        CheckModelName("wpn_t9_knife_combat_spycraft_le" + specificGunOps + modelType);
        CheckModelName("wpn_t9_knife_combat_switchblade" + specificGunOps + modelType);
        CheckModelName("wpn_t9_knife_combat_wooden" + specificGunOps + modelType);
        CheckModelName("wpn_t9_knife_dagger_predator" + specificGunOps + modelType);
        CheckModelName("wpn_t9_launcher_freefire" + specificGunOps + modelType);
        CheckModelName("wpn_t9_launcher_freefire_projectile" + specificGunOps + modelType);
        CheckModelName("wpn_t9_launcher_freefire_stow" + specificGunOps + modelType);
        CheckModelName("wpn_t9_launcher_standard" + specificGunOps + modelType);
        CheckModelName("wpn_t9_launcher_standard_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_launcher_standard_optic" + specificGunOps + modelType);
        CheckModelName("wpn_t9_launcher_standard_projectile" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_accurate" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_accurate_cb_bayou" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_accurate_cb_bite" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_accurate_cb_bowling" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_accurate_cb_bsilver" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_accurate_cb_bstreet" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_accurate_cb_carnival" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_accurate_cb_crimson" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_accurate_cb_endtimes" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_accurate_cb_knight" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_accurate_cb_mummy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_accurate_cb_mvs" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_accurate_cb_nuclear" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_accurate_cb_numbers" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_accurate_cb_overkill" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_accurate_cb_ratrod" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_accurate_cb_scrap" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_accurate_cb_sshovel" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_accurate_cb_street" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_accurate_cb_zweed" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_light" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_light_angel" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_light_animetankg" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_light_arcade" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_light_armyrv" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_light_beachcomber" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_light_carbongold_ms" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_light_carbongold_pc" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_light_carbongold_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_light_cmachine" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_light_dpharao_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_light_ferfluid" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_light_gladia" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_light_milhack" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_light_orda" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_light_rebirth" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_light_tchern" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_light_warship" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_light_x2" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_slowfire" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_slowfire_armored" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_slowfire_btank" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_slowfire_chemburn_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_slowfire_chewing" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_slowfire_cia" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_slowfire_darkaether" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_slowfire_krieger" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_slowfire_leprecon" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_slowfire_necroking" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_slowfire_notcryo" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_slowfire_pigs" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_slowfire_ram" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_slowfire_reactor" + specificGunOps + modelType);
        CheckModelName("wpn_t9_lmg_slowfire_samurai" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_british" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_british_eclipse" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_british_gilded" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_british_gilded_muzzle" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_british_lightw" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_british_muzzle" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_british_scope" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_british_scope_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_british_scope_eclipse" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_british_scope_eclipse_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_british_sultan" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_fasthandling" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_fasthandling_animeninja" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_fasthandling_babayaga" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_fasthandling_bbear" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_fasthandling_charged_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_fasthandling_circuit" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_fasthandling_classic" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_fasthandling_firestorm" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_fasthandling_joke" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_fasthandling_leaf" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_fasthandling_longshot" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_fasthandling_lorider" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_fasthandling_opulence" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_fasthandling_silver_streak" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_fasthandling_snavy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_fasthandling_sterile" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_fasthandling_tagger_ms" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_fasthandling_tagger_pc" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_fasthandling_tagger_solo" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_fasthandling_tagger_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_fasthandling_tiger" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_fasthandling_triton" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_fasthandling_wetops" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_season6" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_season6_artdeco" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_season6_scream" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_season6_unicorn" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_season6_venom" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_slowfire" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_slowfire_assassin" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_slowfire_donnie" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_slowfire_judged" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_slowfire_laser_mount" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_slowfire_laser_mount_assassin" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_slowfire_media" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_slowfire_muzzle" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_slowfire_muzzle_ww" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_slowfire_rockcold" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_slowfire_special" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_slowfire_special_muzzle" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_slowfire_ww" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_slowfirewell_adapter" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_slowhandling" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_slowhandling_carbonchrome_ms" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_slowhandling_carbonchrome_pc" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_slowhandling_carbonchrome_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_slowhandling_dh" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_slowhandling_endgame" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_slowhandling_fishtank" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_slowhandling_frost" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_slowhandling_gmaxis" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_slowhandling_kreiger" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_slowhandling_lightup" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_slowhandling_orda" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_slowhandling_somberv" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_slowhandling_wildchild" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_slowhandling_xray" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_soviet" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_soviet_bw" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_ar_soviet_ferrofluid" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_lmg_fastfire" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_lmg_fastfire_electro" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_lmg_fastfire_highnoon" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_lmg_fastfire_highstakes" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_lmg_fastfire_jester" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_lmg_fastfire_lochness" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_lmg_fastfire_nightf" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_pistol_fullauto" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_pistol_fullauto_eburial" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_pistol_fullauto_eburial_le" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_pistol_fullauto_egyptian" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_pistol_fullauto_egyptian_le" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_pistol_fullauto_gilded" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_pistol_fullauto_gilded_le" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_pistol_fullauto_judged" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_pistol_fullauto_le" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_pistol_fullauto_le_judged" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_pistol_fullauto_le_poison" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_pistol_fullauto_phased" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_pistol_fullauto_phased_le" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_pistol_fullauto_poison" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_pistol_shotgun" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_pistol_shotgun_le" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_pistol_shotgun_throwback" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_pistol_shotgun_throwback_le" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_shotgun_fullauto" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_shotgun_fullauto_acid" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_shotgun_fullauto_base_muzzle" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_shotgun_fullauto_blue" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_shotgun_fullauto_bronze" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_shotgun_fullauto_carapace" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_shotgun_fullauto_carnival" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_shotgun_fullauto_commando" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_shotgun_fullauto_coyote" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_shotgun_fullauto_cyber" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_shotgun_fullauto_lightup" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_shotgun_fullauto_lion" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_shotgun_fullauto_mutant" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_shotgun_fullauto_numbers" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_shotgun_fullauto_summer" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_shotgun_fullauto_surge" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_shotgun_fullauto_wanker" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_shotgun_fullauto_wasteland" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_shotgun_leveraction" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_shotgun_leveraction_carnival" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_shotgun_leveraction_freya" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_shotgun_leveraction_ripper" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_shotgun_leveraction_shell" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_accurate" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_accurate_bod" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_accurate_evil" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_accurate_grunge" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_accurate_gunking" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_accurate_halloween" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_accurate_joke4_ms" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_accurate_joke4_pc" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_accurate_joke4_solo" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_accurate_joke4_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_accurate_maxpurp" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_accurate_poison" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_accurate_soccer" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_accurate_sweet" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_accurate_zombied" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_cqb" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_cqb_cyber" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_cqb_donnie" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_cqb_kgb" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_cqb_mind" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_fastfire" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_fastfire_angel" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_fastfire_base_muzzle" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_fastfire_camera" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_fastfire_cshinobi" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_fastfire_faberge" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_fastfire_fires" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_fastfire_frost" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_fastfire_intercell" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_fastfire_jefes" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_fastfire_judged" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_fastfire_maverick" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_fastfire_mummycat" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_fastfire_overrun" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_fastfire_scrap" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_fastfire_stitch" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_fastfire_sweet" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_fastfire_toke" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_fastfire_wsow_ms" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_fastfire_wsow_pc" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_fastfire_wsow_solo" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_fastfire_wsow_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_fastfire_ztheme" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_flechette" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_flechette_endgame" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_flechette_ilazar" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_lapa" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_lapa_horror" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_lapa_ripper" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_semiauto" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_semiauto_counter" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_semiauto_endgame" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_semiauto_heatwave" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_semiauto_mdriving" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_semiauto_scream" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_spray" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_spray_betty_ms" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_spray_betty_pc" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_spray_betty_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_spray_ferfluid" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_spray_ghostship" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_spray_hypno" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_spray_jester" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_spray_milspec" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_spray_space" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_spray_tagger_ms" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_spray_tagger_pc" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_spray_tagger_solo" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_spray_tagger_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_spray_tuningf" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_smg_spray_urban" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_accurate" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_accurate_animemon" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_accurate_cybersnake" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_accurate_deaths" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_accurate_donnie" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_accurate_egyptian" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_accurate_hollywood" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_accurate_roman" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_accurate_scope_cybersnake" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_accurate_scope_cybersnake_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_accurate_unicorn" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_cannon" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_cannon_8bit" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_cannon_aces" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_cannon_bullet_casing" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_cannon_debonair" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_cannon_ghillie" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_cannon_rave" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_cannon_rebel" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_cannon_scope" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_cannon_scope_8bit" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_cannon_scope_aces" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_cannon_scope_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_cannon_scope_ads_8bit" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_cannon_scope_ads_aces" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_cannon_scope_ads_debonair" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_cannon_scope_ads_ghillie" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_cannon_scope_ads_rave" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_cannon_scope_ads_rebel" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_cannon_scope_debonair" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_cannon_scope_ghillie" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_cannon_scope_rave" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_cannon_scope_rebel" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_cannon_scope_yokai" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_sniper_cannon_yokai" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_special_nailgun" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_special_nailgun_maxpurp" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_special_nailgun_naildome" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_special_nailgun_soulripper" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_tr_fastburst" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_tr_fastburst_chewing" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_tr_fastburst_controller" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_tr_fastburst_cuddly" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_tr_fastburst_halloween" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_tr_fastburst_mdriving" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_tr_fastburst_metamorph" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_tr_fastburst_toke" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_tr_fastburst_wilder" + specificGunOps + modelType);
        CheckModelName("wpn_t9_loot_tr_fastburst_wood" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_axe" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_axe_berserker" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_axe_ripper" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_bat" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_bat_bayou" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_bat_heavyhit" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_bat_penumbra" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_cane" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_cane_class" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_cane_joke_ms" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_cane_joke_pc" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_cane_joke_solo" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_cane_joke_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_crystalaxe" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_halligan_tool_prop_weapon" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_hammersickle_agony_hammer_le" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_hammersickle_agony_sickle" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_hammersickle_hammer_le" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_hammersickle_sickle" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_knuckle_knife_prop" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_kukri_dw_prop_weapon" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_kukri_prop_weapon" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_mace" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_mace_scepter" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_machete" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_machete_croc" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_machete_daether" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_machete_hollywood" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_sais" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_sais_le" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_sais_le_ninja" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_sais_le_rainbow_jewel" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_sais_ninja" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_sais_rainbow_jewel" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_scythe" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_scythe_rbunny" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_shovel" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_shovel_angel" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_shovel_assassin" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_shovel_jefe" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_shovel_warlord" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_sledgehammer" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_sledgehammer_assassin" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_sledgehammer_dozer" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_sledgehammer_predator_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_sledgehammer_prop" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_sledgehammer_rranch" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_sledgehammer_zhunter" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_wakizashi_base" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_wakizashi_base_metamorph" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_wakizashi_base_rebel" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_wakizashi_gladiator" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_wakizashi_ornate" + specificGunOps + modelType);
        CheckModelName("wpn_t9_melee_warmace_prop_weapon" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_animetankg" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_blade" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_decree" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_dw_avalanche" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_dw_blade" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_dw_bullshark" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_dw_decree" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_dw_devil" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_dw_especial" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_dw_faberge" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_dw_firestorm" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_dw_fumigator" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_dw_highfidelity" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_dw_leagueplay" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_dw_rbaron" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_dw_samurai" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_dw_sheriff" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_dw_souleat" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_dw_surge" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_dw_ubronze" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_dw_whunter" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_dw_yokai" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_especial" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_faberge" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_firestorm" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_fumigator" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_highfidelity" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_leagueplay" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_samurai" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_sheriff" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_souleat" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_surge" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_ubronze" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_ultrafunk" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_ultrafunk_dw" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_whunter" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_cb_yokai" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_dw" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_burst_dw_prop" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_revolver" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_revolver_bbear" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_revolver_bite" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_revolver_bite_dw" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_revolver_debonai" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_revolver_dw" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_revolver_dw_84" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_revolver_dw_adder" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_revolver_dw_bbear" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_revolver_dw_bite" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_revolver_dw_debonai" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_revolver_dw_finec" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_revolver_dw_modernp" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_revolver_dw_murder" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_revolver_dw_noir" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_revolver_dw_pollock" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_revolver_dw_prop" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_revolver_dw_scorpion" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_revolver_dw_six" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_revolver_dw_srave" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_revolver_dw_swashbuck" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_revolver_dw_winters" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_revolver_finec" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_revolver_hvt" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_revolver_hvt_dw" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_revolver_modernp" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_revolver_murder" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_revolver_pollock" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_revolver_srave" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_revolver_swashbuck" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_revolver_winters" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_semiauto" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_semiauto_8bit" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_semiauto_classic" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_semiauto_classic_dw" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_semiauto_cp" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_semiauto_cuddly" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_semiauto_dw" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_semiauto_dw_8bit" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_semiauto_dw_cuddly" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_semiauto_dw_endtimes" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_semiauto_dw_fchina" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_semiauto_dw_firework" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_semiauto_dw_midnight" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_semiauto_dw_muerte" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_semiauto_dw_mvice" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_semiauto_dw_pow" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_semiauto_dw_presone" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_semiauto_dw_prop" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_semiauto_dw_rifleer" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_semiauto_dw_sweet" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_semiauto_dw_teal" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_semiauto_dw_tunnel" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_semiauto_endtimes" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_semiauto_eqp_hatchet_prop_weapon" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_semiauto_finechina" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_semiauto_firework" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_semiauto_muerte" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_semiauto_pow" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_semiauto_presone" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_semiauto_prop" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_semiauto_prop_animate" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_semiauto_prop_weapon" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_semiauto_sweet" + specificGunOps + modelType);
        CheckModelName("wpn_t9_pistol_semiauto_tunnel" + specificGunOps + modelType);
        CheckModelName("wpn_t9_red_card_prop" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_pump" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_pump_albino_serpent" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_pump_battery" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_pump_blazer" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_pump_collect" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_pump_dark" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_pump_dozer" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_pump_glitch" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_pump_great" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_pump_grunge" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_pump_gunzroses" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_pump_jefe" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_pump_lawman" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_pump_lfg" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_pump_motocross" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_pump_mvs" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_pump_nature" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_pump_nucleard" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_pump_tunnel" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_pump_wilder" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_semiauto" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_semiauto_cb_aether" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_semiauto_cb_animepilot" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_semiauto_cb_assassin" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_semiauto_cb_cosplay" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_semiauto_cb_darkaether" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_semiauto_cb_doomsday" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_semiauto_cb_elegant" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_semiauto_cb_gmaxis" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_semiauto_cb_hudson_ms" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_semiauto_cb_hudson_pc" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_semiauto_cb_hudson_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_semiauto_cb_jokerh" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_semiauto_cb_miami" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_semiauto_cb_rainbow" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_semiauto_cb_resp" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_semiauto_cb_sunset" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_semiauto_cb_supers" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_semiauto_cb_tuningf" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_semiauto_cb_voodoo" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_semiauto_frogmen" + specificGunOps + modelType);
        CheckModelName("wpn_t9_shotgun_semiauto_unfolded_stock" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sig_grapple_gun" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_burst" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_burst_absinthe_barrel_laser_mount" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_burst_assassin" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_burst_barrel_laser_mount" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_burst_barrel_laser_mount_assassin" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_burst_barrel_laser_mount_rainbow" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_burst_barrel_laser_mount_scarab" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_burst_barrel_laser_mount_wonder" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_burst_barrel_light_mount" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_burst_brutus" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_burst_bullshark" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_burst_dino" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_burst_fumigator" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_burst_improvt" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_burst_jade" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_burst_maneater" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_burst_metamorph" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_burst_milspec" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_burst_motocross" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_burst_nest" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_burst_nugget" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_burst_purpsun" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_burst_rainbow" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_burst_ruby" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_burst_scarab" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_burst_sneaker" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_burst_sultan" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_burst_sunkissed" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_burst_wonder" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_arctic" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_body_mount" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_body_mount_summer" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_body_mount_undead" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_body_ring_mount" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_body_ring_mount_rockcold" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_cocktail" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_dark" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_deaths" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_electric" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_electric_muzzle" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_fishtank" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_gigaswatt" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_goth" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_hanukkah" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_hipower" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_insect" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_jade" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_jwarrior" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_media" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_monte" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_muzzle" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_muzzle_dark" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_muzzle_jade" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_muzzle_monte" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_muzzle_nugget" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_muzzle_summer" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_nugget" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_pink" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_racer" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_rebel" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_rockcold" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_rranch" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_somberv" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_summer" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacity_undead" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_capacityer_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_crystalaxe" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_handling" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_handling_achill" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_handling_angel_fish" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_handling_animeninja" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_handling_assassin" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_handling_bguard" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_handling_blow_runner" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_handling_cell" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_handling_cheese" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_handling_cmoney" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_handling_cubarevo" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_handling_deepblue" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_handling_electro" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_handling_flower" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_handling_gilded" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_handling_heartbreak" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_handling_high_end" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_handling_hudson_ms" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_handling_hudson_pc" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_handling_hudson_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_handling_jewel" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_handling_jungle" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_handling_lucha" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_handling_lycan" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_handling_miami" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_handling_microfilm" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_handling_nights" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_handling_rebirth" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_handling_sim" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_handling_ssilver" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_handling_toohot" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_handling_wanker" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_heavy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_heavy_aagirl" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_heavy_animetankg" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_heavy_apache" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_heavy_arabian" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_heavy_armadillo" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_heavy_batts" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_heavy_big_joke" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_heavy_blade" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_heavy_carbonchrome_ms" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_heavy_carbonchrome_pc" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_heavy_carbonchrome_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_heavy_cdummy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_heavy_checkmate" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_heavy_concrete" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_heavy_gasoline" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_heavy_leagueplay" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_heavy_oktober" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_heavy_orda" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_heavy_panda" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_heavy_penumbra" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_heavy_pow" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_heavy_ratrod" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_heavy_rbunny" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_heavy_rebel" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_heavy_rsurvival" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_heavy_soulripper" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_heavy_standoff" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_heavy_striked" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_heavy_swiss" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_heavy_tagger3" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_heavy_washed" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_heavy_zslayer" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_barrel_light_mount" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_barrel_mount" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_cb_apilot" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_cb_bomber" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_cb_carnival" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_cb_chewing" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_cb_cia" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_cb_coyote" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_cb_cryo" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_cb_cuddly" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_cb_ddaemon" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_cb_debonair" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_cb_dh" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_cb_evintage" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_cb_finec1" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_cb_firework" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_cb_gambit" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_cb_infest" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_cb_leaf" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_cb_nature" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_cb_numbers" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_cb_operator" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_cb_pollock" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_cb_roadwar" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_cb_roman" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_cb_shadow" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_cb_spacehead" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_cb_strace" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_cb_taffy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_cb_zenya" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_cb_znaga" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_chewing" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_cuddly" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_infest" + specificGunOps + modelType);
        CheckModelName("wpn_t9_smg_standard_leaf" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_accurate_scope" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_accurate_scope_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_accurate_scope_ads_animemon" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_accurate_scope_animemon" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_accurate_scope_deaths" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_accurate_scope_deaths_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_accurate_scope_donnie" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_accurate_scope_donnie_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_accurate_scope_egyptian" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_accurate_scope_egyptian_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_accurate_scope_unicorn" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_accurate_scope_unicorn_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_animelight" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_acid" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_acid_frontend" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_animelight" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_animelight_frontend" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_biggame" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_biggame_frontend" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_circuit" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_circuit_frontend" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_hologram" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_hologram_frontend" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_hypno" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_hypno_frontend" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_improvt" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_improvt_frontend" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_intercell" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_intercell_frontend" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_jungle" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_jungle_frontend" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_lancer" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_lancer_frontend" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_rain" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_ruby" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_ruby_frontend" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_scarab" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_scarab_frontend" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_scope_acid" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_scope_ads_acid" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_scope_ads_animelight" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_scope_ads_biggame" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_scope_ads_circuit" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_scope_ads_jungle" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_scope_ads_lancer" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_scope_ads_rain" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_scope_ads_ruby" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_scope_ads_scarab" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_scope_ads_stalker" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_scope_animelight" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_scope_biggame" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_scope_circuit" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_scope_improvt" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_scope_improvt_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_scope_jungle" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_scope_lancer" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_scope_rain" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_scope_rain_frontend" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_scope_ruby" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_scope_scarab" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_scope_stalker" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_stalker" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cb_stalker_frontend" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cmoney" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_cmoney_frontend" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_frontend" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_hypno" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_scope" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_scope_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_scope_ads_cmoney" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_powersemi_scope_cmoney" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_animewidow" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_bullet" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_bwarrior_ms" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_bwarrior_pc" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_bwarrior_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_cotton" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_coyote" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_darkg" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_darkg_scope" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_darkg_scope_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_endgame" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_endgame_scope" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_endgame_scope_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_eyerelief" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_gasoline" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_ghillie_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_holiday" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_holiday_scope" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_holiday_scope_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_manguish" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_mvs" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_opulence" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_pearl" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_psa" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_psa_scope" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_psa_scope_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_rbunny" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_rbunny_scope" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_rbunny_scope_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_redwave" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_scope" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_scope_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_scope_ads_animewidow" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_scope_ads_cotton" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_scope_ads_coyote" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_scope_ads_ghillie_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_scope_ads_manguish" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_scope_ads_opulence" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_scope_ads_pearl" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_scope_ads_somberv" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_scope_ads_wrap" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_scope_animewidow" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_scope_cotton" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_scope_coyote" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_scope_gasoline" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_scope_ghillie_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_scope_manguish" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_scope_mvs" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_scope_opulence" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_scope_pearl" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_scope_skeleton" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_scope_skeleton_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_scope_somberv" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_scope_wrap" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_skeleton" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_somberv" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_vietnam_bullet" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_wind" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_quickscope_wrap" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_achill" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_animesg" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_apex" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_beachcomber" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_carbon_fiber" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_carbon_fiber_scope" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_carbon_fiber_scope_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_dino" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_dino_scope" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_ghost" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_ghost_scope" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_ghost_scope_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_milspec" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_nonuke" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_prof" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_qjackal" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_scope" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_scope_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_scope_ads_animesg" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_scope_ads_prof" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_scope_ads_space" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_scope_animesg" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_scope_apex" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_scope_apex_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_scope_prof" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_scope_space" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_scope_wandering" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_scope_wandering_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_scopeer_ads_ms" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_scopeer_ads_pc" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_scopeer_ads_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_scopeer_ms" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_scopeer_pc" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_scopeer_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_sorrow" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_space" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standard_wandering" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standarder_ms" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standarder_pc" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sniper_standarder_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sparkler_prop" + specificGunOps + modelType);
        CheckModelName("wpn_t9_special_crossbow" + specificGunOps + modelType);
        CheckModelName("wpn_t9_special_crossbow_diynot" + specificGunOps + modelType);
        CheckModelName("wpn_t9_special_crossbow_goth" + specificGunOps + modelType);
        CheckModelName("wpn_t9_special_crossbow_lancehead" + specificGunOps + modelType);
        CheckModelName("wpn_t9_special_crossbow_lastzombie" + specificGunOps + modelType);
        CheckModelName("wpn_t9_special_crossbow_projectile" + specificGunOps + modelType);
        CheckModelName("wpn_t9_special_crossbow_ztheme" + specificGunOps + modelType);
        CheckModelName("wpn_t9_special_nailgun_projectile" + specificGunOps + modelType);
        CheckModelName("wpn_t9_sr_electric_avogadro_projectile" + specificGunOps + modelType);
        CheckModelName("wpn_t9_streak_annihilator" + specificGunOps + modelType);
        CheckModelName("wpn_t9_streak_bow" + specificGunOps + modelType);
        CheckModelName("wpn_t9_streak_bow_arrow_03_projectile" + specificGunOps + modelType);
        CheckModelName("wpn_t9_streak_bow_pickup" + specificGunOps + modelType);
        CheckModelName("wpn_t9_streak_care_package" + specificGunOps + modelType);
        CheckModelName("wpn_t9_streak_care_package_booby_trap" + specificGunOps + modelType);
        CheckModelName("wpn_t9_streak_care_package_friendly" + specificGunOps + modelType);
        CheckModelName("wpn_t9_streak_care_package_friendly_nosight" + specificGunOps + modelType);
        CheckModelName("wpn_t9_streak_care_package_fx_corner" + specificGunOps + modelType);
        CheckModelName("wpn_t9_streak_care_package_fx_ratchet" + specificGunOps + modelType);
        CheckModelName("wpn_t9_streak_death_machine" + specificGunOps + modelType);
        CheckModelName("wpn_t9_streak_flamethrower" + specificGunOps + modelType);
        CheckModelName("wpn_t9_streak_missile_turret" + specificGunOps + modelType);
        CheckModelName("wpn_t9_streak_missile_turret_fx_arm" + specificGunOps + modelType);
        CheckModelName("wpn_t9_streak_missile_turret_fx_base" + specificGunOps + modelType);
        CheckModelName("wpn_t9_streak_missile_turret_fx_leg" + specificGunOps + modelType);
        CheckModelName("wpn_t9_streak_missile_turret_fx_senors" + specificGunOps + modelType);
        CheckModelName("wpn_t9_streak_missile_turret_projectile" + specificGunOps + modelType);
        CheckModelName("wpn_t9_streak_war_machine" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_damagesemi" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_damagesemi_apache" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_damagesemi_babayaga" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_damagesemi_batts" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_damagesemi_cdummy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_damagesemi_checkp" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_damagesemi_codename" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_damagesemi_faberge" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_damagesemi_flashf" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_damagesemi_fuego" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_damagesemi_jfighter_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_damagesemi_king_scorpion" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_damagesemi_onyx_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_damagesemi_wildchild" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_aerobics" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_animepilot" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_arvnr1" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_arvnr2" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_boar_ms" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_boar_pc" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_boar_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_bope" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_cyborg" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_devilwoman" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_dhawk" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_dozer" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_electric" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_fallenh" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_freya" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_gchoice" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_goth" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_highnoon" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_infest" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_joke4_ms" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_joke4_pc" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_joke4_solo" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_joke4_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_jokerh" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_kjackal" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_lastzombie" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_mind" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_mvs" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_opulence" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_peace" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_resp" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_sforces_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_smu" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_ufo" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_longburst_warlock" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_animemeow" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_blade" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_bush" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_carapace" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_carolina" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_chems" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_dieh" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_draid" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_fcarbon" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_ghostship" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_jewel" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_lunar" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_maxpurp" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_monte" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_rthunder" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_scope_ads_animemeow" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_scope_ads_blade" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_scope_ads_bush" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_scope_ads_dieh" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_scope_ads_draid" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_scope_ads_ghostship" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_scope_animemeow" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_scope_blade" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_scope_bush" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_scope_dieh" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_scope_draid" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_scope_ghostship" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_scope_sweet" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_scope_sweet_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_scope_urban" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_scope_urban_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_srave_sy" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_standoff" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_sweet" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_tanner" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_cb_urban" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_scope" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_powerburst_scope_ads" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_precisionsemi" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_precisionsemi_egypt" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_precisionsemi_excellence" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_precisionsemi_ivory" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_precisionsemi_mutant" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_precisionsemi_ninja_v2" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_precisionsemi_punk" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_precisionsemi_reinforced" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_precisionsemi_speckled" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_precisionsemi_tiki" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_precisionsemi_v2_8bit" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_precisionsemi_v2_doomsday" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_precisionsemi_v2_draid" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_precisionsemi_v2_fieldm" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_precisionsemi_v2_lightm" + specificGunOps + modelType);
        CheckModelName("wpn_t9_tr_precisionsemi_v2_wandering" + specificGunOps + modelType);
        CheckModelName("wpn_t9_zm_knife_bowie" + specificGunOps + modelType);
        CheckModelName("wpn_t9_zm_mega_barrel_blazer_beam" + specificGunOps + modelType);
        CheckModelName("wpn_t9_zm_mega_barrel_micro" + specificGunOps + modelType);
        CheckModelName("wpn_t9_zm_mega_barrel_pistol" + specificGunOps + modelType);
        CheckModelName("wpn_t9_zm_mega_barrel_spreadshot" + specificGunOps + modelType);
        CheckModelName("wpn_t9_zm_monkey_bomb" + specificGunOps + modelType);
        CheckModelName("wpn_t9_zm_perk_can_deadshot" + specificGunOps + modelType);
        CheckModelName("wpn_t9_zm_perk_can_death_perception" + specificGunOps + modelType);
        CheckModelName("wpn_t9_zm_perk_can_elemental" + specificGunOps + modelType);
        CheckModelName("wpn_t9_zm_perk_can_juggernog" + specificGunOps + modelType);
        CheckModelName("wpn_t9_zm_perk_can_mule_kick" + specificGunOps + modelType);
        CheckModelName("wpn_t9_zm_perk_can_phd_slider" + specificGunOps + modelType);
        CheckModelName("wpn_t9_zm_perk_can_powerup" + specificGunOps + modelType);
        CheckModelName("wpn_t9_zm_perk_can_quick_revive" + specificGunOps + modelType);
        CheckModelName("wpn_t9_zm_perk_can_speed_cola" + specificGunOps + modelType);
        CheckModelName("wpn_t9_zm_perk_can_stamina_up" + specificGunOps + modelType);
        CheckModelName("wpn_t9_zm_perk_can_tombstone" + specificGunOps + modelType);
        CheckModelName("wpn_t9_zm_ray_rifle" + specificGunOps + modelType);
        CheckModelName("wpn_t9_zm_raygun" + specificGunOps + modelType);
        CheckModelName("wpn_t9_zm_raygun_upg" + specificGunOps + modelType);
        CheckModelName("wpn_t9_zm_silver_panic_knife" + specificGunOps + modelType);
        CheckModelName("wpn_t9_zm_silver_ww" + specificGunOps + modelType);
        CheckModelName("wpn_t9_zm_silver_ww_01" + specificGunOps + modelType);
        CheckModelName("wpn_t9_zm_wand_aether_shround" + specificGunOps + modelType);
        CheckModelName("wpn_t9_zm_wand_energy_mine" + specificGunOps + modelType);
        CheckModelName("wpn_t9_zm_wand_frenzied_guard" + specificGunOps + modelType);
        CheckModelName("wpn_t9_zm_wand_frost_blast" + specificGunOps + modelType);
        CheckModelName("wpn_t9_zm_wand_healing_aura" + specificGunOps + modelType);
        CheckModelName("wpn_t9_zm_wand_ring_fire" + specificGunOps + modelType);
        CheckModelName("wpn_t9_zm_wand_toxic_growth" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s1_analog_aviator_02" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s1_analog_aviator_x2" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s1_analog_bope_01" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s1_analog_brawler_01" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s1_analog_broken_fancy" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s1_analog_fancy_debt_collector" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s1_analog_fancy_gold" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s1_analog_kremlin_01" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s1_analog_origin_01" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s1_analog_private_eye_01" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s1_analog_private_eye_02" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s1_analog_private_eye_03" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s1_analog_retroren_02" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s1_bracelet_01" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s1_bracelet_braided_02" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s1_bracelet_gold_chain_01" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s1_bracelet_silver_chain_01" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s1_bracelet_skull_01" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s1_digital_compass" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s1_digital_diver" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s1_digital_first_spy" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s1_digital_gambit_01" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s1_digital_gaudy" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s1_digital_inteculo_01" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s1_digital_kazuya_01" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s1_digital_rank_01" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s1_digital_rank_penumbra_sy" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s1_digital_zm_heart_rate_01" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s1_digital_zm_heart_rate_black_02" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s2_analog_420" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s2_analog_black_silver" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s2_analog_caiman" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s2_analog_cold_hearted" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s2_analog_dark_aether" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s2_analog_jungle_aviator" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s2_analog_mayan" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s2_analog_mortal" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s2_analog_naval_warfare" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s2_analog_necro_king" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s2_analog_paratroop" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s2_analog_rebel" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s2_bracelet_lure" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s2_bracelet_mardi_gras" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s2_digital_jade" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s2_digital_mayan" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s2_digital_mini_map" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s2_digital_mini_map_hot_rod" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s2_digital_river_slasher" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s2_digital_sforce" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s3_analog_chrono_sea" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s3_analog_mctag" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s3_analog_nuclear_fallout" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s3_analog_rebel_fighter_sy" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s3_analog_winter_ash" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s3_analog_zombie_naga" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s3_bracelet_01" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s3_digital_big_joke" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s3_digital_death_touch" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s3_digital_heart_rate_alien" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s3_digital_inteculo_spycraft" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s3_digital_inteculo_w_fallout" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s3_digital_nuclear_fallout" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s3_digital_radiation" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s3_digital_rank_winter_fallout" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s3_digital_ultrafunk" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s3_digitalic8" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s4_analog_assassin" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s4_analog_fire_storm" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s4_analog_future_soldier" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s4_analog_horror" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s4_analog_jefe" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s4_analog_rbear" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s4_analog_roadwar" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s4_analog_sleek_assassin" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s4_analog_spaceship" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s4_analog_wasteland" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s4_bracelet_leather_studd" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s4_bracelet_weathered" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s4_digital_big_joke" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s4_digital_blade" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s4_digital_evil" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s4_digital_holographic" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s4_digital_holographic_rank" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s4_digital_holographic_rank_cyber" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s4_digital_roadwarrior" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s4_digital_royal_decree" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s5_analog_beer_o_clock" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s5_analog_blood_fancy" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s5_analog_classic" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s5_analog_demon" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s5_analog_dis_assassin" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s5_analog_egy_burial" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s5_analog_hacking_code" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s5_analog_holographic" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s5_analog_no_numbers" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s5_analog_onyx_sy" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s5_analog_retrotac" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s5_digital_arabian" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s5_digital_checkmate" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s5_digital_critical_kill" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s5_digital_dark_weaver" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s5_digital_ghosted" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s5_digital_judge_d" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s5_digital_mummy_cat" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s5_digital_rank_countdwn" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s5_digital_tagger" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s5_digital_wonderland" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_analog_agony" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_analog_big_joke4_ms" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_analog_big_joke4_pc" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_analog_big_joke4_solo" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_analog_big_joke4_sy" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_analog_bite_me" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_analog_blue_chroma" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_analog_bog_ops" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_analog_camo" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_analog_cyber_venom" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_analog_gilded" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_analog_halloween" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_analog_hypnosis" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_analog_krieger" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_analog_scrapyard" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_analog_scream" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_analog_street_mech_sy" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_digital_atomic_ash" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_digital_egyptian_fire" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_digital_endgame" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_digital_frost" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_digital_gov1" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_digital_gov2" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_digital_nightmare_fuel" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_digital_rank_carnival" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_digital_reaper_bunny" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_digital_sultan" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_digital_tagger_ms" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_digital_tagger_pc" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_digital_tagger_solo" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_digital_tagger_sy" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_digital_undead_warrior" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_digital_undeadic" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_digital_ww" + specificGunOps + modelType);
        CheckModelName("wrist_watch_t9_s6_digital_zm_critical_kill" + specificGunOps + modelType);
        // BO4 Operator Models & Skins

        // BO4 Weapon Models & Blueprints
    }
    foreach (string imageType in ImageTypes)
    {
        foreach (string imageSequenceType in ImageSequenceTypes)
        {
            foreach (string imageWpnAttachmentType in ImageWpnAttachmentTypes)
            {
                foreach (string imageWpnBlueprintType in ImageWpnBlueprintTypes)
                {
                    // CW Weapon & Operator Images
                    // Swap imageWpnAttachmentType with imageWpnBlueprintType as some bundles have swapped names for more results
                    CheckImageName("" + specificGunOps + imageType);
                    CheckImageName("i_mtl_wpn_t9" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_bp_smg_standard" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_bp_sniper_quickscope" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_bp_sniper_standard" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_bp_tr_damagesemi" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_bp_tr_longburst" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_combat_knife_american" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_grenade_launcher" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_lmg_accurate" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_lmg_accurate_cb" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_lmg_light" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_lmg_slowfire" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_ar_fasthandling" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_ar_slowfire" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_ar_slowhandling" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_ar_soviet" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_bp" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_lmg_fastfire" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_shotgun_leveraction" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_shotgun_sweeper" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_smg_cqb" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_smg_fastfire" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_smg_ingram" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_smg_lapa" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_smg_semiauto" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_smg_spray" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_sniper_cannon" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_tr_fastburst" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_melee_hammersickle_hammer" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_melee_hammersickle_sikle" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_melee_shovel" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_melee_wakizashi" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_pistol_burst" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_pistol_burst_cb" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_pistol_burst_cb_secondary" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_pistol_burst_secondary" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_pistol_revolver" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_pistol_semiauto" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_shotgun_pump" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_shotgun_semiauto_cb" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_smg_burst" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_smg_capacity" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_smg_handling" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_smg_heavy" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_smg_standard_cb" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_sniper_accurate" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_sniper_powersemi_cb" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_sniper_quickscope" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_sniper_standard" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_special_crossbow" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_tr_damagesemi" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_tr_fullauto_classic" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_tr_longburst" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_tr_powerburst_cb" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_tr_precisionsemi" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_zm_monkey" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_zm_raygun" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_ar_accurate" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_ar_british" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_ar_damage" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_ar_fastfire" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_ar_fasthandling" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_ar_krig6" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_ar_mercenary" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_ar_mobility" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_ar_season6" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_ar_slowfire" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_ar_slowhandling" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_ar_soviet" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_ar_standard" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_bp_ar_damage" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_bp_ar_fastfire" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_bp_ar_krig6" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_bp_ar_mercenary" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_bp_ar_mobility" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_bp_lmg_light" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_bp_loot_ar_fasthandling" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_bp_pistol_burst" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_bp_pistol_revolver" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_bp_pistol_semiauto" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_bp_shotgun_pump" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_bp_smg_burst" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_bp_smg_handling" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_bp_smg_heavy" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_combat_knife_american" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_grenade_launcher" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_knife_ballistic" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_launcher_freefire" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_launcher_standard" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_lmg_accurate" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_lmg_fastfire" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_lmg_light" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_lmg_slowfire" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_ar_british" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_ar_fasthandling" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_ar_season6" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_ar_slowfire" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_ar_slowhandling" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_ar_soviet" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_lmg_fastfire" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_nailgun" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_pistol_fullauto" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_pistol_shotgun" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_shotgun_fullauto" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_shotgun_leveraction" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_smg_accurate" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_smg_cqb" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_smg_fastfire" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_smg_flechette" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_smg_lapa" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_smg_semiauto" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_smg_spray" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_sniper_accurate" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_sniper_cannon" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_loot_tr_fastburst" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_machete" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_melee_axe" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_melee_bat" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_melee_cane" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_melee_hammersickle_hammer" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_melee_hammersickle_sikle" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_melee_mace" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_melee_sais" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_melee_scythe" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_melee_shovel" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_melee_sledgehammer" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_melee_wakizashi" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_nailgun" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_pistol_burst" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_pistol_fullauto" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_pistol_revolver" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_pistol_semiauto" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_pistol_shotgun" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_shotgun_fullauto" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_shotgun_leveraction" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_shotgun_pump" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_shotgun_semiauto" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_smg_accurate" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_smg_burst" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_smg_capacity" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_smg_cqb" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_smg_fastfire" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_smg_flechette" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_smg_handling" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_smg_heavy" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_smg_lapa" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_smg_semiauto" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_smg_spray" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_smg_standard" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_sniper_accurate" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_sniper_cannon" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_sniper_powersemi" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_sniper_quickscope" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_sniper_standard" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_special_crossbow" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_tr_damagesemi" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_tr_fastburst" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_tr_longburst" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_tr_powerburst" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_tr_precisionsemi" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_zm_mega_barrel" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_zm_monkey" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_mtl_wpn_t9_zm_raygun" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_ar_accurate" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_ar_british" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_ar_damage" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_ar_fastfire" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_ar_fasthandling" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_ar_krig6" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_ar_mercenary" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_ar_mobility" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_ar_season6" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_ar_slowfire" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_ar_slowhandling" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_ar_soviet" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_ar_standard" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_combat_knife_american" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_grenade_launcher" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_knife_ballistic" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_launcher_freefire" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_launcher_standard" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_lmg_accurate" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_lmg_fastfire" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_lmg_light" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_lmg_slowfire" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_loot_ar_british" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_loot_ar_fasthandling" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_loot_ar_season6" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_loot_ar_slowfire" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_loot_ar_slowhandling" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_loot_ar_soviet" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_loot_lmg_fastfire" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_loot_nailgun" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_loot_pistol_fullauto" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_loot_pistol_shotgun" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_loot_shotgun_fullauto" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_loot_shotgun_leveraction" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_loot_smg_accurate" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_loot_smg_cqb" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_loot_smg_fastfire" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_loot_smg_flechette" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_loot_smg_lapa" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_loot_smg_semiauto" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_loot_smg_spray" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_loot_sniper_accurate" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_loot_sniper_cannon" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_loot_tr_fastburst" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_machete" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_melee_axe" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_melee_bat" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_melee_cane" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_melee_hammersickle_hammer" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_melee_hammersickle_sikle" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_melee_mace" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_melee_sais" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_melee_scythe" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_melee_shovel" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_melee_sledgehammer" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_melee_wakizashi" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_nailgun" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_pistol_burst" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_pistol_fullauto" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_pistol_revolver" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_pistol_semiauto" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_pistol_shotgun" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_shotgun_fullauto" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_shotgun_leveraction" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_shotgun_pump" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_shotgun_semiauto" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_smg_accurate" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_smg_burst" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_smg_capacity" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_smg_cqb" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_smg_fastfire" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_smg_flechette" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_smg_handling" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_smg_heavy" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_smg_lapa" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_smg_semiauto" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_smg_spray" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_smg_standard" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_sniper_accurate" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_sniper_cannon" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_sniper_powersemi" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_sniper_quickscope" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_sniper_standard" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_special_crossbow" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_tr_damagesemi" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_tr_fastburst" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_tr_longburst" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_tr_powerburst" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_tr_precisionsemi" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_zm_mega_barrel" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_zm_monkey" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("i_wpn_t9_zm_raygun" + specificGunOps + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    CheckImageName("ui_icon_obit" + specificGunOps + imageType);
                    CheckImageName("ui_icon_operators" + specificGunOps + imageType);
                    CheckImageName("ui_icon_weapon" + specificGunOps + imageType);
                    CheckImageName("ui_icon_weapon_ar_accurate_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_ar_british_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_ar_damage_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_ar_fastfire_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_ar_fasthandling_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_ar_mercenary_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_ar_mobility_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_ar_season6_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_ar_slowfire_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_ar_slowhandling_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_ar_soviet_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_ar_standard_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_charms_t9" + specificGunOps + imageType);
                    CheckImageName("ui_icon_weapon_hud" + specificGunOps + imageType);
                    CheckImageName("ui_icon_weapon_knife_combat_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_knife_loadout_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_launcher_freefire_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_launcher_standard_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_lmg_accurate_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_lmg_fastfire_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_lmg_light_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_lmg_slowfire_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_melee_baseballbat_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_melee_battleaxe_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_melee_cane_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_melee_coldwar_t9_dw" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_melee_etool_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_melee_mace_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_melee_machete_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_melee_sai_dw_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_melee_scythe_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_melee_sledgehammer_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_melee_wakizashi_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_pistol_burst_dw_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_pistol_burst_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_pistol_fullauto_dw_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_pistol_fullauto_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_pistol_revolver_dw_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_pistol_revolver_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_pistol_semiauto_dw_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_pistol_semiauto_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_pistol_shotgun_dw_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_pistol_shotgun_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_shotgun_fullauto_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_shotgun_leveraction_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_shotgun_pump_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_shotgun_semiauto_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_smg_accurate_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_smg_burst_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_smg_capacity_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_smg_cqb_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_smg_fastfire_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_smg_flechette_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_smg_handling_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_smg_heavy_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_smg_season6_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_smg_semiauto_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_smg_spray_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_smg_standard_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_sniper_accurate_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_sniper_cannon_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_sniper_powersemi_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_sniper_quickscope_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_sniper_standard_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_special_ballisticknife_dw_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_special_crossbow_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_special_grenade_launcher_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_special_nailgun_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_tr_damagesemi_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_tr_fastburst_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_tr_longburst_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_tr_powerburst_t9" + specificGunOps + imageSequenceType + imageType);
                    CheckImageName("ui_icon_weapon_tr_precisionsemi_t9" + specificGunOps + imageSequenceType + imageType);
                }
            }
        }
    }
    foreach (string materialType in MaterialTypes)
    {
        // BO4 / CW Weapon & Operator Materials
        CheckMaterialName("" + specificGunOps + materialType);
        CheckMaterialName("ei/" + specificGunOps + materialType);
        CheckMaterialName("el/" + specificGunOps + materialType);
        CheckMaterialName("mc/" + specificGunOps + materialType);
        CheckMaterialName("mcs/" + specificGunOps + materialType);
        CheckMaterialName("vd/" + specificGunOps + materialType);
        CheckMaterialName("vdd/" + specificGunOps + materialType);
        CheckMaterialName("wc/" + specificGunOps + materialType);
        //CheckMaterialName("mc/c_t8" + specificGunOps + materialType);
        //CheckMaterialName("mc/c_t9" + specificGunOps + materialType);
        //CheckMaterialName("mc/mtl_c_t8" + specificGunOps + materialType);
        //CheckMaterialName("mc/mtl_c_t9" + specificGunOps + materialType);
    }
    foreach (string voxType in VoxTypes)
    {
        foreach (string languageType in LanguageTypes)
        {
            // BO4 / CW Weapon & Operator / Announcer Sounds
            CheckSoundName("" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/ar_accurate/ar_accurate" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/ar_british/fly_ar_british" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/ar_damage/fly_ar_damage" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/ar_fastfire/fly_ar_fastfire" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/ar_fasthandling/fly_ar_fasthandling" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/ar_mobility/fly_ar_mobility" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/ar_season6/fly_ar_season6" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/ar_slowfire/fly_ar_slowfire" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/ar_slowhandling/fly_ar_slowhandling" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/ar_soviet/fly_ar_soviet" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/ar_standard/fly_ar_standard" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/grenade_launcher/fly_grenade_launcher" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/launcher_freefire/fly_launcher_freefire" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/launcher_standard/fly_launcher_standard" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/lmg_accurate/fly_lmg_accurate" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/lmg_fastfire/fly_lmg_fastfire" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/lmg_light/fly_lmg_light" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/lmg_slowfire/fly_lmg_slowfire" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/pistol_burst/fly_pistol_burst" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/pistol_fullauto/fly_pistol_fullauto" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/pistol_revolver/fly_pistol_revolver" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/pistol_semiauto/fly_pistol_semiauto" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/pistol_shotgun/fly_pistol_shotgun" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/shotgun_leveraction/fly_shotgun_leveraction" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/shotgun_pump/fly_shotgun_pump" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/shotgun_semi/fly_shotgun_semi" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/smg_accurate/fly_smg_accurate" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/smg_burst/fly_smg_burst" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/smg_capacity/fly_smg_capacity" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/smg_cqb/fly_smg_cqb" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/smg_fastfire/fly_smg_fastfire" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/smg_flechette/fly_smg_flechette" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/smg_handling/fly_smg_handling" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/smg_heavy/fly_smg_heavy" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/smg_season6/fly_smg_season6" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/smg_semiauto/fly_smg_semiauto" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/smg_spray/fly_smg_spray" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/smg_standard/fly_smg_standard" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/sniper_accurate/fly_sniper_accurate" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/sniper_cannon/fly_sniper_cannon" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/sniper_powersemi/fly_sniper_powersemi" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/sniper_standard/sniper_standard" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/special_nailgun/fly_nailgun" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/tr_damagesemi/fly_tr_damagesemi" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/tr_fastburst/fly_tr_fastburst" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/tr_longburst/fly_tr_longburst" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/tr_powerburst/fly_tr_powerburst" + specificGunOps + voxType + languageType);
            CheckSoundName("fly/weapon/reload/tr_precision/fly_tr_precision" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/mpl/abnd/vox_abnd" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/mpl/adgi/vox_adgi" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/mpl/ahva/vox_ahva" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/mpl/ami6/vox_ami6" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/mpl/anbo/vox_anbo" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/mpl/anme/vox_anme" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/adlr/vox_adlr" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/antv/vox_antv" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/bakr/vox_bakr" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/bdzr/vox_bdzr" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/beck/vox_beck" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/frs1/vox_frs1" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/frs2/vox_frs2" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/fuze/vox_fuze" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/grca/vox_grca" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/gstf/vox_gstf" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/hdsn/vox_hdsn" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/jckl/vox_jckl" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/kngs/vox_kngs" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/kngt/vox_kngt" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ktsn/vox_ktsn" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/lazr/vox_lazr" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/masn/vox_masn" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/maxi/vox_maxi" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/mcln/vox_mcln" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/mrs1/vox_mrs1" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/mrs2/vox_mrs2" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/mrs3/vox_mrs3" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/naga/vox_naga" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/park/vox_park" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/prce/vox_prce" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ptnv/vox_ptnv" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/rmbo/vox_rmbo" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/rvas/vox_rvas" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/sala/vox_sala" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/sims/vox_sims" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/stch/vox_stch" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/stry/vox_stry" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/weav/vox_weav" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/wolf/vox_wolf" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/wood/vox_wood" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/wrth/vox_wrth" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zyna/vox_zyna" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/adlr/vox_adlr" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/antv/vox_antv" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/bakr/vox_bakr" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/bdzr/vox_bdzr" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/beck/vox_beck" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/frs1/vox_frs1" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/frs2/vox_frs2" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/fuze/vox_fuze" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/grca/vox_grca" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/gstf/vox_gstf" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/hdsn/vox_hdsn" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/jckl/vox_jckl" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/kngs/vox_kngs" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/kngt/vox_kngt" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/ktsn/vox_ktsn" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/lazr/vox_lazr" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/masn/vox_masn" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/maxi/vox_maxi" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/mcln/vox_mcln" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/mrs1/vox_mrs1" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/mrs2/vox_mrs2" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/mrs3/vox_mrs3" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/naga/vox_naga" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/park/vox_park" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/prce/vox_prce" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/ptnv/vox_ptnv" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/rmbo/vox_rmbo" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/rvas/vox_rvas" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/sala/vox_sala" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/sims/vox_sims" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/stch/vox_stch" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/stry/vox_stry" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/weav/vox_weav" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/wolf/vox_wolf" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/wood/vox_wood" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/wrth/vox_wrth" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/operators/zyna/vox_zyna" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/adlr/vox_adlr" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/antv/vox_antv" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/bakr/vox_bakr" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/bdzr/vox_bdzr" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/beck/vox_beck" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/frs1/vox_frs1" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/frs2/vox_frs2" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/fuze/vox_fuze" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/grca/vox_grca" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/gstf/vox_gstf" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/hdsn/vox_hdsn" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/jckl/vox_jckl" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/kngs/vox_kngs" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/kngt/vox_kngt" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/ktsn/vox_ktsn" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/lazr/vox_lazr" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/masn/vox_masn" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/maxi/vox_maxi" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/mcln/vox_mcln" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/mrs1/vox_mrs1" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/mrs2/vox_mrs2" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/mrs3/vox_mrs3" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/naga/vox_naga" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/park/vox_park" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/prce/vox_prce" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/ptnv/vox_ptnv" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/rmbo/vox_rmbo" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/rvas/vox_rvas" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/sala/vox_sala" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/sims/vox_sims" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/stch/vox_stch" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/stry/vox_stry" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/weav/vox_weav" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/wolf/vox_wolf" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/wood/vox_wood" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/wrth/vox_wrth" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/ping/zyna/vox_zyna" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/adlr/vox_adlr" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/antv/vox_antv" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/bakr/vox_bakr" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/bdzr/vox_bdzr" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/beck/vox_beck" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/frs1/vox_frs1" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/frs2/vox_frs2" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/fuze/vox_fuze" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/grca/vox_grca" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/gstf/vox_gstf" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/hdsn/vox_hdsn" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/jckl/vox_jckl" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/kngs/vox_kngs" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/kngt/vox_kngt" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/ktsn/vox_ktsn" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/lazr/vox_lazr" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/masn/vox_masn" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/maxi/vox_maxi" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/mcln/vox_mcln" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/mrs1/vox_mrs1" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/mrs2/vox_mrs2" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/mrs3/vox_mrs3" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/naga/vox_naga" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/park/vox_park" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/prce/vox_prce" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/ptnv/vox_ptnv" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/rmbo/vox_rmbo" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/rvas/vox_rvas" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/sala/vox_sala" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/sims/vox_sims" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/stch/vox_stch" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/stry/vox_stry" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/weav/vox_weav" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/wolf/vox_wolf" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/wood/vox_wood" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/wrth/vox_wrth" + specificGunOps + voxType + languageType);
            CheckSoundName("vox/scripted/zm_operators/zyna/vox_zyna" + specificGunOps + voxType + languageType);
        }
    }
}

void SearchForSpecificName(string SpecificName)
{
    CheckModelName(SpecificName);
    CheckAnimName(SpecificName);
    CheckImageName(SpecificName);
    CheckMaterialName(SpecificName);
    CheckSoundName(SpecificName);
    CheckStringName(SpecificName);
}

void CheckModelName(string modelName)
{
    string hashName = string.Format("{0:x}", HashUtil.Hash(modelName));
    if (Directory.Exists(ExportFolder + "\\xmodel_" + hashName))
    {
        Console.WriteLine("Found Model: {0:x}", hashName + "," + modelName);
        File.AppendAllText(ExportFolder + "\\ModelsFound.txt", hashName + "," + modelName + Environment.NewLine);
        Directory.Delete(ExportFolder + "\\xmodel_" + hashName);
    }
}

void CheckAnimName(string animName)
{
    string hashName = string.Format("{0:x}", HashUtil.Hash(animName));
    if (Directory.Exists(ExportFolder + "\\xanim_" + hashName))
    {
        Console.WriteLine("Found Anim: {0:x}", hashName + "," + animName);
        File.AppendAllText(ExportFolder + "\\AnimsFound.txt", hashName + "," + animName + Environment.NewLine);
        Directory.Delete(ExportFolder + "\\xanim_" + hashName);
    }
}

void CheckImageName(string imageName)
{
    string hashName = string.Format("{0:x}", HashUtil.Hash(imageName));
    if (Directory.Exists(ExportFolder + "\\ximage_" + hashName))
    {
        Console.WriteLine("Found Image: {0:x}", hashName + "," + imageName);
        File.AppendAllText(ExportFolder + "\\ImagesFound.txt", hashName + "," + imageName + Environment.NewLine);
        Directory.Delete(ExportFolder + "\\ximage_" + hashName);
    }
}

void CheckMaterialName(string materialName)
{
    string hashName = string.Format("{0:x}", HashUtil.Hash(materialName));
    if (Directory.Exists(ExportFolder + "\\xmaterial_" + hashName))
    {
        Console.WriteLine("Found Material: {0:x}", hashName + "," + materialName);
        File.AppendAllText(ExportFolder + "\\MaterialsFound.txt", hashName + "," + materialName + Environment.NewLine);
        Directory.Delete(ExportFolder + "\\xmaterial_" + hashName);
    }
}

void CheckSoundName(string soundName)
{
    string hashName = string.Format("{0:x}", HashUtil.Hash(soundName));
    if (Directory.Exists(ExportFolder + "\\xsound_" + hashName))
    {
        Console.WriteLine("Found Sound: {0:x}", hashName + "," + soundName);
        File.AppendAllText(ExportFolder + "\\SoundsFound.txt", hashName + "," + soundName + Environment.NewLine);
        Directory.Delete(ExportFolder + "\\xsound_" + hashName);
    }
}
void CheckStringName(string stringName)
{
    string hashName = string.Format("{0:x}", HashUtil.Hash(stringName));
    if (Directory.Exists(ExportFolder + "\\xstring_" + hashName))
    {
        Console.WriteLine("Found String: {0:x}", hashName + "," + stringName);
        File.AppendAllText(ExportFolder + "\\StringsFound.txt", hashName + "," + stringName + Environment.NewLine);
        Directory.Delete(ExportFolder + "\\xstring_" + hashName);
    }
}

string GetNumberToString(long index)
{
    string str = "";
    while (index > 0)
    {
        str = GetNumberToChar(index % 37) + str;
        index /= 37;
    }
    return str;
}

string GetNumberToChar(long index)
{
    if (index < 27)
        return char.ConvertFromUtf32(64 + (int)index);
    if (index < 37)
        return (index - 27).ToString();
    return index == 37 ? "_" : "";
}

namespace fnvHashFinder
{
    class HashUtil
    {
        public static ulong Hash(string input)
        {
            ulong num = 14695981039346656037;
            for (int index = 0; index < input.Length; ++index)
                num = (ulong)(((long)num ^ (long)input[index]) * 1099511628211L);
            num &= 0xFFFFFFFFFFFFFFF;
            return num;
        }
    }
}