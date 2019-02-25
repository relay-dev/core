namespace Core.Framework
{
    /// <summary>
    /// Factories create objects for use by Commands
    /// </summary>
    /// <typeparam name="TService">Type of object to be created</typeparam>
    public interface IFactory<TService> where TService : class
    {
        /// <summary>
        /// Creates the type requested
        /// </summary>
        /// <typeparam name="TToCreate">Type of object to be returned</typeparam>
        /// <returns>A new instance of an object of type TToCreate</returns>
        TToCreate Create<TToCreate>() where TToCreate : TService;

        /// <summary>
        /// Creates the type requested
        /// </summary>
        /// <param name="name">Unique name of the instance to return (when name is null, the default instance will be used)</param>
        /// <returns>A new instance of an object of type TService</returns>
        TService Create(string name = null);
    }

    /// <summary>
    /// Factories create objects for use by Commands
    /// </summary>
    public interface IFactory
    {
        /// <summary>
        /// Creates the type requested
        /// </summary>
        /// <typeparam name="TToCreate">Type of object to be returned</typeparam>
        /// <returns>A new instance of an object of type TToCreate</returns>
        TToCreate Create<TToCreate>() where TToCreate : class;
    }
}
