using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIBO.SET.Model.Tests
{
    [TestClass()]
    public class USBTests
    {
        [TestMethod()]
        public void HasKeyChainTest()
        {
            USB usb;
            FileKeyChain? keyChain;

            const string nomeUsb = @"C:\";
            usb = new USB(nomeUsb);
            
            Assert.IsFalse(usb.HasKeyChain());
            
            keyChain = usb.KeyChain;

            Assert.IsTrue(usb.HasKeyChain());

        }
    }
}