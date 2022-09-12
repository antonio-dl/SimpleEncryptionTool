using UNIBO.SET.Model;

namespace UNIBO.SET.Services.Shared
{
    internal class SystemHelper
    {
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