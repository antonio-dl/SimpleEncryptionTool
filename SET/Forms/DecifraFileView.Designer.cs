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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Seleziona = new CustomControls.RJControls.RJButton2();
            this.Scan = new CustomControls.RJControls.RJButton2();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Decifra = new CustomControls.RJControls.RJButton2();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(591, 27);
            this.textBox1.TabIndex = 0;
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
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(33, 215);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(630, 240);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lista di USB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lista di file da decifrare";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Seleziona
            // 
            this.Seleziona.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Seleziona.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Seleziona.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Seleziona.BorderRadius = 15;
            this.Seleziona.BorderSize = 0;
            this.Seleziona.FlatAppearance.BorderSize = 0;
            this.Seleziona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Seleziona.ForeColor = System.Drawing.Color.White;
            this.Seleziona.Location = new System.Drawing.Point(642, 24);
            this.Seleziona.Name = "Seleziona";
            this.Seleziona.Size = new System.Drawing.Size(90, 35);
            this.Seleziona.TabIndex = 6;
            this.Seleziona.Text = "Seleziona";
            this.Seleziona.TextColor = System.Drawing.Color.White;
            this.Seleziona.UseVisualStyleBackColor = false;
            // 
            // Scan
            // 
            this.Scan.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Scan.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Scan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Scan.BorderRadius = 15;
            this.Scan.BorderSize = 0;
            this.Scan.FlatAppearance.BorderSize = 0;
            this.Scan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Scan.ForeColor = System.Drawing.Color.White;
            this.Scan.Location = new System.Drawing.Point(237, 105);
            this.Scan.Name = "Scan";
            this.Scan.Size = new System.Drawing.Size(90, 35);
            this.Scan.TabIndex = 7;
            this.Scan.Text = "Scan";
            this.Scan.TextColor = System.Drawing.Color.White;
            this.Scan.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(33, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 28);
            this.comboBox1.TabIndex = 8;
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
            this.Decifra.Location = new System.Drawing.Point(677, 410);
            this.Decifra.Name = "Decifra";
            this.Decifra.Size = new System.Drawing.Size(113, 44);
            this.Decifra.TabIndex = 9;
            this.Decifra.Text = "Decifra";
            this.Decifra.TextColor = System.Drawing.Color.White;
            this.Decifra.UseVisualStyleBackColor = false;
            // 
            // DecifraFileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(802, 467);
            this.Controls.Add(this.Decifra);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Scan);
            this.Controls.Add(this.Seleziona);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "DecifraFileView";
            this.Text = "Decifra File";
            this.Load += new System.EventHandler(this.DecifraFileView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private RichTextBox richTextBox2;
        private Label label2;
        private Label label3;
        private CustomControls.RJControls.RJButton2 Seleziona;
        private CustomControls.RJControls.RJButton2 Scan;
        private ComboBox comboBox1;
        private CustomControls.RJControls.RJButton2 Decifra;
    }
}