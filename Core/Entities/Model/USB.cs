using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIBO.SET.Model
{
    public class USB
    {
        private DriveInfo _driveInfo;
        private FileKeyChain? _keyChain;
        public FileKeyChain KeyChain
        {
            get
            {
                if (_keyChain == null) // da testare :D
                {
                    string pathToKeyChain = Path.Combine(_driveInfo.Name, "FK.set", Utente.GetInstance().Nome, "fk.skc");
                    _keyChain = new FileKeyChain(pathToKeyChain);
                }
                return _keyChain;
            }
        }
        public string Name { get => _driveInfo.Name; }


        public bool HasKeyChain() // DA TESTARE
        {
            string pathToKeyChain = Path.Combine(_driveInfo.Name, "FK.set", Utente.GetInstance().Nome, "fk.skc");
            return System.IO.File.Exists(pathToKeyChain);
        }

        public USB(string s)
        {
            _driveInfo = new DriveInfo(s);
            // _keyChain = this.KeyChain;
        }

    }
}
