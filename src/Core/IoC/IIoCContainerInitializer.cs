namespace Core.IoC
{
    /// <summary>
    /// Encapsulates the initialization of the application's IoC container
    /// </summary>
    public interface IIoCContainerInitializer
    {
        /// <summary>
        /// Initializes a new instance of a <see cref="IIoCContainer"/>
        /// </summary>
        /// <returns>An instance of the <see cref="IIoCContainer"/> configured for the given application</returns>
        IIoCContainer Init();
    }
}
