using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postes
{
    class Program
    {
        static void Main(string[] args)
        {
            //link para enunciado: https://olimpiada.ic.unicamp.br/pratique/p2/2017/f3/postes/

            string texto;
            int nPostes = 0, nConserto = 0, nSubstituto = 0, nSaudavel = 0;
            Console.Write("Número de Postes: ");
            nPostes = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite os tamanhos: ");
            texto = Console.ReadLine();
            string[] postes = texto.Split(' ');

            for (int i = 0; i < postes.Length; i++)
            {
                if (int.Parse(postes[i]) < 50)
                    nSubstituto += 1;
                else if (int.Parse(postes[i]) >= 50 && int.Parse(postes[i]) < 85)
                    nConserto += 1;
                else
                    nSaudavel += 1;
            }

            Console.WriteLine("Postes a ser consertados: {0}\nPostes a ser substituídos: {1}\nPostes a serem usados normalmente: {2}", nConserto, nSubstituto, nSaudavel);
            Console.ReadKey();
        }
    }
}
