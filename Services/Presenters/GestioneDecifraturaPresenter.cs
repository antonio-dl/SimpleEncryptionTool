using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UNIBO.SET.Interfaces;
using UNIBO.SET.Model;
using UNIBO.SET.ModelLog;

namespace UNIBO.SET.Services.Presenters
{
    // probabilmente va aggiunta l'interfaccia IDecifratore, come per il GestioneCifraturaPresenter

    public class GestioneDecifraturaPresenter : IGestioneDecifratura
    {
        private ILogger _logger;
        public void Decifra()
        {
            throw new NotImplementedException();
        }

        public USB[] ElencaDispositiviEsterni()
        {
            throw new NotImplementedException();
        }

        public void LogIt(EntryType type, string messaggio)
        {
            _logger.WriteLog(type, this.GetType().Name, messaggio);
        }

        public void ScansionaUSB()
        {
            throw new NotImplementedException();
        }

        public void SelezionaKey()
        {
            throw new NotImplementedException();
        }

        public bool SelezionaUSB()
        {
            throw new NotImplementedException();
        }

        public bool SelezionaUSB(USB usb)
        {
            throw new NotImplementedException();
        }
    }
