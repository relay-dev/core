namespace Core.Framework
{
    /// <summary>
    /// Indicates this class has properties used to paginate a collection of records
    /// </summary>
    public interface IHavePagingCriteria
    {
        /// <summary>
        /// The current page number
        /// </summary>
        int PageNumber { get; set; }

        /// <summary>
        /// How many records to return for the page
        /// </summary>
        int RecordsPerPage { get; set; }

        /// <summary>
        /// Optional; used to group the result set by a given field
        /// </summary>
        string GroupBy { get; set; }

        /// <summary>
        /// Optional; used to order the result set by a given field
        /// </summary>
        string OrderBy { get; set; }
    }
}
