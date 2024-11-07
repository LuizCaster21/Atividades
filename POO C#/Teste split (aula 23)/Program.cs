namespace split{
    class Program {

        public static void ContaString()
        {
            string input;
            int i = 0;

            Console.WriteLine("Digite uma frase");
            input = Console.ReadLine();

            foreach (char c in input)
            {
                i++;
            }

            Console.WriteLine(i);
        }
        public static void InverteString()
        {
            string input = "pica";
            string reverso = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverso += input[i];
            }
            Console.WriteLine(reverso);
        }

        public static void Maiuscula()
        {
            string a = "pica";

            foreach (char c in a)
            {
                Console.Write(c.ToString().ToUpper());
            }
        }
        public static void Contem()
        {
            string one = "refri";
            string two = "esse refri é pica demais!";

            if (two.Contains(one)){
                Console.WriteLine("Uma string é usada na outra");
            }
        }

        public static void SpiltTeste()
        {
            string normal = "O futuro é pica";
            string[] separado = normal.Split(' ');

            string a1 = separado[0];
            string a2 = separado[1];
            string a3 = separado[2];
            string a4 = separado[3];

            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);
            Console.WriteLine(a4);
        }

        public static void Fixacao()
        {
            string nome;
            string[] tudo;
            int quartos;
            int idade;
            double preco;

            Console.WriteLine("Entre com seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem sua casa?: ");
            quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com seu ultimo nome, idade e altura (mesma linha): ");
            tudo = Console.ReadLine().Split(' ');

            Console.WriteLine("Voce digitou: ");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(tudo[0]);
            Console.WriteLine(tudo[1]);
            Console.WriteLine(tudo[2]);
        }

        public static void Somar(){
            int n1,n2;
            
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            int Soma = n1 + n2;

            Console.WriteLine(Soma);
        }
    }
}