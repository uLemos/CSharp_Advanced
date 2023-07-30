using LINQ_03;

var lista =  new List<Usuario>();

lista.Add(new Usuario() { Nome = "Fernando", Email = "lemos@gmail.com" });
lista.Add(new Usuario() { Nome = "Lemos", Email = "fernando@gmail.com" });
lista.Add(new Usuario() { Nome = "Trevisano", Email = "trevisano@gmail.com" });
lista.Add(new Usuario() { Nome = "Agnes", Email = "santos@gmail.com" });
lista.Add(new Usuario() { Nome = "Santos", Email = "agnes @gmail.com" });

var listas = lista.Where(x => x.Email!.Contains("@gmail.com")).OrderBy(x => x.Nome).Select(x => x);

foreach (var item in listas)
{
    Console.WriteLine($"Nome: {item.Nome} - Email: {item.Email}");
}
