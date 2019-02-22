using Core.Data;

namespace Core.Data
{
    /// <summary>
    /// Creates <see cref="IRepositoryFactory"/> for Commands
    /// </summary>
    public interface IAbstractRepositoryFactory : IFactory<IRepositoryFactory> { }
}
