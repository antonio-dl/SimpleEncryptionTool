namespace UNIBO.SET.GUI.Forms
{
    partial class FirstLoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstLoginView));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ripetiPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Registrati = new CustomControls.RJControls.RJButton2();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(106, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Benvenuto!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Crea una password per creare l\'account";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(205, 160);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(170, 27);
            this.Password.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Inserire password:";
            // 
            // ripetiPass
            // 
            this.ripetiPass.Location = new System.Drawing.Point(205, 204);
            this.ripetiPass.Name = "ripetiPass";
            this.ripetiPass.PasswordChar = '*';
            this.ripetiPass.Size = new System.Drawing.Size(170, 27);
            this.ripetiPass.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ripetere password:";
            // 
            // Registrati
            // 
            this.Registrati.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Registrati.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Registrati.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Registrati.BorderRadius = 15;
            this.Registrati.BorderSize = 0;
            this.Registrati.FlatAppearance.BorderSize = 0;
            this.Registrati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registrati.ForeColor = System.Drawing.Color.White;
            this.Registrati.Location = new System.Drawing.Point(352, 309);
            this.Registrati.Name = "Registrati";
            this.Registrati.Size = new System.Drawing.Size(110, 35);
            this.Registrati.TabIndex = 12;
            this.Registrati.Text = "Registrati";
            this.Registrati.TextColor = System.Drawing.Color.White;
            this.Registrati.UseVisualStyleBackColor = false;
            this.Registrati.Click += new System.EventHandler(this.Registrati_Click);
            // 
            // FirstLoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(474, 356);
            this.Controls.Add(this.Registrati);
            this.Controls.Add(this.ripetiPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FirstLoginView";
            this.Text = "FirstLoginView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Password;
        private Label label3;
        private TextBox ripetiPass;
        private Label label4;
        private CustomControls.RJControls.RJButton2 Registrati;
    }
}