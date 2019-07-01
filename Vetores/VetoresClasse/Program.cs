using System;
using System.Globalization;

namespace VetoresClasse {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            Product[] vetor = new Product[n];

            for (int i = 0; i < n; i++) {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vetor[i] = new Product { Name = name, Price = price };
            }

            double sum = 0;
            for (int i = 0; i < n; i++) {
                sum += vetor[i].Price;
            }

            double avarege = sum / n;

            Console.WriteLine("Preço médio: " + avarege.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
