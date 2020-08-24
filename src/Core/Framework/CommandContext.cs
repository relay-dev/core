namespace Core.Framework
{
    /// <summary>
    /// Provides information about the current command being executed
    /// </summary>
    public class CommandContext
    {
        /// <summary>
        /// The Username from the command request to be used when auditing entities
        /// </summary>
        string Username { get; set; }
    }
}
