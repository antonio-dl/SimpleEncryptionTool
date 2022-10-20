using System.Text;
using File = UNIBO.SET.Model.File;

namespace UNIBO.SET.Services.Cifratori.Tests
{
    [TestClass()]
    public class CifratoreAEScbcTests
    {
        [TestMethod()]
        public void CifraFileTest()
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

            Assert.IsTrue(System.IO.File.Exists(fc.Path));

            var bytesLetti = System.IO.File.ReadAllBytes(fc.Path);
            byte[] bytesContenutoFile = Encoding.ASCII.GetBytes(contenutoFile);

            // testoLetto.Length > contenutoFile.Length ); parte interna alle parentesi dell'assert qui sotto
            Assert.IsTrue(bytesLetti.Length > bytesContenutoFile.Length); // Maggiore per aggiunta del IV
            Assert.AreNotEqual<string>(System.IO.File.ReadAllText(fc.Path), contenutoFile);
        }

        private static void CreaFileDiTest(string pathfile, string content)
        {
            System.IO.File.WriteAllText(pathfile, content);
        }


        [TestMethod()]

        public void BenchmarkCifratore()
        {
            var cifratore = new CifratoreAEScbc();
            var output = System.IO.File.AppendText(@"C:\Users\jackg\Desktop\benchmark\risultato.txt");
            var fileList = Directory.EnumerateFiles(@"C:\Users\jackg\Desktop\benchmark\TestFile").ToList();
            foreach (var file in fileList)
            {
                output.Write(Path.GetFileName(file)+"; ");
            }
            output.Write("\n");

            for (int i=0; i<100; i++)
            {
                foreach (var file in fileList)
                {
                    var timeInizio = DateTime.Now;
                    Key key = cifratore.CifraFile(new File(file));
                    var differenza = (DateTime.Now - timeInizio).TotalMilliseconds;
                    output.Write(differenza+"; ");
                    System.IO.File.Delete(key.TargetFilePath);
                }
                output.Write("\n");
            }
            output.Close();
        }
    }
}