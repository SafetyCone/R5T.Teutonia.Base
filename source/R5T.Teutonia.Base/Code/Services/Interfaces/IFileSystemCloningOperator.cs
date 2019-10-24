using System;

using R5T.Gepidia;


namespace R5T.Teutonia
{
    public interface IFileSystemCloningOperator
    {
        void Clone(FileSystemSite source, FileSystemSite destination, FileSystemCloningOptions options);
    }
}
