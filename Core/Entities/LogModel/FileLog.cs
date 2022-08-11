using UNIBO.SET.ModelLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIBO.SET.ModelLog

{
    public class FileLog : Log
    {
        public string PathCartella { get; init; }
        public FileLog(string pathCartella)
        {
            PathCartella = pathCartella;
        }


        public override void AddEntry(Entry entry) // Da controllare la chiusura del file
        {
            string path = Path.Combine(PathCartella, DateTime.Now.ToString("yMMdd") + ".log");
            using StreamWriter logFile = File.AppendText(path);

            string stringEntry = entry.ToString();
            
            logFile.WriteLineAsync(stringEntry).Start();

        }

    }
}
