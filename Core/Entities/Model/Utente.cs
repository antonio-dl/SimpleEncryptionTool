namespace UNIBO.SET.Model
{
    public class Utente
    {
        public string Nome { get; set; }
        public Impostazioni Impostazioni { get; set; }
        public Credenziali Credenziali { get; set; }
    }

    public abstract class Credenziali
    {
        public abstract bool Confronta(Credenziali credenziali);
    }

    public class Impostazioni
    {
        private Impostazione[] settaggi;
    }

    public class Impostazione
    {
        public string Nome { get; set; }
        public string[] Opzioni { get; set; }
        public string Selezionato { get; set; }
    }
}