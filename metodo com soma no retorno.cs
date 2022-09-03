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
            int C;
            int Temp;
            Console.WriteLine(Valor da temperatra);
            C = int.Parse(Console.ReadLine());
            Temp = Back(C);

            Console.WriteLine(Temératura C + Temp);
            Console.ReadKey();

        }
        public static int Back(int C )
        {
            int RR;
            RR = (9  C + 160)  5;
            return RR;
        }

    }
}