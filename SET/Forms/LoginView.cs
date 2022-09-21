using Microsoft.VisualBasic.ApplicationServices;
using Services.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNIBO.SET.Model;

namespace UNIBO.SET.GUI.Forms
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            User user = LoadUserData();
            InitializeComponent();


        }

        private User LoadUserData()
        {
            // Credenziali -> Utente <- Impostazioni
            Utente u = Utente.GetInstance(); // First Instance of Singleton
            u.Credenziali = LoadCredenziali();
            u.Impostazioni = LoadImpostazioni();


        }

        private Impostazioni LoadImpostazioni()
        {
            
        }

        private Credenziali LoadCredenziali()
        {
            throw new NotImplementedException();
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
