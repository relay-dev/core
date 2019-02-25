using Core.Data;
using Core.Framework;

namespace Core.Providers
{
    public interface IPageProvider<TEntity> : IProvider<IPageable<TEntity>> { }
}
