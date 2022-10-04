﻿using UNIBO.SET.Model;
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
            string[] nomiUsb = new string[tutteUsb.Length];
            for (int i = 0; i < tutteUsb.Length; i++)
            {
                nomiUsb[i] = tutteUsb[i].Name;
            }
            ListaUsbBox.DataSource = nomiUsb;

            listaFileDaDecifrare.Items.Clear();
            PathChiaveBox.Clear();

            ListaUsbBox_SelectedIndexChanged(sender, e);
        }

        private void listaFileDaDecifrare_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PathChiaveBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListaUsbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomeUsb;
            USB usb;
            KeyChain? keyChain;

            if (ListaUsbBox.SelectedItem is not null)
            {
                nomeUsb = (string) ListaUsbBox.SelectedItem;
                usb = new USB(nomeUsb);
                _presenter.SelezionaUSB(usb);
                
                if((keyChain = _presenter.ScansionaUSB()) is not null)
                {
                    _presenter.SelezionaKeyChain(keyChain);
                    PathChiaveBox.Text = _presenter.SelectedKeyChain.ToString();
                }
                else
                    PathChiaveBox.Text = "sfsd";
                
            }
        }

        private void Seleziona_Click(object sender, EventArgs e)
        {
            var pathPicker = new System.Windows.Forms.OpenFileDialog();
            if (pathPicker.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string pathSelezionato = pathPicker.FileName;
                if(!pathSelezionato.Equals(""))
                {
                    PathChiaveBox.Clear();
                    PathChiaveBox.Text = pathSelezionato;
                }
            }
        }

        private void Scan_Click(object sender, EventArgs e)
        {
            var tutteUsb = _presenter.ElencaDispositiviEsterni();
            string[] nomiUsb = new string[tutteUsb.Length];
            for (int i = 0; i < tutteUsb.Length; i++)
            {
                nomiUsb[i] = tutteUsb[i].Name;
            }
            ListaUsbBox.DataSource = nomiUsb;

            ListaUsbBox_SelectedIndexChanged(sender, e);
        }

        private void Decifra_Click(object sender, EventArgs e)
        {

        }
    }
}