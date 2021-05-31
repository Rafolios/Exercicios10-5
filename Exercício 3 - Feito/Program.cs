using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validade;
            double precototal;
            double desconto;
            double precofinal;

            Console.WriteLine($@"
            Bem vindo(a) a calculadora do seu carrinho de supermercado!!");
            do
            {
                Console.WriteLine($@"
                Qual o nome de produto?");
                string nome = Console.ReadLine();
                Console.WriteLine($@"
                Qual a quantidade de " + nome + "?");
                int quantidade = int.Parse(Console.ReadLine());
                Console.WriteLine($@"
                Qual o preço de " + nome + "?");
                double preco = int.Parse(Console.ReadLine());

                if (quantidade <= 5 && quantidade > 0)
                {
                    validade = true;
                    precototal = quantidade*preco;
                    precofinal = precototal*0.98;
                    desconto = precototal-precofinal;

                    Console.WriteLine($@"
                    O Preço de seu produto é R${precototal}
                    E com um desconto de R${Math.Round(desconto, 3)} , é R${precofinal}

                    TOTAL: R${precofinal}
                    ");

                }
                else if (quantidade > 5 && quantidade <= 9)
                {
                    validade = true;
                    precototal = quantidade*preco;
                    precofinal = precototal*0.97;
                    desconto = precototal-precofinal;

                    Console.WriteLine($@"
                    O Preço de seu produto é R${precototal}
                    E com um desconto de R${Math.Round(desconto, 3)}, é R${precofinal}

                    TOTAL: R${precofinal}
                    ");

                }
                else if (quantidade >= 10 && quantidade < 99)
                {
                    validade = true;
                    precototal = quantidade*preco;
                    precofinal = precototal*0.95;
                    desconto = precototal-precofinal;

                    Console.WriteLine($@"
                    O Preço de seu produto é R${precototal}
                    E com um desconto de R${Math.Round(desconto, 3)}, é R${precofinal}

                    TOTAL: R${precofinal}
                    ");

                }
                else
                {
                    validade = false;
                  Console.WriteLine("Não consegui entender, lembre-se de utilizar números de 1 a 99 para a quantidade :)");
                }
            } while (validade == false);

        }
    }
}
