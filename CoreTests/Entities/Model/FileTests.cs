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
            const string TESTPATH = @"C:\Users\De Luca\Desktop\asd.txt";

            var file = new File(TESTPATH);
            string md5 = file.CalcolaMD5();

            Assert.AreEqual(md5, "d41d8cd98f00b204e9800998ecf8427e");
            return;
        }
    }
}