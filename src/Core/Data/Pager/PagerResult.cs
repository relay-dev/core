using System.Data;

namespace Core.Data.Pager
{
    /// <summary>
    /// The result of a pagination command
    /// </summary>
    public class PagerResult
    {
        /// <summary>
        /// Created a new instance of a PagerResult
        /// </summary>
        /// <param name="dataTable">The dataTable to be accessible as the result of the pagination</param>
        /// <param name="totalCount">The total count of all records in the view</param>
        public PagerResult(DataTable dataTable, int totalCount)
        {
            DataTable = dataTable;
            TotalCount = totalCount;
        }

        /// <summary>
        /// The count of all records returned
        /// </summary>
        public int Count
        {
            get
            {
                return DataTable.Rows.Count;
            }
        }

        /// <summary>
        /// The total count of all records in the view
        /// </summary>
        public int TotalCount { get; }

        /// <summary>
        /// The records returned for this iteration of the pager
        /// </summary>
        public DataTable DataTable { get; }
    }
}
