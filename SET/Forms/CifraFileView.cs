using System.Collections;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using UNIBO.SET.Model;
using UNIBO.SET.Services.Presenters;
using UNIBO.SET.Services.Shared;
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

        private void AggiungiFile_Click(object sender, EventArgs e)
        {
            var filePicker = new System.Windows.Forms.OpenFileDialog();
            filePicker.Multiselect = true;
            if (filePicker.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] fileSelezionati = filePicker.FileNames;
                foreach (string s in fileSelezionati)
                    if (!listaFileDaCifrare.Items.Contains(s))
                        listaFileDaCifrare.Items.Add(s);
            }

        }

        private void AggiungiCartella_Click(object sender, EventArgs e)
        {
            var cartellaPicker = new FolderBrowserDialog();
            DialogResult result = cartellaPicker.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(cartellaPicker.SelectedPath))
            {
                string[] files = Directory.GetFiles(cartellaPicker.SelectedPath, "*.*", SearchOption.AllDirectories);
                foreach (string s in files)
                    if (!listaFileDaCifrare.Items.Contains(s))
                        listaFileDaCifrare.Items.Add(s);
            }
        }

        private void Rimuovi_Click(object sender, EventArgs e)
        {
            var selectedItems = listaFileDaCifrare.SelectedItems;

            if (listaFileDaCifrare.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    listaFileDaCifrare.Items.Remove(selectedItems[i]);
            }
        }

        private void Cifra_Click(object sender, EventArgs e)
        {
            string[] fileDaCifrare = listaFileDaCifrare.Items.Cast<string>().ToArray();
            string fileSingolo;
            File f;
            USB? usb = _presenter.SelectedUSB;
            int fcSuccesso = 0;
            int fcFalliti = 0;
            int totFile = fileDaCifrare.Length;
            string[] falliti = new string[totFile];

            if (usb is not null)
            {
                for (int i = 0; i < fileDaCifrare.Length; i++)
                {
                    try
                    {
                        fileSingolo = fileDaCifrare[i].Trim();
                        f = new File(fileSingolo);
                        Key key = _presenter.Cifra(f);
                        _presenter.SalvaKey(key);
                    } catch (FileNotFoundException)
                    {
                        falliti[fcFalliti] = fileDaCifrare[i];
                        fcFalliti++;
                        continue;

                    } catch (SalveKeyException)
                    {
                        falliti[fcFalliti] = fileDaCifrare[i];
                        fcFalliti++;
                        continue;
                    }
                    fcSuccesso++;
                }
                listaFileDaCifrare.Items.Clear();
                MessageBox.Show($"Sono stati cifrati con successo {fcSuccesso} file su {totFile}.\n" +
                $"I seguenti {fcFalliti} file hanno avuto problemi:\n" +
                $"{Helper.elencaFileFalliti(falliti)}", "Operazione terminata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SelezionaUsb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomeUsb;
            USB usb;

            if (SelezionaUsb.SelectedItem is not null)
            {
                nomeUsb = (string)SelezionaUsb.SelectedItem;
                usb = new USB(nomeUsb);
                _presenter.SelezionaUSB(usb);
            }
        }

        private void CifraFileView_Load(object sender, EventArgs e)
        {
            var tutteUsb = _presenter.ElencaDispositiviEsterni();
            string[] nomiUsb = new string[tutteUsb.Length];
            for (int i = 0; i < tutteUsb.Length; i++)
            {
                nomiUsb[i] = tutteUsb[i].Name;
            }

            this.SelezionaUsb.DataSource = nomiUsb;

            this.listaFileDaCifrare.Items.Clear();

            this.SelezionaUsb_SelectedIndexChanged(sender, e);
        }

        private void Aggiorna_Click(object sender, EventArgs e)
        {
            var tutteUsb = _presenter.ElencaDispositiviEsterni();
            string[] nomiUsb = new string[tutteUsb.Length];
            for (int i = 0; i < tutteUsb.Length; i++)
            {
                nomiUsb[i] = tutteUsb[i].Name;
            }
            SelezionaUsb.DataSource = nomiUsb;

            SelezionaUsb_SelectedIndexChanged(sender, e);
        }
    }
}