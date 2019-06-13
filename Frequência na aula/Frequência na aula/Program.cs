using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frequência_na_aula
{
    class Program
    {
        static void Main(string[] args)
        {
            //Link para o enunciado: https://olimpiada.ic.unicamp.br/pratique/p2/2012/f1/frequencia/

            Console.Write("Quantidade de registros: ");
            int qtd = int.Parse(Console.ReadLine());

            int[] alunos = new int[qtd];

            for (int i = 0; i < qtd; i++)
            {
                Console.Write("Aluno {0}: ", i + 1);
                alunos[i] = int.Parse(Console.ReadLine());
            }

            HashSet<int> presença = new HashSet<int>();

            for (int i = 0; i < qtd; i++)            
                presença.Add(alunos[i]);

            Console.WriteLine("\n\nQuantidade de alunos em aula: {0}", presença.Count());

            Console.ReadKey();
        }
    }
}
