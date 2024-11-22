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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            tbLogin = new TextBox();
            tbPasswrod = new TextBox();
            btnLogin = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // tbLogin
            // 
            tbLogin.BackColor = Color.Snow;
            tbLogin.Cursor = Cursors.Hand;
            tbLogin.Font = new Font("Segoe UI", 24F);
            tbLogin.ForeColor = SystemColors.InactiveCaptionText;
            tbLogin.Location = new Point(68, 33);
            tbLogin.Name = "tbLogin";
            tbLogin.PlaceholderText = "Login";
            tbLogin.Size = new Size(632, 50);
            tbLogin.TabIndex = 2;
            // 
            // tbPasswrod
            // 
            tbPasswrod.BackColor = Color.Snow;
            tbPasswrod.Cursor = Cursors.Hand;
            tbPasswrod.Font = new Font("Segoe UI", 24F);
            tbPasswrod.ForeColor = SystemColors.InactiveCaptionText;
            tbPasswrod.Location = new Point(68, 100);
            tbPasswrod.Name = "tbPasswrod";
            tbPasswrod.PasswordChar = '*';
            tbPasswrod.PlaceholderText = "Password";
            tbPasswrod.Size = new Size(632, 50);
            tbPasswrod.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Trebuchet MS", 20F);
            btnLogin.Location = new Point(242, 168);
            btnLogin.Margin = new Padding(5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(275, 62);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnRgstr_Click;
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
            ClientSize = new Size(779, 285);
            Controls.Add(linkLabel1);
            Controls.Add(btnLogin);
            Controls.Add(tbPasswrod);
            Controls.Add(tbLogin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbLogin;
        private TextBox tbPasswrod;
        private Button btnLogin;
        private LinkLabel linkLabel1;
    }
}