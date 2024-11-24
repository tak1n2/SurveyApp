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
            lLNext = new LinkLabel();
            lLPrev = new LinkLabel();
            panelSurveyList = new Panel();
            btnRefresh = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(438, 18);
            label1.Name = "label1";
            label1.Size = new Size(501, 76);
            label1.TabIndex = 0;
            label1.Text = "SURVEYS BROWSE";
            // 
            // lLNext
            // 
            lLNext.AutoSize = true;
            lLNext.Font = new Font("Segoe UI", 20F);
            lLNext.LinkColor = Color.Red;
            lLNext.Location = new Point(1077, 625);
            lLNext.Name = "lLNext";
            lLNext.Size = new Size(221, 46);
            lLNext.TabIndex = 1;
            lLNext.TabStop = true;
            lLNext.Text = "Next page ->";
            lLNext.LinkClicked += lLNext_LinkClicked;
            // 
            // lLPrev
            // 
            lLPrev.AutoSize = true;
            lLPrev.Font = new Font("Segoe UI", 20F);
            lLPrev.LinkColor = Color.Red;
            lLPrev.Location = new Point(12, 635);
            lLPrev.Name = "lLPrev";
            lLPrev.Size = new Size(276, 46);
            lLPrev.TabIndex = 2;
            lLPrev.TabStop = true;
            lLPrev.Text = "<- Previous page";
            lLPrev.LinkClicked += lLPrev_LinkClicked;
            // 
            // panelSurveyList
            // 
            panelSurveyList.AutoScroll = true;
            panelSurveyList.Location = new Point(89, 91);
            panelSurveyList.Name = "panelSurveyList";
            panelSurveyList.Size = new Size(1065, 500);
            panelSurveyList.TabIndex = 3;
            // 
            // btnRefresh
            // 
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Font = new Font("Trebuchet MS", 10F);
            btnRefresh.Location = new Point(637, 625);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(105, 44);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(btnRefresh);
            Controls.Add(panelSurveyList);
            Controls.Add(lLPrev);
            Controls.Add(lLNext);
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
        private LinkLabel lLNext;
        private LinkLabel lLPrev;
        private Panel panelSurveyList;
        private Button btnRefresh;
    }
}