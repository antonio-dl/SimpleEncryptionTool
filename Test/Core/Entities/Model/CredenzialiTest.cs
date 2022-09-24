namespace UNIBO.SET.Model.Tests
{
    [TestClass()]
    public class CredenzialiTest
    {
        [TestMethod()]
        public void ConfrontaTest()
        {
            const string PASSWORD1 = "pswProva";
            const string PASSWORD2 = "pswProva";
            const string PASSWORD3 = "PswProva";
            Credenziali credenziali1 = new CredenzialiPassword(PASSWORD1);
            Credenziali credenziali2 = new CredenzialiPassword(PASSWORD2);
            Credenziali credenziali3 = new CredenzialiPassword(PASSWORD3);

            Assert.IsTrue(credenziali1.Confronta(credenziali2));
            Assert.IsTrue(credenziali2.Confronta(credenziali2));
            Assert.IsFalse(credenziali1.Confronta(credenziali3));

            return;
        }
    }
}