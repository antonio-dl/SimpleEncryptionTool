using UNIBO.SET.Services.Presenters;

namespace UNIBO.SET.GUI.Forms
{
    public partial class DecifraFileView : Form
    {
        private GestioneDecifraturaPresenter _presenter;

        public DecifraFileView(GestioneDecifraturaPresenter _presenter)
        {
            _presenter = _presenter;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}