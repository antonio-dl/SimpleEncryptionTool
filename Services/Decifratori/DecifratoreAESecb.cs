using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            using var aes = Aes.Create();
            aes.Mode = CipherMode.ECB;      // Modalita CBC (dal nome classe)

            var fc = new FileCifrato(key.TargetFilePath);
            var fd = new FileDecifrato(key.SourceFilePath);

            if (fc.Exists)
            {
                throw new FileNotFoundException($"File {fc.Path} non esistente!");
            }

            if (fd.Exists)
            {
                fd = GeneraNuovoNomeFileDecifrato(fd);
            }


            using var sourceStream = fc.Open();
            using var targetStream = fd.Create();

            using var decryptor = aes.CreateDecryptor(
                key.Password, null);
            using var decryptoStream = new CryptoStream(sourceStream, decryptor, CryptoStreamMode.Read);

            decryptoStream.CopyTo(targetStream);

            return fd;
        }

        private FileDecifrato GeneraNuovoNomeFileDecifrato(FileDecifrato fd)
        {
            throw new NotImplementedException();
        }
    }
}
