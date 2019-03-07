using System;

namespace For1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Quantos números inteiros você vai digitar?");
            int n = int.Parse(Console.ReadLine());
            int x = 0;
            for (x = 1; x <= n; x++) {
                Console.WriteLine(x);
            }
        }
    }
}
