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

            List<object> list = new List<object>();
            list.Add("Tutto");
            list.AddRange(Enum.GetNames<EntryType>());
            TipoBox.DataSource = list;
        }

        private void LogBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TipoBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}