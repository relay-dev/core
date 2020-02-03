namespace Core.Data.Pager
{
    /// <summary>
    /// A generic abstraction of an object that can paginate views
    /// </summary>
    public interface IPager
    {
        /// <summary>
        /// Executes a pagination command
        /// </summary>
        /// <param name="pagerCommand">Allows you to set all input paramerters needed to paginate a view</param>
        /// <returns>The result of the Pagination</returns>
        PagerResult Page(PagerCommand pagerCommand);
    }
}
