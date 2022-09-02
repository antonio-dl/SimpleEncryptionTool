using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNIBO.SET.Model;

namespace UNIBO.SET.Services.Decifratori
{
    internal class DecifratoreAESebc : IDecifratore

    {
        public string Algoritmo => "AES-EBC";

        public FileDecifrato Decifra(Key key)
        {
            throw new NotImplementedException();
        }
    }
}
