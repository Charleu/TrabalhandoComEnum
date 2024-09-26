using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComEnum
{
    public class Motor
    {
        public string Tipo { get; set; }
        public int Potencia { get; set; }
        public int Cilindradas { get; set; }  

        public Motor(string tipo, int potencia, int cilindradas)
        {
            Tipo = tipo;
            Potencia = potencia;
            Cilindradas = cilindradas;
        }
    }
}
