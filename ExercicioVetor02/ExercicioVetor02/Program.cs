using System;
using System.Globalization;

namespace ExercicioVetor02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];
            double soma = 0.0;

            for (int i=0; i<n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                vect[i] = new Produto { Nome = nome, Preco = preco };
                soma += vect[i].Preco;
            }

            double avg = soma / n;

            Console.WriteLine("Preço médio = " + avg.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
