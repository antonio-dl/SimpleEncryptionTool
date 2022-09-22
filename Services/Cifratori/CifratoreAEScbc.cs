using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNIBO.SET.Model;
using System.Security.Cryptography;

namespace UNIBO.SET.Services.Cifratori
{
    public class CifratoreAEScbc : ICifratore // Logica di cifrazione dei file
        //TODO: rilanciare eccezioni per errori gravi, niente logging qui ma al chiamante 
    {
        public string Algoritmo => "AES-CBC";

        public Key CifraFile(UNIBO.SET.Model.File fileIn) // N.B.: Size delle key in byte devono essere o di 128 o 192 o 256 byte!!
        {

            using var aes = Aes.Create();
            aes.Mode = CipherMode.CBC;      // Modalita CBC (dal nome classe)
            string pathFileCifrato = fileIn.Path + ".sef";
            
            Key key = new Key(fileIn.Path, fileIn.CodiceVerifica, pathFileCifrato, aes.Key, aes.Mode.ToString());
            FileCifrato fcout = new FileCifrato(pathFileCifrato, key);
            using var sourceStream = fileIn.Open();
            using var targetStream = fcout.Create();



            using var encryptor = aes.CreateEncryptor();
            using var cryptoStream = new CryptoStream(targetStream, encryptor, CryptoStreamMode.Write);

            targetStream.Write(aes.IV, 0, aes.IV.Length);
            sourceStream.CopyTo(cryptoStream);

            return key;
        }

    }
}
