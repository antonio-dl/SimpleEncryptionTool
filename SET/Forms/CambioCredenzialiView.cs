using System.Runtime.Serialization.Formatters.Binary;
using UNIBO.SET.Model;

namespace UNIBO.SET.GUI.Forms
{
    public partial class CambioCredenzialiView : Form
    {
        private Utente utente;
        public CambioCredenzialiView()
        {
            InitializeComponent();
            vecchiaPw.PasswordChar = '\u25CF';
            nuovaPw.PasswordChar = '\u25CF';
            nuovaPw2.PasswordChar = '\u25CF';
        }


        private void CambioCredenzialiView_Load(object sender, EventArgs e)
        {

        }

        private void Annulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Conferma_Click(object sender, EventArgs e)
        {
            CredenzialiPassword c = new CredenzialiPassword(vecchiaPw.Text);
            if (!c.Confronta(utente.Credenziali))
            {
                MessageBox.Show("La vecchia password è errata", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (nuovaPw.Text.Length < 5 && nuovaPw2.Text.Length < 5)
                {
                    MessageBox.Show("Password troppo corta!", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!nuovaPw.Text.Equals(nuovaPw2.Text))
                {
                    MessageBox.Show("Le password sono diverse!", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CredenzialiPassword c2 = new CredenzialiPassword(nuovaPw.Text);
                    BinaryFormatter bf = new BinaryFormatter();
                    FileInfo f = new FileInfo(SETEnvironment.Credential_Path);
                    Stream stream = f.OpenWrite();
                    bf.Serialize(stream, c2);
                    stream.Close();

                    
                }
            }
        }
    }
}