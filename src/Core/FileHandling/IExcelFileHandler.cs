using System.Data;
using System.IO;

namespace Core.FileHandling
{
    /// <summary>
    /// A generic abstraction of a handler for Excel files
    /// </summary>
    public interface IExcelFileHandler
    {
        /// <summary>
        /// Creates an Excel workbook using a DataTable, and returns it as a stream
        /// </summary>
        /// <param name="dataTable">The DataTable to be used as a data source when creating the workbook</param>
        /// <param name="sheetName">The name of the sheet the DataTable data should be stored within</param>
        /// <returns></returns>
        byte[] CreateWorkbookFromDataTable(DataTable dataTable, string sheetName = "Sheet1");


        /// <summary>
        /// Creates an Excel workbook using a collection of DataTables, and returns it as a stream
        /// </summary>
        /// <param name="dataTables">The DataTables to be used as a data source when creating the workbook</param>
        /// <returns></returns>
        byte[] CreateWorkbookFromDataTables(List<DataTable> dataTables);

        /// <summary>
        /// Connects to an Excel file stream and returns the contents of a specified tab as a DataTable
        /// </summary>
        /// <param name="fileStream">The Excel file as a stream</param>
        /// <param name="sheetPosition">Optional; The position of the sheet within the Excel file to populate the DataTable from</param>
        /// <returns>The contents of a specified tab as a DataTable</returns>
        DataTable GetWorksheetAsDataTable(Stream fileStream, int sheetPosition = 1);

        /// <summary>
        /// Connects to an Excel file stream and returns the contents of a specified tab as a DataTable
        /// </summary>
        /// <param name="fileStream">The Excel file as a stream</param>
        /// <param name="sheetName">The name of the sheet within the Excel file to populate the DataTable from</param>
        /// <returns>The contents of a specified tab as a DataTable</returns>
        DataTable GetWorksheetAsDataTable(Stream fileStream, string sheetName);

        /// <summary>
        /// Connects to an Excel file using a filepath and returns the contents of a specified tab as a DataTable
        /// </summary>
        /// <param name="filePath">The full path to the Excel file</param>
        /// <param name="sheetPosition">Optional; The position of the sheet within the Excel file to populate the DataTable from</param>
        /// <returns>The contents of a specified tab as a DataTable</returns>
        DataTable GetWorksheetAsDataTable(string filePath, int sheetPosition = 1);

        /// <summary>
        /// Connects to an Excel file using a filepath and returns the contents of a specified tab as a DataTable
        /// </summary>
        /// <param name="filePath">The full path to the Excel file</param>
        /// <param name="sheetName">The name of the sheet within the Excel file to populate the DataTable from</param>
        /// <returns>The contents of a specified tab as a DataTable</returns>
        DataTable GetWorksheetAsDataTable(string filePath, string sheetName);

        /// <summary>
        /// Saves an Excel workbook using a DataTable
        /// </summary>
        /// <param name="dataTable">The DataTable to be used as a data source when creating the workbook</param>
        /// <param name="filePath">The file path for which the file should be saved</param>
        /// <param name="sheetName">The name of the sheet the DataTable data should be stored within</param>
        void SaveWorkbookFromDataTable(DataTable dataTable, string filePath, string sheetName = "Sheet1");
    }
}
