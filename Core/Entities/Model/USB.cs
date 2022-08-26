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

        public FileKeyChain KeyChain
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public string Name { get => _driveInfo.Name; }


        public bool HasKeyChain()
        {
            // _driveInfo.RootDirectory.GetDirectories().
            throw new NotImplementedException();
        }


    }
}
