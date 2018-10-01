using System;
using System.Net;
using System.Windows.Forms;

namespace HTML_Scraper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                string htmlCode = client.DownloadString(textBox1.Text);
                richTextBox1.Text = htmlCode;
            }
        }
    }
}
