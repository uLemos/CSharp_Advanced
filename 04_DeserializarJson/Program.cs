using _00_Biblioteca;
using System.Text.Json;


var stream = new StreamReader(@"C:\Users\fekel\Desktop\DOCS\CURSOS\Curso C# Avançado\Serialize\JSON\02_SerializarJSON.json");

var deserializar = (Usuario) JsonSerializer.Deserialize(stream.ReadToEnd(), typeof(Usuario))!;

Console.WriteLine($"- Nome: {deserializar.Nome}\n- CPF: {deserializar.CPF}\n- Email: {deserializar.Email}");