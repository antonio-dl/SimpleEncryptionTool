﻿using System;
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

            keyChain = usb.KeyChain;
            Console.WriteLine(keyChain.Name);
            Console.WriteLine(keyChain.Path);

            Assert.IsTrue(usb.HasKeyChain());
            Assert.IsNotNull(keyChain.ToString());

            USB usb2;
            const string nomeUsb2 = @"G:\";
            usb2 = new USB(nomeUsb2);

            Assert.IsFalse(usb2.HasKeyChain());
        }

        [TestMethod()]
        public void GetUsbsTest()
        {
            Utente u1 = Utente.GetInstance();
            USB[] tutte = USB.GetUsbs();

            Assert.IsNotNull(tutte);
            Console.WriteLine(tutte.ToString());
            for(int i=0; i<tutte.Length; i++)
            {
                Console.WriteLine(tutte[i].Name);
                Console.WriteLine(tutte[i].KeyChain.Name);
                Console.WriteLine(tutte[i].KeyChain.Path);
            }
        }
    }
}