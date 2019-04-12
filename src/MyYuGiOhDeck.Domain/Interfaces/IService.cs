using FluentValidation;
using System.Collections.Generic;

namespace MyYuGiOhDeck.Domain.Interfaces
{
    public interface IService<T>
    {
        void Insert<V>(T obj) where V : AbstractValidator<T>;
        void Update<V>(T obj) where V : AbstractValidator<T>;
        void Delete(string id);
        T GetById(string id);
        IList<T> GetAll();
    }
}
