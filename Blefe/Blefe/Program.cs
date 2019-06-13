using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blefe
{
    class Program
    {
        static void Main(string[] args)
        {
               
            //Link para o enunciado: https://olimpiada.ic.unicamp.br/pratique/p2/2014/f2/blefe/
            // (I) - Incluir em B qualquer um dos números do conjunto A
            // (II) - Incluir em B um número que é a soma de dois números quaisquer que já estejam em B

            Console.Write("Tamanho do conjunto A | Tamanho da sequência B: ");
            string texto = Console.ReadLine();
            string[] ab = texto.Split(' ');

            Console.Write("\n Conjunto A: ");
            texto = Console.ReadLine();
            string[] conjunto = texto.Split(' ');

            Console.Write("\n Sequência B: ");
            texto = Console.ReadLine();
            string[] sequenciaB = texto.Split(' ');

            List<int> conjuntoA = new List<int>();
            HashSet<int> somaB = new HashSet<int>();

            for (int i = 0; i < conjunto.Length; i++)
                conjuntoA.Add(int.Parse(conjunto[i]));

            for (int i = 0; i < sequenciaB.Length; i++)
                for (int j = i; j < sequenciaB.Length; j++)
                    somaB.Add(int.Parse(sequenciaB[i]) + int.Parse(sequenciaB[j]));

            bool[] jogadasValidas = new bool[int.Parse(ab[1])];
            int jValidas = 0;


            for (int i = 0; i < sequenciaB.Length; i++)
            {
                if (conjuntoA.Contains(int.Parse(sequenciaB[i])))
                    jogadasValidas[i] = true;

                else
                    jogadasValidas[i] = false;
            }

            for (int i = 0; i < sequenciaB.Length; i++)
                if (jogadasValidas[i] == false)
                    if (somaB.Contains(int.Parse(sequenciaB[i])))
                        jogadasValidas[i] = true;

            for (int i = 0; i < jogadasValidas.Length; i++)
                if (jogadasValidas[i] == true)
                    jValidas += 1;


            if (jValidas == jogadasValidas.Length)
                Console.WriteLine("\nTodas as jogadas são válidas.");
            else
            {
                Console.WriteLine("\nHá jogadas inválidas");
                for (int i = 0; i < jogadasValidas.Length; i++)
                {
                    if(jogadasValidas[i] == false)
                        Console.WriteLine(sequenciaB[i]);
                }
            }
            Console.ReadKey();
        }
    }
}


