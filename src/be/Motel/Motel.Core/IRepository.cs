using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Motel.Core
{
    public interface IRepository
    {
        Task AddAsync<TEntity>(TEntity entity) where TEntity : BaseEntity;

        Task AddRangeAsync<TEntity>(IEnumerable<TEntity> entities) where TEntity : BaseEntity;

        Task DeleteRangeAsync<TEntity>(IEnumerable<Guid> ids) where TEntity : BaseEntity;
        
        Task DeleteRangeAsync<TEntity, TKey>(IEnumerable<TEntity> entities) where TEntity : BaseEntity;

        Task DeleteAsync<TEntity>(TEntity entity) where TEntity : BaseEntity;

        Task DeleteAsync<TEntity>(Guid id) where TEntity : BaseEntity;

        Task<IEnumerable<TEntity>> FindAllAsync<TEntity>(Expression<Func<TEntity, bool>> where = null, Expression<Func<TEntity, TEntity>> selector = null, IEnumerable<string> includes = null) where TEntity : BaseEntity;

        Task<IEnumerable<TEntity>> FindAllAsync<TEntity>(IQueryable<TEntity> query, Expression<Func<TEntity, TEntity>> selector = null) where TEntity : BaseEntity;

        Task<TEntity> FindAsync<TEntity>(Expression<Func<TEntity, bool>> where = null, IEnumerable<string> includes = null) where TEntity : BaseEntity;

        Task<TEntity> FindAsync<TEntity>(Guid id) where TEntity : BaseEntity;

        Task<TEntity> FindAsync<TEntity>(Guid id, IEnumerable<string> includes = null) where TEntity : BaseEntity;

        IQueryable<TEntity> GetQueryable<TEntity>() where TEntity : BaseEntity;

        Task SaveChangeAsync();

        Task UpdateAsync<TEntity>(TEntity entity) where TEntity : BaseEntity;

        Task UpdateRangeAsync<TEntity>(IEnumerable<TEntity> entites) where TEntity : BaseEntity;
    }
}
