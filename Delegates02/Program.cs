using Delegates02.Lib;



Foto foto = new Foto { Nome = "foto.jpg", TamanhoX = 1920, TamanhoY = 1080 };
FotoProcessador.filtros = new FotoFiltro().GerarThumb;
FotoProcessador.Processar(foto);


Foto foto2 = new Foto { Nome = "produto.jpg", TamanhoX = 1920, TamanhoY = 1080 };
FotoProcessador.filtros = new FotoFiltro().Colorir;
FotoProcessador.filtros += new FotoFiltro().RedimensionaTamMedio;
FotoProcessador.Processar(foto2);

Foto foto3 = new Foto { Nome = "album.jpg", TamanhoX = 1920, TamanhoY = 1080 };
FotoProcessador.filtros = new FotoFiltro().PretoBranco;
FotoProcessador.Processar(foto3);

