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


        private byte[] _password;
        private string _algoritmo;



    }

    public abstract class KeyChain
    {
        private Key[] _keychain;


    }

    public class FileKeyChain : KeyChain { }
}
