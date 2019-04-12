using System.Collections.Generic;

namespace MyYuGiOhDeck.Domain.Interfaces
{
    public interface IRepository<T>
    {
        void Insert(T obj);
        void Update(T obj);
        void Delete(string id);
        T GetById(string id);
        IList<T> GetAll();
    }
}
