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
            string pathfile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\prova.txt";
            string test = System.IO.File.ReadAllText(pathfile);
            System.IO.File.Delete(pathfile + ".sef");
            File provaFile = new File(pathfile);
            var cifratore = new CifratoreTestNonCifratore();
            cifratore.CifraFile(provaFile);

            Assert.IsTrue(System.IO.File.Exists(pathfile + ".sef"));
        }
    }
}