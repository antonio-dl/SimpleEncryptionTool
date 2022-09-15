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
            throw new NotImplementedException();
        }

        public static Utente GetInstance() { // TODO: CAMBIARE QUESTA COSA PER IL PATTERN SINGLETON
            return _utente;
        }

        public string Nome { get; set; }
        public Impostazioni Impostazioni { get; set; }
        public Credenziali Credenziali { get; set; }

        public Utente(string nome, Impostazioni impostazioni, Credenziali credenziali)
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