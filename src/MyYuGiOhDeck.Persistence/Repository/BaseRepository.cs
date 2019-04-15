using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyYuGiOhDeck.Domain.Entities;
using MyYuGiOhDeck.Domain.Interfaces;
using MyYuGiOhDeck.Persistence.Context;

namespace MyYuGiOhDeck.Persistence.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : EntityBase
    {
        protected readonly MyYuGiOhDeckDbContext _context;
        protected readonly DbSet<T> _db;

        public BaseRepository(MyYuGiOhDeckDbContext context)
        {
            _context = context;
            _db = _context.Set<T>();
        }
        public async Task<bool> DeleteAsync(T obj)
        {
            _db.Remove(obj);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IList<T>> GetAllAsync()
        {
            var cards = await _db
                        .ToListAsync();
            return cards;
        }

        public async Task<T> GetByIdAsync(string id)
        {
            return await _db
                .FirstOrDefaultAsync(x => x.Id.Equals(id));
        }

        public async Task<T> InsertAsync(T obj)
        {
            await _db.AddAsync(obj);
            await _context.SaveChangesAsync();
            return obj;
        }
    }
}
