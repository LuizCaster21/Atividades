﻿using System;
using System.Globalization;

namespace aula32{
        class Program{
            public static void Main(){
                Console.WriteLine("Digite um número: ");
                double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                while(x >= 0){
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3",CultureInfo.InvariantCulture));
                Console.WriteLine("Digite outro número: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                    Console.WriteLine("Número negativo!");
            }
        }
    }