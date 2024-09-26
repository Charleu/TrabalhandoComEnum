using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComEnum
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateTime Ano { get; set; }
        public TipoVeiculo Tipo { get; set; }
        public Motor Motor { get; set; }

        public Veiculo(string marca, string modelo, DateTime ano, TipoVeiculo tipo, Motor motor)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Tipo = tipo;
            Motor = motor;
        }

        public void ImprimirDetalhes()
        {
            Console.WriteLine($"Marca do Veículo: {Marca}" +
                 $"\nModelo do Veículo: {Modelo}\n" +
                 $"Ano do Veículo: {Ano.Year}\n" +
                 $"Tipo do Veículo: {Tipo}\n" +
                 $"Tipo do Motor: {Motor.Tipo}\n" +
                 $"Potência do Motor: {Motor.Potencia} HP\n" +
                 $"Cilindradas do Motor: {Motor.Cilindradas} cc");
        }
    }
}
