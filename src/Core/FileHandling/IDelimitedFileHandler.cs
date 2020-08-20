using System.Data;
using System.IO;

namespace Core.FileHandling
{
    /// <summary>
    /// A generic abstraction of a handler for delimited files
    /// </summary>
    public interface IDelimitedFileHandler
    {
        /// <summary>
        /// Parses a delimited file to a DataTable
        /// </summary>
        /// <param name="filepath">The path to the delimited file</param>
        /// <param name="columnDelimiter">Optional; the characters used as a delimiter in the delimited file</param>
        /// <returns></returns>
        DataTable GetFileAsDataTable(string filepath, char columnDelimiter = ',');

        /// <summary>
        /// Parses a delimited file to a DataTable
        /// </summary>
        /// <param name="stream">The stream of the delimited file</param>
        /// <param name="columnDelimiter">Optional; the characters used as a delimiter in the delimited file</param>
        /// <returns></returns>
        DataTable GetFileStreamAsDataTable(Stream stream, char columnDelimiter = ',');
    }
}
