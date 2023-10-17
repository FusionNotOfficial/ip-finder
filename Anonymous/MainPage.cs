using System.Drawing;
using System.Net;
using System.Text.RegularExpressions;

namespace Anonymous
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Setup();
            string line = "";
            using (WebClient wc = new WebClient())
                line = wc.DownloadString($"http://ipwho.is/{textBox1.Text}?output=xml");
            Match match = Regex.Match(line, "<country>(.*?)</country>(.*?)" +
                                            "<region>(.*?)</region>(.*?)" +
                                            "<city>(.*?)</city>(.*?)" +
                                            "<latitude>(.*?)</latitude>(.*?)" +
                                            "<longitude>(.*?)</longitude>"
                                            );
            countryText.Text += match.Groups[1].Value;
            regionText.Text += match.Groups[3].Value;
            cityText.Text += match.Groups[5].Value;
            latitudeText.Text += match.Groups[7].Value;
            longtitudeText.Text += match.Groups[9].Value;
        }

        private void Setup()
        {
            countryText.Text = "Country: ";
            regionText.Text = "Region: ";
            cityText.Text = "City: ";
            latitudeText.Text = "Latitude: ";
            longtitudeText.Text = "Longtitude: ";
        }
    }
}