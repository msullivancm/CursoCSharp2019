using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {
            bool completo = false;
            char genero = 'F';
            char letra = '\u03B2'; //Beta
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria Green";
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;
            int n7 = int.MinValue;
            int n8 = int.MaxValue;
            decimal n9 = decimal.MaxValue;
            int idade = 32;
            double saldo = 10.35784;

            Console.WriteLine(letra);
            Console.WriteLine(genero);
            Console.WriteLine(completo);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(n7);
            Console.WriteLine(n8);
            Console.WriteLine(n9);
            Console.WriteLine("=================");
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(saldo.ToString("F2")); //Imprime com 2 casas decimais
            Console.WriteLine(saldo.ToString("F4")); //Imprime com 4 casas decimais
            Console.WriteLine(saldo.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine("-------------------------------");
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais.", nome, idade, saldo); //usando place holders
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais."); //Usando interpolação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais."); //usando concatenação

        }
    }
}
