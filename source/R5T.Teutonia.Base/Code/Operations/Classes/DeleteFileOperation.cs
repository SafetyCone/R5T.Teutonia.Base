using System;

using R5T.Gepidia;


namespace R5T.Teutonia
{
    public class DeleteFileOperation : IFileSystemCloningOperation
    {
        public string FilePath { get; }
        public IFileSystemOperator FileSystemOperator { get; }


        public DeleteFileOperation(string filePath, IFileSystemOperator fileSystemOperator)
        {
            this.FilePath = filePath;
            this.FileSystemOperator = fileSystemOperator;
        }

        public void Execute()
        {
            this.FileSystemOperator.DeleteFile(this.FilePath);
        }
    }
}
