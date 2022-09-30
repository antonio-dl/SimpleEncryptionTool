using UNIBO.SET.ModelLog;
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void LogView_Load(object sender, EventArgs e)
        {
            var logFiles = _presenter.GetAllLogs();
            LogBox.DataSource = logFiles;
            LogBox.DisplayMember = "PathFile";
            LogBox.ValueMember = "PathFile";

            var tipoOp = new List<EntryType>();
            tipoOp.Add(EntryType.Info);
            tipoOp.Add(EntryType.Operazione);
            tipoOp.Add(EntryType.Avvertimento);
            tipoOp.Add(EntryType.Errore);
            TipoBox.DataSource = tipoOp;
            TipoBox.DisplayMember = "Name";
            TipoBox.ValueMember = "Value";
        }

        private void LogBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TipoBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}