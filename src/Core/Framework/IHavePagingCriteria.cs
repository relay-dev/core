namespace Core.Framework
{
    /// <summary>
    /// Indicates this class has properties used to paginate a collection of records
    /// </summary>
    public interface IHavePagingCriteria : IPaginate
    {
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
