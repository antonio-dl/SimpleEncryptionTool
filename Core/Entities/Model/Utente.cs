namespace UNIBO.SET.Model
{
    public class Utente
    {
        public string Nome { get; set; }
        public Impostazioni Impostazioni { get; set; }
        public Credenziali Credenziali { get; set }
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