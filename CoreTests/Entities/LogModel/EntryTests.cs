using Microsoft.VisualStudio.TestTools.UnitTesting;
using UNIBO.SET.ModelLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIBO.SET.ModelLog.Tests
{
    [TestClass()]
    public class EntryTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            Entry entry = new Entry(EntryType.Info, "Test", "This is a test!");
            string asd = entry.ToString();
            Console.WriteLine(asd);

        }
    }
}