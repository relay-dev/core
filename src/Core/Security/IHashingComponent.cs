namespace Core.Security
{
    /// <summary>
    /// A generic abstraction of a hashing mechanism
    /// </summary>
    public interface IHashingComponent
    {
        /// <summary>
        /// Creates a hash using the input as a cipher
        /// </summary>
        /// <param name="valueToHash">The cipher text to hash</param>
        /// <returns>A hash that represents the cipher text</returns>
        string CreateHash(string valueToHash);

        /// <summary>
        /// Compares a clear text cipher string against the expected hash it should output
        /// </summary>
        /// <param name="clearTextString">The clear text cipher string</param>
        /// <param name="correctHash">The correct hash for clearTextString</param>
        /// <returns>Returns <c>true</c> if the hash generated using clearTextString matched correctHash; otherwise <c>false</c></returns>
        bool IsHashMatch(string clearTextString, string correctHash);
    }
}
