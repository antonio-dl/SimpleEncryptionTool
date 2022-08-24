namespace UNIBO.SET.GUI.Forms
{
    partial class ProgettazioneDeployment
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rjButton21 = new CustomControls.RJControls.RJButton2();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(89, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verifica degli aggiornamenti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Versione attuale:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ultima versione:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(296, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "sET-1.0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(296, 201);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "sET-1.1";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rjButton21
            // 
            this.rjButton21.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton21.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton21.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton21.BorderRadius = 25;
            this.rjButton21.BorderSize = 0;
            this.rjButton21.FlatAppearance.BorderSize = 0;
            this.rjButton21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton21.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rjButton21.ForeColor = System.Drawing.Color.White;
            this.rjButton21.Location = new System.Drawing.Point(203, 264);
            this.rjButton21.Name = "rjButton21";
            this.rjButton21.Size = new System.Drawing.Size(188, 50);
            this.rjButton21.TabIndex = 5;
            this.rjButton21.Text = "AGGIORNA";
            this.rjButton21.TextColor = System.Drawing.Color.White;
            this.rjButton21.UseVisualStyleBackColor = false;
            // 
            // ProgettazioneDeployment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(607, 416);
            this.Controls.Add(this.rjButton21);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProgettazioneDeployment";
            this.Text = "ProgettazioneDeployment";
            this.Load += new System.EventHandler(this.ProgettazioneDeployment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private CustomControls.RJControls.RJButton2 rjButton21;
    }
}