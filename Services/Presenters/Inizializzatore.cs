using Microsoft.VisualBasic.FileIO;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using UNIBO.SET.Interfaces;
using UNIBO.SET.Model;
using UNIBO.SET.ModelLog;
using UNIBO.SET.Services.Cifratori;
using UNIBO.SET.Services.Decifratori;
using UNIBO.SET.Services.Presenters;

namespace UNIBO.SET.Services.Presenters
{
    public class Inizializzatore // Classe che si occupa di effettuare tutte le iniezioni di dipendenza
    {


        private GestioneCifraturaPresenter _gestioneCifraturaPresenter;
        private GestioneDecifraturaPresenter _gestioneDecifraturaPresenter;
        private GestioneImpECrededenzialiPresenter _gestioneImpECrededenzialiPresenter;
        private GestioneLoginPresenter _gestioneLoginPresenter;
        private GestioneLogPresenter _gestioneLogPresenter;
        private GestioneVerificaPresenter _gestioneVerificaPresenter;

        private ILogger _logger;

        public Inizializzatore()
        {
            CaricaComponenti();


        }

        public GestioneCifraturaPresenter GestioneCifraturaPresenter { get => _gestioneCifraturaPresenter; private set => _gestioneCifraturaPresenter = value; }
        public GestioneDecifraturaPresenter GestioneDecifraturaPresenter { get => _gestioneDecifraturaPresenter; private set => _gestioneDecifraturaPresenter = value; }
        public GestioneImpECrededenzialiPresenter GestioneImpECrededenzialiPresenter { get => _gestioneImpECrededenzialiPresenter; private set => _gestioneImpECrededenzialiPresenter = value; }
        public GestioneLoginPresenter GestioneLoginPresenter { get => _gestioneLoginPresenter; private set => _gestioneLoginPresenter = value; }
        public GestioneLogPresenter GestioneLogPresenter { get => _gestioneLogPresenter; private set => _gestioneLogPresenter = value; }
        public GestioneVerificaPresenter GestioneVerificaPresenter { get => _gestioneVerificaPresenter; private set => _gestioneVerificaPresenter = value; }
        public ILogger Logger { get => _logger; private set => _logger = value; }

        private void CaricaComponenti()
        {
            GestioneLogPresenter = new GestioneLogPresenter(SpecialDirectories.CurrentUserApplicationData + @"SET\Log"); // TODO: TEST THIS NON SO SE E UN PATH VALIDO
            Logger = GestioneLogPresenter as ILogger;
            GestioneVerificaPresenter = new GestioneVerificaPresenter(Logger); // Controllare che abbia effetivamente bisogno del logger

            GestioneCifraturaPresenter = CreaGestioneCifraturaPresenter();
            GestioneDecifraturaPresenter = CreaGestioneDecifraturaPresenter();


            GestioneImpECrededenzialiPresenter = new GestioneImpECrededenzialiPresenter(Logger);

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

        private GestioneDecifraturaPresenter CreaGestioneDecifraturaPresenter()
        {
            GestioneDecifraturaPresenter result;
            IDictionary<string, IDecifratore> mappaDecifratori = GeneraMappaDecifratori();


            result = new GestioneDecifraturaPresenter(Logger, mappaDecifratori);
            return result;
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
