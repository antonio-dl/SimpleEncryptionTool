using System;
using System.Collections;
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
        public string TargetFilePath { get; }
        public string SourceFilePath { get; }
        public byte[] Password { get; }

        public DateTime UltimaModifica { get; } // FIXME: Da aggiustare il costruttore, forse meglio utilizzare un'altra classe per contenere le cryptInfo

        // ricordarsi che va inserito anche il CodiceVerifica

        public Key(string sourceFilePath, string targetFilePath, byte[]? password, string algoritmo)
        {
            SourceFilePath = sourceFilePath ?? throw new ArgumentNullException(nameof(sourceFilePath));
            TargetFilePath = targetFilePath ?? throw new ArgumentNullException(nameof(targetFilePath));
            Password = password ?? throw new ArgumentNullException(nameof(password));
            Algoritmo = algoritmo ?? throw new ArgumentNullException(nameof(algoritmo));
        }

    }

    public abstract class KeyChain : IEnumerable<Key>
    {
        protected Key[] _keychain;

        public IEnumerator<Key> GetEnumerator()
        {
            return ((IEnumerable<Key>)_keychain).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _keychain.GetEnumerator();
        }
    }

    public class FileKeyChain : KeyChain {

        private FileInfo _file;
        public string Name { get => _file.Name; }
        public string Path { get => _file.FullName; }

        public FileKeyChain(string pathFile)
        {
            _file = new FileInfo(pathFile);
        }
        
    }
}
