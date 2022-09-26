using UNIBO.SET.Interfaces;
using UNIBO.SET.Model;
using UNIBO.SET.ModelLog;
using File = UNIBO.SET.Model.File;

namespace UNIBO.SET.Services.Presenters
{
    public class GestioneVerificaPresenter : IGestioneVerifica
    {
        private ILogger _logger;

        public GestioneVerificaPresenter(ILogger logger)
        {
            _logger = logger;
        }

        public void LogIt(EntryType type, string messaggio)
        {
            _logger.WriteLog(type, this.GetType().Name, messaggio);
        }

        public CodiceVerifica GeneraCodice(File file)
        {
            CodiceVerifica result = file.CodiceVerifica;
            return result;
        }

        public bool VerificaFile(CodiceVerifica cv, File file)
        {
            try
            {
                CodiceVerifica cvFile = file.CodiceVerifica;

                if (!cvFile.Equals(cv))
                {
                    LogIt(EntryType.Avvertimento, $"Verifica del file {file.Path} fallita");
                    return false;
                }
                return true;
            }
            catch (IOException e)
            {
                LogIt(EntryType.Errore, $"Errore nella verifica del file {file.Path}");
                throw new IOException($"Errore nella verifica del file {file.Path}", e);
            }
        }
    }
}