using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Lib.Mensageiro
{
    public class SMS
    {
        public void EnviarMensagem(Object sender, VideoEventArgs args) 
        {
            Debug.WriteLine($"SMS enviado para o vídeo {args.Video.Nome}");
        }
    }
}
