namespace Core.IO
{
    /// <summary>
    /// A generic abstraction of the File system
    /// </summary>
    public interface IFileSystem
    {
        /// <summary>
        /// Creates a file and stores it in a location to be determed by the concrete implementations of IFileSystem
        /// </summary>
        /// <param name="fileModel">Details about the file to create</param>
        /// <returns>A unique identifier for the File to be retrieved in the future; a filepath, for example</returns>
        string CreateFile(FileModel fileModel);

        /// <summary>
        /// Deletes an existing File
        /// </summary>
        /// <param name="fileModel">Details about the file to delete</param>
        /// <returns>Returns <c>true</c> if the Directory was deleted successfully; otherwise, <c>false</c></returns>
        bool DeleteFile(FileModel fileModel);

        /// <summary>
        /// Gets a file from a location to be determed by the concrete implementations of IFileSystem
        /// </summary>
        /// <param name="fileIdentifier">A unique identifier for the File to be located; a filepath, for example</param>
        /// <returns>The File that was requested</returns>
        FileModel GetFile(string fileIdentifier);

        /// <summary>
        /// Checks to see if a Dictory already exists
        /// </summary>
        /// <param name="fileModel">DirectoryInfo for the directory of interest</param>
        /// <returns>Returns <c>true</c> if the given Directory exists; otherwise, <c>false</c></returns>
        bool IsFileExists(FileModel fileModel);
    }
}
