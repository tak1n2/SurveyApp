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
            tbLogin = new TextBox();
            tbPsw = new TextBox();
            linkLabel1 = new LinkLabel();
            tbPswConfirm = new TextBox();
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
            // tbLogin
            // 
            tbLogin.BackColor = Color.Snow;
            tbLogin.Cursor = Cursors.Hand;
            tbLogin.Font = new Font("Segoe UI", 24F);
            tbLogin.ForeColor = SystemColors.InactiveCaptionText;
            tbLogin.Location = new Point(76, 42);
            tbLogin.Name = "tbLogin";
            tbLogin.PlaceholderText = "Login";
            tbLogin.Size = new Size(632, 50);
            tbLogin.TabIndex = 1;
            // 
            // tbPsw
            // 
            tbPsw.BackColor = Color.Snow;
            tbPsw.Cursor = Cursors.Hand;
            tbPsw.Font = new Font("Segoe UI", 24F);
            tbPsw.ForeColor = SystemColors.InactiveCaptionText;
            tbPsw.Location = new Point(76, 108);
            tbPsw.Name = "tbPsw";
            tbPsw.PasswordChar = '*';
            tbPsw.PlaceholderText = "Password";
            tbPsw.Size = new Size(632, 50);
            tbPsw.TabIndex = 2;
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
            // tbPswConfirm
            // 
            tbPswConfirm.BackColor = Color.Snow;
            tbPswConfirm.Cursor = Cursors.Hand;
            tbPswConfirm.Font = new Font("Segoe UI", 24F);
            tbPswConfirm.ForeColor = SystemColors.InactiveCaptionText;
            tbPswConfirm.Location = new Point(76, 173);
            tbPswConfirm.Name = "tbPswConfirm";
            tbPswConfirm.PasswordChar = '*';
            tbPswConfirm.PlaceholderText = "Confirm password";
            tbPswConfirm.Size = new Size(632, 50);
            tbPswConfirm.TabIndex = 4;
            // 
            // RegistratrionForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(805, 361);
            Controls.Add(tbPswConfirm);
            Controls.Add(linkLabel1);
            Controls.Add(tbPsw);
            Controls.Add(tbLogin);
            Controls.Add(btnRgstr);
            Font = new Font("Segoe UI", 14F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "RegistratrionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            Load += RegistratrionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRgstr;
        private TextBox tbLogin;
        private TextBox tbPsw;
        private LinkLabel linkLabel1;
        private TextBox tbPswConfirm;
    }
}
