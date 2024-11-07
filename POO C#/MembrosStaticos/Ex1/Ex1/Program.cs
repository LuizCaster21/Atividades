using System;
using System.Globalization;

namespace Ex1
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            double r;
            Console.WriteLine("Digite o valor do raio: ");
            r = double.Parse(Console.ReadLine());

            double circ = Calculadora.Circunferencia(r);
            double volume = Calculadora.Volume(r);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pi: " + Calculadora.Pi.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}