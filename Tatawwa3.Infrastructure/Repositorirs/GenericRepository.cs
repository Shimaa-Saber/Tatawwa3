using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Infrastructure.Data;

namespace Tatawwa3.Infrastructure.Repositorirs
{
    public class GenericRepository<T> : IGeneric<T> where T : BaseModel
    {
        private readonly Tatawwa3DbContext _tatawwa3DbContext;
        public GenericRepository(Tatawwa3DbContext tatawwa3DbContext)
        {
            _tatawwa3DbContext = tatawwa3DbContext;
        }

        public void Add(T category)
        {
            _tatawwa3DbContext.Set<T>().Add(category);
        }

        public void UpdatebyId(string id, T newentity)
        {
            var entity = GetByID(id);
            if (entity is not null)
            {
                _tatawwa3DbContext.Set<T>().Update(newentity);
            }
        }

        public void Remove(string id)
        {
            var entity = GetByID(id);
            if (entity is not null)
            {
                entity.IsDeleted = true;
                UpdateByEntity(entity);
            }
        }

        public IQueryable<T> GetAll()
        {
            return _tatawwa3DbContext.Set<T>().
                    Where(e => e.IsDeleted == false);
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> expression)
        {
            return _tatawwa3DbContext.Set<T>().Where(expression);
        }

        public T GetByID(string id)
        {

            return Get(e => e.Id == id && e.IsDeleted == false).FirstOrDefault();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _tatawwa3DbContext.SaveChangesAsync();
        }

        public void UpdateByEntity(T entity)
        {
            _tatawwa3DbContext.Set<T>().Update(entity);
        }

        public IQueryable<T> GetWithIncludes(params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _tatawwa3DbContext.Set<T>();
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            return query.Where(e => !e.IsDeleted);
        }

        public IQueryable<T> GetQueryable(bool includeSoftDeleted = false)
        {
            var query = _tatawwa3DbContext.Set<T>().AsQueryable();
            return includeSoftDeleted ? query : query.Where(e => !e.IsDeleted);
        }


        public async Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return await _tatawwa3DbContext.Set<T>().FirstOrDefaultAsync(predicate);
        }

        public Task<int> CountAsync()
        {
            return _tatawwa3DbContext.Set<T>().CountAsync();
        }

        public Task<int> CountAsync(Expression<Func<T, bool>> predicate)
        {
            return _tatawwa3DbContext.Set<T>().CountAsync(predicate);
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
            _tatawwa3DbContext.Set<T>().UpdateRange(entities);
        }

    }
}
