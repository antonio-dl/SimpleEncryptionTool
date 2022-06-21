using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIBO.Entities.Interfaces
{
    public interface IController
    {
        public void LogIt(EntryType type, Entry entry);

    }

    public interface IGestioneImpostazioni : IController
    {
        public bool CambiaImpostazione(Impostazione impostazione);

       
    }
}
