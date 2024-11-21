using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientForApp;

namespace SurveyApp
{
    public partial class App : Form
    {
        private readonly Client tcpClient;
        public App(Client client)
        {
            InitializeComponent();
            tcpClient = client;
        }

        private void App_Load(object sender, EventArgs e)
        {

        }
    }
}
