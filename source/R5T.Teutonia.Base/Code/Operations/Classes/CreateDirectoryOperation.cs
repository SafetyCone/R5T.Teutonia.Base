using System;

using R5T.Gepidia;


namespace R5T.Teutonia
{
    public class CreateDirectoryOperation : IFileSystemCloningOperation
    {
        public string DirectoryPath { get; }
        public IFileSystemOperator DestinationFileSystemOperator { get; }


        public CreateDirectoryOperation(string directoryPath, IFileSystemOperator destinationFileSystemOperator)
        {
            this.DirectoryPath = directoryPath;
            this.DestinationFileSystemOperator = destinationFileSystemOperator;
        }

        public void Execute()
        {
            this.DestinationFileSystemOperator.CreateDirectory(this.DirectoryPath);
        }
    }
}
