static void Main(string[] args)
        {
            int sexo=0;
            int idade=0;
            double altura=0;
            int soma_idade = 0;
            int soma_idade_homem = 0;
            int quantidade_de_homem = 0;
            int quantidade_de_mulher = 0;
            double soma_altura_mulher = 0;
            double pessoas18a35 = 0;

            for (int i=0; i<5; i++)
            {
                Console.Write("Digite o sexo (0-F  / 1-M): ");
                sexo = int.Parse(Console.ReadLine());

                Console.Write("Digite a idade: ");
                idade = int.Parse(Console.ReadLine());

                Console.Write("Digite a altura: ");
                altura = double.Parse(Console.ReadLine());

                soma_idade = soma_idade + idade;

                if (sexo == 1)
                {
                    quantidade_de_homem++;
                    soma_idade_homem = soma_idade_homem + idade;
                }
                if (sexo == 0)
                {
                    quantidade_de_mulher++;
                    soma_altura_mulher = soma_altura_mulher + altura;
                }
                if (idade >=18 && idade <= 35 )
                {
                    pessoas18a35++;
                }
            }
            Console.WriteLine("a) A média da idade é: " + soma_idade / 5);
            Console.WriteLine("b) A média da altura das mulheres é " + soma_altura_mulher / quantidade_de_mulher);
            Console.WriteLine("c) A média da idade dos homens é: " + soma_idade_homem / quantidade_de_homem);
            double percentual = pessoas18a35 / 5 ;
            Console.WriteLine("d) O percentual de pessoas com idade entre 18 e 35 é: " + percentual * 100);
            Console.ReadKey();
        }