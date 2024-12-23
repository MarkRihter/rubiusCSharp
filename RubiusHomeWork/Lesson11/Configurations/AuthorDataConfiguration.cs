using Lesson11.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lesson11.Configurations;

public class AuthorDataConfiguration : IEntityTypeConfiguration<AuthorData>
{
    public void Configure(EntityTypeBuilder<AuthorData> builder)
    {
        builder.Property(ad => ad.Name).HasMaxLength(100);
        builder.Property(ad => ad.BirthPlace).HasMaxLength(100);
        builder.Property(ad => ad.Bio).HasMaxLength(1000);
    }
}