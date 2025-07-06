using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Domain.Interfaces
{
    public interface IGeneric<T>
    {
        void Add(T entity);
        void UpdatebyId(string id, T entity);
        void UpdateByEntity(T entity);
        void Remove(string id);
        T GetByID(string id);
        IQueryable<T> GetAll();
        IQueryable<T> Get(Expression<Func<T, bool>> expression);
        IQueryable<T> GetWithIncludes(params Expression<Func<T, object>>[] includes);

        Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);

        IQueryable<T> GetQueryable(bool includeSoftDeleted = false);


        Task<int> SaveChangesAsync();

        Task<int> CountAsync();
        Task<int> CountAsync(Expression<Func<T, bool>> predicate);

        void UpdateRange(IEnumerable<T> entities);
    }
}
