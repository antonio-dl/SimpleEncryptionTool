using System.Runtime.CompilerServices;
using UNIBO.SET.Model;
using UNIBO.SET.Services.Presenters;

namespace UNIBO.SET.GUI.Forms
{
    public partial class DecifraFileView : Form
    {
        private readonly GestioneDecifraturaPresenter _presenter;

        public DecifraFileView(GestioneDecifraturaPresenter presenter)
        {
            _presenter = presenter;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void DecifraFileView_Load(object sender, EventArgs e)
        {
            var tutteUsb = _presenter.ElencaDispositiviEsterni();
            ListaUsbBox.DataSource = tutteUsb;

            listaFileDaDecifrare.Items.Clear();
            PathChiaveBox.Clear();

            ListaUsbBox_SelectedIndexChanged(sender, e);
        }


        private void ListaUsbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomeUsb;
            USB usb;
            FileKeyChain? keyChain;

            if (ListaUsbBox.SelectedItem is not null)
            {
                nomeUsb = ListaUsbBox.SelectedItem.ToString();
                usb = new USB(nomeUsb);
                _presenter.SelezionaUSB(usb);

                if ((keyChain = _presenter.ScansionaUSB()) is not null)
                {
                    _presenter.SelezionaKeyChain(keyChain);
                    PathChiaveBox.Text = _presenter.SelectedKeyChain.ToString();
                }
            }
        }

        private void Seleziona_Click(object sender, EventArgs e)
        {
            var pathPicker = new System.Windows.Forms.OpenFileDialog();
            if (pathPicker.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string pathSelezionato = pathPicker.FileName;
                if (!pathSelezionato.Equals(""))
                {
                    PathChiaveBox.Clear();
                    PathChiaveBox.Text = pathSelezionato;
                }
            }
        }

        private void Scan_Click(object sender, EventArgs e)
        {
            var tutteUsb = _presenter.ElencaDispositiviEsterni();
            ListaUsbBox.DataSource = tutteUsb;

            ListaUsbBox_SelectedIndexChanged(sender, e);
        }

        private void Decifra_Click(object sender, EventArgs e)
        {
            var listaPathDaDecifrare = listaFileDaDecifrare.Items.Cast<string>();

            foreach (string path in listaPathDaDecifrare)
            {
                Key key = _presenter.SelectedKeyChain.SelectKey(path);
                FileDecifrato fd = _presenter.Decifra(key);

                _presenter.SelectedKeyChain.DeleteKey(key);

            }

            _presenter.SalvaKeyChain(_presenter.SelectedKeyChain);


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void OttieniFDBottone_Click(object sender, EventArgs e)
        {
            KeyChain keychain = _presenter.SelectedKeyChain;
            if (keychain is null)
            {
                ///MessageBox.Show(); //logica per errore
                return;
            }

            this.listaFileDaDecifrare.Items.Clear();
            foreach (Key key in keychain.GetAllKey())
            {
                if (System.IO.File.Exists(key.TargetFilePath))
                    this.listaFileDaDecifrare.Items.Add(key.TargetFilePath);

            }
        }
    }
}