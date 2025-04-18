using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double X;
            double Y;
            double resultado;

            Console.Write("Digite o valor de X: ");
            X = Double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de Y: ");
            Y = Double.Parse(Console.ReadLine());

            resultado = Math.Pow(X, Y);

            Console.WriteLine("O resultado de {0} elevado a {1} é: {2}", X, Y, resultado);

        }
    }
}
