﻿namespace Core.Application
{
    /// <summary>
    /// Encapsulates fields useful when diagnosing a database
    /// </summary>
    public class DatabaseDiagnostics
    {
        /// <summary>
        /// The name of the database server the application is connected to
        /// </summary>
        public string ServerName { get; set; }

        /// <summary>
        /// The name of the database the application is connected to
        /// </summary>
        public string DatabaseName { get; set; }
    }
}
