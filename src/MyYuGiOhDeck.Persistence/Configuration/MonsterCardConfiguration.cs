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
        }
    }
}
