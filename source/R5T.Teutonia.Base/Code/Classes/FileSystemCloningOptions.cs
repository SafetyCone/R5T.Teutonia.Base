using System;


namespace R5T.Teutonia
{
    public class FileSystemCloningOptions
    {
        public static readonly FileSystemCloningOptions Default = new FileSystemCloningOptions();


        /// <summary>
        /// Indicates that directories present in the destination, but not in the source, should be deleted.
        /// Default: true.
        /// </summary>
        public bool DeleteExtraneousDestinationDirectories { get; set; } = true;
        /// <summary>
        /// Indicates that files present in the destination, but not in the source, should be deleted.
        /// Default: true.
        /// </summary>
        public bool DeleteExtraneousDestinationFiles { get; set; } = true;
    }
}
