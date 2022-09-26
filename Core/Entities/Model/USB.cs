﻿namespace UNIBO.SET.Model
{
    public class USB
    {
        private DriveInfo _driveInfo;
        private FileKeyChain? _keyChain;

        public FileKeyChain KeyChain
        {
            get
            {
                if (_keyChain == null) // Dovrebbe funzionare a dovere ma è il costruttore FileKeyChain che va corretto
                {
                    string pathToKeyChain = Path.Combine(_driveInfo.Name, ".set", Utente.GetInstance().Nome + ".skc");
                    _keyChain = new FileKeyChain(pathToKeyChain);
                }
                return _keyChain;
            }
        }

        public string Name { get => _driveInfo.Name; }

        public bool HasKeyChain() // Dovrebbe funzionare a dovere
        {
            string pathToKeyChain = Path.Combine(_driveInfo.Name, ".set", Utente.GetInstance().Nome + ".skc");
            return System.IO.File.Exists(pathToKeyChain);
        }

        public USB(string s)
        {
            _driveInfo = new DriveInfo(s);
            // _keyChain = this.KeyChain;
        }

        public static USB[] GetUsbs()
        {
            var usblist = new List<USB>(1);
            var driveList = DriveInfo.GetDrives();

            foreach (DriveInfo drive in driveList)
            {
                if (drive.DriveType == DriveType.Removable)
                {
                    usblist.Add(new USB(drive.Name));
                }
            }
            return usblist.ToArray();
        }
    }
}