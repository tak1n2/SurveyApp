using ClientForApp;

namespace SurveyApp
{
    public partial class RegistratrionForm : Form
    {
        private readonly Client tcpClient;

        public RegistratrionForm()
        {
            InitializeComponent();
            tcpClient = new Client();
            this.Load += RegistratrionForm_Load!;
        }

        private async Task InitializeClientAsync()
        {
            try
            {
                var ip = "127.0.0.1";
                var port = 3456;
                await tcpClient.ConnectAsync(ip, port);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var loginForm = new Login(tcpClient);
            this.Hide(); 
            loginForm.ShowDialog(); 
            this.Close();

        }

        private async Task SendRegisetrRequest(string username, string password)
        {
            var msg = $"REGISTER {username} {password}";
            await tcpClient.SendMessageAsync(msg);
        }

        private async void btnRgstr_Click(object sender, EventArgs e)
        {

            try
            {
                if (tbPsw.Text == tbPswConfirm.Text)
                {
                    await SendRegisetrRequest(tbLogin.Text, tbPsw.Text);
                }

                var msg = await tcpClient.ReceiveMessageAsync();

                if (msg == "REGISTER_SUCCESS")
                {
                    var appForm = new App(tcpClient);
                    this.Hide();
                    appForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login has already taken or credentials are invalid", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

        }

        private async void RegistratrionForm_Load(object sender, EventArgs e)
        {
            await InitializeClientAsync();
        }
    }
}
