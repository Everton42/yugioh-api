using Microsoft.EntityFrameworkCore;
using MyYuGiOhDeck.Domain.Entities;
using MyYuGiOhDeck.Persistence.Configuration;

namespace MyYuGiOhDeck.Persistence.Context
{
    public class MyYuGiOhDeckDbContext : DbContext
    {
        public MyYuGiOhDeckDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<SpellTrapCard> SpellTrapCard { get; set; }
        public DbSet<MonsterCard> MonsterCard { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SpellTrapCard>(new SpellTrapCardConfiguration().Configure);
            modelBuilder.Entity<MonsterCard>(new MonsterCardConfiguration().Configure);
            modelBuilder.Entity<LinkMonsterCard>().ToTable("LinkMonsterCard").HasBaseType<MonsterCard>();
            modelBuilder.Entity<PendulumMonsterCard>().ToTable("PendulumMonsterCard").HasBaseType<MonsterCard>();
        }
    }
}
