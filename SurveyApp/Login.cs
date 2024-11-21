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
        public Login(Client client)
        {
            InitializeComponent();
            tcpClient = client;
        }

       
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registrationForm = new RegistratrionForm();
            this.Hide(); // Hiding Login form
            registrationForm.ShowDialog(); // Open Registration Form
            this.Close();// Closing this form
        }

        private async Task SendLoginRequest(string username, string password)
        {
            var msg = $"LOGIN {username} {password}";
            await tcpClient.SendMessageAsync(msg);
        }

        private async void btnRgstr_Click(object sender, EventArgs e)
        {
            try
            {
                await SendLoginRequest(tbLogin.Text,tbPasswrod.Text);
                var msg = await tcpClient.ReceiveMessageAsync();
                if (msg == "LOGIN_SUCCESS")
                {
                    var appForm = new App(tcpClient);
                    this.Hide();
                    appForm.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Credentials are invalid", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    }
}
