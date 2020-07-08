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
            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<TEntity>> AddCollectionAsync(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                entity.Id = Guid.NewGuid();
                entity.CreatedAt = DateTime.Now;
            }
            await _repository.AddCollectionAsync(entities);
            await _repository.SaveChangesAsync();
            return entities;
        }

        public async Task DeleteByIdAsync(Guid id)
        {
            await _repository.RemoveByIdAsync(id);
            await _repository.SaveChangesAsync();

        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            await _repository.UpdateAsync(entity);
            await _repository.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<TEntity>> UpdateCollectionAsync(IEnumerable<TEntity> entities)
        {
            await _repository.UpdateCollectionAsync(entities);
            await _repository.SaveChangesAsync();
            return entities;
        }
    }
}
