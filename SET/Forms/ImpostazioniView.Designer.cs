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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CambioCredenziali = new CustomControls.RJControls.RJButton2();
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(39, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(286, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // ImpostazioniView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(802, 467);
            this.Controls.Add(this.CambioCredenziali);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "ImpostazioniView";
            this.Text = "Impostazioni";
            this.Load += new System.EventHandler(this.ImpostazioniView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private CustomControls.RJControls.RJButton2 CambioCredenziali;
    }
}