
using System.Globalization;
using System.Reflection.Metadata;

namespace ExBanco
{
    internal class Conta
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Conta() { 
        }

        public Conta(int id, String nome)
        {
            Id = id;
            Nome = nome;
        }

        public Conta(int id, String nome, double saldo) : this(id, nome)
        {
            Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor + 5;
        }
        public override string ToString()
        {
            return "Conta " 
                + Id
                + ", "
                +
                "Titular: "
                + Nome 
                + ", "
                + "Saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
