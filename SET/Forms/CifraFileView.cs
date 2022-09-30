using UNIBO.SET.Services.Presenters;

namespace UNIBO.SET.GUI.Forms
{
    public partial class CifraFileView : Form
    {
        private readonly GestioneCifraturaPresenter _presenter;

        public CifraFileView(GestioneCifraturaPresenter presenter)
        {
            _presenter = presenter;
            InitializeComponent();
        }

        private void Aggiungi_Click(object sender, EventArgs e)
        {
        }

        private void Rimuovi_Click(object sender, EventArgs e)
        {
        }

        private void Cifra_Click(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CifraFileView_Load(object sender, EventArgs e)
        {

        }
    }
}