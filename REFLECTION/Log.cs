using REFLECTION.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REFLECTION
{
    public class Log
    {
        public static List<Object> objetos = new List<Object>();

        public static void Gravar(Object obj)
        {
            objetos.Add(obj);
        }

        public static void ApresentarLog()
        {
            foreach (object obj in objetos)
            {
                Console.WriteLine($"----- Nome Classe: {obj.GetType().Name} ------");

                foreach (var prop in obj.GetType().GetProperties())
                {
                    Console.WriteLine($"{prop.Name}: {prop.GetValue(obj)}");
                }
            }
        }

        //public static List<Usuario> usuarios = new List<Usuario>();
        //public static List<Carro> carros = new List<Carro>();
        
        //public static void GravarUsuario(Usuario usuario)
        //{
        //    usuarios.Add((Usuario)usuario.Clone());
        //}
        //public static void GravarCarro(Carro carro)
        //{
        //    carros.Add(carro);
        //}

        //public static void ApresentarLog()
        //{
        //    foreach (Usuario usuario in usuarios)
        //    {
        //        Console.WriteLine($"Nome: {usuario.Nome}, Email: {usuario.Email}, Senha: {usuario.Senha}");
                
        //        foreach (Carro carro in carros)
        //        {
        //            Console.WriteLine($"Marca: {carro.Marca}, Modelo: {carro.Modelo}");
        //        }
        //    }
        //}
    }
}
