using System;
using System.Collections.Generic;

using R5T.Gepidia;


namespace R5T.Teutonia
{
    public interface IFileSystemCloningOperationsListGenerator
    {
        IFileSystemCloningOperation[] DetermineCloningOperations(IEnumerable<FileSystemEntry> sourceFileSystemEntries, IEnumerable<FileSystemEntry> destinationFileSystemEntries);
    }
}
