using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Motel.Core
{
    public class Repository : IRepository
    {
        public Task AddAsync<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            throw new NotImplementedException();
        }

        public Task AddRangeAsync<TEntity>(IEnumerable<TEntity> entities) where TEntity : BaseEntity
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync<TEntity>(Guid id) where TEntity : BaseEntity
        {
            throw new NotImplementedException();
        }

        public Task DeleteRangeAsync<TEntity>(IEnumerable<Guid> ids) where TEntity : BaseEntity
        {
            throw new NotImplementedException();
        }

        public Task DeleteRangeAsync<TEntity, TKey>(IEnumerable<TEntity> entities) where TEntity : BaseEntity
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> FindAllAsync<TEntity>(Expression<Func<TEntity, bool>> where = null, Expression<Func<TEntity, TEntity>> selector = null, IEnumerable<string> includes = null) where TEntity : BaseEntity
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> FindAllAsync<TEntity>(IQueryable<TEntity> query, Expression<Func<TEntity, TEntity>> selector = null) where TEntity : BaseEntity
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> FindAsync<TEntity>(Expression<Func<TEntity, bool>> where = null, IEnumerable<string> includes = null) where TEntity : BaseEntity
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> FindAsync<TEntity>(Guid id) where TEntity : BaseEntity
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> FindAsync<TEntity>(Guid id, IEnumerable<string> includes = null) where TEntity : BaseEntity
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetQueryable<TEntity>() where TEntity : BaseEntity
        {
            throw new NotImplementedException();
        }

        public Task SaveChangeAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            throw new NotImplementedException();
        }

        public Task UpdateRangeAsync<TEntity>(IEnumerable<TEntity> entites) where TEntity : BaseEntity
        {
            throw new NotImplementedException();
        }
    }
}
