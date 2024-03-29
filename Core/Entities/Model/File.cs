﻿namespace UNIBO.SET.Model
{
    [Serializable]
    public class CodiceVerifica
    {
        public string Codice { get; }

        public CodiceVerifica(string codice)
        {
            Codice = codice;
        }


        public override int GetHashCode()
        {
            return HashCode.Combine(Codice);
        }

        public override bool Equals(object? obj)
        {
            return obj is CodiceVerifica verifica &&
                   Codice == verifica.Codice;
        }
    }

    public class File : FileSystemElement
    {
        protected readonly System.IO.FileInfo _file;

        private CodiceVerifica? _codice = null;

        public File(string path) : base(path)
        {
            _file = new System.IO.FileInfo(path);
        }

        public bool Exists => _file.Exists;

        public CodiceVerifica CodiceVerifica
        {
            get
            {
                return _codice ??= new CodiceVerifica(this.CalcolaMD5());
            }
        }

        public override string ToString() => this.Path;

        public new string Name { get => _file.Name; }

        public string CalcolaMD5()
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                using (var stream = this.Open())
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLower();
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
        public Key? Key { get; private set; }

        public FileCifrato(string path, Key key) : base(path)
        {
            Key = key;
        }

        public FileCifrato(string path) : base(path)
        {
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

        public FileStream Create()
        {
            return this._file.Open(FileMode.Create, FileAccess.Write);
        }

        public void Delete()
        {
            this._file.Delete();
            return;
        }
    }
}