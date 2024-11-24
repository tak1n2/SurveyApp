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
            LoadSurveys();
        }
        private async void LoadSurveys()
        {
            try
            {
                var msg = "GET_SURVEYS";
                await tcpClient.SendMessageAsync(msg);
                var surveys = await tcpClient.ReceiveMessageAsync();
                if (!string.IsNullOrWhiteSpace(surveys))
                {
                    var surveyList = surveys.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    cLBDelete.Items.Clear();
                    foreach (var survey in surveyList)
                    {
                        var parts = survey.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        if (parts.Length > 1)
                        {
                            cLBDelete.Items.Add(parts[1]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load surveys: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            LoadSurveys();
        }
    }
}
