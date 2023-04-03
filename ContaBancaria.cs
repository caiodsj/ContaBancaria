using System;
using System.Globalization;

namespace Saque_Deposito {
    class ContaBancaria {

        public int NumeroConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria() { }

        public void NumConta(int nconta) { NumeroConta = nconta; }
        public void DepositoInicial(string depositar) {
            if (depositar == "s" || depositar == "S") {
                Console.Write("Entre o valor de depósito inicial: ");
                Saldo = double.Parse(Console.ReadLine().Replace('.', ','));
            }
        }
        public override string ToString() {
            return "Conta " + NumeroConta + ", Titular: " + Nome + ", Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AdicionarSaldo(double deposito) {
            Saldo += deposito;
        }

        public void RetirarSaldo(double saque) { Saldo = Saldo - saque - 5.0; }
    }




}

