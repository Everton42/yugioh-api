using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyYuGiOhDeck.Domain.Entities;

namespace MyYuGiOhDeck.Persistence.Configuration
{
    public class LinkMonsterCardConfiguration : IEntityTypeConfiguration<LinkMonsterCard>
    {
        public void Configure(EntityTypeBuilder<LinkMonsterCard> builder)
        {
            builder.ToTable("LinkMonsterCard");

            builder.Property(e => e.Linkval)
                .IsRequired();

            builder.Property(e => e.Linkmarkers)
                .IsRequired()
                .HasMaxLength(300);


        }

    }
}
