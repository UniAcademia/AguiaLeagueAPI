using AguiaLeague.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AguiaLeague.Data.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(m => m.Id);
        builder.Property(m => m.Nome).IsRequired();
        builder.Property(m => m.Tag).IsRequired();

        builder.ToTable("User");
    }
}