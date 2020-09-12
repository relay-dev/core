using System.Security;

namespace Core.Security
{
    /// <summary>
    /// A generic abstraction of a cryptography mechanism
    /// </summary>
    public interface ICryptographyService
    {
        /// <summary>
        /// Encrypt a string
        /// </summary>
        /// <param name="valueToEncrypt">The value to encrypt</param>
        /// <returns>The encrypted result</returns>
        string Encrypt(string valueToEncrypt);

        /// <summary>
        /// Decrypts an encrypted string
        /// </summary>
        /// <param name="cipherString">The string to decrypt</param>
        /// <returns>The decrypted result</returns>
        string Decrypt(string cipherString);
    }
}
