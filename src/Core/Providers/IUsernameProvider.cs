using Core.Framework;

namespace Core.Providers
{
    /// <summary>
    /// Provides Commands with the username which is relevant under the current context
    /// </summary>
    public interface IUsernameProvider : IProvider<string>
    {
        /// <summary>
        /// Sets the username field
        /// </summary>
        /// <param name="username">The username to encapsulate</param>
        void Set(string username);
    }
}
