using FluentValidation;
using MyYuGiOhDeck.Domain.Entities;
using MyYuGiOhDeck.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyYuGiOhDeck.Service.Services
{
    public class BaseService<T> : IService<T> where T : EntityBase
    {
        protected IRepository<T> _repository;
        public BaseService(IRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var card = await GetByIdAsync(id);
            if (!card.Equals(null))
            {
                await _repository.DeleteAsync(card);
                return true;
            }
            return false;
        }

        public Task<IList<T>> GetAllAsync()
        {
            return _repository.GetAllAsync();
        }

        public async Task<T> GetByIdAsync(string id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<T> InsertAsync<V>(T obj) where V : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<V>());
            return await _repository.InsertAsync(obj);
        }

        private void Validate(T obj, AbstractValidator<T> validator)
        {
            if (obj == null)
                throw new Exception("Registros não encontrados!");

            validator.ValidateAndThrow(obj);
        }
    }
}
