using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Repository.Entities;

namespace Repository.RepositoryInterfaces
{
    public interface IRepository<T>: IDisposable where T:EntityBase
    {
        /// <summary>
        /// Gets all objects from database
        /// </summary>
        /// <returns></returns>
        IQueryable<T> All();

        /* NOTE: Should not expose LINQ methods outside repository:
         "Let’s get it straight.There are no complete LINQ to SQL implementations.
         They all are either missing features or implement things like eager/lazy loading in their own way.
         That means that they all are leaky abstractions. So if you expose LINQ outside your repository you get a leaky abstraction.
         You could really stop using the repository pattern then and use the OR/M directly."
         - https://www.codeproject.com/Articles/526874/Repositorypluspattern-cplusdoneplusright
         */

        /// <summary>
        /// Gets objects from database by filter.
        /// </summary>
        /// <param name="predicate">Specified a filter</param>
        /// <returns></returns>
        IQueryable<T> Filter(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Gets objects from database with filtering and paging.
        /// </summary>
        /// <typeparam name="Key"></typeparam>
        /// <param name="filter">Specified a filter</param>
        /// <param name="total">Returns the total records count of the filter.</param>
        /// <param name="index">Specified the page index.</param>
        /// <param name="size">Specified the page size</param>
        /// <returns></returns>
        IQueryable<T> Filter(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50);

        /// <summary>
        /// Determine if the object exists in database by specified filter.
        /// </summary>
        /// <param name="predicate">Specified the filter expression</param>
        /// <returns></returns>
        bool Contains(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Find object by keys.
        /// </summary>
        /// <param name="keys">Specified the search keys.</param>
        /// <returns></returns>
        T Find(params object[] keys);

        /// <summary>
        /// Find object by specified expression.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        T Find(Expression<Func<T, bool>> predicate);


        /// <summary>
        /// Get the total objects count.
        /// </summary>
        int Count { get; }

      
        T Create(T entity);
        void Delete(T entity);

        /// <summary>
        /// Delete objects from database by specified filter expression.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        void Delete(Expression<Func<T, bool>> predicate);
        void Update(T entity);
      
    }
}
