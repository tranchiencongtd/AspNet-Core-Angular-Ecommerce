﻿using System.Threading;
using System.Threading.Tasks;
using Ecommerce.Data;
using Ecommerce.Seeding;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Volo.Abp;
using Volo.Abp.Data;

namespace Ecommerce.DbMigrator;

public class DbMigratorHostedService : IHostedService
{
    private readonly IHostApplicationLifetime _hostApplicationLifetime;
    private readonly IConfiguration _configuration;

    public DbMigratorHostedService(IHostApplicationLifetime hostApplicationLifetime, IConfiguration configuration)
    {
        _hostApplicationLifetime = hostApplicationLifetime;
        _configuration = configuration;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        using IAbpApplicationWithInternalServiceProvider application = await AbpApplicationFactory.CreateAsync<EcommerceDbMigratorModule>(options =>
        {
            _ = options.Services.ReplaceConfiguration(_configuration);
            options.UseAutofac();
            _ = options.Services.AddLogging(c => c.AddSerilog());
            options.AddDataMigrationEnvironment();
        });
        await application.InitializeAsync();

        await application
            .ServiceProvider
            .GetRequiredService<EcommerceDbMigrationService>()
            .MigrateAsync();

        await application
            .ServiceProvider
            .GetRequiredService<IdentityDataSeeder>()
            .SeedAsync("admin@gmail.com", "Abc@123$");

        await application.ShutdownAsync();

        _hostApplicationLifetime.StopApplication();
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}