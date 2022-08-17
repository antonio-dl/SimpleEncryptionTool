
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace UNIBO.SET.GUI
{
    public partial class HomeSET : Form
    {
        private RadioButton currentButton;
        private Form activeForm;
        /*[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidthEllipse,
                int nHeightEllipse
            );*/

        public HomeSET()
        {
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

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton1_CheckedChanged(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.CifraFileView(), sender);
        }

        private void rjButton2_CheckedChanged(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.DecifraFileView(), sender);
        }

        private void rjButton3_CheckedChanged(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ImpostazioniView(), sender);
        }

        private void rjButton4_CheckedChanged(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.LogView(), sender);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}