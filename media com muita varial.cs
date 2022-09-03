using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double clientes,dinheiro,cartao,cheque, dinheiroV, cartaoV, chequeV;
            double mediaD, mediaC, mediaCh, total;

            Console.WriteLine(" quantos clientes teve ? ");
            clientes = double.Parse(Console.ReadLine()); 
            ///////////////////////////////////////////////
            Console.WriteLine(" quantos pagou com  cartoes?");
            cartao = double.Parse(Console.ReadLine());
            Console.WriteLine(" qual foi o valor total ?");
            cartaoV = double.Parse(Console.ReadLine());
            ////////////////////////////////////////////////
            Console.WriteLine(" quantos pagou com  chegue ?");
            cheque = double.Parse(Console.ReadLine());
            Console.WriteLine(" qual foi o valor total ?");
            chequeV = double.Parse(Console.ReadLine());
            ///////////////////////////////////////////////
            Console.WriteLine(" quantos pagou com  dinheiro ?");
            dinheiro = double.Parse(Console.ReadLine());
            Console.WriteLine(" qual foi o valor total ?");
            dinheiroV= double.Parse(Console.ReadLine());
            /////////////////////////////////////////// media
            mediaC = cartaoV / cartao;
            mediaCh = cartaoV / cheque;
            mediaD = dinheiroV / dinheiro;
            total = clientes - cartao - dinheiro - cheque;
            //////////////////////////////////////////////
            Console.WriteLine(" Sua media de cartao foi de {0} ", mediaC);
            Console.WriteLine(" Sua media de dinheiro foi de {0} ", mediaD);
            Console.WriteLine(" Sua media de cheq foi de {0} ", mediaCh);

            Console.ReadKey();
        }
    }
}
