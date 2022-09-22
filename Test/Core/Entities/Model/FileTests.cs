using Microsoft.VisualStudio.TestTools.UnitTesting;
using UNIBO.SET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace UNIBO.SET.Model.Tests
{
    [TestClass()]
    public class FileTests
    {
        [TestMethod()]
        public void CalcolaMD5Test()
        {
            const string TESTPATH0 = Test.Constanti.CARTELLATEST + "asd1.txt";
            const string TESTPATH1 = Test.Constanti.CARTELLATEST + "asd2.txt";

            const string contenuto = "aaabbbccc";

            System.IO.File.WriteAllText(TESTPATH0, contenuto);
            System.IO.File.WriteAllText(TESTPATH1, contenuto);

            var file0 = new File(TESTPATH0);
            var file1 = new File(TESTPATH1);
            string md5f0 = file0.CalcolaMD5();
            string md5f1 = file1.CalcolaMD5();

            Assert.AreEqual(md5f0, md5f1);

            System.IO.File.Delete(TESTPATH0);
            System.IO.File.Delete(TESTPATH1);

            return;
        }

        [TestMethod()]
        public void EqualsCodiceVerificaTest()
        {
            const string cod1 = "CodiceProva";
            const string cod2 = "CodiceProva";
            const string cod3 = "CodiceProvaACaso";

            CodiceVerifica c1 = new CodiceVerifica(cod1);
            CodiceVerifica c2 = new CodiceVerifica(cod2);
            CodiceVerifica c3 = new CodiceVerifica(cod3);

            bool test1 = c1.Equals(c2); // true
            bool test2 = c2.Equals(c1); // true
            bool test3 = c1.Equals(c3); // false
            bool test4 = c2.Equals(c2); // true
            bool test5 = c2.Equals(c3); // false
            bool test6 = c3.Equals(c3); // true

            Assert.IsTrue(test1);
            Assert.IsTrue(test2);
            Assert.IsFalse(test3);
            Assert.IsTrue(test4);
            Assert.IsFalse(test5);
            Assert.IsTrue(test6);

            string pathfile = Test.Constanti.CARTELLATEST + "testProva.txt";
            string pathfile2 = Test.Constanti.CARTELLATEST + "testProva2.txt";
            string pathfile3 = Test.Constanti.CARTELLATEST + "testProva3.txt";
            string contenutoFile12 = Test.Constanti.TESTODIPROVA;
            string contenutoFile3 = "Testo a caso solo per vedere se il codice verifica funziona come deve oppure no";

            CreaFileDiTest(pathfile, contenutoFile12);
            CreaFileDiTest(pathfile2, contenutoFile12);
            CreaFileDiTest(pathfile3, contenutoFile3);

            File provaFile1 = new File(pathfile);
            File provaFile2 = new File(pathfile2);
            File provaFile3 = new File(pathfile3);

            var c7 = provaFile1.CalcolaMD5Byte();
            var c8 = provaFile2.CalcolaMD5Byte();
            var c9 = provaFile3.CalcolaMD5Byte();

            Assert.IsTrue(c7.Equals(c7));
            Assert.IsTrue(c7.Equals(c8));
            Assert.IsFalse(c7.Equals(c9));
        }

        private static void CreaFileDiTest(string pathfile, string content)
        {
            System.IO.File.WriteAllText(pathfile, content);
        }
    }
}