using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates02.Lib
{
    public class FotoProcessador
    {

        public delegate void FotoFiltroHandler(Foto foto);

        public static FotoFiltroHandler filtros;

        public static void Processar(Foto foto)
        {
            filtros(foto);
            //new FotoFiltro().PretoBranco(foto);
            //var filtros = new FotoFiltro();

            //filtros.Colorir(foto);
            //filtros.PretoBranco(foto);
            //filtros.GerarThumb(foto);
            //filtros.RedimensionaTamMedio(foto);

        }
    }
}
