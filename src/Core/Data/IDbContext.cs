using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Data
{
    /// <summary>
    /// A generic abstraction of a database context
    /// </summary>
    public interface IDbContext
    {
        /// <summary>
        /// Returns a reference to a set of entities from the data source
        /// </summary>
        /// <typeparam name="TEntity">The type of entities to reference from the data source</typeparam>
        /// <returns>A reference to a set of entities from the data source</returns>
        ICollection<TEntity> Set<TEntity>() where TEntity : class;

        /// <summary>
        /// A mechanism for tracking entities to be added or modified in the data source
        /// </summary>
        ICollection<object> Tracker { get; }

        /// <summary>
        /// Persists all pending changes to the data source
        /// </summary>
        /// <returns>Count of rows affected</returns>
        int SaveChanges();

        /// <summary>
        /// Persists all pending changes to the data source asyncronously
        /// </summary>
        /// <returns>Count of rows affected</returns>
        Task<int> SaveChangesAsync();
    }
}
