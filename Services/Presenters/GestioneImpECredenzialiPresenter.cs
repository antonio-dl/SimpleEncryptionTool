using UNIBO.SET.Interfaces;
using UNIBO.SET.Model;
using UNIBO.SET.ModelLog;

namespace UNIBO.SET.Services.Presenters
{
    public class GestioneImpECrededenzialiPresenter : IGestioneCredenziali, IGestioneImpostazioni
    {
        private Utente _utente;
        private ILogger _logger;

        public GestioneImpECrededenzialiPresenter(ILogger logger)
        {
            _utente = Utente.GetInstance();
            _logger = logger;
        }

        public bool CambiaImpostazione(string selezionato, Impostazione impostazione)
        {
            Impostazioni opt = _utente.Impostazioni;
            var currentImpostazione = opt.OttieniImpostazione(impostazione.Nome);

            currentImpostazione.Selezionato = selezionato;
            LogIt(EntryType.Info, $"{impostazione.Nome}: l'impostazione è stata modificata in {impostazione.Selezionato}");
            return true;

        }

        public void PersistiImpostazioni(Impostazioni opt)
        {
            string pathImpostazioni = SETEnvironment.Configuration_Path;
            string contents = System.Text.Json.JsonSerializer.Serialize(opt);
            System.IO.File.WriteAllText(pathImpostazioni, contents);
            return;
        }

        public void LogIt(EntryType type, string messaggio)
        {
            _logger.WriteLog(type, this.GetType().Name, messaggio);
        }

        public Impostazioni OttieniImpostazioni()
        {
            return _utente.Impostazioni;
        }

        public bool SalvaNuoveCredenziali(Credenziali vecchie, Credenziali nuove)
        {
            if (!_utente.Credenziali.Confronta(vecchie))
            {
                LogIt(EntryType.Avvertimento, "Tentativo di cambio credenziali fallito");
                return false;
            }
            else
            {
                _utente.Credenziali = nuove;
                LogIt(EntryType.Info, "L'utente ha cambiato le credenziali");
            }
            return true;
        }
    }
}