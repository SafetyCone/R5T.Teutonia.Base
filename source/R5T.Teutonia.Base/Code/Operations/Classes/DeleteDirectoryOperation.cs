using System;

using R5T.Gepidia;


namespace R5T.Teutonia
{
    public class DeleteDirectoryOperation : IFileSystemCloningOperation
    {
        public string DirectoryPath { get; }
        public IFileSystemOperator FileSystemOperator { get; }


        public DeleteDirectoryOperation(string directoryPath, IFileSystemOperator fileSystemOperator)
        {
            this.DirectoryPath = directoryPath;
            this.FileSystemOperator = fileSystemOperator;
        }

        public void Execute()
        {
            this.FileSystemOperator.DeleteDirectory(this.DirectoryPath);
        }
    }
}
