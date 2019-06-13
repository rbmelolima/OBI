using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botas_Trocadas
{
    class Program
    {
        static void Main(string[] args)
        {
            //link para o enunciado: https://olimpiada.ic.unicamp.br/pratique/p2/2017/f1/botas/

            string texto;
            int nBotas, nPares = 0;

            Console.Write("Nº de botas: ");
            nBotas = int.Parse(Console.ReadLine());

            while (nBotas % 2 != 0)
            {
                Console.Clear();
                Console.Write("Nº de botas: ");
                nBotas = int.Parse(Console.ReadLine());
            }


            string[] Pe = new string[nBotas];

            Console.WriteLine("Digite os pares: ");

            for (int i = 0; i < nBotas; i++)
            {
                texto = "";
                texto = Console.ReadLine();
                Pe[i] = texto.ToUpper();
            }

            Array.Sort(Pe);

            for (int i = 0; i < nBotas; i++)
                for (int k = i + 1; k < nBotas; k++)
                    if (Pe[i].Substring(0, 2) == Pe[k].Substring(0, 2))
                        if ((Pe[i].Substring(3, 1).Equals("E") && Pe[k].Substring(3, 1).Equals("D")) || (Pe[i].Substring(3, 1).Equals("D") && Pe[k].Substring(3, 1).Equals("E")))
                            nPares += 1;

            Console.WriteLine("Nº de pares possíveis: {0}", nPares);
            Console.ReadKey();
        }
    }
}
