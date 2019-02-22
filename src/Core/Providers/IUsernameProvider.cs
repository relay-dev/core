using Core.Data;

namespace Core.Providers
{
    /// <summary>
    /// Provides Commands with the username which is relevent under the current context
    /// </summary>
    public interface IUsernameProvider : IProvider<string> { }
}
