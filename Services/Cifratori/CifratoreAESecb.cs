using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNIBO.SET.Model;
using System.Security.Cryptography;

namespace Services.Cifratori
{
    public class CifratoreAESecb : UNIBO.SET.Services.Presenters.ICifratore // Logica di cifrazione dei file
        //TODO: Lancio eccezioni, niente logging qui
    {
        public FileCifrato CifraFile(UNIBO.SET.Model.File fileIn) // NOTE: Size delle key in byte devono essere o di 128 o 192 o 256 byte!!
        {

            using var aes = Aes.Create();
            aes.Mode = CipherMode.ECB;// Modalita CBC (dal nome classe)
            string pathFileCifrato = fileIn.Path + ".sef";
            
            Key key = new Key(fileIn.Path, pathFileCifrato, aes.Key, aes.Mode.ToString());
            FileCifrato fcout = new FileCifrato(pathFileCifrato, key);
            using var sourceStream = fileIn.Open();
            using var targetStream = fcout.Create();



            using var encryptor = aes.CreateEncryptor();
            using var cryptoStream = new CryptoStream(targetStream, encryptor, CryptoStreamMode.Write);

            targetStream.Write(aes.IV, 0, aes.IV.Length);
            sourceStream.CopyTo(cryptoStream);

            return fcout;
        }
    }
}
