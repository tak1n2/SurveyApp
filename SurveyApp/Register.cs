namespace SurveyApp
{
    public partial class RegistratrionForm : Form
    {
        public RegistratrionForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var loginForm = new Login();
            this.Hide(); // Hide the Registration form
            loginForm.ShowDialog(); // Open Login form modally
            this.Close(); // Close Registration form after Login form is closed

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
