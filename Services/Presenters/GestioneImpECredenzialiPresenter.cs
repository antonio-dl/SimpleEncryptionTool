using System;
using UNIBO.SET.Interfaces;
using UNIBO.SET.Model;
using UNIBO.SET.ModelLog;

namespace UNIBO.SET.Services.Presenters
{
    public class GestioneImpECrededenzialiPresenter : IGestioneCredenziali, IGestioneImpostazioni
    {   
        private Utente _utente;
        private ILogger _logger;

        public GestioneImpECrededenzialiPresenter(Utente utente, ILogger logger)
        {
            _utente = utente;
            _logger = logger;
        }

        public bool CambiaImpostazione(Impostazione impostazione)
        {
            Impostazioni opt = _utente.Impostazioni;
            Impostazione[] tutte = opt.OttieniSettaggi();
            
            for(int i=0; i < opt.NumSettaggi(); i++)
            {
                if (tutte[i].Nome.Equals(impostazione.Nome))
                {
                    tutte[i].Selezionato = impostazione.Selezionato;
                    LogIt(EntryType.Info, $"{impostazione.Nome}: l'impostazione è stata modificata in {impostazione.Selezionato}");
                    return true;
                }
            }
            LogIt(EntryType.Errore, $"Impossibile modificare l'impostazione {impostazione.Nome}");
            return false;
        }

        public void LogIt(EntryType type, string messaggio)
        {
            _logger.WriteLog(type, this.GetType().Name, messaggio);
        }

        public Impostazioni OttieniImpostazioni()
        {
            return _utente.Impostazioni;
        }

        public void SalvaNuoveCredenziali(Credenziali vecchie, Credenziali nuove)
        {
            if(!_utente.Credenziali.Confronta(vecchie))
            {
                LogIt(EntryType.Avvertimento, "Tentativo di cambio credenziali fallito");
                return;
            }
            else if(_utente.Credenziali.Confronta(vecchie))
            {
                _utente.Credenziali = nuove;
                LogIt(EntryType.Operazione, "L'utente ha cambiato le credenziali");
            }
        }
    }
}