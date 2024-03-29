﻿using System.Globalization;

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
            // usare questa stringa per l'Inizializzatore
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
            logReader.Close();
            return result.ToArray();
        }

        private Entry parseLine(string line)
        {
            string[] tokens = line.Split('|');

            DateTime timestamp = DateTime.ParseExact(tokens[0].Trim(), "yyyy/MM/dd HH:mm:ss.ff", CultureInfo.CurrentCulture);
            EntryType type = Enum.Parse<EntryType>(tokens[1]);
            string componenteFonte = tokens[2];
            string message = tokens[3];

            return new Entry(timestamp, type, componenteFonte, message);
        }

        public override Entry[] GetEntries()
        {
            using var sr = new StreamReader(PathFile);
            return ReadEntries(sr);
        }

        public override Entry[] GetEntries(EntryType filteredType)
        {
            Entry[] result = GetEntries();

            return result.Where(entry => entry.Type == filteredType).ToArray();
        }

        public override string ToString()
        {
            return Path.GetFileName(this.PathFile);
        }
    }
}