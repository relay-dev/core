using System;
using System.Collections.Generic;
using System.Linq;

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
        /// <param name="connectionString">The connection string of the SMTP server</param>
        public SmtpClientSettings(string connectionString)
        {
            Dictionary<string, string> connectionStringProperties = connectionString.Split(';')
                .Where(prop => !string.IsNullOrEmpty(prop))
                .Select(prop => prop.Split(new char[] { '=' }, 2))
                .ToDictionary(prop => prop[0].Trim(), t => t[1].Trim(), StringComparer.InvariantCultureIgnoreCase);

            Host = TryGet(connectionStringProperties, "Host");
            Port = TryGet(connectionStringProperties, "Port");
            Username = TryGet(connectionStringProperties, "Username");
            Password = TryGet(connectionStringProperties, "Password");
        }

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
        public string Host { get; }

        /// <summary>
        /// The port of the SMTP server
        /// </summary>
        public string Port { get; }

        /// <summary>
        /// The username for the credentials of the SMTP server
        /// </summary>
        public string Username { get; }

        /// <summary>
        /// The password for the credentials of the SMTP server
        /// </summary>
        public string Password { get; }

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
