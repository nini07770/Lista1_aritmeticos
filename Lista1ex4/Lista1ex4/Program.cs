using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baze;
            double altura;
            double area;

            Console.Write("Digite a base do triângulo: ");
            baze = Double.Parse(Console.ReadLine());

            Console.Write("Digite a altura do triângulo: ");
            altura = Double.Parse(Console.ReadLine());

            area = (baze * altura) / 2;

            Console.WriteLine("A área do triângulo de Base {0} e altura {1} é: {2}", baze, altura, area);

        }
    }
}
