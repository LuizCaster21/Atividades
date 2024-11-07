using System;
using System.Collections.Generic;

namespace TesteListas
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            lista.Add("Ader");
            lista.Add("Maria");
            lista.Add("Bibo");
            lista.Add("Gago");
            lista.Insert(1, "Marco");
            lista.Add("Anna");

            foreach (string qualquer in lista)
            {
                Console.WriteLine(qualquer);
            }

            Console.WriteLine("Tamanho da lista: " + lista.Count);

            string s1 = lista.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            string s2 = lista.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = lista.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = lista.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos2);

            List<string> lista2 = lista.FindAll(x => x.Length == 5);

            foreach (string qualquer in lista2)
            {
                Console.WriteLine(qualquer);
            }

            lista.Remove("Ader");
            foreach (string qualquer in lista)
            {
                Console.WriteLine(qualquer); 
            }

            lista.RemoveAll(x => x[0] == 'M');


        }

        static bool teste(string s)
        {
            return s[0] == 'A';
        }
    }
}