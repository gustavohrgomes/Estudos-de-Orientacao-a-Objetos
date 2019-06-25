using System;
using System.Globalization;

namespace Exercicio_de_Fixação {
    class Program {
        static void Main(string[] args) {

            ContaBancaria conta;

            Console.Write("Entre o numero da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titularConta = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S') {
                Console.Write("Entre com o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numeroConta, titularConta, depositoInicial);
            }
            else {
                conta = new ContaBancaria(numeroConta, titularConta);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados Atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados Atualizados: ");
            Console.WriteLine(conta);
        }
    }
}
