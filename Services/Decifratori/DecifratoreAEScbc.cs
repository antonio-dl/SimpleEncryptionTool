using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNIBO.SET.Model;

namespace UNIBO.SET.Services.Decifratori
{
    public class DecifratoreAEScbc : IDecifratore
    {
        public string Algoritmo => "AES-CBC";

        public FileDecifrato Decifra(Key key)
        {
            throw new NotImplementedException();
        }
    }
}
