using ClientForApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveyApp
{
    public partial class AdminGUI : Form
    {
        private readonly Client tcpClient;
        public AdminGUI(Client client)
        {
            InitializeComponent();
            tcpClient = client;
        }       

        private async void btnCreateSurvey_Click(object sender, EventArgs e)
        {
            var topic = tbTopic.Text.Trim();
            var description = tbDesc.Text.Trim(); 
            var options = tbOptions.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            if (string.IsNullOrWhiteSpace(topic) || string.IsNullOrWhiteSpace(description) || options.Length == 0)
            {
                MessageBox.Show("Please fill out all fields properly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var createCommand = $"CREATE {topic} \"{description}\" {string.Join("|", options)}";
            await tcpClient.SendMessageAsync(createCommand);
        }

        private async void btnDelete_Survey_Click(object sender, EventArgs e)
        {
            if (cLBDelete.SelectedItem == null)
            {
                MessageBox.Show("Please select a survey to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var surveyToDelete = cLBDelete.SelectedItem.ToString();
            var deleteCommand = $"DELETE {surveyToDelete}";
            await tcpClient.SendMessageAsync(deleteCommand);
        }
    }
}
