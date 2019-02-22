using System.Collections.Generic;
using System.Linq;

namespace Core.Data
{
    /// <summary>
    /// A generic abstraction of a repository of data
    /// </summary>
    /// <typeparam name="TEntity">The type of Entites that belong to this repository</typeparam>
    public interface IRepository<TEntity>
    {
        /// <summary>
        /// Adds a new entity to the repository
        /// </summary>
        /// <param name="entity">The entity to add to the repository</param>
        void Add(TEntity entity);

        /// <summary>
        /// Deletes an entity from the repository
        /// </summary>
        /// <param name="entity">The entity to delete from the repository</param>
        void Delete(TEntity entity);

        /// <summary>
        /// Gets all entities from the repository
        /// </summary>
        /// <returns>All entities from the repository</returns>
        IEnumerable<TEntity> GetAll();

        /// <summary>
        /// Queries the repository
        /// </summary>
        /// <returns>An expression that can be used to query the repository</returns>
        IQueryable<TEntity> Query();
    }
}
