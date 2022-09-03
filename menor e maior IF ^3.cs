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

            double x, z, y;

            Console.WriteLine(" Digite um numero ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine(" Digite um numero ");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine(" Digite um numero ");
            z = double.Parse(Console.ReadLine());

            if (x > z && x > y)
            {
                Console.WriteLine(" {0} maior que todos ", x);
            }
            if (z > x && z > y )
            {
                Console.WriteLine(" {0} maior que todos ", z);
            }
            if (y > x && y > z)
            {
                Console.WriteLine(" {0} maior que todos ", y);
            }
            //cara
            if (x < z && x < y)
            {
                Console.WriteLine(" {0} menor que todos ", x);
            }
            if (z < x && z < y)
            {
                Console.WriteLine(" {0} menor que todos ", z);
            }
            if (y < x && y < z)
            {
                Console.WriteLine(" {0} menor que todos ", y);
            }
            Console.ReadKey();
        }
    }
}
