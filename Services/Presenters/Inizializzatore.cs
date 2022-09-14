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
        private GestioneCifraturaPresenter _cifratura;
        private GestioneDecifraturaPresenter _decifratura;
        private GestioneImpECrededenzialiPresenter _impECrededenziali;
        private GestioneLoginPresenter _login;
        private GestioneLogPresenter _log;
        private GestioneVerificaPresenter _verifica;

    }
}
