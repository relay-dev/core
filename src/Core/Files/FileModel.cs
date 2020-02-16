using System.IO;

namespace Core.Files
{
    /// <summary>
    /// A generic abstraction of a file
    /// </summary>
    public class FileModel
    {
        /// <summary>
        /// Info for the given file
        /// </summary>
        public FileInfo FileInfo { get; set; }

        /// <summary>
        /// The raw contents of the file
        /// </summary>
        public string FileContents { get; set; }

        /// <summary>
        /// The type of file
        /// </summary>
        public string FileType { get; set; }
    }
}
