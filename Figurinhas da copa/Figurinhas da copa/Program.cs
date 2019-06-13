using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurinhas_da_copa
{
    class Program
    {
        static void Main(string[] args)
        {
            //link do enunciado: https://olimpiada.ic.unicamp.br/pratique/p2/2018/f1/figurinhas/

            int nEspaço = 0, nCarimbada = 0, nComprada = 0;
            string texto;

            Console.WriteLine("Nº de espaços do álbum | Nº de figurinhas carimbadas | Nº de figurinhas já compradas: ");
            texto = Console.ReadLine();

            string[] entrada = texto.Split(' ');

            nEspaço = int.Parse(entrada[0]);
            nCarimbada = int.Parse(entrada[1]);
            nComprada = int.Parse(entrada[2]);

            Console.WriteLine("\nFigurinhas carimbadas do álbum: ");
            texto = Console.ReadLine();
            string[] carimbadas = texto.Split(' ');

            Console.WriteLine("\nFigurinhas compradas do álbum: ");
            texto = Console.ReadLine();
            string[] compradas = texto.Split(' ');

           
            //new HashSet<string>();
            int tem = 0;

            for (int i = 0; i < carimbadas.Length; i++)
            {
                if (compradas.Contains(carimbadas[i]))
                {
                    tem += 1;
                }
            }

            Console.WriteLine("\nFigurinhas restantes: {0}", nCarimbada - tem);
            Console.ReadKey();
        }
    }
}
