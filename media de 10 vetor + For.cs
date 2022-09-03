using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int []v = new int [10];
            int i;
            int novo;
            Console.WriteLine("digite 10 notas");
            for ( i=0; i<10;i++)
            {
                v[i] = int.Parse(console.ReadLine());
            }
            for (i=0;i<10;i++)
            {
                v[i] = v[i]*-1;
            }
            novo1 = (v[0]+v[1]+v[2]+v[3]+v[4]+v[5]+v[6]+v[7]+v[8]+v[9]/10);
            Console.WriteLine("sua media e de "+novo1);   
            Console.ReadKey();
        }
    }
}
