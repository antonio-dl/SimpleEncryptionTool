using UNIBO.SET.Interfaces;
using UNIBO.SET.Model;
using UNIBO.SET.ModelLog;
using UNIBO.SET.Services.Decifratori;
using UNIBO.SET.Services.Shared;

namespace UNIBO.SET.Services.Presenters
{
    public class GestioneDecifraturaPresenter : IGestioneDecifratura
    {
        private readonly IDictionary<string, IDecifratore> _decifratoriDictonary;
        private readonly ILogger _logger;
        private IDecifratore? _decifratore;

        public GestioneDecifraturaPresenter(ILogger logger, IDictionary<string, IDecifratore> decifratoriDictonary)
        {
            _logger = logger;
            _decifratoriDictonary = decifratoriDictonary;
        }

        public FileKeyChain? SelectedKeyChain { get; private set; }
        public USB? SelectedUSB { get; private set; }
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

                this.LogIt(EntryType.Operazione, $"Decifrazione del file {key.TargetFilePath} in {key.SourceFilePath}");
                FileDecifrato fd = _decifratore.Decifra(key);
                if (fd.Path != key.SourceFilePath) // Sovrascittura evitata!
                    LogIt(EntryType.Avvertimento, $"Il file {key.SourceFilePath} è stato rinominato in {fd.Path} per evitare conflitti di nomi");
                return fd;
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

        public void SalvaKeyChain(FileKeyChain? selectedKeyChain)
        {
            Helper.SalvaFileKeyChain(selectedKeyChain);
        }

        public FileKeyChain ScansionaUSB()
        {
            if (this.SelectedUSB.HasKeyChain())
            {
                this.SelezionaKeyChain(Helper.RecuperaFileKeyChain(this.SelectedUSB.GetPathToKeyChain()));
                return this.SelectedKeyChain;
            }
            else
                return null;
        }

        public void SelezionaKeyChain(FileKeyChain chain)
        {
            this.SelectedKeyChain = chain;
            this.LogIt(EntryType.Info, $"Selezionata KeyChain nel path {chain}");
        }

        public void SelezionaUSB(USB usb)
        {
            this.SelectedUSB = usb;
        }
    }
}