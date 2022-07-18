using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UNIBO.SET.Model
{
    public class Key
    {
        public string Algoritmo { get; }
        public string TargetFile { get; }
        public string SourceFilePath { get; }
        public byte[] Password { get; }

        public DateTime UltimaModifica { get; } // FIXME: Da aggiustare il costruttore, forse meglio utilizzare un altra calsse per contenere le cryptInfo






        public Key(string sourceFilePath, string targetFilePath, byte[]? password, string algoritmo)
        {
            SourceFilePath = sourceFilePath ?? throw new ArgumentNullException(nameof(sourceFilePath));
            TargetFile = targetFilePath ?? throw new ArgumentNullException(nameof(targetFilePath));
            Password = password ?? throw new ArgumentNullException(nameof(password));
            Algoritmo = algoritmo ?? throw new ArgumentNullException(nameof(algoritmo));
        }

    }





    public abstract class KeyChain
    {
        private Key[] _keychain;


    }

    public class FileKeyChain : KeyChain { }
}
