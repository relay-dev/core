using Core.Data;
using Core.Framework;

namespace Core.Providers
{
    /// <summary>
    /// Provides Repositories with an IPageable entity
    /// </summary>
    /// <typeparam name="TEntity">The type of entity to page</typeparam>
    public interface IPageProvider<TEntity> : IProvider<IPageable<TEntity>> { }
}
