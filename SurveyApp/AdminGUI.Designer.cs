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
            btnCreateSurvey = new Button();
            AdminPanel = new Panel();
            tbTopic = new TextBox();
            label4 = new Label();
            tbOptions = new TextBox();
            label3 = new Label();
            nUDQuantity = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            tbDesc = new TextBox();
            panel1 = new Panel();
            cLBDelete = new CheckedListBox();
            label5 = new Label();
            btnDelete_Survey = new Button();
            AdminPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUDQuantity).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreateSurvey
            // 
            btnCreateSurvey.BackColor = Color.Black;
            btnCreateSurvey.Cursor = Cursors.Hand;
            btnCreateSurvey.FlatStyle = FlatStyle.Flat;
            btnCreateSurvey.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateSurvey.ForeColor = SystemColors.ButtonFace;
            btnCreateSurvey.Location = new Point(224, 592);
            btnCreateSurvey.Name = "btnCreateSurvey";
            btnCreateSurvey.Size = new Size(260, 63);
            btnCreateSurvey.TabIndex = 0;
            btnCreateSurvey.Text = "Create Survey";
            btnCreateSurvey.UseVisualStyleBackColor = true;
            btnCreateSurvey.Click += btnCreateSurvey_Click;
            // 
            // AdminPanel
            // 
            AdminPanel.Controls.Add(btnCreateSurvey);
            AdminPanel.Controls.Add(tbTopic);
            AdminPanel.Controls.Add(label4);
            AdminPanel.Controls.Add(tbOptions);
            AdminPanel.Controls.Add(label3);
            AdminPanel.Controls.Add(nUDQuantity);
            AdminPanel.Controls.Add(label2);
            AdminPanel.Controls.Add(label1);
            AdminPanel.Controls.Add(tbDesc);
            AdminPanel.Location = new Point(28, 27);
            AdminPanel.Name = "AdminPanel";
            AdminPanel.Size = new Size(714, 670);
            AdminPanel.TabIndex = 1;
            // 
            // tbTopic
            // 
            tbTopic.BackColor = Color.Black;
            tbTopic.ForeColor = Color.Green;
            tbTopic.Location = new Point(271, 24);
            tbTopic.Name = "tbTopic";
            tbTopic.Size = new Size(432, 32);
            tbTopic.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(64, 0, 64);
            label4.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(13, 19);
            label4.Name = "label4";
            label4.Size = new Size(247, 35);
            label4.TabIndex = 6;
            label4.Text = "Enter voter's topic:";
            // 
            // tbOptions
            // 
            tbOptions.BackColor = Color.Black;
            tbOptions.ForeColor = Color.Green;
            tbOptions.Location = new Point(13, 243);
            tbOptions.Multiline = true;
            tbOptions.Name = "tbOptions";
            tbOptions.ScrollBars = ScrollBars.Both;
            tbOptions.Size = new Size(690, 320);
            tbOptions.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(64, 0, 64);
            label3.Font = new Font("Trebuchet MS", 20F);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(13, 205);
            label3.Name = "label3";
            label3.Size = new Size(187, 35);
            label3.TabIndex = 4;
            label3.Text = "Enter options:";
            // 
            // nUDQuantity
            // 
            nUDQuantity.BackColor = Color.Black;
            nUDQuantity.ForeColor = Color.Green;
            nUDQuantity.Location = new Point(325, 164);
            nUDQuantity.Name = "nUDQuantity";
            nUDQuantity.Size = new Size(120, 32);
            nUDQuantity.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(64, 0, 64);
            label2.Font = new Font("Trebuchet MS", 20F);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(13, 158);
            label2.Name = "label2";
            label2.Size = new Size(316, 35);
            label2.TabIndex = 2;
            label2.Text = "Choose options quantity:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 0, 64);
            label1.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(13, 63);
            label1.Name = "label1";
            label1.Size = new Size(239, 35);
            label1.TabIndex = 1;
            label1.Text = "Enter survey desc:";
            // 
            // tbDesc
            // 
            tbDesc.BackColor = Color.Black;
            tbDesc.ForeColor = Color.Green;
            tbDesc.Location = new Point(13, 112);
            tbDesc.Name = "tbDesc";
            tbDesc.Size = new Size(690, 32);
            tbDesc.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(cLBDelete);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnDelete_Survey);
            panel1.Location = new Point(764, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 670);
            panel1.TabIndex = 2;
            // 
            // cLBDelete
            // 
            cLBDelete.BackColor = SystemColors.InactiveCaptionText;
            cLBDelete.ForeColor = SystemColors.Window;
            cLBDelete.FormattingEnabled = true;
            cLBDelete.Location = new Point(61, 73);
            cLBDelete.Name = "cLBDelete";
            cLBDelete.Size = new Size(312, 463);
            cLBDelete.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(64, 0, 64);
            label5.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Snow;
            label5.Location = new Point(22, 19);
            label5.Name = "label5";
            label5.Size = new Size(384, 35);
            label5.TabIndex = 7;
            label5.Text = "Choose what survey to delete:";
            // 
            // btnDelete_Survey
            // 
            btnDelete_Survey.BackColor = Color.Black;
            btnDelete_Survey.Cursor = Cursors.Hand;
            btnDelete_Survey.FlatStyle = FlatStyle.Flat;
            btnDelete_Survey.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete_Survey.ForeColor = SystemColors.ButtonFace;
            btnDelete_Survey.Location = new Point(90, 592);
            btnDelete_Survey.Name = "btnDelete_Survey";
            btnDelete_Survey.Size = new Size(260, 63);
            btnDelete_Survey.TabIndex = 3;
            btnDelete_Survey.Text = "Delete Survey";
            btnDelete_Survey.UseVisualStyleBackColor = true;
            btnDelete_Survey.Click += btnDelete_Survey_Click;
            // 
            // AdminGUI
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(1251, 709);
            Controls.Add(panel1);
            Controls.Add(AdminPanel);
            Font = new Font("Segoe UI", 14F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "AdminGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Voter (Admin)";
            AdminPanel.ResumeLayout(false);
            AdminPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUDQuantity).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreateSurvey;
        private Panel AdminPanel;
        private TextBox tbDesc;
        private Label label1;
        private Label label2;
        private TextBox tbOptions;
        private Label label3;
        private NumericUpDown nUDQuantity;
        private TextBox tbTopic;
        private Label label4;
        private Panel panel1;
        private Button btnDelete_Survey;
        private Label label5;
        private CheckedListBox cLBDelete;
    }
}