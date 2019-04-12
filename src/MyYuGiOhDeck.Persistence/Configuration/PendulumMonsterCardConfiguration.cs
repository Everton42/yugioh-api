using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyYuGiOhDeck.Domain.Entities;

namespace MyYuGiOhDeck.Persistence.Configuration
{
    public class PendulumMonsterCardConfiguration : IEntityTypeConfiguration<PendulumMonsterCard>
    {
        public void Configure(EntityTypeBuilder<PendulumMonsterCard> builder)
        {
            builder.ToTable("PendulumMonster");

            builder.Property(e => e.Scale);
        }
    }
}
