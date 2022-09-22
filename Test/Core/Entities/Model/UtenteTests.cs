using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIBO.SET.Model.Tests
{
    [TestClass()]
    public class UtenteTests
    {
        [TestMethod()]
        public void GetInstanceTest()
        {
            Utente u = Utente.GetInstance();
            Utente u2 = Utente.GetInstance();
            
            Assert.IsNotNull(u);
            Assert.IsNotNull(u2);
            Assert.AreEqual(u.Nome, u2.Nome);
            Assert.AreSame(u, u2);
        }
    }
}
