using System;
using System.Threading;
using System.Threading.Tasks;

using R5T.Gepidia;


namespace R5T.Teutonia
{
    public interface IFileSystemCloningOperator
    {
        void Clone(FileSystemSite source, FileSystemSite destination, FileSystemCloningOptions options);
        Task CloneAsync(FileSystemSite source, FileSystemSite destination, FileSystemCloningOptions options, CancellationToken cancellationToken);
    }
}
