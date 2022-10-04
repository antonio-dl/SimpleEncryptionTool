namespace UNIBO.SET.GUI.Forms

{
    partial class CifraFileView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AggiungiFile = new CustomControls.RJControls.RJButton2();
            this.Rimuovi = new CustomControls.RJControls.RJButton2();
            this.Cifra = new CustomControls.RJControls.RJButton2();
            this.SelezionaUsb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AggiungiCartella = new CustomControls.RJControls.RJButton2();
            this.listaFileDaCifrare = new System.Windows.Forms.ListBox();
            this.Aggiorna = new CustomControls.RJControls.RJButton2();
            this.SuspendLayout();
            // 
            // AggiungiFile
            // 
            this.AggiungiFile.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.AggiungiFile.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.AggiungiFile.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AggiungiFile.BorderRadius = 15;
            this.AggiungiFile.BorderSize = 0;
            this.AggiungiFile.FlatAppearance.BorderSize = 0;
            this.AggiungiFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AggiungiFile.ForeColor = System.Drawing.Color.White;
            this.AggiungiFile.Location = new System.Drawing.Point(41, 313);
            this.AggiungiFile.Name = "AggiungiFile";
            this.AggiungiFile.Size = new System.Drawing.Size(118, 35);
            this.AggiungiFile.TabIndex = 1;
            this.AggiungiFile.Text = "Aggiungi file";
            this.AggiungiFile.TextColor = System.Drawing.Color.White;
            this.AggiungiFile.UseVisualStyleBackColor = false;
            this.AggiungiFile.Click += new System.EventHandler(this.AggiungiFile_Click);
            // 
            // Rimuovi
            // 
            this.Rimuovi.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Rimuovi.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Rimuovi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Rimuovi.BorderRadius = 15;
            this.Rimuovi.BorderSize = 0;
            this.Rimuovi.FlatAppearance.BorderSize = 0;
            this.Rimuovi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rimuovi.ForeColor = System.Drawing.Color.White;
            this.Rimuovi.Location = new System.Drawing.Point(307, 313);
            this.Rimuovi.Name = "Rimuovi";
            this.Rimuovi.Size = new System.Drawing.Size(90, 35);
            this.Rimuovi.TabIndex = 2;
            this.Rimuovi.Text = "Rimuovi";
            this.Rimuovi.TextColor = System.Drawing.Color.White;
            this.Rimuovi.UseVisualStyleBackColor = false;
            this.Rimuovi.Click += new System.EventHandler(this.Rimuovi_Click);
            // 
            // Cifra
            // 
            this.Cifra.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Cifra.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Cifra.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Cifra.BorderRadius = 15;
            this.Cifra.BorderSize = 0;
            this.Cifra.FlatAppearance.BorderSize = 0;
            this.Cifra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cifra.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cifra.ForeColor = System.Drawing.Color.White;
            this.Cifra.Location = new System.Drawing.Point(677, 410);
            this.Cifra.Name = "Cifra";
            this.Cifra.Size = new System.Drawing.Size(113, 44);
            this.Cifra.TabIndex = 3;
            this.Cifra.Text = "Cifra";
            this.Cifra.TextColor = System.Drawing.Color.White;
            this.Cifra.UseVisualStyleBackColor = false;
            this.Cifra.Click += new System.EventHandler(this.Cifra_Click);
            // 
            // SelezionaUsb
            // 
            this.SelezionaUsb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelezionaUsb.FormattingEnabled = true;
            this.SelezionaUsb.Location = new System.Drawing.Point(41, 373);
            this.SelezionaUsb.Name = "SelezionaUsb";
            this.SelezionaUsb.Size = new System.Drawing.Size(186, 28);
            this.SelezionaUsb.TabIndex = 4;
            this.SelezionaUsb.SelectedIndexChanged += new System.EventHandler(this.SelezionaUsb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "File da cifrare";
            // 
            // AggiungiCartella
            // 
            this.AggiungiCartella.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.AggiungiCartella.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.AggiungiCartella.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AggiungiCartella.BorderRadius = 15;
            this.AggiungiCartella.BorderSize = 0;
            this.AggiungiCartella.FlatAppearance.BorderSize = 0;
            this.AggiungiCartella.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AggiungiCartella.ForeColor = System.Drawing.Color.White;
            this.AggiungiCartella.Location = new System.Drawing.Point(165, 313);
            this.AggiungiCartella.Name = "AggiungiCartella";
            this.AggiungiCartella.Size = new System.Drawing.Size(136, 35);
            this.AggiungiCartella.TabIndex = 6;
            this.AggiungiCartella.Text = "Aggiungi cartella";
            this.AggiungiCartella.TextColor = System.Drawing.Color.White;
            this.AggiungiCartella.UseVisualStyleBackColor = false;
            this.AggiungiCartella.Click += new System.EventHandler(this.AggiungiCartella_Click);
            // 
            // listaFileDaCifrare
            // 
            this.listaFileDaCifrare.FormattingEnabled = true;
            this.listaFileDaCifrare.ItemHeight = 20;
            this.listaFileDaCifrare.Items.AddRange(new object[] {
            "PathFileKeyChain dei File da cifrare"});
            this.listaFileDaCifrare.Location = new System.Drawing.Point(41, 46);
            this.listaFileDaCifrare.Name = "listaFileDaCifrare";
            this.listaFileDaCifrare.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listaFileDaCifrare.Size = new System.Drawing.Size(680, 264);
            this.listaFileDaCifrare.TabIndex = 7;
            this.listaFileDaCifrare.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Aggiorna
            // 
            this.Aggiorna.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Aggiorna.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Aggiorna.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Aggiorna.BorderRadius = 15;
            this.Aggiorna.BorderSize = 0;
            this.Aggiorna.FlatAppearance.BorderSize = 0;
            this.Aggiorna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aggiorna.ForeColor = System.Drawing.Color.White;
            this.Aggiorna.Location = new System.Drawing.Point(246, 369);
            this.Aggiorna.Name = "Aggiorna";
            this.Aggiorna.Size = new System.Drawing.Size(90, 35);
            this.Aggiorna.TabIndex = 0;
            this.Aggiorna.Text = "Aggiorna";
            this.Aggiorna.TextColor = System.Drawing.Color.White;
            this.Aggiorna.UseVisualStyleBackColor = false;
            this.Aggiorna.Click += new System.EventHandler(this.Aggiorna_Click);
            // 
            // CifraFileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(802, 467);
            this.Controls.Add(this.Aggiorna);
            this.Controls.Add(this.listaFileDaCifrare);
            this.Controls.Add(this.AggiungiCartella);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelezionaUsb);
            this.Controls.Add(this.Cifra);
            this.Controls.Add(this.Rimuovi);
            this.Controls.Add(this.AggiungiFile);
            this.Name = "CifraFileView";
            this.Text = "Cifra File";
            this.Load += new System.EventHandler(this.CifraFileView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.RJControls.RJButton2 AggiungiFile;
        private CustomControls.RJControls.RJButton2 Rimuovi;
        private CustomControls.RJControls.RJButton2 Cifra;
        private ComboBox SelezionaUsb;
        private Label label1;
        private CustomControls.RJControls.RJButton2 AggiungiCartella;
        private ListBox listaFileDaCifrare;
        private CustomControls.RJControls.RJButton2 Aggiorna;
    }
}