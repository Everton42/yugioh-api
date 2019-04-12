using System.Collections.Generic;
using MyYuGiOhDeck.Domain.Interfaces;

namespace MyYuGiOhDeck.Persistence.Repository
{
    public class BaseRepository<T> : IRepository<T>
    {
        public void Delete(string id)
        {
            throw new System.NotImplementedException();
        }

        public IList<T> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public T GetById(string id)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(T obj)
        {
            throw new System.NotImplementedException();
        }

        public void Update(T obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
