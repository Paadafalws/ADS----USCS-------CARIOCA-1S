            double salario, porcen, novo, novo2;
            Console.WriteLine(" Qual seu salario  ? ");
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine("qual o ganha % ? ");
            porcen = double.Parse(Console.ReadLine());

            novo = salario * (porcen/100);

            novo2 = novo + salario;

            Console.WriteLine(" Novo salario ");
            Console.WriteLine(novo2);
            Console.ReadKey();







