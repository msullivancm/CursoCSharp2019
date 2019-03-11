using System;
using System.Collections.Generic;
using System.Text;

namespace ConversorDeMoeda
{
    class ConversorDeMoeda
    {
    }
}
blic static double iof = 6.0;

        public static double ValorPago(double cotacao, double dolar)
        {
            double total = cotacao * dolar;
            return total + total * iof / 100.0; 
        }
    }
}
