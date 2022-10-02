using System.Collections;
using System.Diagnostics;
using UNIBO.SET.Model;
using UNIBO.SET.Services.Presenters;
using File = UNIBO.SET.Model.File;

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

        /* https://learn.microsoft.com/en-us/windows/uwp/files/quickstart-using-file-and-folder-pickers 
           https://stackoverflow.com/questions/4999734/how-to-add-browse-file-button-to-windows-form-using-c-sharp */
        private void AggiungiFile_Click(object sender, EventArgs e)
        {
            var filePicker = new System.Windows.Forms.OpenFileDialog();
            filePicker.Multiselect = true;
            if (filePicker.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] fileSelezionati = filePicker.FileNames;
                foreach(string s in fileSelezionati)
                {
                    richTextBox1.AppendText(s+ "\n");
                }
            }
        }

        private void AggiungiCartella_Click(object sender, EventArgs e)
        {
            var cartellaPicker = new FolderBrowserDialog();
            DialogResult result = cartellaPicker.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(cartellaPicker.SelectedPath))
            {
                string[] files = Directory.GetFiles(cartellaPicker.SelectedPath);
                foreach (string s in files)
                {
                    richTextBox1.AppendText(s + "\n");
                }
            }
        }

        private void EliminaSpaziVuoti()
        {
            string testo = richTextBox1.Text.Trim();
            richTextBox1.Clear();
            richTextBox1.Text = testo;
            return;
        }

        private void Rimuovi_Click(object sender, EventArgs e)
        {
            // va bene ma per vedere se tutto va la lascio commentata ----> this.EliminaSpaziVuoti();
            string[] righe = richTextBox1.Lines;
            int lungRiga = richTextBox1.SelectedText.Length;
            /*
            foreach (string s in righe)
            {
                richTextBox1.AppendText(s + "\n");
            }
            */
            string selezionato = richTextBox1.SelectedText.Trim();
            int pos = selezionato.IndexOf('\n');

            string[] daRimuovere = new string[righe.Length];
            daRimuovere[0] = selezionato;
            richTextBox1.AppendText("\n\t" + daRimuovere[0]);
        }

        private void Cifra_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void SelezionaUsb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomeUsb;
            USB usb;

            if(SelezionaUsb.SelectedItem is not null)
            {
                nomeUsb = (string) SelezionaUsb.SelectedItem;
                usb = new USB(nomeUsb);
                _presenter.SelezionaUSB(usb);
            }
        }

        private void CifraFileView_Load(object sender, EventArgs e)
        {
            var tutteUsb = _presenter.ElencaDispositiviEsterni();
            string[] nomiUsb = new string[tutteUsb.Length];
            for(int i=0; i<tutteUsb.Length; i++)
            {
                nomiUsb[i] = tutteUsb[i].Name;
            }

            this.SelezionaUsb.DataSource = nomiUsb;

            this.richTextBox1.Clear();
            
            this.SelezionaUsb_SelectedIndexChanged(sender, e);
        }

    }
}