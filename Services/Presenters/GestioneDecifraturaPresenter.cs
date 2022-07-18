using Services.Shared;
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

    public class GestioneDecifraturaPresenter : IGestioneDecifratura
    {
        private readonly ILogger _logger;
        private IDecifratore? _decifratore;


        public USB? SelectedUSB { get; set; }

        private readonly Dictionary<string, IDecifratore> _decifratoriDictonary;

        public GestioneDecifraturaPresenter(ILogger logger, Dictionary<string, IDecifratore> decifratoriDictonary)
        {
            _logger = logger;
            _decifratoriDictonary = decifratoriDictonary;

        }

        public FileDecifrato Decifra(Key key)
        {
            if (_decifratore is not null && _decifratore.Algoritmo != key.Algoritmo) // Caching del decifratore
            {
                try
                {
                    _decifratore = _decifratoriDictonary[key.Algoritmo];
                }
                catch (KeyNotFoundException e)
                {
                    this.LogIt(EntryType.Errore, $"La chiave ha un algoritmo non supportato! Key {key}"); // TODO: To String di Key
                    throw e;
                }

            }

            try
            {
                return _decifratore.Decifra(key);
            }
            catch (FileNotFoundException e)
            {
                this.LogIt(EntryType.Errore, $"Errore nel apertura del file {key.TargetFile}: path non esistente!");
                throw e;
            }
            catch (IOException e)
            {
                this.LogIt(EntryType.Errore, $"Errore IO nel file {key.TargetFile}");
                throw e;
            }
            catch (DecifrazioneException e)
            {
                this.LogIt(EntryType.Errore, $"Errore IO nel file {key.TargetFile}");
                throw e;
            }


        }

        public USB[] ElencaDispositiviEsterni()
        {
            return SystemHelper.GetUsbs();
        }

        public ISet<Model.File> FileDecifrabili(KeyChain chain)
        {
            throw new NotImplementedException();
        }

        public void LogIt(EntryType type, string messaggio)
        {
            _logger.WriteLog(type, this.GetType().Name, messaggio);
        }

        public KeyChain ScansionaUSB()
        {
            throw new NotImplementedException();
        }


        public void SelezionaKeyChain(KeyChain chain)
        {
            throw new NotImplementedException();
        }

        public void SelezionaUSB(USB usb)
        {
            this.SelectedUSB = usb;
        }



    }

    public interface IDecifratore
    {
        FileDecifrato Decifra(Key key);
        string Algoritmo { get; }
    }
}
