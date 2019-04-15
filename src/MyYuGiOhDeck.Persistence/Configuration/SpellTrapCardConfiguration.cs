using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyYuGiOhDeck.Domain.Entities;

namespace MyYuGiOhDeck.Persistence.Configuration
{
    public class SpellTrapCardConfiguration : IEntityTypeConfiguration<SpellTrapCard>
    {
        public void Configure(EntityTypeBuilder<SpellTrapCard> builder)
        {
            builder.ToTable("SpellTrapCard");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(800);

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
                .HasMaxLength(400);

            builder.Property(e => e.SetTag)
                .HasMaxLength(400);

            builder.Property(e => e.ImageUrl)
                .HasMaxLength(300);

            builder.Property(e => e.ImageUrlSmall)
                .HasMaxLength(300);

        }
    }
}
