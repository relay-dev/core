using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Framework.Services
{
    /// <summary>
    /// A generic abstraction of a service that retuns static lookup data
    /// </summary>
    /// <typeparam name="TItem">The type of item to be returned</typeparam>
    public interface ILookupService<TItem> : IService
    {
        /// <summary>
        /// Returns all lookup data items
        /// </summary>
        /// <returns>A collection of all items</returns>
        IEnumerable<TItem> GetAll();

        /// <summary>
        /// Returns all lookup data items asyncronously
        /// </summary>
        /// <returns>A collection of all items</returns>
        Task<IEnumerable<TItem>> GetAllAsync();
    }
}
