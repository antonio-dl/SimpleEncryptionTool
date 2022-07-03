using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UNIBO.SET.Model
{
    public class File : FileSystemElement
    {
        private readonly System.IO.FileInfo _file;

        public new string Name { get => _file.Name; }

        private CodiceVerifica? _codice = null;
        public CodiceVerifica CodiceVerifica
        {
            get
            {
                if (_codice == null)
                    _codice = new CodiceVerifica(this.CalcolaMD5());
                return _codice;
            }
        }

        public bool Equals(CodiceVerifica cv)
        {
            CodiceVerifica questo = this.CodiceVerifica;

            return questo.Codice.Equals(cv.Codice);
        }

        protected FileStream FileStream { get => _file.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite); }

        public File(string path) : base(path)
        {
            _file = new System.IO.FileInfo(path);
        }


        public override IList<string> OttieniPaths()
        {
            return new List<string>() { _file.FullName };
        }

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
    }

    public class FileDecifrato : File
    {


        public FileDecifrato(string path) : base(path)
        {


        }


    }

    public class FileCifrato : File
    {
        private Key _key;

        public FileCifrato(string path, Key key) : base(path)
        {
            _key = key;

        }


    }

    public class CodiceVerifica
    {
        public string Codice { get; }

        public CodiceVerifica(string codice)
        {
            Codice = codice;
        }
    }
}
