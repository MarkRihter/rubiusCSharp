using Lesson11.Configurations;
using Lesson11.Entities;
using Microsoft.EntityFrameworkCore;


namespace Lesson11;

public sealed class ApplicationContext : DbContext
{
    public DbSet<Author> Authors { get; set; } = null!;


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        DotNetEnv.Env.TraversePath().Load();

        var connectionString = Environment.GetEnvironmentVariable("POSTGRES_CONNECTION_STRING");

        optionsBuilder.UseNpgsql(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AuthorConfiguration());
        modelBuilder.ApplyConfiguration(new AuthorDataConfiguration());
        modelBuilder.ApplyConfiguration(new BookConfiguration());
        modelBuilder.ApplyConfiguration(new GenreConfiguration());
    }
}