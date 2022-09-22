using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using UNIBO.SET.Model;
using File = UNIBO.SET.Model.File;

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
                fd = GeneraNuovoNomeFileDecifrato(fd);
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
                throw new IVReadException($"Impossibile leggere vettore iniziale IV dal file {fc.Path}", e);
            }
            using var decryptor = aes.CreateDecryptor(key.Password, IV);
            using var decryptoStream = new CryptoStream(sourceStream, decryptor, CryptoStreamMode.Read);

            decryptoStream.CopyTo(targetStream);
            
            return fd;
        }

        private FileDecifrato GeneraNuovoNomeFileDecifrato(FileDecifrato fd)
        {
            string nome = fd.Name;
            int pos = nome.LastIndexOf(".");
            string nomeCut = nome.Substring(0, pos); // prova.txt --> . in posizione 5 ma nomeCut arriva fino a 4
            string formato = nome.Substring(pos); // prova.txt --> . in posizione 5, quindi inizia dalla posizione 5 fino alla fine
            // prendendo ad esempio un file di nome prova.txt --> nomeCut = prova <-> formato = .txt --> mandare le due variabili in output lo conferma

            char last = nomeCut[pos - 1];
            if (last < '0' || last > '9')
            {
                nomeCut += "1";
            }
            else
            {
                string numeri = "" + last;
                int i = pos - 2;
                do
                {
                    last = nomeCut[i];
                    i--;
                    if (last >= '0' && last <= '9')
                    {
                        numeri = last + numeri;
                    }
                }
                while (last >= '0' && last <= '9');
                nomeCut = nomeCut.Substring(0, nomeCut.LastIndexOf(numeri));
                int lastNum = int.Parse(numeri);
                lastNum++;
                nomeCut += lastNum;
            }

            nomeCut += formato;
            string newPath = fd.Path;
            newPath = newPath.Substring(0, newPath.LastIndexOf(nome));
            newPath += nomeCut;
            return new FileDecifrato(newPath);
        }
    }
}

