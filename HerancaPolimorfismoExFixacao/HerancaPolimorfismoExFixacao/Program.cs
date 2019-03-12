using System;
using System.Collections.Generic;
using System.Globalization;
using HerancaPolimorfismoExFixacao.Entities;

namespace HerancaPolimorfismoExFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> produtos = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Price:");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Custon fee:");
                    double custonFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    produtos.Add(new ImportedProduct(name, price, custonFee));
                }
                else if (ch == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    produtos.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    produtos.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product p in produtos)
            {
                Console.WriteLine(p.PriceTag());
            }
            

        }
    }
}
