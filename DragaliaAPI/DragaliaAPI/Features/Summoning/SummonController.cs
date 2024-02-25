﻿using System.Diagnostics;
using AutoMapper;
using DragaliaAPI.Controllers;
using DragaliaAPI.Database.Entities;
using DragaliaAPI.Database.Repositories;
using DragaliaAPI.Features.Reward;
using DragaliaAPI.Features.Shop;
using DragaliaAPI.Models.Generated;
using DragaliaAPI.Services;
using DragaliaAPI.Services.Exceptions;
using DragaliaAPI.Shared.Definitions.Enums;
using DragaliaAPI.Shared.MasterAsset;
using DragaliaAPI.Shared.MasterAsset.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DragaliaAPI.Features.Summoning;

[Route("summon")]
[Consumes("application/octet-stream")]
[Produces("application/octet-stream")]
[ApiController]
public class SummonController(
    IUserDataRepository userDataRepository,
    IUnitRepository unitRepository,
    IUpdateDataService updateDataService,
    IMapper mapper,
    ISummonRepository summonRepository,
    ISummonService summonService,
    IPaymentService paymentService,
    SummonListService summonListService
) : DragaliaControllerBase
{
    // Repeated from RedoableSummonController, but no point putting this in a shared location
    // as it's all bullshit anyway
    private static class Data
    {
        public static readonly OddsRate OddsRate =
            new(
                new List<AtgenRarityList>()
                {
                    new(5, "placeholder"),
                    new(4, "placeholder"),
                    new(3, "placeholder")
                },
                new List<AtgenRarityGroupList>()
                {
                    new(false, 5, "placeholder", "placeholder", "placeholder", "placeholder")
                },
                new(
                    new List<OddsUnitDetail>()
                    {
                        new(
                            false,
                            5,
                            new List<AtgenUnitList>() { new((int)Charas.Addis, "placeholder") }
                        )
                    },
                    new List<OddsUnitDetail>()
                    {
                        new(
                            false,
                            5,
                            new List<AtgenUnitList>() { new((int)Dragons.Agni, "placeholder") }
                        )
                    },
                    new List<OddsUnitDetail>()
                    {
                        new(
                            false,
                            5,
                            new List<AtgenUnitList>()
                            {
                                new(40050001, "lol you can still summon prints")
                            }
                        )
                    }
                )
            );

        public static readonly SummonPrizeOddsRate PrizeOddsRate =
            new(new List<AtgenSummonPrizeRankList>(), new List<AtgenSummonPrizeEntitySetList>());
    }

    /// <summary>
    /// Returns excluded/excludable units for special banners
    /// </summary>
    /// <param name="sessionId"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("~/summon_exclude/get_list")]
    public async Task<DragaliaResult> SummonExcludeGetList(SummonExcludeGetListRequest request)
    {
        int bannerId = request.summon_id;
        DbPlayerUserData userData = await userDataRepository.UserData.FirstAsync();
        //TODO Replace DummyData with real exludes from BannerInfo
        List<AtgenDuplicateEntityList> excludableList = new();
        foreach (Charas c in Enum.GetValues<Charas>())
        {
            excludableList.Add(new AtgenDuplicateEntityList(EntityTypes.Chara, (int)c));
        }
        foreach (Dragons d in Enum.GetValues<Dragons>())
        {
            excludableList.Add(new AtgenDuplicateEntityList(EntityTypes.Dragon, (int)d));
        }

        return this.Ok(new SummonExcludeGetListData(excludableList));
    }

    [HttpPost]
    [Route("get_odds_data")]
    public async Task<DragaliaResult> GetOddsData(SummonGetOddsDataRequest request)
    {
        int bannerId = request.summon_id;
        DbPlayerUserData userData = await userDataRepository.UserData.FirstAsync();
        //TODO Replace Dummy data with oddscalculation

        return this.Ok(
            new SummonGetOddsDataData(
                new OddsRateList(0, Data.OddsRate, Data.OddsRate),
                new(Data.PrizeOddsRate, Data.PrizeOddsRate)
            )
        );
    }

    [HttpPost]
    [Route("get_summon_history")]
    public async Task<DragaliaResult> GetSummonHistory()
    {
        DbPlayerUserData userData = await userDataRepository.UserData.FirstAsync();

        IEnumerable<SummonHistoryList> dbList = (
            await summonRepository.SummonHistory.ToListAsync()
        ).Select(mapper.Map<SummonHistoryList>);

        return this.Ok(new SummonGetSummonHistoryData(dbList));
    }

    [HttpPost]
    [Route("get_summon_list")]
    public async Task<DragaliaResult<SummonGetSummonListData>> GetSummonList()
    {
        IEnumerable<SummonList> bannerList = await summonListService.GetSummonList();
        IEnumerable<SummonTicketList> ticketList = await summonListService.GetSummonTicketList();

        return new SummonGetSummonListData()
        {
            summon_list = bannerList,
            summon_ticket_list = ticketList,
            campaign_summon_list = [],
            chara_ssr_summon_list = [],
            dragon_ssr_summon_list = [],
            chara_ssr_update_summon_list = [],
            dragon_ssr_update_summon_list = [],
            campaign_ssr_summon_list = [],
            platinum_summon_list = [],
            exclude_summon_list = [],
            cs_summon_list = new()
            {
                summon_list = [],
                platinum_summon_list = [],
                campaign_summon_list = [],
                campaign_ssr_summon_list = [],
                exclude_summon_list = [],
            },
            summon_point_list = [],
        };
    }

    [HttpPost]
    [Route("get_summon_point_trade")]
    public async Task<DragaliaResult> GetSummonPointTrade(SummonGetSummonPointTradeRequest request)
    {
        int bannerId = request.summon_id;
        DbPlayerUserData userData = await userDataRepository.UserData.FirstAsync();
        //TODO maybe throw BadRequest on bad banner id, for now generate empty data if not exists
        DbPlayerBannerData playerBannerData = await summonRepository.GetPlayerBannerData(bannerId);
        //TODO get real list from persisted BannerInfo or dynamic List from Db, dunno yet
        List<AtgenSummonPointTradeList> tradableUnits =
            new()
            {
                new(bannerId * 1000 + 1, EntityTypes.Chara, (int)Charas.Celliera),
                new(bannerId * 1000 + 2, EntityTypes.Chara, (int)Charas.SummerCelliera)
            };

        return this.Ok(
            new SummonGetSummonPointTradeData(
                tradableUnits,
                new List<SummonPointList>() { new(bannerId, 0, 0, 0, int.MaxValue) },
                new(),
                new()
            )
        );
    }

    //TODO: Fully implement and refactor
    [HttpPost]
    [Route("request")]
    public async Task<DragaliaResult> RequestSummon(SummonRequestRequest summonRequest)
    {
        //TODO Fetch real data by bannerId
        SummonList bannerData =
            new(
                1020203,
                0,
                (int)BannerTypes.Normal,
                120,
                120,
                1200,
                1200,
                5,
                30,
                1,
                2,
                300,
                1,
                status: 1,
                DateTimeOffset.UtcNow,
                DateTimeOffset.UtcNow.AddDays(7),
                1,
                0,
                0,
                (int)SummonCampaignTypes.Normal,
                0,
                1,
                1,
                0,
                0
            );

        DateTimeOffset summonDate = DateTimeOffset.UtcNow;

        DbPlayerBannerData playerBannerData = await summonRepository.GetPlayerBannerData(
            bannerData.summon_id
        );

        DbPlayerUserData userData = await userDataRepository.UserData.FirstAsync();

        int numSummons =
            summonRequest.exec_type == SummonExecTypes.Tenfold
                ? 10
                : Math.Max(1, summonRequest.exec_count);

        int summonPointMultiplier = bannerData.add_summon_point;

        int paymentCost;

        switch (summonRequest.payment_type)
        {
            case PaymentTypes.Diamantium:
                summonPointMultiplier = bannerData.add_summon_point_stone;
                playerBannerData.DailyLimitedSummonCount++;
                paymentCost =
                    summonRequest.exec_type == SummonExecTypes.Tenfold
                        ? bannerData.multi_diamond
                        : bannerData.single_diamond * numSummons;
                break;
            case PaymentTypes.Wyrmite:
                paymentCost =
                    summonRequest.exec_type == SummonExecTypes.Tenfold
                        ? bannerData.multi_crystal
                        : bannerData.single_crystal * numSummons;
                break;
            case PaymentTypes.Ticket:
                paymentCost = summonRequest.exec_type == SummonExecTypes.Tenfold ? 1 : numSummons;
                break;
            case PaymentTypes.FreeDailyExecDependant:
            case PaymentTypes.FreeDailyTenfold:
                if (bannerData.is_beginner_campaign == 1)
                    playerBannerData.IsBeginnerFreeSummonAvailable = 0;
                paymentCost = 0;
                break;
            default:
                throw new DragaliaException(
                    ResultCode.SummonTypeUnexpected,
                    "Invalid payment type"
                );
        }

        int entityId = 0;

        if (summonRequest.payment_type == PaymentTypes.Ticket)
        {
            // TODO: Does not capture special ticket logic.
            SummonTickets ticketType = summonRequest.exec_type switch
            {
                SummonExecTypes.Single => SummonTickets.SingleSummon,
                SummonExecTypes.Tenfold => SummonTickets.TenfoldSummon,
                _
                    => throw new DragaliaException(
                        ResultCode.CommonInvalidArgument,
                        "Invalid exec type for ticket summon"
                    )
            };

            entityId = (int)ticketType;
        }

        await paymentService.ProcessPayment(
            new Entity(summonRequest.payment_type.ToEntityType(), entityId, paymentCost),
            summonRequest.payment_target
        );

        List<AtgenRedoableSummonResultUnitList> summonResult = summonService.GenerateSummonResult(
            numSummons
        );

        List<AtgenResultUnitList> returnedResult = new();
        List<AtgenDuplicateEntityList> newGetEntityList = new();

        int lastIndexOfRare5 = 0;
        int countOfRare5Char = 0;
        int countOfRare5Dragon = 0;
        int countOfRare4 = 0;

        List<Dragons> newDragons = (
            await unitRepository.AddDragons(
                summonResult
                    .Where(x => x.entity_type == EntityTypes.Dragon)
                    .Select(x => (Dragons)x.id)
            )
        )
            .Where(x => x.isNew)
            .Select(x => x.id)
            .ToList();

        List<Charas> newCharas = (
            await unitRepository.AddCharas(
                summonResult
                    .Where(x => x.entity_type == EntityTypes.Chara)
                    .Select(x => (Charas)x.id)
            )
        )
            .Where(x => x.isNew)
            .Select(x => x.id)
            .ToList();

        foreach (
            (AtgenRedoableSummonResultUnitList result, int index) in summonResult.Select(
                (x, i) => (x, i)
            )
        )
        {
            bool isNew = result.entity_type switch
            {
                EntityTypes.Dragon => newDragons.Remove((Dragons)result.id),
                EntityTypes.Chara => newCharas.Remove((Charas)result.id),
                _ => throw new UnreachableException("Invalid entity type"),
            };

            int dewPoint = 0;
            if (!isNew && result.entity_type is EntityTypes.Chara)
            {
                dewPoint = CalculateDewValue((Charas)result.id);
                userData.DewPoint += dewPoint;
            }
            else
            {
                newGetEntityList.Add(
                    new() { entity_type = result.entity_type, entity_id = result.id }
                );
            }

            switch (result.rarity)
            {
                case 5:
                {
                    lastIndexOfRare5 = index;

                    if (result.entity_type is EntityTypes.Chara)
                        countOfRare5Char++;
                    else
                        countOfRare5Dragon++;
                    break;
                }
                case 4:
                    countOfRare4++;
                    break;
            }

            await summonRepository.AddSummonHistory(
                new DbPlayerSummonHistory()
                {
                    ViewerId = this.ViewerId,
                    SummonId = bannerData.summon_id,
                    SummonExecType = summonRequest.exec_type,
                    ExecDate = summonDate,
                    PaymentType = summonRequest.payment_type,
                    EntityType = result.entity_type,
                    EntityId = result.id,
                    EntityQuantity = 1,
                    EntityLevel = 1,
                    EntityRarity = (byte)result.rarity,
                    EntityLimitBreakCount = 0,
                    EntityHpPlusCount = 0,
                    EntityAttackPlusCount = 0,
                    SummonPrizeRank = SummonPrizeRanks.None,
                    SummonPoint = summonPointMultiplier,
                    GetDewPointQuantity = dewPoint,
                }
            );

            returnedResult.Add(
                new()
                {
                    entity_type = result.entity_type,
                    id = result.id,
                    is_new = isNew,
                    rarity = result.rarity,
                    dew_point = dewPoint,
                }
            );
        }

        playerBannerData.SummonPoints += numSummons * summonPointMultiplier;
        playerBannerData.SummonCount += numSummons;

        int reversalIndex = lastIndexOfRare5;
        if (reversalIndex != -1 && new Random().NextSingle() < 0.95)
            reversalIndex = -1;

        int sageEffect = (int)SummonEffectsSage.Dull;
        int circleEffect = (int)SummonEffectsSky.Blue;
        int rarityDisplayModifier = reversalIndex == -1 ? 0 : 1;
        if (countOfRare5Char + countOfRare5Dragon > 0 + rarityDisplayModifier)
        {
            sageEffect =
                countOfRare5Dragon > countOfRare5Char
                    ? (int)SummonEffectsSage.GoldFafnirs
                    : (int)SummonEffectsSage.RainbowCrystal;
            circleEffect = (int)SummonEffectsSky.Rainbow;
        }
        else
        {
            circleEffect = (int)SummonEffectsSky.Yellow;
            switch (countOfRare4 + (countOfRare5Char + countOfRare5Dragon) * 2)
            {
                case > 1:
                    sageEffect = (int)SummonEffectsSage.MultiDoves;
                    break;
                case > 0:
                    sageEffect = (int)SummonEffectsSage.SingleDove;
                    break;
                default:
                    sageEffect = (int)SummonEffectsSage.Dull;
                    circleEffect = (int)SummonEffectsSky.Blue;
                    break;
            }
        }

        UpdateDataList updateDataList = await updateDataService.SaveChangesAsync();

        var response = new SummonRequestData(
            returnedResult,
            new List<AtgenResultPrizeList>(),
            new List<int>() { sageEffect, circleEffect },
            reversalIndex,
            updateDataList,
            new EntityResult() { new_get_entity_list = newGetEntityList },
            new List<SummonTicketList>(),
            playerBannerData.SummonPoints,
            new List<UserSummonList>()
            {
                new(
                    bannerData.summon_id,
                    playerBannerData.SummonCount,
                    bannerData.campaign_type,
                    bannerData.free_count_rest,
                    bannerData.is_beginner_campaign,
                    bannerData.beginner_campaign_count_rest,
                    bannerData.consecution_campaign_count_rest
                )
            }
        );

        return this.Ok(response);
    }

    private static int CalculateDewValue(Charas id)
    {
        CharaData data = MasterAsset.CharaData[id];
        return data.Availability == CharaAvailabilities.Story
            ? DewValueData.DupeStorySummon[data.Rarity]
            : DewValueData.DupeSummon[data.Rarity];
    }
}