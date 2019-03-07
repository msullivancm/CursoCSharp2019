using System;

namespace while1
{
    class Program {
    static void Main(string[] args) {
        int x = 0;
        Console.Write("Digite um número: ");
        x = int.Parse(Console.ReadLine());
        while (x > 0) {
            Console.WriteLine(x);
            x--;
        }
    }
}
}
