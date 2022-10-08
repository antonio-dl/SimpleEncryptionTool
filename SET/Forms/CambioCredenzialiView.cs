using System.Runtime.Serialization.Formatters.Binary;
using UNIBO.SET.Model;
using UNIBO.SET.Services.Presenters;

namespace UNIBO.SET.GUI.Forms
{
    public partial class CambioCredenzialiView : Form
    {
        private readonly Utente utente = Utente.GetInstance();
        private readonly GestioneImpECrededenzialiPresenter _presenter;

        public CambioCredenzialiView(GestioneImpECrededenzialiPresenter presenter)
        {
            _presenter = presenter;
            InitializeComponent();
            vecchiaPw.PasswordChar = '\u25CF';
            nuovaPw.PasswordChar = '\u25CF';
            nuovaPw2.PasswordChar = '\u25CF';
        }

        private void Annulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Conferma_Click(object sender, EventArgs e)
        {
            CredenzialiPassword vecchia = new CredenzialiPassword(vecchiaPw.Text);
            CredenzialiPassword nuova = new CredenzialiPassword(nuovaPw.Text);

            if (nuovaPw.Text.Length < 5)
            {
                MessageBox.Show("Password troppo corta!", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!nuovaPw.Text.Equals(nuovaPw2.Text))
            {
                MessageBox.Show("Le password sono diverse!", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!_presenter.SalvaNuoveCredenziali(vecchia, nuova))
            {
                MessageBox.Show("La vecchia password è errata", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CredenzialiPassword c2 = new CredenzialiPassword(nuovaPw.Text);
                BinaryFormatter bf = new BinaryFormatter();
                FileInfo f = new FileInfo(SETEnvironment.Credential_Path);
                Stream stream = f.OpenWrite();
                bf.Serialize(stream, c2);
                stream.Close();

                this.Close();
            }
        }
    }
}