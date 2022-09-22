using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNIBO.SET.Model;

namespace UNIBO.SET.Services.Decifratori
{
    internal class DecifratoreTestNonDecifratore : IDecifratore
    {
        public string Algoritmo => "NessunAlgoritmo";

        public FileDecifrato Decifra(Key key)
        {
            return null;
        }
    }
}
