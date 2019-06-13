using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinco
{
    class Program
    {
        static void Main(string[] args)
        {
            //Link do enunciado: https://olimpiada.ic.unicamp.br/pratique/pu/2018/f3/cinco/

            int n = 0;
            Console.Write("Nº de dígitos: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Digite os dígitos: ");
            string texto = Console.ReadLine();

            string[] numero = texto.Split(' ');
            string[] copia = new string[n];
            Int64[] novonumero = new Int64[n];

            numero.CopyTo(copia, 0);

            string letra, letraFinal, auxiliar;
            bool existe = false;


            for (int x = 0; x < (n - 1); x++)
            {
                if (numero[x].Equals("0") || numero[x].Equals("5"))
                {
                    existe = true;
                    letra = ""; letraFinal = ""; auxiliar = "";

                    letraFinal = copia.Last();
                    letra = copia[x];

                    copia[x] = letraFinal;
                    copia[n - 1] = letra;

                    for (int i = 0; i < copia.Length; i++)
                    {
                        auxiliar += copia[i];
                    }

                    novonumero[x] = int.Parse(auxiliar);
                    numero.CopyTo(copia, 0);
                }
            }

            Int64 Maior;

            if (existe)
            {
                Array.Sort(novonumero);
                Maior = novonumero.Last();
            }

            else
            {
               Maior = -1;
            }

            Console.Write("\n\nMaior número: {0}", Maior);
            Console.ReadKey();
        }
    }
}
