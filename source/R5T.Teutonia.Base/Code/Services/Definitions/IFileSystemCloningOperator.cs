using System;
using System.Threading;
using System.Threading.Tasks;

using R5T.Gepidia;

using R5T.T0064;


namespace R5T.Teutonia
{
    [ServiceDefinitionMarker]
    public interface IFileSystemCloningOperator : IServiceDefinition
    {
        void Clone(FileSystemSite source, FileSystemSite destination, FileSystemCloningOptions options);
        Task CloneAsync(FileSystemSite source, FileSystemSite destination, FileSystemCloningOptions options, CancellationToken cancellationToken);
    }
}
