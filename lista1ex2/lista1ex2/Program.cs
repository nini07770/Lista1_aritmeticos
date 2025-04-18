using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aresta;
            int area;

            Console.Write("Informe o valor da aresta do quadrado: ");
            aresta = int.Parse(Console.ReadLine());

            area = aresta * aresta;

            Console.WriteLine("O valor da área de um quadrado que possui aresta de {0} é {1}", aresta, area);
        }
    }
}
