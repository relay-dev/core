using System.Threading.Tasks;

namespace Core.Framework.Services
{
    /// <summary>
    /// A generic abstraction of a service that contains all basic CRUD methods
    /// </summary>
    /// <typeparam name="TItem">The type of item being operated on</typeparam>
    public interface ICrudService<TItem> : IService
    {
        /// <summary>
        /// Creates the item
        /// </summary>
        /// <param name="item">The item to create</param>
        /// <returns>The Id of the item created</returns>
        long Create(TItem item);

        /// <summary>
        /// Creates the item asyncronously
        /// </summary>
        /// <param name="item">The item to create</param>
        /// <returns>The Id of the item created</returns>
        Task<long> CreateAsync(TItem item);

        /// <summary>
        /// Gets the item by Id
        /// </summary>
        /// <param name="id">The Id of the item to return</param>
        /// <returns>The item if found; otherwise, null</returns>
        TItem GetByID(long id);

        /// <summary>
        /// Gets the item by Id asyncronously
        /// </summary>
        /// <param name="id">The Id of the item to return</param>
        /// <returns>The item if found; otherwise, null</returns>
        Task<TItem> GetByIDAsync(long id);

        /// <summary>
        /// Updates the item
        /// </summary>
        /// <param name="item">The item to update</param>
        void Update(TItem item);

        /// <summary>
        /// Updates the item asyncronously
        /// </summary>
        /// <param name="item">The item to update</param>
        /// <returns>The task to execute</returns>
        Task UpdateAsync(TItem item);

        /// <summary>
        /// Deletes the item
        /// </summary>
        /// <param name="id">The Id of the item to delete</param>
        void Delete(long id);

        /// <summary>
        /// Deletes the item asyncronously
        /// </summary>
        /// <param name="id">The Id of the item to delete</param>
        /// <returns>The task to execute</returns>
        Task DeleteAsync(long id);
    }
}
