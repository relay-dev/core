using System.Threading.Tasks;

namespace Core.Data
{
    /// <summary>
    /// A generic abstraction of a repository of data capable of being paginated
    /// </summary>
    /// <typeparam name="TEntity">The type of entites that belong to this repository</typeparam>
    public interface IPageableRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Gets a pageable sequence of entities
        /// </summary>
        /// <returns>A pageable sequence of entities</returns>
        IPageable<TEntity> Page();

        /// <summary>
        /// Gets a pageable sequence of entities
        /// </summary>
        /// <returns>A pageable sequence of entities</returns>
        Task<IPageable<TEntity>> PageAsync();
    }
}
