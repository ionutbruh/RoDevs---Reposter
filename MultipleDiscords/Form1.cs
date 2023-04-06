using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.IO;
using Newtonsoft.Json;
using System.Collections;

namespace MultipleDiscords
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public List<string> Channels;
        public List<string> Tokens;
        public Form1()
        {
            this.InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.output_listbox.Items.Add("Output");
            this.openFileDialog1.Filter = "TXT files|*.txt";
            this.openFileDialog2.Filter = "TXT files|*.txt";
        }

        private void LogToOutput(string Message) {
            output_listbox.Items.Add(Message);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Tokens = File.ReadAllLines(openFileDialog1.FileName).ToList();
            foreach (string line in Tokens) { 
                tokens_listbox.Items.Add(line);
            }
        }
        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
           Channels = File.ReadAllLines(openFileDialog2.FileName).ToList();
           foreach (string line in Channels)
           {
               channels_listbox.Items.Add(line);
           }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tokens_listbox.Items.Clear();
            channels_listbox.Items.Clear();
        }

        private async void PostMessage(string Message) {

            for (int i = 0; i < tokens_listbox.Items.Count; i++)
            {

                var JSONBody = new MessageBody();
                JSONBody.content = Message;
                string JSONBody_Serialized = JsonConvert.SerializeObject(JSONBody);
                var Content = new StringContent(JSONBody_Serialized, Encoding.UTF8, "application/json");

                var request = new HttpRequestMessage(HttpMethod.Post, "https://discord.com/api/v9/channels/" + channels_listbox.Items[i].ToString() + "/messages");
                request.Content = Content;
                request.Headers.Add("authorization", tokens_listbox.Items[i].ToString());

                var response = await client.SendAsync(request);

                Console.WriteLine(await response.Content.ReadAsStringAsync());

                switch (response.StatusCode)
                {
                    case System.Net.HttpStatusCode.OK:
                        LogToOutput(@"[✓] Posted 'latest' for Index - " + i + 1);
                        break;
                    default:
                        LogToOutput("[X] Error occurred for Index - " + +i + 1);
                        break;
                }

            }

        }

        private async void RePostCommand() {
            for (int i = 0; i < tokens_listbox.Items.Count; i++)
            {
                var JSONBody = new RepostCommandBody();
                JSONBody.channel_id = long.Parse(channels_listbox.Items[i].ToString());

                string JSONBody_Serialized = JsonConvert.SerializeObject(JSONBody);
                var Content = new StringContent(JSONBody_Serialized, Encoding.UTF8, "application/json");

                var request = new HttpRequestMessage(HttpMethod.Post, "https://discord.com/api/v9/interactions");
                request.Content = Content;
                request.Headers.Add("authorization", tokens_listbox.Items[i].ToString());

                var response = await client.SendAsync(request);
                Console.WriteLine(response.StatusCode);

                switch (response.StatusCode)
                {
                    case System.Net.HttpStatusCode.NoContent:
                        LogToOutput("[✓] Reposted for Index - " + i+1);
                        break;
                    default:
                        LogToOutput("[X] Error occurred for Index - " + +i + 1);
                        break;
                }

            }
        }

        private async void ConfirmCommand()
        {
            for (int i = 0; i < tokens_listbox.Items.Count; i++)
            {
                var GetMessages = new HttpRequestMessage(HttpMethod.Get, "https://discord.com/api/v9/channels/" + channels_listbox.Items[i].ToString() + "/messages?limit=1");
                GetMessages.Headers.Add("authorization", tokens_listbox.Items[i].ToString());

                var Messages = await client.SendAsync(GetMessages);
                IList Chunk = JsonConvert.DeserializeObject<IList>(await Messages.Content.ReadAsStringAsync());
                Root LastMessage = JsonConvert.DeserializeObject<Root>(JsonConvert.SerializeObject(Chunk[0]));

                var JSONBody = new ConfirmCommandBody();
                JSONBody.channel_id = long.Parse(channels_listbox.Items[i].ToString());
                JSONBody.message_id = long.Parse(LastMessage.id);

                try
                {
                    JSONBody.data.custom_id = LastMessage.components[0].components[0].custom_id;
                }
                catch (Exception) {          
                    LogToOutput("Last message is not a confirmation.");
                }
                try
                {

                    string JSONBody_Serialized = JsonConvert.SerializeObject(JSONBody);
                    var Content = new StringContent(JSONBody_Serialized, Encoding.UTF8, "application/json");

                    var request = new HttpRequestMessage(HttpMethod.Post, "https://discord.com/api/v9/interactions");
                    request.Content = Content;
                    request.Headers.Add("authorization", tokens_listbox.Items[i].ToString());

                    var response = await client.SendAsync(request);
                    //Console.WriteLine(await response.Content.ReadAsStringAsync());

                    switch (response.StatusCode)
                    {
                        case System.Net.HttpStatusCode.NoContent:
                            LogToOutput("[✓] Reposted for Index - " + i + 1);
                            break;
                        default:
                            LogToOutput("[X] Error occurred for Index - " + +i + 1);
                            break;
                    }
                } catch (Exception e)
                {
                    LogToOutput(e.ToString());
                }
         
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RePostCommand();            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PostMessage("latest");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ConfirmCommand();
        }

    }
}
