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
        private string _sourceFilePath;
        private string _targetFilePath;

        private byte[] _password;
        private string _algoritmo;

        public Key(string sourceFilePath, string targetFilePath, byte[]? password, string algoritmo)
        {
            _sourceFilePath = sourceFilePath ?? throw new ArgumentNullException(nameof(sourceFilePath));
            _targetFilePath = targetFilePath ?? throw new ArgumentNullException(nameof(targetFilePath));
            _password = password ?? throw new ArgumentNullException(nameof(password));
            _algoritmo = algoritmo ?? throw new ArgumentNullException(nameof(algoritmo));
        }

        }



    

    public abstract class KeyChain
    {
        private Key[] _keychain;


    }

    public class FileKeyChain : KeyChain { }
}
