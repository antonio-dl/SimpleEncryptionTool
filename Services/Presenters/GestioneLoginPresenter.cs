using System.Runtime.Serialization.Formatters.Binary;
using UNIBO.SET.Interfaces;
using UNIBO.SET.Model;
using UNIBO.SET.ModelLog;

namespace UNIBO.SET.Services.Presenters
{
    public class GestioneLoginPresenter : IGestioneLogin
    {
        private Utente _utente;
        private ILogger _logger;

        public GestioneLoginPresenter(ILogger logger)
        {
            _utente = Utente.GetInstance();
            _logger = logger;

            _utente.Credenziali = LoadCredenziali();
        }

        public bool LogIn(Credenziali credenziali)
        {
            Thread.Sleep(1200); // Per evitare brute force
            if (!_utente.Credenziali.Confronta(credenziali))
            {
                LogIt(EntryType.Avvertimento, "Tentativo di Login fallito, credenziali errate");
                return false;
            }
            else
            {
                LogIt(EntryType.Info, "Login effettuato");
                return true;
            }
        }

        private Credenziali LoadCredenziali() // TODO: Test della serializzazione e deserializzazione
        {
            Credenziali c;
            BinaryFormatter bf = new BinaryFormatter();
            FileInfo f = new FileInfo(SETEnvironment.Credential_Path);
            Stream stream = f.OpenRead();
            c = (Credenziali)bf.Deserialize(stream);
            stream.Close();

            return c;
        }

        public void LogIt(EntryType type, string messaggio)
        {
            _logger.WriteLog(type, this.GetType().Name, messaggio);
        }
    }
}