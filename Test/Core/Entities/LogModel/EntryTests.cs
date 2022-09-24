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