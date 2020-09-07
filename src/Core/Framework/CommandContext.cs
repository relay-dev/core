namespace Core.Framework
{
    /// <summary>
    /// Provides information about the current command being executed
    /// </summary>
    public class CommandContext
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public CommandContext() { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="username"></param>
        public CommandContext(string username)
        {
            Username = username;
        }

        /// <summary>
        /// The Username from the command request to be used when auditing entities
        /// </summary>
        public string Username { get; set; }
    }
}
