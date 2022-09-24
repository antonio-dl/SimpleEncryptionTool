using UNIBO.SET.Services.Presenters;

namespace UNIBO.SET.GUI.Forms
{
    public partial class LogView : Form
    {
        private GestioneLogPresenter _presenter;

        public LogView(GestioneLogPresenter presenter)
        {
            _presenter = presenter;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}