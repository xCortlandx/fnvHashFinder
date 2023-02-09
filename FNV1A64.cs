using fnvHashFinder;
using System.Diagnostics;

internal class FNV1A64
{
    private static void Main(string[] args)
    {
        string Path = string.Empty;
        string xAsset = string.Empty;

        // You can add Direct names under any of the types
        string[] AnimTypes =
        {
"",
"_acknowledge",
"_acknowledge_additive",
"_acknowledge_additive_dw",
"_acknowledge_bare_hands",
"_acknowledge_bare_hands_additive",
"_acknowledge_dw",
"_acknowledge_lh",
"_acknowledge_lh_additive",
"_acknowledge_rh",
"_acknowledge_rh_additive",
"_active_idle",
"_active_idle_a",
"_active_idle_b",
"_active_idle_c",
"_active_idle_d",
"_active_idle_l",
"_active_idle_r",
"_additive",
"_additive_empty",
"_ads_2x_down",
"_ads_2x_up",
"_ads_3x_down",
"_ads_3x_up",
"_ads_4x_down",
"_ads_4x_up",
"_ads_acog_down",
"_ads_acog_up",
"_ads_base_down",
"_ads_base_down_acog",
"_ads_base_down_elo",
"_ads_base_down_holo",
"_ads_base_down_reflex",
"_ads_base_up",
"_ads_base_up_acog",
"_ads_base_up_elo",
"_ads_base_up_holo",
"_ads_base_up_reflex",
"_ads_down",
"_ads_down_additive",
"_ads_dualoptic_down",
"_ads_dualoptic_lower_down",
"_ads_dualoptic_lower_up",
"_ads_dualoptic_up",
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
"_ads_up_additive",
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
"_attacking_additive_dw",
"_attacking_bare_hands",
"_attacking_bare_hands_additive",
"_attacking_dw",
"_attacking_lh",
"_attacking_lh_additive",
"_attacking_rh",
"_attacking_rh_additive",
"_cancel",
"_cancel_additive",
"_cancel_additive_dw",
"_cancel_additive_lh",
"_cancel_additive_rh",
"_cancel_bare_hands",
"_cancel_bare_hands_additive",
"_cancel_dw",
"_cancel_lh",
"_cancel_rh",
"_cancel_rh_additive",
"_celebration",
"_celebration_additive",
"_celebration_additive_dw",
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
"_defending_additive",
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
"_draw_cancel_ads",
"_draw_loop",
"_draw_loop_ads",
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
"_dw_melee_l_finisher",
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
"_dw_slide_additive",
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
"_fem_prone_first_raise",
"_fem_prone_reload",
"_fem_prone_reload_empty",
"_fem_prone_reload_ext_empty",
"_fem_prone_reload_fast_empty",
"_fem_prone_reload_mixclip_empty",
"_fem_stand_fire",
"_fem_stand_first_raise",
"_fem_stand_reload",
"_fem_stand_reload_empty",
"_fem_stand_reload_ext_empty",
"_fem_stand_reload_fast_empty",
"_fem_stand_reload_mixclip_empty",
"_ferfluid_inspect",
"_finger_pose_l",
"_finger_pose_r",
"_fire",
"_fire_2",
"_fire_3",
"_fire_a",
"_fire_acog_ads",
"_fire_additive",
"_fire_ads",
"_fire_ads_acog",
"_fire_ads_elo",
"_fire_ads_holo",
"_fire_ads_intro",
"_fire_ads_last",
"_fire_ads_last_acog",
"_fire_ads_reflex",
"_fire_ads_reflex_intro",
"_fire_alt",
"_fire_b",
"_fire_c",
"_fire_delay",
"_fire_fail",
"_fire_fail_additive",
"_fire_intro",
"_fire_l",
"_fire_last",
"_fire_last_ads",
"_fire_lastshot",
"_fire_le",
"_fire_left",
"_fire_loop",
"_fire_r",
"_fire_ri",
"_fire_right",
"_fire_shotgun",
"_first_raise",
"_first_raise_alt",
"_first_raise_ext",
"_first_raise_ext_quick",
"_first_raise_foregrip",
"_first_raise_grip",
"_first_raise_quick",
"_first_raise_quick_ext",
"_first_raise_quick_grip",
"_firstraise_alt",
"_flanking",
"_flanking_additive",
"_flanking_bare_hands",
"_flanking_bare_hands_additive",
"_flanking_dw",
"_flanking_lh",
"_flanking_lh_additive",
"_flanking_rh",
"_flanking_rh_additive",
"_group_up",
"_group_up_additive",
"_group_up_additive_dw",
"_group_up_bare_hands",
"_group_up_bare_hands_additive",
"_group_up_dw",
"_group_up_lh",
"_group_up_lh_additive",
"_group_up_rh",
"_group_up_rh_additive",
"_gunbutt_strike",
"_gunbutt_swipe",
"_gunbutt_swipe_grip",
"_hello",
"_hello_additive",
"_hello_additive_dw",
"_hello_additive_rh",
"_hello_bare_hands",
"_hello_bare_hands_additive",
"_hello_dw",
"_hello_lh",
"_hello_rh",
"_idle",
"_idle_active",
"_idle_additive",
"_idle_ads",
"_idle_alt",
"_idle_d",
"_idle_empty",
"_idle_l",
"_idle_r",
"_idle_static",
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
"_lastshot_ads",
"_lh",
"_loop",
"_male_prone_fire",
"_male_prone_first_raise",
"_male_prone_reload",
"_male_prone_reload_empty",
"_male_prone_reload_ext_empty",
"_male_prone_reload_fast_empty",
"_male_prone_reload_mixclip_empty",
"_male_stand_fire",
"_male_stand_first_raise",
"_male_stand_reload",
"_male_stand_reload_empty",
"_male_stand_reload_ext_empty",
"_male_stand_reload_fast_empty",
"_male_stand_reload_mixclip_empty",
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
"_melee_in_l",
"_melee_l",
"_melee_l_finisher",
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
"_melee_miss_a",
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
"_melee_swipe_l",
"_need_help",
"_need_help_additive",
"_need_help_additive_dw",
"_need_help_additive_lh",
"_need_help_additive_rh",
"_need_help_bare_hands",
"_need_help_bare_hands_additive",
"_need_help_dw",
"_need_help_lh",
"_need_help_rh",
"_need_ride",
"_need_ride_additive_dw",
"_need_ride_additive_lh",
"_need_ride_additive_rh",
"_need_ride_bare_hands",
"_need_ride_bare_hands_additive",
"_need_ride_dw",
"_need_ride_lh",
"_need_ride_rh",
"_negative",
"_negative_additive_dw",
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
"_pullout_fast_additive",
"_pullout_first",
"_pullout_first_quick",
"_pullout_grip",
"_pullout_quick",
"_pullout_quick_alt",
"_pullpin",
"_pullpin_additive",
"_pullpin_additive_dw",
"_pullpin_additive_lh",
"_pullpin_additive_rh",
"_pullpin_bare_hands",
"_pullpin_bare_hands_additive",
"_pullpin_dw",
"_pullpin_lh",
"_pullpin_rh",
"_pullpin_rh_additive",
"_putaway",
"_putaway_additive",
"_putaway_alt",
"_putaway_empty",
"_putaway_quick",
"_putaway_quick_alt",
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
"_reload_empty_fast_mag_ads",
"_reload_empty_fastmag",
"_reload_empty_fastmag_ads",
"_reload_empty_grip",
"_reload_empty_hybrid",
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
"_reload_fast_mag_ads",
"_reload_fast_mag_empty",
"_reload_fastmag",
"_reload_fastmag_ads",
"_reload_fastmag_empty",
"_reload_fastmag_empty_ads",
"_reload_hybrid",
"_reload_in",
"_reload_in_ads",
"_reload_loop",
"_reload_loop_ads",
"_reload_mixclip",
"_reload_mixclip_ads",
"_reload_mixclip_ads_empty",
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
"_rh",
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
"_throw_additive",
"_throw_back",
"_throwback",
"_throw_back_additive",
"_throw_back_lh",
"_throw_back_rh",
"_throw_bare_hands",
"_throw_bare_hands_additive",
"_throw_dw",
"_throw_lh",
"_throw_rh",
"_throw_rh_additive",
"_throw_quick",
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
"_arrival_01_r",
"_arrival_02",
"_arrival_03",
"_arrival_04",
"_arrival_05",
"_arrival_06",
"_arrival_07",
"_arrival_08",
"_arrival_09",
"_arrive",
"_attack_01",
"_attack_02",
"_attack_03",
"_base_attack_ranged_01_high",
"_base_com_idle_02",
"_base_com_idle_03",
"_base_crawl_boardtear_aligned_r_5_hold",
"_base_crawl_sprint_v02",
"_base_crawl_win_trav_m_v01",
"_base_dr_jump_down_127",
"_base_dr_jump_down_184",
"_base_dr_jump_down_72",
"_base_dr_jump_down_96",
"_base_jump_down_128",
"_base_jump_down_160",
"_base_jump_down_190",
"_base_jump_down_256",
"_base_jump_down_36",
"_base_jump_down_48",
"_base_jump_down_72",
"_base_jump_up_160",
"_base_jump_up_36_down_244",
"_base_jump_up_48",
"_base_jump_up_72",
"_base_jump_up_96",
"_base_mantle_over_128",
"_base_mantle_over_36",
"_base_mantle_over_72",
"_base_mantle_over_96",
"_base_run_ad_v23_pain_chest_f_alt",
"_base_run_jump_up_72_quick",
"_base_run_jump_up_96_quick",
"_base_walk_jump_down_180",
"_boss_intro",
"_chaingun_aim_2",
"_chaingun_aim_4",
"_chaingun_aim_6",
"_chaingun_aim_8",
"_chaingun_destroyed_pain",
"_chaingun_fire",
"_chaingun_intro_sprint_to_aim_5",
"_com_run_atk_melee_07",
"_com_run_atk_melee_08",
"_death_02",
"_dth_01_loop",
"_exit",
"_head_stun_intro",
"_head_stun_loop",
"_head_stun_outro",
"_idle",
"_idle_01",
"_idle_02",
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
"_ranged_attack_v2_end",
"_ranged_attack_v2_loop",
"_roar",
"_run_01",
"_run_02",
"_run_2",
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
"_sprint_01_attack",
"_sprint_02",
"_sprint_jump_dn_128",
"_sprint_jump_dn_160",
"_sprint_jump_dn_32",
"_sprint_jump_dn_36",
"_sprint_jump_dn_48",
"_sprint_jump_dn_72",
"_sprint_jump_dn_96",
"_sprint_jump_up_128",
"_sprint_jump_up_160",
"_sprint_jump_up_32",
"_sprint_jump_up_36",
"_sprint_jump_up_48",
"_sprint_jump_up_72",
"_sprint_jump_up_96",
"_sprint_v1",
"_stalk_turn_l_135",
"_stalk_turn_l_180",
"_stalk_turn_l_45",
"_stalk_turn_l_90",
"_stalk_turn_r_135",
"_stalk_turn_r_180",
"_stalk_turn_r_45",
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
"_stumble_loop",
"_stumble_outro",
"_sweep",
"_teleport_end",
"_teleport_start",
"_trot_01",
"_trv_entry_mantle_272",
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
"_trv_mantle_128",
"_trv_mantle_36",
"_trv_mantle_40",
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
"_undercroft_spawn_01",
"_walk_01",
"_walk_basic",
"_walk_jump_dn_128",
"_walk_jump_dn_160",
"_walk_jump_dn_32",
"_walk_jump_dn_36",
"_walk_jump_dn_48",
"_walk_jump_dn_96",
"_walk_jump_up_128",
"_walk_jump_up_160",
"_walk_jump_up_32",
"_walk_jump_up_36",
"_walk_jump_up_48",
"_walk_jump_up_72",
"_walk_jump_up_96",
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
"_confetti",
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
"_starsmoon",
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
};
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
"_body",
"_body1",
"_body1_fb",
"_body2",
"_body2_fb",
"_body3",
"_body3_fb",
"_body4",
"_body4_fb",
"_body5",
"_body5_fb",
"_body6",
"_body6_fb",
"_body7",
"_body7_fb",
"_body8",
"_body8_fb",
"_body9",
"_body9_fb",
"_body_01",
"_body_02",
"_body_03",
"_body_04",
"_body_05",
"_body_06",
"_body_07",
"_body_08",
"_body_09",
"_body_fb",
"_clip_sig_01_view",
"_clip_sig_01_world",
"_clip_sig_02_view",
"_clip_sig_02_world",
"_clip_sig_03_view",
"_clip_sig_03_world",
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
"_fxanim",
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
"_head_01",
"_head_02",
"_head_03",
"_head_04",
"_head_05",
"_head_06",
"_head_07",
"_head_08",
"_head_09",
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
"_mag_sig_01_view",
"_mag_sig_01_world",
"_mag_sig_02_view",
"_mag_sig_02_world",
"_mag_sig_03_view",
"_mag_sig_03_world",
"_mag_view",
"_mag_world",
"_mod",
"_projectile",
"_projectile_dead",
"_prop",
"_prop_animate",
"_right_prop",
"_scope_ads_sig_01_view",
"_scope_ads_sig_01_world",
"_scope_ads_sig_02_view",
"_scope_ads_sig_02_world",
"_scope_ads_sig_03_view",
"_scope_ads_sig_03_world",
"_scope_sig_01_view",
"_scope_sig_01_world",
"_scope_sig_02_view",
"_scope_sig_02_world",
"_scope_sig_03_view",
"_scope_sig_03_world",
"_shell_view",
"_sig_01_view",
"_sig_01_world",
"_sig_02_view",
"_sig_02_world",
"_sig_03_view",
"_sig_03_world",
"_sig_view",
"_sig_world",
"_smod",
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
"_view_blue",
"_view_green",
"_view_ms",
"_view_orange",
"_view_pc",
"_view_purple",
"_view_red",
"_view_sy",
"_view_upgraded",
"_view_yellow",
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
"_world_blue",
"_world_dead",
"_world_green",
"_world_ms",
"_world_orange",
"_world_pc",
"_world_purple",
"_world_red",
"_world_sy",
"_world_yellow",
"_world_upgraded",
"_xmodel",
};
        string[] VoxTypes =
        {
"",
// DRAFT - BO4 Foly Vox
"_back",
"_belt_feed",
"_bolt_back",
"_bolt_back_00",
"_bolt_back_01",
"_bolt_back_02",
"_bolt_back_03",
"_bolt_back_04",
"_bolt_back_05",
"_bolt_forward",
"_bolt_forward_00",
"_bolt_forward_01",
"_bolt_forward_02",
"_bolt_forward_03",
"_bolt_forward_04",
"_bolt_forward_05",
"_bolt_release",
"_bolt_release_00",
"_bolt_release_01",
"_bolt_release_02",
"_bolt_release_03",
"_bolt_release_04",
"_bolt_release_05",
"_button",
"_button_press",
"_button_press_00",
"_button_press_01",
"_button_press_02",
"_button_press_03",
"_button_press_04",
"_button_press_05",
"_chamber_bolt_back",
"_chamber_bolt_back_00",
"_chamber_bolt_back_01",
"_chamber_bolt_back_02",
"_chamber_bolt_back_03",
"_chamber_bolt_back_04",
"_chamber_bolt_back_05",
"_chamber_bolt_forward",
"_chamber_bolt_forward_00",
"_chamber_bolt_forward_01",
"_chamber_bolt_forward_02",
"_chamber_bolt_forward_03",
"_chamber_bolt_forward_04",
"_chamber_bolt_forward_05",
"_chamber_cyl_in",
"_chamber_cyl_in_00",
"_chamber_cyl_in_01",
"_chamber_cyl_in_02",
"_chamber_cyl_in_03",
"_chamber_cyl_in_04",
"_chamber_cyl_in_05",
"_chamber_cyl_out",
"_chamber_cyl_out_00",
"_chamber_cyl_out_01",
"_chamber_cyl_out_02",
"_chamber_cyl_out_03",
"_chamber_cyl_out_04",
"_chamber_cyl_out_05",
"_chamber_first",
"_chamber_first_00",
"_chamber_first_01",
"_chamber_first_02",
"_chamber_first_03",
"_chamber_first_04",
"_chamber_first_05",
"_close",
"_cylinder_close",
"_cylinder_latch",
"_cylinder_open",
"_ext_mag_in",
"_ext_mag_out",
"_first_raise",
"_first_raise_00",
"_first_raise_01",
"_first_raise_02",
"_first_raise_03",
"_first_raise_04",
"_first_raise_05",
"_firstraise",
"_firstraise_00",
"_firstraise_01",
"_firstraise_02",
"_firstraise_03",
"_firstraise_04",
"_firstraise_05",
"_forward",
"_hammer_back",
"_in",
"_load",
"_mag_in",
"_mag_in_00",
"_mag_in_01",
"_mag_in_02",
"_mag_in_03",
"_mag_in_04",
"_mag_in_05",
"_mag_in_raise",
"_mag_in_start",
"_mag_in_start_00",
"_mag_in_start_01",
"_mag_in_start_02",
"_mag_in_start_03",
"_mag_in_start_04",
"_mag_in_start_05",
"_mag_lock",
"_mag_out",
"_mag_out_00",
"_mag_out_01",
"_mag_out_02",
"_mag_out_03",
"_mag_out_04",
"_mag_out_05",
"_mag_release",
"_mag_slide",
"_mag_slide_out",
"_mag_tap",
"_mag_tap_00",
"_mag_tap_01",
"_mag_tap_02",
"_mag_tap_03",
"_mag_tap_04",
"_mag_tap_05",
"_mag_unlock",
"_open",
"_out",
"_pull_back",
"_push_forward",
"_rechamber",
"_rechamber_00",
"_rechamber_01",
"_rechamber_02",
"_rechamber_03",
"_rechamber_04",
"_rechamber_05",
"_rechamber_ads",
"_rechamber_ads_00",
"_rechamber_ads_01",
"_rechamber_ads_02",
"_rechamber_ads_03",
"_rechamber_ads_04",
"_rechamber_ads_05",
"_shells_in",
"_shells_out",
"_slide_back",
"_slide_back_00",
"_slide_back_01",
"_slide_back_02",
"_slide_back_03",
"_slide_back_04",
"_slide_back_05",
"_slide_forward",
"_slide_forward_00",
"_slide_forward_01",
"_slide_forward_02",
"_slide_forward_03",
"_slide_forward_04",
"_slide_forward_05",
"_slide_release",
"_slide_release_00",
"_slide_release_01",
"_slide_release_02",
"_slide_release_03",
"_slide_release_04",
"_slide_release_05",
"_spin",
"_switch",
"_tap",
"_tap_00",
"_tap_01",
"_tap_02",
"_tap_03",
"_tap_04",
"_tap_05",
"flap_close",
"flap_open",
"rocket_load",
"rocket_lock",
"sight_open",
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
"_zm_se_kill_mult_lightning_links_00",
"_zm_se_kill_mult_lightning_links_01",
"_zm_se_kill_mult_lightning_links_02",
"_zm_se_kill_mult_lightning_links_03",
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
"p8_rack_wood_hat_lod0",
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
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("[FNV1A64 MODE]\n");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Specify xAsset Directory:");
        Path = Console.ReadLine();
        while (true)
        {
            Console.WriteLine("[1] Start Scan\n[2] Credit");
            string searchType = Console.ReadLine();
            if (searchType == "1")
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                Console.WriteLine("Scanning for Assets...");
                Task.WaitAll(Task.Factory.StartNew(() => SearchForSpecificAsset(xAsset)));
                Console.WriteLine("Scan completed.");
                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
                Console.WriteLine("Scan time:" + elapsedTime);
            }
            else if (searchType == "2")
            {
                Console.WriteLine("\nThis Project was made possible by:\n");
                Thread.Sleep(1000);
                Console.WriteLine("Scobalula");
                Thread.Sleep(500);
                Console.WriteLine("itsNatoriousB");
                Thread.Sleep(500);
                Console.WriteLine("Cortland");
                Thread.Sleep(500);
                Console.WriteLine("Amorfirion");
                Thread.Sleep(500);
                Console.WriteLine("Dark7x");
                Thread.Sleep(500);
                Console.WriteLine("DeltaDriver");
                Thread.Sleep(500);
                Console.WriteLine("pmr360");
                Thread.Sleep(500);
                Console.WriteLine("JohnWick [Limitless]\n");
                Thread.Sleep(500);
            }
        }

        void SearchForSpecificAsset(string xAsset)
        {
            foreach (string animType in AnimTypes)
            {
                foreach (string aiAnimType in AIAnimTypes)
                {
                    // BO4 & CW AI Anims
                    CheckAnimName("" + animType);
                    CheckAnimName("ai_t8_zm_mob_brutus" + animType);
                    CheckAnimName("ai_t8_zm_twrs_hllpht" + aiAnimType);
                    CheckAnimName("ai_t8_zm_twrs_tgr" + aiAnimType);
                    CheckAnimName("ai_t8_zm_twrs_zg_dstyr" + aiAnimType);
                    CheckAnimName("ai_t8_zm_twrs_zg_mrdr" + aiAnimType);
                    CheckAnimName("ai_t8_zm_zod_bltfthr" + aiAnimType);
                    CheckAnimName("ai_t8_zm_zod_catalyst_electric" + aiAnimType);
                    CheckAnimName("ai_t8_zm_zod_catalyst_plasma" + aiAnimType);
                    CheckAnimName("ai_t8_zm_zod_catalyst_water" + aiAnimType);
                    CheckAnimName("ai_t8_zm_zod_stoker" + aiAnimType);
                    CheckAnimName("ai_t8_zm_zombie" + aiAnimType);
                    CheckAnimName("ai_t9_zm_abom" + aiAnimType);
                    CheckAnimName("ai_t9_zm_avogadro" + aiAnimType);
                    CheckAnimName("ai_t9_zm_hulkingsum" + aiAnimType);
                    CheckAnimName("ai_t9_zm_mechz" + aiAnimType);
                    CheckAnimName("ai_t9_zm_plague_hound" + aiAnimType);
                    CheckAnimName("ai_t9_zm_raz" + aiAnimType);
                    CheckAnimName("ai_t9_zm_steiner_base_com" + aiAnimType);
                    // BO4 Weapon Animations
                    // Backhander
                    // Eye of Apophis
                    // Gift Axe
                    // Rising Tide
                    // Spknifeork
                    // Spoon
                    // Spork
                    // vm_essex_model_07
                    // vm_hellion_salvo
                    // vm_hitchcock_m9
                    // vm_midburst
                    // vm_sumarbrandr
                    CheckAnimName("vm_action_figure" + animType);
                    CheckAnimName("vm_ar_accurate" + animType);
                    CheckAnimName("vm_ar_an94_t8" + animType);
                    CheckAnimName("vm_ar_damage" + animType);
                    CheckAnimName("vm_ar_double_barrel" + animType);
                    CheckAnimName("vm_ar_fastfire" + animType);
                    CheckAnimName("vm_ar_galil" + animType);
                    CheckAnimName("vm_ar_k57" + animType);
                    CheckAnimName("vm_ar_peacekeeper_t8" + animType);
                    CheckAnimName("vm_ar_standard" + animType);
                    CheckAnimName("vm_ar_stealth" + animType);
                    CheckAnimName("vm_argus_t8" + animType);
                    CheckAnimName("vm_ballistic_knife_t8" + animType);
                    CheckAnimName("vm_ballistic_knife_t8_dw" + animType);
                    CheckAnimName("vm_bowie_knife_t8" + animType);
                    CheckAnimName("vm_combat_knife_t8" + animType);
                    CheckAnimName("vm_demo_hammer" + animType);
                    CheckAnimName("vm_dg2" + animType);
                    CheckAnimName("vm_hades" + animType);
                    CheckAnimName("vm_homunculus" + animType);
                    CheckAnimName("vm_incendiary" + animType);
                    CheckAnimName("vm_katana" + animType);
                    CheckAnimName("vm_koshka" + animType);
                    CheckAnimName("vm_lmg_heavy" + animType);
                    CheckAnimName("vm_lmg_mk48" + animType);
                    CheckAnimName("vm_lmg_mg08" + animType);
                    CheckAnimName("vm_money_bag_t8" + animType);
                    CheckAnimName("vm_mp40" + animType);
                    CheckAnimName("vm_mp9" + animType);
                    CheckAnimName("vm_pistol_auto" + animType);
                    CheckAnimName("vm_pistol_burst" + animType);
                    CheckAnimName("vm_pistol_revolver" + animType);
                    CheckAnimName("vm_pistol_standard" + animType);
                    CheckAnimName("vm_pistol_webley" + animType);
                    CheckAnimName("vm_polynesian_club_t8" + animType);
                    CheckAnimName("vm_raygun" + animType);
                    CheckAnimName("vm_reaper_lmg" + animType);
                    CheckAnimName("vm_scorpion" + animType);
                    CheckAnimName("vm_shotgun_full_auto" + animType);
                    CheckAnimName("vm_shotgun_pump" + animType);
                    CheckAnimName("vm_shotgun_semiauto" + animType);
                    CheckAnimName("vm_shotgun_trench" + animType);
                    CheckAnimName("vm_slaybell" + animType);
                    CheckAnimName("vm_smg_accurate" + animType);
                    CheckAnimName("vm_smg_capacity" + animType);
                    CheckAnimName("vm_smg_drum_pistol" + animType);
                    CheckAnimName("vm_smg_fastburst" + animType);
                    CheckAnimName("vm_smg_fastfire" + animType);
                    CheckAnimName("vm_smg_folding" + animType);
                    CheckAnimName("vm_smg_handling" + animType);
                    CheckAnimName("vm_smg_minigun" + animType);
                    CheckAnimName("vm_smg_thompson" + animType);
                    CheckAnimName("vm_smg_vmp_t8" + animType);
                    CheckAnimName("vm_sniper_damagesemi" + animType);
                    CheckAnimName("vm_sniper_fast_rechamber" + animType);
                    CheckAnimName("vm_sniper_locus_t8" + animType);
                    CheckAnimName("vm_sniper_mini14" + animType);
                    CheckAnimName("vm_sniper_power_semi" + animType);
                    CheckAnimName("vm_sniper_vanguard" + animType);
                    CheckAnimName("vm_special_crossbow" + animType);
                    CheckAnimName("vm_stop_sign" + animType);
                    CheckAnimName("vm_titan" + animType);
                    CheckAnimName("vm_tr_damageburst_t8" + animType);
                    CheckAnimName("vm_tr_flechette" + animType);
                    CheckAnimName("vm_tr_power_semi" + animType);
                    CheckAnimName("vm_tr_swordfish" + animType);
                    CheckAnimName("vm_ww_akud" + animType);
                    CheckAnimName("vm_ww_blundergat" + animType);
                    CheckAnimName("vm_zom_arm" + animType);
                    CheckAnimName("vm_zom_nesting_doll" + animType);
                    CheckAnimName("vm_zom_raygun_mk2" + animType);
                    CheckAnimName("vm_zom_thundergun" + animType);
                    // CW Weapon Animations
                    CheckAnimName("pt_ar_accurate_t9" + animType);
                    CheckAnimName("pt_ar_british_t9" + animType);
                    CheckAnimName("pt_ar_damage_t9" + animType);
                    CheckAnimName("pt_ar_fastfire_t9" + animType);
                    CheckAnimName("pt_ar_fasthandling_t9" + animType);
                    CheckAnimName("pt_ar_mobility_t9" + animType);
                    CheckAnimName("pt_ar_season6_t9" + animType);
                    CheckAnimName("pt_ar_slowfire_t9" + animType);
                    CheckAnimName("pt_ar_slowhandling_t9" + animType);
                    CheckAnimName("pt_ar_soviet_t9" + animType);
                    CheckAnimName("pt_ar_standard_t9" + animType);
                    CheckAnimName("pt_ballistic_knife_t9" + animType);
                    CheckAnimName("pt_baseball_bat_t9" + animType);
                    CheckAnimName("pt_battle_axe_t9" + animType);
                    CheckAnimName("pt_br_freefall" + animType);
                    CheckAnimName("pt_br_parachute" + animType);
                    CheckAnimName("pt_brawler_t9" + animType);
                    CheckAnimName("pt_cane_t9" + animType);
                    CheckAnimName("pt_com_t9" + animType);
                    CheckAnimName("pt_combat_knife_t9" + animType);
                    CheckAnimName("pt_concussion_grenade_t9" + animType);
                    CheckAnimName("pt_crossbow_t9" + animType);
                    CheckAnimName("pt_dual_sai_t9" + animType);
                    CheckAnimName("pt_etool_t9" + animType);
                    CheckAnimName("pt_flamethrower_t9" + animType);
                    CheckAnimName("pt_frag_grenade_t9" + animType);
                    CheckAnimName("pt_grapple_gun_t9" + animType);
                    CheckAnimName("pt_hammer_sickle_t9" + animType);
                    CheckAnimName("pt_hatchet_t9" + animType);
                    CheckAnimName("pt_launcher_freefire_t9" + animType);
                    CheckAnimName("pt_launcher_standard_t9" + animType);
                    CheckAnimName("pt_lmg_accurate_t9" + animType);
                    CheckAnimName("pt_lmg_fastfire_t9" + animType);
                    CheckAnimName("pt_lmg_light_t9" + animType);
                    CheckAnimName("pt_lmg_slowfire_t9" + animType);
                    CheckAnimName("pt_mace_t9" + animType);
                    CheckAnimName("pt_machete_t9" + animType);
                    CheckAnimName("pt_minigun_t9" + animType);
                    CheckAnimName("pt_nailgun_t9" + animType);
                    CheckAnimName("pt_pistol_burst_t9" + animType);
                    CheckAnimName("pt_pistol_fullauto_t9" + animType);
                    CheckAnimName("pt_pistol_revolver_t9" + animType);
                    CheckAnimName("pt_pistol_semiauto_t9" + animType);
                    CheckAnimName("pt_pistol_shotgun_t9" + animType);
                    CheckAnimName("pt_raygun_t9" + animType);
                    CheckAnimName("pt_scythe_t9" + animType);
                    CheckAnimName("pt_semtex_grenade_t9" + animType);
                    CheckAnimName("pt_shotgun_fullauto_t9" + animType);
                    CheckAnimName("pt_shotgun_leveraction_t9" + animType);
                    CheckAnimName("pt_shotgun_pump_t9" + animType);
                    CheckAnimName("pt_shotgun_semiauto_t9" + animType);
                    CheckAnimName("pt_sledgehammer_t9" + animType);
                    CheckAnimName("pt_smg_accurate_t9" + animType);
                    CheckAnimName("pt_smg_burst_t9" + animType);
                    CheckAnimName("pt_smg_capacity_t9" + animType);
                    CheckAnimName("pt_smg_cqb_t9" + animType);
                    CheckAnimName("pt_smg_fastfire_t9" + animType);
                    CheckAnimName("pt_smg_flechette_t9" + animType);
                    CheckAnimName("pt_smg_handling_t9" + animType);
                    CheckAnimName("pt_smg_heavy_t9" + animType);
                    CheckAnimName("pt_smg_season6_t9" + animType);
                    CheckAnimName("pt_smg_semiauto_t9" + animType);
                    CheckAnimName("pt_smg_spray_t9" + animType);
                    CheckAnimName("pt_smg_standard_t9" + animType);
                    CheckAnimName("pt_smoke_grenade_t9" + animType);
                    CheckAnimName("pt_sniper_accurate_t9" + animType);
                    CheckAnimName("pt_sniper_cannon_t9" + animType);
                    CheckAnimName("pt_sniper_powersemi_t9" + animType);
                    CheckAnimName("pt_sniper_quickscope_t9" + animType);
                    CheckAnimName("pt_sniper_standard_t9" + animType);
                    CheckAnimName("pt_special_grenade_launcher" + animType);
                    CheckAnimName("pt_tr_damagesemi_t9" + animType);
                    CheckAnimName("pt_tr_fastburst_t9" + animType);
                    CheckAnimName("pt_tr_longburst_t9" + animType);
                    CheckAnimName("pt_tr_powerburst_t9" + animType);
                    CheckAnimName("pt_tr_precisionsemi_t9" + animType);
                    CheckAnimName("pt_wakizashi_t9" + animType);
                    CheckAnimName("pt_zm_crystal_axe_melee_t9" + animType);
                    CheckAnimName("pt_zm_crystal_axe_smg_t9" + animType);
                    CheckAnimName("pt_zm_mega_barrel_blazer_beam_t9" + animType);
                    CheckAnimName("pt_zm_mega_barrel_micro_missile_t9" + animType);
                    CheckAnimName("pt_zm_mega_barrel_pistol_t9" + animType);
                    CheckAnimName("pt_zm_ray_rifle_t9" + animType);
                    CheckAnimName("pt_zm_silver_ww_t9" + animType);
                    CheckAnimName("vm_ar_accurate_t9" + animType);
                    CheckAnimName("vm_ar_british_t9" + animType);
                    CheckAnimName("vm_ar_damage_t9" + animType);
                    CheckAnimName("vm_ar_fastfire_t9" + animType);
                    CheckAnimName("vm_ar_fasthandling_t9" + animType);
                    CheckAnimName("vm_ar_mobility_t9" + animType);
                    CheckAnimName("vm_ar_season6_t9" + animType);
                    CheckAnimName("vm_ar_slowfire_t9" + animType);
                    CheckAnimName("vm_ar_slowhandling_t9" + animType);
                    CheckAnimName("vm_ar_soviet_t9" + animType);
                    CheckAnimName("vm_ar_standard_t9" + animType);
                    CheckAnimName("vm_ballistic_knife_t9" + animType);
                    CheckAnimName("vm_baseball_bat_t9" + animType);
                    CheckAnimName("vm_battle_axe_t9" + animType);
                    CheckAnimName("vm_br_freefall" + animType);
                    CheckAnimName("vm_br_parachute" + animType);
                    CheckAnimName("vm_brawler_t9" + animType);
                    CheckAnimName("vm_cane_t9" + animType);
                    CheckAnimName("vm_com" + animType);
                    CheckAnimName("vm_com_t9" + animType);
                    CheckAnimName("vm_combat_knife_t9" + animType);
                    CheckAnimName("vm_concussion_grenade_t9" + animType);
                    CheckAnimName("vm_crossbow_t9" + animType);
                    CheckAnimName("vm_dual_sai_t9" + animType);
                    CheckAnimName("vm_etool_t9" + animType);
                    CheckAnimName("vm_flamethrower_t9" + animType);
                    CheckAnimName("vm_frag_grenade_t9" + animType);
                    CheckAnimName("vm_grapple_gun_t9" + animType);
                    CheckAnimName("vm_hammer_sickle_t9" + animType);
                    CheckAnimName("vm_hatchet_t9" + animType);
                    CheckAnimName("vm_launcher_freefire_t9" + animType);
                    CheckAnimName("vm_launcher_standard_t9" + animType);
                    CheckAnimName("vm_lmg_accurate_t9" + animType);
                    CheckAnimName("vm_lmg_fastfire_t9" + animType);
                    CheckAnimName("vm_lmg_light_t9" + animType);
                    CheckAnimName("vm_lmg_slowfire_t9" + animType);
                    CheckAnimName("vm_mace_t9" + animType);
                    CheckAnimName("vm_machete_t9" + animType);
                    CheckAnimName("vm_minigun_t9" + animType);
                    CheckAnimName("vm_nailgun_t9" + animType);
                    CheckAnimName("vm_pistol_burst_t9" + animType);
                    CheckAnimName("vm_pistol_fullauto_t9" + animType);
                    CheckAnimName("vm_pistol_revolver_t9" + animType);
                    CheckAnimName("vm_pistol_semiauto_t9" + animType);
                    CheckAnimName("vm_pistol_shotgun_t9" + animType);
                    CheckAnimName("vm_ray_gun_t9" + animType);
                    CheckAnimName("vm_scythe_t9" + animType);
                    CheckAnimName("vm_semtex_grenade_t9" + animType);
                    CheckAnimName("vm_shotgun_fullauto_t9" + animType);
                    CheckAnimName("vm_shotgun_leveraction_t9" + animType);
                    CheckAnimName("vm_shotgun_pump_t9" + animType);
                    CheckAnimName("vm_shotgun_semiauto_t9" + animType);
                    CheckAnimName("vm_sledgehammer_t9" + animType);
                    CheckAnimName("vm_smg_accurate_t9" + animType);
                    CheckAnimName("vm_smg_burst_t9" + animType);
                    CheckAnimName("vm_smg_capacity_t9" + animType);
                    CheckAnimName("vm_smg_cqb_t9" + animType);
                    CheckAnimName("vm_smg_fastfire_t9" + animType);
                    CheckAnimName("vm_smg_flechette_t9" + animType);
                    CheckAnimName("vm_smg_handling_t9" + animType);
                    CheckAnimName("vm_smg_heavy_t9" + animType);
                    CheckAnimName("vm_smg_season6_t9" + animType);
                    CheckAnimName("vm_smg_semiauto_t9" + animType);
                    CheckAnimName("vm_smg_spray_t9" + animType);
                    CheckAnimName("vm_smg_standard_t9" + animType);
                    CheckAnimName("vm_smoke_grenade_t9" + animType);
                    CheckAnimName("vm_sniper_accurate_t9" + animType);
                    CheckAnimName("vm_sniper_cannon_t9" + animType);
                    CheckAnimName("vm_sniper_powersemi_t9" + animType);
                    CheckAnimName("vm_sniper_quickscope_t9" + animType);
                    CheckAnimName("vm_sniper_standard_t9" + animType);
                    CheckAnimName("vm_special_grenade_launcher" + animType);
                    CheckAnimName("vm_tactical" + animType);
                    CheckAnimName("vm_tr_damagesemi_t9" + animType);
                    CheckAnimName("vm_tr_fastburst_t9" + animType);
                    CheckAnimName("vm_tr_longburst_t9" + animType);
                    CheckAnimName("vm_tr_powerburst_t9" + animType);
                    CheckAnimName("vm_tr_precisionsemi_t9" + animType);
                    CheckAnimName("vm_wakizashi_t9" + animType);
                    CheckAnimName("vm_zm_crystal_axe_melee_t9" + animType);
                    CheckAnimName("vm_zm_crystal_axe_smg_t9" + animType);
                    CheckAnimName("vm_zm_mega_barrel_blazer_beam_t9" + animType);
                    CheckAnimName("vm_zm_mega_barrel_micro_missile_t9" + animType);
                    CheckAnimName("vm_zm_mega_barrel_pistol_t9" + animType);
                    CheckAnimName("vm_zm_ray_rifle_t9" + animType);
                    CheckAnimName("vm_zm_silver_ww_t9" + animType);
                }
            }
            foreach (string imageType in ImageTypes)
            {
                foreach (string imageWpnAttachmentType in ImageWpnAttachmentTypes)
                {
                    foreach (string imageWpnBlueprintType in ImageWpnBlueprintTypes)
                    {
                        // CW Weapon & Operator Images
                        // Swap imageWpnAttachmentType with imageWpnBlueprintType as some bundles have swapped names for more results
                        CheckImageName("" + imageType);
                        //CheckImageName("i_mtl_wpn_t9" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_bp_smg_standard" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_bp_sniper_quickscope" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_bp_sniper_standard" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_bp_tr_damagesemi" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_bp_tr_longburst" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_combat_knife_american" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_grenade_launcher" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_lmg_accurate" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_lmg_accurate_cb" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_lmg_light" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_lmg_slowfire" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_ar_fasthandling" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_ar_slowfire" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_ar_slowhandling" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_ar_soviet" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_bp" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_lmg_fastfire" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_shotgun_leveraction" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_shotgun_sweeper" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_smg_cqb" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_smg_fastfire" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_smg_ingram" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_smg_lapa" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_smg_semiauto" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_smg_spray" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_sniper_cannon" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_tr_fastburst" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_melee_hammersickle_hammer" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_melee_hammersickle_sikle" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_melee_shovel" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_melee_wakizashi" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_pistol_burst" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_pistol_burst_cb" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_pistol_burst_cb_secondary" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_pistol_burst_secondary" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_pistol_revolver" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_pistol_semiauto" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_shotgun_pump" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_shotgun_semiauto_cb" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_smg_burst" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_smg_capacity" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_smg_handling" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_smg_heavy" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_smg_standard_cb" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_sniper_accurate" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_sniper_powersemi_cb" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_sniper_quickscope" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_sniper_standard" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_special_crossbow" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_tr_damagesemi" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_tr_fullauto_classic" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_tr_longburst" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_tr_powerburst_cb" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_tr_precisionsemi" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_zm_monkey" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_zm_raygun" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_ar_accurate" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_ar_british" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_ar_damage" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_ar_fastfire" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_ar_fasthandling" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_ar_krig6" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_ar_mercenary" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_ar_mobility" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_ar_season6" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_ar_slowfire" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_ar_slowhandling" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_ar_soviet" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_ar_standard" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_bp_ar_damage" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_bp_ar_fastfire" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_bp_ar_krig6" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_bp_ar_mercenary" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_bp_ar_mobility" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_bp_lmg_light" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_bp_loot_ar_fasthandling" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_bp_pistol_burst" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_bp_pistol_revolver" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_bp_pistol_semiauto" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_bp_shotgun_pump" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_bp_smg_burst" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_bp_smg_handling" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_bp_smg_heavy" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_combat_knife_american" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_grenade_launcher" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_knife_ballistic" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_launcher_freefire" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_launcher_standard" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_lmg_accurate" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_lmg_fastfire" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_lmg_light" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_lmg_slowfire" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_ar_british" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_ar_fasthandling" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_ar_season6" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_ar_slowfire" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_ar_slowhandling" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_ar_soviet" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_lmg_fastfire" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_nailgun" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_pistol_fullauto" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_pistol_shotgun" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_shotgun_fullauto" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_shotgun_leveraction" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_smg_accurate" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_smg_cqb" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_smg_fastfire" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_smg_flechette" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_smg_lapa" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_smg_semiauto" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_smg_spray" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_sniper_accurate" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_sniper_cannon" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_loot_tr_fastburst" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_machete" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_melee_axe" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_melee_bat" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_melee_cane" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_melee_hammersickle_hammer" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_melee_hammersickle_sikle" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_melee_mace" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_melee_sais" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_melee_scythe" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_melee_shovel" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_melee_sledgehammer" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_melee_wakizashi" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_nailgun" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_pistol_burst" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_pistol_fullauto" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_pistol_revolver" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_pistol_semiauto" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_pistol_shotgun" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_shotgun_fullauto" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_shotgun_leveraction" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_shotgun_pump" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_shotgun_semiauto" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_smg_accurate" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_smg_burst" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_smg_capacity" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_smg_cqb" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_smg_fastfire" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_smg_flechette" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_smg_handling" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_smg_heavy" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_smg_lapa" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_smg_semiauto" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_smg_spray" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_smg_standard" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_sniper_accurate" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_sniper_cannon" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_sniper_powersemi" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_sniper_quickscope" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_sniper_standard" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_special_crossbow" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_tr_damagesemi" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_tr_fastburst" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_tr_longburst" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_tr_powerburst" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_tr_precisionsemi" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_zm_mega_barrel" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_zm_monkey" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_mtl_wpn_t9_zm_raygun" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_ar_accurate" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_ar_british" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_ar_damage" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_ar_fastfire" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_ar_fasthandling" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_ar_krig6" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_ar_mercenary" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_ar_mobility" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_ar_season6" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_ar_slowfire" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_ar_slowhandling" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_ar_soviet" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_ar_standard" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_combat_knife_american" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_grenade_launcher" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_knife_ballistic" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_launcher_freefire" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_launcher_standard" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_lmg_accurate" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_lmg_fastfire" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_lmg_light" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_lmg_slowfire" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_loot_ar_british" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_loot_ar_fasthandling" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_loot_ar_season6" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_loot_ar_slowfire" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_loot_ar_slowhandling" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_loot_ar_soviet" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_loot_lmg_fastfire" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_loot_nailgun" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_loot_pistol_fullauto" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_loot_pistol_shotgun" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_loot_shotgun_fullauto" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_loot_shotgun_leveraction" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_loot_smg_accurate" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_loot_smg_cqb" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_loot_smg_fastfire" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_loot_smg_flechette" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_loot_smg_lapa" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_loot_smg_semiauto" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_loot_smg_spray" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_loot_sniper_accurate" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_loot_sniper_cannon" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_loot_tr_fastburst" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_machete" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_melee_axe" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_melee_bat" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_melee_cane" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_melee_hammersickle_hammer" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_melee_hammersickle_sikle" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_melee_mace" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_melee_sais" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_melee_scythe" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_melee_shovel" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_melee_sledgehammer" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_melee_wakizashi" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_nailgun" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_pistol_burst" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_pistol_fullauto" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_pistol_revolver" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_pistol_semiauto" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_pistol_shotgun" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_shotgun_fullauto" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_shotgun_leveraction" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_shotgun_pump" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_shotgun_semiauto" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_smg_accurate" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_smg_burst" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_smg_capacity" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_smg_cqb" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_smg_fastfire" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_smg_flechette" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_smg_handling" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_smg_heavy" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_smg_lapa" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_smg_semiauto" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_smg_spray" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_smg_standard" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_sniper_accurate" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_sniper_cannon" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_sniper_powersemi" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_sniper_quickscope" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_sniper_standard" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_special_crossbow" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_tr_damagesemi" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_tr_fastburst" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_tr_longburst" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_tr_powerburst" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_tr_precisionsemi" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_zm_mega_barrel" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_zm_monkey" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                        //CheckImageName("i_wpn_t9_zm_raygun" + imageWpnAttachmentType + imageWpnBlueprintType + imageType);
                    }
                }
            }
            foreach (string materialType in MaterialTypes)
            {
                // BO4 & CW Materials
                CheckMaterialName("" + materialType);
                CheckMaterialName("ei/" + materialType);
                CheckMaterialName("el/" + materialType);
                CheckMaterialName("mc/" + materialType);
                CheckMaterialName("mc/c_t7" + materialType);
                CheckMaterialName("mc/c_t8" + materialType);
                CheckMaterialName("mc/c_t9" + materialType);
                CheckMaterialName("mc/i_mtl" + materialType);
                CheckMaterialName("mc/i_mtl_mtl_mtl_veh_t7" + materialType);
                CheckMaterialName("mc/i_mtl_mtl_mtl_veh_t8" + materialType);
                CheckMaterialName("mc/i_mtl_mtl_mtl_veh_t9" + materialType);
                CheckMaterialName("mc/i_mtl_mtl_veh_t7" + materialType);
                CheckMaterialName("mc/i_mtl_mtl_veh_t8" + materialType);
                CheckMaterialName("mc/i_mtl_mtl_veh_t9" + materialType);
                CheckMaterialName("mc/i_mtl_veh_t7" + materialType);
                CheckMaterialName("mc/i_mtl_veh_t8" + materialType);
                CheckMaterialName("mc/i_mtl_veh_t9" + materialType);
                CheckMaterialName("mc/i_p7" + materialType);
                CheckMaterialName("mc/i_p8" + materialType);
                CheckMaterialName("mc/i_p9" + materialType);
                CheckMaterialName("mc/i_t7" + materialType);
                CheckMaterialName("mc/i_t8" + materialType);
                CheckMaterialName("mc/i_t9" + materialType);
                CheckMaterialName("mc/i_veh" + materialType);
                CheckMaterialName("mc/i_veh_t7" + materialType);
                CheckMaterialName("mc/i_veh_t8" + materialType);
                CheckMaterialName("mc/i_veh_t9" + materialType);
                CheckMaterialName("mc/i_wpn_t7" + materialType);
                CheckMaterialName("mc/i_wpn_t8" + materialType);
                CheckMaterialName("mc/i_wpn_t9" + materialType);
                CheckMaterialName("mc/mlt" + materialType);
                CheckMaterialName("mc/mlt_mtl" + materialType);
                CheckMaterialName("mc/mtl" + materialType);
                CheckMaterialName("mc/mtl_c_t7" + materialType);
                CheckMaterialName("mc/mtl_c_t8" + materialType);
                CheckMaterialName("mc/mtl_c_t9" + materialType);
                CheckMaterialName("mc/mtl_mlt" + materialType);
                CheckMaterialName("mc/mtl_mtl" + materialType);
                CheckMaterialName("mc/mtl_mtl_c_t7" + materialType);
                CheckMaterialName("mc/mtl_mtl_c_t8" + materialType);
                CheckMaterialName("mc/mtl_mtl_c_t9" + materialType);
                CheckMaterialName("mc/mtl_mtl_mtl" + materialType);
                CheckMaterialName("mc/mtl_mtl_mtl_c_t7" + materialType);
                CheckMaterialName("mc/mtl_mtl_mtl_c_t8" + materialType);
                CheckMaterialName("mc/mtl_mtl_mtl_c_t9" + materialType);
                CheckMaterialName("mc/mtl_mtl_mtl_p7" + materialType);
                CheckMaterialName("mc/mtl_mtl_mtl_p8" + materialType);
                CheckMaterialName("mc/mtl_mtl_mtl_p9" + materialType);
                CheckMaterialName("mc/mtl_mtl_mtl_t7" + materialType);
                CheckMaterialName("mc/mtl_mtl_mtl_t8" + materialType);
                CheckMaterialName("mc/mtl_mtl_mtl_t9" + materialType);
                CheckMaterialName("mc/mtl_mtl_p7" + materialType);
                CheckMaterialName("mc/mtl_mtl_p8" + materialType);
                CheckMaterialName("mc/mtl_mtl_p9" + materialType);
                CheckMaterialName("mc/mtl_mtl_t7" + materialType);
                CheckMaterialName("mc/mtl_mtl_t8" + materialType);
                CheckMaterialName("mc/mtl_mtl_t9" + materialType);
                CheckMaterialName("mc/mtl_p7" + materialType);
                CheckMaterialName("mc/mtl_p8" + materialType);
                CheckMaterialName("mc/mtl_p9" + materialType);
                CheckMaterialName("mc/mtl_t7" + materialType);
                CheckMaterialName("mc/mtl_t8" + materialType);
                CheckMaterialName("mc/mtl_t9" + materialType);
                CheckMaterialName("mcs/" + materialType);
                CheckMaterialName("vd/" + materialType);
                CheckMaterialName("vdd/" + materialType);
                CheckMaterialName("wc/" + materialType);
            }
            foreach (string modelType in ModelTypes)
            {
                // CW Operator Models & Skins
                CheckModelName("" + modelType);
                CheckModelName("c_t9_aml_komodo_dragon" + modelType);
                CheckModelName("c_t9_aml_rabbit" + modelType);
                CheckModelName("c_t9_aml_rottweiler" + modelType);
                CheckModelName("c_t9_aml_snow_leopard" + modelType);
                CheckModelName("c_t9_base_female_nude" + modelType);
                CheckModelName("c_t9_base_male_nude_2" + modelType);
                CheckModelName("c_t9_base_male_nude_buff" + modelType);
                CheckModelName("c_t9_cp_rus_pl_f_agent_global_infil_combat" + modelType);
                CheckModelName("c_t9_cp_rus_pl_f_agent_hub_infil" + modelType);
                CheckModelName("c_t9_cp_rus_pl_f_agent_nam_infil_combat" + modelType);
                CheckModelName("c_t9_cp_rus_pl_m_agent_global_infil_combat" + modelType);
                CheckModelName("c_t9_cp_rus_pl_m_agent_global_undrcvr_civ" + modelType);
                CheckModelName("c_t9_cp_rus_pl_m_agent_hub_infil_combat" + modelType);
                CheckModelName("c_t9_cp_usa_pl_mason_infil_takedown" + modelType);
                CheckModelName("c_t9_cp_usa_pl_mason_yam_winter" + modelType);
                CheckModelName("c_t9_cub_pl_dgi_barrio" + modelType);
                CheckModelName("c_t9_cub_pl_dgi_bongo" + modelType);
                CheckModelName("c_t9_cub_pl_dgi_brawler" + modelType);
                CheckModelName("c_t9_cub_pl_dgi_commando" + modelType);
                CheckModelName("c_t9_cub_pl_dgi_el_jefe" + modelType);
                CheckModelName("c_t9_cub_pl_dgi_flick" + modelType);
                CheckModelName("c_t9_cub_pl_dgi_general" + modelType);
                CheckModelName("c_t9_cub_pl_dgi_havana" + modelType);
                CheckModelName("c_t9_cub_pl_dgi_hitman" + modelType);
                CheckModelName("c_t9_cub_pl_dgi_infiltration" + modelType);
                CheckModelName("c_t9_cub_pl_dgi_jack" + modelType);
                CheckModelName("c_t9_cub_pl_dgi_jack_ms" + modelType);
                CheckModelName("c_t9_cub_pl_dgi_jack_pc" + modelType);
                CheckModelName("c_t9_cub_pl_dgi_jack_sy" + modelType);
                CheckModelName("c_t9_cub_pl_dgi_lucha" + modelType);
                CheckModelName("c_t9_cub_pl_dgi_mechanic" + modelType);
                CheckModelName("c_t9_cub_pl_dgi_rebel_leader" + modelType);
                CheckModelName("c_t9_cub_pl_dgi_sicario" + modelType);
                CheckModelName("c_t9_cub_pl_dgi_slasher" + modelType);
                CheckModelName("c_t9_cub_pl_dgi_tropas_ms" + modelType);
                CheckModelName("c_t9_cub_pl_dgi_tropas_pc" + modelType);
                CheckModelName("c_t9_cub_pl_dgi_tropas_sy" + modelType);
                CheckModelName("c_t9_cub_pl_dgi_warlord" + modelType);
                CheckModelName("c_t9_eg_pl_quicksand" + modelType);
                CheckModelName("c_t9_eg_pl_quicksand_khopesh" + modelType);
                CheckModelName("c_t9_eg_pl_quicksand_slither" + modelType);
                CheckModelName("c_t9_esp_pl_goe_bomber" + modelType);
                CheckModelName("c_t9_esp_pl_goe_bomber_scrapmetal" + modelType);
                CheckModelName("c_t9_fin_pl_wraith" + modelType);
                CheckModelName("c_t9_fin_pl_wraith_automaton" + modelType);
                CheckModelName("c_t9_fin_pl_wraith_burnout" + modelType);
                CheckModelName("c_t9_fin_pl_wraith_freya" + modelType);
                CheckModelName("c_t9_fin_pl_wraith_havoc" + modelType);
                CheckModelName("c_t9_fin_pl_wraith_white_queen" + modelType);
                CheckModelName("c_t9_fra_pl_dgse_amped" + modelType);
                CheckModelName("c_t9_fra_pl_dgse_arc" + modelType);
                CheckModelName("c_t9_fra_pl_dgse_dakar" + modelType);
                CheckModelName("c_t9_fra_pl_dgse_gign" + modelType);
                CheckModelName("c_t9_fra_pl_dgse_infiltration" + modelType);
                CheckModelName("c_t9_fra_pl_dgse_mademoiselle" + modelType);
                CheckModelName("c_t9_gen_pl_esports_female" + modelType);
                CheckModelName("c_t9_gen_pl_esports_female_ms" + modelType);
                CheckModelName("c_t9_gen_pl_esports_female_pc" + modelType);
                CheckModelName("c_t9_gen_pl_esports_female_sy" + modelType);
                CheckModelName("c_t9_gen_pl_esports_male_ms" + modelType);
                CheckModelName("c_t9_gen_pl_esports_male_pc" + modelType);
                CheckModelName("c_t9_gen_pl_esports_male_sy" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_empire_ms" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_empire_pc" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_empire_sy" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_faze_ms" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_faze_pc" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_faze_sy" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_guerillas_ms" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_guerillas_pc" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_guerillas_sy" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_legion_ms" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_legion_pc" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_legion_sy" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_mutineers_ms" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_mutineers_pc" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_mutineers_sy" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_optic_ms" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_optic_pc" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_optic_sy" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_rokkr_ms" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_rokkr_pc" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_rokkr_sy" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_royalravens_ms" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_royalravens_pc" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_royalravens_sy" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_subliners_ms" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_subliners_pc" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_subliners_sy" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_surge_ms" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_surge_pc" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_surge_sy" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_thieves_ms" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_thieves_pc" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_thieves_sy" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_ultra_ms" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_ultra_pc" + modelType);
                CheckModelName("c_t9_gen_pl_esports_watch_ultra_sy" + modelType);
                CheckModelName("c_t9_gen_pl_starter1" + modelType);
                CheckModelName("c_t9_gen_pl_starter1_hunter_dash" + modelType);
                CheckModelName("c_t9_gen_pl_starter1_hunter_eagleeye" + modelType);
                CheckModelName("c_t9_gen_pl_starter1_hunter_frontline" + modelType);
                CheckModelName("c_t9_gen_pl_starter1_hunter_inferno" + modelType);
                CheckModelName("c_t9_gen_pl_starter1_hunter_killer" + modelType);
                CheckModelName("c_t9_gen_pl_starter1_hunter_rescue" + modelType);
                CheckModelName("c_t9_gen_pl_starter2" + modelType);
                CheckModelName("c_t9_gen_pl_starter2_vargas_bacano" + modelType);
                CheckModelName("c_t9_gen_pl_starter2_vargas_bull_bull_ms" + modelType);
                CheckModelName("c_t9_gen_pl_starter2_vargas_bull_bull_pc" + modelType);
                CheckModelName("c_t9_gen_pl_starter2_vargas_bull_bull_sy" + modelType);
                CheckModelName("c_t9_gen_pl_starter2_vargas_bunker" + modelType);
                CheckModelName("c_t9_gen_pl_starter2_vargas_finishline" + modelType);
                CheckModelName("c_t9_gen_pl_starter2_vargas_major" + modelType);
                CheckModelName("c_t9_gen_pl_starter2_vargas_steel" + modelType);
                CheckModelName("c_t9_gen_pl_starter2_vargas_stovepipe" + modelType);
                CheckModelName("c_t9_gen_pl_starter3" + modelType);
                CheckModelName("c_t9_gen_pl_starter3_stone_ash" + modelType);
                CheckModelName("c_t9_gen_pl_starter3_stone_bollocks_ms" + modelType);
                CheckModelName("c_t9_gen_pl_starter3_stone_bollocks_pc" + modelType);
                CheckModelName("c_t9_gen_pl_starter3_stone_bollocks_sy" + modelType);
                CheckModelName("c_t9_gen_pl_starter3_stone_bugscreen" + modelType);
                CheckModelName("c_t9_gen_pl_starter3_stone_carver" + modelType);
                CheckModelName("c_t9_gen_pl_starter3_stone_infestation" + modelType);
                CheckModelName("c_t9_gen_pl_starter3_stone_insurgent" + modelType);
                CheckModelName("c_t9_gen_pl_starter3_stone_jammy" + modelType);
                CheckModelName("c_t9_gen_pl_starter3_stone_ripper" + modelType);
                CheckModelName("c_t9_gen_pl_starter3_stone_seige" + modelType);
                CheckModelName("c_t9_gen_pl_starter3_stone_squelch" + modelType);
                CheckModelName("c_t9_gen_pl_starter3_stone_stoned" + modelType);
                CheckModelName("c_t9_gen_pl_starter3_stone_storefront" + modelType);
                CheckModelName("c_t9_gen_pl_starter4" + modelType);
                CheckModelName("c_t9_gen_pl_starter4_song_backflip" + modelType);
                CheckModelName("c_t9_gen_pl_starter4_song_bloom" + modelType);
                CheckModelName("c_t9_gen_pl_starter4_song_busted" + modelType);
                CheckModelName("c_t9_gen_pl_starter4_song_counter" + modelType);
                CheckModelName("c_t9_gen_pl_starter4_song_dagger" + modelType);
                CheckModelName("c_t9_gen_pl_starter4_song_flare" + modelType);
                CheckModelName("c_t9_gen_pl_starter4_song_mechanic_ms" + modelType);
                CheckModelName("c_t9_gen_pl_starter4_song_mechanic_pc" + modelType);
                CheckModelName("c_t9_gen_pl_starter4_song_mechanic_sy" + modelType);
                CheckModelName("c_t9_gen_pl_starter4_song_observer" + modelType);
                CheckModelName("c_t9_gen_pl_starter4_song_tiger" + modelType);
                CheckModelName("c_t9_gen_pl_starter5" + modelType);
                CheckModelName("c_t9_gen_pl_starter5_powers_cameroon" + modelType);
                CheckModelName("c_t9_gen_pl_starter5_powers_desert" + modelType);
                CheckModelName("c_t9_gen_pl_starter5_powers_driver" + modelType);
                CheckModelName("c_t9_gen_pl_starter5_powers_dust" + modelType);
                CheckModelName("c_t9_gen_pl_starter5_powers_ffl" + modelType);
                CheckModelName("c_t9_gen_pl_starter5_powers_gun" + modelType);
                CheckModelName("c_t9_gen_pl_starter5_powers_stealth" + modelType);
                CheckModelName("c_t9_gen_pl_starter5_powers_swift" + modelType);
                CheckModelName("c_t9_ger_pl_maxis_berlin" + modelType);
                CheckModelName("c_t9_ger_pl_maxis_bride" + modelType);
                CheckModelName("c_t9_ger_pl_maxis_dark" + modelType);
                CheckModelName("c_t9_ger_pl_maxis_lumens" + modelType);
                CheckModelName("c_t9_ger_pl_maxis_phantom" + modelType);
                CheckModelName("c_t9_ger_pl_maxis_scythe" + modelType);
                CheckModelName("c_t9_ger_pl_maxis_traveler" + modelType);
                CheckModelName("c_t9_ger_pl_west_bomber" + modelType);
                CheckModelName("c_t9_ger_pl_west_carnage" + modelType);
                CheckModelName("c_t9_ger_pl_west_gothic" + modelType);
                CheckModelName("c_t9_ger_pl_west_gsg9_3" + modelType);
                CheckModelName("c_t9_ger_pl_west_gsg9_hardhat" + modelType);
                CheckModelName("c_t9_ger_pl_west_infiltration" + modelType);
                CheckModelName("c_t9_ger_pl_west_judge_dredd" + modelType);
                CheckModelName("c_t9_ger_pl_west_klown" + modelType);
                CheckModelName("c_t9_ger_pl_west_nightops" + modelType);
                CheckModelName("c_t9_ger_pl_west_paratrooper" + modelType);
                CheckModelName("c_t9_ger_pl_west_patrol" + modelType);
                CheckModelName("c_t9_ger_pl_west_police" + modelType);
                CheckModelName("c_t9_ger_pl_west_professor" + modelType);
                CheckModelName("c_t9_ger_pl_west_racer" + modelType);
                CheckModelName("c_t9_ger_pl_west_raider" + modelType);
                CheckModelName("c_t9_ger_pl_west_stalker" + modelType);
                CheckModelName("c_t9_ger_pl_west_stealth" + modelType);
                CheckModelName("c_t9_ger_pl_west_stronghold" + modelType);
                CheckModelName("c_t9_ger_pl_west_swat" + modelType);
                CheckModelName("c_t9_ger_pl_west_tagger_ii" + modelType);
                CheckModelName("c_t9_ger_pl_west_winter" + modelType);
                CheckModelName("c_t9_isr_pl_lazar_idf" + modelType);
                CheckModelName("c_t9_jpn_pl_kitsune" + modelType);
                CheckModelName("c_t9_jpn_pl_kitsune_biteme" + modelType);
                CheckModelName("c_t9_jpn_pl_kitsune_boss" + modelType);
                CheckModelName("c_t9_jpn_pl_kitsune_ultra" + modelType);
                CheckModelName("c_t9_jpn_pl_kitsune_yokai" + modelType);
                CheckModelName("c_t9_lao_pl_serpent" + modelType);
                CheckModelName("c_t9_lao_pl_serpent_haggler" + modelType);
                CheckModelName("c_t9_lao_pl_serpent_hollow" + modelType);
                CheckModelName("c_t9_lao_pl_serpent_overgrowth" + modelType);
                CheckModelName("c_t9_lao_pl_serpent_shadow" + modelType);
                CheckModelName("c_t9_lao_pl_serpent_warlord" + modelType);
                CheckModelName("c_t9_nic_pl_smuggler" + modelType);
                CheckModelName("c_t9_nic_pl_smuggler_mural" + modelType);
                CheckModelName("c_t9_nic_pl_smuggler_stinger" + modelType);
                CheckModelName("c_t9_nic_pl_smuggler_whiskey" + modelType);
                CheckModelName("c_t9_pl_f_agent_global_undrcvr_civ" + modelType);
                CheckModelName("c_t9_pl_f_agent_global_undrcvr_civ_asian" + modelType);
                CheckModelName("c_t9_pl_f_agent_global_undrcvr_civ_asian2" + modelType);
                CheckModelName("c_t9_pl_f_agent_global_undrcvr_civ_black" + modelType);
                CheckModelName("c_t9_pl_f_agent_global_undrcvr_civ_black2" + modelType);
                CheckModelName("c_t9_pl_f_agent_global_undrcvr_civ_mideast" + modelType);
                CheckModelName("c_t9_pl_f_agent_global_undrcvr_civ_mideast2" + modelType);
                CheckModelName("c_t9_pl_f_agent_global_undrcvr_civ_white" + modelType);
                CheckModelName("c_t9_pl_f_agent_global_undrcvr_civ_white2" + modelType);
                CheckModelName("c_t9_pl_f_agent_kgb_exfil_asian" + modelType);
                CheckModelName("c_t9_pl_f_agent_kgb_exfil_asian2" + modelType);
                CheckModelName("c_t9_pl_f_agent_kgb_exfil_black" + modelType);
                CheckModelName("c_t9_pl_f_agent_kgb_exfil_black2" + modelType);
                CheckModelName("c_t9_pl_f_agent_kgb_exfil_mideast" + modelType);
                CheckModelName("c_t9_pl_f_agent_kgb_exfil_mideast2" + modelType);
                CheckModelName("c_t9_pl_f_agent_kgb_exfil_white" + modelType);
                CheckModelName("c_t9_pl_f_agent_kgb_exfil_white2" + modelType);
                CheckModelName("c_t9_pl_f_agent_kgb_undrcvr_asian" + modelType);
                CheckModelName("c_t9_pl_f_agent_kgb_undrcvr_asian2" + modelType);
                CheckModelName("c_t9_pl_f_agent_kgb_undrcvr_black" + modelType);
                CheckModelName("c_t9_pl_f_agent_kgb_undrcvr_black2" + modelType);
                CheckModelName("c_t9_pl_f_agent_kgb_undrcvr_mideast" + modelType);
                CheckModelName("c_t9_pl_f_agent_kgb_undrcvr_mideast2" + modelType);
                CheckModelName("c_t9_pl_f_agent_kgb_undrcvr_white" + modelType);
                CheckModelName("c_t9_pl_f_agent_kgb_undrcvr_white2" + modelType);
                CheckModelName("c_t9_pl_m_agent_kgb_officer_exfil" + modelType);
                CheckModelName("c_t9_pl_m_agent_kgb_officer_exfil_asian" + modelType);
                CheckModelName("c_t9_pl_m_agent_kgb_officer_exfil_asian2" + modelType);
                CheckModelName("c_t9_pl_m_agent_kgb_officer_exfil_black" + modelType);
                CheckModelName("c_t9_pl_m_agent_kgb_officer_exfil_black2" + modelType);
                CheckModelName("c_t9_pl_m_agent_kgb_officer_exfil_body_asian" + modelType);
                CheckModelName("c_t9_pl_m_agent_kgb_officer_exfil_body_asian2" + modelType);
                CheckModelName("c_t9_pl_m_agent_kgb_officer_exfil_body_black" + modelType);
                CheckModelName("c_t9_pl_m_agent_kgb_officer_exfil_body_black2" + modelType);
                CheckModelName("c_t9_pl_m_agent_kgb_officer_exfil_body_mideast" + modelType);
                CheckModelName("c_t9_pl_m_agent_kgb_officer_exfil_body_mideast2" + modelType);
                CheckModelName("c_t9_pl_m_agent_kgb_officer_exfil_body_white" + modelType);
                CheckModelName("c_t9_pl_m_agent_kgb_officer_exfil_body_white2" + modelType);
                CheckModelName("c_t9_pl_m_agent_kgb_officer_exfil_mideast" + modelType);
                CheckModelName("c_t9_pl_m_agent_kgb_officer_exfil_mideast2" + modelType);
                CheckModelName("c_t9_pl_m_agent_kgb_officer_exfil_white" + modelType);
                CheckModelName("c_t9_pl_m_agent_kgb_officer_exfil_white2" + modelType);
                CheckModelName("c_t9_pl_m_agent_undcvr_kgb_guard" + modelType);
                CheckModelName("c_t9_pl_m_agent_undcvr_kgb_guard_asian" + modelType);
                CheckModelName("c_t9_pl_m_agent_undcvr_kgb_guard_asian2" + modelType);
                CheckModelName("c_t9_pl_m_agent_undcvr_kgb_guard_black" + modelType);
                CheckModelName("c_t9_pl_m_agent_undcvr_kgb_guard_black2" + modelType);
                CheckModelName("c_t9_pl_m_agent_undcvr_kgb_guard_mideast" + modelType);
                CheckModelName("c_t9_pl_m_agent_undcvr_kgb_guard_mideast2" + modelType);
                CheckModelName("c_t9_pl_m_agent_undcvr_kgb_guard_white" + modelType);
                CheckModelName("c_t9_pl_m_agent_undcvr_kgb_guard_white2" + modelType);
                CheckModelName("c_t9_pl_m_agent_undcvr_takedown" + modelType);
                CheckModelName("c_t9_pl_m_agent_undcvr_takedown_body" + modelType);
                CheckModelName("c_t9_pl_mason_infil_stealth_viewmodel" + modelType);
                CheckModelName("c_t9_rus_pl_kgb_assassin" + modelType);
                CheckModelName("c_t9_rus_pl_kgb_breakout" + modelType);
                CheckModelName("c_t9_rus_pl_kgb_bunny" + modelType);
                CheckModelName("c_t9_rus_pl_kgb_burglar" + modelType);
                CheckModelName("c_t9_rus_pl_kgb_funnybone" + modelType);
                CheckModelName("c_t9_rus_pl_kgb_ghost" + modelType);
                CheckModelName("c_t9_rus_pl_kgb_gunshow" + modelType);
                CheckModelName("c_t9_rus_pl_kgb_hash" + modelType);
                CheckModelName("c_t9_rus_pl_kgb_infantry" + modelType);
                CheckModelName("c_t9_rus_pl_kgb_infiltration" + modelType);
                CheckModelName("c_t9_rus_pl_kgb_lab" + modelType);
                CheckModelName("c_t9_rus_pl_kgb_mach1_ms" + modelType);
                CheckModelName("c_t9_rus_pl_kgb_mach1_pc" + modelType);
                CheckModelName("c_t9_rus_pl_kgb_mach1_sy" + modelType);
                CheckModelName("c_t9_rus_pl_kgb_poison" + modelType);
                CheckModelName("c_t9_rus_pl_kgb_punk" + modelType);
                CheckModelName("c_t9_rus_pl_kgb_shadow" + modelType);
                CheckModelName("c_t9_rus_pl_kgb_smoker" + modelType);
                CheckModelName("c_t9_rus_pl_kgb_spyglass" + modelType);
                CheckModelName("c_t9_rus_pl_kgb_tacticalgoth" + modelType);
                CheckModelName("c_t9_rus_pl_kgb_thekid" + modelType);
                CheckModelName("c_t9_rus_pl_kgb_urban" + modelType);
                CheckModelName("c_t9_rus_pl_kgb_valentines" + modelType);
                CheckModelName("c_t9_rus_pl_kgb_winter" + modelType);
                CheckModelName("c_t9_rus_pl_mason_winter_yam" + modelType);
                CheckModelName("c_t9_rus_pl_spetsnaz_afghan_sniper" + modelType);
                CheckModelName("c_t9_rus_pl_spetsnaz_chernobyl" + modelType);
                CheckModelName("c_t9_rus_pl_spetsnaz_grudge" + modelType);
                CheckModelName("c_t9_rus_pl_spetsnaz_infiltration" + modelType);
                CheckModelName("c_t9_rus_pl_spetsnaz_melted" + modelType);
                CheckModelName("c_t9_rus_pl_stitch_01" + modelType);
                CheckModelName("c_t9_rus_pl_stitch_brute" + modelType);
                CheckModelName("c_t9_rus_pl_stitch_cultist" + modelType);
                CheckModelName("c_t9_rus_pl_stitch_cultist_ms" + modelType);
                CheckModelName("c_t9_rus_pl_stitch_cultist_pc" + modelType);
                CheckModelName("c_t9_rus_pl_stitch_cultist_sy" + modelType);
                CheckModelName("c_t9_rus_pl_stitch_echo" + modelType);
                CheckModelName("c_t9_rus_pl_stitch_manga" + modelType);
                CheckModelName("c_t9_rus_pl_stitch_prisoner" + modelType);
                CheckModelName("c_t9_rus_pl_stitch_torn" + modelType);
                CheckModelName("c_t9_sa_pl_deathstalker" + modelType);
                CheckModelName("c_t9_sa_pl_deathstalker_bearclaw" + modelType);
                CheckModelName("c_t9_sa_pl_deathstalker_bearclaw_ms" + modelType);
                CheckModelName("c_t9_sa_pl_deathstalker_bearclaw_pc" + modelType);
                CheckModelName("c_t9_sa_pl_deathstalker_bearclaw_sy" + modelType);
                CheckModelName("c_t9_sa_pl_deathstalker_snake" + modelType);
                CheckModelName("c_t9_uk_pl_kingsley" + modelType);
                CheckModelName("c_t9_uk_pl_mi6_aftermath" + modelType);
                CheckModelName("c_t9_uk_pl_mi6_badblood" + modelType);
                CheckModelName("c_t9_uk_pl_mi6_checker" + modelType);
                CheckModelName("c_t9_uk_pl_mi6_clandestine" + modelType);
                CheckModelName("c_t9_uk_pl_mi6_coal" + modelType);
                CheckModelName("c_t9_uk_pl_mi6_derby" + modelType);
                CheckModelName("c_t9_uk_pl_mi6_doubleagent" + modelType);
                CheckModelName("c_t9_uk_pl_mi6_dystopia" + modelType);
                CheckModelName("c_t9_uk_pl_mi6_fob" + modelType);
                CheckModelName("c_t9_uk_pl_mi6_football" + modelType);
                CheckModelName("c_t9_uk_pl_mi6_glam" + modelType);
                CheckModelName("c_t9_uk_pl_mi6_guard" + modelType);
                CheckModelName("c_t9_uk_pl_mi6_handler" + modelType);
                CheckModelName("c_t9_uk_pl_mi6_heist" + modelType);
                CheckModelName("c_t9_uk_pl_mi6_ignite" + modelType);
                CheckModelName("c_t9_uk_pl_mi6_infiltration" + modelType);
                CheckModelName("c_t9_uk_pl_mi6_napalm" + modelType);
                CheckModelName("c_t9_uk_pl_mi6_racer" + modelType);
                CheckModelName("c_t9_uk_pl_mi6_scorch" + modelType);
                CheckModelName("c_t9_uk_pl_mi6_sis" + modelType);
                CheckModelName("c_t9_uk_pl_mi6_skyhook_ms" + modelType);
                CheckModelName("c_t9_uk_pl_mi6_skyhook_pc" + modelType);
                CheckModelName("c_t9_uk_pl_mi6_skyhook_sy" + modelType);
                CheckModelName("c_t9_uk_pl_mi6_snapshot" + modelType);
                CheckModelName("c_t9_uk_pl_mi6_standoff" + modelType);
                CheckModelName("c_t9_uk_pl_mi6_survivor" + modelType);
                CheckModelName("c_t9_uk_pl_mi6_tagger" + modelType);
                CheckModelName("c_t9_uk_pl_mi6_uncharted" + modelType);
                CheckModelName("c_t9_uk_pl_mi6_xray" + modelType);
                CheckModelName("c_t9_uk_pl_price" + modelType);
                CheckModelName("c_t9_uk_pl_sas_blackknight" + modelType);
                CheckModelName("c_t9_uk_pl_sas_gridlock" + modelType);
                CheckModelName("c_t9_usa_pl_adler_airborne" + modelType);
                CheckModelName("c_t9_usa_pl_adler_buoy" + modelType);
                CheckModelName("c_t9_usa_pl_adler_control" + modelType);
                CheckModelName("c_t9_usa_pl_adler_detective" + modelType);
                CheckModelName("c_t9_usa_pl_adler_detective_ms" + modelType);
                CheckModelName("c_t9_usa_pl_adler_detective_pc" + modelType);
                CheckModelName("c_t9_usa_pl_adler_detective_sy" + modelType);
                CheckModelName("c_t9_usa_pl_adler_game_fuel" + modelType);
                CheckModelName("c_t9_usa_pl_adler_gator" + modelType);
                CheckModelName("c_t9_usa_pl_adler_gunslinger" + modelType);
                CheckModelName("c_t9_usa_pl_adler_hostage" + modelType);
                CheckModelName("c_t9_usa_pl_adler_infiltration" + modelType);
                CheckModelName("c_t9_usa_pl_adler_lancer" + modelType);
                CheckModelName("c_t9_usa_pl_adler_miami" + modelType);
                CheckModelName("c_t9_usa_pl_adler_pressed" + modelType);
                CheckModelName("c_t9_usa_pl_adler_ranger" + modelType);
                CheckModelName("c_t9_usa_pl_adler_red" + modelType);
                CheckModelName("c_t9_usa_pl_adler_renegade" + modelType);
                CheckModelName("c_t9_usa_pl_adler_slayer" + modelType);
                CheckModelName("c_t9_usa_pl_adler_tropic" + modelType);
                CheckModelName("c_t9_usa_pl_adler_vbss" + modelType);
                CheckModelName("c_t9_usa_pl_adler_wire" + modelType);
                CheckModelName("c_t9_usa_pl_bulldozer_01" + modelType);
                CheckModelName("c_t9_usa_pl_bulldozer_boom" + modelType);
                CheckModelName("c_t9_usa_pl_bulldozer_forged" + modelType);
                CheckModelName("c_t9_usa_pl_bulldozer_hawk" + modelType);
                CheckModelName("c_t9_usa_pl_bulldozer_panda" + modelType);
                CheckModelName("c_t9_usa_pl_bulldozer_toxin" + modelType);
                CheckModelName("c_t9_usa_pl_cia_adler_bloodhound" + modelType);
                CheckModelName("c_t9_usa_pl_cia_adler_traveler" + modelType);
                CheckModelName("c_t9_usa_pl_cia_advisor" + modelType);
                CheckModelName("c_t9_usa_pl_cia_agent" + modelType);
                CheckModelName("c_t9_usa_pl_cia_big_joke_3" + modelType);
                CheckModelName("c_t9_usa_pl_cia_boss" + modelType);
                CheckModelName("c_t9_usa_pl_cia_captain" + modelType);
                CheckModelName("c_t9_usa_pl_cia_climber" + modelType);
                CheckModelName("c_t9_usa_pl_cia_commando" + modelType);
                CheckModelName("c_t9_usa_pl_cia_covert" + modelType);
                CheckModelName("c_t9_usa_pl_cia_grit" + modelType);
                CheckModelName("c_t9_usa_pl_cia_infiltration" + modelType);
                CheckModelName("c_t9_usa_pl_cia_kick" + modelType);
                CheckModelName("c_t9_usa_pl_cia_logger" + modelType);
                CheckModelName("c_t9_usa_pl_cia_macv" + modelType);
                CheckModelName("c_t9_usa_pl_cia_macv_code_ms" + modelType);
                CheckModelName("c_t9_usa_pl_cia_macv_code_pc" + modelType);
                CheckModelName("c_t9_usa_pl_cia_macv_code_sy" + modelType);
                CheckModelName("c_t9_usa_pl_cia_penumbra_ms" + modelType);
                CheckModelName("c_t9_usa_pl_cia_penumbra_pc" + modelType);
                CheckModelName("c_t9_usa_pl_cia_penumbra_sy" + modelType);
                CheckModelName("c_t9_usa_pl_cia_regulator" + modelType);
                CheckModelName("c_t9_usa_pl_cia_snatch" + modelType);
                CheckModelName("c_t9_usa_pl_cia_sogman" + modelType);
                CheckModelName("c_t9_usa_pl_cia_tee" + modelType);
                CheckModelName("c_t9_usa_pl_deltaforce_brutalist" + modelType);
                CheckModelName("c_t9_usa_pl_deltaforce_brutalist_ms" + modelType);
                CheckModelName("c_t9_usa_pl_deltaforce_brutalist_pc" + modelType);
                CheckModelName("c_t9_usa_pl_deltaforce_brutalist_sy" + modelType);
                CheckModelName("c_t9_usa_pl_deltaforce_cyclone" + modelType);
                CheckModelName("c_t9_usa_pl_deltaforce_dynamite" + modelType);
                CheckModelName("c_t9_usa_pl_deltaforce_halo" + modelType);
                CheckModelName("c_t9_usa_pl_deltaforce_infiltration" + modelType);
                CheckModelName("c_t9_usa_pl_deltaforce_infiltration_body" + modelType);
                CheckModelName("c_t9_usa_pl_deltaforce_jungle_warfare" + modelType);
                CheckModelName("c_t9_usa_pl_deltaforce_urgentfury" + modelType);
                CheckModelName("c_t9_usa_pl_ghostface" + modelType);
                CheckModelName("c_t9_usa_pl_hudson" + modelType);
                CheckModelName("c_t9_usa_pl_hudson_hazmat_ms" + modelType);
                CheckModelName("c_t9_usa_pl_hudson_hazmat_pc" + modelType);
                CheckModelName("c_t9_usa_pl_hudson_hazmat_sy" + modelType);
                CheckModelName("c_t9_usa_pl_hudson_rock" + modelType);
                CheckModelName("c_t9_usa_pl_mason" + modelType);
                CheckModelName("c_t9_usa_pl_mason_ultra" + modelType);
                CheckModelName("c_t9_usa_pl_masongame" + modelType);
                CheckModelName("c_t9_usa_pl_mcclane" + modelType);
                CheckModelName("c_t9_usa_pl_navyseal_air_ms" + modelType);
                CheckModelName("c_t9_usa_pl_navyseal_air_pc" + modelType);
                CheckModelName("c_t9_usa_pl_navyseal_air_sy" + modelType);
                CheckModelName("c_t9_usa_pl_navyseal_blue_devil" + modelType);
                CheckModelName("c_t9_usa_pl_navyseal_breaker" + modelType);
                CheckModelName("c_t9_usa_pl_navyseal_business" + modelType);
                CheckModelName("c_t9_usa_pl_navyseal_clown" + modelType);
                CheckModelName("c_t9_usa_pl_navyseal_dissident" + modelType);
                CheckModelName("c_t9_usa_pl_navyseal_endurance_ms" + modelType);
                CheckModelName("c_t9_usa_pl_navyseal_endurance_pc" + modelType);
                CheckModelName("c_t9_usa_pl_navyseal_endurance_sy" + modelType);
                CheckModelName("c_t9_usa_pl_navyseal_frank" + modelType);
                CheckModelName("c_t9_usa_pl_navyseal_frogman" + modelType);
                CheckModelName("c_t9_usa_pl_navyseal_gigawatt" + modelType);
                CheckModelName("c_t9_usa_pl_navyseal_grip" + modelType);
                CheckModelName("c_t9_usa_pl_navyseal_grunge" + modelType);
                CheckModelName("c_t9_usa_pl_navyseal_hopper" + modelType);
                CheckModelName("c_t9_usa_pl_navyseal_hunter" + modelType);
                CheckModelName("c_t9_usa_pl_navyseal_infiltration" + modelType);
                CheckModelName("c_t9_usa_pl_navyseal_knucklehead" + modelType);
                CheckModelName("c_t9_usa_pl_navyseal_land_ms" + modelType);
                CheckModelName("c_t9_usa_pl_navyseal_land_pc" + modelType);
                CheckModelName("c_t9_usa_pl_navyseal_land_sy" + modelType);
                CheckModelName("c_t9_usa_pl_navyseal_maverick" + modelType);
                CheckModelName("c_t9_usa_pl_navyseal_ringleader" + modelType);
                CheckModelName("c_t9_usa_pl_navyseal_sea_ms" + modelType);
                CheckModelName("c_t9_usa_pl_navyseal_sea_pc" + modelType);
                CheckModelName("c_t9_usa_pl_navyseal_sea_sy" + modelType);
                CheckModelName("c_t9_usa_pl_navyseal_slugger" + modelType);
                CheckModelName("c_t9_usa_pl_navyseal_sniper" + modelType);
                CheckModelName("c_t9_usa_pl_navyseal_solitude" + modelType);
                CheckModelName("c_t9_usa_pl_navyseal_strike" + modelType);
                CheckModelName("c_t9_usa_pl_navyseal_wolf" + modelType);
                CheckModelName("c_t9_usa_pl_rambo" + modelType);
                CheckModelName("c_t9_usa_pl_spy_female_investigator" + modelType);
                CheckModelName("c_t9_usa_pl_spy_investigator" + modelType);
                CheckModelName("c_t9_usa_pl_surge" + modelType);
                CheckModelName("c_t9_usa_pl_surge_meta" + modelType);
                CheckModelName("c_t9_usa_pl_vip" + modelType);
                CheckModelName("c_t9_usa_pl_vip2_axis_side" + modelType);
                CheckModelName("c_t9_usa_pl_weaver_aftermath" + modelType);
                CheckModelName("c_t9_usa_pl_weaver_cosmodrome" + modelType);
                CheckModelName("c_t9_usa_pl_weaver_rebirth" + modelType);
                CheckModelName("c_t9_usa_pl_weaver_sonsoforda" + modelType);
                CheckModelName("c_t9_usa_pl_woods_biker" + modelType);
                CheckModelName("c_t9_usa_pl_woods_conquer" + modelType);
                CheckModelName("c_t9_usa_pl_woods_dapper" + modelType);
                CheckModelName("c_t9_usa_pl_woods_dope" + modelType);
                CheckModelName("c_t9_usa_pl_woods_eagleclaw" + modelType);
                CheckModelName("c_t9_usa_pl_woods_eliminator" + modelType);
                CheckModelName("c_t9_usa_pl_woods_fisherman" + modelType);
                CheckModelName("c_t9_usa_pl_woods_haha" + modelType);
                CheckModelName("c_t9_usa_pl_woods_holidaywoods" + modelType);
                CheckModelName("c_t9_usa_pl_woods_infiltration" + modelType);
                CheckModelName("c_t9_usa_pl_woods_mellow" + modelType);
                CheckModelName("c_t9_usa_pl_woods_payback" + modelType);
                CheckModelName("c_t9_usa_pl_woods_pow" + modelType);
                CheckModelName("c_t9_usa_pl_woods_pow_body" + modelType);
                CheckModelName("c_t9_usa_pl_woods_rogue" + modelType);
                CheckModelName("c_t9_usa_pl_woods_sandstorm" + modelType);
                CheckModelName("c_t9_usa_pl_woods_slaughter" + modelType);
                CheckModelName("c_t9_usa_pl_woods_swamp" + modelType);
                CheckModelName("c_t9_usa_pl_woods_trucker" + modelType);
                CheckModelName("c_t9_usa_pl_woods_whirlwind" + modelType);
                // BO4 / CW Weapon Models & Blueprints
                // Rising Tide
                // wpn_t8_abr_223
                // wpn_t8_acheron_alliterator
                // wpn_t8_d3s0l8_regulator
                // wpn_t8_escargot
                // wpn_t8_essex_model_07
                // wpn_t8_hitchcock_m9
                // wpn_t8_king_and_country
                CheckModelName("wpn_t8_ar_accurate" + modelType);
                CheckModelName("wpn_t8_ar_fastfire" + modelType);
                CheckModelName("wpn_t8_ar_galil" + modelType);
                CheckModelName("wpn_t8_ar_heavy" + modelType);
                CheckModelName("wpn_t8_ar_k57" + modelType);
                CheckModelName("wpn_t8_ar_stealth" + modelType);
                CheckModelName("wpn_t8_crossbow_special" + modelType);
                CheckModelName("wpn_t8_knife_combat" + modelType);
                CheckModelName("wpn_t8_launcher_standard" + modelType);
                CheckModelName("wpn_t8_lmg_plr" + modelType);
                CheckModelName("wpn_t8_lmg_titan" + modelType);
                CheckModelName("wpn_t8_loot_ar_an94" + modelType);
                CheckModelName("wpn_t8_loot_ar_double_barrel" + modelType);
                CheckModelName("wpn_t8_loot_ar_peacekeeper" + modelType);
                CheckModelName("wpn_t8_loot_ar_standard" + modelType);
                CheckModelName("wpn_t8_loot_knife_ballistic" + modelType);
                CheckModelName("wpn_t8_loot_knife_ballistic_dw" + modelType);
                CheckModelName("wpn_t8_loot_knife_ballistic_karambit_dw" + modelType);
                CheckModelName("wpn_t8_loot_lmg_mk48" + modelType);
                CheckModelName("wpn_t8_loot_melee_action_figure" + modelType);
                CheckModelName("wpn_t8_loot_melee_amulet" + modelType);
                CheckModelName("wpn_t8_loot_melee_coinbag" + modelType);
                CheckModelName("wpn_t8_loot_melee_gift_axe" + modelType);
                CheckModelName("wpn_t8_loot_melee_hammer_demo" + modelType);
                CheckModelName("wpn_t8_loot_melee_polynesian_club" + modelType);
                CheckModelName("wpn_t8_loot_melee_slay_bell" + modelType);
                CheckModelName("wpn_t8_loot_melee_stop_sign" + modelType);
                CheckModelName("wpn_t8_loot_melee_zombie_arm" + modelType);
                CheckModelName("wpn_t8_loot_pistol_auto" + modelType);
                CheckModelName("wpn_t8_loot_shotgun_fullauto" + modelType);
                CheckModelName("wpn_t8_loot_shotgun_prec" + modelType);
                CheckModelName("wpn_t8_loot_smg_fastburst" + modelType);
                CheckModelName("wpn_t8_loot_smg_folding" + modelType);
                CheckModelName("wpn_t8_loot_smg_minigun" + modelType);
                CheckModelName("wpn_t8_loot_smg_vmp" + modelType);
                CheckModelName("wpn_t8_loot_sniper_locus" + modelType);
                CheckModelName("wpn_t8_loot_sniper_mini14" + modelType);
                CheckModelName("wpn_t8_loot_tac_rifle_damageburst" + modelType);
                CheckModelName("wpn_t8_loot_tac_rifle_flechette" + modelType);
                CheckModelName("wpn_t8_pistol_burst" + modelType);
                CheckModelName("wpn_t8_pistol_revolver" + modelType);
                CheckModelName("wpn_t8_pistol_standard" + modelType);
                CheckModelName("wpn_t8_shotgun_pump" + modelType);
                CheckModelName("wpn_t8_shotgun_semi" + modelType);
                CheckModelName("wpn_t8_smg_accurate" + modelType);
                CheckModelName("wpn_t8_smg_capacity" + modelType);
                CheckModelName("wpn_t8_smg_fastfire" + modelType);
                CheckModelName("wpn_t8_smg_handling" + modelType);
                CheckModelName("wpn_t8_smg_mp9" + modelType);
                CheckModelName("wpn_t8_sniper_koshka" + modelType);
                CheckModelName("wpn_t8_sniper_power_semi" + modelType);
                CheckModelName("wpn_t8_sniper_semiauto" + modelType);
                CheckModelName("wpn_t8_sniper_vanguard" + modelType);
                CheckModelName("wpn_t8_sumbarbrandr" + modelType);
                CheckModelName("wpn_t8_tac_rifle_surgeon" + modelType);
                CheckModelName("wpn_t8_tac_rifle_swordfish" + modelType);
                CheckModelName("wpn_t8_zm_akud" + modelType);
                CheckModelName("wpn_t8_zm_akud_scope" + modelType);
                CheckModelName("wpn_t8_zm_blundergat" + modelType);
                CheckModelName("wpn_t8_zm_blundergat_acid" + modelType);
                CheckModelName("wpn_t8_zm_blundergat_fire" + modelType);
                CheckModelName("wpn_t8_zm_crossbow_impaler" + modelType);
                CheckModelName("wpn_t8_zm_dg1" + modelType);
                CheckModelName("wpn_t8_zm_dg2" + modelType);
                CheckModelName("wpn_t8_zm_freeze_gun" + modelType);
                CheckModelName("wpn_t8_zm_goldenknife" + modelType);
                CheckModelName("wpn_t8_zm_hand_charon" + modelType);
                CheckModelName("wpn_t8_zm_hand_gaia" + modelType);
                CheckModelName("wpn_t8_zm_hand_hemera" + modelType);
                CheckModelName("wpn_t8_zm_hand_ouranos" + modelType);
                CheckModelName("wpn_t8_zm_homunculus" + modelType);
                CheckModelName("wpn_t8_zm_knife_bowie" + modelType);
                CheckModelName("wpn_t8_zm_knife_stake" + modelType);
                CheckModelName("wpn_t8_zm_lmg_mg08" + modelType);
                CheckModelName("wpn_t8_zm_mp40" + modelType);
                CheckModelName("wpn_t8_zm_nesting_dolls" + modelType);
                CheckModelName("wpn_t8_zm_raygun" + modelType);
                CheckModelName("wpn_t8_zm_raygun_mk2" + modelType);
                CheckModelName("wpn_t8_zm_raygun_upg" + modelType);
                CheckModelName("wpn_t8_zm_red_shield" + modelType);
                CheckModelName("wpn_t8_zm_red_spear" + modelType);
                CheckModelName("wpn_t8_zm_shotgun_trenchgun" + modelType);
                CheckModelName("wpn_t8_zm_smg_thompson" + modelType);
                CheckModelName("wpn_t8_zm_snowball" + modelType);
                CheckModelName("wpn_t8_zm_snowball_yellow" + modelType);
                CheckModelName("wpn_t8_zm_spknifeork" + modelType);
                CheckModelName("wpn_t8_zm_spoon" + modelType);
                CheckModelName("wpn_t8_zm_spork" + modelType);
                CheckModelName("wpn_t8_zm_thundergun" + modelType);
                CheckModelName("wpn_t8_zm_tomahawk" + modelType);
                CheckModelName("wpn_t8_zm_tundra_gun" + modelType);
                CheckModelName("wpn_t9_ar_damage" + modelType);
                CheckModelName("wpn_t9_ar_damage_8bit" + modelType);
                CheckModelName("wpn_t9_ar_damage_achill" + modelType);
                CheckModelName("wpn_t9_ar_damage_animedark" + modelType);
                CheckModelName("wpn_t9_ar_damage_arvnr1" + modelType);
                CheckModelName("wpn_t9_ar_damage_batts" + modelType);
                CheckModelName("wpn_t9_ar_damage_catbud" + modelType);
                CheckModelName("wpn_t9_ar_damage_champs_ms" + modelType);
                CheckModelName("wpn_t9_ar_damage_champs_pc" + modelType);
                CheckModelName("wpn_t9_ar_damage_champs_sy" + modelType);
                CheckModelName("wpn_t9_ar_damage_checkmate" + modelType);
                CheckModelName("wpn_t9_ar_damage_chrome" + modelType);
                CheckModelName("wpn_t9_ar_damage_cubarevo" + modelType);
                CheckModelName("wpn_t9_ar_damage_czar" + modelType);
                CheckModelName("wpn_t9_ar_damage_evil" + modelType);
                CheckModelName("wpn_t9_ar_damage_go_bananas" + modelType);
                CheckModelName("wpn_t9_ar_damage_grey_ranger" + modelType);
                CheckModelName("wpn_t9_ar_damage_halloween" + modelType);
                CheckModelName("wpn_t9_ar_damage_heartbreak" + modelType);
                CheckModelName("wpn_t9_ar_damage_modernp" + modelType);
                CheckModelName("wpn_t9_ar_damage_moonshine" + modelType);
                CheckModelName("wpn_t9_ar_damage_motocross" + modelType);
                CheckModelName("wpn_t9_ar_damage_nightf" + modelType);
                CheckModelName("wpn_t9_ar_damage_ole" + modelType);
                CheckModelName("wpn_t9_ar_damage_penumbra" + modelType);
                CheckModelName("wpn_t9_ar_damage_psa" + modelType);
                CheckModelName("wpn_t9_ar_damage_ram" + modelType);
                CheckModelName("wpn_t9_ar_damage_resist" + modelType);
                CheckModelName("wpn_t9_ar_damage_roadwar" + modelType);
                CheckModelName("wpn_t9_ar_damage_s05challenge_sy" + modelType);
                CheckModelName("wpn_t9_ar_damage_strace" + modelType);
                CheckModelName("wpn_t9_ar_damage_tchern" + modelType);
                CheckModelName("wpn_t9_ar_damage_ufo" + modelType);
                CheckModelName("wpn_t9_ar_damage_wargames" + modelType);
                CheckModelName("wpn_t9_ar_damage_yokai" + modelType);
                CheckModelName("wpn_t9_ar_damagenificent" + modelType);
                CheckModelName("wpn_t9_ar_fastfire" + modelType);
                CheckModelName("wpn_t9_ar_fastfire_animeskater" + modelType);
                CheckModelName("wpn_t9_ar_fastfire_arcade" + modelType);
                CheckModelName("wpn_t9_ar_fastfire_bowling" + modelType);
                CheckModelName("wpn_t9_ar_fastfire_bwarrior_ms" + modelType);
                CheckModelName("wpn_t9_ar_fastfire_bwarrior_pc" + modelType);
                CheckModelName("wpn_t9_ar_fastfire_bwarrior_sy" + modelType);
                CheckModelName("wpn_t9_ar_fastfire_dbreath" + modelType);
                CheckModelName("wpn_t9_ar_fastfire_dynasty" + modelType);
                CheckModelName("wpn_t9_ar_fastfire_egyptian" + modelType);
                CheckModelName("wpn_t9_ar_fastfire_guerilla" + modelType);
                CheckModelName("wpn_t9_ar_fastfire_hcover" + modelType);
                CheckModelName("wpn_t9_ar_fastfire_hollywood" + modelType);
                CheckModelName("wpn_t9_ar_fastfire_jet" + modelType);
                CheckModelName("wpn_t9_ar_fastfire_junglewarfare" + modelType);
                CheckModelName("wpn_t9_ar_fastfire_kwanzaa" + modelType);
                CheckModelName("wpn_t9_ar_fastfire_legion_sy" + modelType);
                CheckModelName("wpn_t9_ar_fastfire_leprecon" + modelType);
                CheckModelName("wpn_t9_ar_fastfire_lifesaver" + modelType);
                CheckModelName("wpn_t9_ar_fastfire_maneater" + modelType);
                CheckModelName("wpn_t9_ar_fastfire_medical" + modelType);
                CheckModelName("wpn_t9_ar_fastfire_ninja" + modelType);
                CheckModelName("wpn_t9_ar_fastfire_nugget" + modelType);
                CheckModelName("wpn_t9_ar_fastfire_opulence" + modelType);
                CheckModelName("wpn_t9_ar_fastfire_reactor" + modelType);
                CheckModelName("wpn_t9_ar_fastfire_renegade" + modelType);
                CheckModelName("wpn_t9_ar_fastfire_smoulder" + modelType);
                CheckModelName("wpn_t9_ar_fastfire_spacehead" + modelType);
                CheckModelName("wpn_t9_ar_fastfire_stamp" + modelType);
                CheckModelName("wpn_t9_ar_fastfire_ultrafunk" + modelType);
                CheckModelName("wpn_t9_ar_fastfire_wsow_ms" + modelType);
                CheckModelName("wpn_t9_ar_fastfire_wsow_pc" + modelType);
                CheckModelName("wpn_t9_ar_fastfire_wsow_solo" + modelType);
                CheckModelName("wpn_t9_ar_fastfire_wsow_sy" + modelType);
                CheckModelName("wpn_t9_ar_fastfire_zombied" + modelType);
                CheckModelName("wpn_t9_ar_krig6" + modelType);
                CheckModelName("wpn_t9_ar_krig6_ace" + modelType);
                CheckModelName("wpn_t9_ar_krig6_bee" + modelType);
                CheckModelName("wpn_t9_ar_krig6_blazer" + modelType);
                CheckModelName("wpn_t9_ar_krig6_boar_ms" + modelType);
                CheckModelName("wpn_t9_ar_krig6_boar_pc" + modelType);
                CheckModelName("wpn_t9_ar_krig6_boar_sy" + modelType);
                CheckModelName("wpn_t9_ar_krig6_burgertown" + modelType);
                CheckModelName("wpn_t9_ar_krig6_cdl_ms" + modelType);
                CheckModelName("wpn_t9_ar_krig6_cdl_pc" + modelType);
                CheckModelName("wpn_t9_ar_krig6_cdl_sy" + modelType);
                CheckModelName("wpn_t9_ar_krig6_coyote" + modelType);
                CheckModelName("wpn_t9_ar_krig6_darkaether" + modelType);
                CheckModelName("wpn_t9_ar_krig6_dragon" + modelType);
                CheckModelName("wpn_t9_ar_krig6_draid" + modelType);
                CheckModelName("wpn_t9_ar_krig6_especial" + modelType);
                CheckModelName("wpn_t9_ar_krig6_fchance" + modelType);
                CheckModelName("wpn_t9_ar_krig6_glitch" + modelType);
                CheckModelName("wpn_t9_ar_krig6_ilazar" + modelType);
                CheckModelName("wpn_t9_ar_krig6_leagueplay" + modelType);
                CheckModelName("wpn_t9_ar_krig6_lfg" + modelType);
                CheckModelName("wpn_t9_ar_krig6_midnight_express" + modelType);
                CheckModelName("wpn_t9_ar_krig6_rbaron" + modelType);
                CheckModelName("wpn_t9_ar_krig6_rdecree" + modelType);
                CheckModelName("wpn_t9_ar_krig6_rebel" + modelType);
                CheckModelName("wpn_t9_ar_krig6_rebirth" + modelType);
                CheckModelName("wpn_t9_ar_krig6_redbaron" + modelType);
                CheckModelName("wpn_t9_ar_krig6_royal" + modelType);
                CheckModelName("wpn_t9_ar_krig6_space" + modelType);
                CheckModelName("wpn_t9_ar_krig6_spirit" + modelType);
                CheckModelName("wpn_t9_ar_krig6_stitch" + modelType);
                CheckModelName("wpn_t9_ar_krig6_surge" + modelType);
                CheckModelName("wpn_t9_ar_krig6_tagger3" + modelType);
                CheckModelName("wpn_t9_ar_krig6_typhoon" + modelType);
                CheckModelName("wpn_t9_ar_krig6_undead" + modelType);
                CheckModelName("wpn_t9_ar_mercenary" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_animemon" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_arabian" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_armored" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_brutus" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_caiman" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_carolina" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_charden" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_codemam" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_codemam_ms" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_codemam_pc" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_codemam_sy" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_declar" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_devilwoman" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_firework" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_frogmen" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_gigaswatt" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_gladia" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_hologram" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_jester" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_junglec" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_knight" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_law" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_leagueplay" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_mrfix" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_mvs" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_oktober" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_poison" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_predator" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_resist" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_spacegun" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_titanium" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_voodoo" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_wasteland" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_wonder" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_wonder_catapillar" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_zenya" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_zslayer" + modelType);
                CheckModelName("wpn_t9_ar_mercenary_ztheme" + modelType);
                CheckModelName("wpn_t9_ar_mobility" + modelType);
                CheckModelName("wpn_t9_ar_mobility_aagirl" + modelType);
                CheckModelName("wpn_t9_ar_mobility_arcticwind" + modelType);
                CheckModelName("wpn_t9_ar_mobility_bloodhawk_sy" + modelType);
                CheckModelName("wpn_t9_ar_mobility_camera" + modelType);
                CheckModelName("wpn_t9_ar_mobility_colds" + modelType);
                CheckModelName("wpn_t9_ar_mobility_commando" + modelType);
                CheckModelName("wpn_t9_ar_mobility_ddaemon" + modelType);
                CheckModelName("wpn_t9_ar_mobility_dfoilage" + modelType);
                CheckModelName("wpn_t9_ar_mobility_electro" + modelType);
                CheckModelName("wpn_t9_ar_mobility_fastlane" + modelType);
                CheckModelName("wpn_t9_ar_mobility_fchina2" + modelType);
                CheckModelName("wpn_t9_ar_mobility_firestorm" + modelType);
                CheckModelName("wpn_t9_ar_mobility_flashf" + modelType);
                CheckModelName("wpn_t9_ar_mobility_frostbite" + modelType);
                CheckModelName("wpn_t9_ar_mobility_gaudy" + modelType);
                CheckModelName("wpn_t9_ar_mobility_importer" + modelType);
                CheckModelName("wpn_t9_ar_mobility_lochness" + modelType);
                CheckModelName("wpn_t9_ar_mobility_lucha" + modelType);
                CheckModelName("wpn_t9_ar_mobility_lunar" + modelType);
                CheckModelName("wpn_t9_ar_mobility_milboots" + modelType);
                CheckModelName("wpn_t9_ar_mobility_muerte" + modelType);
                CheckModelName("wpn_t9_ar_mobility_nature" + modelType);
                CheckModelName("wpn_t9_ar_mobility_peace" + modelType);
                CheckModelName("wpn_t9_ar_mobility_poseidon" + modelType);
                CheckModelName("wpn_t9_ar_mobility_shark" + modelType);
                CheckModelName("wpn_t9_ar_mobility_sneaker" + modelType);
                CheckModelName("wpn_t9_ar_mobility_soul" + modelType);
                CheckModelName("wpn_t9_ar_mobility_supers" + modelType);
                CheckModelName("wpn_t9_ar_mobility_tattoo" + modelType);
                CheckModelName("wpn_t9_ar_mobility_wanker" + modelType);
                CheckModelName("wpn_t9_boomstick_prop_weapon" + modelType);
                CheckModelName("wpn_t9_bp_ar_damage_bthroat" + modelType);
                CheckModelName("wpn_t9_bp_ar_damage_confront_ms" + modelType);
                CheckModelName("wpn_t9_bp_ar_damage_confront_pc" + modelType);
                CheckModelName("wpn_t9_bp_ar_damage_confront_sy" + modelType);
                CheckModelName("wpn_t9_bp_ar_damage_fires" + modelType);
                CheckModelName("wpn_t9_bp_ar_damage_nocturne" + modelType);
                CheckModelName("wpn_t9_bp_ar_damage_tagger" + modelType);
                CheckModelName("wpn_t9_bp_ar_damage_vcp" + modelType);
                CheckModelName("wpn_t9_bp_ar_fastfire_aconstrictor" + modelType);
                CheckModelName("wpn_t9_bp_ar_fastfire_carbongold_ms" + modelType);
                CheckModelName("wpn_t9_bp_ar_fastfire_carbongold_pc" + modelType);
                CheckModelName("wpn_t9_bp_ar_fastfire_carbongold_sy" + modelType);
                CheckModelName("wpn_t9_bp_ar_fastfire_mallrat" + modelType);
                CheckModelName("wpn_t9_bp_ar_fastfire_sterile" + modelType);
                CheckModelName("wpn_t9_bp_ar_fastfire_street" + modelType);
                CheckModelName("wpn_t9_bp_ar_krig6_ace" + modelType);
                CheckModelName("wpn_t9_bp_ar_krig6_confront" + modelType);
                CheckModelName("wpn_t9_bp_ar_krig6_eclipse" + modelType);
                CheckModelName("wpn_t9_bp_ar_krig6_geo_sy" + modelType);
                CheckModelName("wpn_t9_bp_ar_krig6_opulence" + modelType);
                CheckModelName("wpn_t9_bp_ar_krig6_reaper" + modelType);
                CheckModelName("wpn_t9_bp_ar_krig6_rebirth" + modelType);
                CheckModelName("wpn_t9_bp_ar_krig6_samurai" + modelType);
                CheckModelName("wpn_t9_bp_ar_mercenary_bluereaper" + modelType);
                CheckModelName("wpn_t9_bp_ar_mercenary_miami" + modelType);
                CheckModelName("wpn_t9_bp_ar_mercenary_rifleer" + modelType);
                CheckModelName("wpn_t9_bp_ar_mercenary_sea_ms" + modelType);
                CheckModelName("wpn_t9_bp_ar_mercenary_sea_pc" + modelType);
                CheckModelName("wpn_t9_bp_ar_mercenary_sea_sy" + modelType);
                CheckModelName("wpn_t9_bp_ar_mercenary_tagger" + modelType);
                CheckModelName("wpn_t9_bp_ar_mobility_spirit" + modelType);
                CheckModelName("wpn_t9_bp_lmg_accurate_cb_opulence" + modelType);
                CheckModelName("wpn_t9_bp_lmg_light" + modelType);
                CheckModelName("wpn_t9_bp_lmg_light_bcowboy" + modelType);
                CheckModelName("wpn_t9_bp_lmg_light_beachcomber" + modelType);
                CheckModelName("wpn_t9_bp_lmg_light_gambit" + modelType);
                CheckModelName("wpn_t9_bp_lmg_light_six" + modelType);
                CheckModelName("wpn_t9_bp_lmg_light_trawler" + modelType);
                CheckModelName("wpn_t9_bp_loot_ar_fasthandling_sterile" + modelType);
                CheckModelName("wpn_t9_bp_loot_ar_slowfire_muzzle_waterpark" + modelType);
                CheckModelName("wpn_t9_bp_loot_ar_slowfire_waterpark" + modelType);
                CheckModelName("wpn_t9_bp_loot_ar_slowhandling_420" + modelType);
                CheckModelName("wpn_t9_bp_loot_shotgun_fullauto_maelstrom" + modelType);
                CheckModelName("wpn_t9_bp_loot_shotgun_fullauto_red" + modelType);
                CheckModelName("wpn_t9_bp_loot_smg_accurate_jet" + modelType);
                CheckModelName("wpn_t9_bp_loot_smg_fastfire_gknight" + modelType);
                CheckModelName("wpn_t9_bp_loot_smg_spray_jetfighter" + modelType);
                CheckModelName("wpn_t9_bp_pistol_burst_avalanche" + modelType);
                CheckModelName("wpn_t9_bp_pistol_burst_cb_bullshark" + modelType);
                CheckModelName("wpn_t9_bp_pistol_burst_cb_dw_primal_sy" + modelType);
                CheckModelName("wpn_t9_bp_pistol_burst_cb_rbaron" + modelType);
                CheckModelName("wpn_t9_bp_pistol_burst_devil" + modelType);
                CheckModelName("wpn_t9_bp_pistol_burst_primal_sy" + modelType);
                CheckModelName("wpn_t9_bp_pistol_revolver_84" + modelType);
                CheckModelName("wpn_t9_bp_pistol_revolver_adder" + modelType);
                CheckModelName("wpn_t9_bp_pistol_revolver_noir" + modelType);
                CheckModelName("wpn_t9_bp_pistol_revolver_scorpion" + modelType);
                CheckModelName("wpn_t9_bp_pistol_revolver_six" + modelType);
                CheckModelName("wpn_t9_bp_pistol_semiauto_air_dw_ms" + modelType);
                CheckModelName("wpn_t9_bp_pistol_semiauto_air_dw_pc" + modelType);
                CheckModelName("wpn_t9_bp_pistol_semiauto_air_dw_sy" + modelType);
                CheckModelName("wpn_t9_bp_pistol_semiauto_air_ms" + modelType);
                CheckModelName("wpn_t9_bp_pistol_semiauto_air_pc" + modelType);
                CheckModelName("wpn_t9_bp_pistol_semiauto_air_sy" + modelType);
                CheckModelName("wpn_t9_bp_pistol_semiauto_arvnr1_sy" + modelType);
                CheckModelName("wpn_t9_bp_pistol_semiauto_code_dw_ms" + modelType);
                CheckModelName("wpn_t9_bp_pistol_semiauto_code_dw_pc" + modelType);
                CheckModelName("wpn_t9_bp_pistol_semiauto_code_dw_sy" + modelType);
                CheckModelName("wpn_t9_bp_pistol_semiauto_code_ms" + modelType);
                CheckModelName("wpn_t9_bp_pistol_semiauto_code_pc" + modelType);
                CheckModelName("wpn_t9_bp_pistol_semiauto_code_sy" + modelType);
                CheckModelName("wpn_t9_bp_pistol_semiauto_dw_fixit" + modelType);
                CheckModelName("wpn_t9_bp_pistol_semiauto_fixit" + modelType);
                CheckModelName("wpn_t9_bp_pistol_semiauto_midnight" + modelType);
                CheckModelName("wpn_t9_bp_pistol_semiauto_mvice" + modelType);
                CheckModelName("wpn_t9_bp_pistol_semiauto_rifleer" + modelType);
                CheckModelName("wpn_t9_bp_pistol_semiauto_teal" + modelType);
                CheckModelName("wpn_t9_bp_shotgun_pump_land_ms" + modelType);
                CheckModelName("wpn_t9_bp_shotgun_pump_land_pc" + modelType);
                CheckModelName("wpn_t9_bp_shotgun_pump_land_sy" + modelType);
                CheckModelName("wpn_t9_bp_shotgun_pump_nightfall" + modelType);
                CheckModelName("wpn_t9_bp_shotgun_pump_nt6_bus" + modelType);
                CheckModelName("wpn_t9_bp_shotgun_pump_ripper" + modelType);
                CheckModelName("wpn_t9_bp_shotgun_pump_schwagger" + modelType);
                CheckModelName("wpn_t9_bp_shotgun_semiauto_cb_gnr" + modelType);
                CheckModelName("wpn_t9_bp_shotgun_semiauto_cb_predator" + modelType);
                CheckModelName("wpn_t9_bp_shotgun_semiauto_cb_taffy" + modelType);
                CheckModelName("wpn_t9_bp_shotgun_semiauto_cb_valya" + modelType);
                CheckModelName("wpn_t9_bp_shotgun_semiauto_cb_zslayer" + modelType);
                CheckModelName("wpn_t9_bp_shotgun_semiauto_uglysweater" + modelType);
                CheckModelName("wpn_t9_bp_smg_burst_absinthe" + modelType);
                CheckModelName("wpn_t9_bp_smg_burst_flak" + modelType);
                CheckModelName("wpn_t9_bp_smg_burst_forged" + modelType);
                CheckModelName("wpn_t9_bp_smg_burst_kwanzaa" + modelType);
                CheckModelName("wpn_t9_bp_smg_burst_mechanic" + modelType);
                CheckModelName("wpn_t9_bp_smg_burst_red" + modelType);
                CheckModelName("wpn_t9_bp_smg_burst_runman" + modelType);
                CheckModelName("wpn_t9_bp_smg_capacity_alleywayamb" + modelType);
                CheckModelName("wpn_t9_bp_smg_capacity_bluereaper" + modelType);
                CheckModelName("wpn_t9_bp_smg_capacity_fulltank" + modelType);
                CheckModelName("wpn_t9_bp_smg_capacity_gcompany" + modelType);
                CheckModelName("wpn_t9_bp_smg_capacity_muzzle_bluereaper" + modelType);
                CheckModelName("wpn_t9_bp_smg_capacity_prpsunder" + modelType);
                CheckModelName("wpn_t9_bp_smg_capacity_rocketscience" + modelType);
                CheckModelName("wpn_t9_bp_smg_handling_avalanche" + modelType);
                CheckModelName("wpn_t9_bp_smg_handling_beta" + modelType);
                CheckModelName("wpn_t9_bp_smg_handling_density" + modelType);
                CheckModelName("wpn_t9_bp_smg_handling_schwagger" + modelType);
                CheckModelName("wpn_t9_bp_smg_heavy_brawler" + modelType);
                CheckModelName("wpn_t9_bp_smg_heavy_dinotoy" + modelType);
                CheckModelName("wpn_t9_bp_smg_heavy_polar" + modelType);
                CheckModelName("wpn_t9_bp_smg_heavy_smdest" + modelType);
                CheckModelName("wpn_t9_bp_smg_standard_cb_blkmamba" + modelType);
                CheckModelName("wpn_t9_bp_smg_standard_cb_bwidow" + modelType);
                CheckModelName("wpn_t9_bp_smg_standard_cb_crypto" + modelType);
                CheckModelName("wpn_t9_bp_smg_standard_cb_urbangold" + modelType);
                CheckModelName("wpn_t9_bp_smg_standard_roman" + modelType);
                CheckModelName("wpn_t9_bp_sniper_powersemi_frostbite" + modelType);
                CheckModelName("wpn_t9_bp_sniper_powersemi_frostbite_frontend" + modelType);
                CheckModelName("wpn_t9_bp_sniper_powersemi_scope_ads_frostbite" + modelType);
                CheckModelName("wpn_t9_bp_sniper_powersemi_scope_frostbite" + modelType);
                CheckModelName("wpn_t9_bp_sniper_quickscope_collectors" + modelType);
                CheckModelName("wpn_t9_bp_sniper_quickscope_collectors_scope" + modelType);
                CheckModelName("wpn_t9_bp_sniper_quickscope_scope_collectors_ads" + modelType);
                CheckModelName("wpn_t9_bp_sniper_standard_crypto" + modelType);
                CheckModelName("wpn_t9_bp_sniper_standard_crypto_scope" + modelType);
                CheckModelName("wpn_t9_bp_sniper_standard_crypto_scope_ads" + modelType);
                CheckModelName("wpn_t9_bp_sniper_standard_ghostwood" + modelType);
                CheckModelName("wpn_t9_bp_sniper_standard_ghostwood_scope" + modelType);
                CheckModelName("wpn_t9_bp_sniper_standard_ghostwood_scope_ads" + modelType);
                CheckModelName("wpn_t9_bp_sniper_standard_moa_sy" + modelType);
                CheckModelName("wpn_t9_bp_sniper_standard_scope_ads_moa_sy" + modelType);
                CheckModelName("wpn_t9_bp_sniper_standard_scope_ads_urbangold" + modelType);
                CheckModelName("wpn_t9_bp_sniper_standard_scope_crypto" + modelType);
                CheckModelName("wpn_t9_bp_sniper_standard_scope_ghostwood" + modelType);
                CheckModelName("wpn_t9_bp_sniper_standard_scope_moa_sy" + modelType);
                CheckModelName("wpn_t9_bp_sniper_standard_scope_teal" + modelType);
                CheckModelName("wpn_t9_bp_sniper_standard_scope_urbangold" + modelType);
                CheckModelName("wpn_t9_bp_sniper_standard_teal" + modelType);
                CheckModelName("wpn_t9_bp_sniper_standard_teal_scope" + modelType);
                CheckModelName("wpn_t9_bp_sniper_standard_teal_scope_ads" + modelType);
                CheckModelName("wpn_t9_bp_sniper_standard_urbangold" + modelType);
                CheckModelName("wpn_t9_bp_tr_damagesemi_adder" + modelType);
                CheckModelName("wpn_t9_bp_tr_damagesemi_armyrv" + modelType);
                CheckModelName("wpn_t9_bp_tr_damagesemi_bwidow" + modelType);
                CheckModelName("wpn_t9_bp_tr_damagesemi_crowstorm_sy" + modelType);
                CheckModelName("wpn_t9_bp_tr_damagesemi_fighter" + modelType);
                CheckModelName("wpn_t9_bp_tr_damagesemi_six" + modelType);
                CheckModelName("wpn_t9_bp_tr_damagesemi_soviet_ops" + modelType);
                CheckModelName("wpn_t9_bp_tr_longburst_code_ms" + modelType);
                CheckModelName("wpn_t9_bp_tr_longburst_code_pc" + modelType);
                CheckModelName("wpn_t9_bp_tr_longburst_code_sy" + modelType);
                CheckModelName("wpn_t9_bp_tr_longburst_confront_ms" + modelType);
                CheckModelName("wpn_t9_bp_tr_longburst_confront_pc" + modelType);
                CheckModelName("wpn_t9_bp_tr_longburst_confront_sy" + modelType);
                CheckModelName("wpn_t9_bp_tr_longburst_gaudy" + modelType);
                CheckModelName("wpn_t9_bp_tr_longburst_pink" + modelType);
                CheckModelName("wpn_t9_bp_tr_longburst_resp" + modelType);
                CheckModelName("wpn_t9_bp_tr_longburst_twotone" + modelType);
                CheckModelName("wpn_t9_bp_tr_longburst_verde" + modelType);
                CheckModelName("wpn_t9_bp_tr_powerburst_cb_cupid" + modelType);
                CheckModelName("wpn_t9_bp_tr_powerburst_cb_lurker" + modelType);
                CheckModelName("wpn_t9_bp_tr_powerburst_cb_midnight_xp" + modelType);
                CheckModelName("wpn_t9_bp_tr_powerburst_cb_racer02" + modelType);
                CheckModelName("wpn_t9_bp_tr_powerburst_cb_scope_ads_lurker" + modelType);
                CheckModelName("wpn_t9_bp_tr_powerburst_cb_scope_ads_midnight_xp" + modelType);
                CheckModelName("wpn_t9_bp_tr_powerburst_cb_scope_ads_target_practice" + modelType);
                CheckModelName("wpn_t9_bp_tr_powerburst_cb_scope_cupid" + modelType);
                CheckModelName("wpn_t9_bp_tr_powerburst_cb_scope_cupid_ads" + modelType);
                CheckModelName("wpn_t9_bp_tr_powerburst_cb_scope_fcarbon" + modelType);
                CheckModelName("wpn_t9_bp_tr_powerburst_cb_scope_fcarbon_ads" + modelType);
                CheckModelName("wpn_t9_bp_tr_powerburst_cb_scope_lunar" + modelType);
                CheckModelName("wpn_t9_bp_tr_powerburst_cb_scope_lunar_ads" + modelType);
                CheckModelName("wpn_t9_bp_tr_powerburst_cb_scope_lurker" + modelType);
                CheckModelName("wpn_t9_bp_tr_powerburst_cb_scope_midnight_xp" + modelType);
                CheckModelName("wpn_t9_bp_tr_powerburst_cb_scope_racer02" + modelType);
                CheckModelName("wpn_t9_bp_tr_powerburst_cb_scope_racer02_ads" + modelType);
                CheckModelName("wpn_t9_bp_tr_powerburst_cb_scope_target_practice" + modelType);
                CheckModelName("wpn_t9_bp_tr_powerburst_cb_target_practice" + modelType);
                CheckModelName("wpn_t9_bp_tr_precisionsemi_arrow" + modelType);
                CheckModelName("wpn_t9_cigar_prop" + modelType);
                CheckModelName("wpn_t9_eqp_ammo_pack" + modelType);
                CheckModelName("wpn_t9_eqp_ammo_pack_fx2" + modelType);
                CheckModelName("wpn_t9_eqp_ammo_pack_fx_ammo1" + modelType);
                CheckModelName("wpn_t9_eqp_ammo_pack_fx_base" + modelType);
                CheckModelName("wpn_t9_eqp_ammo_pack_fx_bigmag" + modelType);
                CheckModelName("wpn_t9_eqp_ammo_pack_fx_cover" + modelType);
                CheckModelName("wpn_t9_eqp_ammo_pack_prop" + modelType);
                CheckModelName("wpn_t9_eqp_ammo_pack_prop_cac" + modelType);
                CheckModelName("wpn_t9_eqp_armor_plate" + modelType);
                CheckModelName("wpn_t9_eqp_ascender" + modelType);
                CheckModelName("wpn_t9_eqp_claymore" + modelType);
                CheckModelName("wpn_t9_eqp_data_pad" + modelType);
                CheckModelName("wpn_t9_eqp_flashbang" + modelType);
                CheckModelName("wpn_t9_eqp_flashbang_projectile" + modelType);
                CheckModelName("wpn_t9_eqp_garrot_wire_prop_weapon" + modelType);
                CheckModelName("wpn_t9_eqp_gersh_device" + modelType);
                CheckModelName("wpn_t9_eqp_grenade_concussion" + modelType);
                CheckModelName("wpn_t9_eqp_grenade_concussion_projectile" + modelType);
                CheckModelName("wpn_t9_eqp_grenade_decoy_projectile" + modelType);
                CheckModelName("wpn_t9_eqp_grenade_frag" + modelType);
                CheckModelName("wpn_t9_eqp_grenade_frag_projectile" + modelType);
                CheckModelName("wpn_t9_eqp_grenade_frag_prop_weapon" + modelType);
                CheckModelName("wpn_t9_eqp_grenade_semtex" + modelType);
                CheckModelName("wpn_t9_eqp_grenade_semtex_projectile" + modelType);
                CheckModelName("wpn_t9_eqp_hatchet" + modelType);
                CheckModelName("wpn_t9_eqp_hatchet_projectile" + modelType);
                CheckModelName("wpn_t9_eqp_hatchet_prop_weapon" + modelType);
                CheckModelName("wpn_t9_eqp_jammer" + modelType);
                CheckModelName("wpn_t9_eqp_jammer_fx_base" + modelType);
                CheckModelName("wpn_t9_eqp_jammer_fx_left_panel" + modelType);
                CheckModelName("wpn_t9_eqp_jammer_fx_round_atenna" + modelType);
                CheckModelName("wpn_t9_eqp_jammer_fx_small_atenna" + modelType);
                CheckModelName("wpn_t9_eqp_jammer_fx_tiny_atenna" + modelType);
                CheckModelName("wpn_t9_eqp_land_mine" + modelType);
                CheckModelName("wpn_t9_eqp_listening_device" + modelType);
                CheckModelName("wpn_t9_eqp_listening_device_fx_dish" + modelType);
                CheckModelName("wpn_t9_eqp_listening_device_fx_leg" + modelType);
                CheckModelName("wpn_t9_eqp_listening_device_fx_mic" + modelType);
                CheckModelName("wpn_t9_eqp_listening_device_fx_radio" + modelType);
                CheckModelName("wpn_t9_eqp_map_streak" + modelType);
                CheckModelName("wpn_t9_eqp_medical_injection_sml" + modelType);
                CheckModelName("wpn_t9_eqp_mobile_cover" + modelType);
                CheckModelName("wpn_t9_eqp_molotov" + modelType);
                CheckModelName("wpn_t9_eqp_nightingale" + modelType);
                CheckModelName("wpn_t9_eqp_nightingale_projectile" + modelType);
                CheckModelName("wpn_t9_eqp_parachute" + modelType);
                CheckModelName("wpn_t9_eqp_rcxd_remote" + modelType);
                CheckModelName("wpn_t9_eqp_satchel_charge" + modelType);
                CheckModelName("wpn_t9_eqp_satchel_charge_clacker" + modelType);
                CheckModelName("wpn_t9_eqp_satchel_charge_projectile" + modelType);
                CheckModelName("wpn_t9_eqp_small_radio" + modelType);
                CheckModelName("wpn_t9_eqp_smoke_grenade" + modelType);
                CheckModelName("wpn_t9_eqp_smoke_grenade_projectile" + modelType);
                CheckModelName("wpn_t9_eqp_smoke_grenade_red" + modelType);
                CheckModelName("wpn_t9_eqp_smoke_grenade_yellow" + modelType);
                CheckModelName("wpn_t9_eqp_teargas_mine" + modelType);
                CheckModelName("wpn_t9_eqp_teargas_mine_fx_cap" + modelType);
                CheckModelName("wpn_t9_eqp_teargas_mine_fx_lever" + modelType);
                CheckModelName("wpn_t9_eqp_teargas_mine_fx_pin_1" + modelType);
                CheckModelName("wpn_t9_eqp_teargas_mine_fx_pin_2" + modelType);
                CheckModelName("wpn_t9_eqp_teargas_mine_fx_pin_3" + modelType);
                CheckModelName("wpn_t9_eqp_teargas_mine_sprung" + modelType);
                CheckModelName("wpn_t9_eqp_trophy_system" + modelType);
                CheckModelName("wpn_t9_eqp_trophy_system_fx_head_01" + modelType);
                CheckModelName("wpn_t9_eqp_trophy_system_fx_leg_01" + modelType);
                CheckModelName("wpn_t9_eqp_trophy_system_fx_main" + modelType);
                CheckModelName("wpn_t9_eqp_trophy_system_fx_plate" + modelType);
                CheckModelName("wpn_t9_eqp_trophy_system_knob_01" + modelType);
                CheckModelName("wpn_t9_eqp_ultimate_turret" + modelType);
                CheckModelName("wpn_t9_eqp_ultimate_turret_fx_ammo" + modelType);
                CheckModelName("wpn_t9_eqp_ultimate_turret_fx_barrel" + modelType);
                CheckModelName("wpn_t9_eqp_ultimate_turret_fx_camera" + modelType);
                CheckModelName("wpn_t9_eqp_ultimate_turret_fx_handle" + modelType);
                CheckModelName("wpn_t9_eqp_ultimate_turret_fx_legs" + modelType);
                CheckModelName("wpn_t9_eqp_ultimate_turret_fx_main" + modelType);
                CheckModelName("wpn_t9_eqp_ultimate_turret_pickup" + modelType);
                CheckModelName("wpn_t9_eqp_ultimate_turret_prop" + modelType);
                CheckModelName("wpn_t9_eqp_vip_harness" + modelType);
                CheckModelName("wpn_t9_eqp_zipline_trolley" + modelType);
                CheckModelName("wpn_t9_ges_bottle_vodka_accessory" + modelType);
                CheckModelName("wpn_t9_ges_bullet_127_108mm_cartridge" + modelType);
                CheckModelName("wpn_t9_ges_bunny_reaper_accessory" + modelType);
                CheckModelName("wpn_t9_ges_ferrofluid_accessory" + modelType);
                CheckModelName("wpn_t9_ges_fortunecookie_accessory" + modelType);
                CheckModelName("wpn_t9_ges_jack_o_lantern_accessory" + modelType);
                CheckModelName("wpn_t9_ges_microphone_accessory" + modelType);
                CheckModelName("wpn_t9_ges_scorpion_accessory" + modelType);
                CheckModelName("wpn_t9_ges_teabag_accessory" + modelType);
                CheckModelName("wpn_t9_ges_zombie_arm_accessory" + modelType);
                CheckModelName("wpn_t9_ges_zombie_head_accessory" + modelType);
                CheckModelName("wpn_t9_grenade_frag_prop" + modelType);
                CheckModelName("wpn_t9_grenade_launcher" + modelType);
                CheckModelName("wpn_t9_grenade_launcher_bomber" + modelType);
                CheckModelName("wpn_t9_grenade_launcher_oozeball" + modelType);
                CheckModelName("wpn_t9_grenade_launcher_projectile" + modelType);
                CheckModelName("wpn_t9_grenade_launcher_shadow" + modelType);
                CheckModelName("wpn_t9_knife_ballistic" + modelType);
                CheckModelName("wpn_t9_knife_ballistic_babayaga" + modelType);
                CheckModelName("wpn_t9_knife_ballistic_oktober" + modelType);
                CheckModelName("wpn_t9_knife_ballistic_projectile" + modelType);
                CheckModelName("wpn_t9_knife_ballistic_spycraft" + modelType);
                CheckModelName("wpn_t9_knife_bowie_predator_sy" + modelType);
                CheckModelName("wpn_t9_knife_combat_american" + modelType);
                CheckModelName("wpn_t9_knife_combat_american_cmoney" + modelType);
                CheckModelName("wpn_t9_knife_combat_american_lile" + modelType);
                CheckModelName("wpn_t9_knife_combat_american_prop" + modelType);
                CheckModelName("wpn_t9_knife_combat_babayaga_le" + modelType);
                CheckModelName("wpn_t9_knife_combat_bope" + modelType);
                CheckModelName("wpn_t9_knife_combat_le" + modelType);
                CheckModelName("wpn_t9_knife_combat_le_oktober" + modelType);
                CheckModelName("wpn_t9_knife_combat_russian_aagirl" + modelType);
                CheckModelName("wpn_t9_knife_combat_russian_go_bananas" + modelType);
                CheckModelName("wpn_t9_knife_combat_scream" + modelType);
                CheckModelName("wpn_t9_knife_combat_spycraft_le" + modelType);
                CheckModelName("wpn_t9_knife_combat_switchblade" + modelType);
                CheckModelName("wpn_t9_knife_combat_wooden" + modelType);
                CheckModelName("wpn_t9_knife_dagger_predator" + modelType);
                CheckModelName("wpn_t9_launcher_freefire" + modelType);
                CheckModelName("wpn_t9_launcher_freefire_projectile" + modelType);
                CheckModelName("wpn_t9_launcher_freefire_stow" + modelType);
                CheckModelName("wpn_t9_launcher_standard" + modelType);
                CheckModelName("wpn_t9_launcher_standard_ads" + modelType);
                CheckModelName("wpn_t9_launcher_standard_optic" + modelType);
                CheckModelName("wpn_t9_launcher_standard_projectile" + modelType);
                CheckModelName("wpn_t9_lmg_accurate" + modelType);
                CheckModelName("wpn_t9_lmg_accurate_cb_bayou" + modelType);
                CheckModelName("wpn_t9_lmg_accurate_cb_bite" + modelType);
                CheckModelName("wpn_t9_lmg_accurate_cb_bowling" + modelType);
                CheckModelName("wpn_t9_lmg_accurate_cb_bsilver" + modelType);
                CheckModelName("wpn_t9_lmg_accurate_cb_bstreet" + modelType);
                CheckModelName("wpn_t9_lmg_accurate_cb_carnival" + modelType);
                CheckModelName("wpn_t9_lmg_accurate_cb_crimson" + modelType);
                CheckModelName("wpn_t9_lmg_accurate_cb_endtimes" + modelType);
                CheckModelName("wpn_t9_lmg_accurate_cb_knight" + modelType);
                CheckModelName("wpn_t9_lmg_accurate_cb_mummy" + modelType);
                CheckModelName("wpn_t9_lmg_accurate_cb_mvs" + modelType);
                CheckModelName("wpn_t9_lmg_accurate_cb_nuclear" + modelType);
                CheckModelName("wpn_t9_lmg_accurate_cb_numbers" + modelType);
                CheckModelName("wpn_t9_lmg_accurate_cb_overkill" + modelType);
                CheckModelName("wpn_t9_lmg_accurate_cb_ratrod" + modelType);
                CheckModelName("wpn_t9_lmg_accurate_cb_scrap" + modelType);
                CheckModelName("wpn_t9_lmg_accurate_cb_sshovel" + modelType);
                CheckModelName("wpn_t9_lmg_accurate_cb_street" + modelType);
                CheckModelName("wpn_t9_lmg_accurate_cb_zweed" + modelType);
                CheckModelName("wpn_t9_lmg_light" + modelType);
                CheckModelName("wpn_t9_lmg_light_angel" + modelType);
                CheckModelName("wpn_t9_lmg_light_animetankg" + modelType);
                CheckModelName("wpn_t9_lmg_light_arcade" + modelType);
                CheckModelName("wpn_t9_lmg_light_armyrv" + modelType);
                CheckModelName("wpn_t9_lmg_light_beachcomber" + modelType);
                CheckModelName("wpn_t9_lmg_light_carbongold_ms" + modelType);
                CheckModelName("wpn_t9_lmg_light_carbongold_pc" + modelType);
                CheckModelName("wpn_t9_lmg_light_carbongold_sy" + modelType);
                CheckModelName("wpn_t9_lmg_light_cmachine" + modelType);
                CheckModelName("wpn_t9_lmg_light_dpharao_sy" + modelType);
                CheckModelName("wpn_t9_lmg_light_ferfluid" + modelType);
                CheckModelName("wpn_t9_lmg_light_gladia" + modelType);
                CheckModelName("wpn_t9_lmg_light_milhack" + modelType);
                CheckModelName("wpn_t9_lmg_light_orda" + modelType);
                CheckModelName("wpn_t9_lmg_light_rebirth" + modelType);
                CheckModelName("wpn_t9_lmg_light_tchern" + modelType);
                CheckModelName("wpn_t9_lmg_light_warship" + modelType);
                CheckModelName("wpn_t9_lmg_light_x2" + modelType);
                CheckModelName("wpn_t9_lmg_slowfire" + modelType);
                CheckModelName("wpn_t9_lmg_slowfire_armored" + modelType);
                CheckModelName("wpn_t9_lmg_slowfire_btank" + modelType);
                CheckModelName("wpn_t9_lmg_slowfire_chemburn_sy" + modelType);
                CheckModelName("wpn_t9_lmg_slowfire_chewing" + modelType);
                CheckModelName("wpn_t9_lmg_slowfire_cia" + modelType);
                CheckModelName("wpn_t9_lmg_slowfire_darkaether" + modelType);
                CheckModelName("wpn_t9_lmg_slowfire_krieger" + modelType);
                CheckModelName("wpn_t9_lmg_slowfire_leprecon" + modelType);
                CheckModelName("wpn_t9_lmg_slowfire_necroking" + modelType);
                CheckModelName("wpn_t9_lmg_slowfire_notcryo" + modelType);
                CheckModelName("wpn_t9_lmg_slowfire_pigs" + modelType);
                CheckModelName("wpn_t9_lmg_slowfire_ram" + modelType);
                CheckModelName("wpn_t9_lmg_slowfire_reactor" + modelType);
                CheckModelName("wpn_t9_lmg_slowfire_samurai" + modelType);
                CheckModelName("wpn_t9_loot_ar_british" + modelType);
                CheckModelName("wpn_t9_loot_ar_british_eclipse" + modelType);
                CheckModelName("wpn_t9_loot_ar_british_gilded" + modelType);
                CheckModelName("wpn_t9_loot_ar_british_gilded_muzzle" + modelType);
                CheckModelName("wpn_t9_loot_ar_british_lightw" + modelType);
                CheckModelName("wpn_t9_loot_ar_british_muzzle" + modelType);
                CheckModelName("wpn_t9_loot_ar_british_scope" + modelType);
                CheckModelName("wpn_t9_loot_ar_british_scope_ads" + modelType);
                CheckModelName("wpn_t9_loot_ar_british_scope_eclipse" + modelType);
                CheckModelName("wpn_t9_loot_ar_british_scope_eclipse_ads" + modelType);
                CheckModelName("wpn_t9_loot_ar_british_sultan" + modelType);
                CheckModelName("wpn_t9_loot_ar_fasthandling" + modelType);
                CheckModelName("wpn_t9_loot_ar_fasthandling_animeninja" + modelType);
                CheckModelName("wpn_t9_loot_ar_fasthandling_babayaga" + modelType);
                CheckModelName("wpn_t9_loot_ar_fasthandling_bbear" + modelType);
                CheckModelName("wpn_t9_loot_ar_fasthandling_charged_sy" + modelType);
                CheckModelName("wpn_t9_loot_ar_fasthandling_circuit" + modelType);
                CheckModelName("wpn_t9_loot_ar_fasthandling_classic" + modelType);
                CheckModelName("wpn_t9_loot_ar_fasthandling_firestorm" + modelType);
                CheckModelName("wpn_t9_loot_ar_fasthandling_joke" + modelType);
                CheckModelName("wpn_t9_loot_ar_fasthandling_leaf" + modelType);
                CheckModelName("wpn_t9_loot_ar_fasthandling_longshot" + modelType);
                CheckModelName("wpn_t9_loot_ar_fasthandling_lorider" + modelType);
                CheckModelName("wpn_t9_loot_ar_fasthandling_opulence" + modelType);
                CheckModelName("wpn_t9_loot_ar_fasthandling_silver_streak" + modelType);
                CheckModelName("wpn_t9_loot_ar_fasthandling_snavy" + modelType);
                CheckModelName("wpn_t9_loot_ar_fasthandling_sterile" + modelType);
                CheckModelName("wpn_t9_loot_ar_fasthandling_tagger_ms" + modelType);
                CheckModelName("wpn_t9_loot_ar_fasthandling_tagger_pc" + modelType);
                CheckModelName("wpn_t9_loot_ar_fasthandling_tagger_solo" + modelType);
                CheckModelName("wpn_t9_loot_ar_fasthandling_tagger_sy" + modelType);
                CheckModelName("wpn_t9_loot_ar_fasthandling_tiger" + modelType);
                CheckModelName("wpn_t9_loot_ar_fasthandling_triton" + modelType);
                CheckModelName("wpn_t9_loot_ar_fasthandling_wetops" + modelType);
                CheckModelName("wpn_t9_loot_ar_season6" + modelType);
                CheckModelName("wpn_t9_loot_ar_season6_artdeco" + modelType);
                CheckModelName("wpn_t9_loot_ar_season6_scream" + modelType);
                CheckModelName("wpn_t9_loot_ar_season6_unicorn" + modelType);
                CheckModelName("wpn_t9_loot_ar_season6_venom" + modelType);
                CheckModelName("wpn_t9_loot_ar_slowfire" + modelType);
                CheckModelName("wpn_t9_loot_ar_slowfire_assassin" + modelType);
                CheckModelName("wpn_t9_loot_ar_slowfire_donnie" + modelType);
                CheckModelName("wpn_t9_loot_ar_slowfire_judged" + modelType);
                CheckModelName("wpn_t9_loot_ar_slowfire_laser_mount" + modelType);
                CheckModelName("wpn_t9_loot_ar_slowfire_laser_mount_assassin" + modelType);
                CheckModelName("wpn_t9_loot_ar_slowfire_media" + modelType);
                CheckModelName("wpn_t9_loot_ar_slowfire_muzzle" + modelType);
                CheckModelName("wpn_t9_loot_ar_slowfire_muzzle_ww" + modelType);
                CheckModelName("wpn_t9_loot_ar_slowfire_rockcold" + modelType);
                CheckModelName("wpn_t9_loot_ar_slowfire_special" + modelType);
                CheckModelName("wpn_t9_loot_ar_slowfire_special_muzzle" + modelType);
                CheckModelName("wpn_t9_loot_ar_slowfire_ww" + modelType);
                CheckModelName("wpn_t9_loot_ar_slowfirewell_adapter" + modelType);
                CheckModelName("wpn_t9_loot_ar_slowhandling" + modelType);
                CheckModelName("wpn_t9_loot_ar_slowhandling_carbonchrome_ms" + modelType);
                CheckModelName("wpn_t9_loot_ar_slowhandling_carbonchrome_pc" + modelType);
                CheckModelName("wpn_t9_loot_ar_slowhandling_carbonchrome_sy" + modelType);
                CheckModelName("wpn_t9_loot_ar_slowhandling_dh" + modelType);
                CheckModelName("wpn_t9_loot_ar_slowhandling_endgame" + modelType);
                CheckModelName("wpn_t9_loot_ar_slowhandling_fishtank" + modelType);
                CheckModelName("wpn_t9_loot_ar_slowhandling_frost" + modelType);
                CheckModelName("wpn_t9_loot_ar_slowhandling_gmaxis" + modelType);
                CheckModelName("wpn_t9_loot_ar_slowhandling_kreiger" + modelType);
                CheckModelName("wpn_t9_loot_ar_slowhandling_lightup" + modelType);
                CheckModelName("wpn_t9_loot_ar_slowhandling_orda" + modelType);
                CheckModelName("wpn_t9_loot_ar_slowhandling_somberv" + modelType);
                CheckModelName("wpn_t9_loot_ar_slowhandling_wildchild" + modelType);
                CheckModelName("wpn_t9_loot_ar_slowhandling_xray" + modelType);
                CheckModelName("wpn_t9_loot_ar_soviet" + modelType);
                CheckModelName("wpn_t9_loot_ar_soviet_bw" + modelType);
                CheckModelName("wpn_t9_loot_ar_soviet_ferrofluid" + modelType);
                CheckModelName("wpn_t9_loot_lmg_fastfire" + modelType);
                CheckModelName("wpn_t9_loot_lmg_fastfire_electro" + modelType);
                CheckModelName("wpn_t9_loot_lmg_fastfire_highnoon" + modelType);
                CheckModelName("wpn_t9_loot_lmg_fastfire_highstakes" + modelType);
                CheckModelName("wpn_t9_loot_lmg_fastfire_jester" + modelType);
                CheckModelName("wpn_t9_loot_lmg_fastfire_lochness" + modelType);
                CheckModelName("wpn_t9_loot_lmg_fastfire_nightf" + modelType);
                CheckModelName("wpn_t9_loot_pistol_fullauto" + modelType);
                CheckModelName("wpn_t9_loot_pistol_fullauto_eburial" + modelType);
                CheckModelName("wpn_t9_loot_pistol_fullauto_eburial_le" + modelType);
                CheckModelName("wpn_t9_loot_pistol_fullauto_egyptian" + modelType);
                CheckModelName("wpn_t9_loot_pistol_fullauto_egyptian_le" + modelType);
                CheckModelName("wpn_t9_loot_pistol_fullauto_gilded" + modelType);
                CheckModelName("wpn_t9_loot_pistol_fullauto_gilded_le" + modelType);
                CheckModelName("wpn_t9_loot_pistol_fullauto_judged" + modelType);
                CheckModelName("wpn_t9_loot_pistol_fullauto_le" + modelType);
                CheckModelName("wpn_t9_loot_pistol_fullauto_le_judged" + modelType);
                CheckModelName("wpn_t9_loot_pistol_fullauto_le_poison" + modelType);
                CheckModelName("wpn_t9_loot_pistol_fullauto_phased" + modelType);
                CheckModelName("wpn_t9_loot_pistol_fullauto_phased_le" + modelType);
                CheckModelName("wpn_t9_loot_pistol_fullauto_poison" + modelType);
                CheckModelName("wpn_t9_loot_pistol_shotgun" + modelType);
                CheckModelName("wpn_t9_loot_pistol_shotgun_le" + modelType);
                CheckModelName("wpn_t9_loot_pistol_shotgun_throwback" + modelType);
                CheckModelName("wpn_t9_loot_pistol_shotgun_throwback_le" + modelType);
                CheckModelName("wpn_t9_loot_shotgun_fullauto" + modelType);
                CheckModelName("wpn_t9_loot_shotgun_fullauto_acid" + modelType);
                CheckModelName("wpn_t9_loot_shotgun_fullauto_base_muzzle" + modelType);
                CheckModelName("wpn_t9_loot_shotgun_fullauto_blue" + modelType);
                CheckModelName("wpn_t9_loot_shotgun_fullauto_bronze" + modelType);
                CheckModelName("wpn_t9_loot_shotgun_fullauto_carapace" + modelType);
                CheckModelName("wpn_t9_loot_shotgun_fullauto_carnival" + modelType);
                CheckModelName("wpn_t9_loot_shotgun_fullauto_commando" + modelType);
                CheckModelName("wpn_t9_loot_shotgun_fullauto_coyote" + modelType);
                CheckModelName("wpn_t9_loot_shotgun_fullauto_cyber" + modelType);
                CheckModelName("wpn_t9_loot_shotgun_fullauto_lightup" + modelType);
                CheckModelName("wpn_t9_loot_shotgun_fullauto_lion" + modelType);
                CheckModelName("wpn_t9_loot_shotgun_fullauto_mutant" + modelType);
                CheckModelName("wpn_t9_loot_shotgun_fullauto_numbers" + modelType);
                CheckModelName("wpn_t9_loot_shotgun_fullauto_summer" + modelType);
                CheckModelName("wpn_t9_loot_shotgun_fullauto_surge" + modelType);
                CheckModelName("wpn_t9_loot_shotgun_fullauto_wanker" + modelType);
                CheckModelName("wpn_t9_loot_shotgun_fullauto_wasteland" + modelType);
                CheckModelName("wpn_t9_loot_shotgun_leveraction" + modelType);
                CheckModelName("wpn_t9_loot_shotgun_leveraction_carnival" + modelType);
                CheckModelName("wpn_t9_loot_shotgun_leveraction_freya" + modelType);
                CheckModelName("wpn_t9_loot_shotgun_leveraction_ripper" + modelType);
                CheckModelName("wpn_t9_loot_shotgun_leveraction_shell" + modelType);
                CheckModelName("wpn_t9_loot_smg_accurate" + modelType);
                CheckModelName("wpn_t9_loot_smg_accurate_bod" + modelType);
                CheckModelName("wpn_t9_loot_smg_accurate_evil" + modelType);
                CheckModelName("wpn_t9_loot_smg_accurate_grunge" + modelType);
                CheckModelName("wpn_t9_loot_smg_accurate_gunking" + modelType);
                CheckModelName("wpn_t9_loot_smg_accurate_halloween" + modelType);
                CheckModelName("wpn_t9_loot_smg_accurate_joke4_ms" + modelType);
                CheckModelName("wpn_t9_loot_smg_accurate_joke4_pc" + modelType);
                CheckModelName("wpn_t9_loot_smg_accurate_joke4_solo" + modelType);
                CheckModelName("wpn_t9_loot_smg_accurate_joke4_sy" + modelType);
                CheckModelName("wpn_t9_loot_smg_accurate_maxpurp" + modelType);
                CheckModelName("wpn_t9_loot_smg_accurate_poison" + modelType);
                CheckModelName("wpn_t9_loot_smg_accurate_soccer" + modelType);
                CheckModelName("wpn_t9_loot_smg_accurate_sweet" + modelType);
                CheckModelName("wpn_t9_loot_smg_accurate_zombied" + modelType);
                CheckModelName("wpn_t9_loot_smg_cqb" + modelType);
                CheckModelName("wpn_t9_loot_smg_cqb_cyber" + modelType);
                CheckModelName("wpn_t9_loot_smg_cqb_donnie" + modelType);
                CheckModelName("wpn_t9_loot_smg_cqb_kgb" + modelType);
                CheckModelName("wpn_t9_loot_smg_cqb_mind" + modelType);
                CheckModelName("wpn_t9_loot_smg_fastfire" + modelType);
                CheckModelName("wpn_t9_loot_smg_fastfire_angel" + modelType);
                CheckModelName("wpn_t9_loot_smg_fastfire_base_muzzle" + modelType);
                CheckModelName("wpn_t9_loot_smg_fastfire_camera" + modelType);
                CheckModelName("wpn_t9_loot_smg_fastfire_cshinobi" + modelType);
                CheckModelName("wpn_t9_loot_smg_fastfire_faberge" + modelType);
                CheckModelName("wpn_t9_loot_smg_fastfire_fires" + modelType);
                CheckModelName("wpn_t9_loot_smg_fastfire_frost" + modelType);
                CheckModelName("wpn_t9_loot_smg_fastfire_intercell" + modelType);
                CheckModelName("wpn_t9_loot_smg_fastfire_jefes" + modelType);
                CheckModelName("wpn_t9_loot_smg_fastfire_judged" + modelType);
                CheckModelName("wpn_t9_loot_smg_fastfire_maverick" + modelType);
                CheckModelName("wpn_t9_loot_smg_fastfire_mummycat" + modelType);
                CheckModelName("wpn_t9_loot_smg_fastfire_overrun" + modelType);
                CheckModelName("wpn_t9_loot_smg_fastfire_scrap" + modelType);
                CheckModelName("wpn_t9_loot_smg_fastfire_stitch" + modelType);
                CheckModelName("wpn_t9_loot_smg_fastfire_sweet" + modelType);
                CheckModelName("wpn_t9_loot_smg_fastfire_toke" + modelType);
                CheckModelName("wpn_t9_loot_smg_fastfire_wsow_ms" + modelType);
                CheckModelName("wpn_t9_loot_smg_fastfire_wsow_pc" + modelType);
                CheckModelName("wpn_t9_loot_smg_fastfire_wsow_solo" + modelType);
                CheckModelName("wpn_t9_loot_smg_fastfire_wsow_sy" + modelType);
                CheckModelName("wpn_t9_loot_smg_fastfire_ztheme" + modelType);
                CheckModelName("wpn_t9_loot_smg_flechette" + modelType);
                CheckModelName("wpn_t9_loot_smg_flechette_endgame" + modelType);
                CheckModelName("wpn_t9_loot_smg_flechette_ilazar" + modelType);
                CheckModelName("wpn_t9_loot_smg_lapa" + modelType);
                CheckModelName("wpn_t9_loot_smg_lapa_horror" + modelType);
                CheckModelName("wpn_t9_loot_smg_lapa_ripper" + modelType);
                CheckModelName("wpn_t9_loot_smg_semiauto" + modelType);
                CheckModelName("wpn_t9_loot_smg_semiauto_counter" + modelType);
                CheckModelName("wpn_t9_loot_smg_semiauto_endgame" + modelType);
                CheckModelName("wpn_t9_loot_smg_semiauto_heatwave" + modelType);
                CheckModelName("wpn_t9_loot_smg_semiauto_mdriving" + modelType);
                CheckModelName("wpn_t9_loot_smg_semiauto_scream" + modelType);
                CheckModelName("wpn_t9_loot_smg_spray" + modelType);
                CheckModelName("wpn_t9_loot_smg_spray_betty_ms" + modelType);
                CheckModelName("wpn_t9_loot_smg_spray_betty_pc" + modelType);
                CheckModelName("wpn_t9_loot_smg_spray_betty_sy" + modelType);
                CheckModelName("wpn_t9_loot_smg_spray_ferfluid" + modelType);
                CheckModelName("wpn_t9_loot_smg_spray_ghostship" + modelType);
                CheckModelName("wpn_t9_loot_smg_spray_hypno" + modelType);
                CheckModelName("wpn_t9_loot_smg_spray_jester" + modelType);
                CheckModelName("wpn_t9_loot_smg_spray_milspec" + modelType);
                CheckModelName("wpn_t9_loot_smg_spray_space" + modelType);
                CheckModelName("wpn_t9_loot_smg_spray_tagger_ms" + modelType);
                CheckModelName("wpn_t9_loot_smg_spray_tagger_pc" + modelType);
                CheckModelName("wpn_t9_loot_smg_spray_tagger_solo" + modelType);
                CheckModelName("wpn_t9_loot_smg_spray_tagger_sy" + modelType);
                CheckModelName("wpn_t9_loot_smg_spray_tuningf" + modelType);
                CheckModelName("wpn_t9_loot_smg_spray_urban" + modelType);
                CheckModelName("wpn_t9_loot_sniper_accurate" + modelType);
                CheckModelName("wpn_t9_loot_sniper_accurate_animemon" + modelType);
                CheckModelName("wpn_t9_loot_sniper_accurate_cybersnake" + modelType);
                CheckModelName("wpn_t9_loot_sniper_accurate_deaths" + modelType);
                CheckModelName("wpn_t9_loot_sniper_accurate_donnie" + modelType);
                CheckModelName("wpn_t9_loot_sniper_accurate_egyptian" + modelType);
                CheckModelName("wpn_t9_loot_sniper_accurate_hollywood" + modelType);
                CheckModelName("wpn_t9_loot_sniper_accurate_roman" + modelType);
                CheckModelName("wpn_t9_loot_sniper_accurate_scope_cybersnake" + modelType);
                CheckModelName("wpn_t9_loot_sniper_accurate_scope_cybersnake_ads" + modelType);
                CheckModelName("wpn_t9_loot_sniper_accurate_unicorn" + modelType);
                CheckModelName("wpn_t9_loot_sniper_cannon" + modelType);
                CheckModelName("wpn_t9_loot_sniper_cannon_8bit" + modelType);
                CheckModelName("wpn_t9_loot_sniper_cannon_aces" + modelType);
                CheckModelName("wpn_t9_loot_sniper_cannon_bullet_casing" + modelType);
                CheckModelName("wpn_t9_loot_sniper_cannon_debonair" + modelType);
                CheckModelName("wpn_t9_loot_sniper_cannon_ghillie" + modelType);
                CheckModelName("wpn_t9_loot_sniper_cannon_rave" + modelType);
                CheckModelName("wpn_t9_loot_sniper_cannon_rebel" + modelType);
                CheckModelName("wpn_t9_loot_sniper_cannon_scope" + modelType);
                CheckModelName("wpn_t9_loot_sniper_cannon_scope_8bit" + modelType);
                CheckModelName("wpn_t9_loot_sniper_cannon_scope_aces" + modelType);
                CheckModelName("wpn_t9_loot_sniper_cannon_scope_ads" + modelType);
                CheckModelName("wpn_t9_loot_sniper_cannon_scope_ads_8bit" + modelType);
                CheckModelName("wpn_t9_loot_sniper_cannon_scope_ads_aces" + modelType);
                CheckModelName("wpn_t9_loot_sniper_cannon_scope_ads_debonair" + modelType);
                CheckModelName("wpn_t9_loot_sniper_cannon_scope_ads_ghillie" + modelType);
                CheckModelName("wpn_t9_loot_sniper_cannon_scope_ads_rave" + modelType);
                CheckModelName("wpn_t9_loot_sniper_cannon_scope_ads_rebel" + modelType);
                CheckModelName("wpn_t9_loot_sniper_cannon_scope_debonair" + modelType);
                CheckModelName("wpn_t9_loot_sniper_cannon_scope_ghillie" + modelType);
                CheckModelName("wpn_t9_loot_sniper_cannon_scope_rave" + modelType);
                CheckModelName("wpn_t9_loot_sniper_cannon_scope_rebel" + modelType);
                CheckModelName("wpn_t9_loot_sniper_cannon_scope_yokai" + modelType);
                CheckModelName("wpn_t9_loot_sniper_cannon_yokai" + modelType);
                CheckModelName("wpn_t9_loot_special_nailgun" + modelType);
                CheckModelName("wpn_t9_loot_special_nailgun_maxpurp" + modelType);
                CheckModelName("wpn_t9_loot_special_nailgun_naildome" + modelType);
                CheckModelName("wpn_t9_loot_special_nailgun_soulripper" + modelType);
                CheckModelName("wpn_t9_loot_tr_fastburst" + modelType);
                CheckModelName("wpn_t9_loot_tr_fastburst_chewing" + modelType);
                CheckModelName("wpn_t9_loot_tr_fastburst_controller" + modelType);
                CheckModelName("wpn_t9_loot_tr_fastburst_cuddly" + modelType);
                CheckModelName("wpn_t9_loot_tr_fastburst_halloween" + modelType);
                CheckModelName("wpn_t9_loot_tr_fastburst_mdriving" + modelType);
                CheckModelName("wpn_t9_loot_tr_fastburst_metamorph" + modelType);
                CheckModelName("wpn_t9_loot_tr_fastburst_toke" + modelType);
                CheckModelName("wpn_t9_loot_tr_fastburst_wilder" + modelType);
                CheckModelName("wpn_t9_loot_tr_fastburst_wood" + modelType);
                CheckModelName("wpn_t9_melee_axe" + modelType);
                CheckModelName("wpn_t9_melee_axe_berserker" + modelType);
                CheckModelName("wpn_t9_melee_axe_ripper" + modelType);
                CheckModelName("wpn_t9_melee_bat" + modelType);
                CheckModelName("wpn_t9_melee_bat_bayou" + modelType);
                CheckModelName("wpn_t9_melee_bat_heavyhit" + modelType);
                CheckModelName("wpn_t9_melee_bat_penumbra" + modelType);
                CheckModelName("wpn_t9_melee_cane" + modelType);
                CheckModelName("wpn_t9_melee_cane_class" + modelType);
                CheckModelName("wpn_t9_melee_cane_joke_ms" + modelType);
                CheckModelName("wpn_t9_melee_cane_joke_pc" + modelType);
                CheckModelName("wpn_t9_melee_cane_joke_solo" + modelType);
                CheckModelName("wpn_t9_melee_cane_joke_sy" + modelType);
                CheckModelName("wpn_t9_melee_crystalaxe" + modelType);
                CheckModelName("wpn_t9_melee_halligan_tool_prop_weapon" + modelType);
                CheckModelName("wpn_t9_melee_hammersickle_agony_hammer_le" + modelType);
                CheckModelName("wpn_t9_melee_hammersickle_agony_sickle" + modelType);
                CheckModelName("wpn_t9_melee_hammersickle_hammer_le" + modelType);
                CheckModelName("wpn_t9_melee_hammersickle_sickle" + modelType);
                CheckModelName("wpn_t9_melee_knuckle_knife_prop" + modelType);
                CheckModelName("wpn_t9_melee_kukri_dw_prop_weapon" + modelType);
                CheckModelName("wpn_t9_melee_kukri_prop_weapon" + modelType);
                CheckModelName("wpn_t9_melee_mace" + modelType);
                CheckModelName("wpn_t9_melee_mace_scepter" + modelType);
                CheckModelName("wpn_t9_melee_machete" + modelType);
                CheckModelName("wpn_t9_melee_machete_croc" + modelType);
                CheckModelName("wpn_t9_melee_machete_daether" + modelType);
                CheckModelName("wpn_t9_melee_machete_hollywood" + modelType);
                CheckModelName("wpn_t9_melee_sais" + modelType);
                CheckModelName("wpn_t9_melee_sais_le" + modelType);
                CheckModelName("wpn_t9_melee_sais_le_ninja" + modelType);
                CheckModelName("wpn_t9_melee_sais_le_rainbow_jewel" + modelType);
                CheckModelName("wpn_t9_melee_sais_ninja" + modelType);
                CheckModelName("wpn_t9_melee_sais_rainbow_jewel" + modelType);
                CheckModelName("wpn_t9_melee_scythe" + modelType);
                CheckModelName("wpn_t9_melee_scythe_rbunny" + modelType);
                CheckModelName("wpn_t9_melee_shovel" + modelType);
                CheckModelName("wpn_t9_melee_shovel_angel" + modelType);
                CheckModelName("wpn_t9_melee_shovel_assassin" + modelType);
                CheckModelName("wpn_t9_melee_shovel_jefe" + modelType);
                CheckModelName("wpn_t9_melee_shovel_warlord" + modelType);
                CheckModelName("wpn_t9_melee_sledgehammer" + modelType);
                CheckModelName("wpn_t9_melee_sledgehammer_assassin" + modelType);
                CheckModelName("wpn_t9_melee_sledgehammer_dozer" + modelType);
                CheckModelName("wpn_t9_melee_sledgehammer_predator_sy" + modelType);
                CheckModelName("wpn_t9_melee_sledgehammer_prop" + modelType);
                CheckModelName("wpn_t9_melee_sledgehammer_rranch" + modelType);
                CheckModelName("wpn_t9_melee_sledgehammer_zhunter" + modelType);
                CheckModelName("wpn_t9_melee_wakizashi_base" + modelType);
                CheckModelName("wpn_t9_melee_wakizashi_base_metamorph" + modelType);
                CheckModelName("wpn_t9_melee_wakizashi_base_rebel" + modelType);
                CheckModelName("wpn_t9_melee_wakizashi_gladiator" + modelType);
                CheckModelName("wpn_t9_melee_wakizashi_ornate" + modelType);
                CheckModelName("wpn_t9_melee_warmace_prop_weapon" + modelType);
                CheckModelName("wpn_t9_pistol_burst" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_animetankg" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_blade" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_decree" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_dw_avalanche" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_dw_blade" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_dw_bullshark" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_dw_decree" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_dw_devil" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_dw_especial" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_dw_faberge" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_dw_firestorm" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_dw_fumigator" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_dw_highfidelity" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_dw_leagueplay" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_dw_rbaron" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_dw_samurai" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_dw_sheriff" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_dw_souleat" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_dw_surge" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_dw_ubronze" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_dw_whunter" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_dw_yokai" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_especial" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_faberge" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_firestorm" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_fumigator" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_highfidelity" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_leagueplay" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_samurai" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_secondary" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_sheriff" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_souleat" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_surge" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_ubronze" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_ultrafunk" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_ultrafunk_dw" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_whunter" + modelType);
                CheckModelName("wpn_t9_pistol_burst_cb_yokai" + modelType);
                CheckModelName("wpn_t9_pistol_burst_dw" + modelType);
                CheckModelName("wpn_t9_pistol_burst_dw_prop" + modelType);
                CheckModelName("wpn_t9_pistol_revolver" + modelType);
                CheckModelName("wpn_t9_pistol_revolver_bbear" + modelType);
                CheckModelName("wpn_t9_pistol_revolver_bite" + modelType);
                CheckModelName("wpn_t9_pistol_revolver_bite_dw" + modelType);
                CheckModelName("wpn_t9_pistol_revolver_debonai" + modelType);
                CheckModelName("wpn_t9_pistol_revolver_dw" + modelType);
                CheckModelName("wpn_t9_pistol_revolver_dw_84" + modelType);
                CheckModelName("wpn_t9_pistol_revolver_dw_adder" + modelType);
                CheckModelName("wpn_t9_pistol_revolver_dw_bbear" + modelType);
                CheckModelName("wpn_t9_pistol_revolver_dw_bite" + modelType);
                CheckModelName("wpn_t9_pistol_revolver_dw_debonai" + modelType);
                CheckModelName("wpn_t9_pistol_revolver_dw_finec" + modelType);
                CheckModelName("wpn_t9_pistol_revolver_dw_modernp" + modelType);
                CheckModelName("wpn_t9_pistol_revolver_dw_murder" + modelType);
                CheckModelName("wpn_t9_pistol_revolver_dw_noir" + modelType);
                CheckModelName("wpn_t9_pistol_revolver_dw_pollock" + modelType);
                CheckModelName("wpn_t9_pistol_revolver_dw_prop" + modelType);
                CheckModelName("wpn_t9_pistol_revolver_dw_scorpion" + modelType);
                CheckModelName("wpn_t9_pistol_revolver_dw_six" + modelType);
                CheckModelName("wpn_t9_pistol_revolver_dw_srave" + modelType);
                CheckModelName("wpn_t9_pistol_revolver_dw_swashbuck" + modelType);
                CheckModelName("wpn_t9_pistol_revolver_dw_winters" + modelType);
                CheckModelName("wpn_t9_pistol_revolver_finec" + modelType);
                CheckModelName("wpn_t9_pistol_revolver_hvt" + modelType);
                CheckModelName("wpn_t9_pistol_revolver_hvt_dw" + modelType);
                CheckModelName("wpn_t9_pistol_revolver_modernp" + modelType);
                CheckModelName("wpn_t9_pistol_revolver_murder" + modelType);
                CheckModelName("wpn_t9_pistol_revolver_pollock" + modelType);
                CheckModelName("wpn_t9_pistol_revolver_srave" + modelType);
                CheckModelName("wpn_t9_pistol_revolver_swashbuck" + modelType);
                CheckModelName("wpn_t9_pistol_revolver_winters" + modelType);
                CheckModelName("wpn_t9_pistol_semiauto" + modelType);
                CheckModelName("wpn_t9_pistol_semiauto_8bit" + modelType);
                CheckModelName("wpn_t9_pistol_semiauto_classic" + modelType);
                CheckModelName("wpn_t9_pistol_semiauto_classic_dw" + modelType);
                CheckModelName("wpn_t9_pistol_semiauto_cp" + modelType);
                CheckModelName("wpn_t9_pistol_semiauto_cuddly" + modelType);
                CheckModelName("wpn_t9_pistol_semiauto_dw" + modelType);
                CheckModelName("wpn_t9_pistol_semiauto_dw_8bit" + modelType);
                CheckModelName("wpn_t9_pistol_semiauto_dw_cuddly" + modelType);
                CheckModelName("wpn_t9_pistol_semiauto_dw_endtimes" + modelType);
                CheckModelName("wpn_t9_pistol_semiauto_dw_fchina" + modelType);
                CheckModelName("wpn_t9_pistol_semiauto_dw_firework" + modelType);
                CheckModelName("wpn_t9_pistol_semiauto_dw_midnight" + modelType);
                CheckModelName("wpn_t9_pistol_semiauto_dw_muerte" + modelType);
                CheckModelName("wpn_t9_pistol_semiauto_dw_mvice" + modelType);
                CheckModelName("wpn_t9_pistol_semiauto_dw_pow" + modelType);
                CheckModelName("wpn_t9_pistol_semiauto_dw_presone" + modelType);
                CheckModelName("wpn_t9_pistol_semiauto_dw_prop" + modelType);
                CheckModelName("wpn_t9_pistol_semiauto_dw_rifleer" + modelType);
                CheckModelName("wpn_t9_pistol_semiauto_dw_sweet" + modelType);
                CheckModelName("wpn_t9_pistol_semiauto_dw_teal" + modelType);
                CheckModelName("wpn_t9_pistol_semiauto_dw_tunnel" + modelType);
                CheckModelName("wpn_t9_pistol_semiauto_endtimes" + modelType);
                CheckModelName("wpn_t9_pistol_semiauto_eqp_hatchet_prop_weapon" + modelType);
                CheckModelName("wpn_t9_pistol_semiauto_finechina" + modelType);
                CheckModelName("wpn_t9_pistol_semiauto_firework" + modelType);
                CheckModelName("wpn_t9_pistol_semiauto_muerte" + modelType);
                CheckModelName("wpn_t9_pistol_semiauto_pow" + modelType);
                CheckModelName("wpn_t9_pistol_semiauto_presone" + modelType);
                CheckModelName("wpn_t9_pistol_semiauto_prop" + modelType);
                CheckModelName("wpn_t9_pistol_semiauto_prop_animate" + modelType);
                CheckModelName("wpn_t9_pistol_semiauto_prop_weapon" + modelType);
                CheckModelName("wpn_t9_pistol_semiauto_sweet" + modelType);
                CheckModelName("wpn_t9_pistol_semiauto_tunnel" + modelType);
                CheckModelName("wpn_t9_red_card_prop" + modelType);
                CheckModelName("wpn_t9_shotgun_pump" + modelType);
                CheckModelName("wpn_t9_shotgun_pump_albino_serpent" + modelType);
                CheckModelName("wpn_t9_shotgun_pump_battery" + modelType);
                CheckModelName("wpn_t9_shotgun_pump_blazer" + modelType);
                CheckModelName("wpn_t9_shotgun_pump_collect" + modelType);
                CheckModelName("wpn_t9_shotgun_pump_dark" + modelType);
                CheckModelName("wpn_t9_shotgun_pump_dozer" + modelType);
                CheckModelName("wpn_t9_shotgun_pump_glitch" + modelType);
                CheckModelName("wpn_t9_shotgun_pump_great" + modelType);
                CheckModelName("wpn_t9_shotgun_pump_grunge" + modelType);
                CheckModelName("wpn_t9_shotgun_pump_gunzroses" + modelType);
                CheckModelName("wpn_t9_shotgun_pump_jefe" + modelType);
                CheckModelName("wpn_t9_shotgun_pump_lawman" + modelType);
                CheckModelName("wpn_t9_shotgun_pump_lfg" + modelType);
                CheckModelName("wpn_t9_shotgun_pump_motocross" + modelType);
                CheckModelName("wpn_t9_shotgun_pump_mvs" + modelType);
                CheckModelName("wpn_t9_shotgun_pump_nature" + modelType);
                CheckModelName("wpn_t9_shotgun_pump_nucleard" + modelType);
                CheckModelName("wpn_t9_shotgun_pump_tunnel" + modelType);
                CheckModelName("wpn_t9_shotgun_pump_wilder" + modelType);
                CheckModelName("wpn_t9_shotgun_semiauto" + modelType);
                CheckModelName("wpn_t9_shotgun_semiauto_cb_aether" + modelType);
                CheckModelName("wpn_t9_shotgun_semiauto_cb_animepilot" + modelType);
                CheckModelName("wpn_t9_shotgun_semiauto_cb_assassin" + modelType);
                CheckModelName("wpn_t9_shotgun_semiauto_cb_cosplay" + modelType);
                CheckModelName("wpn_t9_shotgun_semiauto_cb_darkaether" + modelType);
                CheckModelName("wpn_t9_shotgun_semiauto_cb_doomsday" + modelType);
                CheckModelName("wpn_t9_shotgun_semiauto_cb_elegant" + modelType);
                CheckModelName("wpn_t9_shotgun_semiauto_cb_gmaxis" + modelType);
                CheckModelName("wpn_t9_shotgun_semiauto_cb_hudson_ms" + modelType);
                CheckModelName("wpn_t9_shotgun_semiauto_cb_hudson_pc" + modelType);
                CheckModelName("wpn_t9_shotgun_semiauto_cb_hudson_sy" + modelType);
                CheckModelName("wpn_t9_shotgun_semiauto_cb_jokerh" + modelType);
                CheckModelName("wpn_t9_shotgun_semiauto_cb_miami" + modelType);
                CheckModelName("wpn_t9_shotgun_semiauto_cb_rainbow" + modelType);
                CheckModelName("wpn_t9_shotgun_semiauto_cb_resp" + modelType);
                CheckModelName("wpn_t9_shotgun_semiauto_cb_sunset" + modelType);
                CheckModelName("wpn_t9_shotgun_semiauto_cb_supers" + modelType);
                CheckModelName("wpn_t9_shotgun_semiauto_cb_tuningf" + modelType);
                CheckModelName("wpn_t9_shotgun_semiauto_cb_voodoo" + modelType);
                CheckModelName("wpn_t9_shotgun_semiauto_frogmen" + modelType);
                CheckModelName("wpn_t9_shotgun_semiauto_unfolded_stock" + modelType);
                CheckModelName("wpn_t9_sig_grapple_gun" + modelType);
                CheckModelName("wpn_t9_smg_burst" + modelType);
                CheckModelName("wpn_t9_smg_burst_absinthe_barrel_laser_mount" + modelType);
                CheckModelName("wpn_t9_smg_burst_assassin" + modelType);
                CheckModelName("wpn_t9_smg_burst_barrel_laser_mount" + modelType);
                CheckModelName("wpn_t9_smg_burst_barrel_laser_mount_assassin" + modelType);
                CheckModelName("wpn_t9_smg_burst_barrel_laser_mount_rainbow" + modelType);
                CheckModelName("wpn_t9_smg_burst_barrel_laser_mount_scarab" + modelType);
                CheckModelName("wpn_t9_smg_burst_barrel_laser_mount_wonder" + modelType);
                CheckModelName("wpn_t9_smg_burst_barrel_light_mount" + modelType);
                CheckModelName("wpn_t9_smg_burst_brutus" + modelType);
                CheckModelName("wpn_t9_smg_burst_bullshark" + modelType);
                CheckModelName("wpn_t9_smg_burst_dino" + modelType);
                CheckModelName("wpn_t9_smg_burst_fumigator" + modelType);
                CheckModelName("wpn_t9_smg_burst_improvt" + modelType);
                CheckModelName("wpn_t9_smg_burst_jade" + modelType);
                CheckModelName("wpn_t9_smg_burst_maneater" + modelType);
                CheckModelName("wpn_t9_smg_burst_metamorph" + modelType);
                CheckModelName("wpn_t9_smg_burst_milspec" + modelType);
                CheckModelName("wpn_t9_smg_burst_motocross" + modelType);
                CheckModelName("wpn_t9_smg_burst_nest" + modelType);
                CheckModelName("wpn_t9_smg_burst_nugget" + modelType);
                CheckModelName("wpn_t9_smg_burst_purpsun" + modelType);
                CheckModelName("wpn_t9_smg_burst_rainbow" + modelType);
                CheckModelName("wpn_t9_smg_burst_ruby" + modelType);
                CheckModelName("wpn_t9_smg_burst_scarab" + modelType);
                CheckModelName("wpn_t9_smg_burst_sneaker" + modelType);
                CheckModelName("wpn_t9_smg_burst_sultan" + modelType);
                CheckModelName("wpn_t9_smg_burst_sunkissed" + modelType);
                CheckModelName("wpn_t9_smg_burst_wonder" + modelType);
                CheckModelName("wpn_t9_smg_capacity" + modelType);
                CheckModelName("wpn_t9_smg_capacity_arctic" + modelType);
                CheckModelName("wpn_t9_smg_capacity_body_mount" + modelType);
                CheckModelName("wpn_t9_smg_capacity_body_mount_summer" + modelType);
                CheckModelName("wpn_t9_smg_capacity_body_mount_undead" + modelType);
                CheckModelName("wpn_t9_smg_capacity_body_ring_mount" + modelType);
                CheckModelName("wpn_t9_smg_capacity_body_ring_mount_rockcold" + modelType);
                CheckModelName("wpn_t9_smg_capacity_cocktail" + modelType);
                CheckModelName("wpn_t9_smg_capacity_dark" + modelType);
                CheckModelName("wpn_t9_smg_capacity_deaths" + modelType);
                CheckModelName("wpn_t9_smg_capacity_electric" + modelType);
                CheckModelName("wpn_t9_smg_capacity_electric_muzzle" + modelType);
                CheckModelName("wpn_t9_smg_capacity_fishtank" + modelType);
                CheckModelName("wpn_t9_smg_capacity_gigaswatt" + modelType);
                CheckModelName("wpn_t9_smg_capacity_goth" + modelType);
                CheckModelName("wpn_t9_smg_capacity_hanukkah" + modelType);
                CheckModelName("wpn_t9_smg_capacity_hipower" + modelType);
                CheckModelName("wpn_t9_smg_capacity_insect" + modelType);
                CheckModelName("wpn_t9_smg_capacity_jade" + modelType);
                CheckModelName("wpn_t9_smg_capacity_jwarrior" + modelType);
                CheckModelName("wpn_t9_smg_capacity_media" + modelType);
                CheckModelName("wpn_t9_smg_capacity_monte" + modelType);
                CheckModelName("wpn_t9_smg_capacity_muzzle" + modelType);
                CheckModelName("wpn_t9_smg_capacity_muzzle_dark" + modelType);
                CheckModelName("wpn_t9_smg_capacity_muzzle_jade" + modelType);
                CheckModelName("wpn_t9_smg_capacity_muzzle_monte" + modelType);
                CheckModelName("wpn_t9_smg_capacity_muzzle_nugget" + modelType);
                CheckModelName("wpn_t9_smg_capacity_muzzle_summer" + modelType);
                CheckModelName("wpn_t9_smg_capacity_nugget" + modelType);
                CheckModelName("wpn_t9_smg_capacity_pink" + modelType);
                CheckModelName("wpn_t9_smg_capacity_racer" + modelType);
                CheckModelName("wpn_t9_smg_capacity_rebel" + modelType);
                CheckModelName("wpn_t9_smg_capacity_rockcold" + modelType);
                CheckModelName("wpn_t9_smg_capacity_rranch" + modelType);
                CheckModelName("wpn_t9_smg_capacity_somberv" + modelType);
                CheckModelName("wpn_t9_smg_capacity_summer" + modelType);
                CheckModelName("wpn_t9_smg_capacity_undead" + modelType);
                CheckModelName("wpn_t9_smg_capacityer_sy" + modelType);
                CheckModelName("wpn_t9_smg_crystalaxe" + modelType);
                CheckModelName("wpn_t9_smg_handling" + modelType);
                CheckModelName("wpn_t9_smg_handling_achill" + modelType);
                CheckModelName("wpn_t9_smg_handling_angel_fish" + modelType);
                CheckModelName("wpn_t9_smg_handling_animeninja" + modelType);
                CheckModelName("wpn_t9_smg_handling_assassin" + modelType);
                CheckModelName("wpn_t9_smg_handling_bguard" + modelType);
                CheckModelName("wpn_t9_smg_handling_blow_runner" + modelType);
                CheckModelName("wpn_t9_smg_handling_cell" + modelType);
                CheckModelName("wpn_t9_smg_handling_cheese" + modelType);
                CheckModelName("wpn_t9_smg_handling_cmoney" + modelType);
                CheckModelName("wpn_t9_smg_handling_cubarevo" + modelType);
                CheckModelName("wpn_t9_smg_handling_deepblue" + modelType);
                CheckModelName("wpn_t9_smg_handling_electro" + modelType);
                CheckModelName("wpn_t9_smg_handling_flower" + modelType);
                CheckModelName("wpn_t9_smg_handling_gilded" + modelType);
                CheckModelName("wpn_t9_smg_handling_heartbreak" + modelType);
                CheckModelName("wpn_t9_smg_handling_high_end" + modelType);
                CheckModelName("wpn_t9_smg_handling_hudson_ms" + modelType);
                CheckModelName("wpn_t9_smg_handling_hudson_pc" + modelType);
                CheckModelName("wpn_t9_smg_handling_hudson_sy" + modelType);
                CheckModelName("wpn_t9_smg_handling_jewel" + modelType);
                CheckModelName("wpn_t9_smg_handling_jungle" + modelType);
                CheckModelName("wpn_t9_smg_handling_lucha" + modelType);
                CheckModelName("wpn_t9_smg_handling_lycan" + modelType);
                CheckModelName("wpn_t9_smg_handling_miami" + modelType);
                CheckModelName("wpn_t9_smg_handling_microfilm" + modelType);
                CheckModelName("wpn_t9_smg_handling_nights" + modelType);
                CheckModelName("wpn_t9_smg_handling_rebirth" + modelType);
                CheckModelName("wpn_t9_smg_handling_sim" + modelType);
                CheckModelName("wpn_t9_smg_handling_ssilver" + modelType);
                CheckModelName("wpn_t9_smg_handling_toohot" + modelType);
                CheckModelName("wpn_t9_smg_handling_wanker" + modelType);
                CheckModelName("wpn_t9_smg_heavy" + modelType);
                CheckModelName("wpn_t9_smg_heavy_aagirl" + modelType);
                CheckModelName("wpn_t9_smg_heavy_animetankg" + modelType);
                CheckModelName("wpn_t9_smg_heavy_apache" + modelType);
                CheckModelName("wpn_t9_smg_heavy_arabian" + modelType);
                CheckModelName("wpn_t9_smg_heavy_armadillo" + modelType);
                CheckModelName("wpn_t9_smg_heavy_batts" + modelType);
                CheckModelName("wpn_t9_smg_heavy_big_joke" + modelType);
                CheckModelName("wpn_t9_smg_heavy_blade" + modelType);
                CheckModelName("wpn_t9_smg_heavy_carbonchrome_ms" + modelType);
                CheckModelName("wpn_t9_smg_heavy_carbonchrome_pc" + modelType);
                CheckModelName("wpn_t9_smg_heavy_carbonchrome_sy" + modelType);
                CheckModelName("wpn_t9_smg_heavy_cdummy" + modelType);
                CheckModelName("wpn_t9_smg_heavy_checkmate" + modelType);
                CheckModelName("wpn_t9_smg_heavy_concrete" + modelType);
                CheckModelName("wpn_t9_smg_heavy_gasoline" + modelType);
                CheckModelName("wpn_t9_smg_heavy_leagueplay" + modelType);
                CheckModelName("wpn_t9_smg_heavy_oktober" + modelType);
                CheckModelName("wpn_t9_smg_heavy_orda" + modelType);
                CheckModelName("wpn_t9_smg_heavy_panda" + modelType);
                CheckModelName("wpn_t9_smg_heavy_penumbra" + modelType);
                CheckModelName("wpn_t9_smg_heavy_pow" + modelType);
                CheckModelName("wpn_t9_smg_heavy_ratrod" + modelType);
                CheckModelName("wpn_t9_smg_heavy_rbunny" + modelType);
                CheckModelName("wpn_t9_smg_heavy_rebel" + modelType);
                CheckModelName("wpn_t9_smg_heavy_rsurvival" + modelType);
                CheckModelName("wpn_t9_smg_heavy_soulripper" + modelType);
                CheckModelName("wpn_t9_smg_heavy_standoff" + modelType);
                CheckModelName("wpn_t9_smg_heavy_striked" + modelType);
                CheckModelName("wpn_t9_smg_heavy_swiss" + modelType);
                CheckModelName("wpn_t9_smg_heavy_tagger3" + modelType);
                CheckModelName("wpn_t9_smg_heavy_washed" + modelType);
                CheckModelName("wpn_t9_smg_heavy_zslayer" + modelType);
                CheckModelName("wpn_t9_smg_standard" + modelType);
                CheckModelName("wpn_t9_smg_standard_barrel_light_mount" + modelType);
                CheckModelName("wpn_t9_smg_standard_barrel_mount" + modelType);
                CheckModelName("wpn_t9_smg_standard_cb_apilot" + modelType);
                CheckModelName("wpn_t9_smg_standard_cb_bomber" + modelType);
                CheckModelName("wpn_t9_smg_standard_cb_carnival" + modelType);
                CheckModelName("wpn_t9_smg_standard_cb_chewing" + modelType);
                CheckModelName("wpn_t9_smg_standard_cb_cia" + modelType);
                CheckModelName("wpn_t9_smg_standard_cb_coyote" + modelType);
                CheckModelName("wpn_t9_smg_standard_cb_cryo" + modelType);
                CheckModelName("wpn_t9_smg_standard_cb_cuddly" + modelType);
                CheckModelName("wpn_t9_smg_standard_cb_ddaemon" + modelType);
                CheckModelName("wpn_t9_smg_standard_cb_debonair" + modelType);
                CheckModelName("wpn_t9_smg_standard_cb_dh" + modelType);
                CheckModelName("wpn_t9_smg_standard_cb_evintage" + modelType);
                CheckModelName("wpn_t9_smg_standard_cb_finec1" + modelType);
                CheckModelName("wpn_t9_smg_standard_cb_firework" + modelType);
                CheckModelName("wpn_t9_smg_standard_cb_gambit" + modelType);
                CheckModelName("wpn_t9_smg_standard_cb_infest" + modelType);
                CheckModelName("wpn_t9_smg_standard_cb_leaf" + modelType);
                CheckModelName("wpn_t9_smg_standard_cb_nature" + modelType);
                CheckModelName("wpn_t9_smg_standard_cb_numbers" + modelType);
                CheckModelName("wpn_t9_smg_standard_cb_operator" + modelType);
                CheckModelName("wpn_t9_smg_standard_cb_pollock" + modelType);
                CheckModelName("wpn_t9_smg_standard_cb_roadwar" + modelType);
                CheckModelName("wpn_t9_smg_standard_cb_roman" + modelType);
                CheckModelName("wpn_t9_smg_standard_cb_shadow" + modelType);
                CheckModelName("wpn_t9_smg_standard_cb_spacehead" + modelType);
                CheckModelName("wpn_t9_smg_standard_cb_strace" + modelType);
                CheckModelName("wpn_t9_smg_standard_cb_taffy" + modelType);
                CheckModelName("wpn_t9_smg_standard_cb_zenya" + modelType);
                CheckModelName("wpn_t9_smg_standard_cb_znaga" + modelType);
                CheckModelName("wpn_t9_smg_standard_chewing" + modelType);
                CheckModelName("wpn_t9_smg_standard_cuddly" + modelType);
                CheckModelName("wpn_t9_smg_standard_infest" + modelType);
                CheckModelName("wpn_t9_smg_standard_leaf" + modelType);
                CheckModelName("wpn_t9_sniper_accurate_scope" + modelType);
                CheckModelName("wpn_t9_sniper_accurate_scope_ads" + modelType);
                CheckModelName("wpn_t9_sniper_accurate_scope_ads_animemon" + modelType);
                CheckModelName("wpn_t9_sniper_accurate_scope_animemon" + modelType);
                CheckModelName("wpn_t9_sniper_accurate_scope_deaths" + modelType);
                CheckModelName("wpn_t9_sniper_accurate_scope_deaths_ads" + modelType);
                CheckModelName("wpn_t9_sniper_accurate_scope_donnie" + modelType);
                CheckModelName("wpn_t9_sniper_accurate_scope_donnie_ads" + modelType);
                CheckModelName("wpn_t9_sniper_accurate_scope_egyptian" + modelType);
                CheckModelName("wpn_t9_sniper_accurate_scope_egyptian_ads" + modelType);
                CheckModelName("wpn_t9_sniper_accurate_scope_unicorn" + modelType);
                CheckModelName("wpn_t9_sniper_accurate_scope_unicorn_ads" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_animelight" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_acid" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_acid_frontend" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_animelight" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_animelight_frontend" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_biggame" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_biggame_frontend" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_circuit" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_circuit_frontend" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_hologram" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_hologram_frontend" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_hypno" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_hypno_frontend" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_improvt" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_improvt_frontend" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_intercell" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_intercell_frontend" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_jungle" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_jungle_frontend" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_lancer" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_lancer_frontend" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_rain" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_ruby" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_ruby_frontend" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_scarab" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_scarab_frontend" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_scope_acid" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_scope_ads_acid" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_scope_ads_animelight" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_scope_ads_biggame" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_scope_ads_circuit" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_scope_ads_jungle" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_scope_ads_lancer" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_scope_ads_rain" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_scope_ads_ruby" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_scope_ads_scarab" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_scope_ads_stalker" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_scope_animelight" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_scope_biggame" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_scope_circuit" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_scope_improvt" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_scope_improvt_ads" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_scope_jungle" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_scope_lancer" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_scope_rain" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_scope_rain_frontend" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_scope_ruby" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_scope_scarab" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_scope_stalker" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_stalker" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cb_stalker_frontend" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cmoney" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_cmoney_frontend" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_frontend" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_hypno" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_scope" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_scope_ads" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_scope_ads_cmoney" + modelType);
                CheckModelName("wpn_t9_sniper_powersemi_scope_cmoney" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_animewidow" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_bullet" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_bwarrior_ms" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_bwarrior_pc" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_bwarrior_sy" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_cotton" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_coyote" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_darkg" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_darkg_scope" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_darkg_scope_ads" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_endgame" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_endgame_scope" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_endgame_scope_ads" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_eyerelief" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_gasoline" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_ghillie_sy" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_holiday" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_holiday_scope" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_holiday_scope_ads" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_manguish" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_mvs" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_opulence" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_pearl" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_psa" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_psa_scope" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_psa_scope_ads" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_rbunny" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_rbunny_scope" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_rbunny_scope_ads" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_redwave" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_scope" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_scope_ads" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_scope_ads_animewidow" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_scope_ads_cotton" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_scope_ads_coyote" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_scope_ads_ghillie_sy" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_scope_ads_manguish" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_scope_ads_opulence" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_scope_ads_pearl" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_scope_ads_somberv" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_scope_ads_wrap" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_scope_animewidow" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_scope_cotton" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_scope_coyote" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_scope_gasoline" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_scope_ghillie_sy" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_scope_manguish" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_scope_mvs" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_scope_opulence" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_scope_pearl" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_scope_skeleton" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_scope_skeleton_ads" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_scope_somberv" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_scope_wrap" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_skeleton" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_somberv" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_vietnam_bullet" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_wind" + modelType);
                CheckModelName("wpn_t9_sniper_quickscope_wrap" + modelType);
                CheckModelName("wpn_t9_sniper_standard" + modelType);
                CheckModelName("wpn_t9_sniper_standard_achill" + modelType);
                CheckModelName("wpn_t9_sniper_standard_animesg" + modelType);
                CheckModelName("wpn_t9_sniper_standard_apex" + modelType);
                CheckModelName("wpn_t9_sniper_standard_beachcomber" + modelType);
                CheckModelName("wpn_t9_sniper_standard_carbon_fiber" + modelType);
                CheckModelName("wpn_t9_sniper_standard_carbon_fiber_scope" + modelType);
                CheckModelName("wpn_t9_sniper_standard_carbon_fiber_scope_ads" + modelType);
                CheckModelName("wpn_t9_sniper_standard_dino" + modelType);
                CheckModelName("wpn_t9_sniper_standard_dino_scope" + modelType);
                CheckModelName("wpn_t9_sniper_standard_ghost" + modelType);
                CheckModelName("wpn_t9_sniper_standard_ghost_scope" + modelType);
                CheckModelName("wpn_t9_sniper_standard_ghost_scope_ads" + modelType);
                CheckModelName("wpn_t9_sniper_standard_milspec" + modelType);
                CheckModelName("wpn_t9_sniper_standard_nonuke" + modelType);
                CheckModelName("wpn_t9_sniper_standard_prof" + modelType);
                CheckModelName("wpn_t9_sniper_standard_qjackal" + modelType);
                CheckModelName("wpn_t9_sniper_standard_scope" + modelType);
                CheckModelName("wpn_t9_sniper_standard_scope_ads" + modelType);
                CheckModelName("wpn_t9_sniper_standard_scope_ads_animesg" + modelType);
                CheckModelName("wpn_t9_sniper_standard_scope_ads_prof" + modelType);
                CheckModelName("wpn_t9_sniper_standard_scope_ads_space" + modelType);
                CheckModelName("wpn_t9_sniper_standard_scope_animesg" + modelType);
                CheckModelName("wpn_t9_sniper_standard_scope_apex" + modelType);
                CheckModelName("wpn_t9_sniper_standard_scope_apex_ads" + modelType);
                CheckModelName("wpn_t9_sniper_standard_scope_prof" + modelType);
                CheckModelName("wpn_t9_sniper_standard_scope_space" + modelType);
                CheckModelName("wpn_t9_sniper_standard_scope_wandering" + modelType);
                CheckModelName("wpn_t9_sniper_standard_scope_wandering_ads" + modelType);
                CheckModelName("wpn_t9_sniper_standard_scopeer_ads_ms" + modelType);
                CheckModelName("wpn_t9_sniper_standard_scopeer_ads_pc" + modelType);
                CheckModelName("wpn_t9_sniper_standard_scopeer_ads_sy" + modelType);
                CheckModelName("wpn_t9_sniper_standard_scopeer_ms" + modelType);
                CheckModelName("wpn_t9_sniper_standard_scopeer_pc" + modelType);
                CheckModelName("wpn_t9_sniper_standard_scopeer_sy" + modelType);
                CheckModelName("wpn_t9_sniper_standard_sorrow" + modelType);
                CheckModelName("wpn_t9_sniper_standard_space" + modelType);
                CheckModelName("wpn_t9_sniper_standard_wandering" + modelType);
                CheckModelName("wpn_t9_sniper_standarder_ms" + modelType);
                CheckModelName("wpn_t9_sniper_standarder_pc" + modelType);
                CheckModelName("wpn_t9_sniper_standarder_sy" + modelType);
                CheckModelName("wpn_t9_sparkler_prop" + modelType);
                CheckModelName("wpn_t9_special_crossbow" + modelType);
                CheckModelName("wpn_t9_special_crossbow_diynot" + modelType);
                CheckModelName("wpn_t9_special_crossbow_goth" + modelType);
                CheckModelName("wpn_t9_special_crossbow_lancehead" + modelType);
                CheckModelName("wpn_t9_special_crossbow_lastzombie" + modelType);
                CheckModelName("wpn_t9_special_crossbow_projectile" + modelType);
                CheckModelName("wpn_t9_special_crossbow_ztheme" + modelType);
                CheckModelName("wpn_t9_special_nailgun_projectile" + modelType);
                CheckModelName("wpn_t9_sr_electric_avogadro_projectile" + modelType);
                CheckModelName("wpn_t9_streak_annihilator" + modelType);
                CheckModelName("wpn_t9_streak_bow" + modelType);
                CheckModelName("wpn_t9_streak_bow_arrow_03_projectile" + modelType);
                CheckModelName("wpn_t9_streak_bow_pickup" + modelType);
                CheckModelName("wpn_t9_streak_care_package" + modelType);
                CheckModelName("wpn_t9_streak_care_package_booby_trap" + modelType);
                CheckModelName("wpn_t9_streak_care_package_friendly" + modelType);
                CheckModelName("wpn_t9_streak_care_package_friendly_nosight" + modelType);
                CheckModelName("wpn_t9_streak_care_package_fx_corner" + modelType);
                CheckModelName("wpn_t9_streak_care_package_fx_ratchet" + modelType);
                CheckModelName("wpn_t9_streak_death_machine" + modelType);
                CheckModelName("wpn_t9_streak_flamethrower" + modelType);
                CheckModelName("wpn_t9_streak_missile_turret" + modelType);
                CheckModelName("wpn_t9_streak_missile_turret_fx_arm" + modelType);
                CheckModelName("wpn_t9_streak_missile_turret_fx_base" + modelType);
                CheckModelName("wpn_t9_streak_missile_turret_fx_leg" + modelType);
                CheckModelName("wpn_t9_streak_missile_turret_fx_senors" + modelType);
                CheckModelName("wpn_t9_streak_missile_turret_projectile" + modelType);
                CheckModelName("wpn_t9_streak_war_machine" + modelType);
                CheckModelName("wpn_t9_tr_damagesemi" + modelType);
                CheckModelName("wpn_t9_tr_damagesemi_apache" + modelType);
                CheckModelName("wpn_t9_tr_damagesemi_babayaga" + modelType);
                CheckModelName("wpn_t9_tr_damagesemi_batts" + modelType);
                CheckModelName("wpn_t9_tr_damagesemi_cdummy" + modelType);
                CheckModelName("wpn_t9_tr_damagesemi_checkp" + modelType);
                CheckModelName("wpn_t9_tr_damagesemi_codename" + modelType);
                CheckModelName("wpn_t9_tr_damagesemi_faberge" + modelType);
                CheckModelName("wpn_t9_tr_damagesemi_flashf" + modelType);
                CheckModelName("wpn_t9_tr_damagesemi_fuego" + modelType);
                CheckModelName("wpn_t9_tr_damagesemi_jfighter_sy" + modelType);
                CheckModelName("wpn_t9_tr_damagesemi_king_scorpion" + modelType);
                CheckModelName("wpn_t9_tr_damagesemi_onyx_sy" + modelType);
                CheckModelName("wpn_t9_tr_damagesemi_wildchild" + modelType);
                CheckModelName("wpn_t9_tr_longburst" + modelType);
                CheckModelName("wpn_t9_tr_longburst_aerobics" + modelType);
                CheckModelName("wpn_t9_tr_longburst_animepilot" + modelType);
                CheckModelName("wpn_t9_tr_longburst_arvnr1" + modelType);
                CheckModelName("wpn_t9_tr_longburst_arvnr2" + modelType);
                CheckModelName("wpn_t9_tr_longburst_boar_ms" + modelType);
                CheckModelName("wpn_t9_tr_longburst_boar_pc" + modelType);
                CheckModelName("wpn_t9_tr_longburst_boar_sy" + modelType);
                CheckModelName("wpn_t9_tr_longburst_bope" + modelType);
                CheckModelName("wpn_t9_tr_longburst_cyborg" + modelType);
                CheckModelName("wpn_t9_tr_longburst_devilwoman" + modelType);
                CheckModelName("wpn_t9_tr_longburst_dhawk" + modelType);
                CheckModelName("wpn_t9_tr_longburst_dozer" + modelType);
                CheckModelName("wpn_t9_tr_longburst_electric" + modelType);
                CheckModelName("wpn_t9_tr_longburst_fallenh" + modelType);
                CheckModelName("wpn_t9_tr_longburst_freya" + modelType);
                CheckModelName("wpn_t9_tr_longburst_gchoice" + modelType);
                CheckModelName("wpn_t9_tr_longburst_goth" + modelType);
                CheckModelName("wpn_t9_tr_longburst_highnoon" + modelType);
                CheckModelName("wpn_t9_tr_longburst_infest" + modelType);
                CheckModelName("wpn_t9_tr_longburst_joke4_ms" + modelType);
                CheckModelName("wpn_t9_tr_longburst_joke4_pc" + modelType);
                CheckModelName("wpn_t9_tr_longburst_joke4_solo" + modelType);
                CheckModelName("wpn_t9_tr_longburst_joke4_sy" + modelType);
                CheckModelName("wpn_t9_tr_longburst_jokerh" + modelType);
                CheckModelName("wpn_t9_tr_longburst_kjackal" + modelType);
                CheckModelName("wpn_t9_tr_longburst_lastzombie" + modelType);
                CheckModelName("wpn_t9_tr_longburst_mind" + modelType);
                CheckModelName("wpn_t9_tr_longburst_mvs" + modelType);
                CheckModelName("wpn_t9_tr_longburst_opulence" + modelType);
                CheckModelName("wpn_t9_tr_longburst_peace" + modelType);
                CheckModelName("wpn_t9_tr_longburst_resp" + modelType);
                CheckModelName("wpn_t9_tr_longburst_sforces_sy" + modelType);
                CheckModelName("wpn_t9_tr_longburst_smu" + modelType);
                CheckModelName("wpn_t9_tr_longburst_ufo" + modelType);
                CheckModelName("wpn_t9_tr_longburst_warlock" + modelType);
                CheckModelName("wpn_t9_tr_powerburst" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_animemeow" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_blade" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_bush" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_carapace" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_carolina" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_chems" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_dieh" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_draid" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_fcarbon" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_ghostship" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_jewel" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_lunar" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_maxpurp" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_monte" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_rthunder" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_scope_ads_animemeow" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_scope_ads_blade" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_scope_ads_bush" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_scope_ads_dieh" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_scope_ads_draid" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_scope_ads_ghostship" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_scope_animemeow" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_scope_blade" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_scope_bush" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_scope_dieh" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_scope_draid" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_scope_ghostship" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_scope_sweet" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_scope_sweet_ads" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_scope_urban" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_scope_urban_ads" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_srave_sy" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_standoff" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_sweet" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_tanner" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_cb_urban" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_scope" + modelType);
                CheckModelName("wpn_t9_tr_powerburst_scope_ads" + modelType);
                CheckModelName("wpn_t9_tr_precisionsemi" + modelType);
                CheckModelName("wpn_t9_tr_precisionsemi_egypt" + modelType);
                CheckModelName("wpn_t9_tr_precisionsemi_excellence" + modelType);
                CheckModelName("wpn_t9_tr_precisionsemi_ivory" + modelType);
                CheckModelName("wpn_t9_tr_precisionsemi_mutant" + modelType);
                CheckModelName("wpn_t9_tr_precisionsemi_ninja_v2" + modelType);
                CheckModelName("wpn_t9_tr_precisionsemi_punk" + modelType);
                CheckModelName("wpn_t9_tr_precisionsemi_reinforced" + modelType);
                CheckModelName("wpn_t9_tr_precisionsemi_speckled" + modelType);
                CheckModelName("wpn_t9_tr_precisionsemi_tiki" + modelType);
                CheckModelName("wpn_t9_tr_precisionsemi_v2_8bit" + modelType);
                CheckModelName("wpn_t9_tr_precisionsemi_v2_doomsday" + modelType);
                CheckModelName("wpn_t9_tr_precisionsemi_v2_draid" + modelType);
                CheckModelName("wpn_t9_tr_precisionsemi_v2_fieldm" + modelType);
                CheckModelName("wpn_t9_tr_precisionsemi_v2_lightm" + modelType);
                CheckModelName("wpn_t9_tr_precisionsemi_v2_wandering" + modelType);
                CheckModelName("wpn_t9_zm_knife_bowie" + modelType);
                CheckModelName("wpn_t9_zm_mega_barrel_blazer_beam" + modelType);
                CheckModelName("wpn_t9_zm_mega_barrel_micro" + modelType);
                CheckModelName("wpn_t9_zm_mega_barrel_pistol" + modelType);
                CheckModelName("wpn_t9_zm_mega_barrel_spreadshot" + modelType);
                CheckModelName("wpn_t9_zm_monkey_bomb" + modelType);
                CheckModelName("wpn_t9_zm_perk_can_deadshot" + modelType);
                CheckModelName("wpn_t9_zm_perk_can_death_perception" + modelType);
                CheckModelName("wpn_t9_zm_perk_can_elemental" + modelType);
                CheckModelName("wpn_t9_zm_perk_can_juggernog" + modelType);
                CheckModelName("wpn_t9_zm_perk_can_mule_kick" + modelType);
                CheckModelName("wpn_t9_zm_perk_can_phd_slider" + modelType);
                CheckModelName("wpn_t9_zm_perk_can_powerup" + modelType);
                CheckModelName("wpn_t9_zm_perk_can_quick_revive" + modelType);
                CheckModelName("wpn_t9_zm_perk_can_speed_cola" + modelType);
                CheckModelName("wpn_t9_zm_perk_can_stamina_up" + modelType);
                CheckModelName("wpn_t9_zm_perk_can_tombstone" + modelType);
                CheckModelName("wpn_t9_zm_ray_rifle" + modelType);
                CheckModelName("wpn_t9_zm_raygun" + modelType);
                CheckModelName("wpn_t9_zm_raygun_upg" + modelType);
                CheckModelName("wpn_t9_zm_silver_panic_knife" + modelType);
                CheckModelName("wpn_t9_zm_silver_ww" + modelType);
                CheckModelName("wpn_t9_zm_silver_ww_01" + modelType);
                CheckModelName("wpn_t9_zm_wand_aether_shround" + modelType);
                CheckModelName("wpn_t9_zm_wand_energy_mine" + modelType);
                CheckModelName("wpn_t9_zm_wand_frenzied_guard" + modelType);
                CheckModelName("wpn_t9_zm_wand_frost_blast" + modelType);
                CheckModelName("wpn_t9_zm_wand_healing_aura" + modelType);
                CheckModelName("wpn_t9_zm_wand_lightning_links" + modelType);
                CheckModelName("wpn_t9_zm_wand_ring_fire" + modelType);
                CheckModelName("wpn_t9_zm_wand_toxic_growth" + modelType);
                CheckModelName("wpn_t9_zm_wand_closed_aether_shround" + modelType);
                CheckModelName("wpn_t9_zm_wand_closed_energy_mine" + modelType);
                CheckModelName("wpn_t9_zm_wand_closed_frenzied_guard" + modelType);
                CheckModelName("wpn_t9_zm_wand_closed_frost_blast" + modelType);
                CheckModelName("wpn_t9_zm_wand_closed_healing_aura" + modelType);
                CheckModelName("wpn_t9_zm_wand_closed_lightning_links" + modelType);
                CheckModelName("wpn_t9_zm_wand_closed_ring_fire" + modelType);
                CheckModelName("wpn_t9_zm_wand_closed_toxic_growth" + modelType);
                CheckModelName("wrist_watch_t9_s1_analog_aviator_02" + modelType);
                CheckModelName("wrist_watch_t9_s1_analog_aviator_x2" + modelType);
                CheckModelName("wrist_watch_t9_s1_analog_bope_01" + modelType);
                CheckModelName("wrist_watch_t9_s1_analog_brawler_01" + modelType);
                CheckModelName("wrist_watch_t9_s1_analog_broken_fancy" + modelType);
                CheckModelName("wrist_watch_t9_s1_analog_fancy_debt_collector" + modelType);
                CheckModelName("wrist_watch_t9_s1_analog_fancy_gold" + modelType);
                CheckModelName("wrist_watch_t9_s1_analog_kremlin_01" + modelType);
                CheckModelName("wrist_watch_t9_s1_analog_origin_01" + modelType);
                CheckModelName("wrist_watch_t9_s1_analog_private_eye_01" + modelType);
                CheckModelName("wrist_watch_t9_s1_analog_private_eye_02" + modelType);
                CheckModelName("wrist_watch_t9_s1_analog_private_eye_03" + modelType);
                CheckModelName("wrist_watch_t9_s1_analog_retroren_02" + modelType);
                CheckModelName("wrist_watch_t9_s1_bracelet_01" + modelType);
                CheckModelName("wrist_watch_t9_s1_bracelet_braided_02" + modelType);
                CheckModelName("wrist_watch_t9_s1_bracelet_gold_chain_01" + modelType);
                CheckModelName("wrist_watch_t9_s1_bracelet_silver_chain_01" + modelType);
                CheckModelName("wrist_watch_t9_s1_bracelet_skull_01" + modelType);
                CheckModelName("wrist_watch_t9_s1_digital_compass" + modelType);
                CheckModelName("wrist_watch_t9_s1_digital_diver" + modelType);
                CheckModelName("wrist_watch_t9_s1_digital_first_spy" + modelType);
                CheckModelName("wrist_watch_t9_s1_digital_gambit_01" + modelType);
                CheckModelName("wrist_watch_t9_s1_digital_gaudy" + modelType);
                CheckModelName("wrist_watch_t9_s1_digital_inteculo_01" + modelType);
                CheckModelName("wrist_watch_t9_s1_digital_kazuya_01" + modelType);
                CheckModelName("wrist_watch_t9_s1_digital_rank_01" + modelType);
                CheckModelName("wrist_watch_t9_s1_digital_rank_penumbra_sy" + modelType);
                CheckModelName("wrist_watch_t9_s1_digital_zm_heart_rate_01" + modelType);
                CheckModelName("wrist_watch_t9_s1_digital_zm_heart_rate_black_02" + modelType);
                CheckModelName("wrist_watch_t9_s2_analog_420" + modelType);
                CheckModelName("wrist_watch_t9_s2_analog_black_silver" + modelType);
                CheckModelName("wrist_watch_t9_s2_analog_caiman" + modelType);
                CheckModelName("wrist_watch_t9_s2_analog_cold_hearted" + modelType);
                CheckModelName("wrist_watch_t9_s2_analog_dark_aether" + modelType);
                CheckModelName("wrist_watch_t9_s2_analog_jungle_aviator" + modelType);
                CheckModelName("wrist_watch_t9_s2_analog_mayan" + modelType);
                CheckModelName("wrist_watch_t9_s2_analog_mortal" + modelType);
                CheckModelName("wrist_watch_t9_s2_analog_naval_warfare" + modelType);
                CheckModelName("wrist_watch_t9_s2_analog_necro_king" + modelType);
                CheckModelName("wrist_watch_t9_s2_analog_paratroop" + modelType);
                CheckModelName("wrist_watch_t9_s2_analog_rebel" + modelType);
                CheckModelName("wrist_watch_t9_s2_bracelet_lure" + modelType);
                CheckModelName("wrist_watch_t9_s2_bracelet_mardi_gras" + modelType);
                CheckModelName("wrist_watch_t9_s2_digital_jade" + modelType);
                CheckModelName("wrist_watch_t9_s2_digital_mayan" + modelType);
                CheckModelName("wrist_watch_t9_s2_digital_mini_map" + modelType);
                CheckModelName("wrist_watch_t9_s2_digital_mini_map_hot_rod" + modelType);
                CheckModelName("wrist_watch_t9_s2_digital_river_slasher" + modelType);
                CheckModelName("wrist_watch_t9_s2_digital_sforce" + modelType);
                CheckModelName("wrist_watch_t9_s3_analog_chrono_sea" + modelType);
                CheckModelName("wrist_watch_t9_s3_analog_mctag" + modelType);
                CheckModelName("wrist_watch_t9_s3_analog_nuclear_fallout" + modelType);
                CheckModelName("wrist_watch_t9_s3_analog_rebel_fighter_sy" + modelType);
                CheckModelName("wrist_watch_t9_s3_analog_winter_ash" + modelType);
                CheckModelName("wrist_watch_t9_s3_analog_zombie_naga" + modelType);
                CheckModelName("wrist_watch_t9_s3_bracelet_01" + modelType);
                CheckModelName("wrist_watch_t9_s3_digital_big_joke" + modelType);
                CheckModelName("wrist_watch_t9_s3_digital_death_touch" + modelType);
                CheckModelName("wrist_watch_t9_s3_digital_heart_rate_alien" + modelType);
                CheckModelName("wrist_watch_t9_s3_digital_inteculo_spycraft" + modelType);
                CheckModelName("wrist_watch_t9_s3_digital_inteculo_w_fallout" + modelType);
                CheckModelName("wrist_watch_t9_s3_digital_nuclear_fallout" + modelType);
                CheckModelName("wrist_watch_t9_s3_digital_radiation" + modelType);
                CheckModelName("wrist_watch_t9_s3_digital_rank_winter_fallout" + modelType);
                CheckModelName("wrist_watch_t9_s3_digital_ultrafunk" + modelType);
                CheckModelName("wrist_watch_t9_s3_digitalic8" + modelType);
                CheckModelName("wrist_watch_t9_s4_analog_assassin" + modelType);
                CheckModelName("wrist_watch_t9_s4_analog_fire_storm" + modelType);
                CheckModelName("wrist_watch_t9_s4_analog_future_soldier" + modelType);
                CheckModelName("wrist_watch_t9_s4_analog_horror" + modelType);
                CheckModelName("wrist_watch_t9_s4_analog_jefe" + modelType);
                CheckModelName("wrist_watch_t9_s4_analog_rbear" + modelType);
                CheckModelName("wrist_watch_t9_s4_analog_roadwar" + modelType);
                CheckModelName("wrist_watch_t9_s4_analog_sleek_assassin" + modelType);
                CheckModelName("wrist_watch_t9_s4_analog_spaceship" + modelType);
                CheckModelName("wrist_watch_t9_s4_analog_wasteland" + modelType);
                CheckModelName("wrist_watch_t9_s4_bracelet_leather_studd" + modelType);
                CheckModelName("wrist_watch_t9_s4_bracelet_weathered" + modelType);
                CheckModelName("wrist_watch_t9_s4_digital_big_joke" + modelType);
                CheckModelName("wrist_watch_t9_s4_digital_blade" + modelType);
                CheckModelName("wrist_watch_t9_s4_digital_evil" + modelType);
                CheckModelName("wrist_watch_t9_s4_digital_holographic" + modelType);
                CheckModelName("wrist_watch_t9_s4_digital_holographic_rank" + modelType);
                CheckModelName("wrist_watch_t9_s4_digital_holographic_rank_cyber" + modelType);
                CheckModelName("wrist_watch_t9_s4_digital_roadwarrior" + modelType);
                CheckModelName("wrist_watch_t9_s4_digital_royal_decree" + modelType);
                CheckModelName("wrist_watch_t9_s5_analog_beer_o_clock" + modelType);
                CheckModelName("wrist_watch_t9_s5_analog_blood_fancy" + modelType);
                CheckModelName("wrist_watch_t9_s5_analog_classic" + modelType);
                CheckModelName("wrist_watch_t9_s5_analog_demon" + modelType);
                CheckModelName("wrist_watch_t9_s5_analog_dis_assassin" + modelType);
                CheckModelName("wrist_watch_t9_s5_analog_egy_burial" + modelType);
                CheckModelName("wrist_watch_t9_s5_analog_hacking_code" + modelType);
                CheckModelName("wrist_watch_t9_s5_analog_holographic" + modelType);
                CheckModelName("wrist_watch_t9_s5_analog_no_numbers" + modelType);
                CheckModelName("wrist_watch_t9_s5_analog_onyx_sy" + modelType);
                CheckModelName("wrist_watch_t9_s5_analog_retrotac" + modelType);
                CheckModelName("wrist_watch_t9_s5_digital_arabian" + modelType);
                CheckModelName("wrist_watch_t9_s5_digital_checkmate" + modelType);
                CheckModelName("wrist_watch_t9_s5_digital_critical_kill" + modelType);
                CheckModelName("wrist_watch_t9_s5_digital_dark_weaver" + modelType);
                CheckModelName("wrist_watch_t9_s5_digital_ghosted" + modelType);
                CheckModelName("wrist_watch_t9_s5_digital_judge_d" + modelType);
                CheckModelName("wrist_watch_t9_s5_digital_mummy_cat" + modelType);
                CheckModelName("wrist_watch_t9_s5_digital_rank_countdwn" + modelType);
                CheckModelName("wrist_watch_t9_s5_digital_tagger" + modelType);
                CheckModelName("wrist_watch_t9_s5_digital_wonderland" + modelType);
                CheckModelName("wrist_watch_t9_s6_analog_agony" + modelType);
                CheckModelName("wrist_watch_t9_s6_analog_big_joke4_ms" + modelType);
                CheckModelName("wrist_watch_t9_s6_analog_big_joke4_pc" + modelType);
                CheckModelName("wrist_watch_t9_s6_analog_big_joke4_solo" + modelType);
                CheckModelName("wrist_watch_t9_s6_analog_big_joke4_sy" + modelType);
                CheckModelName("wrist_watch_t9_s6_analog_bite_me" + modelType);
                CheckModelName("wrist_watch_t9_s6_analog_blue_chroma" + modelType);
                CheckModelName("wrist_watch_t9_s6_analog_bog_ops" + modelType);
                CheckModelName("wrist_watch_t9_s6_analog_camo" + modelType);
                CheckModelName("wrist_watch_t9_s6_analog_cyber_venom" + modelType);
                CheckModelName("wrist_watch_t9_s6_analog_gilded" + modelType);
                CheckModelName("wrist_watch_t9_s6_analog_halloween" + modelType);
                CheckModelName("wrist_watch_t9_s6_analog_hypnosis" + modelType);
                CheckModelName("wrist_watch_t9_s6_analog_krieger" + modelType);
                CheckModelName("wrist_watch_t9_s6_analog_scrapyard" + modelType);
                CheckModelName("wrist_watch_t9_s6_analog_scream" + modelType);
                CheckModelName("wrist_watch_t9_s6_analog_street_mech_sy" + modelType);
                CheckModelName("wrist_watch_t9_s6_digital_atomic_ash" + modelType);
                CheckModelName("wrist_watch_t9_s6_digital_egyptian_fire" + modelType);
                CheckModelName("wrist_watch_t9_s6_digital_endgame" + modelType);
                CheckModelName("wrist_watch_t9_s6_digital_frost" + modelType);
                CheckModelName("wrist_watch_t9_s6_digital_gov1" + modelType);
                CheckModelName("wrist_watch_t9_s6_digital_gov2" + modelType);
                CheckModelName("wrist_watch_t9_s6_digital_nightmare_fuel" + modelType);
                CheckModelName("wrist_watch_t9_s6_digital_rank_carnival" + modelType);
                CheckModelName("wrist_watch_t9_s6_digital_reaper_bunny" + modelType);
                CheckModelName("wrist_watch_t9_s6_digital_sultan" + modelType);
                CheckModelName("wrist_watch_t9_s6_digital_tagger_ms" + modelType);
                CheckModelName("wrist_watch_t9_s6_digital_tagger_pc" + modelType);
                CheckModelName("wrist_watch_t9_s6_digital_tagger_solo" + modelType);
                CheckModelName("wrist_watch_t9_s6_digital_tagger_sy" + modelType);
                CheckModelName("wrist_watch_t9_s6_digital_undead_warrior" + modelType);
                CheckModelName("wrist_watch_t9_s6_digital_undeadic" + modelType);
                CheckModelName("wrist_watch_t9_s6_digital_ww" + modelType);
                CheckModelName("wrist_watch_t9_s6_digital_zm_critical_kill" + modelType);
            }
            foreach (string voxType in VoxTypes)
            {
                foreach (string languageType in LanguageTypes)
                {
                    // BO4 / CW Weapon, Operator & Announcer Sounds
                    CheckSoundName("" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/ar_accurate/ar_accurate" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/ar_british/fly_ar_british" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/ar_damage/fly_ar_damage" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/ar_fastfire/fly_ar_fastfire" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/ar_fasthandling/fly_ar_fasthandling" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/ar_mobility/fly_ar_mobility" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/ar_season6/fly_ar_season6" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/ar_slowfire/fly_ar_slowfire" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/ar_slowhandling/fly_ar_slowhandling" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/ar_soviet/fly_ar_soviet" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/ar_standard/fly_ar_standard" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/grenade_launcher/fly_grenade_launcher" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/launcher_freefire/fly_launcher_freefire" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/launcher_standard/fly_launcher_standard" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/lmg_accurate/fly_lmg_accurate" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/lmg_fastfire/fly_lmg_fastfire" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/lmg_light/fly_lmg_light" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/lmg_slowfire/fly_lmg_slowfire" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/pistol_burst/fly_pistol_burst" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/pistol_fullauto/fly_pistol_fullauto" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/pistol_revolver/fly_pistol_revolver" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/pistol_semiauto/fly_pistol_semiauto" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/pistol_shotgun/fly_pistol_shotgun" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/shotgun_leveraction/fly_shotgun_leveraction" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/shotgun_pump/fly_shotgun_pump" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/shotgun_semi/fly_shotgun_semi" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/smg_accurate/fly_smg_accurate" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/smg_burst/fly_smg_burst" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/smg_capacity/fly_smg_capacity" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/smg_cqb/fly_smg_cqb" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/smg_fastfire/fly_smg_fastfire" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/smg_flechette/fly_smg_flechette" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/smg_handling/fly_smg_handling" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/smg_heavy/fly_smg_heavy" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/smg_season6/fly_smg_season6" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/smg_semiauto/fly_smg_semiauto" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/smg_spray/fly_smg_spray" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/smg_standard/fly_smg_standard" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/sniper_accurate/fly_sniper_accurate" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/sniper_cannon/fly_sniper_cannon" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/sniper_powersemi/fly_sniper_powersemi" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/sniper_standard/sniper_standard" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/special_nailgun/fly_nailgun" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/tr_damagesemi/fly_tr_damagesemi" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/tr_fastburst/fly_tr_fastburst" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/tr_longburst/fly_tr_longburst" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/tr_powerburst/fly_tr_powerburst" + voxType + languageType);
                    CheckSoundName("fly/weapon/reload/tr_precision/fly_tr_precision" + voxType + languageType);
                    CheckSoundName("vox/scripted/mpl/abnd/vox_abnd" + voxType + languageType);
                    CheckSoundName("vox/scripted/mpl/adgi/vox_adgi" + voxType + languageType);
                    CheckSoundName("vox/scripted/mpl/ahva/vox_ahva" + voxType + languageType);
                    CheckSoundName("vox/scripted/mpl/ami6/vox_ami6" + voxType + languageType);
                    CheckSoundName("vox/scripted/mpl/anbo/vox_anbo" + voxType + languageType);
                    CheckSoundName("vox/scripted/mpl/anme/vox_anme" + voxType + languageType);
                    CheckSoundName("vox/scripted/adlr/vox_adlr" + voxType + languageType);
                    CheckSoundName("vox/scripted/antv/vox_antv" + voxType + languageType);
                    CheckSoundName("vox/scripted/bakr/vox_bakr" + voxType + languageType);
                    CheckSoundName("vox/scripted/bdzr/vox_bdzr" + voxType + languageType);
                    CheckSoundName("vox/scripted/beck/vox_beck" + voxType + languageType);
                    CheckSoundName("vox/scripted/frs1/vox_frs1" + voxType + languageType);
                    CheckSoundName("vox/scripted/frs2/vox_frs2" + voxType + languageType);
                    CheckSoundName("vox/scripted/fuze/vox_fuze" + voxType + languageType);
                    CheckSoundName("vox/scripted/grca/vox_grca" + voxType + languageType);
                    CheckSoundName("vox/scripted/gstf/vox_gstf" + voxType + languageType);
                    CheckSoundName("vox/scripted/hdsn/vox_hdsn" + voxType + languageType);
                    CheckSoundName("vox/scripted/jckl/vox_jckl" + voxType + languageType);
                    CheckSoundName("vox/scripted/kngs/vox_kngs" + voxType + languageType);
                    CheckSoundName("vox/scripted/kngt/vox_kngt" + voxType + languageType);
                    CheckSoundName("vox/scripted/ktsn/vox_ktsn" + voxType + languageType);
                    CheckSoundName("vox/scripted/lazr/vox_lazr" + voxType + languageType);
                    CheckSoundName("vox/scripted/masn/vox_masn" + voxType + languageType);
                    CheckSoundName("vox/scripted/maxi/vox_maxi" + voxType + languageType);
                    CheckSoundName("vox/scripted/mcln/vox_mcln" + voxType + languageType);
                    CheckSoundName("vox/scripted/mrs1/vox_mrs1" + voxType + languageType);
                    CheckSoundName("vox/scripted/mrs2/vox_mrs2" + voxType + languageType);
                    CheckSoundName("vox/scripted/mrs3/vox_mrs3" + voxType + languageType);
                    CheckSoundName("vox/scripted/naga/vox_naga" + voxType + languageType);
                    CheckSoundName("vox/scripted/park/vox_park" + voxType + languageType);
                    CheckSoundName("vox/scripted/prce/vox_prce" + voxType + languageType);
                    CheckSoundName("vox/scripted/ptnv/vox_ptnv" + voxType + languageType);
                    CheckSoundName("vox/scripted/rmbo/vox_rmbo" + voxType + languageType);
                    CheckSoundName("vox/scripted/rvas/vox_rvas" + voxType + languageType);
                    CheckSoundName("vox/scripted/rvnv/vox_rvnv" + voxType + languageType);
                    CheckSoundName("vox/scripted/sala/vox_sala" + voxType + languageType);
                    CheckSoundName("vox/scripted/sims/vox_sims" + voxType + languageType);
                    CheckSoundName("vox/scripted/stch/vox_stch" + voxType + languageType);
                    CheckSoundName("vox/scripted/stry/vox_stry" + voxType + languageType);
                    CheckSoundName("vox/scripted/weav/vox_weav" + voxType + languageType);
                    CheckSoundName("vox/scripted/wolf/vox_wolf" + voxType + languageType);
                    CheckSoundName("vox/scripted/wood/vox_wood" + voxType + languageType);
                    CheckSoundName("vox/scripted/wrth/vox_wrth" + voxType + languageType);
                    CheckSoundName("vox/scripted/zyna/vox_zyna" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/adlr/vox_adlr" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/antv/vox_antv" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/bakr/vox_bakr" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/bdzr/vox_bdzr" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/beck/vox_beck" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/frs1/vox_frs1" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/frs2/vox_frs2" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/fuze/vox_fuze" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/grca/vox_grca" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/gstf/vox_gstf" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/hdsn/vox_hdsn" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/jckl/vox_jckl" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/kngs/vox_kngs" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/kngt/vox_kngt" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/ktsn/vox_ktsn" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/lazr/vox_lazr" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/masn/vox_masn" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/maxi/vox_maxi" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/mcln/vox_mcln" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/mrs1/vox_mrs1" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/mrs2/vox_mrs2" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/mrs3/vox_mrs3" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/naga/vox_naga" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/park/vox_park" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/prce/vox_prce" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/ptnv/vox_ptnv" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/rmbo/vox_rmbo" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/rvas/vox_rvas" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/rvnv/vox_rvnv" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/sala/vox_sala" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/sims/vox_sims" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/stch/vox_stch" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/stry/vox_stry" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/weav/vox_weav" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/wolf/vox_wolf" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/wood/vox_wood" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/wrth/vox_wrth" + voxType + languageType);
                    CheckSoundName("vox/scripted/operators/zyna/vox_zyna" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/adlr/vox_adlr" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/antv/vox_antv" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/bakr/vox_bakr" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/bdzr/vox_bdzr" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/beck/vox_beck" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/frs1/vox_frs1" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/frs2/vox_frs2" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/fuze/vox_fuze" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/grca/vox_grca" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/gstf/vox_gstf" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/hdsn/vox_hdsn" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/jckl/vox_jckl" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/kngs/vox_kngs" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/kngt/vox_kngt" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/ktsn/vox_ktsn" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/lazr/vox_lazr" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/masn/vox_masn" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/maxi/vox_maxi" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/mcln/vox_mcln" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/mrs1/vox_mrs1" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/mrs2/vox_mrs2" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/mrs3/vox_mrs3" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/naga/vox_naga" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/park/vox_park" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/prce/vox_prce" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/ptnv/vox_ptnv" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/rmbo/vox_rmbo" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/rvas/vox_rvas" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/rvnv/vox_rvnv" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/sala/vox_sala" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/sims/vox_sims" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/stch/vox_stch" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/stry/vox_stry" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/weav/vox_weav" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/wolf/vox_wolf" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/wood/vox_wood" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/wrth/vox_wrth" + voxType + languageType);
                    CheckSoundName("vox/scripted/ping/zyna/vox_zyna" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/adlr/vox_adlr" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/antv/vox_antv" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/bakr/vox_bakr" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/bdzr/vox_bdzr" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/beck/vox_beck" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/frs1/vox_frs1" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/frs2/vox_frs2" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/fuze/vox_fuze" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/grca/vox_grca" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/gstf/vox_gstf" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/hdsn/vox_hdsn" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/jckl/vox_jckl" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/kngs/vox_kngs" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/kngt/vox_kngt" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/ktsn/vox_ktsn" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/lazr/vox_lazr" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/masn/vox_masn" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/maxi/vox_maxi" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/mcln/vox_mcln" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/mrs1/vox_mrs1" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/mrs2/vox_mrs2" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/mrs3/vox_mrs3" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/naga/vox_naga" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/park/vox_park" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/prce/vox_prce" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/ptnv/vox_ptnv" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/rmbo/vox_rmbo" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/rvas/vox_rvas" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/rvnv/vox_rvnv" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/sala/vox_sala" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/sims/vox_sims" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/stch/vox_stch" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/stry/vox_stry" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/weav/vox_weav" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/wolf/vox_wolf" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/wood/vox_wood" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/wrth/vox_wrth" + voxType + languageType);
                    CheckSoundName("vox/scripted/zm_operators/zyna/vox_zyna" + voxType + languageType);
                }
            }
            foreach (string stringType in StringTypes)
            {
                CheckStringName("" + stringType);
                CheckStringName("j" + stringType);
                CheckStringName("jnt" + stringType);
                CheckStringName("joint" + stringType);
                CheckStringName("p7" + stringType);
                CheckStringName("p8" + stringType);
                CheckStringName("p9" + stringType);
                CheckStringName("tag" + stringType);
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

        void CheckAnimName(string animName)
        {
            string hashName = string.Format("{0:x}", Hash64Util.Hash64(animName));
            if (Directory.Exists(Path + "\\xanim_" + hashName))
            {
                Console.WriteLine("Found Anim: {0:x}", hashName + "," + animName);
                File.AppendAllText(Path + "\\AnimsFound.txt", hashName + "," + animName + Environment.NewLine);
                Directory.Delete(Path + "\\xanim_" + hashName);
            }
        }

        void CheckImageName(string imageName)
        {
            string hashName = string.Format("{0:x}", Hash64Util.Hash64(imageName));
            if (Directory.Exists(Path + "\\ximage_" + hashName))
            {
                Console.WriteLine("Found Image: {0:x}", hashName + "," + imageName);
                File.AppendAllText(Path + "\\ImagesFound.txt", hashName + "," + imageName + Environment.NewLine);
                Directory.Delete(Path + "\\ximage_" + hashName);
            }
        }

        void CheckMaterialName(string materialName)
        {
            string hashName = string.Format("{0:x}", Hash64Util.Hash64(materialName));
            if (Directory.Exists(Path + "\\xmaterial_" + hashName))
            {
                Console.WriteLine("Found Material: {0:x}", hashName + "," + materialName);
                File.AppendAllText(Path + "\\MaterialsFound.txt", hashName + "," + materialName + Environment.NewLine);
                Directory.Delete(Path + "\\xmaterial_" + hashName);
            }
        }

        void CheckModelName(string modelName)
        {
            string hashName = string.Format("{0:x}", Hash64Util.Hash64(modelName));
            if (Directory.Exists(Path + "\\xmodel_" + hashName))
            {
                Console.WriteLine("Found Model: {0:x}", hashName + "," + modelName);
                File.AppendAllText(Path + "\\ModelsFound.txt", hashName + "," + modelName + Environment.NewLine);
                Directory.Delete(Path + "\\xmodel_" + hashName);
            }
        }

        void CheckSoundName(string soundName)
        {
            string hashName = string.Format("{0:x}", Hash64Util.Hash64(soundName));
            if (Directory.Exists(Path + "\\xsound_" + hashName))
            {
                Console.WriteLine("Found Sound: {0:x}", hashName + "," + soundName);
                File.AppendAllText(Path + "\\SoundsFound.txt", hashName + "," + soundName + Environment.NewLine);
                Directory.Delete(Path + "\\xsound_" + hashName);
            }
        }
        void CheckStringName(string stringName)
        {
            string hashName = string.Format("{0:x}", Hash64Util.Hash64(stringName));
            if (Directory.Exists(Path + "\\xstring_" + hashName))
            {
                Console.WriteLine("Found String: {0:x}", hashName + "," + stringName);
                File.AppendAllText(Path + "\\StringsFound.txt", hashName + "," + stringName + Environment.NewLine);
                Directory.Delete(Path + "\\xstring_" + hashName);
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
    }
}

namespace fnvHashFinder
{
    class Hash64Util
    {
        public static ulong Hash64(string input)
        {
            ulong num = 14695981039346656037;
            for (int index = 0; index < input.Length; ++index)
                num = (ulong)(((long)num ^ (long)input[index]) * 1099511628211L);
            num &= 0xFFFFFFFFFFFFFFF;
            return num;
        }
    }
}