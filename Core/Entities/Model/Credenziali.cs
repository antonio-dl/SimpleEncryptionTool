namespace UNIBO.SET.Model
{
    [Serializable]
    public abstract class Credenziali
    {
        public abstract bool Confronta(Credenziali credenziali);
    }

    [Serializable]
    public class CredenzialiPassword : Credenziali
    {
        public string Password { get; set; }

        public CredenzialiPassword(string password)
        {
            Password = password;
        }

        public override bool Confronta(Credenziali cred)
        {
            return cred is CredenzialiPassword credpass &&
                   Password == credpass.Password;
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