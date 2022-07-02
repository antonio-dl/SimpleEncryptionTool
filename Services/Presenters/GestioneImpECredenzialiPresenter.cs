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

        }

        public void LogIt(EntryType type, string messaggio)
        {
            throw new NotImplementedException();
        }

        public Impostazioni OttieniImpostazioni()
        {

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