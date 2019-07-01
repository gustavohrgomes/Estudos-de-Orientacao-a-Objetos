using System;
using System.Globalization;

namespace Vetores {
    class Program {

        //vetores tipo struct
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            double[] vetor = new double[n];

            for (int i = 0; i < n; i++) {
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++) {
                sum += vetor[i];
            }

            double avarege = sum / n;

            Console.WriteLine("Altura média: " + avarege.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
