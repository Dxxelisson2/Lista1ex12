using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1_ex_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double p1, p2, p3, p4, p5, pag, troco, valort;

            Console.WriteLine("Digite o valor do produto 1: ");
            p1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do produto 2: ");
            p2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do produto 3: ");
            p3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do produto 4: ");
            p4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do produto 5: ");
            p5 = Convert.ToDouble(Console.ReadLine());

            valort = p1 + p2 + p3 + p4 + p5;

            Console.WriteLine("");

            Console.WriteLine("O valor da compra é: " + valort);

            Console.WriteLine("");

            Console.WriteLine(" Digite o valor do pagamento:  ");
            pag = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");

            troco = (pag - valort);

            Console.WriteLine(" O valor do troco é: " + troco);

            Console.ReadKey();

        }
      
    }
}
