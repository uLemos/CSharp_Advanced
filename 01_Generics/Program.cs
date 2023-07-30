using _01_Generics;
using _01_Generics.Models;

var carro = new Carro() { Marca = "FIAT", Modelo = "UNO"};
var casa = new Casa() { Cidade = "São Paulo", Endereco = "aaa 200" };
var usuario = new Usuario() { Nome = "Fernando", Email = "fsngas@gmail.com", Senha = "12345"};

Serializador.Serializar(carro);
Serializador.Serializar(casa);
Serializador.Serializar(usuario);

Carro carro2 = Serializador.Deserializar<Carro>();
Casa casa2 = Serializador.Deserializar<Casa>();
Usuario usuario2 = Serializador.Deserializar<Usuario>();

Console.WriteLine($"Carro2: {carro2.Marca} - {carro2.Modelo}");
Console.WriteLine($"Casa2: {casa2.Cidade} - {casa2.Endereco}");
Console.WriteLine($"Usuario2: {usuario2.Nome} - {usuario2.Email} - {usuario2.Senha}");