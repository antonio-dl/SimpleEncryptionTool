using System.Runtime.Serialization.Formatters.Binary;
using UNIBO.SET.Model;

namespace UNIBO.SET.GUI.Forms
{
    public partial class FirstLoginView : Form
    {
        public FirstLoginView()
        {
            InitializeComponent();
            Password.PasswordChar = '\u25CF';
            ripetiPass.PasswordChar = '\u25CF';
        }

        private void Registrati_Click(object sender, EventArgs e)
        {
            if (Password.Text.Length < 5 && ripetiPass.Text.Length < 5)
            {
                MessageBox.Show("Password troppo corta!", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Password.Text.Equals(ripetiPass.Text))
            {
                MessageBox.Show("Le password sono diverse!", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CredenzialiPassword c = new CredenzialiPassword(Password.Text);
                BinaryFormatter bf = new BinaryFormatter();
                FileInfo f = new FileInfo(SETEnvironment.Credential_Path);
                f.Directory.Create();
                Stream stream = f.OpenWrite();
                bf.Serialize(stream, c);
                stream.Close();

                this.Hide();
                LoginView login = new LoginView();
                login.ShowDialog();
            }
        }
    }
}