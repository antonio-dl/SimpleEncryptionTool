﻿using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using UNIBO.SET.Model;
using UNIBO.SET.Services.Presenters;
using UNIBO.SET.Services.Shared;

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

        private void DecifraFileView_Load(object sender, EventArgs e)
        {
            PathChiaveBox.Clear();
            listaFileDaDecifrare.Items.Clear();
            
            var tutteUsb = _presenter.ElencaDispositiviEsterni();
            ListaUsbBox.DataSource = tutteUsb;

            //ListaUsbBox_SelectedIndexChanged(sender, e);
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

            //ListaUsbBox_SelectedIndexChanged(sender, e);
        }

        private void Decifra_Click(object sender, EventArgs e)
        {
            var listaPathDaDecifrare = listaFileDaDecifrare.Items.Cast<string>();
            int fdSuccesso = 0;
            int fdFalliti = 0;
            int totFile = listaFileDaDecifrare.Items.Count;
            string[] falliti = new string[totFile];

            if (listaFileDaDecifrare.Items.Count > 0)
            {
                foreach (string path in listaPathDaDecifrare)
                {
                    try
                    {
                        Key key = _presenter.SelectedKeyChain.SelectKey(path);
                        FileDecifrato fd = _presenter.Decifra(key);
                        _presenter.SelectedKeyChain.DeleteKey(key);
                    }
                    catch (KeyNotFoundException)
                    {
                        falliti[fdFalliti] = path;
                        fdFalliti++;
                        continue;
                    }
                    catch (FileNotFoundException)
                    {
                        falliti[fdFalliti] = path;
                        fdFalliti++;
                        continue;
                    }
                    catch (IOException)
                    {
                        falliti[fdFalliti] = path;
                        fdFalliti++;
                        continue;
                    }
                    catch (CryptographicException)
                    {
                        falliti[fdFalliti] = path;
                        fdFalliti++;
                        continue;
                    }
                    fdSuccesso++;
                }

                _presenter.SalvaKeyChain(_presenter.SelectedKeyChain);
                this.listaFileDaDecifrare.Items.Clear();
                MessageBox.Show($"Sono stati decifrati con successo {fdSuccesso} file su {totFile}.\n" +
                    $"I seguenti {fdFalliti} file hanno avuto problemi:\n" +
                    $"{Helper.elencaFileFalliti(falliti)}", "Operazione terminata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show($"Non sono selezionati file da decifrare!", "Avviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void Rimuovi_Click(object sender, EventArgs e)
        {
            var selectedItems = listaFileDaDecifrare.SelectedItems;

            if (listaFileDaDecifrare.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    listaFileDaDecifrare.Items.Remove(selectedItems[i]);
            }
        }
    }
}