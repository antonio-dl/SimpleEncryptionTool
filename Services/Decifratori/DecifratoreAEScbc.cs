using System.Security.Cryptography;
using UNIBO.SET.Model;
using UNIBO.SET.Services.Shared;

namespace UNIBO.SET.Services.Decifratori
{
    public class DecifratoreAEScbc : IDecifratore
    {
        public string Algoritmo => "AES-CBC";

        public FileDecifrato Decifra(Key key)
        {
            using var aes = Aes.Create();
            aes.Mode = CipherMode.CBC;      // Modalita CBC (dal nome classe)

            var fc = new FileCifrato(key.TargetFilePath);
            var fd = new FileDecifrato(key.SourceFilePath);

            if (!fc.Exists)
            {
                throw new FileNotFoundException($"File {fc.Path} non esistente!");
            }

            if (fd.Exists)
            {
                fd = Helper.GeneraNuovoNomeFileDecifrato(fd);
            }

            using var sourceStream = fc.Open();
            using var targetStream = fd.Create();
            var IV = new Byte[aes.IV.Length];
            try
            {
                sourceStream.Read(IV, 0, aes.IV.Length);
            }
            catch (IOException e)
            {
                fd.Delete();
                throw new IVReadException($"Impossibile leggere vettore iniziale IV dal file {fc.Path}", e);
            }
            using var decryptor = aes.CreateDecryptor(key.Password, IV);
            using var decryptoStream = new CryptoStream(sourceStream, decryptor, CryptoStreamMode.Read);
            try
            {
                decryptoStream.CopyTo(targetStream);
            }
            catch (CryptographicException e){
                targetStream.Flush();
                targetStream.Close();
                fd.Delete();
                throw new CryptographicException("Errore nella decifrazione del file", e);
            }
            return fd;
        }

    }
}