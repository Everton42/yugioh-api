using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyYuGiOhDeck.Domain.Entities;

namespace MyYuGiOhDeck.Persistence.Configuration
{
    public class MonsterCardConfiguration : IEntityTypeConfiguration<MonsterCard>
    {
        public void Configure(EntityTypeBuilder<MonsterCard> builder)
        {
            builder.ToTable("MonsterCard");

            builder.Property(e => e.Attack);

            builder.Property(e => e.Defence);

            builder.Property(e => e.Level);

            builder.Property(e => e.Attribute);
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(300);

            builder.Property(e => e.Type)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.Archetype)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(e => e.Race)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(e => e.Setcode)
                .HasMaxLength(300);

            builder.Property(e => e.SetTag)
                .HasMaxLength(200);

            builder.Property(e => e.ImageUrl)
                .HasMaxLength(300);

            builder.Property(e => e.ImageUrlSmall)
                .HasMaxLength(300);
        }
    }
}
