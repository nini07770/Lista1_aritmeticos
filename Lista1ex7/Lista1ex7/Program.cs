using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double milhas;
            double km;

            Console.WriteLine("Digite a distância em milhas: ");
            milhas = Double.Parse(Console.ReadLine());

            km = milhas * 1.852;
            Console.WriteLine("A distância de {0} milhas em quilômetros é: {1} km", milhas, km);
           
        }
    }
}
