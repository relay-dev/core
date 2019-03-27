namespace Core.Security
{
    /// <summary>
    /// A generic abstraction of an encrypted value
    /// </summary>
    public class EncryptedValue
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="value">The encrypted value</param>
        public EncryptedValue(string value)
        {
            Value = value;
        }

        /// <summary>
        /// The encrypted value
        /// </summary>
        public string Value { get; }
    }
}
