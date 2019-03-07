using System;

namespace Exercicio9 {
    class Program {
        static void Main(string[] args) {
            double preco = double.Parse(Console.ReadLine());
            if (preco > 100.0) {
                double desconto = preco * 0.1;
            }
            Console.WriteLine(desconto); //como a variável foi declarada dentro do escopo do if, não pode ser usada fora desse escopo.
        }
    }
}
