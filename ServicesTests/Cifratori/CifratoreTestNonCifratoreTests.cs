using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.Cifratori;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UNIBO.SET.Model;
namespace Services.Cifratori.Tests
{
    [TestClass()]
    public class CifratoreTestNonCifratoreTests
    {
        [TestMethod()]
        public void CifraFileTest()
        {
            File provaFile = new File("C:\\Users\\jackg\\Desktop\\prova.txt");
            var cifratore = new CifratoreAEScbc();
            cifratore.CifraFile(provaFile);
        }
    }
}