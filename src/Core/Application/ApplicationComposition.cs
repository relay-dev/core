using System.Collections.Generic;

namespace Core.Application
{
    /// <summary>
    /// A generic abstraction of the configuration of components which comprise an application
    /// </summary>
    public class ApplicationComposition
    {
        /// <summary>
        /// The caching framework to be used
        /// </summary>
        public string Cache { get; set; }

        /// <summary>
        /// The configuration framework to be used
        /// </summary>
        public string Configuration { get; set; }

        /// <summary>
        /// The logging framework to be used
        /// </summary>
        public string Logging { get; set; }

        /// <summary>
        /// The mapping framework to be used
        /// </summary>
        public string Mapping { get; set; }

        /// <summary>
        /// The validation framework to be used
        /// </summary>
        public string Validation { get; set; }

        /// <summary>
        /// All other misc. components to be used
        /// </summary>
        public List<string> Components { get; set; }

        /// <summary>
        /// The IoC container framework to be used
        /// </summary>
        public IoCContainer IoCContainer { get; set; }

        /// <summary>
        /// Specifies the details about all data access needed by the application
        /// </summary>
        public DataAccess DataAccess { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public ApplicationComposition()
        {
            DataAccess = new DataAccess();
        }
    }

    /// <summary>
    /// A generic abstraction of the configuration for an application's IoC container
    /// </summary>
    public class IoCContainer
    {
        /// <summary>
        /// The type of container
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// A collection of all plugins to install on the IoC Container
        /// </summary>
        public List<IoCContainerPlugin> Plugins { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public IoCContainer()
        {
            Plugins = new List<IoCContainerPlugin>();
        }
    }

    /// <summary>
    /// IoC container frameworks
    /// </summary>
    public enum IoCContainerType
    {
        /// <summary>
        /// Not specified
        /// </summary>
        Undefined,

        /// <summary>
        /// Castle Windsor
        /// </summary>
        CastleWindsor
    }

    /// <summary>
    /// A generic abstraction of the configuration for an application's IoC container plugins
    /// </summary>
    public class IoCContainerPlugin
    {
        /// <summary>
        /// The name of the plugin
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The type of the plugin
        /// </summary>
        public string Type { get; set; }
    }

    /// <summary>
    /// A generic abstraction of the configuration for an application's data access
    /// </summary>
    public class DataAccess
    {
        /// <summary>
        /// Databases to be used by the application
        /// </summary>
        public List<Database> Databases { get; set; }

        /// <summary>
        /// Repositories to be used by the application
        /// </summary>
        public List<Repository> Repositories { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public DataAccess()
        {
            Databases = new List<Database>();
            Repositories = new List<Repository>();
        }
    }

    /// <summary>
    /// A generic abstraction of the configuration for an application's database
    /// </summary>
    public class Database
    {
        /// <summary>
        /// The name of the database
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The type of the database
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The encrypted connection string
        /// </summary>
        public string ConnectionString { get; set; }
    }

    /// <summary>
    /// A generic abstraction of the configuration for an application's repository
    /// </summary>
    public class Repository
    {
        /// <summary>
        /// The name of the repository
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The name of the unit of work type to use with this repository
        /// </summary>
        public string UnitOfWork { get; set; }

        /// <summary>
        /// The name of the db context type to use with this repository
        /// </summary>
        public string DbContext { get; set; }
    }

    /// <summary>
    /// Database Types
    /// </summary>
    public enum DatabaseType
    {
        /// <summary>
        /// Not specified
        /// </summary>
        Undefined,

        /// <summary>
        /// SQL Server
        /// </summary>
        SqlServer,

        /// <summary>
        /// Oracle
        /// </summary>
        Oracle,

        /// <summary>
        /// MySQL
        /// </summary>
        MySql,

        /// <summary>
        /// In-memory
        /// </summary>
        InMemory
    }
}
