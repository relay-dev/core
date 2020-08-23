using Core.Framework;

namespace Core.Providers
{
    /// <summary>
    /// Provides Commands with keys, such as encryption keys
    /// </summary>
    public interface IKeyProvider : IProvider<string>
    {
        /// <summary>
        /// Returns the key associated to the keyIdentifier
        /// </summary>
        /// <param name="keyIdentifier">A unique identifier of the key to return</param>
        /// <returns></returns>
        string Get(string keyIdentifier);
    }
}
