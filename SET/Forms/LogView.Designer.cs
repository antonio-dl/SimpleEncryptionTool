namespace UNIBO.SET.GUI.Forms
{
    partial class LogView
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
            this.LogBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TipoBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(49, 130);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(687, 274);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // LogBox
            // 
            this.LogBox.FormattingEnabled = true;
            this.LogBox.Location = new System.Drawing.Point(49, 57);
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(206, 28);
            this.LogBox.TabIndex = 1;
            this.LogBox.SelectedIndexChanged += new System.EventHandler(this.LogBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Log";
            // 
            // TipoBox
            // 
            this.TipoBox.FormattingEnabled = true;
            this.TipoBox.Location = new System.Drawing.Point(358, 57);
            this.TipoBox.Name = "TipoBox";
            this.TipoBox.Size = new System.Drawing.Size(206, 28);
            this.TipoBox.TabIndex = 4;
            this.TipoBox.SelectedIndexChanged += new System.EventHandler(this.TipoBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo di operazione";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // LogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(802, 467);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TipoBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.richTextBox1);
            this.Name = "LogView";
            this.Text = "Log";
            this.Load += new System.EventHandler(this.LogView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private ComboBox LogBox;
        private Label label1;
        private ComboBox TipoBox;
        private Label label3;
    }
}