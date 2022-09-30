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
            this.LogBox.DataSource = logFiles;

            List<object> list = new List<object>();
            list.Add("Tutto");
            list.AddRange(Enum.GetNames<EntryType>());
            this.TipoBox.DataSource = list;

            this.LogBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.TipoBox.DropDownStyle = ComboBoxStyle.DropDownList;

            this.richTextBox1.Clear();
            this.richTextBox1.ReadOnly = true;
        }

        private void LogBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Log logSelezionato;
            EntryType tipo;
            string result = "";
            if(LogBox.SelectedItem is not null && TipoBox.SelectedItem is null)
            {
                logSelezionato = (Log) LogBox.SelectedItem;
                result = _presenter.ReadLog(logSelezionato);
            }
            else if (LogBox.SelectedItem is not null && TipoBox.SelectedItem is not null)
            {
                logSelezionato = (Log)LogBox.SelectedItem;
                tipo = (EntryType)TipoBox.SelectedItem;
                result = _presenter.ReadLog(logSelezionato, tipo);
            }
            richTextBox1.Clear();
            richTextBox1.Text = result;
        }

        private void TipoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Log logSelezionato;
            EntryType tipo;
            string result = "";
            if (LogBox.SelectedItem is not null && TipoBox.SelectedItem is not null)
            {
                logSelezionato = (Log) LogBox.SelectedItem;
                tipo = (EntryType) TipoBox.SelectedItem;
                result = _presenter.ReadLog(logSelezionato, tipo);
            }
            else if (LogBox.SelectedItem is not null && TipoBox.SelectedItem is null)
            {
                logSelezionato = (Log)LogBox.SelectedItem;
                result = _presenter.ReadLog(logSelezionato);
            }
            richTextBox1.Clear();
            richTextBox1.Text = result;
        }
    }
}