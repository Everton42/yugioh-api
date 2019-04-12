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

        public DbSet<Card> Card { get; set; }
        //public DbSet<MonsterCard> MonsterCard { get; set; }
        //public DbSet<LinkMonsterCard> LinkMonsterCard { get; set; }
        //public DbSet<PendulumMonsterCard> PendulumMonsterCard { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Card>(new CardConfiguration().Configure);
            modelBuilder.Entity<MonsterCard>().ToTable("MonsterCard");
            modelBuilder.Entity<LinkMonsterCard>().ToTable("LinkMonsterCard");
            modelBuilder.Entity<PendulumMonsterCard>().ToTable("PendulumMonsterCard");
        }
    }
}
