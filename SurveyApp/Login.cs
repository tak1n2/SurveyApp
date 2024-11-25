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

            tbLogin.KeyDown += LoginKeyDown;
            tbPasswrod.KeyDown += LoginKeyDown;

        }

       
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registrationForm = new RegistratrionForm(tcpClient);
            this.Hide(); 
            registrationForm.ShowDialog(); 
            this.Close();
        }

        private async Task SendLoginRequest(string username, string password)
        {
            var msg = $"LOGIN {username} {password}";
            await tcpClient.SendMessageAsync(msg);
        }


        private void LoginKeyDown(object sender,KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnRgstr_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

        }

        private async void btnRgstr_Click(object sender, EventArgs e)
        {
            try
            {
                if(!IsPasswordValid( tbPasswrod.Text)) {
                    throw new Exception("Password must be at least 5 characters long and include a number, an uppercase letter");

                }

                await SendLoginRequest(tbLogin.Text,tbPasswrod.Text);
                var msg = await tcpClient.ReceiveMessageAsync();
                if (msg == "LOGIN_SUCCESS")
                {
                   
                    Thread appThread = new Thread(() =>
                    {
                        Application.Run(new App(tcpClient));
                    });
                    appThread.SetApartmentState(ApartmentState.STA);
                    appThread.Start();             
                    this.Close();
                }
                else if(msg == "LOGIN_SUCCESS_ADMIN") 
                {
                    Thread appThread = new Thread(() =>
                    {
                        Application.Run(new App(tcpClient));
                    });
                    appThread.SetApartmentState(ApartmentState.STA);
                    appThread.Start();
                    this.Close();


                    Thread adminThread = new Thread(() =>
                    {
                        Application.Run(new AdminGUI(tcpClient));
                    });
                    adminThread.SetApartmentState(ApartmentState.STA);
                    adminThread.Start();
                    this.Close();
                }
                else
                {
                    throw new Exception("Incorrect login or password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private bool IsPasswordValid(string password)
        {

            const int MinLength = 5;


            if (password.Length < MinLength) return false;


            if (!password.Any(char.IsDigit)) return false;


            if (!password.Any(char.IsUpper)) return false;


            return true;
        }






    }
}
