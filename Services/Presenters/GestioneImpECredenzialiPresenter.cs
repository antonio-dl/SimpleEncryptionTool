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
            Impostazioni tutti;
            Impostazione[] imp = new Impostazione[20];
            for (int i = 0; i < imp.Length; i++)
            {
                imp[i]. = 
            }
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