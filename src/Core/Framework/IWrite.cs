namespace Core.Framework
{
    /// <summary>
    /// Represents an object sent by a client with the intent to either insert or update data
    /// </summary>
    public interface IWrite
    {
        /// <summary>
        /// The username that should be stamped on the CreatedBy or ModifiedBy
        /// </summary>
        public string UsernameForAudit { get; set; }
    }
}
