using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExemploLista01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários vai registrar?");
            int qtd = int.Parse(Console.ReadLine());
            List<Funcionario> Funcionarios = new List<Funcionario>();

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Salary: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Funcionarios.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }
            
            Console.Write("Entre o ID do funcionário que terá o aumento : ");
            int searchId = int.Parse(Console.ReadLine());

            Funcionario emp = Funcionarios.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.Write("Entre o percentual de aumento: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.AumentaSalario(percentage);
            }
            else
            {
                Console.WriteLine("Este Id não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada de funcionários:");
            foreach (Funcionario obj in Funcionarios)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
