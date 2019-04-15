using MyYuGiOhDeck.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyYuGiOhDeck.Domain.Interfaces
{
    public interface IRepository<T> where T : EntityBase
    {
        Task<T> InsertAsync(T obj);
        Task<bool> DeleteAsync(T obj);
        Task<T> GetByIdAsync(string id);
        Task<IList<T>> GetAllAsync();
    }
}
