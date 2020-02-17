namespace Core.FileHandling
{
    /// <summary>
    /// Settings used to connect to an FTP drive
    /// </summary>
    public class FtpClientSettings
    {
        /// <summary>
        /// Indicates is the FTP drive to connect to is SFTP
        /// </summary>
        public bool IsSftp { get; set; }

        /// <summary>
        /// The host of the ftp drive
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// The host of the ftp drive
        /// </summary>
        public string Port { get; set; }

        /// <summary>
        /// The username for the credentials of the ftp drive
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// The password for the credentials of the ftp drive
        /// </summary>
        public string Password { get; set; }
    }
}
