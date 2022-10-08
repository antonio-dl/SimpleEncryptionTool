namespace UNIBO.SET.GUI

{
    partial class HomeSET
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeSET));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LogRadioButton = new CustomControls.RJControls.RJButton();
            this.ImpostazioniRadioButton = new CustomControls.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.DecifraRadioButton = new CustomControls.RJControls.RJButton();
            this.CifraRadioButton = new CustomControls.RJControls.RJButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 653);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 599);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marco Esopi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 568);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giacomo Grilli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 538);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Antonio De Luca";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 139);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 124);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleGreen;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(162, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(820, 139);
            this.panel3.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LogRadioButton);
            this.groupBox1.Controls.Add(this.ImpostazioniRadioButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DecifraRadioButton);
            this.groupBox1.Controls.Add(this.CifraRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(51, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navigazione";
            // 
            // LogRadioButton
            // 
            this.LogRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.LogRadioButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.LogRadioButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.LogRadioButton.BorderColor = System.Drawing.Color.Black;
            this.LogRadioButton.BorderRadius = 15;
            this.LogRadioButton.BorderSize = 2;
            this.LogRadioButton.FlatAppearance.BorderSize = 0;
            this.LogRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogRadioButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogRadioButton.ForeColor = System.Drawing.Color.White;
            this.LogRadioButton.Location = new System.Drawing.Point(514, 41);
            this.LogRadioButton.Name = "LogRadioButton";
            this.LogRadioButton.Size = new System.Drawing.Size(140, 60);
            this.LogRadioButton.TabIndex = 3;
            this.LogRadioButton.Text = "Log";
            this.LogRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogRadioButton.TextColor = System.Drawing.Color.White;
            this.LogRadioButton.UseVisualStyleBackColor = false;
            this.LogRadioButton.CheckedChanged += new System.EventHandler(this.LogRadioButton_CheckedChanged);
            // 
            // ImpostazioniRadioButton
            // 
            this.ImpostazioniRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.ImpostazioniRadioButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ImpostazioniRadioButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.ImpostazioniRadioButton.BorderColor = System.Drawing.Color.Black;
            this.ImpostazioniRadioButton.BorderRadius = 15;
            this.ImpostazioniRadioButton.BorderSize = 2;
            this.ImpostazioniRadioButton.FlatAppearance.BorderSize = 0;
            this.ImpostazioniRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImpostazioniRadioButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ImpostazioniRadioButton.ForeColor = System.Drawing.Color.White;
            this.ImpostazioniRadioButton.Location = new System.Drawing.Point(345, 41);
            this.ImpostazioniRadioButton.Name = "ImpostazioniRadioButton";
            this.ImpostazioniRadioButton.Size = new System.Drawing.Size(140, 60);
            this.ImpostazioniRadioButton.TabIndex = 2;
            this.ImpostazioniRadioButton.Text = "Impostazioni";
            this.ImpostazioniRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ImpostazioniRadioButton.TextColor = System.Drawing.Color.White;
            this.ImpostazioniRadioButton.UseVisualStyleBackColor = false;
            this.ImpostazioniRadioButton.CheckedChanged += new System.EventHandler(this.ImpostazioniRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(234, -17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 58);
            this.label1.TabIndex = 4;
            this.label1.Text = "HOME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DecifraRadioButton
            // 
            this.DecifraRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.DecifraRadioButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.DecifraRadioButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.DecifraRadioButton.BorderColor = System.Drawing.Color.Black;
            this.DecifraRadioButton.BorderRadius = 15;
            this.DecifraRadioButton.BorderSize = 2;
            this.DecifraRadioButton.FlatAppearance.BorderSize = 0;
            this.DecifraRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecifraRadioButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DecifraRadioButton.ForeColor = System.Drawing.Color.White;
            this.DecifraRadioButton.Location = new System.Drawing.Point(182, 41);
            this.DecifraRadioButton.Name = "DecifraRadioButton";
            this.DecifraRadioButton.Size = new System.Drawing.Size(140, 60);
            this.DecifraRadioButton.TabIndex = 1;
            this.DecifraRadioButton.Text = "Decifra File";
            this.DecifraRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DecifraRadioButton.TextColor = System.Drawing.Color.White;
            this.DecifraRadioButton.UseVisualStyleBackColor = false;
            this.DecifraRadioButton.CheckedChanged += new System.EventHandler(this.DecifraRadioButton_CheckedChanged);
            // 
            // CifraRadioButton
            // 
            this.CifraRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.CifraRadioButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.CifraRadioButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.CifraRadioButton.BorderColor = System.Drawing.Color.Black;
            this.CifraRadioButton.BorderRadius = 15;
            this.CifraRadioButton.BorderSize = 2;
            this.CifraRadioButton.FlatAppearance.BorderSize = 0;
            this.CifraRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CifraRadioButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CifraRadioButton.ForeColor = System.Drawing.Color.White;
            this.CifraRadioButton.Location = new System.Drawing.Point(20, 41);
            this.CifraRadioButton.Name = "CifraRadioButton";
            this.CifraRadioButton.Size = new System.Drawing.Size(140, 60);
            this.CifraRadioButton.TabIndex = 0;
            this.CifraRadioButton.Text = "Cifra File";
            this.CifraRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CifraRadioButton.TextColor = System.Drawing.Color.White;
            this.CifraRadioButton.UseVisualStyleBackColor = false;
            this.CifraRadioButton.CheckedChanged += new System.EventHandler(this.CifraRadioButton_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(162, 139);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(820, 514);
            this.panel4.TabIndex = 2;
            // 
            // HomeSET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeSET";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private GroupBox groupBox1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Label label1;
        private CustomControls.RJControls.RJButton LogRadioButton;
        private CustomControls.RJControls.RJButton ImpostazioniRadioButton;
        private CustomControls.RJControls.RJButton DecifraRadioButton;
        private CustomControls.RJControls.RJButton CifraRadioButton;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}