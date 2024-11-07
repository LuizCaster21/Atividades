using System;

namespace Ex1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pessoa pessoa1;
            Pessoa pessoa2;

            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Digite os dados da primeira pessoa: ");
            pessoa1.Nome = Console.ReadLine();
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os dados da segunda pessoa: ");
            pessoa2.Nome = Console.ReadLine();
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa1.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa2.Nome);
            }

        }
    }
}