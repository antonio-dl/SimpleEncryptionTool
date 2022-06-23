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


        public FileDecifrato(string path) : base (path)
        {
            

        }


    }

    public class FileCifrato : File
    {
        // private Key _key;

        public FileCifrato(string path) : base(path)
        {

        }


    }
}
