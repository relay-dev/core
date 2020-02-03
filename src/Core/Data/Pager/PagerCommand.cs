namespace Core.Data.Pager
{
    /// <summary>
    /// Allows you to set all input paramerters needed to paginate a view
    /// </summary>
    public class PagerCommand
    {
        /// <summary>
        /// The name of the view to paginate
        /// </summary>
        public string ViewName { get; set; }

        /// <summary>
        /// The index of the page number to return
        /// </summary>
        public int PageNumber { get; set; }

        /// <summary>
        /// The number of records to return in the result
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// Optional: Allows you to limit the columns returned from the view. When not set, the default behavior is to return all columns in the view
        /// </summary>
        public string ColumnsToReturn { get; set; }

        /// <summary>
        /// Optional: Allows you to filter the result returned from the view. When not set, the default behavior is to not apply any filter to the view
        /// </summary>
        public string WhereClause { get; set; }

        /// <summary>
        /// Optional: Allows you to order the result returned from the view. When not set, the default behavior is to order by the first column in the view
        /// </summary>
        public string OrderBy { get; set; }
    }
}
