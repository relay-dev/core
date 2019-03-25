using System.Threading.Tasks;

namespace Core.Framework.Services
{
    /// <summary>
    /// A generic abstraction of an asyncronous service that contains all basic CRUD methods
    /// </summary>
    /// <typeparam name="TItem">The type of item being operated on</typeparam>
    public interface IAsyncCrudService<TItem> : IService
    {
        /// <summary>
        /// Creates the item
        /// </summary>
        /// <param name="item">The item to create</param>
        /// <returns>The ID of the item created</returns>
        Task<long> Create(TItem item);

        /// <summary>
        /// Gets the item by ID
        /// </summary>
        /// <param name="id">The ID of the item to return</param>
        /// <returns>The item if found; otherwise, null</returns>
        Task<TItem> GetByID(long id);

        /// <summary>
        /// Updates the item
        /// </summary>
        /// <param name="item">The item to update</param>
        Task Update(TItem item);

        /// <summary>
        /// Deletes the item
        /// </summary>
        /// <param name="id">The ID of the item to delete</param>
        Task Delete(long id);
    }
}
