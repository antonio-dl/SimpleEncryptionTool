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

        private void Rimuovi_Click(object sender, EventArgs e)
        {
            string[] righe = richTextBox1.Lines;
            string selezionato = richTextBox1.SelectedText.Trim();

            if(selezionato != "")
            {
                for(int i=0; i<righe.Length; i++)
                {
                    if (righe[i].Contains(selezionato))
                    {
                        righe[i] = "";
                    }
                }
            }
            richTextBox1.Clear();
            foreach(string s in righe)
            {
                if(s != "")
                {
                    richTextBox1.AppendText(s + "\n");
                }
            }
        }

        private void Cifra_Click(object sender, EventArgs e)
        {
            string[] fileDaCifrare = richTextBox1.Lines;
            string fileSingolo;
            File f;
            USB? usb = _presenter.SelectedUSB;
            Key key;
            FileKeyChain fkc;

            if(usb is not null)
            {
                for(int i=0; i<fileDaCifrare.Length; i++)
                {
                    fileSingolo = fileDaCifrare[i].Trim();
                    f = new File(fileSingolo);
                    key = _presenter.Cifra(f);
                    fkc = usb.KeyChain;
/*
Non ho capito/manca proprio:
- metodi per creare materialmente il path di cartelle di un FileKeyChain sulla chiavetta USB nel caso ancora non ne avesse uno
- metodi per aggiungere e/o rimuovere Key da una KeyChain contenuta da un FileKeyChain (dal Model)
- metodi nel CifraFilePresenter che permettano di salvare nell'USB (dal Model) una Key dentro a KeyChain contenuta da un FileKeyChain dopo aver cifrato un file
*/
                }
                richTextBox1.Clear();
            }
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