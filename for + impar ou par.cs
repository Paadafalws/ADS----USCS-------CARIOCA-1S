using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aweawex
{
    class Program
    {
        static void Main(string[] args)
        {   // Apresentar todos os valores numéricos inteiros impares situados na faixa de 0 a 20.

            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 1) // verdade se i for impar
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }


    }
    }

