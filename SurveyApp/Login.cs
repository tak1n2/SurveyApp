using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveyApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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
