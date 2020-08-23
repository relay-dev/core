namespace Core.Framework
{
    /// <summary>
    /// Indicates this class has properties used to paginate a collection of records as well as a search string to filter results
    /// </summary>
    public interface IHavePagingAndSearchCriteria : IHavePagingCriteria
    {
        /// <summary>
        /// The search string to filter results
        /// </summary>
        string SearchString { get; set; }
    }
}
