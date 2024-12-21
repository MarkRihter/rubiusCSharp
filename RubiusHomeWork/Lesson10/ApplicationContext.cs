using Lesson10.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lesson10;

public sealed class ApplicationContext : DbContext
{
    public DbSet<Equipment> Equipments { get; set; }

    public ApplicationContext() => Database.EnsureCreated();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(
            "Host=localhost;Port=5432;Database=equipments;Username=mark;Password=PGkafPv6");
    }
}