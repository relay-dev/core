namespace Core.FileHandling
{
    /// <summary>
    /// Settings used to connect to an FTP drive
    /// </summary>
    public class FtpClientSettings
    {
        /// <summary>
        /// Initialized the immutable object
        /// </summary>
        /// <param name="host">The host of the FTP drive</param>
        /// <param name="username">The username for the credentials of the FTP drive</param>
        /// <param name="password">The password for the credentials of the FTP drive</param>
        /// <param name="isSftp">Indicates is the FTP drive to connect to is SFTP</param>
        public FtpClientSettings(string host, string username, string password, bool isSftp)
        {
            Host = host;
            Username = username;
            Password = password;
            IsSftp = isSftp;
        }

        /// <summary>
        /// Indicates is the FTP drive to connect to is SFTP
        /// </summary>
        public bool IsSftp { get; set; }

        /// <summary>
        /// The host of the FTP drive
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// The username for the credentials of the FTP drive
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// The password for the credentials of the FTP drive
        /// </summary>
        public string Password { get; set; }
    }
}
