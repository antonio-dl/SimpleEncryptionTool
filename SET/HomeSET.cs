namespace sET_GUI
{
    public partial class HomeSET : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
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
        private void ActivateButton(object sender)
        {
            if (sender != null)
            {
                if (currentButton != (Button)sender)
                {
                    currentButton = (Button)sender;
                    currentButton.BackColor = Color.BurlyWood;
                    currentButton.ForeColor = Color.White;
                }
            }
        }

       /* private void OpenChildForm(Form childForm, object sender)
        {
            if(activeForm!=null){
                ActiveForm.close();
            }
            ActivateButton(sender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Forms.FormHome(), sender);
            ActivateButton(sender);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}