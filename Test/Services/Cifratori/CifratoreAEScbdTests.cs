using Microsoft.VisualStudio.TestTools.UnitTesting;
using UNIBO.SET.Services.Cifratori;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UNIBO.SET.Model;
using File = UNIBO.SET.Model.File;

namespace UNIBO.SET.Services.Cifratori.Tests
{
    [TestClass()]
    public class CifratoreAEScbdTests
    {
        [TestMethod()]
        public void CifraFileTest()
        {
            string pathfile = Test.Constanti.CARTELLATEST + "prova.txt";
            string contenutoFile = Test.Constanti.TESTODIPROVA;


            CreaFileDiTest(pathfile,contenutoFile);
            //string test = System.IO.File.ReadAllText(pathfile);
            System.IO.File.Delete(pathfile + ".sef");


            File provaFile = new File(pathfile);
            var cifratore = new CifratoreAEScbc();
            var fc = cifratore.CifraFile(provaFile);

            Assert.IsTrue(System.IO.File.Exists(fc.Path));

            string testoLetto = System.IO.File.ReadAllText(fc.Path);
            Assert.IsTrue(testoLetto.Length > contenutoFile.Length ); // Maggiore per aggiunta del IV
            Assert.AreNotEqual<string>(testoLetto, contenutoFile);

        }

        private static void CreaFileDiTest(string pathfile, string content)
        {
            System.IO.File.WriteAllText(pathfile, content);
        }
    }
}