using UNIBO.SET.Interfaces;
using UNIBO.SET.Model;
using UNIBO.SET.ModelLog;
using File = UNIBO.SET.Model.File;

namespace UNIBO.SET.Services.Presenters
{
	public class GestioneVerificaPresenter : IGestioneVerifica
    {
         public void LogIt(EntryType type, string messaggio)
        {
            throw new NotImplementedException();
        }
        
        public CodiceVerifica GeneraCodice(File file)
        {
            CodiceVerifica result = file.CodiceVerifica;
            return result;
        }

        public bool VerificaFile(CodiceVerifica cv, File file)
        {
            CodiceVerifica cvFile = file.CodiceVerifica;

            return cvFile.Codice.Equals(cv.Codice);
        }
    }
}