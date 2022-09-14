using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Presenters
{
    public class Inizializzatore // Classe che si occupa di effettuare tutte le iniezioni di dipendenza
    {
        public Inizializzatore()
        {
            CreaUtenteSingleton();
            CaricaComponenti();


        }

        private void CaricaComponenti()
        {
            throw new NotImplementedException();
        }

        private void CreaUtenteSingleton()
        {
            throw new NotImplementedException();
        }
    }
}
