{
            int num;
            double consumo, valor;




            Console.WriteLine("1 - B1 - Residencial Baixa Renda Consumo Mensal até 30 kWh");
            Console.WriteLine("2 - B1 - Residencial Baixa Renda Consumo Mensal de 31 kWh até 100 kWh");
            Console.WriteLine("3 - B1 - Residencial Baixa Renda Consumo Mensal de 101 kWh até 220 kWh");
            Console.WriteLine("4 - B1 - Residencial Baixa Renda Consumo Mensal acima de 221 kWh");
            Console.WriteLine("5 - B2 - Rural");
            Console.WriteLine("6 - B3 - Demais Classes (Comercial, Industrial e Outros)");
            Console.WriteLine("7 - B4 - Iluminação Pública - Rede de Distribuição");


            Console.Write("Digite a opção desejada: ");
            num = int.Parse(Console.ReadLine());


            Console.Write("Digite o seu consumo de eletricidade em kWh: ");
            consumo = double.Parse(Console.ReadLine());


            switch (num)
            {
                case 1:
                    valor = 0.16;
                    valor = valor * consumo;
                    Console.WriteLine("O valor a pagar é: R$" + valor);
                    break;


                case 2:
                    valor = 0.28;
                    valor = valor * consumo;
                    Console.WriteLine("O valor a pagar é: R$" + valor);
                    break;


                case 3:
                    valor = 0.41;
                    valor = valor * consumo;
                    Console.WriteLine("O valor a pagar é: R$" + valor);
                    break;


                case 4:
                    valor = 0.46;
                    valor = valor * consumo;
                    Console.WriteLine("O valor a pagar é: R$" + valor);
                    break;


                case 5:
                    valor = 0.43;
                    valor = valor * consumo;
                    Console.WriteLine("O valor a pagar é: R$" + valor);
                    break;


                case 6:
                    valor = 0.53;
                    valor = valor * consumo;
                    Console.WriteLine("O valor a pagar é: R$" + valor);
                    break;


                case 7:
                    valor = 0.29;
                    valor = valor * consumo;
                    Console.WriteLine("O valor a pagar é: R$" + valor);
                    break;
            }
            Console.ReadKey();
        }