using System.Collections.Generic;

namespace Core.Framework
{
    /// <summary>
    /// Indicates this class has properties used to convey the result of a search
    /// </summary>
    /// <typeparam name="TResult">The type of objects to be returned in the Result collection</typeparam>
    public interface ISearchResult<TResult>
    {
        /// <summary>
        /// The total count (note, this can be different from Result.Count() when paginating)
        /// </summary>
        int TotalCount { get; set; }

        /// <summary>
        /// The search string to filter results
        /// </summary>
        string SearchString { get; set; }

        /// <summary>
        /// The result of the search
        /// </summary>
        List<TResult> Result { get; set; }
    }
}
