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

        [TestMethod()]
        public void FileLogTests()
        {
            string pathfile = Test.Constanti.CARTELLATEST + "fileLog.log";
            FileLog fl = new FileLog(pathfile);
            DateTime dt = new DateTime(2022, 09, 26, 16, 54, 30, 999);
            Entry e1 = new Entry(dt, EntryType.Info, "Test1", "Primo test!");
            Entry e2 = new Entry(EntryType.Info, "Test2", "Secondo test!");
            Entry e3 = new Entry(EntryType.Avvertimento, "Test3", "Terzo test!");
            Entry e4 = new Entry(EntryType.Avvertimento, "Test4", "Quarto test!");
            Entry e5 = new Entry(EntryType.Errore, "Test5", "Quinto test!");
            Entry e6 = new Entry(EntryType.Errore, "Test6", "Sesto test!");
            Entry e7 = new Entry(EntryType.Operazione, "Test7", "Settimo test!");
            Entry e8 = new Entry(EntryType.Operazione, "Test8", "Ottavo test!");

            fl.AddEntry(e1);
            fl.AddEntry(e2);
            fl.AddEntry(e3);
            fl.AddEntry(e4);
            fl.AddEntry(e5);
            fl.AddEntry(e6);
            fl.AddEntry(e7);
            fl.AddEntry(e8);

            Entry[] tutte = fl.GetEntries();
            Entry[] filtrate = fl.GetEntries(EntryType.Info);

            for(int i=0; i<tutte.Length; i++)
            {
                Console.WriteLine(tutte[i].ToString());
            }
            for (int i = 0; i < filtrate.Length; i++)
            {
                Console.WriteLine(filtrate[i].ToString());
            }
        }
    }
}