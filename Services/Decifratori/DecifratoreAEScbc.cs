using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNIBO.SET.Model;

namespace Services.Decifratori
{
    internal class DecifratoreAEScbc : IDecifratore
    {
        public string Algoritmo => throw new NotImplementedException();

        public FileDecifrato Decifra(Key key)
        {
            throw new NotImplementedException();
        }
    }
}
