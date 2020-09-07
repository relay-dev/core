namespace Core.Framework
{
    /// <summary>
    /// A request that contains pagination instructions
    /// </summary>
    public class PaginationRequest : IPaginate
    {
        /// <summary>
        /// The number of records to skip
        /// </summary>
        public int? Skip { get; set; }

        /// <summary>
        /// The number of records to take
        /// </summary>
        public int? Take { get; set; }

        /// <summary>
        /// A read-only property that resolves the nullable Skip property to the default if it's null
        /// </summary>
        public int SkipResolved => Skip.GetValueOrDefault();

        /// <summary>
        /// A read-only property that resolves the nullable Take property to the default if it's null
        /// </summary>
        public int TakeResolved => Take ?? 100;
    }
}
