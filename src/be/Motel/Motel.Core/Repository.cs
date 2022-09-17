using Microsoft.EntityFrameworkCore;
using Motel.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Motel.Core
{
    public class Repository : IRepository
    {
        private readonly AppDataContext _context;

        public Repository(AppDataContext context)
        {
            _context = context;
        }
        public async Task AddAsync<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            _context.Set<TEntity>().Add(entity);
            await SaveChangeAsync();
        }

        public async Task AddRangeAsync<TEntity>(IEnumerable<TEntity> entities) where TEntity : BaseEntity
        {
            _context.Set<TEntity>().AddRange(entities);
            await SaveChangeAsync();
        }

        public async Task DeleteAsync<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            _context.Set<TEntity>().Remove(entity);
            await SaveChangeAsync();
        }

        public async Task DeleteAsync<TEntity>(Guid id) where TEntity : BaseEntity
        {
            var entity = _context.Set<TEntity>().FirstOrDefault(c => c.Id.Equals(id));
            if(entity != null)
            {
                _context.Set<TEntity>().Remove(entity);
                await SaveChangeAsync();
            }
        }

        public async Task DeleteRangeAsync<TEntity>(IEnumerable<Guid> ids) where TEntity : BaseEntity
        {
            var entities = _context.Set<TEntity>().Where(c => ids.Contains(c.Id));
            _context.RemoveRange(entities);
            await SaveChangeAsync();
        }

        public async Task<IEnumerable<TEntity>> FindAllAsync<TEntity>(Expression<Func<TEntity, bool>> where = null, Expression<Func<TEntity, TEntity>> selector = null, IEnumerable<string> includes = null) where TEntity : BaseEntity
        {
            var query = AsQueryable<TEntity>(includes).AsNoTracking();
            if(where != null)
            {
                query = query.Where(where);
            }

            return await query.Select(selector).ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> FindAllAsync<TEntity>(IQueryable<TEntity> query, Expression<Func<TEntity, TEntity>> selector = null) where TEntity : BaseEntity
        {
            return await query.Select(selector).ToListAsync();
        }

        public async Task<TEntity> FindAsync<TEntity>(Expression<Func<TEntity, bool>> where = null, IEnumerable<string> includes = null) where TEntity : BaseEntity
        {
            var query = AsQueryable<TEntity>(includes);
            return await query.Where(where).FirstOrDefaultAsync();
        }

        public async Task<TEntity> FindAsync<TEntity>(Guid id) where TEntity : BaseEntity
        {
            return await AsQueryable<TEntity>().FirstOrDefaultAsync(c => c.Id.Equals(id));
        }

        public async Task<TEntity> FindAsync<TEntity>(Guid id, IEnumerable<string> includes = null) where TEntity : BaseEntity
        {
            return await AsQueryable<TEntity>(includes).FirstOrDefaultAsync(c => c.Id.Equals(id));

        }

        public IQueryable<TEntity> GetQueryable<TEntity>() where TEntity : BaseEntity
        {
            return AsQueryable<TEntity>();
        }

        public Task UpdateAsync<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            throw new NotImplementedException();
        }

        public Task UpdateRangeAsync<TEntity>(IEnumerable<TEntity> entites) where TEntity : BaseEntity
        {
            throw new NotImplementedException();
        }

        public async Task SaveChangeAsync()
        {
            await _context.SaveChangesAsync();
        }

        private IQueryable<TEntity> AsQueryable<TEntity>(IEnumerable<string> includes = null) where TEntity : BaseEntity
        {
            var query = _context.Set<TEntity>().AsQueryable();
            if (includes?.Any() != true)
            {
                return query;
            }

            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            return query;
        }
    }
}
