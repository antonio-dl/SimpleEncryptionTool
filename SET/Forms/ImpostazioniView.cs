using UNIBO.SET.Model;
using UNIBO.SET.Services.Presenters;

namespace UNIBO.SET.GUI.Forms
{
    public partial class ImpostazioniView : Form
    {
        private readonly GestioneImpECrededenzialiPresenter _presenter;

        public ImpostazioniView(GestioneImpECrededenzialiPresenter presenter)
        {
            _presenter = presenter;
            InitializeComponent();
        }

        private void CambioCredenziali_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (CambioCredenzialiView uu = new CambioCredenzialiView(_presenter))
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }

        private void ImpostazioniView_Load(object sender, EventArgs e)
        {
            var impost = _presenter.OttieniImpostazioneSingola("cifratore");

            this.SelezioneCifraturaBox.DataSource = impost.Opzioni;
            string selected = impost.Selezionato;
            SelezioneCifraturaBox.SelectedItem = selected;
        }

        private void Salva_Click(object sender, EventArgs e)
        {
            var imp = _presenter.OttieniImpostazioneSingola("cifratore");
            string selezionato = (string) SelezioneCifraturaBox.SelectedItem;

            if(_presenter.CambiaImpostazione(selezionato, imp))
            {
                var impost = _presenter.OttieniImpostazioni();
                _presenter.PersistiImpostazioni(impost);
            }
        }
    }
}