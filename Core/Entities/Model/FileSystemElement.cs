using System.IO;


namespace UNIBO.SET.Model
{
    public abstract class FileSystemElement
    {
        private readonly System.IO.FileSystemInfo _info;
        public string Path { get; }
        public string Name { get; }

        public FileSystemElement(string path)
        {
            Path = path ?? throw new ArgumentNullException(nameof(path));
            
        }

        public abstract IList<string> OttieniPaths();
    }
}