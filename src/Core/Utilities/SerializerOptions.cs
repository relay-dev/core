namespace Core.Utilities
{
    /// <summary>
    /// A generic set of options for a serializer to use
    /// </summary>
    public class SerializerOptions
    {
        public bool AllowTrailingCommas { get; set; }
        public int DefaultBufferSize { get; set; }
        public string Encoder { get; set; }
        public string DictionaryKeyPolicy { get; set; }
        public bool IgnoreNullValues { get; set; }
        public bool IgnoreReadOnlyProperties { get; set; }
        public int MaxDepth { get; set; }
        public string PropertyNamingPolicy { get; set; }
        public bool PropertyNameCaseInsensitive { get; set; }
        public string ReadCommentHandling { get; set; }
        public bool WriteIndented { get; set; }
    }
}
