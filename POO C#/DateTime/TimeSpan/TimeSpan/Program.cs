using System;

namespace Course
    {
    class Program
        {
        static void Main(string[] args)
            {
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            /*DateTime x = DateTime.Now;  Exemplo de uma data inicial

            DateTime y1 = x.Add(new TimeSpan(1, 2, 3, 4)); // Adiciona 1 dia, 2 horas, 3 minutos e 4 segundos
            DateTime y2 = x.AddDays(3); // Adiciona 3 dias
            DateTime y3 = x.AddHours(5); // Adiciona 5 horas
            DateTime y4 = x.AddMilliseconds(1000); // Adiciona 1000 milissegundos (1 segundo)
            DateTime y5 = x.AddMinutes(30); // Adiciona 30 minutos
            DateTime y6 = x.AddMonths(2); // Adiciona 2 meses
            DateTime y7 = x.AddSeconds(60); // Adiciona 60 segundos (1 minuto)
            DateTime y8 = x.AddTicks(10000000); // Adiciona 10.000.000 ticks (1 segundo)
            DateTime y9 = x.AddYears(1); // Adiciona 1 ano

            DateTime y10 = x.Subtract(new TimeSpan(1, 0, 0)); // Subtrai 1 hora
            TimeSpan t = x.Subtract(DateTime.Now.AddDays(-1)); // Calcula a diferença em dias entre duas datas
            */
            }
        }
    }