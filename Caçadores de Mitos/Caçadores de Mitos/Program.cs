using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caçadores_de_Mitos
{
    class Program
    {
        static void Main(string[] args)
        {

            //Link para o enunciado: https://olimpiada.ic.unicamp.br/pratique/p2/2009/f1/mito/

            int n = 0;
            bool mito = false;
            Console.Write("Nº de raios: ");
            n = int.Parse(Console.ReadLine());


            string[] cordenadas = new string[n];

            for (int i = 0; i < n; i++)
            {
                cordenadas[i] = Console.ReadLine();
            }

            Console.WriteLine("Verificando... \n");
           

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (cordenadas[i].Equals(cordenadas[j]))
                    {                        
                        mito = true;
                    }
                }

            }

            if (mito)
            {
                Console.WriteLine("mito = {0}", mito);
            }

            else
            {
                Console.WriteLine("mito = {0}", mito);
            }

            Console.ReadKey();
        }
    }
}
