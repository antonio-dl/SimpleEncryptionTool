using UNIBO.SET.Interfaces;
using UNIBO.SET.Model;
using File = UNIBO.SET.Model.File;

namespace UNIBO.SET.Services.Presenters
{
	public class GestioneVerificaPresenter : IGestioneVerifica
    {
        public CodiceVerifica GeneraCodice(File file)
        {
            CodiceVerifica result = file.CodiceVerifica;
            return result;
        }

        public bool VerificaFile(CodiceVerifica cv, File file)
        {
            CodiceVerifica cvFile = file.CodiceVerifica;

            if (cvFile.Equals(cv))
                return true;
            else
                return false;
        }
    }
}