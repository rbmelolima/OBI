using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piso_da_escola
{
    class Program
    {
        static void Main(string[] args)
        {
            //link para o enunciado: https://olimpiada.ic.unicamp.br/pratique/p2/2018/f1/piso/

            string texto;
            Console.Write("Largura | Comprimento: ");
            texto = Console.ReadLine();
            string[] entrada = texto.Split(' ');

            int largura, comprimento;
            largura = int.Parse(entrada[0]);
            comprimento = int.Parse(entrada[1]);

            int tipo1, tipo2;

            tipo2 = ((comprimento - 1) * 2) + ((largura - 1) * 2);
            tipo1 = (largura * comprimento)  + ((largura - 1 ) * (comprimento - 1));



            Console.WriteLine("Quantidade de pisos do tipo 1: {0}\nQuantidade de pisos do tipo 2: {1}\nQuantidade de pisos do tipo 3: 4", tipo1, tipo2);
            Console.ReadKey();
        }
    }
}
