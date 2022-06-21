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


        public FileDecifrato(string path) : base (path)
        {
            

        }


    }

    public class FileCifrato : File
    {
        private Key _key;

        public FileCifrato(string path) : base(path)
        {

        }


    }
}
