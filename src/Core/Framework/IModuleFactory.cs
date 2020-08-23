namespace Core.Framework
{
    /// <summary>
    /// Creates types that implement the IModule interface for Commands
    /// </summary>
    public interface IModuleFactory : IFactory
    {
        /// <summary>
        /// Creates the Module type requested
        /// </summary>
        /// <typeparam name="TModule">Type of the Module to be returned</typeparam>
        /// <returns>A new instance of an object of type IModule</returns>
        new TModule Create<TModule>();
    }
}
