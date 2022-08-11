

namespace sET_GUI
{
    public partial class HomeSET : Form
    {
        private RadioButton currentButton;
       // private Random random;
       // private int tempIndex;
        private Form activeForm;
        public HomeSET()
        {
            InitializeComponent();
        }

       /* private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                random.Next(ThemeColor.ColorList.Count);
            }
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }*/
        private void ActivateRadioButton(object sender)
        {
            if (sender != null)
            {
                if (currentButton != (RadioButton)sender)
                {
                    DisableRadioButton();
                    currentButton = (RadioButton)sender;
                    currentButton.BackColor = Color.Crimson;
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
                    previousBtn.BackColor = Color.Coral;
                }
            }
        }



         private void OpenChildForm(Form childForm, object sender)
         {
             /*if(activeForm!=null)
             {
                 ActiveForm.Close();
             }*/
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
            //OpenChildForm(new HomeSET(), sender);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.CifraFileView(), sender);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.DecifraFileView(), sender);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ImpostazioniView(), sender);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.LogView(), sender);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}