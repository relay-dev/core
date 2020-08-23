using Core.Framework;

namespace Core.Providers
{
    /// <summary>
    /// Provides Commands with the username which is relevant under the current context
    /// </summary>
    public interface IUsernameProvider : IProvider<string> { }
}
