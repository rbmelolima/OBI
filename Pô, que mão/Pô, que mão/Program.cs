using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pô__que_mão
{
    class Program
    {
        static void Main(string[] args)
        {
            //Link do enunciado: https://olimpiada.ic.unicamp.br/pratique/p2/2016/f2/pokemon/

            int[] alimentaçao = new int[3];
            int qtdComida = 0, qtdAnimal = 0;

            Console.Write("Quantidade de alimento: ");
            qtdComida = int.Parse(Console.ReadLine());

            Console.Write("\nAlimento para o primeiro animal: ");
            alimentaçao[0] = int.Parse(Console.ReadLine());

            Console.Write("\nAlimento para o segundo animal: ");
            alimentaçao[1] = int.Parse(Console.ReadLine());

            Console.Write("\nAlimento para o terceiro animal: ");
            alimentaçao[2] = int.Parse(Console.ReadLine());

            Array.Sort(alimentaçao);

            for (int i = 0; i <= 2; i++)
            {
                qtdComida -= alimentaçao[i];
                if (qtdComida > 0)
                {

                    qtdAnimal += 1;
                }
            }


            Console.WriteLine("Animais alimentados: " + qtdAnimal);
            Console.ReadLine();
        }
    }
}
