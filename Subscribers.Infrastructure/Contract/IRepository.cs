using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Subscribers.Infrastructure.Contract
{
    public interface IRepository<T>
    {
        IList<T> Get(
          Expression<Func<T, bool>> filter = null,
          Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
          string includeProperties = "");
        T GetByID(int id);
        T Insert(T entity);
        void Delete(int id);
        void Delete(T entityToDelete);
        void Update(T entityToUpdate);
    }
}
