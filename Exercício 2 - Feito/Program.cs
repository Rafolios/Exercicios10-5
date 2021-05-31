using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TABELA DE PREÇOS");
            Console.WriteLine("Álcool = R$ 4,90");
            Console.WriteLine("Gasolina = R$ 5,30");
            Console.WriteLine("Promoção! Para valores de até 20 litros, obterão 3% de desconto no Álcool e 4% na Gasolina!");
            Console.WriteLine("O gerente ficou maluco!!!! Valores acima de 20 litros te concedem um desconto de 5% de álcool e 6% de gasolina!");

            bool validade;

            do
            {
                Console.WriteLine("Como abastecerá o carro? G para Gasolina e A para Alcool");
                string combustivel = Console.ReadLine().ToLower();

                switch (combustivel)
                {
                    case "a":
                        validade = true;
                        Console.WriteLine("Quantos litros irá abastecer?");
                        int litrosa = int.Parse(Console.ReadLine());
                        double precoa = litrosa*4.90;
                        double descontoa = 0;

                        if (litrosa <= 20)
                        {
                            descontoa = precoa*0.97;
                            Console.WriteLine("Ficou R$ " + Math.Round(descontoa, 2));
                        } else if (litrosa > 20)
                        {
                            descontoa = precoa*0.95;
                            Console.WriteLine("Ficou R$ " + Math.Round(descontoa, 2));
                        } else
                        {
                            Console.WriteLine("Não entendi muito bem, certifique-se de usar NÚMEROS para que eu possa entender");
                        }

                        break;

                    case "g":
                        validade = true;
                        Console.WriteLine("Quantos litros irá abastecer?");
                        int litrosg = int.Parse(Console.ReadLine());
                        double precog = litrosg*5.30;
                        double descontog = 0;

                        if (litrosg <= 20)
                        {
                            descontog = precog*0.96;
                            Console.WriteLine("Ficou R$ " + Math.Round(descontog, 2));
                        } else if (litrosg > 20)
                        {
                            descontog = precog*0.94;
                            Console.WriteLine("Ficou R$ " + Math.Round(descontog, 2));
                        } else
                        {
                            Console.WriteLine("Não entendi muito bem, certifique-se de usar NÚMEROS para que eu possa entender");
                        }
                        break;

                    default:
                        validade = false;
                        Console.WriteLine("Erro, não consegui identificar o combustivel! use (A) para álcool e (G) para gasolina!");
                        break;
                }


            } while (validade == false);
        }
    }
}
