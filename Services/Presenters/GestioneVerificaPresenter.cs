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
            // Per fare questo, probabilmente va usato il costruttore Entry della classe Log
            // dove, in base al risultato del metodo (qui VerificaFile), gli passa un messaggio, un tipo e la fonte
        }
        
        public CodiceVerifica GeneraCodice(File file)
        {
            CodiceVerifica result = file.CodiceVerifica;
            return result;
        }

        public bool VerificaFile(CodiceVerifica cv, File file)
        {
            CodiceVerifica cvFile = file.CodiceVerifica;

            return cvFile.Equals(cv);
        }
    }
}