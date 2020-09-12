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
        /// <returns>An object encapsulating the encrypted value</returns>
        EncryptedValue Encrypt(SecureString valueToEncrypt);

        /// <summary>
        /// Decrypts an EncryptedValue
        /// </summary>
        /// <param name="encryptedValue">The value to decrypt</param>
        /// <returns>The decrypted value as a SecureString</returns>
        SecureString Decrypt(EncryptedValue encryptedValue);
    }
}
