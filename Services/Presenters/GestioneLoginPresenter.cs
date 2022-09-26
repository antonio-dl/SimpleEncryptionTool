using UNIBO.SET.Interfaces;
using UNIBO.SET.Model;
using UNIBO.SET.ModelLog;

namespace UNIBO.SET.Services.Presenters
{
    public class GestioneLoginPresenter : IGestioneLogin
    {
        private Utente _utente;
        private ILogger _logger;

        public GestioneLoginPresenter(Utente utente, ILogger logger)
        {
            _utente = utente;
            _logger = logger;
        }

        public bool LogIn(Credenziali credenziali)
        {
            Thread.Sleep(1200); // Per evitare brute force
            if (!_utente.Credenziali.Confronta(credenziali))
            {
                LogIt(EntryType.Avvertimento, "Login fallito, credenziali errate");
                return false;
            }
            return true;
        }

        public void LogIt(EntryType type, string messaggio)
        {
            _logger.WriteLog(type, this.GetType().Name, messaggio);
        }
    }
}