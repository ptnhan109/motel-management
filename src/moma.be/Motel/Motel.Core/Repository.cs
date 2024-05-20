using DocumentFormat.OpenXml.Office2010.PowerPoint;
using Microsoft.EntityFrameworkCore;
using Motel.Common.Generics;
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
        public async Task<TEntity> AddAsync<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
            entity.IsDeleted = false;
            _context.Set<TEntity>().Add(entity);
            await SaveChangeAsync();

            return entity;
        }

        public async Task AddRangeAsync<TEntity>(IEnumerable<TEntity> entities) where TEntity : BaseEntity
        {
            var data = entities.ToList();
            data.ForEach(x => x.IsDeleted = false);
            _context.Set<TEntity>().AddRange(data);
            await SaveChangeAsync();
        }

        public async Task DeleteAsync<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            entity.IsDeleted = true;
            _context.Set<TEntity>().Update(entity);
            await SaveChangeAsync();
        }

        public async Task DeleteAsync<TEntity>(Guid id) where TEntity : BaseEntity
        {
            var entity = _context.Set<TEntity>().FirstOrDefault(c => c.Id.Equals(id));
            if(entity != null)
            {
                entity.IsDeleted = true;
                _context.Set<TEntity>().Update(entity);
                await SaveChangeAsync();
            }
        }

        public async Task DeleteRangeAsync<TEntity>(IEnumerable<Guid> ids) where TEntity : BaseEntity
        {
            var entities = _context.Set<TEntity>().Where(c => ids.Contains(c.Id)).ToList();
            entities.ForEach(element => element.IsDeleted = true);
            _context.UpdateRange(entities);
            await SaveChangeAsync();
        }


        public async Task DeleteRangeAsync<TEntity>(Expression<Func<TEntity, bool>> where = null) where TEntity : BaseEntity
        {
            var entities = _context.Set<TEntity>().Where(where)
                .ToList();
            entities.ForEach(element => element.IsDeleted = true);
            _context.UpdateRange(entities);
            await SaveChangeAsync();
        }

        public async Task<IEnumerable<TEntity>> FindAllAsync<TEntity>(Expression<Func<TEntity, bool>> where = null, Expression<Func<TEntity, TEntity>> selector = null, IEnumerable<string> includes = null) where TEntity : BaseEntity
        {
            var query = AsQueryable<TEntity>(includes).AsNoTracking();
            if(where != null)
            {
                query = query.Where(where);
            }

            if(selector is null)
            {
                return await query.ToListAsync();
            }

            return await query.Select(selector).ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> FindAllAsync<TEntity>(IQueryable<TEntity> query, Expression<Func<TEntity, TEntity>> selector = null) where TEntity : BaseEntity
        {
            if(selector is null)
            {
                return await query.ToListAsync();
            }
            return await query.Select(selector).ToListAsync();
        }

        public async Task<TEntity> FindAsync<TEntity>(Expression<Func<TEntity, bool>> where = null, IEnumerable<string> includes = null) where TEntity : BaseEntity
        {
            var query = AsQueryable<TEntity>(includes);
            return await query.Where(where).FirstOrDefaultAsync();
        }

        public async Task<TEntity> FindAsync<TEntity>(Guid id) where TEntity : BaseEntity
        {
            return await AsQueryable<TEntity>().AsNoTracking().FirstOrDefaultAsync(c => c.Id.Equals(id));
        }

        public async Task<TEntity> FindNewestAsync<TEntity>(IEnumerable<string> includes) where TEntity : BaseEntity
        {
            var query = GetQueryable<TEntity>(includes);
            query = query.OrderByDescending(c => c.CreatedAt);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<TEntity> FindAsync<TEntity>(Guid id, IEnumerable<string> includes = null) where TEntity : BaseEntity
        {
            return await AsQueryable<TEntity>(includes).AsNoTracking().FirstOrDefaultAsync(c => c.Id.Equals(id));

        }

        public IQueryable<TEntity> GetQueryable<TEntity>() where TEntity : BaseEntity
        {
            return AsQueryable<TEntity>();
        }

        public async Task UpdateAsync<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
             _context.Set<TEntity>().Update(entity);
            await SaveChangeAsync();
        }

        public async Task UpdateRangeAsync<TEntity>(IEnumerable<TEntity> entites) where TEntity : BaseEntity
        {
            var data = entites.ToList();
            data.ForEach(x => x.IsDeleted = false);
            _context.Set<TEntity>().UpdateRange(data);
            await _context.SaveChangesAsync();
        }

        public async Task SaveChangeAsync()
        {
            await _context.SaveChangesAsync();
        }


        public async Task<PagedResult<TEntity>> FindPagedAsync<TEntity>(IQueryable<TEntity> query, int? pageIndex = 1, int? pageSize = 20) where TEntity : BaseEntity
        {
            query = query.AsNoTracking();

            pageIndex = pageIndex.Value <= 0 ? 1 : pageIndex;
            pageSize = pageSize.Value <= 0 ? 20 : pageSize;

            var total = await query.CountAsync();

            query = query.OrderByDescending(c => c.CreatedAt).Skip((pageIndex.Value - 1) * pageSize.Value).Take(pageSize.Value);
            var data = await query.ToListAsync();
            return new PagedResult<TEntity>()
            {
                Items = data,
                PageIndex = pageIndex.Value,
                PageSize = pageSize.Value,
                TotalCount = total,

            };
        }

        private IQueryable<TEntity> AsQueryable<TEntity>(IEnumerable<string> includes = null) where TEntity : BaseEntity
        {
            var query = _context.Set<TEntity>()
                .Where(x => !x.IsDeleted.Value).AsQueryable();

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

        public IQueryable<TEntity> GetQueryable<TEntity>(IEnumerable<string> includes) where TEntity : BaseEntity
        {
            var query = GetQueryable<TEntity>();
            if(includes?.FirstOrDefault() != null)
            {
                foreach(var include in includes)
                {
                    query = query.Include(include);
                }
            }

            return query;
        }

        public async Task<int> CountAsync<TEntity>(Expression<Func<TEntity, bool>> where = null) where TEntity : BaseEntity
        {
            var query = GetQueryable<TEntity>();
            if(where != null)
            {
                query = query.Where(where);
            }

            return await query.CountAsync();
        }
    }
}
