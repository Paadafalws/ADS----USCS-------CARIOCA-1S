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
            {
                int voto = 0;
                double pagoP = 0;
                int pagocomPix= 0;
                int pagocomCartao = 0;
                int pagocomDinheiro = 0;
                double pagoC = 0;
                double pagoD = 0;
                double valores = 0;
                double total;

                for (int i = 0; i < 100; i++)
                {
                    Console.Write("Qual pagamento foi a forma de pagamento ? ");
                    Console.WriteLine("{ Pix = 1 Cartao de credito = 2 Dinheiro = 3 }   : ");
                    voto = int.Parse(Console.ReadLine());

                    Console.Write("Qual foi o valor pago ? ");
                    valores = double.Parse(Console.ReadLine());


                    if (voto == 1)
                    {
                        pagocomPix++;
                        pagoP = pagoP + valores;

                    }
                    if (voto == 2)
                    {
                        pagocomCartao++;
                        pagoC = pagoC + valores;
                    }    
                    if (voto ==3)
                    {
                        pagocomDinheiro++;
                        pagoD = pagoD + valores;
                    }
            
                }
                total = pagoP + pagoD + pagoC;

                Console.WriteLine(" Valor do pix foi de R$ " + pagoP);
                Console.WriteLine(" nº de pessoas que pagou com pix : " + pagocomPix);
                Console.WriteLine(" Valor do cartao foi de R$ " + pagoC);
                Console.WriteLine(" nº de pessoas que pagou com cartao : " + pagocomCartao);
                Console.WriteLine(" Valor do mimo foi de R$ " + pagoD);
                Console.WriteLine(" nº de pessoas que pagou com mimo : " + pagocomDinheiro);
                Console.WriteLine(" Valor total foi de R$ " + total);
            }
            Console.ReadKey();
        }
    }
}
