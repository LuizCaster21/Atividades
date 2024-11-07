using System;

    namespace Condicionais{
        class Program {
            public static void impopar()
        {
            int a = 0;
            Console.WriteLine("Digite um número: ");

            a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Par! ");
            }

            else {
                Console.WriteLine("Ímpar! ");
            }

        }

        public static void hora(){
            double hora;
            Console.WriteLine("Que horas são agora?");

            hora = double.Parse(Console.ReadLine());

            if (hora < 12){
                Console.WriteLine("Bom dia!");
            } else if ( hora >= 12 && hora < 18){
                Console.WriteLine("Boa tarde! ");
            } else{
                Console.WriteLine("Boa noite!");
            }
        }

        public static void maior(){
            int a1,a2,a3;

            Console.WriteLine("Digite três números: ");
            a3 = int.Parse(Console.ReadLine());
            a1 = int.Parse(Console.ReadLine());
            a2 = int.Parse(Console.ReadLine());

            if (a1 > a2 && a1 > a3){
                Console.WriteLine("O maior número é: " + a1);
            } else if(a2 > a3){
                Console.WriteLine("O maior número é: " + a2);
            } else {
                Console.WriteLine("O maior número é; " + a3);
            }
        }
    }
    }