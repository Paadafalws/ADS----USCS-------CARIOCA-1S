using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int i;
            vetor[0] = 76;
            vetor[1] = 22;
            vetor[2] = 10;
            vetor[3] = 5;
            vetor[4] = 36;
            vetor[5] = 67;
            vetor[6] = 89;
            vetor[7] = 92;
            vetor[8] = 15;
            vetor[9] = 28;
            i = 0;
            while (i<10)
            {
                Console.WriteLine(vetor[i]);
                i++;
            }
            Console.ReadKey();
        }
    }
}
