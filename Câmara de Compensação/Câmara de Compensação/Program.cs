using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Câmara_de_Compensação
{
    class Program
    {
        static void Main(string[] args)
        {
            // Link para o enunciado https://olimpiada.ic.unicamp.br/pratique/p2/2018/f1/compensacao/

            //primeira entrada M é o número de cheques emitidos e N é o número de habitantes da cidade

            Console.Write("Nº de cheques emitidos e Nº de habitantes: ");
            string entrada = Console.ReadLine();
            string[] MN = entrada.Split(' ');
            int m, n;
            m = int.Parse(MN[0]);
            n = int.Parse(MN[1]);

            //Saldo dos habitantes
            int[] saldo = new int[n + 1];
            for (int i = 1; i < saldo.Length; i++)
            {
                saldo[i] = 0;
            }

            int valorTotal = 0, valorMenor = 0;
            int x, y, v;

            for (int i = 0; i < m; i++)
            {
                entrada = "";
                entrada = Console.ReadLine();
                string[] movimentaçao = entrada.Split(' ');

                x = int.Parse(movimentaçao[0]);
                v = int.Parse(movimentaçao[1]);
                y = int.Parse(movimentaçao[2]);

                saldo[x] -= v;
                saldo[y] += v;
                valorTotal += v;
            }

            for (int i = 0; i < saldo.Length; i++)
            {
                valorMenor += Math.Abs(saldo[i]);
            }

            valorMenor = valorMenor / 2;
            if (valorMenor == valorTotal)
            {
                Console.WriteLine("\nNão é possível \nValor menor: {0}", valorMenor);
            }

            else
            {
                Console.WriteLine("\nSim, é possivel.\nValor menor: {0}", valorMenor);
            }

            Console.ReadKey();
        }
    }
}