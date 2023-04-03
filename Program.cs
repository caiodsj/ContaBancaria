using System;
using System.Globalization;
namespace Saque_Deposito {
    internal class Program {
        static void Main(string[] args) {

            ContaBancaria conta = new ContaBancaria();

            Console.Write("Entre o número da conta: ");
            int numeroconta = int.Parse(Console.ReadLine());
            conta.NumConta(numeroconta);
            Console.Write("Entre o titular da conta: ");
            conta.Nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            string resp = Console.ReadLine();
            conta.DepositoInicial(resp);
            Console.WriteLine("Dados da conta:\n" + conta);

            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine().Replace('.', ','));
            conta.AdicionarSaldo(deposito);
            Console.WriteLine("Dados da conta atualizados:\n" + conta);

            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine().Replace('.', ','));
            conta.RetirarSaldo(saque);
            Console.WriteLine("Dados da conta atualizados:\n" + conta);

        }
    }
}