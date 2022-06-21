using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Model
{
    public class Key 
    {
        private string _nomeOriginale;
        private string _pathOriginale;

        private byte[] _password;


    }

    public class KeyChain : ISerializable
    {
        private Key[] _keychain;


    }
}
