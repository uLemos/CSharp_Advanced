using REFLECTION;
using REFLECTION.Models;
using System.Reflection.Metadata.Ecma335;

Usuario usuario = new Usuario()
{ 
    Nome = "Fernando",
    Email = "lemos@gmail.com",
    Senha = "123456"
};

Carro carro = new Carro() 
{
    Marca = "FIAT",
    Modelo = "UNO"
};

Log.Gravar(usuario.Clone());

usuario.Nome = "Lemos";
Log.Gravar(usuario.Clone());




Log.Gravar(carro.Clone());
Log.ApresentarLog();

Console.WriteLine("Log Gravado!");
