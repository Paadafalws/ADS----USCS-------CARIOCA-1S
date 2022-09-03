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
            int soma = 0;

            for (int i = 0;  i <= 100;i++ )
            {
                Console.WriteLine(i);
                soma = soma + i;
             
            }
            Console.WriteLine(soma);
            Console.ReadKey();
        }


    }
    }

