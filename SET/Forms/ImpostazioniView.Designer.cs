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
            this.rjButton21 = new CustomControls.RJControls.RJButton2();
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
            this.comboBox1.Location = new System.Drawing.Point(311, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // rjButton21
            // 
            this.rjButton21.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton21.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton21.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton21.BorderRadius = 15;
            this.rjButton21.BorderSize = 0;
            this.rjButton21.FlatAppearance.BorderSize = 0;
            this.rjButton21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton21.ForeColor = System.Drawing.Color.White;
            this.rjButton21.Location = new System.Drawing.Point(39, 127);
            this.rjButton21.Name = "rjButton21";
            this.rjButton21.Size = new System.Drawing.Size(150, 60);
            this.rjButton21.TabIndex = 2;
            this.rjButton21.Text = "Cambio credenziali di accesso";
            this.rjButton21.TextColor = System.Drawing.Color.White;
            this.rjButton21.UseVisualStyleBackColor = false;
            this.rjButton21.Click += new System.EventHandler(this.rjButton21_Click);
            // 
            // ImpostazioniView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(802, 467);
            this.Controls.Add(this.rjButton21);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "ImpostazioniView";
            this.Text = "Impostazioni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private CustomControls.RJControls.RJButton2 rjButton21;
    }
}