using Subscribers.Infrastructure.Contract;
using SubscribersApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Subscribers.Infrastructure
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        internal SubscribersAppContext context;
        internal DbSet<T> dbSet;

        public Repository(SubscribersAppContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }
        public void Delete(int id)
        {
            T entityToDelete = dbSet.Find(id);
            Delete(entityToDelete);
        }

        public void Delete(T entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
        }

        public IList<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }
            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public T GetByID(int id)
        {
            return dbSet.Find(id);
        }

        public T Insert(T entity)
        {
            return dbSet.Add(entity);
        }

        public void Update(T entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}
