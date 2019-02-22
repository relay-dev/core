namespace Core.Configuration
{
    /// <summary>
    /// A generic abstraction of an application configuration mechanism
    /// </summary>
    public interface IConfiguration
    {
        /// <summary>
        /// Gets an application setting from a configuration source by key (a string) and casts it to the expected type
        /// </summary>
        /// <typeparam name="TReturn">Type of object to be returned</typeparam>
        /// <param name="key">Unique key of the application setting</param>
        /// <returns>The application setting, of type TReturn</returns>
        TReturn GetApplicationSetting<TReturn>(string key);

        /// <summary>
        /// Determines if the given key is present in the application settings
        /// </summary>
        /// <param name="key">Unique key of the application setting</param>
        /// <returns><c>true</c> if the given key is present in the application settings; otherwise, <c>false</c></returns>
        bool ContainsApplicationSetting(string key);
    }
}
