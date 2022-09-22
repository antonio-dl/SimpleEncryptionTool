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


        public override void AddEntry(Entry entry)
        {
            // usare questa stringa per l Inizializzatore
            // string path = Path.Combine(PathFile,"SetLog" + DateTime.Now.ToString("yMMdd") + ".log"); // es: SetLog200403.log
            using StreamWriter logFile = File.AppendText(PathFile);

            string stringEntry = entry.ToString();

            logFile.WriteLine(stringEntry);
        }

        private Entry[] ReadEntries(StreamReader logReader)
        {
            IList<Entry> result = new List<Entry>();
            string line;
            while ((line = logReader.ReadLine()) is not null)
            {
                Entry entry = parseLine(line);
                result.Add(entry);
            }

            return result.ToArray();
        }

        private Entry parseLine(string line)
        {
            string[] tokens = line.Split('|');

            DateTime timestamp = DateTime.Parse(tokens[0]);
            EntryType type = Enum.Parse<EntryType>(tokens[1]);
            string componenteFonte = tokens[2];
            string message = tokens[3];

            return new Entry(timestamp, type, componenteFonte, message);
        }

        public override Entry[] GetEntries()
        {
            return ReadEntries(new StreamReader(PathFile));
        }

        public override Entry[] GetEntries(EntryType filteredType)
        {
            Entry[] result = GetEntries();

            return result.Where(entry => entry.Type == filteredType).ToArray();
        }
    }
}
