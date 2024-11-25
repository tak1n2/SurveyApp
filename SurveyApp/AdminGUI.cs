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
        public AdminGUI(Client client, App app)
        {
            InitializeComponent();
            tcpClient = client;
            app.NewSurveyAdded += AdminGUI_AddSurveyToCheckboxList;
        }
        ///////////////////////////////////////////////////////////
        private async Task SendCheckboxRequest()// НЕ ПРАЦЮЄ
        {
            var msg = $"GET_SURVEYS";
            await tcpClient.SendMessageAsync(msg);
        }

        private async void button_Refresh_Click(object sender, EventArgs e)// НЕ ПРАЦЮЄ ПРАВИЛЬНО ОТРИМУЄ ТІЛЬКИ GET_CONFIRMED  Є ДЕБАГ ЩОБ ЦЕ ПОБАЧИТИ
        {
            try
            {
                cLBDelete.Items.Clear();
                await SendCheckboxRequest();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while refreshing surveys: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminGUI_AddSurveyToCheckboxList(string surveyData) // Метод для обробки події
        {
            var match = System.Text.RegularExpressions.Regex.Match(
                           surveyData,
                           @"^(\S+)\s+(\S+)\s+""([^""]+)""\s+(.+)$"
                       );

            if (!match.Success)
            {
                Console.WriteLine("Invalid survey data format");
                return;
            }
            var surveyId = match.Groups[1].Value;
            var topic = match.Groups[2].Value;
            var description = match.Groups[3].Value;
            var options = match.Groups[4].Value.Split('|');
            MessageBox.Show(topic, " ");
            cLBDelete.Items.Add(topic);
        }
        ///////////////////////////////////////////////////////////
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
