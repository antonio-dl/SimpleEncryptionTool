namespace UNIBO.SET.Model
{
    public class Utente
    {
        public string Nome { get; set; }
        public Impostazioni Impostazioni { get; set; }
        public Credenziali Credenziali { get; set; }

        public Utente(string nome, Impostazioni impostazioni, Credenziali credenziali)
        {
            Nome = nome;
            Impostazioni = impostazioni;
            Credenziali = credenziali;
        }
        /*
        public void CambiaCredenziali(Credenziali credenziali)
        {
            this.Credenziali = credenziali;
        }
        */
    }

    public abstract class Credenziali
    {
        public string Passwd { get; }

        public Credenziali(string password)
        {
            Passwd = password;
        }

        public abstract bool Confronta(Credenziali credenziali);
    }

    public class Impostazioni
    {
        private Impostazione[] settaggi;

        public Impostazioni(Impostazione[] settaggi)
        {
            this.settaggi = settaggi;
        }

        public Impostazione[] OttieniSettaggi()
        {
            return settaggi;
        }

        /*public void AggiungiImpostazione(Impostazione imp)
        {
            _ = settaggi.Append(imp);
        }
        */
        public int NumSettaggi()
        {
            return settaggi.Length;
        }
    }

    public class Impostazione
    {
        public string Nome { get; set; }
        public string[] Opzioni { get; set; }
        public string Selezionato { get; set; }

        public Impostazione(string nome, string[] opzioni, string selezionato)
        {
            Nome = nome;
            Opzioni = opzioni;
            Selezionato = selezionato;
        }
    }
}