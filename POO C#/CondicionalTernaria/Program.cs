﻿using System.Globalization;

namespace teste
{
    class Program
    {
        public static void Main()
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(preco);
        }
    }
}