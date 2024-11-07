namespace Exercicios
{
    class Program
    {
        public static void ex1()
        {
            int a;
            Console.WriteLine("Digite um número inteiro (de 0 a 1000): ");
            a = int.Parse(Console.ReadLine());

            for (int i = 0; i <= a; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}