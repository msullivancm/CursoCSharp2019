using System;
using System.Globalization;

namespace ExemploOO02 {
    class Program {
        static void Main(string[] args) {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do Produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: {p} ");

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            p.AdicionarProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dados atualizados: " + p);

            Console.Write("Digite o número de produtos a ser removido ao estoque: ");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dados atualizados: " + p);

        }
    }
}
