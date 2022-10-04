using Microsoft.VisualBasic.FileIO;
using System.Runtime.Serialization;
using UNIBO.SET.Interfaces;
using UNIBO.SET.Model;
using UNIBO.SET.ModelLog;
using UNIBO.SET.Services.Cifratori;
using UNIBO.SET.Services.Decifratori;

namespace UNIBO.SET.Services.Presenters
{
    public class Inizializzatore // Classe che si occupa di effettuare tutte le iniezioni di dipendenza
    {

        public Inizializzatore()
        {
            Utente u = Utente.GetInstance();
            u.Nome = Environment.UserName;

            u.Impostazioni = LoadImpostazioni();

            GestioneLogPresenter = new GestioneLogPresenter(SETEnvironment.Log_Folder); // TODO: TEST THIS NON SO SE E UN PATH VALIDO
            Logger = GestioneLogPresenter as ILogger;
            GestioneVerificaPresenter = new GestioneVerificaPresenter(Logger); // Controllare che abbia effetivamente bisogno del logger
            GestioneLoginPresenter = new GestioneLoginPresenter(Logger);
            GestioneCifraturaPresenter = CreaGestioneCifraturaPresenter();
            GestioneDecifraturaPresenter = CreaGestioneDecifraturaPresenter();

            GestioneImpECrededenzialiPresenter = new GestioneImpECrededenzialiPresenter(Logger);
        }

        public GestioneCifraturaPresenter GestioneCifraturaPresenter { get; private set; }

        public GestioneDecifraturaPresenter GestioneDecifraturaPresenter { get; private set; }

        public GestioneImpECrededenzialiPresenter GestioneImpECrededenzialiPresenter { get; private set; }

        public GestioneLoginPresenter GestioneLoginPresenter { get ; private set; }

        public GestioneLogPresenter GestioneLogPresenter { get; private set; }

        public GestioneVerificaPresenter GestioneVerificaPresenter { get; private set; }

        public ILogger Logger { get ; private set ; }

        private Impostazione CaricaCifratori()
        {
            string[] cifratoriOpzioni = { "AES-ECB", "AES-CBC" };
            return new Impostazione("cifratore", cifratoriOpzioni[0], cifratoriOpzioni);
        }

        private ICifratore CreaCifratore(Impostazione impostazione)
        {
            string nomeCifratore = impostazione.Selezionato;
            if (nomeCifratore == "AES-CBC")
                return new CifratoreAEScbc();
            else if (nomeCifratore == "AES-ECB")
                return new CifratoreAESecb();
            else
            {
                Logger.WriteLog(EntryType.Errore, "Inizializzatore", $"Il cifratore {nomeCifratore} non è stato trovato mentre si tentava di inizializzare l' applicativo");
                throw new CifratoreNotFoundExeption($"Il cifratore {nomeCifratore} non è stato trovato");
            }
        }

        private GestioneCifraturaPresenter CreaGestioneCifraturaPresenter()
        {
            Impostazione impostazione;
            try
            {
                impostazione = Utente.GetInstance().Impostazioni.OttieniImpostazione("cifratore");
            }
            catch (KeyNotFoundException e)
            {
                Logger.WriteLog(EntryType.Errore, "Inizializzatore", "Errore nella ricerca dell' impostazione {cifratore}");
                throw e;
            }
            ICifratore cifratore = CreaCifratore(impostazione);
            var presenter = new GestioneCifraturaPresenter(cifratore, this.Logger);
            return presenter;
        }

        private GestioneDecifraturaPresenter CreaGestioneDecifraturaPresenter()
        {
            GestioneDecifraturaPresenter result;
            IDictionary<string, IDecifratore> mappaDecifratori = GeneraMappaDecifratori();

            result = new GestioneDecifraturaPresenter(Logger, mappaDecifratori);
            return result;
        }

        private Impostazioni CreateDefaultSettings()
        {
            Dictionary<string, Impostazione> settings = new Dictionary<string, Impostazione>();
            Impostazione i = CaricaCifratori();
            settings[i.Nome] = i;

            return new Impostazioni(settings);
        }

        private Dictionary<string, IDecifratore> GeneraMappaDecifratori()
        {
            var result = new Dictionary<string, IDecifratore>();
            IDecifratore decifratore;

            decifratore = new DecifratoreAEScbc();
            result.Add(decifratore.Algoritmo, decifratore);

            decifratore = new DecifratoreAESecb();
            result.Add(decifratore.Algoritmo, decifratore);

            return result;
        }

        private Impostazioni LoadImpostazioni()
        {
            string pathImpostazioni = SETEnvironment.Configuration_Path;
            if (System.IO.File.Exists(pathImpostazioni))
            {
                Impostazioni i;
                string settingsJSON = System.IO.File.ReadAllText(pathImpostazioni);

                return i = System.Text.Json.JsonSerializer.Deserialize<Impostazioni>(settingsJSON);
            }
            else
            {
                Impostazioni created = CreateDefaultSettings();
                string contents = System.Text.Json.JsonSerializer.Serialize(created);
                System.IO.File.WriteAllText(pathImpostazioni, contents);
                return created;
            }
        }
    }

    [Serializable]
    internal class CifratoreNotFoundExeption : Exception
    {
        public CifratoreNotFoundExeption()
        {
        }

        public CifratoreNotFoundExeption(string? message) : base(message)
        {
        }

        public CifratoreNotFoundExeption(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CifratoreNotFoundExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}