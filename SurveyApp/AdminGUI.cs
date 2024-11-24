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

                var message = await tcpClient.ReceiveMessageAsync();
                MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var messages = message.Split(new[] { "\n" }, StringSplitOptions.None);

                foreach (var msg in messages)
                {
                    if (msg == "GET_CONFIRMED")
                    {
                        MessageBox.Show("Survey list successfully updated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (msg.StartsWith("NEW_SURVEY"))
                    {
                        AddSurveyToCheckboxList(msg.Substring(11));
                    }
                    else
                    {
                        Console.WriteLine($"Unhandled message: {msg}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while refreshing surveys: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddSurveyToCheckboxList(string surveyData)//ЦЕ НАЧЕ ПРАВИЛЬНО АЛЕ ПЕРЕВІРИТИ НЕ ВДАЛОСЬ 
        {
            var match = System.Text.RegularExpressions.Regex.Match(
                surveyData,
                @"^(\S+)\s+(.+)$" 
            );
            if (!match.Success)
            {
                Console.WriteLine("Invalid survey data format");
                return;
            }
            var surveyName = match.Groups[2].Value;
            if (!cLBDelete.Items.Contains(surveyName))
            {
                cLBDelete.Items.Add(surveyName);
            }
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
