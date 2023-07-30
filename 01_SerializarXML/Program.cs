using _00_Biblioteca;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

var usuario = new Usuario() { Nome = "Fernando Lemos", CPF = "222.222.222-22", Email = "lemos@gmail.com" };

var serializador = new XmlSerializer(typeof(Usuario));
//var serializador = new XmlSerializer(usuario.GetType());

StreamWriter stream = new StreamWriter(@"C:\Users\fekel\Desktop\DOCS\CURSOS\Curso C# Avançado\Serialize\XML\01_SerializarXml.xml");
serializador.Serialize(stream, usuario);