﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIBO.SET.Model
{
    public class CredenzialiPassword : Credenziali
    {
        public string Password { get; set; }

        public CredenzialiPassword(string password) : base(password)
        {
            Password = password;
        }

        public override bool Confronta(Credenziali cred)
        {
            return this.Password.Equals(cred.Passwd);
        }

        public override bool Equals(object? obj)
        {
            return obj is CredenzialiPassword password &&
                   Password == password.Password;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Password);
        }
    }

}
