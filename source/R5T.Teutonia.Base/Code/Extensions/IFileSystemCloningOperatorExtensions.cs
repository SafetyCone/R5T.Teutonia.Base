using System;

using R5T.Gepidia;


namespace R5T.Teutonia
{
    public static class IFileSystemCloningOperatorExtensions
    {
        /// <summary>
        /// Clones the file-system source to the destination using <see cref="FileSystemCloningOptions.Default"/> options.
        /// </summary>
        public static void Clone(this IFileSystemCloningOperator fileSystemCloningOperator, FileSystemSite source, FileSystemSite destination)
        {
            fileSystemCloningOperator.Clone(source, destination, FileSystemCloningOptions.Default);
        }
    }
}
