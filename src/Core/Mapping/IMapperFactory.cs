using Core.Framework;

namespace Core.Mapping
{
    /// <summary>
    /// Creates <see cref="IMapper"/> instances, using the default (when no name is specified) or the cache instance by name
    /// </summary>
    public interface IMapperFactory : IFactory<IMapper> { }
}
