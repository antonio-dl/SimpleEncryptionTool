using System.Runtime.Serialization.Formatters.Binary;
using UNIBO.SET.Model;
using UNIBO.SET.Services.Presenters;
using File = System.IO.File;

namespace UNIBO.SET.GUI.Forms
{
    public partial class LoginView : Form
    {
        private readonly GestioneLoginPresenter _presenter;
        private readonly Utente _utente;

        private Inizializzatore init;

        public LoginView()
        {
            _utente = Utente.GetInstance();
            _utente.Credenziali = LoadCredenziali();
            init = new Inizializzatore();
            _presenter = init.GestioneLoginPresenter;

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
            
            if (!_presenter.LogIn(c))
            {
                MessageBox.Show("Password errata!", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                HomeSET home = new HomeSET(init);
                home.ShowDialog();
                this.Close();
            }
        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Accedi.PerformClick();
            }
        }
    }
}