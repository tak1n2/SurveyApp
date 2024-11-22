namespace SurveyApp
{
    partial class AdminGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminGUI));
            btnCreateVote = new Button();
            AdminPanel = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            textBox2 = new TextBox();
            AdminPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnCreateVote
            // 
            btnCreateVote.BackColor = Color.Black;
            btnCreateVote.Cursor = Cursors.Hand;
            btnCreateVote.FlatStyle = FlatStyle.Flat;
            btnCreateVote.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateVote.ForeColor = SystemColors.ButtonFace;
            btnCreateVote.Location = new Point(159, 540);
            btnCreateVote.Name = "btnCreateVote";
            btnCreateVote.Size = new Size(260, 63);
            btnCreateVote.TabIndex = 0;
            btnCreateVote.Text = "Create Vote";
            btnCreateVote.UseVisualStyleBackColor = true;
            // 
            // AdminPanel
            // 
            AdminPanel.Controls.Add(textBox2);
            AdminPanel.Controls.Add(label3);
            AdminPanel.Controls.Add(numericUpDown1);
            AdminPanel.Controls.Add(label2);
            AdminPanel.Controls.Add(label1);
            AdminPanel.Controls.Add(textBox1);
            AdminPanel.Location = new Point(28, 27);
            AdminPanel.Name = "AdminPanel";
            AdminPanel.Size = new Size(572, 498);
            AdminPanel.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.ForeColor = Color.Green;
            textBox1.Location = new Point(271, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 32);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 0, 64);
            label1.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(13, 16);
            label1.Name = "label1";
            label1.Size = new Size(252, 35);
            label1.TabIndex = 1;
            label1.Text = "Enter voter's name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(64, 0, 64);
            label2.Font = new Font("Trebuchet MS", 20F);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(13, 71);
            label2.Name = "label2";
            label2.Size = new Size(316, 35);
            label2.TabIndex = 2;
            label2.Text = "Choose options quantity:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.Black;
            numericUpDown1.ForeColor = Color.Green;
            numericUpDown1.Location = new Point(335, 77);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 32);
            numericUpDown1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(64, 0, 64);
            label3.Font = new Font("Trebuchet MS", 20F);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(13, 123);
            label3.Name = "label3";
            label3.Size = new Size(187, 35);
            label3.TabIndex = 4;
            label3.Text = "Enter options:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Black;
            textBox2.ForeColor = Color.Green;
            textBox2.Location = new Point(13, 170);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Both;
            textBox2.Size = new Size(536, 325);
            textBox2.TabIndex = 5;
            // 
            // AdminGUI
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(623, 615);
            Controls.Add(AdminPanel);
            Controls.Add(btnCreateVote);
            Font = new Font("Segoe UI", 14F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "AdminGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Voter (Admin)";
            AdminPanel.ResumeLayout(false);
            AdminPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreateVote;
        private Panel AdminPanel;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private NumericUpDown numericUpDown1;
    }
}