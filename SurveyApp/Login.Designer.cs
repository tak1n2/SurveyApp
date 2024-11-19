namespace SurveyApp
{
    partial class Login
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnRgstr = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Snow;
            textBox1.Cursor = Cursors.Hand;
            textBox1.Font = new Font("Segoe UI", 24F);
            textBox1.ForeColor = SystemColors.InactiveCaptionText;
            textBox1.Location = new Point(68, 33);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Login";
            textBox1.Size = new Size(632, 50);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Snow;
            textBox2.Cursor = Cursors.Hand;
            textBox2.Font = new Font("Segoe UI", 24F);
            textBox2.ForeColor = SystemColors.InactiveCaptionText;
            textBox2.Location = new Point(68, 100);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(632, 50);
            textBox2.TabIndex = 3;
            // 
            // btnRgstr
            // 
            btnRgstr.Cursor = Cursors.Hand;
            btnRgstr.Font = new Font("Trebuchet MS", 20F);
            btnRgstr.Location = new Point(242, 168);
            btnRgstr.Margin = new Padding(5);
            btnRgstr.Name = "btnRgstr";
            btnRgstr.Size = new Size(275, 62);
            btnRgstr.TabIndex = 4;
            btnRgstr.Text = "Login";
            btnRgstr.UseVisualStyleBackColor = true;
            btnRgstr.Click += btnRgstr_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(294, 235);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(164, 24);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create an account";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(800, 285);
            Controls.Add(linkLabel1);
            Controls.Add(btnRgstr);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnRgstr;
        private LinkLabel linkLabel1;
    }
}