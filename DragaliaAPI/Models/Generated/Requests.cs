#nullable disable

using System.ComponentModel.DataAnnotations;
using DragaliaAPI.Shared.Definitions.Enums;
using MessagePack;

namespace DragaliaAPI.Models.Generated;

[MessagePackObject(true)]
public class AbilityCrestBuildupPieceRequest
{
    public int ability_crest_id { get; set; }
    public IEnumerable<AtgenBuildupAbilityCrestPieceList> buildup_ability_crest_piece_list { get; set; }

    public AbilityCrestBuildupPieceRequest(
        int ability_crest_id,
        IEnumerable<AtgenBuildupAbilityCrestPieceList> buildup_ability_crest_piece_list
    )
    {
        this.ability_crest_id = ability_crest_id;
        this.buildup_ability_crest_piece_list = buildup_ability_crest_piece_list;
    }

    public AbilityCrestBuildupPieceRequest() { }
}

[MessagePackObject(true)]
public class AbilityCrestBuildupPlusCountRequest
{
    public int ability_crest_id { get; set; }
    public IEnumerable<AtgenPlusCountParamsList> plus_count_params_list { get; set; }

    public AbilityCrestBuildupPlusCountRequest(
        int ability_crest_id,
        IEnumerable<AtgenPlusCountParamsList> plus_count_params_list
    )
    {
        this.ability_crest_id = ability_crest_id;
        this.plus_count_params_list = plus_count_params_list;
    }

    public AbilityCrestBuildupPlusCountRequest() { }
}

[MessagePackObject(true)]
public class AbilityCrestGetAbilityCrestSetListRequest { }

[MessagePackObject(true)]
public class AbilityCrestResetPlusCountRequest
{
    public int ability_crest_id { get; set; }
    public IEnumerable<int> plus_count_type_list { get; set; }

    public AbilityCrestResetPlusCountRequest(
        int ability_crest_id,
        IEnumerable<int> plus_count_type_list
    )
    {
        this.ability_crest_id = ability_crest_id;
        this.plus_count_type_list = plus_count_type_list;
    }

    public AbilityCrestResetPlusCountRequest() { }
}

[MessagePackObject(true)]
public class AbilityCrestSetAbilityCrestSetRequest
{
    public int ability_crest_set_no { get; set; }
    public string ability_crest_set_name { get; set; }
    public AtgenRequestAbilityCrestSetData request_ability_crest_set_data { get; set; }

    public AbilityCrestSetAbilityCrestSetRequest(
        int ability_crest_set_no,
        string ability_crest_set_name,
        AtgenRequestAbilityCrestSetData request_ability_crest_set_data
    )
    {
        this.ability_crest_set_no = ability_crest_set_no;
        this.ability_crest_set_name = ability_crest_set_name;
        this.request_ability_crest_set_data = request_ability_crest_set_data;
    }

    public AbilityCrestSetAbilityCrestSetRequest() { }
}

[MessagePackObject(true)]
public class AbilityCrestSetFavoriteRequest
{
    public int ability_crest_id { get; set; }
    public int is_favorite { get; set; }

    public AbilityCrestSetFavoriteRequest(int ability_crest_id, int is_favorite)
    {
        this.ability_crest_id = ability_crest_id;
        this.is_favorite = is_favorite;
    }

    public AbilityCrestSetFavoriteRequest() { }
}

[MessagePackObject(true)]
public class AbilityCrestTradeGetListRequest { }

[MessagePackObject(true)]
public class AbilityCrestTradeTradeRequest
{
    public int ability_crest_trade_id { get; set; }
    public int trade_count { get; set; }

    public AbilityCrestTradeTradeRequest(int ability_crest_trade_id, int trade_count)
    {
        this.ability_crest_trade_id = ability_crest_trade_id;
        this.trade_count = trade_count;
    }

    public AbilityCrestTradeTradeRequest() { }
}

[MessagePackObject(true)]
public class AbilityCrestUpdateAbilityCrestSetNameRequest
{
    public int ability_crest_set_no { get; set; }
    public string ability_crest_set_name { get; set; }

    public AbilityCrestUpdateAbilityCrestSetNameRequest(
        int ability_crest_set_no,
        string ability_crest_set_name
    )
    {
        this.ability_crest_set_no = ability_crest_set_no;
        this.ability_crest_set_name = ability_crest_set_name;
    }

    public AbilityCrestUpdateAbilityCrestSetNameRequest() { }
}

[MessagePackObject(true)]
public class AlbumIndexRequest { }

[MessagePackObject(true)]
public class AmuletBuildupRequest
{
    public ulong base_amulet_key_id { get; set; }
    public IEnumerable<GrowMaterialList> grow_material_list { get; set; }

    public AmuletBuildupRequest(
        ulong base_amulet_key_id,
        IEnumerable<GrowMaterialList> grow_material_list
    )
    {
        this.base_amulet_key_id = base_amulet_key_id;
        this.grow_material_list = grow_material_list;
    }

    public AmuletBuildupRequest() { }
}

[MessagePackObject(true)]
public class AmuletLimitBreakRequest
{
    public ulong base_amulet_key_id { get; set; }
    public IEnumerable<GrowMaterialList> grow_material_list { get; set; }

    public AmuletLimitBreakRequest(
        ulong base_amulet_key_id,
        IEnumerable<GrowMaterialList> grow_material_list
    )
    {
        this.base_amulet_key_id = base_amulet_key_id;
        this.grow_material_list = grow_material_list;
    }

    public AmuletLimitBreakRequest() { }
}

[MessagePackObject(true)]
public class AmuletResetPlusCountRequest
{
    public ulong amulet_key_id { get; set; }
    public int plus_count_type { get; set; }

    public AmuletResetPlusCountRequest(ulong amulet_key_id, int plus_count_type)
    {
        this.amulet_key_id = amulet_key_id;
        this.plus_count_type = plus_count_type;
    }

    public AmuletResetPlusCountRequest() { }
}

[MessagePackObject(true)]
public class AmuletSellRequest
{
    public IEnumerable<ulong> amulet_key_id_list { get; set; }

    public AmuletSellRequest(IEnumerable<ulong> amulet_key_id_list)
    {
        this.amulet_key_id_list = amulet_key_id_list;
    }

    public AmuletSellRequest() { }
}

[MessagePackObject(true)]
public class AmuletSetLockRequest
{
    public ulong amulet_key_id { get; set; }
    public int is_lock { get; set; }

    public AmuletSetLockRequest(ulong amulet_key_id, int is_lock)
    {
        this.amulet_key_id = amulet_key_id;
        this.is_lock = is_lock;
    }

    public AmuletSetLockRequest() { }
}

[MessagePackObject(true)]
public class AmuletTradeGetListRequest { }

[MessagePackObject(true)]
public class AmuletTradeTradeRequest
{
    public int amulet_trade_id { get; set; }
    public int trade_count { get; set; }

    public AmuletTradeTradeRequest(int amulet_trade_id, int trade_count)
    {
        this.amulet_trade_id = amulet_trade_id;
        this.trade_count = trade_count;
    }

    public AmuletTradeTradeRequest() { }
}

[MessagePackObject(true)]
public class BattleRoyalEventEntryRequest
{
    public int event_id { get; set; }

    public BattleRoyalEventEntryRequest(int event_id)
    {
        this.event_id = event_id;
    }

    public BattleRoyalEventEntryRequest() { }
}

[MessagePackObject(true)]
public class BattleRoyalEventGetEventDataRequest
{
    public int event_id { get; set; }

    public BattleRoyalEventGetEventDataRequest(int event_id)
    {
        this.event_id = event_id;
    }

    public BattleRoyalEventGetEventDataRequest() { }
}

[MessagePackObject(true)]
public class BattleRoyalEventReceiveEventCyclePointRewardRequest
{
    public int event_id { get; set; }
    public int event_cycle_id { get; set; }

    public BattleRoyalEventReceiveEventCyclePointRewardRequest(int event_id, int event_cycle_id)
    {
        this.event_id = event_id;
        this.event_cycle_id = event_cycle_id;
    }

    public BattleRoyalEventReceiveEventCyclePointRewardRequest() { }
}

[MessagePackObject(true)]
public class BattleRoyalEventReleaseCharaSkinRequest
{
    public int battle_royal_chara_skin_id { get; set; }
    public int is_pickup { get; set; }

    public BattleRoyalEventReleaseCharaSkinRequest(int battle_royal_chara_skin_id, int is_pickup)
    {
        this.battle_royal_chara_skin_id = battle_royal_chara_skin_id;
        this.is_pickup = is_pickup;
    }

    public BattleRoyalEventReleaseCharaSkinRequest() { }
}

[MessagePackObject(true)]
public class BattleRoyalFailRequest
{
    public string dungeon_key { get; set; }
    public int fail_state { get; set; }
    public int no_play_flg { get; set; }

    public BattleRoyalFailRequest(string dungeon_key, int fail_state, int no_play_flg)
    {
        this.dungeon_key = dungeon_key;
        this.fail_state = fail_state;
        this.no_play_flg = no_play_flg;
    }

    public BattleRoyalFailRequest() { }
}

[MessagePackObject(true)]
public class BattleRoyalGetBattleRoyalHistoryRequest
{
    public int event_id { get; set; }

    public BattleRoyalGetBattleRoyalHistoryRequest(int event_id)
    {
        this.event_id = event_id;
    }

    public BattleRoyalGetBattleRoyalHistoryRequest() { }
}

[MessagePackObject(true)]
public class BattleRoyalRecordRoyalRecordMultiRequest
{
    public PlayRecord play_record { get; set; }
    public string dungeon_key { get; set; }
    public string multiplay_key { get; set; }

    public BattleRoyalRecordRoyalRecordMultiRequest(
        PlayRecord play_record,
        string dungeon_key,
        string multiplay_key
    )
    {
        this.play_record = play_record;
        this.dungeon_key = dungeon_key;
        this.multiplay_key = multiplay_key;
    }

    public BattleRoyalRecordRoyalRecordMultiRequest() { }
}

[MessagePackObject(true)]
public class BattleRoyalStartMultiRequest
{
    public Charas chara_id { get; set; }
    public int is_tutorial { get; set; }
    public string multiplay_key { get; set; }

    public BattleRoyalStartMultiRequest(Charas chara_id, int is_tutorial, string multiplay_key)
    {
        this.chara_id = chara_id;
        this.is_tutorial = is_tutorial;
        this.multiplay_key = multiplay_key;
    }

    public BattleRoyalStartMultiRequest() { }
}

[MessagePackObject(true)]
public class BattleRoyalStartRoyalMultiRequest { }

[MessagePackObject(true)]
public class BuildEventEntryRequest
{
    public int event_id { get; set; }

    public BuildEventEntryRequest(int event_id)
    {
        this.event_id = event_id;
    }

    public BuildEventEntryRequest() { }
}

[MessagePackObject(true)]
public class BuildEventGetEventDataRequest
{
    public int event_id { get; set; }

    public BuildEventGetEventDataRequest(int event_id)
    {
        this.event_id = event_id;
    }

    public BuildEventGetEventDataRequest() { }
}

[MessagePackObject(true)]
public class BuildEventReceiveBuildPointRewardRequest
{
    public int event_id { get; set; }

    public BuildEventReceiveBuildPointRewardRequest(int event_id)
    {
        this.event_id = event_id;
    }

    public BuildEventReceiveBuildPointRewardRequest() { }
}

[MessagePackObject(true)]
public class BuildEventReceiveDailyBonusRequest
{
    public int event_id { get; set; }

    public BuildEventReceiveDailyBonusRequest(int event_id)
    {
        this.event_id = event_id;
    }

    public BuildEventReceiveDailyBonusRequest() { }
}

[MessagePackObject(true)]
public class CartoonLatestRequest { }

[MessagePackObject(true)]
public class CastleStoryReadRequest
{
    public int castle_story_id { get; set; }

    public CastleStoryReadRequest(int castle_story_id)
    {
        this.castle_story_id = castle_story_id;
    }

    public CastleStoryReadRequest() { }
}

[MessagePackObject(true)]
public class CharaAwakeRequest
{
    public Charas chara_id { get; set; }
    public int next_rarity { get; set; }

    public CharaAwakeRequest(Charas chara_id, int next_rarity)
    {
        this.chara_id = chara_id;
        this.next_rarity = next_rarity;
    }

    public CharaAwakeRequest() { }
}

[MessagePackObject(true)]
public class CharaBuildupManaRequest
{
    public Charas chara_id { get; set; }
    public IEnumerable<int> mana_circle_piece_id_list { get; set; }
    public int is_use_grow_material { get; set; }

    public CharaBuildupManaRequest(
        Charas chara_id,
        IEnumerable<int> mana_circle_piece_id_list,
        int is_use_grow_material
    )
    {
        this.chara_id = chara_id;
        this.mana_circle_piece_id_list = mana_circle_piece_id_list;
        this.is_use_grow_material = is_use_grow_material;
    }

    public CharaBuildupManaRequest() { }
}

[MessagePackObject(true)]
public class CharaBuildupPlatinumRequest
{
    public Charas chara_id { get; set; }

    public CharaBuildupPlatinumRequest(Charas chara_id)
    {
        this.chara_id = chara_id;
    }

    public CharaBuildupPlatinumRequest() { }
}

[MessagePackObject(true)]
public class CharaBuildupRequest
{
    public Charas chara_id { get; set; }
    public IEnumerable<AtgenEnemyPiece> material_list { get; set; }

    public CharaBuildupRequest(Charas chara_id, IEnumerable<AtgenEnemyPiece> material_list)
    {
        this.chara_id = chara_id;
        this.material_list = material_list;
    }

    public CharaBuildupRequest() { }
}

[MessagePackObject(true)]
public class CharaGetCharaUnitSetRequest
{
    public IEnumerable<int> chara_id_list { get; set; }

    public CharaGetCharaUnitSetRequest(IEnumerable<int> chara_id_list)
    {
        this.chara_id_list = chara_id_list;
    }

    public CharaGetCharaUnitSetRequest() { }
}

[MessagePackObject(true)]
public class CharaGetListRequest { }

[MessagePackObject(true)]
public class CharaLimitBreakAndBuildupManaRequest
{
    public Charas chara_id { get; set; }
    public int next_limit_break_count { get; set; }
    public IEnumerable<int> mana_circle_piece_id_list { get; set; }
    public int is_use_grow_material { get; set; }

    public CharaLimitBreakAndBuildupManaRequest(
        Charas chara_id,
        int next_limit_break_count,
        IEnumerable<int> mana_circle_piece_id_list,
        int is_use_grow_material
    )
    {
        this.chara_id = chara_id;
        this.next_limit_break_count = next_limit_break_count;
        this.mana_circle_piece_id_list = mana_circle_piece_id_list;
        this.is_use_grow_material = is_use_grow_material;
    }

    public CharaLimitBreakAndBuildupManaRequest() { }
}

[MessagePackObject(true)]
public class CharaLimitBreakRequest
{
    public Charas chara_id { get; set; }
    public int next_limit_break_count { get; set; }
    public int is_use_grow_material { get; set; }

    public CharaLimitBreakRequest(
        Charas chara_id,
        int next_limit_break_count,
        int is_use_grow_material
    )
    {
        this.chara_id = chara_id;
        this.next_limit_break_count = next_limit_break_count;
        this.is_use_grow_material = is_use_grow_material;
    }

    public CharaLimitBreakRequest() { }
}

[MessagePackObject(true)]
public class CharaResetPlusCountRequest
{
    public Charas chara_id { get; set; }
    public int plus_count_type { get; set; }

    public CharaResetPlusCountRequest(Charas chara_id, int plus_count_type)
    {
        this.chara_id = chara_id;
        this.plus_count_type = plus_count_type;
    }

    public CharaResetPlusCountRequest() { }
}

[MessagePackObject(true)]
public class CharaSetCharaUnitSetRequest
{
    public int unit_set_no { get; set; }
    public string unit_set_name { get; set; }
    public Charas chara_id { get; set; }
    public AtgenRequestCharaUnitSetData request_chara_unit_set_data { get; set; }

    public CharaSetCharaUnitSetRequest(
        int unit_set_no,
        string unit_set_name,
        Charas chara_id,
        AtgenRequestCharaUnitSetData request_chara_unit_set_data
    )
    {
        this.unit_set_no = unit_set_no;
        this.unit_set_name = unit_set_name;
        this.chara_id = chara_id;
        this.request_chara_unit_set_data = request_chara_unit_set_data;
    }

    public CharaSetCharaUnitSetRequest() { }
}

[MessagePackObject(true)]
public class CharaUnlockEditSkillRequest
{
    public Charas chara_id { get; set; }

    public CharaUnlockEditSkillRequest(Charas chara_id)
    {
        this.chara_id = chara_id;
    }

    public CharaUnlockEditSkillRequest() { }
}

[MessagePackObject(true)]
public class Clb01EventEntryRequest
{
    public int event_id { get; set; }

    public Clb01EventEntryRequest(int event_id)
    {
        this.event_id = event_id;
    }

    public Clb01EventEntryRequest() { }
}

[MessagePackObject(true)]
public class Clb01EventGetEventDataRequest
{
    public int event_id { get; set; }

    public Clb01EventGetEventDataRequest(int event_id)
    {
        this.event_id = event_id;
    }

    public Clb01EventGetEventDataRequest() { }
}

[MessagePackObject(true)]
public class Clb01EventReceiveClb01PointRewardRequest
{
    public int event_id { get; set; }

    public Clb01EventReceiveClb01PointRewardRequest(int event_id)
    {
        this.event_id = event_id;
    }

    public Clb01EventReceiveClb01PointRewardRequest() { }
}

[MessagePackObject(true)]
public class CollectEventEntryRequest
{
    public int event_id { get; set; }

    public CollectEventEntryRequest(int event_id)
    {
        this.event_id = event_id;
    }

    public CollectEventEntryRequest() { }
}

[MessagePackObject(true)]
public class CollectEventGetEventDataRequest
{
    public int event_id { get; set; }

    public CollectEventGetEventDataRequest(int event_id)
    {
        this.event_id = event_id;
    }

    public CollectEventGetEventDataRequest() { }
}

[MessagePackObject(true)]
public class CombatEventEntryRequest
{
    public int event_id { get; set; }

    public CombatEventEntryRequest(int event_id)
    {
        this.event_id = event_id;
    }

    public CombatEventEntryRequest() { }
}

[MessagePackObject(true)]
public class CombatEventGetEventDataRequest
{
    public int event_id { get; set; }

    public CombatEventGetEventDataRequest(int event_id)
    {
        this.event_id = event_id;
    }

    public CombatEventGetEventDataRequest() { }
}

[MessagePackObject(true)]
public class CombatEventReceiveEventLocationRewardRequest
{
    public int event_id { get; set; }
    public int event_location_reward_id { get; set; }

    public CombatEventReceiveEventLocationRewardRequest(int event_id, int event_location_reward_id)
    {
        this.event_id = event_id;
        this.event_location_reward_id = event_location_reward_id;
    }

    public CombatEventReceiveEventLocationRewardRequest() { }
}

[MessagePackObject(true)]
public class CombatEventReceiveEventPointRewardRequest
{
    public int event_id { get; set; }

    public CombatEventReceiveEventPointRewardRequest(int event_id)
    {
        this.event_id = event_id;
    }

    public CombatEventReceiveEventPointRewardRequest() { }
}

[MessagePackObject(true)]
public class CraftAssembleRequest
{
    public ulong weapon_key_id { get; set; }
    public int target_weapon_id { get; set; }
    public IEnumerable<GrowMaterialList> assemble_item_list { get; set; }
    public IEnumerable<AtgenWeaponSetList> weapon_set_list { get; set; }

    public CraftAssembleRequest(
        ulong weapon_key_id,
        int target_weapon_id,
        IEnumerable<GrowMaterialList> assemble_item_list,
        IEnumerable<AtgenWeaponSetList> weapon_set_list
    )
    {
        this.weapon_key_id = weapon_key_id;
        this.target_weapon_id = target_weapon_id;
        this.assemble_item_list = assemble_item_list;
        this.weapon_set_list = weapon_set_list;
    }

    public CraftAssembleRequest() { }
}

[MessagePackObject(true)]
public class CraftCreateRequest
{
    public int target_weapon_id { get; set; }
    public int target_weapon_quantity { get; set; }
    public int force_limit_break { get; set; }
    public IEnumerable<AtgenWeaponSetList> weapon_set_list { get; set; }

    public CraftCreateRequest(
        int target_weapon_id,
        int target_weapon_quantity,
        int force_limit_break,
        IEnumerable<AtgenWeaponSetList> weapon_set_list
    )
    {
        this.target_weapon_id = target_weapon_id;
        this.target_weapon_quantity = target_weapon_quantity;
        this.force_limit_break = force_limit_break;
        this.weapon_set_list = weapon_set_list;
    }

    public CraftCreateRequest() { }
}

[MessagePackObject(true)]
public class CraftDisassembleRequest
{
    public ulong weapon_key_id { get; set; }
    public int payment_type { get; set; }

    public CraftDisassembleRequest(ulong weapon_key_id, int payment_type)
    {
        this.weapon_key_id = weapon_key_id;
        this.payment_type = payment_type;
    }

    public CraftDisassembleRequest() { }
}

[MessagePackObject(true)]
public class CraftResetNewRequest
{
    public IEnumerable<int> weapon_id_list { get; set; }

    public CraftResetNewRequest(IEnumerable<int> weapon_id_list)
    {
        this.weapon_id_list = weapon_id_list;
    }

    public CraftResetNewRequest() { }
}

[MessagePackObject(true)]
public class DeployGetDeployVersionRequest { }

[MessagePackObject(true)]
public class DmodeBuildupServitorPassiveRequest
{
    public IEnumerable<DmodeServitorPassiveList> request_buildup_passive_list { get; set; }

    public DmodeBuildupServitorPassiveRequest(
        IEnumerable<DmodeServitorPassiveList> request_buildup_passive_list
    )
    {
        this.request_buildup_passive_list = request_buildup_passive_list;
    }

    public DmodeBuildupServitorPassiveRequest() { }
}

[MessagePackObject(true)]
public class DmodeDungeonFinishRequest
{
    public int is_game_over { get; set; }

    public DmodeDungeonFinishRequest(int is_game_over)
    {
        this.is_game_over = is_game_over;
    }

    public DmodeDungeonFinishRequest() { }
}

[MessagePackObject(true)]
public class DmodeDungeonFloorRequest
{
    public DmodePlayRecord dmode_play_record { get; set; }

    public DmodeDungeonFloorRequest(DmodePlayRecord dmode_play_record)
    {
        this.dmode_play_record = dmode_play_record;
    }

    public DmodeDungeonFloorRequest() { }
}

[MessagePackObject(true)]
public class DmodeDungeonFloorSkipRequest { }

[MessagePackObject(true)]
public class DmodeDungeonRestartRequest { }

[MessagePackObject(true)]
public class DmodeDungeonStartRequest
{
    public Charas chara_id { get; set; }
    public int start_floor_num { get; set; }
    public int servitor_id { get; set; }
    public IEnumerable<int> bring_edit_skill_chara_id_list { get; set; }

    public DmodeDungeonStartRequest(
        Charas chara_id,
        int start_floor_num,
        int servitor_id,
        IEnumerable<int> bring_edit_skill_chara_id_list
    )
    {
        this.chara_id = chara_id;
        this.start_floor_num = start_floor_num;
        this.servitor_id = servitor_id;
        this.bring_edit_skill_chara_id_list = bring_edit_skill_chara_id_list;
    }

    public DmodeDungeonStartRequest() { }
}

[MessagePackObject(true)]
public class DmodeDungeonSystemHaltRequest { }

[MessagePackObject(true)]
public class DmodeDungeonUserHaltRequest { }

[MessagePackObject(true)]
public class DmodeEntryRequest { }

[MessagePackObject(true)]
public class DmodeExpeditionFinishRequest { }

[MessagePackObject(true)]
public class DmodeExpeditionForceFinishRequest { }

[MessagePackObject(true)]
public class DmodeExpeditionStartRequest
{
    public int target_floor_num { get; set; }
    public IEnumerable<int> chara_id_list { get; set; }

    public DmodeExpeditionStartRequest(int target_floor_num, IEnumerable<int> chara_id_list)
    {
        this.target_floor_num = target_floor_num;
        this.chara_id_list = chara_id_list;
    }

    public DmodeExpeditionStartRequest() { }
}

[MessagePackObject(true)]
public class DmodeGetDataRequest { }

[MessagePackObject(true)]
public class DmodeReadStoryRequest
{
    public int dmode_story_id { get; set; }

    public DmodeReadStoryRequest(int dmode_story_id)
    {
        this.dmode_story_id = dmode_story_id;
    }

    public DmodeReadStoryRequest() { }
}

[MessagePackObject(true)]
public class DragonBuildupRequest
{
    public ulong base_dragon_key_id { get; set; }
    public IEnumerable<GrowMaterialList> grow_material_list { get; set; }

    public DragonBuildupRequest(
        ulong base_dragon_key_id,
        IEnumerable<GrowMaterialList> grow_material_list
    )
    {
        this.base_dragon_key_id = base_dragon_key_id;
        this.grow_material_list = grow_material_list;
    }

    public DragonBuildupRequest() { }
}

[MessagePackObject(true)]
public class DragonBuyGiftToSendMultipleRequest
{
    public int dragon_id { get; set; }
    public IEnumerable<int> dragon_gift_id_list { get; set; }

    public DragonBuyGiftToSendMultipleRequest(int dragon_id, IEnumerable<int> dragon_gift_id_list)
    {
        this.dragon_id = dragon_id;
        this.dragon_gift_id_list = dragon_gift_id_list;
    }

    public DragonBuyGiftToSendMultipleRequest() { }
}

[MessagePackObject(true)]
public class DragonBuyGiftToSendRequest
{
    public int dragon_id { get; set; }
    public int dragon_gift_id { get; set; }

    public DragonBuyGiftToSendRequest(int dragon_id, int dragon_gift_id)
    {
        this.dragon_id = dragon_id;
        this.dragon_gift_id = dragon_gift_id;
    }

    public DragonBuyGiftToSendRequest() { }
}

[MessagePackObject(true)]
public class DragonGetContactDataRequest { }

[MessagePackObject(true)]
public class DragonLimitBreakRequest
{
    public ulong base_dragon_key_id { get; set; }
    public IEnumerable<LimitBreakGrowList> limit_break_grow_list { get; set; }

    public DragonLimitBreakRequest(
        ulong base_dragon_key_id,
        IEnumerable<LimitBreakGrowList> limit_break_grow_list
    )
    {
        this.base_dragon_key_id = base_dragon_key_id;
        this.limit_break_grow_list = limit_break_grow_list;
    }

    public DragonLimitBreakRequest() { }
}

[MessagePackObject(true)]
public class DragonResetPlusCountRequest
{
    public ulong dragon_key_id { get; set; }
    public int plus_count_type { get; set; }

    public DragonResetPlusCountRequest(ulong dragon_key_id, int plus_count_type)
    {
        this.dragon_key_id = dragon_key_id;
        this.plus_count_type = plus_count_type;
    }

    public DragonResetPlusCountRequest() { }
}

[MessagePackObject(true)]
public class DragonSellRequest
{
    public IEnumerable<ulong> dragon_key_id_list { get; set; }

    public DragonSellRequest(IEnumerable<ulong> dragon_key_id_list)
    {
        this.dragon_key_id_list = dragon_key_id_list;
    }

    public DragonSellRequest() { }
}

[MessagePackObject(true)]
public class DragonSendGiftMultipleRequest
{
    public int dragon_id { get; set; }
    public int dragon_gift_id { get; set; }
    public int quantity { get; set; }

    public DragonSendGiftMultipleRequest(int dragon_id, int dragon_gift_id, int quantity)
    {
        this.dragon_id = dragon_id;
        this.dragon_gift_id = dragon_gift_id;
        this.quantity = quantity;
    }

    public DragonSendGiftMultipleRequest() { }
}

[MessagePackObject(true)]
public class DragonSendGiftRequest
{
    public int dragon_id { get; set; }
    public int dragon_gift_id { get; set; }

    public DragonSendGiftRequest(int dragon_id, int dragon_gift_id)
    {
        this.dragon_id = dragon_id;
        this.dragon_gift_id = dragon_gift_id;
    }

    public DragonSendGiftRequest() { }
}

[MessagePackObject(true)]
public class DragonSetLockRequest
{
    public ulong dragon_key_id { get; set; }
    public int is_lock { get; set; }

    public DragonSetLockRequest(ulong dragon_key_id, int is_lock)
    {
        this.dragon_key_id = dragon_key_id;
        this.is_lock = is_lock;
    }

    public DragonSetLockRequest() { }
}

[MessagePackObject(true)]
public class DreamAdventureClearRequest
{
    public int difficulty { get; set; }

    public DreamAdventureClearRequest(int difficulty)
    {
        this.difficulty = difficulty;
    }

    public DreamAdventureClearRequest() { }
}

[MessagePackObject(true)]
public class DreamAdventurePlayRequest
{
    public int difficulty { get; set; }

    public DreamAdventurePlayRequest(int difficulty)
    {
        this.difficulty = difficulty;
    }

    public DreamAdventurePlayRequest() { }
}

[MessagePackObject(true)]
public class DungeonFailRequest
{
    public string dungeon_key { get; set; }
    public int fail_state { get; set; }
    public int no_play_flg { get; set; }

    public DungeonFailRequest(string dungeon_key, int fail_state, int no_play_flg)
    {
        this.dungeon_key = dungeon_key;
        this.fail_state = fail_state;
        this.no_play_flg = no_play_flg;
    }

    public DungeonFailRequest() { }
}

[MessagePackObject(true)]
public class DungeonGetAreaOddsRequest
{
    public string dungeon_key { get; set; }
    public int area_idx { get; set; }

    public DungeonGetAreaOddsRequest(string dungeon_key, int area_idx)
    {
        this.dungeon_key = dungeon_key;
        this.area_idx = area_idx;
    }

    public DungeonGetAreaOddsRequest() { }
}

[MessagePackObject(true)]
public class DungeonReceiveQuestBonusRequest
{
    public int quest_event_id { get; set; }
    public int is_receive { get; set; }
    public int receive_bonus_count { get; set; }

    public DungeonReceiveQuestBonusRequest(
        int quest_event_id,
        int is_receive,
        int receive_bonus_count
    )
    {
        this.quest_event_id = quest_event_id;
        this.is_receive = is_receive;
        this.receive_bonus_count = receive_bonus_count;
    }

    public DungeonReceiveQuestBonusRequest() { }
}

[MessagePackObject(true)]
public class DungeonRecordRecordMultiRequest
{
    public PlayRecord play_record { get; set; }
    public string dungeon_key { get; set; }
    public IEnumerable<ulong> connecting_viewer_id_list { get; set; }
    public int no_play_flg { get; set; }

    public DungeonRecordRecordMultiRequest(
        PlayRecord play_record,
        string dungeon_key,
        IEnumerable<ulong> connecting_viewer_id_list,
        int no_play_flg
    )
    {
        this.play_record = play_record;
        this.dungeon_key = dungeon_key;
        this.connecting_viewer_id_list = connecting_viewer_id_list;
        this.no_play_flg = no_play_flg;
    }

    public DungeonRecordRecordMultiRequest() { }
}

[MessagePackObject(true)]
public class DungeonRecordRecordRequest
{
    public PlayRecord play_record { get; set; }
    public string dungeon_key { get; set; }
    public int repeat_state { get; set; }
    public string repeat_key { get; set; }

    public DungeonRecordRecordRequest(
        PlayRecord play_record,
        string dungeon_key,
        int repeat_state,
        string repeat_key
    )
    {
        this.play_record = play_record;
        this.dungeon_key = dungeon_key;
        this.repeat_state = repeat_state;
        this.repeat_key = repeat_key;
    }

    public DungeonRecordRecordRequest() { }
}

[MessagePackObject(true)]
public class DungeonRetryRequest
{
    public string dungeon_key { get; set; }
    public int payment_type { get; set; }

    public DungeonRetryRequest(string dungeon_key, int payment_type)
    {
        this.dungeon_key = dungeon_key;
        this.payment_type = payment_type;
    }

    public DungeonRetryRequest() { }
}

[MessagePackObject(true)]
public class DungeonSkipStartAssignUnitRequest
{
    public int quest_id { get; set; }
    public IEnumerable<PartySettingList> request_party_setting_list { get; set; }
    public ulong support_viewer_id { get; set; }
    public int play_count { get; set; }
    public int bet_count { get; set; }

    public DungeonSkipStartAssignUnitRequest(
        int quest_id,
        IEnumerable<PartySettingList> request_party_setting_list,
        ulong support_viewer_id,
        int play_count,
        int bet_count
    )
    {
        this.quest_id = quest_id;
        this.request_party_setting_list = request_party_setting_list;
        this.support_viewer_id = support_viewer_id;
        this.play_count = play_count;
        this.bet_count = bet_count;
    }

    public DungeonSkipStartAssignUnitRequest() { }
}

[MessagePackObject(true)]
public class DungeonSkipStartMultipleQuestAssignUnitRequest
{
    public IEnumerable<PartySettingList> request_party_setting_list { get; set; }
    public IEnumerable<AtgenRequestQuestMultipleList> request_quest_multiple_list { get; set; }
    public ulong support_viewer_id { get; set; }

    public DungeonSkipStartMultipleQuestAssignUnitRequest(
        IEnumerable<PartySettingList> request_party_setting_list,
        IEnumerable<AtgenRequestQuestMultipleList> request_quest_multiple_list,
        ulong support_viewer_id
    )
    {
        this.request_party_setting_list = request_party_setting_list;
        this.request_quest_multiple_list = request_quest_multiple_list;
        this.support_viewer_id = support_viewer_id;
    }

    public DungeonSkipStartMultipleQuestAssignUnitRequest() { }
}

[MessagePackObject(true)]
public class DungeonSkipStartMultipleQuestRequest
{
    public int party_no { get; set; }
    public IEnumerable<AtgenRequestQuestMultipleList> request_quest_multiple_list { get; set; }
    public ulong support_viewer_id { get; set; }

    public DungeonSkipStartMultipleQuestRequest(
        int party_no,
        IEnumerable<AtgenRequestQuestMultipleList> request_quest_multiple_list,
        ulong support_viewer_id
    )
    {
        this.party_no = party_no;
        this.request_quest_multiple_list = request_quest_multiple_list;
        this.support_viewer_id = support_viewer_id;
    }

    public DungeonSkipStartMultipleQuestRequest() { }
}

[MessagePackObject(true)]
public class DungeonSkipStartRequest
{
    public int quest_id { get; set; }
    public int party_no { get; set; }
    public ulong support_viewer_id { get; set; }
    public int play_count { get; set; }
    public int bet_count { get; set; }

    public DungeonSkipStartRequest(
        int quest_id,
        int party_no,
        ulong support_viewer_id,
        int play_count,
        int bet_count
    )
    {
        this.quest_id = quest_id;
        this.party_no = party_no;
        this.support_viewer_id = support_viewer_id;
        this.play_count = play_count;
        this.bet_count = bet_count;
    }

    public DungeonSkipStartRequest() { }
}

[MessagePackObject(true)]
public class DungeonStartStartAssignUnitRequest
{
    public int quest_id { get; set; }
    public IEnumerable<PartySettingList> request_party_setting_list { get; set; }
    public int bet_count { get; set; }
    public int repeat_state { get; set; }
    public ulong support_viewer_id { get; set; }
    public RepeatSetting repeat_setting { get; set; }

    public DungeonStartStartAssignUnitRequest(
        int quest_id,
        IEnumerable<PartySettingList> request_party_setting_list,
        int bet_count,
        int repeat_state,
        ulong support_viewer_id,
        RepeatSetting repeat_setting
    )
    {
        this.quest_id = quest_id;
        this.request_party_setting_list = request_party_setting_list;
        this.bet_count = bet_count;
        this.repeat_state = repeat_state;
        this.support_viewer_id = support_viewer_id;
        this.repeat_setting = repeat_setting;
    }

    public DungeonStartStartAssignUnitRequest() { }
}

[MessagePackObject(true)]
public class DungeonStartStartMultiAssignUnitRequest
{
    public int quest_id { get; set; }
    public IEnumerable<PartySettingList> request_party_setting_list { get; set; }

    public DungeonStartStartMultiAssignUnitRequest(
        int quest_id,
        IEnumerable<PartySettingList> request_party_setting_list
    )
    {
        this.quest_id = quest_id;
        this.request_party_setting_list = request_party_setting_list;
    }

    public DungeonStartStartMultiAssignUnitRequest() { }
}

[MessagePackObject(true)]
public class DungeonStartStartMultiRequest
{
    public int quest_id { get; set; }
    public int party_no { get; set; }
    public IEnumerable<int> party_no_list { get; set; }

    public DungeonStartStartMultiRequest(int quest_id, int party_no, IEnumerable<int> party_no_list)
    {
        this.quest_id = quest_id;
        this.party_no = party_no;
        this.party_no_list = party_no_list;
    }

    public DungeonStartStartMultiRequest() { }
}

[MessagePackObject(true)]
public class DungeonStartStartRequest
{
    public int quest_id { get; set; }
    public int party_no { get; set; }
    public List<int> party_no_list { get; set; }
    public int bet_count { get; set; }
    public int repeat_state { get; set; }
    public ulong support_viewer_id { get; set; }
    public RepeatSetting repeat_setting { get; set; }

    public DungeonStartStartRequest(
        int quest_id,
        int party_no,
        List<int> party_no_list,
        int bet_count,
        int repeat_state,
        ulong support_viewer_id,
        RepeatSetting repeat_setting
    )
    {
        this.quest_id = quest_id;
        this.party_no = party_no;
        this.party_no_list = party_no_list;
        this.bet_count = bet_count;
        this.repeat_state = repeat_state;
        this.support_viewer_id = support_viewer_id;
        this.repeat_setting = repeat_setting;
    }

    public DungeonStartStartRequest() { }
}

[MessagePackObject(true)]
public class EarnEventEntryRequest
{
    public int event_id { get; set; }

    public EarnEventEntryRequest(int event_id)
    {
        this.event_id = event_id;
    }

    public EarnEventEntryRequest() { }
}

[MessagePackObject(true)]
public class EarnEventGetEventDataRequest
{
    public int event_id { get; set; }

    public EarnEventGetEventDataRequest(int event_id)
    {
        this.event_id = event_id;
    }

    public EarnEventGetEventDataRequest() { }
}

[MessagePackObject(true)]
public class EarnEventReceiveEventPointRewardRequest
{
    public int event_id { get; set; }

    public EarnEventReceiveEventPointRewardRequest(int event_id)
    {
        this.event_id = event_id;
    }

    public EarnEventReceiveEventPointRewardRequest() { }
}

[MessagePackObject(true)]
public class EmblemGetListRequest { }

[MessagePackObject(true)]
public class EmblemSetRequest
{
    public int emblem_id { get; set; }

    public EmblemSetRequest(int emblem_id)
    {
        this.emblem_id = emblem_id;
    }

    public EmblemSetRequest() { }
}

[MessagePackObject(true)]
public class EulaAgreeAgreeRequest
{
    public string id_token { get; set; }
    public string region { get; set; }
    public string lang { get; set; }
    public int eula_version { get; set; }
    public int privacy_policy_version { get; set; }
    public string uuid { get; set; }

    public EulaAgreeAgreeRequest(
        string id_token,
        string region,
        string lang,
        int eula_version,
        int privacy_policy_version,
        string uuid
    )
    {
        this.id_token = id_token;
        this.region = region;
        this.lang = lang;
        this.eula_version = eula_version;
        this.privacy_policy_version = privacy_policy_version;
        this.uuid = uuid;
    }

    public EulaAgreeAgreeRequest() { }
}

[MessagePackObject(true)]
public class EulaGetVersionListRequest { }

[MessagePackObject(true)]
public class EulaGetVersionRequest
{
    public string id_token { get; set; }
    public string region { get; set; }
    public string lang { get; set; }

    public EulaGetVersionRequest(string id_token, string region, string lang)
    {
        this.id_token = id_token;
        this.region = region;
        this.lang = lang;
    }

    public EulaGetVersionRequest() { }
}

[MessagePackObject(true)]
public class EventDamageGetTotalDamageHistoryRequest
{
    public int event_id { get; set; }

    public EventDamageGetTotalDamageHistoryRequest(int event_id)
    {
        this.event_id = event_id;
    }

    public EventDamageGetTotalDamageHistoryRequest() { }
}

[MessagePackObject(true)]
public class EventDamageReceiveDamageRewardRequest
{
    public int event_id { get; set; }

    public EventDamageReceiveDamageRewardRequest(int event_id)
    {
        this.event_id = event_id;
    }

    public EventDamageReceiveDamageRewardRequest() { }
}

[MessagePackObject(true)]
public class EventStoryReadRequest
{
    public int event_story_id { get; set; }

    public EventStoryReadRequest(int event_story_id)
    {
        this.event_story_id = event_story_id;
    }

    public EventStoryReadRequest() { }
}

[MessagePackObject(true)]
public class EventSummonExecRequest
{
    public int event_id { get; set; }
    public int count { get; set; }
    public int is_enable_stop_by_target { get; set; }

    public EventSummonExecRequest(int event_id, int count, int is_enable_stop_by_target)
    {
        this.event_id = event_id;
        this.count = count;
        this.is_enable_stop_by_target = is_enable_stop_by_target;
    }

    public EventSummonExecRequest() { }
}

[MessagePackObject(true)]
public class EventSummonGetDataRequest
{
    public int event_id { get; set; }

    public EventSummonGetDataRequest(int event_id)
    {
        this.event_id = event_id;
    }

    public EventSummonGetDataRequest() { }
}

[MessagePackObject(true)]
public class EventSummonResetRequest
{
    public int event_id { get; set; }

    public EventSummonResetRequest(int event_id)
    {
        this.event_id = event_id;
    }

    public EventSummonResetRequest() { }
}

[MessagePackObject(true)]
public class EventTradeGetListRequest
{
    public int trade_group_id { get; set; }

    public EventTradeGetListRequest(int trade_group_id)
    {
        this.trade_group_id = trade_group_id;
    }

    public EventTradeGetListRequest() { }
}

[MessagePackObject(true)]
public class EventTradeTradeRequest
{
    public int trade_group_id { get; set; }
    public int trade_id { get; set; }
    public int trade_count { get; set; }

    public EventTradeTradeRequest(int trade_group_id, int trade_id, int trade_count)
    {
        this.trade_group_id = trade_group_id;
        this.trade_id = trade_id;
        this.trade_count = trade_count;
    }

    public EventTradeTradeRequest() { }
}

[MessagePackObject(true)]
public class ExchangeGetUnitListRequest
{
    public int exchange_ticket_id { get; set; }

    public ExchangeGetUnitListRequest(int exchange_ticket_id)
    {
        this.exchange_ticket_id = exchange_ticket_id;
    }

    public ExchangeGetUnitListRequest() { }
}

[MessagePackObject(true)]
public class ExchangeSelectUnitRequest
{
    public int exchange_ticket_id { get; set; }
    public AtgenDuplicateEntityList selected_unit { get; set; }

    public ExchangeSelectUnitRequest(int exchange_ticket_id, AtgenDuplicateEntityList selected_unit)
    {
        this.exchange_ticket_id = exchange_ticket_id;
        this.selected_unit = selected_unit;
    }

    public ExchangeSelectUnitRequest() { }
}

[MessagePackObject(true)]
public class ExHunterEventEntryRequest
{
    public int event_id { get; set; }

    public ExHunterEventEntryRequest(int event_id)
    {
        this.event_id = event_id;
    }

    public ExHunterEventEntryRequest() { }
}

[MessagePackObject(true)]
public class ExHunterEventGetEventDataRequest
{
    public int event_id { get; set; }

    public ExHunterEventGetEventDataRequest(int event_id)
    {
        this.event_id = event_id;
    }

    public ExHunterEventGetEventDataRequest() { }
}

[MessagePackObject(true)]
public class ExHunterEventReceiveExHunterPointRewardRequest
{
    public int event_id { get; set; }
    public IEnumerable<int> ex_hunter_event_reward_id_list { get; set; }

    public ExHunterEventReceiveExHunterPointRewardRequest(
        int event_id,
        IEnumerable<int> ex_hunter_event_reward_id_list
    )
    {
        this.event_id = event_id;
        this.ex_hunter_event_reward_id_list = ex_hunter_event_reward_id_list;
    }

    public ExHunterEventReceiveExHunterPointRewardRequest() { }
}

[MessagePackObject(true)]
public class ExRushEventEntryRequest
{
    public int event_id { get; set; }

    public ExRushEventEntryRequest(int event_id)
    {
        this.event_id = event_id;
    }

    public ExRushEventEntryRequest() { }
}

[MessagePackObject(true)]
public class ExRushEventGetEventDataRequest
{
    public int event_id { get; set; }

    public ExRushEventGetEventDataRequest(int event_id)
    {
        this.event_id = event_id;
    }

    public ExRushEventGetEventDataRequest() { }
}

[MessagePackObject(true)]
public class FortAddCarpenterRequest
{
    public int payment_type { get; set; }

    public FortAddCarpenterRequest(int payment_type)
    {
        this.payment_type = payment_type;
    }

    public FortAddCarpenterRequest() { }
}

[MessagePackObject(true)]
public class FortBuildAtOnceRequest
{
    public ulong build_id { get; set; }
    public int payment_type { get; set; }

    public FortBuildAtOnceRequest(ulong build_id, int payment_type)
    {
        this.build_id = build_id;
        this.payment_type = payment_type;
    }

    public FortBuildAtOnceRequest() { }
}

[MessagePackObject(true)]
public class FortBuildCancelRequest
{
    public ulong build_id { get; set; }

    public FortBuildCancelRequest(ulong build_id)
    {
        this.build_id = build_id;
    }

    public FortBuildCancelRequest() { }
}

[MessagePackObject(true)]
public class FortBuildEndRequest
{
    public ulong build_id { get; set; }

    public FortBuildEndRequest(ulong build_id)
    {
        this.build_id = build_id;
    }

    public FortBuildEndRequest() { }
}

[MessagePackObject(true)]
public class FortBuildStartRequest
{
    public int fort_plant_id { get; set; }
    public int position_x { get; set; }
    public int position_z { get; set; }

    public FortBuildStartRequest(int fort_plant_id, int position_x, int position_z)
    {
        this.fort_plant_id = fort_plant_id;
        this.position_x = position_x;
        this.position_z = position_z;
    }

    public FortBuildStartRequest() { }
}

[MessagePackObject(true)]
public class FortGetDataRequest { }

[MessagePackObject(true)]
public class FortGetMultiIncomeRequest
{
    public IEnumerable<ulong> build_id_list { get; set; }

    public FortGetMultiIncomeRequest(IEnumerable<ulong> build_id_list)
    {
        this.build_id_list = build_id_list;
    }

    public FortGetMultiIncomeRequest() { }
}

[MessagePackObject(true)]
public class FortLevelupAtOnceRequest
{
    public ulong build_id { get; set; }
    public int payment_type { get; set; }

    public FortLevelupAtOnceRequest(ulong build_id, int payment_type)
    {
        this.build_id = build_id;
        this.payment_type = payment_type;
    }

    public FortLevelupAtOnceRequest() { }
}

[MessagePackObject(true)]
public class FortLevelupCancelRequest
{
    public ulong build_id { get; set; }

    public FortLevelupCancelRequest(ulong build_id)
    {
        this.build_id = build_id;
    }

    public FortLevelupCancelRequest() { }
}

[MessagePackObject(true)]
public class FortLevelupEndRequest
{
    public ulong build_id { get; set; }

    public FortLevelupEndRequest(ulong build_id)
    {
        this.build_id = build_id;
    }

    public FortLevelupEndRequest() { }
}

[MessagePackObject(true)]
public class FortLevelupStartRequest
{
    public ulong build_id { get; set; }

    public FortLevelupStartRequest(ulong build_id)
    {
        this.build_id = build_id;
    }

    public FortLevelupStartRequest() { }
}

[MessagePackObject(true)]
public class FortMoveRequest
{
    public ulong build_id { get; set; }
    public int after_position_x { get; set; }
    public int after_position_z { get; set; }

    public FortMoveRequest(ulong build_id, int after_position_x, int after_position_z)
    {
        this.build_id = build_id;
        this.after_position_x = after_position_x;
        this.after_position_z = after_position_z;
    }

    public FortMoveRequest() { }
}

[MessagePackObject(true)]
public class FortSetNewFortPlantRequest
{
    public IEnumerable<int> fort_plant_id_list { get; set; }

    public FortSetNewFortPlantRequest(IEnumerable<int> fort_plant_id_list)
    {
        this.fort_plant_id_list = fort_plant_id_list;
    }

    public FortSetNewFortPlantRequest() { }
}

[MessagePackObject(true)]
public class FriendAllReplyDenyRequest { }

[MessagePackObject(true)]
public class FriendApplyListRequest { }

[MessagePackObject(true)]
public class FriendAutoSearchRequest { }

[MessagePackObject(true)]
public class FriendDeleteRequest
{
    public ulong friend_id { get; set; }

    public FriendDeleteRequest(ulong friend_id)
    {
        this.friend_id = friend_id;
    }

    public FriendDeleteRequest() { }
}

[MessagePackObject(true)]
public class FriendFriendIndexRequest { }

[MessagePackObject(true)]
public class FriendFriendListRequest { }

[MessagePackObject(true)]
public class FriendGetSupportCharaDetailRequest
{
    public ulong support_viewer_id { get; set; }

    public FriendGetSupportCharaDetailRequest(ulong support_viewer_id)
    {
        this.support_viewer_id = support_viewer_id;
    }

    public FriendGetSupportCharaDetailRequest() { }
}

[MessagePackObject(true)]
public class FriendGetSupportCharaRequest { }

[MessagePackObject(true)]
public class FriendIdSearchRequest
{
    public ulong search_id { get; set; }

    public FriendIdSearchRequest(ulong search_id)
    {
        this.search_id = search_id;
    }

    public FriendIdSearchRequest() { }
}

[MessagePackObject(true)]
public class FriendReplyRequest
{
    public ulong friend_id { get; set; }
    public int reply { get; set; }

    public FriendReplyRequest(ulong friend_id, int reply)
    {
        this.friend_id = friend_id;
        this.reply = reply;
    }

    public FriendReplyRequest() { }
}

[MessagePackObject(true)]
public class FriendRequestCancelRequest
{
    public ulong friend_id { get; set; }

    public FriendRequestCancelRequest(ulong friend_id)
    {
        this.friend_id = friend_id;
    }

    public FriendRequestCancelRequest() { }
}

[MessagePackObject(true)]
public class FriendRequestListRequest { }

[MessagePackObject(true)]
public class FriendRequestRequest
{
    public ulong friend_id { get; set; }

    public FriendRequestRequest(ulong friend_id)
    {
        this.friend_id = friend_id;
    }

    public FriendRequestRequest() { }
}

[MessagePackObject(true)]
public class FriendSetSupportCharaRequest
{
    public Charas chara_id { get; set; }
    public ulong dragon_key_id { get; set; }
    public ulong weapon_key_id { get; set; }
    public ulong amulet_key_id { get; set; }
    public ulong amulet_2_key_id { get; set; }
    public int weapon_body_id { get; set; }
    public int crest_slot_type_1_crest_id_1 { get; set; }
    public int crest_slot_type_1_crest_id_2 { get; set; }
    public int crest_slot_type_1_crest_id_3 { get; set; }
    public int crest_slot_type_2_crest_id_1 { get; set; }
    public int crest_slot_type_2_crest_id_2 { get; set; }
    public int crest_slot_type_3_crest_id_1 { get; set; }
    public int crest_slot_type_3_crest_id_2 { get; set; }
    public ulong talisman_key_id { get; set; }

    public FriendSetSupportCharaRequest(
        Charas chara_id,
        ulong dragon_key_id,
        ulong weapon_key_id,
        ulong amulet_key_id,
        ulong amulet_2_key_id,
        int weapon_body_id,
        int crest_slot_type_1_crest_id_1,
        int crest_slot_type_1_crest_id_2,
        int crest_slot_type_1_crest_id_3,
        int crest_slot_type_2_crest_id_1,
        int crest_slot_type_2_crest_id_2,
        int crest_slot_type_3_crest_id_1,
        int crest_slot_type_3_crest_id_2,
        ulong talisman_key_id
    )
    {
        this.chara_id = chara_id;
        this.dragon_key_id = dragon_key_id;
        this.weapon_key_id = weapon_key_id;
        this.amulet_key_id = amulet_key_id;
        this.amulet_2_key_id = amulet_2_key_id;
        this.weapon_body_id = weapon_body_id;
        this.crest_slot_type_1_crest_id_1 = crest_slot_type_1_crest_id_1;
        this.crest_slot_type_1_crest_id_2 = crest_slot_type_1_crest_id_2;
        this.crest_slot_type_1_crest_id_3 = crest_slot_type_1_crest_id_3;
        this.crest_slot_type_2_crest_id_1 = crest_slot_type_2_crest_id_1;
        this.crest_slot_type_2_crest_id_2 = crest_slot_type_2_crest_id_2;
        this.crest_slot_type_3_crest_id_1 = crest_slot_type_3_crest_id_1;
        this.crest_slot_type_3_crest_id_2 = crest_slot_type_3_crest_id_2;
        this.talisman_key_id = talisman_key_id;
    }

    public FriendSetSupportCharaRequest() { }
}

[MessagePackObject(true)]
public class GuildChatGetNewMessageListRequest
{
    public int guild_id { get; set; }
    public ulong chat_message_id { get; set; }

    public GuildChatGetNewMessageListRequest(int guild_id, ulong chat_message_id)
    {
        this.guild_id = guild_id;
        this.chat_message_id = chat_message_id;
    }

    public GuildChatGetNewMessageListRequest() { }
}

[MessagePackObject(true)]
public class GuildChatGetOldMessageListRequest
{
    public int guild_id { get; set; }
    public ulong chat_message_id { get; set; }

    public GuildChatGetOldMessageListRequest(int guild_id, ulong chat_message_id)
    {
        this.guild_id = guild_id;
        this.chat_message_id = chat_message_id;
    }

    public GuildChatGetOldMessageListRequest() { }
}

[MessagePackObject(true)]
public class GuildChatPostMessageStampRequest
{
    public int guild_id { get; set; }
    public ulong chat_message_id { get; set; }
    public int chat_message_stamp_id { get; set; }

    public GuildChatPostMessageStampRequest(
        int guild_id,
        ulong chat_message_id,
        int chat_message_stamp_id
    )
    {
        this.guild_id = guild_id;
        this.chat_message_id = chat_message_id;
        this.chat_message_stamp_id = chat_message_stamp_id;
    }

    public GuildChatPostMessageStampRequest() { }
}

[MessagePackObject(true)]
public class GuildChatPostMessageTextRequest
{
    public int guild_id { get; set; }
    public ulong chat_message_id { get; set; }
    public string chat_message_text { get; set; }

    public GuildChatPostMessageTextRequest(
        int guild_id,
        ulong chat_message_id,
        string chat_message_text
    )
    {
        this.guild_id = guild_id;
        this.chat_message_id = chat_message_id;
        this.chat_message_text = chat_message_text;
    }

    public GuildChatPostMessageTextRequest() { }
}

[MessagePackObject(true)]
public class GuildChatPostReportRequest
{
    public int guild_id { get; set; }
    public ulong chat_message_id { get; set; }
    public int report_category_id { get; set; }
    public string message { get; set; }

    public GuildChatPostReportRequest(
        int guild_id,
        ulong chat_message_id,
        int report_category_id,
        string message
    )
    {
        this.guild_id = guild_id;
        this.chat_message_id = chat_message_id;
        this.report_category_id = report_category_id;
        this.message = message;
    }

    public GuildChatPostReportRequest() { }
}

[MessagePackObject(true)]
public class GuildDisbandRequest
{
    public int guild_id { get; set; }

    public GuildDisbandRequest(int guild_id)
    {
        this.guild_id = guild_id;
    }

    public GuildDisbandRequest() { }
}

[MessagePackObject(true)]
public class GuildDropMemberRequest
{
    public int guild_id { get; set; }
    public ulong target_viewer_id { get; set; }

    public GuildDropMemberRequest(int guild_id, ulong target_viewer_id)
    {
        this.guild_id = guild_id;
        this.target_viewer_id = target_viewer_id;
    }

    public GuildDropMemberRequest() { }
}

[MessagePackObject(true)]
public class GuildEstablishRequest
{
    public string guild_name { get; set; }
    public int guild_emblem_id { get; set; }
    public int joining_condition_type { get; set; }
    public int activity_policy_type { get; set; }
    public string guild_introduction { get; set; }
    public string guild_board { get; set; }

    public GuildEstablishRequest(
        string guild_name,
        int guild_emblem_id,
        int joining_condition_type,
        int activity_policy_type,
        string guild_introduction,
        string guild_board
    )
    {
        this.guild_name = guild_name;
        this.guild_emblem_id = guild_emblem_id;
        this.joining_condition_type = joining_condition_type;
        this.activity_policy_type = activity_policy_type;
        this.guild_introduction = guild_introduction;
        this.guild_board = guild_board;
    }

    public GuildEstablishRequest() { }
}

[MessagePackObject(true)]
public class GuildGetGuildApplyDataRequest
{
    public int guild_id { get; set; }

    public GuildGetGuildApplyDataRequest(int guild_id)
    {
        this.guild_id = guild_id;
    }

    public GuildGetGuildApplyDataRequest() { }
}

[MessagePackObject(true)]
public class GuildGetGuildMemberDataRequest
{
    public int guild_id { get; set; }

    public GuildGetGuildMemberDataRequest(int guild_id)
    {
        this.guild_id = guild_id;
    }

    public GuildGetGuildMemberDataRequest() { }
}

[MessagePackObject(true)]
public class GuildIndexRequest { }

[MessagePackObject(true)]
public class GuildInviteGetGuildInviteReceiveDataRequest { }

[MessagePackObject(true)]
public class GuildInviteGetGuildInviteSendDataRequest
{
    public int guild_id { get; set; }

    public GuildInviteGetGuildInviteSendDataRequest(int guild_id)
    {
        this.guild_id = guild_id;
    }

    public GuildInviteGetGuildInviteSendDataRequest() { }
}

[MessagePackObject(true)]
public class GuildInviteInviteCancelRequest
{
    public int guild_id { get; set; }
    public ulong guild_invite_id { get; set; }

    public GuildInviteInviteCancelRequest(int guild_id, ulong guild_invite_id)
    {
        this.guild_id = guild_id;
        this.guild_invite_id = guild_invite_id;
    }

    public GuildInviteInviteCancelRequest() { }
}

[MessagePackObject(true)]
public class GuildInviteInviteReplyAllDenyRequest
{
    public IEnumerable<AtgenGuildInviteParamsList> guild_invite_params_list { get; set; }

    public GuildInviteInviteReplyAllDenyRequest(
        IEnumerable<AtgenGuildInviteParamsList> guild_invite_params_list
    )
    {
        this.guild_invite_params_list = guild_invite_params_list;
    }

    public GuildInviteInviteReplyAllDenyRequest() { }
}

[MessagePackObject(true)]
public class GuildInviteInviteReplyRequest
{
    public int guild_id { get; set; }
    public ulong guild_invite_id { get; set; }
    public int reply_status { get; set; }

    public GuildInviteInviteReplyRequest(int guild_id, ulong guild_invite_id, int reply_status)
    {
        this.guild_id = guild_id;
        this.guild_invite_id = guild_invite_id;
        this.reply_status = reply_status;
    }

    public GuildInviteInviteReplyRequest() { }
}

[MessagePackObject(true)]
public class GuildInviteInviteSendRequest
{
    public ulong target_viewer_id { get; set; }
    public int guild_id { get; set; }
    public int guild_invite_message_id { get; set; }

    public GuildInviteInviteSendRequest(
        ulong target_viewer_id,
        int guild_id,
        int guild_invite_message_id
    )
    {
        this.target_viewer_id = target_viewer_id;
        this.guild_id = guild_id;
        this.guild_invite_message_id = guild_invite_message_id;
    }

    public GuildInviteInviteSendRequest() { }
}

[MessagePackObject(true)]
public class GuildJoinReplyAllDenyRequest
{
    public int guild_id { get; set; }
    public IEnumerable<ulong> guild_apply_id_list { get; set; }

    public GuildJoinReplyAllDenyRequest(int guild_id, IEnumerable<ulong> guild_apply_id_list)
    {
        this.guild_id = guild_id;
        this.guild_apply_id_list = guild_apply_id_list;
    }

    public GuildJoinReplyAllDenyRequest() { }
}

[MessagePackObject(true)]
public class GuildJoinReplyRequest
{
    public int guild_id { get; set; }
    public ulong guild_apply_id { get; set; }
    public int reply_status { get; set; }

    public GuildJoinReplyRequest(int guild_id, ulong guild_apply_id, int reply_status)
    {
        this.guild_id = guild_id;
        this.guild_apply_id = guild_apply_id;
        this.reply_status = reply_status;
    }

    public GuildJoinReplyRequest() { }
}

[MessagePackObject(true)]
public class GuildJoinRequest
{
    public int guild_id { get; set; }

    public GuildJoinRequest(int guild_id)
    {
        this.guild_id = guild_id;
    }

    public GuildJoinRequest() { }
}

[MessagePackObject(true)]
public class GuildJoinRequestCancelRequest
{
    public int guild_id { get; set; }

    public GuildJoinRequestCancelRequest(int guild_id)
    {
        this.guild_id = guild_id;
    }

    public GuildJoinRequestCancelRequest() { }
}

[MessagePackObject(true)]
public class GuildJoinRequestRequest
{
    public int guild_id { get; set; }

    public GuildJoinRequestRequest(int guild_id)
    {
        this.guild_id = guild_id;
    }

    public GuildJoinRequestRequest() { }
}

[MessagePackObject(true)]
public class GuildPostReportRequest
{
    public int guild_id { get; set; }
    public int report_type { get; set; }
    public string report_data { get; set; }
    public int report_category_id { get; set; }
    public string message { get; set; }

    public GuildPostReportRequest(
        int guild_id,
        int report_type,
        string report_data,
        int report_category_id,
        string message
    )
    {
        this.guild_id = guild_id;
        this.report_type = report_type;
        this.report_data = report_data;
        this.report_category_id = report_category_id;
        this.message = message;
    }

    public GuildPostReportRequest() { }
}

[MessagePackObject(true)]
public class GuildResignRequest
{
    public int guild_id { get; set; }
    public int is_temporary_member { get; set; }

    public GuildResignRequest(int guild_id, int is_temporary_member)
    {
        this.guild_id = guild_id;
        this.is_temporary_member = is_temporary_member;
    }

    public GuildResignRequest() { }
}

[MessagePackObject(true)]
public class GuildSearchAutoSearchRequest
{
    public IEnumerable<int> joining_condition_type_list { get; set; }
    public IEnumerable<int> activity_policy_type_list { get; set; }
    public IEnumerable<int> member_count_type_list { get; set; }

    public GuildSearchAutoSearchRequest(
        IEnumerable<int> joining_condition_type_list,
        IEnumerable<int> activity_policy_type_list,
        IEnumerable<int> member_count_type_list
    )
    {
        this.joining_condition_type_list = joining_condition_type_list;
        this.activity_policy_type_list = activity_policy_type_list;
        this.member_count_type_list = member_count_type_list;
    }

    public GuildSearchAutoSearchRequest() { }
}

[MessagePackObject(true)]
public class GuildSearchGetGuildDetailRequest
{
    public int guild_id { get; set; }

    public GuildSearchGetGuildDetailRequest(int guild_id)
    {
        this.guild_id = guild_id;
    }

    public GuildSearchGetGuildDetailRequest() { }
}

[MessagePackObject(true)]
public class GuildSearchIdSearchRequest
{
    public int guild_id { get; set; }

    public GuildSearchIdSearchRequest(int guild_id)
    {
        this.guild_id = guild_id;
    }

    public GuildSearchIdSearchRequest() { }
}

[MessagePackObject(true)]
public class GuildSearchNameSearchRequest
{
    public string guild_name { get; set; }

    public GuildSearchNameSearchRequest(string guild_name)
    {
        this.guild_name = guild_name;
    }

    public GuildSearchNameSearchRequest() { }
}

[MessagePackObject(true)]
public class GuildUpdateGuildPositionTypeRequest
{
    public int guild_id { get; set; }
    public ulong target_viewer_id { get; set; }
    public int guild_position_type { get; set; }

    public GuildUpdateGuildPositionTypeRequest(
        int guild_id,
        ulong target_viewer_id,
        int guild_position_type
    )
    {
        this.guild_id = guild_id;
        this.target_viewer_id = target_viewer_id;
        this.guild_position_type = guild_position_type;
    }

    public GuildUpdateGuildPositionTypeRequest() { }
}

[MessagePackObject(true)]
public class GuildUpdateGuildSettingRequest
{
    public int guild_id { get; set; }
    public string guild_name { get; set; }
    public int guild_emblem_id { get; set; }
    public string guild_introduction { get; set; }
    public string guild_board { get; set; }
    public int joining_condition_type { get; set; }
    public int activity_policy_type { get; set; }

    public GuildUpdateGuildSettingRequest(
        int guild_id,
        string guild_name,
        int guild_emblem_id,
        string guild_introduction,
        string guild_board,
        int joining_condition_type,
        int activity_policy_type
    )
    {
        this.guild_id = guild_id;
        this.guild_name = guild_name;
        this.guild_emblem_id = guild_emblem_id;
        this.guild_introduction = guild_introduction;
        this.guild_board = guild_board;
        this.joining_condition_type = joining_condition_type;
        this.activity_policy_type = activity_policy_type;
    }

    public GuildUpdateGuildSettingRequest() { }
}

[MessagePackObject(true)]
public class GuildUpdateUserSettingRequest
{
    public int profile_entity_type { get; set; }
    public int profile_entity_id { get; set; }
    public int profile_entity_rarity { get; set; }
    public int guild_push_notification_type_running { get; set; }
    public int guild_push_notification_type_suspending { get; set; }
    public int is_enable_invite_receive { get; set; }

    public GuildUpdateUserSettingRequest(
        int profile_entity_type,
        int profile_entity_id,
        int profile_entity_rarity,
        int guild_push_notification_type_running,
        int guild_push_notification_type_suspending,
        int is_enable_invite_receive
    )
    {
        this.profile_entity_type = profile_entity_type;
        this.profile_entity_id = profile_entity_id;
        this.profile_entity_rarity = profile_entity_rarity;
        this.guild_push_notification_type_running = guild_push_notification_type_running;
        this.guild_push_notification_type_suspending = guild_push_notification_type_suspending;
        this.is_enable_invite_receive = is_enable_invite_receive;
    }

    public GuildUpdateUserSettingRequest() { }
}

[MessagePackObject(true)]
public class InquiryAggregationRequest
{
    public string language_code { get; set; }
    public int inquiry_faq_id { get; set; }

    public InquiryAggregationRequest(string language_code, int inquiry_faq_id)
    {
        this.language_code = language_code;
        this.inquiry_faq_id = inquiry_faq_id;
    }

    public InquiryAggregationRequest() { }
}

[MessagePackObject(true)]
public class InquiryDetailRequest
{
    public string opinion_id { get; set; }
    public string language_code { get; set; }

    public InquiryDetailRequest(string opinion_id, string language_code)
    {
        this.opinion_id = opinion_id;
        this.language_code = language_code;
    }

    public InquiryDetailRequest() { }
}

[MessagePackObject(true)]
public class InquiryReplyRequest
{
    public string opinion_id { get; set; }
    public string comment_text { get; set; }

    public InquiryReplyRequest(string opinion_id, string comment_text)
    {
        this.opinion_id = opinion_id;
        this.comment_text = comment_text;
    }

    public InquiryReplyRequest() { }
}

[MessagePackObject(true)]
public class InquirySendRequest
{
    public string opinion_text { get; set; }
    public int opinion_type { get; set; }
    public string language_code { get; set; }
    public string region_code { get; set; }
    public int occurred_at { get; set; }

    public InquirySendRequest(
        string opinion_text,
        int opinion_type,
        string language_code,
        string region_code,
        int occurred_at
    )
    {
        this.opinion_text = opinion_text;
        this.opinion_type = opinion_type;
        this.language_code = language_code;
        this.region_code = region_code;
        this.occurred_at = occurred_at;
    }

    public InquirySendRequest() { }
}

[MessagePackObject(true)]
public class InquiryTopRequest
{
    public string language_code { get; set; }

    public InquiryTopRequest(string language_code)
    {
        this.language_code = language_code;
    }

    public InquiryTopRequest() { }
}

[MessagePackObject(true)]
public class ItemGetListRequest { }

[MessagePackObject(true)]
public class ItemUseRecoveryStaminaRequest
{
    public IEnumerable<AtgenUseItemList> use_item_list { get; set; }

    public ItemUseRecoveryStaminaRequest(IEnumerable<AtgenUseItemList> use_item_list)
    {
        this.use_item_list = use_item_list;
    }

    public ItemUseRecoveryStaminaRequest() { }
}

[MessagePackObject(true)]
public class LoadIndexRequest { }

[MessagePackObject(true)]
public class LoginIndexRequest
{
    public string jws_result { get; set; }

    public LoginIndexRequest(string jws_result)
    {
        this.jws_result = jws_result;
    }

    public LoginIndexRequest() { }
}

[MessagePackObject(true)]
public class LoginPenaltyConfirmRequest
{
    public int penalty_type { get; set; }
    public int report_id { get; set; }

    public LoginPenaltyConfirmRequest(int penalty_type, int report_id)
    {
        this.penalty_type = penalty_type;
        this.report_id = report_id;
    }

    public LoginPenaltyConfirmRequest() { }
}

[MessagePackObject(true)]
public class LoginVerifyJwsRequest
{
    public string jws_result { get; set; }

    public LoginVerifyJwsRequest(string jws_result)
    {
        this.jws_result = jws_result;
    }

    public LoginVerifyJwsRequest() { }
}

[MessagePackObject(true)]
public class LotteryGetOddsDataRequest
{
    public int lottery_id { get; set; }

    public LotteryGetOddsDataRequest(int lottery_id)
    {
        this.lottery_id = lottery_id;
    }

    public LotteryGetOddsDataRequest() { }
}

[MessagePackObject(true)]
public class LotteryLotteryExecRequest
{
    public int lottery_id { get; set; }

    public LotteryLotteryExecRequest(int lottery_id)
    {
        this.lottery_id = lottery_id;
    }

    public LotteryLotteryExecRequest() { }
}

[MessagePackObject(true)]
public class LotteryResultRequest
{
    public int lottery_id { get; set; }

    public LotteryResultRequest(int lottery_id)
    {
        this.lottery_id = lottery_id;
    }

    public LotteryResultRequest() { }
}

[MessagePackObject(true)]
public class MaintenanceGetTextRequest
{
    public int type { get; set; }
    public string lang { get; set; }

    public MaintenanceGetTextRequest(int type, string lang)
    {
        this.type = type;
        this.lang = lang;
    }

    public MaintenanceGetTextRequest() { }
}

[MessagePackObject(true)]
public class MatchingCheckPenaltyUserRequest
{
    public ulong viewwer_id { get; set; }

    public MatchingCheckPenaltyUserRequest(ulong viewwer_id)
    {
        this.viewwer_id = viewwer_id;
    }

    public MatchingCheckPenaltyUserRequest() { }
}

[MessagePackObject(true)]
public class MatchingGetRoomListByGuildRequest
{
    public int compatible_id { get; set; }

    public MatchingGetRoomListByGuildRequest(int compatible_id)
    {
        this.compatible_id = compatible_id;
    }

    public MatchingGetRoomListByGuildRequest() { }
}

[MessagePackObject(true)]
public class MatchingGetRoomListByLocationRequest
{
    public string region { get; set; }
    public int quest_type { get; set; }
    public float latitude { get; set; }
    public float longitude { get; set; }
    public int compatible_id { get; set; }

    public MatchingGetRoomListByLocationRequest(
        string region,
        int quest_type,
        float latitude,
        float longitude,
        int compatible_id
    )
    {
        this.region = region;
        this.quest_type = quest_type;
        this.latitude = latitude;
        this.longitude = longitude;
        this.compatible_id = compatible_id;
    }

    public MatchingGetRoomListByLocationRequest() { }
}

[MessagePackObject(true)]
public class MatchingGetRoomListByQuestIdRequest
{
    public string region { get; set; }
    public int quest_id { get; set; }
    public int compatible_id { get; set; }

    public MatchingGetRoomListByQuestIdRequest(string region, int quest_id, int compatible_id)
    {
        this.region = region;
        this.quest_id = quest_id;
        this.compatible_id = compatible_id;
    }

    public MatchingGetRoomListByQuestIdRequest() { }
}

[MessagePackObject(true)]
public class MatchingGetRoomListRequest
{
    public string region { get; set; }
    public int tab_type { get; set; }
    public int compatible_id { get; set; }

    public MatchingGetRoomListRequest(string region, int tab_type, int compatible_id)
    {
        this.region = region;
        this.tab_type = tab_type;
        this.compatible_id = compatible_id;
    }

    public MatchingGetRoomListRequest() { }
}

[MessagePackObject(true)]
public class MatchingGetRoomNameRequest
{
    public int room_id { get; set; }

    public MatchingGetRoomNameRequest(int room_id)
    {
        this.room_id = room_id;
    }

    public MatchingGetRoomNameRequest() { }
}

[MessagePackObject(true)]
public class MazeEventEntryRequest
{
    public int event_id { get; set; }

    public MazeEventEntryRequest(int event_id)
    {
        this.event_id = event_id;
    }

    public MazeEventEntryRequest() { }
}

[MessagePackObject(true)]
public class MazeEventGetEventDataRequest
{
    public int event_id { get; set; }

    public MazeEventGetEventDataRequest(int event_id)
    {
        this.event_id = event_id;
    }

    public MazeEventGetEventDataRequest() { }
}

[MessagePackObject(true)]
public class MazeEventReceiveMazePointRewardRequest
{
    public int event_id { get; set; }

    public MazeEventReceiveMazePointRewardRequest(int event_id)
    {
        this.event_id = event_id;
    }

    public MazeEventReceiveMazePointRewardRequest() { }
}

[MessagePackObject(true)]
public class MemoryEventActivateRequest
{
    public int event_id { get; set; }

    public MemoryEventActivateRequest(int event_id)
    {
        this.event_id = event_id;
    }

    public MemoryEventActivateRequest() { }
}

[MessagePackObject(true)]
public class MissionGetDrillMissionListRequest { }

[MessagePackObject(true)]
public class MissionGetMissionListRequest { }

[MessagePackObject(true)]
public class MissionReceiveAlbumRewardRequest
{
    public IEnumerable<int> album_mission_id_list { get; set; }

    public MissionReceiveAlbumRewardRequest(IEnumerable<int> album_mission_id_list)
    {
        this.album_mission_id_list = album_mission_id_list;
    }

    public MissionReceiveAlbumRewardRequest() { }
}

[MessagePackObject(true)]
public class MissionReceiveBeginnerRewardRequest
{
    public IEnumerable<int> beginner_mission_id_list { get; set; }

    public MissionReceiveBeginnerRewardRequest(IEnumerable<int> beginner_mission_id_list)
    {
        this.beginner_mission_id_list = beginner_mission_id_list;
    }

    public MissionReceiveBeginnerRewardRequest() { }
}

[MessagePackObject(true)]
public class MissionReceiveDailyRewardRequest
{
    public IEnumerable<AtgenMissionParamsList> mission_params_list { get; set; }

    public MissionReceiveDailyRewardRequest(IEnumerable<AtgenMissionParamsList> mission_params_list)
    {
        this.mission_params_list = mission_params_list;
    }

    public MissionReceiveDailyRewardRequest() { }
}

[MessagePackObject(true)]
public class MissionReceiveDrillRewardRequest
{
    public IEnumerable<int> drill_mission_id_list { get; set; }
    public IEnumerable<int> drill_mission_group_id_list { get; set; }

    public MissionReceiveDrillRewardRequest(
        IEnumerable<int> drill_mission_id_list,
        IEnumerable<int> drill_mission_group_id_list
    )
    {
        this.drill_mission_id_list = drill_mission_id_list;
        this.drill_mission_group_id_list = drill_mission_group_id_list;
    }

    public MissionReceiveDrillRewardRequest() { }
}

[MessagePackObject(true)]
public class MissionReceiveMainStoryRewardRequest
{
    public IEnumerable<int> main_story_mission_id_list { get; set; }

    public MissionReceiveMainStoryRewardRequest(IEnumerable<int> main_story_mission_id_list)
    {
        this.main_story_mission_id_list = main_story_mission_id_list;
    }

    public MissionReceiveMainStoryRewardRequest() { }
}

[MessagePackObject(true)]
public class MissionReceiveMemoryEventRewardRequest
{
    public IEnumerable<int> memory_event_mission_id_list { get; set; }

    public MissionReceiveMemoryEventRewardRequest(IEnumerable<int> memory_event_mission_id_list)
    {
        this.memory_event_mission_id_list = memory_event_mission_id_list;
    }

    public MissionReceiveMemoryEventRewardRequest() { }
}

[MessagePackObject(true)]
public class MissionReceiveNormalRewardRequest
{
    public IEnumerable<int> normal_mission_id_list { get; set; }

    public MissionReceiveNormalRewardRequest(IEnumerable<int> normal_mission_id_list)
    {
        this.normal_mission_id_list = normal_mission_id_list;
    }

    public MissionReceiveNormalRewardRequest() { }
}

[MessagePackObject(true)]
public class MissionReceivePeriodRewardRequest
{
    public IEnumerable<int> period_mission_id_list { get; set; }

    public MissionReceivePeriodRewardRequest(IEnumerable<int> period_mission_id_list)
    {
        this.period_mission_id_list = period_mission_id_list;
    }

    public MissionReceivePeriodRewardRequest() { }
}

[MessagePackObject(true)]
public class MissionReceiveSpecialRewardRequest
{
    public IEnumerable<int> special_mission_id_list { get; set; }

    public MissionReceiveSpecialRewardRequest(IEnumerable<int> special_mission_id_list)
    {
        this.special_mission_id_list = special_mission_id_list;
    }

    public MissionReceiveSpecialRewardRequest() { }
}

[MessagePackObject(true)]
public class MissionUnlockDrillMissionGroupRequest
{
    public int drill_mission_group_id { get; set; }

    public MissionUnlockDrillMissionGroupRequest(int drill_mission_group_id)
    {
        this.drill_mission_group_id = drill_mission_group_id;
    }

    public MissionUnlockDrillMissionGroupRequest() { }
}

[MessagePackObject(true)]
public class MissionUnlockMainStoryGroupRequest
{
    public int main_story_mission_group_id { get; set; }

    public MissionUnlockMainStoryGroupRequest(int main_story_mission_group_id)
    {
        this.main_story_mission_group_id = main_story_mission_group_id;
    }

    public MissionUnlockMainStoryGroupRequest() { }
}

[MessagePackObject(true)]
public class MypageInfoRequest { }

[MessagePackObject(true)]
public class OptionGetOptionRequest { }

[MessagePackObject(true)]
public class OptionSetOptionRequest
{
    public OptionData option_setting { get; set; }

    public OptionSetOptionRequest(OptionData option_setting)
    {
        this.option_setting = option_setting;
    }

    public OptionSetOptionRequest() { }
}

[MessagePackObject(true)]
public class PartyIndexRequest { }

[MessagePackObject(true)]
public class PartySetMainPartyNoRequest
{
    public int main_party_no { get; set; }

    public PartySetMainPartyNoRequest(int main_party_no)
    {
        this.main_party_no = main_party_no;
    }

    public PartySetMainPartyNoRequest() { }
}

[MessagePackObject(true)]
public class PartySetPartySettingRequest
{
    public int party_no { get; set; }
    public IEnumerable<PartySettingList> request_party_setting_list { get; set; }

    [MaxLength(20)]
    public string party_name { get; set; }
    public int is_entrust { get; set; }
    public int entrust_element { get; set; }

    public PartySetPartySettingRequest(
        int party_no,
        IEnumerable<PartySettingList> request_party_setting_list,
        string party_name,
        int is_entrust,
        int entrust_element
    )
    {
        this.party_no = party_no;
        this.request_party_setting_list = request_party_setting_list;
        this.party_name = party_name;
        this.is_entrust = is_entrust;
        this.entrust_element = entrust_element;
    }

    public PartySetPartySettingRequest() { }
}

[MessagePackObject(true)]
public class PartyUpdatePartyNameRequest
{
    public int party_no { get; set; }

    [MaxLength(20)]
    public string party_name { get; set; }

    public PartyUpdatePartyNameRequest(int party_no, string party_name)
    {
        this.party_no = party_no;
        this.party_name = party_name;
    }

    public PartyUpdatePartyNameRequest() { }
}

[MessagePackObject(true)]
public class PlatformAchievementGetPlatformAchievementListRequest { }

[MessagePackObject(true)]
public class PresentGetHistoryListRequest
{
    public ulong present_history_id { get; set; }

    public PresentGetHistoryListRequest(ulong present_history_id)
    {
        this.present_history_id = present_history_id;
    }

    public PresentGetHistoryListRequest() { }
}

[MessagePackObject(true)]
public class PresentGetPresentListRequest
{
    public int is_limit { get; set; }
    public ulong present_id { get; set; }

    public PresentGetPresentListRequest(int is_limit, ulong present_id)
    {
        this.is_limit = is_limit;
        this.present_id = present_id;
    }

    public PresentGetPresentListRequest() { }
}

[MessagePackObject(true)]
public class PresentReceiveRequest
{
    public IEnumerable<ulong> present_id_list { get; set; }
    public int is_limit { get; set; }

    public PresentReceiveRequest(IEnumerable<ulong> present_id_list, int is_limit)
    {
        this.present_id_list = present_id_list;
        this.is_limit = is_limit;
    }

    public PresentReceiveRequest() { }
}

[MessagePackObject(true)]
public class PushNotificationUpdateSettingRequest
{
    public string region { get; set; }
    public string lang { get; set; }
    public string uuid { get; set; }

    public PushNotificationUpdateSettingRequest(string region, string lang, string uuid)
    {
        this.region = region;
        this.lang = lang;
        this.uuid = uuid;
    }

    public PushNotificationUpdateSettingRequest() { }
}

[MessagePackObject(true)]
public class QuestDropListRequest
{
    public int quest_id { get; set; }

    public QuestDropListRequest(int quest_id)
    {
        this.quest_id = quest_id;
    }

    public QuestDropListRequest() { }
}

[MessagePackObject(true)]
public class QuestGetQuestClearPartyMultiRequest
{
    public int quest_id { get; set; }

    public QuestGetQuestClearPartyMultiRequest(int quest_id)
    {
        this.quest_id = quest_id;
    }

    public QuestGetQuestClearPartyMultiRequest() { }
}

[MessagePackObject(true)]
public class QuestGetQuestClearPartyRequest
{
    public int quest_id { get; set; }

    public QuestGetQuestClearPartyRequest(int quest_id)
    {
        this.quest_id = quest_id;
    }

    public QuestGetQuestClearPartyRequest() { }
}

[MessagePackObject(true)]
public class QuestGetSupportUserListRequest { }

[MessagePackObject(true)]
public class QuestOpenTreasureRequest
{
    public int quest_treasure_id { get; set; }

    public QuestOpenTreasureRequest(int quest_treasure_id)
    {
        this.quest_treasure_id = quest_treasure_id;
    }

    public QuestOpenTreasureRequest() { }
}

[MessagePackObject(true)]
public class QuestReadStoryRequest
{
    public int quest_story_id { get; set; }

    public QuestReadStoryRequest(int quest_story_id)
    {
        this.quest_story_id = quest_story_id;
    }

    public QuestReadStoryRequest() { }
}

[MessagePackObject(true)]
public class QuestSearchQuestClearPartyCharaMultiRequest
{
    public IEnumerable<int> quest_id_list { get; set; }

    public QuestSearchQuestClearPartyCharaMultiRequest(IEnumerable<int> quest_id_list)
    {
        this.quest_id_list = quest_id_list;
    }

    public QuestSearchQuestClearPartyCharaMultiRequest() { }
}

[MessagePackObject(true)]
public class QuestSearchQuestClearPartyCharaRequest
{
    public IEnumerable<int> quest_id_list { get; set; }

    public QuestSearchQuestClearPartyCharaRequest(IEnumerable<int> quest_id_list)
    {
        this.quest_id_list = quest_id_list;
    }

    public QuestSearchQuestClearPartyCharaRequest() { }
}

[MessagePackObject(true)]
public class QuestSearchQuestClearPartyMultiRequest
{
    public int quest_id { get; set; }
    public int party_switch_no { get; set; }
    public IEnumerable<int> chara_id_list { get; set; }
    public IEnumerable<int> dragon_id_list { get; set; }
    public IEnumerable<int> weapon_body_id_list { get; set; }
    public IEnumerable<int> ability_crest_id_list { get; set; }

    public QuestSearchQuestClearPartyMultiRequest(
        int quest_id,
        int party_switch_no,
        IEnumerable<int> chara_id_list,
        IEnumerable<int> dragon_id_list,
        IEnumerable<int> weapon_body_id_list,
        IEnumerable<int> ability_crest_id_list
    )
    {
        this.quest_id = quest_id;
        this.party_switch_no = party_switch_no;
        this.chara_id_list = chara_id_list;
        this.dragon_id_list = dragon_id_list;
        this.weapon_body_id_list = weapon_body_id_list;
        this.ability_crest_id_list = ability_crest_id_list;
    }

    public QuestSearchQuestClearPartyMultiRequest() { }
}

[MessagePackObject(true)]
public class QuestSearchQuestClearPartyRequest
{
    public int quest_id { get; set; }
    public int party_switch_no { get; set; }
    public IEnumerable<int> chara_id_list { get; set; }
    public IEnumerable<int> dragon_id_list { get; set; }
    public IEnumerable<int> weapon_body_id_list { get; set; }
    public IEnumerable<int> ability_crest_id_list { get; set; }

    public QuestSearchQuestClearPartyRequest(
        int quest_id,
        int party_switch_no,
        IEnumerable<int> chara_id_list,
        IEnumerable<int> dragon_id_list,
        IEnumerable<int> weapon_body_id_list,
        IEnumerable<int> ability_crest_id_list
    )
    {
        this.quest_id = quest_id;
        this.party_switch_no = party_switch_no;
        this.chara_id_list = chara_id_list;
        this.dragon_id_list = dragon_id_list;
        this.weapon_body_id_list = weapon_body_id_list;
        this.ability_crest_id_list = ability_crest_id_list;
    }

    public QuestSearchQuestClearPartyRequest() { }
}

[MessagePackObject(true)]
public class QuestSetQuestClearPartyMultiRequest
{
    public int quest_id { get; set; }
    public IEnumerable<PartySettingList> request_party_setting_list { get; set; }

    public QuestSetQuestClearPartyMultiRequest(
        int quest_id,
        IEnumerable<PartySettingList> request_party_setting_list
    )
    {
        this.quest_id = quest_id;
        this.request_party_setting_list = request_party_setting_list;
    }

    public QuestSetQuestClearPartyMultiRequest() { }
}

[MessagePackObject(true)]
public class QuestSetQuestClearPartyRequest
{
    public int quest_id { get; set; }
    public IEnumerable<PartySettingList> request_party_setting_list { get; set; }

    public QuestSetQuestClearPartyRequest(
        int quest_id,
        IEnumerable<PartySettingList> request_party_setting_list
    )
    {
        this.quest_id = quest_id;
        this.request_party_setting_list = request_party_setting_list;
    }

    public QuestSetQuestClearPartyRequest() { }
}

[MessagePackObject(true)]
public class RaidEventEntryRequest
{
    public int raid_event_id { get; set; }

    public RaidEventEntryRequest(int raid_event_id)
    {
        this.raid_event_id = raid_event_id;
    }

    public RaidEventEntryRequest() { }
}

[MessagePackObject(true)]
public class RaidEventGetEventDataRequest
{
    public int raid_event_id { get; set; }

    public RaidEventGetEventDataRequest(int raid_event_id)
    {
        this.raid_event_id = raid_event_id;
    }

    public RaidEventGetEventDataRequest() { }
}

[MessagePackObject(true)]
public class RaidEventReceiveRaidPointRewardRequest
{
    public int raid_event_id { get; set; }
    public IEnumerable<int> raid_event_reward_id_list { get; set; }

    public RaidEventReceiveRaidPointRewardRequest(
        int raid_event_id,
        IEnumerable<int> raid_event_reward_id_list
    )
    {
        this.raid_event_id = raid_event_id;
        this.raid_event_reward_id_list = raid_event_reward_id_list;
    }

    public RaidEventReceiveRaidPointRewardRequest() { }
}

[MessagePackObject(true)]
public class RedoableSummonFixExecRequest { }

[MessagePackObject(true)]
public class RedoableSummonGetDataRequest { }

[MessagePackObject(true)]
public class RedoableSummonPreExecRequest
{
    public int summon_id { get; set; }

    public RedoableSummonPreExecRequest(int summon_id)
    {
        this.summon_id = summon_id;
    }

    public RedoableSummonPreExecRequest() { }
}

[MessagePackObject(true)]
public class RepeatEndRequest { }

[MessagePackObject(true)]
public class ShopChargeCancelRequest
{
    public int shop_type { get; set; }
    public int goods_id { get; set; }

    public ShopChargeCancelRequest(int shop_type, int goods_id)
    {
        this.shop_type = shop_type;
        this.goods_id = goods_id;
    }

    public ShopChargeCancelRequest() { }
}

[MessagePackObject(true)]
public class ShopGetBonusRequest
{
    public int bonus_type { get; set; }

    public ShopGetBonusRequest(int bonus_type)
    {
        this.bonus_type = bonus_type;
    }

    public ShopGetBonusRequest() { }
}

[MessagePackObject(true)]
public class ShopGetDreamSelectUnitListRequest
{
    public int goods_id { get; set; }

    public ShopGetDreamSelectUnitListRequest(int goods_id)
    {
        this.goods_id = goods_id;
    }

    public ShopGetDreamSelectUnitListRequest() { }
}

[MessagePackObject(true)]
public class ShopGetListRequest { }

[MessagePackObject(true)]
public class ShopGetProductListRequest { }

[MessagePackObject(true)]
public class ShopItemSummonExecRequest
{
    public int payment_type { get; set; }
    public PaymentTarget payment_target { get; set; }

    public ShopItemSummonExecRequest(int payment_type, PaymentTarget payment_target)
    {
        this.payment_type = payment_type;
        this.payment_target = payment_target;
    }

    public ShopItemSummonExecRequest() { }
}

[MessagePackObject(true)]
public class ShopItemSummonOddRequest { }

[MessagePackObject(true)]
public class ShopMaterialShopPurchaseRequest
{
    public int goods_id { get; set; }
    public int shop_type { get; set; }
    public int payment_type { get; set; }
    public int quantity { get; set; }

    public ShopMaterialShopPurchaseRequest(
        int goods_id,
        int shop_type,
        int payment_type,
        int quantity
    )
    {
        this.goods_id = goods_id;
        this.shop_type = shop_type;
        this.payment_type = payment_type;
        this.quantity = quantity;
    }

    public ShopMaterialShopPurchaseRequest() { }
}

[MessagePackObject(true)]
public class ShopNormalShopPurchaseRequest
{
    public int goods_id { get; set; }
    public int payment_type { get; set; }
    public int quantity { get; set; }

    public ShopNormalShopPurchaseRequest(int goods_id, int payment_type, int quantity)
    {
        this.goods_id = goods_id;
        this.payment_type = payment_type;
        this.quantity = quantity;
    }

    public ShopNormalShopPurchaseRequest() { }
}

[MessagePackObject(true)]
public class ShopPreChargeCheckRequest
{
    public int shop_type { get; set; }
    public int goods_id { get; set; }
    public int quantity { get; set; }

    public ShopPreChargeCheckRequest(int shop_type, int goods_id, int quantity)
    {
        this.shop_type = shop_type;
        this.goods_id = goods_id;
        this.quantity = quantity;
    }

    public ShopPreChargeCheckRequest() { }
}

[MessagePackObject(true)]
public class ShopSpecialShopPurchaseRequest
{
    public int goods_id { get; set; }
    public int payment_type { get; set; }
    public int quantity { get; set; }
    public AtgenDuplicateEntityList selected_unit { get; set; }

    public ShopSpecialShopPurchaseRequest(
        int goods_id,
        int payment_type,
        int quantity,
        AtgenDuplicateEntityList selected_unit
    )
    {
        this.goods_id = goods_id;
        this.payment_type = payment_type;
        this.quantity = quantity;
        this.selected_unit = selected_unit;
    }

    public ShopSpecialShopPurchaseRequest() { }
}

[MessagePackObject(true)]
public class SimpleEventEntryRequest
{
    public int event_id { get; set; }

    public SimpleEventEntryRequest(int event_id)
    {
        this.event_id = event_id;
    }

    public SimpleEventEntryRequest() { }
}

[MessagePackObject(true)]
public class SimpleEventGetEventDataRequest
{
    public int event_id { get; set; }

    public SimpleEventGetEventDataRequest(int event_id)
    {
        this.event_id = event_id;
    }

    public SimpleEventGetEventDataRequest() { }
}

[MessagePackObject(true)]
public class StampGetStampRequest { }

[MessagePackObject(true)]
public class StampSetEquipStampRequest
{
    public int deck_no { get; set; }
    public IEnumerable<EquipStampList> stamp_list { get; set; }

    public StampSetEquipStampRequest(int deck_no, IEnumerable<EquipStampList> stamp_list)
    {
        this.deck_no = deck_no;
        this.stamp_list = stamp_list;
    }

    public StampSetEquipStampRequest() { }
}

[MessagePackObject(true)]
public class StoryReadRequest
{
    public int unit_story_id { get; set; }

    public StoryReadRequest(int unit_story_id)
    {
        this.unit_story_id = unit_story_id;
    }

    public StoryReadRequest() { }
}

[MessagePackObject(true)]
public class StorySkipSkipRequest { }

[MessagePackObject(true)]
public class SuggestionGetCategoryListRequest
{
    public string language_code { get; set; }

    public SuggestionGetCategoryListRequest(string language_code)
    {
        this.language_code = language_code;
    }

    public SuggestionGetCategoryListRequest() { }
}

[MessagePackObject(true)]
public class SuggestionSetRequest
{
    public string message { get; set; }
    public int category_id { get; set; }

    public SuggestionSetRequest(string message, int category_id)
    {
        this.message = message;
        this.category_id = category_id;
    }

    public SuggestionSetRequest() { }
}

[MessagePackObject(true)]
public class SummonExcludeGetListRequest
{
    public int summon_id { get; set; }

    public SummonExcludeGetListRequest(int summon_id)
    {
        this.summon_id = summon_id;
    }

    public SummonExcludeGetListRequest() { }
}

[MessagePackObject(true)]
public class SummonExcludeGetOddsDataRequest
{
    public int summon_id { get; set; }
    public int exclude_entity_type { get; set; }
    public IEnumerable<int> exclude_entity_id_list { get; set; }

    public SummonExcludeGetOddsDataRequest(
        int summon_id,
        int exclude_entity_type,
        IEnumerable<int> exclude_entity_id_list
    )
    {
        this.summon_id = summon_id;
        this.exclude_entity_type = exclude_entity_type;
        this.exclude_entity_id_list = exclude_entity_id_list;
    }

    public SummonExcludeGetOddsDataRequest() { }
}

[MessagePackObject(true)]
public class SummonExcludeRequestRequest
{
    public int summon_id { get; set; }
    public int payment_type { get; set; }
    public int exclude_entity_type { get; set; }
    public IEnumerable<int> exclude_entity_id_list { get; set; }

    public SummonExcludeRequestRequest(
        int summon_id,
        int payment_type,
        int exclude_entity_type,
        IEnumerable<int> exclude_entity_id_list
    )
    {
        this.summon_id = summon_id;
        this.payment_type = payment_type;
        this.exclude_entity_type = exclude_entity_type;
        this.exclude_entity_id_list = exclude_entity_id_list;
    }

    public SummonExcludeRequestRequest() { }
}

[MessagePackObject(true)]
public class SummonGetOddsDataRequest
{
    public int summon_id { get; set; }

    public SummonGetOddsDataRequest(int summon_id)
    {
        this.summon_id = summon_id;
    }

    public SummonGetOddsDataRequest() { }
}

[MessagePackObject(true)]
public class SummonGetSummonHistoryRequest { }

[MessagePackObject(true)]
public class SummonGetSummonListRequest { }

[MessagePackObject(true)]
public class SummonGetSummonPointTradeRequest
{
    public int summon_id { get; set; }

    public SummonGetSummonPointTradeRequest(int summon_id)
    {
        this.summon_id = summon_id;
    }

    public SummonGetSummonPointTradeRequest() { }
}

[MessagePackObject(true)]
public class SummonRequestRequest
{
    public int summon_id { get; set; }
    public SummonExecTypes exec_type { get; set; }
    public int exec_count { get; set; }
    public PaymentTypes payment_type { get; set; }
    public PaymentTarget payment_target { get; set; }

    public SummonRequestRequest(
        int summon_id,
        SummonExecTypes exec_type,
        int exec_count,
        PaymentTypes payment_type,
        PaymentTarget payment_target
    )
    {
        this.summon_id = summon_id;
        this.exec_type = exec_type;
        this.exec_count = exec_count;
        this.payment_type = payment_type;
        this.payment_target = payment_target;
    }

    public SummonRequestRequest() { }
}

[MessagePackObject(true)]
public class SummonSummonPointTradeRequest
{
    public int summon_id { get; set; }
    public int trade_id { get; set; }

    public SummonSummonPointTradeRequest(int summon_id, int trade_id)
    {
        this.summon_id = summon_id;
        this.trade_id = trade_id;
    }

    public SummonSummonPointTradeRequest() { }
}

[MessagePackObject(true)]
public class TalismanSellRequest
{
    public IEnumerable<ulong> talisman_key_id_list { get; set; }

    public TalismanSellRequest(IEnumerable<ulong> talisman_key_id_list)
    {
        this.talisman_key_id_list = talisman_key_id_list;
    }

    public TalismanSellRequest() { }
}

[MessagePackObject(true)]
public class TalismanSetLockRequest
{
    public ulong talisman_key_id { get; set; }
    public int is_lock { get; set; }

    public TalismanSetLockRequest(ulong talisman_key_id, int is_lock)
    {
        this.talisman_key_id = talisman_key_id;
        this.is_lock = is_lock;
    }

    public TalismanSetLockRequest() { }
}

[MessagePackObject(true)]
public class TimeAttackRankingGetDataRequest { }

[MessagePackObject(true)]
public class TimeAttackRankingReceiveTierRewardRequest
{
    public int quest_id { get; set; }

    public TimeAttackRankingReceiveTierRewardRequest(int quest_id)
    {
        this.quest_id = quest_id;
    }

    public TimeAttackRankingReceiveTierRewardRequest() { }
}

[MessagePackObject(true)]
public class ToolAuthRequest
{
    public string uuid { get; set; }
    public string id_token { get; set; }

    public ToolAuthRequest(string uuid, string id_token)
    {
        this.uuid = uuid;
        this.id_token = id_token;
    }

    public ToolAuthRequest() { }
}

[MessagePackObject(true)]
public class ToolGetMaintenanceTimeRequest { }

[MessagePackObject(true)]
public class ToolGetServiceStatusRequest { }

[MessagePackObject(true)]
public class ToolReauthRequest
{
    public string uuid { get; set; }
    public string id_token { get; set; }

    public ToolReauthRequest(string uuid, string id_token)
    {
        this.uuid = uuid;
        this.id_token = id_token;
    }

    public ToolReauthRequest() { }
}

[MessagePackObject(true)]
public class ToolSignupRequest
{
    public string uuid { get; set; }
    public string id_token { get; set; }
    public string app_version { get; set; }
    public string platform { get; set; }
    public string hashcode { get; set; }
    public int reset_count { get; set; }
    public string eula_region { get; set; }
    public string eula_lang { get; set; }
    public int eula_version { get; set; }
    public int privacy_policy_version { get; set; }

    public ToolSignupRequest(
        string uuid,
        string id_token,
        string app_version,
        string platform,
        string hashcode,
        int reset_count,
        string eula_region,
        string eula_lang,
        int eula_version,
        int privacy_policy_version
    )
    {
        this.uuid = uuid;
        this.id_token = id_token;
        this.app_version = app_version;
        this.platform = platform;
        this.hashcode = hashcode;
        this.reset_count = reset_count;
        this.eula_region = eula_region;
        this.eula_lang = eula_lang;
        this.eula_version = eula_version;
        this.privacy_policy_version = privacy_policy_version;
    }

    public ToolSignupRequest() { }
}

[MessagePackObject(true)]
public class TrackRecordUpdateProgressRequest { }

[MessagePackObject(true)]
public class TransitionTransitionByNAccountRequest
{
    public string uuid { get; set; }
    public string id_token { get; set; }

    public TransitionTransitionByNAccountRequest(string uuid, string id_token)
    {
        this.uuid = uuid;
        this.id_token = id_token;
    }

    public TransitionTransitionByNAccountRequest() { }
}

[MessagePackObject(true)]
public class TreasureTradeGetListAllRequest { }

[MessagePackObject(true)]
public class TreasureTradeGetListRequest
{
    public int trade_group_id { get; set; }

    public TreasureTradeGetListRequest(int trade_group_id)
    {
        this.trade_group_id = trade_group_id;
    }

    public TreasureTradeGetListRequest() { }
}

[MessagePackObject(true)]
public class TreasureTradeTradeRequest
{
    public int trade_group_id { get; set; }
    public int treasure_trade_id { get; set; }
    public IEnumerable<AtgenNeedUnitList> need_unit_list { get; set; }
    public int trade_count { get; set; }

    public TreasureTradeTradeRequest(
        int trade_group_id,
        int treasure_trade_id,
        IEnumerable<AtgenNeedUnitList> need_unit_list,
        int trade_count
    )
    {
        this.trade_group_id = trade_group_id;
        this.treasure_trade_id = treasure_trade_id;
        this.need_unit_list = need_unit_list;
        this.trade_count = trade_count;
    }

    public TreasureTradeTradeRequest() { }
}

[MessagePackObject(true)]
public class TutorialUpdateFlagsRequest
{
    public int flag_id { get; set; }

    public TutorialUpdateFlagsRequest(int flag_id)
    {
        this.flag_id = flag_id;
    }

    public TutorialUpdateFlagsRequest() { }
}

[MessagePackObject(true)]
public class TutorialUpdateStepRequest
{
    public int step { get; set; }
    public int is_skip { get; set; }
    public int entity_id { get; set; }
    public EntityTypes entity_type { get; set; }

    public TutorialUpdateStepRequest(int step, int is_skip, int entity_id, EntityTypes entity_type)
    {
        this.step = step;
        this.is_skip = is_skip;
        this.entity_id = entity_id;
        this.entity_type = entity_type;
    }

    public TutorialUpdateStepRequest() { }
}

[MessagePackObject(true)]
public class UpdateNamechangeRequest
{
    [MaxLength(10)]
    public string name { get; set; }

    public UpdateNamechangeRequest(string name)
    {
        this.name = name;
    }

    public UpdateNamechangeRequest() { }
}

[MessagePackObject(true)]
public class UpdateResetNewRequest
{
    public IEnumerable<AtgenTargetList> target_list { get; set; }

    public UpdateResetNewRequest(IEnumerable<AtgenTargetList> target_list)
    {
        this.target_list = target_list;
    }

    public UpdateResetNewRequest() { }
}

[MessagePackObject(true)]
public class UserGetNAccountInfoRequest { }

[MessagePackObject(true)]
public class UserGetWalletBalanceRequest { }

[MessagePackObject(true)]
public class UserLinkedNAccountRequest { }

[MessagePackObject(true)]
public class UserOptInSettingRequest
{
    public int is_optin { get; set; }

    public UserOptInSettingRequest(int is_optin)
    {
        this.is_optin = is_optin;
    }

    public UserOptInSettingRequest() { }
}

[MessagePackObject(true)]
public class UserRecoverStaminaByStoneRequest
{
    public int recovery_type { get; set; }
    public int recovery_quantity { get; set; }
    public int payment_type { get; set; }

    public UserRecoverStaminaByStoneRequest(
        int recovery_type,
        int recovery_quantity,
        int payment_type
    )
    {
        this.recovery_type = recovery_type;
        this.recovery_quantity = recovery_quantity;
        this.payment_type = payment_type;
    }

    public UserRecoverStaminaByStoneRequest() { }
}

[MessagePackObject(true)]
public class UserWithdrawalRequest { }

[MessagePackObject(true)]
public class VersionGetResourceVersionRequest
{
    public int platform { get; set; }
    public string app_version { get; set; }

    public VersionGetResourceVersionRequest(int platform, string app_version)
    {
        this.platform = platform;
        this.app_version = app_version;
    }

    public VersionGetResourceVersionRequest() { }
}

[MessagePackObject(true)]
public class WalkerSendGiftMultipleRequest
{
    public int dragon_gift_id { get; set; }
    public int quantity { get; set; }

    public WalkerSendGiftMultipleRequest(int dragon_gift_id, int quantity)
    {
        this.dragon_gift_id = dragon_gift_id;
        this.quantity = quantity;
    }

    public WalkerSendGiftMultipleRequest() { }
}

[MessagePackObject(true)]
public class WallFailRequest
{
    public string dungeon_key { get; set; }
    public int fail_state { get; set; }

    public WallFailRequest(string dungeon_key, int fail_state)
    {
        this.dungeon_key = dungeon_key;
        this.fail_state = fail_state;
    }

    public WallFailRequest() { }
}

[MessagePackObject(true)]
public class WallGetMonthlyRewardRequest
{
    public int quest_group_id { get; set; }

    public WallGetMonthlyRewardRequest(int quest_group_id)
    {
        this.quest_group_id = quest_group_id;
    }

    public WallGetMonthlyRewardRequest() { }
}

[MessagePackObject(true)]
public class WallGetWallClearPartyRequest
{
    public int wall_id { get; set; }

    public WallGetWallClearPartyRequest(int wall_id)
    {
        this.wall_id = wall_id;
    }

    public WallGetWallClearPartyRequest() { }
}

[MessagePackObject(true)]
public class WallReceiveMonthlyRewardRequest
{
    public int quest_group_id { get; set; }

    public WallReceiveMonthlyRewardRequest(int quest_group_id)
    {
        this.quest_group_id = quest_group_id;
    }

    public WallReceiveMonthlyRewardRequest() { }
}

[MessagePackObject(true)]
public class WallRecordRecordRequest
{
    public int wall_id { get; set; }
    public string dungeon_key { get; set; }

    public WallRecordRecordRequest(int wall_id, string dungeon_key)
    {
        this.wall_id = wall_id;
        this.dungeon_key = dungeon_key;
    }

    public WallRecordRecordRequest() { }
}

[MessagePackObject(true)]
public class WallSetWallClearPartyRequest
{
    public int wall_id { get; set; }
    public IEnumerable<PartySettingList> request_party_setting_list { get; set; }

    public WallSetWallClearPartyRequest(
        int wall_id,
        IEnumerable<PartySettingList> request_party_setting_list
    )
    {
        this.wall_id = wall_id;
        this.request_party_setting_list = request_party_setting_list;
    }

    public WallSetWallClearPartyRequest() { }
}

[MessagePackObject(true)]
public class WallStartStartAssignUnitRequest
{
    public int wall_id { get; set; }
    public int wall_level { get; set; }
    public IEnumerable<PartySettingList> request_party_setting_list { get; set; }
    public ulong support_viewer_id { get; set; }

    public WallStartStartAssignUnitRequest(
        int wall_id,
        int wall_level,
        IEnumerable<PartySettingList> request_party_setting_list,
        ulong support_viewer_id
    )
    {
        this.wall_id = wall_id;
        this.wall_level = wall_level;
        this.request_party_setting_list = request_party_setting_list;
        this.support_viewer_id = support_viewer_id;
    }

    public WallStartStartAssignUnitRequest() { }
}

[MessagePackObject(true)]
public class WallStartStartRequest
{
    public int wall_id { get; set; }
    public int wall_level { get; set; }
    public int party_no { get; set; }
    public ulong support_viewer_id { get; set; }

    public WallStartStartRequest(int wall_id, int wall_level, int party_no, ulong support_viewer_id)
    {
        this.wall_id = wall_id;
        this.wall_level = wall_level;
        this.party_no = party_no;
        this.support_viewer_id = support_viewer_id;
    }

    public WallStartStartRequest() { }
}

[MessagePackObject(true)]
public class WeaponBodyBuildupPieceRequest
{
    public int weapon_body_id { get; set; }
    public IEnumerable<AtgenBuildupWeaponBodyPieceList> buildup_weapon_body_piece_list { get; set; }

    public WeaponBodyBuildupPieceRequest(
        int weapon_body_id,
        IEnumerable<AtgenBuildupWeaponBodyPieceList> buildup_weapon_body_piece_list
    )
    {
        this.weapon_body_id = weapon_body_id;
        this.buildup_weapon_body_piece_list = buildup_weapon_body_piece_list;
    }

    public WeaponBodyBuildupPieceRequest() { }
}

[MessagePackObject(true)]
public class WeaponBodyCraftRequest
{
    public WeaponBodies weapon_body_id { get; set; }

    public WeaponBodyCraftRequest(WeaponBodies weapon_body_id)
    {
        this.weapon_body_id = weapon_body_id;
    }

    public WeaponBodyCraftRequest() { }
}

[MessagePackObject(true)]
public class WeaponBuildupRequest
{
    public ulong base_weapon_key_id { get; set; }
    public IEnumerable<GrowMaterialList> grow_material_list { get; set; }

    public WeaponBuildupRequest(
        ulong base_weapon_key_id,
        IEnumerable<GrowMaterialList> grow_material_list
    )
    {
        this.base_weapon_key_id = base_weapon_key_id;
        this.grow_material_list = grow_material_list;
    }

    public WeaponBuildupRequest() { }
}

[MessagePackObject(true)]
public class WeaponLimitBreakRequest
{
    public ulong base_weapon_key_id { get; set; }
    public IEnumerable<GrowMaterialList> grow_material_list { get; set; }

    public WeaponLimitBreakRequest(
        ulong base_weapon_key_id,
        IEnumerable<GrowMaterialList> grow_material_list
    )
    {
        this.base_weapon_key_id = base_weapon_key_id;
        this.grow_material_list = grow_material_list;
    }

    public WeaponLimitBreakRequest() { }
}

[MessagePackObject(true)]
public class WeaponResetPlusCountRequest
{
    public ulong weapon_key_id { get; set; }
    public int plus_count_type { get; set; }

    public WeaponResetPlusCountRequest(ulong weapon_key_id, int plus_count_type)
    {
        this.weapon_key_id = weapon_key_id;
        this.plus_count_type = plus_count_type;
    }

    public WeaponResetPlusCountRequest() { }
}

[MessagePackObject(true)]
public class WeaponSellRequest
{
    public IEnumerable<ulong> weapon_key_id_list { get; set; }

    public WeaponSellRequest(IEnumerable<ulong> weapon_key_id_list)
    {
        this.weapon_key_id_list = weapon_key_id_list;
    }

    public WeaponSellRequest() { }
}

[MessagePackObject(true)]
public class WeaponSetLockRequest
{
    public ulong weapon_key_id { get; set; }
    public int is_lock { get; set; }

    public WeaponSetLockRequest(ulong weapon_key_id, int is_lock)
    {
        this.weapon_key_id = weapon_key_id;
        this.is_lock = is_lock;
    }

    public WeaponSetLockRequest() { }
}

[MessagePackObject(true)]
public class WebviewVersionUrlListRequest
{
    public string region { get; set; }

    public WebviewVersionUrlListRequest(string region)
    {
        this.region = region;
    }

    public WebviewVersionUrlListRequest() { }
}
