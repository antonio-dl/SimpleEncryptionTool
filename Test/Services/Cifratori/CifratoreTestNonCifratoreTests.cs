﻿using File = UNIBO.SET.Model.File;

namespace UNIBO.SET.Services.Cifratori.Tests
{
    [TestClass()]
    public class CifratoreTestNonCifratoreTests
    {
        [TestMethod()]
        public void CifraFileTest()
        {
            const string pathfile = Test.Constanti.CARTELLATEST + "prova.txt";
            const string contenutoFile = Test.Constanti.TESTODIPROVA;

            CreaFileDiTest(pathfile, contenutoFile);
            //string test = System.IO.File.ReadAllText(pathfile);
            System.IO.File.Delete(pathfile + ".sef");

            File provaFile = new File(pathfile);
            var cifratore = new TestNonCifratore();
            var key = cifratore.CifraFile(provaFile);
            var fc = new FileCifrato(pathfile); // sostituiti i paramentri "key.TargetFilePath, key" dentro le parentesi

            Assert.IsTrue(key == null);
            Assert.IsTrue(System.IO.File.Exists(fc.Path));
            string lettoDaFile = System.IO.File.ReadAllText(fc.Path);
            Assert.IsTrue(lettoDaFile.Length == contenutoFile.Length);
            Assert.AreEqual(lettoDaFile, contenutoFile);
        }

        private static void CreaFileDiTest(string pathfile, string content)
        {
            System.IO.File.WriteAllText(pathfile, content);
        }
    }
}