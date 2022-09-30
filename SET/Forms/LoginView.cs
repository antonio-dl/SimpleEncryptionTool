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

            return u;
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

        private void Accedi_Click(object sender, EventArgs e)
        {
            CredenzialiPassword c = new CredenzialiPassword(Password.Text);
            
            if (!presenter.LogIn(c))
            {
                MessageBox.Show("Password errata!", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                HomeSET home = new HomeSET(init);
                home.ShowDialog();
                this.Dispose(); // TODO: potrebbe causare errori :D
            }
        }

    }
}