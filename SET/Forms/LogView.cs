using UNIBO.SET.ModelLog;
using UNIBO.SET.Services.Presenters;

namespace UNIBO.SET.GUI.Forms
{
    public partial class LogView : Form
    {
        private readonly GestioneLogPresenter _presenter;

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
            this.LogBox.SelectedIndex = 0;

            List<object> list = new List<object>();
            list.Add("Tutto");
            list.AddRange(Enum.GetNames<EntryType>());
            this.TipoBox.DataSource = list;
            this.TipoBox.SelectedIndex = 0;

            this.richTextBox1.Clear();

            this.LogBox_SelectedIndexChanged(sender, e);
        }

        private void LogBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Log logSelezionato;
            string tipo;
            EntryType entryScelta;
            string result = "";
            if(LogBox.SelectedItem is not null && TipoBox.SelectedItem is not null)
            {
                if(TipoBox.SelectedItem.ToString().Equals("Tutto"))
                {
                    logSelezionato = (Log)LogBox.SelectedItem;
                    result = _presenter.ReadLog(logSelezionato);
                }
                else
                {
                    logSelezionato = (Log)LogBox.SelectedItem;
                    tipo = TipoBox.SelectedItem.ToString();
                    entryScelta = Enum.Parse<EntryType>(tipo);
                    result = _presenter.ReadLog(logSelezionato, entryScelta);
                }
            }
            richTextBox1.Clear();
            richTextBox1.Text = result;
        }

        private void TipoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Log logSelezionato;
            string tipo;
            EntryType entryScelta;
            string result = "";
            if (LogBox.SelectedItem is not null && TipoBox.SelectedItem is not null)
            {
                if (TipoBox.SelectedItem.ToString().Equals("Tutto"))
                {
                    logSelezionato = (Log)LogBox.SelectedItem;
                    result = _presenter.ReadLog(logSelezionato);
                }
                else
                {
                    logSelezionato = (Log)LogBox.SelectedItem;
                    tipo = TipoBox.SelectedItem.ToString();
                    entryScelta = Enum.Parse<EntryType>(tipo);
                    result = _presenter.ReadLog(logSelezionato, entryScelta);
                }
            }
            richTextBox1.Clear();
            richTextBox1.Text = result;
        }
    }
}