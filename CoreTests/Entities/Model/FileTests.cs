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
    public class FileTests
    {
        [TestMethod()]
        public void CalcolaMD5Test()
        {
            const string TESTPATH0 = @"C:\Users\De Luca\Desktop\asd0.txt";
            const string TESTPATH1 = @"C:\Users\De Luca\Desktop\asd2.txt";

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
    }
}