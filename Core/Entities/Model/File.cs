using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UNIBO.SET.Model
{
    public abstract class File
    {
        protected FileStream fs;
        public abstract FileStream GetFileStream
        { get; }


    }

    public class FileDecifrato : File
    {


        public sealed override FileStream GetFileStream { get { return fs; } }
        public FileDecifrato(string path)
        {
            fs = System.IO.File.Open(path, FileMode.Open, FileAccess.Read); // readOnly

        }


    }

    public class FileCifrato : File
    {
        public sealed override FileStream GetFileStream { get { return fs; } }
        public FileCifrato(string path)
        {
            fs = System.IO.File.Open(path, FileMode.Open, FileAccess.ReadWrite); // readWrite

        }


    }
}
