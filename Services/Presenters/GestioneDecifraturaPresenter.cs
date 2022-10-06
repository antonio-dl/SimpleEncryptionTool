using UNIBO.SET.Interfaces;
using UNIBO.SET.Model;
using UNIBO.SET.ModelLog;
using UNIBO.SET.Services.Decifratori;

namespace UNIBO.SET.Services.Presenters
{
    public class GestioneDecifraturaPresenter : IGestioneDecifratura
    {
        private readonly ILogger _logger;
        private IDecifratore? _decifratore;

        public USB? SelectedUSB { get; private set; }
        public KeyChain? SelectedKeyChain { get; private set; }

        private readonly IDictionary<string, IDecifratore> _decifratoriDictonary;

        public GestioneDecifraturaPresenter(ILogger logger, IDictionary<string, IDecifratore> decifratoriDictonary)
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
                this.LogIt(EntryType.Errore, $"Errore nel apertura del file {key.TargetFilePath}: path non esistente!");
                throw e;
            }
            catch (IOException e)
            {
                this.LogIt(EntryType.Errore, $"Errore IO nel file {key.TargetFilePath}");
                throw e;
            }
        }

        public USB[] ElencaDispositiviEsterni()
        {
            return USB.GetUsbs();
        }

        public ISet<Model.File> FileDecifrabili(KeyChain chain)
        {
            HashSet<Model.File> result = new HashSet<Model.File>();
            foreach (var key in chain.GetAllKey())
            {
                var file = new Model.File(key.SourceFilePath);
                if (file.Exists)
                    result.Add(file);
            }
            return result;
        }

        public void LogIt(EntryType type, string messaggio)
        {
            _logger.WriteLog(type, this.GetType().Name, messaggio);
        }

        public KeyChain ScansionaUSB()
        {
            if (this.SelectedUSB.HasKeyChain())
                return new FileKeyChain(this.SelectedUSB.GetPathToKeyChain());
            else
                return null;
        }

        public void SelezionaKeyChain(KeyChain chain)
        {
            this.SelectedKeyChain = chain;
        }

        public void SelezionaUSB(USB usb)
        {
            this.SelectedUSB = usb;
        }
    }
}