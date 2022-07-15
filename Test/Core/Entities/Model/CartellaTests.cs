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
    public class CartellaTests
    {
        [TestMethod()]
        public void OttieniPathsTest()
        {
            const string TESTPATH = Test.Constanti.CARTELLATEST;

            Assert.IsTrue(System.IO.Directory.Exists(TESTPATH));
            var cartella = new Cartella(TESTPATH);
            var lista = cartella.OttieniPaths().ToList();
            return;

        }
    }
}