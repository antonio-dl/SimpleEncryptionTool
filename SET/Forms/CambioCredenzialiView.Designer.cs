namespace UNIBO.SET.GUI.Forms
{
    partial class CambioCredenzialiView
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nuovaPw2 = new System.Windows.Forms.TextBox();
            this.nuovaPw = new System.Windows.Forms.TextBox();
            this.vecchiaPw = new System.Windows.Forms.TextBox();
            this.Annulla = new CustomControls.RJControls.RJButton2();
            this.Conferma = new CustomControls.RJControls.RJButton2();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserire vecchia password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inserire nuova password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ripetere nuova password";
            // 
            // nuovaPw2
            // 
            this.nuovaPw2.Location = new System.Drawing.Point(86, 225);
            this.nuovaPw2.Name = "nuovaPw2";
            this.nuovaPw2.Size = new System.Drawing.Size(125, 27);
            this.nuovaPw2.TabIndex = 3;
            // 
            // nuovaPw
            // 
            this.nuovaPw.Location = new System.Drawing.Point(85, 142);
            this.nuovaPw.Name = "nuovaPw";
            this.nuovaPw.Size = new System.Drawing.Size(125, 27);
            this.nuovaPw.TabIndex = 4;
            // 
            // vecchiaPw
            // 
            this.vecchiaPw.Location = new System.Drawing.Point(85, 58);
            this.vecchiaPw.Name = "vecchiaPw";
            this.vecchiaPw.Size = new System.Drawing.Size(125, 27);
            this.vecchiaPw.TabIndex = 5;
            // 
            // Annulla
            // 
            this.Annulla.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Annulla.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Annulla.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Annulla.BorderRadius = 15;
            this.Annulla.BorderSize = 0;
            this.Annulla.FlatAppearance.BorderSize = 0;
            this.Annulla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Annulla.ForeColor = System.Drawing.Color.White;
            this.Annulla.Location = new System.Drawing.Point(85, 278);
            this.Annulla.Name = "Annulla";
            this.Annulla.Size = new System.Drawing.Size(90, 35);
            this.Annulla.TabIndex = 6;
            this.Annulla.Text = "Annulla";
            this.Annulla.TextColor = System.Drawing.Color.White;
            this.Annulla.UseVisualStyleBackColor = false;
            this.Annulla.Click += new System.EventHandler(this.Annulla_Click);
            // 
            // Conferma
            // 
            this.Conferma.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Conferma.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Conferma.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Conferma.BorderRadius = 15;
            this.Conferma.BorderSize = 0;
            this.Conferma.FlatAppearance.BorderSize = 0;
            this.Conferma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Conferma.ForeColor = System.Drawing.Color.White;
            this.Conferma.Location = new System.Drawing.Point(304, 278);
            this.Conferma.Name = "Conferma";
            this.Conferma.Size = new System.Drawing.Size(90, 35);
            this.Conferma.TabIndex = 7;
            this.Conferma.Text = "Conferma";
            this.Conferma.TextColor = System.Drawing.Color.White;
            this.Conferma.UseVisualStyleBackColor = false;
            this.Conferma.Click += new System.EventHandler(this.Conferma_Click);
            // 
            // CambioCredenzialiView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(476, 392);
            this.Controls.Add(this.Conferma);
            this.Controls.Add(this.Annulla);
            this.Controls.Add(this.vecchiaPw);
            this.Controls.Add(this.nuovaPw);
            this.Controls.Add(this.nuovaPw2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CambioCredenzialiView";
            this.Text = "CambioCredenzialiView";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox nuovaPw2;
        private TextBox nuovaPw;
        private TextBox vecchiaPw;
        private CustomControls.RJControls.RJButton2 Annulla;
        private CustomControls.RJControls.RJButton2 Conferma;
    }
}