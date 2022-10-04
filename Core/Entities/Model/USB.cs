namespace UNIBO.SET.Model
{
    public class USB
    {
        private readonly DriveInfo _driveInfo;

        public string Name { get => _driveInfo.Name; }

        public string GetPathToKeyChain()
        {
            return Path.Combine(_driveInfo.Name, ".set", Utente.GetInstance().Nome + ".skc");
        }

        public bool HasKeyChain() // Dovrebbe funzionare a dovere
        {
            return System.IO.File.Exists(GetPathToKeyChain());
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