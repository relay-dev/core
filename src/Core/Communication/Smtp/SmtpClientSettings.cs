namespace Core.Communication.Smtp
{
    /// <summary>
    /// Settings used to connect to an SMTP server
    /// </summary>
    public class SmtpClientSettings
    {
        /// <summary>
        /// Initialized the immutable object
        /// </summary>
        /// <param name="host">The host of the SMTP server</param>
        /// <param name="port">The port of the SMTP server</param>
        /// <param name="username">The username for the credentials of the SMTP server</param>
        /// <param name="password">The password for the credentials of the SMTP server</param>
        public SmtpClientSettings(string host, string port, string username, string password)
        {
            Host = host;
            Port = port;
            Username = username;
            Password = password;
        }

        /// <summary>
        /// The host of the SMTP server
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// The port of the SMTP server
        /// </summary>
        public string Port { get; set; }

        /// <summary>
        /// The username for the credentials of the SMTP server
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// The password for the credentials of the SMTP server
        /// </summary>
        public string Password { get; set; }
    }
}
