using System.Runtime.Serialization.Formatters.Binary;
using UNIBO.SET.Interfaces;
using UNIBO.SET.Model;
using UNIBO.SET.ModelLog;
using UNIBO.SET.Services.Cifratori;

namespace UNIBO.SET.Services.Presenters
{
    public class GestioneCifraturaPresenter : IGestioneCifratura
    {
        private readonly ILogger _logger;
        public USB? SelectedUSB { get; set; }
        public ISet<string> ListaFileSelezionati { get; set; }

        private ICifratore Cifratore { get; set; }

        public GestioneCifraturaPresenter(ICifratore cifratore, ILogger logger)
        {
            Cifratore = cifratore;
            ListaFileSelezionati = new HashSet<string>();
            _logger = logger;
        }

        public bool Aggiungi(FileSystemElement sysElement)
        {
            foreach (string path in sysElement.OttieniPaths())
                ListaFileSelezionati.Add(path);
            return true;
        }

        public Key Cifra(Model.File file) // da vedere altre eccezioni
        {
            this.LogIt(EntryType.Operazione, $"Cifrato file nel path: {file.Path}");
            try
            {
                return this.Cifratore.CifraFile(file);
            }
            catch (FileNotFoundException ex)
            {
                this.LogIt(EntryType.Errore, $"Il file non esiste: {file.Path}");
                throw ex;
            }
        }

        public USB[] ElencaDispositiviEsterni()
        {
            return USB.GetUsbs();
        }

        public void LogIt(EntryType type, string messaggio)
        {
            _logger.WriteLog(type, this.GetType().Name, messaggio);
        }

        public bool Rimuovi(FileSystemElement sysElement)
        {
            bool result = true;
            foreach (string path in sysElement.OttieniPaths())
                result &= ListaFileSelezionati.Remove(path);
            return result;
        }

        public void SelezionaUSB(USB usb)
        {
            this.SelectedUSB = usb;
        }

        public void SalvaKey(Key key)
        {
            if (this.SelectedUSB == null)
                return;
            string pathToKeyChain = this.SelectedUSB.GetPathToKeyChain();

            FileKeyChain fkc = RecuperaFileKeyChain(pathToKeyChain);
            fkc.AddKey(key);
            SalvaFileKeyChain(fkc);


        }

        private void SalvaFileKeyChain(FileKeyChain fkc)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(fkc.PathFileKeyChain));

            BinaryFormatter bf = new BinaryFormatter();
            FileInfo f = new FileInfo(fkc.PathFileKeyChain);
            using Stream stream = f.OpenWrite();
            bf.Serialize(stream,fkc);
        }

        private FileKeyChain RecuperaFileKeyChain(string pathToKeyChain)
        {
            if (System.IO.File.Exists(pathToKeyChain))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileInfo f = new FileInfo(pathToKeyChain);
                using Stream stream = f.OpenRead();
                return (FileKeyChain)bf.Deserialize(stream);
            } else
            {

                return new FileKeyChain(pathToKeyChain);
            }
            
        }
    }
}