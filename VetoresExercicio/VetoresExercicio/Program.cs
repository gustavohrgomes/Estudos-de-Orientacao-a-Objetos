using System;

namespace VetoresExercicio {
    class Program {
        static void Main(string[] args) {

            Estudante[] vetor = new Estudante[10];

            Console.Write("Quantos quartos serão alugados? ");
            int quantidadeQuartosAlugados = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantidadeQuartosAlugados; i++) {

                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vetor[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos Alugados:");
            for (int i = 0; i < 10; i++) {
                if (vetor[i] != null) {
                    Console.WriteLine(i + ": " + vetor[i]);
                }
            }
            
        }
    }
}
