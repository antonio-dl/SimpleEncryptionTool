namespace UNIBO.SET.GUI.Forms
{
    partial class DecifraFileView
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
            this.PathChiaveBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SelezionaPathBottone = new CustomControls.RJControls.RJButton2();
            this.ScanBottone = new CustomControls.RJControls.RJButton2();
            this.ListaUsbBox = new System.Windows.Forms.ComboBox();
            this.Decifra = new CustomControls.RJControls.RJButton2();
            this.listaFileDaDecifrare = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // PathChiaveBox
            // 
            this.PathChiaveBox.Location = new System.Drawing.Point(33, 32);
            this.PathChiaveBox.Name = "PathChiaveBox";
            this.PathChiaveBox.ReadOnly = true;
            this.PathChiaveBox.Size = new System.Drawing.Size(591, 27);
            this.PathChiaveBox.TabIndex = 0;
            this.PathChiaveBox.TextChanged += new System.EventHandler(this.PathChiaveBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path chiave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lista di USB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lista di file da decifrare";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // SelezionaPathBottone
            // 
            this.SelezionaPathBottone.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.SelezionaPathBottone.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.SelezionaPathBottone.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.SelezionaPathBottone.BorderRadius = 15;
            this.SelezionaPathBottone.BorderSize = 0;
            this.SelezionaPathBottone.FlatAppearance.BorderSize = 0;
            this.SelezionaPathBottone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelezionaPathBottone.ForeColor = System.Drawing.Color.White;
            this.SelezionaPathBottone.Location = new System.Drawing.Point(642, 24);
            this.SelezionaPathBottone.Name = "SelezionaPathBottone";
            this.SelezionaPathBottone.Size = new System.Drawing.Size(90, 35);
            this.SelezionaPathBottone.TabIndex = 6;
            this.SelezionaPathBottone.Text = "Seleziona";
            this.SelezionaPathBottone.TextColor = System.Drawing.Color.White;
            this.SelezionaPathBottone.UseVisualStyleBackColor = false;
            this.SelezionaPathBottone.Click += new System.EventHandler(this.Seleziona_Click);
            // 
            // ScanBottone
            // 
            this.ScanBottone.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ScanBottone.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.ScanBottone.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ScanBottone.BorderRadius = 15;
            this.ScanBottone.BorderSize = 0;
            this.ScanBottone.FlatAppearance.BorderSize = 0;
            this.ScanBottone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScanBottone.ForeColor = System.Drawing.Color.White;
            this.ScanBottone.Location = new System.Drawing.Point(237, 105);
            this.ScanBottone.Name = "ScanBottone";
            this.ScanBottone.Size = new System.Drawing.Size(90, 35);
            this.ScanBottone.TabIndex = 7;
            this.ScanBottone.Text = "Scan";
            this.ScanBottone.TextColor = System.Drawing.Color.White;
            this.ScanBottone.UseVisualStyleBackColor = false;
            this.ScanBottone.Click += new System.EventHandler(this.Scan_Click);
            // 
            // ListaUsbBox
            // 
            this.ListaUsbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListaUsbBox.FormattingEnabled = true;
            this.ListaUsbBox.Location = new System.Drawing.Point(33, 112);
            this.ListaUsbBox.Name = "ListaUsbBox";
            this.ListaUsbBox.Size = new System.Drawing.Size(191, 28);
            this.ListaUsbBox.TabIndex = 8;
            this.ListaUsbBox.SelectedIndexChanged += new System.EventHandler(this.ListaUsbBox_SelectedIndexChanged);
            // 
            // Decifra
            // 
            this.Decifra.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Decifra.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Decifra.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Decifra.BorderRadius = 15;
            this.Decifra.BorderSize = 0;
            this.Decifra.FlatAppearance.BorderSize = 0;
            this.Decifra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Decifra.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Decifra.ForeColor = System.Drawing.Color.White;
            this.Decifra.Location = new System.Drawing.Point(677, 409);
            this.Decifra.Name = "Decifra";
            this.Decifra.Size = new System.Drawing.Size(113, 44);
            this.Decifra.TabIndex = 9;
            this.Decifra.Text = "Decifra";
            this.Decifra.TextColor = System.Drawing.Color.White;
            this.Decifra.UseVisualStyleBackColor = false;
            this.Decifra.Click += new System.EventHandler(this.Decifra_Click);
            // 
            // listaFileDaDecifrare
            // 
            this.listaFileDaDecifrare.FormattingEnabled = true;
            this.listaFileDaDecifrare.ItemHeight = 20;
            this.listaFileDaDecifrare.Items.AddRange(new object[] {
            "Lista dei File da decifrare"});
            this.listaFileDaDecifrare.Location = new System.Drawing.Point(33, 209);
            this.listaFileDaDecifrare.Name = "listaFileDaDecifrare";
            this.listaFileDaDecifrare.Size = new System.Drawing.Size(638, 244);
            this.listaFileDaDecifrare.TabIndex = 10;
            this.listaFileDaDecifrare.SelectedIndexChanged += new System.EventHandler(this.listaFileDaDecifrare_SelectedIndexChanged);
            // 
            // DecifraFileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(802, 467);
            this.Controls.Add(this.listaFileDaDecifrare);
            this.Controls.Add(this.Decifra);
            this.Controls.Add(this.ListaUsbBox);
            this.Controls.Add(this.ScanBottone);
            this.Controls.Add(this.SelezionaPathBottone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PathChiaveBox);
            this.Name = "DecifraFileView";
            this.Text = "Decifra File";
            this.Load += new System.EventHandler(this.DecifraFileView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox PathChiaveBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private CustomControls.RJControls.RJButton2 SelezionaPathBottone;
        private CustomControls.RJControls.RJButton2 ScanBottone;
        private ComboBox ListaUsbBox;
        private CustomControls.RJControls.RJButton2 Decifra;
        private ListBox listaFileDaDecifrare;
    }
}