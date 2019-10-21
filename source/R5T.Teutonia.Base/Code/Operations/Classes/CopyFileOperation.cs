using System;

using R5T.Gepidia;


namespace R5T.Teutonia
{
    public class CopyFileOperation : IFileSystemCloningOperation
    {
        public string SourceFilePath { get; }
        public IFileSystemOperator SourceFileSystemOperator { get; }
        public string DestinationFilePath { get; }
        public IFileSystemOperator DestinationFileSystemOperator { get; }


        public void Execute()
        {
            this.SourceFileSystemOperator.Copy(this.SourceFilePath, this.DestinationFileSystemOperator, this.DestinationFilePath);
        }
    }
}
