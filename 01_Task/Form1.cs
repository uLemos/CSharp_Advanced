using System.Net;

namespace _01_Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnBaixar_Click(object sender, EventArgs e)
        {
            string endereco = txtSite.Text;

            WebClient web = new WebClient();

            //string html = web.DownloadString(endereco);
            string html = await web.DownloadStringTaskAsync(new Uri(endereco));

            txtResultado.Text = html;
        }
    }
}