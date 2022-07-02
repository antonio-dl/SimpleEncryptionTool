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

        public GestioneLogPresenter(Log log)
        {
            _log = log;
        }

        public void WriteLog(EntryType type, string fonte, string messaggio)
        {
            _log.AddEntry(new Entry(type, fonte, messaggio));

        }




    }
}
