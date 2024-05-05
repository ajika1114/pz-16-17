using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private readonly HttpClient httpClient = new HttpClient();


        public Form1()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 600; 
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            await UpdateCatFactAsync();
        }

        private async Task UpdateCatFactAsync()
        {
            string catFact = await GetRandomCatFact();
            UpdateCatFactLabel(catFact);
        }

        private async Task<string> GetRandomCatFact()
        {
            try
            {
                string apiUrl = "https://meowfacts.herokuapp.com/";
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        private void UpdateCatFactLabel(string catFact)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action<string>(UpdateCatFactLabel), catFact);
                return;
            }

            labelCatFact.Text = catFact;
        }
    }
}
