using CharacterManager.Application.Interfaces.Shared;
using CharacterManager.Domain.DataContracts.Shared;
using CharacterManager.Domain.Models.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CharacterManager.Application.Services.Shared
{
    public class BaseService<TEntity, TRepository> : IBaseService<TEntity>
        where TEntity : Entity
        where TRepository : IBaseRepository<TEntity>
    {
        protected readonly TRepository _repository;

        public BaseService(TRepository repository)
        {
            _repository = repository;
        }


        public async Task<TEntity> AddAsync(TEntity entity)
        {
            entity.Id = Guid.NewGuid();
            entity.CreatedAt = DateTime.Now;
            await _repository.InsertOneAsync(entity);
            return entity;
        }

        public async Task<ICollection<TEntity>> AddCollectionAsync(ICollection<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                entity.Id = Guid.NewGuid();
                entity.CreatedAt = DateTime.Now;
            }
            await _repository.InsertManyAsync(entities);
            return entities;
        }

        public async Task DeleteByIdAsync(Guid id)
        {
            await _repository.DeleteByIdAsync(id);

        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _repository.FilterByAsync(_ => true);
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await _repository.FindByIdAsync(id);
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            await _repository.ReplaceOneAsync(entity);
            return entity;
        }
    }
}
