using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscribersApp.Domain.Contracts
{
    public interface IEntityService<T>
    {
        IList<T> GetAll();
        T GetById(int id);
        T Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
