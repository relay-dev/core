using Core.Framework;

namespace Core.Data
{
    /// <summary>
    /// Creates <see cref="IDatabase"/> instances, using the default (when no name is specified) or the database instance by name
    /// </summary>
    public interface IDatabaseFactory : IFactory<IDatabase> { }
}
