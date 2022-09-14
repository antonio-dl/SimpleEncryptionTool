using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNIBO.SET.Interfaces;
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

        private void CaricaComponenti()
        {
            GestioneLogPresenter = new GestioneLogPresenter(SpecialDirectories.CurrentUserApplicationData + @"SET\Log"); // TODO: TEST THIS NON SO SE E UN PATH VALIDO
            ILogger logger = GestioneLogPresenter as ILogger;
            GestioneVerificaPresenter = new GestioneVerificaPresenter(logger); // Controllare che abbia effetivamente bisogno del logger
            // GestioneCifraturaPresenter = new GestioneCifraturaPresenter(); // metodo prima della modifica: GeneraCifratorePresenter()
            // GestioneDecifraturaPresenter = GeneraDecifratorePresenter();

            GestioneImpECrededenzialiPresenter = new GestioneImpECrededenzialiPresenter(logger);

        }

        private void CreaUtenteSingleton()
        {
            throw new NotImplementedException();
        }
    }
}
