using _00_Biblioteca;
using System.IO;
using System.Xml.Serialization;


var serializador = new XmlSerializer(typeof(Usuario));

var stream = new StreamReader(@"C:\Users\fekel\Desktop\DOCS\CURSOS\Curso C# Avançado\Serialize\XML\01_SerializarXml.xml");
var usuario = (Usuario) serializador.Deserialize(stream)!; //Fazendo Cashing

Console.WriteLine($"Deserialização\n\n- Nome: {usuario.Nome} \n- CPF: {usuario.CPF} \n- Email: {usuario.Email}");