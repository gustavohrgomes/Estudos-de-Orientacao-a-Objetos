using System;
using System.Globalization;

namespace Encapsulamento {
    class Program {
        static void Main(string[] args) {

            Produto produto = new Produto("TV", 500.00, 10);

            produto.SetNome("TV 4K");

            Console.WriteLine(produto.GetNome());
            Console.WriteLine(produto.GetPreco());
        }
    }
}