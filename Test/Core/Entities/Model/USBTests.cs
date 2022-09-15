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
            Utente u1 = Utente.GetInstance();

            const string nomeUsb = @"F:\";
            usb = new USB(nomeUsb);
            
            Assert.IsFalse(usb.HasKeyChain());
            
            keyChain = usb.KeyChain;
            Console.WriteLine(keyChain);
            
            Assert.IsTrue(usb.HasKeyChain());
            Assert.IsNotNull(keyChain.ToString());

        }
    }
}