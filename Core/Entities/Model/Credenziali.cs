using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIBO.SET.Model
{
    public class CredenzialiPassword : Credenziali
    {
        public string password { get; set; }

        public CredenzialiPassword(string psw)
        {
            this.password = psw;
        }

        public override bool Confronta(Credenziali cred)
        {
            return this.password.Equals(cred);
        }
    }
}
