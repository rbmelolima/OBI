using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dario_e_Xerxes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Link do enunciado: https://olimpiada.ic.unicamp.br/pratique/pu/2017/f2/xerxes/

            int rodadas;
            Console.Write("Número de rodadas: ");
            rodadas = int.Parse(Console.ReadLine());

            while (rodadas < 1 || rodadas > 999 || (rodadas % 2 == 0))
            {
                Console.Clear();
                Console.WriteLine("Número de rodadas: ");
                rodadas = int.Parse(Console.ReadLine());
            }

            int dario = 0, xerxes = 0, Vdario = 0, Vxerxes = 0;
            string[] mao;
            string texto;

            Console.WriteLine("Começando a partida!\n");

            for (int x = 0; x < rodadas; x++)
            {
                Console.Write("Rodada {0}: ", x + 1);
                texto = Console.ReadLine();

                mao = texto.Split(' ');

                dario = int.Parse(mao[0]);
                xerxes = int.Parse(mao[1]);

                if (dario > 4 || dario < 0 || xerxes > 4 || xerxes < 0)
                {
                    Console.WriteLine("Erro");
                    break;
                }


                if (dario == 0 && (xerxes == 1 || xerxes == 2))
                {
                    Vdario += 1;
                }

                else if (dario == 1 && (xerxes == 2 || xerxes == 3))
                {
                    Vdario += 1;
                }

                else if (dario == 2 && (xerxes == 3 || xerxes == 4))
                {
                    Vdario += 1;
                }

                else if (dario == 3 && (xerxes == 4 || xerxes == 0))
                {
                    Vdario += 1;
                }

                else if (dario == 4 && (xerxes == 0 || xerxes == 1))
                {
                    Vdario += 1;
                }

                else
                {
                    Vxerxes += 1;
                }

                mao[0] = "";
                mao[1] = "";
            }


            if(Vxerxes > Vdario)
            {
                Console.WriteLine("\nXerxes é o campeão.");
            }

            else
            {
                Console.WriteLine("\nDário é o campeão.");
            }

            Console.ReadKey();
        }
    }
}
