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
            Key key = new Key(); // TODO: da modificare

            FileCifrato fcout = new FileCifrato(fileIn.Path + ".sef", key);
            using var sourceStream = fileIn.FileStream;
            using var targetStream = fcout.FileStream;
            using var aes = Aes.Create();
            aes.Mode = CipherMode.CBC;// Modalita CBC (dal nome classe)
            
            aes.Key = System.Convert.FromBase64String("banana");

            using var encryptor = aes.CreateEncryptor();
            using var cryptoStream = new CryptoStream(targetStream, encryptor, CryptoStreamMode.Write);

            targetStream.Write(aes.IV, 0, aes.Key.Length);
            sourceStream.CopyTo(cryptoStream); //async start

            return fcout;



        }
    }
}
