namespace UNIBO.SET.Model
{
    public class Utente
    {
        private string Nome { get; set; }
        private Impostazioni impost;
        private Credenziali cred;
    }

    public abstract class Credenziali
    {
        public bool Confronta(Credenziali credenziali);
    }

    public class Impostazioni
    {
        private Impostazione[] settaggi;
    }

    public class Impostazione
    {
        public string Nome;
        public string[] Opzioni;
        public string Selezionato;
    }
}