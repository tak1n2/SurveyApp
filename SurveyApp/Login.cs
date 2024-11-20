using ClientForApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SurveyApp
{
    public partial class Login : Form
    {
        private readonly Client tcpClient;
        public Login()
        {
            InitializeComponent();
            tcpClient = new Client();
            InitializeClientAsync();
            tcpClient.MessageReceived += (sender, e) =>
            {
                tbLogin.Text = e.Message;
            };
            
        }

        private async Task InitializeClientAsync()
        {
            try
            {
                var ip = "224.5.5.5";
                var port = 5678;
                await tcpClient.ConnectAsync(ip, port);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registrationForm = new RegistratrionForm();
            this.Hide(); // Hiding Login form
            registrationForm.ShowDialog(); // Open Registration Form
            this.Close();// Closing this form
        }

        private void btnRgstr_Click(object sender, EventArgs e)
        {
            var appForm = new App();
            this.Hide();
            appForm.ShowDialog();
            this.Close();
        }
    }
}
