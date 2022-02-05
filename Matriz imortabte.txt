using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weawe23sdas
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] N = new int[4, 4];

            {
                int[,] x = new int[4, 4];

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                        x[i, j] = int.Parse(Console.ReadLine());
                }


                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                        Console.Write(x[i, j] + " ");
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        }
    }
}
