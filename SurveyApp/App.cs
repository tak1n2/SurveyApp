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
        public readonly List<Panel> surveys = new List<Panel>();
        private int currentPage = 0;
        private const int SurveysPerPage = 4;
        public App(Client client)
        {
            InitializeComponent();
            tcpClient = client;
            ListenForServerMessages();
        }


        private async void ListenForServerMessages()
        {
            while (true)
            {
                try
                {
                    var message = await tcpClient.ReceiveMessageAsync();

                    if (message == null)
                    {
                        break;
                    }

                    if (message.StartsWith("NEW_SURVEY"))
                    {
                        AddSurveyToGui(message.Substring(11));
                    }
                    else if (message.StartsWith("DELETE_SURVEY"))
                    {
                        RemoveSurveyFromGui(message.Substring(14));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error in ListenForServerMessages: {ex.Message}");
                    break;
                }
            }
        }



        private void AddSurveyToGui(string surveyData)
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

            var surveyPanel = new Panel
            {
                Name = surveyId,
                Tag = surveyId,
                Size = new Size(panelSurveyList.Width - 20, 160),
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10),
                AutoScroll = true
            };

            surveyPanel.Controls.Add(new Label
            {
                Text = $"Topic: {topic}",
                AutoSize = true,
                Location = new Point(10, 10),
                Font = new Font("Trebuchet MS", 16, FontStyle.Bold)
            });

            surveyPanel.Controls.Add(new Label
            {
                Text = $"Description: {description}",
                AutoSize = true,
                Location = new Point(10, 45),
                Font = new Font("Trebuchet MS", 14)
            });

            int optionY = 70;
            int n = 1;
            for (int i = 0; i < options.Length; i++)
            {
                var option = options[i];
                if (option.Contains("GET_CONFIRMED"))
                {
                    options[i] = option.Replace("GET_CONFIRMED", string.Empty);
                }
                surveyPanel.Controls.Add(new RadioButton
                {
                    Text = $"Option {n}: {options[i]}",
                    AutoSize = true,
                    Location = new Point(10, optionY),
                    Font = new Font("Trebuchet MS", 14)
                });
                optionY += 30;
                n++;
            }
            var voteButton = new Button
            {
                Text = "Vote",
                Size = new Size(80, 30),
                Location = new Point(35, optionY + 10) 
            };

            voteButton.Click += (sender, e) =>
            {
                var selectedOption = surveyPanel.Controls.OfType<RadioButton>()
                                                         .FirstOrDefault(rb => rb.Checked);

                if (selectedOption != null)
                {
                    MessageBox.Show($"You voted for: {selectedOption.Text}", "Vote Submitted",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select an option before voting.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };
            surveyPanel.Controls.Add(voteButton);
            surveys.Add(surveyPanel);
            DisplayCurrentPage();
        }
        private void RemoveSurveyFromGui(string surveyId)
        {
            var surveyPanel = surveys.FirstOrDefault(s => s.Name == surveyId);
            if (surveyPanel != null)
            {
                surveys.Remove(surveyPanel);
                DisplayCurrentPage();
            }
        }
        private void DisplayCurrentPage()
        {
            panelSurveyList.Controls.Clear();

            int start = currentPage * SurveysPerPage;
            int end = Math.Min(start + SurveysPerPage, surveys.Count);

            for (int i = start; i < end; i++)
            {
                surveys[i].Location = new Point(0, (i - start) * 120);
                panelSurveyList.Controls.Add(surveys[i]);
            }

            lLPrev.Enabled = currentPage > 0;
            lLNext.Enabled = end < surveys.Count;
        }
        private async void App_Load(object sender, EventArgs e)
        {
            surveys.Clear(); 
            panelSurveyList.Controls.Clear(); 
            currentPage = 0; 

            try
            {
                await SendSurveyRequest(); 
                DisplayCurrentPage(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while refreshing surveys: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lLNext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if ((currentPage + 1) * SurveysPerPage < surveys.Count)
            {
                currentPage++;
                DisplayCurrentPage();
            }
        }

        private void lLPrev_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                DisplayCurrentPage();
            }
        }
        private async Task SendSurveyRequest()
        {
            var msg = $"GET_SURVEYS";
            await tcpClient.SendMessageAsync(msg);
        }
         private async void btnRefresh_Click(object sender, EventArgs e)
        {
            surveys.Clear();
            panelSurveyList.Controls.Clear();
            currentPage = 0;
            try
            {
                await SendSurveyRequest();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while refreshing surveys: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
