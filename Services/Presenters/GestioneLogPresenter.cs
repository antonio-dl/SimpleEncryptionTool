using System.Text;

using UNIBO.SET.ModelLog;

namespace UNIBO.SET.Services.Presenters
{
    public class GestioneLogPresenter : UNIBO.SET.Interfaces.IGestioneLog
    {
        private Log _log;
        public string CartellaLog { get; set; }

        public GestioneLogPresenter(string pathCartellaLog)
        {
            CartellaLog = pathCartellaLog;
            Directory.CreateDirectory(pathCartellaLog);

            _log = new FileLog(Path.Combine(CartellaLog, "SET" + DateTime.Now.ToString("yMMdd") + ".log"));

            return;
        }

        public void WriteLog(EntryType type, string fonte, string messaggio)
        {
            _log.AddEntry(new Entry(type, fonte, messaggio));
        }

        public Log[] GetAllLogs() // TODO: Da testare
        {
            return Directory.EnumerateFiles(CartellaLog, "*.log").Select(f => new FileLog(f)).ToArray();
        }

        public string ReadLog(Log selectedLog)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var entry in selectedLog.GetEntries())
            {
                sb.AppendLine(entry.ToString());
            }
            return sb.ToString();
        }

        public string ReadLog(Log selectedLog, EntryType filteredType)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var entry in selectedLog.GetEntries(filteredType))
            {
                sb.AppendLine(entry.ToString());
            }
            return sb.ToString();
        }
    }
}