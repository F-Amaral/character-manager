using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CharacterManager.Application.Interfaces.Shared
{
    public interface IBaseService<TEntity>
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(Guid id);
        Task<TEntity> AddAsync(TEntity entity);
        Task<IEnumerable<TEntity>> AddCollectionAsync(IEnumerable<TEntity> entities);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<IEnumerable<TEntity>> UpdateCollectionAsync(IEnumerable<TEntity> entities);
        Task DeleteByIdAsync(Guid id);
    }
}
