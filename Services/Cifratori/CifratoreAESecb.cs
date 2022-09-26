using System.Security.Cryptography;
using UNIBO.SET.Model;

namespace UNIBO.SET.Services.Cifratori
{
    public class CifratoreAESecb : ICifratore // Logica di cifrazione dei file
                                              //TODO: Lancio eccezioni, niente logging qui
    {
        public string Algoritmo => "AES-ECB";

        public Key CifraFile(UNIBO.SET.Model.File fileIn) // NOTE: Size delle key in byte devono essere o di 128 o 192 o 256 byte!!
        {
            using var aes = Aes.Create();
            aes.Mode = CipherMode.ECB;// Modalita ECB (dal nome classe)
            string pathFileCifrato = fileIn.Path + ".sef";

            Key key = new Key(fileIn.Path, fileIn.CodiceVerifica, pathFileCifrato, aes.Key, aes.Mode.ToString());
            FileCifrato fcout = new FileCifrato(pathFileCifrato, key);
            using var sourceStream = fileIn.Open();
            using var targetStream = fcout.Create();

            using var encryptor = aes.CreateEncryptor();
            using var cryptoStream = new CryptoStream(targetStream, encryptor, CryptoStreamMode.Write);

            sourceStream.CopyTo(cryptoStream);

            return key;
        }
    }
}