using System.IO;

namespace Core.FileHandling
{
    /// <summary>
    /// A generic abstraction of the Directory system
    /// </summary>
    public interface IDirectorySystem
    {
        /// <summary>
        /// Creates a new Directory
        /// </summary>
        /// <param name="directoryInfo">DirectoryInfo for the directory of interest</param>
        /// <returns>Returns <c>true</c> if the Directory was created successfully; otherwise, <c>false</c></returns>
        bool CreateDirectory(DirectoryInfo directoryInfo);

        /// <summary>
        /// Deletes an existing Directory
        /// </summary>
        /// <param name="directoryInfo">DirectoryInfo for the directory of interest</param>
        /// <returns>Returns <c>true</c> if the Directory was created successfully; otherwise, <c>false</c></returns>
        bool DeleteDirectory(DirectoryInfo directoryInfo);

        /// <summary>
        /// Finds a unique filename for the directory you wish to store a file. This guarentees you'll be able to save a file, using a certain naming convention, in any directory you choose, regarless of whether or not a file by that same name already exists in that directory (useful on retry scenarios where files are being created)
        /// </summary>
        /// <param name="fileInfo">Details about the file to generate a unique name for, such as the directory, and potential name for the file</param>
        /// <returns>Returns FileInfo about the unique file to avoid ambiguity about the nature of a simpiler return type, such as a string</returns>
        FileInfo GetUniqueFileInfo(FileInfo fileInfo);

        /// <summary>
        /// Checks to see if a Dictory already exists
        /// </summary>
        /// <param name="directoryInfo">DirectoryInfo for the directory of interest</param>
        /// <returns>Returns <c>true</c> if the given Directory exists; otherwise, <c>false</c></returns>
        bool IsDirectoryExists(DirectoryInfo directoryInfo);
    }
}
