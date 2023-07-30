using System.Net;

List<Task> lista = new List<Task>();

lista.Add(Task.Factory.StartNew(Metodo01));
lista.Add(Task.Factory.StartNew(Metodo01));
lista.Add(Task.Factory.StartNew(Metodo01));
lista.Add(Task.Factory.StartNew(Metodo01));

Task.WaitAll(lista.ToArray());



string[] enderecos = new string[]
{
    "https://www.google.com.br", "https://www.microsoft.com.br"
};

var listaEnd = from end in enderecos select DownloadPagina(end);

Task.WaitAll(listaEnd.ToArray());

Console.WriteLine("Programa Finalizado!");
static void Metodo01()
{
    for (var i = 0; i < 1000; i++)
    {
        Console.WriteLine($"Valor: {i} TASKID: {Task.CurrentId}");
    }
}

static async Task DownloadPagina(string end)
{
    WebClient web = new WebClient();
    string html = await web.DownloadStringTaskAsync(end);
    Console.WriteLine($"Download realizado para a página {end}");
}
