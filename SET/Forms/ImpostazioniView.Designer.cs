namespace UNIBO.SET.GUI.Forms
{
    partial class ImpostazioniView
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
            this.label1 = new System.Windows.Forms.Label();
            this.SelezioneCifraturaBox = new System.Windows.Forms.ComboBox();
            this.CambioCredenziali = new CustomControls.RJControls.RJButton2();
            this.Salva = new CustomControls.RJControls.RJButton2();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selezione impostazione di cifratura";
            // 
            // SelezioneCifraturaBox
            // 
            this.SelezioneCifraturaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelezioneCifraturaBox.FormattingEnabled = true;
            this.SelezioneCifraturaBox.Location = new System.Drawing.Point(39, 72);
            this.SelezioneCifraturaBox.Name = "SelezioneCifraturaBox";
            this.SelezioneCifraturaBox.Size = new System.Drawing.Size(286, 28);
            this.SelezioneCifraturaBox.TabIndex = 1;
            // 
            // CambioCredenziali
            // 
            this.CambioCredenziali.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.CambioCredenziali.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.CambioCredenziali.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.CambioCredenziali.BorderRadius = 15;
            this.CambioCredenziali.BorderSize = 0;
            this.CambioCredenziali.FlatAppearance.BorderSize = 0;
            this.CambioCredenziali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CambioCredenziali.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CambioCredenziali.ForeColor = System.Drawing.Color.White;
            this.CambioCredenziali.Location = new System.Drawing.Point(39, 168);
            this.CambioCredenziali.Name = "CambioCredenziali";
            this.CambioCredenziali.Size = new System.Drawing.Size(292, 60);
            this.CambioCredenziali.TabIndex = 2;
            this.CambioCredenziali.Text = "Cambio credenziali di accesso";
            this.CambioCredenziali.TextColor = System.Drawing.Color.White;
            this.CambioCredenziali.UseVisualStyleBackColor = false;
            this.CambioCredenziali.Click += new System.EventHandler(this.CambioCredenziali_Click);
            // 
            // Salva
            // 
            this.Salva.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Salva.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Salva.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Salva.BorderRadius = 15;
            this.Salva.BorderSize = 0;
            this.Salva.FlatAppearance.BorderSize = 0;
            this.Salva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salva.ForeColor = System.Drawing.Color.White;
            this.Salva.Location = new System.Drawing.Point(666, 411);
            this.Salva.Name = "Salva";
            this.Salva.Size = new System.Drawing.Size(113, 44);
            this.Salva.TabIndex = 3;
            this.Salva.Text = "Salva";
            this.Salva.TextColor = System.Drawing.Color.White;
            this.Salva.UseVisualStyleBackColor = false;
            this.Salva.Click += new System.EventHandler(this.Salva_Click);
            // 
            // ImpostazioniView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(802, 467);
            this.Controls.Add(this.Salva);
            this.Controls.Add(this.CambioCredenziali);
            this.Controls.Add(this.SelezioneCifraturaBox);
            this.Controls.Add(this.label1);
            this.Name = "ImpostazioniView";
            this.Text = "Impostazioni";
            this.Load += new System.EventHandler(this.ImpostazioniView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox SelezioneCifraturaBox;
        private CustomControls.RJControls.RJButton2 CambioCredenziali;
        private CustomControls.RJControls.RJButton2 Salva;
    }
}