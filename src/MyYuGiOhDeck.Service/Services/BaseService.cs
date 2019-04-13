using System;
using System.Collections.Generic;
using FluentValidation;
using MyYuGiOhDeck.Domain.Interfaces;
using MyYuGiOhDeck.Persistence.Repository;

namespace MyYuGiOhDeck.Service.Services
{
    public class BaseService<T> : IService<T>
    {
        private BaseRepository<T> repository = new BaseRepository<T>();

        public void Delete(string id)
        {
            repository.Delete(id);
        }

        public IList<T> GetAll() => repository.GetAll();

        public T GetById(string id)
        {
            return repository.GetById(id);
        }

        public void Insert<V>(T obj) where V : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<V>());

            repository.Insert(obj);
        }

        public void Update<V>(T obj) where V : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<V>());

            repository.Update(obj);
        }

        private void Validate(T obj, AbstractValidator<T> validator)
        {
            if (obj == null)
                throw new Exception("Registros não encontrados!");

            validator.ValidateAndThrow(obj);
        }
    }
}
