﻿namespace UNIBO.SET.GUI.Forms
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Seleziona = new CustomControls.RJControls.RJButton2();
            this.Scan = new CustomControls.RJControls.RJButton2();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 27);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path chiave";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(49, 212);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(279, 164);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(491, 104);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(297, 190);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lista di USB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 311);
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
            this.Seleziona.Location = new System.Drawing.Point(346, 46);
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
            this.Scan.Location = new System.Drawing.Point(238, 394);
            this.Scan.Name = "Scan";
            this.Scan.Size = new System.Drawing.Size(90, 35);
            this.Scan.TabIndex = 7;
            this.Scan.Text = "Scan";
            this.Scan.TextColor = System.Drawing.Color.White;
            this.Scan.UseVisualStyleBackColor = false;
            // 
            // DecifraFileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(802, 467);
            this.Controls.Add(this.Scan);
            this.Controls.Add(this.Seleziona);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "DecifraFileView";
            this.Text = "Decifra File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Label label2;
        private Label label3;
        private CustomControls.RJControls.RJButton2 Seleziona;
        private CustomControls.RJControls.RJButton2 Scan;
    }
}