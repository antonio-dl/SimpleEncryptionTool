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
        public bool CambiaImpostazione(string selezionato, Impostazione impostazione);

        public Impostazioni OttieniImpostazioni();
    }

    public interface IGestioneCredenziali : IController
    {
        public bool SalvaNuoveCredenziali(Credenziali vecchie, Credenziali nuove);
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
        public Key Cifra(File file);

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
        public Log[] GetAllLogs();

        public string ReadLog(Log selectedLog);

        public string ReadLog(Log selectedLog, EntryType filteredType);
    }
}