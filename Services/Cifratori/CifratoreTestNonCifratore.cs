using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNIBO.SET.Model;
using System.Security.Cryptography;

namespace Services.Cifratori
{
    public class CifratoreTestNonCifratore : UNIBO.SET.Services.Presenters.ICifratore // Inserire qui la logica di cifrazione dei file
    {
        public FileCifrato CifraFile(UNIBO.SET.Model.File fileIn)
        {

            FileCifrato fc = new FileCifrato(fileIn.Path + ".sef", null);

            using var streamOut = fc.Create();
            using var streamIn = fileIn.Open();

            streamIn.CopyToAsync(streamOut).Start();

            return fc;



        }
    }
}
