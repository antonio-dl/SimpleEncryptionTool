using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNIBO.SET.Services.Cifratori;
using File = UNIBO.SET.Model.File;

namespace UNIBO.SET.Services.Decifratori.Tests
{
    [TestClass()]
    public class DecifratoreAEScbdTests
    {
        [TestMethod()]
        public void DecifraFileTest()
        {
            string pathfile = Test.Constanti.CARTELLATEST + "prova.txt.sef";
            string contenutoFile = Test.Constanti.TESTODIPROVA;

            // CreaFileDiTest(pathfile,contenutoFile);
            // string test = System.IO.File.ReadAllText(pathfile);
            // System.IO.File.Delete(pathfile + ".sef");


            File provaFile = new File(pathfile);
            var decifratore = new DecifratoreAEScbc();
            var fd = decifratore.Decifra(KEY);

            Assert.IsTrue(System.IO.File.Exists(fd.Path));

            string testoLetto = System.IO.File.ReadAllText(fd.Path);
            Assert.IsTrue(testoLetto.Length > contenutoFile.Length); // Maggiore per aggiunta del IV
            Assert.AreNotEqual<string>(testoLetto, contenutoFile);
        }

        private static void CreaFileDiTest(string pathfile, string content)
        {
            System.IO.File.WriteAllText(pathfile, content);
        }
    }
}
