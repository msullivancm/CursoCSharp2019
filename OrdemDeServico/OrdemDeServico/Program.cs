using System;
using OrdemDeServico.Entities;
using OrdemDeServico.Entities.Enums;

namespace OrdemDeServico
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            order.Client.Name = Console.ReadLine();
            Console.Write("Email: ");
            order.Client.Email = Console.ReadLine();
            Console.Write("Bird date DD/MM/YYYY: ");
            order.Client.BirthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            order.Status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order: ");
            int norders = int.Parse(Console.ReadLine());

            for (int i=1; i<=norders; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                
                Product product = new Product(productName,price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product);
                order.AddItem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}
