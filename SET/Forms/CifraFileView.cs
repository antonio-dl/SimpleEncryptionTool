using System.Collections;
using System.Diagnostics;
using UNIBO.SET.Model;
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

        private void AggiungiFile_Click(object sender, EventArgs e)
        {
            Process.Start("Explorer.exe");
            // questo qui sopra non va propriamente bene; guardare dal link qui sotto
            /* https://learn.microsoft.com/en-us/windows/uwp/files/quickstart-using-file-and-folder-pickers 
             https://stackoverflow.com/questions/4999734/how-to-add-browse-file-button-to-windows-form-using-c-sharp */
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

        private void AggiungiCartella_Click(object sender, EventArgs e)
        {

        }
    }
}