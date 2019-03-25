namespace Core.Framework
{
    /// <summary>
    /// Creates types that implement the IService interface for Commands
    /// </summary>
    public interface IServiceFactory : IFactory<IService> { }
}
