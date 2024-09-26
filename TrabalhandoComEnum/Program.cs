using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComEnum
{
    public class Program
    {
        static void Main(string[] args)
        {
            Motor motor = new Motor("V8", 500, 5000);
            Veiculo veiculo = new Veiculo("Ford", "Mustang", new DateTime(2025, 02, 16), TipoVeiculo.Carro, motor);

            veiculo.ImprimirDetalhes();
        }
    }
}
