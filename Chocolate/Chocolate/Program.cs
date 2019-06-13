using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolate
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Link do enunciado do exercício
             * https://olimpiada.ic.unicamp.br/pratique/p2/2007/f1/choc/
             */

            string loop = "S";
            while (loop == "S")
            {
                Console.Clear();
                int nDivisao = 0, nPedaço = 0;
                Console.Write("Número de divisões: ");
                nDivisao = int.Parse(Console.ReadLine());
                Console.WriteLine(" --- ");
                Console.Write("Número de pedaços em que o pedaço atual foi dividido: ");
                string texto = Console.ReadLine();
                string[] pedaço = texto.Split(' ');

                for (int x = 0; x < pedaço.Length; x++)
                {
                    nPedaço += int.Parse(pedaço[x]);
                }

                nPedaço -= nDivisao;
                Console.WriteLine("Número de pedaços de chocolate que serão armazenados em estoque: {0}", nPedaço);
                Console.WriteLine("\n\nDeseja repetir o programa? (S/N): ");
                loop = Console.ReadLine().ToUpper();
                Console.ReadKey();
            }

        }
    }
}
