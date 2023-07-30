using LINQ_JOIN;


var autores = new List<Autor>();
var livros = new List<Livro>();

livros.Add(new Livro() { Id = 1, Titulo = "A", AutorId = 2 });
livros.Add(new Livro() { Id = 2, Titulo = "B", AutorId = 2 });
livros.Add(new Livro() { Id = 3, Titulo = "C", AutorId = 3 });
livros.Add(new Livro() { Id = 4, Titulo = "D", AutorId = 1 });


autores.Add(new Autor() { Nome = "Russel", Id = 1 });
autores.Add(new Autor() { Nome = "Silverter", Id = 2 });
autores.Add(new Autor() { Nome = "Bruce Lee", Id = 3 });


var listaJoin = from listaLivro in livros join autor in autores on listaLivro.AutorId equals autor.Id select new { listaLivro, autor };

foreach (var item in listaJoin)
{
    Console.WriteLine($"Livro: {item.listaLivro.Titulo} - Autor: {item.autor.Nome}");
}
