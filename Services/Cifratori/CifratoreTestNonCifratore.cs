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
            Key key = new Key();

            FileCifrato fc = new FileCifrato(fileIn.Path + ".sef", key);

            
            
            fileIn.FileStream.CopyTo(fc.FileStream);

            fc.FileStream.Close();
            fileIn.FileStream.Close();



            return fc;



        }
    }
}
