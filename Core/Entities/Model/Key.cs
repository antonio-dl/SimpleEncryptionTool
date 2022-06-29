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
        private string _nomeOriginale;
        private string _pathOriginale;

        private byte[] _password;


    }

    public abstract class KeyChain
    {
        private Key[] _keychain;


    }

    public class FileKeyChain : KeyChain { }
}
