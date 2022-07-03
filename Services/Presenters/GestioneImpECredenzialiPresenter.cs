using System;
using UNIBO.SET.Interfaces;
using UNIBO.SET.Model;
using UNIBO.SET.ModelLog;

namespace UNIBO.SET.Services.Presenters
{
    public class GestioneImpECrededenzialiPresenter : IGestioneCredenziali, IGestioneImpostazioni
    {
        public void CambiaImpostazione(Impostazione impostazione)
        {
            Impostazioni opt = this.OttieniImpostazioni();
            Impostazione[] tutte = opt.OttieniSettaggi();
            
            for(int i=0; i < opt.NumSettaggi(); i++)
            {
                if (tutte[i].Nome.Equals(impostazione.Nome))
                    tutte[i].Selezionato = impostazione.Selezionato;
            }
        }

        public void LogIt(EntryType type, string messaggio)
        {
            throw new NotImplementedException();
        }

        public Impostazioni OttieniImpostazioni()
        {
            Impostazioni result;
            Impostazione[] tutte;

            //return result;
            throw new NotImplementedException();

        }

        public void SalvaNuoveCredenziali(Credenziali cred)
        {
            /*
            Utente questo;
            questo.CambiaCredenziali(cred);
            */
            /*
            CredenzialiPassword Password = new CredenzialiPassword(cred.Passwd);
            */
        }

        bool IGestioneImpostazioni.CambiaImpostazione(Impostazione impostazione)
        {
            throw new NotImplementedException();
            /*
            Questo metodo è stato implementato già sopra ma con il tipo void e non bool ma nell'interfaccia IGestioneImpostazioni
            ma nei diagrammi risulta sempre void, quale preferisci mantenere?
            */
        }
    }
}