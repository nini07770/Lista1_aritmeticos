using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor1, valor2, valor3, valor4;
            double media;

            Console.Write("Digite o primeiro valor: ");
            valor1 = Double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            valor2 = Double.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            valor3 = Double.Parse(Console.ReadLine());

            Console.Write("Digite o quarto valor: ");
            valor4 = Double.Parse(Console.ReadLine());

            media = (valor1 + valor2 + valor3 + valor4) / 4;

            Console.WriteLine("A média dos números {0}, {1}, {2} e {3} é: {4}", valor1, valor2, valor3, valor4, media);


        }
    }
}
