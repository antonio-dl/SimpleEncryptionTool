using System;
using UNIBO.SET.Interfaces;
using UNIBO.SET.Model;
using UNIBO.SET.ModelLog;

namespace UNIBO.SET.Services.Presenters
{
    public class GestioneImpECrededenzialiPresenter : IGestioneCredenziali, IGestioneImpostazioni
    {
        public void CambiaImpostazione(Impostazione impost)
        {
            Impostazioni opt = this.OttieniImpostazioni();
            Impostazione[] tutte = opt.OttieniSettaggi();
            
            for(int i=0; i < opt.NumSettaggi(); i++)
            {
                if (tutte[i].Nome.Equals(impost.Nome))
                    tutte[i].Selezionato = impost.Selezionato;
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

        }

        bool IGestioneImpostazioni.CambiaImpostazione(Impostazione impostazione)
        {
            throw new NotImplementedException();
        }
    }
}