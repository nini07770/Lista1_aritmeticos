using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double diametro;
            double area;

            Console.Write("Digite o diâmetro do círculo: ");
            diametro = Double.Parse(Console.ReadLine());

            area = 3.14 * (diametro / 2) * (diametro / 2);

            Console.WriteLine("A área do círculo com diâmetro {0} é: {1}", diametro, area);
        }
    }
}
