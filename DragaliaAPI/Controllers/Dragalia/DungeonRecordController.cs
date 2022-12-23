﻿using System.Diagnostics;
using DragaliaAPI.Database.Entities;
using DragaliaAPI.Database.Repositories;
using DragaliaAPI.Models;
using DragaliaAPI.Models.Generated;
using DragaliaAPI.Services;
using DragaliaAPI.Shared.Definitions.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DragaliaAPI.Controllers.Dragalia;

[Route("dungeon_record")]
public class DungeonRecordController : DragaliaControllerBase
{
    private readonly IQuestRepository questRepository;
    private readonly IDungeonService dungeonService;
    private readonly IUserDataRepository userDataRepository;
    private readonly IInventoryRepository inventoryRepository;
    private readonly IUpdateDataService updateDataService;

    public DungeonRecordController(
        IQuestRepository questRepository,
        IDungeonService dungeonService,
        IUserDataRepository userDataRepository,
        IInventoryRepository inventoryRepository,
        IUpdateDataService updateDataService
    )
    {
        this.questRepository = questRepository;
        this.dungeonService = dungeonService;
        this.userDataRepository = userDataRepository;
        this.inventoryRepository = inventoryRepository;
        this.updateDataService = updateDataService;
    }

    [HttpPost("record")]
    public async Task<DragaliaResult> Record(DungeonRecordRecordRequest request)
    {
        DungeonSession session = await this.dungeonService.FinishDungeon(request.dungeon_key);

        await this.userDataRepository.AddTutorialFlag(this.DeviceAccountId, 1022);
        await this.questRepository.CompleteQuest(this.DeviceAccountId, session.DungeonId);

        DbPlayerUserData userData = await this.userDataRepository
            .GetUserData(this.DeviceAccountId)
            .SingleAsync();

        userData.Exp += 1;
        userData.ManaPoint += 1000;
        userData.Coin += 1000;
        userData.Crystal += 25;

        IEnumerable<Materials> drops = DefaultDrops.GetRandomList();
        await this.inventoryRepository.AddMaterials(this.DeviceAccountId, drops, 100);

        UpdateDataList updateDataList = this.updateDataService.GetUpdateDataList(
            this.DeviceAccountId
        );

        await this.questRepository.SaveChangesAsync();

        return this.Ok(
            new DungeonRecordRecordData()
            {
                ingame_result_data = new()
                {
                    dungeon_key = request.dungeon_key,
                    play_type = 1,
                    quest_id = session.DungeonId,
                    reward_record = new()
                    {
                        /*drop_all = new List<AtgenDropAll>()
                        {
                            new()
                            {
                                type = (int)EntityTypes.Material,
                                id = 201014003, // Squishum
                                quantity = 1,
                                place = 0,
                                factor = 0
                            }
                        },*/
                        drop_all = drops.Select(
                            x =>
                                new AtgenDropAll()
                                {
                                    type = EntityTypes.Material,
                                    id = (int)x,
                                    quantity = 10,
                                    place = 0,
                                    factor = 0,
                                }
                        ),
                        first_clear_set = new List<AtgenFirstClearSet>()
                        {
                            new()
                            {
                                type = (int)EntityTypes.Wyrmite,
                                id = 0,
                                quantity = 5
                            }
                        },
                        take_coin = 1000,
                        take_astral_item_quantity = 300,
                        missions_clear_set = Enumerable
                            .Range(1, 3)
                            .Select(
                                x =>
                                    new AtgenMissionsClearSet()
                                    {
                                        type = 23,
                                        id = 0,
                                        quantity = 5,
                                        mission_no = x
                                    }
                            ),
                        mission_complete = new List<AtgenFirstClearSet>()
                        {
                            new()
                            {
                                type = (int)EntityTypes.Wyrmite,
                                id = 0,
                                quantity = 5
                            }
                        },
                        enemy_piece = new List<AtgenEnemyPiece>(),
                        reborn_bonus = new List<AtgenFirstClearSet>(),
                        quest_bonus_list = new List<AtgenFirstClearSet>(),
                        carry_bonus = new List<AtgenFirstClearSet>(),
                        challenge_quest_bonus_list = new List<AtgenFirstClearSet>(),
                        campaign_extra_reward_list = new List<AtgenFirstClearSet>(),
                        weekly_limit_reward_list = new List<AtgenFirstClearSet>(),
                    },
                    grow_record = new()
                    {
                        take_player_exp = 1,
                        take_chara_exp = 4000,
                        take_mana = 1000,
                        bonus_factor = 1,
                        mana_bonus_factor = 1,
                        chara_grow_record = session.Party.Select(
                            x =>
                                new AtgenCharaGrowRecord()
                                {
                                    chara_id = (int)x.chara_id,
                                    take_exp = 240
                                }
                        ),
                        chara_friendship_list = new List<CharaFriendshipList>()
                    },
                    start_time = DateTimeOffset.UtcNow,
                    end_time = DateTimeOffset.FromUnixTimeSeconds(0),
                    current_play_count = 1,
                    is_clear = false,
                    state = 1,
                    is_host = true,
                    reborn_count = 0,
                    helper_list = new List<UserSupportList>(),
                    helper_detail_list = new List<AtgenHelperDetailList>(),
                    quest_party_setting_list = session.Party,
                    bonus_factor_list = new List<AtgenBonusFactorList>(),
                    scoring_enemy_point_list = new List<AtgenScoringEnemyPointList>(),
                    score_mission_success_list = new List<AtgenScoreMissionSuccessList>(),
                    event_passive_up_list = new List<AtgenEventPassiveUpList>(),
                    clear_time = 70,
                    is_best_clear_time = true,
                    converted_entity_list = new List<ConvertedEntityList>(),
                    dungeon_skip_type = 0,
                    total_play_damage = 0,
                },
                update_data_list = updateDataList,
                entity_result = new(),
            }
        );
    }

    [HttpPost("record_multi")]
    public DragaliaResult RecordMulti(DungeonRecordRecordMultiRequest request)
    {
        return RedirectToActionPreserveMethod("Record", routeValues: new { request });
    }

    private static class DefaultDrops
    {
        public static readonly IReadOnlyList<Materials> Orbs = new List<Materials>()
        {
            // Flame
            Materials.FlameOrb,
            Materials.BlazeOrb,
            Materials.InfernoOrb,
            Materials.IncandescenceOrb,
            // Water
            Materials.WaterOrb,
            Materials.StreamOrb,
            Materials.DelugeOrb,
            Materials.TsunamiOrb,
            // Wind
            Materials.WindOrb,
            Materials.StormOrb,
            Materials.MaelstromOrb,
            Materials.TempestOrb,
            // Light
            Materials.LightOrb,
            Materials.RadianceOrb,
            Materials.RefulgenceOrb,
            Materials.ResplendenceOrb,
            // Shadow
            Materials.ShadowOrb,
            Materials.NightfallOrb,
            Materials.NetherOrb,
            Materials.AbaddonOrb,
            // Misc
            Materials.RainbowOrb,
        };

        public static readonly IReadOnlyList<Materials> DragonParts = new List<Materials>()
        {
            // Brunhilda
            Materials.FlamewyrmsScale,
            Materials.FlamewyrmsScaldscale,
            Materials.FlamewyrmsGreatsphere,
            Materials.FlamewyrmsSphere,
            Materials.HighFlamewyrmsHorn,
            Materials.HighFlamewyrmsTail,
            // Mercury
            Materials.WaterwyrmsScale,
            Materials.WaterwyrmsGlistscale,
            Materials.WaterwyrmsGreatsphere,
            Materials.WaterwyrmsSphere,
            Materials.HighWaterwyrmsHorn,
            Materials.HighWaterwyrmsTail,
            // Mids
            Materials.WindwyrmsScale,
            Materials.WindwyrmsSquallscale,
            Materials.WindwyrmsGreatsphere,
            Materials.WindwyrmsSphere,
            Materials.HighWindwyrmsHorn,
            Materials.HighWindwyrmsTail,
            // Jupiter
            Materials.LightwyrmsScale,
            Materials.LightwyrmsGlowscale,
            Materials.LightwyrmsGreatsphere,
            Materials.LightwyrmsSphere,
            Materials.HighLightwyrmsHorn,
            Materials.HighLightwyrmsTail,
            // Zodiark
            Materials.ShadowwyrmsScale,
            Materials.ShadowwyrmsDarkscale,
            Materials.ShadowwyrmsGreatsphere,
            Materials.ShadowwyrmsSphere,
            Materials.HighShadowwyrmsHorn,
            Materials.HighShadowwyrmsTail,
        };

        public static readonly IReadOnlyList<Materials> MiscUpgrade = new List<Materials>()
        {
            // === Crystals ===
            Materials.GoldCrystal,
            Materials.SilverCrystal,
            Materials.BronzeCrystal,
            // === Testaments ===
            Materials.ChampionsTestament,
            Materials.KnightsTestament,
            // === Void ===
            Materials.VoidSeed,
            Materials.BurningHeart,
            Materials.AzureHeart,
            Materials.VerdantHeart,
            Materials.CoronalHeart,
            Materials.EbonyHeart,
            Materials.LongingHeart,
            // === Misc ===
            Materials.Omnicite,
        };

        public static IReadOnlyList<Materials> GetRandomList()
        {
            Random r = new();
            return r.Next(0, 3) switch
            {
                0 => Orbs,
                1 => DragonParts,
                2 => MiscUpgrade,
                _ => throw new UnreachableException("r.Next(3) returned something odd"),
            };
        }
    }
}