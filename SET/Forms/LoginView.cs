using Microsoft.VisualBasic.ApplicationServices;
using Services.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNIBO.SET.Model;
using File = System.IO.File;

namespace UNIBO.SET.GUI.Forms
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            Utente utente = LoadUserData();
            InitializeComponent();


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
            string pathImpostazioni = UNIBO.SET.SETEnvironment.Configuration_Path;
            Impostazioni i;
            string settingsJSON = System.IO.File.ReadAllText(pathImpostazioni);

            i = System.Text.Json.JsonSerializer.Deserialize<Impostazioni>(settingsJSON);

            return i;

        }

        private Credenziali LoadCredenziali(Utente u) // TODO: Test della seriallizzaziote e deserializzazione
        {
            Credenziali c;
            BinaryFormatter bf = new BinaryFormatter();
            FileInfo f = new FileInfo(SETEnvironment.Credential_Path);
            Stream stream = f.OpenRead();
            c = (Credenziali) bf.Deserialize(stream );
            stream.Close();

            return c;
        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Accedi_Click(object sender, EventArgs e)
        {

            this.Hide();
            HomeSET home = new HomeSET(init);
            home.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
