using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNIBO.SET.Services.Presenters;

namespace Services.Presenters
{
    public class Inizializzatore // Classe che si occupa di effettuare tutte le iniezioni di dipendenza
    {
        public Inizializzatore()
        {
            CreaUtenteSingleton();
            CaricaComponenti();


        }

        private void CaricaComponenti()
        {
            throw new NotImplementedException();
        }

        private void CreaUtenteSingleton()
        {
            throw new NotImplementedException();
        }
        private GestioneCifraturaPresenter _gestioneCifraturaPresenter;
        private GestioneDecifraturaPresenter _gestioneDecifraturaPresenter;
        private GestioneImpECrededenzialiPresenter _gestioneImpECrededenzialiPresenter;
        private GestioneLoginPresenter _gestioneLoginPresenter;
        private GestioneLogPresenter _gestioneLogPresenter;
        private GestioneVerificaPresenter _gestioneVerificaPresenter;

        public GestioneCifraturaPresenter GestioneCifraturaPresenter { get => _gestioneCifraturaPresenter; }
        public GestioneDecifraturaPresenter GestioneDecifraturaPresenter { get => _gestioneDecifraturaPresenter; }
        public GestioneImpECrededenzialiPresenter GestioneImpECrededenzialiPresenter { get => _gestioneImpECrededenzialiPresenter; }
        public GestioneLoginPresenter GestioneLoginPresenter { get => _gestioneLoginPresenter; }
        public GestioneLogPresenter GestioneLogPresenter { get => _gestioneLogPresenter; }
        public GestioneVerificaPresenter GestioneVerificaPresenter { get => _gestioneVerificaPresenter; }
    }
}
