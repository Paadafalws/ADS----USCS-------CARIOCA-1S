using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] TT = new int[5];
            int q;
            
            for ( int A =0; A<5; A++)
            {
                Console.WriteLine(" Numero local V == " + A); ;
                TT[A] = int.Parse(Console.ReadLine());
            }
            q = CSX(TT);
            Console.WriteLine("  par " + q);
            
            Console.ReadKey();

        }
        public static int CSX(int [] vetor )
        {
            int RR = 0;
           for( int D=0; D<5; D++)
            {
                if (vetor[D]%2==0)
                {
                    RR = RR + vetor[D];
                }
            }
            return RR;
            
        }
       
    }
}