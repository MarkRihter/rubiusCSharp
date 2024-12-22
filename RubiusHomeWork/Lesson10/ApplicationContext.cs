using Lesson10.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Lesson10;

public sealed class ApplicationContext : DbContext
{
    public DbSet<Equipment> Equipments { get; set; }

    public ApplicationContext() => Database.EnsureCreated();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        DotNetEnv.Env.TraversePath().Load();

        var user = Environment.GetEnvironmentVariable(@"POSTGRES_USER");
        var password = Environment.GetEnvironmentVariable(@"POSTGRES_PASSWORD");
        var database = Environment.GetEnvironmentVariable(@"POSTGRES_DB");
        var port = Environment.GetEnvironmentVariable(@"POSTGRES_PORT");
        var host = Environment.GetEnvironmentVariable(@"POSTGRES_HOST");

        optionsBuilder.UseNpgsql($"Host={host};Port={port};Database={database};Username={user};Password={password}");
    }
}