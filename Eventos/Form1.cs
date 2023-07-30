using Eventos.Lib;
using Eventos.Lib.Mensageiro;

namespace Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnVideoEncode.Click += EventoDeClick;
        }

        public void EventoDeClick(object sender, EventArgs e)
        {

            Video video = new Video() { Nome = "video.mp4" };

            VideoEncode vid = new VideoEncode();

            vid.Encoded += new Email().EnviarMensagem;
            vid.Encoded += new SMS().EnviarMensagem;

            vid.Encode(video);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}