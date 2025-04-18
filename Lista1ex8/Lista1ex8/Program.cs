using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grausC;
            double grausF;

            Console.Write("Digite a temperatura em graus Celsius: ");
            grausC = Double.Parse(Console.ReadLine());

            grausF = (grausC * 9 / 5) + 32;

            Console.WriteLine("A temperatura {0}ºC em graus Fahrenheit é: {1}ºF", grausC, grausF);

        }
    }
}
