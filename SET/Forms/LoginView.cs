using System.Runtime.Serialization.Formatters.Binary;
using UNIBO.SET.Model;
using UNIBO.SET.Services.Presenters;
using File = System.IO.File;

namespace UNIBO.SET.GUI.Forms
{
    public partial class LoginView : Form
    {
        private GestioneLoginPresenter presenter;
        private Utente utente;

        private Inizializzatore init;

        public LoginView()
        {
            utente = LoadUserData();
            init = new Inizializzatore();
            presenter = init.GestioneLoginPresenter;

            InitializeComponent();
            Password.PasswordChar = '\u25CF';
        }

        private Utente LoadUserData()
        {
            // Credenziali -> Utente <- Impostazioni
            Utente u = Utente.GetInstance(); // First Instance of Singleton
            u.Credenziali = LoadCredenziali(u);
            u.Impostazioni = LoadImpostazioni(u);

            return u;
        }

        private Impostazioni LoadImpostazioni(Utente u)
        {
            if (File.Exists(SETEnvironment.Configuration_Path))
            {
                string pathImpostazioni = UNIBO.SET.SETEnvironment.Configuration_Path;
                Impostazioni i;
                string settingsJSON = System.IO.File.ReadAllText(pathImpostazioni);

                return i = System.Text.Json.JsonSerializer.Deserialize<Impostazioni>(settingsJSON);
            }
            else
            {
                return CreateDefaultSettings();
            }
        }

        private Impostazioni CreateDefaultSettings()
        {
            Dictionary<string, Impostazione> settings = new Dictionary<string, Impostazione>();
            Impostazione i = CaricaCifratori();
            settings[i.Nome] = i;

            return new Impostazioni(settings);
        }

        private Impostazione CaricaCifratori()
        {
            string[] cifratoriOpzioni = { "AES-ECB", "AES-CBC" };
            return new Impostazione("cifratore", cifratoriOpzioni[0], cifratoriOpzioni);
        }

        private Credenziali LoadCredenziali(Utente u) // TODO: Test della serializzazione e deserializzazione
        {
            Credenziali c;
            BinaryFormatter bf = new BinaryFormatter();
            FileInfo f = new FileInfo(SETEnvironment.Credential_Path);
            Stream stream = f.OpenRead();
            c = (Credenziali)bf.Deserialize(stream);
            stream.Close();

            return c;
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
        }

        private void Accedi_Click(object sender, EventArgs e)
        {
            CredenzialiPassword c = new CredenzialiPassword(Password.Text);

            if (!c.Confronta(utente.Credenziali))
            {
                Thread.Sleep(1000);
                MessageBox.Show("Password errata!", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                HomeSET home = new HomeSET(init);
                home.ShowDialog();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}