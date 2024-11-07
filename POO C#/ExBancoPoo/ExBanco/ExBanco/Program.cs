using ExBanco;
using System;
using System.Globalization;

    namespace ExBancoPoo
    {
        class Program
        {
            static void Main()
            {
                double DepositoInicial = 0, Aux;
                int id;
                string nome;
                bool DepIni;
                Conta C;

                Console.WriteLine("Entre o numero da conta: ");
                id = int.Parse(Console.ReadLine());

                Console.WriteLine("Entre com o nome do titular da conta: ");
                nome = Console.ReadLine();

                Console.WriteLine("Haverá depósito inicial (S/N) ?");
                string resposta = Console.ReadLine().ToLower();

                while (resposta != "s" && resposta != "n")
                {
                    Console.WriteLine("Resposta inválida. Por favor, digite S para sim ou N para não.");
                    resposta = Console.ReadLine().ToLower();
                }

                DepIni = resposta == "s";

                if (DepIni)
                {
                    Console.WriteLine("Qual o valor do deposito inicial? ");
                    DepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    C = new Conta(id, nome, DepositoInicial);
                }
                else
                {
                    C = new Conta(id, nome);
                }

                Console.WriteLine("Dados da conta:");
                Console.WriteLine(C);
                Console.WriteLine("");

                Console.WriteLine("Entre com um valor para depósito: ");
                Aux = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                C.Depositar(Aux);

                Console.WriteLine("Dados da conta atualizados:");
                Console.WriteLine(C);
                Console.WriteLine("");

                Console.WriteLine("Entre com um valor para saque");
                Aux = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                C.Sacar(Aux);

                Console.WriteLine("Dados da conta atualizados:");
                Console.WriteLine(C);
                Console.WriteLine("");
            }
        }
    }