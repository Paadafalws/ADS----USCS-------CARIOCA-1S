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
            int [] Soma = new int[10];
            int i, x;
            int sm, sm0 ,sm1, sm2, sm3, sm4, sm5, sm6, sm7, sm8, sm9;
           
            x = 2;
            Console.WriteLine("digite 10 algarimos reais ");
            for (i = 0; i < 10; i++)
            {
                Soma[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < 4;)
            {
                sm0 = (int)Math.Pow(Soma[0], x);
                sm1 = (int)Math.Pow(Soma[1], x);
                sm2 = (int)Math.Pow(Soma[2], x);
                sm3 = (int)Math.Pow(Soma[3], x);
                sm4 = (int)Math.Pow(Soma[4], x);
                sm5 = (int)Math.Pow(Soma[5], x);
                sm6 = (int)Math.Pow(Soma[6], x);
                sm7 = (int)Math.Pow(Soma[7], x);
                sm8 = (int)Math.Pow(Soma[8], x);
                sm9 = (int)Math.Pow(Soma[9], x);
                Console.WriteLine(" ");
                Console.WriteLine("o quadrado dos vetores "+  sm0);
                Console.WriteLine(" ");
                Console.WriteLine("o quadrado dos vetores " + sm1);
                Console.WriteLine(" ");
                Console.WriteLine("o quadrado dos vetores " + sm2);
                Console.WriteLine(" ");
                Console.WriteLine("o quadrado dos vetores " + sm3);
                Console.WriteLine(" ");
                Console.WriteLine("o quadrado dos vetores " + sm4);
                Console.WriteLine(" ");
                Console.WriteLine("o quadrado dos vetores " + sm5);
                Console.WriteLine(" ");
                Console.WriteLine("o quadrado dos vetores " + sm6);
                Console.WriteLine(" ");
                Console.WriteLine("o quadrado dos vetores " + sm7);
                Console.WriteLine(" ");
                Console.WriteLine("o quadrado dos vetores " + sm8);
                Console.WriteLine(" ");
                Console.WriteLine("o quadrado dos vetores " + sm9);
            }
            int[] S = new int[4];
            S[0] = Soma[0];
            Console.WriteLine(S[0]);



            Console.ReadKey();
        }


    }
}

