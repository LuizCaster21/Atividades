using System;
using System.Globalization;

namespace Ex2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Funcionario Funcionario1 = new Funcionario();
            Funcionario Funcionario2 = new Funcionario();

            Console.WriteLine("Digite os dados do primeiro funcionário: ");
            Funcionario1.Nome = Console.ReadLine();
            Funcionario1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite os dados do segundo funcionário: ");
            Funcionario2.Nome = Console.ReadLine();
            Funcionario2.Salario = double.Parse(Console.ReadLine());

            double MediaSalarios = (Funcionario1.Salario + Funcionario2.Salario) / 2;
            Console.WriteLine("Média de salários = " + MediaSalarios.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}