using System;
using System.Globalization;

namespace ExercicioOO05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int contacorrente = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n)?");
            char deposito = char.Parse(Console.ReadLine());

            Conta c = new Conta(contacorrente, titular);
            double aport = 0.0;

            if (deposito == 's' || deposito == 'S')
            {
                Console.Write("Entre o valor do depósito inicial: ");
                aport = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                c.Deposito(aport);
            }

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(c);

            Console.Write("Entre um valor para depósito: ");
            aport = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(aport);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);

            Console.Write("Entre um valor para saque: ");
            aport = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(aport);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);
            
        }
    }
}
