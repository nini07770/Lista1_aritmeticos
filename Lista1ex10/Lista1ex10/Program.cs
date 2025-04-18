using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cotacaoDolar;
            double valorEmDolar;
            double valorEmReal;

            Console.Write("Digite a cotação do dólar atual: ");
            cotacaoDolar = Double.Parse(Console.ReadLine());

            Console.Write("Digite um valor em dólar: ");
            valorEmDolar = Double.Parse(Console.ReadLine());

            valorEmReal = cotacaoDolar * valorEmDolar;

            Console.WriteLine("O valor de {0} dólares é equivalente a {1} reais", valorEmDolar, valorEmReal);

        }
    }
}
