using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Utilitários
{
    public class Calculadora1
    {
        public long Fatorial(long n)
        {
            long resultado = 1;

            for (long i = 2; i <= n; i++)
            {
                resultado *= i;
            }

            return resultado;
        }

        public double Seno(double n)
        {
            double graus = n;
            double radianos = graus * (Math.PI / 180);

            double resultado = Math.Sin(radianos);

            return resultado;
        }

        public double Cosseno(double n)
        {
            double graus = n;
            double radianos = graus * (Math.PI / 180);

            double resultado = Math.Cos(radianos);
            return resultado;
        }

        public double Tangente(double n)
        {
            double graus = n;
            double radianos = graus * (Math.PI / 180);

            double resultado = Math.Tan(radianos);

            return resultado;
        }

        public string Binario(int n)
        { 
            string resultado = "";

            while (n > 0)
            {
                resultado = (n % 2) + resultado;
                n /= 2;
            }

            return resultado;
        }
    }
}
