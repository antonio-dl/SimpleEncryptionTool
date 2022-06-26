using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UNIBO.SET.Model
{
    public class Cartella : FileSystemElement
    {
        private System.IO.DirectoryInfo _directory;

        public Cartella(string path) : base(path)
        {
            _directory = new System.IO.DirectoryInfo(path);
        }


        public override IList<string> OttieniPaths() 
        {
            var result = new List<string>();
            foreach(var dir in _directory.EnumerateDirectories())
            {
                result.AddRange(new Cartella(dir.FullName).OttieniPaths());
            }
            foreach (var file in _directory.GetFiles())
            {
                result.AddRange(new File(file.FullName).OttieniPaths());
            }
            return result;
        }
    }
}
