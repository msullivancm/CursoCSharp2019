using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioOO05
{
    class Conta
    {
        public int ContaCorrente { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public Conta() { }

        public Conta(int contaCorrente, string titular)
        {
            ContaCorrente = contaCorrente;
            Titular = titular;
        }

        public Conta(int contaCorrente, string titular, double depositoInicial) : this(contaCorrente, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double aport)
        {
            Saldo = Saldo + aport;
        }
        public void Saque(double aport)
        {
            Saldo = Saldo - aport - 5.0;
        }

        public override string ToString()
        {
            return $"Conta: {ContaCorrente}, Titular: {Titular}, Saldo: "+ Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
