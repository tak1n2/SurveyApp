namespace SurveyApp
{
    partial class RegistratrionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistratrionForm));
            btnRgstr = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            linkLabel1 = new LinkLabel();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // btnRgstr
            // 
            btnRgstr.Cursor = Cursors.Hand;
            btnRgstr.Font = new Font("Trebuchet MS", 20F);
            btnRgstr.Location = new Point(249, 231);
            btnRgstr.Margin = new Padding(5);
            btnRgstr.Name = "btnRgstr";
            btnRgstr.Size = new Size(275, 62);
            btnRgstr.TabIndex = 0;
            btnRgstr.Text = "Register";
            btnRgstr.UseVisualStyleBackColor = true;
            btnRgstr.Click += btnRgstr_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Snow;
            textBox1.Cursor = Cursors.Hand;
            textBox1.Font = new Font("Segoe UI", 24F);
            textBox1.ForeColor = SystemColors.InactiveCaptionText;
            textBox1.Location = new Point(76, 42);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Login";
            textBox1.Size = new Size(632, 50);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Snow;
            textBox2.Cursor = Cursors.Hand;
            textBox2.Font = new Font("Segoe UI", 24F);
            textBox2.ForeColor = SystemColors.InactiveCaptionText;
            textBox2.Location = new Point(76, 108);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(632, 50);
            textBox2.TabIndex = 2;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(271, 298);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(224, 24);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Already have an account?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Snow;
            textBox3.Cursor = Cursors.Hand;
            textBox3.Font = new Font("Segoe UI", 24F);
            textBox3.ForeColor = SystemColors.InactiveCaptionText;
            textBox3.Location = new Point(76, 173);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Confirm password";
            textBox3.Size = new Size(632, 50);
            textBox3.TabIndex = 4;
            // 
            // RegistratrionForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(805, 361);
            Controls.Add(textBox3);
            Controls.Add(linkLabel1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnRgstr);
            Font = new Font("Segoe UI", 14F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "RegistratrionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRgstr;
        private TextBox textBox1;
        private TextBox textBox2;
        private LinkLabel linkLabel1;
        private TextBox textBox3;
    }
}
