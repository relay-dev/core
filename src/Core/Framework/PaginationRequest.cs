namespace Core.Framework
{
    /// <summary>
    /// A request that contains pagination instructions
    /// </summary>
    public class PaginationRequest : IPaginate
    {
        /// <summary>
        /// The number of the current page
        /// </summary>
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of records to return for each iteration
        /// </summary>
        public int? PageSize { get; set; }
    }
}
