using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNIBO.SET.Model;
using System.Security.Cryptography;

namespace Services.Cifratori
{
    public class CifratoreAEScbc : UNIBO.SET.Services.Presenters.ICifratore // Inserire qui la logica di cifrazione dei file
    {
        public FileCifrato CifraFile(UNIBO.SET.Model.File fileIn)
        {
            Key key = _kgen.generateKey();

            FileCifrato fcout = new FileCifrato(fileIn.Path + ".sef", key);
            using (var sourceStream = fileIn.FileStream)
            using (var targetStream = fcout.FileStream)
                using(var provider = new Aes)
        }
    }
}
