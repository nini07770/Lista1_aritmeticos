using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor1, valor2, valor3, valor4, valor5;
            double soma;
            double pagamento;
            double troco;

            Console.Write("Digite o valor do primeiro produto: ");
            valor1 = Double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do segundo produto: ");
            valor2 = Double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do terceiro produto: ");  
            valor3 = Double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do quarto produto: ");
            valor4 = Double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do quinto produto: ");
            valor5 = Double.Parse(Console.ReadLine());

            soma = valor1 + valor2 + valor3 + valor4 + valor5;

            Console.Write("Sua compra totalizou: R$ {0},00. Digite o valor que você vai pagar: ", soma);
            pagamento = Double.Parse(Console.ReadLine());

            troco = pagamento - soma;

            Console.WriteLine("O troco a receber é de: R$ {0},00", troco);

        }
    }
}
