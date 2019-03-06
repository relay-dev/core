using Core.Application;
using Core.Framework;

namespace Core.IoC
{
    /// <summary>
    /// Creates <see cref="IIoCContainer"/> instances, using the default (when no name is specified) or the IoC container instance by name
    /// </summary>
    public interface IIoCContainerFactory : IFactory<IIoCContainer>
    {
        /// <summary>
        /// Creates an IoC container based on the IoCContainerType input
        /// </summary>
        /// <param name="iocContainerType">The IoC container type</param>
        /// <returns>A new instance of the requested IoC container type</returns>
        IIoCContainer Create(IoCContainerType iocContainerType);
    }
}
