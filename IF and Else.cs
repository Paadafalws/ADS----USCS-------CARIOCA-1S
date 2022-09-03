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
            double A, B, C;

            Console.WriteLine(" Numeros de forma crescente ");

            A = Double.Parse(Console.ReadLine());
            B = Double.Parse(Console.ReadLine());
            C = Double.Parse(Console.ReadLine());

            if (A > B && A > C && B>C)
            {
                Console.WriteLine(" {0},{1},{2}",A,B,C); 
            }
            else
            {
                Console.WriteLine(" {0},{1},{2}", B, C, A);
            }
            if (C>A && C>B && A>B )
            {
                Console.WriteLine(" {0},{1},{2}", C, A, B);
            }
            else
            {
                Console.WriteLine(" {0},{1},{2}", C, B, A);
            }
            Console.ReadKey();
        }
    }
}
