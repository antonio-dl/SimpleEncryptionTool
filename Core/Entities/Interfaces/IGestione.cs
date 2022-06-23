using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using UNIBO.SET.Model;

namespace UNIBO.SET.Interfaces
{
    public interface IController
    {
        public void LogIt(EntryType type, Entry entry);

    }

    public interface IGestioneImpostazioni : IController
    {
        public bool CambiaImpostazione(Impostazione impostazione);
        public Impostazioni OttieniImpostazioni();
    }

    public interface IGestioneCredenziali : IController
    {
        public void SalvaNuoveCredenziali(Credenziali credenziali);
    }

    public interface IGestioneLogin : IController
    {
        public bool LogIn(Credenziali credenziali);
    }

    public interface IGestioneVerifica : IController
    {
        public void VerificaFile(CodiceVerifica codVerifica, File file);
        public void GeneraCodice(File file);
    }

    public interface IUSBSelectorController : IController
    {
        public bool SelezionaUSB(USB usb);
        public USB[] ElencaDispositiviEsterni();
    }

    public interface IGestioneCifratura : IUSBSelectorController
    {
        public bool SelezionaUSB();
        public bool SelezionaDestinazione();
        public void Cifra();
        public string GeneraPassword();
        public bool Aggiungi(SystemElement syselement);
        public bool Rimuovi(SystemElement syselement);

    }

    public interface IGestioneDecifratura : IUSBSelectorController
    {
        public bool SelezionaUSB();
        public void ScansionaUSB();
        public void SelezionaKey();
        public void Decifra();
    }
}
