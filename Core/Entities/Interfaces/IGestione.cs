using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using UNIBO.SET.Model;
using UNIBO.SET.ModelLog;
using File = UNIBO.SET.Model.File;

namespace UNIBO.SET.Interfaces
{
    public interface IController
    {
        public void LogIt(EntryType type, string messaggio);

    }

    public interface IGestioneImpostazioni : IController
    {
        public bool CambiaImpostazione(Impostazione impostazione);
        public Impostazioni OttieniImpostazioni();
    }

    public interface IGestioneCredenziali : IController
    {
        public void SalvaNuoveCredenziali(Credenziali vecchie, Credenziali nuove);
    }

    public interface IGestioneLogin : IController
    {
        public bool LogIn(Credenziali credenziali);
    }

    public interface IGestioneVerifica : IController
    {
        public bool VerificaFile(CodiceVerifica codVerifica, File file);
        public CodiceVerifica GeneraCodice(File file);
    }

    public interface IUSBSelectorController : IController
    {
        public void SelezionaUSB(USB usb);
        public USB[] ElencaDispositiviEsterni();
    }

    public interface IGestioneCifratura : IUSBSelectorController
    {
        public bool SelezionaDestinazione(string path);
        public FileCifrato Cifra(File file);
        public bool Aggiungi(FileSystemElement sysElement);
        public bool Rimuovi(FileSystemElement sysElement);

    }

    public interface IGestioneDecifratura : IUSBSelectorController
    {
        public KeyChain ScansionaUSB();
        public void SelezionaKeyChain(KeyChain chain);
        public FileDecifrato Decifra(Key key);

        public ISet<File> FileDecifrabili(KeyChain chain);


    }

    public interface ILogger
    {
        public void WriteLog(EntryType type, string fonte, string messaggio);
    }
    public interface IGestioneLog : ILogger
    {

        //public void GetEntry(DateTime time1, DateTime time2);
        //public void GetEntry(Date date);
        //public void GetAnomalie(Date dateAnom);
        //public void AnalisiAnomalieOperazioni(Date dateOp);
        //public void AnalisiAnomalieMessaggi(Date dateMes);
        //public void PrintLogOperazione(Entry[] operazioni);
        //public void PrintLogMessaggio(Entry[] messaggi);
    }
}
