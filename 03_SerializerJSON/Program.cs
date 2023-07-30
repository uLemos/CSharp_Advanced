using _00_Biblioteca;
using System.Text.Json;

var usuario = new Usuario() { Nome = "Ana Lemos", CPF = "222.222.222-23", Email = "trevisano@gmail.com" };

var jsonString = JsonSerializer.Serialize(usuario);
StreamWriter stream = new StreamWriter(@"C:\Users\fekel\Desktop\DOCS\CURSOS\Curso C# Avançado\Serialize\JSON\02_SerializarJSON.json");
stream.WriteLine(jsonString);
stream.Close();

