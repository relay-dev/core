using Core.Framework;

namespace Core.Data
{
    /// <summary>
    /// Creates types that implement the IRepository interface for Commands
    /// </summary>
    public interface IRepositoryFactory : IFactory
    {
        /// <summary>
        /// Creates the Repository type requested
        /// </summary>
        /// <typeparam name="TEntity">Type of the Repository to be returned</typeparam>
        /// <returns>A new instance of an object of type IRepository</returns>
        new IRepository<TEntity> Create<TEntity>();
    }
}
