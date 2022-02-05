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
            double consumo, vreal;
            string bandeira, classif;


            Console.WriteLine("Informe o Consumo em kWh:");
            consumo = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a classificação do Imóvel:");
            Console.WriteLine("B1 ou B2 ou B3");
            classif = (Console.ReadLine());
            Console.WriteLine("Informe a bandeira:");
            Console.WriteLine("branca ou amarela ou vermelha");
            bandeira = (Console.ReadLine());


            if (classif == "B1")
            {
                if (bandeira == "branca")
                {
                    Console.WriteLine("Valor é: R$" + consumo * 0.42);
                }
                if (bandeira == "amarela")
                {
                    Console.WriteLine("Valor é: R$" + consumo * 0.63);
                }
                if (bandeira == "vermelha")
                {
                    Console.WriteLine("Valor é: R$" + consumo * 0.98);
                }
            }
            if (classif == "B2")
            {
                if (bandeira == "branca")
                {
                    Console.WriteLine("Valor é: R$" + consumo * 0.36);
                }
                if (bandeira == "amarela")
                {
                    Console.WriteLine("Valor é: R$" + consumo * 0.54);
                }
                if (bandeira == "vermelha")
                {
                    Console.WriteLine("Valor é: R$" + consumo * 0.85);
                }
            }
            if (classif == "B3")
            {
                if (bandeira == "branca")
                {
                    Console.WriteLine("Valor é: R$" + consumo * 0.45);
                }
                if (bandeira == "amarela")
                {
                    Console.WriteLine("Valor é: R$" + consumo * 0.70);
                }
                if (bandeira == "vermelha")
                {
                    Console.WriteLine("Valor é: R$" + consumo * 1.11);
                }
            }
            Console.ReadKey();
        }
    }
}
