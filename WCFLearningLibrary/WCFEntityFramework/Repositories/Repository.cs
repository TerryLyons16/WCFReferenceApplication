using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Repository.RepositoryInterfaces;

using Repository.Entities;

namespace EntityFramework.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : EntityBase
    {

        protected bool _shareContext = false;

        protected ForumDBContext context;

        public Repository()
        {
            context = new ForumDBContext();
        }

        public Repository(ForumDBContext c)
        {
            context = c;
            //If the Repository is passed a context, then it is being shared by a unit of work, so don't
            //do individual saves within the repository. Let the context's owner (i.e. the Unit of Work)
            //do the saving
            _shareContext = true;
        }

        protected DbSet<T> DbSet
        {
            get
            {
                return context.Set<T>();
            }
        }

        public IQueryable<T> All()
        {
            return DbSet.AsQueryable();
        }

        public bool Contains(Expression<Func<T, bool>> predicate)
        {
            return DbSet.Count(predicate) > 0;
        }

        public int Count
        {
            get
            {
                return DbSet.Count();
            }
        }

        public T Create(T entity)
        {
            var newItem = DbSet.Add(entity);
            if (!_shareContext)//If the context is shared, it is up to its owner (i.e. the Unit Of Work) to save the changes
                context.SaveChanges();

            return entity;
        }

        public void Delete(Expression<Func<T, bool>> predicate)
        {
            var toDelete = Filter(predicate);
            foreach (var entry in toDelete)
            {
                DbSet.Remove(entry);
            }
            if (!_shareContext)
                context.SaveChanges();
        }

        public void Delete(T entity)
        {
            DbSet.Remove(entity);
            if (!_shareContext)
                context.SaveChanges();
        }

        public void Dispose()
        {
            if (!_shareContext && context != null)//Don't dispose the context if it is shared
            {
                context.Dispose();
            }
        }

        public IQueryable<T> Filter(Expression<Func<T, bool>> predicate)
        {
            return DbSet.Where(predicate).AsQueryable<T>();
        }

        public IQueryable<T> Filter(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50)
        {
            int skipCount = index * size;
            var _resetSet = filter != null ? DbSet.Where(filter).AsQueryable() : DbSet.AsQueryable();
            _resetSet = skipCount == 0 ? _resetSet.Take(size) : _resetSet.Skip(skipCount).Take(size);
            total = _resetSet.Count();
            return _resetSet.AsQueryable();
        }

        public T Find(Expression<Func<T, bool>> predicate)
        {
            return DbSet.FirstOrDefault(predicate);
        }

        public T Find(params object[] keys)
        {
            return DbSet.Find(keys);
        }

        public void Update(T entity)
        {
            var entry = context.Entry(entity);
            DbSet.Attach(entity);

            entry.State = EntityState.Modified;
            if (!_shareContext)
                context.SaveChanges();
        }
    }
}
