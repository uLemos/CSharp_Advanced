using System.Text.Json;

namespace _01_Generics
{
    public class Serializador 
    {
        public static void Serializar(Object obj)
        {
            var stream = new StreamWriter(@"C:\Users\fekel\Desktop\DOCS\CURSOS\Curso C# Avançado\Serialize\Generics\03_"+ obj.GetType().Name +".txt");
            stream.Write(JsonSerializer.Serialize(obj));
            stream.Close();
        }

        public static T Deserializar<T>()
        {
            var stream = new StreamReader(@"C:\Users\fekel\Desktop\DOCS\CURSOS\Curso C# Avançado\Serialize\Generics\03_"+ typeof(T).Name+ ".txt");

            T obj = (T) JsonSerializer.Deserialize(stream.ReadToEnd(), typeof(T))!;
            return obj;
        }
    }
}
