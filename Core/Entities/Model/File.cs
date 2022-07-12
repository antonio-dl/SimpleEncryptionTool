namespace UNIBO.SET.Model
{
    public class CodiceVerifica
    {
        public CodiceVerifica(string codice)
        {
            Codice = codice;
        }

        public string Codice { get; }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj as CodiceVerifica);
        }

        public bool Equals(CodiceVerifica cv)
        {
            return cv is not null && this.Codice.Equals(cv.Codice);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Codice);
        }
    }

    public class File : FileSystemElement
    {
        protected readonly System.IO.FileInfo _file;

        private CodiceVerifica? _codice = null;
        private FileStream? _fileStream = null;
        public File(string path) : base(path)
        {
            _file = new System.IO.FileInfo(path);
        }

        public CodiceVerifica CodiceVerifica
        {
            get
            {
                if (_codice == null)
                    _codice = new CodiceVerifica(this.CalcolaMD5());
                return _codice;
            }
        }

        public FileStream FileStream { get => this._fileStream ??= _file.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite); }
        public new string Name { get => _file.Name; }
        // TODO: da eliminare

        public string CalcolaMD5()
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                using (var stream = this.FileStream)
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToLower();
                }
            }
        }

        public virtual FileStream Open()
        {
            return _file.Open(FileMode.Open, FileAccess.Read);
        }
        public override IList<string> OttieniPaths()
        {
            return new List<string>() { _file.FullName };
        }
    }

    public class FileCifrato : File
    {
        private Key _key;

        public FileCifrato(string path, Key key) : base(path)
        {
            _key = key;
        }

      public FileStream Create()
        {
            return this._file.Open(FileMode.Create, FileAccess.Write);
        }
    }

    public class FileDecifrato : File
    {
        public FileDecifrato(string path) : base(path)
        {
        }
    }
}