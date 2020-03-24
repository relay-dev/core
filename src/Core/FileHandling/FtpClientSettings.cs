﻿using System;
using System.Collections.Generic;
using System.Linq;

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
        /// <param name="connectionString">The connection string of the FTP server</param>
        public FtpClientSettings(string connectionString)
        {
            Dictionary<string, string> connectionStringProperties = connectionString.Split(';')
                .Where(prop => !string.IsNullOrEmpty(prop))
                .Select(prop => prop.Split(new char[] { '=' }, 2))
                .ToDictionary(prop => prop[0].Trim(), t => t[1].Trim(), StringComparer.InvariantCultureIgnoreCase);

            Host = TryGet(connectionStringProperties, "Host");
            Port = TryGet(connectionStringProperties, "Port");
            Username = TryGet(connectionStringProperties, "Username");
            Password = TryGet(connectionStringProperties, "Password");
            IsSftp = Convert.ToBoolean(TryGet(connectionStringProperties, "IsSftp"));
        }

        /// <summary>
        /// Initialized the immutable object
        /// </summary>
        /// <param name="host">The host of the FTP drive</param>
        /// <param name="port">The port of the FTP drive</param>
        /// <param name="username">The username for the credentials of the FTP drive</param>
        /// <param name="password">The password for the credentials of the FTP drive</param>
        /// <param name="isSftp">Indicates is the FTP drive to connect to is SFTP</param>
        public FtpClientSettings(string host, string port, string username, string password, bool isSftp)
        {
            Host = host;
            Port = port;
            Username = username;
            Password = password;
            IsSftp = isSftp;
        }

        /// <summary>
        /// The host of the FTP drive
        /// </summary>
        public string Host { get; }

        /// <summary>
        /// The port of the SMTP server
        /// </summary>
        public string Port { get; }

        /// <summary>
        /// The username for the credentials of the FTP drive
        /// </summary>
        public string Username { get; }

        /// <summary>
        /// The password for the credentials of the FTP drive
        /// </summary>
        public string Password { get; }

        /// <summary>
        /// Indicates is the FTP drive to connect to is SFTP
        /// </summary>
        public bool IsSftp { get; }

        #region Private

        private string TryGet(Dictionary<string, string> dictionary, string key)
        {
            if (dictionary.ContainsKey(key))
            {
                return dictionary[key];
            }

            return null;
        }

        #endregion
    }
}