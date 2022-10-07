using Microsoft.VisualStudio.TestTools.UnitTesting;
using UNIBO.SET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIBO.SET.Model.Tests
{
    [TestClass()]
    public class FileKeyChainTests
    {
        [TestMethod()]
        public void AddKeyTest()
        {
            var kc = new FileKeyChain("RandomPath");

            kc.AddKey(new Key("a", new CodiceVerifica("cdv"), "c", new byte[20], "prova"));
            kc.AddKey(new Key("a", new CodiceVerifica("cdv"), "c2", new byte[20], "prova"));
            kc.AddKey(new Key("a1", new CodiceVerifica("cdv"), "c1", new byte[20], "prova"));
            kc.AddKey(new Key("a1", new CodiceVerifica("cdv"), "c1", new byte[20], "prova"));

            Assert.IsTrue(kc.DeleteKey(new Key("a1", new CodiceVerifica("cdv"), "c1", new byte[20], "prova")));

        }
    }
}