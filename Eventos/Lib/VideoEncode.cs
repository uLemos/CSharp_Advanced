using System.Diagnostics;

namespace Eventos.Lib
{
    public class VideoEncode
    {
        //public delegate void VideoEncodedHandler(Video video);
        //public event VideoEncodedHandler Encoded;

        public event EventHandler<VideoEventArgs> Encoded;

        public void Encode(Video video)
        {
            Debug.WriteLine($"Convertendo o vídeo...");
            Thread.Sleep(2000);
            Debug.WriteLine("Vídeo convertido!");

            Encoded(null, new VideoEventArgs() { Video = video });
        }
    }
    public class VideoEventArgs : EventArgs
    {
        public Video? Video { get; set; }
    }
}
