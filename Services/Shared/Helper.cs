using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using UNIBO.SET.Model;

namespace UNIBO.SET.Services.Shared
{
    public static class Helper
    {
        public static FileKeyChain RecuperaFileKeyChain(string pathToKeyChain)
        {
            if (System.IO.File.Exists(pathToKeyChain))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileInfo f = new FileInfo(pathToKeyChain);
                using Stream stream = f.OpenRead();
                return (FileKeyChain)bf.Deserialize(stream);
            }
            else
            {
                return new FileKeyChain(pathToKeyChain);
            }
        }

        public static FileDecifrato GeneraNuovoNomeFileDecifrato(FileDecifrato fd)
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

        public static string elencaFileFalliti(string[] lista)
        {
            StringBuilder sb = new StringBuilder();
            if (lista.Length <= 20)
            {
                foreach (string s in lista)
                {
                    sb.AppendLine(s);
                }
            }
            else
            {
                for (int i = 0; i < 20; i++)
                {
                    sb.AppendLine(lista[i]);
                }
                sb.AppendLine($"E altri {lista.Length - 20}");
            }
            return sb.ToString();
        }

        /*
        internal static FileDecifrato GeneraNuovoNomeFileDecifrato(FileDecifrato fd)
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
        */

        public static void SalvaFileKeyChain(FileKeyChain fkc)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(fkc.PathFileKeyChain));

            BinaryFormatter bf = new BinaryFormatter();
            FileInfo f = new FileInfo(fkc.PathFileKeyChain);
            using Stream stream = f.OpenWrite();
            bf.Serialize(stream, fkc);
        }
    }
}
