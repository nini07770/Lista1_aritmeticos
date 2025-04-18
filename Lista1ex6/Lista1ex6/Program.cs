using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor1, valor2;
            double mediageo;

            Console.Write("Digite o primeiro número: ");
            valor1 = Double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            valor2 = Double.Parse(Console.ReadLine());

            mediageo = Math.Sqrt(valor1 * valor2);

            Console.WriteLine("A média geométrica dos números {0} e {1} é: {2}", valor1, valor2, mediageo);
           
            
        }
    }
}
