using CharacterManager.Domain.DataContracts.Shared;
using CharacterManager.Domain.Models.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterManager.Domain.SQL.Shared
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : Entity
    {

        protected DbSet<TEntity> DbSet;
        protected DbContext DbContext;
        protected BaseRepository(DbContext dbContext)
        {
            DbContext = dbContext;
            DbSet = DbContext.Set<TEntity>();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await DbSet.OrderBy(x => x.CreatedAt).ToListAsync();
        }
        public virtual async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await DbSet.Where(x => x.Id == id).FirstAsync();
        }

        public virtual async Task AddAsync(TEntity entity)
        {
            await DbSet.AddAsync(entity).ConfigureAwait(false);
        }

        public virtual async Task AddCollectionAsync(IEnumerable<TEntity> entities)
        {
            await DbSet.AddRangeAsync(entities).ConfigureAwait(false);
        }

        public virtual Task UpdateAsync(TEntity entity)
        {
            DbSet.Update(entity);
            return Task.CompletedTask;
        }

        public virtual Task UpdateCollectionAsync(IEnumerable<TEntity> entities)
        {
            DbSet.UpdateRange(entities);
            return Task.CompletedTask;
        }
        public virtual Task RemoveAsync(TEntity entity)
        {
            DbSet.Remove(entity);
            return Task.CompletedTask;
        }

        public Task RemoveByIdAsync(Guid id)
        {
            DbSet.Remove(DbSet.Where(x => x.Id == id).First());
            return Task.CompletedTask;
        }
        public virtual async Task SaveChangesAsync()
        {
            await DbContext.SaveChangesAsync().ConfigureAwait(false);
        }

    }
}
