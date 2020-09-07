namespace Core.Framework
{
    /// <summary>
    /// Represents a request that contains pagination instructions 
    /// </summary>
    public interface IPaginate
    {
        /// <summary>
        /// The number of records to skip
        /// </summary>
        public int? Skip { get; set; }

        /// <summary>
        /// The number of records to take
        /// </summary>
        public int? Take { get; set; }
    }
}