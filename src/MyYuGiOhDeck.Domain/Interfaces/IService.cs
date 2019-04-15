using FluentValidation;
using MyYuGiOhDeck.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyYuGiOhDeck.Domain.Interfaces
{
    public interface IService<T> where T : EntityBase 
    {
        Task<T> InsertAsync<V>(T obj) where V : AbstractValidator<T>;
        Task<bool> DeleteAsync(string id);
        Task<T> GetByIdAsync(string id);
        Task<IList<T>> GetAllAsync();
    }
}
