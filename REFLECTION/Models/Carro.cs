using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REFLECTION.Models
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }


        public object Clone()
        {
            return new Carro()
            {
                Marca = this.Marca,
                Modelo = this.Modelo
            };
        }
    }

}
