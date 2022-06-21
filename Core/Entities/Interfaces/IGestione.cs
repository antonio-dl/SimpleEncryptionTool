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
}