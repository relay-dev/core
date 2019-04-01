using Core.Application;
using Core.Framework;

namespace Core.Providers
{
    /// <summary>
    /// Provides consumers with the current ApplicationContext
    /// </summary>
    public interface IApplicationContextProvider : IProvider<ApplicationContext> { }
}
