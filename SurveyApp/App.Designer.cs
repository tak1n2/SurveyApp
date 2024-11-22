namespace SurveyApp
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(438, 18);
            label1.Name = "label1";
            label1.Size = new Size(402, 61);
            label1.TabIndex = 0;
            label1.Text = "SURVEYS BROWSE";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 20F);
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(1077, 625);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(175, 37);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Next page ->";
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "App";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Voter";
            Load += App_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel linkLabel1;
    }
}