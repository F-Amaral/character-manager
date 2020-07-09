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
        Task<ICollection<TEntity>> AddCollectionAsync(ICollection<TEntity> entities);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task DeleteByIdAsync(Guid id);
    }
}
