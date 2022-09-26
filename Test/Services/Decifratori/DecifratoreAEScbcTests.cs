using System.Text;
using UNIBO.SET.Services.Cifratori;
using File = UNIBO.SET.Model.File;

namespace UNIBO.SET.Services.Decifratori.Tests
{
    [TestClass()]
    public class DecifratoreAEScbcTests
    {
        [TestMethod()]
        public void DecifraFileTest()
        {
            string pathfile = Test.Constanti.CARTELLATEST + "prova.txt";
            string contenutoFile = Test.Constanti.TESTODIPROVA;

            CreaFileDiTest(pathfile, contenutoFile);
            //string test = System.IO.File.ReadAllText(pathfile);
            System.IO.File.Delete(pathfile + ".sef");

            File provaFile = new File(pathfile);
            var cifratore = new CifratoreAEScbc();
            var key = cifratore.CifraFile(provaFile);
            var fc = new FileCifrato(key.TargetFilePath, key);

            var decifratore = new DecifratoreAEScbc();
            FileDecifrato fd = decifratore.Decifra(key);
            // che sia esistente e uguale al file originale prima della cifratura
            Assert.IsTrue(System.IO.File.Exists(fd.Path));

            var bytesLetti = System.IO.File.ReadAllBytes(fc.Path);
            byte[] bytesContenutoFile = Encoding.ASCII.GetBytes(contenutoFile);
            byte[] bytesfd = System.IO.File.ReadAllBytes(fd.Path);
            string fdLetto = System.IO.File.ReadAllText(fd.Path);

            // testoLetto.Length > contenutoFile.Length ); parte interna alle parentesi dell'assert qui sotto
            Assert.IsTrue(bytesLetti.Length > bytesContenutoFile.Length);   // Maggiore per aggiunta del IV
            Assert.IsTrue(bytesLetti.Length > bytesfd.Length);              // Maggiore per aggiunta del IV
            Assert.AreEqual(bytesfd.Length, bytesContenutoFile.Length);     // dovrebbero avere la stessa lunghezza
            Assert.AreNotEqual<string>(System.IO.File.ReadAllText(fc.Path), contenutoFile); // dovrebbero essere ovviamente diversi perché il primo è cifrato, il secondo no
            Assert.AreNotEqual<string>(System.IO.File.ReadAllText(fc.Path), fdLetto); // dovrebbero essere ovviamente diversi perché il primo è cifrato, il secondo no
            Assert.AreEqual<string>(fdLetto, contenutoFile); // dovrebbero essere uguali perché una volta decifrato dovrebbe avere lo stesso contenuto di quello di partenza
            Assert.IsTrue(fdLetto.Length == contenutoFile.Length); // dovrebbero essere uguali per il motivo precedente
        }

        private static void CreaFileDiTest(string pathfile, string content)
        {
            System.IO.File.WriteAllText(pathfile, content);
        }
    }
}