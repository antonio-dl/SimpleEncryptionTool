using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            _log = new FileLog(Path.Combine(CartellaLog, "SetLog" + DateTime.Now.ToString("yMMdd") + ".log"));

        }

        public void WriteLog(EntryType type, string fonte, string messaggio)
        {
            _log.AddEntry(new Entry(type, fonte, messaggio));

        }

        public Log[] GetAllLog() // TODO: Da testare
        {
            return Directory.EnumerateFiles(CartellaLog, "*.log").Select(f => new FileLog(f)).ToArray();
        }

        public string ReadLog()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var entry in _log.GetEntries())
            {
                sb.AppendLine(entry.ToString());
            }
            return sb.ToString();
        }

        public string ReadLog(EntryType filteredType)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var entry in _log.GetEntries(filteredType))
            {
                sb.AppendLine(entry.ToString());
            }
            return sb.ToString();
        }

    }
}
