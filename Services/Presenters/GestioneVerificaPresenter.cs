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
            Entry Nuova;
            string fonte = "GestioneVerificaPresenter";
            Nuova = new Entry(type, fonte, messaggio);
            /* Per il metodo AddEntry non so come reperire un istanza FileLog esistente su cui eseguirla */
        }
        
        public CodiceVerifica GeneraCodice(File file)
        {
            CodiceVerifica result = file.CodiceVerifica;
            return result;
        }

        public bool VerificaFile(CodiceVerifica cv, File file)
        {
            CodiceVerifica cvFile = file.CodiceVerifica;

            if(cvFile.Equals(cv))
            {
                EntryType tipo = EntryType.Info;
                string msg = "L'operazione di verifica ha avuto successo, il codice verifica combacia con quello del file";
                LogIt(tipo, msg);
            }
            else
            {
                EntryType tipo = EntryType.Avvertimento;
                string msg = "L'operazione di verifica ha avuto esito negativo, il codice verifica non è lo stesso di quello del file";
                LogIt(tipo, msg);
            }

            return cvFile.Equals(cv);
        }
    }
}