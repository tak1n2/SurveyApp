using ClientForApp;

namespace SurveyApp
{
    public partial class RegistratrionForm : Form
    {
        private readonly Client tcpClient;

        public RegistratrionForm(Client client)
        {
            InitializeComponent();
            tcpClient = client;
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

                if (!IsPasswordValid(tbPsw.Text))
                {
                    throw new Exception("Password must be at least 5 characters long and include a number, an uppercase letter");                
                }

                if(!(tbPsw.Text == tbPswConfirm.Text))
                {
                    throw new Exception("Passwords don't match");
                }

                await SendRegisetrRequest(tbLogin.Text, tbPsw.Text);
                var msg = await tcpClient.ReceiveMessageAsync();

                if (msg == "REGISTER_SUCCESS")
                {
                  
                    Thread appThread = new Thread(() =>
                    {
                        Application.Run(new App(tcpClient));
                    });
                    appThread.SetApartmentState(ApartmentState.STA);
                    appThread.Start();
                    this.Close();
                    
                }
                else
                {
                    throw new Exception("Login has already taken or credentials are invalid");
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
