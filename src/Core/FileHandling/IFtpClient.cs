using System.Collections.Generic;
using System.IO;

namespace Core.FileHandling
{
    /// <summary>
    /// A generic abstraction of an FTP client
    /// </summary>
    public interface IFtpClient
    {
        /// <summary>
        /// Deletes the remote file
        /// </summary>
        /// <param name="filePath">The remote file path, including the file name</param>
        void DeleteFile(string filePath);

        /// <summary>
        /// Downloads a remote file to a stream
        /// </summary>
        /// <param name="filePath">The remote file path, including the file name</param>
        /// <returns>A stream of the file</returns>
        Stream DownloadFile(string filePath);

        /// <summary>
        /// Gets the DateTimestamp of the remote file
        /// </summary>
        /// <param name="filePath">The remote file path, including the file name</param>
        /// <returns>The DateTimestamp</returns>
        string GetDateTimestamp(string filePath);

        /// <summary>
        /// Gets the file size of the remote file
        /// </summary>
        /// <param name="filePath">The remote file path, including the file name</param>
        /// <returns>The file size</returns>
        string GetFileSize(string filePath);

        /// <summary>
        /// Determines if a file exists on the FTP drive, by name
        /// </summary>
        /// <param name="filePath">The remote file path, including the file name</param>
        /// <returns>Returns <c>true</c> if the file exists; otherwise false</returns>
        bool IsFileExists(string filePath);

        /// <summary>
        /// Lists all files in a remote directory
        /// </summary>
        /// <param name="directoryPath">The remote directory path</param>
        /// <returns>A list of all files in the remote directory</returns>
        List<string> ListDirectory(string directoryPath);

        /// <summary>
        /// Lists all files in a remote directory with extended details
        /// </summary>
        /// <param name="directoryPath">The remote directory path</param>
        /// <returns>A list of all files in the remote directory</returns>
        List<string> ListDirectoryDetails(string directoryPath);

        /// <summary>
        /// Makes a directory on the remote target
        /// </summary>
        /// <param name="directoryPath">The remote directory path</param>
        void MakeDirectory(string directoryPath);

        /// <summary>
        /// Removes a directory on the remote target
        /// </summary>
        /// <param name="directoryPath">The remote directory path</param>
        void RemoveDirectory(string directoryPath);

        /// <summary>
        /// Renames a file on the remote taget
        /// </summary>
        /// <param name="currentFilePath">The remote file path, including the file name</param>
        /// <param name="newFilePath">The new file path, including the file name</param>
        void Rename(string currentFilePath, string newFilePath);

        /// <summary>
        /// Uploads a file to the remote target
        /// </summary>
        /// <param name="stream">A stream of the file</param>
        /// <param name="filePath">The remote file path, including the file name</param>
        void UploadFile(Stream stream, string filePath);
    }
}
