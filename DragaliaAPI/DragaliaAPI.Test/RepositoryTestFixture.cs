﻿using AutoMapper;
using DragaliaAPI.Database;
using DragaliaAPI.Database.Repositories;
using DragaliaAPI.Features.SavefileUpdate;
using DragaliaAPI.Services.Game;
using DragaliaAPI.Test.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;

namespace DragaliaAPI.Test;

[Collection(nameof(RepositoryTestFixture))]
public class RepositoryTestFixture : IDisposable
{
    protected ApiContext ApiContext { get; init; }

    protected IMapper Mapper { get; init; }

    public const long ViewerId = 1;

    private readonly string DbName = $"DbTestFixture-{Guid.NewGuid()}";

    public RepositoryTestFixture()
    {
        DbContextOptions<ApiContext> options = new DbContextOptionsBuilder<ApiContext>()
            .UseInMemoryDatabase(DbName)
            .EnableSensitiveDataLogging()
            .ConfigureWarnings(config => config.Ignore(InMemoryEventId.TransactionIgnoredWarning))
            .Options;

        this.ApiContext = new ApiContext(options, new StubPlayerIdentityService(ViewerId));

        // Unused for creating saves
        Mock<ILogger<SavefileService>> mockLogger = new(MockBehavior.Loose);
        Mock<IDistributedCache> mockCache = new(MockBehavior.Loose);
        // Used but we probably don't want it to actually add characters?
        Mock<IUnitRepository> mockUnitRepository = new(MockBehavior.Loose);

        SavefileService savefileService =
            new(
                this.ApiContext,
                mockCache.Object,
                new MapperConfiguration(opts =>
                    opts.AddMaps(typeof(Program).Assembly)
                ).CreateMapper(),
                mockLogger.Object,
                IdentityTestUtils.MockPlayerDetailsService.Object,
                Enumerable.Empty<ISavefileUpdate>(),
                mockUnitRepository.Object
            );
        savefileService.Create().Wait();

        this.Mapper = UnitTestUtils.CreateMapper();
    }

    public async Task AddToDatabase<TEntity>(TEntity data)
    {
        if (data is null)
            return;

        await this.ApiContext.AddAsync(data);
        await this.ApiContext.SaveChangesAsync();
    }

    public async Task AddRangeToDatabase<TEntity>(IEnumerable<TEntity> data)
    {
        if (data is null)
            return;

        await this.ApiContext.AddRangeAsync((IEnumerable<object>)data);
        await this.ApiContext.SaveChangesAsync();
    }

    public void Dispose()
    {
        this.ApiContext.Dispose();
        GC.SuppressFinalize(this);
    }
}
