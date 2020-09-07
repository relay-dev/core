namespace Core.Providers
{
    /// <summary>
    /// Generates a random alpha-numeric code
    /// </summary>
    public interface IRandomCodeProvider
    {
        /// <summary>
        /// Generates a random alpha-numeric code
        /// </summary>
        /// <param name="length">The length of the code to generate</param>
        /// <param name="prefix">The prefix to be used on the code</param>
        /// <param name="suffix">The suffix to be used on the code</param>
        /// <returns>The random alpha-numeric code</returns>
        string Get(int length, string prefix = null, string suffix = null);
    }
}