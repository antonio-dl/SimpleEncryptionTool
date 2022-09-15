namespace UNIBO.SET.Model
{
    public class Utente // Applicare Pattern Singleton
    {
        private static Utente _utente;

        private Utente() {
            _utente = LoadUserDataMock();
        }

        private Utente LoadUserDataMock()
        {
            IDictionary<string, Impostazione> basic = new Dictionary<string, Impostazione>();
            string[] caso1 = { "rosso", "giallo", "verde" };
            Impostazione imp1 = new Impostazione("Colore", caso1, "rosso");
            basic.Add("aCaso1", imp1);
            string[] caso2 = { "piccolo", "medio", "grande" };
            Impostazione imp2 = new Impostazione("Dimensione", caso2, "piccolo");
            basic.Add("aCaso2", imp2);
            Credenziali cred = new CredenzialiPassword("Ciabatta");
            return new Utente("Me", new Impostazioni(basic), cred);
        }

        public static Utente GetInstance() {
            
            return _utente ?? new Utente();
        }

        public string Nome { get; set; }
        public Impostazioni Impostazioni { get; set; }
        public Credenziali Credenziali { get; set; }

        private Utente(string nome, Impostazioni impostazioni, Credenziali credenziali)
        {
            Nome = nome;
            Impostazioni = impostazioni;
            Credenziali = credenziali;
        }
    }

    public class Impostazioni
    {
        private IDictionary<string,Impostazione> impostazioni;

        public Impostazioni(IDictionary<string, Impostazione> impostazioni)
        {
            this.impostazioni = impostazioni;
        }

        public Impostazione[] OttieniTutteImpostazioni()
        {
            return this.impostazioni.Values.ToArray();
        }

        /*public void AggiungiImpostazione(Impostazione imp)
        {
            _ = settaggi.Append(imp);
        }
        */

        public int LunghezzaImpostazioni()
        {
            return impostazioni.Count;
        }

        public Impostazione OttieniImpostazione(string nomeImpostazione)
        {
            return impostazioni[nomeImpostazione];
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