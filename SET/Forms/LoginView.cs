using System.Runtime.Serialization.Formatters.Binary;
using UNIBO.SET.Model;
using UNIBO.SET.Services.Presenters;
using File = System.IO.File;

namespace UNIBO.SET.GUI.Forms
{
    public partial class LoginView : Form
    {
        private readonly GestioneLoginPresenter presenter;
        private readonly Utente utente;

        private Inizializzatore init;

        public LoginView()
        {
            utente = Utente.GetInstance();
            utente.Credenziali = LoadCredenziali();
            init = new Inizializzatore();
            presenter = init.GestioneLoginPresenter;

            InitializeComponent();
            Password.PasswordChar = '\u25CF';
        }

        private static Credenziali LoadCredenziali() // TODO: Test della serializzazione e deserializzazione
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
                this.Close(); // TODO: potrebbe causare errori :D
            }
        }

    }
}