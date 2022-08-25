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
        public string PathFile { get; init; }
        public FileLog(string pathFile)
        {
            PathFile = pathFile;
        }


        public override void AddEntry(Entry entry) // Da controllare la chiusura del file
        {
            // usare questa stringa per l Inizializzatore
            // string path = Path.Combine(PathFile,"SetLog" + DateTime.Now.ToString("yMMdd") + ".log"); // es: SetLog200403.log
            using StreamWriter logFile = File.AppendText(PathFile);

            string stringEntry = entry.ToString();
            
            logFile.WriteLineAsync(stringEntry).Start();

        }

        private Entry[] ReadEntries(StreamReader logReader)
        {
            throw new NotImplementedException();
        }

        public override Entry[] GetEntries()
        {
            return ReadEntries(new StreamReader(PathFile));
        }

        public override Entry[] GetEntries(EntryType filteredType)
        {
            throw new NotImplementedException();
        }
    }
}
