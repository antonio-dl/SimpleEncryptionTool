using UNIBO.SET.ModelLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIBO.SET.LogModel
{
    public class FileLog : Log
    {
        public string PathCartella { get; init; }
        public FileLog (string pathCartella)
        {
            PathCartella = pathCartella;
        }
        public override void Save() // Questo metodo va eliminato
        {
            var file = File.AppendText(Path.Combine(PathCartella,DateTime.Now.ToString("yMdd")));
            


        }
    }
}
