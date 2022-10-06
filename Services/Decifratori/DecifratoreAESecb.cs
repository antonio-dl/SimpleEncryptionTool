using System.Security.Cryptography;
using UNIBO.SET.Model;

namespace UNIBO.SET.Services.Decifratori
{
    public class DecifratoreAESecb : IDecifratore
    {
        public string Algoritmo => "AES-EBC";

        public FileDecifrato Decifra(Key key)
        {
            using var aes = Aes.Create();
            aes.Mode = CipherMode.ECB;      // Modalita ECB (dal nome classe)

            var fc = new FileCifrato(key.TargetFilePath);
            var fd = new FileDecifrato(key.SourceFilePath);

            if (!fc.Exists)
            {
                throw new FileNotFoundException($"File {fc.Path} non esistente!");
            }

            if (fd.Exists)
            {
                fd = MyGeneraNuovoNomeFileDecifrato(fd);
            }

            using var sourceStream = fc.Open();
            using var targetStream = fd.Create();

            using var decryptor = aes.CreateDecryptor(key.Password, null);
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

        private FileDecifrato MyGeneraNuovoNomeFileDecifrato(FileDecifrato fd)
        {
            int n = 1;
            string nome = fd.Name;
            int pos = nome.LastIndexOf(".");
            string nomeCut = nome.Substring(0, pos); // prova.txt --> . in posizione 5 ma nomeCut arriva fino a 4
            string formato = nome.Substring(pos); // prova.txt --> . in posizione 5, quindi inizia dalla posizione 5 fino alla fine
            // prendendo ad esempio un file di nome prova.txt --> nomeCut = prova <-> formato = .txt --> mandare le due variabili in output lo conferma

            FileDecifrato result;
            do
            {
                string newNome = nomeCut + "(" + n + ")";
                n++;
                newNome += formato;
                string newPath = fd.Path;
                newPath = newPath.Substring(0, newPath.LastIndexOf(nome));
                newPath += newNome;
                result = new FileDecifrato(newPath);
            }
            while (result.Exists);
            return result;
        }

    }
}