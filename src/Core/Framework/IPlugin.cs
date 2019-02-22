namespace Core.Data
{
    /// <summary>
    /// Third Party modules that enjoy a pub/sub pattern
    /// </summary>
    public interface IPlugin
    {
        /// <summary>
        /// Loads the IPlugin
        /// </summary>
        void Load();
    }
}
