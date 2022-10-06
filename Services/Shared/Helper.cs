using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using UNIBO.SET.Model;

namespace UNIBO.SET.Services.Shared
{
    internal static class Helper
    {
        internal static FileKeyChain RecuperaFileKeyChain(string pathToKeyChain)
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
                throw new FileNotFoundException($"FileKeyChain non trovata nel path {pathToKeyChain}");
            }
        }
    }
}
