using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using UNIBO.SET.Interfaces;
using UNIBO.SET.Model;
using UNIBO.SET.Services.Cifratori;
using UNIBO.SET.Services.Presenters;

namespace Services.Presenters
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
            CreaUtenteSingleton();
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
            ILogger logger = GestioneLogPresenter as ILogger;
            GestioneVerificaPresenter = new GestioneVerificaPresenter(logger); // Controllare che abbia effetivamente bisogno del logger

            GestioneCifraturaPresenter = CreaGestioneCifraturaPresenter(logger);
            GestioneDecifraturaPresenter = CreaGestioneDecifraturaPresenter();


            GestioneImpECrededenzialiPresenter = new GestioneImpECrededenzialiPresenter(logger);

        }

        private GestioneCifraturaPresenter CreaGestioneCifraturaPresenter(ILogger logger)
        {

            Impostazione impostazione = Utente.GetInstance().Impostazioni.OttieniImpostazione("cifratore");

            ICifratore cifratore = CreaCifratore(impostazione);
            var presenter = new GestioneCifraturaPresenter(cifratore, logger);
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
                throw new CifratoreNotFoundExeption($"Il cifratore {nomeCifratore} non è stato trovato");

        }

        private GestioneDecifraturaPresenter CreaGestioneDecifraturaPresenter()
        {
            throw new NotImplementedException();
        }

        private void CreaUtenteSingleton()
        {
            throw new NotImplementedException();
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
