using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExemploLista01
{
    class Funcionario
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Nome
                + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AumentaSalario(double percentual)
        {
            Salario += Salario * (percentual / 100);
        }
    }
}
