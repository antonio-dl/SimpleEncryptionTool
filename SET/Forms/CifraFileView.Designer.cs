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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Aggiungi = new CustomControls.RJControls.RJButton2();
            this.Rimuovi = new CustomControls.RJControls.RJButton2();
            this.Cifra = new CustomControls.RJControls.RJButton2();
            this.SelezionaUsb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(41, 50);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(679, 257);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Aggiungi
            // 
            this.Aggiungi.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Aggiungi.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Aggiungi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Aggiungi.BorderRadius = 15;
            this.Aggiungi.BorderSize = 0;
            this.Aggiungi.FlatAppearance.BorderSize = 0;
            this.Aggiungi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aggiungi.ForeColor = System.Drawing.Color.White;
            this.Aggiungi.Location = new System.Drawing.Point(41, 313);
            this.Aggiungi.Name = "Aggiungi";
            this.Aggiungi.Size = new System.Drawing.Size(90, 35);
            this.Aggiungi.TabIndex = 1;
            this.Aggiungi.Text = "Aggiungi";
            this.Aggiungi.TextColor = System.Drawing.Color.White;
            this.Aggiungi.UseVisualStyleBackColor = false;
            this.Aggiungi.Click += new System.EventHandler(this.Aggiungi_Click);
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
            this.Rimuovi.Location = new System.Drawing.Point(137, 313);
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
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "File da cifrare";
            // 
            // CifraFileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(802, 467);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelezionaUsb);
            this.Controls.Add(this.Cifra);
            this.Controls.Add(this.Rimuovi);
            this.Controls.Add(this.Aggiungi);
            this.Controls.Add(this.richTextBox1);
            this.Name = "CifraFileView";
            this.Text = "Cifra File";
            this.Load += new System.EventHandler(this.CifraFileView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private CustomControls.RJControls.RJButton2 Aggiungi;
        private CustomControls.RJControls.RJButton2 Rimuovi;
        private CustomControls.RJControls.RJButton2 Cifra;
        private ComboBox SelezionaUsb;
        private Label label1;
    }
}