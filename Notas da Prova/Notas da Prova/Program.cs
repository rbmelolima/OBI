using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas_da_Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            //Link para o enunciado: https://olimpiada.ic.unicamp.br/pratique/p2/2009/f1/nota/

            Console.Write("Nota numérica: ");
            int n = int.Parse(Console.ReadLine());

            if(n == 0)
                Console.WriteLine("E");

            else if (n >= 1 && n <= 35)
                Console.WriteLine("D");

            else if (n >= 36 && n <= 60)
                Console.WriteLine("C");

            else if (n >= 61 && n <= 85)
                Console.WriteLine("B");

            else if (n >= 86 && n <= 100)
                Console.WriteLine("A");

            Console.ReadKey();

        }
    }
}
