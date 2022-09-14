
using Services.Presenters;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace UNIBO.SET.GUI
{
    public partial class HomeSET : Form
    {
        private RadioButton? currentButton;
        private Form activeForm;
        private Inizializzatore _init;


        public HomeSET(Inizializzatore init)
        {
            this._init = init;
            InitializeComponent();

        }

        private void ActivateRadioButton(object sender)
        {
            if (sender != null)
            {
                if (currentButton != (RadioButton)sender)
                {
                    DisableRadioButton();
                    currentButton = (RadioButton)sender;
                    currentButton.BackColor = Color.MediumSlateBlue;
                    currentButton.ForeColor = Color.White;
                }
            }
        }

        private void DisableRadioButton()
        {
            foreach(Control previousBtn in groupBox1.Controls)
            {
                if (previousBtn.GetType() == typeof(RadioButton))
                {
                    previousBtn.BackColor = Color.MediumSlateBlue;
                }
            }
        }



         private void OpenChildForm(Form childForm, object sender)
         {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateRadioButton(sender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel4.Controls.Add(childForm);
            this.panel4.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;
         }

        private void Reset()
        {
            DisableRadioButton();
            label1.Text = "HOME";
            currentButton = null;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void CifraRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.CifraFileView(_init.GestioneCifraturaPresenter), sender);
        }

        private void DecifraRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.DecifraFileView(_init.GestioneDecifraturaPresenter), sender);
        }

        private void ImpostazioniRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ImpostazioniView(_init.GestioneImpECrededenzialiPresenter), sender);
        }

        private void LogRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.LogView(_init.GestioneLogPresenter), sender);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}