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
        {

            double n1, n2, n3;

            Console.WriteLine(" O jogo Funciona assimm,acerte uma sequencia de 3 numeros se acertar voce ganha ");
            Console.WriteLine(" Regras: ele vai de  0~9 ");


            Console.WriteLine(" 1º algarismos , e o 2º algarimos da sequencia numerica   ");
            n1= double.Parse(Console.ReadLine());

            if (n1 == 1)
            {

                Console.WriteLine(" acertou o primeiro  ");

            }
            else
            {
                Console.WriteLine("Desqualificado ");
            }

            Console.WriteLine(" 2º algarismos , quantas coreias existems  ?  ");
            n2 = double.Parse(Console.ReadLine());

            if (n2 == 2)
            {

                Console.WriteLine(" acertou o segundo  ");

            }
            else
            {
                Console.WriteLine("Desqualificado ");
            }

            Console.WriteLine(" 3º algarismos , qual eo algarismo da  5º colocaçao da sequencia fibonacci  ?  ");
            n3 = double.Parse(Console.ReadLine());
            if (n3 == 3)
            {

                Console.WriteLine(" acertou o terceiro  ");

            }
            else
            {
                Console.WriteLine("Desqualificado ");
            }

            Console.ReadKey();
        }
    }
}
