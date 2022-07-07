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
                    return true;
                }
            }
            return false;
            // Va loggato il caso in cui l'impostazione passata come parametro non esista o sia sbagliata?
            // perché non so che altro possa dare un errore imprevisto
        }

        public void LogIt(EntryType type, string messaggio)
        {
            _logger.WriteLog(type, this.GetType().Name, messaggio);
        }

        public Impostazioni OttieniImpostazioni()
        {
            return _utente.Impostazioni;
        }

        public void SalvaNuoveCredenziali(Credenziali cred)
        {
            _utente.Credenziali = cred;
        }
    }
}