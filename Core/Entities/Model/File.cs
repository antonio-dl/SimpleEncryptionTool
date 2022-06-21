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
        protected FileStream fs;

        public File(string path) : base(path)
        {
            _file = new System.IO.FileInfo(path);
        }

        public FileStream GetFileStream { get { return fs; } }

        public override IList<string> OttieniPaths()
        {
            throw new NotImplementedException();
        }
    }

    public class FileDecifrato : File
    {


        public FileDecifrato(string path)
        {
            fs = System.IO.File.Open(path, FileMode.Open, FileAccess.Read); // readOnly

        }


    }

    public class FileCifrato : File
    {
        public FileCifrato(string path)
        {
            fs = System.IO.File.Open(path, FileMode.Open, FileAccess.ReadWrite); // readWrite

        }


    }
}
